# camt.025.001.09-physical
```mermaid
classDiagram
    class ISO20022.Camt025001.Document {
        # Uri  : String
        + Rct () : ISO20022.Camt025001.ReceiptV09
        + Validation () = validation(validElement(Rct))
    }
    class ISO20022.Camt025001.ReceiptV09 {
        # owner  : ISO20022.Camt025001.Document
        + SplmtryData  : List~ISO20022.Camt025001.SupplementaryData1~
        + RctDtls  : List~ISO20022.Camt025001.Receipt7~
        + MsgHdr  : ISO20022.Camt025001.MessageHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RctDtls""",RctDtls),validList("""RctDtls""",RctDtls),validElement(RctDtls),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt025001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|Rct|ISO20022.Camt025001.ReceiptV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rct))|

---

## AspectImpl ISO20022.Camt025001.ReceiptV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt025001.Document||||
|+|SplmtryData|List<ISO20022.Camt025001.SupplementaryData1>||XmlElement()||
|+|RctDtls|List<ISO20022.Camt025001.Receipt7>||XmlElement()||
|+|MsgHdr|ISO20022.Camt025001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RctDtls""",RctDtls),validList("""RctDtls""",RctDtls),validElement(RctDtls),validElement(MsgHdr))|

