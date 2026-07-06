# tsrv.016.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsrv016001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsrv016001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Tsrv016001.ContactDetails2 {
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsrv016001.DateAndPlaceOfBirth {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Tsrv016001.Demand2 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Amt  : ISO20022.Tsrv016001.ActiveCurrencyAndAmount
        + SubmissnDtTm  : DateTime
        + Id  : String
    }
    ISO20022.Tsrv016001.Demand2 *-- ISO20022.Tsrv016001.ActiveCurrencyAndAmount
    class ISO20022.Tsrv016001.DemandRefusal1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + DspstnOfDocs  : global::System.Collections.Generic.List~String~
        + Dscrpncy  : global::System.Collections.Generic.List~ISO20022.Tsrv016001.Discrepancy1~
        + Sts  : String
        + DmndDtls  : ISO20022.Tsrv016001.Demand2
        + CnfrmrRefNb  : String
        + ScndAdvsgPtyRefNb  : String
        + AdvsgPtyRefNb  : String
        + UdrtkgId  : ISO20022.Tsrv016001.Undertaking9
    }
    ISO20022.Tsrv016001.DemandRefusal1 *-- ISO20022.Tsrv016001.Discrepancy1
    ISO20022.Tsrv016001.DemandRefusal1 *-- ISO20022.Tsrv016001.Demand2
    ISO20022.Tsrv016001.DemandRefusal1 *-- ISO20022.Tsrv016001.Undertaking9
    class ISO20022.Tsrv016001.DemandRefusalNotificationV01 {
        + DgtlSgntr  : ISO20022.Tsrv016001.PartyAndSignature2
        + DmndRfslNtfctnDtls  : global::System.Collections.Generic.List~ISO20022.Tsrv016001.DemandRefusal1~
    }
    ISO20022.Tsrv016001.DemandRefusalNotificationV01 *-- ISO20022.Tsrv016001.PartyAndSignature2
    ISO20022.Tsrv016001.DemandRefusalNotificationV01 *-- ISO20022.Tsrv016001.DemandRefusal1
    class ISO20022.Tsrv016001.Discrepancy1 {
        + Nrrtv  : String
        + Id  : String
    }
    class ISO20022.Tsrv016001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv016001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv016001.GenericOrganisationIdentification1 *-- ISO20022.Tsrv016001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Tsrv016001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsrv016001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsrv016001.GenericPersonIdentification1 *-- ISO20022.Tsrv016001.PersonIdentificationSchemeName1Choice
    class ISO20022.Tsrv016001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Tsrv016001.OrganisationIdentification8 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv016001.GenericOrganisationIdentification1~
        + AnyBIC  : String
    }
    ISO20022.Tsrv016001.OrganisationIdentification8 *-- ISO20022.Tsrv016001.GenericOrganisationIdentification1
    class ISO20022.Tsrv016001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv016001.Party11Choice {
        + PrvtId  : ISO20022.Tsrv016001.PersonIdentification5
        + OrgId  : ISO20022.Tsrv016001.OrganisationIdentification8
    }
    ISO20022.Tsrv016001.Party11Choice *-- ISO20022.Tsrv016001.PersonIdentification5
    ISO20022.Tsrv016001.Party11Choice *-- ISO20022.Tsrv016001.OrganisationIdentification8
    class ISO20022.Tsrv016001.PartyAndSignature2 {
        + Sgntr  : ISO20022.Tsrv016001.ProprietaryData3
        + Pty  : ISO20022.Tsrv016001.PartyIdentification43
    }
    ISO20022.Tsrv016001.PartyAndSignature2 *-- ISO20022.Tsrv016001.ProprietaryData3
    ISO20022.Tsrv016001.PartyAndSignature2 *-- ISO20022.Tsrv016001.PartyIdentification43
    class ISO20022.Tsrv016001.PartyIdentification43 {
        + CtctDtls  : ISO20022.Tsrv016001.ContactDetails2
        + CtryOfRes  : String
        + Id  : ISO20022.Tsrv016001.Party11Choice
        + PstlAdr  : ISO20022.Tsrv016001.PostalAddress6
        + Nm  : String
    }
    ISO20022.Tsrv016001.PartyIdentification43 *-- ISO20022.Tsrv016001.ContactDetails2
    ISO20022.Tsrv016001.PartyIdentification43 *-- ISO20022.Tsrv016001.Party11Choice
    ISO20022.Tsrv016001.PartyIdentification43 *-- ISO20022.Tsrv016001.PostalAddress6
    class ISO20022.Tsrv016001.PersonIdentification5 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsrv016001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Tsrv016001.DateAndPlaceOfBirth
    }
    ISO20022.Tsrv016001.PersonIdentification5 *-- ISO20022.Tsrv016001.GenericPersonIdentification1
    ISO20022.Tsrv016001.PersonIdentification5 *-- ISO20022.Tsrv016001.DateAndPlaceOfBirth
    class ISO20022.Tsrv016001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsrv016001.PostalAddress6 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Tsrv016001.ProprietaryData3 {
    }
    class ISO20022.Tsrv016001.Undertaking9 {
        + ApplcntRefNb  : String
        + Issr  : ISO20022.Tsrv016001.PartyIdentification43
        + Id  : String
    }
    ISO20022.Tsrv016001.Undertaking9 *-- ISO20022.Tsrv016001.PartyIdentification43
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Hiperspace.Edge
        + Tos (To = this) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Value ISO20022.Tsrv016001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Tsrv016001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Tsrv016001.ContactDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Tsrv016001.DateAndPlaceOfBirth


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv016001.Demand2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Amt|ISO20022.Tsrv016001.ActiveCurrencyAndAmount||XmlElement()||
|+|SubmissnDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validElement(Amt))|

---

## Value ISO20022.Tsrv016001.DemandRefusal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DspstnOfDocs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dscrpncy|global::System.Collections.Generic.List<ISO20022.Tsrv016001.Discrepancy1>||XmlElement()||
|+|Sts|String||XmlElement()||
|+|DmndDtls|ISO20022.Tsrv016001.Demand2||XmlElement()||
|+|CnfrmrRefNb|String||XmlElement()||
|+|ScndAdvsgPtyRefNb|String||XmlElement()||
|+|AdvsgPtyRefNb|String||XmlElement()||
|+|UdrtkgId|ISO20022.Tsrv016001.Undertaking9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlInf""",AddtlInf,5),validListMax("""DspstnOfDocs""",DspstnOfDocs,5),validList("""Dscrpncy""",Dscrpncy),validElement(Dscrpncy),validPattern("""Sts""",Sts,"""REFUSED"""),validElement(DmndDtls),validElement(UdrtkgId))|

---

## Aspect ISO20022.Tsrv016001.DemandRefusalNotificationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|ISO20022.Tsrv016001.PartyAndSignature2||XmlElement()||
|+|DmndRfslNtfctnDtls|global::System.Collections.Generic.List<ISO20022.Tsrv016001.DemandRefusal1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validList("""DmndRfslNtfctnDtls""",DmndRfslNtfctnDtls),validElement(DmndRfslNtfctnDtls))|

---

## Value ISO20022.Tsrv016001.Discrepancy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Tsrv016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmndRfslNtfctn|ISO20022.Tsrv016001.DemandRefusalNotificationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DmndRfslNtfctn))|

---

## Value ISO20022.Tsrv016001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv016001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsrv016001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsrv016001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Enum ISO20022.Tsrv016001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Tsrv016001.OrganisationIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv016001.GenericOrganisationIdentification1>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsrv016001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv016001.Party11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Tsrv016001.PersonIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsrv016001.OrganisationIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsrv016001.PartyAndSignature2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Tsrv016001.ProprietaryData3||XmlElement()||
|+|Pty|ISO20022.Tsrv016001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Tsrv016001.PartyIdentification43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Tsrv016001.ContactDetails2||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Tsrv016001.Party11Choice||XmlElement()||
|+|PstlAdr|ISO20022.Tsrv016001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Tsrv016001.PersonIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsrv016001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Tsrv016001.DateAndPlaceOfBirth||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Tsrv016001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsrv016001.PostalAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsrv016001.ProprietaryData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsrv016001.Undertaking9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ApplcntRefNb|String||XmlElement()||
|+|Issr|ISO20022.Tsrv016001.PartyIdentification43||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

