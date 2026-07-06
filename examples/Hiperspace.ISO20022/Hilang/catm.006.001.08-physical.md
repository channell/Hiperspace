# catm.006.001.08-physical
```mermaid
classDiagram
    class ISO20022.Catm006001.Document {
        # Uri  : String
        + MntncDlgtnRspn () : ISO20022.Catm006001.MaintenanceDelegationResponseV08
        + Validation () = validation(validElement(MntncDlgtnRspn))
    }
    class ISO20022.Catm006001.MaintenanceDelegationResponseV08 {
        # owner  : ISO20022.Catm006001.Document
        + SctyTrlr  : ISO20022.Catm006001.ContentInformationType38
        + MntncDlgtnRspn  : ISO20022.Catm006001.MaintenanceDelegationResponse8
        + Hdr  : ISO20022.Catm006001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(MntncDlgtnRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MntncDlgtnRspn|ISO20022.Catm006001.MaintenanceDelegationResponseV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntncDlgtnRspn))|

---

## AspectImpl ISO20022.Catm006001.MaintenanceDelegationResponseV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm006001.Document||||
|+|SctyTrlr|ISO20022.Catm006001.ContentInformationType38||XmlElement()||
|+|MntncDlgtnRspn|ISO20022.Catm006001.MaintenanceDelegationResponse8||XmlElement()||
|+|Hdr|ISO20022.Catm006001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(MntncDlgtnRspn),validElement(Hdr))|

