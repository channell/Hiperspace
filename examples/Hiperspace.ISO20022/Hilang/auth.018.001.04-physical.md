# auth.018.001.04-physical
```mermaid
classDiagram
    class ISO20022.Auth018001.Document {
        # Uri  : String
        + CtrctRegnReq () : ISO20022.Auth018001.ContractRegistrationRequestV04
        + Validation () = validation(validElement(CtrctRegnReq))
    }
    class ISO20022.Auth018001.ContractRegistrationRequestV04 {
        # owner  : ISO20022.Auth018001.Document
        + SplmtryData  : List~ISO20022.Auth018001.SupplementaryData1~
        + CtrctRegn  : List~ISO20022.Auth018001.ContractRegistration7~
        + GrpHdr  : ISO20022.Auth018001.CurrencyControlHeader8
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CtrctRegn""",CtrctRegn),validList("""CtrctRegn""",CtrctRegn),validElement(CtrctRegn),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CtrctRegnReq|ISO20022.Auth018001.ContractRegistrationRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctRegnReq))|

---

## AspectImpl ISO20022.Auth018001.ContractRegistrationRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth018001.Document||||
|+|SplmtryData|List<ISO20022.Auth018001.SupplementaryData1>||XmlElement()||
|+|CtrctRegn|List<ISO20022.Auth018001.ContractRegistration7>||XmlElement()||
|+|GrpHdr|ISO20022.Auth018001.CurrencyControlHeader8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CtrctRegn""",CtrctRegn),validList("""CtrctRegn""",CtrctRegn),validElement(CtrctRegn),validElement(GrpHdr))|

