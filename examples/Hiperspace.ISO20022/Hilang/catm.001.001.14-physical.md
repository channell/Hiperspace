# catm.001.001.14-physical
```mermaid
classDiagram
    class ISO20022.Catm001001.Document {
        # Uri  : String
        + StsRpt () : ISO20022.Catm001001.StatusReportV14
        + Validation () = validation(validElement(StsRpt))
    }
    class ISO20022.Catm001001.StatusReportV14 {
        # owner  : ISO20022.Catm001001.Document
        + SctyTrlr  : ISO20022.Catm001001.ContentInformationType38
        + StsRpt  : ISO20022.Catm001001.StatusReport14
        + Hdr  : ISO20022.Catm001001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(StsRpt),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsRpt|ISO20022.Catm001001.StatusReportV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsRpt))|

---

## AspectImpl ISO20022.Catm001001.StatusReportV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm001001.Document||||
|+|SctyTrlr|ISO20022.Catm001001.ContentInformationType38||XmlElement()||
|+|StsRpt|ISO20022.Catm001001.StatusReport14||XmlElement()||
|+|Hdr|ISO20022.Catm001001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(StsRpt),validElement(Hdr))|

