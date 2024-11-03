namespace SQLLinq

open FSharp.Compiler.Interactive.Shell
open FSharp.Compiler.Tokenization

open System
open System.IO
open System.Text
open FSharp.Text.Lexing
open SQLLinq.Ast
open Validation
open Resolution
open Hiperspace

type Engine (space : SubSpace, session : FsiEvaluationSession) =
(*
    // Initialize output and input streams
    let sbOut = new StringBuilder()
    let sbErr = new StringBuilder()
    let inStream = new StringReader("")
    let outStream = new StringWriter(sbOut)
    let errStream = new StringWriter(sbErr)

    // Build command line arguments & start FSI session
    let argv = [| "C:\\fsi.exe" |]

    let allArgs =
        Array.append argv [| "--noninteractive" |]

    let fsiConfig =
        FsiEvaluationSession.GetDefaultConfiguration()

    let fsiSession =
        FsiEvaluationSession.Create(fsiConfig, allArgs, inStream, outStream, errStream)

*)
    let parse source = 
        let lexbuf = LexBuffer<_>.FromString source
        try
            Some (Parser.start Lexer.read lexbuf), None
        with e -> 
            let src = Array.fold(fun a y -> a + y.ToString() ) "" (lexbuf.Lexeme)
            let pos =   
                { 
                    sl = lexbuf.StartPos.pos_lnum
                    sc = (lexbuf.StartPos.pos_cnum - lexbuf.StartPos.pos_bol + 1)
                    el = lexbuf.EndPos.pos_lnum
                    ec = (lexbuf.EndPos.pos_cnum - lexbuf.StartPos.pos_bol + 1)
                }
            None , Some (pos, src, e.Message)

    let schema = Resolution.references space

    let prepare (source : string) =
        let result = 
            match (parse source) with
            | Some result, _            -> validate (resolve schema result)
            | _, Some (pos, src, msg)   -> None, [$"{msg} with \"{src}\"", pos]
            | _                         -> None, ["Unknown error", { sl = 0; sc = 0; el = 0; ec = 0 }]

        let result =
            match result with
            | Some result, []           -> result
            | Some _, errors            -> raise (new Exception (errors |> Seq.fold (fun a (m,p) -> a + $"{m} at {p}\n") ""))
            | _, errors                 -> raise (new Exception (errors |> Seq.fold (fun a (m,p) -> a + $"{m} at {p}\n") ""))
    
        Translation.translate space result.Statements


    member _.Code (sql : string) =
        let code = prepare sql
        code



(*    let result = session.EvalExpression .Eval(sql)
    match result with
    | FsiEvaluationResult.Success _ -> sbOut.ToString()
    | FsiEvaluationResult.Failure _ -> sbErr.ToString())*)