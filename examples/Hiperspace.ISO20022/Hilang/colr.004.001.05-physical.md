# colr.004.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr004001.Document {
        # Uri  : String
        + MrgnCallRspn () : ISO20022.Colr004001.MarginCallResponseV05
        + Validation () = validation(validElement(MrgnCallRspn))
    }
    class ISO20022.Colr004001.MarginCallResponseV05 {
        # owner  : ISO20022.Colr004001.Document
        + SplmtryData  : List~ISO20022.Colr004001.SupplementaryData1~
        + RspnDtls  : ISO20022.Colr004001.Response1
        + AgrdAmtDueToB  : ISO20022.Colr004001.AgreedAmount1Choice
        + AgrdAmtDueToA  : ISO20022.Colr004001.AgreedAmount1Choice
        + MrgnDtlsDueToB  : ISO20022.Colr004001.MarginCall1
        + MrgnDtlsDueToA  : ISO20022.Colr004001.MarginCall1
        + Agrmt  : ISO20022.Colr004001.Agreement4
        + Oblgtn  : ISO20022.Colr004001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RspnDtls),validElement(AgrdAmtDueToB),validElement(AgrdAmtDueToA),validElement(MrgnDtlsDueToB),validElement(MrgnDtlsDueToA),validElement(Agrmt),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MrgnCallRspn|ISO20022.Colr004001.MarginCallResponseV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnCallRspn))|

---

## AspectImpl ISO20022.Colr004001.MarginCallResponseV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr004001.Document||||
|+|SplmtryData|List<ISO20022.Colr004001.SupplementaryData1>||XmlElement()||
|+|RspnDtls|ISO20022.Colr004001.Response1||XmlElement()||
|+|AgrdAmtDueToB|ISO20022.Colr004001.AgreedAmount1Choice||XmlElement()||
|+|AgrdAmtDueToA|ISO20022.Colr004001.AgreedAmount1Choice||XmlElement()||
|+|MrgnDtlsDueToB|ISO20022.Colr004001.MarginCall1||XmlElement()||
|+|MrgnDtlsDueToA|ISO20022.Colr004001.MarginCall1||XmlElement()||
|+|Agrmt|ISO20022.Colr004001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr004001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RspnDtls),validElement(AgrdAmtDueToB),validElement(AgrdAmtDueToA),validElement(MrgnDtlsDueToB),validElement(MrgnDtlsDueToA),validElement(Agrmt),validElement(Oblgtn))|

