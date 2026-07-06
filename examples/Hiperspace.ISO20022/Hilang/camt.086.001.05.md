# camt.086.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt086001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt086001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt086001.AccountIdentification4Choice *-- ISO20022.Camt086001.GenericAccountIdentification1
    class ISO20022.Camt086001.AccountLevel1Code {
        SMRY = 1
        INTM = 2
    }
    class ISO20022.Camt086001.AccountLevel2Code {
        DETL = 1
        SMRY = 2
        INTM = 3
    }
    class ISO20022.Camt086001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.AccountTax1 {
        + NonResCtry  : ISO20022.Camt086001.ResidenceLocation1Choice
        + Rgn  : String
        + ClctnMtd  : String
    }
    ISO20022.Camt086001.AccountTax1 *-- ISO20022.Camt086001.ResidenceLocation1Choice
    class ISO20022.Camt086001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt086001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt086001.AddressType3Choice {
        + Prtry  : ISO20022.Camt086001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt086001.AddressType3Choice *-- ISO20022.Camt086001.GenericIdentification30
    class ISO20022.Camt086001.AmountAndDirection34 {
        + Sgn  : String
        + Amt  : ISO20022.Camt086001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt086001.AmountAndDirection34 *-- ISO20022.Camt086001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt086001.BalanceAdjustment1 {
        + EarngsAdjstmntAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Days  : Decimal
        + PstngDt  : DateTime
        + ErrDt  : DateTime
        + AvrgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + BalAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Desc  : String
        + Tp  : String
    }
    ISO20022.Camt086001.BalanceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BalanceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BalanceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BalanceAdjustmentType1Code {
        CLLD = 1
        FLOT = 2
        LDGR = 3
    }
    class ISO20022.Camt086001.BankServicesBillingStatementV05 {
        + BllgStmtGrp  : global::System.Collections.Generic.List~ISO20022.Camt086001.StatementGroup5~
        + RptHdr  : ISO20022.Camt086001.ReportHeader6
    }
    ISO20022.Camt086001.BankServicesBillingStatementV05 *-- ISO20022.Camt086001.StatementGroup5
    ISO20022.Camt086001.BankServicesBillingStatementV05 *-- ISO20022.Camt086001.ReportHeader6
    class ISO20022.Camt086001.BankTransactionCodeStructure4 {
        + Prtry  : ISO20022.Camt086001.ProprietaryBankTransactionCodeStructure1
        + Domn  : ISO20022.Camt086001.BankTransactionCodeStructure5
    }
    ISO20022.Camt086001.BankTransactionCodeStructure4 *-- ISO20022.Camt086001.ProprietaryBankTransactionCodeStructure1
    ISO20022.Camt086001.BankTransactionCodeStructure4 *-- ISO20022.Camt086001.BankTransactionCodeStructure5
    class ISO20022.Camt086001.BankTransactionCodeStructure5 {
        + Fmly  : ISO20022.Camt086001.BankTransactionCodeStructure6
        + Cd  : String
    }
    ISO20022.Camt086001.BankTransactionCodeStructure5 *-- ISO20022.Camt086001.BankTransactionCodeStructure6
    class ISO20022.Camt086001.BankTransactionCodeStructure6 {
        + SubFmlyCd  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.BillingBalance1 {
        + CcyTp  : String
        + Val  : ISO20022.Camt086001.AmountAndDirection34
        + Tp  : ISO20022.Camt086001.BillingBalanceType1Choice
    }
    ISO20022.Camt086001.BillingBalance1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingBalance1 *-- ISO20022.Camt086001.BillingBalanceType1Choice
    class ISO20022.Camt086001.BillingBalanceType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.BillingChargeMethod1Code {
        BBSE = 1
        ZPRC = 2
        TPRC = 3
        TIR9 = 4
        TIR8 = 5
        TIR7 = 6
        TIR6 = 7
        TIR5 = 8
        TIR4 = 9
        TIR3 = 10
        TIR2 = 11
        TIR1 = 12
        MXRD = 13
        MCHG = 14
        LPRC = 15
        FCHG = 16
        DPRC = 17
        BCHG = 18
        STAM = 19
        UPRC = 20
    }
    class ISO20022.Camt086001.BillingCompensation1 {
        + CcyTp  : String
        + Val  : ISO20022.Camt086001.AmountAndDirection34
        + Tp  : ISO20022.Camt086001.BillingCompensationType1Choice
    }
    ISO20022.Camt086001.BillingCompensation1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingCompensation1 *-- ISO20022.Camt086001.BillingCompensationType1Choice
    class ISO20022.Camt086001.BillingCompensationType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.BillingCurrencyType1Code {
        PRCG = 1
        STLM = 2
        ACCT = 3
    }
    class ISO20022.Camt086001.BillingCurrencyType2Code {
        HOST = 1
        PRCG = 2
        STLM = 3
        ACCT = 4
    }
    class ISO20022.Camt086001.BillingMethod1 {
        + TaxId  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServicesTax1~
        + TtlChrg  : ISO20022.Camt086001.BillingServicesAmount2
        + SvcTax  : ISO20022.Camt086001.BillingServicesAmount1
        + SvcChrgHstAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingMethod1 *-- ISO20022.Camt086001.BillingServicesTax1
    ISO20022.Camt086001.BillingMethod1 *-- ISO20022.Camt086001.BillingServicesAmount2
    ISO20022.Camt086001.BillingMethod1 *-- ISO20022.Camt086001.BillingServicesAmount1
    ISO20022.Camt086001.BillingMethod1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingMethod1Choice {
        + MtdD  : ISO20022.Camt086001.BillingMethod3
        + MtdB  : ISO20022.Camt086001.BillingMethod2
        + MtdA  : ISO20022.Camt086001.BillingMethod1
    }
    ISO20022.Camt086001.BillingMethod1Choice *-- ISO20022.Camt086001.BillingMethod3
    ISO20022.Camt086001.BillingMethod1Choice *-- ISO20022.Camt086001.BillingMethod2
    ISO20022.Camt086001.BillingMethod1Choice *-- ISO20022.Camt086001.BillingMethod1
    class ISO20022.Camt086001.BillingMethod2 {
        + TaxId  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServicesTax1~
        + SvcTax  : ISO20022.Camt086001.BillingServicesAmount1
        + SvcChrgHstAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingMethod2 *-- ISO20022.Camt086001.BillingServicesTax1
    ISO20022.Camt086001.BillingMethod2 *-- ISO20022.Camt086001.BillingServicesAmount1
    ISO20022.Camt086001.BillingMethod2 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingMethod3 {
        + TaxId  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServicesTax2~
        + SvcTaxPricAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingMethod3 *-- ISO20022.Camt086001.BillingServicesTax2
    ISO20022.Camt086001.BillingMethod3 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingMethod4 {
        + TaxClctn  : ISO20022.Camt086001.TaxCalculation1
        + SvcDtl  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServiceParameters2~
    }
    ISO20022.Camt086001.BillingMethod4 *-- ISO20022.Camt086001.TaxCalculation1
    ISO20022.Camt086001.BillingMethod4 *-- ISO20022.Camt086001.BillingServiceParameters2
    class ISO20022.Camt086001.BillingPrice1 {
        + Rule  : String
        + Mtd  : String
        + UnitPric  : ISO20022.Camt086001.AmountAndDirection34
        + Ccy  : String
    }
    ISO20022.Camt086001.BillingPrice1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingRate1 {
        + DaysInYr  : Decimal
        + DaysInPrd  : Decimal
        + Val  : Decimal
        + Id  : ISO20022.Camt086001.BillingRateIdentification1Choice
    }
    ISO20022.Camt086001.BillingRate1 *-- ISO20022.Camt086001.BillingRateIdentification1Choice
    class ISO20022.Camt086001.BillingRateIdentification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.BillingService2 {
        + TaxClctn  : ISO20022.Camt086001.BillingMethod1Choice
        + TaxDsgnt  : ISO20022.Camt086001.ServiceTaxDesignation1
        + BalReqrdAcctAmt  : ISO20022.Camt086001.AmountAndDirection34
        + OrgnlChrgSttlmAmt  : ISO20022.Camt086001.AmountAndDirection34
        + OrgnlChrgPric  : ISO20022.Camt086001.AmountAndDirection34
        + PmtMtd  : String
        + Pric  : ISO20022.Camt086001.BillingPrice1
        + SvcDtl  : ISO20022.Camt086001.BillingServiceParameters3
    }
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.BillingMethod1Choice
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.ServiceTaxDesignation1
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.BillingPrice1
    ISO20022.Camt086001.BillingService2 *-- ISO20022.Camt086001.BillingServiceParameters3
    class ISO20022.Camt086001.BillingServiceAdjustment1 {
        + NewChrgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + OrgnlChrgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + NewVol  : Decimal
        + OrgnlVol  : Decimal
        + VolChng  : Decimal
        + NewPric  : ISO20022.Camt086001.AmountAndDirection34
        + OrgnlPric  : ISO20022.Camt086001.AmountAndDirection34
        + PricChng  : ISO20022.Camt086001.AmountAndDirection34
        + SubSvc  : ISO20022.Camt086001.BillingSubServiceIdentification1
        + AdjstmntId  : String
        + ErrDt  : DateTime
        + BalReqrdAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Amt  : ISO20022.Camt086001.AmountAndDirection34
        + Desc  : String
        + Tp  : String
    }
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.BillingSubServiceIdentification1
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceAdjustment1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServiceCommonIdentification1 {
        + Id  : String
        + Issr  : String
    }
    class ISO20022.Camt086001.BillingServiceIdentification2 {
        + Desc  : String
        + SubSvc  : ISO20022.Camt086001.BillingSubServiceIdentification1
        + Id  : String
    }
    ISO20022.Camt086001.BillingServiceIdentification2 *-- ISO20022.Camt086001.BillingSubServiceIdentification1
    class ISO20022.Camt086001.BillingServiceIdentification3 {
        + SvcTp  : String
        + BkTxCd  : ISO20022.Camt086001.BankTransactionCodeStructure4
        + CmonCd  : ISO20022.Camt086001.BillingServiceCommonIdentification1
        + Desc  : String
        + SubSvc  : ISO20022.Camt086001.BillingSubServiceIdentification1
        + Id  : String
    }
    ISO20022.Camt086001.BillingServiceIdentification3 *-- ISO20022.Camt086001.BankTransactionCodeStructure4
    ISO20022.Camt086001.BillingServiceIdentification3 *-- ISO20022.Camt086001.BillingServiceCommonIdentification1
    ISO20022.Camt086001.BillingServiceIdentification3 *-- ISO20022.Camt086001.BillingSubServiceIdentification1
    class ISO20022.Camt086001.BillingServiceParameters2 {
        + SvcChrgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + UnitPric  : ISO20022.Camt086001.AmountAndDirection34
        + Vol  : Decimal
        + BkSvc  : ISO20022.Camt086001.BillingServiceIdentification2
    }
    ISO20022.Camt086001.BillingServiceParameters2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceParameters2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServiceParameters2 *-- ISO20022.Camt086001.BillingServiceIdentification2
    class ISO20022.Camt086001.BillingServiceParameters3 {
        + Vol  : Decimal
        + BkSvc  : ISO20022.Camt086001.BillingServiceIdentification3
    }
    ISO20022.Camt086001.BillingServiceParameters3 *-- ISO20022.Camt086001.BillingServiceIdentification3
    class ISO20022.Camt086001.BillingServicesAmount1 {
        + PricgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + HstAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingServicesAmount1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServicesAmount1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServicesAmount2 {
        + PricgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + SttlmAmt  : ISO20022.Camt086001.AmountAndDirection34
        + HstAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingServicesAmount2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServicesAmount2 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServicesAmount2 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServicesAmount3 {
        + HstAmt  : ISO20022.Camt086001.AmountAndDirection34
        + SrcAmt  : ISO20022.Camt086001.AmountAndDirection34
    }
    ISO20022.Camt086001.BillingServicesAmount3 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServicesAmount3 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServicesTax1 {
        + PricgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + HstAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Rate  : Decimal
        + Desc  : String
        + Nb  : String
    }
    ISO20022.Camt086001.BillingServicesTax1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingServicesTax1 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServicesTax2 {
        + PricgAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Rate  : Decimal
        + Desc  : String
        + Nb  : String
    }
    ISO20022.Camt086001.BillingServicesTax2 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingServicesTax3 {
        + TtlTaxAmt  : ISO20022.Camt086001.AmountAndDirection34
        + Rate  : Decimal
        + Desc  : String
        + Nb  : String
    }
    ISO20022.Camt086001.BillingServicesTax3 *-- ISO20022.Camt086001.AmountAndDirection34
    class ISO20022.Camt086001.BillingStatement5 {
        + SvcAdjstmnt  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServiceAdjustment1~
        + BalAdjstmnt  : global::System.Collections.Generic.List~ISO20022.Camt086001.BalanceAdjustment1~
        + TaxRgn  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingTaxRegion3~
        + Svc  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingService2~
        + Compstn  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingCompensation1~
        + Bal  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingBalance1~
        + CcyXchg  : global::System.Collections.Generic.List~ISO20022.Camt086001.CurrencyExchange6~
        + RateData  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingRate1~
        + AcctChrtcs  : ISO20022.Camt086001.CashAccountCharacteristics5
        + Sts  : String
        + CreDtTm  : DateTime
        + FrToDt  : ISO20022.Camt086001.DatePeriod1
        + StmtId  : String
    }
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingServiceAdjustment1
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BalanceAdjustment1
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingTaxRegion3
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingService2
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingCompensation1
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingBalance1
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.CurrencyExchange6
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.BillingRate1
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.CashAccountCharacteristics5
    ISO20022.Camt086001.BillingStatement5 *-- ISO20022.Camt086001.DatePeriod1
    class ISO20022.Camt086001.BillingStatementStatus1Code {
        TEST = 1
        RPLC = 2
        ORGN = 3
    }
    class ISO20022.Camt086001.BillingSubServiceIdentification1 {
        + Id  : String
        + Issr  : ISO20022.Camt086001.BillingSubServiceQualifier1Choice
    }
    ISO20022.Camt086001.BillingSubServiceIdentification1 *-- ISO20022.Camt086001.BillingSubServiceQualifier1Choice
    class ISO20022.Camt086001.BillingSubServiceQualifier1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.BillingSubServiceQualifier1Code {
        MACT = 1
        SEQN = 2
        BILA = 3
        STOR = 4
        LBOX = 5
    }
    class ISO20022.Camt086001.BillingTaxCalculationMethod1Code {
        UDFD = 1
        MTDD = 2
        MTDC = 3
        MTDB = 4
        MTDA = 5
        NTAX = 6
    }
    class ISO20022.Camt086001.BillingTaxIdentification3 {
        + TaxCtct  : ISO20022.Camt086001.Contact13
        + TaxRegnNb  : String
        + VATRegnNb  : String
    }
    ISO20022.Camt086001.BillingTaxIdentification3 *-- ISO20022.Camt086001.Contact13
    class ISO20022.Camt086001.BillingTaxRegion3 {
        + TaxDueToRgn  : ISO20022.Camt086001.AmountAndDirection34
        + SttlmAmt  : ISO20022.Camt086001.AmountAndDirection34
        + MtdC  : ISO20022.Camt086001.BillingMethod4
        + InvcNb  : String
        + SndgFI  : ISO20022.Camt086001.BillingTaxIdentification3
        + PtDt  : DateTime
        + CstmrTaxId  : String
        + RgnNm  : String
        + RgnNb  : String
    }
    ISO20022.Camt086001.BillingTaxRegion3 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingTaxRegion3 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.BillingTaxRegion3 *-- ISO20022.Camt086001.BillingMethod4
    ISO20022.Camt086001.BillingTaxRegion3 *-- ISO20022.Camt086001.BillingTaxIdentification3
    class ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt086001.BranchData5
        + FinInstnId  : ISO20022.Camt086001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt086001.BranchData5
    ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt086001.FinancialInstitutionIdentification23
    class ISO20022.Camt086001.BranchData5 {
        + PstlAdr  : ISO20022.Camt086001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt086001.BranchData5 *-- ISO20022.Camt086001.PostalAddress27
    class ISO20022.Camt086001.CashAccount40 {
        + Prxy  : ISO20022.Camt086001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt086001.CashAccountType2Choice
        + Id  : ISO20022.Camt086001.AccountIdentification4Choice
    }
    ISO20022.Camt086001.CashAccount40 *-- ISO20022.Camt086001.ProxyAccountIdentification1
    ISO20022.Camt086001.CashAccount40 *-- ISO20022.Camt086001.CashAccountType2Choice
    ISO20022.Camt086001.CashAccount40 *-- ISO20022.Camt086001.AccountIdentification4Choice
    class ISO20022.Camt086001.CashAccountCharacteristics5 {
        + AcctSvcrCtct  : ISO20022.Camt086001.Contact13
        + Tax  : ISO20022.Camt086001.AccountTax1
        + HstCcyCd  : String
        + SttlmCcyCd  : String
        + AcctBalCcyCd  : String
        + SttlmAdvc  : String
        + DelydDbtDt  : DateTime
        + DbtAcct  : ISO20022.Camt086001.AccountIdentification4Choice
        + CompstnMtd  : String
        + PrntAcct  : ISO20022.Camt086001.ParentCashAccount5
        + AcctSvcr  : ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8
        + CshAcct  : ISO20022.Camt086001.CashAccount40
        + AcctLvl  : String
    }
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.Contact13
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.AccountTax1
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.AccountIdentification4Choice
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.ParentCashAccount5
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt086001.CashAccountCharacteristics5 *-- ISO20022.Camt086001.CashAccount40
    class ISO20022.Camt086001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt086001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt086001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt086001.ClearingSystemIdentification2Choice
    class ISO20022.Camt086001.CompensationMethod1Code {
        DDBT = 1
        INVD = 2
        DBTD = 3
        NOCP = 4
    }
    class ISO20022.Camt086001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt086001.OtherContact1~
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
    ISO20022.Camt086001.Contact13 *-- ISO20022.Camt086001.OtherContact1
    class ISO20022.Camt086001.CurrencyExchange6 {
        + QtnDt  : DateTime
        + Cmnts  : String
        + UnitCcy  : String
        + Desc  : String
        + XchgRate  : Decimal
        + TrgtCcy  : String
        + SrcCcy  : String
    }
    class ISO20022.Camt086001.DatePeriod1 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt086001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.FinancialInstitutionIdentification19 {
        + Othr  : ISO20022.Camt086001.GenericFinancialIdentification1
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt086001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt086001.FinancialInstitutionIdentification19 *-- ISO20022.Camt086001.GenericFinancialIdentification1
    ISO20022.Camt086001.FinancialInstitutionIdentification19 *-- ISO20022.Camt086001.ClearingSystemMemberIdentification2
    class ISO20022.Camt086001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt086001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt086001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt086001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt086001.FinancialInstitutionIdentification23 *-- ISO20022.Camt086001.GenericFinancialIdentification1
    ISO20022.Camt086001.FinancialInstitutionIdentification23 *-- ISO20022.Camt086001.PostalAddress27
    ISO20022.Camt086001.FinancialInstitutionIdentification23 *-- ISO20022.Camt086001.ClearingSystemMemberIdentification2
    class ISO20022.Camt086001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt086001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt086001.GenericAccountIdentification1 *-- ISO20022.Camt086001.AccountSchemeName1Choice
    class ISO20022.Camt086001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt086001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt086001.GenericFinancialIdentification1 *-- ISO20022.Camt086001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt086001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt086001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt086001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt086001.GenericOrganisationIdentification3 *-- ISO20022.Camt086001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt086001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt086001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt086001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt086001.OrganisationIdentification39 *-- ISO20022.Camt086001.GenericOrganisationIdentification3
    class ISO20022.Camt086001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt086001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Camt086001.ParentCashAccount5 {
        + Svcr  : ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8
        + Id  : ISO20022.Camt086001.CashAccount40
        + Lvl  : String
    }
    ISO20022.Camt086001.ParentCashAccount5 *-- ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt086001.ParentCashAccount5 *-- ISO20022.Camt086001.CashAccount40
    class ISO20022.Camt086001.Party56Choice {
        + FIId  : ISO20022.Camt086001.FinancialInstitutionIdentification19
        + OrgId  : ISO20022.Camt086001.OrganisationIdentification39
    }
    ISO20022.Camt086001.Party56Choice *-- ISO20022.Camt086001.FinancialInstitutionIdentification19
    ISO20022.Camt086001.Party56Choice *-- ISO20022.Camt086001.OrganisationIdentification39
    class ISO20022.Camt086001.PartyIdentification273 {
        + CtctDtls  : ISO20022.Camt086001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt086001.Party56Choice
        + PstlAdr  : ISO20022.Camt086001.PostalAddress27
        + LglNm  : String
        + Nm  : String
    }
    ISO20022.Camt086001.PartyIdentification273 *-- ISO20022.Camt086001.Contact13
    ISO20022.Camt086001.PartyIdentification273 *-- ISO20022.Camt086001.Party56Choice
    ISO20022.Camt086001.PartyIdentification273 *-- ISO20022.Camt086001.PostalAddress27
    class ISO20022.Camt086001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt086001.AddressType3Choice
    }
    ISO20022.Camt086001.PostalAddress27 *-- ISO20022.Camt086001.AddressType3Choice
    class ISO20022.Camt086001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt086001.ProprietaryBankTransactionCodeStructure1 {
        + Issr  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt086001.ProxyAccountType1Choice
    }
    ISO20022.Camt086001.ProxyAccountIdentification1 *-- ISO20022.Camt086001.ProxyAccountType1Choice
    class ISO20022.Camt086001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt086001.ReportHeader6 {
        + MsgPgntn  : ISO20022.Camt086001.Pagination1
        + RptId  : String
    }
    ISO20022.Camt086001.ReportHeader6 *-- ISO20022.Camt086001.Pagination1
    class ISO20022.Camt086001.ResidenceLocation1Choice {
        + Area  : String
        + Ctry  : String
    }
    class ISO20022.Camt086001.ServiceAdjustmentType1Code {
        NCMP = 1
        COMP = 2
    }
    class ISO20022.Camt086001.ServicePaymentMethod1Code {
        FREE = 1
        WVED = 2
        INVS = 3
        PVCH = 4
        FLAT = 5
        BCMP = 6
    }
    class ISO20022.Camt086001.ServiceTaxDesignation1 {
        + TaxRsn  : global::System.Collections.Generic.List~ISO20022.Camt086001.TaxReason1~
        + Rgn  : String
        + Cd  : String
    }
    ISO20022.Camt086001.ServiceTaxDesignation1 *-- ISO20022.Camt086001.TaxReason1
    class ISO20022.Camt086001.ServiceTaxDesignation1Code {
        TAXE = 1
        ZERO = 2
        XMPT = 3
    }
    class ISO20022.Camt086001.StatementGroup5 {
        + BllgStmt  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingStatement5~
        + RcvrIndvCtct  : global::System.Collections.Generic.List~ISO20022.Camt086001.Contact13~
        + Rcvr  : ISO20022.Camt086001.PartyIdentification273
        + SndrIndvCtct  : global::System.Collections.Generic.List~ISO20022.Camt086001.Contact13~
        + Sndr  : ISO20022.Camt086001.PartyIdentification273
        + GrpId  : String
    }
    ISO20022.Camt086001.StatementGroup5 *-- ISO20022.Camt086001.BillingStatement5
    ISO20022.Camt086001.StatementGroup5 *-- ISO20022.Camt086001.Contact13
    ISO20022.Camt086001.StatementGroup5 *-- ISO20022.Camt086001.PartyIdentification273
    ISO20022.Camt086001.StatementGroup5 *-- ISO20022.Camt086001.Contact13
    ISO20022.Camt086001.StatementGroup5 *-- ISO20022.Camt086001.PartyIdentification273
    class ISO20022.Camt086001.TaxCalculation1 {
        + TtlTax  : ISO20022.Camt086001.AmountAndDirection34
        + TaxId  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServicesTax3~
        + TtlTaxblSvcChrgHstAmt  : ISO20022.Camt086001.AmountAndDirection34
        + TaxblSvcChrgConvs  : global::System.Collections.Generic.List~ISO20022.Camt086001.BillingServicesAmount3~
        + HstCcy  : String
    }
    ISO20022.Camt086001.TaxCalculation1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.TaxCalculation1 *-- ISO20022.Camt086001.BillingServicesTax3
    ISO20022.Camt086001.TaxCalculation1 *-- ISO20022.Camt086001.AmountAndDirection34
    ISO20022.Camt086001.TaxCalculation1 *-- ISO20022.Camt086001.BillingServicesAmount3
    class ISO20022.Camt086001.TaxReason1 {
        + Expltn  : String
        + Cd  : String
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

## Value ISO20022.Camt086001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt086001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Enum ISO20022.Camt086001.AccountLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMRY|Int32||XmlEnum("""SMRY""")|1|
||INTM|Int32||XmlEnum("""INTM""")|2|

---

## Enum ISO20022.Camt086001.AccountLevel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DETL|Int32||XmlEnum("""DETL""")|1|
||SMRY|Int32||XmlEnum("""SMRY""")|2|
||INTM|Int32||XmlEnum("""INTM""")|3|

---

## Value ISO20022.Camt086001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.AccountTax1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonResCtry|ISO20022.Camt086001.ResidenceLocation1Choice||XmlElement()||
|+|Rgn|String||XmlElement()||
|+|ClctnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonResCtry))|

---

## Value ISO20022.Camt086001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt086001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt086001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt086001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.AmountAndDirection34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Camt086001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt086001.BalanceAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EarngsAdjstmntAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Days|Decimal||XmlElement()||
|+|PstngDt|DateTime||XmlElement()||
|+|ErrDt|DateTime||XmlElement()||
|+|AvrgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|BalAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EarngsAdjstmntAmt),validElement(AvrgAmt),validElement(BalAmt))|

---

## Enum ISO20022.Camt086001.BalanceAdjustmentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLLD|Int32||XmlEnum("""CLLD""")|1|
||FLOT|Int32||XmlEnum("""FLOT""")|2|
||LDGR|Int32||XmlEnum("""LDGR""")|3|

---

## Aspect ISO20022.Camt086001.BankServicesBillingStatementV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BllgStmtGrp|global::System.Collections.Generic.List<ISO20022.Camt086001.StatementGroup5>||XmlElement()||
|+|RptHdr|ISO20022.Camt086001.ReportHeader6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BllgStmtGrp""",BllgStmtGrp),validList("""BllgStmtGrp""",BllgStmtGrp),validElement(BllgStmtGrp),validElement(RptHdr))|

---

## Value ISO20022.Camt086001.BankTransactionCodeStructure4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt086001.ProprietaryBankTransactionCodeStructure1||XmlElement()||
|+|Domn|ISO20022.Camt086001.BankTransactionCodeStructure5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Domn))|

---

## Value ISO20022.Camt086001.BankTransactionCodeStructure5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fmly|ISO20022.Camt086001.BankTransactionCodeStructure6||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fmly))|

---

## Value ISO20022.Camt086001.BankTransactionCodeStructure6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubFmlyCd|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt086001.BillingBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyTp|String||XmlElement()||
|+|Val|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Tp|ISO20022.Camt086001.BillingBalanceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Camt086001.BillingBalanceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt086001.BillingChargeMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BBSE|Int32||XmlEnum("""BBSE""")|1|
||ZPRC|Int32||XmlEnum("""ZPRC""")|2|
||TPRC|Int32||XmlEnum("""TPRC""")|3|
||TIR9|Int32||XmlEnum("""TIR9""")|4|
||TIR8|Int32||XmlEnum("""TIR8""")|5|
||TIR7|Int32||XmlEnum("""TIR7""")|6|
||TIR6|Int32||XmlEnum("""TIR6""")|7|
||TIR5|Int32||XmlEnum("""TIR5""")|8|
||TIR4|Int32||XmlEnum("""TIR4""")|9|
||TIR3|Int32||XmlEnum("""TIR3""")|10|
||TIR2|Int32||XmlEnum("""TIR2""")|11|
||TIR1|Int32||XmlEnum("""TIR1""")|12|
||MXRD|Int32||XmlEnum("""MXRD""")|13|
||MCHG|Int32||XmlEnum("""MCHG""")|14|
||LPRC|Int32||XmlEnum("""LPRC""")|15|
||FCHG|Int32||XmlEnum("""FCHG""")|16|
||DPRC|Int32||XmlEnum("""DPRC""")|17|
||BCHG|Int32||XmlEnum("""BCHG""")|18|
||STAM|Int32||XmlEnum("""STAM""")|19|
||UPRC|Int32||XmlEnum("""UPRC""")|20|

---

## Value ISO20022.Camt086001.BillingCompensation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyTp|String||XmlElement()||
|+|Val|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Tp|ISO20022.Camt086001.BillingCompensationType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Camt086001.BillingCompensationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt086001.BillingCurrencyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRCG|Int32||XmlEnum("""PRCG""")|1|
||STLM|Int32||XmlEnum("""STLM""")|2|
||ACCT|Int32||XmlEnum("""ACCT""")|3|

---

## Enum ISO20022.Camt086001.BillingCurrencyType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HOST|Int32||XmlEnum("""HOST""")|1|
||PRCG|Int32||XmlEnum("""PRCG""")|2|
||STLM|Int32||XmlEnum("""STLM""")|3|
||ACCT|Int32||XmlEnum("""ACCT""")|4|

---

## Value ISO20022.Camt086001.BillingMethod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxId|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServicesTax1>||XmlElement()||
|+|TtlChrg|ISO20022.Camt086001.BillingServicesAmount2||XmlElement()||
|+|SvcTax|ISO20022.Camt086001.BillingServicesAmount1||XmlElement()||
|+|SvcChrgHstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""TaxId""",TaxId),validList("""TaxId""",TaxId),validListMax("""TaxId""",TaxId,3),validElement(TaxId),validElement(TtlChrg),validElement(SvcTax),validElement(SvcChrgHstAmt))|

---

## Value ISO20022.Camt086001.BillingMethod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtdD|ISO20022.Camt086001.BillingMethod3||XmlElement()||
|+|MtdB|ISO20022.Camt086001.BillingMethod2||XmlElement()||
|+|MtdA|ISO20022.Camt086001.BillingMethod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtdD),validElement(MtdB),validElement(MtdA),validChoice(MtdD,MtdB,MtdA))|

---

## Value ISO20022.Camt086001.BillingMethod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxId|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServicesTax1>||XmlElement()||
|+|SvcTax|ISO20022.Camt086001.BillingServicesAmount1||XmlElement()||
|+|SvcChrgHstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""TaxId""",TaxId),validList("""TaxId""",TaxId),validListMax("""TaxId""",TaxId,3),validElement(TaxId),validElement(SvcTax),validElement(SvcChrgHstAmt))|

---

## Value ISO20022.Camt086001.BillingMethod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxId|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServicesTax2>||XmlElement()||
|+|SvcTaxPricAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""TaxId""",TaxId),validList("""TaxId""",TaxId),validListMax("""TaxId""",TaxId,3),validElement(TaxId),validElement(SvcTaxPricAmt))|

---

## Value ISO20022.Camt086001.BillingMethod4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctn|ISO20022.Camt086001.TaxCalculation1||XmlElement()||
|+|SvcDtl|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServiceParameters2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctn),validRequired("""SvcDtl""",SvcDtl),validList("""SvcDtl""",SvcDtl),validElement(SvcDtl))|

---

## Value ISO20022.Camt086001.BillingPrice1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rule|String||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|UnitPric|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitPric),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt086001.BillingRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DaysInYr|Decimal||XmlElement()||
|+|DaysInPrd|Decimal||XmlElement()||
|+|Val|Decimal||XmlElement()||
|+|Id|ISO20022.Camt086001.BillingRateIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Camt086001.BillingRateIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.BillingService2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctn|ISO20022.Camt086001.BillingMethod1Choice||XmlElement()||
|+|TaxDsgnt|ISO20022.Camt086001.ServiceTaxDesignation1||XmlElement()||
|+|BalReqrdAcctAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|OrgnlChrgSttlmAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|OrgnlChrgPric|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|PmtMtd|String||XmlElement()||
|+|Pric|ISO20022.Camt086001.BillingPrice1||XmlElement()||
|+|SvcDtl|ISO20022.Camt086001.BillingServiceParameters3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctn),validElement(TaxDsgnt),validElement(BalReqrdAcctAmt),validElement(OrgnlChrgSttlmAmt),validElement(OrgnlChrgPric),validElement(Pric),validElement(SvcDtl))|

---

## Value ISO20022.Camt086001.BillingServiceAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NewChrgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|OrgnlChrgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|NewVol|Decimal||XmlElement()||
|+|OrgnlVol|Decimal||XmlElement()||
|+|VolChng|Decimal||XmlElement()||
|+|NewPric|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|OrgnlPric|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|PricChng|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|SubSvc|ISO20022.Camt086001.BillingSubServiceIdentification1||XmlElement()||
|+|AdjstmntId|String||XmlElement()||
|+|ErrDt|DateTime||XmlElement()||
|+|BalReqrdAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Amt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewChrgAmt),validElement(OrgnlChrgAmt),validElement(NewPric),validElement(OrgnlPric),validElement(PricChng),validElement(SubSvc),validElement(BalReqrdAmt),validElement(Amt))|

---

## Value ISO20022.Camt086001.BillingServiceCommonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt086001.BillingServiceIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|SubSvc|ISO20022.Camt086001.BillingSubServiceIdentification1||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubSvc))|

---

## Value ISO20022.Camt086001.BillingServiceIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcTp|String||XmlElement()||
|+|BkTxCd|ISO20022.Camt086001.BankTransactionCodeStructure4||XmlElement()||
|+|CmonCd|ISO20022.Camt086001.BillingServiceCommonIdentification1||XmlElement()||
|+|Desc|String||XmlElement()||
|+|SubSvc|ISO20022.Camt086001.BillingSubServiceIdentification1||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkTxCd),validElement(CmonCd),validElement(SubSvc))|

---

## Value ISO20022.Camt086001.BillingServiceParameters2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcChrgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|UnitPric|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Vol|Decimal||XmlElement()||
|+|BkSvc|ISO20022.Camt086001.BillingServiceIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SvcChrgAmt),validElement(UnitPric),validElement(BkSvc))|

---

## Value ISO20022.Camt086001.BillingServiceParameters3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vol|Decimal||XmlElement()||
|+|BkSvc|ISO20022.Camt086001.BillingServiceIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkSvc))|

---

## Value ISO20022.Camt086001.BillingServicesAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|HstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricgAmt),validElement(HstAmt))|

---

## Value ISO20022.Camt086001.BillingServicesAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|SttlmAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|HstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricgAmt),validElement(SttlmAmt),validElement(HstAmt))|

---

## Value ISO20022.Camt086001.BillingServicesAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|SrcAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HstAmt),validElement(SrcAmt))|

---

## Value ISO20022.Camt086001.BillingServicesTax1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|HstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricgAmt),validElement(HstAmt))|

---

## Value ISO20022.Camt086001.BillingServicesTax2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricgAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricgAmt))|

---

## Value ISO20022.Camt086001.BillingServicesTax3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlTaxAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlTaxAmt))|

---

## Value ISO20022.Camt086001.BillingStatement5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcAdjstmnt|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServiceAdjustment1>||XmlElement()||
|+|BalAdjstmnt|global::System.Collections.Generic.List<ISO20022.Camt086001.BalanceAdjustment1>||XmlElement()||
|+|TaxRgn|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingTaxRegion3>||XmlElement()||
|+|Svc|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingService2>||XmlElement()||
|+|Compstn|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingCompensation1>||XmlElement()||
|+|Bal|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingBalance1>||XmlElement()||
|+|CcyXchg|global::System.Collections.Generic.List<ISO20022.Camt086001.CurrencyExchange6>||XmlElement()||
|+|RateData|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingRate1>||XmlElement()||
|+|AcctChrtcs|ISO20022.Camt086001.CashAccountCharacteristics5||XmlElement()||
|+|Sts|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|FrToDt|ISO20022.Camt086001.DatePeriod1||XmlElement()||
|+|StmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SvcAdjstmnt""",SvcAdjstmnt),validElement(SvcAdjstmnt),validList("""BalAdjstmnt""",BalAdjstmnt),validElement(BalAdjstmnt),validList("""TaxRgn""",TaxRgn),validElement(TaxRgn),validList("""Svc""",Svc),validElement(Svc),validList("""Compstn""",Compstn),validElement(Compstn),validList("""Bal""",Bal),validElement(Bal),validList("""CcyXchg""",CcyXchg),validElement(CcyXchg),validList("""RateData""",RateData),validElement(RateData),validElement(AcctChrtcs),validElement(FrToDt))|

---

## Enum ISO20022.Camt086001.BillingStatementStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEST|Int32||XmlEnum("""TEST""")|1|
||RPLC|Int32||XmlEnum("""RPLC""")|2|
||ORGN|Int32||XmlEnum("""ORGN""")|3|

---

## Value ISO20022.Camt086001.BillingSubServiceIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Issr|ISO20022.Camt086001.BillingSubServiceQualifier1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Camt086001.BillingSubServiceQualifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt086001.BillingSubServiceQualifier1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MACT|Int32||XmlEnum("""MACT""")|1|
||SEQN|Int32||XmlEnum("""SEQN""")|2|
||BILA|Int32||XmlEnum("""BILA""")|3|
||STOR|Int32||XmlEnum("""STOR""")|4|
||LBOX|Int32||XmlEnum("""LBOX""")|5|

---

## Enum ISO20022.Camt086001.BillingTaxCalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UDFD|Int32||XmlEnum("""UDFD""")|1|
||MTDD|Int32||XmlEnum("""MTDD""")|2|
||MTDC|Int32||XmlEnum("""MTDC""")|3|
||MTDB|Int32||XmlEnum("""MTDB""")|4|
||MTDA|Int32||XmlEnum("""MTDA""")|5|
||NTAX|Int32||XmlEnum("""NTAX""")|6|

---

## Value ISO20022.Camt086001.BillingTaxIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxCtct|ISO20022.Camt086001.Contact13||XmlElement()||
|+|TaxRegnNb|String||XmlElement()||
|+|VATRegnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxCtct))|

---

## Value ISO20022.Camt086001.BillingTaxRegion3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxDueToRgn|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|SttlmAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|MtdC|ISO20022.Camt086001.BillingMethod4||XmlElement()||
|+|InvcNb|String||XmlElement()||
|+|SndgFI|ISO20022.Camt086001.BillingTaxIdentification3||XmlElement()||
|+|PtDt|DateTime||XmlElement()||
|+|CstmrTaxId|String||XmlElement()||
|+|RgnNm|String||XmlElement()||
|+|RgnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxDueToRgn),validElement(SttlmAmt),validElement(MtdC),validElement(SndgFI))|

---

## Value ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt086001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt086001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt086001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt086001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt086001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt086001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt086001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt086001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt086001.CashAccountCharacteristics5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcrCtct|ISO20022.Camt086001.Contact13||XmlElement()||
|+|Tax|ISO20022.Camt086001.AccountTax1||XmlElement()||
|+|HstCcyCd|String||XmlElement()||
|+|SttlmCcyCd|String||XmlElement()||
|+|AcctBalCcyCd|String||XmlElement()||
|+|SttlmAdvc|String||XmlElement()||
|+|DelydDbtDt|DateTime||XmlElement()||
|+|DbtAcct|ISO20022.Camt086001.AccountIdentification4Choice||XmlElement()||
|+|CompstnMtd|String||XmlElement()||
|+|PrntAcct|ISO20022.Camt086001.ParentCashAccount5||XmlElement()||
|+|AcctSvcr|ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcct|ISO20022.Camt086001.CashAccount40||XmlElement()||
|+|AcctLvl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcrCtct),validElement(Tax),validPattern("""HstCcyCd""",HstCcyCd,"""[A-Z]{3,3}"""),validPattern("""SttlmCcyCd""",SttlmCcyCd,"""[A-Z]{3,3}"""),validPattern("""AcctBalCcyCd""",AcctBalCcyCd,"""[A-Z]{3,3}"""),validElement(DbtAcct),validElement(PrntAcct),validElement(AcctSvcr),validElement(CshAcct))|

---

## Value ISO20022.Camt086001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt086001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt086001.CompensationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DDBT|Int32||XmlEnum("""DDBT""")|1|
||INVD|Int32||XmlEnum("""INVD""")|2|
||DBTD|Int32||XmlEnum("""DBTD""")|3|
||NOCP|Int32||XmlEnum("""NOCP""")|4|

---

## Value ISO20022.Camt086001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt086001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Camt086001.CurrencyExchange6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnDt|DateTime||XmlElement()||
|+|Cmnts|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|TrgtCcy|String||XmlElement()||
|+|SrcCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validPattern("""TrgtCcy""",TrgtCcy,"""[A-Z]{3,3}"""),validPattern("""SrcCcy""",SrcCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt086001.DatePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Camt086001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BkSvcsBllgStmt|ISO20022.Camt086001.BankServicesBillingStatementV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkSvcsBllgStmt))|

---

## Value ISO20022.Camt086001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.FinancialInstitutionIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt086001.GenericFinancialIdentification1||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt086001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt086001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt086001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt086001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt086001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt086001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt086001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt086001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt086001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt086001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt086001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt086001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Enum ISO20022.Camt086001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt086001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt086001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt086001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt086001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Camt086001.ParentCashAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Camt086001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Id|ISO20022.Camt086001.CashAccount40||XmlElement()||
|+|Lvl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(Id))|

---

## Value ISO20022.Camt086001.Party56Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FIId|ISO20022.Camt086001.FinancialInstitutionIdentification19||XmlElement()||
|+|OrgId|ISO20022.Camt086001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIId),validElement(OrgId),validChoice(FIId,OrgId))|

---

## Value ISO20022.Camt086001.PartyIdentification273


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt086001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt086001.Party56Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt086001.PostalAddress27||XmlElement()||
|+|LglNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt086001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt086001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt086001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt086001.ProprietaryBankTransactionCodeStructure1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt086001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt086001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt086001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt086001.ReportHeader6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgPgntn|ISO20022.Camt086001.Pagination1||XmlElement()||
|+|RptId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgPgntn))|

---

## Value ISO20022.Camt086001.ResidenceLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Area|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(Area,Ctry))|

---

## Enum ISO20022.Camt086001.ServiceAdjustmentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCMP|Int32||XmlEnum("""NCMP""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Enum ISO20022.Camt086001.ServicePaymentMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FREE|Int32||XmlEnum("""FREE""")|1|
||WVED|Int32||XmlEnum("""WVED""")|2|
||INVS|Int32||XmlEnum("""INVS""")|3|
||PVCH|Int32||XmlEnum("""PVCH""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|
||BCMP|Int32||XmlEnum("""BCMP""")|6|

---

## Value ISO20022.Camt086001.ServiceTaxDesignation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxRsn|global::System.Collections.Generic.List<ISO20022.Camt086001.TaxReason1>||XmlElement()||
|+|Rgn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxRsn""",TaxRsn),validElement(TaxRsn))|

---

## Enum ISO20022.Camt086001.ServiceTaxDesignation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAXE|Int32||XmlEnum("""TAXE""")|1|
||ZERO|Int32||XmlEnum("""ZERO""")|2|
||XMPT|Int32||XmlEnum("""XMPT""")|3|

---

## Value ISO20022.Camt086001.StatementGroup5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BllgStmt|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingStatement5>||XmlElement()||
|+|RcvrIndvCtct|global::System.Collections.Generic.List<ISO20022.Camt086001.Contact13>||XmlElement()||
|+|Rcvr|ISO20022.Camt086001.PartyIdentification273||XmlElement()||
|+|SndrIndvCtct|global::System.Collections.Generic.List<ISO20022.Camt086001.Contact13>||XmlElement()||
|+|Sndr|ISO20022.Camt086001.PartyIdentification273||XmlElement()||
|+|GrpId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BllgStmt""",BllgStmt),validList("""BllgStmt""",BllgStmt),validElement(BllgStmt),validList("""RcvrIndvCtct""",RcvrIndvCtct),validListMax("""RcvrIndvCtct""",RcvrIndvCtct,2),validElement(RcvrIndvCtct),validElement(Rcvr),validList("""SndrIndvCtct""",SndrIndvCtct),validListMax("""SndrIndvCtct""",SndrIndvCtct,2),validElement(SndrIndvCtct),validElement(Sndr))|

---

## Value ISO20022.Camt086001.TaxCalculation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlTax|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|TaxId|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServicesTax3>||XmlElement()||
|+|TtlTaxblSvcChrgHstAmt|ISO20022.Camt086001.AmountAndDirection34||XmlElement()||
|+|TaxblSvcChrgConvs|global::System.Collections.Generic.List<ISO20022.Camt086001.BillingServicesAmount3>||XmlElement()||
|+|HstCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlTax),validRequired("""TaxId""",TaxId),validList("""TaxId""",TaxId),validListMax("""TaxId""",TaxId,3),validElement(TaxId),validElement(TtlTaxblSvcChrgHstAmt),validRequired("""TaxblSvcChrgConvs""",TaxblSvcChrgConvs),validList("""TaxblSvcChrgConvs""",TaxblSvcChrgConvs),validElement(TaxblSvcChrgConvs),validPattern("""HstCcy""",HstCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt086001.TaxReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Expltn|String||XmlElement()||
|+|Cd|String||XmlElement()||
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

