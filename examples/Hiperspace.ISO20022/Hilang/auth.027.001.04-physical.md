# auth.027.001.04-physical
```mermaid
classDiagram
    class ISO20022.Auth027001.Document {
        # Uri  : String
        + CcyCtrlStsAdvc () : ISO20022.Auth027001.CurrencyControlStatusAdviceV04
        + Validation () = validation(validElement(CcyCtrlStsAdvc))
    }
    class ISO20022.Auth027001.CurrencyControlStatusAdviceV04 {
        # owner  : ISO20022.Auth027001.Document
        + SplmtryData  : List~ISO20022.Auth027001.SupplementaryData1~
        + PackgSts  : List~ISO20022.Auth027001.CurrencyControlPackageStatus3~
        + GrpSts  : List~ISO20022.Auth027001.CurrencyControlGroupStatus3~
        + GrpHdr  : ISO20022.Auth027001.CurrencyControlHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PackgSts""",PackgSts),validElement(PackgSts),validRequired("""GrpSts""",GrpSts),validList("""GrpSts""",GrpSts),validElement(GrpSts),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CcyCtrlStsAdvc|ISO20022.Auth027001.CurrencyControlStatusAdviceV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyCtrlStsAdvc))|

---

## AspectImpl ISO20022.Auth027001.CurrencyControlStatusAdviceV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth027001.Document||||
|+|SplmtryData|List<ISO20022.Auth027001.SupplementaryData1>||XmlElement()||
|+|PackgSts|List<ISO20022.Auth027001.CurrencyControlPackageStatus3>||XmlElement()||
|+|GrpSts|List<ISO20022.Auth027001.CurrencyControlGroupStatus3>||XmlElement()||
|+|GrpHdr|ISO20022.Auth027001.CurrencyControlHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PackgSts""",PackgSts),validElement(PackgSts),validRequired("""GrpSts""",GrpSts),validList("""GrpSts""",GrpSts),validElement(GrpSts),validElement(GrpHdr))|

