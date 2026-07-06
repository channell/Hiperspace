# pain.011.001.08-physical
```mermaid
classDiagram
    class ISO20022.Pain011001.Document {
        # Uri  : String
        + MndtCxlReq () : ISO20022.Pain011001.MandateCancellationRequestV08
        + Validation () = validation(validElement(MndtCxlReq))
    }
    class ISO20022.Pain011001.MandateCancellationRequestV08 {
        # owner  : ISO20022.Pain011001.Document
        + SplmtryData  : List~ISO20022.Pain011001.SupplementaryData1~
        + UndrlygCxlDtls  : List~ISO20022.Pain011001.MandateCancellation8~
        + GrpHdr  : ISO20022.Pain011001.GroupHeader110
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygCxlDtls""",UndrlygCxlDtls),validList("""UndrlygCxlDtls""",UndrlygCxlDtls),validElement(UndrlygCxlDtls),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MndtCxlReq|ISO20022.Pain011001.MandateCancellationRequestV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtCxlReq))|

---

## AspectImpl ISO20022.Pain011001.MandateCancellationRequestV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain011001.Document||||
|+|SplmtryData|List<ISO20022.Pain011001.SupplementaryData1>||XmlElement()||
|+|UndrlygCxlDtls|List<ISO20022.Pain011001.MandateCancellation8>||XmlElement()||
|+|GrpHdr|ISO20022.Pain011001.GroupHeader110||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygCxlDtls""",UndrlygCxlDtls),validList("""UndrlygCxlDtls""",UndrlygCxlDtls),validElement(UndrlygCxlDtls),validElement(GrpHdr))|

