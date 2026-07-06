# caaa.026.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Caaa026001.AcceptorCancellationAdvice14 {
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction143
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
    }
    ISO20022.Caaa026001.AcceptorCancellationAdvice14 *-- ISO20022.Caaa026001.CardPaymentTransaction143
    ISO20022.Caaa026001.AcceptorCancellationAdvice14 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.AcceptorCancellationAdvice14 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    class ISO20022.Caaa026001.AcceptorCompletionAdvice14 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Caaa026001.SupplementaryData1~
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction140
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
    }
    ISO20022.Caaa026001.AcceptorCompletionAdvice14 *-- ISO20022.Caaa026001.SupplementaryData1
    ISO20022.Caaa026001.AcceptorCompletionAdvice14 *-- ISO20022.Caaa026001.CardPaymentTransaction140
    ISO20022.Caaa026001.AcceptorCompletionAdvice14 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.AcceptorCompletionAdvice14 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    class ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02 {
        + SctyTrlr  : ISO20022.Caaa026001.ContentInformationType38
        + BodyElmt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.AcceptorToAcquirerFileBody2~
        + Hdr  : ISO20022.Caaa026001.Header56
    }
    ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02 *-- ISO20022.Caaa026001.ContentInformationType38
    ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02 *-- ISO20022.Caaa026001.AcceptorToAcquirerFileBody2
    ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02 *-- ISO20022.Caaa026001.Header56
    class ISO20022.Caaa026001.AcceptorToAcquirerFileBody2 {
        + BtchTrf  : ISO20022.Caaa026001.CardPaymentBatchTransfer13
        + CxlAdvc  : ISO20022.Caaa026001.AcceptorCancellationAdvice14
        + CmpltnAdvc  : ISO20022.Caaa026001.AcceptorCompletionAdvice14
    }
    ISO20022.Caaa026001.AcceptorToAcquirerFileBody2 *-- ISO20022.Caaa026001.CardPaymentBatchTransfer13
    ISO20022.Caaa026001.AcceptorToAcquirerFileBody2 *-- ISO20022.Caaa026001.AcceptorCancellationAdvice14
    ISO20022.Caaa026001.AcceptorToAcquirerFileBody2 *-- ISO20022.Caaa026001.AcceptorCompletionAdvice14
    class ISO20022.Caaa026001.AccountChoiceMethod1Code {
        TPSL = 1
        NOSL = 2
        IMPL = 3
        IMAC = 4
        ENTR = 5
        ACSL = 6
    }
    class ISO20022.Caaa026001.AccountIdentification4Choice {
        + Othr  : ISO20022.Caaa026001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Caaa026001.AccountIdentification4Choice *-- ISO20022.Caaa026001.GenericAccountIdentification1
    class ISO20022.Caaa026001.AccountIdentification54Choice {
        + Othr  : String
        + Dmst  : String
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
        + EMail  : String
        + MSISDN  : String
        + Card  : String
    }
    class ISO20022.Caaa026001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Caaa026001.Acquirer10 {
        + ParamsVrsn  : String
        + Id  : ISO20022.Caaa026001.GenericIdentification177
    }
    ISO20022.Caaa026001.Acquirer10 *-- ISO20022.Caaa026001.GenericIdentification177
    class ISO20022.Caaa026001.Action17 {
        + TmCond  : ISO20022.Caaa026001.ProcessTiming6
        + Rtry  : ISO20022.Caaa026001.ProcessRetry3
        + RmotAccs  : ISO20022.Caaa026001.NetworkParameters7
        + MsgToPres  : ISO20022.Caaa026001.ActionMessage11
        + ActnTp  : String
    }
    ISO20022.Caaa026001.Action17 *-- ISO20022.Caaa026001.ProcessTiming6
    ISO20022.Caaa026001.Action17 *-- ISO20022.Caaa026001.ProcessRetry3
    ISO20022.Caaa026001.Action17 *-- ISO20022.Caaa026001.NetworkParameters7
    ISO20022.Caaa026001.Action17 *-- ISO20022.Caaa026001.ActionMessage11
    class ISO20022.Caaa026001.ActionMessage11 {
        + MinDispTm  : Decimal
        + RspnReqrdFlg  : String
        + OutptBrcd  : ISO20022.Caaa026001.OutputBarcode2
        + MsgCnttSgntr  : ISO20022.Caaa026001.ContentInformationType38
        + MsgCntt  : String
        + Frmt  : String
        + InfQlfr  : String
        + MsgDstn  : String
    }
    ISO20022.Caaa026001.ActionMessage11 *-- ISO20022.Caaa026001.OutputBarcode2
    ISO20022.Caaa026001.ActionMessage11 *-- ISO20022.Caaa026001.ContentInformationType38
    class ISO20022.Caaa026001.ActionType15Code {
        NCOF = 1
        DNTA = 2
        TALT = 3
        ACUP = 4
        STOR = 5
        STAR = 6
        CHDA = 7
        CDCV = 8
        PINQ = 9
        FLFW = 10
        DCCQ = 11
        RQDT = 12
        RFRL = 13
        PRNT = 14
        PINR = 15
        PINL = 16
        RQID = 17
        NOVR = 18
        DISP = 19
        CPTR = 20
        BUSY = 21
    }
    class ISO20022.Caaa026001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Caaa026001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Caaa026001.AddressType3Choice {
        + Prtry  : ISO20022.Caaa026001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Caaa026001.AddressType3Choice *-- ISO20022.Caaa026001.GenericIdentification30
    class ISO20022.Caaa026001.AddressVerification1 {
        + PstlCdDgts  : String
        + AdrDgts  : String
    }
    class ISO20022.Caaa026001.AggregationTransaction3 {
        + IndvPmt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DetailedAmount21~
        + NbOfPmts  : Decimal
        + LastPmtDtTm  : DateTime
        + FrstPmtDtTm  : DateTime
    }
    ISO20022.Caaa026001.AggregationTransaction3 *-- ISO20022.Caaa026001.DetailedAmount21
    class ISO20022.Caaa026001.Algorithm26Code {
        SMS3 = 1
        SHK2 = 2
        SHK1 = 3
        SH35 = 4
        SH33 = 5
        SH32 = 6
        SH31 = 7
        HS01 = 8
        HS51 = 9
        HS38 = 10
        HS25 = 11
    }
    class ISO20022.Caaa026001.Algorithm27Code {
        S34R = 1
        S34C = 2
        CCA3 = 3
        CCA2 = 4
        CCA1 = 5
        MCS3 = 6
        CM33 = 7
        CM32 = 8
        CM31 = 9
        CMA2 = 10
        CMA5 = 11
        CMA9 = 12
        MCC1 = 13
        CMA1 = 14
        MCCS = 15
        MACC = 16
    }
    class ISO20022.Caaa026001.Algorithm28Code {
        SM4R = 1
        SM4C = 2
        UKA3 = 3
        UKA1 = 4
        SD5C = 5
        E36R = 6
        E36C = 7
        E3DR = 8
        EA2R = 9
        EA9R = 10
        EA5R = 11
        N108 = 12
        DA25 = 13
        DA19 = 14
        DA12 = 15
        EA5C = 16
        EA9C = 17
        UKA2 = 18
        UKPT = 19
        DKP9 = 20
        E3DC = 21
        EA2C = 22
    }
    class ISO20022.Caaa026001.Algorithm29Code {
        S2S3 = 1
        SM25 = 2
        SM23 = 3
        SM35 = 4
        SM32 = 5
        SM33 = 6
        SM22 = 7
        DD25 = 8
        DD23 = 9
        DD35 = 10
        DD33 = 11
        DD32 = 12
        DD22 = 13
        EO25 = 14
        EO23 = 15
        EO35 = 16
        EO22 = 17
        EO32 = 18
        EF25 = 19
        EO33 = 20
        EF23 = 21
        EF35 = 22
        EF33 = 23
        EF22 = 24
        EF32 = 25
        ED22 = 26
        ES25 = 27
        ES23 = 28
        ES35 = 29
        ES33 = 30
        ES32 = 31
        ES22 = 32
        ED25 = 33
        ED23 = 34
        ED35 = 35
        ED33 = 36
        ED32 = 37
        ERS3 = 38
        RPSS = 39
        ERS1 = 40
        ERS2 = 41
    }
    class ISO20022.Caaa026001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Caaa026001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Caaa026001.AlgorithmIdentification31 {
        + Param  : ISO20022.Caaa026001.Parameter7
        + Algo  : String
    }
    ISO20022.Caaa026001.AlgorithmIdentification31 *-- ISO20022.Caaa026001.Parameter7
    class ISO20022.Caaa026001.AlgorithmIdentification32 {
        + Param  : ISO20022.Caaa026001.Parameter12
        + Algo  : String
    }
    ISO20022.Caaa026001.AlgorithmIdentification32 *-- ISO20022.Caaa026001.Parameter12
    class ISO20022.Caaa026001.AlgorithmIdentification33 {
        + Param  : ISO20022.Caaa026001.Parameter16
        + Algo  : String
    }
    ISO20022.Caaa026001.AlgorithmIdentification33 *-- ISO20022.Caaa026001.Parameter16
    class ISO20022.Caaa026001.AlgorithmIdentification34 {
        + Param  : ISO20022.Caaa026001.Parameter18
        + Algo  : String
    }
    ISO20022.Caaa026001.AlgorithmIdentification34 *-- ISO20022.Caaa026001.Parameter18
    class ISO20022.Caaa026001.AlgorithmIdentification35 {
        + Param  : ISO20022.Caaa026001.Parameter17
        + Algo  : String
    }
    ISO20022.Caaa026001.AlgorithmIdentification35 *-- ISO20022.Caaa026001.Parameter17
    class ISO20022.Caaa026001.AlgorithmIdentification36 {
        + Algo  : String
    }
    class ISO20022.Caaa026001.Amount5 {
        + Sgn  : String
        + Amt  : Decimal
    }
    class ISO20022.Caaa026001.AmountAndDirection93 {
        + Sgn  : String
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Caaa026001.AmountUnit1Code {
        POIN = 1
        MONE = 2
    }
    class ISO20022.Caaa026001.AttendanceContext1Code {
        UATT = 1
        SATT = 2
        ATTD = 3
    }
    class ISO20022.Caaa026001.AttendanceContext2Code {
        SELF = 1
        FULL = 2
        CUST = 3
        CARR = 4
        ATTL = 5
    }
    class ISO20022.Caaa026001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Caaa026001.AuthenticatedData10 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Caaa026001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Caaa026001.AlgorithmIdentification31
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Recipient15Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.AuthenticatedData10 *-- ISO20022.Caaa026001.EncapsulatedContent3
    ISO20022.Caaa026001.AuthenticatedData10 *-- ISO20022.Caaa026001.AlgorithmIdentification31
    ISO20022.Caaa026001.AuthenticatedData10 *-- ISO20022.Caaa026001.Recipient15Choice
    class ISO20022.Caaa026001.AuthenticationEntity2Code {
        TRML = 1
        ISSR = 2
        ACQR = 3
        MERC = 4
        AGNT = 5
        ICCD = 6
    }
    class ISO20022.Caaa026001.AuthenticationMethod6Code {
        TOKP = 1
        FPIN = 2
        MANU = 3
        ADDS = 4
        CSEC = 5
        PSVE = 6
        CSCV = 7
        CRYP = 8
        CDHI = 9
        BIOM = 10
        ADDB = 11
        CPSG = 12
        SNCT = 13
        SCNL = 14
        SCRT = 15
        PSWD = 16
        PPSG = 17
        NPIN = 18
    }
    class ISO20022.Caaa026001.AuthenticationMethod8Code {
        UKNW = 1
        TOKN = 2
        CPSG = 3
        ADDS = 4
        SNCT = 5
        CSEC = 6
        SCNL = 7
        SCRT = 8
        TOKP = 9
        PSWD = 10
        PSVE = 11
        PPSG = 12
        OTHR = 13
        NPIN = 14
        FPIN = 15
        MOBL = 16
        MERC = 17
        MANU = 18
        CSCV = 19
        CRYP = 20
        CDHI = 21
        BIOM = 22
        BYPS = 23
        ADDB = 24
        TOKA = 25
    }
    class ISO20022.Caaa026001.AuthenticationResult1Code {
        UCRP = 1
        CRPT = 2
        AUTH = 3
        CARD = 4
        MRCH = 5
        DENY = 6
    }
    class ISO20022.Caaa026001.AuthorisationResult17 {
        + TMSTrggr  : ISO20022.Caaa026001.TMSTrigger1
        + CmpltnReqrd  : String
        + AuthstnCd  : String
        + RspnToAuthstn  : ISO20022.Caaa026001.ResponseType10
        + AuthstnNtty  : ISO20022.Caaa026001.GenericIdentification90
    }
    ISO20022.Caaa026001.AuthorisationResult17 *-- ISO20022.Caaa026001.TMSTrigger1
    ISO20022.Caaa026001.AuthorisationResult17 *-- ISO20022.Caaa026001.ResponseType10
    ISO20022.Caaa026001.AuthorisationResult17 *-- ISO20022.Caaa026001.GenericIdentification90
    class ISO20022.Caaa026001.AuthorisationResult18 {
        + AuthstnCd  : String
        + RspnToAuthstn  : ISO20022.Caaa026001.ResponseType10
        + AuthstnNtty  : ISO20022.Caaa026001.GenericIdentification90
    }
    ISO20022.Caaa026001.AuthorisationResult18 *-- ISO20022.Caaa026001.ResponseType10
    ISO20022.Caaa026001.AuthorisationResult18 *-- ISO20022.Caaa026001.GenericIdentification90
    class ISO20022.Caaa026001.AuthorisationResult19 {
        + TMSTrggr  : ISO20022.Caaa026001.TMSTrigger1
        + AuthstnCd  : String
        + RspnToAuthstn  : ISO20022.Caaa026001.ResponseType10
        + AuthstnNtty  : ISO20022.Caaa026001.GenericIdentification90
    }
    ISO20022.Caaa026001.AuthorisationResult19 *-- ISO20022.Caaa026001.TMSTrigger1
    ISO20022.Caaa026001.AuthorisationResult19 *-- ISO20022.Caaa026001.ResponseType10
    ISO20022.Caaa026001.AuthorisationResult19 *-- ISO20022.Caaa026001.GenericIdentification90
    class ISO20022.Caaa026001.BarcodeType1Code {
        UPCA = 1
        P417 = 2
        EAN8 = 3
        EA13 = 4
        C039 = 5
        C025 = 6
        C128 = 7
        COQR = 8
    }
    class ISO20022.Caaa026001.BinRange1 {
        + HghrBin  : String
        + LwrBin  : String
    }
    class ISO20022.Caaa026001.BusinessArea2Code {
        TOPT = 1
        EOPT = 2
        TKNF = 3
        PPAY = 4
        AIBD = 5
    }
    class ISO20022.Caaa026001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Caaa026001.CardAccount16 {
        + Svcr  : ISO20022.Caaa026001.PartyIdentification177Choice
        + AcctIdr  : ISO20022.Caaa026001.AccountIdentification54Choice
        + Ccy  : String
        + AcctOwnr  : ISO20022.Caaa026001.NameAndAddress3
        + AcctNm  : String
        + SelctdAcctTp  : String
        + SelctnMtd  : String
    }
    ISO20022.Caaa026001.CardAccount16 *-- ISO20022.Caaa026001.PartyIdentification177Choice
    ISO20022.Caaa026001.CardAccount16 *-- ISO20022.Caaa026001.AccountIdentification54Choice
    ISO20022.Caaa026001.CardAccount16 *-- ISO20022.Caaa026001.NameAndAddress3
    class ISO20022.Caaa026001.CardAccountType3Code {
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
    class ISO20022.Caaa026001.CardDataReading5Code {
        CDFL = 1
        ECTL = 2
        CTLS = 3
        DFLE = 4
        CICC = 5
        MGST = 6
        BRCD = 7
        PHYS = 8
        TAGC = 9
    }
    class ISO20022.Caaa026001.CardDataReading8Code {
        OPTC = 1
        QRCD = 2
        UNKW = 3
        SICC = 4
        CDFL = 5
        ECTL = 6
        CTLS = 7
        DFLE = 8
        CICC = 9
        MGST = 10
        BRCD = 11
        PHYS = 12
        TAGC = 13
    }
    class ISO20022.Caaa026001.CardFallback1Code {
        NFLB = 1
        SFLB = 2
        FFLB = 3
    }
    class ISO20022.Caaa026001.CardIdentificationType1Code {
        UUID = 1
        PRIV = 2
        CPAN = 3
        PHON = 4
        ISO2 = 5
        BARC = 6
        ACCT = 7
    }
    class ISO20022.Caaa026001.CardPaymentBatchTransfer13 {
        + DataSet  : global::System.Collections.Generic.List~ISO20022.Caaa026001.CardPaymentDataSet40~
        + TxTtls  : global::System.Collections.Generic.List~ISO20022.Caaa026001.TransactionTotals12~
    }
    ISO20022.Caaa026001.CardPaymentBatchTransfer13 *-- ISO20022.Caaa026001.CardPaymentDataSet40
    ISO20022.Caaa026001.CardPaymentBatchTransfer13 *-- ISO20022.Caaa026001.TransactionTotals12
    class ISO20022.Caaa026001.CardPaymentDataSet40 {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice~
        + CmonData  : ISO20022.Caaa026001.CommonData14
        + TxTtls  : global::System.Collections.Generic.List~ISO20022.Caaa026001.TransactionTotals12~
        + DataSetInitr  : ISO20022.Caaa026001.GenericIdentification176
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Traceability8~
        + DataSetId  : ISO20022.Caaa026001.DataSetIdentification5
    }
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.CommonData14
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.TransactionTotals12
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.GenericIdentification176
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.Traceability8
    ISO20022.Caaa026001.CardPaymentDataSet40 *-- ISO20022.Caaa026001.DataSetIdentification5
    class ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice {
        + TknRspn  : ISO20022.Caaa026001.TokenRequestComponent5
        + TknReq  : ISO20022.Caaa026001.TokenRequestComponent5
        + AuthstnRspn  : ISO20022.Caaa026001.CardPaymentDataSetTransaction53
        + AuthstnReq  : ISO20022.Caaa026001.CardPaymentDataSetTransaction52
        + Cxl  : ISO20022.Caaa026001.CardPaymentDataSetTransaction50
        + Cmpltn  : ISO20022.Caaa026001.CardPaymentDataSetTransaction51
    }
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.TokenRequestComponent5
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.TokenRequestComponent5
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.CardPaymentDataSetTransaction53
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.CardPaymentDataSetTransaction52
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.CardPaymentDataSetTransaction50
    ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice *-- ISO20022.Caaa026001.CardPaymentDataSetTransaction51
    class ISO20022.Caaa026001.CardPaymentDataSetTransaction50 {
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction143
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Traceability8~
        + TxSeqCntr  : String
    }
    ISO20022.Caaa026001.CardPaymentDataSetTransaction50 *-- ISO20022.Caaa026001.CardPaymentTransaction143
    ISO20022.Caaa026001.CardPaymentDataSetTransaction50 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.CardPaymentDataSetTransaction50 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    ISO20022.Caaa026001.CardPaymentDataSetTransaction50 *-- ISO20022.Caaa026001.Traceability8
    class ISO20022.Caaa026001.CardPaymentDataSetTransaction51 {
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction140
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Traceability8~
        + TxSeqCntr  : String
    }
    ISO20022.Caaa026001.CardPaymentDataSetTransaction51 *-- ISO20022.Caaa026001.CardPaymentTransaction140
    ISO20022.Caaa026001.CardPaymentDataSetTransaction51 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.CardPaymentDataSetTransaction51 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    ISO20022.Caaa026001.CardPaymentDataSetTransaction51 *-- ISO20022.Caaa026001.Traceability8
    class ISO20022.Caaa026001.CardPaymentDataSetTransaction52 {
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction139
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Traceability8~
        + TxSeqCntr  : String
    }
    ISO20022.Caaa026001.CardPaymentDataSetTransaction52 *-- ISO20022.Caaa026001.CardPaymentTransaction139
    ISO20022.Caaa026001.CardPaymentDataSetTransaction52 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.CardPaymentDataSetTransaction52 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    ISO20022.Caaa026001.CardPaymentDataSetTransaction52 *-- ISO20022.Caaa026001.Traceability8
    class ISO20022.Caaa026001.CardPaymentDataSetTransaction53 {
        + TxRspn  : ISO20022.Caaa026001.CardPaymentTransaction144
        + Tx  : ISO20022.Caaa026001.CardPaymentTransaction137
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Traceability8~
        + TxSeqCntr  : String
    }
    ISO20022.Caaa026001.CardPaymentDataSetTransaction53 *-- ISO20022.Caaa026001.CardPaymentTransaction144
    ISO20022.Caaa026001.CardPaymentDataSetTransaction53 *-- ISO20022.Caaa026001.CardPaymentTransaction137
    ISO20022.Caaa026001.CardPaymentDataSetTransaction53 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    ISO20022.Caaa026001.CardPaymentDataSetTransaction53 *-- ISO20022.Caaa026001.Traceability8
    class ISO20022.Caaa026001.CardPaymentEnvironment81 {
        + SaleEnvt  : ISO20022.Caaa026001.RetailerSaleEnvironment2
        + PrtctdCrdhldrData  : ISO20022.Caaa026001.ContentInformationType40
        + Crdhldr  : ISO20022.Caaa026001.Cardholder21
        + MrchntTkn  : ISO20022.Caaa026001.MerchantToken2
        + PmtTkn  : ISO20022.Caaa026001.Token1
        + Wllt  : ISO20022.Caaa026001.CustomerDevice3
        + CstmrDvc  : ISO20022.Caaa026001.CustomerDevice3
        + LltyAcct  : global::System.Collections.Generic.List~ISO20022.Caaa026001.LoyaltyAccount3~
        + StordValAcct  : global::System.Collections.Generic.List~ISO20022.Caaa026001.StoredValueAccount2~
        + Chck  : ISO20022.Caaa026001.Check1
        + Card  : ISO20022.Caaa026001.PaymentCard35
        + POI  : ISO20022.Caaa026001.PointOfInteraction15
        + Mrchnt  : ISO20022.Caaa026001.Organisation41
        + SvcPrvdr  : ISO20022.Caaa026001.Acquirer10
        + Acqrr  : ISO20022.Caaa026001.Acquirer10
    }
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.RetailerSaleEnvironment2
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.ContentInformationType40
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Cardholder21
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.MerchantToken2
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Token1
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.CustomerDevice3
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.CustomerDevice3
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.LoyaltyAccount3
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.StoredValueAccount2
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Check1
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.PaymentCard35
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.PointOfInteraction15
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Organisation41
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Acquirer10
    ISO20022.Caaa026001.CardPaymentEnvironment81 *-- ISO20022.Caaa026001.Acquirer10
    class ISO20022.Caaa026001.CardPaymentServiceType12Code {
        CIDD = 1
        CAFL = 2
        CAFT = 3
        UNLD = 4
        VALC = 5
        RESA = 6
        RFND = 7
        QUCH = 8
        PINC = 9
        ORCR = 10
        LOAD = 11
        DEFR = 12
        CSHD = 13
        CSHW = 14
        CAVR = 15
        CAFH = 16
        CRDP = 17
        CACT = 18
        BALC = 19
    }
    class ISO20022.Caaa026001.CardPaymentServiceType15Code {
        DFCL = 1
        GOPT = 2
        RREC = 3
        FREC = 4
        ARES = 5
        PRES = 6
        URES = 7
        IRES = 8
    }
    class ISO20022.Caaa026001.CardPaymentServiceType9Code {
        NRFD = 1
        INST = 2
        CSHB = 3
        INSA = 4
        INSI = 5
        VCAU = 6
        SOAF = 7
        RECP = 8
        PUCO = 9
        NRES = 10
        LOYT = 11
        GRTT = 12
        DCCV = 13
        AGGR = 14
    }
    class ISO20022.Caaa026001.CardPaymentTransaction137 {
        + MrchntRefData  : String
        + TxDtls  : ISO20022.Caaa026001.CardPaymentTransactionDetails53
        + IntrchngData  : String
        + RcncltnId  : String
        + RcptTxId  : String
        + InitrTxId  : String
        + TxId  : ISO20022.Caaa026001.TransactionIdentifier1
        + SaleRefId  : String
    }
    ISO20022.Caaa026001.CardPaymentTransaction137 *-- ISO20022.Caaa026001.CardPaymentTransactionDetails53
    ISO20022.Caaa026001.CardPaymentTransaction137 *-- ISO20022.Caaa026001.TransactionIdentifier1
    class ISO20022.Caaa026001.CardPaymentTransaction138 {
        + TxRslt  : ISO20022.Caaa026001.CardPaymentTransactionResult4
        + CardDataNtryMd  : String
        + SvcAttr  : String
        + AddtlSvc  : global::System.Collections.Generic.List~String~
        + TxTp  : String
        + RcptTxId  : String
        + InitrTxId  : String
        + POIId  : ISO20022.Caaa026001.GenericIdentification32
        + TxId  : ISO20022.Caaa026001.TransactionIdentifier1
        + SaleRefId  : String
    }
    ISO20022.Caaa026001.CardPaymentTransaction138 *-- ISO20022.Caaa026001.CardPaymentTransactionResult4
    ISO20022.Caaa026001.CardPaymentTransaction138 *-- ISO20022.Caaa026001.GenericIdentification32
    ISO20022.Caaa026001.CardPaymentTransaction138 *-- ISO20022.Caaa026001.TransactionIdentifier1
    class ISO20022.Caaa026001.CardPaymentTransaction139 {
        + AddtlTxData  : global::System.Collections.Generic.List~String~
        + AcctTo  : ISO20022.Caaa026001.CardAccount16
        + AcctFr  : ISO20022.Caaa026001.CardAccount16
        + MrchntRefData  : String
        + TxDtls  : ISO20022.Caaa026001.CardPaymentTransactionDetails53
        + MrchntCITId  : String
        + IssrCITId  : String
        + RcncltnId  : String
        + InitrTxId  : String
        + OrgnlTx  : ISO20022.Caaa026001.CardPaymentTransaction138
        + TxId  : ISO20022.Caaa026001.TransactionIdentifier1
        + SaleRefId  : String
        + CardPrgrmmApld  : String
        + CardPrgrmmPropsd  : global::System.Collections.Generic.List~String~
        + CstmrCnsnt  : String
        + MrchntCtgyCd  : String
        + LastTxFlg  : String
        + SvcAttr  : String
        + AddtlSvc  : global::System.Collections.Generic.List~String~
        + TxTp  : String
        + TxCaptr  : String
    }
    ISO20022.Caaa026001.CardPaymentTransaction139 *-- ISO20022.Caaa026001.CardAccount16
    ISO20022.Caaa026001.CardPaymentTransaction139 *-- ISO20022.Caaa026001.CardAccount16
    ISO20022.Caaa026001.CardPaymentTransaction139 *-- ISO20022.Caaa026001.CardPaymentTransactionDetails53
    ISO20022.Caaa026001.CardPaymentTransaction139 *-- ISO20022.Caaa026001.CardPaymentTransaction138
    ISO20022.Caaa026001.CardPaymentTransaction139 *-- ISO20022.Caaa026001.TransactionIdentifier1
    class ISO20022.Caaa026001.CardPaymentTransaction140 {
        + AddtlTxData  : global::System.Collections.Generic.List~String~
        + AcctTo  : ISO20022.Caaa026001.CardAccount16
        + AcctFr  : ISO20022.Caaa026001.CardAccount16
        + MrchntRefData  : String
        + AuthstnRslt  : ISO20022.Caaa026001.AuthorisationResult18
        + TxDtls  : ISO20022.Caaa026001.CardPaymentTransactionDetails53
        + MrchntCITId  : String
        + IssrCITId  : String
        + IntrchngData  : String
        + RcncltnId  : String
        + RcptTxId  : String
        + InitrTxId  : String
        + FailrRsn  : global::System.Collections.Generic.List~String~
        + MrchntOvrrd  : String
        + Rvsl  : String
        + TxSucss  : String
        + OrgnlTx  : ISO20022.Caaa026001.CardPaymentTransaction138
        + TxId  : ISO20022.Caaa026001.TransactionIdentifier1
        + SaleRefId  : String
        + CardPrgrmmApld  : String
        + CardPrgrmmPropsd  : global::System.Collections.Generic.List~String~
        + CstmrCnsnt  : String
        + MrchntCtgyCd  : String
        + LastTxFlg  : String
        + SvcAttr  : String
        + AddtlSvc  : global::System.Collections.Generic.List~String~
        + TxTp  : String
        + TxCaptr  : String
    }
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.CardAccount16
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.CardAccount16
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.AuthorisationResult18
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.CardPaymentTransactionDetails53
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.CardPaymentTransaction138
    ISO20022.Caaa026001.CardPaymentTransaction140 *-- ISO20022.Caaa026001.TransactionIdentifier1
    class ISO20022.Caaa026001.CardPaymentTransaction143 {
        + AddtlTxData  : global::System.Collections.Generic.List~String~
        + AuthstnRslt  : ISO20022.Caaa026001.AuthorisationResult19
        + TxDtls  : ISO20022.Caaa026001.CardPaymentTransactionDetails50
        + IntrchngData  : String
        + RcncltnId  : String
        + RcptTxId  : String
        + InitrTxId  : String
        + FailrRsn  : global::System.Collections.Generic.List~String~
        + Rvsl  : String
        + TxSucss  : String
        + OrgnlTx  : ISO20022.Caaa026001.CardPaymentTransaction138
        + TxId  : ISO20022.Caaa026001.TransactionIdentifier1
        + SaleRefId  : String
        + CardPrgrmmApld  : String
        + CardPrgrmmPropsd  : global::System.Collections.Generic.List~String~
        + CstmrCnsnt  : String
        + MrchntCtgyCd  : String
    }
    ISO20022.Caaa026001.CardPaymentTransaction143 *-- ISO20022.Caaa026001.AuthorisationResult19
    ISO20022.Caaa026001.CardPaymentTransaction143 *-- ISO20022.Caaa026001.CardPaymentTransactionDetails50
    ISO20022.Caaa026001.CardPaymentTransaction143 *-- ISO20022.Caaa026001.CardPaymentTransaction138
    ISO20022.Caaa026001.CardPaymentTransaction143 *-- ISO20022.Caaa026001.TransactionIdentifier1
    class ISO20022.Caaa026001.CardPaymentTransaction144 {
        + CcyConvsElgblty  : ISO20022.Caaa026001.CurrencyConversion29
        + Actn  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Action17~
        + PrtctdBal  : ISO20022.Caaa026001.ContentInformationType40
        + Bal  : ISO20022.Caaa026001.AmountAndDirection93
        + AddtlAvlblPdct  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Product5~
        + NotAllwdPdctCd  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Product4~
        + AllwdPdctCd  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Product4~
        + AuthstnRslt  : ISO20022.Caaa026001.AuthorisationResult17
    }
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.CurrencyConversion29
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.Action17
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.ContentInformationType40
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.AmountAndDirection93
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.Product5
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.Product4
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.Product4
    ISO20022.Caaa026001.CardPaymentTransaction144 *-- ISO20022.Caaa026001.AuthorisationResult17
    class ISO20022.Caaa026001.CardPaymentTransactionDetails50 {
        + KeepAuthstnOpn  : String
        + ICCRltdData  : String
        + VldtyDt  : DateTime
        + TtlAmt  : Decimal
        + Ccy  : String
    }
    class ISO20022.Caaa026001.CardPaymentTransactionDetails53 {
        + ICCRltdData  : String
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ExternallyDefinedData5~
        + TtlAuthrsdAmt  : Decimal
        + CmpltnSeqCntr  : Decimal
        + CmpltnSeqNb  : Decimal
        + ReSubmissnCntr  : Decimal
        + DlvryLctn  : String
        + SaleItm  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Product6~
        + PdctCdSetId  : String
        + AggtnTx  : ISO20022.Caaa026001.AggregationTransaction3
        + Rcrng  : ISO20022.Caaa026001.RecurringTransaction6
        + Instlmt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Instalment5~
        + CcyConvsRslt  : ISO20022.Caaa026001.CurrencyConversion30
        + AcctTp  : String
        + UattnddLvlCtgy  : String
        + OnLineRsn  : global::System.Collections.Generic.List~String~
        + VldtyDt  : DateTime
        + InvcAmt  : Decimal
        + AuthrsdAmt  : Decimal
        + ReqdAmt  : Decimal
        + DtldAmt  : ISO20022.Caaa026001.DetailedAmount15
        + AmtQlfr  : String
        + CmltvAmt  : Decimal
        + TtlAmt  : Decimal
        + Ccy  : String
    }
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.ExternallyDefinedData5
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.Product6
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.AggregationTransaction3
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.RecurringTransaction6
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.Instalment5
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.CurrencyConversion30
    ISO20022.Caaa026001.CardPaymentTransactionDetails53 *-- ISO20022.Caaa026001.DetailedAmount15
    class ISO20022.Caaa026001.CardPaymentTransactionResult4 {
        + AuthstnCd  : String
        + RspnToAuthstn  : ISO20022.Caaa026001.ResponseType10
        + AuthstnNtty  : ISO20022.Caaa026001.GenericIdentification90
    }
    ISO20022.Caaa026001.CardPaymentTransactionResult4 *-- ISO20022.Caaa026001.ResponseType10
    ISO20022.Caaa026001.CardPaymentTransactionResult4 *-- ISO20022.Caaa026001.GenericIdentification90
    class ISO20022.Caaa026001.CardProductType1Code {
        CONS = 1
        COMM = 2
    }
    class ISO20022.Caaa026001.Cardholder21 {
        + MobData  : global::System.Collections.Generic.List~ISO20022.Caaa026001.MobileData6~
        + PrsnlData  : String
        + TxVrfctnRslt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.TransactionVerificationResult4~
        + Authntcn  : global::System.Collections.Generic.List~ISO20022.Caaa026001.CardholderAuthentication17~
        + Vhcl  : ISO20022.Caaa026001.Vehicle1
        + TripNb  : String
        + ShppgAdr  : ISO20022.Caaa026001.PostalAddress22
        + BllgAdr  : ISO20022.Caaa026001.PostalAddress22
        + Lang  : String
        + Nm  : String
        + Id  : ISO20022.Caaa026001.PersonIdentification15
    }
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.MobileData6
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.TransactionVerificationResult4
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.CardholderAuthentication17
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.Vehicle1
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.PostalAddress22
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.PostalAddress22
    ISO20022.Caaa026001.Cardholder21 *-- ISO20022.Caaa026001.PersonIdentification15
    class ISO20022.Caaa026001.CardholderAuthentication17 {
        + AuthntcnAddtlInf  : ISO20022.Caaa026001.ExternallyDefinedData5
        + AuthntcnRslt  : String
        + AuthntcnLvl  : String
        + AuthntcnTp  : String
        + AdrVrfctn  : ISO20022.Caaa026001.AddressVerification1
        + CrdhldrId  : ISO20022.Caaa026001.PersonIdentification15
        + CrdhldrOnLinePIN  : ISO20022.Caaa026001.OnLinePIN11
        + PrtctdAuthntcnVal  : ISO20022.Caaa026001.ContentInformationType40
        + AuthntcnVal  : String
        + AuthntcnXmptn  : String
        + AuthntcnMtd  : String
    }
    ISO20022.Caaa026001.CardholderAuthentication17 *-- ISO20022.Caaa026001.ExternallyDefinedData5
    ISO20022.Caaa026001.CardholderAuthentication17 *-- ISO20022.Caaa026001.AddressVerification1
    ISO20022.Caaa026001.CardholderAuthentication17 *-- ISO20022.Caaa026001.PersonIdentification15
    ISO20022.Caaa026001.CardholderAuthentication17 *-- ISO20022.Caaa026001.OnLinePIN11
    ISO20022.Caaa026001.CardholderAuthentication17 *-- ISO20022.Caaa026001.ContentInformationType40
    class ISO20022.Caaa026001.CardholderVerificationCapability4Code {
        OTHR = 1
        NOVF = 2
        NBIO = 3
        SCEC = 4
        PKIS = 5
        NPIN = 6
        FEPN = 7
        FCPN = 8
        FDSG = 9
        FBIO = 10
        FBIG = 11
        MNVR = 12
        MNSG = 13
        CHDT = 14
        APKI = 15
    }
    class ISO20022.Caaa026001.CashAccount40 {
        + Prxy  : ISO20022.Caaa026001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Caaa026001.CashAccountType2Choice
        + Id  : ISO20022.Caaa026001.AccountIdentification4Choice
    }
    ISO20022.Caaa026001.CashAccount40 *-- ISO20022.Caaa026001.ProxyAccountIdentification1
    ISO20022.Caaa026001.CashAccount40 *-- ISO20022.Caaa026001.CashAccountType2Choice
    ISO20022.Caaa026001.CashAccount40 *-- ISO20022.Caaa026001.AccountIdentification4Choice
    class ISO20022.Caaa026001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Caaa026001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Caaa026001.RelativeDistinguishedName1~
    }
    ISO20022.Caaa026001.CertificateIssuer1 *-- ISO20022.Caaa026001.RelativeDistinguishedName1
    class ISO20022.Caaa026001.Check1 {
        + Ctry  : String
        + ChckTp  : String
        + ChckTrckData2  : ISO20022.Caaa026001.TrackData2
        + ChckCardNb  : String
        + ChckNb  : String
        + AcctNb  : String
        + BkId  : String
    }
    ISO20022.Caaa026001.Check1 *-- ISO20022.Caaa026001.TrackData2
    class ISO20022.Caaa026001.CheckType1Code {
        PERS = 1
        PAYR = 2
        GOVC = 3
        BUSI = 4
        BANK = 5
    }
    class ISO20022.Caaa026001.Commission18 {
        + AddtlInf  : String
        + Rate  : Decimal
    }
    class ISO20022.Caaa026001.Commission19 {
        + AddtlInf  : String
        + Amt  : Decimal
    }
    class ISO20022.Caaa026001.CommonData14 {
        + Ccy  : String
        + RcncltnId  : String
        + MrchntCtgyCd  : String
        + SvcAttr  : String
        + AddtlSvc  : global::System.Collections.Generic.List~String~
        + TxTp  : String
        + Cntxt  : ISO20022.Caaa026001.PaymentContext30
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
    }
    ISO20022.Caaa026001.CommonData14 *-- ISO20022.Caaa026001.PaymentContext30
    ISO20022.Caaa026001.CommonData14 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    class ISO20022.Caaa026001.CommunicationAddress9 {
        + AddtlCtctInf  : String
        + CstmrSvc  : String
        + Phne  : String
        + URLAdr  : String
        + Email  : String
        + PstlAdr  : ISO20022.Caaa026001.PostalAddress22
    }
    ISO20022.Caaa026001.CommunicationAddress9 *-- ISO20022.Caaa026001.PostalAddress22
    class ISO20022.Caaa026001.CommunicationCharacteristics5 {
        + PhysIntrfc  : ISO20022.Caaa026001.PhysicalInterfaceParameter1
        + Params  : ISO20022.Caaa026001.NetworkParameters7
        + Actv  : String
        + RmotPty  : global::System.Collections.Generic.List~String~
        + ComTp  : String
    }
    ISO20022.Caaa026001.CommunicationCharacteristics5 *-- ISO20022.Caaa026001.PhysicalInterfaceParameter1
    ISO20022.Caaa026001.CommunicationCharacteristics5 *-- ISO20022.Caaa026001.NetworkParameters7
    class ISO20022.Caaa026001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.OtherContact1~
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
    ISO20022.Caaa026001.Contact13 *-- ISO20022.Caaa026001.OtherContact1
    class ISO20022.Caaa026001.ContentInformationType38 {
        + SgndData  : ISO20022.Caaa026001.SignedData9
        + AuthntcdData  : ISO20022.Caaa026001.AuthenticatedData10
        + CnttTp  : String
    }
    ISO20022.Caaa026001.ContentInformationType38 *-- ISO20022.Caaa026001.SignedData9
    ISO20022.Caaa026001.ContentInformationType38 *-- ISO20022.Caaa026001.AuthenticatedData10
    class ISO20022.Caaa026001.ContentInformationType39 {
        + DgstdData  : ISO20022.Caaa026001.DigestedData6
        + SgndData  : ISO20022.Caaa026001.SignedData9
        + AuthntcdData  : ISO20022.Caaa026001.AuthenticatedData10
        + EnvlpdData  : ISO20022.Caaa026001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Caaa026001.ContentInformationType39 *-- ISO20022.Caaa026001.DigestedData6
    ISO20022.Caaa026001.ContentInformationType39 *-- ISO20022.Caaa026001.SignedData9
    ISO20022.Caaa026001.ContentInformationType39 *-- ISO20022.Caaa026001.AuthenticatedData10
    ISO20022.Caaa026001.ContentInformationType39 *-- ISO20022.Caaa026001.EnvelopedData11
    class ISO20022.Caaa026001.ContentInformationType40 {
        + EnvlpdData  : ISO20022.Caaa026001.EnvelopedData11
        + CnttTp  : String
    }
    ISO20022.Caaa026001.ContentInformationType40 *-- ISO20022.Caaa026001.EnvelopedData11
    class ISO20022.Caaa026001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Caaa026001.CreditTransferContext1 {
        + PrtctdCdtrAcct  : ISO20022.Caaa026001.ContentInformationType39
        + CdtrAcct  : ISO20022.Caaa026001.CashAccount40
        + Cdtr  : ISO20022.Caaa026001.PartyIdentification272
        + PrtctdDbtrAcct  : ISO20022.Caaa026001.ContentInformationType39
        + DbtrAcct  : ISO20022.Caaa026001.CashAccount40
        + Dbtr  : ISO20022.Caaa026001.PartyIdentification272
        + SysToNtfy  : String
        + WaitForNtfctnBfrEndg  : String
        + AutomtcNtfctnOfCshMvmnt  : String
    }
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.ContentInformationType39
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.CashAccount40
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.PartyIdentification272
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.ContentInformationType39
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.CashAccount40
    ISO20022.Caaa026001.CreditTransferContext1 *-- ISO20022.Caaa026001.PartyIdentification272
    class ISO20022.Caaa026001.CryptographicKey18 {
        + AddtlMgmtInf  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericInformation1~
        + KeyChckVal  : String
        + PrtctdCmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ContentInformationType39~
        + CmpntWthAuthrsdAccs  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericIdentification186~
        + KeyVal  : ISO20022.Caaa026001.ContentInformationType39
        + DeactvtnDt  : DateTime
        + ActvtnDt  : DateTime
        + Fctn  : global::System.Collections.Generic.List~String~
        + Tp  : String
        + Vrsn  : String
        + ItmNb  : String
        + SctyPrfl  : String
        + Nm  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Caaa026001.CryptographicKey18 *-- ISO20022.Caaa026001.GenericInformation1
    ISO20022.Caaa026001.CryptographicKey18 *-- ISO20022.Caaa026001.ContentInformationType39
    ISO20022.Caaa026001.CryptographicKey18 *-- ISO20022.Caaa026001.GenericIdentification186
    ISO20022.Caaa026001.CryptographicKey18 *-- ISO20022.Caaa026001.ContentInformationType39
    class ISO20022.Caaa026001.CryptographicKeyType3Code {
        EDE4 = 1
        AES5 = 2
        AES9 = 3
        DKP9 = 4
        EDE3 = 5
        AES2 = 6
    }
    class ISO20022.Caaa026001.CurrencyConversion29 {
        + DclrtnDtls  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ActionMessage11~
        + MrkUpDtls  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Commission18~
        + ComssnDtls  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Commission19~
        + OrgnlAmt  : ISO20022.Caaa026001.OriginalAmountDetails1
        + AplblBinRg  : global::System.Collections.Generic.List~ISO20022.Caaa026001.BinRange1~
        + SrcCcy  : ISO20022.Caaa026001.CurrencyDetails2
        + VldUntil  : DateTime
        + VldFr  : DateTime
        + QtnDt  : DateTime
        + NvrtdXchgRate  : Decimal
        + XchgRate  : Decimal
        + RsltgAmt  : Decimal
        + TrgtCcy  : ISO20022.Caaa026001.CurrencyDetails3
        + CcyConvsId  : String
    }
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.ActionMessage11
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.Commission18
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.Commission19
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.OriginalAmountDetails1
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.BinRange1
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.CurrencyDetails2
    ISO20022.Caaa026001.CurrencyConversion29 *-- ISO20022.Caaa026001.CurrencyDetails3
    class ISO20022.Caaa026001.CurrencyConversion30 {
        + Convs  : ISO20022.Caaa026001.CurrencyConversion29
        + AccptdByCrdhldr  : String
    }
    ISO20022.Caaa026001.CurrencyConversion30 *-- ISO20022.Caaa026001.CurrencyConversion29
    class ISO20022.Caaa026001.CurrencyDetails2 {
        + Nm  : String
        + Dcml  : Decimal
        + NmrcCd  : String
        + AlphaCd  : String
    }
    class ISO20022.Caaa026001.CurrencyDetails3 {
        + Nm  : String
        + Dcml  : Decimal
        + NmrcCd  : String
        + AlphaCd  : String
    }
    class ISO20022.Caaa026001.CustomerDevice3 {
        + Prvdr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.DataSetCategory8Code {
        RCLE = 1
        MGTP = 2
        DLGT = 3
        STRP = 4
        AKCP = 5
        TXCP = 6
        MRPR = 7
        AQPR = 8
        VDPR = 9
        SWPK = 10
    }
    class ISO20022.Caaa026001.DataSetIdentification5 {
        + CreDtTm  : DateTime
        + Vrsn  : String
        + Tp  : String
        + Nm  : String
    }
    class ISO20022.Caaa026001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Caaa026001.DetailedAmount15 {
        + Srchrg  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DetailedAmount4~
        + ValAddedTax  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DetailedAmount4~
        + Rbt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DetailedAmount4~
        + Fees  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DetailedAmount4~
        + Grtty  : Decimal
        + CshBck  : Decimal
        + AmtGoodsAndSvcs  : Decimal
    }
    ISO20022.Caaa026001.DetailedAmount15 *-- ISO20022.Caaa026001.DetailedAmount4
    ISO20022.Caaa026001.DetailedAmount15 *-- ISO20022.Caaa026001.DetailedAmount4
    ISO20022.Caaa026001.DetailedAmount15 *-- ISO20022.Caaa026001.DetailedAmount4
    ISO20022.Caaa026001.DetailedAmount15 *-- ISO20022.Caaa026001.DetailedAmount4
    class ISO20022.Caaa026001.DetailedAmount21 {
        + Labl  : String
        + ICCRltdData  : String
        + CardDataNtryMd  : String
        + DtTm  : DateTime
        + Amt  : Decimal
    }
    class ISO20022.Caaa026001.DetailedAmount4 {
        + Labl  : String
        + Amt  : Decimal
    }
    class ISO20022.Caaa026001.DigestedData6 {
        + Dgst  : String
        + NcpsltdCntt  : ISO20022.Caaa026001.EncapsulatedContent3
        + DgstAlgo  : ISO20022.Caaa026001.AlgorithmIdentification36
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.DigestedData6 *-- ISO20022.Caaa026001.EncapsulatedContent3
    ISO20022.Caaa026001.DigestedData6 *-- ISO20022.Caaa026001.AlgorithmIdentification36
    class ISO20022.Caaa026001.DirectDebitContext1 {
        + MndtRltdInf  : ISO20022.Caaa026001.MandateRelatedInformation17
        + PrtctdCdtrAcct  : ISO20022.Caaa026001.ContentInformationType39
        + CdtrAcct  : ISO20022.Caaa026001.CashAccount40
        + Cdtr  : ISO20022.Caaa026001.PartyIdentification272
        + PrtctdDbtrAcct  : ISO20022.Caaa026001.ContentInformationType39
        + DbtrAcct  : ISO20022.Caaa026001.CashAccount40
        + Dbtr  : ISO20022.Caaa026001.PartyIdentification272
    }
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.MandateRelatedInformation17
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.ContentInformationType39
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.CashAccount40
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.PartyIdentification272
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.ContentInformationType39
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.CashAccount40
    ISO20022.Caaa026001.DirectDebitContext1 *-- ISO20022.Caaa026001.PartyIdentification272
    class ISO20022.Caaa026001.DisplayCapabilities4 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa026001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Caaa026001.EncryptedContent7 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Caaa026001.AlgorithmIdentification32
        + CnttTp  : String
    }
    ISO20022.Caaa026001.EncryptedContent7 *-- ISO20022.Caaa026001.AlgorithmIdentification32
    class ISO20022.Caaa026001.EncryptionFormat2Code {
        I238 = 1
        TR34 = 2
        TR31 = 3
    }
    class ISO20022.Caaa026001.EnvelopedData11 {
        + NcrptdCntt  : ISO20022.Caaa026001.EncryptedContent7
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Recipient15Choice~
        + OrgtrInf  : ISO20022.Caaa026001.OriginatorInformation1
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.EnvelopedData11 *-- ISO20022.Caaa026001.EncryptedContent7
    ISO20022.Caaa026001.EnvelopedData11 *-- ISO20022.Caaa026001.Recipient15Choice
    ISO20022.Caaa026001.EnvelopedData11 *-- ISO20022.Caaa026001.OriginatorInformation1
    class ISO20022.Caaa026001.Exemption1Code {
        TMBE = 1
        PKGE = 2
        TRAE = 3
        SCAD = 4
        SCPE = 5
        RECP = 6
        MINT = 7
        LOWA = 8
    }
    class ISO20022.Caaa026001.ExternallyDefinedData5 {
        + Tp  : String
        + PrtctdVal  : ISO20022.Caaa026001.ContentInformationType39
        + Val  : String
        + Id  : String
    }
    ISO20022.Caaa026001.ExternallyDefinedData5 *-- ISO20022.Caaa026001.ContentInformationType39
    class ISO20022.Caaa026001.FailureReason3Code {
        SECU = 1
        USND = 2
        UCMP = 3
        LATE = 4
        TIMO = 5
        SFRD = 6
        PART = 7
        NDCL = 8
        FDCL = 9
        MALF = 10
        CUCL = 11
        CDCL = 12
    }
    class ISO20022.Caaa026001.Frequency3Code {
        TEND = 1
        DAIL = 2
        WEEK = 3
        MIAN = 4
        QURT = 5
        MNTH = 6
        YEAR = 7
    }
    class ISO20022.Caaa026001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Caaa026001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Caaa026001.GenericAccountIdentification1 *-- ISO20022.Caaa026001.AccountSchemeName1Choice
    class ISO20022.Caaa026001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification176 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification177 {
        + Glctn  : ISO20022.Caaa026001.Geolocation1
        + RmotAccs  : ISO20022.Caaa026001.NetworkParameters7
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    ISO20022.Caaa026001.GenericIdentification177 *-- ISO20022.Caaa026001.Geolocation1
    ISO20022.Caaa026001.GenericIdentification177 *-- ISO20022.Caaa026001.NetworkParameters7
    class ISO20022.Caaa026001.GenericIdentification186 {
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification32 {
        + ShrtNm  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification4 {
        + IdTp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification48 {
        + Issr  : String
        + Vrsn  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericIdentification90 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caaa026001.GenericInformation1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Caaa026001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Caaa026001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Caaa026001.GenericOrganisationIdentification3 *-- ISO20022.Caaa026001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Caaa026001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Caaa026001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Caaa026001.GenericPersonIdentification2 *-- ISO20022.Caaa026001.PersonIdentificationSchemeName1Choice
    class ISO20022.Caaa026001.Geolocation1 {
        + UTMCordints  : ISO20022.Caaa026001.GeolocationUTMCoordinates1
        + GeogcCordints  : ISO20022.Caaa026001.GeolocationGeographicCoordinates1
    }
    ISO20022.Caaa026001.Geolocation1 *-- ISO20022.Caaa026001.GeolocationUTMCoordinates1
    ISO20022.Caaa026001.Geolocation1 *-- ISO20022.Caaa026001.GeolocationGeographicCoordinates1
    class ISO20022.Caaa026001.GeolocationGeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Caaa026001.GeolocationUTMCoordinates1 {
        + UTMNrthwrd  : String
        + UTMEstwrd  : String
        + UTMZone  : String
    }
    class ISO20022.Caaa026001.GracePeriod1 {
        + OthrUnitTp  : String
        + UnitTp  : String
        + Tm  : String
    }
    class ISO20022.Caaa026001.GracePeriodUnitType1Code {
        DAYS = 1
        MNTH = 2
        OTHN = 3
        OTHP = 4
        PMTS = 5
        WEKS = 6
    }
    class ISO20022.Caaa026001.Header56 {
        + RcptPty  : ISO20022.Caaa026001.GenericIdentification177
        + InitgPty  : ISO20022.Caaa026001.GenericIdentification176
        + CreDtTm  : DateTime
        + XchgId  : Decimal
        + FrmtVrsn  : String
        + DwnldTrf  : String
    }
    ISO20022.Caaa026001.Header56 *-- ISO20022.Caaa026001.GenericIdentification177
    ISO20022.Caaa026001.Header56 *-- ISO20022.Caaa026001.GenericIdentification176
    class ISO20022.Caaa026001.InformationQualify1Code {
        VCHR = 1
        STAT = 2
        SOND = 3
        RCPT = 4
        POIR = 5
        INPT = 6
        ERRO = 7
        DOCT = 8
        DISP = 9
        CUSA = 10
    }
    class ISO20022.Caaa026001.Instalment5 {
        + PlanNtce  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ActionMessage11~
        + GracePrd  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GracePeriod1~
        + IntrstRate  : global::System.Collections.Generic.List~ISO20022.Caaa026001.InterestRateDetails1~
        + DtldChrgs  : global::System.Collections.Generic.List~ISO20022.Caaa026001.InstalmentAmountDetails1~
        + Chrgs  : Decimal
        + LastAmt  : Decimal
        + SbsqntAmt  : Decimal
        + FrstAmt  : Decimal
        + TtlAmt  : ISO20022.Caaa026001.ActiveCurrencyAndAmount
        + FrstPmtDt  : DateTime
        + TtlNbOfPmts  : Decimal
        + InstlmtPrd  : Decimal
        + PrdUnit  : String
        + SeqNb  : Decimal
        + PlanOwnr  : String
        + PlanId  : String
        + InstlmtPlan  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Caaa026001.Instalment5 *-- ISO20022.Caaa026001.ActionMessage11
    ISO20022.Caaa026001.Instalment5 *-- ISO20022.Caaa026001.GracePeriod1
    ISO20022.Caaa026001.Instalment5 *-- ISO20022.Caaa026001.InterestRateDetails1
    ISO20022.Caaa026001.Instalment5 *-- ISO20022.Caaa026001.InstalmentAmountDetails1
    ISO20022.Caaa026001.Instalment5 *-- ISO20022.Caaa026001.ActiveCurrencyAndAmount
    class ISO20022.Caaa026001.InstalmentAmountDetails1 {
        + Pctg  : Decimal
        + Amt  : ISO20022.Caaa026001.Amount5
        + SubTp  : String
        + OthrTp  : String
        + Tp  : String
    }
    ISO20022.Caaa026001.InstalmentAmountDetails1 *-- ISO20022.Caaa026001.Amount5
    class ISO20022.Caaa026001.InstalmentAmountDetailsType1Code {
        AFCO = 1
        EXPN = 2
        FEES = 3
        FUNA = 4
        INSU = 5
        OTHC = 6
        OTHN = 7
        OTHP = 8
        RQST = 9
        TAXX = 10
    }
    class ISO20022.Caaa026001.InstalmentPeriod1Code {
        ANNU = 1
        MNTH = 2
    }
    class ISO20022.Caaa026001.InstalmentPlan1Code {
        DFRI = 1
        NQPM = 2
        EQPM = 3
    }
    class ISO20022.Caaa026001.InterestRate1Code {
        OTHP = 1
        OTHN = 2
        NTRT = 3
        GSRT = 4
    }
    class ISO20022.Caaa026001.InterestRateDetails1 {
        + Rate  : Decimal
        + Prd  : String
        + OthrTp  : String
        + Tp  : String
    }
    class ISO20022.Caaa026001.IssuerAndSerialNumber2 {
        + SrlNb  : String
        + Issr  : ISO20022.Caaa026001.CertificateIssuer1
    }
    ISO20022.Caaa026001.IssuerAndSerialNumber2 *-- ISO20022.Caaa026001.CertificateIssuer1
    class ISO20022.Caaa026001.KEK9 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caaa026001.AlgorithmIdentification32
        + KEKId  : ISO20022.Caaa026001.KEKIdentifier7
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.KEK9 *-- ISO20022.Caaa026001.AlgorithmIdentification32
    ISO20022.Caaa026001.KEK9 *-- ISO20022.Caaa026001.KEKIdentifier7
    class ISO20022.Caaa026001.KEKIdentifier7 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caaa026001.KeyTransport10 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caaa026001.AlgorithmIdentification35
        + RcptId  : ISO20022.Caaa026001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.KeyTransport10 *-- ISO20022.Caaa026001.AlgorithmIdentification35
    ISO20022.Caaa026001.KeyTransport10 *-- ISO20022.Caaa026001.Recipient13Choice
    class ISO20022.Caaa026001.KeyUsage1Code {
        KEYD = 1
        KEYX = 2
        KEYI = 3
        KEYG = 4
        PINV = 5
        PIND = 6
        PINE = 7
        SUGV = 8
        SIGG = 9
        MACV = 10
        MACG = 11
        TRNX = 12
        TRNI = 13
        DDEC = 14
        DENC = 15
        DCPT = 16
        ENCR = 17
    }
    class ISO20022.Caaa026001.LocationCategory3Code {
        VNDG = 1
        SSLE = 2
        MSLE = 3
        MPMP = 4
        MPOI = 5
        IPMP = 6
        INDR = 7
    }
    class ISO20022.Caaa026001.LocationCategory4Code {
        VIRT = 1
        FIXD = 2
        NMDC = 3
        ABRD = 4
    }
    class ISO20022.Caaa026001.LoyaltyAccount3 {
        + Bal  : Decimal
        + Ccy  : String
        + Unit  : String
        + OwnrNm  : String
        + Prvdr  : String
        + Brnd  : String
        + IdTp  : String
        + NtryMd  : String
        + LltyId  : String
    }
    class ISO20022.Caaa026001.LoyaltyHandling1Code {
        REQU = 1
        PROP = 2
        PRCS = 3
        DENY = 4
        ALLO = 5
    }
    class ISO20022.Caaa026001.MandateRelatedInformation17 {
        + PrtctdMndtImg  : ISO20022.Caaa026001.ContentInformationType39
        + MndtImg  : String
        + DtOfSgntr  : DateTime
        + MndtId  : String
    }
    ISO20022.Caaa026001.MandateRelatedInformation17 *-- ISO20022.Caaa026001.ContentInformationType39
    class ISO20022.Caaa026001.MemoryCharacteristics1 {
        + Unit  : String
        + FreeSz  : Decimal
        + TtlSz  : Decimal
        + Id  : String
    }
    class ISO20022.Caaa026001.MemoryUnit1Code {
        TERA = 1
        PETA = 2
        MEGA = 3
        KILO = 4
        GIGA = 5
        EXAB = 6
        BYTE = 7
    }
    class ISO20022.Caaa026001.MerchantToken2 {
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknAssrncLvl  : Decimal
        + TknRqstr  : ISO20022.Caaa026001.PaymentTokenIdentifiers1
        + TknChrtc  : global::System.Collections.Generic.List~String~
        + TknXpryDt  : String
        + Tkn  : String
    }
    ISO20022.Caaa026001.MerchantToken2 *-- ISO20022.Caaa026001.PaymentTokenIdentifiers1
    class ISO20022.Caaa026001.MobileData6 {
        + PrtctdMobData  : ISO20022.Caaa026001.ContentInformationType40
        + SnstvMobData  : ISO20022.Caaa026001.SensitiveMobileData1
        + Glctn  : ISO20022.Caaa026001.Geolocation1
        + MobMskdMSISDN  : String
        + MobNtwkCd  : String
        + MobCtryCd  : String
    }
    ISO20022.Caaa026001.MobileData6 *-- ISO20022.Caaa026001.ContentInformationType40
    ISO20022.Caaa026001.MobileData6 *-- ISO20022.Caaa026001.SensitiveMobileData1
    ISO20022.Caaa026001.MobileData6 *-- ISO20022.Caaa026001.Geolocation1
    class ISO20022.Caaa026001.NameAndAddress3 {
        + Adr  : ISO20022.Caaa026001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Caaa026001.NameAndAddress3 *-- ISO20022.Caaa026001.PostalAddress1
    class ISO20022.Caaa026001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Caaa026001.NetworkParameters7 {
        + SctyPrfl  : String
        + ClntCert  : global::System.Collections.Generic.List~String~
        + SvrCertIdr  : global::System.Collections.Generic.List~String~
        + SvrCert  : global::System.Collections.Generic.List~String~
        + AccsCd  : String
        + UsrNm  : String
        + Adr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.NetworkParameters9~
    }
    ISO20022.Caaa026001.NetworkParameters7 *-- ISO20022.Caaa026001.NetworkParameters9
    class ISO20022.Caaa026001.NetworkParameters9 {
        + AdrVal  : String
        + NtwkTp  : String
    }
    class ISO20022.Caaa026001.NetworkType1Code {
        PSTN = 1
        IPNW = 2
    }
    class ISO20022.Caaa026001.OnLineCapability1Code {
        SMON = 1
        ONLN = 2
        OFLN = 3
    }
    class ISO20022.Caaa026001.OnLinePIN11 {
        + AddtlInpt  : String
        + PINFrmt  : String
        + NcrptdPINBlck  : ISO20022.Caaa026001.ContentInformationType40
    }
    ISO20022.Caaa026001.OnLinePIN11 *-- ISO20022.Caaa026001.ContentInformationType40
    class ISO20022.Caaa026001.OnLineReason2Code {
        IFPR = 1
        CRCY = 2
        FLOW = 3
        CPAN = 4
        UBIN = 5
        CBIN = 6
        TAMT = 7
        EXFL = 8
        FRLT = 9
        ISSF = 10
        TRMF = 11
        MERF = 12
        ICCF = 13
        RNDM = 14
    }
    class ISO20022.Caaa026001.Organisation26 {
        + RegdIdr  : String
        + MrchntCtgyCd  : String
        + CtryCd  : String
        + Adr  : String
        + CmonNm  : String
    }
    class ISO20022.Caaa026001.Organisation41 {
        + SchmeData  : String
        + LctnAndCtct  : ISO20022.Caaa026001.CommunicationAddress9
        + LctnCtgy  : String
        + CmonNm  : String
        + Id  : ISO20022.Caaa026001.GenericIdentification32
    }
    ISO20022.Caaa026001.Organisation41 *-- ISO20022.Caaa026001.CommunicationAddress9
    ISO20022.Caaa026001.Organisation41 *-- ISO20022.Caaa026001.GenericIdentification32
    class ISO20022.Caaa026001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Caaa026001.OrganisationIdentification39 *-- ISO20022.Caaa026001.GenericOrganisationIdentification3
    class ISO20022.Caaa026001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Caaa026001.OriginalAmountDetails1 {
        + MaxAmt  : Decimal
        + MinAmt  : Decimal
        + ActlAmt  : Decimal
    }
    class ISO20022.Caaa026001.OriginatorInformation1 {
        + Cert  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa026001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Caaa026001.OutputBarcode2 {
        + QRCdErrCrrctn  : String
        + QRCdNcodgMd  : String
        + QRCdVrsn  : String
        + QRCdBinryVal  : String
        + BrcdVal  : String
        + BrcdTp  : String
    }
    class ISO20022.Caaa026001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Caaa026001.OutputFormat3Code {
        HTML = 1
        TEXT = 2
        SREF = 3
        MREF = 4
        MENT = 5
        BARC = 6
    }
    class ISO20022.Caaa026001.PINFormat3Code {
        ISO5 = 1
        ISO4 = 2
        ISO3 = 3
        ISO2 = 4
        ISO1 = 5
        ISO0 = 6
    }
    class ISO20022.Caaa026001.POICommunicationType2Code {
        WT5G = 1
        WT4G = 2
        WT3G = 3
        WT2G = 4
        WIFI = 5
        USBH = 6
        USBD = 7
        RS23 = 8
        PSTN = 9
        GSMF = 10
        GPRS = 11
        ETHR = 12
        BLTH = 13
    }
    class ISO20022.Caaa026001.POIComponentAssessment1Code {
        EVAL = 1
        CERT = 2
        APPL = 3
    }
    class ISO20022.Caaa026001.POIComponentStatus1Code {
        DACT = 1
        OPER = 2
        OUTD = 3
        WAIT = 4
    }
    class ISO20022.Caaa026001.POIComponentType7Code {
        PROB = 1
        RPFL = 2
        CONF = 3
        SOFT = 4
        MDFL = 5
        LOGF = 6
        SAPR = 7
        SACP = 8
        TMSP = 9
        CRTF = 10
        MRPR = 11
        OPST = 12
        DRVR = 13
        MDWR = 14
        EMVO = 15
        EMVK = 16
        APLI = 17
        SECM = 18
        DVCE = 19
        TERM = 20
        SERV = 21
        SCPR = 22
        TLPR = 23
        APPR = 24
        AQPP = 25
    }
    class ISO20022.Caaa026001.PackageType5 {
        + PackgBlck  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ExternallyDefinedData5~
        + OffsetEnd  : Decimal
        + OffsetStart  : Decimal
        + PackgLngth  : Decimal
        + PackgId  : ISO20022.Caaa026001.GenericIdentification176
    }
    ISO20022.Caaa026001.PackageType5 *-- ISO20022.Caaa026001.ExternallyDefinedData5
    ISO20022.Caaa026001.PackageType5 *-- ISO20022.Caaa026001.GenericIdentification176
    class ISO20022.Caaa026001.Parameter12 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Caaa026001.Parameter16 {
        + OIDCrvNm  : String
        + TrlrFld  : Decimal
        + SaltLngth  : Decimal
        + MskGnrtrAlgo  : ISO20022.Caaa026001.AlgorithmIdentification34
        + DgstAlgo  : String
    }
    ISO20022.Caaa026001.Parameter16 *-- ISO20022.Caaa026001.AlgorithmIdentification34
    class ISO20022.Caaa026001.Parameter17 {
        + MskGnrtrAlgo  : ISO20022.Caaa026001.AlgorithmIdentification34
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Caaa026001.Parameter17 *-- ISO20022.Caaa026001.AlgorithmIdentification34
    class ISO20022.Caaa026001.Parameter18 {
        + DgstAlgo  : String
    }
    class ISO20022.Caaa026001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Caaa026001.Party52Choice {
        + PrvtId  : ISO20022.Caaa026001.PersonIdentification18
        + OrgId  : ISO20022.Caaa026001.OrganisationIdentification39
    }
    ISO20022.Caaa026001.Party52Choice *-- ISO20022.Caaa026001.PersonIdentification18
    ISO20022.Caaa026001.Party52Choice *-- ISO20022.Caaa026001.OrganisationIdentification39
    class ISO20022.Caaa026001.PartyIdentification177Choice {
        + PrtryId  : ISO20022.Caaa026001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Caaa026001.PartyIdentification177Choice *-- ISO20022.Caaa026001.GenericIdentification1
    class ISO20022.Caaa026001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Caaa026001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Caaa026001.Party52Choice
        + PstlAdr  : ISO20022.Caaa026001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Caaa026001.PartyIdentification272 *-- ISO20022.Caaa026001.Contact13
    ISO20022.Caaa026001.PartyIdentification272 *-- ISO20022.Caaa026001.Party52Choice
    ISO20022.Caaa026001.PartyIdentification272 *-- ISO20022.Caaa026001.PostalAddress27
    class ISO20022.Caaa026001.PartyType14Code {
        ICCA = 1
        DLIS = 2
        CISS = 3
        ACQR = 4
        ITAG = 5
        ACCP = 6
        MERC = 7
        OPOI = 8
    }
    class ISO20022.Caaa026001.PartyType33Code {
        TMGT = 1
        TAXH = 2
        MTMG = 3
        DLIS = 4
        CISS = 5
        ACQR = 6
        ITAG = 7
        ACCP = 8
        MERC = 9
        OPOI = 10
    }
    class ISO20022.Caaa026001.PartyType3Code {
        DLIS = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
        OPOI = 7
    }
    class ISO20022.Caaa026001.PartyType4Code {
        TAXH = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
    }
    class ISO20022.Caaa026001.PartyType7Code {
        SALE = 1
        TMGT = 2
        PCPT = 3
        ITAG = 4
        ACQR = 5
    }
    class ISO20022.Caaa026001.PaymentCard35 {
        + AddtlCardData  : String
        + SvcOptn  : String
        + AllwdPdct  : global::System.Collections.Generic.List~String~
        + IntrnlCard  : String
        + CardPdctSubTp  : String
        + CardPdctTp  : String
        + CardBrnd  : String
        + CardPdctPrfl  : String
        + CardCcyCd  : String
        + CardCtryCd  : String
        + IssrBIN  : String
        + MskdPAN  : String
        + PmtAcctRef  : String
        + PlainCardData  : ISO20022.Caaa026001.PlainCardData22
        + PrvtCardData  : String
        + PrtctdCardData  : ISO20022.Caaa026001.ContentInformationType40
    }
    ISO20022.Caaa026001.PaymentCard35 *-- ISO20022.Caaa026001.PlainCardData22
    ISO20022.Caaa026001.PaymentCard35 *-- ISO20022.Caaa026001.ContentInformationType40
    class ISO20022.Caaa026001.PaymentContext29 {
        + SpprtdOptn  : global::System.Collections.Generic.List~String~
        + FllbckInd  : String
        + CardDataNtryMd  : String
        + AttndntLang  : String
        + AttndntMsgCpbl  : String
        + BizArea  : String
        + TxChanl  : String
        + TxEnvt  : String
        + AttndncCntxt  : String
        + OnLineCntxt  : String
        + CrdhldrPres  : String
        + CardPres  : String
    }
    class ISO20022.Caaa026001.PaymentContext30 {
        + DrctDbtCntxt  : ISO20022.Caaa026001.DirectDebitContext1
        + CdtTrfCntxt  : ISO20022.Caaa026001.CreditTransferContext1
        + SaleCntxt  : ISO20022.Caaa026001.SaleContext4
        + PmtCntxt  : ISO20022.Caaa026001.PaymentContext29
    }
    ISO20022.Caaa026001.PaymentContext30 *-- ISO20022.Caaa026001.DirectDebitContext1
    ISO20022.Caaa026001.PaymentContext30 *-- ISO20022.Caaa026001.CreditTransferContext1
    ISO20022.Caaa026001.PaymentContext30 *-- ISO20022.Caaa026001.SaleContext4
    ISO20022.Caaa026001.PaymentContext30 *-- ISO20022.Caaa026001.PaymentContext29
    class ISO20022.Caaa026001.PaymentTokenIdentifiers1 {
        + RqstrId  : String
        + PrvdrId  : String
    }
    class ISO20022.Caaa026001.PersonIdentification15 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericIdentification4~
        + DtAndPlcOfBirth  : ISO20022.Caaa026001.DateAndPlaceOfBirth1
        + EmailAdr  : String
        + Dept  : String
        + JobNb  : String
        + MplyeeIdNb  : String
        + MplyrIdNb  : String
        + IdntyCardNb  : String
        + TaxIdNb  : String
        + PsptNb  : String
        + AlnRegnNb  : String
        + SclSctyNb  : String
        + CstmrNb  : String
        + DrvrId  : String
        + DrvrLicNm  : String
        + DrvrLicLctn  : String
        + DrvrLicNb  : String
    }
    ISO20022.Caaa026001.PersonIdentification15 *-- ISO20022.Caaa026001.GenericIdentification4
    ISO20022.Caaa026001.PersonIdentification15 *-- ISO20022.Caaa026001.DateAndPlaceOfBirth1
    class ISO20022.Caaa026001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Caaa026001.DateAndPlaceOfBirth1
    }
    ISO20022.Caaa026001.PersonIdentification18 *-- ISO20022.Caaa026001.GenericPersonIdentification2
    ISO20022.Caaa026001.PersonIdentification18 *-- ISO20022.Caaa026001.DateAndPlaceOfBirth1
    class ISO20022.Caaa026001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Caaa026001.PhysicalInterfaceParameter1 {
        + AddtlParams  : String
        + SctyPrfl  : String
        + AccsCd  : String
        + UsrNm  : String
        + IntrfcTp  : String
        + IntrfcNm  : String
    }
    class ISO20022.Caaa026001.PlainCardData17 {
        + NtryMd  : String
        + AddtlCardData  : global::System.Collections.Generic.List~String~
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + PAN  : String
    }
    class ISO20022.Caaa026001.PlainCardData22 {
        + CrdhldrNm  : String
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + SvcCd  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    class ISO20022.Caaa026001.PlanOwner1Code {
        OTHP = 1
        OTHN = 2
        ISSR = 3
        ACQR = 4
        ACCP = 5
    }
    class ISO20022.Caaa026001.PointOfInteraction15 {
        + Cmpnt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.PointOfInteractionComponent17~
        + TermnlIntgtn  : String
        + TmZone  : String
        + Cpblties  : ISO20022.Caaa026001.PointOfInteractionCapabilities9
        + GrpId  : String
        + SysNm  : String
        + Id  : ISO20022.Caaa026001.GenericIdentification177
    }
    ISO20022.Caaa026001.PointOfInteraction15 *-- ISO20022.Caaa026001.PointOfInteractionComponent17
    ISO20022.Caaa026001.PointOfInteraction15 *-- ISO20022.Caaa026001.PointOfInteractionCapabilities9
    ISO20022.Caaa026001.PointOfInteraction15 *-- ISO20022.Caaa026001.GenericIdentification177
    class ISO20022.Caaa026001.PointOfInteractionCapabilities9 {
        + MsgCpblties  : global::System.Collections.Generic.List~ISO20022.Caaa026001.DisplayCapabilities4~
        + OnLineCpblties  : String
        + CardCaptrCpbl  : String
        + MxScrptLngth  : Decimal
        + ApprvlCdLngth  : Decimal
        + PINLngthCpblties  : Decimal
        + CrdhldrVrfctnCpblties  : global::System.Collections.Generic.List~String~
        + CardRdngCpblties  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Caaa026001.PointOfInteractionCapabilities9 *-- ISO20022.Caaa026001.DisplayCapabilities4
    class ISO20022.Caaa026001.PointOfInteractionComponent17 {
        + PrbVal  : String
        + Packg  : global::System.Collections.Generic.List~ISO20022.Caaa026001.PackageType5~
        + Assmnt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.PointOfInteractionComponentAssessment1~
        + Chrtcs  : ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10
        + StdCmplc  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericIdentification48~
        + Sts  : ISO20022.Caaa026001.PointOfInteractionComponentStatus3
        + Id  : ISO20022.Caaa026001.PointOfInteractionComponentIdentification2
        + SubTpInf  : String
        + Tp  : String
    }
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.PackageType5
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.PointOfInteractionComponentAssessment1
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.GenericIdentification48
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.PointOfInteractionComponentStatus3
    ISO20022.Caaa026001.PointOfInteractionComponent17 *-- ISO20022.Caaa026001.PointOfInteractionComponentIdentification2
    class ISO20022.Caaa026001.PointOfInteractionComponentAssessment1 {
        + Nb  : String
        + XprtnDt  : DateTime
        + DlvryDt  : DateTime
        + Assgnr  : global::System.Collections.Generic.List~String~
        + Tp  : String
    }
    class ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10 {
        + SctyElmt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.CryptographicKey18~
        + SbcbrIdntyMdls  : Decimal
        + SctyAccsMdls  : Decimal
        + Com  : global::System.Collections.Generic.List~ISO20022.Caaa026001.CommunicationCharacteristics5~
        + Mmry  : global::System.Collections.Generic.List~ISO20022.Caaa026001.MemoryCharacteristics1~
    }
    ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa026001.CryptographicKey18
    ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa026001.CommunicationCharacteristics5
    ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10 *-- ISO20022.Caaa026001.MemoryCharacteristics1
    class ISO20022.Caaa026001.PointOfInteractionComponentIdentification2 {
        + SrlNb  : String
        + Id  : String
        + PrvdrId  : String
        + ItmNb  : String
    }
    class ISO20022.Caaa026001.PointOfInteractionComponentStatus3 {
        + XpryDt  : DateTime
        + Sts  : String
        + VrsnNb  : String
    }
    class ISO20022.Caaa026001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Caaa026001.PostalAddress22 {
        + CtryCd  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Caaa026001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Caaa026001.AddressType3Choice
    }
    ISO20022.Caaa026001.PostalAddress27 *-- ISO20022.Caaa026001.AddressType3Choice
    class ISO20022.Caaa026001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Caaa026001.ProcessRetry3 {
        + UnitOfTm  : String
        + MaxNb  : Decimal
        + Dely  : String
    }
    class ISO20022.Caaa026001.ProcessTiming6 {
        + UnitOfTm  : String
        + Prd  : String
        + EndTm  : DateTime
        + StartTm  : DateTime
    }
    class ISO20022.Caaa026001.Product4 {
        + AddtlPdctCd  : String
        + PdctCd  : String
    }
    class ISO20022.Caaa026001.Product5 {
        + UnitOfMeasr  : String
        + QtyLmt  : Decimal
        + AmtLmt  : Decimal
        + AddtlPdctCd  : String
        + PdctCd  : String
    }
    class ISO20022.Caaa026001.Product6 {
        + AddtlPdctDesc  : String
        + SaleChanl  : String
        + DlvrySvc  : String
        + DlvryLctn  : String
        + PdctDesc  : String
        + TaxTp  : String
        + ValAddedTax  : Decimal
        + PdctAmtSgn  : String
        + PdctAmt  : Decimal
        + UnitPricSgn  : String
        + UnitPric  : Decimal
        + PdctQty  : Decimal
        + UnitOfMeasr  : String
        + AddtlPdctCd  : String
        + PdctCd  : String
        + ItmId  : String
    }
    class ISO20022.Caaa026001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Caaa026001.ProxyAccountType1Choice
    }
    ISO20022.Caaa026001.ProxyAccountIdentification1 *-- ISO20022.Caaa026001.ProxyAccountType1Choice
    class ISO20022.Caaa026001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Caaa026001.QRCodeEncodingMode1Code {
        NUME = 1
        KANJ = 2
        BINA = 3
        ALFA = 4
    }
    class ISO20022.Caaa026001.QRCodeErrorCorrection1Code {
        L007 = 1
        H030 = 2
        Q025 = 3
        M015 = 4
    }
    class ISO20022.Caaa026001.Recipient13Choice {
        + SbjtKeyIdr  : String
        + IssrAndSrlNb  : ISO20022.Caaa026001.IssuerAndSerialNumber2
    }
    ISO20022.Caaa026001.Recipient13Choice *-- ISO20022.Caaa026001.IssuerAndSerialNumber2
    class ISO20022.Caaa026001.Recipient15Choice {
        + KeyIdr  : ISO20022.Caaa026001.KEKIdentifier7
        + KEK  : ISO20022.Caaa026001.KEK9
        + KeyTrnsprt  : ISO20022.Caaa026001.KeyTransport10
    }
    ISO20022.Caaa026001.Recipient15Choice *-- ISO20022.Caaa026001.KEKIdentifier7
    ISO20022.Caaa026001.Recipient15Choice *-- ISO20022.Caaa026001.KEK9
    ISO20022.Caaa026001.Recipient15Choice *-- ISO20022.Caaa026001.KeyTransport10
    class ISO20022.Caaa026001.RecurringTransaction6 {
        + PlanNtce  : global::System.Collections.Generic.List~ISO20022.Caaa026001.ActionMessage11~
        + GracePrd  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GracePeriod1~
        + PrdUnit  : String
        + SeqNb  : Decimal
        + PlanId  : String
    }
    ISO20022.Caaa026001.RecurringTransaction6 *-- ISO20022.Caaa026001.ActionMessage11
    ISO20022.Caaa026001.RecurringTransaction6 *-- ISO20022.Caaa026001.GracePeriod1
    class ISO20022.Caaa026001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Caaa026001.Response9Code {
        TECH = 1
        SUSP = 2
        PART = 3
        DECL = 4
        APPR = 5
    }
    class ISO20022.Caaa026001.ResponseType10 {
        + AddtlRspnInf  : String
        + RspnRsn  : String
        + Rspn  : String
    }
    class ISO20022.Caaa026001.RetailerSaleEnvironment2 {
        + LltyHdlg  : String
        + DbtPrefrdFlg  : String
        + MinSpltAmt  : Decimal
        + MaxCshBckAmt  : Decimal
        + MinAmtToDlvr  : Decimal
        + Ccy  : String
        + SaleCpblties  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caaa026001.SaleCapabilities1Code {
        PRVC = 1
        PRRP = 2
        PRDC = 3
        POIR = 4
        CUIN = 5
        CUER = 6
        CUAS = 7
        CUDI = 8
        CHST = 9
        CHIN = 10
        CHER = 11
        CHDI = 12
    }
    class ISO20022.Caaa026001.SaleContext4 {
        + AddtlSaleData  : String
        + SaleTknScp  : String
        + AllwdNtryMd  : global::System.Collections.Generic.List~String~
        + ReuseCardDataFlg  : String
        + ForceOnlnFlg  : String
        + RmngAmt  : Decimal
        + SpltPmt  : String
        + SpnsrdMrchnt  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Organisation26~
        + DlvryNoteNb  : String
        + InvcNb  : String
        + PurchsOrdrNb  : String
        + CstmrOrdrReqFlg  : String
        + ShftNb  : String
        + CshrLang  : global::System.Collections.Generic.List~String~
        + CshrId  : String
        + SaleRcncltnId  : String
        + SaleRefNb  : String
        + SaleId  : String
    }
    ISO20022.Caaa026001.SaleContext4 *-- ISO20022.Caaa026001.Organisation26
    class ISO20022.Caaa026001.SaleTokenScope1Code {
        SNGL = 1
        MULT = 2
    }
    class ISO20022.Caaa026001.SensitiveMobileData1 {
        + IMEI  : String
        + IMSI  : String
        + MSISDN  : String
    }
    class ISO20022.Caaa026001.SignedData9 {
        + Sgnr  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Signer8~
        + Cert  : global::System.Collections.Generic.List~String~
        + NcpsltdCntt  : ISO20022.Caaa026001.EncapsulatedContent3
        + DgstAlgo  : global::System.Collections.Generic.List~ISO20022.Caaa026001.AlgorithmIdentification36~
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.SignedData9 *-- ISO20022.Caaa026001.Signer8
    ISO20022.Caaa026001.SignedData9 *-- ISO20022.Caaa026001.EncapsulatedContent3
    ISO20022.Caaa026001.SignedData9 *-- ISO20022.Caaa026001.AlgorithmIdentification36
    class ISO20022.Caaa026001.Signer8 {
        + Sgntr  : String
        + SgntrAlgo  : ISO20022.Caaa026001.AlgorithmIdentification33
        + SgndAttrbts  : global::System.Collections.Generic.List~ISO20022.Caaa026001.GenericInformation1~
        + DgstAlgo  : ISO20022.Caaa026001.AlgorithmIdentification36
        + SgnrId  : ISO20022.Caaa026001.Recipient13Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caaa026001.Signer8 *-- ISO20022.Caaa026001.AlgorithmIdentification33
    ISO20022.Caaa026001.Signer8 *-- ISO20022.Caaa026001.GenericInformation1
    ISO20022.Caaa026001.Signer8 *-- ISO20022.Caaa026001.AlgorithmIdentification36
    ISO20022.Caaa026001.Signer8 *-- ISO20022.Caaa026001.Recipient13Choice
    class ISO20022.Caaa026001.StoredValueAccount2 {
        + Bal  : Decimal
        + Ccy  : String
        + NtryMd  : String
        + XpryDt  : String
        + OwnrNm  : String
        + Prvdr  : String
        + Brnd  : String
        + Id  : String
        + IdTp  : String
        + AcctTp  : String
    }
    class ISO20022.Caaa026001.StoredValueAccountType1Code {
        TRVL = 1
        CARD = 2
        PHON = 3
        OTHR = 4
        MERC = 5
        OLVC = 6
        MLVC = 7
        GCER = 8
        GIFT = 9
        ELMY = 10
        CPYA = 11
        CWVC = 12
        BNKA = 13
    }
    class ISO20022.Caaa026001.SupplementaryData1 {
        + Envlp  : ISO20022.Caaa026001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Caaa026001.SupplementaryData1 *-- ISO20022.Caaa026001.SupplementaryDataEnvelope1
    class ISO20022.Caaa026001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Caaa026001.SupportedPaymentOption2Code {
        PINQ = 1
        INSI = 2
        MSRV = 3
        PART = 4
    }
    class ISO20022.Caaa026001.TMSContactLevel1Code {
        DTIM = 1
        ASAP = 2
        CRIT = 3
    }
    class ISO20022.Caaa026001.TMSTrigger1 {
        + TMSCtctDtTm  : DateTime
        + TMSId  : String
        + TMSCtctLvl  : String
    }
    class ISO20022.Caaa026001.TimeUnit1Code {
        YEAR = 1
        WEEK = 2
        SECO = 3
        MNTH = 4
        MINU = 5
        HOUR = 6
        DAYC = 7
    }
    class ISO20022.Caaa026001.Token1 {
        + TknInittdInd  : String
        + TknAssrncMtd  : String
        + TknAssrncData  : String
        + TknRqstrId  : String
        + TknXpryDt  : String
        + PmtTkn  : String
    }
    class ISO20022.Caaa026001.TokenRequestComponent5 {
        + Envt  : ISO20022.Caaa026001.CardPaymentEnvironment81
        + TxSeqCntr  : String
    }
    ISO20022.Caaa026001.TokenRequestComponent5 *-- ISO20022.Caaa026001.CardPaymentEnvironment81
    class ISO20022.Caaa026001.Traceability8 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + PrtcolVrsn  : String
        + PrtcolNm  : String
        + RlayId  : ISO20022.Caaa026001.GenericIdentification177
    }
    ISO20022.Caaa026001.Traceability8 *-- ISO20022.Caaa026001.GenericIdentification177
    class ISO20022.Caaa026001.TrackData2 {
        + TrckVal  : String
        + TrckFrmt  : String
        + TrckNb  : Decimal
    }
    class ISO20022.Caaa026001.TrackFormat1Code {
        JIS2 = 1
        JIS1 = 2
        ISOF = 3
        E13B = 4
        CMC7 = 5
        AAMV = 6
    }
    class ISO20022.Caaa026001.TransactionChannel5Code {
        MPOS = 1
        MOBL = 2
        SECM = 3
        TVPY = 4
        ECOM = 5
        TLPH = 6
        MAIL = 7
    }
    class ISO20022.Caaa026001.TransactionEnvironment1Code {
        PUBL = 1
        PRIV = 2
        MERC = 3
    }
    class ISO20022.Caaa026001.TransactionIdentifier1 {
        + TxRef  : String
        + TxDtTm  : DateTime
    }
    class ISO20022.Caaa026001.TransactionTotals12 {
        + CmltvAmt  : Decimal
        + TtlNb  : Decimal
        + Tp  : String
        + Ccy  : String
        + CardPdctPrfl  : String
        + CardBrnd  : String
        + POIGrpId  : String
    }
    class ISO20022.Caaa026001.TransactionVerificationResult4 {
        + AddtlRslt  : String
        + Rslt  : String
        + VrfctnNtty  : String
        + Mtd  : String
    }
    class ISO20022.Caaa026001.TypeOfAmount8Code {
        RESD = 1
        DECR = 2
        INCR = 3
        RPLT = 4
        DFLT = 5
        MAXI = 6
        ESTM = 7
        ACTL = 8
    }
    class ISO20022.Caaa026001.TypeTransactionTotals2Code {
        FAIL = 1
        DECL = 2
        DBTR = 3
        DEBT = 4
        CRDR = 5
        CRDT = 6
    }
    class ISO20022.Caaa026001.UnitOfMeasure6Code {
        GGEU = 1
        DGEU = 2
        KWHO = 3
        ACRE = 4
        SQIN = 5
        SQFO = 6
        SQYA = 7
        SQMI = 8
        SMIL = 9
        SCMT = 10
        SMET = 11
        ARES = 12
        HECT = 13
        SQKI = 14
        YARD = 15
        KMET = 16
        MILE = 17
        USPI = 18
        GBPI = 19
        USQA = 20
        GBQA = 21
        USOU = 22
        GBOU = 23
        MILI = 24
        CELI = 25
        LITR = 26
        MMET = 27
        CMET = 28
        METR = 29
        PUND = 30
        KILO = 31
        INCH = 32
        GRAM = 33
        USGA = 34
        GBGA = 35
        FOOT = 36
        TONS = 37
        PIEC = 38
    }
    class ISO20022.Caaa026001.UserInterface4Code {
        CRDO = 1
        MRCP = 2
        MDSP = 3
        CRCP = 4
        CDSP = 5
    }
    class ISO20022.Caaa026001.Vehicle1 {
        + AddtlVhclData  : global::System.Collections.Generic.List~ISO20022.Caaa026001.Vehicle2~
        + DrvrOrVhclCard  : ISO20022.Caaa026001.PlainCardData17
        + MntncId  : String
        + RefrHrs  : String
        + TrlrHrs  : String
        + Hbmtr  : Decimal
        + Odmtr  : Decimal
        + RplcmntCar  : String
        + UnitNb  : String
        + VhclTagNtryMd  : String
        + VhclTag  : String
        + TrlrNb  : String
        + VhclNb  : String
    }
    ISO20022.Caaa026001.Vehicle1 *-- ISO20022.Caaa026001.Vehicle2
    ISO20022.Caaa026001.Vehicle1 *-- ISO20022.Caaa026001.PlainCardData17
    class ISO20022.Caaa026001.Vehicle2 {
        + Data  : String
        + NtryMd  : String
        + Tp  : String
    }
    class ISO20022.Caaa026001.Verification1Code {
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

## Value ISO20022.Caaa026001.AcceptorCancellationAdvice14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction143||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt))|

---

## Value ISO20022.Caaa026001.AcceptorCompletionAdvice14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Caaa026001.SupplementaryData1>||XmlElement()||
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction140||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Tx),validElement(Cntxt),validElement(Envt))|

---

## Aspect ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Caaa026001.ContentInformationType38||XmlElement()||
|+|BodyElmt|global::System.Collections.Generic.List<ISO20022.Caaa026001.AcceptorToAcquirerFileBody2>||XmlElement()||
|+|Hdr|ISO20022.Caaa026001.Header56||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validRequired("""BodyElmt""",BodyElmt),validList("""BodyElmt""",BodyElmt),validElement(BodyElmt),validElement(Hdr))|

---

## Value ISO20022.Caaa026001.AcceptorToAcquirerFileBody2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BtchTrf|ISO20022.Caaa026001.CardPaymentBatchTransfer13||XmlElement()||
|+|CxlAdvc|ISO20022.Caaa026001.AcceptorCancellationAdvice14||XmlElement()||
|+|CmpltnAdvc|ISO20022.Caaa026001.AcceptorCompletionAdvice14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BtchTrf),validElement(CxlAdvc),validElement(CmpltnAdvc))|

---

## Enum ISO20022.Caaa026001.AccountChoiceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPSL|Int32||XmlEnum("""TPSL""")|1|
||NOSL|Int32||XmlEnum("""NOSL""")|2|
||IMPL|Int32||XmlEnum("""IMPL""")|3|
||IMAC|Int32||XmlEnum("""IMAC""")|4|
||ENTR|Int32||XmlEnum("""ENTR""")|5|
||ACSL|Int32||XmlEnum("""ACSL""")|6|

---

## Value ISO20022.Caaa026001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Caaa026001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Caaa026001.AccountIdentification54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|Dmst|String||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
|+|EMail|String||XmlElement()||
|+|MSISDN|String||XmlElement()||
|+|Card|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validPattern("""Card""",Card,"""[0-9]{8,28}"""),validChoice(Othr,Dmst,UPIC,BBAN,IBAN,EMail,MSISDN,Card))|

---

## Value ISO20022.Caaa026001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Caaa026001.Acquirer10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ParamsVrsn|String||XmlElement()||
|+|Id|ISO20022.Caaa026001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Caaa026001.Action17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmCond|ISO20022.Caaa026001.ProcessTiming6||XmlElement()||
|+|Rtry|ISO20022.Caaa026001.ProcessRetry3||XmlElement()||
|+|RmotAccs|ISO20022.Caaa026001.NetworkParameters7||XmlElement()||
|+|MsgToPres|ISO20022.Caaa026001.ActionMessage11||XmlElement()||
|+|ActnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmCond),validElement(Rtry),validElement(RmotAccs),validElement(MsgToPres))|

---

## Value ISO20022.Caaa026001.ActionMessage11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MinDispTm|Decimal||XmlElement()||
|+|RspnReqrdFlg|String||XmlElement()||
|+|OutptBrcd|ISO20022.Caaa026001.OutputBarcode2||XmlElement()||
|+|MsgCnttSgntr|ISO20022.Caaa026001.ContentInformationType38||XmlElement()||
|+|MsgCntt|String||XmlElement()||
|+|Frmt|String||XmlElement()||
|+|InfQlfr|String||XmlElement()||
|+|MsgDstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OutptBrcd),validElement(MsgCnttSgntr))|

---

## Enum ISO20022.Caaa026001.ActionType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCOF|Int32||XmlEnum("""NCOF""")|1|
||DNTA|Int32||XmlEnum("""DNTA""")|2|
||TALT|Int32||XmlEnum("""TALT""")|3|
||ACUP|Int32||XmlEnum("""ACUP""")|4|
||STOR|Int32||XmlEnum("""STOR""")|5|
||STAR|Int32||XmlEnum("""STAR""")|6|
||CHDA|Int32||XmlEnum("""CHDA""")|7|
||CDCV|Int32||XmlEnum("""CDCV""")|8|
||PINQ|Int32||XmlEnum("""PINQ""")|9|
||FLFW|Int32||XmlEnum("""FLFW""")|10|
||DCCQ|Int32||XmlEnum("""DCCQ""")|11|
||RQDT|Int32||XmlEnum("""RQDT""")|12|
||RFRL|Int32||XmlEnum("""RFRL""")|13|
||PRNT|Int32||XmlEnum("""PRNT""")|14|
||PINR|Int32||XmlEnum("""PINR""")|15|
||PINL|Int32||XmlEnum("""PINL""")|16|
||RQID|Int32||XmlEnum("""RQID""")|17|
||NOVR|Int32||XmlEnum("""NOVR""")|18|
||DISP|Int32||XmlEnum("""DISP""")|19|
||CPTR|Int32||XmlEnum("""CPTR""")|20|
||BUSY|Int32||XmlEnum("""BUSY""")|21|

---

## Value ISO20022.Caaa026001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa026001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Caaa026001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Caaa026001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Caaa026001.AddressVerification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlCdDgts|String||XmlElement()||
|+|AdrDgts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PstlCdDgts""",PstlCdDgts,"""[0-9]{1,5}"""),validPattern("""AdrDgts""",AdrDgts,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Caaa026001.AggregationTransaction3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvPmt|global::System.Collections.Generic.List<ISO20022.Caaa026001.DetailedAmount21>||XmlElement()||
|+|NbOfPmts|Decimal||XmlElement()||
|+|LastPmtDtTm|DateTime||XmlElement()||
|+|FrstPmtDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvPmt""",IndvPmt),validElement(IndvPmt))|

---

## Enum ISO20022.Caaa026001.Algorithm26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMS3|Int32||XmlEnum("""SMS3""")|1|
||SHK2|Int32||XmlEnum("""SHK2""")|2|
||SHK1|Int32||XmlEnum("""SHK1""")|3|
||SH35|Int32||XmlEnum("""SH35""")|4|
||SH33|Int32||XmlEnum("""SH33""")|5|
||SH32|Int32||XmlEnum("""SH32""")|6|
||SH31|Int32||XmlEnum("""SH31""")|7|
||HS01|Int32||XmlEnum("""HS01""")|8|
||HS51|Int32||XmlEnum("""HS51""")|9|
||HS38|Int32||XmlEnum("""HS38""")|10|
||HS25|Int32||XmlEnum("""HS25""")|11|

---

## Enum ISO20022.Caaa026001.Algorithm27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S34R|Int32||XmlEnum("""S34R""")|1|
||S34C|Int32||XmlEnum("""S34C""")|2|
||CCA3|Int32||XmlEnum("""CCA3""")|3|
||CCA2|Int32||XmlEnum("""CCA2""")|4|
||CCA1|Int32||XmlEnum("""CCA1""")|5|
||MCS3|Int32||XmlEnum("""MCS3""")|6|
||CM33|Int32||XmlEnum("""CM33""")|7|
||CM32|Int32||XmlEnum("""CM32""")|8|
||CM31|Int32||XmlEnum("""CM31""")|9|
||CMA2|Int32||XmlEnum("""CMA2""")|10|
||CMA5|Int32||XmlEnum("""CMA5""")|11|
||CMA9|Int32||XmlEnum("""CMA9""")|12|
||MCC1|Int32||XmlEnum("""MCC1""")|13|
||CMA1|Int32||XmlEnum("""CMA1""")|14|
||MCCS|Int32||XmlEnum("""MCCS""")|15|
||MACC|Int32||XmlEnum("""MACC""")|16|

---

## Enum ISO20022.Caaa026001.Algorithm28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SM4R|Int32||XmlEnum("""SM4R""")|1|
||SM4C|Int32||XmlEnum("""SM4C""")|2|
||UKA3|Int32||XmlEnum("""UKA3""")|3|
||UKA1|Int32||XmlEnum("""UKA1""")|4|
||SD5C|Int32||XmlEnum("""SD5C""")|5|
||E36R|Int32||XmlEnum("""E36R""")|6|
||E36C|Int32||XmlEnum("""E36C""")|7|
||E3DR|Int32||XmlEnum("""E3DR""")|8|
||EA2R|Int32||XmlEnum("""EA2R""")|9|
||EA9R|Int32||XmlEnum("""EA9R""")|10|
||EA5R|Int32||XmlEnum("""EA5R""")|11|
||N108|Int32||XmlEnum("""N108""")|12|
||DA25|Int32||XmlEnum("""DA25""")|13|
||DA19|Int32||XmlEnum("""DA19""")|14|
||DA12|Int32||XmlEnum("""DA12""")|15|
||EA5C|Int32||XmlEnum("""EA5C""")|16|
||EA9C|Int32||XmlEnum("""EA9C""")|17|
||UKA2|Int32||XmlEnum("""UKA2""")|18|
||UKPT|Int32||XmlEnum("""UKPT""")|19|
||DKP9|Int32||XmlEnum("""DKP9""")|20|
||E3DC|Int32||XmlEnum("""E3DC""")|21|
||EA2C|Int32||XmlEnum("""EA2C""")|22|

---

## Enum ISO20022.Caaa026001.Algorithm29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||S2S3|Int32||XmlEnum("""S2S3""")|1|
||SM25|Int32||XmlEnum("""SM25""")|2|
||SM23|Int32||XmlEnum("""SM23""")|3|
||SM35|Int32||XmlEnum("""SM35""")|4|
||SM32|Int32||XmlEnum("""SM32""")|5|
||SM33|Int32||XmlEnum("""SM33""")|6|
||SM22|Int32||XmlEnum("""SM22""")|7|
||DD25|Int32||XmlEnum("""DD25""")|8|
||DD23|Int32||XmlEnum("""DD23""")|9|
||DD35|Int32||XmlEnum("""DD35""")|10|
||DD33|Int32||XmlEnum("""DD33""")|11|
||DD32|Int32||XmlEnum("""DD32""")|12|
||DD22|Int32||XmlEnum("""DD22""")|13|
||EO25|Int32||XmlEnum("""EO25""")|14|
||EO23|Int32||XmlEnum("""EO23""")|15|
||EO35|Int32||XmlEnum("""EO35""")|16|
||EO22|Int32||XmlEnum("""EO22""")|17|
||EO32|Int32||XmlEnum("""EO32""")|18|
||EF25|Int32||XmlEnum("""EF25""")|19|
||EO33|Int32||XmlEnum("""EO33""")|20|
||EF23|Int32||XmlEnum("""EF23""")|21|
||EF35|Int32||XmlEnum("""EF35""")|22|
||EF33|Int32||XmlEnum("""EF33""")|23|
||EF22|Int32||XmlEnum("""EF22""")|24|
||EF32|Int32||XmlEnum("""EF32""")|25|
||ED22|Int32||XmlEnum("""ED22""")|26|
||ES25|Int32||XmlEnum("""ES25""")|27|
||ES23|Int32||XmlEnum("""ES23""")|28|
||ES35|Int32||XmlEnum("""ES35""")|29|
||ES33|Int32||XmlEnum("""ES33""")|30|
||ES32|Int32||XmlEnum("""ES32""")|31|
||ES22|Int32||XmlEnum("""ES22""")|32|
||ED25|Int32||XmlEnum("""ED25""")|33|
||ED23|Int32||XmlEnum("""ED23""")|34|
||ED35|Int32||XmlEnum("""ED35""")|35|
||ED33|Int32||XmlEnum("""ED33""")|36|
||ED32|Int32||XmlEnum("""ED32""")|37|
||ERS3|Int32||XmlEnum("""ERS3""")|38|
||RPSS|Int32||XmlEnum("""RPSS""")|39|
||ERS1|Int32||XmlEnum("""ERS1""")|40|
||ERS2|Int32||XmlEnum("""ERS2""")|41|

---

## Enum ISO20022.Caaa026001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Caaa026001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa026001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa026001.Parameter12||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa026001.Parameter16||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa026001.Parameter18||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caaa026001.Parameter17||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caaa026001.AlgorithmIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Amount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.AmountAndDirection93


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa026001.AmountUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POIN|Int32||XmlEnum("""POIN""")|1|
||MONE|Int32||XmlEnum("""MONE""")|2|

---

## Enum ISO20022.Caaa026001.AttendanceContext1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UATT|Int32||XmlEnum("""UATT""")|1|
||SATT|Int32||XmlEnum("""SATT""")|2|
||ATTD|Int32||XmlEnum("""ATTD""")|3|

---

## Enum ISO20022.Caaa026001.AttendanceContext2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SELF|Int32||XmlEnum("""SELF""")|1|
||FULL|Int32||XmlEnum("""FULL""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||CARR|Int32||XmlEnum("""CARR""")|4|
||ATTL|Int32||XmlEnum("""ATTL""")|5|

---

## Enum ISO20022.Caaa026001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Caaa026001.AuthenticatedData10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa026001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Caaa026001.AlgorithmIdentification31||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Recipient15Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Caaa026001.AuthenticationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRML|Int32||XmlEnum("""TRML""")|1|
||ISSR|Int32||XmlEnum("""ISSR""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Enum ISO20022.Caaa026001.AuthenticationMethod6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOKP|Int32||XmlEnum("""TOKP""")|1|
||FPIN|Int32||XmlEnum("""FPIN""")|2|
||MANU|Int32||XmlEnum("""MANU""")|3|
||ADDS|Int32||XmlEnum("""ADDS""")|4|
||CSEC|Int32||XmlEnum("""CSEC""")|5|
||PSVE|Int32||XmlEnum("""PSVE""")|6|
||CSCV|Int32||XmlEnum("""CSCV""")|7|
||CRYP|Int32||XmlEnum("""CRYP""")|8|
||CDHI|Int32||XmlEnum("""CDHI""")|9|
||BIOM|Int32||XmlEnum("""BIOM""")|10|
||ADDB|Int32||XmlEnum("""ADDB""")|11|
||CPSG|Int32||XmlEnum("""CPSG""")|12|
||SNCT|Int32||XmlEnum("""SNCT""")|13|
||SCNL|Int32||XmlEnum("""SCNL""")|14|
||SCRT|Int32||XmlEnum("""SCRT""")|15|
||PSWD|Int32||XmlEnum("""PSWD""")|16|
||PPSG|Int32||XmlEnum("""PPSG""")|17|
||NPIN|Int32||XmlEnum("""NPIN""")|18|

---

## Enum ISO20022.Caaa026001.AuthenticationMethod8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKNW|Int32||XmlEnum("""UKNW""")|1|
||TOKN|Int32||XmlEnum("""TOKN""")|2|
||CPSG|Int32||XmlEnum("""CPSG""")|3|
||ADDS|Int32||XmlEnum("""ADDS""")|4|
||SNCT|Int32||XmlEnum("""SNCT""")|5|
||CSEC|Int32||XmlEnum("""CSEC""")|6|
||SCNL|Int32||XmlEnum("""SCNL""")|7|
||SCRT|Int32||XmlEnum("""SCRT""")|8|
||TOKP|Int32||XmlEnum("""TOKP""")|9|
||PSWD|Int32||XmlEnum("""PSWD""")|10|
||PSVE|Int32||XmlEnum("""PSVE""")|11|
||PPSG|Int32||XmlEnum("""PPSG""")|12|
||OTHR|Int32||XmlEnum("""OTHR""")|13|
||NPIN|Int32||XmlEnum("""NPIN""")|14|
||FPIN|Int32||XmlEnum("""FPIN""")|15|
||MOBL|Int32||XmlEnum("""MOBL""")|16|
||MERC|Int32||XmlEnum("""MERC""")|17|
||MANU|Int32||XmlEnum("""MANU""")|18|
||CSCV|Int32||XmlEnum("""CSCV""")|19|
||CRYP|Int32||XmlEnum("""CRYP""")|20|
||CDHI|Int32||XmlEnum("""CDHI""")|21|
||BIOM|Int32||XmlEnum("""BIOM""")|22|
||BYPS|Int32||XmlEnum("""BYPS""")|23|
||ADDB|Int32||XmlEnum("""ADDB""")|24|
||TOKA|Int32||XmlEnum("""TOKA""")|25|

---

## Enum ISO20022.Caaa026001.AuthenticationResult1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCRP|Int32||XmlEnum("""UCRP""")|1|
||CRPT|Int32||XmlEnum("""CRPT""")|2|
||AUTH|Int32||XmlEnum("""AUTH""")|3|
||CARD|Int32||XmlEnum("""CARD""")|4|
||MRCH|Int32||XmlEnum("""MRCH""")|5|
||DENY|Int32||XmlEnum("""DENY""")|6|

---

## Value ISO20022.Caaa026001.AuthorisationResult17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TMSTrggr|ISO20022.Caaa026001.TMSTrigger1||XmlElement()||
|+|CmpltnReqrd|String||XmlElement()||
|+|AuthstnCd|String||XmlElement()||
|+|RspnToAuthstn|ISO20022.Caaa026001.ResponseType10||XmlElement()||
|+|AuthstnNtty|ISO20022.Caaa026001.GenericIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TMSTrggr),validElement(RspnToAuthstn),validElement(AuthstnNtty))|

---

## Value ISO20022.Caaa026001.AuthorisationResult18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthstnCd|String||XmlElement()||
|+|RspnToAuthstn|ISO20022.Caaa026001.ResponseType10||XmlElement()||
|+|AuthstnNtty|ISO20022.Caaa026001.GenericIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnToAuthstn),validElement(AuthstnNtty))|

---

## Value ISO20022.Caaa026001.AuthorisationResult19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TMSTrggr|ISO20022.Caaa026001.TMSTrigger1||XmlElement()||
|+|AuthstnCd|String||XmlElement()||
|+|RspnToAuthstn|ISO20022.Caaa026001.ResponseType10||XmlElement()||
|+|AuthstnNtty|ISO20022.Caaa026001.GenericIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TMSTrggr),validElement(RspnToAuthstn),validElement(AuthstnNtty))|

---

## Enum ISO20022.Caaa026001.BarcodeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPCA|Int32||XmlEnum("""UPCA""")|1|
||P417|Int32||XmlEnum("""P417""")|2|
||EAN8|Int32||XmlEnum("""EAN8""")|3|
||EA13|Int32||XmlEnum("""EA13""")|4|
||C039|Int32||XmlEnum("""C039""")|5|
||C025|Int32||XmlEnum("""C025""")|6|
||C128|Int32||XmlEnum("""C128""")|7|
||COQR|Int32||XmlEnum("""COQR""")|8|

---

## Value ISO20022.Caaa026001.BinRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HghrBin|String||XmlElement()||
|+|LwrBin|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HghrBin""",HghrBin,"""[0-9]{1,15}"""),validPattern("""LwrBin""",LwrBin,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Caaa026001.BusinessArea2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOPT|Int32||XmlEnum("""TOPT""")|1|
||EOPT|Int32||XmlEnum("""EOPT""")|2|
||TKNF|Int32||XmlEnum("""TKNF""")|3|
||PPAY|Int32||XmlEnum("""PPAY""")|4|
||AIBD|Int32||XmlEnum("""AIBD""")|5|

---

## Enum ISO20022.Caaa026001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Caaa026001.CardAccount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Caaa026001.PartyIdentification177Choice||XmlElement()||
|+|AcctIdr|ISO20022.Caaa026001.AccountIdentification54Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|AcctOwnr|ISO20022.Caaa026001.NameAndAddress3||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|SelctdAcctTp|String||XmlElement()||
|+|SelctnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(AcctIdr),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(AcctOwnr))|

---

## Enum ISO20022.Caaa026001.CardAccountType3Code


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

## Enum ISO20022.Caaa026001.CardDataReading5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDFL|Int32||XmlEnum("""CDFL""")|1|
||ECTL|Int32||XmlEnum("""ECTL""")|2|
||CTLS|Int32||XmlEnum("""CTLS""")|3|
||DFLE|Int32||XmlEnum("""DFLE""")|4|
||CICC|Int32||XmlEnum("""CICC""")|5|
||MGST|Int32||XmlEnum("""MGST""")|6|
||BRCD|Int32||XmlEnum("""BRCD""")|7|
||PHYS|Int32||XmlEnum("""PHYS""")|8|
||TAGC|Int32||XmlEnum("""TAGC""")|9|

---

## Enum ISO20022.Caaa026001.CardDataReading8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPTC|Int32||XmlEnum("""OPTC""")|1|
||QRCD|Int32||XmlEnum("""QRCD""")|2|
||UNKW|Int32||XmlEnum("""UNKW""")|3|
||SICC|Int32||XmlEnum("""SICC""")|4|
||CDFL|Int32||XmlEnum("""CDFL""")|5|
||ECTL|Int32||XmlEnum("""ECTL""")|6|
||CTLS|Int32||XmlEnum("""CTLS""")|7|
||DFLE|Int32||XmlEnum("""DFLE""")|8|
||CICC|Int32||XmlEnum("""CICC""")|9|
||MGST|Int32||XmlEnum("""MGST""")|10|
||BRCD|Int32||XmlEnum("""BRCD""")|11|
||PHYS|Int32||XmlEnum("""PHYS""")|12|
||TAGC|Int32||XmlEnum("""TAGC""")|13|

---

## Enum ISO20022.Caaa026001.CardFallback1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NFLB|Int32||XmlEnum("""NFLB""")|1|
||SFLB|Int32||XmlEnum("""SFLB""")|2|
||FFLB|Int32||XmlEnum("""FFLB""")|3|

---

## Enum ISO20022.Caaa026001.CardIdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UUID|Int32||XmlEnum("""UUID""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|
||CPAN|Int32||XmlEnum("""CPAN""")|3|
||PHON|Int32||XmlEnum("""PHON""")|4|
||ISO2|Int32||XmlEnum("""ISO2""")|5|
||BARC|Int32||XmlEnum("""BARC""")|6|
||ACCT|Int32||XmlEnum("""ACCT""")|7|

---

## Value ISO20022.Caaa026001.CardPaymentBatchTransfer13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DataSet|global::System.Collections.Generic.List<ISO20022.Caaa026001.CardPaymentDataSet40>||XmlElement()||
|+|TxTtls|global::System.Collections.Generic.List<ISO20022.Caaa026001.TransactionTotals12>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DataSet""",DataSet),validElement(DataSet),validList("""TxTtls""",TxTtls),validElement(TxTtls))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSet40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice>||XmlElement()||
|+|CmonData|ISO20022.Caaa026001.CommonData14||XmlElement()||
|+|TxTtls|global::System.Collections.Generic.List<ISO20022.Caaa026001.TransactionTotals12>||XmlElement()||
|+|DataSetInitr|ISO20022.Caaa026001.GenericIdentification176||XmlElement()||
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Traceability8>||XmlElement()||
|+|DataSetId|ISO20022.Caaa026001.DataSetIdentification5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validElement(CmonData),validRequired("""TxTtls""",TxTtls),validList("""TxTtls""",TxTtls),validElement(TxTtls),validElement(DataSetInitr),validList("""Tracblt""",Tracblt),validElement(Tracblt),validElement(DataSetId))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSetTransaction13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TknRspn|ISO20022.Caaa026001.TokenRequestComponent5||XmlElement()||
|+|TknReq|ISO20022.Caaa026001.TokenRequestComponent5||XmlElement()||
|+|AuthstnRspn|ISO20022.Caaa026001.CardPaymentDataSetTransaction53||XmlElement()||
|+|AuthstnReq|ISO20022.Caaa026001.CardPaymentDataSetTransaction52||XmlElement()||
|+|Cxl|ISO20022.Caaa026001.CardPaymentDataSetTransaction50||XmlElement()||
|+|Cmpltn|ISO20022.Caaa026001.CardPaymentDataSetTransaction51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TknRspn),validElement(TknReq),validElement(AuthstnRspn),validElement(AuthstnReq),validElement(Cxl),validElement(Cmpltn),validChoice(TknRspn,TknReq,AuthstnRspn,AuthstnReq,Cxl,Cmpltn))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSetTransaction50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction143||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Traceability8>||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt),validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSetTransaction51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction140||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Traceability8>||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt),validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSetTransaction52


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction139||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Traceability8>||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt),validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentDataSetTransaction53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRspn|ISO20022.Caaa026001.CardPaymentTransaction144||XmlElement()||
|+|Tx|ISO20022.Caaa026001.CardPaymentTransaction137||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Traceability8>||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxRspn),validElement(Tx),validElement(Envt),validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentEnvironment81


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SaleEnvt|ISO20022.Caaa026001.RetailerSaleEnvironment2||XmlElement()||
|+|PrtctdCrdhldrData|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
|+|Crdhldr|ISO20022.Caaa026001.Cardholder21||XmlElement()||
|+|MrchntTkn|ISO20022.Caaa026001.MerchantToken2||XmlElement()||
|+|PmtTkn|ISO20022.Caaa026001.Token1||XmlElement()||
|+|Wllt|ISO20022.Caaa026001.CustomerDevice3||XmlElement()||
|+|CstmrDvc|ISO20022.Caaa026001.CustomerDevice3||XmlElement()||
|+|LltyAcct|global::System.Collections.Generic.List<ISO20022.Caaa026001.LoyaltyAccount3>||XmlElement()||
|+|StordValAcct|global::System.Collections.Generic.List<ISO20022.Caaa026001.StoredValueAccount2>||XmlElement()||
|+|Chck|ISO20022.Caaa026001.Check1||XmlElement()||
|+|Card|ISO20022.Caaa026001.PaymentCard35||XmlElement()||
|+|POI|ISO20022.Caaa026001.PointOfInteraction15||XmlElement()||
|+|Mrchnt|ISO20022.Caaa026001.Organisation41||XmlElement()||
|+|SvcPrvdr|ISO20022.Caaa026001.Acquirer10||XmlElement()||
|+|Acqrr|ISO20022.Caaa026001.Acquirer10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleEnvt),validElement(PrtctdCrdhldrData),validElement(Crdhldr),validElement(MrchntTkn),validElement(PmtTkn),validElement(Wllt),validElement(CstmrDvc),validList("""LltyAcct""",LltyAcct),validElement(LltyAcct),validList("""StordValAcct""",StordValAcct),validElement(StordValAcct),validElement(Chck),validElement(Card),validElement(POI),validElement(Mrchnt),validElement(SvcPrvdr),validElement(Acqrr))|

---

## Enum ISO20022.Caaa026001.CardPaymentServiceType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CIDD|Int32||XmlEnum("""CIDD""")|1|
||CAFL|Int32||XmlEnum("""CAFL""")|2|
||CAFT|Int32||XmlEnum("""CAFT""")|3|
||UNLD|Int32||XmlEnum("""UNLD""")|4|
||VALC|Int32||XmlEnum("""VALC""")|5|
||RESA|Int32||XmlEnum("""RESA""")|6|
||RFND|Int32||XmlEnum("""RFND""")|7|
||QUCH|Int32||XmlEnum("""QUCH""")|8|
||PINC|Int32||XmlEnum("""PINC""")|9|
||ORCR|Int32||XmlEnum("""ORCR""")|10|
||LOAD|Int32||XmlEnum("""LOAD""")|11|
||DEFR|Int32||XmlEnum("""DEFR""")|12|
||CSHD|Int32||XmlEnum("""CSHD""")|13|
||CSHW|Int32||XmlEnum("""CSHW""")|14|
||CAVR|Int32||XmlEnum("""CAVR""")|15|
||CAFH|Int32||XmlEnum("""CAFH""")|16|
||CRDP|Int32||XmlEnum("""CRDP""")|17|
||CACT|Int32||XmlEnum("""CACT""")|18|
||BALC|Int32||XmlEnum("""BALC""")|19|

---

## Enum ISO20022.Caaa026001.CardPaymentServiceType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFCL|Int32||XmlEnum("""DFCL""")|1|
||GOPT|Int32||XmlEnum("""GOPT""")|2|
||RREC|Int32||XmlEnum("""RREC""")|3|
||FREC|Int32||XmlEnum("""FREC""")|4|
||ARES|Int32||XmlEnum("""ARES""")|5|
||PRES|Int32||XmlEnum("""PRES""")|6|
||URES|Int32||XmlEnum("""URES""")|7|
||IRES|Int32||XmlEnum("""IRES""")|8|

---

## Enum ISO20022.Caaa026001.CardPaymentServiceType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRFD|Int32||XmlEnum("""NRFD""")|1|
||INST|Int32||XmlEnum("""INST""")|2|
||CSHB|Int32||XmlEnum("""CSHB""")|3|
||INSA|Int32||XmlEnum("""INSA""")|4|
||INSI|Int32||XmlEnum("""INSI""")|5|
||VCAU|Int32||XmlEnum("""VCAU""")|6|
||SOAF|Int32||XmlEnum("""SOAF""")|7|
||RECP|Int32||XmlEnum("""RECP""")|8|
||PUCO|Int32||XmlEnum("""PUCO""")|9|
||NRES|Int32||XmlEnum("""NRES""")|10|
||LOYT|Int32||XmlEnum("""LOYT""")|11|
||GRTT|Int32||XmlEnum("""GRTT""")|12|
||DCCV|Int32||XmlEnum("""DCCV""")|13|
||AGGR|Int32||XmlEnum("""AGGR""")|14|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction137


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrchntRefData|String||XmlElement()||
|+|TxDtls|ISO20022.Caaa026001.CardPaymentTransactionDetails53||XmlElement()||
|+|IntrchngData|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|RcptTxId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|TxId|ISO20022.Caaa026001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxDtls),validElement(TxId))|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction138


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRslt|ISO20022.Caaa026001.CardPaymentTransactionResult4||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
|+|SvcAttr|String||XmlElement()||
|+|AddtlSvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|RcptTxId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|POIId|ISO20022.Caaa026001.GenericIdentification32||XmlElement()||
|+|TxId|ISO20022.Caaa026001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxRslt),validElement(POIId),validElement(TxId))|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlTxData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcctTo|ISO20022.Caaa026001.CardAccount16||XmlElement()||
|+|AcctFr|ISO20022.Caaa026001.CardAccount16||XmlElement()||
|+|MrchntRefData|String||XmlElement()||
|+|TxDtls|ISO20022.Caaa026001.CardPaymentTransactionDetails53||XmlElement()||
|+|MrchntCITId|String||XmlElement()||
|+|IssrCITId|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|OrgnlTx|ISO20022.Caaa026001.CardPaymentTransaction138||XmlElement()||
|+|TxId|ISO20022.Caaa026001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
|+|CardPrgrmmApld|String||XmlElement()||
|+|CardPrgrmmPropsd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CstmrCnsnt|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|LastTxFlg|String||XmlElement()||
|+|SvcAttr|String||XmlElement()||
|+|AddtlSvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|TxCaptr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctTo),validElement(AcctFr),validElement(TxDtls),validElement(OrgnlTx),validElement(TxId))|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction140


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlTxData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcctTo|ISO20022.Caaa026001.CardAccount16||XmlElement()||
|+|AcctFr|ISO20022.Caaa026001.CardAccount16||XmlElement()||
|+|MrchntRefData|String||XmlElement()||
|+|AuthstnRslt|ISO20022.Caaa026001.AuthorisationResult18||XmlElement()||
|+|TxDtls|ISO20022.Caaa026001.CardPaymentTransactionDetails53||XmlElement()||
|+|MrchntCITId|String||XmlElement()||
|+|IssrCITId|String||XmlElement()||
|+|IntrchngData|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|RcptTxId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|FailrRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MrchntOvrrd|String||XmlElement()||
|+|Rvsl|String||XmlElement()||
|+|TxSucss|String||XmlElement()||
|+|OrgnlTx|ISO20022.Caaa026001.CardPaymentTransaction138||XmlElement()||
|+|TxId|ISO20022.Caaa026001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
|+|CardPrgrmmApld|String||XmlElement()||
|+|CardPrgrmmPropsd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CstmrCnsnt|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|LastTxFlg|String||XmlElement()||
|+|SvcAttr|String||XmlElement()||
|+|AddtlSvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|TxCaptr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctTo),validElement(AcctFr),validElement(AuthstnRslt),validElement(TxDtls),validElement(OrgnlTx),validElement(TxId))|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction143


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlTxData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AuthstnRslt|ISO20022.Caaa026001.AuthorisationResult19||XmlElement()||
|+|TxDtls|ISO20022.Caaa026001.CardPaymentTransactionDetails50||XmlElement()||
|+|IntrchngData|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|RcptTxId|String||XmlElement()||
|+|InitrTxId|String||XmlElement()||
|+|FailrRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rvsl|String||XmlElement()||
|+|TxSucss|String||XmlElement()||
|+|OrgnlTx|ISO20022.Caaa026001.CardPaymentTransaction138||XmlElement()||
|+|TxId|ISO20022.Caaa026001.TransactionIdentifier1||XmlElement()||
|+|SaleRefId|String||XmlElement()||
|+|CardPrgrmmApld|String||XmlElement()||
|+|CardPrgrmmPropsd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CstmrCnsnt|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthstnRslt),validElement(TxDtls),validElement(OrgnlTx),validElement(TxId))|

---

## Value ISO20022.Caaa026001.CardPaymentTransaction144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyConvsElgblty|ISO20022.Caaa026001.CurrencyConversion29||XmlElement()||
|+|Actn|global::System.Collections.Generic.List<ISO20022.Caaa026001.Action17>||XmlElement()||
|+|PrtctdBal|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
|+|Bal|ISO20022.Caaa026001.AmountAndDirection93||XmlElement()||
|+|AddtlAvlblPdct|global::System.Collections.Generic.List<ISO20022.Caaa026001.Product5>||XmlElement()||
|+|NotAllwdPdctCd|global::System.Collections.Generic.List<ISO20022.Caaa026001.Product4>||XmlElement()||
|+|AllwdPdctCd|global::System.Collections.Generic.List<ISO20022.Caaa026001.Product4>||XmlElement()||
|+|AuthstnRslt|ISO20022.Caaa026001.AuthorisationResult17||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyConvsElgblty),validList("""Actn""",Actn),validElement(Actn),validElement(PrtctdBal),validElement(Bal),validList("""AddtlAvlblPdct""",AddtlAvlblPdct),validElement(AddtlAvlblPdct),validList("""NotAllwdPdctCd""",NotAllwdPdctCd),validElement(NotAllwdPdctCd),validList("""AllwdPdctCd""",AllwdPdctCd),validElement(AllwdPdctCd),validElement(AuthstnRslt))|

---

## Value ISO20022.Caaa026001.CardPaymentTransactionDetails50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeepAuthstnOpn|String||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|VldtyDt|DateTime||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentTransactionDetails53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ICCRltdData|String||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Caaa026001.ExternallyDefinedData5>||XmlElement()||
|+|TtlAuthrsdAmt|Decimal||XmlElement()||
|+|CmpltnSeqCntr|Decimal||XmlElement()||
|+|CmpltnSeqNb|Decimal||XmlElement()||
|+|ReSubmissnCntr|Decimal||XmlElement()||
|+|DlvryLctn|String||XmlElement()||
|+|SaleItm|global::System.Collections.Generic.List<ISO20022.Caaa026001.Product6>||XmlElement()||
|+|PdctCdSetId|String||XmlElement()||
|+|AggtnTx|ISO20022.Caaa026001.AggregationTransaction3||XmlElement()||
|+|Rcrng|ISO20022.Caaa026001.RecurringTransaction6||XmlElement()||
|+|Instlmt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Instalment5>||XmlElement()||
|+|CcyConvsRslt|ISO20022.Caaa026001.CurrencyConversion30||XmlElement()||
|+|AcctTp|String||XmlElement()||
|+|UattnddLvlCtgy|String||XmlElement()||
|+|OnLineRsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|VldtyDt|DateTime||XmlElement()||
|+|InvcAmt|Decimal||XmlElement()||
|+|AuthrsdAmt|Decimal||XmlElement()||
|+|ReqdAmt|Decimal||XmlElement()||
|+|DtldAmt|ISO20022.Caaa026001.DetailedAmount15||XmlElement()||
|+|AmtQlfr|String||XmlElement()||
|+|CmltvAmt|Decimal||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""SaleItm""",SaleItm),validElement(SaleItm),validElement(AggtnTx),validElement(Rcrng),validList("""Instlmt""",Instlmt),validElement(Instlmt),validElement(CcyConvsRslt),validPattern("""UattnddLvlCtgy""",UattnddLvlCtgy,"""[0-9]{1,35}"""),validElement(DtldAmt),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa026001.CardPaymentTransactionResult4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthstnCd|String||XmlElement()||
|+|RspnToAuthstn|ISO20022.Caaa026001.ResponseType10||XmlElement()||
|+|AuthstnNtty|ISO20022.Caaa026001.GenericIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnToAuthstn),validElement(AuthstnNtty))|

---

## Enum ISO20022.Caaa026001.CardProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CONS|Int32||XmlEnum("""CONS""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|

---

## Value ISO20022.Caaa026001.Cardholder21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MobData|global::System.Collections.Generic.List<ISO20022.Caaa026001.MobileData6>||XmlElement()||
|+|PrsnlData|String||XmlElement()||
|+|TxVrfctnRslt|global::System.Collections.Generic.List<ISO20022.Caaa026001.TransactionVerificationResult4>||XmlElement()||
|+|Authntcn|global::System.Collections.Generic.List<ISO20022.Caaa026001.CardholderAuthentication17>||XmlElement()||
|+|Vhcl|ISO20022.Caaa026001.Vehicle1||XmlElement()||
|+|TripNb|String||XmlElement()||
|+|ShppgAdr|ISO20022.Caaa026001.PostalAddress22||XmlElement()||
|+|BllgAdr|ISO20022.Caaa026001.PostalAddress22||XmlElement()||
|+|Lang|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Caaa026001.PersonIdentification15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MobData""",MobData),validElement(MobData),validList("""TxVrfctnRslt""",TxVrfctnRslt),validElement(TxVrfctnRslt),validList("""Authntcn""",Authntcn),validElement(Authntcn),validElement(Vhcl),validElement(ShppgAdr),validElement(BllgAdr),validElement(Id))|

---

## Value ISO20022.Caaa026001.CardholderAuthentication17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnAddtlInf|ISO20022.Caaa026001.ExternallyDefinedData5||XmlElement()||
|+|AuthntcnRslt|String||XmlElement()||
|+|AuthntcnLvl|String||XmlElement()||
|+|AuthntcnTp|String||XmlElement()||
|+|AdrVrfctn|ISO20022.Caaa026001.AddressVerification1||XmlElement()||
|+|CrdhldrId|ISO20022.Caaa026001.PersonIdentification15||XmlElement()||
|+|CrdhldrOnLinePIN|ISO20022.Caaa026001.OnLinePIN11||XmlElement()||
|+|PrtctdAuthntcnVal|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
|+|AuthntcnVal|String||XmlElement()||
|+|AuthntcnXmptn|String||XmlElement()||
|+|AuthntcnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcnAddtlInf),validElement(AdrVrfctn),validElement(CrdhldrId),validElement(CrdhldrOnLinePIN),validElement(PrtctdAuthntcnVal))|

---

## Enum ISO20022.Caaa026001.CardholderVerificationCapability4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NOVF|Int32||XmlEnum("""NOVF""")|2|
||NBIO|Int32||XmlEnum("""NBIO""")|3|
||SCEC|Int32||XmlEnum("""SCEC""")|4|
||PKIS|Int32||XmlEnum("""PKIS""")|5|
||NPIN|Int32||XmlEnum("""NPIN""")|6|
||FEPN|Int32||XmlEnum("""FEPN""")|7|
||FCPN|Int32||XmlEnum("""FCPN""")|8|
||FDSG|Int32||XmlEnum("""FDSG""")|9|
||FBIO|Int32||XmlEnum("""FBIO""")|10|
||FBIG|Int32||XmlEnum("""FBIG""")|11|
||MNVR|Int32||XmlEnum("""MNVR""")|12|
||MNSG|Int32||XmlEnum("""MNSG""")|13|
||CHDT|Int32||XmlEnum("""CHDT""")|14|
||APKI|Int32||XmlEnum("""APKI""")|15|

---

## Value ISO20022.Caaa026001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Caaa026001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Caaa026001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Caaa026001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Caaa026001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Caaa026001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Caaa026001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Caaa026001.Check1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|ChckTp|String||XmlElement()||
|+|ChckTrckData2|ISO20022.Caaa026001.TrackData2||XmlElement()||
|+|ChckCardNb|String||XmlElement()||
|+|ChckNb|String||XmlElement()||
|+|AcctNb|String||XmlElement()||
|+|BkId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChckTrckData2))|

---

## Enum ISO20022.Caaa026001.CheckType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERS|Int32||XmlEnum("""PERS""")|1|
||PAYR|Int32||XmlEnum("""PAYR""")|2|
||GOVC|Int32||XmlEnum("""GOVC""")|3|
||BUSI|Int32||XmlEnum("""BUSI""")|4|
||BANK|Int32||XmlEnum("""BANK""")|5|

---

## Value ISO20022.Caaa026001.Commission18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Commission19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.CommonData14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|SvcAttr|String||XmlElement()||
|+|AddtlSvc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxTp|String||XmlElement()||
|+|Cntxt|ISO20022.Caaa026001.PaymentContext30||XmlElement()||
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Cntxt),validElement(Envt))|

---

## Value ISO20022.Caaa026001.CommunicationAddress9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCtctInf|String||XmlElement()||
|+|CstmrSvc|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|PstlAdr|ISO20022.Caaa026001.PostalAddress22||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CstmrSvc""",CstmrSvc,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(PstlAdr))|

---

## Value ISO20022.Caaa026001.CommunicationCharacteristics5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PhysIntrfc|ISO20022.Caaa026001.PhysicalInterfaceParameter1||XmlElement()||
|+|Params|ISO20022.Caaa026001.NetworkParameters7||XmlElement()||
|+|Actv|String||XmlElement()||
|+|RmotPty|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ComTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PhysIntrfc),validElement(Params),validRequired("""RmotPty""",RmotPty))|

---

## Value ISO20022.Caaa026001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Caaa026001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Caaa026001.ContentInformationType38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndData|ISO20022.Caaa026001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Caaa026001.AuthenticatedData10||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndData),validElement(AuthntcdData))|

---

## Value ISO20022.Caaa026001.ContentInformationType39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstdData|ISO20022.Caaa026001.DigestedData6||XmlElement()||
|+|SgndData|ISO20022.Caaa026001.SignedData9||XmlElement()||
|+|AuthntcdData|ISO20022.Caaa026001.AuthenticatedData10||XmlElement()||
|+|EnvlpdData|ISO20022.Caaa026001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgstdData),validElement(SgndData),validElement(AuthntcdData),validElement(EnvlpdData))|

---

## Value ISO20022.Caaa026001.ContentInformationType40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Caaa026001.EnvelopedData11||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Enum ISO20022.Caaa026001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Caaa026001.CreditTransferContext1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctdCdtrAcct|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|CdtrAcct|ISO20022.Caaa026001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Caaa026001.PartyIdentification272||XmlElement()||
|+|PrtctdDbtrAcct|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|DbtrAcct|ISO20022.Caaa026001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Caaa026001.PartyIdentification272||XmlElement()||
|+|SysToNtfy|String||XmlElement()||
|+|WaitForNtfctnBfrEndg|String||XmlElement()||
|+|AutomtcNtfctnOfCshMvmnt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdCdtrAcct),validElement(CdtrAcct),validElement(Cdtr),validElement(PrtctdDbtrAcct),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Caaa026001.CryptographicKey18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlMgmtInf|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericInformation1>||XmlElement()||
|+|KeyChckVal|String||XmlElement()||
|+|PrtctdCmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Caaa026001.ContentInformationType39>||XmlElement()||
|+|CmpntWthAuthrsdAccs|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericIdentification186>||XmlElement()||
|+|KeyVal|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|DeactvtnDt|DateTime||XmlElement()||
|+|ActvtnDt|DateTime||XmlElement()||
|+|Fctn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlMgmtInf""",AddtlMgmtInf),validElement(AddtlMgmtInf),validList("""PrtctdCmpntWthAuthrsdAccs""",PrtctdCmpntWthAuthrsdAccs),validElement(PrtctdCmpntWthAuthrsdAccs),validList("""CmpntWthAuthrsdAccs""",CmpntWthAuthrsdAccs),validElement(CmpntWthAuthrsdAccs),validElement(KeyVal))|

---

## Enum ISO20022.Caaa026001.CryptographicKeyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EDE4|Int32||XmlEnum("""EDE4""")|1|
||AES5|Int32||XmlEnum("""AES5""")|2|
||AES9|Int32||XmlEnum("""AES9""")|3|
||DKP9|Int32||XmlEnum("""DKP9""")|4|
||EDE3|Int32||XmlEnum("""EDE3""")|5|
||AES2|Int32||XmlEnum("""AES2""")|6|

---

## Value ISO20022.Caaa026001.CurrencyConversion29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DclrtnDtls|global::System.Collections.Generic.List<ISO20022.Caaa026001.ActionMessage11>||XmlElement()||
|+|MrkUpDtls|global::System.Collections.Generic.List<ISO20022.Caaa026001.Commission18>||XmlElement()||
|+|ComssnDtls|global::System.Collections.Generic.List<ISO20022.Caaa026001.Commission19>||XmlElement()||
|+|OrgnlAmt|ISO20022.Caaa026001.OriginalAmountDetails1||XmlElement()||
|+|AplblBinRg|global::System.Collections.Generic.List<ISO20022.Caaa026001.BinRange1>||XmlElement()||
|+|SrcCcy|ISO20022.Caaa026001.CurrencyDetails2||XmlElement()||
|+|VldUntil|DateTime||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|NvrtdXchgRate|Decimal||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|RsltgAmt|Decimal||XmlElement()||
|+|TrgtCcy|ISO20022.Caaa026001.CurrencyDetails3||XmlElement()||
|+|CcyConvsId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DclrtnDtls""",DclrtnDtls),validElement(DclrtnDtls),validList("""MrkUpDtls""",MrkUpDtls),validElement(MrkUpDtls),validList("""ComssnDtls""",ComssnDtls),validElement(ComssnDtls),validElement(OrgnlAmt),validList("""AplblBinRg""",AplblBinRg),validElement(AplblBinRg),validElement(SrcCcy),validElement(TrgtCcy))|

---

## Value ISO20022.Caaa026001.CurrencyConversion30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Convs|ISO20022.Caaa026001.CurrencyConversion29||XmlElement()||
|+|AccptdByCrdhldr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Convs))|

---

## Value ISO20022.Caaa026001.CurrencyDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|NmrcCd|String||XmlElement()||
|+|AlphaCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NmrcCd""",NmrcCd,"""[0-9]{3}"""),validPattern("""AlphaCd""",AlphaCd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa026001.CurrencyDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|NmrcCd|String||XmlElement()||
|+|AlphaCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NmrcCd""",NmrcCd,"""[0-9]{3}"""),validPattern("""AlphaCd""",AlphaCd,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa026001.CustomerDevice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prvdr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.DataSetCategory8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLE|Int32||XmlEnum("""RCLE""")|1|
||MGTP|Int32||XmlEnum("""MGTP""")|2|
||DLGT|Int32||XmlEnum("""DLGT""")|3|
||STRP|Int32||XmlEnum("""STRP""")|4|
||AKCP|Int32||XmlEnum("""AKCP""")|5|
||TXCP|Int32||XmlEnum("""TXCP""")|6|
||MRPR|Int32||XmlEnum("""MRPR""")|7|
||AQPR|Int32||XmlEnum("""AQPR""")|8|
||VDPR|Int32||XmlEnum("""VDPR""")|9|
||SWPK|Int32||XmlEnum("""SWPK""")|10|

---

## Value ISO20022.Caaa026001.DataSetIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Caaa026001.DetailedAmount15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Srchrg|global::System.Collections.Generic.List<ISO20022.Caaa026001.DetailedAmount4>||XmlElement()||
|+|ValAddedTax|global::System.Collections.Generic.List<ISO20022.Caaa026001.DetailedAmount4>||XmlElement()||
|+|Rbt|global::System.Collections.Generic.List<ISO20022.Caaa026001.DetailedAmount4>||XmlElement()||
|+|Fees|global::System.Collections.Generic.List<ISO20022.Caaa026001.DetailedAmount4>||XmlElement()||
|+|Grtty|Decimal||XmlElement()||
|+|CshBck|Decimal||XmlElement()||
|+|AmtGoodsAndSvcs|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Srchrg""",Srchrg),validElement(Srchrg),validList("""ValAddedTax""",ValAddedTax),validElement(ValAddedTax),validList("""Rbt""",Rbt),validElement(Rbt),validList("""Fees""",Fees),validElement(Fees))|

---

## Value ISO20022.Caaa026001.DetailedAmount21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
|+|DtTm|DateTime||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.DetailedAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.DigestedData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dgst|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa026001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|ISO20022.Caaa026001.AlgorithmIdentification36||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(DgstAlgo))|

---

## Value ISO20022.Caaa026001.DirectDebitContext1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtRltdInf|ISO20022.Caaa026001.MandateRelatedInformation17||XmlElement()||
|+|PrtctdCdtrAcct|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|CdtrAcct|ISO20022.Caaa026001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Caaa026001.PartyIdentification272||XmlElement()||
|+|PrtctdDbtrAcct|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|DbtrAcct|ISO20022.Caaa026001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Caaa026001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtRltdInf),validElement(PrtctdCdtrAcct),validElement(CdtrAcct),validElement(Cdtr),validElement(PrtctdDbtrAcct),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Caaa026001.DisplayCapabilities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Dstn""",Dstn))|

---

## Type ISO20022.Caaa026001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AccptrToAcqrrBtchFileXchg|ISO20022.Caaa026001.AcceptorToAcquirerBatchFileExchangeV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrToAcqrrBtchFileXchg))|

---

## Value ISO20022.Caaa026001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.EncryptedContent7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Caaa026001.AlgorithmIdentification32||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Caaa026001.EncryptionFormat2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||I238|Int32||XmlEnum("""I238""")|1|
||TR34|Int32||XmlEnum("""TR34""")|2|
||TR31|Int32||XmlEnum("""TR31""")|3|

---

## Value ISO20022.Caaa026001.EnvelopedData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Caaa026001.EncryptedContent7||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Recipient15Choice>||XmlElement()||
|+|OrgtrInf|ISO20022.Caaa026001.OriginatorInformation1||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt),validElement(OrgtrInf))|

---

## Enum ISO20022.Caaa026001.Exemption1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMBE|Int32||XmlEnum("""TMBE""")|1|
||PKGE|Int32||XmlEnum("""PKGE""")|2|
||TRAE|Int32||XmlEnum("""TRAE""")|3|
||SCAD|Int32||XmlEnum("""SCAD""")|4|
||SCPE|Int32||XmlEnum("""SCPE""")|5|
||RECP|Int32||XmlEnum("""RECP""")|6|
||MINT|Int32||XmlEnum("""MINT""")|7|
||LOWA|Int32||XmlEnum("""LOWA""")|8|

---

## Value ISO20022.Caaa026001.ExternallyDefinedData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|PrtctdVal|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|Val|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdVal))|

---

## Enum ISO20022.Caaa026001.FailureReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||USND|Int32||XmlEnum("""USND""")|2|
||UCMP|Int32||XmlEnum("""UCMP""")|3|
||LATE|Int32||XmlEnum("""LATE""")|4|
||TIMO|Int32||XmlEnum("""TIMO""")|5|
||SFRD|Int32||XmlEnum("""SFRD""")|6|
||PART|Int32||XmlEnum("""PART""")|7|
||NDCL|Int32||XmlEnum("""NDCL""")|8|
||FDCL|Int32||XmlEnum("""FDCL""")|9|
||MALF|Int32||XmlEnum("""MALF""")|10|
||CUCL|Int32||XmlEnum("""CUCL""")|11|
||CDCL|Int32||XmlEnum("""CDCL""")|12|

---

## Enum ISO20022.Caaa026001.Frequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEND|Int32||XmlEnum("""TEND""")|1|
||DAIL|Int32||XmlEnum("""DAIL""")|2|
||WEEK|Int32||XmlEnum("""WEEK""")|3|
||MIAN|Int32||XmlEnum("""MIAN""")|4|
||QURT|Int32||XmlEnum("""QURT""")|5|
||MNTH|Int32||XmlEnum("""MNTH""")|6|
||YEAR|Int32||XmlEnum("""YEAR""")|7|

---

## Value ISO20022.Caaa026001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Caaa026001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Caaa026001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericIdentification176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa026001.GenericIdentification177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Glctn|ISO20022.Caaa026001.Geolocation1||XmlElement()||
|+|RmotAccs|ISO20022.Caaa026001.NetworkParameters7||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Glctn),validElement(RmotAccs),validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa026001.GenericIdentification186


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Caaa026001.GenericIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericIdentification48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa026001.GenericInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Caaa026001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Caaa026001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Caaa026001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Caaa026001.Geolocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Caaa026001.GeolocationUTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Caaa026001.GeolocationGeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints))|

---

## Value ISO20022.Caaa026001.GeolocationGeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GeolocationUTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|String||XmlElement()||
|+|UTMEstwrd|String||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.GracePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrUnitTp|String||XmlElement()||
|+|UnitTp|String||XmlElement()||
|+|Tm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Tm""",Tm,"""[0-9]{1,3}"""))|

---

## Enum ISO20022.Caaa026001.GracePeriodUnitType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAYS|Int32||XmlEnum("""DAYS""")|1|
||MNTH|Int32||XmlEnum("""MNTH""")|2|
||OTHN|Int32||XmlEnum("""OTHN""")|3|
||OTHP|Int32||XmlEnum("""OTHP""")|4|
||PMTS|Int32||XmlEnum("""PMTS""")|5|
||WEKS|Int32||XmlEnum("""WEKS""")|6|

---

## Value ISO20022.Caaa026001.Header56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcptPty|ISO20022.Caaa026001.GenericIdentification177||XmlElement()||
|+|InitgPty|ISO20022.Caaa026001.GenericIdentification176||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|Decimal||XmlElement()||
|+|FrmtVrsn|String||XmlElement()||
|+|DwnldTrf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptPty),validElement(InitgPty))|

---

## Enum ISO20022.Caaa026001.InformationQualify1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VCHR|Int32||XmlEnum("""VCHR""")|1|
||STAT|Int32||XmlEnum("""STAT""")|2|
||SOND|Int32||XmlEnum("""SOND""")|3|
||RCPT|Int32||XmlEnum("""RCPT""")|4|
||POIR|Int32||XmlEnum("""POIR""")|5|
||INPT|Int32||XmlEnum("""INPT""")|6|
||ERRO|Int32||XmlEnum("""ERRO""")|7|
||DOCT|Int32||XmlEnum("""DOCT""")|8|
||DISP|Int32||XmlEnum("""DISP""")|9|
||CUSA|Int32||XmlEnum("""CUSA""")|10|

---

## Value ISO20022.Caaa026001.Instalment5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlanNtce|global::System.Collections.Generic.List<ISO20022.Caaa026001.ActionMessage11>||XmlElement()||
|+|GracePrd|global::System.Collections.Generic.List<ISO20022.Caaa026001.GracePeriod1>||XmlElement()||
|+|IntrstRate|global::System.Collections.Generic.List<ISO20022.Caaa026001.InterestRateDetails1>||XmlElement()||
|+|DtldChrgs|global::System.Collections.Generic.List<ISO20022.Caaa026001.InstalmentAmountDetails1>||XmlElement()||
|+|Chrgs|Decimal||XmlElement()||
|+|LastAmt|Decimal||XmlElement()||
|+|SbsqntAmt|Decimal||XmlElement()||
|+|FrstAmt|Decimal||XmlElement()||
|+|TtlAmt|ISO20022.Caaa026001.ActiveCurrencyAndAmount||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|TtlNbOfPmts|Decimal||XmlElement()||
|+|InstlmtPrd|Decimal||XmlElement()||
|+|PrdUnit|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|PlanOwnr|String||XmlElement()||
|+|PlanId|String||XmlElement()||
|+|InstlmtPlan|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PlanNtce""",PlanNtce),validElement(PlanNtce),validList("""GracePrd""",GracePrd),validElement(GracePrd),validList("""IntrstRate""",IntrstRate),validElement(IntrstRate),validList("""DtldChrgs""",DtldChrgs),validElement(DtldChrgs),validElement(TtlAmt))|

---

## Value ISO20022.Caaa026001.InstalmentAmountDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pctg|Decimal||XmlElement()||
|+|Amt|ISO20022.Caaa026001.Amount5||XmlElement()||
|+|SubTp|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Caaa026001.InstalmentAmountDetailsType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AFCO|Int32||XmlEnum("""AFCO""")|1|
||EXPN|Int32||XmlEnum("""EXPN""")|2|
||FEES|Int32||XmlEnum("""FEES""")|3|
||FUNA|Int32||XmlEnum("""FUNA""")|4|
||INSU|Int32||XmlEnum("""INSU""")|5|
||OTHC|Int32||XmlEnum("""OTHC""")|6|
||OTHN|Int32||XmlEnum("""OTHN""")|7|
||OTHP|Int32||XmlEnum("""OTHP""")|8|
||RQST|Int32||XmlEnum("""RQST""")|9|
||TAXX|Int32||XmlEnum("""TAXX""")|10|

---

## Enum ISO20022.Caaa026001.InstalmentPeriod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANNU|Int32||XmlEnum("""ANNU""")|1|
||MNTH|Int32||XmlEnum("""MNTH""")|2|

---

## Enum ISO20022.Caaa026001.InstalmentPlan1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DFRI|Int32||XmlEnum("""DFRI""")|1|
||NQPM|Int32||XmlEnum("""NQPM""")|2|
||EQPM|Int32||XmlEnum("""EQPM""")|3|

---

## Enum ISO20022.Caaa026001.InterestRate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||NTRT|Int32||XmlEnum("""NTRT""")|3|
||GSRT|Int32||XmlEnum("""GSRT""")|4|

---

## Value ISO20022.Caaa026001.InterestRateDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Prd|String||XmlElement()||
|+|OthrTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.IssuerAndSerialNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Caaa026001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Caaa026001.KEK9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caaa026001.AlgorithmIdentification32||XmlElement()||
|+|KEKId|ISO20022.Caaa026001.KEKIdentifier7||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Caaa026001.KEKIdentifier7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.KeyTransport10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caaa026001.AlgorithmIdentification35||XmlElement()||
|+|RcptId|ISO20022.Caaa026001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Caaa026001.KeyUsage1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||KEYD|Int32||XmlEnum("""KEYD""")|1|
||KEYX|Int32||XmlEnum("""KEYX""")|2|
||KEYI|Int32||XmlEnum("""KEYI""")|3|
||KEYG|Int32||XmlEnum("""KEYG""")|4|
||PINV|Int32||XmlEnum("""PINV""")|5|
||PIND|Int32||XmlEnum("""PIND""")|6|
||PINE|Int32||XmlEnum("""PINE""")|7|
||SUGV|Int32||XmlEnum("""SUGV""")|8|
||SIGG|Int32||XmlEnum("""SIGG""")|9|
||MACV|Int32||XmlEnum("""MACV""")|10|
||MACG|Int32||XmlEnum("""MACG""")|11|
||TRNX|Int32||XmlEnum("""TRNX""")|12|
||TRNI|Int32||XmlEnum("""TRNI""")|13|
||DDEC|Int32||XmlEnum("""DDEC""")|14|
||DENC|Int32||XmlEnum("""DENC""")|15|
||DCPT|Int32||XmlEnum("""DCPT""")|16|
||ENCR|Int32||XmlEnum("""ENCR""")|17|

---

## Enum ISO20022.Caaa026001.LocationCategory3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VNDG|Int32||XmlEnum("""VNDG""")|1|
||SSLE|Int32||XmlEnum("""SSLE""")|2|
||MSLE|Int32||XmlEnum("""MSLE""")|3|
||MPMP|Int32||XmlEnum("""MPMP""")|4|
||MPOI|Int32||XmlEnum("""MPOI""")|5|
||IPMP|Int32||XmlEnum("""IPMP""")|6|
||INDR|Int32||XmlEnum("""INDR""")|7|

---

## Enum ISO20022.Caaa026001.LocationCategory4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIRT|Int32||XmlEnum("""VIRT""")|1|
||FIXD|Int32||XmlEnum("""FIXD""")|2|
||NMDC|Int32||XmlEnum("""NMDC""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|

---

## Value ISO20022.Caaa026001.LoyaltyAccount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Unit|String||XmlElement()||
|+|OwnrNm|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
|+|Brnd|String||XmlElement()||
|+|IdTp|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|LltyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa026001.LoyaltyHandling1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REQU|Int32||XmlEnum("""REQU""")|1|
||PROP|Int32||XmlEnum("""PROP""")|2|
||PRCS|Int32||XmlEnum("""PRCS""")|3|
||DENY|Int32||XmlEnum("""DENY""")|4|
||ALLO|Int32||XmlEnum("""ALLO""")|5|

---

## Value ISO20022.Caaa026001.MandateRelatedInformation17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctdMndtImg|ISO20022.Caaa026001.ContentInformationType39||XmlElement()||
|+|MndtImg|String||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdMndtImg))|

---

## Value ISO20022.Caaa026001.MemoryCharacteristics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|String||XmlElement()||
|+|FreeSz|Decimal||XmlElement()||
|+|TtlSz|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.MemoryUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TERA|Int32||XmlEnum("""TERA""")|1|
||PETA|Int32||XmlEnum("""PETA""")|2|
||MEGA|Int32||XmlEnum("""MEGA""")|3|
||KILO|Int32||XmlEnum("""KILO""")|4|
||GIGA|Int32||XmlEnum("""GIGA""")|5|
||EXAB|Int32||XmlEnum("""EXAB""")|6|
||BYTE|Int32||XmlEnum("""BYTE""")|7|

---

## Value ISO20022.Caaa026001.MerchantToken2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknAssrncLvl|Decimal||XmlElement()||
|+|TknRqstr|ISO20022.Caaa026001.PaymentTokenIdentifiers1||XmlElement()||
|+|TknChrtc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|Tkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validElement(TknRqstr))|

---

## Value ISO20022.Caaa026001.MobileData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctdMobData|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
|+|SnstvMobData|ISO20022.Caaa026001.SensitiveMobileData1||XmlElement()||
|+|Glctn|ISO20022.Caaa026001.Geolocation1||XmlElement()||
|+|MobMskdMSISDN|String||XmlElement()||
|+|MobNtwkCd|String||XmlElement()||
|+|MobCtryCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtctdMobData),validElement(SnstvMobData),validElement(Glctn),validPattern("""MobNtwkCd""",MobNtwkCd,"""[0-9]{2,3}"""),validPattern("""MobCtryCd""",MobCtryCd,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caaa026001.NameAndAddress3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Caaa026001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Caaa026001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Caaa026001.NetworkParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyPrfl|String||XmlElement()||
|+|ClntCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCertIdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvrCert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|Adr|global::System.Collections.Generic.List<ISO20022.Caaa026001.NetworkParameters9>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Adr""",Adr),validList("""Adr""",Adr),validElement(Adr))|

---

## Value ISO20022.Caaa026001.NetworkParameters9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrVal|String||XmlElement()||
|+|NtwkTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.NetworkType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTN|Int32||XmlEnum("""PSTN""")|1|
||IPNW|Int32||XmlEnum("""IPNW""")|2|

---

## Enum ISO20022.Caaa026001.OnLineCapability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMON|Int32||XmlEnum("""SMON""")|1|
||ONLN|Int32||XmlEnum("""ONLN""")|2|
||OFLN|Int32||XmlEnum("""OFLN""")|3|

---

## Value ISO20022.Caaa026001.OnLinePIN11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInpt|String||XmlElement()||
|+|PINFrmt|String||XmlElement()||
|+|NcrptdPINBlck|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdPINBlck))|

---

## Enum ISO20022.Caaa026001.OnLineReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IFPR|Int32||XmlEnum("""IFPR""")|1|
||CRCY|Int32||XmlEnum("""CRCY""")|2|
||FLOW|Int32||XmlEnum("""FLOW""")|3|
||CPAN|Int32||XmlEnum("""CPAN""")|4|
||UBIN|Int32||XmlEnum("""UBIN""")|5|
||CBIN|Int32||XmlEnum("""CBIN""")|6|
||TAMT|Int32||XmlEnum("""TAMT""")|7|
||EXFL|Int32||XmlEnum("""EXFL""")|8|
||FRLT|Int32||XmlEnum("""FRLT""")|9|
||ISSF|Int32||XmlEnum("""ISSF""")|10|
||TRMF|Int32||XmlEnum("""TRMF""")|11|
||MERF|Int32||XmlEnum("""MERF""")|12|
||ICCF|Int32||XmlEnum("""ICCF""")|13|
||RNDM|Int32||XmlEnum("""RNDM""")|14|

---

## Value ISO20022.Caaa026001.Organisation26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdIdr|String||XmlElement()||
|+|MrchntCtgyCd|String||XmlElement()||
|+|CtryCd|String||XmlElement()||
|+|Adr|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[0-9]{3,3}"""))|

---

## Value ISO20022.Caaa026001.Organisation41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeData|String||XmlElement()||
|+|LctnAndCtct|ISO20022.Caaa026001.CommunicationAddress9||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|CmonNm|String||XmlElement()||
|+|Id|ISO20022.Caaa026001.GenericIdentification32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LctnAndCtct),validElement(Id))|

---

## Value ISO20022.Caaa026001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Caaa026001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Caaa026001.OriginalAmountDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MaxAmt|Decimal||XmlElement()||
|+|MinAmt|Decimal||XmlElement()||
|+|ActlAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.OriginatorInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.OutputBarcode2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QRCdErrCrrctn|String||XmlElement()||
|+|QRCdNcodgMd|String||XmlElement()||
|+|QRCdVrsn|String||XmlElement()||
|+|QRCdBinryVal|String||XmlElement()||
|+|BrcdVal|String||XmlElement()||
|+|BrcdTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Enum ISO20022.Caaa026001.OutputFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||SREF|Int32||XmlEnum("""SREF""")|3|
||MREF|Int32||XmlEnum("""MREF""")|4|
||MENT|Int32||XmlEnum("""MENT""")|5|
||BARC|Int32||XmlEnum("""BARC""")|6|

---

## Enum ISO20022.Caaa026001.PINFormat3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ISO5|Int32||XmlEnum("""ISO5""")|1|
||ISO4|Int32||XmlEnum("""ISO4""")|2|
||ISO3|Int32||XmlEnum("""ISO3""")|3|
||ISO2|Int32||XmlEnum("""ISO2""")|4|
||ISO1|Int32||XmlEnum("""ISO1""")|5|
||ISO0|Int32||XmlEnum("""ISO0""")|6|

---

## Enum ISO20022.Caaa026001.POICommunicationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WT5G|Int32||XmlEnum("""WT5G""")|1|
||WT4G|Int32||XmlEnum("""WT4G""")|2|
||WT3G|Int32||XmlEnum("""WT3G""")|3|
||WT2G|Int32||XmlEnum("""WT2G""")|4|
||WIFI|Int32||XmlEnum("""WIFI""")|5|
||USBH|Int32||XmlEnum("""USBH""")|6|
||USBD|Int32||XmlEnum("""USBD""")|7|
||RS23|Int32||XmlEnum("""RS23""")|8|
||PSTN|Int32||XmlEnum("""PSTN""")|9|
||GSMF|Int32||XmlEnum("""GSMF""")|10|
||GPRS|Int32||XmlEnum("""GPRS""")|11|
||ETHR|Int32||XmlEnum("""ETHR""")|12|
||BLTH|Int32||XmlEnum("""BLTH""")|13|

---

## Enum ISO20022.Caaa026001.POIComponentAssessment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EVAL|Int32||XmlEnum("""EVAL""")|1|
||CERT|Int32||XmlEnum("""CERT""")|2|
||APPL|Int32||XmlEnum("""APPL""")|3|

---

## Enum ISO20022.Caaa026001.POIComponentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DACT|Int32||XmlEnum("""DACT""")|1|
||OPER|Int32||XmlEnum("""OPER""")|2|
||OUTD|Int32||XmlEnum("""OUTD""")|3|
||WAIT|Int32||XmlEnum("""WAIT""")|4|

---

## Enum ISO20022.Caaa026001.POIComponentType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROB|Int32||XmlEnum("""PROB""")|1|
||RPFL|Int32||XmlEnum("""RPFL""")|2|
||CONF|Int32||XmlEnum("""CONF""")|3|
||SOFT|Int32||XmlEnum("""SOFT""")|4|
||MDFL|Int32||XmlEnum("""MDFL""")|5|
||LOGF|Int32||XmlEnum("""LOGF""")|6|
||SAPR|Int32||XmlEnum("""SAPR""")|7|
||SACP|Int32||XmlEnum("""SACP""")|8|
||TMSP|Int32||XmlEnum("""TMSP""")|9|
||CRTF|Int32||XmlEnum("""CRTF""")|10|
||MRPR|Int32||XmlEnum("""MRPR""")|11|
||OPST|Int32||XmlEnum("""OPST""")|12|
||DRVR|Int32||XmlEnum("""DRVR""")|13|
||MDWR|Int32||XmlEnum("""MDWR""")|14|
||EMVO|Int32||XmlEnum("""EMVO""")|15|
||EMVK|Int32||XmlEnum("""EMVK""")|16|
||APLI|Int32||XmlEnum("""APLI""")|17|
||SECM|Int32||XmlEnum("""SECM""")|18|
||DVCE|Int32||XmlEnum("""DVCE""")|19|
||TERM|Int32||XmlEnum("""TERM""")|20|
||SERV|Int32||XmlEnum("""SERV""")|21|
||SCPR|Int32||XmlEnum("""SCPR""")|22|
||TLPR|Int32||XmlEnum("""TLPR""")|23|
||APPR|Int32||XmlEnum("""APPR""")|24|
||AQPP|Int32||XmlEnum("""AQPP""")|25|

---

## Value ISO20022.Caaa026001.PackageType5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PackgBlck|global::System.Collections.Generic.List<ISO20022.Caaa026001.ExternallyDefinedData5>||XmlElement()||
|+|OffsetEnd|Decimal||XmlElement()||
|+|OffsetStart|Decimal||XmlElement()||
|+|PackgLngth|Decimal||XmlElement()||
|+|PackgId|ISO20022.Caaa026001.GenericIdentification176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PackgBlck""",PackgBlck),validElement(PackgBlck),validElement(PackgId))|

---

## Value ISO20022.Caaa026001.Parameter12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Parameter16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OIDCrvNm|String||XmlElement()||
|+|TrlrFld|Decimal||XmlElement()||
|+|SaltLngth|Decimal||XmlElement()||
|+|MskGnrtrAlgo|ISO20022.Caaa026001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caaa026001.Parameter17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Caaa026001.AlgorithmIdentification34||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caaa026001.Parameter18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Caaa026001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Caaa026001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Caaa026001.PartyIdentification177Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Caaa026001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Caaa026001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Caaa026001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Caaa026001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Caaa026001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Enum ISO20022.Caaa026001.PartyType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICCA|Int32||XmlEnum("""ICCA""")|1|
||DLIS|Int32||XmlEnum("""DLIS""")|2|
||CISS|Int32||XmlEnum("""CISS""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|
||ITAG|Int32||XmlEnum("""ITAG""")|5|
||ACCP|Int32||XmlEnum("""ACCP""")|6|
||MERC|Int32||XmlEnum("""MERC""")|7|
||OPOI|Int32||XmlEnum("""OPOI""")|8|

---

## Enum ISO20022.Caaa026001.PartyType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMGT|Int32||XmlEnum("""TMGT""")|1|
||TAXH|Int32||XmlEnum("""TAXH""")|2|
||MTMG|Int32||XmlEnum("""MTMG""")|3|
||DLIS|Int32||XmlEnum("""DLIS""")|4|
||CISS|Int32||XmlEnum("""CISS""")|5|
||ACQR|Int32||XmlEnum("""ACQR""")|6|
||ITAG|Int32||XmlEnum("""ITAG""")|7|
||ACCP|Int32||XmlEnum("""ACCP""")|8|
||MERC|Int32||XmlEnum("""MERC""")|9|
||OPOI|Int32||XmlEnum("""OPOI""")|10|

---

## Enum ISO20022.Caaa026001.PartyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLIS|Int32||XmlEnum("""DLIS""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|
||OPOI|Int32||XmlEnum("""OPOI""")|7|

---

## Enum ISO20022.Caaa026001.PartyType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAXH|Int32||XmlEnum("""TAXH""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|

---

## Enum ISO20022.Caaa026001.PartyType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SALE|Int32||XmlEnum("""SALE""")|1|
||TMGT|Int32||XmlEnum("""TMGT""")|2|
||PCPT|Int32||XmlEnum("""PCPT""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACQR|Int32||XmlEnum("""ACQR""")|5|

---

## Value ISO20022.Caaa026001.PaymentCard35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCardData|String||XmlElement()||
|+|SvcOptn|String||XmlElement()||
|+|AllwdPdct|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IntrnlCard|String||XmlElement()||
|+|CardPdctSubTp|String||XmlElement()||
|+|CardPdctTp|String||XmlElement()||
|+|CardBrnd|String||XmlElement()||
|+|CardPdctPrfl|String||XmlElement()||
|+|CardCcyCd|String||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|IssrBIN|String||XmlElement()||
|+|MskdPAN|String||XmlElement()||
|+|PmtAcctRef|String||XmlElement()||
|+|PlainCardData|ISO20022.Caaa026001.PlainCardData22||XmlElement()||
|+|PrvtCardData|String||XmlElement()||
|+|PrtctdCardData|ISO20022.Caaa026001.ContentInformationType40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CardCcyCd""",CardCcyCd,"""[a-zA-Z0-9]{3}"""),validPattern("""IssrBIN""",IssrBIN,"""[0-9]{1,15}"""),validElement(PlainCardData),validElement(PrtctdCardData))|

---

## Value ISO20022.Caaa026001.PaymentContext29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SpprtdOptn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FllbckInd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
|+|AttndntLang|String||XmlElement()||
|+|AttndntMsgCpbl|String||XmlElement()||
|+|BizArea|String||XmlElement()||
|+|TxChanl|String||XmlElement()||
|+|TxEnvt|String||XmlElement()||
|+|AttndncCntxt|String||XmlElement()||
|+|OnLineCntxt|String||XmlElement()||
|+|CrdhldrPres|String||XmlElement()||
|+|CardPres|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.PaymentContext30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctDbtCntxt|ISO20022.Caaa026001.DirectDebitContext1||XmlElement()||
|+|CdtTrfCntxt|ISO20022.Caaa026001.CreditTransferContext1||XmlElement()||
|+|SaleCntxt|ISO20022.Caaa026001.SaleContext4||XmlElement()||
|+|PmtCntxt|ISO20022.Caaa026001.PaymentContext29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrctDbtCntxt),validElement(CdtTrfCntxt),validElement(SaleCntxt),validElement(PmtCntxt))|

---

## Value ISO20022.Caaa026001.PaymentTokenIdentifiers1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RqstrId|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.PersonIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericIdentification4>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Caaa026001.DateAndPlaceOfBirth1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|JobNb|String||XmlElement()||
|+|MplyeeIdNb|String||XmlElement()||
|+|MplyrIdNb|String||XmlElement()||
|+|IdntyCardNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|PsptNb|String||XmlElement()||
|+|AlnRegnNb|String||XmlElement()||
|+|SclSctyNb|String||XmlElement()||
|+|CstmrNb|String||XmlElement()||
|+|DrvrId|String||XmlElement()||
|+|DrvrLicNm|String||XmlElement()||
|+|DrvrLicLctn|String||XmlElement()||
|+|DrvrLicNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Caaa026001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Caaa026001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Caaa026001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Caaa026001.PhysicalInterfaceParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlParams|String||XmlElement()||
|+|SctyPrfl|String||XmlElement()||
|+|AccsCd|String||XmlElement()||
|+|UsrNm|String||XmlElement()||
|+|IntrfcTp|String||XmlElement()||
|+|IntrfcNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.PlainCardData17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtryMd|String||XmlElement()||
|+|AddtlCardData|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Trck3|String||XmlElement()||
|+|Trck2|String||XmlElement()||
|+|Trck1|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Caaa026001.PlainCardData22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrdhldrNm|String||XmlElement()||
|+|Trck3|String||XmlElement()||
|+|Trck2|String||XmlElement()||
|+|Trck1|String||XmlElement()||
|+|SvcCd|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SvcCd""",SvcCd,"""[0-9]{3}"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Enum ISO20022.Caaa026001.PlanOwner1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHP|Int32||XmlEnum("""OTHP""")|1|
||OTHN|Int32||XmlEnum("""OTHN""")|2|
||ISSR|Int32||XmlEnum("""ISSR""")|3|
||ACQR|Int32||XmlEnum("""ACQR""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|

---

## Value ISO20022.Caaa026001.PointOfInteraction15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmpnt|global::System.Collections.Generic.List<ISO20022.Caaa026001.PointOfInteractionComponent17>||XmlElement()||
|+|TermnlIntgtn|String||XmlElement()||
|+|TmZone|String||XmlElement()||
|+|Cpblties|ISO20022.Caaa026001.PointOfInteractionCapabilities9||XmlElement()||
|+|GrpId|String||XmlElement()||
|+|SysNm|String||XmlElement()||
|+|Id|ISO20022.Caaa026001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmpnt""",Cmpnt),validElement(Cmpnt),validElement(Cpblties),validElement(Id))|

---

## Value ISO20022.Caaa026001.PointOfInteractionCapabilities9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgCpblties|global::System.Collections.Generic.List<ISO20022.Caaa026001.DisplayCapabilities4>||XmlElement()||
|+|OnLineCpblties|String||XmlElement()||
|+|CardCaptrCpbl|String||XmlElement()||
|+|MxScrptLngth|Decimal||XmlElement()||
|+|ApprvlCdLngth|Decimal||XmlElement()||
|+|PINLngthCpblties|Decimal||XmlElement()||
|+|CrdhldrVrfctnCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardRdngCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MsgCpblties""",MsgCpblties),validElement(MsgCpblties))|

---

## Value ISO20022.Caaa026001.PointOfInteractionComponent17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrbVal|String||XmlElement()||
|+|Packg|global::System.Collections.Generic.List<ISO20022.Caaa026001.PackageType5>||XmlElement()||
|+|Assmnt|global::System.Collections.Generic.List<ISO20022.Caaa026001.PointOfInteractionComponentAssessment1>||XmlElement()||
|+|Chrtcs|ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10||XmlElement()||
|+|StdCmplc|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericIdentification48>||XmlElement()||
|+|Sts|ISO20022.Caaa026001.PointOfInteractionComponentStatus3||XmlElement()||
|+|Id|ISO20022.Caaa026001.PointOfInteractionComponentIdentification2||XmlElement()||
|+|SubTpInf|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Packg""",Packg),validElement(Packg),validList("""Assmnt""",Assmnt),validElement(Assmnt),validElement(Chrtcs),validList("""StdCmplc""",StdCmplc),validElement(StdCmplc),validElement(Sts),validElement(Id))|

---

## Value ISO20022.Caaa026001.PointOfInteractionComponentAssessment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|DlvryDt|DateTime||XmlElement()||
|+|Assgnr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Assgnr""",Assgnr))|

---

## Value ISO20022.Caaa026001.PointOfInteractionComponentCharacteristics10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyElmt|global::System.Collections.Generic.List<ISO20022.Caaa026001.CryptographicKey18>||XmlElement()||
|+|SbcbrIdntyMdls|Decimal||XmlElement()||
|+|SctyAccsMdls|Decimal||XmlElement()||
|+|Com|global::System.Collections.Generic.List<ISO20022.Caaa026001.CommunicationCharacteristics5>||XmlElement()||
|+|Mmry|global::System.Collections.Generic.List<ISO20022.Caaa026001.MemoryCharacteristics1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SctyElmt""",SctyElmt),validElement(SctyElmt),validList("""Com""",Com),validElement(Com),validList("""Mmry""",Mmry),validElement(Mmry))|

---

## Value ISO20022.Caaa026001.PointOfInteractionComponentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|PrvdrId|String||XmlElement()||
|+|ItmNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.PointOfInteractionComponentStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XpryDt|DateTime||XmlElement()||
|+|Sts|String||XmlElement()||
|+|VrsnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.PostalAddress1


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

## Value ISO20022.Caaa026001.PostalAddress22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryCd|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[a-zA-Z]{2,3}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Caaa026001.PostalAddress27


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
|+|AdrTp|ISO20022.Caaa026001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Caaa026001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Caaa026001.ProcessRetry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfTm|String||XmlElement()||
|+|MaxNb|Decimal||XmlElement()||
|+|Dely|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dely""",Dely,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.ProcessTiming6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfTm|String||XmlElement()||
|+|Prd|String||XmlElement()||
|+|EndTm|DateTime||XmlElement()||
|+|StartTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prd""",Prd,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.Product4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlPdctCd|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Product5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|String||XmlElement()||
|+|QtyLmt|Decimal||XmlElement()||
|+|AmtLmt|Decimal||XmlElement()||
|+|AddtlPdctCd|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.Product6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlPdctDesc|String||XmlElement()||
|+|SaleChanl|String||XmlElement()||
|+|DlvrySvc|String||XmlElement()||
|+|DlvryLctn|String||XmlElement()||
|+|PdctDesc|String||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|ValAddedTax|Decimal||XmlElement()||
|+|PdctAmtSgn|String||XmlElement()||
|+|PdctAmt|Decimal||XmlElement()||
|+|UnitPricSgn|String||XmlElement()||
|+|UnitPric|Decimal||XmlElement()||
|+|PdctQty|Decimal||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|AddtlPdctCd|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
|+|ItmId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Caaa026001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Caaa026001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Caaa026001.QRCodeEncodingMode1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NUME|Int32||XmlEnum("""NUME""")|1|
||KANJ|Int32||XmlEnum("""KANJ""")|2|
||BINA|Int32||XmlEnum("""BINA""")|3|
||ALFA|Int32||XmlEnum("""ALFA""")|4|

---

## Enum ISO20022.Caaa026001.QRCodeErrorCorrection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||L007|Int32||XmlEnum("""L007""")|1|
||H030|Int32||XmlEnum("""H030""")|2|
||Q025|Int32||XmlEnum("""Q025""")|3|
||M015|Int32||XmlEnum("""M015""")|4|

---

## Value ISO20022.Caaa026001.Recipient13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbjtKeyIdr|String||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Caaa026001.IssuerAndSerialNumber2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IssrAndSrlNb),validChoice(SbjtKeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Caaa026001.Recipient15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caaa026001.KEKIdentifier7||XmlElement()||
|+|KEK|ISO20022.Caaa026001.KEK9||XmlElement()||
|+|KeyTrnsprt|ISO20022.Caaa026001.KeyTransport10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Caaa026001.RecurringTransaction6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlanNtce|global::System.Collections.Generic.List<ISO20022.Caaa026001.ActionMessage11>||XmlElement()||
|+|GracePrd|global::System.Collections.Generic.List<ISO20022.Caaa026001.GracePeriod1>||XmlElement()||
|+|PrdUnit|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|PlanId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PlanNtce""",PlanNtce),validElement(PlanNtce),validList("""GracePrd""",GracePrd),validElement(GracePrd))|

---

## Value ISO20022.Caaa026001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.Response9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TECH|Int32||XmlEnum("""TECH""")|1|
||SUSP|Int32||XmlEnum("""SUSP""")|2|
||PART|Int32||XmlEnum("""PART""")|3|
||DECL|Int32||XmlEnum("""DECL""")|4|
||APPR|Int32||XmlEnum("""APPR""")|5|

---

## Value ISO20022.Caaa026001.ResponseType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRspnInf|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.RetailerSaleEnvironment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LltyHdlg|String||XmlElement()||
|+|DbtPrefrdFlg|String||XmlElement()||
|+|MinSpltAmt|Decimal||XmlElement()||
|+|MaxCshBckAmt|Decimal||XmlElement()||
|+|MinAmtToDlvr|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|SaleCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa026001.SaleCapabilities1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRVC|Int32||XmlEnum("""PRVC""")|1|
||PRRP|Int32||XmlEnum("""PRRP""")|2|
||PRDC|Int32||XmlEnum("""PRDC""")|3|
||POIR|Int32||XmlEnum("""POIR""")|4|
||CUIN|Int32||XmlEnum("""CUIN""")|5|
||CUER|Int32||XmlEnum("""CUER""")|6|
||CUAS|Int32||XmlEnum("""CUAS""")|7|
||CUDI|Int32||XmlEnum("""CUDI""")|8|
||CHST|Int32||XmlEnum("""CHST""")|9|
||CHIN|Int32||XmlEnum("""CHIN""")|10|
||CHER|Int32||XmlEnum("""CHER""")|11|
||CHDI|Int32||XmlEnum("""CHDI""")|12|

---

## Value ISO20022.Caaa026001.SaleContext4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSaleData|String||XmlElement()||
|+|SaleTknScp|String||XmlElement()||
|+|AllwdNtryMd|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ReuseCardDataFlg|String||XmlElement()||
|+|ForceOnlnFlg|String||XmlElement()||
|+|RmngAmt|Decimal||XmlElement()||
|+|SpltPmt|String||XmlElement()||
|+|SpnsrdMrchnt|global::System.Collections.Generic.List<ISO20022.Caaa026001.Organisation26>||XmlElement()||
|+|DlvryNoteNb|String||XmlElement()||
|+|InvcNb|String||XmlElement()||
|+|PurchsOrdrNb|String||XmlElement()||
|+|CstmrOrdrReqFlg|String||XmlElement()||
|+|ShftNb|String||XmlElement()||
|+|CshrLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CshrId|String||XmlElement()||
|+|SaleRcncltnId|String||XmlElement()||
|+|SaleRefNb|String||XmlElement()||
|+|SaleId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SpnsrdMrchnt""",SpnsrdMrchnt),validElement(SpnsrdMrchnt),validPattern("""ShftNb""",ShftNb,"""[0-9]{1,2}"""))|

---

## Enum ISO20022.Caaa026001.SaleTokenScope1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SNGL|Int32||XmlEnum("""SNGL""")|1|
||MULT|Int32||XmlEnum("""MULT""")|2|

---

## Value ISO20022.Caaa026001.SensitiveMobileData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IMEI|String||XmlElement()||
|+|IMSI|String||XmlElement()||
|+|MSISDN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IMEI""",IMEI,"""[0-9]{1,35}"""),validPattern("""IMSI""",IMSI,"""[0-9]{1,35}"""),validPattern("""MSISDN""",MSISDN,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Caaa026001.SignedData9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgnr|global::System.Collections.Generic.List<ISO20022.Caaa026001.Signer8>||XmlElement()||
|+|Cert|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caaa026001.EncapsulatedContent3||XmlElement()||
|+|DgstAlgo|global::System.Collections.Generic.List<ISO20022.Caaa026001.AlgorithmIdentification36>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Sgnr""",Sgnr),validElement(Sgnr),validElement(NcpsltdCntt),validList("""DgstAlgo""",DgstAlgo),validElement(DgstAlgo))|

---

## Value ISO20022.Caaa026001.Signer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|String||XmlElement()||
|+|SgntrAlgo|ISO20022.Caaa026001.AlgorithmIdentification33||XmlElement()||
|+|SgndAttrbts|global::System.Collections.Generic.List<ISO20022.Caaa026001.GenericInformation1>||XmlElement()||
|+|DgstAlgo|ISO20022.Caaa026001.AlgorithmIdentification36||XmlElement()||
|+|SgnrId|ISO20022.Caaa026001.Recipient13Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgntrAlgo),validList("""SgndAttrbts""",SgndAttrbts),validElement(SgndAttrbts),validElement(DgstAlgo),validElement(SgnrId))|

---

## Value ISO20022.Caaa026001.StoredValueAccount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|OwnrNm|String||XmlElement()||
|+|Prvdr|String||XmlElement()||
|+|Brnd|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|IdTp|String||XmlElement()||
|+|AcctTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caaa026001.StoredValueAccountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRVL|Int32||XmlEnum("""TRVL""")|1|
||CARD|Int32||XmlEnum("""CARD""")|2|
||PHON|Int32||XmlEnum("""PHON""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||MERC|Int32||XmlEnum("""MERC""")|5|
||OLVC|Int32||XmlEnum("""OLVC""")|6|
||MLVC|Int32||XmlEnum("""MLVC""")|7|
||GCER|Int32||XmlEnum("""GCER""")|8|
||GIFT|Int32||XmlEnum("""GIFT""")|9|
||ELMY|Int32||XmlEnum("""ELMY""")|10|
||CPYA|Int32||XmlEnum("""CPYA""")|11|
||CWVC|Int32||XmlEnum("""CWVC""")|12|
||BNKA|Int32||XmlEnum("""BNKA""")|13|

---

## Value ISO20022.Caaa026001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Caaa026001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Caaa026001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.SupportedPaymentOption2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PINQ|Int32||XmlEnum("""PINQ""")|1|
||INSI|Int32||XmlEnum("""INSI""")|2|
||MSRV|Int32||XmlEnum("""MSRV""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Caaa026001.TMSContactLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DTIM|Int32||XmlEnum("""DTIM""")|1|
||ASAP|Int32||XmlEnum("""ASAP""")|2|
||CRIT|Int32||XmlEnum("""CRIT""")|3|

---

## Value ISO20022.Caaa026001.TMSTrigger1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TMSCtctDtTm|DateTime||XmlElement()||
|+|TMSId|String||XmlElement()||
|+|TMSCtctLvl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.TimeUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||SECO|Int32||XmlEnum("""SECO""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||MINU|Int32||XmlEnum("""MINU""")|5|
||HOUR|Int32||XmlEnum("""HOUR""")|6|
||DAYC|Int32||XmlEnum("""DAYC""")|7|

---

## Value ISO20022.Caaa026001.Token1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TknInittdInd|String||XmlElement()||
|+|TknAssrncMtd|String||XmlElement()||
|+|TknAssrncData|String||XmlElement()||
|+|TknRqstrId|String||XmlElement()||
|+|TknXpryDt|String||XmlElement()||
|+|PmtTkn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TknAssrncMtd""",TknAssrncMtd,"""[0-9]{1,2}"""),validPattern("""TknRqstrId""",TknRqstrId,"""[0-9]{1,11}"""),validPattern("""TknXpryDt""",TknXpryDt,"""[0-9]{4}"""),validPattern("""PmtTkn""",PmtTkn,"""[0-9]{1,19}"""))|

---

## Value ISO20022.Caaa026001.TokenRequestComponent5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envt|ISO20022.Caaa026001.CardPaymentEnvironment81||XmlElement()||
|+|TxSeqCntr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envt),validPattern("""TxSeqCntr""",TxSeqCntr,"""[0-9]{1,9}"""))|

---

## Value ISO20022.Caaa026001.Traceability8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|PrtcolNm|String||XmlElement()||
|+|RlayId|ISO20022.Caaa026001.GenericIdentification177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Value ISO20022.Caaa026001.TrackData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckVal|String||XmlElement()||
|+|TrckFrmt|String||XmlElement()||
|+|TrckNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.TrackFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||JIS2|Int32||XmlEnum("""JIS2""")|1|
||JIS1|Int32||XmlEnum("""JIS1""")|2|
||ISOF|Int32||XmlEnum("""ISOF""")|3|
||E13B|Int32||XmlEnum("""E13B""")|4|
||CMC7|Int32||XmlEnum("""CMC7""")|5|
||AAMV|Int32||XmlEnum("""AAMV""")|6|

---

## Enum ISO20022.Caaa026001.TransactionChannel5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MPOS|Int32||XmlEnum("""MPOS""")|1|
||MOBL|Int32||XmlEnum("""MOBL""")|2|
||SECM|Int32||XmlEnum("""SECM""")|3|
||TVPY|Int32||XmlEnum("""TVPY""")|4|
||ECOM|Int32||XmlEnum("""ECOM""")|5|
||TLPH|Int32||XmlEnum("""TLPH""")|6|
||MAIL|Int32||XmlEnum("""MAIL""")|7|

---

## Enum ISO20022.Caaa026001.TransactionEnvironment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|
||MERC|Int32||XmlEnum("""MERC""")|3|

---

## Value ISO20022.Caaa026001.TransactionIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caaa026001.TransactionTotals12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmltvAmt|Decimal||XmlElement()||
|+|TtlNb|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|CardPdctPrfl|String||XmlElement()||
|+|CardBrnd|String||XmlElement()||
|+|POIGrpId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Caaa026001.TransactionVerificationResult4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|VrfctnNtty|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.TypeOfAmount8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESD|Int32||XmlEnum("""RESD""")|1|
||DECR|Int32||XmlEnum("""DECR""")|2|
||INCR|Int32||XmlEnum("""INCR""")|3|
||RPLT|Int32||XmlEnum("""RPLT""")|4|
||DFLT|Int32||XmlEnum("""DFLT""")|5|
||MAXI|Int32||XmlEnum("""MAXI""")|6|
||ESTM|Int32||XmlEnum("""ESTM""")|7|
||ACTL|Int32||XmlEnum("""ACTL""")|8|

---

## Enum ISO20022.Caaa026001.TypeTransactionTotals2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FAIL|Int32||XmlEnum("""FAIL""")|1|
||DECL|Int32||XmlEnum("""DECL""")|2|
||DBTR|Int32||XmlEnum("""DBTR""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|
||CRDR|Int32||XmlEnum("""CRDR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Enum ISO20022.Caaa026001.UnitOfMeasure6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GGEU|Int32||XmlEnum("""GGEU""")|1|
||DGEU|Int32||XmlEnum("""DGEU""")|2|
||KWHO|Int32||XmlEnum("""KWHO""")|3|
||ACRE|Int32||XmlEnum("""ACRE""")|4|
||SQIN|Int32||XmlEnum("""SQIN""")|5|
||SQFO|Int32||XmlEnum("""SQFO""")|6|
||SQYA|Int32||XmlEnum("""SQYA""")|7|
||SQMI|Int32||XmlEnum("""SQMI""")|8|
||SMIL|Int32||XmlEnum("""SMIL""")|9|
||SCMT|Int32||XmlEnum("""SCMT""")|10|
||SMET|Int32||XmlEnum("""SMET""")|11|
||ARES|Int32||XmlEnum("""ARES""")|12|
||HECT|Int32||XmlEnum("""HECT""")|13|
||SQKI|Int32||XmlEnum("""SQKI""")|14|
||YARD|Int32||XmlEnum("""YARD""")|15|
||KMET|Int32||XmlEnum("""KMET""")|16|
||MILE|Int32||XmlEnum("""MILE""")|17|
||USPI|Int32||XmlEnum("""USPI""")|18|
||GBPI|Int32||XmlEnum("""GBPI""")|19|
||USQA|Int32||XmlEnum("""USQA""")|20|
||GBQA|Int32||XmlEnum("""GBQA""")|21|
||USOU|Int32||XmlEnum("""USOU""")|22|
||GBOU|Int32||XmlEnum("""GBOU""")|23|
||MILI|Int32||XmlEnum("""MILI""")|24|
||CELI|Int32||XmlEnum("""CELI""")|25|
||LITR|Int32||XmlEnum("""LITR""")|26|
||MMET|Int32||XmlEnum("""MMET""")|27|
||CMET|Int32||XmlEnum("""CMET""")|28|
||METR|Int32||XmlEnum("""METR""")|29|
||PUND|Int32||XmlEnum("""PUND""")|30|
||KILO|Int32||XmlEnum("""KILO""")|31|
||INCH|Int32||XmlEnum("""INCH""")|32|
||GRAM|Int32||XmlEnum("""GRAM""")|33|
||USGA|Int32||XmlEnum("""USGA""")|34|
||GBGA|Int32||XmlEnum("""GBGA""")|35|
||FOOT|Int32||XmlEnum("""FOOT""")|36|
||TONS|Int32||XmlEnum("""TONS""")|37|
||PIEC|Int32||XmlEnum("""PIEC""")|38|

---

## Enum ISO20022.Caaa026001.UserInterface4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRDO|Int32||XmlEnum("""CRDO""")|1|
||MRCP|Int32||XmlEnum("""MRCP""")|2|
||MDSP|Int32||XmlEnum("""MDSP""")|3|
||CRCP|Int32||XmlEnum("""CRCP""")|4|
||CDSP|Int32||XmlEnum("""CDSP""")|5|

---

## Value ISO20022.Caaa026001.Vehicle1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlVhclData|global::System.Collections.Generic.List<ISO20022.Caaa026001.Vehicle2>||XmlElement()||
|+|DrvrOrVhclCard|ISO20022.Caaa026001.PlainCardData17||XmlElement()||
|+|MntncId|String||XmlElement()||
|+|RefrHrs|String||XmlElement()||
|+|TrlrHrs|String||XmlElement()||
|+|Hbmtr|Decimal||XmlElement()||
|+|Odmtr|Decimal||XmlElement()||
|+|RplcmntCar|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|VhclTagNtryMd|String||XmlElement()||
|+|VhclTag|String||XmlElement()||
|+|TrlrNb|String||XmlElement()||
|+|VhclNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlVhclData""",AddtlVhclData),validElement(AddtlVhclData),validElement(DrvrOrVhclCard),validPattern("""UnitNb""",UnitNb,"""[0-9]{1,35}"""),validPattern("""TrlrNb""",TrlrNb,"""[0-9]{1,35}"""),validPattern("""VhclNb""",VhclNb,"""[0-9]{1,35}"""))|

---

## Value ISO20022.Caaa026001.Vehicle2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Data|String||XmlElement()||
|+|NtryMd|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caaa026001.Verification1Code


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

