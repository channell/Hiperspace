# pacs.002.001.12
```mermaid
classDiagram
    class Pacs002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class Pacs002001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class Pacs002001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class Pacs002001.DocumentType3Code {
        SCOR = 1
        PUOR = 2
        DISP = 3
        FXDR = 4
        RPIN = 5
        RADM = 6
    }
    class Pacs002001.DocumentType6Code {
        PUOR = 1
        TSUT = 2
        AROI = 3
        VCHR = 4
        BOLD = 5
        DISP = 6
        SOAC = 7
        CMCN = 8
        SBIN = 9
        HIRI = 10
        DEBN = 11
        CREN = 12
        CINV = 13
        DNFA = 14
        CNFA = 15
        MSIN = 16
    }
    class Pacs002001.Frequency6Code {
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
    class Pacs002001.MandateClassification1Code {
        VARI = 1
        USGB = 2
        FIXE = 3
    }
    class Pacs002001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class Pacs002001.PaymentMethod4Code {
        TRA = 1
        DD = 2
        TRF = 3
        CHK = 4
    }
    class Pacs002001.PreferredContactMethod1Code {
        CELL = 1
        FAXX = 2
        PHON = 3
        MAIL = 4
        LETT = 5
    }
    class Pacs002001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class Pacs002001.SequenceType3Code {
        RPRE = 1
        OOFF = 2
        FNAL = 3
        RCUR = 4
        FRST = 5
    }
    class Pacs002001.SettlementMethod1Code {
        CLRG = 1
        COVE = 2
        INGA = 3
        INDA = 4
    }
    class Pacs002001.TaxRecordPeriod1Code {
        HLF2 = 1
        HLF1 = 2
        QTR4 = 3
        QTR3 = 4
        QTR2 = 5
        QTR1 = 6
        MM12 = 7
        MM11 = 8
        MM10 = 9
        MM09 = 10
        MM08 = 11
        MM07 = 12
        MM06 = 13
        MM05 = 14
        MM04 = 15
        MM03 = 16
        MM02 = 17
        MM01 = 18
    }
    class Pacs002001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
        + ValidRequired_Value () = validRequired("Value",Value)
        + ValidRequired_Ccy () = validRequired("Ccy",Ccy)
        + ValidPattern_Ccy () = validPattern("Ccy",Ccy,"[A-Z]{3,3}")
        + Validation () = validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)
    }
    class Pacs002001.AmendmentInformationDetails14 {
        + OrgnlTrckgDays  : String
        + OrgnlRsn  : Pacs002001.MandateSetupReason1Choice
        + OrgnlFrqcy  : Pacs002001.Frequency36Choice
        + OrgnlFnlColltnDt  : DateTime
        + OrgnlDbtrAgtAcct  : Pacs002001.CashAccount40
        + OrgnlDbtrAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + OrgnlDbtrAcct  : Pacs002001.CashAccount40
        + OrgnlDbtr  : Pacs002001.PartyIdentification135
        + OrgnlCdtrAgtAcct  : Pacs002001.CashAccount40
        + OrgnlCdtrAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + OrgnlCdtrSchmeId  : Pacs002001.PartyIdentification135
        + OrgnlMndtId  : String
        + ValidPattern_OrgnlTrckgDays () = validPattern("OrgnlTrckgDays",OrgnlTrckgDays,"[0-9]{2}")
        + ValidElement_OrgnlRsn () = validElement(OrgnlRsn)
        + ValidElement_OrgnlFrqcy () = validElement(OrgnlFrqcy)
        + ValidElement_OrgnlDbtrAgtAcct () = validElement(OrgnlDbtrAgtAcct)
        + ValidElement_OrgnlDbtrAgt () = validElement(OrgnlDbtrAgt)
        + ValidElement_OrgnlDbtrAcct () = validElement(OrgnlDbtrAcct)
        + ValidElement_OrgnlDbtr () = validElement(OrgnlDbtr)
        + ValidElement_OrgnlCdtrAgtAcct () = validElement(OrgnlCdtrAgtAcct)
        + ValidElement_OrgnlCdtrAgt () = validElement(OrgnlCdtrAgt)
        + ValidElement_OrgnlCdtrSchmeId () = validElement(OrgnlCdtrSchmeId)
        + Validation () = validation(ValidPattern_OrgnlTrckgDays,ValidElement_OrgnlRsn,ValidElement_OrgnlFrqcy,ValidElement_OrgnlDbtrAgtAcct,ValidElement_OrgnlDbtrAgt,ValidElement_OrgnlDbtrAcct,ValidElement_OrgnlDbtr,ValidElement_OrgnlCdtrAgtAcct,ValidElement_OrgnlCdtrAgt,ValidElement_OrgnlCdtrSchmeId)
    }
    class Pacs002001.BranchAndFinancialInstitutionIdentification6 {
        + BrnchId  : Pacs002001.BranchData3
        + FinInstnId  : Pacs002001.FinancialInstitutionIdentification18
        + ValidElement_BrnchId () = validElement(BrnchId)
        + ValidElement_FinInstnId () = validElement(FinInstnId)
        + Validation () = validation(ValidElement_BrnchId,ValidElement_FinInstnId)
    }
    class Pacs002001.BranchData3 {
        + PstlAdr  : Pacs002001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + Id  : String
        + ValidElement_PstlAdr () = validElement(PstlAdr)
        + ValidPattern_LEI () = validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")
        + Validation () = validation(ValidElement_PstlAdr,ValidPattern_LEI)
    }
    class Pacs002001.CashAccount40 {
        + Prxy  : Pacs002001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : Pacs002001.CashAccountType2Choice
        + Id  : Pacs002001.AccountIdentification4Choice
        + ValidElement_Prxy () = validElement(Prxy)
        + ValidPattern_Ccy () = validPattern("Ccy",Ccy,"[A-Z]{3,3}")
        + ValidElement_Tp () = validElement(Tp)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_Prxy,ValidPattern_Ccy,ValidElement_Tp,ValidElement_Id)
    }
    class Pacs002001.Charges7 {
        + Agt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidElement_Agt () = validElement(Agt)
        + ValidElement_Amt () = validElement(Amt)
        + Validation () = validation(ValidElement_Agt,ValidElement_Amt)
    }
    class Pacs002001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : Pacs002001.ClearingSystemIdentification2Choice
        + ValidElement_ClrSysId () = validElement(ClrSysId)
        + Validation () = validation(ValidElement_ClrSysId)
    }
    class Pacs002001.Contact4 {
        + PrefrdMtd  : String
        + Othr  : List~Pacs002001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
        + ValidList_Othr () = validList("Othr",Othr)
        + ValidElement_Othr () = validElement(Othr)
        + ValidPattern_FaxNb () = validPattern("FaxNb",FaxNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")
        + ValidPattern_MobNb () = validPattern("MobNb",MobNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")
        + ValidPattern_PhneNb () = validPattern("PhneNb",PhneNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")
        + Validation () = validation(ValidList_Othr,ValidElement_Othr,ValidPattern_FaxNb,ValidPattern_MobNb,ValidPattern_PhneNb)
    }
    class Pacs002001.CreditorReferenceInformation2 {
        + Ref  : String
        + Tp  : Pacs002001.CreditorReferenceType2
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Tp)
    }
    class Pacs002001.CreditorReferenceType2 {
        + Issr  : String
        + CdOrPrtry  : Pacs002001.CreditorReferenceType1Choice
        + ValidElement_CdOrPrtry () = validElement(CdOrPrtry)
        + Validation () = validation(ValidElement_CdOrPrtry)
    }
    class Pacs002001.CreditTransferMandateData1 {
        + Rsn  : Pacs002001.MandateSetupReason1Choice
        + Frqcy  : Pacs002001.Frequency36Choice
        + FnlPmtDt  : DateTime
        + FrstPmtDt  : DateTime
        + ElctrncSgntr  : String
        + DtOfVrfctn  : DateTime
        + DtOfSgntr  : DateTime
        + Tp  : Pacs002001.MandateTypeInformation2
        + MndtId  : String
        + ValidElement_Rsn () = validElement(Rsn)
        + ValidElement_Frqcy () = validElement(Frqcy)
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Rsn,ValidElement_Frqcy,ValidElement_Tp)
    }
    class Pacs002001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
        + ValidPattern_CtryOfBirth () = validPattern("CtryOfBirth",CtryOfBirth,"[A-Z]{2,2}")
        + Validation () = validation(ValidPattern_CtryOfBirth)
    }
    class Pacs002001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
        + Validation () = ""
    }
    class Pacs002001.DiscountAmountAndType1 {
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : Pacs002001.DiscountAmountType1Choice
        + ValidElement_Amt () = validElement(Amt)
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Amt,ValidElement_Tp)
    }
    class Pacs002001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidElement_Amt () = validElement(Amt)
        + Validation () = validation(ValidElement_Amt)
    }
    class Pacs002001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : Pacs002001.DocumentLineType1
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Tp)
    }
    class Pacs002001.DocumentLineInformation1 {
        + Amt  : Pacs002001.RemittanceAmount3
        + Desc  : String
        + Id  : List~Pacs002001.DocumentLineIdentification1~
        + ValidElement_Amt () = validElement(Amt)
        + ValidRequired_Id () = validRequired("Id",Id)
        + ValidList_Id () = validList("Id",Id)
        + ValidElement_Id () = validElement(Id)
        + Validation () = validation(ValidElement_Amt,ValidRequired_Id,ValidList_Id,ValidElement_Id)
    }
    class Pacs002001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : Pacs002001.DocumentLineType1Choice
        + ValidElement_CdOrPrtry () = validElement(CdOrPrtry)
        + Validation () = validation(ValidElement_CdOrPrtry)
    }
    class Pacs002001.EquivalentAmount2 {
        + CcyOfTrf  : String
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidPattern_CcyOfTrf () = validPattern("CcyOfTrf",CcyOfTrf,"[A-Z]{3,3}")
        + ValidElement_Amt () = validElement(Amt)
        + Validation () = validation(ValidPattern_CcyOfTrf,ValidElement_Amt)
    }
    class Pacs002001.FinancialInstitutionIdentification18 {
        + Othr  : Pacs002001.GenericFinancialIdentification1
        + PstlAdr  : Pacs002001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : Pacs002001.ClearingSystemMemberIdentification2
        + BICFI  : String
        + ValidElement_Othr () = validElement(Othr)
        + ValidElement_PstlAdr () = validElement(PstlAdr)
        + ValidPattern_LEI () = validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")
        + ValidElement_ClrSysMmbId () = validElement(ClrSysMmbId)
        + ValidPattern_BICFI () = validPattern("BICFI",BICFI,"[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidElement_Othr,ValidElement_PstlAdr,ValidPattern_LEI,ValidElement_ClrSysMmbId,ValidPattern_BICFI)
    }
    class Pacs002001.FrequencyAndMoment1 {
        + PtInTm  : String
        + Tp  : String
        + ValidPattern_PtInTm () = validPattern("PtInTm",PtInTm,"[0-9]{2}")
        + Validation () = validation(ValidPattern_PtInTm)
    }
    class Pacs002001.FrequencyPeriod1 {
        + CntPerPrd  : Decimal
        + Tp  : String
        + Validation () = ""
    }
    class Pacs002001.Garnishment3 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : Pacs002001.PartyIdentification135
        + Grnshee  : Pacs002001.PartyIdentification135
        + Tp  : Pacs002001.GarnishmentType1
        + ValidElement_RmtdAmt () = validElement(RmtdAmt)
        + ValidElement_GrnshmtAdmstr () = validElement(GrnshmtAdmstr)
        + ValidElement_Grnshee () = validElement(Grnshee)
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_RmtdAmt,ValidElement_GrnshmtAdmstr,ValidElement_Grnshee,ValidElement_Tp)
    }
    class Pacs002001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : Pacs002001.GarnishmentType1Choice
        + ValidElement_CdOrPrtry () = validElement(CdOrPrtry)
        + Validation () = validation(ValidElement_CdOrPrtry)
    }
    class Pacs002001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : Pacs002001.AccountSchemeName1Choice
        + Id  : String
        + ValidElement_SchmeNm () = validElement(SchmeNm)
        + Validation () = validation(ValidElement_SchmeNm)
    }
    class Pacs002001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : Pacs002001.FinancialIdentificationSchemeName1Choice
        + Id  : String
        + ValidElement_SchmeNm () = validElement(SchmeNm)
        + Validation () = validation(ValidElement_SchmeNm)
    }
    class Pacs002001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
        + ValidPattern_Id () = validPattern("Id",Id,"[a-zA-Z0-9]{4}")
        + Validation () = validation(ValidPattern_Id)
    }
    class Pacs002001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : Pacs002001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
        + ValidElement_SchmeNm () = validElement(SchmeNm)
        + Validation () = validation(ValidElement_SchmeNm)
    }
    class Pacs002001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : Pacs002001.PersonIdentificationSchemeName1Choice
        + Id  : String
        + ValidElement_SchmeNm () = validElement(SchmeNm)
        + Validation () = validation(ValidElement_SchmeNm)
    }
    class Pacs002001.GroupHeader101 {
        + OrgnlBizQry  : Pacs002001.OriginalBusinessQuery1
        + InstdAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + InstgAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + CreDtTm  : DateTime
        + MsgId  : String
        + ValidElement_OrgnlBizQry () = validElement(OrgnlBizQry)
        + ValidElement_InstdAgt () = validElement(InstdAgt)
        + ValidElement_InstgAgt () = validElement(InstgAgt)
        + Validation () = validation(ValidElement_OrgnlBizQry,ValidElement_InstdAgt,ValidElement_InstgAgt)
    }
    class Pacs002001.MandateRelatedInformation15 {
        + TrckgDays  : String
        + Rsn  : Pacs002001.MandateSetupReason1Choice
        + Frqcy  : Pacs002001.Frequency36Choice
        + FnlColltnDt  : DateTime
        + FrstColltnDt  : DateTime
        + ElctrncSgntr  : String
        + AmdmntInfDtls  : Pacs002001.AmendmentInformationDetails14
        + AmdmntInd  : String
        + DtOfSgntr  : DateTime
        + MndtId  : String
        + ValidPattern_TrckgDays () = validPattern("TrckgDays",TrckgDays,"[0-9]{2}")
        + ValidElement_Rsn () = validElement(Rsn)
        + ValidElement_Frqcy () = validElement(Frqcy)
        + ValidElement_AmdmntInfDtls () = validElement(AmdmntInfDtls)
        + Validation () = validation(ValidPattern_TrckgDays,ValidElement_Rsn,ValidElement_Frqcy,ValidElement_AmdmntInfDtls)
    }
    class Pacs002001.MandateTypeInformation2 {
        + Clssfctn  : Pacs002001.MandateClassification1Choice
        + CtgyPurp  : Pacs002001.CategoryPurpose1Choice
        + LclInstrm  : Pacs002001.LocalInstrument2Choice
        + SvcLvl  : Pacs002001.ServiceLevel8Choice
        + ValidElement_Clssfctn () = validElement(Clssfctn)
        + ValidElement_CtgyPurp () = validElement(CtgyPurp)
        + ValidElement_LclInstrm () = validElement(LclInstrm)
        + ValidElement_SvcLvl () = validElement(SvcLvl)
        + Validation () = validation(ValidElement_Clssfctn,ValidElement_CtgyPurp,ValidElement_LclInstrm,ValidElement_SvcLvl)
    }
    class Pacs002001.NumberOfTransactionsPerStatus5 {
        + DtldCtrlSum  : Decimal
        + DtldSts  : String
        + DtldNbOfTxs  : String
        + ValidPattern_DtldNbOfTxs () = validPattern("DtldNbOfTxs",DtldNbOfTxs,"[0-9]{1,15}")
        + Validation () = validation(ValidPattern_DtldNbOfTxs)
    }
    class Pacs002001.OrganisationIdentification29 {
        + Othr  : List~Pacs002001.GenericOrganisationIdentification1~
        + LEI  : String
        + AnyBIC  : String
        + ValidList_Othr () = validList("Othr",Othr)
        + ValidElement_Othr () = validElement(Othr)
        + ValidPattern_LEI () = validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")
        + ValidPattern_AnyBIC () = validPattern("AnyBIC",AnyBIC,"[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}")
        + Validation () = validation(ValidList_Othr,ValidElement_Othr,ValidPattern_LEI,ValidPattern_AnyBIC)
    }
    class Pacs002001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
        + Validation () = ""
    }
    class Pacs002001.OriginalGroupHeader17 {
        + NbOfTxsPerSts  : List~Pacs002001.NumberOfTransactionsPerStatus5~
        + StsRsnInf  : List~Pacs002001.StatusReasonInformation12~
        + GrpSts  : String
        + OrgnlCtrlSum  : Decimal
        + OrgnlNbOfTxs  : String
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
        + ValidList_NbOfTxsPerSts () = validList("NbOfTxsPerSts",NbOfTxsPerSts)
        + ValidElement_NbOfTxsPerSts () = validElement(NbOfTxsPerSts)
        + ValidList_StsRsnInf () = validList("StsRsnInf",StsRsnInf)
        + ValidElement_StsRsnInf () = validElement(StsRsnInf)
        + ValidPattern_OrgnlNbOfTxs () = validPattern("OrgnlNbOfTxs",OrgnlNbOfTxs,"[0-9]{1,15}")
        + Validation () = validation(ValidList_NbOfTxsPerSts,ValidElement_NbOfTxsPerSts,ValidList_StsRsnInf,ValidElement_StsRsnInf,ValidPattern_OrgnlNbOfTxs)
    }
    class Pacs002001.OriginalGroupInformation29 {
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
        + Validation () = ""
    }
    class Pacs002001.OriginalTransactionReference35 {
        + Purp  : Pacs002001.Purpose2Choice
        + UltmtCdtr  : Pacs002001.Party40Choice
        + CdtrAcct  : Pacs002001.CashAccount40
        + Cdtr  : Pacs002001.Party40Choice
        + CdtrAgtAcct  : Pacs002001.CashAccount40
        + CdtrAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + DbtrAgtAcct  : Pacs002001.CashAccount40
        + DbtrAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + DbtrAcct  : Pacs002001.CashAccount40
        + Dbtr  : Pacs002001.Party40Choice
        + UltmtDbtr  : Pacs002001.Party40Choice
        + RmtInf  : Pacs002001.RemittanceInformation21
        + MndtRltdInf  : Pacs002001.MandateRelatedData2Choice
        + PmtMtd  : String
        + PmtTpInf  : Pacs002001.PaymentTypeInformation27
        + SttlmInf  : Pacs002001.SettlementInstruction11
        + CdtrSchmeId  : Pacs002001.PartyIdentification135
        + ReqdExctnDt  : Pacs002001.DateAndDateTime2Choice
        + ReqdColltnDt  : DateTime
        + IntrBkSttlmDt  : DateTime
        + Amt  : Pacs002001.AmountType4Choice
        + IntrBkSttlmAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidElement_Purp () = validElement(Purp)
        + ValidElement_UltmtCdtr () = validElement(UltmtCdtr)
        + ValidElement_CdtrAcct () = validElement(CdtrAcct)
        + ValidElement_Cdtr () = validElement(Cdtr)
        + ValidElement_CdtrAgtAcct () = validElement(CdtrAgtAcct)
        + ValidElement_CdtrAgt () = validElement(CdtrAgt)
        + ValidElement_DbtrAgtAcct () = validElement(DbtrAgtAcct)
        + ValidElement_DbtrAgt () = validElement(DbtrAgt)
        + ValidElement_DbtrAcct () = validElement(DbtrAcct)
        + ValidElement_Dbtr () = validElement(Dbtr)
        + ValidElement_UltmtDbtr () = validElement(UltmtDbtr)
        + ValidElement_RmtInf () = validElement(RmtInf)
        + ValidElement_MndtRltdInf () = validElement(MndtRltdInf)
        + ValidElement_PmtTpInf () = validElement(PmtTpInf)
        + ValidElement_SttlmInf () = validElement(SttlmInf)
        + ValidElement_CdtrSchmeId () = validElement(CdtrSchmeId)
        + ValidElement_ReqdExctnDt () = validElement(ReqdExctnDt)
        + ValidElement_Amt () = validElement(Amt)
        + ValidElement_IntrBkSttlmAmt () = validElement(IntrBkSttlmAmt)
        + Validation () = validation(ValidElement_Purp,ValidElement_UltmtCdtr,ValidElement_CdtrAcct,ValidElement_Cdtr,ValidElement_CdtrAgtAcct,ValidElement_CdtrAgt,ValidElement_DbtrAgtAcct,ValidElement_DbtrAgt,ValidElement_DbtrAcct,ValidElement_Dbtr,ValidElement_UltmtDbtr,ValidElement_RmtInf,ValidElement_MndtRltdInf,ValidElement_PmtTpInf,ValidElement_SttlmInf,ValidElement_CdtrSchmeId,ValidElement_ReqdExctnDt,ValidElement_Amt,ValidElement_IntrBkSttlmAmt)
    }
    class Pacs002001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
        + Validation () = ""
    }
    class Pacs002001.PartyIdentification135 {
        + CtctDtls  : Pacs002001.Contact4
        + CtryOfRes  : String
        + Id  : Pacs002001.Party38Choice
        + PstlAdr  : Pacs002001.PostalAddress24
        + Nm  : String
        + ValidElement_CtctDtls () = validElement(CtctDtls)
        + ValidPattern_CtryOfRes () = validPattern("CtryOfRes",CtryOfRes,"[A-Z]{2,2}")
        + ValidElement_Id () = validElement(Id)
        + ValidElement_PstlAdr () = validElement(PstlAdr)
        + Validation () = validation(ValidElement_CtctDtls,ValidPattern_CtryOfRes,ValidElement_Id,ValidElement_PstlAdr)
    }
    class Pacs002001.PaymentTransaction130 {
        + SplmtryData  : List~Pacs002001.SupplementaryData1~
        + OrgnlTxRef  : Pacs002001.OriginalTransactionReference35
        + InstdAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + InstgAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + ClrSysRef  : String
        + AcctSvcrRef  : String
        + FctvIntrBkSttlmDt  : Pacs002001.DateAndDateTime2Choice
        + AccptncDtTm  : DateTime
        + ChrgsInf  : List~Pacs002001.Charges7~
        + StsRsnInf  : List~Pacs002001.StatusReasonInformation12~
        + TxSts  : String
        + OrgnlUETR  : String
        + OrgnlTxId  : String
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + OrgnlGrpInf  : Pacs002001.OriginalGroupInformation29
        + StsId  : String
        + ValidList_SplmtryData () = validList("SplmtryData",SplmtryData)
        + ValidElement_SplmtryData () = validElement(SplmtryData)
        + ValidElement_OrgnlTxRef () = validElement(OrgnlTxRef)
        + ValidElement_InstdAgt () = validElement(InstdAgt)
        + ValidElement_InstgAgt () = validElement(InstgAgt)
        + ValidElement_FctvIntrBkSttlmDt () = validElement(FctvIntrBkSttlmDt)
        + ValidList_ChrgsInf () = validList("ChrgsInf",ChrgsInf)
        + ValidElement_ChrgsInf () = validElement(ChrgsInf)
        + ValidList_StsRsnInf () = validList("StsRsnInf",StsRsnInf)
        + ValidElement_StsRsnInf () = validElement(StsRsnInf)
        + ValidPattern_OrgnlUETR () = validPattern("OrgnlUETR",OrgnlUETR,"[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}")
        + ValidElement_OrgnlGrpInf () = validElement(OrgnlGrpInf)
        + Validation () = validation(ValidList_SplmtryData,ValidElement_SplmtryData,ValidElement_OrgnlTxRef,ValidElement_InstdAgt,ValidElement_InstgAgt,ValidElement_FctvIntrBkSttlmDt,ValidList_ChrgsInf,ValidElement_ChrgsInf,ValidList_StsRsnInf,ValidElement_StsRsnInf,ValidPattern_OrgnlUETR,ValidElement_OrgnlGrpInf)
    }
    class Pacs002001.PaymentTypeInformation27 {
        + CtgyPurp  : Pacs002001.CategoryPurpose1Choice
        + SeqTp  : String
        + LclInstrm  : Pacs002001.LocalInstrument2Choice
        + SvcLvl  : List~Pacs002001.ServiceLevel8Choice~
        + ClrChanl  : String
        + InstrPrty  : String
        + ValidElement_CtgyPurp () = validElement(CtgyPurp)
        + ValidElement_LclInstrm () = validElement(LclInstrm)
        + ValidList_SvcLvl () = validList("SvcLvl",SvcLvl)
        + ValidElement_SvcLvl () = validElement(SvcLvl)
        + Validation () = validation(ValidElement_CtgyPurp,ValidElement_LclInstrm,ValidList_SvcLvl,ValidElement_SvcLvl)
    }
    class Pacs002001.PersonIdentification13 {
        + Othr  : List~Pacs002001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : Pacs002001.DateAndPlaceOfBirth1
        + ValidList_Othr () = validList("Othr",Othr)
        + ValidElement_Othr () = validElement(Othr)
        + ValidElement_DtAndPlcOfBirth () = validElement(DtAndPlcOfBirth)
        + Validation () = validation(ValidList_Othr,ValidElement_Othr,ValidElement_DtAndPlcOfBirth)
    }
    class Pacs002001.PostalAddress24 {
        + AdrLine  : List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : Pacs002001.AddressType3Choice
        + ValidListMax_AdrLine () = validListMax("AdrLine",AdrLine,7)
        + ValidPattern_Ctry () = validPattern("Ctry",Ctry,"[A-Z]{2,2}")
        + ValidElement_AdrTp () = validElement(AdrTp)
        + Validation () = validation(ValidListMax_AdrLine,ValidPattern_Ctry,ValidElement_AdrTp)
    }
    class Pacs002001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : Pacs002001.ProxyAccountType1Choice
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Tp)
    }
    class Pacs002001.ReferredDocumentInformation7 {
        + LineDtls  : List~Pacs002001.DocumentLineInformation1~
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : Pacs002001.ReferredDocumentType4
        + ValidList_LineDtls () = validList("LineDtls",LineDtls)
        + ValidElement_LineDtls () = validElement(LineDtls)
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidList_LineDtls,ValidElement_LineDtls,ValidElement_Tp)
    }
    class Pacs002001.ReferredDocumentType4 {
        + Issr  : String
        + CdOrPrtry  : Pacs002001.ReferredDocumentType3Choice
        + ValidElement_CdOrPrtry () = validElement(CdOrPrtry)
        + Validation () = validation(ValidElement_CdOrPrtry)
    }
    class Pacs002001.RemittanceAmount2 {
        + RmtdAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : List~Pacs002001.DocumentAdjustment1~
        + TaxAmt  : List~Pacs002001.TaxAmountAndType1~
        + CdtNoteAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : List~Pacs002001.DiscountAmountAndType1~
        + DuePyblAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidElement_RmtdAmt () = validElement(RmtdAmt)
        + ValidList_AdjstmntAmtAndRsn () = validList("AdjstmntAmtAndRsn",AdjstmntAmtAndRsn)
        + ValidElement_AdjstmntAmtAndRsn () = validElement(AdjstmntAmtAndRsn)
        + ValidList_TaxAmt () = validList("TaxAmt",TaxAmt)
        + ValidElement_TaxAmt () = validElement(TaxAmt)
        + ValidElement_CdtNoteAmt () = validElement(CdtNoteAmt)
        + ValidList_DscntApldAmt () = validList("DscntApldAmt",DscntApldAmt)
        + ValidElement_DscntApldAmt () = validElement(DscntApldAmt)
        + ValidElement_DuePyblAmt () = validElement(DuePyblAmt)
        + Validation () = validation(ValidElement_RmtdAmt,ValidList_AdjstmntAmtAndRsn,ValidElement_AdjstmntAmtAndRsn,ValidList_TaxAmt,ValidElement_TaxAmt,ValidElement_CdtNoteAmt,ValidList_DscntApldAmt,ValidElement_DscntApldAmt,ValidElement_DuePyblAmt)
    }
    class Pacs002001.RemittanceAmount3 {
        + RmtdAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : List~Pacs002001.DocumentAdjustment1~
        + TaxAmt  : List~Pacs002001.TaxAmountAndType1~
        + CdtNoteAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : List~Pacs002001.DiscountAmountAndType1~
        + DuePyblAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidElement_RmtdAmt () = validElement(RmtdAmt)
        + ValidList_AdjstmntAmtAndRsn () = validList("AdjstmntAmtAndRsn",AdjstmntAmtAndRsn)
        + ValidElement_AdjstmntAmtAndRsn () = validElement(AdjstmntAmtAndRsn)
        + ValidList_TaxAmt () = validList("TaxAmt",TaxAmt)
        + ValidElement_TaxAmt () = validElement(TaxAmt)
        + ValidElement_CdtNoteAmt () = validElement(CdtNoteAmt)
        + ValidList_DscntApldAmt () = validList("DscntApldAmt",DscntApldAmt)
        + ValidElement_DscntApldAmt () = validElement(DscntApldAmt)
        + ValidElement_DuePyblAmt () = validElement(DuePyblAmt)
        + Validation () = validation(ValidElement_RmtdAmt,ValidList_AdjstmntAmtAndRsn,ValidElement_AdjstmntAmtAndRsn,ValidList_TaxAmt,ValidElement_TaxAmt,ValidElement_CdtNoteAmt,ValidList_DscntApldAmt,ValidElement_DscntApldAmt,ValidElement_DuePyblAmt)
    }
    class Pacs002001.RemittanceInformation21 {
        + Strd  : List~Pacs002001.StructuredRemittanceInformation17~
        + Ustrd  : List~String~
        + ValidList_Strd () = validList("Strd",Strd)
        + ValidElement_Strd () = validElement(Strd)
        + Validation () = validation(ValidList_Strd,ValidElement_Strd)
    }
    class Pacs002001.SettlementInstruction11 {
        + ThrdRmbrsmntAgtAcct  : Pacs002001.CashAccount40
        + ThrdRmbrsmntAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + InstdRmbrsmntAgtAcct  : Pacs002001.CashAccount40
        + InstdRmbrsmntAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + InstgRmbrsmntAgtAcct  : Pacs002001.CashAccount40
        + InstgRmbrsmntAgt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + ClrSys  : Pacs002001.ClearingSystemIdentification3Choice
        + SttlmAcct  : Pacs002001.CashAccount40
        + SttlmMtd  : String
        + ValidElement_ThrdRmbrsmntAgtAcct () = validElement(ThrdRmbrsmntAgtAcct)
        + ValidElement_ThrdRmbrsmntAgt () = validElement(ThrdRmbrsmntAgt)
        + ValidElement_InstdRmbrsmntAgtAcct () = validElement(InstdRmbrsmntAgtAcct)
        + ValidElement_InstdRmbrsmntAgt () = validElement(InstdRmbrsmntAgt)
        + ValidElement_InstgRmbrsmntAgtAcct () = validElement(InstgRmbrsmntAgtAcct)
        + ValidElement_InstgRmbrsmntAgt () = validElement(InstgRmbrsmntAgt)
        + ValidElement_ClrSys () = validElement(ClrSys)
        + ValidElement_SttlmAcct () = validElement(SttlmAcct)
        + Validation () = validation(ValidElement_ThrdRmbrsmntAgtAcct,ValidElement_ThrdRmbrsmntAgt,ValidElement_InstdRmbrsmntAgtAcct,ValidElement_InstdRmbrsmntAgt,ValidElement_InstgRmbrsmntAgtAcct,ValidElement_InstgRmbrsmntAgt,ValidElement_ClrSys,ValidElement_SttlmAcct)
    }
    class Pacs002001.StatusReasonInformation12 {
        + AddtlInf  : List~String~
        + Rsn  : Pacs002001.StatusReason6Choice
        + Orgtr  : Pacs002001.PartyIdentification135
        + ValidElement_Rsn () = validElement(Rsn)
        + ValidElement_Orgtr () = validElement(Orgtr)
        + Validation () = validation(ValidElement_Rsn,ValidElement_Orgtr)
    }
    class Pacs002001.StructuredRemittanceInformation17 {
        + AddtlRmtInf  : List~String~
        + GrnshmtRmt  : Pacs002001.Garnishment3
        + TaxRmt  : Pacs002001.TaxData1
        + Invcee  : Pacs002001.PartyIdentification135
        + Invcr  : Pacs002001.PartyIdentification135
        + CdtrRefInf  : Pacs002001.CreditorReferenceInformation2
        + RfrdDocAmt  : Pacs002001.RemittanceAmount2
        + RfrdDocInf  : List~Pacs002001.ReferredDocumentInformation7~
        + ValidListMax_AddtlRmtInf () = validListMax("AddtlRmtInf",AddtlRmtInf,3)
        + ValidElement_GrnshmtRmt () = validElement(GrnshmtRmt)
        + ValidElement_TaxRmt () = validElement(TaxRmt)
        + ValidElement_Invcee () = validElement(Invcee)
        + ValidElement_Invcr () = validElement(Invcr)
        + ValidElement_CdtrRefInf () = validElement(CdtrRefInf)
        + ValidElement_RfrdDocAmt () = validElement(RfrdDocAmt)
        + ValidList_RfrdDocInf () = validList("RfrdDocInf",RfrdDocInf)
        + ValidElement_RfrdDocInf () = validElement(RfrdDocInf)
        + Validation () = validation(ValidListMax_AddtlRmtInf,ValidElement_GrnshmtRmt,ValidElement_TaxRmt,ValidElement_Invcee,ValidElement_Invcr,ValidElement_CdtrRefInf,ValidElement_RfrdDocAmt,ValidList_RfrdDocInf,ValidElement_RfrdDocInf)
    }
    class Pacs002001.SupplementaryData1 {
        + Envlp  : Pacs002001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
        + ValidElement_Envlp () = validElement(Envlp)
        + Validation () = validation(ValidElement_Envlp)
    }
    class Pacs002001.SupplementaryDataEnvelope1 {
        + Validation () = ""
    }
    class Pacs002001.TaxAmount3 {
        + Dtls  : List~Pacs002001.TaxRecordDetails3~
        + TtlAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
        + ValidList_Dtls () = validList("Dtls",Dtls)
        + ValidElement_Dtls () = validElement(Dtls)
        + ValidElement_TtlAmt () = validElement(TtlAmt)
        + ValidElement_TaxblBaseAmt () = validElement(TaxblBaseAmt)
        + Validation () = validation(ValidList_Dtls,ValidElement_Dtls,ValidElement_TtlAmt,ValidElement_TaxblBaseAmt)
    }
    class Pacs002001.TaxAmountAndType1 {
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : Pacs002001.TaxAmountType1Choice
        + ValidElement_Amt () = validElement(Amt)
        + ValidElement_Tp () = validElement(Tp)
        + Validation () = validation(ValidElement_Amt,ValidElement_Tp)
    }
    class Pacs002001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
        + Validation () = ""
    }
    class Pacs002001.TaxData1 {
        + Rcrd  : List~Pacs002001.TaxRecord3~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : Pacs002001.TaxParty2
        + Dbtr  : Pacs002001.TaxParty2
        + Cdtr  : Pacs002001.TaxParty1
        + ValidList_Rcrd () = validList("Rcrd",Rcrd)
        + ValidElement_Rcrd () = validElement(Rcrd)
        + ValidElement_TtlTaxAmt () = validElement(TtlTaxAmt)
        + ValidElement_TtlTaxblBaseAmt () = validElement(TtlTaxblBaseAmt)
        + ValidElement_UltmtDbtr () = validElement(UltmtDbtr)
        + ValidElement_Dbtr () = validElement(Dbtr)
        + ValidElement_Cdtr () = validElement(Cdtr)
        + Validation () = validation(ValidList_Rcrd,ValidElement_Rcrd,ValidElement_TtlTaxAmt,ValidElement_TtlTaxblBaseAmt,ValidElement_UltmtDbtr,ValidElement_Dbtr,ValidElement_Cdtr)
    }
    class Pacs002001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
        + Validation () = ""
    }
    class Pacs002001.TaxParty2 {
        + Authstn  : Pacs002001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
        + ValidElement_Authstn () = validElement(Authstn)
        + Validation () = validation(ValidElement_Authstn)
    }
    class Pacs002001.TaxPeriod3 {
        + FrToDt  : Pacs002001.DatePeriod2
        + Tp  : String
        + Yr  : Int32
        + ValidElement_FrToDt () = validElement(FrToDt)
        + Validation () = validation(ValidElement_FrToDt)
    }
    class Pacs002001.TaxRecord3 {
        + AddtlInf  : String
        + TaxAmt  : Pacs002001.TaxAmount3
        + Prd  : Pacs002001.TaxPeriod3
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
        + ValidElement_TaxAmt () = validElement(TaxAmt)
        + ValidElement_Prd () = validElement(Prd)
        + Validation () = validation(ValidElement_TaxAmt,ValidElement_Prd)
    }
    class Pacs002001.TaxRecordDetails3 {
        + Amt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : Pacs002001.TaxPeriod3
        + ValidElement_Amt () = validElement(Amt)
        + ValidElement_Prd () = validElement(Prd)
        + Validation () = validation(ValidElement_Amt,ValidElement_Prd)
    }
    class Pacs002001.Document {
        # Uri  : String
        + FIToFIPmtStsRpt () : Pacs002001.FIToFIPaymentStatusReportV12
        + ValidElement_FIToFIPmtStsRpt () = validElement(FIToFIPmtStsRpt)
        + Validation () = validation(ValidElement_FIToFIPmtStsRpt)
    }
    class Pacs002001.FIToFIPaymentStatusReportV12 {
        + SplmtryData  : List~Pacs002001.SupplementaryData1~
        + TxInfAndSts  : List~Pacs002001.PaymentTransaction130~
        + OrgnlGrpInfAndSts  : List~Pacs002001.OriginalGroupHeader17~
        + GrpHdr  : Pacs002001.GroupHeader101
        + ValidList_SplmtryData () = validList("SplmtryData",SplmtryData)
        + ValidElement_SplmtryData () = validElement(SplmtryData)
        + ValidList_TxInfAndSts () = validList("TxInfAndSts",TxInfAndSts)
        + ValidElement_TxInfAndSts () = validElement(TxInfAndSts)
        + ValidList_OrgnlGrpInfAndSts () = validList("OrgnlGrpInfAndSts",OrgnlGrpInfAndSts)
        + ValidElement_OrgnlGrpInfAndSts () = validElement(OrgnlGrpInfAndSts)
        + ValidElement_GrpHdr () = validElement(GrpHdr)
        + Validation () = validation(ValidList_SplmtryData,ValidElement_SplmtryData,ValidList_TxInfAndSts,ValidElement_TxInfAndSts,ValidList_OrgnlGrpInfAndSts,ValidElement_OrgnlGrpInfAndSts,ValidElement_GrpHdr)
    }
    class Pacs002001.AccountIdentification4Choice {
        + Othr  : Pacs002001.GenericAccountIdentification1
        + IBAN  : String
        + ValidChoice () = validChoice(Othr,IBAN)
        + ValidElement_Othr () = validElement(Othr)
        + ValidPattern_IBAN () = validPattern("IBAN",IBAN,"[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")
        + Validation () = validation(ValidElement_Othr,ValidPattern_IBAN,ValidChoice)
    }
    class Pacs002001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.AddressType3Choice {
        + Prtry  : Pacs002001.GenericIdentification30
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + ValidElement_Prtry () = validElement(Prtry)
        + Validation () = validation(ValidElement_Prtry,ValidChoice)
    }
    class Pacs002001.AmountType4Choice {
        + EqvtAmt  : Pacs002001.EquivalentAmount2
        + InstdAmt  : Pacs002001.ActiveOrHistoricCurrencyAndAmount
        + ValidChoice () = validChoice(EqvtAmt,InstdAmt)
        + ValidElement_EqvtAmt () = validElement(EqvtAmt)
        + ValidElement_InstdAmt () = validElement(InstdAmt)
        + Validation () = validation(ValidElement_EqvtAmt,ValidElement_InstdAmt,ValidChoice)
    }
    class Pacs002001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.ClearingSystemIdentification3Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.CreditorReferenceType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
        + ValidChoice () = validChoice(DtTm,Dt)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.DiscountAmountType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.Frequency36Choice {
        + PtInTm  : Pacs002001.FrequencyAndMoment1
        + Prd  : Pacs002001.FrequencyPeriod1
        + Tp  : String
        + ValidChoice () = validChoice(PtInTm,Prd,Tp)
        + ValidElement_PtInTm () = validElement(PtInTm)
        + ValidElement_Prd () = validElement(Prd)
        + Validation () = validation(ValidElement_PtInTm,ValidElement_Prd,ValidChoice)
    }
    class Pacs002001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.MandateClassification1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.MandateRelatedData2Choice {
        + CdtTrfMndt  : Pacs002001.CreditTransferMandateData1
        + DrctDbtMndt  : Pacs002001.MandateRelatedInformation15
        + ValidChoice () = validChoice(CdtTrfMndt,DrctDbtMndt)
        + ValidElement_CdtTrfMndt () = validElement(CdtTrfMndt)
        + ValidElement_DrctDbtMndt () = validElement(DrctDbtMndt)
        + Validation () = validation(ValidElement_CdtTrfMndt,ValidElement_DrctDbtMndt,ValidChoice)
    }
    class Pacs002001.MandateSetupReason1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.Party38Choice {
        + PrvtId  : Pacs002001.PersonIdentification13
        + OrgId  : Pacs002001.OrganisationIdentification29
        + ValidChoice () = validChoice(PrvtId,OrgId)
        + ValidElement_PrvtId () = validElement(PrvtId)
        + ValidElement_OrgId () = validElement(OrgId)
        + Validation () = validation(ValidElement_PrvtId,ValidElement_OrgId,ValidChoice)
    }
    class Pacs002001.Party40Choice {
        + Agt  : Pacs002001.BranchAndFinancialInstitutionIdentification6
        + Pty  : Pacs002001.PartyIdentification135
        + ValidChoice () = validChoice(Agt,Pty)
        + ValidElement_Agt () = validElement(Agt)
        + ValidElement_Pty () = validElement(Pty)
        + Validation () = validation(ValidElement_Agt,ValidElement_Pty,ValidChoice)
    }
    class Pacs002001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.ReferredDocumentType3Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.StatusReason6Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Pacs002001.TaxAmountType1Choice {
        + Prtry  : String
        + Cd  : String
        + ValidChoice () = validChoice(Prtry,Cd)
        + Validation () = validation(ValidChoice)
    }
    class Edge {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Edge
        + Tos (To = this) : Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## Enum Pacs002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32|||1|
||MLTO|Int32|||2|
||BIZZ|Int32|||3|
||HOME|Int32|||4|
||PBOX|Int32|||5|
||ADDR|Int32|||6|

---

## Enum Pacs002001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32|||1|
||MPNS|Int32|||2|
||RTNS|Int32|||3|
||RTGS|Int32|||4|

---

## Enum Pacs002001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32|||1|
||CRDT|Int32|||2|

---

## Enum Pacs002001.DocumentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCOR|Int32|||1|
||PUOR|Int32|||2|
||DISP|Int32|||3|
||FXDR|Int32|||4|
||RPIN|Int32|||5|
||RADM|Int32|||6|

---

## Enum Pacs002001.DocumentType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUOR|Int32|||1|
||TSUT|Int32|||2|
||AROI|Int32|||3|
||VCHR|Int32|||4|
||BOLD|Int32|||5|
||DISP|Int32|||6|
||SOAC|Int32|||7|
||CMCN|Int32|||8|
||SBIN|Int32|||9|
||HIRI|Int32|||10|
||DEBN|Int32|||11|
||CREN|Int32|||12|
||CINV|Int32|||13|
||DNFA|Int32|||14|
||CNFA|Int32|||15|
||MSIN|Int32|||16|

---

## Enum Pacs002001.Frequency6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTN|Int32|||1|
||INDA|Int32|||2|
||ADHO|Int32|||3|
||DAIL|Int32|||4|
||WEEK|Int32|||5|
||MIAN|Int32|||6|
||QURT|Int32|||7|
||MNTH|Int32|||8|
||YEAR|Int32|||9|

---

## Enum Pacs002001.MandateClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32|||1|
||USGB|Int32|||2|
||FIXE|Int32|||3|

---

## Enum Pacs002001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32|||1|
||MIST|Int32|||2|
||MISS|Int32|||3|
||MADM|Int32|||4|
||DOCT|Int32|||5|

---

## Enum Pacs002001.PaymentMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRA|Int32|||1|
||DD|Int32|||2|
||TRF|Int32|||3|
||CHK|Int32|||4|

---

## Enum Pacs002001.PreferredContactMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CELL|Int32|||1|
||FAXX|Int32|||2|
||PHON|Int32|||3|
||MAIL|Int32|||4|
||LETT|Int32|||5|

---

## Enum Pacs002001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32|||1|
||HIGH|Int32|||2|

---

## Enum Pacs002001.SequenceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPRE|Int32|||1|
||OOFF|Int32|||2|
||FNAL|Int32|||3|
||RCUR|Int32|||4|
||FRST|Int32|||5|

---

## Enum Pacs002001.SettlementMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLRG|Int32|||1|
||COVE|Int32|||2|
||INGA|Int32|||3|
||INDA|Int32|||4|

---

## Enum Pacs002001.TaxRecordPeriod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HLF2|Int32|||1|
||HLF1|Int32|||2|
||QTR4|Int32|||3|
||QTR3|Int32|||4|
||QTR2|Int32|||5|
||QTR1|Int32|||6|
||MM12|Int32|||7|
||MM11|Int32|||8|
||MM10|Int32|||9|
||MM09|Int32|||10|
||MM08|Int32|||11|
||MM07|Int32|||12|
||MM06|Int32|||13|
||MM05|Int32|||14|
||MM04|Int32|||15|
||MM03|Int32|||16|
||MM02|Int32|||17|
||MM01|Int32|||18|

---

## Value Pacs002001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||ValidRequired_Value|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Value",Value)|
||ValidRequired_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Ccy",Ccy)|
||ValidPattern_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ccy",Ccy,"[A-Z]{3,3}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidRequired_Value,ValidRequired_Ccy,ValidPattern_Ccy)|

---

## Value Pacs002001.AmendmentInformationDetails14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlTrckgDays|String||XmlElement()||
|+|OrgnlRsn|Pacs002001.MandateSetupReason1Choice||XmlElement()||
|+|OrgnlFrqcy|Pacs002001.Frequency36Choice||XmlElement()||
|+|OrgnlFnlColltnDt|DateTime||XmlElement()||
|+|OrgnlDbtrAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|OrgnlDbtrAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|OrgnlDbtrAcct|Pacs002001.CashAccount40||XmlElement()||
|+|OrgnlDbtr|Pacs002001.PartyIdentification135||XmlElement()||
|+|OrgnlCdtrAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|OrgnlCdtrAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|OrgnlCdtrSchmeId|Pacs002001.PartyIdentification135||XmlElement()||
|+|OrgnlMndtId|String||XmlElement()||
||ValidPattern_OrgnlTrckgDays|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("OrgnlTrckgDays",OrgnlTrckgDays,"[0-9]{2}")|
||ValidElement_OrgnlRsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlRsn)|
||ValidElement_OrgnlFrqcy|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlFrqcy)|
||ValidElement_OrgnlDbtrAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlDbtrAgtAcct)|
||ValidElement_OrgnlDbtrAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlDbtrAgt)|
||ValidElement_OrgnlDbtrAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlDbtrAcct)|
||ValidElement_OrgnlDbtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlDbtr)|
||ValidElement_OrgnlCdtrAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlCdtrAgtAcct)|
||ValidElement_OrgnlCdtrAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlCdtrAgt)|
||ValidElement_OrgnlCdtrSchmeId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlCdtrSchmeId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_OrgnlTrckgDays,ValidElement_OrgnlRsn,ValidElement_OrgnlFrqcy,ValidElement_OrgnlDbtrAgtAcct,ValidElement_OrgnlDbtrAgt,ValidElement_OrgnlDbtrAcct,ValidElement_OrgnlDbtr,ValidElement_OrgnlCdtrAgtAcct,ValidElement_OrgnlCdtrAgt,ValidElement_OrgnlCdtrSchmeId)|

---

## Value Pacs002001.BranchAndFinancialInstitutionIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|Pacs002001.BranchData3||XmlElement()||
|+|FinInstnId|Pacs002001.FinancialInstitutionIdentification18||XmlElement()||
||ValidElement_BrnchId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(BrnchId)|
||ValidElement_FinInstnId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FinInstnId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_BrnchId,ValidElement_FinInstnId)|

---

## Value Pacs002001.BranchData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|Pacs002001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||ValidElement_PstlAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PstlAdr)|
||ValidPattern_LEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_PstlAdr,ValidPattern_LEI)|

---

## Value Pacs002001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|Pacs002001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|Pacs002001.CashAccountType2Choice||XmlElement()||
|+|Id|Pacs002001.AccountIdentification4Choice||XmlElement()||
||ValidElement_Prxy|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prxy)|
||ValidPattern_Ccy|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ccy",Ccy,"[A-Z]{3,3}")|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Prxy,ValidPattern_Ccy,ValidElement_Tp,ValidElement_Id)|

---

## Value Pacs002001.Charges7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidElement_Agt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Agt)|
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Agt,ValidElement_Amt)|

---

## Value Pacs002001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|Pacs002001.ClearingSystemIdentification2Choice||XmlElement()||
||ValidElement_ClrSysId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ClrSysId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_ClrSysId)|

---

## Value Pacs002001.Contact4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|List<Pacs002001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||ValidList_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validList("Othr",Othr)|
||ValidElement_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Othr)|
||ValidPattern_FaxNb|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("FaxNb",FaxNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")|
||ValidPattern_MobNb|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("MobNb",MobNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")|
||ValidPattern_PhneNb|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("PhneNb",PhneNb,"\+[0-9]{1,3}-[0-9()+\-]{1,30}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Othr,ValidElement_Othr,ValidPattern_FaxNb,ValidPattern_MobNb,ValidPattern_PhneNb)|

---

## Value Pacs002001.CreditorReferenceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|Pacs002001.CreditorReferenceType2||XmlElement()||
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Tp)|

---

## Value Pacs002001.CreditorReferenceType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|Pacs002001.CreditorReferenceType1Choice||XmlElement()||
||ValidElement_CdOrPrtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdOrPrtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CdOrPrtry)|

---

## Value Pacs002001.CreditTransferMandateData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|Pacs002001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|Pacs002001.Frequency36Choice||XmlElement()||
|+|FnlPmtDt|DateTime||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|DtOfVrfctn|DateTime||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|Tp|Pacs002001.MandateTypeInformation2||XmlElement()||
|+|MndtId|String||XmlElement()||
||ValidElement_Rsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Rsn)|
||ValidElement_Frqcy|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Frqcy)|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Rsn,ValidElement_Frqcy,ValidElement_Tp)|

---

## Value Pacs002001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||ValidPattern_CtryOfBirth|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("CtryOfBirth",CtryOfBirth,"[A-Z]{2,2}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_CtryOfBirth)|

---

## Value Pacs002001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.DiscountAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|Pacs002001.DiscountAmountType1Choice||XmlElement()||
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt,ValidElement_Tp)|

---

## Value Pacs002001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt)|

---

## Value Pacs002001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|Pacs002001.DocumentLineType1||XmlElement()||
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Tp)|

---

## Value Pacs002001.DocumentLineInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Pacs002001.RemittanceAmount3||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|List<Pacs002001.DocumentLineIdentification1>||XmlElement()||
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||ValidRequired_Id|Some(String)||XmlIgnore(), JsonIgnore()|validRequired("Id",Id)|
||ValidList_Id|Some(String)||XmlIgnore(), JsonIgnore()|validList("Id",Id)|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt,ValidRequired_Id,ValidList_Id,ValidElement_Id)|

---

## Value Pacs002001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|Pacs002001.DocumentLineType1Choice||XmlElement()||
||ValidElement_CdOrPrtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdOrPrtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CdOrPrtry)|

---

## Value Pacs002001.EquivalentAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyOfTrf|String||XmlElement()||
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidPattern_CcyOfTrf|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("CcyOfTrf",CcyOfTrf,"[A-Z]{3,3}")|
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_CcyOfTrf,ValidElement_Amt)|

---

## Value Pacs002001.FinancialInstitutionIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|Pacs002001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|Pacs002001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|Pacs002001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||ValidElement_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Othr)|
||ValidElement_PstlAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PstlAdr)|
||ValidPattern_LEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")|
||ValidElement_ClrSysMmbId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ClrSysMmbId)|
||ValidPattern_BICFI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("BICFI",BICFI,"[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Othr,ValidElement_PstlAdr,ValidPattern_LEI,ValidElement_ClrSysMmbId,ValidPattern_BICFI)|

---

## Value Pacs002001.FrequencyAndMoment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|String||XmlElement()||
|+|Tp|String||XmlElement()||
||ValidPattern_PtInTm|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("PtInTm",PtInTm,"[0-9]{2}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_PtInTm)|

---

## Value Pacs002001.FrequencyPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CntPerPrd|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.Garnishment3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|Pacs002001.PartyIdentification135||XmlElement()||
|+|Grnshee|Pacs002001.PartyIdentification135||XmlElement()||
|+|Tp|Pacs002001.GarnishmentType1||XmlElement()||
||ValidElement_RmtdAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RmtdAmt)|
||ValidElement_GrnshmtAdmstr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(GrnshmtAdmstr)|
||ValidElement_Grnshee|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Grnshee)|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RmtdAmt,ValidElement_GrnshmtAdmstr,ValidElement_Grnshee,ValidElement_Tp)|

---

## Value Pacs002001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|Pacs002001.GarnishmentType1Choice||XmlElement()||
||ValidElement_CdOrPrtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdOrPrtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CdOrPrtry)|

---

## Value Pacs002001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|Pacs002001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||ValidElement_SchmeNm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SchmeNm)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_SchmeNm)|

---

## Value Pacs002001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|Pacs002001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||ValidElement_SchmeNm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SchmeNm)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_SchmeNm)|

---

## Value Pacs002001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||ValidPattern_Id|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Id",Id,"[a-zA-Z0-9]{4}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_Id)|

---

## Value Pacs002001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|Pacs002001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||ValidElement_SchmeNm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SchmeNm)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_SchmeNm)|

---

## Value Pacs002001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|Pacs002001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||ValidElement_SchmeNm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SchmeNm)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_SchmeNm)|

---

## Value Pacs002001.GroupHeader101


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlBizQry|Pacs002001.OriginalBusinessQuery1||XmlElement()||
|+|InstdAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||ValidElement_OrgnlBizQry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlBizQry)|
||ValidElement_InstdAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstdAgt)|
||ValidElement_InstgAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstgAgt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_OrgnlBizQry,ValidElement_InstdAgt,ValidElement_InstgAgt)|

---

## Value Pacs002001.MandateRelatedInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckgDays|String||XmlElement()||
|+|Rsn|Pacs002001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|Pacs002001.Frequency36Choice||XmlElement()||
|+|FnlColltnDt|DateTime||XmlElement()||
|+|FrstColltnDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|AmdmntInfDtls|Pacs002001.AmendmentInformationDetails14||XmlElement()||
|+|AmdmntInd|String||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|MndtId|String||XmlElement()||
||ValidPattern_TrckgDays|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("TrckgDays",TrckgDays,"[0-9]{2}")|
||ValidElement_Rsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Rsn)|
||ValidElement_Frqcy|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Frqcy)|
||ValidElement_AmdmntInfDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AmdmntInfDtls)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_TrckgDays,ValidElement_Rsn,ValidElement_Frqcy,ValidElement_AmdmntInfDtls)|

---

## Value Pacs002001.MandateTypeInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clssfctn|Pacs002001.MandateClassification1Choice||XmlElement()||
|+|CtgyPurp|Pacs002001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|Pacs002001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|Pacs002001.ServiceLevel8Choice||XmlElement()||
||ValidElement_Clssfctn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Clssfctn)|
||ValidElement_CtgyPurp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CtgyPurp)|
||ValidElement_LclInstrm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(LclInstrm)|
||ValidElement_SvcLvl|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SvcLvl)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Clssfctn,ValidElement_CtgyPurp,ValidElement_LclInstrm,ValidElement_SvcLvl)|

---

## Value Pacs002001.NumberOfTransactionsPerStatus5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtldCtrlSum|Decimal||XmlElement()||
|+|DtldSts|String||XmlElement()||
|+|DtldNbOfTxs|String||XmlElement()||
||ValidPattern_DtldNbOfTxs|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("DtldNbOfTxs",DtldNbOfTxs,"[0-9]{1,15}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidPattern_DtldNbOfTxs)|

---

## Value Pacs002001.OrganisationIdentification29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|List<Pacs002001.GenericOrganisationIdentification1>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||ValidList_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validList("Othr",Othr)|
||ValidElement_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Othr)|
||ValidPattern_LEI|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("LEI",LEI,"[A-Z0-9]{18,18}[0-9]{2,2}")|
||ValidPattern_AnyBIC|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("AnyBIC",AnyBIC,"[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Othr,ValidElement_Othr,ValidPattern_LEI,ValidPattern_AnyBIC)|

---

## Value Pacs002001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.OriginalGroupHeader17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfTxsPerSts|List<Pacs002001.NumberOfTransactionsPerStatus5>||XmlElement()||
|+|StsRsnInf|List<Pacs002001.StatusReasonInformation12>||XmlElement()||
|+|GrpSts|String||XmlElement()||
|+|OrgnlCtrlSum|Decimal||XmlElement()||
|+|OrgnlNbOfTxs|String||XmlElement()||
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||ValidList_NbOfTxsPerSts|Some(String)||XmlIgnore(), JsonIgnore()|validList("NbOfTxsPerSts",NbOfTxsPerSts)|
||ValidElement_NbOfTxsPerSts|Some(String)||XmlIgnore(), JsonIgnore()|validElement(NbOfTxsPerSts)|
||ValidList_StsRsnInf|Some(String)||XmlIgnore(), JsonIgnore()|validList("StsRsnInf",StsRsnInf)|
||ValidElement_StsRsnInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StsRsnInf)|
||ValidPattern_OrgnlNbOfTxs|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("OrgnlNbOfTxs",OrgnlNbOfTxs,"[0-9]{1,15}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_NbOfTxsPerSts,ValidElement_NbOfTxsPerSts,ValidList_StsRsnInf,ValidElement_StsRsnInf,ValidPattern_OrgnlNbOfTxs)|

---

## Value Pacs002001.OriginalGroupInformation29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.OriginalTransactionReference35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|Pacs002001.Purpose2Choice||XmlElement()||
|+|UltmtCdtr|Pacs002001.Party40Choice||XmlElement()||
|+|CdtrAcct|Pacs002001.CashAccount40||XmlElement()||
|+|Cdtr|Pacs002001.Party40Choice||XmlElement()||
|+|CdtrAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|CdtrAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|DbtrAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAcct|Pacs002001.CashAccount40||XmlElement()||
|+|Dbtr|Pacs002001.Party40Choice||XmlElement()||
|+|UltmtDbtr|Pacs002001.Party40Choice||XmlElement()||
|+|RmtInf|Pacs002001.RemittanceInformation21||XmlElement()||
|+|MndtRltdInf|Pacs002001.MandateRelatedData2Choice||XmlElement()||
|+|PmtMtd|String||XmlElement()||
|+|PmtTpInf|Pacs002001.PaymentTypeInformation27||XmlElement()||
|+|SttlmInf|Pacs002001.SettlementInstruction11||XmlElement()||
|+|CdtrSchmeId|Pacs002001.PartyIdentification135||XmlElement()||
|+|ReqdExctnDt|Pacs002001.DateAndDateTime2Choice||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|Amt|Pacs002001.AmountType4Choice||XmlElement()||
|+|IntrBkSttlmAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidElement_Purp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Purp)|
||ValidElement_UltmtCdtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(UltmtCdtr)|
||ValidElement_CdtrAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtrAcct)|
||ValidElement_Cdtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Cdtr)|
||ValidElement_CdtrAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtrAgtAcct)|
||ValidElement_CdtrAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtrAgt)|
||ValidElement_DbtrAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DbtrAgtAcct)|
||ValidElement_DbtrAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DbtrAgt)|
||ValidElement_DbtrAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DbtrAcct)|
||ValidElement_Dbtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Dbtr)|
||ValidElement_UltmtDbtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(UltmtDbtr)|
||ValidElement_RmtInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RmtInf)|
||ValidElement_MndtRltdInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(MndtRltdInf)|
||ValidElement_PmtTpInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PmtTpInf)|
||ValidElement_SttlmInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SttlmInf)|
||ValidElement_CdtrSchmeId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtrSchmeId)|
||ValidElement_ReqdExctnDt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ReqdExctnDt)|
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||ValidElement_IntrBkSttlmAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(IntrBkSttlmAmt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Purp,ValidElement_UltmtCdtr,ValidElement_CdtrAcct,ValidElement_Cdtr,ValidElement_CdtrAgtAcct,ValidElement_CdtrAgt,ValidElement_DbtrAgtAcct,ValidElement_DbtrAgt,ValidElement_DbtrAcct,ValidElement_Dbtr,ValidElement_UltmtDbtr,ValidElement_RmtInf,ValidElement_MndtRltdInf,ValidElement_PmtTpInf,ValidElement_SttlmInf,ValidElement_CdtrSchmeId,ValidElement_ReqdExctnDt,ValidElement_Amt,ValidElement_IntrBkSttlmAmt)|

---

## Value Pacs002001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.PartyIdentification135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|Pacs002001.Contact4||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|Pacs002001.Party38Choice||XmlElement()||
|+|PstlAdr|Pacs002001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||ValidElement_CtctDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CtctDtls)|
||ValidPattern_CtryOfRes|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("CtryOfRes",CtryOfRes,"[A-Z]{2,2}")|
||ValidElement_Id|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Id)|
||ValidElement_PstlAdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PstlAdr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CtctDtls,ValidPattern_CtryOfRes,ValidElement_Id,ValidElement_PstlAdr)|

---

## Value Pacs002001.PaymentTransaction130


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|List<Pacs002001.SupplementaryData1>||XmlElement()||
|+|OrgnlTxRef|Pacs002001.OriginalTransactionReference35||XmlElement()||
|+|InstdAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|ClrSysRef|String||XmlElement()||
|+|AcctSvcrRef|String||XmlElement()||
|+|FctvIntrBkSttlmDt|Pacs002001.DateAndDateTime2Choice||XmlElement()||
|+|AccptncDtTm|DateTime||XmlElement()||
|+|ChrgsInf|List<Pacs002001.Charges7>||XmlElement()||
|+|StsRsnInf|List<Pacs002001.StatusReasonInformation12>||XmlElement()||
|+|TxSts|String||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlTxId|String||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|OrgnlGrpInf|Pacs002001.OriginalGroupInformation29||XmlElement()||
|+|StsId|String||XmlElement()||
||ValidList_SplmtryData|Some(String)||XmlIgnore(), JsonIgnore()|validList("SplmtryData",SplmtryData)|
||ValidElement_SplmtryData|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SplmtryData)|
||ValidElement_OrgnlTxRef|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlTxRef)|
||ValidElement_InstdAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstdAgt)|
||ValidElement_InstgAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstgAgt)|
||ValidElement_FctvIntrBkSttlmDt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FctvIntrBkSttlmDt)|
||ValidList_ChrgsInf|Some(String)||XmlIgnore(), JsonIgnore()|validList("ChrgsInf",ChrgsInf)|
||ValidElement_ChrgsInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ChrgsInf)|
||ValidList_StsRsnInf|Some(String)||XmlIgnore(), JsonIgnore()|validList("StsRsnInf",StsRsnInf)|
||ValidElement_StsRsnInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(StsRsnInf)|
||ValidPattern_OrgnlUETR|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("OrgnlUETR",OrgnlUETR,"[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}")|
||ValidElement_OrgnlGrpInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlGrpInf)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_SplmtryData,ValidElement_SplmtryData,ValidElement_OrgnlTxRef,ValidElement_InstdAgt,ValidElement_InstgAgt,ValidElement_FctvIntrBkSttlmDt,ValidList_ChrgsInf,ValidElement_ChrgsInf,ValidList_StsRsnInf,ValidElement_StsRsnInf,ValidPattern_OrgnlUETR,ValidElement_OrgnlGrpInf)|

---

## Value Pacs002001.PaymentTypeInformation27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|Pacs002001.CategoryPurpose1Choice||XmlElement()||
|+|SeqTp|String||XmlElement()||
|+|LclInstrm|Pacs002001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|List<Pacs002001.ServiceLevel8Choice>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||ValidElement_CtgyPurp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CtgyPurp)|
||ValidElement_LclInstrm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(LclInstrm)|
||ValidList_SvcLvl|Some(String)||XmlIgnore(), JsonIgnore()|validList("SvcLvl",SvcLvl)|
||ValidElement_SvcLvl|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SvcLvl)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CtgyPurp,ValidElement_LclInstrm,ValidList_SvcLvl,ValidElement_SvcLvl)|

---

## Value Pacs002001.PersonIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|List<Pacs002001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|Pacs002001.DateAndPlaceOfBirth1||XmlElement()||
||ValidList_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validList("Othr",Othr)|
||ValidElement_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Othr)|
||ValidElement_DtAndPlcOfBirth|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DtAndPlcOfBirth)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Othr,ValidElement_Othr,ValidElement_DtAndPlcOfBirth)|

---

## Value Pacs002001.PostalAddress24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|Pacs002001.AddressType3Choice||XmlElement()||
||ValidListMax_AdrLine|Some(String)||XmlIgnore(), JsonIgnore()|validListMax("AdrLine",AdrLine,7)|
||ValidPattern_Ctry|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("Ctry",Ctry,"[A-Z]{2,2}")|
||ValidElement_AdrTp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AdrTp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidListMax_AdrLine,ValidPattern_Ctry,ValidElement_AdrTp)|

---

## Value Pacs002001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|Pacs002001.ProxyAccountType1Choice||XmlElement()||
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Tp)|

---

## Value Pacs002001.ReferredDocumentInformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|List<Pacs002001.DocumentLineInformation1>||XmlElement()||
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|Pacs002001.ReferredDocumentType4||XmlElement()||
||ValidList_LineDtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("LineDtls",LineDtls)|
||ValidElement_LineDtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(LineDtls)|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_LineDtls,ValidElement_LineDtls,ValidElement_Tp)|

---

## Value Pacs002001.ReferredDocumentType4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|Pacs002001.ReferredDocumentType3Choice||XmlElement()||
||ValidElement_CdOrPrtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdOrPrtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CdOrPrtry)|

---

## Value Pacs002001.RemittanceAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|List<Pacs002001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|List<Pacs002001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|List<Pacs002001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidElement_RmtdAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RmtdAmt)|
||ValidList_AdjstmntAmtAndRsn|Some(String)||XmlIgnore(), JsonIgnore()|validList("AdjstmntAmtAndRsn",AdjstmntAmtAndRsn)|
||ValidElement_AdjstmntAmtAndRsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AdjstmntAmtAndRsn)|
||ValidList_TaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validList("TaxAmt",TaxAmt)|
||ValidElement_TaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TaxAmt)|
||ValidElement_CdtNoteAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtNoteAmt)|
||ValidList_DscntApldAmt|Some(String)||XmlIgnore(), JsonIgnore()|validList("DscntApldAmt",DscntApldAmt)|
||ValidElement_DscntApldAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DscntApldAmt)|
||ValidElement_DuePyblAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DuePyblAmt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RmtdAmt,ValidList_AdjstmntAmtAndRsn,ValidElement_AdjstmntAmtAndRsn,ValidList_TaxAmt,ValidElement_TaxAmt,ValidElement_CdtNoteAmt,ValidList_DscntApldAmt,ValidElement_DscntApldAmt,ValidElement_DuePyblAmt)|

---

## Value Pacs002001.RemittanceAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|List<Pacs002001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|List<Pacs002001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|List<Pacs002001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidElement_RmtdAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RmtdAmt)|
||ValidList_AdjstmntAmtAndRsn|Some(String)||XmlIgnore(), JsonIgnore()|validList("AdjstmntAmtAndRsn",AdjstmntAmtAndRsn)|
||ValidElement_AdjstmntAmtAndRsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(AdjstmntAmtAndRsn)|
||ValidList_TaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validList("TaxAmt",TaxAmt)|
||ValidElement_TaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TaxAmt)|
||ValidElement_CdtNoteAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtNoteAmt)|
||ValidList_DscntApldAmt|Some(String)||XmlIgnore(), JsonIgnore()|validList("DscntApldAmt",DscntApldAmt)|
||ValidElement_DscntApldAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DscntApldAmt)|
||ValidElement_DuePyblAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DuePyblAmt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_RmtdAmt,ValidList_AdjstmntAmtAndRsn,ValidElement_AdjstmntAmtAndRsn,ValidList_TaxAmt,ValidElement_TaxAmt,ValidElement_CdtNoteAmt,ValidList_DscntApldAmt,ValidElement_DscntApldAmt,ValidElement_DuePyblAmt)|

---

## Value Pacs002001.RemittanceInformation21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|List<Pacs002001.StructuredRemittanceInformation17>||XmlElement()||
|+|Ustrd|List<String>||XmlElement()||
||ValidList_Strd|Some(String)||XmlIgnore(), JsonIgnore()|validList("Strd",Strd)|
||ValidElement_Strd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Strd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Strd,ValidElement_Strd)|

---

## Value Pacs002001.SettlementInstruction11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrdRmbrsmntAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|ThrdRmbrsmntAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstdRmbrsmntAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|InstdRmbrsmntAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgRmbrsmntAgtAcct|Pacs002001.CashAccount40||XmlElement()||
|+|InstgRmbrsmntAgt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|ClrSys|Pacs002001.ClearingSystemIdentification3Choice||XmlElement()||
|+|SttlmAcct|Pacs002001.CashAccount40||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
||ValidElement_ThrdRmbrsmntAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ThrdRmbrsmntAgtAcct)|
||ValidElement_ThrdRmbrsmntAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ThrdRmbrsmntAgt)|
||ValidElement_InstdRmbrsmntAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstdRmbrsmntAgtAcct)|
||ValidElement_InstdRmbrsmntAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstdRmbrsmntAgt)|
||ValidElement_InstgRmbrsmntAgtAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstgRmbrsmntAgtAcct)|
||ValidElement_InstgRmbrsmntAgt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstgRmbrsmntAgt)|
||ValidElement_ClrSys|Some(String)||XmlIgnore(), JsonIgnore()|validElement(ClrSys)|
||ValidElement_SttlmAcct|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SttlmAcct)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_ThrdRmbrsmntAgtAcct,ValidElement_ThrdRmbrsmntAgt,ValidElement_InstdRmbrsmntAgtAcct,ValidElement_InstdRmbrsmntAgt,ValidElement_InstgRmbrsmntAgtAcct,ValidElement_InstgRmbrsmntAgt,ValidElement_ClrSys,ValidElement_SttlmAcct)|

---

## Value Pacs002001.StatusReasonInformation12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|List<String>||XmlElement()||
|+|Rsn|Pacs002001.StatusReason6Choice||XmlElement()||
|+|Orgtr|Pacs002001.PartyIdentification135||XmlElement()||
||ValidElement_Rsn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Rsn)|
||ValidElement_Orgtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Orgtr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Rsn,ValidElement_Orgtr)|

---

## Value Pacs002001.StructuredRemittanceInformation17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|List<String>||XmlElement()||
|+|GrnshmtRmt|Pacs002001.Garnishment3||XmlElement()||
|+|TaxRmt|Pacs002001.TaxData1||XmlElement()||
|+|Invcee|Pacs002001.PartyIdentification135||XmlElement()||
|+|Invcr|Pacs002001.PartyIdentification135||XmlElement()||
|+|CdtrRefInf|Pacs002001.CreditorReferenceInformation2||XmlElement()||
|+|RfrdDocAmt|Pacs002001.RemittanceAmount2||XmlElement()||
|+|RfrdDocInf|List<Pacs002001.ReferredDocumentInformation7>||XmlElement()||
||ValidListMax_AddtlRmtInf|Some(String)||XmlIgnore(), JsonIgnore()|validListMax("AddtlRmtInf",AddtlRmtInf,3)|
||ValidElement_GrnshmtRmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(GrnshmtRmt)|
||ValidElement_TaxRmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TaxRmt)|
||ValidElement_Invcee|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Invcee)|
||ValidElement_Invcr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Invcr)|
||ValidElement_CdtrRefInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtrRefInf)|
||ValidElement_RfrdDocAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RfrdDocAmt)|
||ValidList_RfrdDocInf|Some(String)||XmlIgnore(), JsonIgnore()|validList("RfrdDocInf",RfrdDocInf)|
||ValidElement_RfrdDocInf|Some(String)||XmlIgnore(), JsonIgnore()|validElement(RfrdDocInf)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidListMax_AddtlRmtInf,ValidElement_GrnshmtRmt,ValidElement_TaxRmt,ValidElement_Invcee,ValidElement_Invcr,ValidElement_CdtrRefInf,ValidElement_RfrdDocAmt,ValidList_RfrdDocInf,ValidElement_RfrdDocInf)|

---

## Value Pacs002001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|Pacs002001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||ValidElement_Envlp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Envlp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Envlp)|

---

## Value Pacs002001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.TaxAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|List<Pacs002001.TaxRecordDetails3>||XmlElement()||
|+|TtlAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||ValidList_Dtls|Some(String)||XmlIgnore(), JsonIgnore()|validList("Dtls",Dtls)|
||ValidElement_Dtls|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Dtls)|
||ValidElement_TtlAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlAmt)|
||ValidElement_TaxblBaseAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TaxblBaseAmt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Dtls,ValidElement_Dtls,ValidElement_TtlAmt,ValidElement_TaxblBaseAmt)|

---

## Value Pacs002001.TaxAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|Pacs002001.TaxAmountType1Choice||XmlElement()||
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||ValidElement_Tp|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Tp)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt,ValidElement_Tp)|

---

## Value Pacs002001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.TaxData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|List<Pacs002001.TaxRecord3>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|Pacs002001.TaxParty2||XmlElement()||
|+|Dbtr|Pacs002001.TaxParty2||XmlElement()||
|+|Cdtr|Pacs002001.TaxParty1||XmlElement()||
||ValidList_Rcrd|Some(String)||XmlIgnore(), JsonIgnore()|validList("Rcrd",Rcrd)|
||ValidElement_Rcrd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Rcrd)|
||ValidElement_TtlTaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlTaxAmt)|
||ValidElement_TtlTaxblBaseAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TtlTaxblBaseAmt)|
||ValidElement_UltmtDbtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(UltmtDbtr)|
||ValidElement_Dbtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Dbtr)|
||ValidElement_Cdtr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Cdtr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_Rcrd,ValidElement_Rcrd,ValidElement_TtlTaxAmt,ValidElement_TtlTaxblBaseAmt,ValidElement_UltmtDbtr,ValidElement_Dbtr,ValidElement_Cdtr)|

---

## Value Pacs002001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value Pacs002001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|Pacs002001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||ValidElement_Authstn|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Authstn)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Authstn)|

---

## Value Pacs002001.TaxPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|Pacs002001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||ValidElement_FrToDt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FrToDt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_FrToDt)|

---

## Value Pacs002001.TaxRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|Pacs002001.TaxAmount3||XmlElement()||
|+|Prd|Pacs002001.TaxPeriod3||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||ValidElement_TaxAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TaxAmt)|
||ValidElement_Prd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_TaxAmt,ValidElement_Prd)|

---

## Value Pacs002001.TaxRecordDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|Pacs002001.TaxPeriod3||XmlElement()||
||ValidElement_Amt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Amt)|
||ValidElement_Prd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Amt,ValidElement_Prd)|

---

## Entity Pacs002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FIToFIPmtStsRpt|Pacs002001.FIToFIPaymentStatusReportV12||XmlElement()||
||ValidElement_FIToFIPmtStsRpt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(FIToFIPmtStsRpt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_FIToFIPmtStsRpt)|

---

## Aspect Pacs002001.FIToFIPaymentStatusReportV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|List<Pacs002001.SupplementaryData1>||XmlElement()||
|+|TxInfAndSts|List<Pacs002001.PaymentTransaction130>||XmlElement()||
|+|OrgnlGrpInfAndSts|List<Pacs002001.OriginalGroupHeader17>||XmlElement()||
|+|GrpHdr|Pacs002001.GroupHeader101||XmlElement()||
||ValidList_SplmtryData|Some(String)||XmlIgnore(), JsonIgnore()|validList("SplmtryData",SplmtryData)|
||ValidElement_SplmtryData|Some(String)||XmlIgnore(), JsonIgnore()|validElement(SplmtryData)|
||ValidList_TxInfAndSts|Some(String)||XmlIgnore(), JsonIgnore()|validList("TxInfAndSts",TxInfAndSts)|
||ValidElement_TxInfAndSts|Some(String)||XmlIgnore(), JsonIgnore()|validElement(TxInfAndSts)|
||ValidList_OrgnlGrpInfAndSts|Some(String)||XmlIgnore(), JsonIgnore()|validList("OrgnlGrpInfAndSts",OrgnlGrpInfAndSts)|
||ValidElement_OrgnlGrpInfAndSts|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgnlGrpInfAndSts)|
||ValidElement_GrpHdr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(GrpHdr)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidList_SplmtryData,ValidElement_SplmtryData,ValidList_TxInfAndSts,ValidElement_TxInfAndSts,ValidList_OrgnlGrpInfAndSts,ValidElement_OrgnlGrpInfAndSts,ValidElement_GrpHdr)|

---

## Value Pacs002001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|Pacs002001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Othr,IBAN)|
||ValidElement_Othr|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Othr)|
||ValidPattern_IBAN|Some(String)||XmlIgnore(), JsonIgnore()|validPattern("IBAN",IBAN,"[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}")|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Othr,ValidPattern_IBAN,ValidChoice)|

---

## Value Pacs002001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|Pacs002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||ValidElement_Prtry|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prtry)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Prtry,ValidChoice)|

---

## Value Pacs002001.AmountType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EqvtAmt|Pacs002001.EquivalentAmount2||XmlElement()||
|+|InstdAmt|Pacs002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(EqvtAmt,InstdAmt)|
||ValidElement_EqvtAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(EqvtAmt)|
||ValidElement_InstdAmt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(InstdAmt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_EqvtAmt,ValidElement_InstdAmt,ValidChoice)|

---

## Value Pacs002001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.ClearingSystemIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.CreditorReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(DtTm,Dt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.DiscountAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.Frequency36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|Pacs002001.FrequencyAndMoment1||XmlElement()||
|+|Prd|Pacs002001.FrequencyPeriod1||XmlElement()||
|+|Tp|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(PtInTm,Prd,Tp)|
||ValidElement_PtInTm|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PtInTm)|
||ValidElement_Prd|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Prd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_PtInTm,ValidElement_Prd,ValidChoice)|

---

## Value Pacs002001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.MandateClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.MandateRelatedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtTrfMndt|Pacs002001.CreditTransferMandateData1||XmlElement()||
|+|DrctDbtMndt|Pacs002001.MandateRelatedInformation15||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(CdtTrfMndt,DrctDbtMndt)|
||ValidElement_CdtTrfMndt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(CdtTrfMndt)|
||ValidElement_DrctDbtMndt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(DrctDbtMndt)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_CdtTrfMndt,ValidElement_DrctDbtMndt,ValidChoice)|

---

## Value Pacs002001.MandateSetupReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.Party38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|Pacs002001.PersonIdentification13||XmlElement()||
|+|OrgId|Pacs002001.OrganisationIdentification29||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(PrvtId,OrgId)|
||ValidElement_PrvtId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(PrvtId)|
||ValidElement_OrgId|Some(String)||XmlIgnore(), JsonIgnore()|validElement(OrgId)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_PrvtId,ValidElement_OrgId,ValidChoice)|

---

## Value Pacs002001.Party40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|Pacs002001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Pty|Pacs002001.PartyIdentification135||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Agt,Pty)|
||ValidElement_Agt|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Agt)|
||ValidElement_Pty|Some(String)||XmlIgnore(), JsonIgnore()|validElement(Pty)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidElement_Agt,ValidElement_Pty,ValidChoice)|

---

## Value Pacs002001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.ReferredDocumentType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.StatusReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## Value Pacs002001.TaxAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||ValidChoice|Some(String)||XmlIgnore(), JsonIgnore()|validChoice(Prtry,Cd)|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(ValidChoice)|

---

## View Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Edge|||From = this|
||Tos|Edge|||To = this|

