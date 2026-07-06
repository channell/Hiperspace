# caam.011.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Caam011001.ATMConfigurationParameter1 {
        + Vrsn  : String
        + Tp  : String
    }
    class ISO20022.Caam011001.ATMContext25 {
        + Svc  : ISO20022.Caam011001.ATMService27
        + SsnRef  : String
    }
    ISO20022.Caam011001.ATMContext25 *-- ISO20022.Caam011001.ATMService27
    class ISO20022.Caam011001.ATMCustomer7 {
        + AuthntcnRslt  : global::System.Collections.Generic.List~ISO20022.Caam011001.TransactionVerificationResult5~
        + SelctdLang  : String
        + Prfl  : ISO20022.Caam011001.ATMCustomerProfile6
    }
    ISO20022.Caam011001.ATMCustomer7 *-- ISO20022.Caam011001.TransactionVerificationResult5
    ISO20022.Caam011001.ATMCustomer7 *-- ISO20022.Caam011001.ATMCustomerProfile6
    class ISO20022.Caam011001.ATMCustomerProfile1Code {
        PREQ = 1
        OREQ = 2
        CRDF = 3
    }
    class ISO20022.Caam011001.ATMCustomerProfile6 {
        + PrefrdLang  : String
        + CstmrId  : String
        + PrflRef  : String
        + RtrvlMd  : String
    }
    class ISO20022.Caam011001.ATMEnvironment20 {
        + Card  : ISO20022.Caam011001.PaymentCard37
        + Cstmr  : ISO20022.Caam011001.ATMCustomer7
        + ATM  : ISO20022.Caam011001.AutomatedTellerMachine12
        + HstgNtty  : ISO20022.Caam011001.TerminalHosting1
        + ATMMgrId  : String
        + Acqrr  : ISO20022.Caam011001.Acquirer7
    }
    ISO20022.Caam011001.ATMEnvironment20 *-- ISO20022.Caam011001.PaymentCard37
    ISO20022.Caam011001.ATMEnvironment20 *-- ISO20022.Caam011001.ATMCustomer7
    ISO20022.Caam011001.ATMEnvironment20 *-- ISO20022.Caam011001.AutomatedTellerMachine12
    ISO20022.Caam011001.ATMEnvironment20 *-- ISO20022.Caam011001.TerminalHosting1
    ISO20022.Caam011001.ATMEnvironment20 *-- ISO20022.Caam011001.Acquirer7
    class ISO20022.Caam011001.ATMEquipment1 {
        + CfgtnParam  : global::System.Collections.Generic.List~ISO20022.Caam011001.ATMConfigurationParameter1~
        + ApprvlNb  : String
        + ApplVrsn  : String
        + ApplNm  : String
        + ApplPrvdr  : String
        + SrlNb  : String
        + Mdl  : String
        + Manfctr  : String
    }
    ISO20022.Caam011001.ATMEquipment1 *-- ISO20022.Caam011001.ATMConfigurationParameter1
    class ISO20022.Caam011001.ATMExceptionAdvice2 {
        + Tx  : ISO20022.Caam011001.ATMTransaction40
        + Cntxt  : ISO20022.Caam011001.ATMContext25
        + Envt  : ISO20022.Caam011001.ATMEnvironment20
    }
    ISO20022.Caam011001.ATMExceptionAdvice2 *-- ISO20022.Caam011001.ATMTransaction40
    ISO20022.Caam011001.ATMExceptionAdvice2 *-- ISO20022.Caam011001.ATMContext25
    ISO20022.Caam011001.ATMExceptionAdvice2 *-- ISO20022.Caam011001.ATMEnvironment20
    class ISO20022.Caam011001.ATMExceptionAdviceV02 {
        + SctyTrlr  : ISO20022.Caam011001.ContentInformationType15
        + ATMXcptnAdvc  : ISO20022.Caam011001.ATMExceptionAdvice2
        + PrtctdATMXcptnAdvc  : ISO20022.Caam011001.ContentInformationType10
        + Hdr  : ISO20022.Caam011001.Header32
    }
    ISO20022.Caam011001.ATMExceptionAdviceV02 *-- ISO20022.Caam011001.ContentInformationType15
    ISO20022.Caam011001.ATMExceptionAdviceV02 *-- ISO20022.Caam011001.ATMExceptionAdvice2
    ISO20022.Caam011001.ATMExceptionAdviceV02 *-- ISO20022.Caam011001.ContentInformationType10
    ISO20022.Caam011001.ATMExceptionAdviceV02 *-- ISO20022.Caam011001.Header32
    class ISO20022.Caam011001.ATMMediaType1Code {
        UDTM = 1
        STMP = 2
        NOTE = 3
        CPNS = 4
        CMDT = 5
        COIN = 6
        CARD = 7
    }
    class ISO20022.Caam011001.ATMMediaType4Code {
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
    class ISO20022.Caam011001.ATMMessageFunction2 {
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + Fctn  : String
    }
    class ISO20022.Caam011001.ATMService27 {
        + SvcVarntId  : global::System.Collections.Generic.List~String~
        + SvcTp  : String
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + SvcRef  : String
    }
    class ISO20022.Caam011001.ATMServiceType11Code {
        MINI = 1
        ACCD = 2
        DPSV = 3
        SPRV = 4
        STDR = 5
        EMVS = 6
        PRFL = 7
        PATH = 8
        PINU = 9
        PINR = 10
        PINC = 11
        DPSN = 12
        MCHG = 13
        XRTW = 14
        XRTD = 15
        DCCS = 16
        CMPF = 17
        CHSN = 18
        CDVF = 19
        BLCQ = 20
        ASTS = 21
        TRFP = 22
        TRFI = 23
        TRFC = 24
    }
    class ISO20022.Caam011001.ATMTransaction40 {
        + ElctrncPrsBal  : ISO20022.Caam011001.CurrencyAndAmount
        + XcptnDtl  : global::System.Collections.Generic.List~String~
        + Xcptn  : global::System.Collections.Generic.List~String~
        + RcncltnId  : String
        + TxId  : ISO20022.Caam011001.TransactionIdentifier3
    }
    ISO20022.Caam011001.ATMTransaction40 *-- ISO20022.Caam011001.CurrencyAndAmount
    ISO20022.Caam011001.ATMTransaction40 *-- ISO20022.Caam011001.TransactionIdentifier3
    class ISO20022.Caam011001.Acquirer7 {
        + Brnch  : String
        + AcqrgInstn  : String
    }
    class ISO20022.Caam011001.Algorithm11Code {
        HS01 = 1
        HS51 = 2
        HS38 = 3
        HS25 = 4
    }
    class ISO20022.Caam011001.Algorithm12Code {
        CMA5 = 1
        CMA9 = 2
        MCC1 = 3
        CMA1 = 4
        MCCS = 5
        MACC = 6
    }
    class ISO20022.Caam011001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Caam011001.Algorithm15Code {
        EA5C = 1
        EA9C = 2
        E3DC = 3
        EA2C = 4
    }
    class ISO20022.Caam011001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Caam011001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Caam011001.AlgorithmIdentification11 {
        + Param  : ISO20022.Caam011001.Parameter4
        + Algo  : String
    }
    ISO20022.Caam011001.AlgorithmIdentification11 *-- ISO20022.Caam011001.Parameter4
    class ISO20022.Caam011001.AlgorithmIdentification12 {
        + Param  : ISO20022.Caam011001.Parameter5
        + Algo  : String
    }
    ISO20022.Caam011001.AlgorithmIdentification12 *-- ISO20022.Caam011001.Parameter5
    class ISO20022.Caam011001.AlgorithmIdentification13 {
        + Param  : ISO20022.Caam011001.Parameter6
        + Algo  : String
    }
    ISO20022.Caam011001.AlgorithmIdentification13 *-- ISO20022.Caam011001.Parameter6
    class ISO20022.Caam011001.AlgorithmIdentification14 {
        + Param  : ISO20022.Caam011001.Parameter6
        + Algo  : String
    }
    ISO20022.Caam011001.AlgorithmIdentification14 *-- ISO20022.Caam011001.Parameter6
    class ISO20022.Caam011001.AlgorithmIdentification15 {
        + Param  : ISO20022.Caam011001.Parameter7
        + Algo  : String
    }
    ISO20022.Caam011001.AlgorithmIdentification15 *-- ISO20022.Caam011001.Parameter7
    class ISO20022.Caam011001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Caam011001.AuthenticatedData4 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Caam011001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Caam011001.AlgorithmIdentification15
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caam011001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caam011001.AuthenticatedData4 *-- ISO20022.Caam011001.EncapsulatedContent3
    ISO20022.Caam011001.AuthenticatedData4 *-- ISO20022.Caam011001.AlgorithmIdentification15
    ISO20022.Caam011001.AuthenticatedData4 *-- ISO20022.Caam011001.Recipient4Choice
    class ISO20022.Caam011001.AuthenticationEntity2Code {
        TRML = 1
        ISSR = 2
        ACQR = 3
        MERC = 4
        AGNT = 5
        ICCD = 6
    }
    class ISO20022.Caam011001.AuthenticationMethod7Code {
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
    class ISO20022.Caam011001.AutomatedTellerMachine12 {
        + Eqpmnt  : ISO20022.Caam011001.ATMEquipment1
        + Cpblties  : ISO20022.Caam011001.PointOfInteractionCapabilities10
        + LctnCtgy  : String
        + Lctn  : ISO20022.Caam011001.PostalAddress17
        + BaseCcy  : String
        + SeqNb  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Caam011001.AutomatedTellerMachine12 *-- ISO20022.Caam011001.ATMEquipment1
    ISO20022.Caam011001.AutomatedTellerMachine12 *-- ISO20022.Caam011001.PointOfInteractionCapabilities10
    ISO20022.Caam011001.AutomatedTellerMachine12 *-- ISO20022.Caam011001.PostalAddress17
    class ISO20022.Caam011001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Caam011001.CardDataReading1Code {
        ECTL = 1
        CTLS = 2
        DFLE = 3
        CICC = 4
        MGST = 5
        BRCD = 6
        PHYS = 7
        TAGC = 8
    }
    class ISO20022.Caam011001.CardDataReading4Code {
        CTLS = 1
        MGST = 2
        CICC = 3
        ECTL = 4
    }
    class ISO20022.Caam011001.CardholderVerificationCapability3Code {
        PCOD = 1
        PKIS = 2
        FBIG = 3
        FBIO = 4
        FDSG = 5
        FEPN = 6
        FCPN = 7
        NPIN = 8
    }
    class ISO20022.Caam011001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Caam011001.RelativeDistinguishedName1~
    }
    ISO20022.Caam011001.CertificateIssuer1 *-- ISO20022.Caam011001.RelativeDistinguishedName1
    class ISO20022.Caam011001.ContentInformationType10 {
        + EnvlpdData  : ISO20022.Caam011001.EnvelopedData4
        + CnttTp  : String
    }
    ISO20022.Caam011001.ContentInformationType10 *-- ISO20022.Caam011001.EnvelopedData4
    class ISO20022.Caam011001.ContentInformationType15 {
        + AuthntcdData  : ISO20022.Caam011001.AuthenticatedData4
        + CnttTp  : String
    }
    ISO20022.Caam011001.ContentInformationType15 *-- ISO20022.Caam011001.AuthenticatedData4
    class ISO20022.Caam011001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Caam011001.CurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Caam011001.DataSetCategory7Code {
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
    class ISO20022.Caam011001.DisplayCapabilities5 {
        + AvlblLang  : global::System.Collections.Generic.List~String~
        + LineWidth  : Decimal
        + NbOfLines  : Decimal
        + AvlblFrmt  : global::System.Collections.Generic.List~String~
        + Dstn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Caam011001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Caam011001.EncryptedContent3 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Caam011001.AlgorithmIdentification14
        + CnttTp  : String
    }
    ISO20022.Caam011001.EncryptedContent3 *-- ISO20022.Caam011001.AlgorithmIdentification14
    class ISO20022.Caam011001.EncryptionFormat1Code {
        TR34 = 1
        TR31 = 2
    }
    class ISO20022.Caam011001.EnvelopedData4 {
        + NcrptdCntt  : ISO20022.Caam011001.EncryptedContent3
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Caam011001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Caam011001.EnvelopedData4 *-- ISO20022.Caam011001.EncryptedContent3
    ISO20022.Caam011001.EnvelopedData4 *-- ISO20022.Caam011001.Recipient4Choice
    class ISO20022.Caam011001.FailureReason8Code {
        UCPT = 1
        SFRD = 2
        SECU = 3
        MALF = 4
        CDFG = 5
        CUCL = 6
        CDCP = 7
        CDRT = 8
    }
    class ISO20022.Caam011001.GenericIdentification77 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Caam011001.GeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Caam011001.GeographicLocation1Choice {
        + UTMCordints  : ISO20022.Caam011001.UTMCoordinates1
        + GeogcCordints  : ISO20022.Caam011001.GeographicCoordinates1
    }
    ISO20022.Caam011001.GeographicLocation1Choice *-- ISO20022.Caam011001.UTMCoordinates1
    ISO20022.Caam011001.GeographicLocation1Choice *-- ISO20022.Caam011001.GeographicCoordinates1
    class ISO20022.Caam011001.Header32 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Caam011001.Traceability4~
        + PrcStat  : String
        + RcptPty  : String
        + InitgPty  : String
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : Decimal
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : ISO20022.Caam011001.ATMMessageFunction2
    }
    ISO20022.Caam011001.Header32 *-- ISO20022.Caam011001.Traceability4
    ISO20022.Caam011001.Header32 *-- ISO20022.Caam011001.ATMMessageFunction2
    class ISO20022.Caam011001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Caam011001.CertificateIssuer1
    }
    ISO20022.Caam011001.IssuerAndSerialNumber1 *-- ISO20022.Caam011001.CertificateIssuer1
    class ISO20022.Caam011001.KEK4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caam011001.AlgorithmIdentification13
        + KEKId  : ISO20022.Caam011001.KEKIdentifier2
        + Vrsn  : Decimal
    }
    ISO20022.Caam011001.KEK4 *-- ISO20022.Caam011001.AlgorithmIdentification13
    ISO20022.Caam011001.KEK4 *-- ISO20022.Caam011001.KEKIdentifier2
    class ISO20022.Caam011001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Caam011001.KeyTransport4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Caam011001.AlgorithmIdentification11
        + RcptId  : ISO20022.Caam011001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Caam011001.KeyTransport4 *-- ISO20022.Caam011001.AlgorithmIdentification11
    ISO20022.Caam011001.KeyTransport4 *-- ISO20022.Caam011001.Recipient5Choice
    class ISO20022.Caam011001.MessageFunction11Code {
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
    class ISO20022.Caam011001.OutputFormat1Code {
        HTML = 1
        TEXT = 2
        MREF = 3
    }
    class ISO20022.Caam011001.Parameter4 {
        + MskGnrtrAlgo  : ISO20022.Caam011001.AlgorithmIdentification12
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Caam011001.Parameter4 *-- ISO20022.Caam011001.AlgorithmIdentification12
    class ISO20022.Caam011001.Parameter5 {
        + DgstAlgo  : String
    }
    class ISO20022.Caam011001.Parameter6 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Caam011001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Caam011001.PartyType12Code {
        OATM = 1
        ITAG = 2
        HSTG = 3
        DLIS = 4
        CISP = 5
        ATMG = 6
        ACQR = 7
    }
    class ISO20022.Caam011001.PaymentCard37 {
        + ElctrncPrsBal  : ISO20022.Caam011001.CurrencyAndAmount
        + CardCcyCd  : String
        + CardCtryCd  : String
        + PlainCardData  : ISO20022.Caam011001.PlainCardData24
        + PrtctdCardData  : ISO20022.Caam011001.ContentInformationType10
        + FllbckInd  : String
        + CardDataNtryMd  : String
    }
    ISO20022.Caam011001.PaymentCard37 *-- ISO20022.Caam011001.CurrencyAndAmount
    ISO20022.Caam011001.PaymentCard37 *-- ISO20022.Caam011001.PlainCardData24
    ISO20022.Caam011001.PaymentCard37 *-- ISO20022.Caam011001.ContentInformationType10
    class ISO20022.Caam011001.PlainCardData24 {
        + Trck3  : String
        + Trck2  : String
        + Trck1  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    class ISO20022.Caam011001.PointOfInteractionCapabilities10 {
        + RctPrtg  : String
        + IntractvTxs  : global::System.Collections.Generic.List~String~
        + MsgCpblties  : global::System.Collections.Generic.List~ISO20022.Caam011001.DisplayCapabilities5~
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
    ISO20022.Caam011001.PointOfInteractionCapabilities10 *-- ISO20022.Caam011001.DisplayCapabilities5
    class ISO20022.Caam011001.PostalAddress17 {
        + GLctn  : ISO20022.Caam011001.GeographicLocation1Choice
        + Ctry  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Caam011001.PostalAddress17 *-- ISO20022.Caam011001.GeographicLocation1Choice
    class ISO20022.Caam011001.Recipient4Choice {
        + KeyIdr  : ISO20022.Caam011001.KEKIdentifier2
        + KEK  : ISO20022.Caam011001.KEK4
        + KeyTrnsprt  : ISO20022.Caam011001.KeyTransport4
    }
    ISO20022.Caam011001.Recipient4Choice *-- ISO20022.Caam011001.KEKIdentifier2
    ISO20022.Caam011001.Recipient4Choice *-- ISO20022.Caam011001.KEK4
    ISO20022.Caam011001.Recipient4Choice *-- ISO20022.Caam011001.KeyTransport4
    class ISO20022.Caam011001.Recipient5Choice {
        + KeyIdr  : ISO20022.Caam011001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Caam011001.IssuerAndSerialNumber1
    }
    ISO20022.Caam011001.Recipient5Choice *-- ISO20022.Caam011001.KEKIdentifier2
    ISO20022.Caam011001.Recipient5Choice *-- ISO20022.Caam011001.IssuerAndSerialNumber1
    class ISO20022.Caam011001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Caam011001.TerminalHosting1 {
        + Id  : String
        + Ctgy  : String
    }
    class ISO20022.Caam011001.Traceability4 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + SeqNb  : String
        + RlayId  : ISO20022.Caam011001.GenericIdentification77
    }
    ISO20022.Caam011001.Traceability4 *-- ISO20022.Caam011001.GenericIdentification77
    class ISO20022.Caam011001.TransactionEnvironment2Code {
        PUBL = 1
        PRIV = 2
    }
    class ISO20022.Caam011001.TransactionEnvironment3Code {
        OTHR = 1
        MERC = 2
        BRCH = 3
    }
    class ISO20022.Caam011001.TransactionIdentifier3 {
        + TxRef  : String
        + HstTxDtTm  : DateTime
        + TxDtTm  : DateTime
    }
    class ISO20022.Caam011001.TransactionVerificationResult5 {
        + AuthntcnTkn  : String
        + AddtlRslt  : String
        + Rslt  : String
        + VrfctnNtty  : String
        + Mtd  : String
    }
    class ISO20022.Caam011001.UTMCoordinates1 {
        + UTMNrthwrd  : Decimal
        + UTMEstwrd  : Decimal
        + UTMZone  : String
    }
    class ISO20022.Caam011001.UserInterface5Code {
        CRDO = 1
        CRCP = 2
        CDSP = 3
    }
    class ISO20022.Caam011001.Verification1Code {
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

## Value ISO20022.Caam011001.ATMConfigurationParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.ATMContext25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svc|ISO20022.Caam011001.ATMService27||XmlElement()||
|+|SsnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svc))|

---

## Value ISO20022.Caam011001.ATMCustomer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnRslt|global::System.Collections.Generic.List<ISO20022.Caam011001.TransactionVerificationResult5>||XmlElement()||
|+|SelctdLang|String||XmlElement()||
|+|Prfl|ISO20022.Caam011001.ATMCustomerProfile6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AuthntcnRslt""",AuthntcnRslt),validList("""AuthntcnRslt""",AuthntcnRslt),validElement(AuthntcnRslt),validElement(Prfl))|

---

## Enum ISO20022.Caam011001.ATMCustomerProfile1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREQ|Int32||XmlEnum("""PREQ""")|1|
||OREQ|Int32||XmlEnum("""OREQ""")|2|
||CRDF|Int32||XmlEnum("""CRDF""")|3|

---

## Value ISO20022.Caam011001.ATMCustomerProfile6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdLang|String||XmlElement()||
|+|CstmrId|String||XmlElement()||
|+|PrflRef|String||XmlElement()||
|+|RtrvlMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.ATMEnvironment20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Card|ISO20022.Caam011001.PaymentCard37||XmlElement()||
|+|Cstmr|ISO20022.Caam011001.ATMCustomer7||XmlElement()||
|+|ATM|ISO20022.Caam011001.AutomatedTellerMachine12||XmlElement()||
|+|HstgNtty|ISO20022.Caam011001.TerminalHosting1||XmlElement()||
|+|ATMMgrId|String||XmlElement()||
|+|Acqrr|ISO20022.Caam011001.Acquirer7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Card),validElement(Cstmr),validElement(ATM),validElement(HstgNtty),validElement(Acqrr))|

---

## Value ISO20022.Caam011001.ATMEquipment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CfgtnParam|global::System.Collections.Generic.List<ISO20022.Caam011001.ATMConfigurationParameter1>||XmlElement()||
|+|ApprvlNb|String||XmlElement()||
|+|ApplVrsn|String||XmlElement()||
|+|ApplNm|String||XmlElement()||
|+|ApplPrvdr|String||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|Manfctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CfgtnParam""",CfgtnParam),validElement(CfgtnParam))|

---

## Value ISO20022.Caam011001.ATMExceptionAdvice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Caam011001.ATMTransaction40||XmlElement()||
|+|Cntxt|ISO20022.Caam011001.ATMContext25||XmlElement()||
|+|Envt|ISO20022.Caam011001.ATMEnvironment20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(Envt))|

---

## Aspect ISO20022.Caam011001.ATMExceptionAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Caam011001.ContentInformationType15||XmlElement()||
|+|ATMXcptnAdvc|ISO20022.Caam011001.ATMExceptionAdvice2||XmlElement()||
|+|PrtctdATMXcptnAdvc|ISO20022.Caam011001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam011001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMXcptnAdvc),validElement(PrtctdATMXcptnAdvc),validElement(Hdr))|

---

## Enum ISO20022.Caam011001.ATMMediaType1Code


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

## Enum ISO20022.Caam011001.ATMMediaType4Code


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

## Value ISO20022.Caam011001.ATMMessageFunction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|Fctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.ATMService27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcVarntId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvcTp|String||XmlElement()||
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|SvcRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam011001.ATMServiceType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MINI|Int32||XmlEnum("""MINI""")|1|
||ACCD|Int32||XmlEnum("""ACCD""")|2|
||DPSV|Int32||XmlEnum("""DPSV""")|3|
||SPRV|Int32||XmlEnum("""SPRV""")|4|
||STDR|Int32||XmlEnum("""STDR""")|5|
||EMVS|Int32||XmlEnum("""EMVS""")|6|
||PRFL|Int32||XmlEnum("""PRFL""")|7|
||PATH|Int32||XmlEnum("""PATH""")|8|
||PINU|Int32||XmlEnum("""PINU""")|9|
||PINR|Int32||XmlEnum("""PINR""")|10|
||PINC|Int32||XmlEnum("""PINC""")|11|
||DPSN|Int32||XmlEnum("""DPSN""")|12|
||MCHG|Int32||XmlEnum("""MCHG""")|13|
||XRTW|Int32||XmlEnum("""XRTW""")|14|
||XRTD|Int32||XmlEnum("""XRTD""")|15|
||DCCS|Int32||XmlEnum("""DCCS""")|16|
||CMPF|Int32||XmlEnum("""CMPF""")|17|
||CHSN|Int32||XmlEnum("""CHSN""")|18|
||CDVF|Int32||XmlEnum("""CDVF""")|19|
||BLCQ|Int32||XmlEnum("""BLCQ""")|20|
||ASTS|Int32||XmlEnum("""ASTS""")|21|
||TRFP|Int32||XmlEnum("""TRFP""")|22|
||TRFI|Int32||XmlEnum("""TRFI""")|23|
||TRFC|Int32||XmlEnum("""TRFC""")|24|

---

## Value ISO20022.Caam011001.ATMTransaction40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctrncPrsBal|ISO20022.Caam011001.CurrencyAndAmount||XmlElement()||
|+|XcptnDtl|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Xcptn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RcncltnId|String||XmlElement()||
|+|TxId|ISO20022.Caam011001.TransactionIdentifier3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElctrncPrsBal),validRequired("""Xcptn""",Xcptn),validElement(TxId))|

---

## Value ISO20022.Caam011001.Acquirer7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brnch|String||XmlElement()||
|+|AcqrgInstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam011001.Algorithm11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS01|Int32||XmlEnum("""HS01""")|1|
||HS51|Int32||XmlEnum("""HS51""")|2|
||HS38|Int32||XmlEnum("""HS38""")|3|
||HS25|Int32||XmlEnum("""HS25""")|4|

---

## Enum ISO20022.Caam011001.Algorithm12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMA5|Int32||XmlEnum("""CMA5""")|1|
||CMA9|Int32||XmlEnum("""CMA9""")|2|
||MCC1|Int32||XmlEnum("""MCC1""")|3|
||CMA1|Int32||XmlEnum("""CMA1""")|4|
||MCCS|Int32||XmlEnum("""MCCS""")|5|
||MACC|Int32||XmlEnum("""MACC""")|6|

---

## Enum ISO20022.Caam011001.Algorithm13Code


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

## Enum ISO20022.Caam011001.Algorithm15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||E3DC|Int32||XmlEnum("""E3DC""")|3|
||EA2C|Int32||XmlEnum("""EA2C""")|4|

---

## Enum ISO20022.Caam011001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Caam011001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Caam011001.AlgorithmIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam011001.Parameter4||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam011001.AlgorithmIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam011001.Parameter5||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam011001.AlgorithmIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam011001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam011001.AlgorithmIdentification14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam011001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Caam011001.AlgorithmIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Caam011001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Caam011001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Caam011001.AuthenticatedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Caam011001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Caam011001.AlgorithmIdentification15||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caam011001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Caam011001.AuthenticationEntity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRML|Int32||XmlEnum("""TRML""")|1|
||ISSR|Int32||XmlEnum("""ISSR""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||AGNT|Int32||XmlEnum("""AGNT""")|5|
||ICCD|Int32||XmlEnum("""ICCD""")|6|

---

## Enum ISO20022.Caam011001.AuthenticationMethod7Code


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

## Value ISO20022.Caam011001.AutomatedTellerMachine12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Eqpmnt|ISO20022.Caam011001.ATMEquipment1||XmlElement()||
|+|Cpblties|ISO20022.Caam011001.PointOfInteractionCapabilities10||XmlElement()||
|+|LctnCtgy|String||XmlElement()||
|+|Lctn|ISO20022.Caam011001.PostalAddress17||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Eqpmnt),validElement(Cpblties),validElement(Lctn),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caam011001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Enum ISO20022.Caam011001.CardDataReading1Code


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

## Enum ISO20022.Caam011001.CardDataReading4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CTLS|Int32||XmlEnum("""CTLS""")|1|
||MGST|Int32||XmlEnum("""MGST""")|2|
||CICC|Int32||XmlEnum("""CICC""")|3|
||ECTL|Int32||XmlEnum("""ECTL""")|4|

---

## Enum ISO20022.Caam011001.CardholderVerificationCapability3Code


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

## Value ISO20022.Caam011001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Caam011001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Caam011001.ContentInformationType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Caam011001.EnvelopedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Value ISO20022.Caam011001.ContentInformationType15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcdData|ISO20022.Caam011001.AuthenticatedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcdData))|

---

## Enum ISO20022.Caam011001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Value ISO20022.Caam011001.CurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Caam011001.DataSetCategory7Code


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

## Value ISO20022.Caam011001.DisplayCapabilities5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblLang|global::System.Collections.Generic.List<String>||XmlElement()||
|+|LineWidth|Decimal||XmlElement()||
|+|NbOfLines|Decimal||XmlElement()||
|+|AvlblFrmt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dstn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Dstn""",Dstn))|

---

## Type ISO20022.Caam011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMXcptnAdvc|ISO20022.Caam011001.ATMExceptionAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMXcptnAdvc))|

---

## Value ISO20022.Caam011001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.EncryptedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Caam011001.AlgorithmIdentification14||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Caam011001.EncryptionFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||TR31|Int32||XmlEnum("""TR31""")|2|

---

## Value ISO20022.Caam011001.EnvelopedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Caam011001.EncryptedContent3||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Caam011001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Enum ISO20022.Caam011001.FailureReason8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCPT|Int32||XmlEnum("""UCPT""")|1|
||SFRD|Int32||XmlEnum("""SFRD""")|2|
||SECU|Int32||XmlEnum("""SECU""")|3|
||MALF|Int32||XmlEnum("""MALF""")|4|
||CDFG|Int32||XmlEnum("""CDFG""")|5|
||CUCL|Int32||XmlEnum("""CUCL""")|6|
||CDCP|Int32||XmlEnum("""CDCP""")|7|
||CDRT|Int32||XmlEnum("""CDRT""")|8|

---

## Value ISO20022.Caam011001.GenericIdentification77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Caam011001.GeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.GeographicLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Caam011001.UTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Caam011001.GeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints),validChoice(UTMCordints,GeogcCordints))|

---

## Value ISO20022.Caam011001.Header32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Caam011001.Traceability4>||XmlElement()||
|+|PrcStat|String||XmlElement()||
|+|RcptPty|String||XmlElement()||
|+|InitgPty|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|Decimal||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|ISO20022.Caam011001.ATMMessageFunction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""),validElement(MsgFctn))|

---

## Value ISO20022.Caam011001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Caam011001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Caam011001.KEK4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caam011001.AlgorithmIdentification13||XmlElement()||
|+|KEKId|ISO20022.Caam011001.KEKIdentifier2||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Caam011001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.KeyTransport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Caam011001.AlgorithmIdentification11||XmlElement()||
|+|RcptId|ISO20022.Caam011001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Caam011001.MessageFunction11Code


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

## Enum ISO20022.Caam011001.OutputFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HTML|Int32||XmlEnum("""HTML""")|1|
||TEXT|Int32||XmlEnum("""TEXT""")|2|
||MREF|Int32||XmlEnum("""MREF""")|3|

---

## Value ISO20022.Caam011001.Parameter4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Caam011001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Caam011001.Parameter5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.Parameter6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam011001.PartyType12Code


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

## Value ISO20022.Caam011001.PaymentCard37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctrncPrsBal|ISO20022.Caam011001.CurrencyAndAmount||XmlElement()||
|+|CardCcyCd|String||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|PlainCardData|ISO20022.Caam011001.PlainCardData24||XmlElement()||
|+|PrtctdCardData|ISO20022.Caam011001.ContentInformationType10||XmlElement()||
|+|FllbckInd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElctrncPrsBal),validPattern("""CardCcyCd""",CardCcyCd,"""[a-zA-Z0-9]{3}"""),validElement(PlainCardData),validElement(PrtctdCardData))|

---

## Value ISO20022.Caam011001.PlainCardData24


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

## Value ISO20022.Caam011001.PointOfInteractionCapabilities10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RctPrtg|String||XmlElement()||
|+|IntractvTxs|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MsgCpblties|global::System.Collections.Generic.List<ISO20022.Caam011001.DisplayCapabilities5>||XmlElement()||
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

## Value ISO20022.Caam011001.PostalAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GLctn|ISO20022.Caam011001.GeographicLocation1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GLctn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Caam011001.Recipient4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caam011001.KEKIdentifier2||XmlElement()||
|+|KEK|ISO20022.Caam011001.KEK4||XmlElement()||
|+|KeyTrnsprt|ISO20022.Caam011001.KeyTransport4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Caam011001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Caam011001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Caam011001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Caam011001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.TerminalHosting1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.Traceability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RlayId|ISO20022.Caam011001.GenericIdentification77||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Enum ISO20022.Caam011001.TransactionEnvironment2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|

---

## Enum ISO20022.Caam011001.TransactionEnvironment3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MERC|Int32||XmlEnum("""MERC""")|2|
||BRCH|Int32||XmlEnum("""BRCH""")|3|

---

## Value ISO20022.Caam011001.TransactionIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|HstTxDtTm|DateTime||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.TransactionVerificationResult5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnTkn|String||XmlElement()||
|+|AddtlRslt|String||XmlElement()||
|+|Rslt|String||XmlElement()||
|+|VrfctnNtty|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Caam011001.UTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|Decimal||XmlElement()||
|+|UTMEstwrd|Decimal||XmlElement()||
|+|UTMZone|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Caam011001.UserInterface5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRDO|Int32||XmlEnum("""CRDO""")|1|
||CRCP|Int32||XmlEnum("""CRCP""")|2|
||CDSP|Int32||XmlEnum("""CDSP""")|3|

---

## Enum ISO20022.Caam011001.Verification1Code


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

