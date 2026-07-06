# auth.002.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth002001.Document {
        # Uri  : String
        + InfReqRspn () : ISO20022.Auth002001.InformationRequestResponseV02
        + Validation () = validation(validElement(InfReqRspn))
    }
    class ISO20022.Auth002001.InformationRequestResponseV02 {
        # owner  : ISO20022.Auth002001.Document
        + SplmtryData  : List~ISO20022.Auth002001.SupplementaryData1~
        + RtrInd  : List~ISO20022.Auth002001.ReturnIndicator2~
        + SchCrit  : ISO20022.Auth002001.SearchCriteria2Choice
        + RspnSts  : String
        + InvstgtnId  : String
        + RspnId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RtrInd""",RtrInd),validList("""RtrInd""",RtrInd),validElement(RtrInd),validElement(SchCrit))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InfReqRspn|ISO20022.Auth002001.InformationRequestResponseV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfReqRspn))|

---

## AspectImpl ISO20022.Auth002001.InformationRequestResponseV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth002001.Document||||
|+|SplmtryData|List<ISO20022.Auth002001.SupplementaryData1>||XmlElement()||
|+|RtrInd|List<ISO20022.Auth002001.ReturnIndicator2>||XmlElement()||
|+|SchCrit|ISO20022.Auth002001.SearchCriteria2Choice||XmlElement()||
|+|RspnSts|String||XmlElement()||
|+|InvstgtnId|String||XmlElement()||
|+|RspnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RtrInd""",RtrInd),validList("""RtrInd""",RtrInd),validElement(RtrInd),validElement(SchCrit))|

