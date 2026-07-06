# secl.004.001.04-physical
```mermaid
classDiagram
    class ISO20022.Secl004001.Document {
        # Uri  : String
        + NetPos () : ISO20022.Secl004001.NetPositionV04
        + Validation () = validation(validElement(NetPos))
    }
    class ISO20022.Secl004001.NetPositionV04 {
        # owner  : ISO20022.Secl004001.Document
        + SplmtryData  : List~ISO20022.Secl004001.SupplementaryData1~
        + NetPosRpt  : List~ISO20022.Secl004001.NetPosition4~
        + ClrSgmt  : ISO20022.Secl004001.PartyIdentification253Choice
        + ClrMmb  : ISO20022.Secl004001.PartyIdentification253Choice
        + Pgntn  : ISO20022.Secl004001.Pagination1
        + RptParams  : ISO20022.Secl004001.ReportParameters7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""NetPosRpt""",NetPosRpt),validList("""NetPosRpt""",NetPosRpt),validElement(NetPosRpt),validElement(ClrSgmt),validElement(ClrMmb),validElement(Pgntn),validElement(RptParams))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Secl004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NetPos|ISO20022.Secl004001.NetPositionV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NetPos))|

---

## AspectImpl ISO20022.Secl004001.NetPositionV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Secl004001.Document||||
|+|SplmtryData|List<ISO20022.Secl004001.SupplementaryData1>||XmlElement()||
|+|NetPosRpt|List<ISO20022.Secl004001.NetPosition4>||XmlElement()||
|+|ClrSgmt|ISO20022.Secl004001.PartyIdentification253Choice||XmlElement()||
|+|ClrMmb|ISO20022.Secl004001.PartyIdentification253Choice||XmlElement()||
|+|Pgntn|ISO20022.Secl004001.Pagination1||XmlElement()||
|+|RptParams|ISO20022.Secl004001.ReportParameters7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""NetPosRpt""",NetPosRpt),validList("""NetPosRpt""",NetPosRpt),validElement(NetPosRpt),validElement(ClrSgmt),validElement(ClrMmb),validElement(Pgntn),validElement(RptParams))|

