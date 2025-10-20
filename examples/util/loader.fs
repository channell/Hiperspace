// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module loader

open System
open Sparx
open Sparx.EA
open Microsoft.EntityFrameworkCore;
open Log
    
let load (space : SparxSpace) (ctx : Context) = 

    let mdl = ctx.Model
    mdl.GetEntityTypes()
    |> Seq.iter (fun r -> printfn "%A" r.Name
                          r.GetProperties()
                          |> Seq.iter (fun p -> printfn "\t%A" p ))

    log "Loading"
    let start = DateTime.Now    
    let loading = Sparx.Load.Tracking (When = start)
    log "Package"
    query { for r in ctx.Packages.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Packages.Bind(r, false).Value.Loaded <- loading.As r.Loaded)   
    log "Elements"
    query { for r in ctx.Elements.AsNoTracking() do select r } |> Seq.iter (fun r -> space.EAElements.Bind(r, false).Value.Loaded <- loading.As r.Loaded)    
    log "Resources"
    query { for r in ctx.Resources.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Resources.Bind(r, false) |> ignore)    
    log "Diagrams"
    query { for r in ctx.Diagrams.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Diagrams.Bind(r, false) |> ignore)    
    log "DiagramObjects"
    query { for r in ctx.DiagramObjects.AsNoTracking() do select r } |> Seq.iter (fun r -> space.DiagramObjects.Bind(r, false) |> ignore)    
    log "DiagramLinks"
    query { for r in ctx.DiagramLinks.AsNoTracking() do select r } |> Seq.iter (fun r -> space.DiagramLinks.Bind(r, false) |> ignore)    
    log "Connectors"
    query { for r in ctx.Connectors.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Connectors.Bind(r, false) |> ignore)    
    log "Attributes"
    query { for r in ctx.Attributes.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Attributes.Bind(r, false) |> ignore)    
    log "Operations"
    query { for r in ctx.Operations.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Operations.Bind(r, false) |> ignore)    
    log "ElementOperationTags"
    query { for r in ctx.OperationTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.OperationTags.Bind(r, false) |> ignore)    
    log "ElementOperationPreConditions"
    query { for r in ctx.OperationPreConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.OperationPreConditions.Bind(r, false) |> ignore)    
    log "ElementOperationPostConditions"
    query { for r in ctx.OperationPostConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.OperationPostConditions.Bind(r, false) |> ignore)    
    log "ElementOperationParams"
    query { for r in ctx.OperationParams.AsNoTracking() do select r } |> Seq.iter (fun r -> space.OperationParams.Bind(r, false) |> ignore)    
//    query { for r in ctx.ElementTrxs do select r } |> Seq.iter (fun r -> space.ElementTrxs.Bind(r, false) |> ignore)    
    log "ElementTests"
    query { for r in ctx.ObjectTests.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectTests.Bind(r, false) |> ignore)    
    log "ObjectScenarios"
    query { for r in ctx.ObjectScenarios.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectScenarios.Bind(r, false) |> ignore)    
    log "ObjectRisks"
    query { for r in ctx.ObjectRisks.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectRisks.Bind(r, false) |> ignore)    
    log "ObjectResource"
    query { for r in ctx.ObjectResource.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectResources.Bind(r, false) |> ignore)    
    log "ObjectRequires"
    query { for r in ctx.ObjectRequires.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectRequires.Bind(r, false) |> ignore)    
    log "ObjectProperties"
    query { for r in ctx.ObjectProperties.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectPropertys.Bind(r, false) |> ignore)    
    log "ObjectProblems"
    query { for r in ctx.ObjectProblems.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectProblems.Bind(r, false) |> ignore)    
    log "ObjectMetrics"    
    query { for r in ctx.ObjectMetrics.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectMetrics.Bind(r, false) |> ignore)    
    log "ObjectFiles"
    query { for r in ctx.ObjectFiles.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ObjectFiles.Bind(r, false) |> ignore)
    log "RoleConstraints"
    query { for r in ctx.RoleConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.RoleConstraints.Bind(r, false) |> ignore)    
    log "ConnectorTags"
    query { for r in ctx.ConnectorTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorTags.Bind(r, false) |> ignore)  
    log "ConnectorConstraints"
    query { for r in ctx.ConnectorConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorConstraints.Bind(r, false) |> ignore)    

