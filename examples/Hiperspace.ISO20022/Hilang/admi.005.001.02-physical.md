# admi.005.001.02-physical
```mermaid
classDiagram
    class ISO20022.Admi005001.Document {
        # Uri  : String
        + RptQryReq () : ISO20022.Admi005001.ReportQueryRequestV02
        + Validation () = validation(validElement(RptQryReq))
    }
    class ISO20022.Admi005001.ReportQueryRequestV02 {
        # owner  : ISO20022.Admi005001.Document
        + SplmtryData  : List~ISO20022.Admi005001.SupplementaryData1~
        + RptQryCrit  : List~ISO20022.Admi005001.ReportQueryCriteria3~
        + MsgHdr  : ISO20022.Admi005001.MessageHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""RptQryCrit""",RptQryCrit),validElement(RptQryCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Admi005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RptQryReq|ISO20022.Admi005001.ReportQueryRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptQryReq))|

---

## AspectImpl ISO20022.Admi005001.ReportQueryRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Admi005001.Document||||
|+|SplmtryData|List<ISO20022.Admi005001.SupplementaryData1>||XmlElement()||
|+|RptQryCrit|List<ISO20022.Admi005001.ReportQueryCriteria3>||XmlElement()||
|+|MsgHdr|ISO20022.Admi005001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""RptQryCrit""",RptQryCrit),validElement(RptQryCrit),validElement(MsgHdr))|

