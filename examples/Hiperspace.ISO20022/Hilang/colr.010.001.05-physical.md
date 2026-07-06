# colr.010.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr010001.Document {
        # Uri  : String
        + CollSbstitnReq () : ISO20022.Colr010001.CollateralSubstitutionRequestV05
        + Validation () = validation(validElement(CollSbstitnReq))
    }
    class ISO20022.Colr010001.CollateralSubstitutionRequestV05 {
        # owner  : ISO20022.Colr010001.Document
        + SplmtryData  : List~ISO20022.Colr010001.SupplementaryData1~
        + CollSbstitnDlvr  : ISO20022.Colr010001.CollateralSubstitution8
        + CollSbstitnRtr  : ISO20022.Colr010001.CollateralSubstitution7
        + Agrmt  : ISO20022.Colr010001.Agreement4
        + Oblgtn  : ISO20022.Colr010001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollSbstitnDlvr),validElement(CollSbstitnRtr),validElement(Agrmt),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollSbstitnReq|ISO20022.Colr010001.CollateralSubstitutionRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollSbstitnReq))|

---

## AspectImpl ISO20022.Colr010001.CollateralSubstitutionRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr010001.Document||||
|+|SplmtryData|List<ISO20022.Colr010001.SupplementaryData1>||XmlElement()||
|+|CollSbstitnDlvr|ISO20022.Colr010001.CollateralSubstitution8||XmlElement()||
|+|CollSbstitnRtr|ISO20022.Colr010001.CollateralSubstitution7||XmlElement()||
|+|Agrmt|ISO20022.Colr010001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr010001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollSbstitnDlvr),validElement(CollSbstitnRtr),validElement(Agrmt),validElement(Oblgtn))|

