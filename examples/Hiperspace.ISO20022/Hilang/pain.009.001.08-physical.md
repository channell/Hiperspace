# pain.009.001.08-physical
```mermaid
classDiagram
    class ISO20022.Pain009001.Document {
        # Uri  : String
        + MndtInitnReq () : ISO20022.Pain009001.MandateInitiationRequestV08
        + Validation () = validation(validElement(MndtInitnReq))
    }
    class ISO20022.Pain009001.MandateInitiationRequestV08 {
        # owner  : ISO20022.Pain009001.Document
        + SplmtryData  : List~ISO20022.Pain009001.SupplementaryData1~
        + Mndt  : List~ISO20022.Pain009001.Mandate23~
        + GrpHdr  : ISO20022.Pain009001.GroupHeader110
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mndt""",Mndt),validList("""Mndt""",Mndt),validElement(Mndt),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MndtInitnReq|ISO20022.Pain009001.MandateInitiationRequestV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtInitnReq))|

---

## AspectImpl ISO20022.Pain009001.MandateInitiationRequestV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain009001.Document||||
|+|SplmtryData|List<ISO20022.Pain009001.SupplementaryData1>||XmlElement()||
|+|Mndt|List<ISO20022.Pain009001.Mandate23>||XmlElement()||
|+|GrpHdr|ISO20022.Pain009001.GroupHeader110||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mndt""",Mndt),validList("""Mndt""",Mndt),validElement(Mndt),validElement(GrpHdr))|

