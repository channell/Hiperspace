module Hiperspace.SQL.Dynamic

open System
open System.Reflection
open System.Reflection.Emit

let moduleBuilder = 
    let assemblyName = AssemblyName("DynamicAssembly")
    let assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run)
    assemblyBuilder.DefineDynamicModule("MainModule")

let createType name (members : (string * Type) seq) =
    let typeBuilder = moduleBuilder.DefineType(name, TypeAttributes.Public)

    let members = Array.ofSeq members

    let fields = 
        members
        |> Array.map (fun (name, t) -> typeBuilder.DefineField(name, t, FieldAttributes.Public))

    let constructor =
        typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, members |> Array.map snd)

    let il = constructor.GetILGenerator()
    il.Emit(OpCodes.Ldarg_0)
    il.Emit(OpCodes.Call, (typeof<obj>.GetConstructor(Type.EmptyTypes)))
    il.Emit(OpCodes.Nop)

    members
    |> Array.iteri (fun i (name, t) -> 
        il.Emit(OpCodes.Ldarg_0)
        il.Emit(OpCodes.Ldarga_S, i)
        il.Emit(OpCodes.Stfld, fields.[i])
    )
    il.Emit(OpCodes.Ret)
    typeBuilder.CreateType()
