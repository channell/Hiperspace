# sese.011.001.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese011001.Account33 {
        + SubAcctDtls  : ISO20022.Sese011001.SubAccount5
        + Svcr  : ISO20022.Sese011001.PartyIdentification132
        + Tp  : ISO20022.Sese011001.GenericIdentification30
        + AcctNm  : String
        + AcctDsgnt  : String
        + AcctId  : String
        + OwnrId  : ISO20022.Sese011001.PartyIdentification132
    }
    ISO20022.Sese011001.Account33 *-- ISO20022.Sese011001.SubAccount5
    ISO20022.Sese011001.Account33 *-- ISO20022.Sese011001.PartyIdentification132
    ISO20022.Sese011001.Account33 *-- ISO20022.Sese011001.GenericIdentification30
    ISO20022.Sese011001.Account33 *-- ISO20022.Sese011001.PartyIdentification132
    class ISO20022.Sese011001.Account34 {
        + RegnAdr  : ISO20022.Sese011001.PostalAddress1
        + AcctSvcr  : ISO20022.Sese011001.PartyIdentification132
        + AcctNm  : String
        + AcctDsgnt  : String
        + AcctId  : String
    }
    ISO20022.Sese011001.Account34 *-- ISO20022.Sese011001.PostalAddress1
    ISO20022.Sese011001.Account34 *-- ISO20022.Sese011001.PartyIdentification132
    class ISO20022.Sese011001.AccountIdentificationAndName6 {
        + Othr  : ISO20022.Sese011001.GenericAccountIdentification1
        + IBAN  : String
        + Nm  : String
    }
    ISO20022.Sese011001.AccountIdentificationAndName6 *-- ISO20022.Sese011001.GenericAccountIdentification1
    class ISO20022.Sese011001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese011001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese011001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese011001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese011001.AdditionalInformation15 {
        + InfVal  : String
        + InfTp  : ISO20022.Sese011001.GenericIdentification36
    }
    ISO20022.Sese011001.AdditionalInformation15 *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese011001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese011001.AdditionalReference10 *-- ISO20022.Sese011001.PartyIdentification139
    class ISO20022.Sese011001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese011001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Sese011001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Sese011001.AlternateSecurityIdentification7 *-- ISO20022.Sese011001.IdentificationSource1Choice
    class ISO20022.Sese011001.ApplicableRules1Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.ApplicableRules1Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.ApplicableRules1Code {
        YPRE = 1
        NPRE = 2
    }
    class ISO20022.Sese011001.BeneficiaryDrawdown1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + DthUdrLmt  : String
        + BnfcryTp  : ISO20022.Sese011001.BeneficiaryType1Choice
    }
    ISO20022.Sese011001.BeneficiaryDrawdown1 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.BeneficiaryDrawdown1 *-- ISO20022.Sese011001.BeneficiaryType1Choice
    class ISO20022.Sese011001.BeneficiaryType1Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.BeneficiaryType1Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.BeneficiaryType1Code {
        SUCC = 1
        NOMI = 2
        DEPE = 3
    }
    class ISO20022.Sese011001.BenefitCrystallisationEvent2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + LftmAllwncPrtcn  : String
        + PctgOfAllwnc  : Decimal
        + CrstllstnAmt  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + EvtDt  : DateTime
        + EvtTpNm  : String
        + EvtTpNb  : String
    }
    ISO20022.Sese011001.BenefitCrystallisationEvent2 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.BenefitCrystallisationEvent2 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese011001.BranchData2 {
        + PstlAdr  : ISO20022.Sese011001.PostalAddress6
        + Nm  : String
        + Id  : String
    }
    ISO20022.Sese011001.BranchData2 *-- ISO20022.Sese011001.PostalAddress6
    class ISO20022.Sese011001.CancellationPendingStatus7Choice {
        + NoSpcfdRsn  : String
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + Rsn  : String
    }
    ISO20022.Sese011001.CancellationPendingStatus7Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.CancelledStatus13Choice {
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + XtndedRsn  : String
        + Rsn  : String
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese011001.CancelledStatus13Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.CancelledStatusReason3Code {
        CNIN = 1
        CNCL = 2
        CNTA = 3
    }
    class ISO20022.Sese011001.Capped1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + IncmLmtNxtPrd  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + IncmCurPrd  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + IncmLmtCurPrd  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + StartDt  : DateTime
    }
    ISO20022.Sese011001.Capped1 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.Capped1 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.Capped1 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.Capped1 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese011001.CashAsset3 {
        + AddtlInf  : ISO20022.Sese011001.AdditionalInformation15
        + TrfCcy  : String
        + HldgCcy  : String
        + CshAsstTp  : ISO20022.Sese011001.CashAssetType1Choice
    }
    ISO20022.Sese011001.CashAsset3 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.CashAsset3 *-- ISO20022.Sese011001.CashAssetType1Choice
    class ISO20022.Sese011001.CashAssetType1Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.CashAssetType1Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.CashAssetType1Code {
        CSH1 = 1
        CSH2 = 2
    }
    class ISO20022.Sese011001.ChargeBasis2Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.ChargeBasis2Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.ChargeOrCommissionDiscount1 {
        + Bsis  : ISO20022.Sese011001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese011001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese011001.WaivingInstruction2Choice
    ISO20022.Sese011001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    class ISO20022.Sese011001.ChargeType5Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.ChargeType5Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.Cheque12 {
        + DrwrId  : ISO20022.Sese011001.PartyIdentification139
        + DrweeId  : ISO20022.Sese011001.FinancialInstitutionIdentification17
        + PyeeId  : ISO20022.Sese011001.PartyIdentification139
        + Nb  : String
    }
    ISO20022.Sese011001.Cheque12 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.Cheque12 *-- ISO20022.Sese011001.FinancialInstitutionIdentification17
    ISO20022.Sese011001.Cheque12 *-- ISO20022.Sese011001.PartyIdentification139
    class ISO20022.Sese011001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese011001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese011001.ClassificationType32Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice {
        + OthrClrCdId  : String
        + PLKNR  : String
        + GRHEBIC  : String
        + INIFSC  : String
        + AUBSBs  : String
        + AUBSBx  : String
        + HKNCC  : String
        + ZANCC  : String
        + ESNCC  : String
        + DEBLZ  : String
        + CHSIC  : String
        + CACPA  : String
        + ATBLZ  : String
        + ITNCC  : String
        + RUCB  : String
        + PTNCC  : String
        + USFW  : String
        + CHBC  : String
        + USCH  : String
        + GBSC  : String
        + IENSC  : String
        + NZNCC  : String
        + USCHU  : String
    }
    class ISO20022.Sese011001.ClearingSystemMemberIdentification4Choice {
        + AUBSBs  : String
        + AUBSBx  : String
        + HKNCC  : String
        + ZANCC  : String
        + ESNCC  : String
        + DEBLZ  : String
        + CHSIC  : String
        + CACPA  : String
        + ATBLZ  : String
        + ITNCC  : String
        + RUCB  : String
        + PTNCC  : String
        + USFW  : String
        + CHBC  : String
        + USCH  : String
        + GBSC  : String
        + IENSC  : String
        + NZNCC  : String
        + USCHU  : String
    }
    class ISO20022.Sese011001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Sese011001.Conversion2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + UnitsDtls  : global::System.Collections.Generic.List~ISO20022.Sese011001.Unit13~
        + TtlUnitsNb  : Decimal
        + SrcScty  : ISO20022.Sese011001.FinancialInstrumentIdentification1
    }
    ISO20022.Sese011001.Conversion2 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.Conversion2 *-- ISO20022.Sese011001.Unit13
    ISO20022.Sese011001.Conversion2 *-- ISO20022.Sese011001.FinancialInstrumentIdentification1
    class ISO20022.Sese011001.CreditTransfer9 {
        + CdtrAcct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + Cdtr  : ISO20022.Sese011001.PartyIdentification132
        + CdtrAgtAcct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + CdtrAgt  : ISO20022.Sese011001.FinancialInstitutionIdentification16
        + IntrmyAgt2Acct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + IntrmyAgt2  : ISO20022.Sese011001.FinancialInstitutionIdentification16
        + IntrmyAgt1Acct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + IntrmyAgt1  : ISO20022.Sese011001.FinancialInstitutionIdentification16
        + DbtrAgtAcct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + DbtrAgt  : ISO20022.Sese011001.FinancialInstitutionIdentification16
        + DbtrAcct  : ISO20022.Sese011001.AccountIdentificationAndName6
        + Dbtr  : ISO20022.Sese011001.PartyIdentification132
    }
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.PartyIdentification132
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.FinancialInstitutionIdentification16
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.FinancialInstitutionIdentification16
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.FinancialInstitutionIdentification16
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.FinancialInstitutionIdentification16
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.AccountIdentificationAndName6
    ISO20022.Sese011001.CreditTransfer9 *-- ISO20022.Sese011001.PartyIdentification132
    class ISO20022.Sese011001.DateFormat42Choice {
        + YrMnthDay  : DateTime
        + YrMnth  : String
    }
    class ISO20022.Sese011001.Drawdown2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + FlxblDrwdwnTrggrdDt  : DateTime
        + CapdLmts  : ISO20022.Sese011001.Capped1
        + BnfcryDtls  : ISO20022.Sese011001.BeneficiaryDrawdown1
        + RcptOfDrwdwnInd  : String
        + LftmAllwnc  : Decimal
        + MltplPnsnCmcmntLumpSums  : String
        + PnsnCmcmntLumpSumDt  : DateTime
        + PnsnCmcmntLumpSumRmng  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + AddtlFndsDsgntd  : String
        + TtlAmtNetDrwdwn  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + PctgOfTtlTrfVal  : Decimal
        + InvstrTaxRef  : ISO20022.Sese011001.TaxReference2
        + AplblRules  : ISO20022.Sese011001.ApplicableRules1Choice
        + TrchTp  : ISO20022.Sese011001.DrawdownType2Choice
        + Id  : String
    }
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.Capped1
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.BeneficiaryDrawdown1
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.TaxReference2
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.ApplicableRules1Choice
    ISO20022.Sese011001.Drawdown2 *-- ISO20022.Sese011001.DrawdownType2Choice
    class ISO20022.Sese011001.Drawdown3 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + MplymntDtls  : ISO20022.Sese011001.EmploymentDetails1
    }
    ISO20022.Sese011001.Drawdown3 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.Drawdown3 *-- ISO20022.Sese011001.EmploymentDetails1
    class ISO20022.Sese011001.DrawdownType2Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.DrawdownType2Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.DrawdownType2Code {
        FLEX = 1
        CAPP = 2
        BOTH = 3
    }
    class ISO20022.Sese011001.EmploymentDetails1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + EndDt  : ISO20022.Sese011001.DateFormat42Choice
        + StartDt  : ISO20022.Sese011001.DateFormat42Choice
        + PrvsTax  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + PrvsPay  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + CmltvTaxInd  : String
        + OthrTaxCdInd  : String
        + TaxCd  : ISO20022.Sese011001.GenericIdentification36
    }
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.DateFormat42Choice
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.DateFormat42Choice
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.EmploymentDetails1 *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Sese011001.FailedSettlementStatus2Choice {
        + NoSpcfdRsn  : String
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + Rsn  : String
    }
    ISO20022.Sese011001.FailedSettlementStatus2Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.Fee5 {
        + InftvInd  : String
        + RcptId  : ISO20022.Sese011001.PartyIdentification139
        + NonStdSLARef  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + DscntDtls  : ISO20022.Sese011001.ChargeOrCommissionDiscount1
        + StdRate  : Decimal
        + StdAmt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese011001.ChargeBasis2Choice
        + Tp  : ISO20022.Sese011001.ChargeType5Choice
    }
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.ChargeOrCommissionDiscount1
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.ChargeBasis2Choice
    ISO20022.Sese011001.Fee5 *-- ISO20022.Sese011001.ChargeType5Choice
    class ISO20022.Sese011001.FinancialInstitutionIdentification10Choice {
        + PrtryId  : String
        + ClrSysMmbId  : ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice
        + BICFI  : String
        + NmAndAdr  : ISO20022.Sese011001.NameAndAddress5
    }
    ISO20022.Sese011001.FinancialInstitutionIdentification10Choice *-- ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice
    ISO20022.Sese011001.FinancialInstitutionIdentification10Choice *-- ISO20022.Sese011001.NameAndAddress5
    class ISO20022.Sese011001.FinancialInstitutionIdentification16 {
        + BrnchId  : ISO20022.Sese011001.BranchData2
        + PrtryId  : String
        + LEI  : String
        + NmAndAdr  : ISO20022.Sese011001.NameAndAddress5
        + ClrSysMmbId  : ISO20022.Sese011001.ClearingSystemMemberIdentification4Choice
        + BICFI  : String
    }
    ISO20022.Sese011001.FinancialInstitutionIdentification16 *-- ISO20022.Sese011001.BranchData2
    ISO20022.Sese011001.FinancialInstitutionIdentification16 *-- ISO20022.Sese011001.NameAndAddress5
    ISO20022.Sese011001.FinancialInstitutionIdentification16 *-- ISO20022.Sese011001.ClearingSystemMemberIdentification4Choice
    class ISO20022.Sese011001.FinancialInstitutionIdentification17 {
        + LEI  : String
        + Pty  : ISO20022.Sese011001.FinancialInstitutionIdentification10Choice
    }
    ISO20022.Sese011001.FinancialInstitutionIdentification17 *-- ISO20022.Sese011001.FinancialInstitutionIdentification10Choice
    class ISO20022.Sese011001.FinancialInstrument63Choice {
        + OthrAsst  : ISO20022.Sese011001.OtherAsset2
        + CshAsst  : ISO20022.Sese011001.CashAsset3
        + Scty  : ISO20022.Sese011001.FinancialInstrumentIdentification2
    }
    ISO20022.Sese011001.FinancialInstrument63Choice *-- ISO20022.Sese011001.OtherAsset2
    ISO20022.Sese011001.FinancialInstrument63Choice *-- ISO20022.Sese011001.CashAsset3
    ISO20022.Sese011001.FinancialInstrument63Choice *-- ISO20022.Sese011001.FinancialInstrumentIdentification2
    class ISO20022.Sese011001.FinancialInstrumentIdentification1 {
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese011001.SecurityIdentification25Choice
    }
    ISO20022.Sese011001.FinancialInstrumentIdentification1 *-- ISO20022.Sese011001.SecurityIdentification25Choice
    class ISO20022.Sese011001.FinancialInstrumentIdentification2 {
        + ClssfctnTp  : ISO20022.Sese011001.ClassificationType32Choice
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese011001.SecurityIdentification25Choice
    }
    ISO20022.Sese011001.FinancialInstrumentIdentification2 *-- ISO20022.Sese011001.ClassificationType32Choice
    ISO20022.Sese011001.FinancialInstrumentIdentification2 *-- ISO20022.Sese011001.SecurityIdentification25Choice
    class ISO20022.Sese011001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Sese011001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Sese011001.GenericAccountIdentification1 *-- ISO20022.Sese011001.AccountSchemeName1Choice
    class ISO20022.Sese011001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese011001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese011001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese011001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese011001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Sese011001.InRepairStatus4Choice {
        + NoSpcfdRsn  : String
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + Rsn  : String
    }
    ISO20022.Sese011001.InRepairStatus4Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.Intermediary48 {
        + CtctPrsn  : ISO20022.Sese011001.ContactIdentification2
        + Role  : ISO20022.Sese011001.Role8Choice
        + Acct  : ISO20022.Sese011001.Account34
        + Id  : ISO20022.Sese011001.PartyIdentification132
    }
    ISO20022.Sese011001.Intermediary48 *-- ISO20022.Sese011001.ContactIdentification2
    ISO20022.Sese011001.Intermediary48 *-- ISO20022.Sese011001.Role8Choice
    ISO20022.Sese011001.Intermediary48 *-- ISO20022.Sese011001.Account34
    ISO20022.Sese011001.Intermediary48 *-- ISO20022.Sese011001.PartyIdentification132
    class ISO20022.Sese011001.InvestmentFundFee1Code {
        PENA = 1
        REGF = 2
        UCIC = 3
        SWIT = 4
        SHIP = 5
        CHAR = 6
        PREM = 7
        POST = 8
        ADDF = 9
        INIT = 10
        FEND = 11
        DLEV = 12
        CBCH = 13
        CDSC = 14
        CDPL = 15
        COMM = 16
        BRKF = 17
        BEND = 18
    }
    class ISO20022.Sese011001.InvestmentFundRole8Code {
        DATP = 1
        CONC = 2
        CACO = 3
        REGI = 4
        UCL2 = 5
        UCL1 = 6
        TRAN = 7
        TRAG = 8
        INVS = 9
        INVE = 10
        INTR = 11
        FMCO = 12
        DIST = 13
        CUST = 14
    }
    class ISO20022.Sese011001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Sese011001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Sese011001.NameAndAddress5 {
        + Adr  : ISO20022.Sese011001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese011001.NameAndAddress5 *-- ISO20022.Sese011001.PostalAddress1
    class ISO20022.Sese011001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Sese011001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese011001.OtherAmount1 {
        + Amt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese011001.OtherAmountType1Choice
    }
    ISO20022.Sese011001.OtherAmount1 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.OtherAmount1 *-- ISO20022.Sese011001.OtherAmountType1Choice
    class ISO20022.Sese011001.OtherAmountType1Choice {
        + PrtryCd  : ISO20022.Sese011001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Sese011001.OtherAmountType1Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.OtherAmountType1Code {
        SINT = 1
        PINT = 2
    }
    class ISO20022.Sese011001.OtherAsset2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + OthrId  : global::System.Collections.Generic.List~String~
        + Desc  : String
        + Nm  : String
        + Id  : String
        + OthrAsstTp  : ISO20022.Sese011001.OtherAsset2Choice
    }
    ISO20022.Sese011001.OtherAsset2 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.OtherAsset2 *-- ISO20022.Sese011001.OtherAsset2Choice
    class ISO20022.Sese011001.OtherAsset2Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.OtherAsset2Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.OtherAsset2Code {
        TIPP = 1
        PROP = 2
        MOVE = 3
        EXIA = 4
        DIMA = 5
    }
    class ISO20022.Sese011001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Sese011001.NameAndAddress5
        + PrtryId  : ISO20022.Sese011001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese011001.PartyIdentification125Choice *-- ISO20022.Sese011001.NameAndAddress5
    ISO20022.Sese011001.PartyIdentification125Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.PartyIdentification132 {
        + LEI  : String
        + PrtryId  : ISO20022.Sese011001.GenericIdentification1
        + NmAndAdr  : ISO20022.Sese011001.NameAndAddress5
        + ClrSysMmbId  : ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice
        + AnyBIC  : String
    }
    ISO20022.Sese011001.PartyIdentification132 *-- ISO20022.Sese011001.GenericIdentification1
    ISO20022.Sese011001.PartyIdentification132 *-- ISO20022.Sese011001.NameAndAddress5
    ISO20022.Sese011001.PartyIdentification132 *-- ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice
    class ISO20022.Sese011001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Sese011001.PartyIdentification125Choice
    }
    ISO20022.Sese011001.PartyIdentification139 *-- ISO20022.Sese011001.PartyIdentification125Choice
    class ISO20022.Sese011001.PaymentInstrument18 {
        + CshSttlmDtls  : ISO20022.Sese011001.PaymentInstrument25Choice
        + PmtDt  : DateTime
        + Amt  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + Ref  : String
    }
    ISO20022.Sese011001.PaymentInstrument18 *-- ISO20022.Sese011001.PaymentInstrument25Choice
    ISO20022.Sese011001.PaymentInstrument18 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese011001.PaymentInstrument25Choice {
        + ChqDtls  : ISO20022.Sese011001.Cheque12
        + CdtTrfDtls  : ISO20022.Sese011001.CreditTransfer9
    }
    ISO20022.Sese011001.PaymentInstrument25Choice *-- ISO20022.Sese011001.Cheque12
    ISO20022.Sese011001.PaymentInstrument25Choice *-- ISO20022.Sese011001.CreditTransfer9
    class ISO20022.Sese011001.PendingSettlementStatus3Choice {
        + NoSpcfdRsn  : String
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + XtndedRsn  : String
        + Rsn  : String
    }
    ISO20022.Sese011001.PendingSettlementStatus3Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.PendingSettlementStatusReason2Code {
        FVER = 1
        NRCP = 2
        ESCA = 3
        XCNF = 4
        TAPR = 5
        SDUT = 6
        WCPA = 7
        OVER = 8
        CYDV = 9
        CYIN = 10
        DRJC = 11
        ADS2 = 12
        ADS1 = 13
        ADRQ = 14
        LPRO = 15
        STST = 16
        AFST = 17
        ASTA = 18
        USUA = 19
        WTRF = 20
        AINV = 21
        CINV = 22
        IINV = 23
        ACOP = 24
        MINF = 25
        SBLO = 26
        PHSE = 27
        PHCK = 28
        LINK = 29
        LACK = 30
        IAAD = 31
        DOCY = 32
        DOCC = 33
        CLAC = 34
        CAIS = 35
        BLOC = 36
        AWSH = 37
    }
    class ISO20022.Sese011001.PersonIdentificationType7Code {
        ITIN = 1
        GTIN = 2
        ATIN = 3
    }
    class ISO20022.Sese011001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese011001.PostalAddress6 {
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
    class ISO20022.Sese011001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Sese011001.PriceValue1 {
        + Amt  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Sese011001.PriceValue1 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese011001.References64Choice {
        + OthrRef  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalReference10~
        + RltdRef  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalReference10~
    }
    ISO20022.Sese011001.References64Choice *-- ISO20022.Sese011001.AdditionalReference10
    ISO20022.Sese011001.References64Choice *-- ISO20022.Sese011001.AdditionalReference10
    class ISO20022.Sese011001.RejectedReason45Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.RejectedReason45Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.RejectedStatusReason13Code {
        NCMP = 1
        URSC = 2
        UPAY = 3
        DTRD = 4
        NCRR = 5
        IVAG = 6
        PRCT = 7
        DMON = 8
        INTE = 9
        IPAC = 10
        ICAG = 11
        DINV = 12
        BMRV = 13
        ILLI = 14
        COSE = 15
        BLTR = 16
        NQTY = 17
        NASS = 18
        ACLO = 19
        NCON = 20
        OTHR = 21
        ISAT = 22
        DEPT = 23
        ISTP = 24
        DDAT = 25
        DLVY = 26
        PTNS = 27
        SECU = 28
        NSLA = 29
        LEGL = 30
        INUK = 31
        SAFE = 32
        INNA = 33
        INPM = 34
        CASH = 35
        INAC = 36
        INID = 37
        FTAX = 38
        DQUA = 39
        IDNA = 40
        DSEC = 41
        TREF = 42
        CYPA = 43
        ICTN = 44
        IAQD = 45
        DOCC = 46
        BLCA = 47
    }
    class ISO20022.Sese011001.RejectionReason56 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese011001.RejectedReason45Choice
    }
    ISO20022.Sese011001.RejectionReason56 *-- ISO20022.Sese011001.RejectedReason45Choice
    class ISO20022.Sese011001.ReversedStatus2Choice {
        + NoSpcfdRsn  : String
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + Rsn  : String
    }
    ISO20022.Sese011001.ReversedStatus2Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.Role8Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.Role8Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Sese011001.AlternateSecurityIdentification7
        + Cmon  : String
        + Belgn  : String
        + SCVM  : String
        + Vlrn  : String
        + Dtch  : String
        + Wrtppr  : String
        + QUICK  : String
        + CTA  : String
        + Blmbrg  : String
        + TckrSymb  : String
        + RIC  : String
        + CUSIP  : String
        + SEDOL  : String
        + ISIN  : String
    }
    ISO20022.Sese011001.SecurityIdentification25Choice *-- ISO20022.Sese011001.AlternateSecurityIdentification7
    class ISO20022.Sese011001.SubAccount5 {
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Sese011001.Tax35 {
        + TaxClctnDtls  : ISO20022.Sese011001.TaxCalculationInformation10
        + RcptId  : ISO20022.Sese011001.PartyIdentification139
        + Ctry  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese011001.TaxType3Choice
    }
    ISO20022.Sese011001.Tax35 *-- ISO20022.Sese011001.TaxCalculationInformation10
    ISO20022.Sese011001.Tax35 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.Tax35 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.Tax35 *-- ISO20022.Sese011001.TaxType3Choice
    class ISO20022.Sese011001.TaxBasis1Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.TaxBasis1Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.TaxCalculationInformation10 {
        + TaxblAmt  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese011001.TaxBasis1Choice
    }
    ISO20022.Sese011001.TaxCalculationInformation10 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.TaxCalculationInformation10 *-- ISO20022.Sese011001.TaxBasis1Choice
    class ISO20022.Sese011001.TaxReference2 {
        + Ref  : String
        + Tp  : ISO20022.Sese011001.TaxReferenceType1Choice
    }
    ISO20022.Sese011001.TaxReference2 *-- ISO20022.Sese011001.TaxReferenceType1Choice
    class ISO20022.Sese011001.TaxReferenceType1Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese011001.TaxReferenceType1Choice *-- ISO20022.Sese011001.GenericIdentification36
    class ISO20022.Sese011001.TaxType17Code {
        ZWIS = 1
        AKT2 = 2
        AKT1 = 3
        EUTR = 4
        COAX = 5
        GIFT = 6
        CTAX = 7
        SOSU = 8
        INHT = 9
        WTAX = 10
        STAM = 11
        INPO = 12
        NKAP = 13
        KAPA = 14
        WITH = 15
        STAT = 16
        NATI = 17
        PROV = 18
    }
    class ISO20022.Sese011001.TaxType3Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.TaxType3Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Sese011001.TaxationBasis2Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Sese011001.TaxationBasis5Code {
        PERU = 1
        NAVP = 2
        NEAM = 3
        GRAM = 4
        FLAT = 5
    }
    class ISO20022.Sese011001.TotalFeesAndTaxes41 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Sese011001.Tax35~
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Sese011001.Fee5~
        + ComrclAgrmtRef  : String
        + TtlTaxs  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + TtlFees  : ISO20022.Sese011001.ActiveCurrencyAndAmount
        + TtlOvrhdApld  : ISO20022.Sese011001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese011001.TotalFeesAndTaxes41 *-- ISO20022.Sese011001.Tax35
    ISO20022.Sese011001.TotalFeesAndTaxes41 *-- ISO20022.Sese011001.Fee5
    ISO20022.Sese011001.TotalFeesAndTaxes41 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.TotalFeesAndTaxes41 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    ISO20022.Sese011001.TotalFeesAndTaxes41 *-- ISO20022.Sese011001.ActiveCurrencyAndAmount
    class ISO20022.Sese011001.TransferInstructionStatus5 {
        + Rsn  : String
        + Sts  : String
    }
    class ISO20022.Sese011001.TransferInstructionStatusReportV09 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Sese011001.Extension1~
        + MktPrctcVrsn  : ISO20022.Sese011001.MarketPracticeVersion1
        + StsRpt  : ISO20022.Sese011001.TransferStatusAndReason8
        + Ref  : ISO20022.Sese011001.References64Choice
        + CtrPtyRef  : ISO20022.Sese011001.AdditionalReference10
        + MsgId  : ISO20022.Sese011001.MessageIdentification1
    }
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.Extension1
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.MarketPracticeVersion1
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.TransferStatusAndReason8
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.References64Choice
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.AdditionalReference10
    ISO20022.Sese011001.TransferInstructionStatusReportV09 *-- ISO20022.Sese011001.MessageIdentification1
    class ISO20022.Sese011001.TransferStatus5Choice {
        + CxlPdg  : ISO20022.Sese011001.CancellationPendingStatus7Choice
        + Rvsd  : ISO20022.Sese011001.ReversedStatus2Choice
        + Canc  : ISO20022.Sese011001.CancelledStatus13Choice
        + FaildSttlm  : ISO20022.Sese011001.FailedSettlementStatus2Choice
        + Rjctd  : global::System.Collections.Generic.List~ISO20022.Sese011001.RejectionReason56~
        + InRpr  : ISO20022.Sese011001.InRepairStatus4Choice
        + Umtchd  : ISO20022.Sese011001.TransferUnmatchedStatus4Choice
        + PdgSttlm  : ISO20022.Sese011001.PendingSettlementStatus3Choice
        + Sts  : ISO20022.Sese011001.TransferInstructionStatus5
    }
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.CancellationPendingStatus7Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.ReversedStatus2Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.CancelledStatus13Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.FailedSettlementStatus2Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.RejectionReason56
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.InRepairStatus4Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.TransferUnmatchedStatus4Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.PendingSettlementStatus3Choice
    ISO20022.Sese011001.TransferStatus5Choice *-- ISO20022.Sese011001.TransferInstructionStatus5
    class ISO20022.Sese011001.TransferStatus6Code {
        SETT = 1
        STNP = 2
        RECE = 3
        MACH = 4
        DELY = 5
        COMP = 6
        COSE = 7
        PACK = 8
    }
    class ISO20022.Sese011001.TransferStatusAndReason8 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.AdditionalInformation15~
        + StsRcpt  : ISO20022.Sese011001.PartyIdentification139
        + StsIssr  : ISO20022.Sese011001.PartyIdentification139
        + StsInitr  : ISO20022.Sese011001.PartyIdentification139
        + QryRspn  : global::System.Collections.Generic.List~String~
        + OthrDrwdwnInf  : ISO20022.Sese011001.Drawdown3
        + DrwdwnTrch  : global::System.Collections.Generic.List~ISO20022.Sese011001.Drawdown2~
        + BnftCrstllstnEvt  : global::System.Collections.Generic.List~ISO20022.Sese011001.BenefitCrystallisationEvent2~
        + PmtDtls  : global::System.Collections.Generic.List~ISO20022.Sese011001.PaymentInstrument18~
        + TtlTrfVal  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + Convs  : ISO20022.Sese011001.Conversion2
        + UnitsDtls  : global::System.Collections.Generic.List~ISO20022.Sese011001.Unit11~
        + AvrgPric  : ISO20022.Sese011001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + TtlUnitsNb  : Decimal
        + CshSttlmDt  : DateTime
        + SndOutDt  : DateTime
        + SttlmDt  : DateTime
        + TradDt  : DateTime
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Sese011001.Intermediary48~
        + InvstmtAcctDtls  : ISO20022.Sese011001.Account33
        + Instrm  : ISO20022.Sese011001.FinancialInstrument63Choice
        + TrfSts  : ISO20022.Sese011001.TransferStatus5Choice
        + TrfEvtTp  : global::System.Collections.Generic.List~ISO20022.Sese011001.TransferStatusType3Choice~
        + CxlRef  : String
        + ClntRef  : ISO20022.Sese011001.AdditionalReference10
        + TrfRef  : String
        + MstrRef  : String
    }
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.AdditionalInformation15
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.PartyIdentification139
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Drawdown3
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Drawdown2
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.BenefitCrystallisationEvent2
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.PaymentInstrument18
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Conversion2
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Unit11
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Intermediary48
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.Account33
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.FinancialInstrument63Choice
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.TransferStatus5Choice
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.TransferStatusType3Choice
    ISO20022.Sese011001.TransferStatusAndReason8 *-- ISO20022.Sese011001.AdditionalReference10
    class ISO20022.Sese011001.TransferStatusType2Code {
        CONV = 1
        S001 = 2
        S005 = 3
        STAT = 4
        INFO = 5
        S012 = 6
        PAYA = 7
        DRAW = 8
        SETT = 9
        BCEV = 10
        S019 = 11
    }
    class ISO20022.Sese011001.TransferStatusType3Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Sese011001.TransferStatusType3Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.TransferUnmatchedReason3Code {
        SAFE = 1
        ICUS = 2
        DQUA = 3
        DDAT = 4
        DEPT = 5
        PODU = 6
        PHYS = 7
        DSEC = 8
        DELN = 9
        CPCA = 10
        CMIS = 11
    }
    class ISO20022.Sese011001.TransferUnmatchedStatus4Choice {
        + DataSrcSchme  : ISO20022.Sese011001.GenericIdentification1
        + XtndedRsn  : String
        + Rsn  : String
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese011001.TransferUnmatchedStatus4Choice *-- ISO20022.Sese011001.GenericIdentification1
    class ISO20022.Sese011001.TypeOfPrice10Code {
        ACTU = 1
        DDVR = 2
        SWIC = 3
        RINV = 4
        MIDD = 5
        SWNG = 6
        INTE = 7
        CANC = 8
        CREA = 9
        NAVL = 10
        OFFR = 11
        BIDE = 12
    }
    class ISO20022.Sese011001.TypeOfPrice46Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.TypeOfPrice46Choice *-- ISO20022.Sese011001.GenericIdentification47
    class ISO20022.Sese011001.UKTaxGroupUnit1Code {
        GRP2 = 1
        GRP1 = 2
    }
    class ISO20022.Sese011001.Unit11 {
        + OthrAmt  : global::System.Collections.Generic.List~ISO20022.Sese011001.OtherAmount1~
        + TxOvrhd  : ISO20022.Sese011001.TotalFeesAndTaxes41
        + PricDtls  : ISO20022.Sese011001.UnitPrice23
        + Ref  : String
        + Grp1Or2Units  : String
        + CertNb  : global::System.Collections.Generic.List~String~
        + AcqstnDt  : DateTime
        + OrdrDt  : DateTime
        + UnitsNb  : Decimal
    }
    ISO20022.Sese011001.Unit11 *-- ISO20022.Sese011001.OtherAmount1
    ISO20022.Sese011001.Unit11 *-- ISO20022.Sese011001.TotalFeesAndTaxes41
    ISO20022.Sese011001.Unit11 *-- ISO20022.Sese011001.UnitPrice23
    class ISO20022.Sese011001.Unit13 {
        + Ref  : String
        + Grp1Or2Units  : String
        + CertNb  : global::System.Collections.Generic.List~String~
        + AcqstnDt  : DateTime
        + OrdrDt  : DateTime
        + UnitsNb  : Decimal
    }
    class ISO20022.Sese011001.UnitPrice23 {
        + TaxblIncmPerShrClctd  : ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice
        + TaxblIncmPerShr  : ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
        + NbOfDaysAcrd  : Decimal
        + AcrdIntrstNAV  : ISO20022.Sese011001.ActiveOrHistoricCurrencyAndAmount
        + PricMtd  : String
        + Val  : ISO20022.Sese011001.PriceValue1
        + Tp  : ISO20022.Sese011001.TypeOfPrice46Choice
    }
    ISO20022.Sese011001.UnitPrice23 *-- ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice
    ISO20022.Sese011001.UnitPrice23 *-- ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese011001.UnitPrice23 *-- ISO20022.Sese011001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese011001.UnitPrice23 *-- ISO20022.Sese011001.PriceValue1
    ISO20022.Sese011001.UnitPrice23 *-- ISO20022.Sese011001.TypeOfPrice46Choice
    class ISO20022.Sese011001.WaivingInstruction1Code {
        WIUN = 1
        WICA = 2
    }
    class ISO20022.Sese011001.WaivingInstruction2Choice {
        + Prtry  : ISO20022.Sese011001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese011001.WaivingInstruction2Choice *-- ISO20022.Sese011001.GenericIdentification47
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

## Value ISO20022.Sese011001.Account33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Sese011001.SubAccount5||XmlElement()||
|+|Svcr|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
|+|Tp|ISO20022.Sese011001.GenericIdentification30||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|OwnrId|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(Svcr),validElement(Tp),validElement(OwnrId))|

---

## Value ISO20022.Sese011001.Account34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnAdr|ISO20022.Sese011001.PostalAddress1||XmlElement()||
|+|AcctSvcr|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegnAdr),validElement(AcctSvcr))|

---

## Value ISO20022.Sese011001.AccountIdentificationAndName6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Sese011001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""))|

---

## Value ISO20022.Sese011001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese011001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese011001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese011001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese011001.AdditionalInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|InfTp|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfTp))|

---

## Value ISO20022.Sese011001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Sese011001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese011001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Sese011001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Sese011001.ApplicableRules1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.ApplicableRules1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YPRE|Int32||XmlEnum("""YPRE""")|1|
||NPRE|Int32||XmlEnum("""NPRE""")|2|

---

## Value ISO20022.Sese011001.BeneficiaryDrawdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|DthUdrLmt|String||XmlElement()||
|+|BnfcryTp|ISO20022.Sese011001.BeneficiaryType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(BnfcryTp))|

---

## Value ISO20022.Sese011001.BeneficiaryType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.BeneficiaryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUCC|Int32||XmlEnum("""SUCC""")|1|
||NOMI|Int32||XmlEnum("""NOMI""")|2|
||DEPE|Int32||XmlEnum("""DEPE""")|3|

---

## Value ISO20022.Sese011001.BenefitCrystallisationEvent2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|LftmAllwncPrtcn|String||XmlElement()||
|+|PctgOfAllwnc|Decimal||XmlElement()||
|+|CrstllstnAmt|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|EvtTpNm|String||XmlElement()||
|+|EvtTpNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(CrstllstnAmt))|

---

## Value ISO20022.Sese011001.BranchData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Sese011001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Value ISO20022.Sese011001.CancellationPendingStatus7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(NoSpcfdRsn,DataSrcSchme,Rsn))|

---

## Value ISO20022.Sese011001.CancelledStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|XtndedRsn|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(DataSrcSchme,XtndedRsn,Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese011001.CancelledStatusReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CNIN|Int32||XmlEnum("""CNIN""")|1|
||CNCL|Int32||XmlEnum("""CNCL""")|2|
||CNTA|Int32||XmlEnum("""CNTA""")|3|

---

## Value ISO20022.Sese011001.Capped1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|IncmLmtNxtPrd|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|IncmCurPrd|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|IncmLmtCurPrd|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(IncmLmtNxtPrd),validElement(IncmCurPrd),validElement(IncmLmtCurPrd))|

---

## Value ISO20022.Sese011001.CashAsset3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese011001.AdditionalInformation15||XmlElement()||
|+|TrfCcy|String||XmlElement()||
|+|HldgCcy|String||XmlElement()||
|+|CshAsstTp|ISO20022.Sese011001.CashAssetType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""TrfCcy""",TrfCcy,"""[A-Z]{3,3}"""),validPattern("""HldgCcy""",HldgCcy,"""[A-Z]{3,3}"""),validElement(CshAsstTp))|

---

## Value ISO20022.Sese011001.CashAssetType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.CashAssetType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSH1|Int32||XmlEnum("""CSH1""")|1|
||CSH2|Int32||XmlEnum("""CSH2""")|2|

---

## Value ISO20022.Sese011001.ChargeBasis2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.ChargeOrCommissionDiscount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Sese011001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Sese011001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.Cheque12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrwrId|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|DrweeId|ISO20022.Sese011001.FinancialInstitutionIdentification17||XmlElement()||
|+|PyeeId|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrwrId),validElement(DrweeId),validElement(PyeeId))|

---

## Value ISO20022.Sese011001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClrCdId|String||XmlElement()||
|+|PLKNR|String||XmlElement()||
|+|GRHEBIC|String||XmlElement()||
|+|INIFSC|String||XmlElement()||
|+|AUBSBs|String||XmlElement()||
|+|AUBSBx|String||XmlElement()||
|+|HKNCC|String||XmlElement()||
|+|ZANCC|String||XmlElement()||
|+|ESNCC|String||XmlElement()||
|+|DEBLZ|String||XmlElement()||
|+|CHSIC|String||XmlElement()||
|+|CACPA|String||XmlElement()||
|+|ATBLZ|String||XmlElement()||
|+|ITNCC|String||XmlElement()||
|+|RUCB|String||XmlElement()||
|+|PTNCC|String||XmlElement()||
|+|USFW|String||XmlElement()||
|+|CHBC|String||XmlElement()||
|+|USCH|String||XmlElement()||
|+|GBSC|String||XmlElement()||
|+|IENSC|String||XmlElement()||
|+|NZNCC|String||XmlElement()||
|+|USCHU|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PLKNR""",PLKNR,"""PL[0-9]{8,8}"""),validPattern("""GRHEBIC""",GRHEBIC,"""GR[0-9]{7,7}"""),validPattern("""INIFSC""",INIFSC,"""IN[a-zA-Z0-9]{11,11}"""),validPattern("""AUBSBs""",AUBSBs,"""AU[0-9]{6,6}"""),validPattern("""AUBSBx""",AUBSBx,"""AU[0-9]{6,6}"""),validPattern("""HKNCC""",HKNCC,"""HK[0-9]{3,3}"""),validPattern("""ZANCC""",ZANCC,"""ZA[0-9]{6,6}"""),validPattern("""ESNCC""",ESNCC,"""ES[0-9]{8,9}"""),validPattern("""DEBLZ""",DEBLZ,"""BL[0-9]{8,8}"""),validPattern("""CHSIC""",CHSIC,"""SW[0-9]{6,6}"""),validPattern("""CACPA""",CACPA,"""CA[0-9]{9,9}"""),validPattern("""ATBLZ""",ATBLZ,"""AT[0-9]{5,5}"""),validPattern("""ITNCC""",ITNCC,"""IT[0-9]{10,10}"""),validPattern("""RUCB""",RUCB,"""RU[0-9]{9,9}"""),validPattern("""PTNCC""",PTNCC,"""PT[0-9]{8,8}"""),validPattern("""USFW""",USFW,"""FW[0-9]{9,9}"""),validPattern("""CHBC""",CHBC,"""SW[0-9]{3,5}"""),validPattern("""USCH""",USCH,"""CP[0-9]{4,4}"""),validPattern("""GBSC""",GBSC,"""SC[0-9]{6,6}"""),validPattern("""IENSC""",IENSC,"""IE[0-9]{6,6}"""),validPattern("""NZNCC""",NZNCC,"""NZ[0-9]{6,6}"""),validPattern("""USCHU""",USCHU,"""CH[0-9]{6,6}"""),validChoice(OthrClrCdId,PLKNR,GRHEBIC,INIFSC,AUBSBs,AUBSBx,HKNCC,ZANCC,ESNCC,DEBLZ,CHSIC,CACPA,ATBLZ,ITNCC,RUCB,PTNCC,USFW,CHBC,USCH,GBSC,IENSC,NZNCC,USCHU))|

---

## Value ISO20022.Sese011001.ClearingSystemMemberIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AUBSBs|String||XmlElement()||
|+|AUBSBx|String||XmlElement()||
|+|HKNCC|String||XmlElement()||
|+|ZANCC|String||XmlElement()||
|+|ESNCC|String||XmlElement()||
|+|DEBLZ|String||XmlElement()||
|+|CHSIC|String||XmlElement()||
|+|CACPA|String||XmlElement()||
|+|ATBLZ|String||XmlElement()||
|+|ITNCC|String||XmlElement()||
|+|RUCB|String||XmlElement()||
|+|PTNCC|String||XmlElement()||
|+|USFW|String||XmlElement()||
|+|CHBC|String||XmlElement()||
|+|USCH|String||XmlElement()||
|+|GBSC|String||XmlElement()||
|+|IENSC|String||XmlElement()||
|+|NZNCC|String||XmlElement()||
|+|USCHU|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AUBSBs""",AUBSBs,"""AU[0-9]{6,6}"""),validPattern("""AUBSBx""",AUBSBx,"""AU[0-9]{6,6}"""),validPattern("""HKNCC""",HKNCC,"""HK[0-9]{3,3}"""),validPattern("""ZANCC""",ZANCC,"""ZA[0-9]{6,6}"""),validPattern("""ESNCC""",ESNCC,"""ES[0-9]{8,9}"""),validPattern("""DEBLZ""",DEBLZ,"""BL[0-9]{8,8}"""),validPattern("""CHSIC""",CHSIC,"""SW[0-9]{6,6}"""),validPattern("""CACPA""",CACPA,"""CA[0-9]{9,9}"""),validPattern("""ATBLZ""",ATBLZ,"""AT[0-9]{5,5}"""),validPattern("""ITNCC""",ITNCC,"""IT[0-9]{10,10}"""),validPattern("""RUCB""",RUCB,"""RU[0-9]{9,9}"""),validPattern("""PTNCC""",PTNCC,"""PT[0-9]{8,8}"""),validPattern("""USFW""",USFW,"""FW[0-9]{9,9}"""),validPattern("""CHBC""",CHBC,"""SW[0-9]{3,5}"""),validPattern("""USCH""",USCH,"""CP[0-9]{4,4}"""),validPattern("""GBSC""",GBSC,"""SC[0-9]{6,6}"""),validPattern("""IENSC""",IENSC,"""IE[0-9]{6,6}"""),validPattern("""NZNCC""",NZNCC,"""NZ[0-9]{6,6}"""),validPattern("""USCHU""",USCHU,"""CH[0-9]{6,6}"""),validChoice(AUBSBs,AUBSBx,HKNCC,ZANCC,ESNCC,DEBLZ,CHSIC,CACPA,ATBLZ,ITNCC,RUCB,PTNCC,USFW,CHBC,USCH,GBSC,IENSC,NZNCC,USCHU))|

---

## Value ISO20022.Sese011001.ContactIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Sese011001.Conversion2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|UnitsDtls|global::System.Collections.Generic.List<ISO20022.Sese011001.Unit13>||XmlElement()||
|+|TtlUnitsNb|Decimal||XmlElement()||
|+|SrcScty|ISO20022.Sese011001.FinancialInstrumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""UnitsDtls""",UnitsDtls),validElement(UnitsDtls),validElement(SrcScty))|

---

## Value ISO20022.Sese011001.CreditTransfer9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|Cdtr|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|CdtrAgt|ISO20022.Sese011001.FinancialInstitutionIdentification16||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|IntrmyAgt2|ISO20022.Sese011001.FinancialInstitutionIdentification16||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|IntrmyAgt1|ISO20022.Sese011001.FinancialInstitutionIdentification16||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|DbtrAgt|ISO20022.Sese011001.FinancialInstitutionIdentification16||XmlElement()||
|+|DbtrAcct|ISO20022.Sese011001.AccountIdentificationAndName6||XmlElement()||
|+|Dbtr|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Sese011001.DateFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|YrMnthDay|DateTime||XmlElement()||
|+|YrMnth|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(YrMnthDay,YrMnth))|

---

## Type ISO20022.Sese011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfInstrStsRpt|ISO20022.Sese011001.TransferInstructionStatusReportV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrfInstrStsRpt))|

---

## Value ISO20022.Sese011001.Drawdown2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|FlxblDrwdwnTrggrdDt|DateTime||XmlElement()||
|+|CapdLmts|ISO20022.Sese011001.Capped1||XmlElement()||
|+|BnfcryDtls|ISO20022.Sese011001.BeneficiaryDrawdown1||XmlElement()||
|+|RcptOfDrwdwnInd|String||XmlElement()||
|+|LftmAllwnc|Decimal||XmlElement()||
|+|MltplPnsnCmcmntLumpSums|String||XmlElement()||
|+|PnsnCmcmntLumpSumDt|DateTime||XmlElement()||
|+|PnsnCmcmntLumpSumRmng|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AddtlFndsDsgntd|String||XmlElement()||
|+|TtlAmtNetDrwdwn|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PctgOfTtlTrfVal|Decimal||XmlElement()||
|+|InvstrTaxRef|ISO20022.Sese011001.TaxReference2||XmlElement()||
|+|AplblRules|ISO20022.Sese011001.ApplicableRules1Choice||XmlElement()||
|+|TrchTp|ISO20022.Sese011001.DrawdownType2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(CapdLmts),validElement(BnfcryDtls),validElement(PnsnCmcmntLumpSumRmng),validElement(TtlAmtNetDrwdwn),validElement(InvstrTaxRef),validElement(AplblRules),validElement(TrchTp))|

---

## Value ISO20022.Sese011001.Drawdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|MplymntDtls|ISO20022.Sese011001.EmploymentDetails1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(MplymntDtls))|

---

## Value ISO20022.Sese011001.DrawdownType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.DrawdownType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLEX|Int32||XmlEnum("""FLEX""")|1|
||CAPP|Int32||XmlEnum("""CAPP""")|2|
||BOTH|Int32||XmlEnum("""BOTH""")|3|

---

## Value ISO20022.Sese011001.EmploymentDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|EndDt|ISO20022.Sese011001.DateFormat42Choice||XmlElement()||
|+|StartDt|ISO20022.Sese011001.DateFormat42Choice||XmlElement()||
|+|PrvsTax|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|PrvsPay|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|CmltvTaxInd|String||XmlElement()||
|+|OthrTaxCdInd|String||XmlElement()||
|+|TaxCd|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(EndDt),validElement(StartDt),validElement(PrvsTax),validElement(PrvsPay),validElement(TaxCd))|

---

## Value ISO20022.Sese011001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.FailedSettlementStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(NoSpcfdRsn,DataSrcSchme,Rsn))|

---

## Value ISO20022.Sese011001.Fee5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InftvInd|String||XmlElement()||
|+|RcptId|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|NonStdSLARef|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|DscntDtls|ISO20022.Sese011001.ChargeOrCommissionDiscount1||XmlElement()||
|+|StdRate|Decimal||XmlElement()||
|+|StdAmt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese011001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Sese011001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(ApldAmt),validElement(DscntDtls),validElement(StdAmt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Sese011001.FinancialInstitutionIdentification10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice||XmlElement()||
|+|BICFI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese011001.NameAndAddress5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(NmAndAdr),validChoice(PrtryId,ClrSysMmbId,BICFI,NmAndAdr))|

---

## Value ISO20022.Sese011001.FinancialInstitutionIdentification16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Sese011001.BranchData2||XmlElement()||
|+|PrtryId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese011001.NameAndAddress5||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese011001.ClearingSystemMemberIdentification4Choice||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese011001.FinancialInstitutionIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese011001.FinancialInstitutionIdentification10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese011001.FinancialInstrument63Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAsst|ISO20022.Sese011001.OtherAsset2||XmlElement()||
|+|CshAsst|ISO20022.Sese011001.CashAsset3||XmlElement()||
|+|Scty|ISO20022.Sese011001.FinancialInstrumentIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrAsst),validElement(CshAsst),validElement(Scty),validChoice(OthrAsst,CshAsst,Scty))|

---

## Value ISO20022.Sese011001.FinancialInstrumentIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese011001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Sese011001.FinancialInstrumentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClssfctnTp|ISO20022.Sese011001.ClassificationType32Choice||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese011001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClssfctnTp),validElement(Id))|

---

## Value ISO20022.Sese011001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Sese011001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Sese011001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese011001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese011001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Value ISO20022.Sese011001.InRepairStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(NoSpcfdRsn,DataSrcSchme,Rsn))|

---

## Value ISO20022.Sese011001.Intermediary48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Sese011001.ContactIdentification2||XmlElement()||
|+|Role|ISO20022.Sese011001.Role8Choice||XmlElement()||
|+|Acct|ISO20022.Sese011001.Account34||XmlElement()||
|+|Id|ISO20022.Sese011001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(Role),validElement(Acct),validElement(Id))|

---

## Enum ISO20022.Sese011001.InvestmentFundFee1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PENA|Int32||XmlEnum("""PENA""")|1|
||REGF|Int32||XmlEnum("""REGF""")|2|
||UCIC|Int32||XmlEnum("""UCIC""")|3|
||SWIT|Int32||XmlEnum("""SWIT""")|4|
||SHIP|Int32||XmlEnum("""SHIP""")|5|
||CHAR|Int32||XmlEnum("""CHAR""")|6|
||PREM|Int32||XmlEnum("""PREM""")|7|
||POST|Int32||XmlEnum("""POST""")|8|
||ADDF|Int32||XmlEnum("""ADDF""")|9|
||INIT|Int32||XmlEnum("""INIT""")|10|
||FEND|Int32||XmlEnum("""FEND""")|11|
||DLEV|Int32||XmlEnum("""DLEV""")|12|
||CBCH|Int32||XmlEnum("""CBCH""")|13|
||CDSC|Int32||XmlEnum("""CDSC""")|14|
||CDPL|Int32||XmlEnum("""CDPL""")|15|
||COMM|Int32||XmlEnum("""COMM""")|16|
||BRKF|Int32||XmlEnum("""BRKF""")|17|
||BEND|Int32||XmlEnum("""BEND""")|18|

---

## Enum ISO20022.Sese011001.InvestmentFundRole8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DATP|Int32||XmlEnum("""DATP""")|1|
||CONC|Int32||XmlEnum("""CONC""")|2|
||CACO|Int32||XmlEnum("""CACO""")|3|
||REGI|Int32||XmlEnum("""REGI""")|4|
||UCL2|Int32||XmlEnum("""UCL2""")|5|
||UCL1|Int32||XmlEnum("""UCL1""")|6|
||TRAN|Int32||XmlEnum("""TRAN""")|7|
||TRAG|Int32||XmlEnum("""TRAG""")|8|
||INVS|Int32||XmlEnum("""INVS""")|9|
||INVE|Int32||XmlEnum("""INVE""")|10|
||INTR|Int32||XmlEnum("""INTR""")|11|
||FMCO|Int32||XmlEnum("""FMCO""")|12|
||DIST|Int32||XmlEnum("""DIST""")|13|
||CUST|Int32||XmlEnum("""CUST""")|14|

---

## Value ISO20022.Sese011001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese011001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese011001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Enum ISO20022.Sese011001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese011001.OtherAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese011001.OtherAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Sese011001.OtherAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryCd|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryCd),validChoice(PrtryCd,Cd))|

---

## Enum ISO20022.Sese011001.OtherAmountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SINT|Int32||XmlEnum("""SINT""")|1|
||PINT|Int32||XmlEnum("""PINT""")|2|

---

## Value ISO20022.Sese011001.OtherAsset2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|OthrAsstTp|ISO20022.Sese011001.OtherAsset2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validListMax("""OthrId""",OthrId,5),validElement(OthrAsstTp))|

---

## Value ISO20022.Sese011001.OtherAsset2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.OtherAsset2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TIPP|Int32||XmlEnum("""TIPP""")|1|
||PROP|Int32||XmlEnum("""PROP""")|2|
||MOVE|Int32||XmlEnum("""MOVE""")|3|
||EXIA|Int32||XmlEnum("""EXIA""")|4|
||DIMA|Int32||XmlEnum("""DIMA""")|5|

---

## Value ISO20022.Sese011001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese011001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese011001.PartyIdentification132


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PrtryId|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|NmAndAdr|ISO20022.Sese011001.NameAndAddress5||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese011001.ClearingSystemMemberIdentification2Choice||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PrtryId),validElement(NmAndAdr),validElement(ClrSysMmbId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese011001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese011001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese011001.PaymentInstrument18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSttlmDtls|ISO20022.Sese011001.PaymentInstrument25Choice||XmlElement()||
|+|PmtDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSttlmDtls),validElement(Amt))|

---

## Value ISO20022.Sese011001.PaymentInstrument25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChqDtls|ISO20022.Sese011001.Cheque12||XmlElement()||
|+|CdtTrfDtls|ISO20022.Sese011001.CreditTransfer9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChqDtls),validElement(CdtTrfDtls),validChoice(ChqDtls,CdtTrfDtls))|

---

## Value ISO20022.Sese011001.PendingSettlementStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|XtndedRsn|String||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(NoSpcfdRsn,DataSrcSchme,XtndedRsn,Rsn))|

---

## Enum ISO20022.Sese011001.PendingSettlementStatusReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FVER|Int32||XmlEnum("""FVER""")|1|
||NRCP|Int32||XmlEnum("""NRCP""")|2|
||ESCA|Int32||XmlEnum("""ESCA""")|3|
||XCNF|Int32||XmlEnum("""XCNF""")|4|
||TAPR|Int32||XmlEnum("""TAPR""")|5|
||SDUT|Int32||XmlEnum("""SDUT""")|6|
||WCPA|Int32||XmlEnum("""WCPA""")|7|
||OVER|Int32||XmlEnum("""OVER""")|8|
||CYDV|Int32||XmlEnum("""CYDV""")|9|
||CYIN|Int32||XmlEnum("""CYIN""")|10|
||DRJC|Int32||XmlEnum("""DRJC""")|11|
||ADS2|Int32||XmlEnum("""ADS2""")|12|
||ADS1|Int32||XmlEnum("""ADS1""")|13|
||ADRQ|Int32||XmlEnum("""ADRQ""")|14|
||LPRO|Int32||XmlEnum("""LPRO""")|15|
||STST|Int32||XmlEnum("""STST""")|16|
||AFST|Int32||XmlEnum("""AFST""")|17|
||ASTA|Int32||XmlEnum("""ASTA""")|18|
||USUA|Int32||XmlEnum("""USUA""")|19|
||WTRF|Int32||XmlEnum("""WTRF""")|20|
||AINV|Int32||XmlEnum("""AINV""")|21|
||CINV|Int32||XmlEnum("""CINV""")|22|
||IINV|Int32||XmlEnum("""IINV""")|23|
||ACOP|Int32||XmlEnum("""ACOP""")|24|
||MINF|Int32||XmlEnum("""MINF""")|25|
||SBLO|Int32||XmlEnum("""SBLO""")|26|
||PHSE|Int32||XmlEnum("""PHSE""")|27|
||PHCK|Int32||XmlEnum("""PHCK""")|28|
||LINK|Int32||XmlEnum("""LINK""")|29|
||LACK|Int32||XmlEnum("""LACK""")|30|
||IAAD|Int32||XmlEnum("""IAAD""")|31|
||DOCY|Int32||XmlEnum("""DOCY""")|32|
||DOCC|Int32||XmlEnum("""DOCC""")|33|
||CLAC|Int32||XmlEnum("""CLAC""")|34|
||CAIS|Int32||XmlEnum("""CAIS""")|35|
||BLOC|Int32||XmlEnum("""BLOC""")|36|
||AWSH|Int32||XmlEnum("""AWSH""")|37|

---

## Enum ISO20022.Sese011001.PersonIdentificationType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ITIN|Int32||XmlEnum("""ITIN""")|1|
||GTIN|Int32||XmlEnum("""GTIN""")|2|
||ATIN|Int32||XmlEnum("""ATIN""")|3|

---

## Value ISO20022.Sese011001.PostalAddress1


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

## Value ISO20022.Sese011001.PostalAddress6


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

## Enum ISO20022.Sese011001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Sese011001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese011001.References64Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRef|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalReference10>||XmlElement()||
|+|RltdRef|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalReference10>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OthrRef""",OthrRef),validList("""OthrRef""",OthrRef),validListMax("""OthrRef""",OthrRef,2),validElement(OthrRef),validRequired("""RltdRef""",RltdRef),validList("""RltdRef""",RltdRef),validListMax("""RltdRef""",RltdRef,2),validElement(RltdRef),validChoice(OthrRef,RltdRef))|

---

## Value ISO20022.Sese011001.RejectedReason45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.RejectedStatusReason13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCMP|Int32||XmlEnum("""NCMP""")|1|
||URSC|Int32||XmlEnum("""URSC""")|2|
||UPAY|Int32||XmlEnum("""UPAY""")|3|
||DTRD|Int32||XmlEnum("""DTRD""")|4|
||NCRR|Int32||XmlEnum("""NCRR""")|5|
||IVAG|Int32||XmlEnum("""IVAG""")|6|
||PRCT|Int32||XmlEnum("""PRCT""")|7|
||DMON|Int32||XmlEnum("""DMON""")|8|
||INTE|Int32||XmlEnum("""INTE""")|9|
||IPAC|Int32||XmlEnum("""IPAC""")|10|
||ICAG|Int32||XmlEnum("""ICAG""")|11|
||DINV|Int32||XmlEnum("""DINV""")|12|
||BMRV|Int32||XmlEnum("""BMRV""")|13|
||ILLI|Int32||XmlEnum("""ILLI""")|14|
||COSE|Int32||XmlEnum("""COSE""")|15|
||BLTR|Int32||XmlEnum("""BLTR""")|16|
||NQTY|Int32||XmlEnum("""NQTY""")|17|
||NASS|Int32||XmlEnum("""NASS""")|18|
||ACLO|Int32||XmlEnum("""ACLO""")|19|
||NCON|Int32||XmlEnum("""NCON""")|20|
||OTHR|Int32||XmlEnum("""OTHR""")|21|
||ISAT|Int32||XmlEnum("""ISAT""")|22|
||DEPT|Int32||XmlEnum("""DEPT""")|23|
||ISTP|Int32||XmlEnum("""ISTP""")|24|
||DDAT|Int32||XmlEnum("""DDAT""")|25|
||DLVY|Int32||XmlEnum("""DLVY""")|26|
||PTNS|Int32||XmlEnum("""PTNS""")|27|
||SECU|Int32||XmlEnum("""SECU""")|28|
||NSLA|Int32||XmlEnum("""NSLA""")|29|
||LEGL|Int32||XmlEnum("""LEGL""")|30|
||INUK|Int32||XmlEnum("""INUK""")|31|
||SAFE|Int32||XmlEnum("""SAFE""")|32|
||INNA|Int32||XmlEnum("""INNA""")|33|
||INPM|Int32||XmlEnum("""INPM""")|34|
||CASH|Int32||XmlEnum("""CASH""")|35|
||INAC|Int32||XmlEnum("""INAC""")|36|
||INID|Int32||XmlEnum("""INID""")|37|
||FTAX|Int32||XmlEnum("""FTAX""")|38|
||DQUA|Int32||XmlEnum("""DQUA""")|39|
||IDNA|Int32||XmlEnum("""IDNA""")|40|
||DSEC|Int32||XmlEnum("""DSEC""")|41|
||TREF|Int32||XmlEnum("""TREF""")|42|
||CYPA|Int32||XmlEnum("""CYPA""")|43|
||ICTN|Int32||XmlEnum("""ICTN""")|44|
||IAQD|Int32||XmlEnum("""IAQD""")|45|
||DOCC|Int32||XmlEnum("""DOCC""")|46|
||BLCA|Int32||XmlEnum("""BLCA""")|47|

---

## Value ISO20022.Sese011001.RejectionReason56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese011001.RejectedReason45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese011001.ReversedStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(NoSpcfdRsn,DataSrcSchme,Rsn))|

---

## Value ISO20022.Sese011001.Role8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Sese011001.AlternateSecurityIdentification7||XmlElement()||
|+|Cmon|String||XmlElement()||
|+|Belgn|String||XmlElement()||
|+|SCVM|String||XmlElement()||
|+|Vlrn|String||XmlElement()||
|+|Dtch|String||XmlElement()||
|+|Wrtppr|String||XmlElement()||
|+|QUICK|String||XmlElement()||
|+|CTA|String||XmlElement()||
|+|Blmbrg|String||XmlElement()||
|+|TckrSymb|String||XmlElement()||
|+|RIC|String||XmlElement()||
|+|CUSIP|String||XmlElement()||
|+|SEDOL|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPrtryId),validPattern("""Blmbrg""",Blmbrg,"""(BBG)[BCDFGHJKLMNPQRSTVWXYZ\d]{8}\d"""),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN))|

---

## Value ISO20022.Sese011001.SubAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.Tax35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Sese011001.TaxCalculationInformation10||XmlElement()||
|+|RcptId|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese011001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(ApldAmt),validElement(Tp))|

---

## Value ISO20022.Sese011001.TaxBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.TaxCalculationInformation10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblAmt|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese011001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblAmt),validElement(Bsis))|

---

## Value ISO20022.Sese011001.TaxReference2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Sese011001.TaxReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese011001.TaxReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.TaxType17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ZWIS|Int32||XmlEnum("""ZWIS""")|1|
||AKT2|Int32||XmlEnum("""AKT2""")|2|
||AKT1|Int32||XmlEnum("""AKT1""")|3|
||EUTR|Int32||XmlEnum("""EUTR""")|4|
||COAX|Int32||XmlEnum("""COAX""")|5|
||GIFT|Int32||XmlEnum("""GIFT""")|6|
||CTAX|Int32||XmlEnum("""CTAX""")|7|
||SOSU|Int32||XmlEnum("""SOSU""")|8|
||INHT|Int32||XmlEnum("""INHT""")|9|
||WTAX|Int32||XmlEnum("""WTAX""")|10|
||STAM|Int32||XmlEnum("""STAM""")|11|
||INPO|Int32||XmlEnum("""INPO""")|12|
||NKAP|Int32||XmlEnum("""NKAP""")|13|
||KAPA|Int32||XmlEnum("""KAPA""")|14|
||WITH|Int32||XmlEnum("""WITH""")|15|
||STAT|Int32||XmlEnum("""STAT""")|16|
||NATI|Int32||XmlEnum("""NATI""")|17|
||PROV|Int32||XmlEnum("""PROV""")|18|

---

## Value ISO20022.Sese011001.TaxType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Enum ISO20022.Sese011001.TaxationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Enum ISO20022.Sese011001.TaxationBasis5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||NAVP|Int32||XmlEnum("""NAVP""")|2|
||NEAM|Int32||XmlEnum("""NEAM""")|3|
||GRAM|Int32||XmlEnum("""GRAM""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|

---

## Value ISO20022.Sese011001.TotalFeesAndTaxes41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Sese011001.Tax35>||XmlElement()||
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Sese011001.Fee5>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
|+|TtlTaxs|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlFees|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlOvrhdApld|ISO20022.Sese011001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""IndvFee""",IndvFee),validElement(IndvFee),validElement(TtlTaxs),validElement(TtlFees),validElement(TtlOvrhdApld))|

---

## Value ISO20022.Sese011001.TransferInstructionStatus5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Sese011001.TransferInstructionStatusReportV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Sese011001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Sese011001.MarketPracticeVersion1||XmlElement()||
|+|StsRpt|ISO20022.Sese011001.TransferStatusAndReason8||XmlElement()||
|+|Ref|ISO20022.Sese011001.References64Choice||XmlElement()||
|+|CtrPtyRef|ISO20022.Sese011001.AdditionalReference10||XmlElement()||
|+|MsgId|ISO20022.Sese011001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validElement(StsRpt),validElement(Ref),validElement(CtrPtyRef),validElement(MsgId))|

---

## Value ISO20022.Sese011001.TransferStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlPdg|ISO20022.Sese011001.CancellationPendingStatus7Choice||XmlElement()||
|+|Rvsd|ISO20022.Sese011001.ReversedStatus2Choice||XmlElement()||
|+|Canc|ISO20022.Sese011001.CancelledStatus13Choice||XmlElement()||
|+|FaildSttlm|ISO20022.Sese011001.FailedSettlementStatus2Choice||XmlElement()||
|+|Rjctd|global::System.Collections.Generic.List<ISO20022.Sese011001.RejectionReason56>||XmlElement()||
|+|InRpr|ISO20022.Sese011001.InRepairStatus4Choice||XmlElement()||
|+|Umtchd|ISO20022.Sese011001.TransferUnmatchedStatus4Choice||XmlElement()||
|+|PdgSttlm|ISO20022.Sese011001.PendingSettlementStatus3Choice||XmlElement()||
|+|Sts|ISO20022.Sese011001.TransferInstructionStatus5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlPdg),validElement(Rvsd),validElement(Canc),validElement(FaildSttlm),validRequired("""Rjctd""",Rjctd),validList("""Rjctd""",Rjctd),validListMax("""Rjctd""",Rjctd,10),validElement(Rjctd),validElement(InRpr),validElement(Umtchd),validElement(PdgSttlm),validElement(Sts),validChoice(CxlPdg,Rvsd,Canc,FaildSttlm,Rjctd,InRpr,Umtchd,PdgSttlm,Sts))|

---

## Enum ISO20022.Sese011001.TransferStatus6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETT|Int32||XmlEnum("""SETT""")|1|
||STNP|Int32||XmlEnum("""STNP""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|
||MACH|Int32||XmlEnum("""MACH""")|4|
||DELY|Int32||XmlEnum("""DELY""")|5|
||COMP|Int32||XmlEnum("""COMP""")|6|
||COSE|Int32||XmlEnum("""COSE""")|7|
||PACK|Int32||XmlEnum("""PACK""")|8|

---

## Value ISO20022.Sese011001.TransferStatusAndReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese011001.AdditionalInformation15>||XmlElement()||
|+|StsRcpt|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|StsIssr|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|StsInitr|ISO20022.Sese011001.PartyIdentification139||XmlElement()||
|+|QryRspn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|OthrDrwdwnInf|ISO20022.Sese011001.Drawdown3||XmlElement()||
|+|DrwdwnTrch|global::System.Collections.Generic.List<ISO20022.Sese011001.Drawdown2>||XmlElement()||
|+|BnftCrstllstnEvt|global::System.Collections.Generic.List<ISO20022.Sese011001.BenefitCrystallisationEvent2>||XmlElement()||
|+|PmtDtls|global::System.Collections.Generic.List<ISO20022.Sese011001.PaymentInstrument18>||XmlElement()||
|+|TtlTrfVal|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Convs|ISO20022.Sese011001.Conversion2||XmlElement()||
|+|UnitsDtls|global::System.Collections.Generic.List<ISO20022.Sese011001.Unit11>||XmlElement()||
|+|AvrgPric|ISO20022.Sese011001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|TtlUnitsNb|Decimal||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
|+|SndOutDt|DateTime||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Sese011001.Intermediary48>||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Sese011001.Account33||XmlElement()||
|+|Instrm|ISO20022.Sese011001.FinancialInstrument63Choice||XmlElement()||
|+|TrfSts|ISO20022.Sese011001.TransferStatus5Choice||XmlElement()||
|+|TrfEvtTp|global::System.Collections.Generic.List<ISO20022.Sese011001.TransferStatusType3Choice>||XmlElement()||
|+|CxlRef|String||XmlElement()||
|+|ClntRef|ISO20022.Sese011001.AdditionalReference10||XmlElement()||
|+|TrfRef|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(StsRcpt),validElement(StsIssr),validElement(StsInitr),validElement(OthrDrwdwnInf),validList("""DrwdwnTrch""",DrwdwnTrch),validElement(DrwdwnTrch),validList("""BnftCrstllstnEvt""",BnftCrstllstnEvt),validElement(BnftCrstllstnEvt),validList("""PmtDtls""",PmtDtls),validElement(PmtDtls),validElement(TtlTrfVal),validElement(Convs),validList("""UnitsDtls""",UnitsDtls),validElement(UnitsDtls),validElement(AvrgPric),validList("""IntrmyInf""",IntrmyInf),validElement(IntrmyInf),validElement(InvstmtAcctDtls),validElement(Instrm),validElement(TrfSts),validList("""TrfEvtTp""",TrfEvtTp),validElement(TrfEvtTp),validElement(ClntRef))|

---

## Enum ISO20022.Sese011001.TransferStatusType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONV|Int32||XmlEnum("""CONV""")|1|
||S001|Int32||XmlEnum("""S001""")|2|
||S005|Int32||XmlEnum("""S005""")|3|
||STAT|Int32||XmlEnum("""STAT""")|4|
||INFO|Int32||XmlEnum("""INFO""")|5|
||S012|Int32||XmlEnum("""S012""")|6|
||PAYA|Int32||XmlEnum("""PAYA""")|7|
||DRAW|Int32||XmlEnum("""DRAW""")|8|
||SETT|Int32||XmlEnum("""SETT""")|9|
||BCEV|Int32||XmlEnum("""BCEV""")|10|
||S019|Int32||XmlEnum("""S019""")|11|

---

## Value ISO20022.Sese011001.TransferStatusType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.TransferUnmatchedReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SAFE|Int32||XmlEnum("""SAFE""")|1|
||ICUS|Int32||XmlEnum("""ICUS""")|2|
||DQUA|Int32||XmlEnum("""DQUA""")|3|
||DDAT|Int32||XmlEnum("""DDAT""")|4|
||DEPT|Int32||XmlEnum("""DEPT""")|5|
||PODU|Int32||XmlEnum("""PODU""")|6|
||PHYS|Int32||XmlEnum("""PHYS""")|7|
||DSEC|Int32||XmlEnum("""DSEC""")|8|
||DELN|Int32||XmlEnum("""DELN""")|9|
||CPCA|Int32||XmlEnum("""CPCA""")|10|
||CMIS|Int32||XmlEnum("""CMIS""")|11|

---

## Value ISO20022.Sese011001.TransferUnmatchedStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSrcSchme|ISO20022.Sese011001.GenericIdentification1||XmlElement()||
|+|XtndedRsn|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DataSrcSchme),validChoice(DataSrcSchme,XtndedRsn,Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese011001.TypeOfPrice10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||DDVR|Int32||XmlEnum("""DDVR""")|2|
||SWIC|Int32||XmlEnum("""SWIC""")|3|
||RINV|Int32||XmlEnum("""RINV""")|4|
||MIDD|Int32||XmlEnum("""MIDD""")|5|
||SWNG|Int32||XmlEnum("""SWNG""")|6|
||INTE|Int32||XmlEnum("""INTE""")|7|
||CANC|Int32||XmlEnum("""CANC""")|8|
||CREA|Int32||XmlEnum("""CREA""")|9|
||NAVL|Int32||XmlEnum("""NAVL""")|10|
||OFFR|Int32||XmlEnum("""OFFR""")|11|
||BIDE|Int32||XmlEnum("""BIDE""")|12|

---

## Value ISO20022.Sese011001.TypeOfPrice46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese011001.UKTaxGroupUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRP2|Int32||XmlEnum("""GRP2""")|1|
||GRP1|Int32||XmlEnum("""GRP1""")|2|

---

## Value ISO20022.Sese011001.Unit11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAmt|global::System.Collections.Generic.List<ISO20022.Sese011001.OtherAmount1>||XmlElement()||
|+|TxOvrhd|ISO20022.Sese011001.TotalFeesAndTaxes41||XmlElement()||
|+|PricDtls|ISO20022.Sese011001.UnitPrice23||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Grp1Or2Units|String||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcqstnDt|DateTime||XmlElement()||
|+|OrdrDt|DateTime||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrAmt""",OthrAmt),validElement(OthrAmt),validElement(TxOvrhd),validElement(PricDtls))|

---

## Value ISO20022.Sese011001.Unit13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Grp1Or2Units|String||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcqstnDt|DateTime||XmlElement()||
|+|OrdrDt|DateTime||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese011001.UnitPrice23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblIncmPerShrClctd|ISO20022.Sese011001.TaxableIncomePerShareCalculated2Choice||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Sese011001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|AcrdIntrstNAV|ISO20022.Sese011001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|Val|ISO20022.Sese011001.PriceValue1||XmlElement()||
|+|Tp|ISO20022.Sese011001.TypeOfPrice46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblIncmPerShrClctd),validElement(TaxblIncmPerShr),validElement(AcrdIntrstNAV),validElement(Val),validElement(Tp))|

---

## Enum ISO20022.Sese011001.WaivingInstruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIUN|Int32||XmlEnum("""WIUN""")|1|
||WICA|Int32||XmlEnum("""WICA""")|2|

---

## Value ISO20022.Sese011001.WaivingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese011001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

