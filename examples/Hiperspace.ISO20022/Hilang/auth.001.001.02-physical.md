# auth.001.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth001001.Document {
        # Uri  : String
        + InfReqOpng () : ISO20022.Auth001001.InformationRequestOpeningV02
        + Validation () = validation(validElement(InfReqOpng))
    }
    class ISO20022.Auth001001.InformationRequestOpeningV02 {
        # owner  : ISO20022.Auth001001.Document
        + SplmtryData  : List~ISO20022.Auth001001.SupplementaryData1~
        + SchCrit  : ISO20022.Auth001001.SearchCriteria2Choice
        + InvstgtnPrd  : ISO20022.Auth001001.DateOrDateTimePeriod1Choice
        + DueDt  : ISO20022.Auth001001.DueDate1
        + CnfdtltySts  : String
        + LglMndtBsis  : ISO20022.Auth001001.LegalMandate1
        + InvstgtnId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(InvstgtnPrd),validElement(DueDt),validElement(LglMndtBsis))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InfReqOpng|ISO20022.Auth001001.InformationRequestOpeningV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfReqOpng))|

---

## AspectImpl ISO20022.Auth001001.InformationRequestOpeningV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth001001.Document||||
|+|SplmtryData|List<ISO20022.Auth001001.SupplementaryData1>||XmlElement()||
|+|SchCrit|ISO20022.Auth001001.SearchCriteria2Choice||XmlElement()||
|+|InvstgtnPrd|ISO20022.Auth001001.DateOrDateTimePeriod1Choice||XmlElement()||
|+|DueDt|ISO20022.Auth001001.DueDate1||XmlElement()||
|+|CnfdtltySts|String||XmlElement()||
|+|LglMndtBsis|ISO20022.Auth001001.LegalMandate1||XmlElement()||
|+|InvstgtnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(InvstgtnPrd),validElement(DueDt),validElement(LglMndtBsis))|

