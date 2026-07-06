# tsmt.053.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt053001.AccountIdentification3Choice {
        + PrtryAcct  : ISO20022.Tsmt053001.SimpleIdentificationInformation2
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Tsmt053001.AccountIdentification3Choice *-- ISO20022.Tsmt053001.SimpleIdentificationInformation2
    class ISO20022.Tsmt053001.AccountIdentification4Choice {
        + Othr  : ISO20022.Tsmt053001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Tsmt053001.AccountIdentification4Choice *-- ISO20022.Tsmt053001.GenericAccountIdentification1
    class ISO20022.Tsmt053001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt053001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Tsmt053001.Adjustment5 {
        + Amt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + Drctn  : String
    }
    ISO20022.Tsmt053001.Adjustment5 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.AdjustmentDirection1Code {
        SUBS = 1
        ADDD = 2
    }
    class ISO20022.Tsmt053001.Algorithm5Code {
        HS51 = 1
        HS38 = 2
        HS25 = 3
    }
    class ISO20022.Tsmt053001.AlgorithmAndDigest1 {
        + Dgst  : String
        + DgstAlgo  : String
    }
    class ISO20022.Tsmt053001.BinaryFile1 {
        + InclBinryObjct  : String
        + CharSet  : String
        + NcodgTp  : String
        + MIMETp  : String
    }
    class ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4 {
        + BrnchId  : ISO20022.Tsmt053001.BranchData2
        + FinInstnId  : ISO20022.Tsmt053001.FinancialInstitutionIdentification7
    }
    ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4 *-- ISO20022.Tsmt053001.BranchData2
    ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4 *-- ISO20022.Tsmt053001.FinancialInstitutionIdentification7
    class ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5 {
        + BrnchId  : ISO20022.Tsmt053001.BranchData2
        + FinInstnId  : ISO20022.Tsmt053001.FinancialInstitutionIdentification8
    }
    ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5 *-- ISO20022.Tsmt053001.BranchData2
    ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5 *-- ISO20022.Tsmt053001.FinancialInstitutionIdentification8
    class ISO20022.Tsmt053001.BranchData2 {
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress6
        + Nm  : String
        + Id  : String
    }
    ISO20022.Tsmt053001.BranchData2 *-- ISO20022.Tsmt053001.PostalAddress6
    class ISO20022.Tsmt053001.BusinessApplicationHeader1 {
        + Sgntr  : ISO20022.Tsmt053001.SignatureEnvelope
        + Prty  : String
        + PssblDplct  : String
        + CpyDplct  : String
        + CreDt  : DateTime
        + BizSvc  : String
        + MsgDefIdr  : String
        + BizMsgIdr  : String
        + To  : ISO20022.Tsmt053001.Party9Choice
        + Fr  : ISO20022.Tsmt053001.Party9Choice
        + CharSet  : String
    }
    ISO20022.Tsmt053001.BusinessApplicationHeader1 *-- ISO20022.Tsmt053001.SignatureEnvelope
    ISO20022.Tsmt053001.BusinessApplicationHeader1 *-- ISO20022.Tsmt053001.Party9Choice
    ISO20022.Tsmt053001.BusinessApplicationHeader1 *-- ISO20022.Tsmt053001.Party9Choice
    class ISO20022.Tsmt053001.BusinessLetter1 {
        + DgtlSgntr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1~
        + VldtnStsInf  : ISO20022.Tsmt053001.ValidationStatusInformation1
        + Ntce  : String
        + AddtlInf  : String
        + LglCntxt  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.GovernanceRules2~
        + GovngCtrct  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedDocumentInformation1~
        + AssoctdDoc  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedDocumentInformation1~
        + OthrPty  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + CpyRcpt  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + RspnRcpt  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + AuthstnUsr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + Sndr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + PmryRcpt  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedPartyIdentification1~
        + Orgtr  : ISO20022.Tsmt053001.QualifiedPartyIdentification1
        + InstrPrty  : String
        + CnttIdr  : global::System.Collections.Generic.List~String~
        + RltdMsg  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedDocumentInformation1~
        + RltdLttr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.QualifiedDocumentInformation1~
        + Dt  : DateTime
        + LttrIdr  : ISO20022.Tsmt053001.QualifiedDocumentInformation1
        + ApplCntxt  : String
    }
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.ValidationStatusInformation1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.GovernanceRules2
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedDocumentInformation1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedDocumentInformation1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedPartyIdentification1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedDocumentInformation1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedDocumentInformation1
    ISO20022.Tsmt053001.BusinessLetter1 *-- ISO20022.Tsmt053001.QualifiedDocumentInformation1
    class ISO20022.Tsmt053001.CashAccount16 {
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Tsmt053001.CashAccountType2
        + Id  : ISO20022.Tsmt053001.AccountIdentification4Choice
    }
    ISO20022.Tsmt053001.CashAccount16 *-- ISO20022.Tsmt053001.CashAccountType2
    ISO20022.Tsmt053001.CashAccount16 *-- ISO20022.Tsmt053001.AccountIdentification4Choice
    class ISO20022.Tsmt053001.CashAccount7 {
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Tsmt053001.CashAccountType2
        + Id  : ISO20022.Tsmt053001.AccountIdentification3Choice
    }
    ISO20022.Tsmt053001.CashAccount7 *-- ISO20022.Tsmt053001.CashAccountType2
    ISO20022.Tsmt053001.CashAccount7 *-- ISO20022.Tsmt053001.AccountIdentification3Choice
    class ISO20022.Tsmt053001.CashAccountType2 {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.CashAccountType4Code {
        ODFT = 1
        SLRY = 2
        LOAN = 3
        MOMA = 4
        NREX = 5
        MGLD = 6
        ONDP = 7
        SVGS = 8
        CACC = 9
        SACC = 10
        TRAS = 11
        CISH = 12
        TAXE = 13
        COMM = 14
        CHAR = 15
        CASH = 16
    }
    class ISO20022.Tsmt053001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Tsmt053001.ClearingSystemIdentification2Choice
    }
    ISO20022.Tsmt053001.ClearingSystemMemberIdentification2 *-- ISO20022.Tsmt053001.ClearingSystemIdentification2Choice
    class ISO20022.Tsmt053001.ContactDetails2 {
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsmt053001.Contacts3 {
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + Othr  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    class ISO20022.Tsmt053001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Tsmt053001.CountrySubdivision1Choice {
        + Prtry  : ISO20022.Tsmt053001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsmt053001.CountrySubdivision1Choice *-- ISO20022.Tsmt053001.GenericIdentification1
    class ISO20022.Tsmt053001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Tsmt053001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Tsmt053001.DateAndPlaceOfBirth {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Tsmt053001.EncapsulatedBusinessMessage1 {
        + Msg  : ISO20022.Tsmt053001.StrictPayload
        + Prtl  : String
        + Prfx  : String
        + Hdr  : ISO20022.Tsmt053001.BusinessApplicationHeader1
    }
    ISO20022.Tsmt053001.EncapsulatedBusinessMessage1 *-- ISO20022.Tsmt053001.StrictPayload
    ISO20022.Tsmt053001.EncapsulatedBusinessMessage1 *-- ISO20022.Tsmt053001.BusinessApplicationHeader1
    class ISO20022.Tsmt053001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.FinancialInstitutionIdentification7 {
        + Othr  : ISO20022.Tsmt053001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress6
        + Nm  : String
        + ClrSysMmbId  : ISO20022.Tsmt053001.ClearingSystemMemberIdentification2
        + BIC  : String
    }
    ISO20022.Tsmt053001.FinancialInstitutionIdentification7 *-- ISO20022.Tsmt053001.GenericFinancialIdentification1
    ISO20022.Tsmt053001.FinancialInstitutionIdentification7 *-- ISO20022.Tsmt053001.PostalAddress6
    ISO20022.Tsmt053001.FinancialInstitutionIdentification7 *-- ISO20022.Tsmt053001.ClearingSystemMemberIdentification2
    class ISO20022.Tsmt053001.FinancialInstitutionIdentification8 {
        + Othr  : ISO20022.Tsmt053001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress6
        + Nm  : String
        + ClrSysMmbId  : ISO20022.Tsmt053001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Tsmt053001.FinancialInstitutionIdentification8 *-- ISO20022.Tsmt053001.GenericFinancialIdentification1
    ISO20022.Tsmt053001.FinancialInstitutionIdentification8 *-- ISO20022.Tsmt053001.PostalAddress6
    ISO20022.Tsmt053001.FinancialInstitutionIdentification8 *-- ISO20022.Tsmt053001.ClearingSystemMemberIdentification2
    class ISO20022.Tsmt053001.FinancialItem1 {
        + PrtryDtls  : ISO20022.Tsmt053001.SupplementaryData1
        + FincgSts  : ISO20022.Tsmt053001.FinancingInformationAndStatus1
        + VldtnStsInf  : ISO20022.Tsmt053001.ValidationStatusInformation1
        + AssoctdDoc  : global::System.Collections.Generic.List~String~
        + AddtlInf  : String
        + InstlmtInf  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.Instalment2~
        + DueAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + TtlAmt  : ISO20022.Tsmt053001.InvoiceTotals1
        + CdtDbtInd  : String
        + FinDocRef  : global::System.Collections.Generic.List~String~
        + ItmCntxt  : ISO20022.Tsmt053001.FinancialItemParameters1
    }
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.SupplementaryData1
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.FinancingInformationAndStatus1
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.ValidationStatusInformation1
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.Instalment2
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.InvoiceTotals1
    ISO20022.Tsmt053001.FinancialItem1 *-- ISO20022.Tsmt053001.FinancialItemParameters1
    class ISO20022.Tsmt053001.FinancialItemParameters1 {
        + TradMkt  : ISO20022.Tsmt053001.TradeMarket1Choice
        + CdtAcct  : ISO20022.Tsmt053001.AccountIdentification4Choice
        + DbtAcct  : ISO20022.Tsmt053001.AccountIdentification4Choice
        + Ccy  : String
        + LglCntxt  : String
        + GovngCtrct  : global::System.Collections.Generic.List~String~
        + BuyrFinAgt  : String
        + SellrFinAgt  : String
        + Sellr  : String
        + Buyr  : String
        + Rcpt  : String
        + Issr  : String
        + LangCd  : String
        + DocPurp  : String
        + RltdItm  : global::System.Collections.Generic.List~String~
        + IsseDt  : DateTime
        + Idr  : String
    }
    ISO20022.Tsmt053001.FinancialItemParameters1 *-- ISO20022.Tsmt053001.TradeMarket1Choice
    ISO20022.Tsmt053001.FinancialItemParameters1 *-- ISO20022.Tsmt053001.AccountIdentification4Choice
    ISO20022.Tsmt053001.FinancialItemParameters1 *-- ISO20022.Tsmt053001.AccountIdentification4Choice
    class ISO20022.Tsmt053001.FinancingAllowedSummary1 {
        + FincgAcct  : ISO20022.Tsmt053001.CashAccount7
        + CdtAcct  : ISO20022.Tsmt053001.CashAccount7
        + FincgDtDtls  : ISO20022.Tsmt053001.FinancingDateDetails1
        + TtlFincdAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + ApldPctg  : Decimal
        + TtlAccptdItmsAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + FincdItmNb  : Decimal
    }
    ISO20022.Tsmt053001.FinancingAllowedSummary1 *-- ISO20022.Tsmt053001.CashAccount7
    ISO20022.Tsmt053001.FinancingAllowedSummary1 *-- ISO20022.Tsmt053001.CashAccount7
    ISO20022.Tsmt053001.FinancingAllowedSummary1 *-- ISO20022.Tsmt053001.FinancingDateDetails1
    ISO20022.Tsmt053001.FinancingAllowedSummary1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    ISO20022.Tsmt053001.FinancingAllowedSummary1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.FinancingDateDetails1 {
        + DbtDt  : DateTime
        + CdtDt  : DateTime
        + BookDt  : global::System.Collections.Generic.List~DateTime~
    }
    class ISO20022.Tsmt053001.FinancingInformationAndStatus1 {
        + InvcFincgDtls  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.InvoiceFinancingDetails1~
        + FincgAllwdSummry  : ISO20022.Tsmt053001.FinancingAllowedSummary1
    }
    ISO20022.Tsmt053001.FinancingInformationAndStatus1 *-- ISO20022.Tsmt053001.InvoiceFinancingDetails1
    ISO20022.Tsmt053001.FinancingInformationAndStatus1 *-- ISO20022.Tsmt053001.FinancingAllowedSummary1
    class ISO20022.Tsmt053001.FinancingRateOrAmountChoice {
        + Rate  : Decimal
        + Amt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsmt053001.FinancingRateOrAmountChoice *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.FinancingResult1 {
        + FincdAmt  : ISO20022.Tsmt053001.FinancingRateOrAmountChoice
        + AddtlStsRsnInf  : global::System.Collections.Generic.List~String~
        + StsRsn  : ISO20022.Tsmt053001.StatusReason4Choice
        + FincgReqSts  : String
    }
    ISO20022.Tsmt053001.FinancingResult1 *-- ISO20022.Tsmt053001.FinancingRateOrAmountChoice
    ISO20022.Tsmt053001.FinancingResult1 *-- ISO20022.Tsmt053001.StatusReason4Choice
    class ISO20022.Tsmt053001.FinancingStatusReason1Code {
        CA03 = 1
        NA01 = 2
        MI01 = 3
        ID03 = 4
        ID02 = 5
        ID01 = 6
        DT02 = 7
        BE11 = 8
        BE10 = 9
        BE09 = 10
        BE08 = 11
        AC06 = 12
        AC04 = 13
        AC01 = 14
        CA02 = 15
        CA01 = 16
    }
    class ISO20022.Tsmt053001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt053001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt053001.GenericAccountIdentification1 *-- ISO20022.Tsmt053001.AccountSchemeName1Choice
    class ISO20022.Tsmt053001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt053001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt053001.GenericFinancialIdentification1 *-- ISO20022.Tsmt053001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Tsmt053001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Tsmt053001.GenericIdentification20 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Tsmt053001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Tsmt053001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Tsmt053001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt053001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt053001.GenericOrganisationIdentification1 *-- ISO20022.Tsmt053001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Tsmt053001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Tsmt053001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Tsmt053001.GenericPersonIdentification1 *-- ISO20022.Tsmt053001.PersonIdentificationSchemeName1Choice
    class ISO20022.Tsmt053001.GovernanceIdentification1Choice {
        + Prtry  : ISO20022.Tsmt053001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Tsmt053001.GovernanceIdentification1Choice *-- ISO20022.Tsmt053001.GenericIdentification1
    class ISO20022.Tsmt053001.GovernanceIdentification1Code {
        URDG = 1
        UCPR = 2
        NONE = 3
        ISPR = 4
    }
    class ISO20022.Tsmt053001.GovernanceRules2 {
        + Jursdctn  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.Location1~
        + AplblLaw  : ISO20022.Tsmt053001.Location1
        + RuleId  : ISO20022.Tsmt053001.GovernanceIdentification1Choice
        + Id  : String
    }
    ISO20022.Tsmt053001.GovernanceRules2 *-- ISO20022.Tsmt053001.Location1
    ISO20022.Tsmt053001.GovernanceRules2 *-- ISO20022.Tsmt053001.Location1
    ISO20022.Tsmt053001.GovernanceRules2 *-- ISO20022.Tsmt053001.GovernanceIdentification1Choice
    class ISO20022.Tsmt053001.Instalment2 {
        + PmtInstrm  : ISO20022.Tsmt053001.PaymentMeans1
        + Amt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + PmtDueDt  : DateTime
        + SeqId  : String
    }
    ISO20022.Tsmt053001.Instalment2 *-- ISO20022.Tsmt053001.PaymentMeans1
    ISO20022.Tsmt053001.Instalment2 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.InstalmentFinancingInformation1 {
        + InstlmtFincgRslt  : ISO20022.Tsmt053001.FinancingResult1
        + InstlmtTtlAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + InstlmtSeqId  : String
    }
    ISO20022.Tsmt053001.InstalmentFinancingInformation1 *-- ISO20022.Tsmt053001.FinancingResult1
    ISO20022.Tsmt053001.InstalmentFinancingInformation1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.InvoiceFinancingDetails1 {
        + InstlmtFincgInf  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.InstalmentFinancingInformation1~
        + InvcFincgRslt  : ISO20022.Tsmt053001.FinancingResult1
        + Spplr  : ISO20022.Tsmt053001.PartyIdentification8
        + OrgnlInvcInf  : ISO20022.Tsmt053001.OriginalInvoiceInformation1
    }
    ISO20022.Tsmt053001.InvoiceFinancingDetails1 *-- ISO20022.Tsmt053001.InstalmentFinancingInformation1
    ISO20022.Tsmt053001.InvoiceFinancingDetails1 *-- ISO20022.Tsmt053001.FinancingResult1
    ISO20022.Tsmt053001.InvoiceFinancingDetails1 *-- ISO20022.Tsmt053001.PartyIdentification8
    ISO20022.Tsmt053001.InvoiceFinancingDetails1 *-- ISO20022.Tsmt053001.OriginalInvoiceInformation1
    class ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01 {
        + AttchdMsg  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.EncapsulatedBusinessMessage1~
        + CtrlSum  : Decimal
        + ItmCnt  : String
        + RcncltnCnt  : String
        + RcncltnList  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.ReconciliationList1~
        + Hdr  : ISO20022.Tsmt053001.BusinessLetter1
    }
    ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01 *-- ISO20022.Tsmt053001.EncapsulatedBusinessMessage1
    ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01 *-- ISO20022.Tsmt053001.ReconciliationList1
    ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01 *-- ISO20022.Tsmt053001.BusinessLetter1
    class ISO20022.Tsmt053001.InvoiceTotals1 {
        + PmtDueDt  : DateTime
        + TtlInvcAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + Adjstmnt  : ISO20022.Tsmt053001.Adjustment5
        + TtlTaxAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + TtlTaxblAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    }
    ISO20022.Tsmt053001.InvoiceTotals1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    ISO20022.Tsmt053001.InvoiceTotals1 *-- ISO20022.Tsmt053001.Adjustment5
    ISO20022.Tsmt053001.InvoiceTotals1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    ISO20022.Tsmt053001.InvoiceTotals1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.LegalOrganisation1 {
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Tsmt053001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.Location1 {
        + Txt  : global::System.Collections.Generic.List~String~
        + CtrySubDvsn  : ISO20022.Tsmt053001.CountrySubdivision1Choice
        + Ctry  : String
    }
    ISO20022.Tsmt053001.Location1 *-- ISO20022.Tsmt053001.CountrySubdivision1Choice
    class ISO20022.Tsmt053001.NameAndAddress5 {
        + Adr  : ISO20022.Tsmt053001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Tsmt053001.NameAndAddress5 *-- ISO20022.Tsmt053001.PostalAddress1
    class ISO20022.Tsmt053001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Tsmt053001.OrganisationIdentification2 {
        + PrtryId  : ISO20022.Tsmt053001.GenericIdentification3
        + TaxIdNb  : String
        + BkPtyId  : String
        + DUNS  : String
        + USCHU  : String
        + EANGLN  : String
        + BEI  : String
        + IBEI  : String
        + BIC  : String
    }
    ISO20022.Tsmt053001.OrganisationIdentification2 *-- ISO20022.Tsmt053001.GenericIdentification3
    class ISO20022.Tsmt053001.OrganisationIdentification6 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.GenericOrganisationIdentification1~
        + BIC  : String
    }
    ISO20022.Tsmt053001.OrganisationIdentification6 *-- ISO20022.Tsmt053001.GenericOrganisationIdentification1
    class ISO20022.Tsmt053001.OrganisationIdentification7 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.GenericOrganisationIdentification1~
        + AnyBIC  : String
    }
    ISO20022.Tsmt053001.OrganisationIdentification7 *-- ISO20022.Tsmt053001.GenericOrganisationIdentification1
    class ISO20022.Tsmt053001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.OriginalInvoiceInformation1 {
        + PmtDueDt  : DateTime
        + IsseDt  : DateTime
        + TtlInvcAmt  : ISO20022.Tsmt053001.ActiveCurrencyAndAmount
        + DocNb  : String
    }
    ISO20022.Tsmt053001.OriginalInvoiceInformation1 *-- ISO20022.Tsmt053001.ActiveCurrencyAndAmount
    class ISO20022.Tsmt053001.Party10Choice {
        + PrvtId  : ISO20022.Tsmt053001.PersonIdentification5
        + OrgId  : ISO20022.Tsmt053001.OrganisationIdentification7
    }
    ISO20022.Tsmt053001.Party10Choice *-- ISO20022.Tsmt053001.PersonIdentification5
    ISO20022.Tsmt053001.Party10Choice *-- ISO20022.Tsmt053001.OrganisationIdentification7
    class ISO20022.Tsmt053001.Party2Choice {
        + PrvtId  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.PersonIdentification3~
        + OrgId  : ISO20022.Tsmt053001.OrganisationIdentification2
    }
    ISO20022.Tsmt053001.Party2Choice *-- ISO20022.Tsmt053001.PersonIdentification3
    ISO20022.Tsmt053001.Party2Choice *-- ISO20022.Tsmt053001.OrganisationIdentification2
    class ISO20022.Tsmt053001.Party8Choice {
        + PrvtId  : ISO20022.Tsmt053001.PersonIdentification5
        + OrgId  : ISO20022.Tsmt053001.OrganisationIdentification6
    }
    ISO20022.Tsmt053001.Party8Choice *-- ISO20022.Tsmt053001.PersonIdentification5
    ISO20022.Tsmt053001.Party8Choice *-- ISO20022.Tsmt053001.OrganisationIdentification6
    class ISO20022.Tsmt053001.Party9Choice {
        + FIId  : ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5
        + OrgId  : ISO20022.Tsmt053001.PartyIdentification42
    }
    ISO20022.Tsmt053001.Party9Choice *-- ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5
    ISO20022.Tsmt053001.Party9Choice *-- ISO20022.Tsmt053001.PartyIdentification42
    class ISO20022.Tsmt053001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Tsmt053001.NameAndAddress5
        + PrtryId  : ISO20022.Tsmt053001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Tsmt053001.PartyIdentification2Choice *-- ISO20022.Tsmt053001.NameAndAddress5
    ISO20022.Tsmt053001.PartyIdentification2Choice *-- ISO20022.Tsmt053001.GenericIdentification1
    class ISO20022.Tsmt053001.PartyIdentification42 {
        + CtctDtls  : ISO20022.Tsmt053001.ContactDetails2
        + CtryOfRes  : String
        + Id  : ISO20022.Tsmt053001.Party10Choice
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress6
        + Nm  : String
    }
    ISO20022.Tsmt053001.PartyIdentification42 *-- ISO20022.Tsmt053001.ContactDetails2
    ISO20022.Tsmt053001.PartyIdentification42 *-- ISO20022.Tsmt053001.Party10Choice
    ISO20022.Tsmt053001.PartyIdentification42 *-- ISO20022.Tsmt053001.PostalAddress6
    class ISO20022.Tsmt053001.PartyIdentification45 {
        + CtctDtls  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.Contacts3~
        + CtryOfRes  : String
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress6
        + Nm  : String
        + Id  : ISO20022.Tsmt053001.Party8Choice
    }
    ISO20022.Tsmt053001.PartyIdentification45 *-- ISO20022.Tsmt053001.Contacts3
    ISO20022.Tsmt053001.PartyIdentification45 *-- ISO20022.Tsmt053001.PostalAddress6
    ISO20022.Tsmt053001.PartyIdentification45 *-- ISO20022.Tsmt053001.Party8Choice
    class ISO20022.Tsmt053001.PartyIdentification8 {
        + CtryOfRes  : String
        + Id  : ISO20022.Tsmt053001.Party2Choice
        + PstlAdr  : ISO20022.Tsmt053001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Tsmt053001.PartyIdentification8 *-- ISO20022.Tsmt053001.Party2Choice
    ISO20022.Tsmt053001.PartyIdentification8 *-- ISO20022.Tsmt053001.PostalAddress1
    class ISO20022.Tsmt053001.PaymentIdentification1 {
        + EndToEndId  : String
        + InstrId  : String
    }
    class ISO20022.Tsmt053001.PaymentMeans1 {
        + PyerFI  : ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4
        + PyerDbtrAcct  : ISO20022.Tsmt053001.CashAccount16
        + PyeeFI  : ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4
        + PyeeCdtrAcct  : ISO20022.Tsmt053001.CashAccount16
        + PmtMtdCd  : String
        + PmtTp  : ISO20022.Tsmt053001.PaymentTypeInformation19
    }
    ISO20022.Tsmt053001.PaymentMeans1 *-- ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4
    ISO20022.Tsmt053001.PaymentMeans1 *-- ISO20022.Tsmt053001.CashAccount16
    ISO20022.Tsmt053001.PaymentMeans1 *-- ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4
    ISO20022.Tsmt053001.PaymentMeans1 *-- ISO20022.Tsmt053001.CashAccount16
    ISO20022.Tsmt053001.PaymentMeans1 *-- ISO20022.Tsmt053001.PaymentTypeInformation19
    class ISO20022.Tsmt053001.PaymentMethod4Code {
        TRA = 1
        DD = 2
        TRF = 3
        CHK = 4
    }
    class ISO20022.Tsmt053001.PaymentPeriod1 {
        + NbOfDays  : Decimal
        + Cd  : String
    }
    class ISO20022.Tsmt053001.PaymentTerms6 {
        + PnltyPctRate  : Decimal
        + PnltyAmt  : ISO20022.Tsmt053001.CurrencyAndAmount
        + DscntPctRate  : Decimal
        + DscntAmt  : ISO20022.Tsmt053001.CurrencyAndAmount
        + BsisAmt  : ISO20022.Tsmt053001.CurrencyAndAmount
        + DrctDbtMndtId  : global::System.Collections.Generic.List~String~
        + PrtlPmtPct  : Decimal
        + Desc  : global::System.Collections.Generic.List~String~
        + PmtPrd  : ISO20022.Tsmt053001.PaymentPeriod1
        + DueDt  : DateTime
    }
    ISO20022.Tsmt053001.PaymentTerms6 *-- ISO20022.Tsmt053001.CurrencyAndAmount
    ISO20022.Tsmt053001.PaymentTerms6 *-- ISO20022.Tsmt053001.CurrencyAndAmount
    ISO20022.Tsmt053001.PaymentTerms6 *-- ISO20022.Tsmt053001.CurrencyAndAmount
    ISO20022.Tsmt053001.PaymentTerms6 *-- ISO20022.Tsmt053001.PaymentPeriod1
    class ISO20022.Tsmt053001.PaymentTime1Code {
        EMTR = 1
        EPRR = 2
        PRMR = 3
        IREC = 4
        PRMD = 5
        EPRD = 6
        EMTD = 7
        CASH = 8
    }
    class ISO20022.Tsmt053001.PaymentTypeInformation19 {
        + CtgyPurp  : ISO20022.Tsmt053001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Tsmt053001.LocalInstrument2Choice
        + SvcLvl  : ISO20022.Tsmt053001.ServiceLevel8Choice
        + InstrPrty  : String
    }
    ISO20022.Tsmt053001.PaymentTypeInformation19 *-- ISO20022.Tsmt053001.CategoryPurpose1Choice
    ISO20022.Tsmt053001.PaymentTypeInformation19 *-- ISO20022.Tsmt053001.LocalInstrument2Choice
    ISO20022.Tsmt053001.PaymentTypeInformation19 *-- ISO20022.Tsmt053001.ServiceLevel8Choice
    class ISO20022.Tsmt053001.PersonIdentification3 {
        + Issr  : String
        + OthrId  : ISO20022.Tsmt053001.GenericIdentification4
        + DtAndPlcOfBirth  : ISO20022.Tsmt053001.DateAndPlaceOfBirth
        + MplyrIdNb  : String
        + IdntyCardNb  : String
        + TaxIdNb  : String
        + PsptNb  : String
        + AlnRegnNb  : String
        + SclSctyNb  : String
        + CstmrNb  : String
        + DrvrsLicNb  : String
    }
    ISO20022.Tsmt053001.PersonIdentification3 *-- ISO20022.Tsmt053001.GenericIdentification4
    ISO20022.Tsmt053001.PersonIdentification3 *-- ISO20022.Tsmt053001.DateAndPlaceOfBirth
    class ISO20022.Tsmt053001.PersonIdentification5 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Tsmt053001.DateAndPlaceOfBirth
    }
    ISO20022.Tsmt053001.PersonIdentification5 *-- ISO20022.Tsmt053001.GenericPersonIdentification1
    ISO20022.Tsmt053001.PersonIdentification5 *-- ISO20022.Tsmt053001.DateAndPlaceOfBirth
    class ISO20022.Tsmt053001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Tsmt053001.PostalAddress6 {
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
    class ISO20022.Tsmt053001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Tsmt053001.Priority3Code {
        NORM = 1
        HIGH = 2
        URGT = 3
    }
    class ISO20022.Tsmt053001.QualifiedDocumentInformation1 {
        + AttchdFile  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.BinaryFile1~
        + URL  : String
        + DocTp  : String
        + Dgst  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.AlgorithmAndDigest1~
        + ElctrncOrgnl  : String
        + Vrsn  : String
        + Dt  : DateTime
        + ItmIdr  : String
        + ItmListIdr  : String
        + Issr  : String
        + Id  : String
    }
    ISO20022.Tsmt053001.QualifiedDocumentInformation1 *-- ISO20022.Tsmt053001.BinaryFile1
    ISO20022.Tsmt053001.QualifiedDocumentInformation1 *-- ISO20022.Tsmt053001.AlgorithmAndDigest1
    class ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1 {
        + Sgntr  : ISO20022.Tsmt053001.SignatureEnvelope
        + Pty  : String
    }
    ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1 *-- ISO20022.Tsmt053001.SignatureEnvelope
    class ISO20022.Tsmt053001.QualifiedPartyIdentification1 {
        + RoleDesc  : String
        + Role  : ISO20022.Tsmt053001.GenericIdentification1
        + ShrtId  : ISO20022.Tsmt053001.PartyIdentification2Choice
        + Pty  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1~
        + Id  : String
    }
    ISO20022.Tsmt053001.QualifiedPartyIdentification1 *-- ISO20022.Tsmt053001.GenericIdentification1
    ISO20022.Tsmt053001.QualifiedPartyIdentification1 *-- ISO20022.Tsmt053001.PartyIdentification2Choice
    ISO20022.Tsmt053001.QualifiedPartyIdentification1 *-- ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1
    class ISO20022.Tsmt053001.ReconciliationList1 {
        + VldtnStsInf  : ISO20022.Tsmt053001.ValidationStatusInformation1
        + AddtlInf  : String
        + AssoctdDoc  : global::System.Collections.Generic.List~String~
        + CtrlSum  : Decimal
        + ItmCnt  : String
        + Itm  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.FinancialItem1~
        + PmtAmt  : ISO20022.Tsmt053001.CurrencyAndAmount
        + PmtTerms  : ISO20022.Tsmt053001.PaymentTerms6
        + PmtDt  : DateTime
        + PmtMeans  : ISO20022.Tsmt053001.PaymentMeans1
        + PmtRef  : ISO20022.Tsmt053001.PaymentIdentification1
        + Params  : ISO20022.Tsmt053001.FinancialItemParameters1
        + Advsr  : String
        + Rcpt  : String
        + RltdDoc  : global::System.Collections.Generic.List~String~
        + Dt  : DateTime
    }
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.ValidationStatusInformation1
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.FinancialItem1
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.CurrencyAndAmount
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.PaymentTerms6
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.PaymentMeans1
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.PaymentIdentification1
    ISO20022.Tsmt053001.ReconciliationList1 *-- ISO20022.Tsmt053001.FinancialItemParameters1
    class ISO20022.Tsmt053001.RequestStatus1Code {
        NTFD = 1
        PDNG = 2
        FNCD = 3
    }
    class ISO20022.Tsmt053001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.SignatureEnvelope {
    }
    class ISO20022.Tsmt053001.SimpleIdentificationInformation2 {
        + Id  : String
    }
    class ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1 {
        + RltvIdr  : global::System.Collections.Generic.List~String~
        + BasePty  : ISO20022.Tsmt053001.TradeParty1
    }
    ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1 *-- ISO20022.Tsmt053001.TradeParty1
    class ISO20022.Tsmt053001.StatusReason4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Tsmt053001.StrictPayload {
    }
    class ISO20022.Tsmt053001.SupplementaryData1 {
        + Envlp  : ISO20022.Tsmt053001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Tsmt053001.SupplementaryData1 *-- ISO20022.Tsmt053001.SupplementaryDataEnvelope1
    class ISO20022.Tsmt053001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Tsmt053001.TaxExemptReason1Code {
        EIOP = 1
        EIFP = 2
        RCIP = 3
        RCRF = 4
        RIAN = 5
        RIRA = 6
        E457X = 7
        E403B = 8
        SIRA = 9
        E401K = 10
        PFSP = 11
        KEOG = 12
        IRAR = 13
        IRAC = 14
        DECP = 15
        NFQP = 16
        NFPI = 17
        ECYE = 18
        EPRY = 19
        EMCY = 20
        EMPY = 21
        ASTR = 22
        PRYP = 23
        CUYP = 24
        IISA = 25
        SISA = 26
        MISA = 27
        MASA = 28
        NONE = 29
    }
    class ISO20022.Tsmt053001.TaxExemptionReasonFormatChoice {
        + Strd  : String
        + Ustrd  : String
    }
    class ISO20022.Tsmt053001.TaxParty3 {
        + TaxXmptnRsn  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.TaxExemptionReasonFormatChoice~
        + RegnId  : String
        + TaxTp  : String
        + TaxId  : String
    }
    ISO20022.Tsmt053001.TaxParty3 *-- ISO20022.Tsmt053001.TaxExemptionReasonFormatChoice
    class ISO20022.Tsmt053001.TechnicalValidationStatus1Code {
        RCER = 1
        RCCF = 2
    }
    class ISO20022.Tsmt053001.TradeMarket1Choice {
        + Prtry  : ISO20022.Tsmt053001.GenericIdentification20
        + Cd  : String
    }
    ISO20022.Tsmt053001.TradeMarket1Choice *-- ISO20022.Tsmt053001.GenericIdentification20
    class ISO20022.Tsmt053001.TradeParty1 {
        + TaxPty  : global::System.Collections.Generic.List~ISO20022.Tsmt053001.TaxParty3~
        + LglOrg  : ISO20022.Tsmt053001.LegalOrganisation1
        + PtyId  : ISO20022.Tsmt053001.PartyIdentification45
    }
    ISO20022.Tsmt053001.TradeParty1 *-- ISO20022.Tsmt053001.TaxParty3
    ISO20022.Tsmt053001.TradeParty1 *-- ISO20022.Tsmt053001.LegalOrganisation1
    ISO20022.Tsmt053001.TradeParty1 *-- ISO20022.Tsmt053001.PartyIdentification45
    class ISO20022.Tsmt053001.ValidationStatusInformation1 {
        + AddtlStsRsnInf  : global::System.Collections.Generic.List~String~
        + StsRsn  : ISO20022.Tsmt053001.StatusReason4Choice
        + Sts  : String
    }
    ISO20022.Tsmt053001.ValidationStatusInformation1 *-- ISO20022.Tsmt053001.StatusReason4Choice
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

## Value ISO20022.Tsmt053001.AccountIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryAcct|ISO20022.Tsmt053001.SimpleIdentificationInformation2||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[a-zA-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(PrtryAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Tsmt053001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Tsmt053001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Tsmt053001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Tsmt053001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Tsmt053001.Adjustment5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|Drctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Tsmt053001.AdjustmentDirection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBS|Int32||XmlEnum("""SUBS""")|1|
||ADDD|Int32||XmlEnum("""ADDD""")|2|

---

## Enum ISO20022.Tsmt053001.Algorithm5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS51|Int32||XmlEnum("""HS51""")|1|
||HS38|Int32||XmlEnum("""HS38""")|2|
||HS25|Int32||XmlEnum("""HS25""")|3|

---

## Value ISO20022.Tsmt053001.AlgorithmAndDigest1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dgst|String||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.BinaryFile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InclBinryObjct|String||XmlElement()||
|+|CharSet|String||XmlElement()||
|+|NcodgTp|String||XmlElement()||
|+|MIMETp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Tsmt053001.BranchData2||XmlElement()||
|+|FinInstnId|ISO20022.Tsmt053001.FinancialInstitutionIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Tsmt053001.BranchData2||XmlElement()||
|+|FinInstnId|ISO20022.Tsmt053001.FinancialInstitutionIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Tsmt053001.BranchData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Value ISO20022.Tsmt053001.BusinessApplicationHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Tsmt053001.SignatureEnvelope||XmlElement()||
|+|Prty|String||XmlElement()||
|+|PssblDplct|String||XmlElement()||
|+|CpyDplct|String||XmlElement()||
|+|CreDt|DateTime||XmlElement()||
|+|BizSvc|String||XmlElement()||
|+|MsgDefIdr|String||XmlElement()||
|+|BizMsgIdr|String||XmlElement()||
|+|To|ISO20022.Tsmt053001.Party9Choice||XmlElement()||
|+|Fr|ISO20022.Tsmt053001.Party9Choice||XmlElement()||
|+|CharSet|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validPattern("""CreDt""",CreDt,""".*Z"""),validElement(To),validElement(Fr))|

---

## Value ISO20022.Tsmt053001.BusinessLetter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlSgntr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1>||XmlElement()||
|+|VldtnStsInf|ISO20022.Tsmt053001.ValidationStatusInformation1||XmlElement()||
|+|Ntce|String||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|LglCntxt|global::System.Collections.Generic.List<ISO20022.Tsmt053001.GovernanceRules2>||XmlElement()||
|+|GovngCtrct|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedDocumentInformation1>||XmlElement()||
|+|AssoctdDoc|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedDocumentInformation1>||XmlElement()||
|+|OthrPty|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|CpyRcpt|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|RspnRcpt|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|AuthstnUsr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|Sndr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|PmryRcpt|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedPartyIdentification1>||XmlElement()||
|+|Orgtr|ISO20022.Tsmt053001.QualifiedPartyIdentification1||XmlElement()||
|+|InstrPrty|String||XmlElement()||
|+|CnttIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RltdMsg|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedDocumentInformation1>||XmlElement()||
|+|RltdLttr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.QualifiedDocumentInformation1>||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|LttrIdr|ISO20022.Tsmt053001.QualifiedDocumentInformation1||XmlElement()||
|+|ApplCntxt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(VldtnStsInf),validList("""LglCntxt""",LglCntxt),validElement(LglCntxt),validList("""GovngCtrct""",GovngCtrct),validElement(GovngCtrct),validList("""AssoctdDoc""",AssoctdDoc),validElement(AssoctdDoc),validList("""OthrPty""",OthrPty),validElement(OthrPty),validList("""CpyRcpt""",CpyRcpt),validElement(CpyRcpt),validList("""RspnRcpt""",RspnRcpt),validElement(RspnRcpt),validRequired("""AuthstnUsr""",AuthstnUsr),validList("""AuthstnUsr""",AuthstnUsr),validElement(AuthstnUsr),validList("""Sndr""",Sndr),validElement(Sndr),validRequired("""PmryRcpt""",PmryRcpt),validList("""PmryRcpt""",PmryRcpt),validElement(PmryRcpt),validElement(Orgtr),validList("""RltdMsg""",RltdMsg),validElement(RltdMsg),validList("""RltdLttr""",RltdLttr),validElement(RltdLttr),validElement(LttrIdr))|

---

## Value ISO20022.Tsmt053001.CashAccount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Tsmt053001.CashAccountType2||XmlElement()||
|+|Id|ISO20022.Tsmt053001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Tsmt053001.CashAccount7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Tsmt053001.CashAccountType2||XmlElement()||
|+|Id|ISO20022.Tsmt053001.AccountIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Tsmt053001.CashAccountType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsmt053001.CashAccountType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ODFT|Int32||XmlEnum("""ODFT""")|1|
||SLRY|Int32||XmlEnum("""SLRY""")|2|
||LOAN|Int32||XmlEnum("""LOAN""")|3|
||MOMA|Int32||XmlEnum("""MOMA""")|4|
||NREX|Int32||XmlEnum("""NREX""")|5|
||MGLD|Int32||XmlEnum("""MGLD""")|6|
||ONDP|Int32||XmlEnum("""ONDP""")|7|
||SVGS|Int32||XmlEnum("""SVGS""")|8|
||CACC|Int32||XmlEnum("""CACC""")|9|
||SACC|Int32||XmlEnum("""SACC""")|10|
||TRAS|Int32||XmlEnum("""TRAS""")|11|
||CISH|Int32||XmlEnum("""CISH""")|12|
||TAXE|Int32||XmlEnum("""TAXE""")|13|
||COMM|Int32||XmlEnum("""COMM""")|14|
||CHAR|Int32||XmlEnum("""CHAR""")|15|
||CASH|Int32||XmlEnum("""CASH""")|16|

---

## Value ISO20022.Tsmt053001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Tsmt053001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Tsmt053001.ContactDetails2


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

## Value ISO20022.Tsmt053001.Contacts3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|Othr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Tsmt053001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Value ISO20022.Tsmt053001.CountrySubdivision1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt053001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsmt053001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Tsmt053001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Tsmt053001.DateAndPlaceOfBirth


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Tsmt053001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvcPmtRcncltnAdvc|ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcPmtRcncltnAdvc))|

---

## Value ISO20022.Tsmt053001.EncapsulatedBusinessMessage1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Msg|ISO20022.Tsmt053001.StrictPayload||XmlElement()||
|+|Prtl|String||XmlElement()||
|+|Prfx|String||XmlElement()||
|+|Hdr|ISO20022.Tsmt053001.BusinessApplicationHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Msg),validElement(Hdr))|

---

## Value ISO20022.Tsmt053001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.FinancialInstitutionIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Tsmt053001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Tsmt053001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validElement(ClrSysMmbId),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt053001.FinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Tsmt053001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Tsmt053001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt053001.FinancialItem1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryDtls|ISO20022.Tsmt053001.SupplementaryData1||XmlElement()||
|+|FincgSts|ISO20022.Tsmt053001.FinancingInformationAndStatus1||XmlElement()||
|+|VldtnStsInf|ISO20022.Tsmt053001.ValidationStatusInformation1||XmlElement()||
|+|AssoctdDoc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|InstlmtInf|global::System.Collections.Generic.List<ISO20022.Tsmt053001.Instalment2>||XmlElement()||
|+|DueAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlAmt|ISO20022.Tsmt053001.InvoiceTotals1||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinDocRef|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ItmCntxt|ISO20022.Tsmt053001.FinancialItemParameters1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryDtls),validElement(FincgSts),validElement(VldtnStsInf),validList("""InstlmtInf""",InstlmtInf),validElement(InstlmtInf),validElement(DueAmt),validElement(TtlAmt),validElement(ItmCntxt))|

---

## Value ISO20022.Tsmt053001.FinancialItemParameters1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradMkt|ISO20022.Tsmt053001.TradeMarket1Choice||XmlElement()||
|+|CdtAcct|ISO20022.Tsmt053001.AccountIdentification4Choice||XmlElement()||
|+|DbtAcct|ISO20022.Tsmt053001.AccountIdentification4Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|LglCntxt|String||XmlElement()||
|+|GovngCtrct|global::System.Collections.Generic.List<String>||XmlElement()||
|+|BuyrFinAgt|String||XmlElement()||
|+|SellrFinAgt|String||XmlElement()||
|+|Sellr|String||XmlElement()||
|+|Buyr|String||XmlElement()||
|+|Rcpt|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|LangCd|String||XmlElement()||
|+|DocPurp|String||XmlElement()||
|+|RltdItm|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|Idr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradMkt),validElement(CdtAcct),validElement(DbtAcct),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Tsmt053001.FinancingAllowedSummary1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FincgAcct|ISO20022.Tsmt053001.CashAccount7||XmlElement()||
|+|CdtAcct|ISO20022.Tsmt053001.CashAccount7||XmlElement()||
|+|FincgDtDtls|ISO20022.Tsmt053001.FinancingDateDetails1||XmlElement()||
|+|TtlFincdAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|ApldPctg|Decimal||XmlElement()||
|+|TtlAccptdItmsAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|FincdItmNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FincgAcct),validElement(CdtAcct),validElement(FincgDtDtls),validElement(TtlFincdAmt),validElement(TtlAccptdItmsAmt))|

---

## Value ISO20022.Tsmt053001.FinancingDateDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DbtDt|DateTime||XmlElement()||
|+|CdtDt|DateTime||XmlElement()||
|+|BookDt|global::System.Collections.Generic.List<DateTime>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.FinancingInformationAndStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvcFincgDtls|global::System.Collections.Generic.List<ISO20022.Tsmt053001.InvoiceFinancingDetails1>||XmlElement()||
|+|FincgAllwdSummry|ISO20022.Tsmt053001.FinancingAllowedSummary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""InvcFincgDtls""",InvcFincgDtls),validList("""InvcFincgDtls""",InvcFincgDtls),validElement(InvcFincgDtls),validElement(FincgAllwdSummry))|

---

## Value ISO20022.Tsmt053001.FinancingRateOrAmountChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Tsmt053001.FinancingResult1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FincdAmt|ISO20022.Tsmt053001.FinancingRateOrAmountChoice||XmlElement()||
|+|AddtlStsRsnInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|StsRsn|ISO20022.Tsmt053001.StatusReason4Choice||XmlElement()||
|+|FincgReqSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FincdAmt),validElement(StsRsn))|

---

## Enum ISO20022.Tsmt053001.FinancingStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CA03|Int32||XmlEnum("""CA03""")|1|
||NA01|Int32||XmlEnum("""NA01""")|2|
||MI01|Int32||XmlEnum("""MI01""")|3|
||ID03|Int32||XmlEnum("""ID03""")|4|
||ID02|Int32||XmlEnum("""ID02""")|5|
||ID01|Int32||XmlEnum("""ID01""")|6|
||DT02|Int32||XmlEnum("""DT02""")|7|
||BE11|Int32||XmlEnum("""BE11""")|8|
||BE10|Int32||XmlEnum("""BE10""")|9|
||BE09|Int32||XmlEnum("""BE09""")|10|
||BE08|Int32||XmlEnum("""BE08""")|11|
||AC06|Int32||XmlEnum("""AC06""")|12|
||AC04|Int32||XmlEnum("""AC04""")|13|
||AC01|Int32||XmlEnum("""AC01""")|14|
||CA02|Int32||XmlEnum("""CA02""")|15|
||CA01|Int32||XmlEnum("""CA01""")|16|

---

## Value ISO20022.Tsmt053001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt053001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt053001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt053001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt053001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.GenericIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Tsmt053001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt053001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt053001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Tsmt053001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Tsmt053001.GovernanceIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt053001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Tsmt053001.GovernanceIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URDG|Int32||XmlEnum("""URDG""")|1|
||UCPR|Int32||XmlEnum("""UCPR""")|2|
||NONE|Int32||XmlEnum("""NONE""")|3|
||ISPR|Int32||XmlEnum("""ISPR""")|4|

---

## Value ISO20022.Tsmt053001.GovernanceRules2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Jursdctn|global::System.Collections.Generic.List<ISO20022.Tsmt053001.Location1>||XmlElement()||
|+|AplblLaw|ISO20022.Tsmt053001.Location1||XmlElement()||
|+|RuleId|ISO20022.Tsmt053001.GovernanceIdentification1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Jursdctn""",Jursdctn),validElement(Jursdctn),validElement(AplblLaw),validElement(RuleId))|

---

## Value ISO20022.Tsmt053001.Instalment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtInstrm|ISO20022.Tsmt053001.PaymentMeans1||XmlElement()||
|+|Amt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|PmtDueDt|DateTime||XmlElement()||
|+|SeqId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtInstrm),validElement(Amt))|

---

## Value ISO20022.Tsmt053001.InstalmentFinancingInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstlmtFincgRslt|ISO20022.Tsmt053001.FinancingResult1||XmlElement()||
|+|InstlmtTtlAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|InstlmtSeqId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstlmtFincgRslt),validElement(InstlmtTtlAmt))|

---

## Value ISO20022.Tsmt053001.InvoiceFinancingDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstlmtFincgInf|global::System.Collections.Generic.List<ISO20022.Tsmt053001.InstalmentFinancingInformation1>||XmlElement()||
|+|InvcFincgRslt|ISO20022.Tsmt053001.FinancingResult1||XmlElement()||
|+|Spplr|ISO20022.Tsmt053001.PartyIdentification8||XmlElement()||
|+|OrgnlInvcInf|ISO20022.Tsmt053001.OriginalInvoiceInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""InstlmtFincgInf""",InstlmtFincgInf),validElement(InstlmtFincgInf),validElement(InvcFincgRslt),validElement(Spplr),validElement(OrgnlInvcInf))|

---

## Aspect ISO20022.Tsmt053001.InvoicePaymentReconciliationAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdMsg|global::System.Collections.Generic.List<ISO20022.Tsmt053001.EncapsulatedBusinessMessage1>||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|ItmCnt|String||XmlElement()||
|+|RcncltnCnt|String||XmlElement()||
|+|RcncltnList|global::System.Collections.Generic.List<ISO20022.Tsmt053001.ReconciliationList1>||XmlElement()||
|+|Hdr|ISO20022.Tsmt053001.BusinessLetter1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validPattern("""RcncltnCnt""",RcncltnCnt,"""[0-9]{1,15}"""),validRequired("""RcncltnList""",RcncltnList),validList("""RcncltnList""",RcncltnList),validElement(RcncltnList),validElement(Hdr))|

---

## Value ISO20022.Tsmt053001.InvoiceTotals1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDueDt|DateTime||XmlElement()||
|+|TtlInvcAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|Adjstmnt|ISO20022.Tsmt053001.Adjustment5||XmlElement()||
|+|TtlTaxAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlTaxblAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlInvcAmt),validElement(Adjstmnt),validElement(TtlTaxAmt),validElement(TtlTaxblAmt))|

---

## Value ISO20022.Tsmt053001.LegalOrganisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.Location1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtrySubDvsn|ISO20022.Tsmt053001.CountrySubdivision1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""Txt""",Txt,5),validElement(CtrySubDvsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Tsmt053001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Tsmt053001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Tsmt053001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Tsmt053001.OrganisationIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Tsmt053001.GenericIdentification3||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|BkPtyId|String||XmlElement()||
|+|DUNS|String||XmlElement()||
|+|USCHU|String||XmlElement()||
|+|EANGLN|String||XmlElement()||
|+|BEI|String||XmlElement()||
|+|IBEI|String||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""DUNS""",DUNS,"""[0-9]{9,9}"""),validPattern("""USCHU""",USCHU,"""CH[0-9]{6,6}"""),validPattern("""EANGLN""",EANGLN,"""[0-9]{13,13}"""),validPattern("""BEI""",BEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validPattern("""IBEI""",IBEI,"""[A-Z]{2,2}[B-DF-HJ-NP-TV-XZ0-9]{7,7}[0-9]{1,1}"""),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt053001.OrganisationIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.GenericOrganisationIdentification1>||XmlElement()||
|+|BIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""BIC""",BIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt053001.OrganisationIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.GenericOrganisationIdentification1>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Tsmt053001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.OriginalInvoiceInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDueDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|TtlInvcAmt|ISO20022.Tsmt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|DocNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlInvcAmt))|

---

## Value ISO20022.Tsmt053001.Party10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Tsmt053001.PersonIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsmt053001.OrganisationIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsmt053001.Party2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|global::System.Collections.Generic.List<ISO20022.Tsmt053001.PersonIdentification3>||XmlElement()||
|+|OrgId|ISO20022.Tsmt053001.OrganisationIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PrvtId""",PrvtId),validList("""PrvtId""",PrvtId),validListMax("""PrvtId""",PrvtId,4),validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsmt053001.Party8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Tsmt053001.PersonIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsmt053001.OrganisationIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Tsmt053001.Party9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FIId|ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification5||XmlElement()||
|+|OrgId|ISO20022.Tsmt053001.PartyIdentification42||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIId),validElement(OrgId),validChoice(FIId,OrgId))|

---

## Value ISO20022.Tsmt053001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Tsmt053001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Tsmt053001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Tsmt053001.PartyIdentification42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Tsmt053001.ContactDetails2||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Tsmt053001.Party10Choice||XmlElement()||
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Tsmt053001.PartyIdentification45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|global::System.Collections.Generic.List<ISO20022.Tsmt053001.Contacts3>||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Tsmt053001.Party8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CtctDtls""",CtctDtls),validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(PstlAdr),validElement(Id))|

---

## Value ISO20022.Tsmt053001.PartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Tsmt053001.Party2Choice||XmlElement()||
|+|PstlAdr|ISO20022.Tsmt053001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Tsmt053001.PaymentIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.PaymentMeans1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PyerFI|ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4||XmlElement()||
|+|PyerDbtrAcct|ISO20022.Tsmt053001.CashAccount16||XmlElement()||
|+|PyeeFI|ISO20022.Tsmt053001.BranchAndFinancialInstitutionIdentification4||XmlElement()||
|+|PyeeCdtrAcct|ISO20022.Tsmt053001.CashAccount16||XmlElement()||
|+|PmtMtdCd|String||XmlElement()||
|+|PmtTp|ISO20022.Tsmt053001.PaymentTypeInformation19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PyerFI),validElement(PyerDbtrAcct),validElement(PyeeFI),validElement(PyeeCdtrAcct),validElement(PmtTp))|

---

## Enum ISO20022.Tsmt053001.PaymentMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRA|Int32||XmlEnum("""TRA""")|1|
||DD|Int32||XmlEnum("""DD""")|2|
||TRF|Int32||XmlEnum("""TRF""")|3|
||CHK|Int32||XmlEnum("""CHK""")|4|

---

## Value ISO20022.Tsmt053001.PaymentPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|Decimal||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.PaymentTerms6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PnltyPctRate|Decimal||XmlElement()||
|+|PnltyAmt|ISO20022.Tsmt053001.CurrencyAndAmount||XmlElement()||
|+|DscntPctRate|Decimal||XmlElement()||
|+|DscntAmt|ISO20022.Tsmt053001.CurrencyAndAmount||XmlElement()||
|+|BsisAmt|ISO20022.Tsmt053001.CurrencyAndAmount||XmlElement()||
|+|DrctDbtMndtId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtlPmtPct|Decimal||XmlElement()||
|+|Desc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PmtPrd|ISO20022.Tsmt053001.PaymentPeriod1||XmlElement()||
|+|DueDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PnltyAmt),validElement(DscntAmt),validElement(BsisAmt),validElement(PmtPrd))|

---

## Enum ISO20022.Tsmt053001.PaymentTime1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMTR|Int32||XmlEnum("""EMTR""")|1|
||EPRR|Int32||XmlEnum("""EPRR""")|2|
||PRMR|Int32||XmlEnum("""PRMR""")|3|
||IREC|Int32||XmlEnum("""IREC""")|4|
||PRMD|Int32||XmlEnum("""PRMD""")|5|
||EPRD|Int32||XmlEnum("""EPRD""")|6|
||EMTD|Int32||XmlEnum("""EMTD""")|7|
||CASH|Int32||XmlEnum("""CASH""")|8|

---

## Value ISO20022.Tsmt053001.PaymentTypeInformation19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Tsmt053001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Tsmt053001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|ISO20022.Tsmt053001.ServiceLevel8Choice||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validElement(SvcLvl))|

---

## Value ISO20022.Tsmt053001.PersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|OthrId|ISO20022.Tsmt053001.GenericIdentification4||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Tsmt053001.DateAndPlaceOfBirth||XmlElement()||
|+|MplyrIdNb|String||XmlElement()||
|+|IdntyCardNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|PsptNb|String||XmlElement()||
|+|AlnRegnNb|String||XmlElement()||
|+|SclSctyNb|String||XmlElement()||
|+|CstmrNb|String||XmlElement()||
|+|DrvrsLicNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validElement(DtAndPlcOfBirth),validChoice(Issr,OthrId,DtAndPlcOfBirth,MplyrIdNb,IdntyCardNb,TaxIdNb,PsptNb,AlnRegnNb,SclSctyNb,CstmrNb,DrvrsLicNb))|

---

## Value ISO20022.Tsmt053001.PersonIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Tsmt053001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Tsmt053001.DateAndPlaceOfBirth||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Tsmt053001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Tsmt053001.PostalAddress6


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

## Enum ISO20022.Tsmt053001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Enum ISO20022.Tsmt053001.Priority3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|
||URGT|Int32||XmlEnum("""URGT""")|3|

---

## Value ISO20022.Tsmt053001.QualifiedDocumentInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdFile|global::System.Collections.Generic.List<ISO20022.Tsmt053001.BinaryFile1>||XmlElement()||
|+|URL|String||XmlElement()||
|+|DocTp|String||XmlElement()||
|+|Dgst|global::System.Collections.Generic.List<ISO20022.Tsmt053001.AlgorithmAndDigest1>||XmlElement()||
|+|ElctrncOrgnl|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|ItmIdr|String||XmlElement()||
|+|ItmListIdr|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AttchdFile""",AttchdFile),validElement(AttchdFile),validList("""Dgst""",Dgst),validListMax("""Dgst""",Dgst,2),validElement(Dgst))|

---

## Value ISO20022.Tsmt053001.QualifiedPartyAndXMLSignature1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Tsmt053001.SignatureEnvelope||XmlElement()||
|+|Pty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr))|

---

## Value ISO20022.Tsmt053001.QualifiedPartyIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RoleDesc|String||XmlElement()||
|+|Role|ISO20022.Tsmt053001.GenericIdentification1||XmlElement()||
|+|ShrtId|ISO20022.Tsmt053001.PartyIdentification2Choice||XmlElement()||
|+|Pty|global::System.Collections.Generic.List<ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Role),validElement(ShrtId),validRequired("""Pty""",Pty),validList("""Pty""",Pty),validElement(Pty))|

---

## Value ISO20022.Tsmt053001.ReconciliationList1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldtnStsInf|ISO20022.Tsmt053001.ValidationStatusInformation1||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|AssoctdDoc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|ItmCnt|String||XmlElement()||
|+|Itm|global::System.Collections.Generic.List<ISO20022.Tsmt053001.FinancialItem1>||XmlElement()||
|+|PmtAmt|ISO20022.Tsmt053001.CurrencyAndAmount||XmlElement()||
|+|PmtTerms|ISO20022.Tsmt053001.PaymentTerms6||XmlElement()||
|+|PmtDt|DateTime||XmlElement()||
|+|PmtMeans|ISO20022.Tsmt053001.PaymentMeans1||XmlElement()||
|+|PmtRef|ISO20022.Tsmt053001.PaymentIdentification1||XmlElement()||
|+|Params|ISO20022.Tsmt053001.FinancialItemParameters1||XmlElement()||
|+|Advsr|String||XmlElement()||
|+|Rcpt|String||XmlElement()||
|+|RltdDoc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VldtnStsInf),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validRequired("""Itm""",Itm),validList("""Itm""",Itm),validElement(Itm),validElement(PmtAmt),validElement(PmtTerms),validElement(PmtMeans),validElement(PmtRef),validElement(Params))|

---

## Enum ISO20022.Tsmt053001.RequestStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTFD|Int32||XmlEnum("""NTFD""")|1|
||PDNG|Int32||XmlEnum("""PDNG""")|2|
||FNCD|Int32||XmlEnum("""FNCD""")|3|

---

## Value ISO20022.Tsmt053001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.SignatureEnvelope


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.SimpleIdentificationInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.SingleQualifiedPartyIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|BasePty|ISO20022.Tsmt053001.TradeParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""RltvIdr""",RltvIdr,5),validElement(BasePty))|

---

## Value ISO20022.Tsmt053001.StatusReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.StrictPayload


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt053001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Tsmt053001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Tsmt053001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Tsmt053001.TaxExemptReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EIOP|Int32||XmlEnum("""EIOP""")|1|
||EIFP|Int32||XmlEnum("""EIFP""")|2|
||RCIP|Int32||XmlEnum("""RCIP""")|3|
||RCRF|Int32||XmlEnum("""RCRF""")|4|
||RIAN|Int32||XmlEnum("""RIAN""")|5|
||RIRA|Int32||XmlEnum("""RIRA""")|6|
||E457X|Int32||XmlEnum("""457X""")|7|
||E403B|Int32||XmlEnum("""403B""")|8|
||SIRA|Int32||XmlEnum("""SIRA""")|9|
||E401K|Int32||XmlEnum("""401K""")|10|
||PFSP|Int32||XmlEnum("""PFSP""")|11|
||KEOG|Int32||XmlEnum("""KEOG""")|12|
||IRAR|Int32||XmlEnum("""IRAR""")|13|
||IRAC|Int32||XmlEnum("""IRAC""")|14|
||DECP|Int32||XmlEnum("""DECP""")|15|
||NFQP|Int32||XmlEnum("""NFQP""")|16|
||NFPI|Int32||XmlEnum("""NFPI""")|17|
||ECYE|Int32||XmlEnum("""ECYE""")|18|
||EPRY|Int32||XmlEnum("""EPRY""")|19|
||EMCY|Int32||XmlEnum("""EMCY""")|20|
||EMPY|Int32||XmlEnum("""EMPY""")|21|
||ASTR|Int32||XmlEnum("""ASTR""")|22|
||PRYP|Int32||XmlEnum("""PRYP""")|23|
||CUYP|Int32||XmlEnum("""CUYP""")|24|
||IISA|Int32||XmlEnum("""IISA""")|25|
||SISA|Int32||XmlEnum("""SISA""")|26|
||MISA|Int32||XmlEnum("""MISA""")|27|
||MASA|Int32||XmlEnum("""MASA""")|28|
||NONE|Int32||XmlEnum("""NONE""")|29|

---

## Value ISO20022.Tsmt053001.TaxExemptionReasonFormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|String||XmlElement()||
|+|Ustrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Strd,Ustrd))|

---

## Value ISO20022.Tsmt053001.TaxParty3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxXmptnRsn|global::System.Collections.Generic.List<ISO20022.Tsmt053001.TaxExemptionReasonFormatChoice>||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxXmptnRsn""",TaxXmptnRsn),validElement(TaxXmptnRsn))|

---

## Enum ISO20022.Tsmt053001.TechnicalValidationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCER|Int32||XmlEnum("""RCER""")|1|
||RCCF|Int32||XmlEnum("""RCCF""")|2|

---

## Value ISO20022.Tsmt053001.TradeMarket1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Tsmt053001.GenericIdentification20||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Tsmt053001.TradeParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxPty|global::System.Collections.Generic.List<ISO20022.Tsmt053001.TaxParty3>||XmlElement()||
|+|LglOrg|ISO20022.Tsmt053001.LegalOrganisation1||XmlElement()||
|+|PtyId|ISO20022.Tsmt053001.PartyIdentification45||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxPty""",TaxPty),validElement(TaxPty),validElement(LglOrg),validElement(PtyId))|

---

## Value ISO20022.Tsmt053001.ValidationStatusInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlStsRsnInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|StsRsn|ISO20022.Tsmt053001.StatusReason4Choice||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsRsn))|

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

