# pain.009.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Pain009001.AccountIdentification4Choice {
        + Othr  : ISO20022.Pain009001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Pain009001.AccountIdentification4Choice *-- ISO20022.Pain009001.GenericAccountIdentification1
    class ISO20022.Pain009001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Pain009001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Pain009001.AddressType3Choice {
        + Prtry  : ISO20022.Pain009001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Pain009001.AddressType3Choice *-- ISO20022.Pain009001.GenericIdentification30
    class ISO20022.Pain009001.AuthenticationChannel1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.Authorisation1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.Authorisation1Code {
        ILEV = 1
        FSUM = 2
        FDET = 3
        AUTH = 4
    }
    class ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Pain009001.BranchData5
        + FinInstnId  : ISO20022.Pain009001.FinancialInstitutionIdentification23
    }
    ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Pain009001.BranchData5
    ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Pain009001.FinancialInstitutionIdentification23
    class ISO20022.Pain009001.BranchData5 {
        + PstlAdr  : ISO20022.Pain009001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Pain009001.BranchData5 *-- ISO20022.Pain009001.PostalAddress27
    class ISO20022.Pain009001.CashAccount40 {
        + Prxy  : ISO20022.Pain009001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Pain009001.CashAccountType2Choice
        + Id  : ISO20022.Pain009001.AccountIdentification4Choice
    }
    ISO20022.Pain009001.CashAccount40 *-- ISO20022.Pain009001.ProxyAccountIdentification1
    ISO20022.Pain009001.CashAccount40 *-- ISO20022.Pain009001.CashAccountType2Choice
    ISO20022.Pain009001.CashAccount40 *-- ISO20022.Pain009001.AccountIdentification4Choice
    class ISO20022.Pain009001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Pain009001.ClearingSystemIdentification2Choice
    }
    ISO20022.Pain009001.ClearingSystemMemberIdentification2 *-- ISO20022.Pain009001.ClearingSystemIdentification2Choice
    class ISO20022.Pain009001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Pain009001.OtherContact1~
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
    ISO20022.Pain009001.Contact13 *-- ISO20022.Pain009001.OtherContact1
    class ISO20022.Pain009001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Pain009001.DateAndType1 {
        + Dt  : DateTime
        + Tp  : ISO20022.Pain009001.DateType2Choice
    }
    ISO20022.Pain009001.DateAndType1 *-- ISO20022.Pain009001.DateType2Choice
    class ISO20022.Pain009001.DatePeriod3 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Pain009001.DateType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.DocumentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Pain009001.DocumentType2Choice
    }
    ISO20022.Pain009001.DocumentType1 *-- ISO20022.Pain009001.DocumentType2Choice
    class ISO20022.Pain009001.DocumentType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Pain009001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Pain009001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Pain009001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Pain009001.FinancialInstitutionIdentification23 *-- ISO20022.Pain009001.GenericFinancialIdentification1
    ISO20022.Pain009001.FinancialInstitutionIdentification23 *-- ISO20022.Pain009001.PostalAddress27
    ISO20022.Pain009001.FinancialInstitutionIdentification23 *-- ISO20022.Pain009001.ClearingSystemMemberIdentification2
    class ISO20022.Pain009001.Frequency10Code {
        QURT = 1
        MIAN = 2
        RATE = 3
        YEAR = 4
        NEVR = 5
    }
    class ISO20022.Pain009001.Frequency36Choice {
        + PtInTm  : ISO20022.Pain009001.FrequencyAndMoment1
        + Prd  : ISO20022.Pain009001.FrequencyPeriod1
        + Tp  : String
    }
    ISO20022.Pain009001.Frequency36Choice *-- ISO20022.Pain009001.FrequencyAndMoment1
    ISO20022.Pain009001.Frequency36Choice *-- ISO20022.Pain009001.FrequencyPeriod1
    class ISO20022.Pain009001.Frequency37Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.Frequency6Code {
        FRTN = 1
        INDA = 2
        ADHO = 3
        DAIL = 4
        WEEK = 5
        MIAN = 6
        QURT = 7
        MNTH = 8
        YEAR = 9
    }
    class ISO20022.Pain009001.FrequencyAndMoment1 {
        + PtInTm  : String
        + Tp  : String
    }
    class ISO20022.Pain009001.FrequencyPeriod1 {
        + CntPerPrd  : Decimal
        + Tp  : String
    }
    class ISO20022.Pain009001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Pain009001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Pain009001.GenericAccountIdentification1 *-- ISO20022.Pain009001.AccountSchemeName1Choice
    class ISO20022.Pain009001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Pain009001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Pain009001.GenericFinancialIdentification1 *-- ISO20022.Pain009001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Pain009001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Pain009001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Pain009001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Pain009001.GenericOrganisationIdentification3 *-- ISO20022.Pain009001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Pain009001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Pain009001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Pain009001.GenericPersonIdentification2 *-- ISO20022.Pain009001.PersonIdentificationSchemeName1Choice
    class ISO20022.Pain009001.GroupHeader110 {
        + InstdAgt  : ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
        + InitgPty  : ISO20022.Pain009001.PartyIdentification272
        + Authstn  : global::System.Collections.Generic.List~ISO20022.Pain009001.Authorisation1Choice~
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Pain009001.GroupHeader110 *-- ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Pain009001.GroupHeader110 *-- ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Pain009001.GroupHeader110 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.GroupHeader110 *-- ISO20022.Pain009001.Authorisation1Choice
    class ISO20022.Pain009001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.Mandate23 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Pain009001.SupplementaryData1~
        + RfrdDoc  : global::System.Collections.Generic.List~ISO20022.Pain009001.ReferredMandateDocument2~
        + MndtRef  : String
        + UltmtDbtr  : ISO20022.Pain009001.PartyIdentification272
        + DbtrAgt  : ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Pain009001.CashAccount40
        + Dbtr  : ISO20022.Pain009001.PartyIdentification272
        + UltmtCdtr  : ISO20022.Pain009001.PartyIdentification272
        + CdtrAgt  : ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
        + CdtrAcct  : ISO20022.Pain009001.CashAccount40
        + Cdtr  : ISO20022.Pain009001.PartyIdentification272
        + CdtrSchmeId  : ISO20022.Pain009001.PartyIdentification272
        + Rsn  : ISO20022.Pain009001.MandateSetupReason1Choice
        + Adjstmnt  : ISO20022.Pain009001.MandateAdjustment1
        + MaxAmt  : ISO20022.Pain009001.ActiveCurrencyAndAmount
        + ColltnAmt  : ISO20022.Pain009001.ActiveCurrencyAndAmount
        + FrstColltnAmt  : ISO20022.Pain009001.ActiveCurrencyAndAmount
        + TrckgInd  : String
        + Ocrncs  : ISO20022.Pain009001.MandateOccurrences5
        + Tp  : ISO20022.Pain009001.MandateTypeInformation2
        + Authntcn  : ISO20022.Pain009001.MandateAuthentication1
        + MndtReqId  : String
        + MndtId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.SupplementaryData1
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.ReferredMandateDocument2
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.CashAccount40
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.CashAccount40
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.PartyIdentification272
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.MandateSetupReason1Choice
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.MandateAdjustment1
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.ActiveCurrencyAndAmount
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.ActiveCurrencyAndAmount
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.ActiveCurrencyAndAmount
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.MandateOccurrences5
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.MandateTypeInformation2
    ISO20022.Pain009001.Mandate23 *-- ISO20022.Pain009001.MandateAuthentication1
    class ISO20022.Pain009001.MandateAdjustment1 {
        + Rate  : Decimal
        + Amt  : ISO20022.Pain009001.ActiveCurrencyAndAmount
        + Ctgy  : ISO20022.Pain009001.Frequency37Choice
        + DtAdjstmntRuleInd  : String
    }
    ISO20022.Pain009001.MandateAdjustment1 *-- ISO20022.Pain009001.ActiveCurrencyAndAmount
    ISO20022.Pain009001.MandateAdjustment1 *-- ISO20022.Pain009001.Frequency37Choice
    class ISO20022.Pain009001.MandateAuthentication1 {
        + Chanl  : ISO20022.Pain009001.AuthenticationChannel1Choice
        + Dt  : DateTime
        + MsgAuthntcnCd  : String
    }
    ISO20022.Pain009001.MandateAuthentication1 *-- ISO20022.Pain009001.AuthenticationChannel1Choice
    class ISO20022.Pain009001.MandateClassification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.MandateClassification1Code {
        VARI = 1
        USGB = 2
        FIXE = 3
    }
    class ISO20022.Pain009001.MandateInitiationRequestV08 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Pain009001.SupplementaryData1~
        + Mndt  : global::System.Collections.Generic.List~ISO20022.Pain009001.Mandate23~
        + GrpHdr  : ISO20022.Pain009001.GroupHeader110
    }
    ISO20022.Pain009001.MandateInitiationRequestV08 *-- ISO20022.Pain009001.SupplementaryData1
    ISO20022.Pain009001.MandateInitiationRequestV08 *-- ISO20022.Pain009001.Mandate23
    ISO20022.Pain009001.MandateInitiationRequestV08 *-- ISO20022.Pain009001.GroupHeader110
    class ISO20022.Pain009001.MandateOccurrences5 {
        + FnlColltnDt  : DateTime
        + FrstColltnDt  : DateTime
        + Drtn  : ISO20022.Pain009001.DatePeriod3
        + Frqcy  : ISO20022.Pain009001.Frequency36Choice
        + SeqTp  : String
    }
    ISO20022.Pain009001.MandateOccurrences5 *-- ISO20022.Pain009001.DatePeriod3
    ISO20022.Pain009001.MandateOccurrences5 *-- ISO20022.Pain009001.Frequency36Choice
    class ISO20022.Pain009001.MandateSetupReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.MandateTypeInformation2 {
        + Clssfctn  : ISO20022.Pain009001.MandateClassification1Choice
        + CtgyPurp  : ISO20022.Pain009001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Pain009001.LocalInstrument2Choice
        + SvcLvl  : ISO20022.Pain009001.ServiceLevel8Choice
    }
    ISO20022.Pain009001.MandateTypeInformation2 *-- ISO20022.Pain009001.MandateClassification1Choice
    ISO20022.Pain009001.MandateTypeInformation2 *-- ISO20022.Pain009001.CategoryPurpose1Choice
    ISO20022.Pain009001.MandateTypeInformation2 *-- ISO20022.Pain009001.LocalInstrument2Choice
    ISO20022.Pain009001.MandateTypeInformation2 *-- ISO20022.Pain009001.ServiceLevel8Choice
    class ISO20022.Pain009001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Pain009001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Pain009001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Pain009001.OrganisationIdentification39 *-- ISO20022.Pain009001.GenericOrganisationIdentification3
    class ISO20022.Pain009001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Pain009001.Party52Choice {
        + PrvtId  : ISO20022.Pain009001.PersonIdentification18
        + OrgId  : ISO20022.Pain009001.OrganisationIdentification39
    }
    ISO20022.Pain009001.Party52Choice *-- ISO20022.Pain009001.PersonIdentification18
    ISO20022.Pain009001.Party52Choice *-- ISO20022.Pain009001.OrganisationIdentification39
    class ISO20022.Pain009001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Pain009001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Pain009001.Party52Choice
        + PstlAdr  : ISO20022.Pain009001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Pain009001.PartyIdentification272 *-- ISO20022.Pain009001.Contact13
    ISO20022.Pain009001.PartyIdentification272 *-- ISO20022.Pain009001.Party52Choice
    ISO20022.Pain009001.PartyIdentification272 *-- ISO20022.Pain009001.PostalAddress27
    class ISO20022.Pain009001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Pain009001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Pain009001.DateAndPlaceOfBirth1
    }
    ISO20022.Pain009001.PersonIdentification18 *-- ISO20022.Pain009001.GenericPersonIdentification2
    ISO20022.Pain009001.PersonIdentification18 *-- ISO20022.Pain009001.DateAndPlaceOfBirth1
    class ISO20022.Pain009001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Pain009001.AddressType3Choice
    }
    ISO20022.Pain009001.PostalAddress27 *-- ISO20022.Pain009001.AddressType3Choice
    class ISO20022.Pain009001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Pain009001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Pain009001.ProxyAccountType1Choice
    }
    ISO20022.Pain009001.ProxyAccountIdentification1 *-- ISO20022.Pain009001.ProxyAccountType1Choice
    class ISO20022.Pain009001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.ReferredMandateDocument2 {
        + RltdDt  : ISO20022.Pain009001.DateAndType1
        + CdtrRef  : String
        + Nb  : String
        + Tp  : ISO20022.Pain009001.DocumentType1
    }
    ISO20022.Pain009001.ReferredMandateDocument2 *-- ISO20022.Pain009001.DateAndType1
    ISO20022.Pain009001.ReferredMandateDocument2 *-- ISO20022.Pain009001.DocumentType1
    class ISO20022.Pain009001.SequenceType2Code {
        OOFF = 1
        RCUR = 2
    }
    class ISO20022.Pain009001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Pain009001.SupplementaryData1 {
        + Envlp  : ISO20022.Pain009001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Pain009001.SupplementaryData1 *-- ISO20022.Pain009001.SupplementaryDataEnvelope1
    class ISO20022.Pain009001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Pain009001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Pain009001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Pain009001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Pain009001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Pain009001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Pain009001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.AuthenticationChannel1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.Authorisation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Pain009001.Authorisation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ILEV|Int32||XmlEnum("""ILEV""")|1|
||FSUM|Int32||XmlEnum("""FSUM""")|2|
||FDET|Int32||XmlEnum("""FDET""")|3|
||AUTH|Int32||XmlEnum("""AUTH""")|4|

---

## Value ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Pain009001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Pain009001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Pain009001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Pain009001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Pain009001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Pain009001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Pain009001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Pain009001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Pain009001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Pain009001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Pain009001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Pain009001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Pain009001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Pain009001.DateAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|Tp|ISO20022.Pain009001.DateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Pain009001.DatePeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Pain009001.DateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Type ISO20022.Pain009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtInitnReq|ISO20022.Pain009001.MandateInitiationRequestV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtInitnReq))|

---

## Value ISO20022.Pain009001.DocumentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Pain009001.DocumentType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Pain009001.DocumentType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Pain009001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Pain009001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Pain009001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Enum ISO20022.Pain009001.Frequency10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QURT|Int32||XmlEnum("""QURT""")|1|
||MIAN|Int32||XmlEnum("""MIAN""")|2|
||RATE|Int32||XmlEnum("""RATE""")|3|
||YEAR|Int32||XmlEnum("""YEAR""")|4|
||NEVR|Int32||XmlEnum("""NEVR""")|5|

---

## Value ISO20022.Pain009001.Frequency36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|ISO20022.Pain009001.FrequencyAndMoment1||XmlElement()||
|+|Prd|ISO20022.Pain009001.FrequencyPeriod1||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtInTm),validElement(Prd),validChoice(PtInTm,Prd,Tp))|

---

## Value ISO20022.Pain009001.Frequency37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Pain009001.Frequency6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTN|Int32||XmlEnum("""FRTN""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||ADHO|Int32||XmlEnum("""ADHO""")|3|
||DAIL|Int32||XmlEnum("""DAIL""")|4|
||WEEK|Int32||XmlEnum("""WEEK""")|5|
||MIAN|Int32||XmlEnum("""MIAN""")|6|
||QURT|Int32||XmlEnum("""QURT""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Pain009001.FrequencyAndMoment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtInTm""",PtInTm,"""[0-9]{2}"""))|

---

## Value ISO20022.Pain009001.FrequencyPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CntPerPrd|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Pain009001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Pain009001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Pain009001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Pain009001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Pain009001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Pain009001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Pain009001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Pain009001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Pain009001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Pain009001.GroupHeader110


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdAgt|ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InitgPty|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|Authstn|global::System.Collections.Generic.List<ISO20022.Pain009001.Authorisation1Choice>||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdAgt),validElement(InstgAgt),validElement(InitgPty),validList("""Authstn""",Authstn),validListMax("""Authstn""",Authstn,2),validElement(Authstn))|

---

## Value ISO20022.Pain009001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.Mandate23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Pain009001.SupplementaryData1>||XmlElement()||
|+|RfrdDoc|global::System.Collections.Generic.List<ISO20022.Pain009001.ReferredMandateDocument2>||XmlElement()||
|+|MndtRef|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|DbtrAgt|ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Pain009001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|UltmtCdtr|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|CdtrAgt|ISO20022.Pain009001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CdtrAcct|ISO20022.Pain009001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|CdtrSchmeId|ISO20022.Pain009001.PartyIdentification272||XmlElement()||
|+|Rsn|ISO20022.Pain009001.MandateSetupReason1Choice||XmlElement()||
|+|Adjstmnt|ISO20022.Pain009001.MandateAdjustment1||XmlElement()||
|+|MaxAmt|ISO20022.Pain009001.ActiveCurrencyAndAmount||XmlElement()||
|+|ColltnAmt|ISO20022.Pain009001.ActiveCurrencyAndAmount||XmlElement()||
|+|FrstColltnAmt|ISO20022.Pain009001.ActiveCurrencyAndAmount||XmlElement()||
|+|TrckgInd|String||XmlElement()||
|+|Ocrncs|ISO20022.Pain009001.MandateOccurrences5||XmlElement()||
|+|Tp|ISO20022.Pain009001.MandateTypeInformation2||XmlElement()||
|+|Authntcn|ISO20022.Pain009001.MandateAuthentication1||XmlElement()||
|+|MndtReqId|String||XmlElement()||
|+|MndtId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""RfrdDoc""",RfrdDoc),validElement(RfrdDoc),validElement(UltmtDbtr),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(UltmtCdtr),validElement(CdtrAgt),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrSchmeId),validElement(Rsn),validElement(Adjstmnt),validElement(MaxAmt),validElement(ColltnAmt),validElement(FrstColltnAmt),validElement(Ocrncs),validElement(Tp),validElement(Authntcn))|

---

## Value ISO20022.Pain009001.MandateAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Pain009001.ActiveCurrencyAndAmount||XmlElement()||
|+|Ctgy|ISO20022.Pain009001.Frequency37Choice||XmlElement()||
|+|DtAdjstmntRuleInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Ctgy))|

---

## Value ISO20022.Pain009001.MandateAuthentication1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chanl|ISO20022.Pain009001.AuthenticationChannel1Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|MsgAuthntcnCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Chanl))|

---

## Value ISO20022.Pain009001.MandateClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Pain009001.MandateClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||USGB|Int32||XmlEnum("""USGB""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Aspect ISO20022.Pain009001.MandateInitiationRequestV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Pain009001.SupplementaryData1>||XmlElement()||
|+|Mndt|global::System.Collections.Generic.List<ISO20022.Pain009001.Mandate23>||XmlElement()||
|+|GrpHdr|ISO20022.Pain009001.GroupHeader110||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mndt""",Mndt),validList("""Mndt""",Mndt),validElement(Mndt),validElement(GrpHdr))|

---

## Value ISO20022.Pain009001.MandateOccurrences5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FnlColltnDt|DateTime||XmlElement()||
|+|FrstColltnDt|DateTime||XmlElement()||
|+|Drtn|ISO20022.Pain009001.DatePeriod3||XmlElement()||
|+|Frqcy|ISO20022.Pain009001.Frequency36Choice||XmlElement()||
|+|SeqTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Drtn),validElement(Frqcy))|

---

## Value ISO20022.Pain009001.MandateSetupReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.MandateTypeInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clssfctn|ISO20022.Pain009001.MandateClassification1Choice||XmlElement()||
|+|CtgyPurp|ISO20022.Pain009001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Pain009001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|ISO20022.Pain009001.ServiceLevel8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clssfctn),validElement(CtgyPurp),validElement(LclInstrm),validElement(SvcLvl))|

---

## Enum ISO20022.Pain009001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Pain009001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Pain009001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Pain009001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Pain009001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Pain009001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Pain009001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Pain009001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Pain009001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Pain009001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Pain009001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Pain009001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Pain009001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Pain009001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Pain009001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.PostalAddress27


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
|+|AdrTp|ISO20022.Pain009001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Pain009001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Pain009001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Pain009001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Pain009001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.ReferredMandateDocument2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|ISO20022.Pain009001.DateAndType1||XmlElement()||
|+|CdtrRef|String||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Pain009001.DocumentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltdDt),validElement(Tp))|

---

## Enum ISO20022.Pain009001.SequenceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOFF|Int32||XmlEnum("""OOFF""")|1|
||RCUR|Int32||XmlEnum("""RCUR""")|2|

---

## Value ISO20022.Pain009001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Pain009001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Pain009001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Pain009001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

