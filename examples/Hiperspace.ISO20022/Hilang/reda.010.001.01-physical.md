# reda.010.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda010001.Document {
        # Uri  : String
        + SctyQry () : ISO20022.Reda010001.SecurityQueryV01
        + Validation () = validation(validElement(SctyQry))
    }
    class ISO20022.Reda010001.SecurityQueryV01 {
        # owner  : ISO20022.Reda010001.Document
        + SplmtryData  : List~ISO20022.Reda010001.SupplementaryData1~
        + SmlSetRtrCrit  : ISO20022.Reda010001.SecuritiesReturnCriteria1
        + SchCrit  : ISO20022.Reda010001.SecuritiesSearchCriteria4
        + ReqTp  : ISO20022.Reda010001.GenericIdentification1
        + MsgHdr  : ISO20022.Reda010001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SmlSetRtrCrit),validElement(SchCrit),validElement(ReqTp),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyQry|ISO20022.Reda010001.SecurityQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyQry))|

---

## AspectImpl ISO20022.Reda010001.SecurityQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda010001.Document||||
|+|SplmtryData|List<ISO20022.Reda010001.SupplementaryData1>||XmlElement()||
|+|SmlSetRtrCrit|ISO20022.Reda010001.SecuritiesReturnCriteria1||XmlElement()||
|+|SchCrit|ISO20022.Reda010001.SecuritiesSearchCriteria4||XmlElement()||
|+|ReqTp|ISO20022.Reda010001.GenericIdentification1||XmlElement()||
|+|MsgHdr|ISO20022.Reda010001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SmlSetRtrCrit),validElement(SchCrit),validElement(ReqTp),validElement(MsgHdr))|

