# colr.008.001.06-physical
```mermaid
classDiagram
    class ISO20022.Colr008001.Document {
        # Uri  : String
        + CollPrpslRspn () : ISO20022.Colr008001.CollateralProposalResponseV06
        + Validation () = validation(validElement(CollPrpslRspn))
    }
    class ISO20022.Colr008001.CollateralProposalResponseV06 {
        # owner  : ISO20022.Colr008001.Document
        + SplmtryData  : List~ISO20022.Colr008001.SupplementaryData1~
        + PrpslRspn  : ISO20022.Colr008001.CollateralProposalResponse4Choice
        + Oblgtn  : ISO20022.Colr008001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrpslRspn),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollPrpslRspn|ISO20022.Colr008001.CollateralProposalResponseV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollPrpslRspn))|

---

## AspectImpl ISO20022.Colr008001.CollateralProposalResponseV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr008001.Document||||
|+|SplmtryData|List<ISO20022.Colr008001.SupplementaryData1>||XmlElement()||
|+|PrpslRspn|ISO20022.Colr008001.CollateralProposalResponse4Choice||XmlElement()||
|+|Oblgtn|ISO20022.Colr008001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrpslRspn),validElement(Oblgtn))|

