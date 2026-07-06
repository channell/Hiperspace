# camt.106.001.03-physical
```mermaid
classDiagram
    class ISO20022.Camt106001.Document {
        # Uri  : String
        + ChrgsPmtReq () : ISO20022.Camt106001.ChargesPaymentRequestV03
        + Validation () = validation(validElement(ChrgsPmtReq))
    }
    class ISO20022.Camt106001.ChargesPaymentRequestV03 {
        # owner  : ISO20022.Camt106001.Document
        + SplmtryData  : List~ISO20022.Camt106001.SupplementaryData1~
        + Chrgs  : ISO20022.Camt106001.Charges6Choice
        + GrpHdr  : ISO20022.Camt106001.GroupHeader130
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Chrgs),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt106001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ChrgsPmtReq|ISO20022.Camt106001.ChargesPaymentRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgsPmtReq))|

---

## AspectImpl ISO20022.Camt106001.ChargesPaymentRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt106001.Document||||
|+|SplmtryData|List<ISO20022.Camt106001.SupplementaryData1>||XmlElement()||
|+|Chrgs|ISO20022.Camt106001.Charges6Choice||XmlElement()||
|+|GrpHdr|ISO20022.Camt106001.GroupHeader130||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Chrgs),validElement(GrpHdr))|

