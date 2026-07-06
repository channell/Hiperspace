# catm.008.001.07-physical
```mermaid
classDiagram
    class ISO20022.Catm008001.Document {
        # Uri  : String
        + CertMgmtRspn () : ISO20022.Catm008001.CertificateManagementResponseV07
        + Validation () = validation(validElement(CertMgmtRspn))
    }
    class ISO20022.Catm008001.CertificateManagementResponseV07 {
        # owner  : ISO20022.Catm008001.Document
        + SctyTrlr  : ISO20022.Catm008001.ContentInformationType38
        + CertMgmtRspn  : ISO20022.Catm008001.CertificateManagementResponse3
        + Hdr  : ISO20022.Catm008001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(CertMgmtRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CertMgmtRspn|ISO20022.Catm008001.CertificateManagementResponseV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertMgmtRspn))|

---

## AspectImpl ISO20022.Catm008001.CertificateManagementResponseV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm008001.Document||||
|+|SctyTrlr|ISO20022.Catm008001.ContentInformationType38||XmlElement()||
|+|CertMgmtRspn|ISO20022.Catm008001.CertificateManagementResponse3||XmlElement()||
|+|Hdr|ISO20022.Catm008001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CertMgmtRspn),validElement(Hdr))|

