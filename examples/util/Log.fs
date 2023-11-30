// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module Log
open System

let log s =
    printfn "%s %s" (DateTime.Now.TimeOfDay.ToString()) s

