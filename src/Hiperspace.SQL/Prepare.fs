namespace Hiperspace.SQL

open System.IO
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp
open System.Runtime.Loader
open System
open System.Linq
open System.Collections.Generic
open System.Reflection
open System.Text.Json

/// Interface that all plansd conform to
type IPlan =
    interface
        abstract member Validate    : IDictionary<string,obj> -> string
        abstract member Queryable   : IDictionary<string,obj> -> IQueryable
        abstract member Execute     : IDictionary<string,obj> -> IDictionary<string,obj array>
        abstract member Parquet     : IDictionary<string,obj> * string -> string 
    end

/// Reference to a plan that can be released from memory
type PlanReference =
    {
        Source              : string
        Plan                : Type
        Context             : AssemblyLoadContext
        mutable LastUsed    : DateTime
    }
    member this.Use () = 
        this.LastUsed <- DateTime.Now
        this

    interface IDisposable with
        member this.Dispose() = this.Context.Unload()

type Compiler () =

    let dir =
        let t = [].AsQueryable()
        let t = System.Text.RegularExpressions.Regex.Match("Hiperspace", ".*space")
        let t = JsonSerializer.Serialize("Hiperspace")
        let loc = System.Reflection.Assembly.GetExecutingAssembly().Location;
        loc.Substring(0, loc.LastIndexOf(Path.DirectorySeparatorChar));

    let references =
        let location = 
            Directory.GetFiles(dir)
            |> Array.toList
            |> List.filter (fun i -> i.EndsWith(".dll"))
            |> List.map (fun i -> MetadataReference.CreateFromFile(i) :> MetadataReference)

        let loaded =
            AssemblyLoadContext.All
            |> Seq.toList
            |> List.fold (fun a i -> Seq.toList i.Assemblies @ a) []
            |> List.map (fun i -> i.Location)
            |> List.distinct
            |> List.filter (fun i -> File.Exists(i))
            |> List.map (fun i -> MetadataReference.CreateFromFile(i) :> MetadataReference)

        //let sys =
        //    MetadataReference.CreateFromFile(typeof<IServiceProvider>.Assembly.Location) :> MetadataReference

        //sys :: location @ loaded
        location @ loaded
        |> List.distinct
        |> List.toArray

    let baseCompiler = 
        CSharpCompilation.Create(
            "Hiperspace.SQL.Dynamic",
            syntaxTrees = [| |],
            references = references,
            options = CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))

    member this.Prepare name (code : string) source = 

        let parseOptions = CSharpParseOptions(LanguageVersion.Latest)  
        let syntaxTree = CSharpSyntaxTree.ParseText(code, parseOptions)
        let compiler = baseCompiler.Clone()
        let compilation = compiler.AddSyntaxTrees(syntaxTree)
        use ms = new MemoryStream()
        // write IL code into memory
        let result = compilation.Emit(ms)
        if not result.Success then
            // handle exceptions
            let failures = 
                result.Diagnostics
                |> Seq.filter (fun diagnostic -> 
                    diagnostic.IsWarningAsError || diagnostic.Severity = DiagnosticSeverity.Error)
                |> Seq.fold (fun a i -> a + $"{i}\n") ""

            raise (System.Exception(failures))
        else
            // load this 'virtual' DLL so that we can use
            ms.Seek(0L, SeekOrigin.Begin) |> ignore
            let uid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            let ctx = new AssemblyLoadContext(uid, true)
            let assemby = ctx.LoadFromStream(ms)
            let result = assemby.GetType(name)
            { Source = source; Plan = result; Context = ctx; LastUsed = DateTime.Now }