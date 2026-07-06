# catp.003.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Catp003001.ATMCassette3 {
        + CssttSts  : String
        + MdiaCntrs  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMCassetteCounters6~
        + MdiaTp  : String
        + SubTp  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + SrlNb  : String
        + LogclId  : String
        + PhysId  : String
    }
    ISO20022.Catp003001.ATMCassette3 *-- ISO20022.Catp003001.ATMCassetteCounters6
    class ISO20022.Catp003001.ATMCassetteCounters5 {
        + InitlAmt  : Decimal
        + InitlNb  : Decimal
        + PresntdNb  : Decimal
        + RjctdNb  : Decimal
        + RtrctdAmt  : Decimal
        + RtrctdNb  : Decimal
        + RcycldNb  : Decimal
        + DpstdAmt  : Decimal
        + DpstdNb  : Decimal
        + DspnsdNb  : Decimal
        + RmvdAmt  : Decimal
        + RmvdNb  : Decimal
        + AddedNb  : Decimal
        + Tp  : String
    }
    class ISO20022.Catp003001.ATMCassetteCounters6 {
        + FlowTtls  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMCassetteCounters5~
        + CurAmt  : Decimal
        + CurNb  : Decimal
        + InitlCnt  : Decimal
        + MdiaCtgy  : String
        + Ccy  : String
        + UnitVal  : Decimal
    }
    ISO20022.Catp003001.ATMCassetteCounters6 *-- ISO20022.Catp003001.ATMCassetteCounters5
    class ISO20022.Catp003001.ATMCassetteStatus1Code {
        CUMP = 1
        CUNR = 2
        CUNA = 3
        CUMS = 4
        CUNP = 5
        CUMT = 6
        CULW = 7
        CUHG = 8
        CUFL = 9
        CUOK = 10
    }
    class ISO20022.Catp003001.ATMCassetteType1Code {
        RTRC = 1
        RPLT = 2
        RJCT = 3
        RCYC = 4
        DISP = 5
        DPST = 6
    }
    class ISO20022.Catp003001.ATMConfigurationParameter1 {
        + Vrsn  : String
        + Tp  : String
    }
    class ISO20022.Catp003001.ATMContext9 {
        + Svc  : ISO20022.Catp003001.ATMService10
        + SsnRef  : String
    }
    ISO20022.Catp003001.ATMContext9 *-- ISO20022.Catp003001.ATMService10
    class ISO20022.Catp003001.ATMCounterType3Code {
        SLRP = 1
        OPER = 2
        PRTN = 3
        BDAY = 4
        CTOF = 5
        CTXN = 6
        INQU = 7
    }
    class ISO20022.Catp003001.ATMCustomer7 {
        + AuthntcnRslt  : global::System.Collections.Generic.List~ISO20022.Catp003001.TransactionVerificationResult5~
        + SelctdLang  : String
        + Prfl  : ISO20022.Catp003001.ATMCustomerProfile6
    }
    ISO20022.Catp003001.ATMCustomer7 *-- ISO20022.Catp003001.TransactionVerificationResult5
    ISO20022.Catp003001.ATMCustomer7 *-- ISO20022.Catp003001.ATMCustomerProfile6
    class ISO20022.Catp003001.ATMCustomerProfile1Code {
        PREQ = 1
        OREQ = 2
        CRDF = 3
    }
    class ISO20022.Catp003001.ATMCustomerProfile6 {
        + PrefrdLang  : String
        + CstmrId  : String
        + PrflRef  : String
        + RtrvlMd  : String
    }
    class ISO20022.Catp003001.ATMDevice1Code {
        RWDR = 1
        RPRN = 2
        JPRN = 3
        JRNL = 4
        DPRN = 5
        CDIS = 6
    }
    class ISO20022.Catp003001.ATMEnvironment19 {
        + Card  : ISO20022.Catp003001.PaymentCard37
        + Cstmr  : ISO20022.Catp003001.ATMCustomer7
        + ATM  : ISO20022.Catp003001.AutomatedTellerMachine12
        + HstgNtty  : ISO20022.Catp003001.TerminalHosting1
        + ATMMgrId  : String
        + Acqrr  : ISO20022.Catp003001.Acquirer7
    }
    ISO20022.Catp003001.ATMEnvironment19 *-- ISO20022.Catp003001.PaymentCard37
    ISO20022.Catp003001.ATMEnvironment19 *-- ISO20022.Catp003001.ATMCustomer7
    ISO20022.Catp003001.ATMEnvironment19 *-- ISO20022.Catp003001.AutomatedTellerMachine12
    ISO20022.Catp003001.ATMEnvironment19 *-- ISO20022.Catp003001.TerminalHosting1
    ISO20022.Catp003001.ATMEnvironment19 *-- ISO20022.Catp003001.Acquirer7
    class ISO20022.Catp003001.ATMEquipment1 {
        + CfgtnParam  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMConfigurationParameter1~
        + ApprvlNb  : String
        + ApplVrsn  : String
        + ApplNm  : String
        + ApplPrvdr  : String
        + SrlNb  : String
        + Mdl  : String
        + Manfctr  : String
    }
    ISO20022.Catp003001.ATMEquipment1 *-- ISO20022.Catp003001.ATMConfigurationParameter1
    class ISO20022.Catp003001.ATMExchangeRateComponent1 {
        + AddtlInf  : String
        + PblshDt  : DateTime
        + XchgRate  : Decimal
    }
    class ISO20022.Catp003001.ATMFeeComponent1 {
        + FeeLabl  : String
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp003001.ATMMediaType1Code {
        UDTM = 1
        STMP = 2
        NOTE = 3
        CPNS = 4
        CMDT = 5
        COIN = 6
        CARD = 7
    }
    class ISO20022.Catp003001.ATMMediaType3Code {
        UNRG = 1
        UNFT = 2
        SPCT = 3
        FITU = 4
        FITN = 5
        CNTR = 6
    }
    class ISO20022.Catp003001.ATMMediaType4Code {
        MLTP = 1
        ENVP = 2
        CHCK = 3
        UDTM = 4
        STMP = 5
        NOTE = 6
        CPNS = 7
        CMDT = 8
        COIN = 9
        CARD = 10
    }
    class ISO20022.Catp003001.ATMMessageFunction2 {
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + Fctn  : String
    }
    class ISO20022.Catp003001.ATMNoteType1Code {
        UNFT = 1
        SCNT = 2
        IDVD = 3
        CNTR = 4
        ALLT = 5
    }
    class ISO20022.Catp003001.ATMService10 {
        + SvcVarntId  : global::System.Collections.Generic.List~String~
        + SvcTp  : String
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + SvcRef  : String
    }
    class ISO20022.Catp003001.ATMServiceType1Code {
        SPRV = 1
        STDR = 2
        PRFL = 3
        PATH = 4
        CHSN = 5
    }
    class ISO20022.Catp003001.ATMTotals4 {
        + ATMCurNb  : Decimal
        + ATMBalNb  : Decimal
        + ATMCur  : Decimal
        + ATMBal  : Decimal
        + Ccy  : String
        + MdiaTp  : String
    }
    class ISO20022.Catp003001.ATMTransaction53 {
        + Csstt  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMCassette3~
        + ATMTtls  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMTotals4~
        + ICCRltdData  : String
        + AuthstnRslt  : ISO20022.Catp003001.AuthorisationResult20
        + Lmts  : ISO20022.Catp003001.ATMTransactionAmounts6
        + CstmrCnsnt  : String
        + RctPrtd  : String
        + ReqdRct  : String
        + AddtlChrg  : global::System.Collections.Generic.List~ISO20022.Catp003001.DetailedAmount13~
        + CcyConvsRslt  : ISO20022.Catp003001.CurrencyConversion32
        + DtldReqdAmt  : ISO20022.Catp003001.DetailedAmount12
        + TtlReqdAmt  : Decimal
        + TtlAuthrsdAmt  : Decimal
        + TtlPresntdAmt  : ISO20022.Catp003001.AmountAndCurrency1
        + PrtctdAcctData  : ISO20022.Catp003001.ContentInformationType10
        + AcctData  : ISO20022.Catp003001.CardAccount17
        + RcncltnId  : String
        + IncdntDtl  : global::System.Collections.Generic.List~String~
        + Incdnt  : global::System.Collections.Generic.List~String~
        + PresntdAmtSts  : String
        + BndlPresntdAmt  : global::System.Collections.Generic.List~Decimal~
        + MultiBndl  : String
        + TxSts  : String
        + TxId  : ISO20022.Catp003001.TransactionIdentifier3
    }
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.ATMCassette3
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.ATMTotals4
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.AuthorisationResult20
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.ATMTransactionAmounts6
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.DetailedAmount13
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.CurrencyConversion32
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.DetailedAmount12
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.AmountAndCurrency1
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.ContentInformationType10
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.CardAccount17
    ISO20022.Catp003001.ATMTransaction53 *-- ISO20022.Catp003001.TransactionIdentifier3
    class ISO20022.Catp003001.ATMTransactionAmounts6 {
        + AddtlAmt  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMTransactionAmounts7~
        + MinPssblAmt  : Decimal
        + MaxPssblAmt  : Decimal
        + Ccy  : String
    }
    ISO20022.Catp003001.ATMTransactionAmounts6 *-- ISO20022.Catp003001.ATMTransactionAmounts7
    class ISO20022.Catp003001.ATMTransactionAmounts7 {
        + Labl  : String
        + Ccy  : String
        + Amt  : Decimal
        + Tp  : String
    }
    class ISO20022.Catp003001.ATMTransactionStatus1Code {
        SCSS = 1
        FAIL = 2
        DOBT = 3
    }
    class ISO20022.Catp003001.ATMTransactionStatus2Code {
        NONE = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3 {
        + Tx  : ISO20022.Catp003001.ATMTransaction53
        + Cntxt  : ISO20022.Catp003001.ATMContext9
        + Envt  : ISO20022.Catp003001.ATMEnvironment19
    }
    ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3 *-- ISO20022.Catp003001.ATMTransaction53
    ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3 *-- ISO20022.Catp003001.ATMContext9
    ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3 *-- ISO20022.Catp003001.ATMEnvironment19
    class ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 {
        + SctyTrlr  : ISO20022.Catp003001.ContentInformationType15
        + ATMWdrwlCmpltnAdvc  : ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3
        + PrtctdATMWdrwlCmpltnAdvc  : ISO20022.Catp003001.ContentInformationType10
        + Hdr  : ISO20022.Catp003001.Header32
    }
    ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 *-- ISO20022.Catp003001.ContentInformationType15
    ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 *-- ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3
    ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 *-- ISO20022.Catp003001.ContentInformationType10
    ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 *-- ISO20022.Catp003001.Header32
    class ISO20022.Catp003001.AccountChoiceMethod1Code {
        TPSL = 1
        NOSL = 2
        IMPL = 3
        IMAC = 4
        ENTR = 5
        ACSL = 6
    }
    class ISO20022.Catp003001.AccountIdentification80Choice {
        + Email  : String
        + MSISDN  : String
        + DmstAcct  : ISO20022.Catp003001.SimpleIdentificationInformation4
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Catp003001.AccountIdentification80Choice *-- ISO20022.Catp003001.SimpleIdentificationInformation4
    class ISO20022.Catp003001.Acquirer7 {
        + Brnch  : String
        + AcqrgInstn  : String
    }
    class ISO20022.Catp003001.Action7 {
        + ReqToPrfrm  : String
        + MsgToPres  : ISO20022.Catp003001.ActionMessage4
        + ActnTp  : String
    }
    ISO20022.Catp003001.Action7 *-- ISO20022.Catp003001.ActionMessage4
    class ISO20022.Catp003001.ActionMessage4 {
        + MsgCnttSgntr  : String
        + Dvc  : String
        + Ref  : String
        + Msg  : String
        + Frmt  : String
    }
    class ISO20022.Catp003001.ActionMessage5 {
        + MsgCntt  : String
        + Frmt  : String
    }
    class ISO20022.Catp003001.ActionType6Code {
        TRCK = 1
        PINR = 2
        PINL = 3
        RQST = 4
        CPNS = 5
        DISP = 6
        CPTR = 7
        BUSY = 8
        LAMT = 9
        HAMT = 10
        FEES = 11
        DCCQ = 12
    }
    class ISO20022.Catp003001.Algorithm11Code {
        HS01 = 1
        HS51 = 2
        HS38 = 3
        HS25 = 4
    }
    class ISO20022.Catp003001.Algorithm12Code {
        CMA5 = 1
        CMA9 = 2
        MCC1 = 3
        CMA1 = 4
        MCCS = 5
        MACC = 6
    }
    class ISO20022.Catp003001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Catp003001.Algorithm15Code {
        EA5C = 1
        EA9C = 2
        E3DC = 3
        EA2C = 4
    }
    class ISO20022.Catp003001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Catp003001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Catp003001.AlgorithmIdentification11 {
        + Param  : ISO20022.Catp003001.Parameter4
        + Algo  : String
    }
    ISO20022.Catp003001.AlgorithmIdentification11 *-- ISO20022.Catp003001.Parameter4
    class ISO20022.Catp003001.AlgorithmIdentification12 {
        + Param  : ISO20022.Catp003001.Parameter5
        + Algo  : String
    }
    ISO20022.Catp003001.AlgorithmIdentification12 *-- ISO20022.Catp003001.Parameter5
    class ISO20022.Catp003001.AlgorithmIdentification13 {
        + Param  : ISO20022.Catp003001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp003001.AlgorithmIdentification13 *-- ISO20022.Catp003001.Parameter6
    class ISO20022.Catp003001.AlgorithmIdentification14 {
        + Param  : ISO20022.Catp003001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp003001.AlgorithmIdentification14 *-- ISO20022.Catp003001.Parameter6
    class ISO20022.Catp003001.AlgorithmIdentification15 {
        + Param  : ISO20022.Catp003001.Parameter7
        + Algo  : String
    }
    ISO20022.Catp003001.AlgorithmIdentification15 *-- ISO20022.Catp003001.Parameter7
    class ISO20022.Catp003001.AmountAndCurrency1 {
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp003001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Catp003001.AuthenticatedData4 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Catp003001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Catp003001.AlgorithmIdentification15
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp003001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp003001.AuthenticatedData4 *-- ISO20022.Catp003001.EncapsulatedContent3
    ISO20022.Catp003001.AuthenticatedData4 *-- ISO20022.Catp003001.AlgorithmIdentification15
    ISO20022.Catp003001.AuthenticatedData4 *-- ISO20022.Catp003001.Recipient4Choice
    class ISO20022.Catp003001.AuthenticationEntity2Code {
        TRML = 1
        ISSR = 2
        ACQR = 3
        MERC = 4
        AGNT = 5
        ICCD = 6
    }
    class ISO20022.Catp003001.AuthenticationMethod7Code {
        SCNL = 1
        SCRT = 2
        PSWD = 3
        NPIN = 4
        FPIN = 5
        OTHR = 6
        MOBL = 7
        BIOM = 8
        TOKA = 9
    }
    class ISO20022.Catp003001.AuthorisationResult20 {
        + FeeToAdd  : global::System.Collections.Generic.List~ISO20022.Catp003001.ATMFeeComponent1~
        + Actn  : global::System.Collections.Generic.List~ISO20022.Catp003001.Action7~
        + AuthstnCd  : String
        + RspnTrac  : global::System.Collections.Generic.List~ISO20022.Catp003001.ResponseType8~
        + AuthstnRspn  : ISO20022.Catp003001.ResponseType12
        + AuthstnNtty  : String
    }
    ISO20022.Catp003001.AuthorisationResult20 *-- ISO20022.Catp003001.ATMFeeComponent1
    ISO20022.Catp003001.AuthorisationResult20 *-- ISO20022.Catp003001.Action7
    ISO20022.Catp003001.AuthorisationResult20 *-- ISO20022.Catp003001.ResponseType8
    ISO20022.Catp003001.AuthorisationResult20 *-- ISO20022.Catp003001.ResponseType12
    class ISO20022.Catp003001.AutomatedTellerMachine12 {
        + Eqpmnt  : ISO20022.Catp003001.ATMEquipment1
        + Cpblties  : ISO20022.Catp003001.PointOfInteractionCapabilities10
        + LctnCtgy  : String
        + Lctn  : ISO20022.Catp003001.PostalAddress17
        + BaseCcy  : String
        + SeqNb  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Catp003001.AutomatedTellerMachine12 *-- ISO20022.Catp003001.ATMEquipment1
    ISO20022.Catp003001.AutomatedTellerMachine12 *-- ISO20022.Catp003001.PointOfInteractionCapabilities10
    ISO20022.Catp003001.AutomatedTellerMachine12 *-- ISO20022.Catp003001.PostalAddress17
    class ISO20022.Catp003001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Catp003001.CardAccount17 {
        + Svcr  : ISO20022.Catp003001.PartyIdentification177Choice
        + CdtRef  : String
        + AcctIdr  : ISO20022.Catp003001.AccountIdentification80Choice
        + Ccy  : String
        + AcctNm  : String
        + SelctdAcctTp  : String
        + SelctnMtd  : String
    }
    ISO20022.Catp003001.CardAccount17 *-- ISO20022.Catp003001.PartyIdentification177Choice
    ISO20022.Catp003001.CardAccount17 *-- ISO20022.Catp003001.AccountIdentification80Choice
    class ISO20022.Catp003001.CardAccountType3Code {
        FLTC = 1
        PRPD = 2
        UVRL = 3
        STBD = 4
        SVNG = 5
        RVLV = 6
        RTRM = 7
        MTGL = 8
        MNMC = 9
        MNMK = 10
        MBNW = 11
        LCDT = 12
        INVS = 13
        ISTL = 14
        HEQL = 15
        EPRS = 16
        DFLT = 17
        CDBT = 18
        CURR = 19
        CRDT = 20
        CHCK = 21
        CTDP = 22
    }
    class ISO20022.Catp003001.CardDataReading1Code {
        ECTL = 1
        CTLS = 2
        DFLE = 3
        CICC = 4
        MGST = 5
        BRCD = 6
        PHYS = 7
        TAGC = 8
    }
    class ISO20022.Catp003001.CardDataReading4Code {
        CTLS = 1
        MGST = 2
        CICC = 3
        ECTL = 4
    }
    class ISO20022.Catp003001.CardholderVerificationCapability3Code {
        PCOD = 1
        PKIS = 2
        FBIG = 3
        FBIO = 4
        FDSG = 5
        FEPN = 6
        FCPN = 7
        NPIN = 8
    }
    class ISO20022.Catp003001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Catp003001.RelativeDistinguishedName1~
    }
    ISO20022.Catp003001.CertificateIssuer1 *-- ISO20022.Catp003001.RelativeDistinguishedName1
    class ISO20022.Catp003001.Commission18 {
        + AddtlInf  : String
        + Rate  : Decimal
    }
    class ISO20022.Catp003001.Commission19 {
        + AddtlInf  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp003001.ContentInformationType10 {
        + EnvlpdData  : ISO20022.Catp003001.EnvelopedData4
        + CnttTp  : String
    }
    ISO20022.Catp003001.ContentInformationType10 *-- ISO20022.Catp003001.EnvelopedData4
    class ISO20022.Catp003001.ContentInformationType15 {
        + AuthntcdData  : ISO20022.Catp003001.AuthenticatedData4
        + CnttTp  : String
    }
    ISO20022.Catp003001.ContentInformationType15 *-- ISO20022.Catp003001.AuthenticatedData4
    class ISO20022.Catp003001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Catp003001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Catp003001.CurrencyConversion32 {
        + RefRate  : ISO20022.Catp003001.ATMExchangeRateComponent1
        + DclrtnDtls  : ISO20022.Catp003001.ActionMessage5
        + MrkUpDtls  : global::System.Collections.Generic.List~ISO20022.Catp003001.Commission18~
        + ComssnDtls  : global::System.Collections.Generic.List~ISO20022.Catp003001.Commission19~
        + OrgnlAmt  : Decimal
        + SrcCcy  : ISO20022.Catp003001.CurrencyDetails2
        + VldUntil  : DateTime
        + QtnDt  : DateTime
        + NvrtdXchgRate  : Decimal
        + XchgRate  : Decimal
        + RsltgAmt  : Decimal
        + TrgtCcy  : ISO20022.Catp003001.CurrencyDetails2
        + CcyConvsId  : String
    }
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.ATMExchangeRateComponent1
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.ActionMessage5
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.Commission18
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.Commission19
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.CurrencyDetails2
    ISO20022.Catp003001.CurrencyConversion32 *-- ISO20022.Catp003001.CurrencyDetails2
    class ISO20022.Catp003001.CurrencyDetails2 {
        + Nm  : String
        + Dcml  : Decimal
        + NmrcCd  : String
        + AlphaCd  : String
    }
    class ISO20022.Catp003001.DataSetCategory7Code {
        MNOC = 1
        LOCC = 2
        AMNT = 3
        OEXR = 4
        CPRC = 5
        CRAP = 6
        APPR = 7
        ATMP = 8
        ATMC = 9
    }
    class ISO20022.Catp003001.DetailedAmount12 {
        + Dontn  : global::System.Collections.Generic.List~ISO20022.Catp003001.DetailedAmount13~
        + Fees  : global::System.Collections.Generic.List~ISO20022.Catp003001.DetailedAmount13~
        + Ccy  : String
        + AmtToDspns  : Decimal
    }
    ISO20022.Catp003001.DetailedAmount12 *-- ISO20022.Catp003001.DetailedAmount13
    ISO20022.Catp003001.DetailedAmount12 *-- ISO20022.Catp003001.DetailedAmount13
    class ISO20022.Catp003001.DetailedAmount13 {
        + Labl  : String
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp003001.DisplayCapabilities5 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Catp003001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Catp003001.EncryptedContent3 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Catp003001.AlgorithmIdentification14
        + CnttTp  : String
    }
    ISO20022.Catp003001.EncryptedContent3 *-- ISO20022.Catp003001.AlgorithmIdentification14
    class ISO20022.Catp003001.EncryptionFormat1Code {
        TR34 = 1
        TR31 = 2
    }
    class ISO20022.Catp003001.EnvelopedData4 {
        + NcrptdCntt  : ISO20022.Catp003001.EncryptedContent3
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp003001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp003001.EnvelopedData4 *-- ISO20022.Catp003001.EncryptedContent3
    ISO20022.Catp003001.EnvelopedData4 *-- ISO20022.Catp003001.Recipient4Choice
    class ISO20022.Catp003001.FailureReason9Code {
        RSTR = 1
        DCRT = 2
        CQRT = 3
        QFGC = 4
        CFGC = 5
        DFGC = 6
        CQFG = 7
        DCFG = 8
        CHFG = 9
        VLTE = 10
        FMTE = 11
        RJCT = 12
        CUTO = 13
        CDRT = 14
        CSRV = 15
        USND = 16
        UCMP = 17
        UCPT = 18
        LATE = 19
        TIMO = 20
        SFRD = 21
        SECU = 22
        NDCL = 23
        MALF = 24
        FILL = 25
        CDFG = 26
        CUDC = 27
        CUCL = 28
        CDER = 29
        CDCL = 30
        CDCP = 31
    }
    class ISO20022.Catp003001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Catp003001.GenericIdentification77 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catp003001.GeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Catp003001.GeographicLocation1Choice {
        + UTMCordints  : ISO20022.Catp003001.UTMCoordinates1
        + GeogcCordints  : ISO20022.Catp003001.GeographicCoordinates1
    }
    ISO20022.Catp003001.GeographicLocation1Choice *-- ISO20022.Catp003001.UTMCoordinates1
    ISO20022.Catp003001.GeographicLocation1Choice *-- ISO20022.Catp003001.GeographicCoordinates1
    class ISO20022.Catp003001.Header32 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Catp003001.Traceability4~
        + PrcStat  : String
        + RcptPty  : String
        + InitgPty  : String
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : Decimal
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : ISO20022.Catp003001.ATMMessageFunction2
    }
    ISO20022.Catp003001.Header32 *-- ISO20022.Catp003001.Traceability4
    ISO20022.Catp003001.Header32 *-- ISO20022.Catp003001.ATMMessageFunction2
    class ISO20022.Catp003001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Catp003001.CertificateIssuer1
    }
    ISO20022.Catp003001.IssuerAndSerialNumber1 *-- ISO20022.Catp003001.CertificateIssuer1
    class ISO20022.Catp003001.KEK4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp003001.AlgorithmIdentification13
        + KEKId  : ISO20022.Catp003001.KEKIdentifier2
        + Vrsn  : Decimal
    }
    ISO20022.Catp003001.KEK4 *-- ISO20022.Catp003001.AlgorithmIdentification13
    ISO20022.Catp003001.KEK4 *-- ISO20022.Catp003001.KEKIdentifier2
    class ISO20022.Catp003001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catp003001.KeyTransport4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp003001.AlgorithmIdentification11
        + RcptId  : ISO20022.Catp003001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catp003001.KeyTransport4 *-- ISO20022.Catp003001.AlgorithmIdentification11
    ISO20022.Catp003001.KeyTransport4 *-- ISO20022.Catp003001.Recipient5Choice
    class ISO20022.Catp003001.MessageFunction11Code {
        RPTC = 1
        TRFP = 2
        TRFQ = 3
        EXPV = 4
        EXPK = 5
        DPSP = 6
        DPSQ = 7
        DPSV = 8
        DPSK = 9
        SSTS = 10
        SKSC = 11
        DSEC = 12
        CSEC = 13
        TMOP = 14
        H2AQ = 15
        H2AP = 16
        INQC = 17
        WITP = 18
        WITQ = 19
        WITK = 20
        WITV = 21
        RJAP = 22
        RJAQ = 23
        PINP = 24
        PINQ = 25
        KYAP = 26
        KYAQ = 27
        INQP = 28
        INQQ = 29
        GSTS = 30
        DIAP = 31
        DIAQ = 32
        DVCC = 33
        ACMD = 34
        CMPD = 35
        CMPA = 36
        BALN = 37
    }
    class ISO20022.Catp003001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Catp003001.OutputFormat2Code {
        HTML = 1
        TEXT = 2
        SREF = 3
        MREF = 4
    }
    class ISO20022.Catp003001.Parameter4 {
        + MskGnrtrAlgo  : ISO20022.Catp003001.AlgorithmIdentification12
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Catp003001.Parameter4 *-- ISO20022.Catp003001.AlgorithmIdentification12
    class ISO20022.Catp003001.Parameter5 {
        + DgstAlgo  : String
    }
    class ISO20022.Catp003001.Parameter6 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Catp003001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Catp003001.PartyIdentification177Choice {
        + PrtryId  : ISO20022.Catp003001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Catp003001.PartyIdentification177Choice *-- ISO20022.Catp003001.GenericIdentification1
    class ISO20022.Catp003001.PartyType12Code {
        OATM = 1
        ITAG = 2
        HSTG = 3
        DLIS = 4
        CISP = 5
        ATMG = 6
        ACQR = 7
    }
    class ISO20022.Catp003001.PartyType16Code {
        ATMG = 1
        BKAT = 2
        BKAF = 3
        OTRM = 4
        ITAG = 5
        DLIS = 6
        CISS = 7
        ACQR = 8
    }
    class ISO20022.Catp003001.PaymentCard37 {
        + ElctrncPrsBal  : ISO20022.Catp003001.CurrencyAndAmount
        + CardCcyCd  : String
        + CardCtryCd  : String
        + PlainCardData  : ISO20022.Catp003001.PlainCardData24
        + PrtctdCardData  : ISO20022.Catp003001.ContentInformationType10
        + FllbckInd  : String
        + CardDataNtryMd  : String
    }
    ISO20022.Catp003001.PaymentCard37 *-- ISO20022.Catp003001.CurrencyAndAmount
    ISO20022.Catp003001.PaymentCard37 *-- ISO20022.Catp003001.PlainCardData24
    ISO20022.Catp003001.PaymentCard37 *-- ISO20022.Catp003001.ContentInformationType10
    class ISO20022.Catp003001.PlainCardData24 {
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    class ISO20022.Catp003001.PointOfInteractionCapabilities10 {
        + RctPrtg  : String
        + IntractvTxs  : global::System.Collections.Generic.List~String~
        + MsgCpblties  : global::System.Collections.Generic.List~ISO20022.Catp003001.DisplayCapabilities5~
        + DpstdMdia  : global::System.Collections.Generic.List~String~
        + WdrwlMdia  : global::System.Collections.Generic.List~String~
        + CardCaptrCpbl  : String
        + MxScrptLngth  : Decimal
        + ApprvlCdLngth  : Decimal
        + PINLngthCpblties  : Decimal
        + Authntcn  : global::System.Collections.Generic.List~String~
        + CardWrtData  : global::System.Collections.Generic.List~String~
        + CardRdData  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catp003001.PointOfInteractionCapabilities10 *-- ISO20022.Catp003001.DisplayCapabilities5
    class ISO20022.Catp003001.PostalAddress17 {
        + GLctn  : ISO20022.Catp003001.GeographicLocation1Choice
        + Ctry  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catp003001.PostalAddress17 *-- ISO20022.Catp003001.GeographicLocation1Choice
    class ISO20022.Catp003001.Recipient4Choice {
        + KeyIdr  : ISO20022.Catp003001.KEKIdentifier2
        + KEK  : ISO20022.Catp003001.KEK4
        + KeyTrnsprt  : ISO20022.Catp003001.KeyTransport4
    }
    ISO20022.Catp003001.Recipient4Choice *-- ISO20022.Catp003001.KEKIdentifier2
    ISO20022.Catp003001.Recipient4Choice *-- ISO20022.Catp003001.KEK4
    ISO20022.Catp003001.Recipient4Choice *-- ISO20022.Catp003001.KeyTransport4
    class ISO20022.Catp003001.Recipient5Choice {
        + KeyIdr  : ISO20022.Catp003001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Catp003001.IssuerAndSerialNumber1
    }
    ISO20022.Catp003001.Recipient5Choice *-- ISO20022.Catp003001.KEKIdentifier2
    ISO20022.Catp003001.Recipient5Choice *-- ISO20022.Catp003001.IssuerAndSerialNumber1
    class ISO20022.Catp003001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catp003001.Response12Code {
        ASUP = 1
        PART = 2
        DECL = 3
        APPR = 4
    }
    class ISO20022.Catp003001.ResponseType12 {
        + AddtlRspnInf  : String
        + RspnRsn  : String
        + Rspn  : String
    }
    class ISO20022.Catp003001.ResponseType8 {
        + AddtlRspnInf  : String
        + RspnRsn  : String
        + Rspn  : String
        + Cdfctn  : String
        + RspndrId  : String
    }
    class ISO20022.Catp003001.ResultDetail5Code {
        FEEM = 1
        ADCC = 2
        SACT = 3
        AGFE = 4
        AMMA = 5
        SRVI = 6
        MEDI = 7
        CRDW = 8
        NMBW = 9
        AMTW = 10
        VNDF = 11
        VNDR = 12
        SVSU = 13
        CRDU = 14
        CMKY = 15
        UNBC = 16
        UNBP = 17
        UNBO = 18
        ORGF = 19
        TXND = 20
        TXNU = 21
        TTLV = 22
        ACTT = 23
        TRMI = 24
        SYSM = 25
        SYSP = 26
        FRDS = 27
        CNTC = 28
        SRCH = 29
        CRDS = 30
        SPCC = 31
        SFWE = 32
        SRVU = 33
        SECV = 34
        CRDT = 35
        RECD = 36
        QMAX = 37
        PINE = 38
        PINX = 39
        PINS = 40
        PIND = 41
        PINC = 42
        SEQO = 43
        BALO = 44
        OTHR = 45
        TXNM = 46
        NPRC = 47
        ONLP = 48
        OFFL = 49
        NPRA = 50
        PINA = 51
        LBLU = 52
        CRDA = 53
        PINN = 54
        ICCM = 55
        MACK = 56
        MACR = 57
        CRDL = 58
        LBLA = 59
        KEYS = 60
        ISSU = 61
        ISST = 62
        ISSO = 63
        ISSF = 64
        ISSP = 65
        DATI = 66
        TXNV = 67
        TKID = 68
        SGNI = 69
        TKKO = 70
        PINV = 71
        AMTO = 72
        CTFV = 73
        CRDI = 74
        CHDI = 75
        BRHI = 76
        ADDI = 77
        AMTI = 78
        ACPI = 79
        FNDI = 80
        TXNG = 81
        FMTR = 82
        FDCL = 83
        CRDX = 84
        NMBD = 85
        AMTD = 86
        TXNL = 87
        FEES = 88
        DBER = 89
        CTVG = 90
        ACTC = 91
        CRDF = 92
        CRDR = 93
        BANK = 94
        AUTH = 95
        AMTA = 96
        AMLV = 97
        ACQS = 98
        ACTF = 99
    }
    class ISO20022.Catp003001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Catp003001.TerminalHosting1 {
        + Id  : String
        + Ctgy  : String
    }
    class ISO20022.Catp003001.Traceability4 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + SeqNb  : String
        + RlayId  : ISO20022.Catp003001.GenericIdentification77
    }
    ISO20022.Catp003001.Traceability4 *-- ISO20022.Catp003001.GenericIdentification77
    class ISO20022.Catp003001.TransactionEnvironment2Code {
        PUBL = 1
        PRIV = 2
    }
    class ISO20022.Catp003001.TransactionEnvironment3Code {
        OTHR = 1
        MERC = 2
        BRCH = 3
    }
    class ISO20022.Catp003001.TransactionIdentifier3 {
        + TxRef  : String
        + HstTxDtTm  : DateTime
        + TxDtTm  : DateTime
    }
    class ISO20022.Catp003001.TransactionVerificationResult5 {
        + AuthntcnTkn  : String
        + AddtlRslt  : String
        + Rslt  : String
        + VrfctnNtty  : String
        + Mtd  : String
    }
    class ISO20022.Catp003001.UTMCoordinates1 {
        + UTMNrthwrd  : Decimal
        + UTMEstwrd  : Decimal
        + UTMZone  : String
    }
    class ISO20022.Catp003001.UserInterface5Code {
        CRDO = 1
        CRCP = 2
        CDSP = 3
    }
    class ISO20022.Catp003001.Verification1Code {
        ERRR = 1
        SUCC = 2
        PART = 3
        NOVF = 4
        MISS = 5
        FAIL = 6
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

## Value ISO20022.Catp003001.ATMCassette3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CssttSts|String||XmlElement()||
|+|MdiaCntrs|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMCassetteCounters6>||XmlElement()||
|+|MdiaTp|String||XmlElement()||
|+|SubTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|LogclId|String||XmlElement()||
|+|PhysId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MdiaCntrs""",MdiaCntrs),validElement(MdiaCntrs))|

---

## Value ISO20022.Catp003001.ATMCassetteCounters5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InitlAmt|Decimal||XmlElement()||
|+|InitlNb|Decimal||XmlElement()||
|+|PresntdNb|Decimal||XmlElement()||
|+|RjctdNb|Decimal||XmlElement()||
|+|RtrctdAmt|Decimal||XmlElement()||
|+|RtrctdNb|Decimal||XmlElement()||
|+|RcycldNb|Decimal||XmlElement()||
|+|DpstdAmt|Decimal||XmlElement()||
|+|DpstdNb|Decimal||XmlElement()||
|+|DspnsdNb|Decimal||XmlElement()||
|+|RmvdAmt|Decimal||XmlElement()||
|+|RmvdNb|Decimal||XmlElement()||
|+|AddedNb|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ATMCassetteCounters6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FlowTtls|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMCassetteCounters5>||XmlElement()||
|+|CurAmt|Decimal||XmlElement()||
|+|CurNb|Decimal||XmlElement()||
|+|InitlCnt|Decimal||XmlElement()||
|+|MdiaCtgy|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|UnitVal|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FlowTtls""",FlowTtls),validElement(FlowTtls),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.ATMCassetteStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CUMP|Int32||XmlEnum("""CUMP""")|1|
||CUNR|Int32||XmlEnum("""CUNR""")|2|
||CUNA|Int32||XmlEnum("""CUNA""")|3|
||CUMS|Int32||XmlEnum("""CUMS""")|4|
||CUNP|Int32||XmlEnum("""CUNP""")|5|
||CUMT|Int32||XmlEnum("""CUMT""")|6|
||CULW|Int32||XmlEnum("""CULW""")|7|
||CUHG|Int32||XmlEnum("""CUHG""")|8|
||CUFL|Int32||XmlEnum("""CUFL""")|9|
||CUOK|Int32||XmlEnum("""CUOK""")|10|

---

## Enum ISO20022.Catp003001.ATMCassetteType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RTRC|Int32||XmlEnum("""RTRC""")|1|
||RPLT|Int32||XmlEnum("""RPLT""")|2|
||RJCT|Int32||XmlEnum("""RJCT""")|3|
||RCYC|Int32||XmlEnum("""RCYC""")|4|
||DISP|Int32||XmlEnum("""DISP""")|5|
||DPST|Int32||XmlEnum("""DPST""")|6|

---

## Value ISO20022.Catp003001.ATMConfigurationParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ATMContext9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svc|ISO20022.Catp003001.ATMService10||XmlElement()||
|+|SsnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svc))|

---

## Enum ISO20022.Catp003001.ATMCounterType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLRP|Int32||XmlEnum("""SLRP""")|1|
||OPER|Int32||XmlEnum("""OPER""")|2|
||PRTN|Int32||XmlEnum("""PRTN""")|3|
||BDAY|Int32||XmlEnum("""BDAY""")|4|
||CTOF|Int32||XmlEnum("""CTOF""")|5|
||CTXN|Int32||XmlEnum("""CTXN""")|6|
||INQU|Int32||XmlEnum("""INQU""")|7|

---

## Value ISO20022.Catp003001.ATMCustomer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnRslt|global::System.Collections.Generic.List<ISO20022.Catp003001.TransactionVerificationResult5>||XmlElement()||
|+|SelctdLang|String||XmlElement()||
|+|Prfl|ISO20022.Catp003001.ATMCustomerProfile6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AuthntcnRslt""",AuthntcnRslt),validList("""AuthntcnRslt""",AuthntcnRslt),validElement(AuthntcnRslt),validElement(Prfl))|

---

## Enum ISO20022.Catp003001.ATMCustomerProfile1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREQ|Int32||XmlEnum("""PREQ""")|1|
||OREQ|Int32||XmlEnum("""OREQ""")|2|
||CRDF|Int32||XmlEnum("""CRDF""")|3|

---

## Value ISO20022.Catp003001.ATMCustomerProfile6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdLang|String||XmlElement()||
|+|CstmrId|String||XmlElement()||
|+|PrflRef|String||XmlElement()||
|+|RtrvlMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.ATMDevice1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RWDR|Int32||XmlEnum("""RWDR""")|1|
||RPRN|Int32||XmlEnum("""RPRN""")|2|
||JPRN|Int32||XmlEnum("""JPRN""")|3|
||JRNL|Int32||XmlEnum("""JRNL""")|4|
||DPRN|Int32||XmlEnum("""DPRN""")|5|
||CDIS|Int32||XmlEnum("""CDIS""")|6|

---

## Value ISO20022.Catp003001.ATMEnvironment19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Card|ISO20022.Catp003001.PaymentCard37||XmlElement()||
|+|Cstmr|ISO20022.Catp003001.ATMCustomer7||XmlElement()||
|+|ATM|ISO20022.Catp003001.AutomatedTellerMachine12||XmlElement()||
|+|HstgNtty|ISO20022.Catp003001.TerminalHosting1||XmlElement()||
|+|ATMMgrId|String||XmlElement()||
|+|Acqrr|ISO20022.Catp003001.Acquirer7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Card),validElement(Cstmr),validElement(ATM),validElement(HstgNtty),validElement(Acqrr))|

---

## Value ISO20022.Catp003001.ATMEquipment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CfgtnParam|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMConfigurationParameter1>||XmlElement()||
|+|ApprvlNb|String||XmlElement()||
|+|ApplVrsn|String||XmlElement()||
|+|ApplNm|String||XmlElement()||
|+|ApplPrvdr|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CfgtnParam""",CfgtnParam),validElement(CfgtnParam))|

---

## Value ISO20022.Catp003001.ATMExchangeRateComponent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|PblshDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ATMFeeComponent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FeeLabl|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.ATMMediaType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UDTM|Int32||XmlEnum("""UDTM""")|1|
||STMP|Int32||XmlEnum("""STMP""")|2|
||NOTE|Int32||XmlEnum("""NOTE""")|3|
||CPNS|Int32||XmlEnum("""CPNS""")|4|
||CMDT|Int32||XmlEnum("""CMDT""")|5|
||COIN|Int32||XmlEnum("""COIN""")|6|
||CARD|Int32||XmlEnum("""CARD""")|7|

---

## Enum ISO20022.Catp003001.ATMMediaType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNRG|Int32||XmlEnum("""UNRG""")|1|
||UNFT|Int32||XmlEnum("""UNFT""")|2|
||SPCT|Int32||XmlEnum("""SPCT""")|3|
||FITU|Int32||XmlEnum("""FITU""")|4|
||FITN|Int32||XmlEnum("""FITN""")|5|
||CNTR|Int32||XmlEnum("""CNTR""")|6|

---

## Enum ISO20022.Catp003001.ATMMediaType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MLTP|Int32||XmlEnum("""MLTP""")|1|
||ENVP|Int32||XmlEnum("""ENVP""")|2|
||CHCK|Int32||XmlEnum("""CHCK""")|3|
||UDTM|Int32||XmlEnum("""UDTM""")|4|
||STMP|Int32||XmlEnum("""STMP""")|5|
||NOTE|Int32||XmlEnum("""NOTE""")|6|
||CPNS|Int32||XmlEnum("""CPNS""")|7|
||CMDT|Int32||XmlEnum("""CMDT""")|8|
||COIN|Int32||XmlEnum("""COIN""")|9|
||CARD|Int32||XmlEnum("""CARD""")|10|

---

## Value ISO20022.Catp003001.ATMMessageFunction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|Fctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.ATMNoteType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNFT|Int32||XmlEnum("""UNFT""")|1|
||SCNT|Int32||XmlEnum("""SCNT""")|2|
||IDVD|Int32||XmlEnum("""IDVD""")|3|
||CNTR|Int32||XmlEnum("""CNTR""")|4|
||ALLT|Int32||XmlEnum("""ALLT""")|5|

---

## Value ISO20022.Catp003001.ATMService10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcVarntId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvcTp|String||XmlElement()||
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|SvcRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.ATMServiceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPRV|Int32||XmlEnum("""SPRV""")|1|
||STDR|Int32||XmlEnum("""STDR""")|2|
||PRFL|Int32||XmlEnum("""PRFL""")|3|
||PATH|Int32||XmlEnum("""PATH""")|4|
||CHSN|Int32||XmlEnum("""CHSN""")|5|

---

## Value ISO20022.Catp003001.ATMTotals4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMCurNb|Decimal||XmlElement()||
|+|ATMBalNb|Decimal||XmlElement()||
|+|ATMCur|Decimal||XmlElement()||
|+|ATMBal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|MdiaTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp003001.ATMTransaction53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Csstt|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMCassette3>||XmlElement()||
|+|ATMTtls|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMTotals4>||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|AuthstnRslt|ISO20022.Catp003001.AuthorisationResult20||XmlElement()||
|+|Lmts|ISO20022.Catp003001.ATMTransactionAmounts6||XmlElement()||
|+|CstmrCnsnt|String||XmlElement()||
|+|RctPrtd|String||XmlElement()||
|+|ReqdRct|String||XmlElement()||
|+|AddtlChrg|global::System.Collections.Generic.List<ISO20022.Catp003001.DetailedAmount13>||XmlElement()||
|+|CcyConvsRslt|ISO20022.Catp003001.CurrencyConversion32||XmlElement()||
|+|DtldReqdAmt|ISO20022.Catp003001.DetailedAmount12||XmlElement()||
|+|TtlReqdAmt|Decimal||XmlElement()||
|+|TtlAuthrsdAmt|Decimal||XmlElement()||
|+|TtlPresntdAmt|ISO20022.Catp003001.AmountAndCurrency1||XmlElement()||
|+|PrtctdAcctData|ISO20022.Catp003001.ContentInformationType10||XmlElement()||
|+|AcctData|ISO20022.Catp003001.CardAccount17||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|IncdntDtl|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Incdnt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PresntdAmtSts|String||XmlElement()||
|+|BndlPresntdAmt|global::System.Collections.Generic.List<Decimal>||XmlElement()||
|+|MultiBndl|String||XmlElement()||
|+|TxSts|String||XmlElement()||
|+|TxId|ISO20022.Catp003001.TransactionIdentifier3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Csstt""",Csstt),validElement(Csstt),validList("""ATMTtls""",ATMTtls),validElement(ATMTtls),validElement(AuthstnRslt),validElement(Lmts),validList("""AddtlChrg""",AddtlChrg),validElement(AddtlChrg),validElement(CcyConvsRslt),validElement(DtldReqdAmt),validElement(TtlPresntdAmt),validElement(PrtctdAcctData),validElement(AcctData),validElement(TxId))|

---

## Value ISO20022.Catp003001.ATMTransactionAmounts6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlAmt|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMTransactionAmounts7>||XmlElement()||
|+|MinPssblAmt|Decimal||XmlElement()||
|+|MaxPssblAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp003001.ATMTransactionAmounts7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.ATMTransactionStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCSS|Int32||XmlEnum("""SCSS""")|1|
||FAIL|Int32||XmlEnum("""FAIL""")|2|
||DOBT|Int32||XmlEnum("""DOBT""")|3|

---

## Enum ISO20022.Catp003001.ATMTransactionStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONE|Int32||XmlEnum("""NONE""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Catp003001.ATMTransaction53||XmlElement()||
|+|Cntxt|ISO20022.Catp003001.ATMContext9||XmlElement()||
|+|Envt|ISO20022.Catp003001.ATMEnvironment19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt))|

---

## Aspect ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Catp003001.ContentInformationType15||XmlElement()||
|+|ATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3||XmlElement()||
|+|PrtctdATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp003001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMWdrwlCmpltnAdvc),validElement(PrtctdATMWdrwlCmpltnAdvc),validElement(Hdr))|

---

## Enum ISO20022.Catp003001.AccountChoiceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPSL|Int32||XmlEnum("""TPSL""")|1|
||NOSL|Int32||XmlEnum("""NOSL""")|2|
||IMPL|Int32||XmlEnum("""IMPL""")|3|
||IMAC|Int32||XmlEnum("""IMAC""")|4|
||ENTR|Int32||XmlEnum("""ENTR""")|5|
||ACSL|Int32||XmlEnum("""ACSL""")|6|

---

## Value ISO20022.Catp003001.AccountIdentification80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Email|String||XmlElement()||
|+|MSISDN|String||XmlElement()||
|+|DmstAcct|ISO20022.Catp003001.SimpleIdentificationInformation4||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DmstAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Email,MSISDN,DmstAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Catp003001.Acquirer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brnch|String||XmlElement()||
|+|AcqrgInstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.Action7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqToPrfrm|String||XmlElement()||
|+|MsgToPres|ISO20022.Catp003001.ActionMessage4||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgToPres))|

---

## Value ISO20022.Catp003001.ActionMessage4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgCnttSgntr|String||XmlElement()||
|+|Dvc|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Msg|String||XmlElement()||
|+|Frmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ActionMessage5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgCntt|String||XmlElement()||
|+|Frmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.ActionType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRCK|Int32||XmlEnum("""TRCK""")|1|
||PINR|Int32||XmlEnum("""PINR""")|2|
||PINL|Int32||XmlEnum("""PINL""")|3|
||RQST|Int32||XmlEnum("""RQST""")|4|
||CPNS|Int32||XmlEnum("""CPNS""")|5|
||DISP|Int32||XmlEnum("""DISP""")|6|
||CPTR|Int32||XmlEnum("""CPTR""")|7|
||BUSY|Int32||XmlEnum("""BUSY""")|8|
||LAMT|Int32||XmlEnum("""LAMT""")|9|
||HAMT|Int32||XmlEnum("""HAMT""")|10|
||FEES|Int32||XmlEnum("""FEES""")|11|
||DCCQ|Int32||XmlEnum("""DCCQ""")|12|

---

## Enum ISO20022.Catp003001.Algorithm11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS01|Int32||XmlEnum("""HS01""")|1|
||HS51|Int32||XmlEnum("""HS51""")|2|
||HS38|Int32||XmlEnum("""HS38""")|3|
||HS25|Int32||XmlEnum("""HS25""")|4|

---

## Enum ISO20022.Catp003001.Algorithm12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMA5|Int32||XmlEnum("""CMA5""")|1|
||CMA9|Int32||XmlEnum("""CMA9""")|2|
||MCC1|Int32||XmlEnum("""MCC1""")|3|
||CMA1|Int32||XmlEnum("""CMA1""")|4|
||MCCS|Int32||XmlEnum("""MCCS""")|5|
||MACC|Int32||XmlEnum("""MACC""")|6|

---

## Enum ISO20022.Catp003001.Algorithm13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||UKA1|Int32||XmlEnum("""UKA1""")|3|
||UKPT|Int32||XmlEnum("""UKPT""")|4|
||DKP9|Int32||XmlEnum("""DKP9""")|5|
||E3DC|Int32||XmlEnum("""E3DC""")|6|
||EA2C|Int32||XmlEnum("""EA2C""")|7|

---

## Enum ISO20022.Catp003001.Algorithm15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||E3DC|Int32||XmlEnum("""E3DC""")|3|
||EA2C|Int32||XmlEnum("""EA2C""")|4|

---

## Enum ISO20022.Catp003001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Catp003001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Catp003001.AlgorithmIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp003001.Parameter4||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp003001.AlgorithmIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp003001.Parameter5||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp003001.AlgorithmIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp003001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp003001.AlgorithmIdentification14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp003001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp003001.AlgorithmIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp003001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp003001.AmountAndCurrency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Catp003001.AuthenticatedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catp003001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Catp003001.AlgorithmIdentification15||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp003001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Catp003001.AuthenticationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRML|Int32||XmlEnum("""TRML""")|1|
||ISSR|Int32||XmlEnum("""ISSR""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Enum ISO20022.Catp003001.AuthenticationMethod7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCNL|Int32||XmlEnum("""SCNL""")|1|
||SCRT|Int32||XmlEnum("""SCRT""")|2|
||PSWD|Int32||XmlEnum("""PSWD""")|3|
||NPIN|Int32||XmlEnum("""NPIN""")|4|
||FPIN|Int32||XmlEnum("""FPIN""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||MOBL|Int32||XmlEnum("""MOBL""")|7|
||BIOM|Int32||XmlEnum("""BIOM""")|8|
||TOKA|Int32||XmlEnum("""TOKA""")|9|

---

## Value ISO20022.Catp003001.AuthorisationResult20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FeeToAdd|global::System.Collections.Generic.List<ISO20022.Catp003001.ATMFeeComponent1>||XmlElement()||
|+|Actn|global::System.Collections.Generic.List<ISO20022.Catp003001.Action7>||XmlElement()||
|+|AuthstnCd|String||XmlElement()||
|+|RspnTrac|global::System.Collections.Generic.List<ISO20022.Catp003001.ResponseType8>||XmlElement()||
|+|AuthstnRspn|ISO20022.Catp003001.ResponseType12||XmlElement()||
|+|AuthstnNtty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FeeToAdd""",FeeToAdd),validElement(FeeToAdd),validList("""Actn""",Actn),validElement(Actn),validList("""RspnTrac""",RspnTrac),validElement(RspnTrac),validElement(AuthstnRspn))|

---

## Value ISO20022.Catp003001.AutomatedTellerMachine12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Eqpmnt|ISO20022.Catp003001.ATMEquipment1||XmlElement()||
|+|Cpblties|ISO20022.Catp003001.PointOfInteractionCapabilities10||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|Lctn|ISO20022.Catp003001.PostalAddress17||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Eqpmnt),validElement(Cpblties),validElement(Lctn),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Catp003001.CardAccount17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Catp003001.PartyIdentification177Choice||XmlElement()||
|+|CdtRef|String||XmlElement()||
|+|AcctIdr|ISO20022.Catp003001.AccountIdentification80Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|SelctdAcctTp|String||XmlElement()||
|+|SelctnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(AcctIdr),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.CardAccountType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLTC|Int32||XmlEnum("""FLTC""")|1|
||PRPD|Int32||XmlEnum("""PRPD""")|2|
||UVRL|Int32||XmlEnum("""UVRL""")|3|
||STBD|Int32||XmlEnum("""STBD""")|4|
||SVNG|Int32||XmlEnum("""SVNG""")|5|
||RVLV|Int32||XmlEnum("""RVLV""")|6|
||RTRM|Int32||XmlEnum("""RTRM""")|7|
||MTGL|Int32||XmlEnum("""MTGL""")|8|
||MNMC|Int32||XmlEnum("""MNMC""")|9|
||MNMK|Int32||XmlEnum("""MNMK""")|10|
||MBNW|Int32||XmlEnum("""MBNW""")|11|
||LCDT|Int32||XmlEnum("""LCDT""")|12|
||INVS|Int32||XmlEnum("""INVS""")|13|
||ISTL|Int32||XmlEnum("""ISTL""")|14|
||HEQL|Int32||XmlEnum("""HEQL""")|15|
||EPRS|Int32||XmlEnum("""EPRS""")|16|
||DFLT|Int32||XmlEnum("""DFLT""")|17|
||CDBT|Int32||XmlEnum("""CDBT""")|18|
||CURR|Int32||XmlEnum("""CURR""")|19|
||CRDT|Int32||XmlEnum("""CRDT""")|20|
||CHCK|Int32||XmlEnum("""CHCK""")|21|
||CTDP|Int32||XmlEnum("""CTDP""")|22|

---

## Enum ISO20022.Catp003001.CardDataReading1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ECTL|Int32||XmlEnum("""ECTL""")|1|
||CTLS|Int32||XmlEnum("""CTLS""")|2|
||DFLE|Int32||XmlEnum("""DFLE""")|3|
||CICC|Int32||XmlEnum("""CICC""")|4|
||MGST|Int32||XmlEnum("""MGST""")|5|
||BRCD|Int32||XmlEnum("""BRCD""")|6|
||PHYS|Int32||XmlEnum("""PHYS""")|7|
||TAGC|Int32||XmlEnum("""TAGC""")|8|

---

## Enum ISO20022.Catp003001.CardDataReading4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CTLS|Int32||XmlEnum("""CTLS""")|1|
||MGST|Int32||XmlEnum("""MGST""")|2|
||CICC|Int32||XmlEnum("""CICC""")|3|
||ECTL|Int32||XmlEnum("""ECTL""")|4|

---

## Enum ISO20022.Catp003001.CardholderVerificationCapability3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PCOD|Int32||XmlEnum("""PCOD""")|1|
||PKIS|Int32||XmlEnum("""PKIS""")|2|
||FBIG|Int32||XmlEnum("""FBIG""")|3|
||FBIO|Int32||XmlEnum("""FBIO""")|4|
||FDSG|Int32||XmlEnum("""FDSG""")|5|
||FEPN|Int32||XmlEnum("""FEPN""")|6|
||FCPN|Int32||XmlEnum("""FCPN""")|7|
||NPIN|Int32||XmlEnum("""NPIN""")|8|

---

## Value ISO20022.Catp003001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Catp003001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Catp003001.Commission18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.Commission19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ContentInformationType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Catp003001.EnvelopedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Value ISO20022.Catp003001.ContentInformationType15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcdData|ISO20022.Catp003001.AuthenticatedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcdData))|

---

## Enum ISO20022.Catp003001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Catp003001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp003001.CurrencyConversion32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefRate|ISO20022.Catp003001.ATMExchangeRateComponent1||XmlElement()||
|+|DclrtnDtls|ISO20022.Catp003001.ActionMessage5||XmlElement()||
|+|MrkUpDtls|global::System.Collections.Generic.List<ISO20022.Catp003001.Commission18>||XmlElement()||
|+|ComssnDtls|global::System.Collections.Generic.List<ISO20022.Catp003001.Commission19>||XmlElement()||
|+|OrgnlAmt|Decimal||XmlElement()||
|+|SrcCcy|ISO20022.Catp003001.CurrencyDetails2||XmlElement()||
|+|VldUntil|DateTime||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|NvrtdXchgRate|Decimal||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|RsltgAmt|Decimal||XmlElement()||
|+|TrgtCcy|ISO20022.Catp003001.CurrencyDetails2||XmlElement()||
|+|CcyConvsId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefRate),validElement(DclrtnDtls),validList("""MrkUpDtls""",MrkUpDtls),validElement(MrkUpDtls),validList("""ComssnDtls""",ComssnDtls),validElement(ComssnDtls),validElement(SrcCcy),validElement(TrgtCcy))|

---

## Value ISO20022.Catp003001.CurrencyDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|NmrcCd|String||XmlElement()||
|+|AlphaCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NmrcCd""",NmrcCd,"""[0-9]{3}"""),validPattern("""AlphaCd""",AlphaCd,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp003001.DataSetCategory7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MNOC|Int32||XmlEnum("""MNOC""")|1|
||LOCC|Int32||XmlEnum("""LOCC""")|2|
||AMNT|Int32||XmlEnum("""AMNT""")|3|
||OEXR|Int32||XmlEnum("""OEXR""")|4|
||CPRC|Int32||XmlEnum("""CPRC""")|5|
||CRAP|Int32||XmlEnum("""CRAP""")|6|
||APPR|Int32||XmlEnum("""APPR""")|7|
||ATMP|Int32||XmlEnum("""ATMP""")|8|
||ATMC|Int32||XmlEnum("""ATMC""")|9|

---

## Value ISO20022.Catp003001.DetailedAmount12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dontn|global::System.Collections.Generic.List<ISO20022.Catp003001.DetailedAmount13>||XmlElement()||
|+|Fees|global::System.Collections.Generic.List<ISO20022.Catp003001.DetailedAmount13>||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|AmtToDspns|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dontn""",Dontn),validElement(Dontn),validList("""Fees""",Fees),validElement(Fees),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp003001.DetailedAmount13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp003001.DisplayCapabilities5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Dstn""",Dstn))|

---

## Type ISO20022.Catp003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMWdrwlCmpltnAdvc))|

---

## Value ISO20022.Catp003001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.EncryptedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Catp003001.AlgorithmIdentification14||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Catp003001.EncryptionFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||TR31|Int32||XmlEnum("""TR31""")|2|

---

## Value ISO20022.Catp003001.EnvelopedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Catp003001.EncryptedContent3||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp003001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Catp003001.FailureReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||DCRT|Int32||XmlEnum("""DCRT""")|2|
||CQRT|Int32||XmlEnum("""CQRT""")|3|
||QFGC|Int32||XmlEnum("""QFGC""")|4|
||CFGC|Int32||XmlEnum("""CFGC""")|5|
||DFGC|Int32||XmlEnum("""DFGC""")|6|
||CQFG|Int32||XmlEnum("""CQFG""")|7|
||DCFG|Int32||XmlEnum("""DCFG""")|8|
||CHFG|Int32||XmlEnum("""CHFG""")|9|
||VLTE|Int32||XmlEnum("""VLTE""")|10|
||FMTE|Int32||XmlEnum("""FMTE""")|11|
||RJCT|Int32||XmlEnum("""RJCT""")|12|
||CUTO|Int32||XmlEnum("""CUTO""")|13|
||CDRT|Int32||XmlEnum("""CDRT""")|14|
||CSRV|Int32||XmlEnum("""CSRV""")|15|
||USND|Int32||XmlEnum("""USND""")|16|
||UCMP|Int32||XmlEnum("""UCMP""")|17|
||UCPT|Int32||XmlEnum("""UCPT""")|18|
||LATE|Int32||XmlEnum("""LATE""")|19|
||TIMO|Int32||XmlEnum("""TIMO""")|20|
||SFRD|Int32||XmlEnum("""SFRD""")|21|
||SECU|Int32||XmlEnum("""SECU""")|22|
||NDCL|Int32||XmlEnum("""NDCL""")|23|
||MALF|Int32||XmlEnum("""MALF""")|24|
||FILL|Int32||XmlEnum("""FILL""")|25|
||CDFG|Int32||XmlEnum("""CDFG""")|26|
||CUDC|Int32||XmlEnum("""CUDC""")|27|
||CUCL|Int32||XmlEnum("""CUCL""")|28|
||CDER|Int32||XmlEnum("""CDER""")|29|
||CDCL|Int32||XmlEnum("""CDCL""")|30|
||CDCP|Int32||XmlEnum("""CDCP""")|31|

---

## Value ISO20022.Catp003001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.GenericIdentification77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catp003001.GeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.GeographicLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Catp003001.UTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Catp003001.GeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints),validChoice(UTMCordints,GeogcCordints))|

---

## Value ISO20022.Catp003001.Header32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Catp003001.Traceability4>||XmlElement()||
|+|PrcStat|String||XmlElement()||
|+|RcptPty|String||XmlElement()||
|+|InitgPty|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|Decimal||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|ISO20022.Catp003001.ATMMessageFunction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""),validElement(MsgFctn))|

---

## Value ISO20022.Catp003001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Catp003001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Catp003001.KEK4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp003001.AlgorithmIdentification13||XmlElement()||
|+|KEKId|ISO20022.Catp003001.KEKIdentifier2||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Catp003001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.KeyTransport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp003001.AlgorithmIdentification11||XmlElement()||
|+|RcptId|ISO20022.Catp003001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Catp003001.MessageFunction11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPTC|Int32||XmlEnum("""RPTC""")|1|
||TRFP|Int32||XmlEnum("""TRFP""")|2|
||TRFQ|Int32||XmlEnum("""TRFQ""")|3|
||EXPV|Int32||XmlEnum("""EXPV""")|4|
||EXPK|Int32||XmlEnum("""EXPK""")|5|
||DPSP|Int32||XmlEnum("""DPSP""")|6|
||DPSQ|Int32||XmlEnum("""DPSQ""")|7|
||DPSV|Int32||XmlEnum("""DPSV""")|8|
||DPSK|Int32||XmlEnum("""DPSK""")|9|
||SSTS|Int32||XmlEnum("""SSTS""")|10|
||SKSC|Int32||XmlEnum("""SKSC""")|11|
||DSEC|Int32||XmlEnum("""DSEC""")|12|
||CSEC|Int32||XmlEnum("""CSEC""")|13|
||TMOP|Int32||XmlEnum("""TMOP""")|14|
||H2AQ|Int32||XmlEnum("""H2AQ""")|15|
||H2AP|Int32||XmlEnum("""H2AP""")|16|
||INQC|Int32||XmlEnum("""INQC""")|17|
||WITP|Int32||XmlEnum("""WITP""")|18|
||WITQ|Int32||XmlEnum("""WITQ""")|19|
||WITK|Int32||XmlEnum("""WITK""")|20|
||WITV|Int32||XmlEnum("""WITV""")|21|
||RJAP|Int32||XmlEnum("""RJAP""")|22|
||RJAQ|Int32||XmlEnum("""RJAQ""")|23|
||PINP|Int32||XmlEnum("""PINP""")|24|
||PINQ|Int32||XmlEnum("""PINQ""")|25|
||KYAP|Int32||XmlEnum("""KYAP""")|26|
||KYAQ|Int32||XmlEnum("""KYAQ""")|27|
||INQP|Int32||XmlEnum("""INQP""")|28|
||INQQ|Int32||XmlEnum("""INQQ""")|29|
||GSTS|Int32||XmlEnum("""GSTS""")|30|
||DIAP|Int32||XmlEnum("""DIAP""")|31|
||DIAQ|Int32||XmlEnum("""DIAQ""")|32|
||DVCC|Int32||XmlEnum("""DVCC""")|33|
||ACMD|Int32||XmlEnum("""ACMD""")|34|
||CMPD|Int32||XmlEnum("""CMPD""")|35|
||CMPA|Int32||XmlEnum("""CMPA""")|36|
||BALN|Int32||XmlEnum("""BALN""")|37|

---

## Enum ISO20022.Catp003001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Enum ISO20022.Catp003001.OutputFormat2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||SREF|Int32||XmlEnum("""SREF""")|3|
||MREF|Int32||XmlEnum("""MREF""")|4|

---

## Value ISO20022.Catp003001.Parameter4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Catp003001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catp003001.Parameter5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.Parameter6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.PartyIdentification177Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Catp003001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Catp003001.PartyType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OATM|Int32||XmlEnum("""OATM""")|1|
||ITAG|Int32||XmlEnum("""ITAG""")|2|
||HSTG|Int32||XmlEnum("""HSTG""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISP|Int32||XmlEnum("""CISP""")|5|
||ATMG|Int32||XmlEnum("""ATMG""")|6|
||ACQR|Int32||XmlEnum("""ACQR""")|7|

---

## Enum ISO20022.Catp003001.PartyType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ATMG|Int32||XmlEnum("""ATMG""")|1|
||BKAT|Int32||XmlEnum("""BKAT""")|2|
||BKAF|Int32||XmlEnum("""BKAF""")|3|
||OTRM|Int32||XmlEnum("""OTRM""")|4|
||ITAG|Int32||XmlEnum("""ITAG""")|5|
||DLIS|Int32||XmlEnum("""DLIS""")|6|
||CISS|Int32||XmlEnum("""CISS""")|7|
||ACQR|Int32||XmlEnum("""ACQR""")|8|

---

## Value ISO20022.Catp003001.PaymentCard37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctrncPrsBal|ISO20022.Catp003001.CurrencyAndAmount||XmlElement()||
|+|CardCcyCd|String||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|PlainCardData|ISO20022.Catp003001.PlainCardData24||XmlElement()||
|+|PrtctdCardData|ISO20022.Catp003001.ContentInformationType10||XmlElement()||
|+|FllbckInd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElctrncPrsBal),validPattern("""CardCcyCd""",CardCcyCd,"""[a-zA-Z0-9]{3}"""),validElement(PlainCardData),validElement(PrtctdCardData))|

---

## Value ISO20022.Catp003001.PlainCardData24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Trck3|String||XmlElement()||
|+|Trck2|String||XmlElement()||
|+|Trck1|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""XpryDt""",XpryDt,"""([0-9]{4,4}-[0-9]{2,2}-[0-9]{2,2})\|([0-9]{2,2}-[0-9]{2,2})\|([0-9]{4,4}-[0-9]{2,2})"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Catp003001.PointOfInteractionCapabilities10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RctPrtg|String||XmlElement()||
|+|IntractvTxs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgCpblties|global::System.Collections.Generic.List<ISO20022.Catp003001.DisplayCapabilities5>||XmlElement()||
|+|DpstdMdia|global::System.Collections.Generic.List<String>||XmlElement()||
|+|WdrwlMdia|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardCaptrCpbl|String||XmlElement()||
|+|MxScrptLngth|Decimal||XmlElement()||
|+|ApprvlCdLngth|Decimal||XmlElement()||
|+|PINLngthCpblties|Decimal||XmlElement()||
|+|Authntcn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardWrtData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardRdData|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MsgCpblties""",MsgCpblties),validElement(MsgCpblties))|

---

## Value ISO20022.Catp003001.PostalAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GLctn|ISO20022.Catp003001.GeographicLocation1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GLctn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Catp003001.Recipient4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp003001.KEKIdentifier2||XmlElement()||
|+|KEK|ISO20022.Catp003001.KEK4||XmlElement()||
|+|KeyTrnsprt|ISO20022.Catp003001.KeyTransport4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Catp003001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp003001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Catp003001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Catp003001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.Response12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ASUP|Int32||XmlEnum("""ASUP""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||DECL|Int32||XmlEnum("""DECL""")|3|
||APPR|Int32||XmlEnum("""APPR""")|4|

---

## Value ISO20022.Catp003001.ResponseType12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRspnInf|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.ResponseType8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRspnInf|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
|+|Cdfctn|String||XmlElement()||
|+|RspndrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.ResultDetail5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FEEM|Int32||XmlEnum("""FEEM""")|1|
||ADCC|Int32||XmlEnum("""ADCC""")|2|
||SACT|Int32||XmlEnum("""SACT""")|3|
||AGFE|Int32||XmlEnum("""AGFE""")|4|
||AMMA|Int32||XmlEnum("""AMMA""")|5|
||SRVI|Int32||XmlEnum("""SRVI""")|6|
||MEDI|Int32||XmlEnum("""MEDI""")|7|
||CRDW|Int32||XmlEnum("""CRDW""")|8|
||NMBW|Int32||XmlEnum("""NMBW""")|9|
||AMTW|Int32||XmlEnum("""AMTW""")|10|
||VNDF|Int32||XmlEnum("""VNDF""")|11|
||VNDR|Int32||XmlEnum("""VNDR""")|12|
||SVSU|Int32||XmlEnum("""SVSU""")|13|
||CRDU|Int32||XmlEnum("""CRDU""")|14|
||CMKY|Int32||XmlEnum("""CMKY""")|15|
||UNBC|Int32||XmlEnum("""UNBC""")|16|
||UNBP|Int32||XmlEnum("""UNBP""")|17|
||UNBO|Int32||XmlEnum("""UNBO""")|18|
||ORGF|Int32||XmlEnum("""ORGF""")|19|
||TXND|Int32||XmlEnum("""TXND""")|20|
||TXNU|Int32||XmlEnum("""TXNU""")|21|
||TTLV|Int32||XmlEnum("""TTLV""")|22|
||ACTT|Int32||XmlEnum("""ACTT""")|23|
||TRMI|Int32||XmlEnum("""TRMI""")|24|
||SYSM|Int32||XmlEnum("""SYSM""")|25|
||SYSP|Int32||XmlEnum("""SYSP""")|26|
||FRDS|Int32||XmlEnum("""FRDS""")|27|
||CNTC|Int32||XmlEnum("""CNTC""")|28|
||SRCH|Int32||XmlEnum("""SRCH""")|29|
||CRDS|Int32||XmlEnum("""CRDS""")|30|
||SPCC|Int32||XmlEnum("""SPCC""")|31|
||SFWE|Int32||XmlEnum("""SFWE""")|32|
||SRVU|Int32||XmlEnum("""SRVU""")|33|
||SECV|Int32||XmlEnum("""SECV""")|34|
||CRDT|Int32||XmlEnum("""CRDT""")|35|
||RECD|Int32||XmlEnum("""RECD""")|36|
||QMAX|Int32||XmlEnum("""QMAX""")|37|
||PINE|Int32||XmlEnum("""PINE""")|38|
||PINX|Int32||XmlEnum("""PINX""")|39|
||PINS|Int32||XmlEnum("""PINS""")|40|
||PIND|Int32||XmlEnum("""PIND""")|41|
||PINC|Int32||XmlEnum("""PINC""")|42|
||SEQO|Int32||XmlEnum("""SEQO""")|43|
||BALO|Int32||XmlEnum("""BALO""")|44|
||OTHR|Int32||XmlEnum("""OTHR""")|45|
||TXNM|Int32||XmlEnum("""TXNM""")|46|
||NPRC|Int32||XmlEnum("""NPRC""")|47|
||ONLP|Int32||XmlEnum("""ONLP""")|48|
||OFFL|Int32||XmlEnum("""OFFL""")|49|
||NPRA|Int32||XmlEnum("""NPRA""")|50|
||PINA|Int32||XmlEnum("""PINA""")|51|
||LBLU|Int32||XmlEnum("""LBLU""")|52|
||CRDA|Int32||XmlEnum("""CRDA""")|53|
||PINN|Int32||XmlEnum("""PINN""")|54|
||ICCM|Int32||XmlEnum("""ICCM""")|55|
||MACK|Int32||XmlEnum("""MACK""")|56|
||MACR|Int32||XmlEnum("""MACR""")|57|
||CRDL|Int32||XmlEnum("""CRDL""")|58|
||LBLA|Int32||XmlEnum("""LBLA""")|59|
||KEYS|Int32||XmlEnum("""KEYS""")|60|
||ISSU|Int32||XmlEnum("""ISSU""")|61|
||ISST|Int32||XmlEnum("""ISST""")|62|
||ISSO|Int32||XmlEnum("""ISSO""")|63|
||ISSF|Int32||XmlEnum("""ISSF""")|64|
||ISSP|Int32||XmlEnum("""ISSP""")|65|
||DATI|Int32||XmlEnum("""DATI""")|66|
||TXNV|Int32||XmlEnum("""TXNV""")|67|
||TKID|Int32||XmlEnum("""TKID""")|68|
||SGNI|Int32||XmlEnum("""SGNI""")|69|
||TKKO|Int32||XmlEnum("""TKKO""")|70|
||PINV|Int32||XmlEnum("""PINV""")|71|
||AMTO|Int32||XmlEnum("""AMTO""")|72|
||CTFV|Int32||XmlEnum("""CTFV""")|73|
||CRDI|Int32||XmlEnum("""CRDI""")|74|
||CHDI|Int32||XmlEnum("""CHDI""")|75|
||BRHI|Int32||XmlEnum("""BRHI""")|76|
||ADDI|Int32||XmlEnum("""ADDI""")|77|
||AMTI|Int32||XmlEnum("""AMTI""")|78|
||ACPI|Int32||XmlEnum("""ACPI""")|79|
||FNDI|Int32||XmlEnum("""FNDI""")|80|
||TXNG|Int32||XmlEnum("""TXNG""")|81|
||FMTR|Int32||XmlEnum("""FMTR""")|82|
||FDCL|Int32||XmlEnum("""FDCL""")|83|
||CRDX|Int32||XmlEnum("""CRDX""")|84|
||NMBD|Int32||XmlEnum("""NMBD""")|85|
||AMTD|Int32||XmlEnum("""AMTD""")|86|
||TXNL|Int32||XmlEnum("""TXNL""")|87|
||FEES|Int32||XmlEnum("""FEES""")|88|
||DBER|Int32||XmlEnum("""DBER""")|89|
||CTVG|Int32||XmlEnum("""CTVG""")|90|
||ACTC|Int32||XmlEnum("""ACTC""")|91|
||CRDF|Int32||XmlEnum("""CRDF""")|92|
||CRDR|Int32||XmlEnum("""CRDR""")|93|
||BANK|Int32||XmlEnum("""BANK""")|94|
||AUTH|Int32||XmlEnum("""AUTH""")|95|
||AMTA|Int32||XmlEnum("""AMTA""")|96|
||AMLV|Int32||XmlEnum("""AMLV""")|97|
||ACQS|Int32||XmlEnum("""ACQS""")|98|
||ACTF|Int32||XmlEnum("""ACTF""")|99|

---

## Value ISO20022.Catp003001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.TerminalHosting1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.Traceability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RlayId|ISO20022.Catp003001.GenericIdentification77||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Enum ISO20022.Catp003001.TransactionEnvironment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|

---

## Enum ISO20022.Catp003001.TransactionEnvironment3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MERC|Int32||XmlEnum("""MERC""")|2|
||BRCH|Int32||XmlEnum("""BRCH""")|3|

---

## Value ISO20022.Catp003001.TransactionIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|HstTxDtTm|DateTime||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.TransactionVerificationResult5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnTkn|String||XmlElement()||
|+|AddtlRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|VrfctnNtty|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp003001.UTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|Decimal||XmlElement()||
|+|UTMEstwrd|Decimal||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp003001.UserInterface5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRDO|Int32||XmlEnum("""CRDO""")|1|
||CRCP|Int32||XmlEnum("""CRCP""")|2|
||CDSP|Int32||XmlEnum("""CDSP""")|3|

---

## Enum ISO20022.Catp003001.Verification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ERRR|Int32||XmlEnum("""ERRR""")|1|
||SUCC|Int32||XmlEnum("""SUCC""")|2|
||PART|Int32||XmlEnum("""PART""")|3|
||NOVF|Int32||XmlEnum("""NOVF""")|4|
||MISS|Int32||XmlEnum("""MISS""")|5|
||FAIL|Int32||XmlEnum("""FAIL""")|6|

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

