// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module loader

open Sparx
open Sparx.EA
open Microsoft.EntityFrameworkCore;
open Log
    
let load (space : SparxSpace) (ctx : Context) = 
    log "Loading"
    log "Package"
    query { for r in ctx.Packages.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Packages.BindAsync(r, false) |> ignore)    
    log "Elements"
    query { for r in ctx.Elements.AsNoTracking() do select r } |> Seq.iter (fun r -> space.EAElements.BindAsync(r, false) |> ignore)    
    log "Resources"
    query { for r in ctx.Resources.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Resources.BindAsync(r, false) |> ignore)    
    log "Diagrams"
    query { for r in ctx.Diagrams.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Diagrams.BindAsync(r, false) |> ignore)    
    log "DiagramObjects"
    query { for r in ctx.DiagramObjects.AsNoTracking() do select r } |> Seq.iter (fun r -> space.DiagramObjects.BindAsync(r, false) |> ignore)    
    log "DiagramLinks"
    query { for r in ctx.DiagramLinks.AsNoTracking() do select r } |> Seq.iter (fun r -> space.DiagramLinks.BindAsync(r, false) |> ignore)    
    log "Connectors"
    query { for r in ctx.Connectors.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Connectors.BindAsync(r, false) |> ignore)    
    log "Attributes"
    query { for r in ctx.Attributes.AsNoTracking() do select r } |> Seq.iter (fun r -> space.Attributes.BindAsync(r, false) |> ignore)    
    log "ElementOperations"
    query { for r in ctx.ElementOperations.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationss.BindAsync(r, false) |> ignore)    
    log "ElementOperationTags"
    query { for r in ctx.ElementOperationTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationsTagss.BindAsync(r, false) |> ignore)    
    log "ElementOperationPreConditions"
    query { for r in ctx.ElementOperationPreConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationsPreConditionss.BindAsync(r, false) |> ignore)    
    log "ElementOperationPostConditions"
    query { for r in ctx.ElementOperationPostConditions.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationsPostCondiitonss.BindAsync(r, false) |> ignore)    
    log "ElementOperationParams"
    query { for r in ctx.ElementOperationParams.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementOperationsParameterss.BindAsync(r, false) |> ignore)    
//    query { for r in ctx.ElementTrxs do select r } |> Seq.iter (fun r -> space.ElementTrxs.BindAsync(r, false) |> ignore)    
    log "ElementTests"
    query { for r in ctx.ElementTests.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementTestss.BindAsync(r, false) |> ignore)    
    log "ElementScenarios"
    query { for r in ctx.ElementScenarios.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementScenarioss.BindAsync(r, false) |> ignore)    
    log "ElementRisks"
    query { for r in ctx.ElementRisks.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementRiskss.BindAsync(r, false) |> ignore)    
    log "ElementResource"
    query { for r in ctx.ElementResource.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementResourcess.BindAsync(r, false) |> ignore)    
    log "ElementRequires"
    query { for r in ctx.ElementRequires.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementRequirementss.BindAsync(r, false) |> ignore)    
    log "ElementProperties"
    query { for r in ctx.ElementProperties.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementPropertiess.BindAsync(r, false) |> ignore)    
    log "ElementProblems"
    query { for r in ctx.ElementProblems.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementProblemss.BindAsync(r, false) |> ignore)    
    log "ElementMetrics"
    query { for r in ctx.ElementMetrics.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementMetricss.BindAsync(r, false) |> ignore)    
    log "ElementFiles"
    query { for r in ctx.ElementFiles.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ElementFiless.BindAsync(r, false) |> ignore)
    log "RoleConstraints"
    query { for r in ctx.RoleConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorRoleConstraintss.BindAsync(r, false) |> ignore)    
    log "ConnectorTags"
    query { for r in ctx.ConnectorTags.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorTagss.BindAsync(r, false) |> ignore)    
    log "ConnectorConstraints"
    query { for r in ctx.ConnectorConstraints.AsNoTracking() do select r } |> Seq.iter (fun r -> space.ConnectorConstraintss.BindAsync(r, false) |> ignore)    

