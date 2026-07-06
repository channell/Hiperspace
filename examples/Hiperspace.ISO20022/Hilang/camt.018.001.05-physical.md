# camt.018.001.05-physical
```mermaid
classDiagram
    class ISO20022.Camt018001.Document {
        # Uri  : String
        + GetBizDayInf () : ISO20022.Camt018001.GetBusinessDayInformationV05
        + Validation () = validation(validElement(GetBizDayInf))
    }
    class ISO20022.Camt018001.GetBusinessDayInformationV05 {
        # owner  : ISO20022.Camt018001.Document
        + SplmtryData  : List~ISO20022.Camt018001.SupplementaryData1~
        + BizDayInfQryDef  : ISO20022.Camt018001.BusinessDayQuery2
        + MsgHdr  : ISO20022.Camt018001.MessageHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(BizDayInfQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetBizDayInf|ISO20022.Camt018001.GetBusinessDayInformationV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetBizDayInf))|

---

## AspectImpl ISO20022.Camt018001.GetBusinessDayInformationV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt018001.Document||||
|+|SplmtryData|List<ISO20022.Camt018001.SupplementaryData1>||XmlElement()||
|+|BizDayInfQryDef|ISO20022.Camt018001.BusinessDayQuery2||XmlElement()||
|+|MsgHdr|ISO20022.Camt018001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(BizDayInfQryDef),validElement(MsgHdr))|

