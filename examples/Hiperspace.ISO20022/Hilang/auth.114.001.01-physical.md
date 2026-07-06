# auth.114.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth114001.Document {
        # Uri  : String
        + RgltryMetadataRpt () : ISO20022.Auth114001.RegulatoryMetadataReportV01
        + Validation () = validation(validElement(RgltryMetadataRpt))
    }
    class ISO20022.Auth114001.RegulatoryMetadataReportV01 {
        # owner  : ISO20022.Auth114001.Document
        + SplmtryData  : List~ISO20022.Auth114001.SupplementaryData1~
        + MetadataRpt  : List~ISO20022.Auth114001.MetadataReport5~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""MetadataRpt""",MetadataRpt),validList("""MetadataRpt""",MetadataRpt),validElement(MetadataRpt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth114001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RgltryMetadataRpt|ISO20022.Auth114001.RegulatoryMetadataReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RgltryMetadataRpt))|

---

## AspectImpl ISO20022.Auth114001.RegulatoryMetadataReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth114001.Document||||
|+|SplmtryData|List<ISO20022.Auth114001.SupplementaryData1>||XmlElement()||
|+|MetadataRpt|List<ISO20022.Auth114001.MetadataReport5>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""MetadataRpt""",MetadataRpt),validList("""MetadataRpt""",MetadataRpt),validElement(MetadataRpt))|

