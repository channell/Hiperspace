// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module updates

open Sparx
open Sparx.EA
open Log
open System
open Microsoft.EntityFrameworkCore

let update (space : SparxSpace) =
    log "update rocks"
    query { for element in space.EAElements do
             where (element.Name = "Visitor")
             select element}
    |> Seq.iter (fun element -> let e = Element (element) 
                                e.Status <- "Approved"
                                space.EAElements.BindAsync (e, false) |> ignore)
    log "updated rocks"

let updateSQL (ctx : Context) =
    log "update SQL"
    query { for element in ctx.Elements do
             where (element.Name = "Visitor")
             select element}
    |> Seq.iter (fun element -> element.Status <- "Approved"
                                element.ModifiedDate <- DateTime.Now)
    let cnt = ctx.SaveChanges() 
    log "updated SQL"
