# colr.013.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr013001.Document {
        # Uri  : String
        + IntrstPmtReq () : ISO20022.Colr013001.InterestPaymentRequestV05
        + Validation () = validation(validElement(IntrstPmtReq))
    }
    class ISO20022.Colr013001.InterestPaymentRequestV05 {
        # owner  : ISO20022.Colr013001.Document
        + SplmtryData  : List~ISO20022.Colr013001.SupplementaryData1~
        + NetAmtDtls  : ISO20022.Colr013001.InterestResult1
        + IntrstDueToB  : ISO20022.Colr013001.InterestAmount4
        + IntrstDueToA  : ISO20022.Colr013001.InterestAmount4
        + Agrmt  : ISO20022.Colr013001.Agreement4
        + Oblgtn  : ISO20022.Colr013001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NetAmtDtls),validElement(IntrstDueToB),validElement(IntrstDueToA),validElement(Agrmt),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|IntrstPmtReq|ISO20022.Colr013001.InterestPaymentRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstPmtReq))|

---

## AspectImpl ISO20022.Colr013001.InterestPaymentRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr013001.Document||||
|+|SplmtryData|List<ISO20022.Colr013001.SupplementaryData1>||XmlElement()||
|+|NetAmtDtls|ISO20022.Colr013001.InterestResult1||XmlElement()||
|+|IntrstDueToB|ISO20022.Colr013001.InterestAmount4||XmlElement()||
|+|IntrstDueToA|ISO20022.Colr013001.InterestAmount4||XmlElement()||
|+|Agrmt|ISO20022.Colr013001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr013001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NetAmtDtls),validElement(IntrstDueToB),validElement(IntrstDueToA),validElement(Agrmt),validElement(Oblgtn))|

