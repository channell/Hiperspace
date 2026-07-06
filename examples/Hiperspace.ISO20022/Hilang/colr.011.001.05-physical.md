# colr.011.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr011001.Document {
        # Uri  : String
        + CollSbstitnRspn () : ISO20022.Colr011001.CollateralSubstitutionResponseV05
        + Validation () = validation(validElement(CollSbstitnRspn))
    }
    class ISO20022.Colr011001.CollateralSubstitutionResponseV05 {
        # owner  : ISO20022.Colr011001.Document
        + SplmtryData  : List~ISO20022.Colr011001.SupplementaryData1~
        + SbstitnRspn  : ISO20022.Colr011001.SubstitutionResponse2
        + Agrmt  : ISO20022.Colr011001.Agreement4
        + Oblgtn  : ISO20022.Colr011001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SbstitnRspn),validElement(Agrmt),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollSbstitnRspn|ISO20022.Colr011001.CollateralSubstitutionResponseV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollSbstitnRspn))|

---

## AspectImpl ISO20022.Colr011001.CollateralSubstitutionResponseV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr011001.Document||||
|+|SplmtryData|List<ISO20022.Colr011001.SupplementaryData1>||XmlElement()||
|+|SbstitnRspn|ISO20022.Colr011001.SubstitutionResponse2||XmlElement()||
|+|Agrmt|ISO20022.Colr011001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr011001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SbstitnRspn),validElement(Agrmt),validElement(Oblgtn))|

