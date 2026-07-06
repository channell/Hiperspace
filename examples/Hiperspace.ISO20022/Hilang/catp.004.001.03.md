# catp.004.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Catp004001.ATMCommand4Code {
        RPTC = 1
        SNDM = 2
        DISC = 3
        CCNT = 4
        CFGT = 5
        ASTS = 6
        ABAL = 7
    }
    class ISO20022.Catp004001.ATMCommand7 {
        + CmdParams  : ISO20022.Catp004001.ATMCommandParameters1Choice
        + CmdId  : ISO20022.Catp004001.ATMCommandIdentification1
        + DtTm  : DateTime
        + Urgcy  : String
        + Tp  : String
    }
    ISO20022.Catp004001.ATMCommand7 *-- ISO20022.Catp004001.ATMCommandParameters1Choice
    ISO20022.Catp004001.ATMCommand7 *-- ISO20022.Catp004001.ATMCommandIdentification1
    class ISO20022.Catp004001.ATMCommandIdentification1 {
        + Prcr  : String
        + Ref  : String
        + Orgn  : String
    }
    class ISO20022.Catp004001.ATMCommandParameters1Choice {
        + ReqrdCfgtnParam  : ISO20022.Catp004001.ATMConfigurationParameter1
        + XpctdMsgFctn  : String
        + ATMReqrdGblSts  : String
    }
    ISO20022.Catp004001.ATMCommandParameters1Choice *-- ISO20022.Catp004001.ATMConfigurationParameter1
    class ISO20022.Catp004001.ATMConfigurationParameter1 {
        + Vrsn  : String
        + Tp  : String
    }
    class ISO20022.Catp004001.ATMContext9 {
        + Svc  : ISO20022.Catp004001.ATMService10
        + SsnRef  : String
    }
    ISO20022.Catp004001.ATMContext9 *-- ISO20022.Catp004001.ATMService10
    class ISO20022.Catp004001.ATMMessageFunction2 {
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + Fctn  : String
    }
    class ISO20022.Catp004001.ATMService10 {
        + SvcVarntId  : global::System.Collections.Generic.List~String~
        + SvcTp  : String
        + HstSvcCd  : String
        + ATMSvcCd  : String
        + SvcRef  : String
    }
    class ISO20022.Catp004001.ATMServiceType1Code {
        SPRV = 1
        STDR = 2
        PRFL = 3
        PATH = 4
        CHSN = 5
    }
    class ISO20022.Catp004001.ATMStatus1Code {
        OUTS = 1
        INSV = 2
    }
    class ISO20022.Catp004001.ATMTransaction45 {
        + Cmd  : global::System.Collections.Generic.List~ISO20022.Catp004001.ATMCommand7~
        + ICCRltdData  : String
        + RspnRsn  : String
        + Rspn  : String
        + TxId  : ISO20022.Catp004001.TransactionIdentifier3
    }
    ISO20022.Catp004001.ATMTransaction45 *-- ISO20022.Catp004001.ATMCommand7
    ISO20022.Catp004001.ATMTransaction45 *-- ISO20022.Catp004001.TransactionIdentifier3
    class ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3 {
        + Tx  : ISO20022.Catp004001.ATMTransaction45
        + Cntxt  : ISO20022.Catp004001.ATMContext9
        + ATM  : ISO20022.Catp004001.AutomatedTellerMachine3
    }
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3 *-- ISO20022.Catp004001.ATMTransaction45
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3 *-- ISO20022.Catp004001.ATMContext9
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3 *-- ISO20022.Catp004001.AutomatedTellerMachine3
    class ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03 {
        + SctyTrlr  : ISO20022.Catp004001.ContentInformationType15
        + ATMWdrwlCmpltnAck  : ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3
        + PrtctdATMWdrwlCmpltnAck  : ISO20022.Catp004001.ContentInformationType10
        + Hdr  : ISO20022.Catp004001.Header32
    }
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03 *-- ISO20022.Catp004001.ContentInformationType15
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03 *-- ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03 *-- ISO20022.Catp004001.ContentInformationType10
    ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03 *-- ISO20022.Catp004001.Header32
    class ISO20022.Catp004001.Algorithm11Code {
        HS01 = 1
        HS51 = 2
        HS38 = 3
        HS25 = 4
    }
    class ISO20022.Catp004001.Algorithm12Code {
        CMA5 = 1
        CMA9 = 2
        MCC1 = 3
        CMA1 = 4
        MCCS = 5
        MACC = 6
    }
    class ISO20022.Catp004001.Algorithm13Code {
        EA5C = 1
        EA9C = 2
        UKA1 = 3
        UKPT = 4
        DKP9 = 5
        E3DC = 6
        EA2C = 7
    }
    class ISO20022.Catp004001.Algorithm15Code {
        EA5C = 1
        EA9C = 2
        E3DC = 3
        EA2C = 4
    }
    class ISO20022.Catp004001.Algorithm7Code {
        RSAO = 1
        ERSA = 2
    }
    class ISO20022.Catp004001.Algorithm8Code {
        MGF1 = 1
    }
    class ISO20022.Catp004001.AlgorithmIdentification11 {
        + Param  : ISO20022.Catp004001.Parameter4
        + Algo  : String
    }
    ISO20022.Catp004001.AlgorithmIdentification11 *-- ISO20022.Catp004001.Parameter4
    class ISO20022.Catp004001.AlgorithmIdentification12 {
        + Param  : ISO20022.Catp004001.Parameter5
        + Algo  : String
    }
    ISO20022.Catp004001.AlgorithmIdentification12 *-- ISO20022.Catp004001.Parameter5
    class ISO20022.Catp004001.AlgorithmIdentification13 {
        + Param  : ISO20022.Catp004001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp004001.AlgorithmIdentification13 *-- ISO20022.Catp004001.Parameter6
    class ISO20022.Catp004001.AlgorithmIdentification14 {
        + Param  : ISO20022.Catp004001.Parameter6
        + Algo  : String
    }
    ISO20022.Catp004001.AlgorithmIdentification14 *-- ISO20022.Catp004001.Parameter6
    class ISO20022.Catp004001.AlgorithmIdentification15 {
        + Param  : ISO20022.Catp004001.Parameter7
        + Algo  : String
    }
    ISO20022.Catp004001.AlgorithmIdentification15 *-- ISO20022.Catp004001.Parameter7
    class ISO20022.Catp004001.AttributeType1Code {
        CATT = 1
        OUAT = 2
        OATT = 3
        LATT = 4
        CNAT = 5
    }
    class ISO20022.Catp004001.AuthenticatedData4 {
        + MAC  : String
        + NcpsltdCntt  : ISO20022.Catp004001.EncapsulatedContent3
        + MACAlgo  : ISO20022.Catp004001.AlgorithmIdentification15
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp004001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp004001.AuthenticatedData4 *-- ISO20022.Catp004001.EncapsulatedContent3
    ISO20022.Catp004001.AuthenticatedData4 *-- ISO20022.Catp004001.AlgorithmIdentification15
    ISO20022.Catp004001.AuthenticatedData4 *-- ISO20022.Catp004001.Recipient4Choice
    class ISO20022.Catp004001.AutomatedTellerMachine3 {
        + Lctn  : ISO20022.Catp004001.PostalAddress17
        + SeqNb  : String
        + AddtlId  : String
        + Id  : String
    }
    ISO20022.Catp004001.AutomatedTellerMachine3 *-- ISO20022.Catp004001.PostalAddress17
    class ISO20022.Catp004001.BytePadding1Code {
        RAND = 1
        NULL = 2
        NULG = 3
        NUL8 = 4
        LNGT = 5
    }
    class ISO20022.Catp004001.CertificateIssuer1 {
        + RltvDstngshdNm  : global::System.Collections.Generic.List~ISO20022.Catp004001.RelativeDistinguishedName1~
    }
    ISO20022.Catp004001.CertificateIssuer1 *-- ISO20022.Catp004001.RelativeDistinguishedName1
    class ISO20022.Catp004001.ContentInformationType10 {
        + EnvlpdData  : ISO20022.Catp004001.EnvelopedData4
        + CnttTp  : String
    }
    ISO20022.Catp004001.ContentInformationType10 *-- ISO20022.Catp004001.EnvelopedData4
    class ISO20022.Catp004001.ContentInformationType15 {
        + AuthntcdData  : ISO20022.Catp004001.AuthenticatedData4
        + CnttTp  : String
    }
    ISO20022.Catp004001.ContentInformationType15 *-- ISO20022.Catp004001.AuthenticatedData4
    class ISO20022.Catp004001.ContentType2Code {
        AUTH = 1
        DGST = 2
        EVLP = 3
        SIGN = 4
        DATA = 5
    }
    class ISO20022.Catp004001.DataSetCategory7Code {
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
    class ISO20022.Catp004001.EncapsulatedContent3 {
        + Cntt  : String
        + CnttTp  : String
    }
    class ISO20022.Catp004001.EncryptedContent3 {
        + NcrptdData  : String
        + CnttNcrptnAlgo  : ISO20022.Catp004001.AlgorithmIdentification14
        + CnttTp  : String
    }
    ISO20022.Catp004001.EncryptedContent3 *-- ISO20022.Catp004001.AlgorithmIdentification14
    class ISO20022.Catp004001.EncryptionFormat1Code {
        TR34 = 1
        TR31 = 2
    }
    class ISO20022.Catp004001.EnvelopedData4 {
        + NcrptdCntt  : ISO20022.Catp004001.EncryptedContent3
        + Rcpt  : global::System.Collections.Generic.List~ISO20022.Catp004001.Recipient4Choice~
        + Vrsn  : Decimal
    }
    ISO20022.Catp004001.EnvelopedData4 *-- ISO20022.Catp004001.EncryptedContent3
    ISO20022.Catp004001.EnvelopedData4 *-- ISO20022.Catp004001.Recipient4Choice
    class ISO20022.Catp004001.GenericIdentification77 {
        + ShrtNm  : String
        + Ctry  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Catp004001.GeographicCoordinates1 {
        + Long  : String
        + Lat  : String
    }
    class ISO20022.Catp004001.GeographicLocation1Choice {
        + UTMCordints  : ISO20022.Catp004001.UTMCoordinates1
        + GeogcCordints  : ISO20022.Catp004001.GeographicCoordinates1
    }
    ISO20022.Catp004001.GeographicLocation1Choice *-- ISO20022.Catp004001.UTMCoordinates1
    ISO20022.Catp004001.GeographicLocation1Choice *-- ISO20022.Catp004001.GeographicCoordinates1
    class ISO20022.Catp004001.Header32 {
        + Tracblt  : global::System.Collections.Generic.List~ISO20022.Catp004001.Traceability4~
        + PrcStat  : String
        + RcptPty  : String
        + InitgPty  : String
        + CreDtTm  : DateTime
        + ReTrnsmssnCntr  : Decimal
        + XchgId  : String
        + PrtcolVrsn  : String
        + MsgFctn  : ISO20022.Catp004001.ATMMessageFunction2
    }
    ISO20022.Catp004001.Header32 *-- ISO20022.Catp004001.Traceability4
    ISO20022.Catp004001.Header32 *-- ISO20022.Catp004001.ATMMessageFunction2
    class ISO20022.Catp004001.IssuerAndSerialNumber1 {
        + SrlNb  : String
        + Issr  : ISO20022.Catp004001.CertificateIssuer1
    }
    ISO20022.Catp004001.IssuerAndSerialNumber1 *-- ISO20022.Catp004001.CertificateIssuer1
    class ISO20022.Catp004001.KEK4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp004001.AlgorithmIdentification13
        + KEKId  : ISO20022.Catp004001.KEKIdentifier2
        + Vrsn  : Decimal
    }
    ISO20022.Catp004001.KEK4 *-- ISO20022.Catp004001.AlgorithmIdentification13
    ISO20022.Catp004001.KEK4 *-- ISO20022.Catp004001.KEKIdentifier2
    class ISO20022.Catp004001.KEKIdentifier2 {
        + DerivtnId  : String
        + SeqNb  : Decimal
        + KeyVrsn  : String
        + KeyId  : String
    }
    class ISO20022.Catp004001.KeyTransport4 {
        + NcrptdKey  : String
        + KeyNcrptnAlgo  : ISO20022.Catp004001.AlgorithmIdentification11
        + RcptId  : ISO20022.Catp004001.Recipient5Choice
        + Vrsn  : Decimal
    }
    ISO20022.Catp004001.KeyTransport4 *-- ISO20022.Catp004001.AlgorithmIdentification11
    ISO20022.Catp004001.KeyTransport4 *-- ISO20022.Catp004001.Recipient5Choice
    class ISO20022.Catp004001.MessageFunction11Code {
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
    class ISO20022.Catp004001.MessageFunction8Code {
        SSTS = 1
        KEYQ = 2
        INQC = 3
        DSEC = 4
        GSTS = 5
        BALN = 6
    }
    class ISO20022.Catp004001.Parameter4 {
        + MskGnrtrAlgo  : ISO20022.Catp004001.AlgorithmIdentification12
        + DgstAlgo  : String
        + NcrptnFrmt  : String
    }
    ISO20022.Catp004001.Parameter4 *-- ISO20022.Catp004001.AlgorithmIdentification12
    class ISO20022.Catp004001.Parameter5 {
        + DgstAlgo  : String
    }
    class ISO20022.Catp004001.Parameter6 {
        + BPddg  : String
        + InitlstnVctr  : String
        + NcrptnFrmt  : String
    }
    class ISO20022.Catp004001.Parameter7 {
        + BPddg  : String
        + InitlstnVctr  : String
    }
    class ISO20022.Catp004001.PartyType12Code {
        OATM = 1
        ITAG = 2
        HSTG = 3
        DLIS = 4
        CISP = 5
        ATMG = 6
        ACQR = 7
    }
    class ISO20022.Catp004001.PostalAddress17 {
        + GLctn  : ISO20022.Catp004001.GeographicLocation1Choice
        + Ctry  : String
        + CtrySubDvsn  : global::System.Collections.Generic.List~String~
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Catp004001.PostalAddress17 *-- ISO20022.Catp004001.GeographicLocation1Choice
    class ISO20022.Catp004001.Recipient4Choice {
        + KeyIdr  : ISO20022.Catp004001.KEKIdentifier2
        + KEK  : ISO20022.Catp004001.KEK4
        + KeyTrnsprt  : ISO20022.Catp004001.KeyTransport4
    }
    ISO20022.Catp004001.Recipient4Choice *-- ISO20022.Catp004001.KEKIdentifier2
    ISO20022.Catp004001.Recipient4Choice *-- ISO20022.Catp004001.KEK4
    ISO20022.Catp004001.Recipient4Choice *-- ISO20022.Catp004001.KeyTransport4
    class ISO20022.Catp004001.Recipient5Choice {
        + KeyIdr  : ISO20022.Catp004001.KEKIdentifier2
        + IssrAndSrlNb  : ISO20022.Catp004001.IssuerAndSerialNumber1
    }
    ISO20022.Catp004001.Recipient5Choice *-- ISO20022.Catp004001.KEKIdentifier2
    ISO20022.Catp004001.Recipient5Choice *-- ISO20022.Catp004001.IssuerAndSerialNumber1
    class ISO20022.Catp004001.RelativeDistinguishedName1 {
        + AttrVal  : String
        + AttrTp  : String
    }
    class ISO20022.Catp004001.Response12Code {
        ASUP = 1
        PART = 2
        DECL = 3
        APPR = 4
    }
    class ISO20022.Catp004001.ResultDetail5Code {
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
    class ISO20022.Catp004001.TMSContactLevel2Code {
        ENCS = 1
        DTIM = 2
        CRIT = 3
        ASAP = 4
    }
    class ISO20022.Catp004001.Traceability4 {
        + TracDtTmOut  : DateTime
        + TracDtTmIn  : DateTime
        + SeqNb  : String
        + RlayId  : ISO20022.Catp004001.GenericIdentification77
    }
    ISO20022.Catp004001.Traceability4 *-- ISO20022.Catp004001.GenericIdentification77
    class ISO20022.Catp004001.TransactionIdentifier3 {
        + TxRef  : String
        + HstTxDtTm  : DateTime
        + TxDtTm  : DateTime
    }
    class ISO20022.Catp004001.UTMCoordinates1 {
        + UTMNrthwrd  : Decimal
        + UTMEstwrd  : Decimal
        + UTMZone  : String
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

## Enum ISO20022.Catp004001.ATMCommand4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPTC|Int32||XmlEnum("""RPTC""")|1|
||SNDM|Int32||XmlEnum("""SNDM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||CCNT|Int32||XmlEnum("""CCNT""")|4|
||CFGT|Int32||XmlEnum("""CFGT""")|5|
||ASTS|Int32||XmlEnum("""ASTS""")|6|
||ABAL|Int32||XmlEnum("""ABAL""")|7|

---

## Value ISO20022.Catp004001.ATMCommand7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmdParams|ISO20022.Catp004001.ATMCommandParameters1Choice||XmlElement()||
|+|CmdId|ISO20022.Catp004001.ATMCommandIdentification1||XmlElement()||
|+|DtTm|DateTime||XmlElement()||
|+|Urgcy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CmdParams),validElement(CmdId))|

---

## Value ISO20022.Catp004001.ATMCommandIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcr|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Orgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.ATMCommandParameters1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqrdCfgtnParam|ISO20022.Catp004001.ATMConfigurationParameter1||XmlElement()||
|+|XpctdMsgFctn|String||XmlElement()||
|+|ATMReqrdGblSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqrdCfgtnParam),validChoice(ReqrdCfgtnParam,XpctdMsgFctn,ATMReqrdGblSts))|

---

## Value ISO20022.Catp004001.ATMConfigurationParameter1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.ATMContext9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svc|ISO20022.Catp004001.ATMService10||XmlElement()||
|+|SsnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svc))|

---

## Value ISO20022.Catp004001.ATMMessageFunction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|Fctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.ATMService10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcVarntId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SvcTp|String||XmlElement()||
|+|HstSvcCd|String||XmlElement()||
|+|ATMSvcCd|String||XmlElement()||
|+|SvcRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp004001.ATMServiceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPRV|Int32||XmlEnum("""SPRV""")|1|
||STDR|Int32||XmlEnum("""STDR""")|2|
||PRFL|Int32||XmlEnum("""PRFL""")|3|
||PATH|Int32||XmlEnum("""PATH""")|4|
||CHSN|Int32||XmlEnum("""CHSN""")|5|

---

## Enum ISO20022.Catp004001.ATMStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OUTS|Int32||XmlEnum("""OUTS""")|1|
||INSV|Int32||XmlEnum("""INSV""")|2|

---

## Value ISO20022.Catp004001.ATMTransaction45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmd|global::System.Collections.Generic.List<ISO20022.Catp004001.ATMCommand7>||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|RspnRsn|String||XmlElement()||
|+|Rspn|String||XmlElement()||
|+|TxId|ISO20022.Catp004001.TransactionIdentifier3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmd""",Cmd),validElement(Cmd),validElement(TxId))|

---

## Value ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|ISO20022.Catp004001.ATMTransaction45||XmlElement()||
|+|Cntxt|ISO20022.Catp004001.ATMContext9||XmlElement()||
|+|ATM|ISO20022.Catp004001.AutomatedTellerMachine3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tx),validElement(Cntxt),validElement(ATM))|

---

## Aspect ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyTrlr|ISO20022.Catp004001.ContentInformationType15||XmlElement()||
|+|ATMWdrwlCmpltnAck|ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgement3||XmlElement()||
|+|PrtctdATMWdrwlCmpltnAck|ISO20022.Catp004001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp004001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMWdrwlCmpltnAck),validElement(PrtctdATMWdrwlCmpltnAck),validElement(Hdr))|

---

## Enum ISO20022.Catp004001.Algorithm11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HS01|Int32||XmlEnum("""HS01""")|1|
||HS51|Int32||XmlEnum("""HS51""")|2|
||HS38|Int32||XmlEnum("""HS38""")|3|
||HS25|Int32||XmlEnum("""HS25""")|4|

---

## Enum ISO20022.Catp004001.Algorithm12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMA5|Int32||XmlEnum("""CMA5""")|1|
||CMA9|Int32||XmlEnum("""CMA9""")|2|
||MCC1|Int32||XmlEnum("""MCC1""")|3|
||CMA1|Int32||XmlEnum("""CMA1""")|4|
||MCCS|Int32||XmlEnum("""MCCS""")|5|
||MACC|Int32||XmlEnum("""MACC""")|6|

---

## Enum ISO20022.Catp004001.Algorithm13Code


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

## Enum ISO20022.Catp004001.Algorithm15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EA5C|Int32||XmlEnum("""EA5C""")|1|
||EA9C|Int32||XmlEnum("""EA9C""")|2|
||E3DC|Int32||XmlEnum("""E3DC""")|3|
||EA2C|Int32||XmlEnum("""EA2C""")|4|

---

## Enum ISO20022.Catp004001.Algorithm7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSAO|Int32||XmlEnum("""RSAO""")|1|
||ERSA|Int32||XmlEnum("""ERSA""")|2|

---

## Enum ISO20022.Catp004001.Algorithm8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGF1|Int32||XmlEnum("""MGF1""")|1|

---

## Value ISO20022.Catp004001.AlgorithmIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp004001.Parameter4||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp004001.AlgorithmIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp004001.Parameter5||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp004001.AlgorithmIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp004001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp004001.AlgorithmIdentification14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp004001.Parameter6||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Value ISO20022.Catp004001.AlgorithmIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Param|ISO20022.Catp004001.Parameter7||XmlElement()||
|+|Algo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Param))|

---

## Enum ISO20022.Catp004001.AttributeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CATT|Int32||XmlEnum("""CATT""")|1|
||OUAT|Int32||XmlEnum("""OUAT""")|2|
||OATT|Int32||XmlEnum("""OATT""")|3|
||LATT|Int32||XmlEnum("""LATT""")|4|
||CNAT|Int32||XmlEnum("""CNAT""")|5|

---

## Value ISO20022.Catp004001.AuthenticatedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MAC|String||XmlElement()||
|+|NcpsltdCntt|ISO20022.Catp004001.EncapsulatedContent3||XmlElement()||
|+|MACAlgo|ISO20022.Catp004001.AlgorithmIdentification15||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp004001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcpsltdCntt),validElement(MACAlgo),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Catp004001.AutomatedTellerMachine3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|ISO20022.Catp004001.PostalAddress17||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|AddtlId|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lctn))|

---

## Enum ISO20022.Catp004001.BytePadding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RAND|Int32||XmlEnum("""RAND""")|1|
||NULL|Int32||XmlEnum("""NULL""")|2|
||NULG|Int32||XmlEnum("""NULG""")|3|
||NUL8|Int32||XmlEnum("""NUL8""")|4|
||LNGT|Int32||XmlEnum("""LNGT""")|5|

---

## Value ISO20022.Catp004001.CertificateIssuer1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltvDstngshdNm|global::System.Collections.Generic.List<ISO20022.Catp004001.RelativeDistinguishedName1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RltvDstngshdNm""",RltvDstngshdNm),validList("""RltvDstngshdNm""",RltvDstngshdNm),validElement(RltvDstngshdNm))|

---

## Value ISO20022.Catp004001.ContentInformationType10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnvlpdData|ISO20022.Catp004001.EnvelopedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnvlpdData))|

---

## Value ISO20022.Catp004001.ContentInformationType15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcdData|ISO20022.Catp004001.AuthenticatedData4||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcdData))|

---

## Enum ISO20022.Catp004001.ContentType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AUTH|Int32||XmlEnum("""AUTH""")|1|
||DGST|Int32||XmlEnum("""DGST""")|2|
||EVLP|Int32||XmlEnum("""EVLP""")|3|
||SIGN|Int32||XmlEnum("""SIGN""")|4|
||DATA|Int32||XmlEnum("""DATA""")|5|

---

## Enum ISO20022.Catp004001.DataSetCategory7Code


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

## Type ISO20022.Catp004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ATMWdrwlCmpltnAck|ISO20022.Catp004001.ATMWithdrawalCompletionAcknowledgementV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMWdrwlCmpltnAck))|

---

## Value ISO20022.Catp004001.EncapsulatedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cntt|String||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.EncryptedContent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdData|String||XmlElement()||
|+|CnttNcrptnAlgo|ISO20022.Catp004001.AlgorithmIdentification14||XmlElement()||
|+|CnttTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnttNcrptnAlgo))|

---

## Enum ISO20022.Catp004001.EncryptionFormat1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TR34|Int32||XmlEnum("""TR34""")|1|
||TR31|Int32||XmlEnum("""TR31""")|2|

---

## Value ISO20022.Catp004001.EnvelopedData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdCntt|ISO20022.Catp004001.EncryptedContent3||XmlElement()||
|+|Rcpt|global::System.Collections.Generic.List<ISO20022.Catp004001.Recipient4Choice>||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NcrptdCntt),validRequired("""Rcpt""",Rcpt),validList("""Rcpt""",Rcpt),validElement(Rcpt))|

---

## Value ISO20022.Catp004001.GenericIdentification77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[a-zA-Z]{2,3}"""))|

---

## Value ISO20022.Catp004001.GeographicCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Long|String||XmlElement()||
|+|Lat|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.GeographicLocation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMCordints|ISO20022.Catp004001.UTMCoordinates1||XmlElement()||
|+|GeogcCordints|ISO20022.Catp004001.GeographicCoordinates1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTMCordints),validElement(GeogcCordints),validChoice(UTMCordints,GeogcCordints))|

---

## Value ISO20022.Catp004001.Header32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tracblt|global::System.Collections.Generic.List<ISO20022.Catp004001.Traceability4>||XmlElement()||
|+|PrcStat|String||XmlElement()||
|+|RcptPty|String||XmlElement()||
|+|InitgPty|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|ReTrnsmssnCntr|Decimal||XmlElement()||
|+|XchgId|String||XmlElement()||
|+|PrtcolVrsn|String||XmlElement()||
|+|MsgFctn|ISO20022.Catp004001.ATMMessageFunction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tracblt""",Tracblt),validElement(Tracblt),validPattern("""XchgId""",XchgId,"""[0-9]{1,3}"""),validElement(MsgFctn))|

---

## Value ISO20022.Catp004001.IssuerAndSerialNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrlNb|String||XmlElement()||
|+|Issr|ISO20022.Catp004001.CertificateIssuer1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr))|

---

## Value ISO20022.Catp004001.KEK4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp004001.AlgorithmIdentification13||XmlElement()||
|+|KEKId|ISO20022.Catp004001.KEKIdentifier2||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(KEKId))|

---

## Value ISO20022.Catp004001.KEKIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivtnId|String||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|KeyVrsn|String||XmlElement()||
|+|KeyId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.KeyTransport4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NcrptdKey|String||XmlElement()||
|+|KeyNcrptnAlgo|ISO20022.Catp004001.AlgorithmIdentification11||XmlElement()||
|+|RcptId|ISO20022.Catp004001.Recipient5Choice||XmlElement()||
|+|Vrsn|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyNcrptnAlgo),validElement(RcptId))|

---

## Enum ISO20022.Catp004001.MessageFunction11Code


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

## Enum ISO20022.Catp004001.MessageFunction8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SSTS|Int32||XmlEnum("""SSTS""")|1|
||KEYQ|Int32||XmlEnum("""KEYQ""")|2|
||INQC|Int32||XmlEnum("""INQC""")|3|
||DSEC|Int32||XmlEnum("""DSEC""")|4|
||GSTS|Int32||XmlEnum("""GSTS""")|5|
||BALN|Int32||XmlEnum("""BALN""")|6|

---

## Value ISO20022.Catp004001.Parameter4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MskGnrtrAlgo|ISO20022.Catp004001.AlgorithmIdentification12||XmlElement()||
|+|DgstAlgo|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MskGnrtrAlgo))|

---

## Value ISO20022.Catp004001.Parameter5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgstAlgo|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.Parameter6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
|+|NcrptnFrmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.Parameter7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BPddg|String||XmlElement()||
|+|InitlstnVctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp004001.PartyType12Code


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

## Value ISO20022.Catp004001.PostalAddress17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GLctn|ISO20022.Catp004001.GeographicLocation1Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GLctn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""CtrySubDvsn""",CtrySubDvsn,2),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Catp004001.Recipient4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp004001.KEKIdentifier2||XmlElement()||
|+|KEK|ISO20022.Catp004001.KEK4||XmlElement()||
|+|KeyTrnsprt|ISO20022.Catp004001.KeyTransport4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(KEK),validElement(KeyTrnsprt),validChoice(KeyIdr,KEK,KeyTrnsprt))|

---

## Value ISO20022.Catp004001.Recipient5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KeyIdr|ISO20022.Catp004001.KEKIdentifier2||XmlElement()||
|+|IssrAndSrlNb|ISO20022.Catp004001.IssuerAndSerialNumber1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyIdr),validElement(IssrAndSrlNb),validChoice(KeyIdr,IssrAndSrlNb))|

---

## Value ISO20022.Catp004001.RelativeDistinguishedName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttrVal|String||XmlElement()||
|+|AttrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Catp004001.Response12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ASUP|Int32||XmlEnum("""ASUP""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||DECL|Int32||XmlEnum("""DECL""")|3|
||APPR|Int32||XmlEnum("""APPR""")|4|

---

## Enum ISO20022.Catp004001.ResultDetail5Code


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

## Enum ISO20022.Catp004001.TMSContactLevel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENCS|Int32||XmlEnum("""ENCS""")|1|
||DTIM|Int32||XmlEnum("""DTIM""")|2|
||CRIT|Int32||XmlEnum("""CRIT""")|3|
||ASAP|Int32||XmlEnum("""ASAP""")|4|

---

## Value ISO20022.Catp004001.Traceability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TracDtTmOut|DateTime||XmlElement()||
|+|TracDtTmIn|DateTime||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RlayId|ISO20022.Catp004001.GenericIdentification77||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RlayId))|

---

## Value ISO20022.Catp004001.TransactionIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|HstTxDtTm|DateTime||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Catp004001.UTMCoordinates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTMNrthwrd|Decimal||XmlElement()||
|+|UTMEstwrd|Decimal||XmlElement()||
|+|UTMZone|String||XmlElement()||
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

