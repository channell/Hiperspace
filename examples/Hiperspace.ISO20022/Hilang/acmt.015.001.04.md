# acmt.015.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt015001.AccountContract2 {
        + UrgcyFlg  : String
        + TrgtClsgDt  : DateTime
        + TrgtGoLiveDt  : DateTime
    }
    class ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Acmt015001.SupplementaryData1~
        + DgtlSgntr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.PartyAndSignature4~
        + AddtlMsgInf  : ISO20022.Acmt015001.AdditionalInformation5
        + Org  : ISO20022.Acmt015001.OrganisationModification3
        + AcctSvcrId  : ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8
        + Acct  : ISO20022.Acmt015001.CustomerAccountModification1
        + UndrlygMstrAgrmt  : ISO20022.Acmt015001.ContractDocument1
        + CtrctDts  : ISO20022.Acmt015001.AccountContract2
        + Fr  : ISO20022.Acmt015001.OrganisationIdentification39
        + Refs  : ISO20022.Acmt015001.References4
    }
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.SupplementaryData1
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.PartyAndSignature4
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.AdditionalInformation5
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.OrganisationModification3
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.CustomerAccountModification1
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.ContractDocument1
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.AccountContract2
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.OrganisationIdentification39
    ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04 *-- ISO20022.Acmt015001.References4
    class ISO20022.Acmt015001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt015001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt015001.AccountIdentification4Choice *-- ISO20022.Acmt015001.GenericAccountIdentification1
    class ISO20022.Acmt015001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.AccountStatus3Code {
        FORM = 1
        DELE = 2
        DISA = 3
        ENAB = 4
    }
    class ISO20022.Acmt015001.AccountStatusModification1 {
        + Sts  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.AdditionalInformation5 {
        + Inf  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Acmt015001.AddressModification3 {
        + Adr  : ISO20022.Acmt015001.PostalAddress27
        + ModCd  : String
    }
    ISO20022.Acmt015001.AddressModification3 *-- ISO20022.Acmt015001.PostalAddress27
    class ISO20022.Acmt015001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt015001.AddressType3Choice {
        + Prtry  : ISO20022.Acmt015001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Acmt015001.AddressType3Choice *-- ISO20022.Acmt015001.GenericIdentification30
    class ISO20022.Acmt015001.AmountModification1 {
        + Amt  : Decimal
        + ModCd  : String
    }
    class ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Acmt015001.BranchData5
        + FinInstnId  : ISO20022.Acmt015001.FinancialInstitutionIdentification23
    }
    ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt015001.BranchData5
    ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt015001.FinancialInstitutionIdentification23
    class ISO20022.Acmt015001.BranchData5 {
        + PstlAdr  : ISO20022.Acmt015001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Acmt015001.BranchData5 *-- ISO20022.Acmt015001.PostalAddress27
    class ISO20022.Acmt015001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Acmt015001.ClearingSystemIdentification2Choice
    }
    ISO20022.Acmt015001.ClearingSystemMemberIdentification2 *-- ISO20022.Acmt015001.ClearingSystemIdentification2Choice
    class ISO20022.Acmt015001.CodeOrProprietary1Choice {
        + Prtry  : ISO20022.Acmt015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Acmt015001.CodeOrProprietary1Choice *-- ISO20022.Acmt015001.GenericIdentification13
    class ISO20022.Acmt015001.CommunicationFormat1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.CommunicationMethod2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.CommunicationMethod2Code {
        POST = 1
        ONLI = 2
        FILE = 3
        FAXI = 4
        EMAL = 5
    }
    class ISO20022.Acmt015001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.OtherContact1~
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
    ISO20022.Acmt015001.Contact13 *-- ISO20022.Acmt015001.OtherContact1
    class ISO20022.Acmt015001.ContractDocument1 {
        + Vrsn  : String
        + SgnOffDt  : DateTime
        + Ref  : String
    }
    class ISO20022.Acmt015001.CustomerAccountModification1 {
        + Rstrctn  : global::System.Collections.Generic.List~ISO20022.Acmt015001.RestrictionModification1~
        + ClsgDt  : ISO20022.Acmt015001.DateModification1
        + StmtFrqcyAndFrmt  : global::System.Collections.Generic.List~ISO20022.Acmt015001.StatementFrequencyAndFormModification1~
        + ClngNtfctnAmt  : ISO20022.Acmt015001.AmountModification1
        + FlrNtfctnAmt  : ISO20022.Acmt015001.AmountModification1
        + AcctPurp  : ISO20022.Acmt015001.PurposeModification1
        + AvrgBal  : ISO20022.Acmt015001.AmountModification1
        + MnthlyTxNb  : ISO20022.Acmt015001.NumberModification1
        + MnthlyRcvdVal  : ISO20022.Acmt015001.AmountModification1
        + MnthlyPmtVal  : ISO20022.Acmt015001.AmountModification1
        + Ccy  : String
        + Tp  : ISO20022.Acmt015001.TypeModification1
        + Sts  : ISO20022.Acmt015001.AccountStatusModification1
        + Nm  : ISO20022.Acmt015001.NameModification1
        + Id  : global::System.Collections.Generic.List~ISO20022.Acmt015001.AccountIdentification4Choice~
    }
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.RestrictionModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.DateModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.StatementFrequencyAndFormModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AmountModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AmountModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.PurposeModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AmountModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.NumberModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AmountModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AmountModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.TypeModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AccountStatusModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.NameModification1
    ISO20022.Acmt015001.CustomerAccountModification1 *-- ISO20022.Acmt015001.AccountIdentification4Choice
    class ISO20022.Acmt015001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Acmt015001.DateModification1 {
        + Dt  : DateTime
        + ModCd  : String
    }
    class ISO20022.Acmt015001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Acmt015001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Acmt015001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Acmt015001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Acmt015001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt015001.GenericFinancialIdentification1
    ISO20022.Acmt015001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt015001.PostalAddress27
    ISO20022.Acmt015001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt015001.ClearingSystemMemberIdentification2
    class ISO20022.Acmt015001.Frequency7Code {
        INDA = 1
        WEEK = 2
        MOVE = 3
        TEND = 4
        MIAN = 5
        QURT = 6
        MNTH = 7
        DAIL = 8
        YEAR = 9
    }
    class ISO20022.Acmt015001.FullLegalNameModification1 {
        + FullLglNm  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt015001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt015001.GenericAccountIdentification1 *-- ISO20022.Acmt015001.AccountSchemeName1Choice
    class ISO20022.Acmt015001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt015001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt015001.GenericFinancialIdentification1 *-- ISO20022.Acmt015001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Acmt015001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Acmt015001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt015001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt015001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt015001.GenericOrganisationIdentification3 *-- ISO20022.Acmt015001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Acmt015001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt015001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt015001.GenericPersonIdentification2 *-- ISO20022.Acmt015001.PersonIdentificationSchemeName1Choice
    class ISO20022.Acmt015001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt015001.Modification1Code {
        ADDD = 1
        DELE = 2
        MODI = 3
        NOCH = 4
    }
    class ISO20022.Acmt015001.NameModification1 {
        + Nm  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Acmt015001.NumberModification1 {
        + Nb  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Acmt015001.OrganisationIdentification39 *-- ISO20022.Acmt015001.GenericOrganisationIdentification3
    class ISO20022.Acmt015001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.OrganisationModification3 {
        + LglRprtv  : global::System.Collections.Generic.List~ISO20022.Acmt015001.PartyModification3~
        + Sndr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.PartyModification3~
        + MainMndtHldr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.PartyModification3~
        + TrsrMgr  : ISO20022.Acmt015001.PartyModification3
        + RprtvOffcr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.PartyModification3~
        + OrgId  : ISO20022.Acmt015001.OrganisationIdentification39
        + BllgAdr  : ISO20022.Acmt015001.AddressModification3
        + LglAdr  : ISO20022.Acmt015001.AddressModification3
        + BizAdr  : ISO20022.Acmt015001.AddressModification3
        + OprlAdr  : ISO20022.Acmt015001.AddressModification3
        + RegnDt  : DateTime
        + CtryOfOpr  : String
        + TradgNm  : ISO20022.Acmt015001.TradingNameModification1
        + FullLglNm  : ISO20022.Acmt015001.FullLegalNameModification1
    }
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.PartyModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.PartyModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.PartyModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.PartyModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.PartyModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.OrganisationIdentification39
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.AddressModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.AddressModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.AddressModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.AddressModification3
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.TradingNameModification1
    ISO20022.Acmt015001.OrganisationModification3 *-- ISO20022.Acmt015001.FullLegalNameModification1
    class ISO20022.Acmt015001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Acmt015001.Party52Choice {
        + PrvtId  : ISO20022.Acmt015001.PersonIdentification18
        + OrgId  : ISO20022.Acmt015001.OrganisationIdentification39
    }
    ISO20022.Acmt015001.Party52Choice *-- ISO20022.Acmt015001.PersonIdentification18
    ISO20022.Acmt015001.Party52Choice *-- ISO20022.Acmt015001.OrganisationIdentification39
    class ISO20022.Acmt015001.PartyAndSignature4 {
        + Sgntr  : ISO20022.Acmt015001.SkipPayload
        + Pty  : ISO20022.Acmt015001.PartyIdentification272
    }
    ISO20022.Acmt015001.PartyAndSignature4 *-- ISO20022.Acmt015001.SkipPayload
    ISO20022.Acmt015001.PartyAndSignature4 *-- ISO20022.Acmt015001.PartyIdentification272
    class ISO20022.Acmt015001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Acmt015001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt015001.Party52Choice
        + PstlAdr  : ISO20022.Acmt015001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt015001.PartyIdentification272 *-- ISO20022.Acmt015001.Contact13
    ISO20022.Acmt015001.PartyIdentification272 *-- ISO20022.Acmt015001.Party52Choice
    ISO20022.Acmt015001.PartyIdentification272 *-- ISO20022.Acmt015001.PostalAddress27
    class ISO20022.Acmt015001.PartyIdentification274 {
        + CtctDtls  : ISO20022.Acmt015001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt015001.PersonIdentification18
        + PstlAdr  : ISO20022.Acmt015001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt015001.PartyIdentification274 *-- ISO20022.Acmt015001.Contact13
    ISO20022.Acmt015001.PartyIdentification274 *-- ISO20022.Acmt015001.PersonIdentification18
    ISO20022.Acmt015001.PartyIdentification274 *-- ISO20022.Acmt015001.PostalAddress27
    class ISO20022.Acmt015001.PartyModification3 {
        + PtyId  : ISO20022.Acmt015001.PartyIdentification274
        + ModCd  : String
    }
    ISO20022.Acmt015001.PartyModification3 *-- ISO20022.Acmt015001.PartyIdentification274
    class ISO20022.Acmt015001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt015001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Acmt015001.DateAndPlaceOfBirth1
    }
    ISO20022.Acmt015001.PersonIdentification18 *-- ISO20022.Acmt015001.GenericPersonIdentification2
    ISO20022.Acmt015001.PersonIdentification18 *-- ISO20022.Acmt015001.DateAndPlaceOfBirth1
    class ISO20022.Acmt015001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt015001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Acmt015001.AddressType3Choice
    }
    ISO20022.Acmt015001.PostalAddress27 *-- ISO20022.Acmt015001.AddressType3Choice
    class ISO20022.Acmt015001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Acmt015001.PurposeModification1 {
        + Purp  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.References4 {
        + AttchdDocNm  : global::System.Collections.Generic.List~String~
        + PrcId  : ISO20022.Acmt015001.MessageIdentification1
        + MsgId  : ISO20022.Acmt015001.MessageIdentification1
    }
    ISO20022.Acmt015001.References4 *-- ISO20022.Acmt015001.MessageIdentification1
    ISO20022.Acmt015001.References4 *-- ISO20022.Acmt015001.MessageIdentification1
    class ISO20022.Acmt015001.Restriction1 {
        + VldUntil  : DateTime
        + VldFr  : DateTime
        + RstrctnTp  : ISO20022.Acmt015001.CodeOrProprietary1Choice
    }
    ISO20022.Acmt015001.Restriction1 *-- ISO20022.Acmt015001.CodeOrProprietary1Choice
    class ISO20022.Acmt015001.RestrictionModification1 {
        + Rstrctn  : ISO20022.Acmt015001.Restriction1
        + ModCd  : String
    }
    ISO20022.Acmt015001.RestrictionModification1 *-- ISO20022.Acmt015001.Restriction1
    class ISO20022.Acmt015001.SkipPayload {
    }
    class ISO20022.Acmt015001.StatementFrequencyAndForm1 {
        + Frmt  : ISO20022.Acmt015001.CommunicationFormat1Choice
        + DlvryAdr  : String
        + ComMtd  : ISO20022.Acmt015001.CommunicationMethod2Choice
        + Frqcy  : String
    }
    ISO20022.Acmt015001.StatementFrequencyAndForm1 *-- ISO20022.Acmt015001.CommunicationFormat1Choice
    ISO20022.Acmt015001.StatementFrequencyAndForm1 *-- ISO20022.Acmt015001.CommunicationMethod2Choice
    class ISO20022.Acmt015001.StatementFrequencyAndFormModification1 {
        + StmtFrqcyAndForm  : ISO20022.Acmt015001.StatementFrequencyAndForm1
        + ModCd  : String
    }
    ISO20022.Acmt015001.StatementFrequencyAndFormModification1 *-- ISO20022.Acmt015001.StatementFrequencyAndForm1
    class ISO20022.Acmt015001.SupplementaryData1 {
        + Envlp  : ISO20022.Acmt015001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Acmt015001.SupplementaryData1 *-- ISO20022.Acmt015001.SupplementaryDataEnvelope1
    class ISO20022.Acmt015001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Acmt015001.TradingNameModification1 {
        + TradgNm  : String
        + ModCd  : String
    }
    class ISO20022.Acmt015001.TypeModification1 {
        + Tp  : ISO20022.Acmt015001.CashAccountType2Choice
        + ModCd  : String
    }
    ISO20022.Acmt015001.TypeModification1 *-- ISO20022.Acmt015001.CashAccountType2Choice
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

## Value ISO20022.Acmt015001.AccountContract2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UrgcyFlg|String||XmlElement()||
|+|TrgtClsgDt|DateTime||XmlElement()||
|+|TrgtGoLiveDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Acmt015001.SupplementaryData1>||XmlElement()||
|+|DgtlSgntr|global::System.Collections.Generic.List<ISO20022.Acmt015001.PartyAndSignature4>||XmlElement()||
|+|AddtlMsgInf|ISO20022.Acmt015001.AdditionalInformation5||XmlElement()||
|+|Org|ISO20022.Acmt015001.OrganisationModification3||XmlElement()||
|+|AcctSvcrId|ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Acct|ISO20022.Acmt015001.CustomerAccountModification1||XmlElement()||
|+|UndrlygMstrAgrmt|ISO20022.Acmt015001.ContractDocument1||XmlElement()||
|+|CtrctDts|ISO20022.Acmt015001.AccountContract2||XmlElement()||
|+|Fr|ISO20022.Acmt015001.OrganisationIdentification39||XmlElement()||
|+|Refs|ISO20022.Acmt015001.References4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(AddtlMsgInf),validElement(Org),validElement(AcctSvcrId),validElement(Acct),validElement(UndrlygMstrAgrmt),validElement(CtrctDts),validElement(Fr),validElement(Refs))|

---

## Value ISO20022.Acmt015001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt015001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Acmt015001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt015001.AccountStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FORM|Int32||XmlEnum("""FORM""")|1|
||DELE|Int32||XmlEnum("""DELE""")|2|
||DISA|Int32||XmlEnum("""DISA""")|3|
||ENAB|Int32||XmlEnum("""ENAB""")|4|

---

## Value ISO20022.Acmt015001.AccountStatusModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sts|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.AdditionalInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Inf""",Inf))|

---

## Value ISO20022.Acmt015001.AddressModification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Acmt015001.PostalAddress27||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Acmt015001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt015001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt015001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.AmountModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Decimal||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Acmt015001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Acmt015001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Acmt015001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt015001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Acmt015001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Acmt015001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Acmt015001.CodeOrProprietary1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.CommunicationFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.CommunicationMethod2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt015001.CommunicationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POST|Int32||XmlEnum("""POST""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||FILE|Int32||XmlEnum("""FILE""")|3|
||FAXI|Int32||XmlEnum("""FAXI""")|4|
||EMAL|Int32||XmlEnum("""EMAL""")|5|

---

## Value ISO20022.Acmt015001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt015001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Acmt015001.ContractDocument1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|SgnOffDt|DateTime||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.CustomerAccountModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rstrctn|global::System.Collections.Generic.List<ISO20022.Acmt015001.RestrictionModification1>||XmlElement()||
|+|ClsgDt|ISO20022.Acmt015001.DateModification1||XmlElement()||
|+|StmtFrqcyAndFrmt|global::System.Collections.Generic.List<ISO20022.Acmt015001.StatementFrequencyAndFormModification1>||XmlElement()||
|+|ClngNtfctnAmt|ISO20022.Acmt015001.AmountModification1||XmlElement()||
|+|FlrNtfctnAmt|ISO20022.Acmt015001.AmountModification1||XmlElement()||
|+|AcctPurp|ISO20022.Acmt015001.PurposeModification1||XmlElement()||
|+|AvrgBal|ISO20022.Acmt015001.AmountModification1||XmlElement()||
|+|MnthlyTxNb|ISO20022.Acmt015001.NumberModification1||XmlElement()||
|+|MnthlyRcvdVal|ISO20022.Acmt015001.AmountModification1||XmlElement()||
|+|MnthlyPmtVal|ISO20022.Acmt015001.AmountModification1||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt015001.TypeModification1||XmlElement()||
|+|Sts|ISO20022.Acmt015001.AccountStatusModification1||XmlElement()||
|+|Nm|ISO20022.Acmt015001.NameModification1||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Acmt015001.AccountIdentification4Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rstrctn""",Rstrctn),validElement(Rstrctn),validElement(ClsgDt),validList("""StmtFrqcyAndFrmt""",StmtFrqcyAndFrmt),validElement(StmtFrqcyAndFrmt),validElement(ClngNtfctnAmt),validElement(FlrNtfctnAmt),validElement(AcctPurp),validElement(AvrgBal),validElement(MnthlyTxNb),validElement(MnthlyRcvdVal),validElement(MnthlyPmtVal),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Sts),validElement(Nm),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Acmt015001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Acmt015001.DateModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Acmt015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctExcldMndtMntncReq|ISO20022.Acmt015001.AccountExcludedMandateMaintenanceRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctExcldMndtMntncReq))|

---

## Value ISO20022.Acmt015001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt015001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Acmt015001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt015001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Enum ISO20022.Acmt015001.Frequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDA|Int32||XmlEnum("""INDA""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MOVE|Int32||XmlEnum("""MOVE""")|3|
||TEND|Int32||XmlEnum("""TEND""")|4|
||MIAN|Int32||XmlEnum("""MIAN""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||DAIL|Int32||XmlEnum("""DAIL""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Acmt015001.FullLegalNameModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FullLglNm|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt015001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt015001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt015001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt015001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Acmt015001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt015001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt015001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt015001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt015001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt015001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt015001.Modification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADDD|Int32||XmlEnum("""ADDD""")|1|
||DELE|Int32||XmlEnum("""DELE""")|2|
||MODI|Int32||XmlEnum("""MODI""")|3|
||NOCH|Int32||XmlEnum("""NOCH""")|4|

---

## Value ISO20022.Acmt015001.NameModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt015001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Acmt015001.NumberModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Acmt015001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt015001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt015001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.OrganisationModification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglRprtv|global::System.Collections.Generic.List<ISO20022.Acmt015001.PartyModification3>||XmlElement()||
|+|Sndr|global::System.Collections.Generic.List<ISO20022.Acmt015001.PartyModification3>||XmlElement()||
|+|MainMndtHldr|global::System.Collections.Generic.List<ISO20022.Acmt015001.PartyModification3>||XmlElement()||
|+|TrsrMgr|ISO20022.Acmt015001.PartyModification3||XmlElement()||
|+|RprtvOffcr|global::System.Collections.Generic.List<ISO20022.Acmt015001.PartyModification3>||XmlElement()||
|+|OrgId|ISO20022.Acmt015001.OrganisationIdentification39||XmlElement()||
|+|BllgAdr|ISO20022.Acmt015001.AddressModification3||XmlElement()||
|+|LglAdr|ISO20022.Acmt015001.AddressModification3||XmlElement()||
|+|BizAdr|ISO20022.Acmt015001.AddressModification3||XmlElement()||
|+|OprlAdr|ISO20022.Acmt015001.AddressModification3||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|CtryOfOpr|String||XmlElement()||
|+|TradgNm|ISO20022.Acmt015001.TradingNameModification1||XmlElement()||
|+|FullLglNm|ISO20022.Acmt015001.FullLegalNameModification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LglRprtv""",LglRprtv),validElement(LglRprtv),validList("""Sndr""",Sndr),validElement(Sndr),validList("""MainMndtHldr""",MainMndtHldr),validElement(MainMndtHldr),validElement(TrsrMgr),validList("""RprtvOffcr""",RprtvOffcr),validElement(RprtvOffcr),validElement(OrgId),validElement(BllgAdr),validElement(LglAdr),validElement(BizAdr),validElement(OprlAdr),validPattern("""CtryOfOpr""",CtryOfOpr,"""[A-Z]{2,2}"""),validElement(TradgNm),validElement(FullLglNm))|

---

## Value ISO20022.Acmt015001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Acmt015001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Acmt015001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Acmt015001.PartyAndSignature4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Acmt015001.SkipPayload||XmlElement()||
|+|Pty|ISO20022.Acmt015001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Acmt015001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt015001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt015001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Acmt015001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt015001.PartyIdentification274


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt015001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt015001.PersonIdentification18||XmlElement()||
|+|PstlAdr|ISO20022.Acmt015001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt015001.PartyModification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyId|ISO20022.Acmt015001.PartyIdentification274||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyId))|

---

## Value ISO20022.Acmt015001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt015001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Acmt015001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Acmt015001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt015001.PostalAddress27


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
|+|AdrTp|ISO20022.Acmt015001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt015001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Acmt015001.PurposeModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.References4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdDocNm|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrcId|ISO20022.Acmt015001.MessageIdentification1||XmlElement()||
|+|MsgId|ISO20022.Acmt015001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcId),validElement(MsgId))|

---

## Value ISO20022.Acmt015001.Restriction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldUntil|DateTime||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
|+|RstrctnTp|ISO20022.Acmt015001.CodeOrProprietary1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RstrctnTp))|

---

## Value ISO20022.Acmt015001.RestrictionModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rstrctn|ISO20022.Acmt015001.Restriction1||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rstrctn))|

---

## Value ISO20022.Acmt015001.SkipPayload


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.StatementFrequencyAndForm1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Frmt|ISO20022.Acmt015001.CommunicationFormat1Choice||XmlElement()||
|+|DlvryAdr|String||XmlElement()||
|+|ComMtd|ISO20022.Acmt015001.CommunicationMethod2Choice||XmlElement()||
|+|Frqcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Frmt),validElement(ComMtd))|

---

## Value ISO20022.Acmt015001.StatementFrequencyAndFormModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtFrqcyAndForm|ISO20022.Acmt015001.StatementFrequencyAndForm1||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtFrqcyAndForm))|

---

## Value ISO20022.Acmt015001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Acmt015001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Acmt015001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.TradingNameModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradgNm|String||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt015001.TypeModification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Acmt015001.CashAccountType2Choice||XmlElement()||
|+|ModCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

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

