# catm.005.001.11-physical
```mermaid
classDiagram
    class ISO20022.Catm005001.Document {
        # Uri  : String
        + MntncDlgtnReq () : ISO20022.Catm005001.MaintenanceDelegationRequestV11
        + Validation () = validation(validElement(MntncDlgtnReq))
    }
    class ISO20022.Catm005001.MaintenanceDelegationRequestV11 {
        # owner  : ISO20022.Catm005001.Document
        + SctyTrlr  : ISO20022.Catm005001.ContentInformationType38
        + MntncDlgtnReq  : ISO20022.Catm005001.MaintenanceDelegationRequest11
        + Hdr  : ISO20022.Catm005001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(MntncDlgtnReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MntncDlgtnReq|ISO20022.Catm005001.MaintenanceDelegationRequestV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntncDlgtnReq))|

---

## AspectImpl ISO20022.Catm005001.MaintenanceDelegationRequestV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm005001.Document||||
|+|SctyTrlr|ISO20022.Catm005001.ContentInformationType38||XmlElement()||
|+|MntncDlgtnReq|ISO20022.Catm005001.MaintenanceDelegationRequest11||XmlElement()||
|+|Hdr|ISO20022.Catm005001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(MntncDlgtnReq),validElement(Hdr))|

