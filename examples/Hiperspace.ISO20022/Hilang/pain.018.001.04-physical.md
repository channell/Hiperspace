# pain.018.001.04-physical
```mermaid
classDiagram
    class ISO20022.Pain018001.Document {
        # Uri  : String
        + MndtSspnsnReq () : ISO20022.Pain018001.MandateSuspensionRequestV04
        + Validation () = validation(validElement(MndtSspnsnReq))
    }
    class ISO20022.Pain018001.MandateSuspensionRequestV04 {
        # owner  : ISO20022.Pain018001.Document
        + SplmtryData  : List~ISO20022.Pain018001.SupplementaryData1~
        + UndrlygSspnsnDtls  : List~ISO20022.Pain018001.MandateSuspension4~
        + GrpHdr  : ISO20022.Pain018001.GroupHeader110
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygSspnsnDtls""",UndrlygSspnsnDtls),validList("""UndrlygSspnsnDtls""",UndrlygSspnsnDtls),validElement(UndrlygSspnsnDtls),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MndtSspnsnReq|ISO20022.Pain018001.MandateSuspensionRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtSspnsnReq))|

---

## AspectImpl ISO20022.Pain018001.MandateSuspensionRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain018001.Document||||
|+|SplmtryData|List<ISO20022.Pain018001.SupplementaryData1>||XmlElement()||
|+|UndrlygSspnsnDtls|List<ISO20022.Pain018001.MandateSuspension4>||XmlElement()||
|+|GrpHdr|ISO20022.Pain018001.GroupHeader110||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygSspnsnDtls""",UndrlygSspnsnDtls),validList("""UndrlygSspnsnDtls""",UndrlygSspnsnDtls),validElement(UndrlygSspnsnDtls),validElement(GrpHdr))|

