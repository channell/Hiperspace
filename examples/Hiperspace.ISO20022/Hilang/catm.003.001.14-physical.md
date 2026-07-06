# catm.003.001.14-physical
```mermaid
classDiagram
    class ISO20022.Catm003001.Document {
        # Uri  : String
        + AccptrCfgtnUpd () : ISO20022.Catm003001.AcceptorConfigurationUpdateV14
        + Validation () = validation(validElement(AccptrCfgtnUpd))
    }
    class ISO20022.Catm003001.AcceptorConfigurationUpdateV14 {
        # owner  : ISO20022.Catm003001.Document
        + SctyTrlr  : ISO20022.Catm003001.ContentInformationType38
        + AccptrCfgtn  : ISO20022.Catm003001.AcceptorConfiguration14
        + Hdr  : ISO20022.Catm003001.TMSHeader1
        + Validation () = validation(validElement(SctyTrlr),validElement(AccptrCfgtn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catm003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrCfgtnUpd|ISO20022.Catm003001.AcceptorConfigurationUpdateV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCfgtnUpd))|

---

## AspectImpl ISO20022.Catm003001.AcceptorConfigurationUpdateV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catm003001.Document||||
|+|SctyTrlr|ISO20022.Catm003001.ContentInformationType38||XmlElement()||
|+|AccptrCfgtn|ISO20022.Catm003001.AcceptorConfiguration14||XmlElement()||
|+|Hdr|ISO20022.Catm003001.TMSHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(AccptrCfgtn),validElement(Hdr))|

