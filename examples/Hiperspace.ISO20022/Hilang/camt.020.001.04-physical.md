# camt.020.001.04-physical
```mermaid
classDiagram
    class ISO20022.Camt020001.Document {
        # Uri  : String
        + GetGnlBizInf () : ISO20022.Camt020001.GetGeneralBusinessInformationV04
        + Validation () = validation(validElement(GetGnlBizInf))
    }
    class ISO20022.Camt020001.GetGeneralBusinessInformationV04 {
        # owner  : ISO20022.Camt020001.Document
        + SplmtryData  : List~ISO20022.Camt020001.SupplementaryData1~
        + GnlBizInfQryDef  : ISO20022.Camt020001.BusinessInformationQueryDefinition3
        + MsgHdr  : ISO20022.Camt020001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(GnlBizInfQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt020001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetGnlBizInf|ISO20022.Camt020001.GetGeneralBusinessInformationV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetGnlBizInf))|

---

## AspectImpl ISO20022.Camt020001.GetGeneralBusinessInformationV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt020001.Document||||
|+|SplmtryData|List<ISO20022.Camt020001.SupplementaryData1>||XmlElement()||
|+|GnlBizInfQryDef|ISO20022.Camt020001.BusinessInformationQueryDefinition3||XmlElement()||
|+|MsgHdr|ISO20022.Camt020001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(GnlBizInfQryDef),validElement(MsgHdr))|

