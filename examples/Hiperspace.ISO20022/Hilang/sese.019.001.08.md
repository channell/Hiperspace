# sese.019.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese019001.Account28 {
        + SubAcctDtls  : ISO20022.Sese019001.SubAccount5
        + Svcr  : ISO20022.Sese019001.PartyIdentification132
        + AcctNm  : String
        + Dsgnt  : String
        + AcctId  : String
        + OwnrId  : ISO20022.Sese019001.PartyIdentification132
    }
    ISO20022.Sese019001.Account28 *-- ISO20022.Sese019001.SubAccount5
    ISO20022.Sese019001.Account28 *-- ISO20022.Sese019001.PartyIdentification132
    ISO20022.Sese019001.Account28 *-- ISO20022.Sese019001.PartyIdentification132
    class ISO20022.Sese019001.AccountHoldingInformationRequestV08 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Sese019001.Extension1~
        + MktPrctcVrsn  : ISO20022.Sese019001.MarketPracticeVersion1
        + PdctTrf  : global::System.Collections.Generic.List~ISO20022.Sese019001.PortfolioTransfer12~
        + Trfee  : ISO20022.Sese019001.PartyIdentification132
        + NmneeAcct  : ISO20022.Sese019001.InvestmentAccount69
        + TrfrAcct  : ISO20022.Sese019001.InvestmentAccount69
        + OthrCorpInvstr  : global::System.Collections.Generic.List~ISO20022.Sese019001.Organisation36~
        + ScndryCorpInvstr  : ISO20022.Sese019001.Organisation36
        + PmryCorpInvstr  : ISO20022.Sese019001.Organisation36
        + OthrIndvInvstr  : global::System.Collections.Generic.List~ISO20022.Sese019001.IndividualPerson8~
        + ScndryIndvInvstr  : ISO20022.Sese019001.IndividualPerson8
        + PmryIndvInvstr  : ISO20022.Sese019001.IndividualPerson8
        + BizFlowDrctnTp  : String
        + RltdRef  : ISO20022.Sese019001.AdditionalReference10
        + PrvsRef  : ISO20022.Sese019001.AdditionalReference10
        + PoolRef  : ISO20022.Sese019001.AdditionalReference11
        + MsgRef  : ISO20022.Sese019001.MessageIdentification1
    }
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.Extension1
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.MarketPracticeVersion1
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.PortfolioTransfer12
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.PartyIdentification132
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.InvestmentAccount69
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.InvestmentAccount69
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.Organisation36
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.Organisation36
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.Organisation36
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.IndividualPerson8
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.IndividualPerson8
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.IndividualPerson8
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.AdditionalReference10
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.AdditionalReference10
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.AdditionalReference11
    ISO20022.Sese019001.AccountHoldingInformationRequestV08 *-- ISO20022.Sese019001.MessageIdentification1
    class ISO20022.Sese019001.AccountOwnershipType6Code {
        USUF = 1
        UNCO = 2
        SIGL = 3
        RGIC = 4
        OWNR = 5
        ONIS = 6
        NFPO = 7
        NOMI = 8
        LIPA = 9
        LLCO = 10
        JOIN = 11
        COMO = 12
        JOIT = 13
        GOVO = 14
        TRUS = 15
        PART = 16
        EURE = 17
        ENTR = 18
        CUST = 19
        CORP = 20
        BOWN = 21
    }
    class ISO20022.Sese019001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese019001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese019001.AdditionalInformation15 {
        + InfVal  : String
        + InfTp  : ISO20022.Sese019001.GenericIdentification36
    }
    ISO20022.Sese019001.AdditionalInformation15 *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese019001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese019001.AdditionalReference10 *-- ISO20022.Sese019001.PartyIdentification139
    class ISO20022.Sese019001.AdditionalReference11 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese019001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese019001.AdditionalReference11 *-- ISO20022.Sese019001.PartyIdentification139
    class ISO20022.Sese019001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese019001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese019001.IdentificationType42Choice
    }
    ISO20022.Sese019001.AlternatePartyIdentification7 *-- ISO20022.Sese019001.IdentificationType42Choice
    class ISO20022.Sese019001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Sese019001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Sese019001.AlternateSecurityIdentification7 *-- ISO20022.Sese019001.IdentificationSource1Choice
    class ISO20022.Sese019001.BusinessFlowDirectionType1Code {
        ARCV = 1
        ADLV = 2
    }
    class ISO20022.Sese019001.CashAsset2 {
        + AddtlInf  : ISO20022.Sese019001.AdditionalInformation15
        + HldgCcy  : String
        + CshAsstTp  : ISO20022.Sese019001.CashAssetType1Choice
    }
    ISO20022.Sese019001.CashAsset2 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.CashAsset2 *-- ISO20022.Sese019001.CashAssetType1Choice
    class ISO20022.Sese019001.CashAssetType1Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.CashAssetType1Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.CashAssetType1Code {
        CSH1 = 1
        CSH2 = 2
    }
    class ISO20022.Sese019001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese019001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese019001.ClassificationType32Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.ClearingSystemMemberIdentification2Choice {
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
    class ISO20022.Sese019001.DateAndAmount2 {
        + Amt  : ISO20022.Sese019001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
    }
    ISO20022.Sese019001.DateAndAmount2 *-- ISO20022.Sese019001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese019001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese019001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Sese019001.FinancialInstrument101 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + TrfRsltsInChngOfBnfclOwnr  : String
        + AsstsHeldInOwnNm  : String
        + SttlmPtiesDtls  : ISO20022.Sese019001.FundSettlementParameters18
        + Trfr  : ISO20022.Sese019001.Account28
        + TrfeeAcct  : ISO20022.Sese019001.Account28
        + CtrPtyRef  : ISO20022.Sese019001.AdditionalReference10
        + ClntRef  : ISO20022.Sese019001.AdditionalReference10
        + Instrm  : ISO20022.Sese019001.FinancialInstrument61Choice
        + LineId  : String
    }
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.FundSettlementParameters18
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.Account28
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.Account28
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.AdditionalReference10
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.AdditionalReference10
    ISO20022.Sese019001.FinancialInstrument101 *-- ISO20022.Sese019001.FinancialInstrument61Choice
    class ISO20022.Sese019001.FinancialInstrument61Choice {
        + OthrAsst  : ISO20022.Sese019001.OtherAsset2
        + CshAsst  : ISO20022.Sese019001.CashAsset2
        + Scty  : ISO20022.Sese019001.FinancialInstrumentIdentification2
    }
    ISO20022.Sese019001.FinancialInstrument61Choice *-- ISO20022.Sese019001.OtherAsset2
    ISO20022.Sese019001.FinancialInstrument61Choice *-- ISO20022.Sese019001.CashAsset2
    ISO20022.Sese019001.FinancialInstrument61Choice *-- ISO20022.Sese019001.FinancialInstrumentIdentification2
    class ISO20022.Sese019001.FinancialInstrumentIdentification2 {
        + ClssfctnTp  : ISO20022.Sese019001.ClassificationType32Choice
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese019001.SecurityIdentification25Choice
    }
    ISO20022.Sese019001.FinancialInstrumentIdentification2 *-- ISO20022.Sese019001.ClassificationType32Choice
    ISO20022.Sese019001.FinancialInstrumentIdentification2 *-- ISO20022.Sese019001.SecurityIdentification25Choice
    class ISO20022.Sese019001.FundPortfolio9Choice {
        + Pnsn  : ISO20022.Sese019001.Pension6
        + GnlInvstmt  : ISO20022.Sese019001.GeneralInvestment2
        + TaxEffcntPdct  : ISO20022.Sese019001.TaxEfficientProduct4
    }
    ISO20022.Sese019001.FundPortfolio9Choice *-- ISO20022.Sese019001.Pension6
    ISO20022.Sese019001.FundPortfolio9Choice *-- ISO20022.Sese019001.GeneralInvestment2
    ISO20022.Sese019001.FundPortfolio9Choice *-- ISO20022.Sese019001.TaxEfficientProduct4
    class ISO20022.Sese019001.FundSettlementParameters18 {
        + RcvgSdDtls  : ISO20022.Sese019001.SettlementParties94
        + SctiesSttlmSysId  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese019001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese019001.TradeTransactionCondition8Choice~
        + SfkpgPlc  : ISO20022.Sese019001.SafekeepingPlaceFormat28Choice
    }
    ISO20022.Sese019001.FundSettlementParameters18 *-- ISO20022.Sese019001.SettlementParties94
    ISO20022.Sese019001.FundSettlementParameters18 *-- ISO20022.Sese019001.SettlementTransactionCondition30Choice
    ISO20022.Sese019001.FundSettlementParameters18 *-- ISO20022.Sese019001.TradeTransactionCondition8Choice
    ISO20022.Sese019001.FundSettlementParameters18 *-- ISO20022.Sese019001.SafekeepingPlaceFormat28Choice
    class ISO20022.Sese019001.GenderCode {
        FEMA = 1
        MALE = 2
    }
    class ISO20022.Sese019001.GeneralInvestment2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + EstmtdVal  : ISO20022.Sese019001.DateAndAmount2
        + CurInvstmtAmt  : ISO20022.Sese019001.ActiveCurrencyAnd13DecimalAmount
        + OwnrshTp  : String
        + Tp  : ISO20022.Sese019001.GeneralInvestmentAccountType2Choice
    }
    ISO20022.Sese019001.GeneralInvestment2 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.GeneralInvestment2 *-- ISO20022.Sese019001.DateAndAmount2
    ISO20022.Sese019001.GeneralInvestment2 *-- ISO20022.Sese019001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese019001.GeneralInvestment2 *-- ISO20022.Sese019001.GeneralInvestmentAccountType2Choice
    class ISO20022.Sese019001.GeneralInvestmentAccountType2Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.GeneralInvestmentAccountType2Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.GeneralInvestmentAccountType2Code {
        EQUI = 1
        ANYY = 2
    }
    class ISO20022.Sese019001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese019001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese019001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese019001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese019001.GenericIdentification30
    }
    ISO20022.Sese019001.GenericIdentification78 *-- ISO20022.Sese019001.GenericIdentification30
    class ISO20022.Sese019001.HolderType1Code {
        TFOR = 1
        TFEE = 2
    }
    class ISO20022.Sese019001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Sese019001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese019001.IdentificationType42Choice *-- ISO20022.Sese019001.GenericIdentification30
    class ISO20022.Sese019001.IndividualPerson8 {
        + IndvInvstrAdr  : ISO20022.Sese019001.PostalAddress1
        + SclSctyNb  : String
        + BirthDt  : DateTime
        + Gndr  : String
        + NmSfx  : String
        + NmPrfx  : String
        + GvnNm  : String
        + Nm  : String
    }
    ISO20022.Sese019001.IndividualPerson8 *-- ISO20022.Sese019001.PostalAddress1
    class ISO20022.Sese019001.InvestmentAccount69 {
        + Svcr  : ISO20022.Sese019001.PartyIdentification132
        + AcctNm  : String
        + Dsgnt  : String
        + Id  : String
    }
    ISO20022.Sese019001.InvestmentAccount69 *-- ISO20022.Sese019001.PartyIdentification132
    class ISO20022.Sese019001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Sese019001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Sese019001.NameAndAddress5 {
        + Adr  : ISO20022.Sese019001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese019001.NameAndAddress5 *-- ISO20022.Sese019001.PostalAddress1
    class ISO20022.Sese019001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Sese019001.Organisation36 {
        + CorpInvstrAdr  : ISO20022.Sese019001.PostalAddress1
        + NtlRegnNb  : String
        + TaxIdNb  : String
        + RegnDt  : DateTime
        + RegnCtry  : String
        + TaxtnCtry  : String
        + Purp  : String
        + Id  : ISO20022.Sese019001.PartyIdentification140
        + Nm  : String
    }
    ISO20022.Sese019001.Organisation36 *-- ISO20022.Sese019001.PostalAddress1
    ISO20022.Sese019001.Organisation36 *-- ISO20022.Sese019001.PartyIdentification140
    class ISO20022.Sese019001.OtherAsset2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + OthrId  : global::System.Collections.Generic.List~String~
        + Desc  : String
        + Nm  : String
        + Id  : String
        + OthrAsstTp  : ISO20022.Sese019001.OtherAsset2Choice
    }
    ISO20022.Sese019001.OtherAsset2 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.OtherAsset2 *-- ISO20022.Sese019001.OtherAsset2Choice
    class ISO20022.Sese019001.OtherAsset2Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.OtherAsset2Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.OtherAsset2Code {
        TIPP = 1
        PROP = 2
        MOVE = 3
        EXIA = 4
        DIMA = 5
    }
    class ISO20022.Sese019001.PartyIdentification122Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese019001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese019001.PartyIdentification122Choice *-- ISO20022.Sese019001.NameAndAddress5
    class ISO20022.Sese019001.PartyIdentification123Choice {
        + NmAndAdr  : ISO20022.Sese019001.NameAndAddress5
        + PrtryId  : ISO20022.Sese019001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese019001.PartyIdentification123Choice *-- ISO20022.Sese019001.NameAndAddress5
    ISO20022.Sese019001.PartyIdentification123Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Sese019001.NameAndAddress5
        + PrtryId  : ISO20022.Sese019001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese019001.PartyIdentification125Choice *-- ISO20022.Sese019001.NameAndAddress5
    ISO20022.Sese019001.PartyIdentification125Choice *-- ISO20022.Sese019001.GenericIdentification1
    class ISO20022.Sese019001.PartyIdentification126Choice {
        + PrtryId  : ISO20022.Sese019001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese019001.PartyIdentification126Choice *-- ISO20022.Sese019001.GenericIdentification1
    class ISO20022.Sese019001.PartyIdentification132 {
        + LEI  : String
        + PrtryId  : ISO20022.Sese019001.GenericIdentification1
        + NmAndAdr  : ISO20022.Sese019001.NameAndAddress5
        + ClrSysMmbId  : ISO20022.Sese019001.ClearingSystemMemberIdentification2Choice
        + AnyBIC  : String
    }
    ISO20022.Sese019001.PartyIdentification132 *-- ISO20022.Sese019001.GenericIdentification1
    ISO20022.Sese019001.PartyIdentification132 *-- ISO20022.Sese019001.NameAndAddress5
    ISO20022.Sese019001.PartyIdentification132 *-- ISO20022.Sese019001.ClearingSystemMemberIdentification2Choice
    class ISO20022.Sese019001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Sese019001.PartyIdentification125Choice
    }
    ISO20022.Sese019001.PartyIdentification139 *-- ISO20022.Sese019001.PartyIdentification125Choice
    class ISO20022.Sese019001.PartyIdentification140 {
        + LEI  : String
        + Pty  : ISO20022.Sese019001.PartyIdentification126Choice
    }
    ISO20022.Sese019001.PartyIdentification140 *-- ISO20022.Sese019001.PartyIdentification126Choice
    class ISO20022.Sese019001.PartyIdentification141 {
        + AddtlInf  : ISO20022.Sese019001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese019001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese019001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese019001.PartyIdentification122Choice
    }
    ISO20022.Sese019001.PartyIdentification141 *-- ISO20022.Sese019001.PartyTextInformation1
    ISO20022.Sese019001.PartyIdentification141 *-- ISO20022.Sese019001.DateAndDateTime2Choice
    ISO20022.Sese019001.PartyIdentification141 *-- ISO20022.Sese019001.AlternatePartyIdentification7
    ISO20022.Sese019001.PartyIdentification141 *-- ISO20022.Sese019001.PartyIdentification122Choice
    class ISO20022.Sese019001.PartyIdentificationAndAccount194 {
        + AddtlInf  : ISO20022.Sese019001.PartyTextInformation6
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese019001.DateAndDateTime2Choice
        + SfkpgAcct  : ISO20022.Sese019001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese019001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese019001.PartyIdentification123Choice
    }
    ISO20022.Sese019001.PartyIdentificationAndAccount194 *-- ISO20022.Sese019001.PartyTextInformation6
    ISO20022.Sese019001.PartyIdentificationAndAccount194 *-- ISO20022.Sese019001.DateAndDateTime2Choice
    ISO20022.Sese019001.PartyIdentificationAndAccount194 *-- ISO20022.Sese019001.SecuritiesAccount19
    ISO20022.Sese019001.PartyIdentificationAndAccount194 *-- ISO20022.Sese019001.AlternatePartyIdentification7
    ISO20022.Sese019001.PartyIdentificationAndAccount194 *-- ISO20022.Sese019001.PartyIdentification123Choice
    class ISO20022.Sese019001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese019001.PartyTextInformation6 {
        + RegnAdr  : ISO20022.Sese019001.PostalAddress1
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    ISO20022.Sese019001.PartyTextInformation6 *-- ISO20022.Sese019001.PostalAddress1
    class ISO20022.Sese019001.Pension6 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + NonWrpprTrf  : String
        + DrwdwnTrchId  : String
        + TaxRef  : global::System.Collections.Generic.List~ISO20022.Sese019001.TaxReference1~
        + TrfScp  : ISO20022.Sese019001.PensionTransferScope1Choice
        + Tp  : ISO20022.Sese019001.PensionSchemeType3Choice
        + Id  : ISO20022.Sese019001.PensionPolicy1
    }
    ISO20022.Sese019001.Pension6 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.Pension6 *-- ISO20022.Sese019001.TaxReference1
    ISO20022.Sese019001.Pension6 *-- ISO20022.Sese019001.PensionTransferScope1Choice
    ISO20022.Sese019001.Pension6 *-- ISO20022.Sese019001.PensionSchemeType3Choice
    ISO20022.Sese019001.Pension6 *-- ISO20022.Sese019001.PensionPolicy1
    class ISO20022.Sese019001.PensionPolicy1 {
        + AddtlInf  : ISO20022.Sese019001.AdditionalInformation15
        + SubIdr  : String
        + Idr  : String
    }
    ISO20022.Sese019001.PensionPolicy1 *-- ISO20022.Sese019001.AdditionalInformation15
    class ISO20022.Sese019001.PensionSchemeType3Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.PensionSchemeType3Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.PensionSchemeType3Code {
        NWRP = 1
        SSAS = 2
        SIPP = 3
        S32A = 4
        SC32 = 5
        REAN = 6
        ITPO = 7
        EPKA = 8
        PPNS = 9
        OCDC = 10
        OTPM = 11
        STKI = 12
        IPST = 13
        STKG = 14
        SIPG = 15
        GPPS = 16
        FAVC = 17
        EXPP = 18
        DBEN = 19
        AAVC = 20
    }
    class ISO20022.Sese019001.PensionTransferScope1Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.PensionTransferScope1Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.PensionTransferScope1Code {
        UCRY = 1
        FULP = 2
        SDDT = 3
        CRYS = 4
    }
    class ISO20022.Sese019001.PersonIdentificationType7Code {
        ITIN = 1
        GTIN = 2
        ATIN = 3
    }
    class ISO20022.Sese019001.PortfolioTransfer12 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + FinInstrmAsstForTrf  : global::System.Collections.Generic.List~ISO20022.Sese019001.FinancialInstrument101~
        + Prtfl  : ISO20022.Sese019001.FundPortfolio9Choice
        + TrfId  : String
        + MstrRef  : String
    }
    ISO20022.Sese019001.PortfolioTransfer12 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.PortfolioTransfer12 *-- ISO20022.Sese019001.FinancialInstrument101
    ISO20022.Sese019001.PortfolioTransfer12 *-- ISO20022.Sese019001.FundPortfolio9Choice
    class ISO20022.Sese019001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese019001.PreviousYear2Choice {
        + SpcfcPrvsYrs  : global::System.Collections.Generic.List~Int32~
        + AllPrvsYrs  : String
    }
    class ISO20022.Sese019001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese019001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Sese019001.SafekeepingPlaceFormat28Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification78
        + TpAndId  : ISO20022.Sese019001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese019001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Sese019001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese019001.GenericIdentification78
    ISO20022.Sese019001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese019001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese019001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese019001.SafekeepingPlaceTypeAndText6
    class ISO20022.Sese019001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese019001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese019001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese019001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese019001.SecuritiesAccount19 *-- ISO20022.Sese019001.GenericIdentification30
    class ISO20022.Sese019001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Sese019001.AlternateSecurityIdentification7
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
    ISO20022.Sese019001.SecurityIdentification25Choice *-- ISO20022.Sese019001.AlternateSecurityIdentification7
    class ISO20022.Sese019001.SettlementParties94 {
        + Pty5  : ISO20022.Sese019001.PartyIdentificationAndAccount194
        + Pty4  : ISO20022.Sese019001.PartyIdentificationAndAccount194
        + Pty3  : ISO20022.Sese019001.PartyIdentificationAndAccount194
        + Pty2  : ISO20022.Sese019001.PartyIdentificationAndAccount194
        + Pty1  : ISO20022.Sese019001.PartyIdentificationAndAccount194
        + Dpstry  : ISO20022.Sese019001.PartyIdentification141
    }
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentificationAndAccount194
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentificationAndAccount194
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentificationAndAccount194
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentificationAndAccount194
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentificationAndAccount194
    ISO20022.Sese019001.SettlementParties94 *-- ISO20022.Sese019001.PartyIdentification141
    class ISO20022.Sese019001.SettlementTransactionCondition11Code {
        NOMC = 1
    }
    class ISO20022.Sese019001.SettlementTransactionCondition30Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese019001.SettlementTransactionCondition30Choice *-- ISO20022.Sese019001.GenericIdentification30
    class ISO20022.Sese019001.SubAccount5 {
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Sese019001.TaxEfficientProduct4 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese019001.AdditionalInformation15~
        + PrvsYrs  : ISO20022.Sese019001.PreviousYear2Choice
        + CurYr  : String
        + TaxEffcntPdctTp  : ISO20022.Sese019001.TaxEfficientProductType2Choice
    }
    ISO20022.Sese019001.TaxEfficientProduct4 *-- ISO20022.Sese019001.AdditionalInformation15
    ISO20022.Sese019001.TaxEfficientProduct4 *-- ISO20022.Sese019001.PreviousYear2Choice
    ISO20022.Sese019001.TaxEfficientProduct4 *-- ISO20022.Sese019001.TaxEfficientProductType2Choice
    class ISO20022.Sese019001.TaxEfficientProductType2Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.TaxEfficientProductType2Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.TaxEfficientProductType2Code {
        EQUI = 1
        SCTF = 2
        CCTF = 3
        LISA = 4
        JISA = 5
        JCSH = 6
        INNF = 7
        HISA = 8
        GASK = 9
        GISK = 10
        FISA = 11
        CLIS = 12
        CASH = 13
    }
    class ISO20022.Sese019001.TaxReference1 {
        + HldrTp  : ISO20022.Sese019001.TaxReferenceParty1Choice
        + Ref  : String
        + TaxTp  : ISO20022.Sese019001.TaxReferenceType1Choice
    }
    ISO20022.Sese019001.TaxReference1 *-- ISO20022.Sese019001.TaxReferenceParty1Choice
    ISO20022.Sese019001.TaxReference1 *-- ISO20022.Sese019001.TaxReferenceType1Choice
    class ISO20022.Sese019001.TaxReferenceParty1Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.TaxReferenceParty1Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.TaxReferenceType1Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese019001.TaxReferenceType1Choice *-- ISO20022.Sese019001.GenericIdentification36
    class ISO20022.Sese019001.TradeTransactionCondition5Code {
        CCPN = 1
        XCPN = 2
    }
    class ISO20022.Sese019001.TradeTransactionCondition8Choice {
        + Prtry  : ISO20022.Sese019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese019001.TradeTransactionCondition8Choice *-- ISO20022.Sese019001.GenericIdentification30
    class ISO20022.Sese019001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
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

## Value ISO20022.Sese019001.Account28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Sese019001.SubAccount5||XmlElement()||
|+|Svcr|ISO20022.Sese019001.PartyIdentification132||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|OwnrId|ISO20022.Sese019001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(Svcr),validElement(OwnrId))|

---

## Aspect ISO20022.Sese019001.AccountHoldingInformationRequestV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Sese019001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Sese019001.MarketPracticeVersion1||XmlElement()||
|+|PdctTrf|global::System.Collections.Generic.List<ISO20022.Sese019001.PortfolioTransfer12>||XmlElement()||
|+|Trfee|ISO20022.Sese019001.PartyIdentification132||XmlElement()||
|+|NmneeAcct|ISO20022.Sese019001.InvestmentAccount69||XmlElement()||
|+|TrfrAcct|ISO20022.Sese019001.InvestmentAccount69||XmlElement()||
|+|OthrCorpInvstr|global::System.Collections.Generic.List<ISO20022.Sese019001.Organisation36>||XmlElement()||
|+|ScndryCorpInvstr|ISO20022.Sese019001.Organisation36||XmlElement()||
|+|PmryCorpInvstr|ISO20022.Sese019001.Organisation36||XmlElement()||
|+|OthrIndvInvstr|global::System.Collections.Generic.List<ISO20022.Sese019001.IndividualPerson8>||XmlElement()||
|+|ScndryIndvInvstr|ISO20022.Sese019001.IndividualPerson8||XmlElement()||
|+|PmryIndvInvstr|ISO20022.Sese019001.IndividualPerson8||XmlElement()||
|+|BizFlowDrctnTp|String||XmlElement()||
|+|RltdRef|ISO20022.Sese019001.AdditionalReference10||XmlElement()||
|+|PrvsRef|ISO20022.Sese019001.AdditionalReference10||XmlElement()||
|+|PoolRef|ISO20022.Sese019001.AdditionalReference11||XmlElement()||
|+|MsgRef|ISO20022.Sese019001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validRequired("""PdctTrf""",PdctTrf),validList("""PdctTrf""",PdctTrf),validElement(PdctTrf),validElement(Trfee),validElement(NmneeAcct),validElement(TrfrAcct),validList("""OthrCorpInvstr""",OthrCorpInvstr),validElement(OthrCorpInvstr),validElement(ScndryCorpInvstr),validElement(PmryCorpInvstr),validList("""OthrIndvInvstr""",OthrIndvInvstr),validElement(OthrIndvInvstr),validElement(ScndryIndvInvstr),validElement(PmryIndvInvstr),validElement(RltdRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgRef))|

---

## Enum ISO20022.Sese019001.AccountOwnershipType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USUF|Int32||XmlEnum("""USUF""")|1|
||UNCO|Int32||XmlEnum("""UNCO""")|2|
||SIGL|Int32||XmlEnum("""SIGL""")|3|
||RGIC|Int32||XmlEnum("""RGIC""")|4|
||OWNR|Int32||XmlEnum("""OWNR""")|5|
||ONIS|Int32||XmlEnum("""ONIS""")|6|
||NFPO|Int32||XmlEnum("""NFPO""")|7|
||NOMI|Int32||XmlEnum("""NOMI""")|8|
||LIPA|Int32||XmlEnum("""LIPA""")|9|
||LLCO|Int32||XmlEnum("""LLCO""")|10|
||JOIN|Int32||XmlEnum("""JOIN""")|11|
||COMO|Int32||XmlEnum("""COMO""")|12|
||JOIT|Int32||XmlEnum("""JOIT""")|13|
||GOVO|Int32||XmlEnum("""GOVO""")|14|
||TRUS|Int32||XmlEnum("""TRUS""")|15|
||PART|Int32||XmlEnum("""PART""")|16|
||EURE|Int32||XmlEnum("""EURE""")|17|
||ENTR|Int32||XmlEnum("""ENTR""")|18|
||CUST|Int32||XmlEnum("""CUST""")|19|
||CORP|Int32||XmlEnum("""CORP""")|20|
||BOWN|Int32||XmlEnum("""BOWN""")|21|

---

## Value ISO20022.Sese019001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese019001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese019001.AdditionalInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|InfTp|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfTp))|

---

## Value ISO20022.Sese019001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese019001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Sese019001.AdditionalReference11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese019001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Sese019001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese019001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese019001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese019001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Sese019001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Enum ISO20022.Sese019001.BusinessFlowDirectionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ARCV|Int32||XmlEnum("""ARCV""")|1|
||ADLV|Int32||XmlEnum("""ADLV""")|2|

---

## Value ISO20022.Sese019001.CashAsset2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese019001.AdditionalInformation15||XmlElement()||
|+|HldgCcy|String||XmlElement()||
|+|CshAsstTp|ISO20022.Sese019001.CashAssetType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""HldgCcy""",HldgCcy,"""[A-Z]{3,3}"""),validElement(CshAsstTp))|

---

## Value ISO20022.Sese019001.CashAssetType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.CashAssetType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSH1|Int32||XmlEnum("""CSH1""")|1|
||CSH2|Int32||XmlEnum("""CSH2""")|2|

---

## Value ISO20022.Sese019001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese019001.ClearingSystemMemberIdentification2Choice


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

## Value ISO20022.Sese019001.DateAndAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese019001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese019001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Sese019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctHldgInfReq|ISO20022.Sese019001.AccountHoldingInformationRequestV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctHldgInfReq))|

---

## Value ISO20022.Sese019001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.FinancialInstrument101


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|TrfRsltsInChngOfBnfclOwnr|String||XmlElement()||
|+|AsstsHeldInOwnNm|String||XmlElement()||
|+|SttlmPtiesDtls|ISO20022.Sese019001.FundSettlementParameters18||XmlElement()||
|+|Trfr|ISO20022.Sese019001.Account28||XmlElement()||
|+|TrfeeAcct|ISO20022.Sese019001.Account28||XmlElement()||
|+|CtrPtyRef|ISO20022.Sese019001.AdditionalReference10||XmlElement()||
|+|ClntRef|ISO20022.Sese019001.AdditionalReference10||XmlElement()||
|+|Instrm|ISO20022.Sese019001.FinancialInstrument61Choice||XmlElement()||
|+|LineId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmPtiesDtls),validElement(Trfr),validElement(TrfeeAcct),validElement(CtrPtyRef),validElement(ClntRef),validElement(Instrm))|

---

## Value ISO20022.Sese019001.FinancialInstrument61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAsst|ISO20022.Sese019001.OtherAsset2||XmlElement()||
|+|CshAsst|ISO20022.Sese019001.CashAsset2||XmlElement()||
|+|Scty|ISO20022.Sese019001.FinancialInstrumentIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrAsst),validElement(CshAsst),validElement(Scty),validChoice(OthrAsst,CshAsst,Scty))|

---

## Value ISO20022.Sese019001.FinancialInstrumentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClssfctnTp|ISO20022.Sese019001.ClassificationType32Choice||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese019001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClssfctnTp),validElement(Id))|

---

## Value ISO20022.Sese019001.FundPortfolio9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pnsn|ISO20022.Sese019001.Pension6||XmlElement()||
|+|GnlInvstmt|ISO20022.Sese019001.GeneralInvestment2||XmlElement()||
|+|TaxEffcntPdct|ISO20022.Sese019001.TaxEfficientProduct4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pnsn),validElement(GnlInvstmt),validElement(TaxEffcntPdct),validChoice(Pnsn,GnlInvstmt,TaxEffcntPdct))|

---

## Value ISO20022.Sese019001.FundSettlementParameters18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgSdDtls|ISO20022.Sese019001.SettlementParties94||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese019001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese019001.TradeTransactionCondition8Choice>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese019001.SafekeepingPlaceFormat28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(SfkpgPlc))|

---

## Enum ISO20022.Sese019001.GenderCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FEMA|Int32||XmlEnum("""FEMA""")|1|
||MALE|Int32||XmlEnum("""MALE""")|2|

---

## Value ISO20022.Sese019001.GeneralInvestment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|EstmtdVal|ISO20022.Sese019001.DateAndAmount2||XmlElement()||
|+|CurInvstmtAmt|ISO20022.Sese019001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|OwnrshTp|String||XmlElement()||
|+|Tp|ISO20022.Sese019001.GeneralInvestmentAccountType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(EstmtdVal),validElement(CurInvstmtAmt),validElement(Tp))|

---

## Value ISO20022.Sese019001.GeneralInvestmentAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.GeneralInvestmentAccountType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQUI|Int32||XmlEnum("""EQUI""")|1|
||ANYY|Int32||XmlEnum("""ANYY""")|2|

---

## Value ISO20022.Sese019001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese019001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese019001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese019001.HolderType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TFOR|Int32||XmlEnum("""TFOR""")|1|
||TFEE|Int32||XmlEnum("""TFEE""")|2|

---

## Value ISO20022.Sese019001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Value ISO20022.Sese019001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese019001.IndividualPerson8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvInvstrAdr|ISO20022.Sese019001.PostalAddress1||XmlElement()||
|+|SclSctyNb|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
|+|Gndr|String||XmlElement()||
|+|NmSfx|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndvInvstrAdr))|

---

## Value ISO20022.Sese019001.InvestmentAccount69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Sese019001.PartyIdentification132||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr))|

---

## Value ISO20022.Sese019001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese019001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese019001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Sese019001.Organisation36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpInvstrAdr|ISO20022.Sese019001.PostalAddress1||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|RegnCtry|String||XmlElement()||
|+|TaxtnCtry|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|Id|ISO20022.Sese019001.PartyIdentification140||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpInvstrAdr),validPattern("""RegnCtry""",RegnCtry,"""[A-Z]{2,2}"""),validPattern("""TaxtnCtry""",TaxtnCtry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese019001.OtherAsset2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|OthrAsstTp|ISO20022.Sese019001.OtherAsset2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validListMax("""OthrId""",OthrId,5),validElement(OthrAsstTp))|

---

## Value ISO20022.Sese019001.OtherAsset2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.OtherAsset2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TIPP|Int32||XmlEnum("""TIPP""")|1|
||PROP|Int32||XmlEnum("""PROP""")|2|
||MOVE|Int32||XmlEnum("""MOVE""")|3|
||EXIA|Int32||XmlEnum("""EXIA""")|4|
||DIMA|Int32||XmlEnum("""DIMA""")|5|

---

## Value ISO20022.Sese019001.PartyIdentification122Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese019001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese019001.PartyIdentification123Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese019001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese019001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese019001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese019001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese019001.PartyIdentification126Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese019001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese019001.PartyIdentification132


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PrtryId|ISO20022.Sese019001.GenericIdentification1||XmlElement()||
|+|NmAndAdr|ISO20022.Sese019001.NameAndAddress5||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese019001.ClearingSystemMemberIdentification2Choice||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PrtryId),validElement(NmAndAdr),validElement(ClrSysMmbId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese019001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese019001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese019001.PartyIdentification140


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese019001.PartyIdentification126Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese019001.PartyIdentification141


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese019001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese019001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese019001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese019001.PartyIdentification122Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese019001.PartyIdentificationAndAccount194


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese019001.PartyTextInformation6||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese019001.DateAndDateTime2Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese019001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese019001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese019001.PartyIdentification123Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese019001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.PartyTextInformation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnAdr|ISO20022.Sese019001.PostalAddress1||XmlElement()||
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegnAdr))|

---

## Value ISO20022.Sese019001.Pension6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|NonWrpprTrf|String||XmlElement()||
|+|DrwdwnTrchId|String||XmlElement()||
|+|TaxRef|global::System.Collections.Generic.List<ISO20022.Sese019001.TaxReference1>||XmlElement()||
|+|TrfScp|ISO20022.Sese019001.PensionTransferScope1Choice||XmlElement()||
|+|Tp|ISO20022.Sese019001.PensionSchemeType3Choice||XmlElement()||
|+|Id|ISO20022.Sese019001.PensionPolicy1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""TaxRef""",TaxRef),validElement(TaxRef),validElement(TrfScp),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese019001.PensionPolicy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese019001.AdditionalInformation15||XmlElement()||
|+|SubIdr|String||XmlElement()||
|+|Idr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf))|

---

## Value ISO20022.Sese019001.PensionSchemeType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.PensionSchemeType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NWRP|Int32||XmlEnum("""NWRP""")|1|
||SSAS|Int32||XmlEnum("""SSAS""")|2|
||SIPP|Int32||XmlEnum("""SIPP""")|3|
||S32A|Int32||XmlEnum("""S32A""")|4|
||SC32|Int32||XmlEnum("""SC32""")|5|
||REAN|Int32||XmlEnum("""REAN""")|6|
||ITPO|Int32||XmlEnum("""ITPO""")|7|
||EPKA|Int32||XmlEnum("""EPKA""")|8|
||PPNS|Int32||XmlEnum("""PPNS""")|9|
||OCDC|Int32||XmlEnum("""OCDC""")|10|
||OTPM|Int32||XmlEnum("""OTPM""")|11|
||STKI|Int32||XmlEnum("""STKI""")|12|
||IPST|Int32||XmlEnum("""IPST""")|13|
||STKG|Int32||XmlEnum("""STKG""")|14|
||SIPG|Int32||XmlEnum("""SIPG""")|15|
||GPPS|Int32||XmlEnum("""GPPS""")|16|
||FAVC|Int32||XmlEnum("""FAVC""")|17|
||EXPP|Int32||XmlEnum("""EXPP""")|18|
||DBEN|Int32||XmlEnum("""DBEN""")|19|
||AAVC|Int32||XmlEnum("""AAVC""")|20|

---

## Value ISO20022.Sese019001.PensionTransferScope1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.PensionTransferScope1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCRY|Int32||XmlEnum("""UCRY""")|1|
||FULP|Int32||XmlEnum("""FULP""")|2|
||SDDT|Int32||XmlEnum("""SDDT""")|3|
||CRYS|Int32||XmlEnum("""CRYS""")|4|

---

## Enum ISO20022.Sese019001.PersonIdentificationType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ITIN|Int32||XmlEnum("""ITIN""")|1|
||GTIN|Int32||XmlEnum("""GTIN""")|2|
||ATIN|Int32||XmlEnum("""ATIN""")|3|

---

## Value ISO20022.Sese019001.PortfolioTransfer12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|FinInstrmAsstForTrf|global::System.Collections.Generic.List<ISO20022.Sese019001.FinancialInstrument101>||XmlElement()||
|+|Prtfl|ISO20022.Sese019001.FundPortfolio9Choice||XmlElement()||
|+|TrfId|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""FinInstrmAsstForTrf""",FinInstrmAsstForTrf),validElement(FinInstrmAsstForTrf),validElement(Prtfl))|

---

## Value ISO20022.Sese019001.PostalAddress1


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

## Value ISO20022.Sese019001.PreviousYear2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SpcfcPrvsYrs|global::System.Collections.Generic.List<Int32>||XmlElement()||
|+|AllPrvsYrs|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SpcfcPrvsYrs""",SpcfcPrvsYrs),validPattern("""AllPrvsYrs""",AllPrvsYrs,"""ALL"""),validChoice(SpcfcPrvsYrs,AllPrvsYrs))|

---

## Enum ISO20022.Sese019001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese019001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Sese019001.SafekeepingPlaceFormat28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese019001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese019001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese019001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese019001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese019001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese019001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Sese019001.AlternateSecurityIdentification7||XmlElement()||
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

## Value ISO20022.Sese019001.SettlementParties94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese019001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty4|ISO20022.Sese019001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty3|ISO20022.Sese019001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty2|ISO20022.Sese019001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty1|ISO20022.Sese019001.PartyIdentificationAndAccount194||XmlElement()||
|+|Dpstry|ISO20022.Sese019001.PartyIdentification141||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese019001.SettlementTransactionCondition11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOMC|Int32||XmlEnum("""NOMC""")|1|

---

## Value ISO20022.Sese019001.SettlementTransactionCondition30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese019001.SubAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese019001.TaxEfficientProduct4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese019001.AdditionalInformation15>||XmlElement()||
|+|PrvsYrs|ISO20022.Sese019001.PreviousYear2Choice||XmlElement()||
|+|CurYr|String||XmlElement()||
|+|TaxEffcntPdctTp|ISO20022.Sese019001.TaxEfficientProductType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(PrvsYrs),validElement(TaxEffcntPdctTp))|

---

## Value ISO20022.Sese019001.TaxEfficientProductType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.TaxEfficientProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQUI|Int32||XmlEnum("""EQUI""")|1|
||SCTF|Int32||XmlEnum("""SCTF""")|2|
||CCTF|Int32||XmlEnum("""CCTF""")|3|
||LISA|Int32||XmlEnum("""LISA""")|4|
||JISA|Int32||XmlEnum("""JISA""")|5|
||JCSH|Int32||XmlEnum("""JCSH""")|6|
||INNF|Int32||XmlEnum("""INNF""")|7|
||HISA|Int32||XmlEnum("""HISA""")|8|
||GASK|Int32||XmlEnum("""GASK""")|9|
||GISK|Int32||XmlEnum("""GISK""")|10|
||FISA|Int32||XmlEnum("""FISA""")|11|
||CLIS|Int32||XmlEnum("""CLIS""")|12|
||CASH|Int32||XmlEnum("""CASH""")|13|

---

## Value ISO20022.Sese019001.TaxReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldrTp|ISO20022.Sese019001.TaxReferenceParty1Choice||XmlElement()||
|+|Ref|String||XmlElement()||
|+|TaxTp|ISO20022.Sese019001.TaxReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HldrTp),validElement(TaxTp))|

---

## Value ISO20022.Sese019001.TaxReferenceParty1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese019001.TaxReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.TradeTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPN|Int32||XmlEnum("""CCPN""")|1|
||XCPN|Int32||XmlEnum("""XCPN""")|2|

---

## Value ISO20022.Sese019001.TradeTransactionCondition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese019001.TypeOfIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||DRLC|Int32||XmlEnum("""DRLC""")|3|
||CORP|Int32||XmlEnum("""CORP""")|4|
||CHTY|Int32||XmlEnum("""CHTY""")|5|
||CCPT|Int32||XmlEnum("""CCPT""")|6|
||ARNU|Int32||XmlEnum("""ARNU""")|7|

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

