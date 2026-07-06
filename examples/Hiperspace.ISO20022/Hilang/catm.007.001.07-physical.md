# catm.007.001.07-physical
```mermaid
classDiagram
    class ISO20022.Catm007001.Document {
        # Uri  : String
        + CertMgmtReq () : ISO20022.Catm007001.CertificateManagementRequestV07
        + Validation () = validation(validElement(CertMgmtReq))
    }
    class ISO20022.Catm007001.CertificateManagementRequestV07 {
        # owner  : ISO20022.Catm007001.Document
        + SctyTrlr  : ISO20022.Catm007001.ContentInformationType38
        + CertMgmtReq  : ISO20022.Catm007001.CertificateManagementRequest3
        + Hdr  : ISO20022.Catm007001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(CertMgmtReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CertMgmtReq|ISO20022.Catm007001.CertificateManagementRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CertMgmtReq))|

---

## AspectImpl ISO20022.Catm007001.CertificateManagementRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm007001.Document||||
|+|SctyTrlr|ISO20022.Catm007001.ContentInformationType38||XmlElement()||
|+|CertMgmtReq|ISO20022.Catm007001.CertificateManagementRequest3||XmlElement()||
|+|Hdr|ISO20022.Catm007001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CertMgmtReq),validElement(Hdr))|

