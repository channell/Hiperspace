# catp.012.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Catp012001.ATMConfigurationParameter1 {
        + Vrsn  : String
        + Tp  : String
    }
    class ISO20022.Catp012001.ATMContext10 {
        + Svc  : ISO20022.Catp012001.ATMService11
        + SsnRef  : String
    }
    ISO20022.Catp012001.ATMContext10 *-- ISO20022.Catp012001.ATMService11
    class ISO20022.Catp012001.ATMCustomer8 {
        + AuthntcnRslt  : global::System.Collections.Generic.List~ISO20022.Catp012001.TransactionVerificationResult5~
        + Authntcn  : global::System.Collections.Generic.List~ISO20022.Catp012001.CardholderAuthentication8~
        + SelctdLang  : String
        + Prfl  : ISO20022.Catp012001.ATMCustomerProfile6
    }
    ISO20022.Catp012001.ATMCustomer8 *-- ISO20022.Catp012001.TransactionVerificationResult5
    ISO20022.Catp012001.ATMCustomer8 *-- ISO20022.Catp012001.CardholderAuthentication8
    ISO20022.Catp012001.ATMCustomer8 *-- ISO20022.Catp012001.ATMCustomerProfile6
    class ISO20022.Catp012001.ATMCustomerProfile1Code {
        PREQ = 1
        OREQ = 2
        CRDF = 3
    }
    class ISO20022.Catp012001.ATMCustomerProfile6 {
        + PrefrdLang  : String
        + CstmrId  : String
        + PrflRef  : String
        + RtrvlMd  : String
    }
    class ISO20022.Catp012001.ATMDepositComponent1 {
        + DpstdMdia  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMDepositedMedia4~
        + DtldReqdAmt  : global::System.Collections.Generic.List~ISO20022.Catp012001.DetailedAmount16~
        + PrtctdAcctData  : global::System.Collections.Generic.List~ISO20022.Catp012001.ContentInformationType10~
        + AcctData  : global::System.Collections.Generic.List~ISO20022.Catp012001.CardAccount21~
        + SubDpstId  : String
    }
    ISO20022.Catp012001.ATMDepositComponent1 *-- ISO20022.Catp012001.ATMDepositedMedia4
    ISO20022.Catp012001.ATMDepositComponent1 *-- ISO20022.Catp012001.DetailedAmount16
    ISO20022.Catp012001.ATMDepositComponent1 *-- ISO20022.Catp012001.ContentInformationType10
    ISO20022.Catp012001.ATMDepositComponent1 *-- ISO20022.Catp012001.CardAccount21
    class ISO20022.Catp012001.ATMDepositRequest2 {
        + Tx  : ISO20022.Catp012001.ATMTransaction50
        + Cntxt  : ISO20022.Catp012001.ATMContext10
        + Envt  : ISO20022.Catp012001.ATMEnvironment18
    }
    ISO20022.Catp012001.ATMDepositRequest2 *-- ISO20022.Catp012001.ATMTransaction50
    ISO20022.Catp012001.ATMDepositRequest2 *-- ISO20022.Catp012001.ATMContext10
    ISO20022.Catp012001.ATMDepositRequest2 *-- ISO20022.Catp012001.ATMEnvironment18
    class ISO20022.Catp012001.ATMDepositRequestV02 {
        + SctyTrlr  : ISO20022.Catp012001.ContentInformationType15
        + ATMDpstReq  : ISO20022.Catp012001.ATMDepositRequest2
        + PrtctdATMDpstReq  : ISO20022.Catp012001.ContentInformationType10
        + Hdr  : ISO20022.Catp012001.Header31
    }
    ISO20022.Catp012001.ATMDepositRequestV02 *-- ISO20022.Catp012001.ContentInformationType15
    ISO20022.Catp012001.ATMDepositRequestV02 *-- ISO20022.Catp012001.ATMDepositRequest2
    ISO20022.Catp012001.ATMDepositRequestV02 *-- ISO20022.Catp012001.ContentInformationType10
    ISO20022.Catp012001.ATMDepositRequestV02 *-- ISO20022.Catp012001.Header31
    class ISO20022.Catp012001.ATMDepositedMedia4 {
        + MdiaItm  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMDepositedMediaItem1~
        + MdiaCtgy  : String
        + MdiaTp  : String
        + AcctSeqNb  : Decimal
    }
    ISO20022.Catp012001.ATMDepositedMedia4 *-- ISO20022.Catp012001.ATMDepositedMediaItem1
    class ISO20022.Catp012001.ATMDepositedMediaItem1 {
        + AddtlData  : global::System.Collections.Generic.List~ISO20022.Catp012001.GenericInformation1~
        + Ref  : String
        + RjctdRsn  : String
        + MdiaSts  : String
        + CnfdncLvl  : Decimal
        + ScnndVal  : Decimal
        + CdLine  : String
        + CdLineFrmt  : String
        + Ccy  : String
        + UnitVal  : Decimal
        + Cnt  : Decimal
        + MdiaId  : String
    }
    ISO20022.Catp012001.ATMDepositedMediaItem1 *-- ISO20022.Catp012001.GenericInformation1
    class ISO20022.Catp012001.ATMEnvironment18 {
        + Card  : ISO20022.Catp012001.PaymentCard36
        + Cstmr  : ISO20022.Catp012001.ATMCustomer8
        + ATM  : ISO20022.Catp012001.AutomatedTellerMachine12
        + HstgNtty  : ISO20022.Catp012001.TerminalHosting1
        + ATMMgrId  : String
        + Acqrr  : ISO20022.Catp012001.Acquirer7
    }
    ISO20022.Catp012001.ATMEnvironment18 *-- ISO20022.Catp012001.PaymentCard36
    ISO20022.Catp012001.ATMEnvironment18 *-- ISO20022.Catp012001.ATMCustomer8
    ISO20022.Catp012001.ATMEnvironment18 *-- ISO20022.Catp012001.AutomatedTellerMachine12
    ISO20022.Catp012001.ATMEnvironment18 *-- ISO20022.Catp012001.TerminalHosting1
    ISO20022.Catp012001.ATMEnvironment18 *-- ISO20022.Catp012001.Acquirer7
    class ISO20022.Catp012001.ATMEquipment1 {
        + CfgtnParam  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMConfigurationParameter1~
        + ApprvlNb  : String
        + ApplVrsn  : String
        + ApplNm  : String
        + ApplPrvdr  : String
        + SrlNb  : String
        + Mdl  : String
        + Manfctr  : String
    }
    ISO20022.Catp012001.ATMEquipment1 *-- ISO20022.Catp012001.ATMConfigurationParameter1
    class ISO20022.Catp012001.ATMMediaStatus1Code {
        REJT = 1
        ACPT = 2
    }
    class ISO20022.Catp012001.ATMMediaType1Code {
        UDTM = 1
        STMP = 2
        NOTE = 3
        CPNS = 4
        CMDT = 5
        COIN = 6
        CARD = 7
    }
    class ISO20022.Catp012001.ATMMediaType3Code {
        UNRG = 1
        UNFT = 2
        SPCT = 3
        FITU = 4
        FITN = 5
        CNTR = 6
    }
    class ISO20022.Catp012001.ATMMediaType4Code {
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
    class ISO20022.Catp012001.ATMMessageFunction2 {
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + Fctn  : String
    }
    class ISO20022.Catp012001.ATMService11 {
        + MultiAcct  : String
        + CshBck  : String
        + SvcVarntId  : global::System.Collections.Generic.List~String~
        + SvcTp  : String
        + ATMSvcCd  : String
        + SvcRef  : String
    }
    class ISO20022.Catp012001.ATMServiceType6Code {
        DPSV = 1
        DPSN = 2
        MCHG = 3
    }
    class ISO20022.Catp012001.ATMTransaction50 {
        + ICCRltdData  : String
        + ReqdRct  : String
        + TtlAmt  : ISO20022.Catp012001.AmountAndCurrency1
        + SubDpst  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMDepositComponent1~
        + TtlReqdAmt  : Decimal
        + RcncltnId  : String
        + TxId  : ISO20022.Catp012001.TransactionIdentifier3
    }
    ISO20022.Catp012001.ATMTransaction50 *-- ISO20022.Catp012001.AmountAndCurrency1
    ISO20022.Catp012001.ATMTransaction50 *-- ISO20022.Catp012001.ATMDepositComponent1
    ISO20022.Catp012001.ATMTransaction50 *-- ISO20022.Catp012001.TransactionIdentifier3
    class ISO20022.Catp012001.ATMTransactionAmounts10 {
        + DispFlg  : String
        + MaxNb  : Decimal
        + MinNb  : Decimal
        + Ccy  : String
        + MdiaTp  : String
    }
    class ISO20022.Catp012001.ATMTransactionAmounts11 {
        + DpstLmts  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMTransactionAmounts10~
        + AddtlAmt  : global::System.Collections.Generic.List~ISO20022.Catp012001.ATMTransactionAmounts7~
        + MinPssblAmt  : Decimal
        + MaxPssblAmt  : Decimal
        + Ccy  : String
    }
    ISO20022.Catp012001.ATMTransactionAmounts11 *-- ISO20022.Catp012001.ATMTransactionAmounts10
    ISO20022.Catp012001.ATMTransactionAmounts11 *-- ISO20022.Catp012001.ATMTransactionAmounts7
    class ISO20022.Catp012001.ATMTransactionAmounts7 {
        + Labl  : String
        + Ccy  : String
        + Amt  : Decimal
        + Tp  : String
    }
    class ISO20022.Catp012001.AccountChoiceMethod1Code {
        TPSL = 1
        NOSL = 2
        IMPL = 3
        IMAC = 4
        ENTR = 5
        ACSL = 6
    }
    class ISO20022.Catp012001.AccountIdentification80Choice {
        + Email  : String
        + MSISDN  : String
        + DmstAcct  : ISO20022.Catp012001.SimpleIdentificationInformation4
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Catp012001.AccountIdentification80Choice *-- ISO20022.Catp012001.SimpleIdentificationInformation4
    class ISO20022.Catp012001.Acquirer7 {
        + Brnch  : String
        + AcqrgInstn  : String
    }
    class ISO20022.Catp012001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Catp012001.Algorithm11Code {
        HS01 = 1
        HS51 = 2
        HS38 = 3
        HS25 = 4
    }
    class ISO20022.Catp012001.Algorithm12Code {
        CMA5 = 1
        CMA9 = 2
        MCC1 = 3
        CMA1 = 4
        MCCS = 5
        MACC = 6
    }
    class ISO20022.Catp012001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Catp012001.Algorithm15Code {
        EA5C = 1
        EA9C = 2
        E3DC = 3
        EA2C = 4
    }
    class ISO20022.Catp012001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Catp012001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Catp012001.AlgorithmIdentification11 {
        + Param  : ISO20022.Catp012001.Parameter4
        + Algo  : String
    }
    ISO20022.Catp012001.AlgorithmIdentification11 *-- ISO20022.Catp012001.Parameter4
    class ISO20022.Catp012001.AlgorithmIdentification12 {
        + Param  : ISO20022.Catp012001.Parameter5
        + Algo  : String
    }
    ISO20022.Catp012001.AlgorithmIdentification12 *-- ISO20022.Catp012001.Parameter5
    class ISO20022.Catp012001.AlgorithmIdentification13 {
        + Param  : ISO20022.Catp012001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp012001.AlgorithmIdentification13 *-- ISO20022.Catp012001.Parameter6
    class ISO20022.Catp012001.AlgorithmIdentification14 {
        + Param  : ISO20022.Catp012001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp012001.AlgorithmIdentification14 *-- ISO20022.Catp012001.Parameter6
    class ISO20022.Catp012001.AlgorithmIdentification15 {
        + Param  : ISO20022.Catp012001.Parameter7
        + Algo  : String
    }
    ISO20022.Catp012001.AlgorithmIdentification15 *-- ISO20022.Catp012001.Parameter7
    class ISO20022.Catp012001.AmountAndCurrency1 {
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp012001.AmountAndDirection111 {
        + Labl  : String
        + Dt  : DateTime
        + Sgn  : String
        + Amt  : ISO20022.Catp012001.CurrencyAndAmount
    }
    ISO20022.Catp012001.AmountAndDirection111 *-- ISO20022.Catp012001.CurrencyAndAmount
    class ISO20022.Catp012001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Catp012001.AuthenticatedData4 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Catp012001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Catp012001.AlgorithmIdentification15
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp012001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp012001.AuthenticatedData4 *-- ISO20022.Catp012001.EncapsulatedContent3
    ISO20022.Catp012001.AuthenticatedData4 *-- ISO20022.Catp012001.AlgorithmIdentification15
    ISO20022.Catp012001.AuthenticatedData4 *-- ISO20022.Catp012001.Recipient4Choice
    class ISO20022.Catp012001.AuthenticationEntity2Code {
        TRML = 1
        ISSR = 2
        ACQR = 3
        MERC = 4
        AGNT = 5
        ICCD = 6
    }
    class ISO20022.Catp012001.AuthenticationMethod7Code {
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
    class ISO20022.Catp012001.AutomatedTellerMachine12 {
        + Eqpmnt  : ISO20022.Catp012001.ATMEquipment1
        + Cpblties  : ISO20022.Catp012001.PointOfInteractionCapabilities10
        + LctnCtgy  : String
        + Lctn  : ISO20022.Catp012001.PostalAddress17
        + BaseCcy  : String
        + SeqNb  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Catp012001.AutomatedTellerMachine12 *-- ISO20022.Catp012001.ATMEquipment1
    ISO20022.Catp012001.AutomatedTellerMachine12 *-- ISO20022.Catp012001.PointOfInteractionCapabilities10
    ISO20022.Catp012001.AutomatedTellerMachine12 *-- ISO20022.Catp012001.PostalAddress17
    class ISO20022.Catp012001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Catp012001.CardAccount21 {
        + Lmts  : ISO20022.Catp012001.ATMTransactionAmounts11
        + DfltAcctInd  : String
        + BalDispFlg  : String
        + Bal  : ISO20022.Catp012001.AmountAndDirection111
        + Svcr  : ISO20022.Catp012001.PartyIdentification177Choice
        + CdtRef  : String
        + AcctIdr  : ISO20022.Catp012001.AccountIdentification80Choice
        + Ccy  : String
        + AcctOwnr  : ISO20022.Catp012001.NameAndAddress3
        + AcctNm  : String
        + SelctdAcctTp  : String
        + SelctnMtd  : String
        + AcctSeqNb  : Decimal
    }
    ISO20022.Catp012001.CardAccount21 *-- ISO20022.Catp012001.ATMTransactionAmounts11
    ISO20022.Catp012001.CardAccount21 *-- ISO20022.Catp012001.AmountAndDirection111
    ISO20022.Catp012001.CardAccount21 *-- ISO20022.Catp012001.PartyIdentification177Choice
    ISO20022.Catp012001.CardAccount21 *-- ISO20022.Catp012001.AccountIdentification80Choice
    ISO20022.Catp012001.CardAccount21 *-- ISO20022.Catp012001.NameAndAddress3
    class ISO20022.Catp012001.CardAccountType3Code {
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
    class ISO20022.Catp012001.CardDataReading1Code {
        ECTL = 1
        CTLS = 2
        DFLE = 3
        CICC = 4
        MGST = 5
        BRCD = 6
        PHYS = 7
        TAGC = 8
    }
    class ISO20022.Catp012001.CardDataReading4Code {
        CTLS = 1
        MGST = 2
        CICC = 3
        ECTL = 4
    }
    class ISO20022.Catp012001.CardholderAuthentication8 {
        + CrdhldrOnLinePIN  : ISO20022.Catp012001.OnLinePIN5
        + PrtctdAuthntcnVal  : ISO20022.Catp012001.ContentInformationType10
        + AuthntcnVal  : String
        + TknReqd  : String
        + AuthntcnMtd  : String
    }
    ISO20022.Catp012001.CardholderAuthentication8 *-- ISO20022.Catp012001.OnLinePIN5
    ISO20022.Catp012001.CardholderAuthentication8 *-- ISO20022.Catp012001.ContentInformationType10
    class ISO20022.Catp012001.CardholderVerificationCapability3Code {
        PCOD = 1
        PKIS = 2
        FBIG = 3
        FBIO = 4
        FDSG = 5
        FEPN = 6
        FCPN = 7
        NPIN = 8
    }
    class ISO20022.Catp012001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Catp012001.RelativeDistinguishedName1~
    }
    ISO20022.Catp012001.CertificateIssuer1 *-- ISO20022.Catp012001.RelativeDistinguishedName1
    class ISO20022.Catp012001.CheckCodeLine1Code {
        OCRF = 1
        OCRB = 2
        OCRA = 3
        E13B = 4
        CMC7 = 5
    }
    class ISO20022.Catp012001.ContentInformationType10 {
        + EnvlpdData  : ISO20022.Catp012001.EnvelopedData4
        + CnttTp  : String
    }
    ISO20022.Catp012001.ContentInformationType10 *-- ISO20022.Catp012001.EnvelopedData4
    class ISO20022.Catp012001.ContentInformationType15 {
        + AuthntcdData  : ISO20022.Catp012001.AuthenticatedData4
        + CnttTp  : String
    }
    ISO20022.Catp012001.ContentInformationType15 *-- ISO20022.Catp012001.AuthenticatedData4
    class ISO20022.Catp012001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Catp012001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Catp012001.DataSetCategory7Code {
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
    class ISO20022.Catp012001.DetailedAmount13 {
        + Labl  : String
        + Ccy  : String
        + Amt  : Decimal
    }
    class ISO20022.Catp012001.DetailedAmount16 {
        + Dontn  : global::System.Collections.Generic.List~ISO20022.Catp012001.DetailedAmount13~
        + Fees  : global::System.Collections.Generic.List~ISO20022.Catp012001.DetailedAmount13~
        + CshBckAmt  : Decimal
        + Ccy  : String
        + AmtToDpst  : Decimal
        + AcctSeqNb  : Decimal
    }
    ISO20022.Catp012001.DetailedAmount16 *-- ISO20022.Catp012001.DetailedAmount13
    ISO20022.Catp012001.DetailedAmount16 *-- ISO20022.Catp012001.DetailedAmount13
    class ISO20022.Catp012001.DisplayCapabilities5 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Catp012001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Catp012001.EncryptedContent3 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Catp012001.AlgorithmIdentification14
        + CnttTp  : String
    }
    ISO20022.Catp012001.EncryptedContent3 *-- ISO20022.Catp012001.AlgorithmIdentification14
    class ISO20022.Catp012001.EncryptionFormat1Code {
        TR34 = 1
        TR31 = 2
    }
    class ISO20022.Catp012001.EnvelopedData4 {
        + NcrptdCntt  : ISO20022.Catp012001.EncryptedContent3
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp012001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp012001.EnvelopedData4 *-- ISO20022.Catp012001.EncryptedContent3
    ISO20022.Catp012001.EnvelopedData4 *-- ISO20022.Catp012001.Recipient4Choice
    class ISO20022.Catp012001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Catp012001.GenericIdentification77 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catp012001.GenericInformation1 {
        + Val  : String
        + Nm  : String
    }
    class ISO20022.Catp012001.GeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Catp012001.GeographicLocation1Choice {
        + UTMCordints  : ISO20022.Catp012001.UTMCoordinates1
        + GeogcCordints  : ISO20022.Catp012001.GeographicCoordinates1
    }
    ISO20022.Catp012001.GeographicLocation1Choice *-- ISO20022.Catp012001.UTMCoordinates1
    ISO20022.Catp012001.GeographicLocation1Choice *-- ISO20022.Catp012001.GeographicCoordinates1
    class ISO20022.Catp012001.Header31 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Catp012001.Traceability4~
        + PrcStat  : String
        + RcptPty  : String
        + InitgPty  : String
        + CreDtTm  : DateTime
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : ISO20022.Catp012001.ATMMessageFunction2
    }
    ISO20022.Catp012001.Header31 *-- ISO20022.Catp012001.Traceability4
    ISO20022.Catp012001.Header31 *-- ISO20022.Catp012001.ATMMessageFunction2
    class ISO20022.Catp012001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Catp012001.CertificateIssuer1
    }
    ISO20022.Catp012001.IssuerAndSerialNumber1 *-- ISO20022.Catp012001.CertificateIssuer1
    class ISO20022.Catp012001.KEK4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp012001.AlgorithmIdentification13
        + KEKId  : ISO20022.Catp012001.KEKIdentifier2
        + Vrsn  : Decimal
    }
    ISO20022.Catp012001.KEK4 *-- ISO20022.Catp012001.AlgorithmIdentification13
    ISO20022.Catp012001.KEK4 *-- ISO20022.Catp012001.KEKIdentifier2
    class ISO20022.Catp012001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catp012001.KeyTransport4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp012001.AlgorithmIdentification11
        + RcptId  : ISO20022.Catp012001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catp012001.KeyTransport4 *-- ISO20022.Catp012001.AlgorithmIdentification11
    ISO20022.Catp012001.KeyTransport4 *-- ISO20022.Catp012001.Recipient5Choice
    class ISO20022.Catp012001.MessageFunction11Code {
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
    class ISO20022.Catp012001.NameAndAddress3 {
        + Adr  : ISO20022.Catp012001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Catp012001.NameAndAddress3 *-- ISO20022.Catp012001.PostalAddress1
    class ISO20022.Catp012001.OnLinePIN5 {
        + AddtlInpt  : String
        + PINFrmt  : String
        + NcrptdPINBlck  : ISO20022.Catp012001.ContentInformationType10
    }
    ISO20022.Catp012001.OnLinePIN5 *-- ISO20022.Catp012001.ContentInformationType10
    class ISO20022.Catp012001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Catp012001.PINFormat4Code {
        VIS3 = 1
        VIS2 = 2
        ISO5 = 3
        ISO4 = 4
        ISO3 = 5
        ISO2 = 6
        ISO1 = 7
        ISO0 = 8
        IBM3 = 9
        EMVS = 10
        ECI3 = 11
        ECI2 = 12
        DBLC = 13
        DBLD = 14
        BKSY = 15
        BNCM = 16
        ANSI = 17
    }
    class ISO20022.Catp012001.Parameter4 {
        + MskGnrtrAlgo  : ISO20022.Catp012001.AlgorithmIdentification12
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Catp012001.Parameter4 *-- ISO20022.Catp012001.AlgorithmIdentification12
    class ISO20022.Catp012001.Parameter5 {
        + DgstAlgo  : String
    }
    class ISO20022.Catp012001.Parameter6 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Catp012001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Catp012001.PartyIdentification177Choice {
        + PrtryId  : ISO20022.Catp012001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Catp012001.PartyIdentification177Choice *-- ISO20022.Catp012001.GenericIdentification1
    class ISO20022.Catp012001.PartyType12Code {
        OATM = 1
        ITAG = 2
        HSTG = 3
        DLIS = 4
        CISP = 5
        ATMG = 6
        ACQR = 7
    }
    class ISO20022.Catp012001.PaymentCard36 {
        + CardCcyCd  : String
        + CardCtryCd  : String
        + PlainCardData  : ISO20022.Catp012001.PlainCardData25
        + PrtctdCardData  : ISO20022.Catp012001.ContentInformationType10
        + FllbckInd  : String
        + CardDataNtryMd  : String
    }
    ISO20022.Catp012001.PaymentCard36 *-- ISO20022.Catp012001.PlainCardData25
    ISO20022.Catp012001.PaymentCard36 *-- ISO20022.Catp012001.ContentInformationType10
    class ISO20022.Catp012001.PlainCardData25 {
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
    class ISO20022.Catp012001.PointOfInteractionCapabilities10 {
        + RctPrtg  : String
        + IntractvTxs  : global::System.Collections.Generic.List~String~
        + MsgCpblties  : global::System.Collections.Generic.List~ISO20022.Catp012001.DisplayCapabilities5~
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
    ISO20022.Catp012001.PointOfInteractionCapabilities10 *-- ISO20022.Catp012001.DisplayCapabilities5
    class ISO20022.Catp012001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Catp012001.PostalAddress17 {
        + GLctn  : ISO20022.Catp012001.GeographicLocation1Choice
        + Ctry  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catp012001.PostalAddress17 *-- ISO20022.Catp012001.GeographicLocation1Choice
    class ISO20022.Catp012001.Recipient4Choice {
        + KeyIdr  : ISO20022.Catp012001.KEKIdentifier2
        + KEK  : ISO20022.Catp012001.KEK4
        + KeyTrnsprt  : ISO20022.Catp012001.KeyTransport4
    }
    ISO20022.Catp012001.Recipient4Choice *-- ISO20022.Catp012001.KEKIdentifier2
    ISO20022.Catp012001.Recipient4Choice *-- ISO20022.Catp012001.KEK4
    ISO20022.Catp012001.Recipient4Choice *-- ISO20022.Catp012001.KeyTransport4
    class ISO20022.Catp012001.Recipient5Choice {
        + KeyIdr  : ISO20022.Catp012001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Catp012001.IssuerAndSerialNumber1
    }
    ISO20022.Catp012001.Recipient5Choice *-- ISO20022.Catp012001.KEKIdentifier2
    ISO20022.Catp012001.Recipient5Choice *-- ISO20022.Catp012001.IssuerAndSerialNumber1
    class ISO20022.Catp012001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catp012001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Catp012001.TerminalHosting1 {
        + Id  : String
        + Ctgy  : String
    }
    class ISO20022.Catp012001.Traceability4 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + SeqNb  : String
        + RlayId  : ISO20022.Catp012001.GenericIdentification77
    }
    ISO20022.Catp012001.Traceability4 *-- ISO20022.Catp012001.GenericIdentification77
    class ISO20022.Catp012001.TransactionEnvironment2Code {
        PUBL = 1
        PRIV = 2
    }
    class ISO20022.Catp012001.TransactionEnvironment3Code {
        OTHR = 1
        MERC = 2
        BRCH = 3
    }
    class ISO20022.Catp012001.TransactionIdentifier3 {
        + TxRef  : String
        + HstTxDtTm  : DateTime
        + TxDtTm  : DateTime
    }
    class ISO20022.Catp012001.TransactionVerificationResult5 {
        + AuthntcnTkn  : String
        + AddtlRslt  : String
        + Rslt  : String
        + VrfctnNtty  : String
        + Mtd  : String
    }
    class ISO20022.Catp012001.UTMCoordinates1 {
        + UTMNrthwrd  : Decimal
        + UTMEstwrd  : Decimal
        + UTMZone  : String
    }
    class ISO20022.Catp012001.UserInterface5Code {
        CRDO = 1
        CRCP = 2
        CDSP = 3
    }
    class ISO20022.Catp012001.Verification1Code {
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

## Value ISO20022.Catp012001.ATMConfigurationParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.ATMContext10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svc|ISO20022.Catp012001.ATMService11||XmlElement()||
|+|SsnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svc))|

---

## Value ISO20022.Catp012001.ATMCustomer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnRslt|global::System.Collections.Generic.List<ISO20022.Catp012001.TransactionVerificationResult5>||XmlElement()||
|+|Authntcn|global::System.Collections.Generic.List<ISO20022.Catp012001.CardholderAuthentication8>||XmlElement()||
|+|SelctdLang|String||XmlElement()||
|+|Prfl|ISO20022.Catp012001.ATMCustomerProfile6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AuthntcnRslt""",AuthntcnRslt),validElement(AuthntcnRslt),validRequired("""Authntcn""",Authntcn),validList("""Authntcn""",Authntcn),validElement(Authntcn),validElement(Prfl))|

---

## Enum ISO20022.Catp012001.ATMCustomerProfile1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREQ|Int32||XmlEnum("""PREQ""")|1|
||OREQ|Int32||XmlEnum("""OREQ""")|2|
||CRDF|Int32||XmlEnum("""CRDF""")|3|

---

## Value ISO20022.Catp012001.ATMCustomerProfile6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdLang|String||XmlElement()||
|+|CstmrId|String||XmlElement()||
|+|PrflRef|String||XmlElement()||
|+|RtrvlMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.ATMDepositComponent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DpstdMdia|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMDepositedMedia4>||XmlElement()||
|+|DtldReqdAmt|global::System.Collections.Generic.List<ISO20022.Catp012001.DetailedAmount16>||XmlElement()||
|+|PrtctdAcctData|global::System.Collections.Generic.List<ISO20022.Catp012001.ContentInformationType10>||XmlElement()||
|+|AcctData|global::System.Collections.Generic.List<ISO20022.Catp012001.CardAccount21>||XmlElement()||
|+|SubDpstId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DpstdMdia""",DpstdMdia),validElement(DpstdMdia),validList("""DtldReqdAmt""",DtldReqdAmt),validElement(DtldReqdAmt),validList("""PrtctdAcctData""",PrtctdAcctData),validElement(PrtctdAcctData),validList("""AcctData""",AcctData),validElement(AcctData))|

---

## Value ISO20022.Catp012001.ATMDepositRequest2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Catp012001.ATMTransaction50||XmlElement()||
|+|Cntxt|ISO20022.Catp012001.ATMContext10||XmlElement()||
|+|Envt|ISO20022.Catp012001.ATMEnvironment18||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt))|

---

## Aspect ISO20022.Catp012001.ATMDepositRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Catp012001.ContentInformationType15||XmlElement()||
|+|ATMDpstReq|ISO20022.Catp012001.ATMDepositRequest2||XmlElement()||
|+|PrtctdATMDpstReq|ISO20022.Catp012001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp012001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDpstReq),validElement(PrtctdATMDpstReq),validElement(Hdr))|

---

## Value ISO20022.Catp012001.ATMDepositedMedia4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MdiaItm|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMDepositedMediaItem1>||XmlElement()||
|+|MdiaCtgy|String||XmlElement()||
|+|MdiaTp|String||XmlElement()||
|+|AcctSeqNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""MdiaItm""",MdiaItm),validList("""MdiaItm""",MdiaItm),validElement(MdiaItm))|

---

## Value ISO20022.Catp012001.ATMDepositedMediaItem1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlData|global::System.Collections.Generic.List<ISO20022.Catp012001.GenericInformation1>||XmlElement()||
|+|Ref|String||XmlElement()||
|+|RjctdRsn|String||XmlElement()||
|+|MdiaSts|String||XmlElement()||
|+|CnfdncLvl|Decimal||XmlElement()||
|+|ScnndVal|Decimal||XmlElement()||
|+|CdLine|String||XmlElement()||
|+|CdLineFrmt|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|UnitVal|Decimal||XmlElement()||
|+|Cnt|Decimal||XmlElement()||
|+|MdiaId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlData""",AddtlData),validElement(AddtlData),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.ATMEnvironment18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Card|ISO20022.Catp012001.PaymentCard36||XmlElement()||
|+|Cstmr|ISO20022.Catp012001.ATMCustomer8||XmlElement()||
|+|ATM|ISO20022.Catp012001.AutomatedTellerMachine12||XmlElement()||
|+|HstgNtty|ISO20022.Catp012001.TerminalHosting1||XmlElement()||
|+|ATMMgrId|String||XmlElement()||
|+|Acqrr|ISO20022.Catp012001.Acquirer7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Card),validElement(Cstmr),validElement(ATM),validElement(HstgNtty),validElement(Acqrr))|

---

## Value ISO20022.Catp012001.ATMEquipment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CfgtnParam|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMConfigurationParameter1>||XmlElement()||
|+|ApprvlNb|String||XmlElement()||
|+|ApplVrsn|String||XmlElement()||
|+|ApplNm|String||XmlElement()||
|+|ApplPrvdr|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CfgtnParam""",CfgtnParam),validElement(CfgtnParam))|

---

## Enum ISO20022.Catp012001.ATMMediaStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REJT|Int32||XmlEnum("""REJT""")|1|
||ACPT|Int32||XmlEnum("""ACPT""")|2|

---

## Enum ISO20022.Catp012001.ATMMediaType1Code


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

## Enum ISO20022.Catp012001.ATMMediaType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNRG|Int32||XmlEnum("""UNRG""")|1|
||UNFT|Int32||XmlEnum("""UNFT""")|2|
||SPCT|Int32||XmlEnum("""SPCT""")|3|
||FITU|Int32||XmlEnum("""FITU""")|4|
||FITN|Int32||XmlEnum("""FITN""")|5|
||CNTR|Int32||XmlEnum("""CNTR""")|6|

---

## Enum ISO20022.Catp012001.ATMMediaType4Code


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

## Value ISO20022.Catp012001.ATMMessageFunction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|Fctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.ATMService11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MultiAcct|String||XmlElement()||
|+|CshBck|String||XmlElement()||
|+|SvcVarntId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvcTp|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|SvcRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp012001.ATMServiceType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DPSV|Int32||XmlEnum("""DPSV""")|1|
||DPSN|Int32||XmlEnum("""DPSN""")|2|
||MCHG|Int32||XmlEnum("""MCHG""")|3|

---

## Value ISO20022.Catp012001.ATMTransaction50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ICCRltdData|String||XmlElement()||
|+|ReqdRct|String||XmlElement()||
|+|TtlAmt|ISO20022.Catp012001.AmountAndCurrency1||XmlElement()||
|+|SubDpst|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMDepositComponent1>||XmlElement()||
|+|TtlReqdAmt|Decimal||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|TxId|ISO20022.Catp012001.TransactionIdentifier3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlAmt),validList("""SubDpst""",SubDpst),validElement(SubDpst),validElement(TxId))|

---

## Value ISO20022.Catp012001.ATMTransactionAmounts10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DispFlg|String||XmlElement()||
|+|MaxNb|Decimal||XmlElement()||
|+|MinNb|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|MdiaTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.ATMTransactionAmounts11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DpstLmts|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMTransactionAmounts10>||XmlElement()||
|+|AddtlAmt|global::System.Collections.Generic.List<ISO20022.Catp012001.ATMTransactionAmounts7>||XmlElement()||
|+|MinPssblAmt|Decimal||XmlElement()||
|+|MaxPssblAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DpstLmts""",DpstLmts),validElement(DpstLmts),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.ATMTransactionAmounts7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp012001.AccountChoiceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TPSL|Int32||XmlEnum("""TPSL""")|1|
||NOSL|Int32||XmlEnum("""NOSL""")|2|
||IMPL|Int32||XmlEnum("""IMPL""")|3|
||IMAC|Int32||XmlEnum("""IMAC""")|4|
||ENTR|Int32||XmlEnum("""ENTR""")|5|
||ACSL|Int32||XmlEnum("""ACSL""")|6|

---

## Value ISO20022.Catp012001.AccountIdentification80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Email|String||XmlElement()||
|+|MSISDN|String||XmlElement()||
|+|DmstAcct|ISO20022.Catp012001.SimpleIdentificationInformation4||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DmstAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Email,MSISDN,DmstAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Catp012001.Acquirer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brnch|String||XmlElement()||
|+|AcqrgInstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp012001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Catp012001.Algorithm11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS01|Int32||XmlEnum("""HS01""")|1|
||HS51|Int32||XmlEnum("""HS51""")|2|
||HS38|Int32||XmlEnum("""HS38""")|3|
||HS25|Int32||XmlEnum("""HS25""")|4|

---

## Enum ISO20022.Catp012001.Algorithm12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMA5|Int32||XmlEnum("""CMA5""")|1|
||CMA9|Int32||XmlEnum("""CMA9""")|2|
||MCC1|Int32||XmlEnum("""MCC1""")|3|
||CMA1|Int32||XmlEnum("""CMA1""")|4|
||MCCS|Int32||XmlEnum("""MCCS""")|5|
||MACC|Int32||XmlEnum("""MACC""")|6|

---

## Enum ISO20022.Catp012001.Algorithm13Code


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

## Enum ISO20022.Catp012001.Algorithm15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||E3DC|Int32||XmlEnum("""E3DC""")|3|
||EA2C|Int32||XmlEnum("""EA2C""")|4|

---

## Enum ISO20022.Catp012001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Catp012001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Catp012001.AlgorithmIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp012001.Parameter4||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp012001.AlgorithmIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp012001.Parameter5||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp012001.AlgorithmIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp012001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp012001.AlgorithmIdentification14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp012001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp012001.AlgorithmIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp012001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp012001.AmountAndCurrency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.AmountAndDirection111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Catp012001.CurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Catp012001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Catp012001.AuthenticatedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catp012001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Catp012001.AlgorithmIdentification15||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp012001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Catp012001.AuthenticationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRML|Int32||XmlEnum("""TRML""")|1|
||ISSR|Int32||XmlEnum("""ISSR""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Enum ISO20022.Catp012001.AuthenticationMethod7Code


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

## Value ISO20022.Catp012001.AutomatedTellerMachine12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Eqpmnt|ISO20022.Catp012001.ATMEquipment1||XmlElement()||
|+|Cpblties|ISO20022.Catp012001.PointOfInteractionCapabilities10||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|Lctn|ISO20022.Catp012001.PostalAddress17||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Eqpmnt),validElement(Cpblties),validElement(Lctn),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp012001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Catp012001.CardAccount21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lmts|ISO20022.Catp012001.ATMTransactionAmounts11||XmlElement()||
|+|DfltAcctInd|String||XmlElement()||
|+|BalDispFlg|String||XmlElement()||
|+|Bal|ISO20022.Catp012001.AmountAndDirection111||XmlElement()||
|+|Svcr|ISO20022.Catp012001.PartyIdentification177Choice||XmlElement()||
|+|CdtRef|String||XmlElement()||
|+|AcctIdr|ISO20022.Catp012001.AccountIdentification80Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|AcctOwnr|ISO20022.Catp012001.NameAndAddress3||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|SelctdAcctTp|String||XmlElement()||
|+|SelctnMtd|String||XmlElement()||
|+|AcctSeqNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lmts),validElement(Bal),validElement(Svcr),validElement(AcctIdr),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(AcctOwnr))|

---

## Enum ISO20022.Catp012001.CardAccountType3Code


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

## Enum ISO20022.Catp012001.CardDataReading1Code


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

## Enum ISO20022.Catp012001.CardDataReading4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CTLS|Int32||XmlEnum("""CTLS""")|1|
||MGST|Int32||XmlEnum("""MGST""")|2|
||CICC|Int32||XmlEnum("""CICC""")|3|
||ECTL|Int32||XmlEnum("""ECTL""")|4|

---

## Value ISO20022.Catp012001.CardholderAuthentication8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrdhldrOnLinePIN|ISO20022.Catp012001.OnLinePIN5||XmlElement()||
|+|PrtctdAuthntcnVal|ISO20022.Catp012001.ContentInformationType10||XmlElement()||
|+|AuthntcnVal|String||XmlElement()||
|+|TknReqd|String||XmlElement()||
|+|AuthntcnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CrdhldrOnLinePIN),validElement(PrtctdAuthntcnVal))|

---

## Enum ISO20022.Catp012001.CardholderVerificationCapability3Code


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

## Value ISO20022.Catp012001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Catp012001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Enum ISO20022.Catp012001.CheckCodeLine1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OCRF|Int32||XmlEnum("""OCRF""")|1|
||OCRB|Int32||XmlEnum("""OCRB""")|2|
||OCRA|Int32||XmlEnum("""OCRA""")|3|
||E13B|Int32||XmlEnum("""E13B""")|4|
||CMC7|Int32||XmlEnum("""CMC7""")|5|

---

## Value ISO20022.Catp012001.ContentInformationType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Catp012001.EnvelopedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Value ISO20022.Catp012001.ContentInformationType15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcdData|ISO20022.Catp012001.AuthenticatedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcdData))|

---

## Enum ISO20022.Catp012001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Catp012001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Catp012001.DataSetCategory7Code


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

## Value ISO20022.Catp012001.DetailedAmount13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Labl|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.DetailedAmount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dontn|global::System.Collections.Generic.List<ISO20022.Catp012001.DetailedAmount13>||XmlElement()||
|+|Fees|global::System.Collections.Generic.List<ISO20022.Catp012001.DetailedAmount13>||XmlElement()||
|+|CshBckAmt|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|AmtToDpst|Decimal||XmlElement()||
|+|AcctSeqNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dontn""",Dontn),validElement(Dontn),validList("""Fees""",Fees),validElement(Fees),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Catp012001.DisplayCapabilities5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Dstn""",Dstn))|

---

## Type ISO20022.Catp012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMDpstReq|ISO20022.Catp012001.ATMDepositRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDpstReq))|

---

## Value ISO20022.Catp012001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.EncryptedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Catp012001.AlgorithmIdentification14||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Catp012001.EncryptionFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||TR31|Int32||XmlEnum("""TR31""")|2|

---

## Value ISO20022.Catp012001.EnvelopedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Catp012001.EncryptedContent3||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp012001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Catp012001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.GenericIdentification77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catp012001.GenericInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.GeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.GeographicLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Catp012001.UTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Catp012001.GeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints),validChoice(UTMCordints,GeogcCordints))|

---

## Value ISO20022.Catp012001.Header31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Catp012001.Traceability4>||XmlElement()||
|+|PrcStat|String||XmlElement()||
|+|RcptPty|String||XmlElement()||
|+|InitgPty|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|ISO20022.Catp012001.ATMMessageFunction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""),validElement(MsgFctn))|

---

## Value ISO20022.Catp012001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Catp012001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Catp012001.KEK4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp012001.AlgorithmIdentification13||XmlElement()||
|+|KEKId|ISO20022.Catp012001.KEKIdentifier2||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Catp012001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.KeyTransport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp012001.AlgorithmIdentification11||XmlElement()||
|+|RcptId|ISO20022.Catp012001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Catp012001.MessageFunction11Code


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

## Value ISO20022.Catp012001.NameAndAddress3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Catp012001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Catp012001.OnLinePIN5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInpt|String||XmlElement()||
|+|PINFrmt|String||XmlElement()||
|+|NcrptdPINBlck|ISO20022.Catp012001.ContentInformationType10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdPINBlck))|

---

## Enum ISO20022.Catp012001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Enum ISO20022.Catp012001.PINFormat4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIS3|Int32||XmlEnum("""VIS3""")|1|
||VIS2|Int32||XmlEnum("""VIS2""")|2|
||ISO5|Int32||XmlEnum("""ISO5""")|3|
||ISO4|Int32||XmlEnum("""ISO4""")|4|
||ISO3|Int32||XmlEnum("""ISO3""")|5|
||ISO2|Int32||XmlEnum("""ISO2""")|6|
||ISO1|Int32||XmlEnum("""ISO1""")|7|
||ISO0|Int32||XmlEnum("""ISO0""")|8|
||IBM3|Int32||XmlEnum("""IBM3""")|9|
||EMVS|Int32||XmlEnum("""EMVS""")|10|
||ECI3|Int32||XmlEnum("""ECI3""")|11|
||ECI2|Int32||XmlEnum("""ECI2""")|12|
||DBLC|Int32||XmlEnum("""DBLC""")|13|
||DBLD|Int32||XmlEnum("""DBLD""")|14|
||BKSY|Int32||XmlEnum("""BKSY""")|15|
||BNCM|Int32||XmlEnum("""BNCM""")|16|
||ANSI|Int32||XmlEnum("""ANSI""")|17|

---

## Value ISO20022.Catp012001.Parameter4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Catp012001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catp012001.Parameter5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.Parameter6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.PartyIdentification177Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Catp012001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Catp012001.PartyType12Code


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

## Value ISO20022.Catp012001.PaymentCard36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CardCcyCd|String||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|PlainCardData|ISO20022.Catp012001.PlainCardData25||XmlElement()||
|+|PrtctdCardData|ISO20022.Catp012001.ContentInformationType10||XmlElement()||
|+|FllbckInd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CardCcyCd""",CardCcyCd,"""[a-zA-Z0-9]{3}"""),validElement(PlainCardData),validElement(PrtctdCardData))|

---

## Value ISO20022.Catp012001.PlainCardData25


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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SvcCd""",SvcCd,"""[0-9]{3}"""),validPattern("""XpryDt""",XpryDt,"""([0-9]{4,4}-[0-9]{2,2}-[0-9]{2,2})\|([0-9]{2,2}-[0-9]{2,2})\|([0-9]{4,4}-[0-9]{2,2})"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Catp012001.PointOfInteractionCapabilities10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RctPrtg|String||XmlElement()||
|+|IntractvTxs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgCpblties|global::System.Collections.Generic.List<ISO20022.Catp012001.DisplayCapabilities5>||XmlElement()||
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

## Value ISO20022.Catp012001.PostalAddress1


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

## Value ISO20022.Catp012001.PostalAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GLctn|ISO20022.Catp012001.GeographicLocation1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GLctn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Catp012001.Recipient4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp012001.KEKIdentifier2||XmlElement()||
|+|KEK|ISO20022.Catp012001.KEK4||XmlElement()||
|+|KeyTrnsprt|ISO20022.Catp012001.KeyTransport4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Catp012001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp012001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Catp012001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Catp012001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.TerminalHosting1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.Traceability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RlayId|ISO20022.Catp012001.GenericIdentification77||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Enum ISO20022.Catp012001.TransactionEnvironment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|

---

## Enum ISO20022.Catp012001.TransactionEnvironment3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MERC|Int32||XmlEnum("""MERC""")|2|
||BRCH|Int32||XmlEnum("""BRCH""")|3|

---

## Value ISO20022.Catp012001.TransactionIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|HstTxDtTm|DateTime||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.TransactionVerificationResult5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnTkn|String||XmlElement()||
|+|AddtlRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|VrfctnNtty|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp012001.UTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|Decimal||XmlElement()||
|+|UTMEstwrd|Decimal||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp012001.UserInterface5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRDO|Int32||XmlEnum("""CRDO""")|1|
||CRCP|Int32||XmlEnum("""CRCP""")|2|
||CDSP|Int32||XmlEnum("""CDSP""")|3|

---

## Enum ISO20022.Catp012001.Verification1Code


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

