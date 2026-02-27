# readme
```mermaid
classDiagram
    class QL.FixedRate {
        # Mnmonic  : String
        + Convention  : String
        + Calendar  : String
        + Effective  : DateTime
        + Maturity  : DateTime
        + FaceAmount  : Double
        + SettlementDays  : Int32
        + DayCount  : String
        + Coupons  : List~Double~
        + Rate  : Double
        + Engine  : String
        + _DayCount () = makeDayCounter(DayCount)
        + _Calendar () = makeCalendar(Calendar)
        + _ZERO () = "ZERO"
        + _rule () = makeRule(_ZERO)
        + _M () = "M"
        + _MP () = makePeriod(_M)
        + _Convention () = makeBusinessDayConvention(Convention)
        + _Schedule () = makeSchedule(Effective,Maturity,_MP,_Calendar,_Convention,_rule)
        + _Yield () = makeCurve(Effective,Rate,_DayCount)
        + _Engine () = makeEngine(Engine,_Yield)
        + Bond () = makeFixedRateBond(SettlementDays,FaceAmount,_Schedule,Coupons,_DayCount)
        + NPV () = NPV(Bond)
        + CASH () = CASH(Bond)
        + FixedRate_Dimension () = 
        + FixedRate_Cube (CubeSlice = "55", FixedRate = this, ContextLabel = contextlabel(this)) : QL.FixedRate_Cube
    }
    class QL.FixedRate_Cube {
        # CubeSlice  : String
        # ContextLabel  : String
        # FixedRate  : QL.FixedRate
        + NPV  : Double
        + CASH  : Double
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(FixedRate)
    }
    class QL.FixedRate_Fact {
        # ContextLabel  : String
        # FixedRate  : QL.FixedRate
        + NPV  : Double
        + CASH  : Double
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(FixedRate)
    }
```

---

## EntityImpl QL.FixedRate
A Fixed rate bond stored in hiperspace

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Mnmonic|String||||
|+|Convention|String||||
|+|Calendar|String||||
|+|Effective|DateTime||||
|+|Maturity|DateTime||||
|+|FaceAmount|Double||||
|+|SettlementDays|Int32||||
|+|DayCount|String||||
|+|Coupons|List<Double>||||
|+|Rate|Double||||
|+|Engine|String||||
||_DayCount|Some(QLNet.DayCounter)|||makeDayCounter(DayCount)|
||_Calendar|Some(QLNet.Calendar)|||makeCalendar(Calendar)|
||_ZERO|Some(String)|||"ZERO"|
||_rule|Some(QLNet.DateGeneration.Rule)|||makeRule(_ZERO)|
||_M|Some(String)|||"M"|
||_MP|Some(QLNet.Period)|||makePeriod(_M)|
||_Convention|Some(QLNet.BusinessDayConvention)|||makeBusinessDayConvention(Convention)|
||_Schedule|Some(QLNet.Schedule)|||makeSchedule(Effective,Maturity,_MP,_Calendar,_Convention,_rule)|
||_Yield|Some(QLNet.Handle<QLNet.YieldTermStructure>)|||makeCurve(Effective,Rate,_DayCount)|
||_Engine|Some(QLNet.IPricingEngine)|||makeEngine(Engine,_Yield)|
||Bond|Some(QLNet.FixedRateBond)||Once()|makeFixedRateBond(SettlementDays,FaceAmount,_Schedule,Coupons,_DayCount)|
||NPV|Some(Double)||CubeMeasure(Aggregate?.Sum)|NPV(Bond)|
||CASH|Some(Double)||CubeMeasure(Aggregate?.Sum)|CASH(Bond)|
||FixedRate_Dimension|Some(QL.FixedRate)||||
||FixedRate_Cube|QL.FixedRate_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "55", FixedRate = this, ContextLabel = contextlabel(this)|

---

## EntityImpl QL.FixedRate_Cube
A Fixed rate bond stored in hiperspace

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|CubeSlice|String||||
|#|ContextLabel|String||||
|#|FixedRate|QL.FixedRate|A Fixed rate bond stored in hiperspace|CubeDimensionReference()||
|+|NPV|Double||CubeMeasure(Aggregate?.Sum)||
|+|CASH|Double||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(FixedRate)|

---

## EntityImpl QL.FixedRate_Fact
A Fixed rate bond stored in hiperspace

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|ContextLabel|String||||
|#|FixedRate|QL.FixedRate|A Fixed rate bond stored in hiperspace|CubeDimensionReference()||
|+|NPV|Double||CubeMeasure(Aggregate?.Sum)||
|+|CASH|Double||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(FixedRate)|

