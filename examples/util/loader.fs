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
    log "ElementOperations"
    query { for r in ctx.ElementOperations.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperations.Bind(r, false) |> ignore)    
    log "ElementOperationTags"
    query { for r in ctx.ElementOperationTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationTags.Bind(r, false) |> ignore)    
    log "ElementOperationPreConditions"
    query { for r in ctx.ElementOperationPreConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationPreConditions.Bind(r, false) |> ignore)    
    log "ElementOperationPostConditions"
    query { for r in ctx.ElementOperationPostConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationPostConditions.Bind(r, false) |> ignore)    
    log "ElementOperationParams"
    query { for r in ctx.ElementOperationParams.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationParameters.Bind(r, false) |> ignore)    
//    query { for r in ctx.ElementTrxs do select r } |> Seq.iter (fun r -> space.ElementTrxs.Bind(r, false) |> ignore)    
    log "ElementTests"
    query { for r in ctx.ElementTests.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementTests.Bind(r, false) |> ignore)    
    log "ElementScenarios"
    query { for r in ctx.ElementScenarios.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementScenarios.Bind(r, false) |> ignore)    
    log "ElementRisks"
    query { for r in ctx.ElementRisks.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementRisks.Bind(r, false) |> ignore)    
    log "ElementResource"
    query { for r in ctx.ElementResource.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementResources.Bind(r, false) |> ignore)    
    log "ElementRequires"
    query { for r in ctx.ElementRequires.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementRequirements.Bind(r, false) |> ignore)    
    log "ElementProperties"
    query { for r in ctx.ElementProperties.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementProperties.Bind(r, false) |> ignore)    
    log "ElementProblems"
    query { for r in ctx.ElementProblems.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementProblems.Bind(r, false) |> ignore)    
    log "ElementMetrics"    
    query { for r in ctx.ElementMetrics.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementMetrics.Bind(r, false) |> ignore)    
    log "ElementFiles"
    query { for r in ctx.ElementFiles.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementFiles.Bind(r, false) |> ignore)
    log "RoleConstraints"
    query { for r in ctx.RoleConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorRoleConstraints.Bind(r, false) |> ignore)    
    log "ConnectorTags"
    query { for r in ctx.ConnectorTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorTags.Bind(r, false) |> ignore)  
    log "ConnectorConstraints"
    query { for r in ctx.ConnectorConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorConstraints.Bind(r, false) |> ignore)    

