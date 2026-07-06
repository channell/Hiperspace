# colr.014.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr014001.Document {
        # Uri  : String
        + IntrstPmtRspn () : ISO20022.Colr014001.InterestPaymentResponseV05
        + Validation () = validation(validElement(IntrstPmtRspn))
    }
    class ISO20022.Colr014001.InterestPaymentResponseV05 {
        # owner  : ISO20022.Colr014001.Document
        + SplmtryData  : List~ISO20022.Colr014001.SupplementaryData1~
        + IntrstRspn  : ISO20022.Colr014001.InterestResponse1
        + IntrstDueToB  : ISO20022.Colr014001.InterestAmount3
        + IntrstDueToA  : ISO20022.Colr014001.InterestAmount3
        + Agrmt  : ISO20022.Colr014001.Agreement4
        + Oblgtn  : ISO20022.Colr014001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(IntrstRspn),validElement(IntrstDueToB),validElement(IntrstDueToA),validElement(Agrmt),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|IntrstPmtRspn|ISO20022.Colr014001.InterestPaymentResponseV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstPmtRspn))|

---

## AspectImpl ISO20022.Colr014001.InterestPaymentResponseV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr014001.Document||||
|+|SplmtryData|List<ISO20022.Colr014001.SupplementaryData1>||XmlElement()||
|+|IntrstRspn|ISO20022.Colr014001.InterestResponse1||XmlElement()||
|+|IntrstDueToB|ISO20022.Colr014001.InterestAmount3||XmlElement()||
|+|IntrstDueToA|ISO20022.Colr014001.InterestAmount3||XmlElement()||
|+|Agrmt|ISO20022.Colr014001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr014001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(IntrstRspn),validElement(IntrstDueToB),validElement(IntrstDueToA),validElement(Agrmt),validElement(Oblgtn))|

