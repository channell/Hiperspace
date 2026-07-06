# acmt.010.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt010001.AccountForAction1 {
        + Ccy  : String
        + Id  : ISO20022.Acmt010001.AccountIdentification4Choice
    }
    ISO20022.Acmt010001.AccountForAction1 *-- ISO20022.Acmt010001.AccountIdentification4Choice
    class ISO20022.Acmt010001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt010001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt010001.AccountIdentification4Choice *-- ISO20022.Acmt010001.GenericAccountIdentification1
    class ISO20022.Acmt010001.AccountRequestAcknowledgementV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Acmt010001.SupplementaryData1~
        + DgtlSgntr  : global::System.Collections.Generic.List~ISO20022.Acmt010001.PartyAndSignature4~
        + AcctSvcrId  : ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8
        + OrgId  : ISO20022.Acmt010001.OrganisationIdentification39
        + AcctId  : global::System.Collections.Generic.List~ISO20022.Acmt010001.AccountForAction1~
        + Fr  : ISO20022.Acmt010001.OrganisationIdentification39
        + Refs  : ISO20022.Acmt010001.References5
    }
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.SupplementaryData1
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.PartyAndSignature4
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.OrganisationIdentification39
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.AccountForAction1
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.OrganisationIdentification39
    ISO20022.Acmt010001.AccountRequestAcknowledgementV04 *-- ISO20022.Acmt010001.References5
    class ISO20022.Acmt010001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt010001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt010001.AddressType3Choice {
        + Prtry  : ISO20022.Acmt010001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Acmt010001.AddressType3Choice *-- ISO20022.Acmt010001.GenericIdentification30
    class ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Acmt010001.BranchData5
        + FinInstnId  : ISO20022.Acmt010001.FinancialInstitutionIdentification23
    }
    ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt010001.BranchData5
    ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt010001.FinancialInstitutionIdentification23
    class ISO20022.Acmt010001.BranchData5 {
        + PstlAdr  : ISO20022.Acmt010001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Acmt010001.BranchData5 *-- ISO20022.Acmt010001.PostalAddress27
    class ISO20022.Acmt010001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt010001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Acmt010001.ClearingSystemIdentification2Choice
    }
    ISO20022.Acmt010001.ClearingSystemMemberIdentification2 *-- ISO20022.Acmt010001.ClearingSystemIdentification2Choice
    class ISO20022.Acmt010001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt010001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + URLAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    ISO20022.Acmt010001.Contact13 *-- ISO20022.Acmt010001.OtherContact1
    class ISO20022.Acmt010001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Acmt010001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt010001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Acmt010001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Acmt010001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Acmt010001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Acmt010001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt010001.GenericFinancialIdentification1
    ISO20022.Acmt010001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt010001.PostalAddress27
    ISO20022.Acmt010001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt010001.ClearingSystemMemberIdentification2
    class ISO20022.Acmt010001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt010001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt010001.GenericAccountIdentification1 *-- ISO20022.Acmt010001.AccountSchemeName1Choice
    class ISO20022.Acmt010001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt010001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt010001.GenericFinancialIdentification1 *-- ISO20022.Acmt010001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Acmt010001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt010001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt010001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt010001.GenericOrganisationIdentification3 *-- ISO20022.Acmt010001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Acmt010001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt010001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt010001.GenericPersonIdentification2 *-- ISO20022.Acmt010001.PersonIdentificationSchemeName1Choice
    class ISO20022.Acmt010001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt010001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Acmt010001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt010001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Acmt010001.OrganisationIdentification39 *-- ISO20022.Acmt010001.GenericOrganisationIdentification3
    class ISO20022.Acmt010001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt010001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Acmt010001.Party52Choice {
        + PrvtId  : ISO20022.Acmt010001.PersonIdentification18
        + OrgId  : ISO20022.Acmt010001.OrganisationIdentification39
    }
    ISO20022.Acmt010001.Party52Choice *-- ISO20022.Acmt010001.PersonIdentification18
    ISO20022.Acmt010001.Party52Choice *-- ISO20022.Acmt010001.OrganisationIdentification39
    class ISO20022.Acmt010001.PartyAndSignature4 {
        + Sgntr  : ISO20022.Acmt010001.SkipPayload
        + Pty  : ISO20022.Acmt010001.PartyIdentification272
    }
    ISO20022.Acmt010001.PartyAndSignature4 *-- ISO20022.Acmt010001.SkipPayload
    ISO20022.Acmt010001.PartyAndSignature4 *-- ISO20022.Acmt010001.PartyIdentification272
    class ISO20022.Acmt010001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Acmt010001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt010001.Party52Choice
        + PstlAdr  : ISO20022.Acmt010001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt010001.PartyIdentification272 *-- ISO20022.Acmt010001.Contact13
    ISO20022.Acmt010001.PartyIdentification272 *-- ISO20022.Acmt010001.Party52Choice
    ISO20022.Acmt010001.PartyIdentification272 *-- ISO20022.Acmt010001.PostalAddress27
    class ISO20022.Acmt010001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt010001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Acmt010001.DateAndPlaceOfBirth1
    }
    ISO20022.Acmt010001.PersonIdentification18 *-- ISO20022.Acmt010001.GenericPersonIdentification2
    ISO20022.Acmt010001.PersonIdentification18 *-- ISO20022.Acmt010001.DateAndPlaceOfBirth1
    class ISO20022.Acmt010001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt010001.PostalAddress27 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + UnitNb  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + CareOf  : String
        + AdrTp  : ISO20022.Acmt010001.AddressType3Choice
    }
    ISO20022.Acmt010001.PostalAddress27 *-- ISO20022.Acmt010001.AddressType3Choice
    class ISO20022.Acmt010001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Acmt010001.References5 {
        + AttchdDocNm  : global::System.Collections.Generic.List~String~
        + Sts  : String
        + AckdMsgId  : global::System.Collections.Generic.List~ISO20022.Acmt010001.MessageIdentification1~
        + PrcId  : ISO20022.Acmt010001.MessageIdentification1
        + MsgId  : ISO20022.Acmt010001.MessageIdentification1
        + ReqTp  : String
    }
    ISO20022.Acmt010001.References5 *-- ISO20022.Acmt010001.MessageIdentification1
    ISO20022.Acmt010001.References5 *-- ISO20022.Acmt010001.MessageIdentification1
    ISO20022.Acmt010001.References5 *-- ISO20022.Acmt010001.MessageIdentification1
    class ISO20022.Acmt010001.SkipPayload {
    }
    class ISO20022.Acmt010001.SupplementaryData1 {
        + Envlp  : ISO20022.Acmt010001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Acmt010001.SupplementaryData1 *-- ISO20022.Acmt010001.SupplementaryDataEnvelope1
    class ISO20022.Acmt010001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Acmt010001.UseCases1Code {
        VIEW = 1
        CLSG = 2
        MNTN = 3
        OPEN = 4
    }
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

## Value ISO20022.Acmt010001.AccountForAction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Id|ISO20022.Acmt010001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Id))|

---

## Value ISO20022.Acmt010001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt010001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Aspect ISO20022.Acmt010001.AccountRequestAcknowledgementV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Acmt010001.SupplementaryData1>||XmlElement()||
|+|DgtlSgntr|global::System.Collections.Generic.List<ISO20022.Acmt010001.PartyAndSignature4>||XmlElement()||
|+|AcctSvcrId|ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|OrgId|ISO20022.Acmt010001.OrganisationIdentification39||XmlElement()||
|+|AcctId|global::System.Collections.Generic.List<ISO20022.Acmt010001.AccountForAction1>||XmlElement()||
|+|Fr|ISO20022.Acmt010001.OrganisationIdentification39||XmlElement()||
|+|Refs|ISO20022.Acmt010001.References5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(AcctSvcrId),validElement(OrgId),validList("""AcctId""",AcctId),validElement(AcctId),validElement(Fr),validElement(Refs))|

---

## Value ISO20022.Acmt010001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt010001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt010001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt010001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt010001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Acmt010001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Acmt010001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Acmt010001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt010001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Acmt010001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt010001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Acmt010001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Acmt010001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt010001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Acmt010001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Acmt010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctReqAck|ISO20022.Acmt010001.AccountRequestAcknowledgementV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctReqAck))|

---

## Value ISO20022.Acmt010001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt010001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt010001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Acmt010001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt010001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt010001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt010001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt010001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt010001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt010001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt010001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt010001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt010001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt010001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt010001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt010001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Acmt010001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt010001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt010001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt010001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt010001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Acmt010001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Acmt010001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Acmt010001.PartyAndSignature4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Acmt010001.SkipPayload||XmlElement()||
|+|Pty|ISO20022.Acmt010001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Acmt010001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt010001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt010001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Acmt010001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt010001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt010001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Acmt010001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Acmt010001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt010001.PostalAddress27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|AdrTp|ISO20022.Acmt010001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt010001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Acmt010001.References5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdDocNm|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Sts|String||XmlElement()||
|+|AckdMsgId|global::System.Collections.Generic.List<ISO20022.Acmt010001.MessageIdentification1>||XmlElement()||
|+|PrcId|ISO20022.Acmt010001.MessageIdentification1||XmlElement()||
|+|MsgId|ISO20022.Acmt010001.MessageIdentification1||XmlElement()||
|+|ReqTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AckdMsgId""",AckdMsgId),validElement(AckdMsgId),validElement(PrcId),validElement(MsgId))|

---

## Value ISO20022.Acmt010001.SkipPayload


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt010001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Acmt010001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Acmt010001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt010001.UseCases1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIEW|Int32||XmlEnum("""VIEW""")|1|
||CLSG|Int32||XmlEnum("""CLSG""")|2|
||MNTN|Int32||XmlEnum("""MNTN""")|3|
||OPEN|Int32||XmlEnum("""OPEN""")|4|

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

