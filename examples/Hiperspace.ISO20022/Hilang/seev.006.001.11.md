# seev.006.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev006001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev006001.CancellationProcessingStatus2 {
        + AddtlInf  : String
        + Sts  : String
    }
    class ISO20022.Seev006001.CancellationStatus31Choice {
        + DtldCxlSts  : global::System.Collections.Generic.List~ISO20022.Seev006001.DetailedInstructionCancellationStatus15~
        + GblCxlSts  : ISO20022.Seev006001.CancellationStatus32Choice
    }
    ISO20022.Seev006001.CancellationStatus31Choice *-- ISO20022.Seev006001.DetailedInstructionCancellationStatus15
    ISO20022.Seev006001.CancellationStatus31Choice *-- ISO20022.Seev006001.CancellationStatus32Choice
    class ISO20022.Seev006001.CancellationStatus32Choice {
        + PdgCxl  : ISO20022.Seev006001.PendingCancellationStatus12Choice
        + Rjctd  : ISO20022.Seev006001.RejectedStatus31Choice
        + PrcgSts  : ISO20022.Seev006001.CancellationProcessingStatus2
    }
    ISO20022.Seev006001.CancellationStatus32Choice *-- ISO20022.Seev006001.PendingCancellationStatus12Choice
    ISO20022.Seev006001.CancellationStatus32Choice *-- ISO20022.Seev006001.RejectedStatus31Choice
    ISO20022.Seev006001.CancellationStatus32Choice *-- ISO20022.Seev006001.CancellationProcessingStatus2
    class ISO20022.Seev006001.CancellationStatus6Code {
        RCIS = 1
        CAND = 2
        PACK = 3
    }
    class ISO20022.Seev006001.DateAndPlaceOfBirth2 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Seev006001.DetailedInstructionCancellationStatus15 {
        + InstrCxlSts  : ISO20022.Seev006001.CancellationStatus32Choice
        + SubAcctId  : String
        + AcctId  : String
        + SnglInstrCxlId  : String
    }
    ISO20022.Seev006001.DetailedInstructionCancellationStatus15 *-- ISO20022.Seev006001.CancellationStatus32Choice
    class ISO20022.Seev006001.DetailedInstructionStatus21 {
        + InstrSts  : ISO20022.Seev006001.InstructionStatus13Choice
        + SubAcctId  : String
        + AcctId  : String
        + SnglInstrId  : String
    }
    ISO20022.Seev006001.DetailedInstructionStatus21 *-- ISO20022.Seev006001.InstructionStatus13Choice
    class ISO20022.Seev006001.EligiblePosition17 {
        + HldgBal  : global::System.Collections.Generic.List~ISO20022.Seev006001.HoldingBalance13~
        + AcctOwnr  : ISO20022.Seev006001.PartyIdentification231Choice
        + BlckChainAdrOrWllt  : String
        + AcctId  : String
    }
    ISO20022.Seev006001.EligiblePosition17 *-- ISO20022.Seev006001.HoldingBalance13
    ISO20022.Seev006001.EligiblePosition17 *-- ISO20022.Seev006001.PartyIdentification231Choice
    class ISO20022.Seev006001.FinancialInstrumentQuantity45Choice {
        + DgtlTknUnit  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev006001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev006001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev006001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev006001.HoldingBalance13 {
        + BalTp  : String
        + Bal  : ISO20022.Seev006001.SignedQuantityFormat14
    }
    ISO20022.Seev006001.HoldingBalance13 *-- ISO20022.Seev006001.SignedQuantityFormat14
    class ISO20022.Seev006001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev006001.IdentificationType45Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev006001.IdentificationType45Choice *-- ISO20022.Seev006001.GenericIdentification30
    class ISO20022.Seev006001.InstructionProcessingStatus6 {
        + AddtlInf  : String
        + AttndncCardNb  : String
        + Sts  : String
    }
    class ISO20022.Seev006001.InstructionStatus13Choice {
        + Pdg  : ISO20022.Seev006001.PendingStatus70Choice
        + Rjctd  : ISO20022.Seev006001.RejectedStatus55Choice
        + PrcgSts  : ISO20022.Seev006001.InstructionProcessingStatus6
    }
    ISO20022.Seev006001.InstructionStatus13Choice *-- ISO20022.Seev006001.PendingStatus70Choice
    ISO20022.Seev006001.InstructionStatus13Choice *-- ISO20022.Seev006001.RejectedStatus55Choice
    ISO20022.Seev006001.InstructionStatus13Choice *-- ISO20022.Seev006001.InstructionProcessingStatus6
    class ISO20022.Seev006001.InstructionType2Choice {
        + InstrCxlId  : String
        + InstrId  : String
    }
    class ISO20022.Seev006001.InstructionTypeStatus7Choice {
        + CxlSts  : ISO20022.Seev006001.CancellationStatus31Choice
        + InstrSts  : global::System.Collections.Generic.List~ISO20022.Seev006001.DetailedInstructionStatus21~
    }
    ISO20022.Seev006001.InstructionTypeStatus7Choice *-- ISO20022.Seev006001.CancellationStatus31Choice
    ISO20022.Seev006001.InstructionTypeStatus7Choice *-- ISO20022.Seev006001.DetailedInstructionStatus21
    class ISO20022.Seev006001.MeetingInstructionStatusV11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev006001.SupplementaryData1~
        + RghtsHldr  : global::System.Collections.Generic.List~ISO20022.Seev006001.PartyIdentification246Choice~
        + VoteCstgPty  : ISO20022.Seev006001.PartyIdentification226Choice
        + CnfrmgPty  : ISO20022.Seev006001.PartyIdentification226Choice
        + Pos  : ISO20022.Seev006001.EligiblePosition17
        + InstrTpSts  : ISO20022.Seev006001.InstructionTypeStatus7Choice
        + FinInstrmId  : ISO20022.Seev006001.SecurityIdentification19
        + MtgRef  : ISO20022.Seev006001.MeetingReference10
        + InstrTp  : ISO20022.Seev006001.InstructionType2Choice
    }
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.SupplementaryData1
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.PartyIdentification246Choice
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.PartyIdentification226Choice
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.PartyIdentification226Choice
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.EligiblePosition17
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.InstructionTypeStatus7Choice
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.SecurityIdentification19
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.MeetingReference10
    ISO20022.Seev006001.MeetingInstructionStatusV11 *-- ISO20022.Seev006001.InstructionType2Choice
    class ISO20022.Seev006001.MeetingReference10 {
        + Issr  : ISO20022.Seev006001.PartyIdentification129Choice
        + Lctn  : global::System.Collections.Generic.List~ISO20022.Seev006001.PostalAddress1~
        + Clssfctn  : ISO20022.Seev006001.MeetingTypeClassification2Choice
        + Tp  : String
        + MtgDtAndTm  : DateTime
        + IssrMtgId  : String
        + MtgId  : String
    }
    ISO20022.Seev006001.MeetingReference10 *-- ISO20022.Seev006001.PartyIdentification129Choice
    ISO20022.Seev006001.MeetingReference10 *-- ISO20022.Seev006001.PostalAddress1
    ISO20022.Seev006001.MeetingReference10 *-- ISO20022.Seev006001.MeetingTypeClassification2Choice
    class ISO20022.Seev006001.MeetingType4Code {
        CMET = 1
        BMET = 2
        SPCL = 3
        MIXD = 4
        GMET = 5
        XMET = 6
    }
    class ISO20022.Seev006001.MeetingTypeClassification2Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev006001.MeetingTypeClassification2Choice *-- ISO20022.Seev006001.GenericIdentification13
    class ISO20022.Seev006001.MeetingTypeClassification2Code {
        VRHI = 1
        OMET = 2
        ISSU = 3
        CLAS = 4
        AMET = 5
    }
    class ISO20022.Seev006001.NameAndAddress5 {
        + Adr  : ISO20022.Seev006001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev006001.NameAndAddress5 *-- ISO20022.Seev006001.PostalAddress1
    class ISO20022.Seev006001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Seev006001.NaturalPersonIdentification1 {
        + IdTp  : ISO20022.Seev006001.IdentificationType45Choice
        + Id  : String
    }
    ISO20022.Seev006001.NaturalPersonIdentification1 *-- ISO20022.Seev006001.IdentificationType45Choice
    class ISO20022.Seev006001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev006001.OtherIdentification1 {
        + Tp  : ISO20022.Seev006001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev006001.OtherIdentification1 *-- ISO20022.Seev006001.IdentificationSource3Choice
    class ISO20022.Seev006001.PartyIdentification129Choice {
        + LEI  : String
        + NmAndAdr  : ISO20022.Seev006001.NameAndAddress5
        + PrtryId  : ISO20022.Seev006001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev006001.PartyIdentification129Choice *-- ISO20022.Seev006001.NameAndAddress5
    ISO20022.Seev006001.PartyIdentification129Choice *-- ISO20022.Seev006001.GenericIdentification36
    class ISO20022.Seev006001.PartyIdentification198Choice {
        + PrtryId  : ISO20022.Seev006001.GenericIdentification36
        + ClntId  : String
        + AnyBIC  : String
        + LEI  : String
        + NtlRegnNb  : String
    }
    ISO20022.Seev006001.PartyIdentification198Choice *-- ISO20022.Seev006001.GenericIdentification36
    class ISO20022.Seev006001.PartyIdentification221 {
        + Id  : ISO20022.Seev006001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName2
    }
    ISO20022.Seev006001.PartyIdentification221 *-- ISO20022.Seev006001.PartyIdentification198Choice
    ISO20022.Seev006001.PartyIdentification221 *-- ISO20022.Seev006001.PersonName2
    class ISO20022.Seev006001.PartyIdentification222 {
        + Id  : ISO20022.Seev006001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName1
    }
    ISO20022.Seev006001.PartyIdentification222 *-- ISO20022.Seev006001.NaturalPersonIdentification1
    ISO20022.Seev006001.PartyIdentification222 *-- ISO20022.Seev006001.PersonName1
    class ISO20022.Seev006001.PartyIdentification224 {
        + Id  : ISO20022.Seev006001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName2
    }
    ISO20022.Seev006001.PartyIdentification224 *-- ISO20022.Seev006001.PartyIdentification198Choice
    ISO20022.Seev006001.PartyIdentification224 *-- ISO20022.Seev006001.PersonName2
    class ISO20022.Seev006001.PartyIdentification226Choice {
        + NtrlPrsn  : ISO20022.Seev006001.PartyIdentification222
        + LglPrsn  : ISO20022.Seev006001.PartyIdentification224
    }
    ISO20022.Seev006001.PartyIdentification226Choice *-- ISO20022.Seev006001.PartyIdentification222
    ISO20022.Seev006001.PartyIdentification226Choice *-- ISO20022.Seev006001.PartyIdentification224
    class ISO20022.Seev006001.PartyIdentification231Choice {
        + NtrlPrsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.PartyIdentification238~
        + LglPrsn  : ISO20022.Seev006001.PartyIdentification221
    }
    ISO20022.Seev006001.PartyIdentification231Choice *-- ISO20022.Seev006001.PartyIdentification238
    ISO20022.Seev006001.PartyIdentification231Choice *-- ISO20022.Seev006001.PartyIdentification221
    class ISO20022.Seev006001.PartyIdentification238 {
        + DtAndPlcOfBirth  : ISO20022.Seev006001.DateAndPlaceOfBirth2
        + Ntlty  : String
        + Id  : ISO20022.Seev006001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName3
    }
    ISO20022.Seev006001.PartyIdentification238 *-- ISO20022.Seev006001.DateAndPlaceOfBirth2
    ISO20022.Seev006001.PartyIdentification238 *-- ISO20022.Seev006001.NaturalPersonIdentification1
    ISO20022.Seev006001.PartyIdentification238 *-- ISO20022.Seev006001.PersonName3
    class ISO20022.Seev006001.PartyIdentification246Choice {
        + NtrlPrsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.PartyIdentification250~
        + LglPrsn  : ISO20022.Seev006001.PartyIdentification269
    }
    ISO20022.Seev006001.PartyIdentification246Choice *-- ISO20022.Seev006001.PartyIdentification250
    ISO20022.Seev006001.PartyIdentification246Choice *-- ISO20022.Seev006001.PartyIdentification269
    class ISO20022.Seev006001.PartyIdentification250 {
        + CpnyRegrShrhldrId  : String
        + DtAndPlcOfBirth  : ISO20022.Seev006001.DateAndPlaceOfBirth2
        + Ntlty  : String
        + Id  : ISO20022.Seev006001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName3
    }
    ISO20022.Seev006001.PartyIdentification250 *-- ISO20022.Seev006001.DateAndPlaceOfBirth2
    ISO20022.Seev006001.PartyIdentification250 *-- ISO20022.Seev006001.NaturalPersonIdentification1
    ISO20022.Seev006001.PartyIdentification250 *-- ISO20022.Seev006001.PersonName3
    class ISO20022.Seev006001.PartyIdentification269 {
        + CtryOfIncorprtn  : String
        + CpnyRegrShrhldrId  : String
        + Id  : ISO20022.Seev006001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev006001.PersonName2
    }
    ISO20022.Seev006001.PartyIdentification269 *-- ISO20022.Seev006001.PartyIdentification198Choice
    ISO20022.Seev006001.PartyIdentification269 *-- ISO20022.Seev006001.PersonName2
    class ISO20022.Seev006001.PendingCancellationReason6Code {
        ADEA = 1
        OTHR = 2
        LATE = 3
        DQUA = 4
    }
    class ISO20022.Seev006001.PendingCancellationReason7Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev006001.PendingCancellationReason7Choice *-- ISO20022.Seev006001.GenericIdentification30
    class ISO20022.Seev006001.PendingCancellationStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.PendingCancellationStatusReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev006001.PendingCancellationStatus12Choice *-- ISO20022.Seev006001.PendingCancellationStatusReason10
    class ISO20022.Seev006001.PendingCancellationStatusReason10 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev006001.PendingCancellationReason7Choice
    }
    ISO20022.Seev006001.PendingCancellationStatusReason10 *-- ISO20022.Seev006001.PendingCancellationReason7Choice
    class ISO20022.Seev006001.PendingReason25Code {
        IPED = 1
        PENR = 2
        PRXY = 3
        OTHR = 4
        IREG = 5
        NPOS = 6
        LATE = 7
        LACK = 8
        IPOS = 9
        IPOA = 10
        FULL = 11
        DREM = 12
        DQUA = 13
        ADDM = 14
        ADEA = 15
    }
    class ISO20022.Seev006001.PendingReason67Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev006001.PendingReason67Choice *-- ISO20022.Seev006001.GenericIdentification30
    class ISO20022.Seev006001.PendingStatus70Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.PendingStatusReason26~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev006001.PendingStatus70Choice *-- ISO20022.Seev006001.PendingStatusReason26
    class ISO20022.Seev006001.PendingStatusReason26 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev006001.PendingReason67Choice
    }
    ISO20022.Seev006001.PendingStatusReason26 *-- ISO20022.Seev006001.PendingReason67Choice
    class ISO20022.Seev006001.PersonName1 {
        + Adr  : ISO20022.Seev006001.PostalAddress26
        + Srnm  : String
        + FrstNm  : String
    }
    ISO20022.Seev006001.PersonName1 *-- ISO20022.Seev006001.PostalAddress26
    class ISO20022.Seev006001.PersonName2 {
        + Adr  : ISO20022.Seev006001.PostalAddress26
        + Nm  : String
    }
    ISO20022.Seev006001.PersonName2 *-- ISO20022.Seev006001.PostalAddress26
    class ISO20022.Seev006001.PersonName3 {
        + Adr  : ISO20022.Seev006001.PostalAddress26
        + Srnm  : String
        + FrstNm  : String
        + NmPrfx  : String
    }
    ISO20022.Seev006001.PersonName3 *-- ISO20022.Seev006001.PostalAddress26
    class ISO20022.Seev006001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev006001.PostalAddress26 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + PstBx  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev006001.RejectedReason29Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev006001.RejectedReason29Choice *-- ISO20022.Seev006001.GenericIdentification30
    class ISO20022.Seev006001.RejectedReason57Choice {
        + Prtry  : ISO20022.Seev006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev006001.RejectedReason57Choice *-- ISO20022.Seev006001.GenericIdentification30
    class ISO20022.Seev006001.RejectedStatus31Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.RejectedStatusReason28~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev006001.RejectedStatus31Choice *-- ISO20022.Seev006001.RejectedStatusReason28
    class ISO20022.Seev006001.RejectedStatus55Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev006001.RejectedStatusReason54~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev006001.RejectedStatus55Choice *-- ISO20022.Seev006001.RejectedStatusReason54
    class ISO20022.Seev006001.RejectedStatusReason28 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev006001.RejectedReason29Choice
    }
    ISO20022.Seev006001.RejectedStatusReason28 *-- ISO20022.Seev006001.RejectedReason29Choice
    class ISO20022.Seev006001.RejectedStatusReason54 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev006001.RejectedReason57Choice
    }
    ISO20022.Seev006001.RejectedStatusReason54 *-- ISO20022.Seev006001.RejectedReason57Choice
    class ISO20022.Seev006001.RejectionReason51Code {
        ULNK = 1
        SAFE = 2
        RBIS = 3
        OTHR = 4
        LATE = 5
        INIR = 6
        EVNM = 7
        DSEC = 8
        DPRG = 9
        DCAN = 10
        DQUA = 11
        ADEA = 12
    }
    class ISO20022.Seev006001.RejectionReason82Code {
        DUPL = 1
        IPED = 2
        PMNS = 3
        NOSL = 4
        LIST = 5
        LACK = 6
        OPTY = 7
        ULNK = 8
        SPLT = 9
        SAFE = 10
        RESN = 11
        RBIS = 12
        PRXY = 13
        PART = 14
        OTHR = 15
        NPOS = 16
        LATE = 17
        IREG = 18
        IPOS = 19
        IPOA = 20
        FULL = 21
        EVNM = 22
        DSEC = 23
        DREM = 24
        DQUA = 25
        MCAN = 26
        ADDM = 27
        ADEA = 28
    }
    class ISO20022.Seev006001.SecuritiesEntryType3Code {
        INBA = 1
        UNBA = 2
        ELIG = 3
    }
    class ISO20022.Seev006001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev006001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev006001.SecurityIdentification19 *-- ISO20022.Seev006001.OtherIdentification1
    class ISO20022.Seev006001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev006001.SignedQuantityFormat14 {
        + Qty  : ISO20022.Seev006001.FinancialInstrumentQuantity45Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev006001.SignedQuantityFormat14 *-- ISO20022.Seev006001.FinancialInstrumentQuantity45Choice
    class ISO20022.Seev006001.Status11Code {
        DREG = 1
        STIN = 2
        REGM = 3
        RCIS = 4
        FRWD = 5
        CSUB = 6
        CAND = 7
        ATTC = 8
        PACK = 9
    }
    class ISO20022.Seev006001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev006001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev006001.SupplementaryData1 *-- ISO20022.Seev006001.SupplementaryDataEnvelope1
    class ISO20022.Seev006001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev006001.TypeOfIdentification4Code {
        TXID = 1
        SOCS = 2
        CCPT = 3
        NRIN = 4
        IDCD = 5
        DRLC = 6
        CORP = 7
        CUST = 8
        ARNU = 9
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

## Enum ISO20022.Seev006001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev006001.CancellationProcessingStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev006001.CancellationStatus31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtldCxlSts|global::System.Collections.Generic.List<ISO20022.Seev006001.DetailedInstructionCancellationStatus15>||XmlElement()||
|+|GblCxlSts|ISO20022.Seev006001.CancellationStatus32Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""DtldCxlSts""",DtldCxlSts),validList("""DtldCxlSts""",DtldCxlSts),validElement(DtldCxlSts),validElement(GblCxlSts),validChoice(DtldCxlSts,GblCxlSts))|

---

## Value ISO20022.Seev006001.CancellationStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgCxl|ISO20022.Seev006001.PendingCancellationStatus12Choice||XmlElement()||
|+|Rjctd|ISO20022.Seev006001.RejectedStatus31Choice||XmlElement()||
|+|PrcgSts|ISO20022.Seev006001.CancellationProcessingStatus2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdgCxl),validElement(Rjctd),validElement(PrcgSts),validChoice(PdgCxl,Rjctd,PrcgSts))|

---

## Enum ISO20022.Seev006001.CancellationStatus6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCIS|Int32||XmlEnum("""RCIS""")|1|
||CAND|Int32||XmlEnum("""CAND""")|2|
||PACK|Int32||XmlEnum("""PACK""")|3|

---

## Value ISO20022.Seev006001.DateAndPlaceOfBirth2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Seev006001.DetailedInstructionCancellationStatus15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrCxlSts|ISO20022.Seev006001.CancellationStatus32Choice||XmlElement()||
|+|SubAcctId|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|SnglInstrCxlId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrCxlSts))|

---

## Value ISO20022.Seev006001.DetailedInstructionStatus21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrSts|ISO20022.Seev006001.InstructionStatus13Choice||XmlElement()||
|+|SubAcctId|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|SnglInstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrSts))|

---

## Type ISO20022.Seev006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtgInstrSts|ISO20022.Seev006001.MeetingInstructionStatusV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtgInstrSts))|

---

## Value ISO20022.Seev006001.EligiblePosition17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgBal|global::System.Collections.Generic.List<ISO20022.Seev006001.HoldingBalance13>||XmlElement()||
|+|AcctOwnr|ISO20022.Seev006001.PartyIdentification231Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""HldgBal""",HldgBal),validList("""HldgBal""",HldgBal),validListMax("""HldgBal""",HldgBal,3),validElement(HldgBal),validElement(AcctOwnr))|

---

## Value ISO20022.Seev006001.FinancialInstrumentQuantity45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,FaceAmt,Unit))|

---

## Value ISO20022.Seev006001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev006001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev006001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev006001.HoldingBalance13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalTp|String||XmlElement()||
|+|Bal|ISO20022.Seev006001.SignedQuantityFormat14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal))|

---

## Value ISO20022.Seev006001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.IdentificationType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.InstructionProcessingStatus6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|AttndncCardNb|String||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev006001.InstructionStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pdg|ISO20022.Seev006001.PendingStatus70Choice||XmlElement()||
|+|Rjctd|ISO20022.Seev006001.RejectedStatus55Choice||XmlElement()||
|+|PrcgSts|ISO20022.Seev006001.InstructionProcessingStatus6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pdg),validElement(Rjctd),validElement(PrcgSts),validChoice(Pdg,Rjctd,PrcgSts))|

---

## Value ISO20022.Seev006001.InstructionType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrCxlId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(InstrCxlId,InstrId))|

---

## Value ISO20022.Seev006001.InstructionTypeStatus7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlSts|ISO20022.Seev006001.CancellationStatus31Choice||XmlElement()||
|+|InstrSts|global::System.Collections.Generic.List<ISO20022.Seev006001.DetailedInstructionStatus21>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlSts),validRequired("""InstrSts""",InstrSts),validList("""InstrSts""",InstrSts),validElement(InstrSts),validChoice(CxlSts,InstrSts))|

---

## Aspect ISO20022.Seev006001.MeetingInstructionStatusV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev006001.SupplementaryData1>||XmlElement()||
|+|RghtsHldr|global::System.Collections.Generic.List<ISO20022.Seev006001.PartyIdentification246Choice>||XmlElement()||
|+|VoteCstgPty|ISO20022.Seev006001.PartyIdentification226Choice||XmlElement()||
|+|CnfrmgPty|ISO20022.Seev006001.PartyIdentification226Choice||XmlElement()||
|+|Pos|ISO20022.Seev006001.EligiblePosition17||XmlElement()||
|+|InstrTpSts|ISO20022.Seev006001.InstructionTypeStatus7Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev006001.SecurityIdentification19||XmlElement()||
|+|MtgRef|ISO20022.Seev006001.MeetingReference10||XmlElement()||
|+|InstrTp|ISO20022.Seev006001.InstructionType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""RghtsHldr""",RghtsHldr),validListMax("""RghtsHldr""",RghtsHldr,250),validElement(RghtsHldr),validElement(VoteCstgPty),validElement(CnfrmgPty),validElement(Pos),validElement(InstrTpSts),validElement(FinInstrmId),validElement(MtgRef),validElement(InstrTp))|

---

## Value ISO20022.Seev006001.MeetingReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|ISO20022.Seev006001.PartyIdentification129Choice||XmlElement()||
|+|Lctn|global::System.Collections.Generic.List<ISO20022.Seev006001.PostalAddress1>||XmlElement()||
|+|Clssfctn|ISO20022.Seev006001.MeetingTypeClassification2Choice||XmlElement()||
|+|Tp|String||XmlElement()||
|+|MtgDtAndTm|DateTime||XmlElement()||
|+|IssrMtgId|String||XmlElement()||
|+|MtgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Issr),validList("""Lctn""",Lctn),validListMax("""Lctn""",Lctn,5),validElement(Lctn),validElement(Clssfctn))|

---

## Enum ISO20022.Seev006001.MeetingType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMET|Int32||XmlEnum("""CMET""")|1|
||BMET|Int32||XmlEnum("""BMET""")|2|
||SPCL|Int32||XmlEnum("""SPCL""")|3|
||MIXD|Int32||XmlEnum("""MIXD""")|4|
||GMET|Int32||XmlEnum("""GMET""")|5|
||XMET|Int32||XmlEnum("""XMET""")|6|

---

## Value ISO20022.Seev006001.MeetingTypeClassification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev006001.MeetingTypeClassification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VRHI|Int32||XmlEnum("""VRHI""")|1|
||OMET|Int32||XmlEnum("""OMET""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||CLAS|Int32||XmlEnum("""CLAS""")|4|
||AMET|Int32||XmlEnum("""AMET""")|5|

---

## Value ISO20022.Seev006001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev006001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev006001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Seev006001.NaturalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|ISO20022.Seev006001.IdentificationType45Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdTp))|

---

## Enum ISO20022.Seev006001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev006001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev006001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev006001.PartyIdentification129Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev006001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev006001.PartyIdentification198Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev006001.GenericIdentification36||XmlElement()||
|+|ClntId|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(PrtryId,ClntId,AnyBIC,LEI,NtlRegnNb))|

---

## Value ISO20022.Seev006001.PartyIdentification221


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev006001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev006001.PartyIdentification222


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev006001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev006001.PartyIdentification224


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev006001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev006001.PartyIdentification226Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|ISO20022.Seev006001.PartyIdentification222||XmlElement()||
|+|LglPrsn|ISO20022.Seev006001.PartyIdentification224||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev006001.PartyIdentification231Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|global::System.Collections.Generic.List<ISO20022.Seev006001.PartyIdentification238>||XmlElement()||
|+|LglPrsn|ISO20022.Seev006001.PartyIdentification221||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NtrlPrsn""",NtrlPrsn),validList("""NtrlPrsn""",NtrlPrsn),validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev006001.PartyIdentification238


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtAndPlcOfBirth|ISO20022.Seev006001.DateAndPlaceOfBirth2||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Id|ISO20022.Seev006001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtAndPlcOfBirth),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev006001.PartyIdentification246Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|global::System.Collections.Generic.List<ISO20022.Seev006001.PartyIdentification250>||XmlElement()||
|+|LglPrsn|ISO20022.Seev006001.PartyIdentification269||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NtrlPrsn""",NtrlPrsn),validList("""NtrlPrsn""",NtrlPrsn),validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev006001.PartyIdentification250


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CpnyRegrShrhldrId|String||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Seev006001.DateAndPlaceOfBirth2||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Id|ISO20022.Seev006001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtAndPlcOfBirth),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev006001.PartyIdentification269


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfIncorprtn|String||XmlElement()||
|+|CpnyRegrShrhldrId|String||XmlElement()||
|+|Id|ISO20022.Seev006001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev006001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfIncorprtn""",CtryOfIncorprtn,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Enum ISO20022.Seev006001.PendingCancellationReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADEA|Int32||XmlEnum("""ADEA""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||LATE|Int32||XmlEnum("""LATE""")|3|
||DQUA|Int32||XmlEnum("""DQUA""")|4|

---

## Value ISO20022.Seev006001.PendingCancellationReason7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.PendingCancellationStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev006001.PendingCancellationStatusReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev006001.PendingCancellationStatusReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev006001.PendingCancellationReason7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev006001.PendingReason25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPED|Int32||XmlEnum("""IPED""")|1|
||PENR|Int32||XmlEnum("""PENR""")|2|
||PRXY|Int32||XmlEnum("""PRXY""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||IREG|Int32||XmlEnum("""IREG""")|5|
||NPOS|Int32||XmlEnum("""NPOS""")|6|
||LATE|Int32||XmlEnum("""LATE""")|7|
||LACK|Int32||XmlEnum("""LACK""")|8|
||IPOS|Int32||XmlEnum("""IPOS""")|9|
||IPOA|Int32||XmlEnum("""IPOA""")|10|
||FULL|Int32||XmlEnum("""FULL""")|11|
||DREM|Int32||XmlEnum("""DREM""")|12|
||DQUA|Int32||XmlEnum("""DQUA""")|13|
||ADDM|Int32||XmlEnum("""ADDM""")|14|
||ADEA|Int32||XmlEnum("""ADEA""")|15|

---

## Value ISO20022.Seev006001.PendingReason67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.PendingStatus70Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev006001.PendingStatusReason26>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev006001.PendingStatusReason26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev006001.PendingReason67Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Value ISO20022.Seev006001.PersonName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev006001.PostalAddress26||XmlElement()||
|+|Srnm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev006001.PersonName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev006001.PostalAddress26||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev006001.PersonName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev006001.PostalAddress26||XmlElement()||
|+|Srnm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev006001.PostalAddress1


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

## Value ISO20022.Seev006001.PostalAddress26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Seev006001.RejectedReason29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.RejectedReason57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev006001.RejectedStatus31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev006001.RejectedStatusReason28>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev006001.RejectedStatus55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev006001.RejectedStatusReason54>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev006001.RejectedStatusReason28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev006001.RejectedReason29Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Value ISO20022.Seev006001.RejectedStatusReason54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev006001.RejectedReason57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev006001.RejectionReason51Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ULNK|Int32||XmlEnum("""ULNK""")|1|
||SAFE|Int32||XmlEnum("""SAFE""")|2|
||RBIS|Int32||XmlEnum("""RBIS""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|
||INIR|Int32||XmlEnum("""INIR""")|6|
||EVNM|Int32||XmlEnum("""EVNM""")|7|
||DSEC|Int32||XmlEnum("""DSEC""")|8|
||DPRG|Int32||XmlEnum("""DPRG""")|9|
||DCAN|Int32||XmlEnum("""DCAN""")|10|
||DQUA|Int32||XmlEnum("""DQUA""")|11|
||ADEA|Int32||XmlEnum("""ADEA""")|12|

---

## Enum ISO20022.Seev006001.RejectionReason82Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||IPED|Int32||XmlEnum("""IPED""")|2|
||PMNS|Int32||XmlEnum("""PMNS""")|3|
||NOSL|Int32||XmlEnum("""NOSL""")|4|
||LIST|Int32||XmlEnum("""LIST""")|5|
||LACK|Int32||XmlEnum("""LACK""")|6|
||OPTY|Int32||XmlEnum("""OPTY""")|7|
||ULNK|Int32||XmlEnum("""ULNK""")|8|
||SPLT|Int32||XmlEnum("""SPLT""")|9|
||SAFE|Int32||XmlEnum("""SAFE""")|10|
||RESN|Int32||XmlEnum("""RESN""")|11|
||RBIS|Int32||XmlEnum("""RBIS""")|12|
||PRXY|Int32||XmlEnum("""PRXY""")|13|
||PART|Int32||XmlEnum("""PART""")|14|
||OTHR|Int32||XmlEnum("""OTHR""")|15|
||NPOS|Int32||XmlEnum("""NPOS""")|16|
||LATE|Int32||XmlEnum("""LATE""")|17|
||IREG|Int32||XmlEnum("""IREG""")|18|
||IPOS|Int32||XmlEnum("""IPOS""")|19|
||IPOA|Int32||XmlEnum("""IPOA""")|20|
||FULL|Int32||XmlEnum("""FULL""")|21|
||EVNM|Int32||XmlEnum("""EVNM""")|22|
||DSEC|Int32||XmlEnum("""DSEC""")|23|
||DREM|Int32||XmlEnum("""DREM""")|24|
||DQUA|Int32||XmlEnum("""DQUA""")|25|
||MCAN|Int32||XmlEnum("""MCAN""")|26|
||ADDM|Int32||XmlEnum("""ADDM""")|27|
||ADEA|Int32||XmlEnum("""ADEA""")|28|

---

## Enum ISO20022.Seev006001.SecuritiesEntryType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBA|Int32||XmlEnum("""INBA""")|1|
||UNBA|Int32||XmlEnum("""UNBA""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Seev006001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev006001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev006001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev006001.SignedQuantityFormat14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev006001.FinancialInstrumentQuantity45Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Enum ISO20022.Seev006001.Status11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DREG|Int32||XmlEnum("""DREG""")|1|
||STIN|Int32||XmlEnum("""STIN""")|2|
||REGM|Int32||XmlEnum("""REGM""")|3|
||RCIS|Int32||XmlEnum("""RCIS""")|4|
||FRWD|Int32||XmlEnum("""FRWD""")|5|
||CSUB|Int32||XmlEnum("""CSUB""")|6|
||CAND|Int32||XmlEnum("""CAND""")|7|
||ATTC|Int32||XmlEnum("""ATTC""")|8|
||PACK|Int32||XmlEnum("""PACK""")|9|

---

## Value ISO20022.Seev006001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev006001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev006001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev006001.TypeOfIdentification4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||SOCS|Int32||XmlEnum("""SOCS""")|2|
||CCPT|Int32||XmlEnum("""CCPT""")|3|
||NRIN|Int32||XmlEnum("""NRIN""")|4|
||IDCD|Int32||XmlEnum("""IDCD""")|5|
||DRLC|Int32||XmlEnum("""DRLC""")|6|
||CORP|Int32||XmlEnum("""CORP""")|7|
||CUST|Int32||XmlEnum("""CUST""")|8|
||ARNU|Int32||XmlEnum("""ARNU""")|9|

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

