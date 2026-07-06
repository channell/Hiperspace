# tsmt.041.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt041001.Document {
        # Uri  : String
        + TxRpt () : ISO20022.Tsmt041001.TransactionReportV03
        + Validation () = validation(validElement(TxRpt))
    }
    class ISO20022.Tsmt041001.TransactionReportV03 {
        # owner  : ISO20022.Tsmt041001.Document
        + RptdItms  : List~ISO20022.Tsmt041001.TransactionReportItems3~
        + RltdMsgRef  : ISO20022.Tsmt041001.MessageIdentification1
        + RptId  : ISO20022.Tsmt041001.MessageIdentification1
        + Validation () = validation(validList("""RptdItms""",RptdItms),validElement(RptdItms),validElement(RltdMsgRef),validElement(RptId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt041001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TxRpt|ISO20022.Tsmt041001.TransactionReportV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxRpt))|

---

## AspectImpl ISO20022.Tsmt041001.TransactionReportV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt041001.Document||||
|+|RptdItms|List<ISO20022.Tsmt041001.TransactionReportItems3>||XmlElement()||
|+|RltdMsgRef|ISO20022.Tsmt041001.MessageIdentification1||XmlElement()||
|+|RptId|ISO20022.Tsmt041001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RptdItms""",RptdItms),validElement(RptdItms),validElement(RltdMsgRef),validElement(RptId))|

