# camt.006.001.11-physical
```mermaid
classDiagram
    class ISO20022.Camt006001.Document {
        # Uri  : String
        + RtrTx () : ISO20022.Camt006001.ReturnTransactionV11
        + Validation () = validation(validElement(RtrTx))
    }
    class ISO20022.Camt006001.ReturnTransactionV11 {
        # owner  : ISO20022.Camt006001.Document
        + SplmtryData  : List~ISO20022.Camt006001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt006001.TransactionReportOrError7Choice
        + MsgHdr  : ISO20022.Camt006001.MessageHeader8
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrTx|ISO20022.Camt006001.ReturnTransactionV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrTx))|

---

## AspectImpl ISO20022.Camt006001.ReturnTransactionV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt006001.Document||||
|+|SplmtryData|List<ISO20022.Camt006001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt006001.TransactionReportOrError7Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt006001.MessageHeader8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

