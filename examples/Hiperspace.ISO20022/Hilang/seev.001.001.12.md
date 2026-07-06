# seev.001.001.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev001001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev001001.AdditionalRight1Code {
        AIPS = 1
        RSPS = 2
        WQPS = 3
    }
    class ISO20022.Seev001001.AdditionalRightCode1Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev001001.AdditionalRightCode1Choice *-- ISO20022.Seev001001.GenericIdentification13
    class ISO20022.Seev001001.AdditionalRightThreshold2Choice {
        + AddtlRghtThrshldPctg  : Decimal
        + AddtlRghtThrshld  : String
    }
    class ISO20022.Seev001001.AdditionalRights4 {
        + AddtlRghtThrshld  : ISO20022.Seev001001.AdditionalRightThreshold2Choice
        + AddtlRghtMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + AddtlRghtDdln  : ISO20022.Seev001001.DateFormat58Choice
        + AddtlRghtInfURLAdr  : String
        + AddtlRght  : ISO20022.Seev001001.AdditionalRightCode1Choice
    }
    ISO20022.Seev001001.AdditionalRights4 *-- ISO20022.Seev001001.AdditionalRightThreshold2Choice
    ISO20022.Seev001001.AdditionalRights4 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.AdditionalRights4 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.AdditionalRights4 *-- ISO20022.Seev001001.AdditionalRightCode1Choice
    class ISO20022.Seev001001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev001001.AgentRole1Code {
        SUBA = 1
        PRIN = 2
    }
    class ISO20022.Seev001001.Attendance2 {
        + ConfMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + ConfDdln  : ISO20022.Seev001001.DateFormat58Choice
        + ConfInf  : String
        + AdmssnConds  : global::System.Collections.Generic.List~ISO20022.Seev001001.AttendanceAdmissionConditions2~
    }
    ISO20022.Seev001001.Attendance2 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.Attendance2 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.Attendance2 *-- ISO20022.Seev001001.AttendanceAdmissionConditions2
    class ISO20022.Seev001001.AttendanceAdmissionConditions2 {
        + AddtlInf  : String
        + Cd  : String
    }
    class ISO20022.Seev001001.AttendanceAdmissionConditions2Code {
        MANP = 1
        MADS = 2
        MATK = 3
        MAHI = 4
        MALR = 5
        MAAL = 6
        MAPO = 7
        MASL = 8
        MASH = 9
    }
    class ISO20022.Seev001001.CommunicationAddress11 {
        + URLAdr  : String
        + EmailAdr  : String
    }
    class ISO20022.Seev001001.CommunicationAddress12 {
        + URLAdr  : String
    }
    class ISO20022.Seev001001.ContactIdentification1 {
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + Role  : String
        + GvnNm  : String
        + NmPrfx  : String
        + Nm  : String
    }
    class ISO20022.Seev001001.CorporateEventNarrative4 {
        + PrcgTxtForNxtIntrmy  : global::System.Collections.Generic.List~String~
        + Dsclmr  : global::System.Collections.Generic.List~ISO20022.Seev001001.LanguageSpecifiedNarrative1~
    }
    ISO20022.Seev001001.CorporateEventNarrative4 *-- ISO20022.Seev001001.LanguageSpecifiedNarrative1
    class ISO20022.Seev001001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev001001.DateAndPlaceOfBirth2 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Seev001001.DateCode34Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev001001.DateCode34Choice *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.DateFormat1 {
        + DtMd  : String
        + Dt  : ISO20022.Seev001001.DateFormat3Choice
    }
    ISO20022.Seev001001.DateFormat1 *-- ISO20022.Seev001001.DateFormat3Choice
    class ISO20022.Seev001001.DateFormat3Choice {
        + DtCd  : String
        + Dt  : DateTime
    }
    class ISO20022.Seev001001.DateFormat58Choice {
        + DtCd  : String
        + DtOrDtTm  : ISO20022.Seev001001.DateAndDateTime2Choice
    }
    ISO20022.Seev001001.DateFormat58Choice *-- ISO20022.Seev001001.DateAndDateTime2Choice
    class ISO20022.Seev001001.DateFormat60Choice {
        + DtCd  : ISO20022.Seev001001.DateCode34Choice
        + Dt  : ISO20022.Seev001001.DateAndDateTime2Choice
    }
    ISO20022.Seev001001.DateFormat60Choice *-- ISO20022.Seev001001.DateCode34Choice
    ISO20022.Seev001001.DateFormat60Choice *-- ISO20022.Seev001001.DateAndDateTime2Choice
    class ISO20022.Seev001001.DateMode1Code {
        EODY = 1
        BODY = 2
    }
    class ISO20022.Seev001001.DateType10Code {
        PPYD = 1
        RDTE = 2
        NARR = 3
        UKWN = 4
        MEET = 5
    }
    class ISO20022.Seev001001.DateType1Code {
        UKWN = 1
    }
    class ISO20022.Seev001001.EligiblePosition18 {
        + RghtsHldr  : global::System.Collections.Generic.List~ISO20022.Seev001001.PartyIdentification246Choice~
        + HldgBal  : global::System.Collections.Generic.List~ISO20022.Seev001001.HoldingBalance14~
        + AcctOwnr  : ISO20022.Seev001001.PartyIdentification231Choice
        + BlckChainAdrOrWllt  : String
        + AcctId  : String
    }
    ISO20022.Seev001001.EligiblePosition18 *-- ISO20022.Seev001001.PartyIdentification246Choice
    ISO20022.Seev001001.EligiblePosition18 *-- ISO20022.Seev001001.HoldingBalance14
    ISO20022.Seev001001.EligiblePosition18 *-- ISO20022.Seev001001.PartyIdentification231Choice
    class ISO20022.Seev001001.Entitlement1Choice {
        + EntitlmntDesc  : String
        + EntitlmntRatio  : Decimal
    }
    class ISO20022.Seev001001.EventCompletenessStatus1Code {
        INCO = 1
        COMP = 2
    }
    class ISO20022.Seev001001.EventConfirmationStatus1Code {
        UCON = 1
        CONF = 2
    }
    class ISO20022.Seev001001.EventStatus1 {
        + EvtConfSts  : String
        + EvtCmpltnsSts  : String
    }
    class ISO20022.Seev001001.FinancialInstrumentQuantity18Choice {
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev001001.FinancialInstrumentQuantity45Choice {
        + DgtlTknUnit  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev001001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev001001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev001001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev001001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev001001.GenericIdentification30
    }
    ISO20022.Seev001001.GenericIdentification78 *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.HoldingBalance14 {
        + Dt  : DateTime
        + SfkpgPlc  : ISO20022.Seev001001.SafekeepingPlaceFormat42Choice
        + BalTp  : String
        + Bal  : ISO20022.Seev001001.SignedQuantityFormat14
    }
    ISO20022.Seev001001.HoldingBalance14 *-- ISO20022.Seev001001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev001001.HoldingBalance14 *-- ISO20022.Seev001001.SignedQuantityFormat14
    class ISO20022.Seev001001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev001001.IdentificationType45Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev001001.IdentificationType45Choice *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.IncentivePremium6 {
        + PmtDt  : ISO20022.Seev001001.DateFormat3Choice
        + Tp  : ISO20022.Seev001001.IncentivePremiumType2Choice
        + Amt  : ISO20022.Seev001001.PriceRateOrAmount8Choice
        + Desc  : String
    }
    ISO20022.Seev001001.IncentivePremium6 *-- ISO20022.Seev001001.DateFormat3Choice
    ISO20022.Seev001001.IncentivePremium6 *-- ISO20022.Seev001001.IncentivePremiumType2Choice
    ISO20022.Seev001001.IncentivePremium6 *-- ISO20022.Seev001001.PriceRateOrAmount8Choice
    class ISO20022.Seev001001.IncentivePremiumType2Choice {
        + PerAttndee  : String
        + PerVote  : global::System.Collections.Generic.List~ISO20022.Seev001001.VoteTypeAndQuantity1~
        + PerScty  : Decimal
    }
    ISO20022.Seev001001.IncentivePremiumType2Choice *-- ISO20022.Seev001001.VoteTypeAndQuantity1
    class ISO20022.Seev001001.IndividualPerson43 {
        + EmplngPty  : ISO20022.Seev001001.PartyIdentification129Choice
        + PrssgndPrxy  : ISO20022.Seev001001.PartyIdentification232Choice
    }
    ISO20022.Seev001001.IndividualPerson43 *-- ISO20022.Seev001001.PartyIdentification129Choice
    ISO20022.Seev001001.IndividualPerson43 *-- ISO20022.Seev001001.PartyIdentification232Choice
    class ISO20022.Seev001001.IssuerAgent3 {
        + Role  : String
        + Id  : ISO20022.Seev001001.PartyIdentification129Choice
    }
    ISO20022.Seev001001.IssuerAgent3 *-- ISO20022.Seev001001.PartyIdentification129Choice
    class ISO20022.Seev001001.IssuerInformation3 {
        + URLAdr  : String
        + Id  : ISO20022.Seev001001.PartyIdentification129Choice
    }
    ISO20022.Seev001001.IssuerInformation3 *-- ISO20022.Seev001001.PartyIdentification129Choice
    class ISO20022.Seev001001.ItemDescription2 {
        + Desc  : global::System.Collections.Generic.List~String~
        + Titl  : String
        + Lang  : String
    }
    class ISO20022.Seev001001.LanguageSpecifiedNarrative1 {
        + AddtlInf  : String
        + Lang  : String
    }
    class ISO20022.Seev001001.LocationFormat1Choice {
        + LctnCd  : String
        + Adr  : ISO20022.Seev001001.PostalAddress1
    }
    ISO20022.Seev001001.LocationFormat1Choice *-- ISO20022.Seev001001.PostalAddress1
    class ISO20022.Seev001001.MailAddress1 {
        + EmailAdr  : global::System.Collections.Generic.List~String~
        + Crspdc  : global::System.Collections.Generic.List~ISO20022.Seev001001.PostalAddress1~
    }
    ISO20022.Seev001001.MailAddress1 *-- ISO20022.Seev001001.PostalAddress1
    class ISO20022.Seev001001.Meeting7 {
        + URLAdr  : String
        + QrmQty  : ISO20022.Seev001001.QuorumQuantity2Choice
        + Lctn  : global::System.Collections.Generic.List~ISO20022.Seev001001.LocationFormat1Choice~
        + QrmReqrd  : String
        + DtSts  : String
        + DtAndTm  : ISO20022.Seev001001.DateFormat58Choice
    }
    ISO20022.Seev001001.Meeting7 *-- ISO20022.Seev001001.QuorumQuantity2Choice
    ISO20022.Seev001001.Meeting7 *-- ISO20022.Seev001001.LocationFormat1Choice
    ISO20022.Seev001001.Meeting7 *-- ISO20022.Seev001001.DateFormat58Choice
    class ISO20022.Seev001001.MeetingContactPerson3 {
        + PlcOfListg  : String
        + EmplngPty  : ISO20022.Seev001001.PartyIdentification129Choice
        + CtctPrsn  : ISO20022.Seev001001.ContactIdentification1
    }
    ISO20022.Seev001001.MeetingContactPerson3 *-- ISO20022.Seev001001.PartyIdentification129Choice
    ISO20022.Seev001001.MeetingContactPerson3 *-- ISO20022.Seev001001.ContactIdentification1
    class ISO20022.Seev001001.MeetingDateStatus2Code {
        TNTA = 1
        CNFR = 2
    }
    class ISO20022.Seev001001.MeetingEventReference1 {
        + LkgTp  : String
        + EvtId  : ISO20022.Seev001001.MeetingEventReference1Choice
    }
    ISO20022.Seev001001.MeetingEventReference1 *-- ISO20022.Seev001001.MeetingEventReference1Choice
    class ISO20022.Seev001001.MeetingEventReference1Choice {
        + LkdMtgId  : String
        + LkdIssrMtgId  : String
    }
    class ISO20022.Seev001001.MeetingNotice9 {
        + EnrlmntDdln  : ISO20022.Seev001001.DateFormat58Choice
        + EnrlmntMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + RegnSctiesMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + RegnSctiesDdln  : ISO20022.Seev001001.DateFormat58Choice
        + EntitlmntFxgDt  : ISO20022.Seev001001.DateFormat1
        + SctiesBlckgPrdEndDt  : ISO20022.Seev001001.DateFormat60Choice
        + RsltPblctnDt  : ISO20022.Seev001001.DateFormat3Choice
        + CtctPrsnDtls  : global::System.Collections.Generic.List~ISO20022.Seev001001.MeetingContactPerson3~
        + PrxyChc  : ISO20022.Seev001001.Proxy5Choice
        + PrxyAppntmntNtfctnAdr  : ISO20022.Seev001001.PostalAddress1
        + TtlNbOfVtngRghts  : Decimal
        + TtlNbOfSctiesOutsdng  : ISO20022.Seev001001.FinancialInstrumentQuantity18Choice
        + AddtlPrcdrDtls  : global::System.Collections.Generic.List~ISO20022.Seev001001.AdditionalRights4~
        + EvtPrcgWebSiteAdr  : String
        + AddtlDcmnttnURLAdr  : global::System.Collections.Generic.List~String~
        + Attndnc  : ISO20022.Seev001001.Attendance2
        + Prtcptn  : global::System.Collections.Generic.List~ISO20022.Seev001001.ParticipationMethod2~
        + OneManOneVoteInd  : String
        + AnncmntDt  : ISO20022.Seev001001.DateAndDateTime2Choice
        + Clssfctn  : ISO20022.Seev001001.MeetingTypeClassification2Choice
        + Tp  : String
        + IssrMtgId  : String
        + MtgId  : String
    }
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat1
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat60Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateFormat3Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.MeetingContactPerson3
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.Proxy5Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.PostalAddress1
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.FinancialInstrumentQuantity18Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.AdditionalRights4
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.Attendance2
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.ParticipationMethod2
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.DateAndDateTime2Choice
    ISO20022.Seev001001.MeetingNotice9 *-- ISO20022.Seev001001.MeetingTypeClassification2Choice
    class ISO20022.Seev001001.MeetingNotificationV12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev001001.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev001001.CorporateEventNarrative4
        + PwrOfAttnyRqrmnts  : ISO20022.Seev001001.PowerOfAttorneyRequirements4
        + Vote  : ISO20022.Seev001001.VoteParameters9
        + Rsltn  : global::System.Collections.Generic.List~ISO20022.Seev001001.Resolution8~
        + Scty  : global::System.Collections.Generic.List~ISO20022.Seev001001.SecurityPosition20~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev001001.IssuerAgent3~
        + Issr  : ISO20022.Seev001001.IssuerInformation3
        + MtgDtls  : global::System.Collections.Generic.List~ISO20022.Seev001001.Meeting7~
        + Mtg  : ISO20022.Seev001001.MeetingNotice9
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev001001.MeetingEventReference1~
        + NtfctnUpd  : ISO20022.Seev001001.NotificationUpdate2
        + NtfctnGnlInf  : ISO20022.Seev001001.NotificationGeneralInformation4
        + Pgntn  : ISO20022.Seev001001.Pagination1
    }
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.SupplementaryData1
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.CorporateEventNarrative4
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.PowerOfAttorneyRequirements4
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.VoteParameters9
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.Resolution8
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.SecurityPosition20
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.IssuerAgent3
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.IssuerInformation3
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.Meeting7
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.MeetingNotice9
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.MeetingEventReference1
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.NotificationUpdate2
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.NotificationGeneralInformation4
    ISO20022.Seev001001.MeetingNotificationV12 *-- ISO20022.Seev001001.Pagination1
    class ISO20022.Seev001001.MeetingType4Code {
        CMET = 1
        BMET = 2
        SPCL = 3
        MIXD = 4
        GMET = 5
        XMET = 6
    }
    class ISO20022.Seev001001.MeetingTypeClassification2Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev001001.MeetingTypeClassification2Choice *-- ISO20022.Seev001001.GenericIdentification13
    class ISO20022.Seev001001.MeetingTypeClassification2Code {
        VRHI = 1
        OMET = 2
        ISSU = 3
        CLAS = 4
        AMET = 5
    }
    class ISO20022.Seev001001.NameAndAddress5 {
        + Adr  : ISO20022.Seev001001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev001001.NameAndAddress5 *-- ISO20022.Seev001001.PostalAddress1
    class ISO20022.Seev001001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Seev001001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Seev001001.NaturalPersonIdentification1 {
        + IdTp  : ISO20022.Seev001001.IdentificationType45Choice
        + Id  : String
    }
    ISO20022.Seev001001.NaturalPersonIdentification1 *-- ISO20022.Seev001001.IdentificationType45Choice
    class ISO20022.Seev001001.NotificationGeneralInformation4 {
        + ConfOfHldgReqrd  : String
        + ShrhldrRghtsDrctvInd  : String
        + NtfctnSts  : ISO20022.Seev001001.EventStatus1
        + NtfctnTp  : String
        + NtfctnId  : String
    }
    ISO20022.Seev001001.NotificationGeneralInformation4 *-- ISO20022.Seev001001.EventStatus1
    class ISO20022.Seev001001.NotificationType3Code {
        RMDR = 1
        REPL = 2
        NEWM = 3
    }
    class ISO20022.Seev001001.NotificationUpdate2 {
        + RcnfrmInstrs  : String
        + PrvsNtfctnId  : String
    }
    class ISO20022.Seev001001.NumberOrPercentage2Choice {
        + ThrshldNb  : Decimal
        + ThrshldPctg  : Decimal
    }
    class ISO20022.Seev001001.OtherIdentification1 {
        + Tp  : ISO20022.Seev001001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev001001.OtherIdentification1 *-- ISO20022.Seev001001.IdentificationSource3Choice
    class ISO20022.Seev001001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev001001.ParticipationMethod2 {
        + RspnDdlnForVtng  : ISO20022.Seev001001.DateFormat58Choice
        + SpprtdByAcctSvcr  : String
        + IssrDdlnForVtng  : ISO20022.Seev001001.DateFormat58Choice
        + PrtcptnMtd  : ISO20022.Seev001001.ParticipationMethod3Choice
    }
    ISO20022.Seev001001.ParticipationMethod2 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.ParticipationMethod2 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.ParticipationMethod2 *-- ISO20022.Seev001001.ParticipationMethod3Choice
    class ISO20022.Seev001001.ParticipationMethod3Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev001001.ParticipationMethod3Choice *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.PartyIdentification129Choice {
        + LEI  : String
        + NmAndAdr  : ISO20022.Seev001001.NameAndAddress5
        + PrtryId  : ISO20022.Seev001001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev001001.PartyIdentification129Choice *-- ISO20022.Seev001001.NameAndAddress5
    ISO20022.Seev001001.PartyIdentification129Choice *-- ISO20022.Seev001001.GenericIdentification36
    class ISO20022.Seev001001.PartyIdentification198Choice {
        + PrtryId  : ISO20022.Seev001001.GenericIdentification36
        + ClntId  : String
        + AnyBIC  : String
        + LEI  : String
        + NtlRegnNb  : String
    }
    ISO20022.Seev001001.PartyIdentification198Choice *-- ISO20022.Seev001001.GenericIdentification36
    class ISO20022.Seev001001.PartyIdentification221 {
        + Id  : ISO20022.Seev001001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev001001.PersonName2
    }
    ISO20022.Seev001001.PartyIdentification221 *-- ISO20022.Seev001001.PartyIdentification198Choice
    ISO20022.Seev001001.PartyIdentification221 *-- ISO20022.Seev001001.PersonName2
    class ISO20022.Seev001001.PartyIdentification231Choice {
        + NtrlPrsn  : global::System.Collections.Generic.List~ISO20022.Seev001001.PartyIdentification238~
        + LglPrsn  : ISO20022.Seev001001.PartyIdentification221
    }
    ISO20022.Seev001001.PartyIdentification231Choice *-- ISO20022.Seev001001.PartyIdentification238
    ISO20022.Seev001001.PartyIdentification231Choice *-- ISO20022.Seev001001.PartyIdentification221
    class ISO20022.Seev001001.PartyIdentification232Choice {
        + NtrlPrsn  : ISO20022.Seev001001.PartyIdentification238
        + LglPrsn  : ISO20022.Seev001001.PartyIdentification221
    }
    ISO20022.Seev001001.PartyIdentification232Choice *-- ISO20022.Seev001001.PartyIdentification238
    ISO20022.Seev001001.PartyIdentification232Choice *-- ISO20022.Seev001001.PartyIdentification221
    class ISO20022.Seev001001.PartyIdentification238 {
        + DtAndPlcOfBirth  : ISO20022.Seev001001.DateAndPlaceOfBirth2
        + Ntlty  : String
        + Id  : ISO20022.Seev001001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev001001.PersonName3
    }
    ISO20022.Seev001001.PartyIdentification238 *-- ISO20022.Seev001001.DateAndPlaceOfBirth2
    ISO20022.Seev001001.PartyIdentification238 *-- ISO20022.Seev001001.NaturalPersonIdentification1
    ISO20022.Seev001001.PartyIdentification238 *-- ISO20022.Seev001001.PersonName3
    class ISO20022.Seev001001.PartyIdentification246Choice {
        + NtrlPrsn  : global::System.Collections.Generic.List~ISO20022.Seev001001.PartyIdentification250~
        + LglPrsn  : ISO20022.Seev001001.PartyIdentification269
    }
    ISO20022.Seev001001.PartyIdentification246Choice *-- ISO20022.Seev001001.PartyIdentification250
    ISO20022.Seev001001.PartyIdentification246Choice *-- ISO20022.Seev001001.PartyIdentification269
    class ISO20022.Seev001001.PartyIdentification250 {
        + CpnyRegrShrhldrId  : String
        + DtAndPlcOfBirth  : ISO20022.Seev001001.DateAndPlaceOfBirth2
        + Ntlty  : String
        + Id  : ISO20022.Seev001001.NaturalPersonIdentification1
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev001001.PersonName3
    }
    ISO20022.Seev001001.PartyIdentification250 *-- ISO20022.Seev001001.DateAndPlaceOfBirth2
    ISO20022.Seev001001.PartyIdentification250 *-- ISO20022.Seev001001.NaturalPersonIdentification1
    ISO20022.Seev001001.PartyIdentification250 *-- ISO20022.Seev001001.PersonName3
    class ISO20022.Seev001001.PartyIdentification269 {
        + CtryOfIncorprtn  : String
        + CpnyRegrShrhldrId  : String
        + Id  : ISO20022.Seev001001.PartyIdentification198Choice
        + EmailAdr  : String
        + NmAndAdr  : ISO20022.Seev001001.PersonName2
    }
    ISO20022.Seev001001.PartyIdentification269 *-- ISO20022.Seev001001.PartyIdentification198Choice
    ISO20022.Seev001001.PartyIdentification269 *-- ISO20022.Seev001001.PersonName2
    class ISO20022.Seev001001.PersonName2 {
        + Adr  : ISO20022.Seev001001.PostalAddress26
        + Nm  : String
    }
    ISO20022.Seev001001.PersonName2 *-- ISO20022.Seev001001.PostalAddress26
    class ISO20022.Seev001001.PersonName3 {
        + Adr  : ISO20022.Seev001001.PostalAddress26
        + Srnm  : String
        + FrstNm  : String
        + NmPrfx  : String
    }
    ISO20022.Seev001001.PersonName3 *-- ISO20022.Seev001001.PostalAddress26
    class ISO20022.Seev001001.PlaceType1Code {
        UKWN = 1
    }
    class ISO20022.Seev001001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev001001.PostalAddress26 {
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
    class ISO20022.Seev001001.PowerOfAttorneyLegalisation1Code {
        COUN = 1
        APOS = 2
        LOCA = 3
        NOTA = 4
    }
    class ISO20022.Seev001001.PowerOfAttorneyRequirements4 {
        + DocSubmissnDdln  : ISO20022.Seev001001.DateFormat58Choice
        + OthrDcmnttn  : String
        + LglRqrmnt  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Seev001001.PowerOfAttorneyRequirements4 *-- ISO20022.Seev001001.DateFormat58Choice
    class ISO20022.Seev001001.PriceRateOrAmount8Choice {
        + Amt  : ISO20022.Seev001001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev001001.PriceRateOrAmount8Choice *-- ISO20022.Seev001001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Seev001001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev001001.Proxy11 {
        + PrsnDtls  : ISO20022.Seev001001.IndividualPerson43
        + PrxyTp  : String
    }
    ISO20022.Seev001001.Proxy11 *-- ISO20022.Seev001001.IndividualPerson43
    class ISO20022.Seev001001.Proxy5Choice {
        + PrxyNotAllwd  : String
        + Prxy  : ISO20022.Seev001001.ProxyAppointmentInformation6
    }
    ISO20022.Seev001001.Proxy5Choice *-- ISO20022.Seev001001.ProxyAppointmentInformation6
    class ISO20022.Seev001001.ProxyAppointmentInformation6 {
        + AuthrsdPrxy  : global::System.Collections.Generic.List~ISO20022.Seev001001.Proxy11~
        + MktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + Ddln  : ISO20022.Seev001001.DateFormat58Choice
        + RegnMtd  : String
    }
    ISO20022.Seev001001.ProxyAppointmentInformation6 *-- ISO20022.Seev001001.Proxy11
    ISO20022.Seev001001.ProxyAppointmentInformation6 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.ProxyAppointmentInformation6 *-- ISO20022.Seev001001.DateFormat58Choice
    class ISO20022.Seev001001.ProxyNotAllowed1Code {
        NPRO = 1
    }
    class ISO20022.Seev001001.ProxyType3Code {
        HLDR = 1
        NEPR = 2
        DISC = 3
        CHRM = 4
    }
    class ISO20022.Seev001001.QuorumQuantity2Choice {
        + QrmQtyPctg  : Decimal
        + QrmQty  : String
    }
    class ISO20022.Seev001001.Resolution8 {
        + URLAdr  : String
        + VtngRghtsThrshldForApprvl  : global::System.Collections.Generic.List~ISO20022.Seev001001.VotingRightsThreshold2~
        + Entitlmnt  : ISO20022.Seev001001.Entitlement1Choice
        + NtifngPtyRcmmndtn  : String
        + MgmtRcmmndtn  : String
        + VoteInstrTp  : global::System.Collections.Generic.List~ISO20022.Seev001001.VoteInstructionType1~
        + RghtToWdrwInd  : String
        + SubmittdBySctyHldr  : String
        + Sts  : String
        + VoteTp  : String
        + ForInfOnly  : String
        + Tp  : String
        + ListgGrpRsltnLabl  : String
        + Desc  : global::System.Collections.Generic.List~ISO20022.Seev001001.ItemDescription2~
        + IssrLabl  : String
    }
    ISO20022.Seev001001.Resolution8 *-- ISO20022.Seev001001.VotingRightsThreshold2
    ISO20022.Seev001001.Resolution8 *-- ISO20022.Seev001001.Entitlement1Choice
    ISO20022.Seev001001.Resolution8 *-- ISO20022.Seev001001.VoteInstructionType1
    ISO20022.Seev001001.Resolution8 *-- ISO20022.Seev001001.ItemDescription2
    class ISO20022.Seev001001.ResolutionStatus1Code {
        WDRA = 1
        ACTV = 2
    }
    class ISO20022.Seev001001.ResolutionType2Code {
        SPCL = 1
        EXTR = 2
    }
    class ISO20022.Seev001001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev001001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev001001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification78
        + TpAndId  : ISO20022.Seev001001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev001001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev001001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev001001.GenericIdentification78
    ISO20022.Seev001001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev001001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev001001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev001001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev001001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev001001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev001001.SecuritiesEntryType2Code {
        REGO = 1
        INBA = 2
        UNBA = 3
        COLO = 4
        COLI = 5
        TRAD = 6
        SPOS = 7
        LOAN = 8
        BORR = 9
        SETD = 10
        NOMI = 11
        PENR = 12
        PEND = 13
        ELIG = 14
        BLOK = 15
    }
    class ISO20022.Seev001001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev001001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev001001.SecurityIdentification19 *-- ISO20022.Seev001001.OtherIdentification1
    class ISO20022.Seev001001.SecurityPosition20 {
        + Pos  : global::System.Collections.Generic.List~ISO20022.Seev001001.EligiblePosition18~
        + FinInstrmId  : ISO20022.Seev001001.SecurityIdentification19
    }
    ISO20022.Seev001001.SecurityPosition20 *-- ISO20022.Seev001001.EligiblePosition18
    ISO20022.Seev001001.SecurityPosition20 *-- ISO20022.Seev001001.SecurityIdentification19
    class ISO20022.Seev001001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev001001.SignedQuantityFormat14 {
        + Qty  : ISO20022.Seev001001.FinancialInstrumentQuantity45Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev001001.SignedQuantityFormat14 *-- ISO20022.Seev001001.FinancialInstrumentQuantity45Choice
    class ISO20022.Seev001001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev001001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev001001.SupplementaryData1 *-- ISO20022.Seev001001.SupplementaryDataEnvelope1
    class ISO20022.Seev001001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev001001.ThresholdBasis1Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev001001.ThresholdBasis1Choice *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.ThresholdBasis1Code {
        ALVO = 1
        ALSM = 2
        ALSH = 3
    }
    class ISO20022.Seev001001.TypeOfIdentification4Code {
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
    class ISO20022.Seev001001.VoteChannel1Code {
        VOCI = 1
        VOPI = 2
    }
    class ISO20022.Seev001001.VoteInstruction5Code {
        NREC = 1
        BLNK = 2
        TWOY = 3
        THRY = 4
        ONEY = 5
        WTHH = 6
        NOAC = 7
        CFOR = 8
        CHRM = 9
        CAGS = 10
        ABST = 11
    }
    class ISO20022.Seev001001.VoteInstruction6Code {
        WMGT = 1
        WTHH = 2
        TWOY = 3
        THRY = 4
        ONEY = 5
        NOAC = 6
        CFOR = 7
        DISC = 8
        CHRM = 9
        BLNK = 10
        AMGT = 11
        CAGS = 12
        ABST = 13
    }
    class ISO20022.Seev001001.VoteInstructionType1 {
        + AddtlInf  : String
        + VoteInstrTpCd  : ISO20022.Seev001001.VoteInstructionType1Choice
    }
    ISO20022.Seev001001.VoteInstructionType1 *-- ISO20022.Seev001001.VoteInstructionType1Choice
    class ISO20022.Seev001001.VoteInstructionType1Choice {
        + Prtry  : ISO20022.Seev001001.GenericIdentification30
        + Tp  : String
    }
    ISO20022.Seev001001.VoteInstructionType1Choice *-- ISO20022.Seev001001.GenericIdentification30
    class ISO20022.Seev001001.VoteMethods5 {
        + VoteByTel  : global::System.Collections.Generic.List~String~
        + ElctrncVote  : global::System.Collections.Generic.List~ISO20022.Seev001001.CommunicationAddress12~
        + VoteByMail  : ISO20022.Seev001001.MailAddress1
        + VoteThrghNtwk  : ISO20022.Seev001001.VoteThroughNetwork1Choice
    }
    ISO20022.Seev001001.VoteMethods5 *-- ISO20022.Seev001001.CommunicationAddress12
    ISO20022.Seev001001.VoteMethods5 *-- ISO20022.Seev001001.MailAddress1
    ISO20022.Seev001001.VoteMethods5 *-- ISO20022.Seev001001.VoteThroughNetwork1Choice
    class ISO20022.Seev001001.VoteParameters9 {
        + PrvsInstrInvldtyInd  : String
        + AddtlVtngRqrmnts  : String
        + VoteWthPrmMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + VoteWthPrmDdln  : ISO20022.Seev001001.DateFormat58Choice
        + EarlyVoteWthPrmDdln  : ISO20022.Seev001001.DateFormat58Choice
        + IncntivPrm  : ISO20022.Seev001001.IncentivePremium6
        + EarlyIncntivPrm  : ISO20022.Seev001001.IncentivePremium6
        + BnfclOwnrDsclsr  : String
        + RvcbltyMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + RvcbltyDdln  : ISO20022.Seev001001.DateFormat58Choice
        + VtngBlltReqAdr  : ISO20022.Seev001001.PostalAddress1
        + VtngBlltElctrncAdr  : ISO20022.Seev001001.CommunicationAddress11
        + VoteMthds  : ISO20022.Seev001001.VoteMethods5
        + VoteMktDdln  : ISO20022.Seev001001.DateFormat58Choice
        + VoteDdln  : ISO20022.Seev001001.DateFormat58Choice
        + SpltVoteAllwd  : String
        + PrtlVoteAllwd  : String
        + SctiesQtyReqrdToVote  : ISO20022.Seev001001.FinancialInstrumentQuantity18Choice
    }
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.IncentivePremium6
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.IncentivePremium6
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.PostalAddress1
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.CommunicationAddress11
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.VoteMethods5
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.DateFormat58Choice
    ISO20022.Seev001001.VoteParameters9 *-- ISO20022.Seev001001.FinancialInstrumentQuantity18Choice
    class ISO20022.Seev001001.VoteThroughNetwork1Choice {
        + VoteDrctlyToIssr  : global::System.Collections.Generic.List~String~
        + VoteChanl  : String
    }
    class ISO20022.Seev001001.VoteType1Code {
        BNDG = 1
        ADVI = 2
    }
    class ISO20022.Seev001001.VoteTypeAndQuantity1 {
        + VoteQty  : Decimal
        + VoteInstrTp  : ISO20022.Seev001001.VoteInstructionType1Choice
    }
    ISO20022.Seev001001.VoteTypeAndQuantity1 *-- ISO20022.Seev001001.VoteInstructionType1Choice
    class ISO20022.Seev001001.VotingParticipationMethod3Code {
        VIRT = 1
        PRXY = 2
        PHNV = 3
        PHYS = 4
        EVOT = 5
        MAIL = 6
    }
    class ISO20022.Seev001001.VotingRightsThreshold2 {
        + ThrshldBsis  : ISO20022.Seev001001.ThresholdBasis1Choice
        + Thrshld  : ISO20022.Seev001001.NumberOrPercentage2Choice
    }
    ISO20022.Seev001001.VotingRightsThreshold2 *-- ISO20022.Seev001001.ThresholdBasis1Choice
    ISO20022.Seev001001.VotingRightsThreshold2 *-- ISO20022.Seev001001.NumberOrPercentage2Choice
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

## Value ISO20022.Seev001001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev001001.AdditionalRight1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AIPS|Int32||XmlEnum("""AIPS""")|1|
||RSPS|Int32||XmlEnum("""RSPS""")|2|
||WQPS|Int32||XmlEnum("""WQPS""")|3|

---

## Value ISO20022.Seev001001.AdditionalRightCode1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev001001.AdditionalRightThreshold2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRghtThrshldPctg|Decimal||XmlElement()||
|+|AddtlRghtThrshld|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AddtlRghtThrshldPctg,AddtlRghtThrshld))|

---

## Value ISO20022.Seev001001.AdditionalRights4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRghtThrshld|ISO20022.Seev001001.AdditionalRightThreshold2Choice||XmlElement()||
|+|AddtlRghtMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|AddtlRghtDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|AddtlRghtInfURLAdr|String||XmlElement()||
|+|AddtlRght|ISO20022.Seev001001.AdditionalRightCode1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlRghtThrshld),validElement(AddtlRghtMktDdln),validElement(AddtlRghtDdln),validElement(AddtlRght))|

---

## Enum ISO20022.Seev001001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Seev001001.AgentRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBA|Int32||XmlEnum("""SUBA""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Seev001001.Attendance2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConfMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|ConfDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|ConfInf|String||XmlElement()||
|+|AdmssnConds|global::System.Collections.Generic.List<ISO20022.Seev001001.AttendanceAdmissionConditions2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ConfMktDdln),validElement(ConfDdln),validList("""AdmssnConds""",AdmssnConds),validListMax("""AdmssnConds""",AdmssnConds,7),validElement(AdmssnConds))|

---

## Value ISO20022.Seev001001.AttendanceAdmissionConditions2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev001001.AttendanceAdmissionConditions2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MANP|Int32||XmlEnum("""MANP""")|1|
||MADS|Int32||XmlEnum("""MADS""")|2|
||MATK|Int32||XmlEnum("""MATK""")|3|
||MAHI|Int32||XmlEnum("""MAHI""")|4|
||MALR|Int32||XmlEnum("""MALR""")|5|
||MAAL|Int32||XmlEnum("""MAAL""")|6|
||MAPO|Int32||XmlEnum("""MAPO""")|7|
||MASL|Int32||XmlEnum("""MASL""")|8|
||MASH|Int32||XmlEnum("""MASH""")|9|

---

## Value ISO20022.Seev001001.CommunicationAddress11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.CommunicationAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.ContactIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Seev001001.CorporateEventNarrative4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgTxtForNxtIntrmy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Dsclmr|global::System.Collections.Generic.List<ISO20022.Seev001001.LanguageSpecifiedNarrative1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dsclmr""",Dsclmr),validElement(Dsclmr))|

---

## Value ISO20022.Seev001001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev001001.DateAndPlaceOfBirth2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Seev001001.DateCode34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev001001.DateFormat1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtMd|String||XmlElement()||
|+|Dt|ISO20022.Seev001001.DateFormat3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt))|

---

## Value ISO20022.Seev001001.DateFormat3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev001001.DateFormat58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|String||XmlElement()||
|+|DtOrDtTm|ISO20022.Seev001001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtOrDtTm),validChoice(DtCd,DtOrDtTm))|

---

## Value ISO20022.Seev001001.DateFormat60Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev001001.DateCode34Choice||XmlElement()||
|+|Dt|ISO20022.Seev001001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev001001.DateMode1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EODY|Int32||XmlEnum("""EODY""")|1|
||BODY|Int32||XmlEnum("""BODY""")|2|

---

## Enum ISO20022.Seev001001.DateType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PPYD|Int32||XmlEnum("""PPYD""")|1|
||RDTE|Int32||XmlEnum("""RDTE""")|2|
||NARR|Int32||XmlEnum("""NARR""")|3|
||UKWN|Int32||XmlEnum("""UKWN""")|4|
||MEET|Int32||XmlEnum("""MEET""")|5|

---

## Enum ISO20022.Seev001001.DateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Type ISO20022.Seev001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtgNtfctn|ISO20022.Seev001001.MeetingNotificationV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtgNtfctn))|

---

## Value ISO20022.Seev001001.EligiblePosition18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RghtsHldr|global::System.Collections.Generic.List<ISO20022.Seev001001.PartyIdentification246Choice>||XmlElement()||
|+|HldgBal|global::System.Collections.Generic.List<ISO20022.Seev001001.HoldingBalance14>||XmlElement()||
|+|AcctOwnr|ISO20022.Seev001001.PartyIdentification231Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RghtsHldr""",RghtsHldr),validListMax("""RghtsHldr""",RghtsHldr,250),validElement(RghtsHldr),validList("""HldgBal""",HldgBal),validListMax("""HldgBal""",HldgBal,15),validElement(HldgBal),validElement(AcctOwnr))|

---

## Value ISO20022.Seev001001.Entitlement1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EntitlmntDesc|String||XmlElement()||
|+|EntitlmntRatio|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(EntitlmntDesc,EntitlmntRatio))|

---

## Enum ISO20022.Seev001001.EventCompletenessStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCO|Int32||XmlEnum("""INCO""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Enum ISO20022.Seev001001.EventConfirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCON|Int32||XmlEnum("""UCON""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Value ISO20022.Seev001001.EventStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtConfSts|String||XmlElement()||
|+|EvtCmpltnsSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.FinancialInstrumentQuantity18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Seev001001.FinancialInstrumentQuantity45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,FaceAmt,Unit))|

---

## Value ISO20022.Seev001001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev001001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev001001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev001001.HoldingBalance14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev001001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|BalTp|String||XmlElement()||
|+|Bal|ISO20022.Seev001001.SignedQuantityFormat14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(Bal))|

---

## Value ISO20022.Seev001001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev001001.IdentificationType45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev001001.IncentivePremium6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtDt|ISO20022.Seev001001.DateFormat3Choice||XmlElement()||
|+|Tp|ISO20022.Seev001001.IncentivePremiumType2Choice||XmlElement()||
|+|Amt|ISO20022.Seev001001.PriceRateOrAmount8Choice||XmlElement()||
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtDt),validElement(Tp),validElement(Amt))|

---

## Value ISO20022.Seev001001.IncentivePremiumType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PerAttndee|String||XmlElement()||
|+|PerVote|global::System.Collections.Generic.List<ISO20022.Seev001001.VoteTypeAndQuantity1>||XmlElement()||
|+|PerScty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PerVote""",PerVote),validList("""PerVote""",PerVote),validElement(PerVote),validChoice(PerAttndee,PerVote,PerScty))|

---

## Value ISO20022.Seev001001.IndividualPerson43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmplngPty|ISO20022.Seev001001.PartyIdentification129Choice||XmlElement()||
|+|PrssgndPrxy|ISO20022.Seev001001.PartyIdentification232Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EmplngPty),validElement(PrssgndPrxy))|

---

## Value ISO20022.Seev001001.IssuerAgent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Role|String||XmlElement()||
|+|Id|ISO20022.Seev001001.PartyIdentification129Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Seev001001.IssuerInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|Id|ISO20022.Seev001001.PartyIdentification129Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Seev001001.ItemDescription2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Titl|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev001001.LanguageSpecifiedNarrative1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Lang|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lang""",Lang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Seev001001.LocationFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LctnCd|String||XmlElement()||
|+|Adr|ISO20022.Seev001001.PostalAddress1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr),validChoice(LctnCd,Adr))|

---

## Value ISO20022.Seev001001.MailAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Crspdc|global::System.Collections.Generic.List<ISO20022.Seev001001.PostalAddress1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""EmailAdr""",EmailAdr,5),validList("""Crspdc""",Crspdc),validListMax("""Crspdc""",Crspdc,5),validElement(Crspdc))|

---

## Value ISO20022.Seev001001.Meeting7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|QrmQty|ISO20022.Seev001001.QuorumQuantity2Choice||XmlElement()||
|+|Lctn|global::System.Collections.Generic.List<ISO20022.Seev001001.LocationFormat1Choice>||XmlElement()||
|+|QrmReqrd|String||XmlElement()||
|+|DtSts|String||XmlElement()||
|+|DtAndTm|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QrmQty),validRequired("""Lctn""",Lctn),validList("""Lctn""",Lctn),validListMax("""Lctn""",Lctn,5),validElement(Lctn),validElement(DtAndTm))|

---

## Value ISO20022.Seev001001.MeetingContactPerson3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcOfListg|String||XmlElement()||
|+|EmplngPty|ISO20022.Seev001001.PartyIdentification129Choice||XmlElement()||
|+|CtctPrsn|ISO20022.Seev001001.ContactIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(EmplngPty),validElement(CtctPrsn))|

---

## Enum ISO20022.Seev001001.MeetingDateStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TNTA|Int32||XmlEnum("""TNTA""")|1|
||CNFR|Int32||XmlEnum("""CNFR""")|2|

---

## Value ISO20022.Seev001001.MeetingEventReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|String||XmlElement()||
|+|EvtId|ISO20022.Seev001001.MeetingEventReference1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtId))|

---

## Value ISO20022.Seev001001.MeetingEventReference1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdMtgId|String||XmlElement()||
|+|LkdIssrMtgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LkdMtgId,LkdIssrMtgId))|

---

## Value ISO20022.Seev001001.MeetingNotice9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EnrlmntDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|EnrlmntMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|RegnSctiesMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|RegnSctiesDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|EntitlmntFxgDt|ISO20022.Seev001001.DateFormat1||XmlElement()||
|+|SctiesBlckgPrdEndDt|ISO20022.Seev001001.DateFormat60Choice||XmlElement()||
|+|RsltPblctnDt|ISO20022.Seev001001.DateFormat3Choice||XmlElement()||
|+|CtctPrsnDtls|global::System.Collections.Generic.List<ISO20022.Seev001001.MeetingContactPerson3>||XmlElement()||
|+|PrxyChc|ISO20022.Seev001001.Proxy5Choice||XmlElement()||
|+|PrxyAppntmntNtfctnAdr|ISO20022.Seev001001.PostalAddress1||XmlElement()||
|+|TtlNbOfVtngRghts|Decimal||XmlElement()||
|+|TtlNbOfSctiesOutsdng|ISO20022.Seev001001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|AddtlPrcdrDtls|global::System.Collections.Generic.List<ISO20022.Seev001001.AdditionalRights4>||XmlElement()||
|+|EvtPrcgWebSiteAdr|String||XmlElement()||
|+|AddtlDcmnttnURLAdr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Attndnc|ISO20022.Seev001001.Attendance2||XmlElement()||
|+|Prtcptn|global::System.Collections.Generic.List<ISO20022.Seev001001.ParticipationMethod2>||XmlElement()||
|+|OneManOneVoteInd|String||XmlElement()||
|+|AnncmntDt|ISO20022.Seev001001.DateAndDateTime2Choice||XmlElement()||
|+|Clssfctn|ISO20022.Seev001001.MeetingTypeClassification2Choice||XmlElement()||
|+|Tp|String||XmlElement()||
|+|IssrMtgId|String||XmlElement()||
|+|MtgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EnrlmntDdln),validElement(EnrlmntMktDdln),validElement(RegnSctiesMktDdln),validElement(RegnSctiesDdln),validElement(EntitlmntFxgDt),validElement(SctiesBlckgPrdEndDt),validElement(RsltPblctnDt),validList("""CtctPrsnDtls""",CtctPrsnDtls),validListMax("""CtctPrsnDtls""",CtctPrsnDtls,12),validElement(CtctPrsnDtls),validElement(PrxyChc),validElement(PrxyAppntmntNtfctnAdr),validElement(TtlNbOfSctiesOutsdng),validList("""AddtlPrcdrDtls""",AddtlPrcdrDtls),validListMax("""AddtlPrcdrDtls""",AddtlPrcdrDtls,5),validElement(AddtlPrcdrDtls),validElement(Attndnc),validList("""Prtcptn""",Prtcptn),validElement(Prtcptn),validElement(AnncmntDt),validElement(Clssfctn))|

---

## Aspect ISO20022.Seev001001.MeetingNotificationV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev001001.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev001001.CorporateEventNarrative4||XmlElement()||
|+|PwrOfAttnyRqrmnts|ISO20022.Seev001001.PowerOfAttorneyRequirements4||XmlElement()||
|+|Vote|ISO20022.Seev001001.VoteParameters9||XmlElement()||
|+|Rsltn|global::System.Collections.Generic.List<ISO20022.Seev001001.Resolution8>||XmlElement()||
|+|Scty|global::System.Collections.Generic.List<ISO20022.Seev001001.SecurityPosition20>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev001001.IssuerAgent3>||XmlElement()||
|+|Issr|ISO20022.Seev001001.IssuerInformation3||XmlElement()||
|+|MtgDtls|global::System.Collections.Generic.List<ISO20022.Seev001001.Meeting7>||XmlElement()||
|+|Mtg|ISO20022.Seev001001.MeetingNotice9||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev001001.MeetingEventReference1>||XmlElement()||
|+|NtfctnUpd|ISO20022.Seev001001.NotificationUpdate2||XmlElement()||
|+|NtfctnGnlInf|ISO20022.Seev001001.NotificationGeneralInformation4||XmlElement()||
|+|Pgntn|ISO20022.Seev001001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PwrOfAttnyRqrmnts),validElement(Vote),validList("""Rsltn""",Rsltn),validListMax("""Rsltn""",Rsltn,1000),validElement(Rsltn),validRequired("""Scty""",Scty),validList("""Scty""",Scty),validListMax("""Scty""",Scty,200),validElement(Scty),validList("""IssrAgt""",IssrAgt),validListMax("""IssrAgt""",IssrAgt,10),validElement(IssrAgt),validElement(Issr),validRequired("""MtgDtls""",MtgDtls),validList("""MtgDtls""",MtgDtls),validListMax("""MtgDtls""",MtgDtls,5),validElement(MtgDtls),validElement(Mtg),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validElement(NtfctnUpd),validElement(NtfctnGnlInf),validElement(Pgntn))|

---

## Enum ISO20022.Seev001001.MeetingType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CMET|Int32||XmlEnum("""CMET""")|1|
||BMET|Int32||XmlEnum("""BMET""")|2|
||SPCL|Int32||XmlEnum("""SPCL""")|3|
||MIXD|Int32||XmlEnum("""MIXD""")|4|
||GMET|Int32||XmlEnum("""GMET""")|5|
||XMET|Int32||XmlEnum("""XMET""")|6|

---

## Value ISO20022.Seev001001.MeetingTypeClassification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev001001.MeetingTypeClassification2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VRHI|Int32||XmlEnum("""VRHI""")|1|
||OMET|Int32||XmlEnum("""OMET""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||CLAS|Int32||XmlEnum("""CLAS""")|4|
||AMET|Int32||XmlEnum("""AMET""")|5|

---

## Value ISO20022.Seev001001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev001001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Enum ISO20022.Seev001001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Seev001001.NaturalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdTp|ISO20022.Seev001001.IdentificationType45Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdTp))|

---

## Value ISO20022.Seev001001.NotificationGeneralInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConfOfHldgReqrd|String||XmlElement()||
|+|ShrhldrRghtsDrctvInd|String||XmlElement()||
|+|NtfctnSts|ISO20022.Seev001001.EventStatus1||XmlElement()||
|+|NtfctnTp|String||XmlElement()||
|+|NtfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnSts))|

---

## Enum ISO20022.Seev001001.NotificationType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RMDR|Int32||XmlEnum("""RMDR""")|1|
||REPL|Int32||XmlEnum("""REPL""")|2|
||NEWM|Int32||XmlEnum("""NEWM""")|3|

---

## Value ISO20022.Seev001001.NotificationUpdate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcnfrmInstrs|String||XmlElement()||
|+|PrvsNtfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.NumberOrPercentage2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrshldNb|Decimal||XmlElement()||
|+|ThrshldPctg|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ThrshldNb,ThrshldPctg))|

---

## Value ISO20022.Seev001001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev001001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev001001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev001001.ParticipationMethod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnDdlnForVtng|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|SpprtdByAcctSvcr|String||XmlElement()||
|+|IssrDdlnForVtng|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|PrtcptnMtd|ISO20022.Seev001001.ParticipationMethod3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnDdlnForVtng),validElement(IssrDdlnForVtng),validElement(PrtcptnMtd))|

---

## Value ISO20022.Seev001001.ParticipationMethod3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev001001.PartyIdentification129Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev001001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev001001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(LEI,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev001001.PartyIdentification198Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev001001.GenericIdentification36||XmlElement()||
|+|ClntId|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(PrtryId,ClntId,AnyBIC,LEI,NtlRegnNb))|

---

## Value ISO20022.Seev001001.PartyIdentification221


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Seev001001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev001001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev001001.PartyIdentification231Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|global::System.Collections.Generic.List<ISO20022.Seev001001.PartyIdentification238>||XmlElement()||
|+|LglPrsn|ISO20022.Seev001001.PartyIdentification221||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NtrlPrsn""",NtrlPrsn),validList("""NtrlPrsn""",NtrlPrsn),validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev001001.PartyIdentification232Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|ISO20022.Seev001001.PartyIdentification238||XmlElement()||
|+|LglPrsn|ISO20022.Seev001001.PartyIdentification221||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev001001.PartyIdentification238


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtAndPlcOfBirth|ISO20022.Seev001001.DateAndPlaceOfBirth2||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Id|ISO20022.Seev001001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev001001.PersonName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtAndPlcOfBirth),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev001001.PartyIdentification246Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtrlPrsn|global::System.Collections.Generic.List<ISO20022.Seev001001.PartyIdentification250>||XmlElement()||
|+|LglPrsn|ISO20022.Seev001001.PartyIdentification269||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NtrlPrsn""",NtrlPrsn),validList("""NtrlPrsn""",NtrlPrsn),validElement(NtrlPrsn),validElement(LglPrsn),validChoice(NtrlPrsn,LglPrsn))|

---

## Value ISO20022.Seev001001.PartyIdentification250


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CpnyRegrShrhldrId|String||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Seev001001.DateAndPlaceOfBirth2||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|Id|ISO20022.Seev001001.NaturalPersonIdentification1||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev001001.PersonName3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtAndPlcOfBirth),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev001001.PartyIdentification269


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfIncorprtn|String||XmlElement()||
|+|CpnyRegrShrhldrId|String||XmlElement()||
|+|Id|ISO20022.Seev001001.PartyIdentification198Choice||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|NmAndAdr|ISO20022.Seev001001.PersonName2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfIncorprtn""",CtryOfIncorprtn,"""[A-Z]{2,2}"""),validElement(Id),validElement(NmAndAdr))|

---

## Value ISO20022.Seev001001.PersonName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev001001.PostalAddress26||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev001001.PersonName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev001001.PostalAddress26||XmlElement()||
|+|Srnm|String||XmlElement()||
|+|FrstNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev001001.PlaceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev001001.PostalAddress1


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

## Value ISO20022.Seev001001.PostalAddress26


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

## Enum ISO20022.Seev001001.PowerOfAttorneyLegalisation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COUN|Int32||XmlEnum("""COUN""")|1|
||APOS|Int32||XmlEnum("""APOS""")|2|
||LOCA|Int32||XmlEnum("""LOCA""")|3|
||NOTA|Int32||XmlEnum("""NOTA""")|4|

---

## Value ISO20022.Seev001001.PowerOfAttorneyRequirements4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DocSubmissnDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|OthrDcmnttn|String||XmlElement()||
|+|LglRqrmnt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DocSubmissnDdln),validListMax("""LglRqrmnt""",LglRqrmnt,4))|

---

## Value ISO20022.Seev001001.PriceRateOrAmount8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev001001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Seev001001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev001001.Proxy11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrsnDtls|ISO20022.Seev001001.IndividualPerson43||XmlElement()||
|+|PrxyTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrsnDtls))|

---

## Value ISO20022.Seev001001.Proxy5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrxyNotAllwd|String||XmlElement()||
|+|Prxy|ISO20022.Seev001001.ProxyAppointmentInformation6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validChoice(PrxyNotAllwd,Prxy))|

---

## Value ISO20022.Seev001001.ProxyAppointmentInformation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthrsdPrxy|global::System.Collections.Generic.List<ISO20022.Seev001001.Proxy11>||XmlElement()||
|+|MktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|Ddln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|RegnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AuthrsdPrxy""",AuthrsdPrxy),validListMax("""AuthrsdPrxy""",AuthrsdPrxy,10),validElement(AuthrsdPrxy),validElement(MktDdln),validElement(Ddln))|

---

## Enum ISO20022.Seev001001.ProxyNotAllowed1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRO|Int32||XmlEnum("""NPRO""")|1|

---

## Enum ISO20022.Seev001001.ProxyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HLDR|Int32||XmlEnum("""HLDR""")|1|
||NEPR|Int32||XmlEnum("""NEPR""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||CHRM|Int32||XmlEnum("""CHRM""")|4|

---

## Value ISO20022.Seev001001.QuorumQuantity2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QrmQtyPctg|Decimal||XmlElement()||
|+|QrmQty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(QrmQtyPctg,QrmQty))|

---

## Value ISO20022.Seev001001.Resolution8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|VtngRghtsThrshldForApprvl|global::System.Collections.Generic.List<ISO20022.Seev001001.VotingRightsThreshold2>||XmlElement()||
|+|Entitlmnt|ISO20022.Seev001001.Entitlement1Choice||XmlElement()||
|+|NtifngPtyRcmmndtn|String||XmlElement()||
|+|MgmtRcmmndtn|String||XmlElement()||
|+|VoteInstrTp|global::System.Collections.Generic.List<ISO20022.Seev001001.VoteInstructionType1>||XmlElement()||
|+|RghtToWdrwInd|String||XmlElement()||
|+|SubmittdBySctyHldr|String||XmlElement()||
|+|Sts|String||XmlElement()||
|+|VoteTp|String||XmlElement()||
|+|ForInfOnly|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|ListgGrpRsltnLabl|String||XmlElement()||
|+|Desc|global::System.Collections.Generic.List<ISO20022.Seev001001.ItemDescription2>||XmlElement()||
|+|IssrLabl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""VtngRghtsThrshldForApprvl""",VtngRghtsThrshldForApprvl),validElement(VtngRghtsThrshldForApprvl),validElement(Entitlmnt),validList("""VoteInstrTp""",VoteInstrTp),validElement(VoteInstrTp),validList("""Desc""",Desc),validElement(Desc))|

---

## Enum ISO20022.Seev001001.ResolutionStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WDRA|Int32||XmlEnum("""WDRA""")|1|
||ACTV|Int32||XmlEnum("""ACTV""")|2|

---

## Enum ISO20022.Seev001001.ResolutionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPCL|Int32||XmlEnum("""SPCL""")|1|
||EXTR|Int32||XmlEnum("""EXTR""")|2|

---

## Enum ISO20022.Seev001001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev001001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev001001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev001001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev001001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev001001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev001001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev001001.SecuritiesEntryType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGO|Int32||XmlEnum("""REGO""")|1|
||INBA|Int32||XmlEnum("""INBA""")|2|
||UNBA|Int32||XmlEnum("""UNBA""")|3|
||COLO|Int32||XmlEnum("""COLO""")|4|
||COLI|Int32||XmlEnum("""COLI""")|5|
||TRAD|Int32||XmlEnum("""TRAD""")|6|
||SPOS|Int32||XmlEnum("""SPOS""")|7|
||LOAN|Int32||XmlEnum("""LOAN""")|8|
||BORR|Int32||XmlEnum("""BORR""")|9|
||SETD|Int32||XmlEnum("""SETD""")|10|
||NOMI|Int32||XmlEnum("""NOMI""")|11|
||PENR|Int32||XmlEnum("""PENR""")|12|
||PEND|Int32||XmlEnum("""PEND""")|13|
||ELIG|Int32||XmlEnum("""ELIG""")|14|
||BLOK|Int32||XmlEnum("""BLOK""")|15|

---

## Value ISO20022.Seev001001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev001001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev001001.SecurityPosition20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pos|global::System.Collections.Generic.List<ISO20022.Seev001001.EligiblePosition18>||XmlElement()||
|+|FinInstrmId|ISO20022.Seev001001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Pos""",Pos),validListMax("""Pos""",Pos,1000),validElement(Pos),validElement(FinInstrmId))|

---

## Enum ISO20022.Seev001001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev001001.SignedQuantityFormat14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev001001.FinancialInstrumentQuantity45Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev001001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev001001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev001001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev001001.ThresholdBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev001001.ThresholdBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALVO|Int32||XmlEnum("""ALVO""")|1|
||ALSM|Int32||XmlEnum("""ALSM""")|2|
||ALSH|Int32||XmlEnum("""ALSH""")|3|

---

## Enum ISO20022.Seev001001.TypeOfIdentification4Code


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

## Enum ISO20022.Seev001001.VoteChannel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOCI|Int32||XmlEnum("""VOCI""")|1|
||VOPI|Int32||XmlEnum("""VOPI""")|2|

---

## Enum ISO20022.Seev001001.VoteInstruction5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NREC|Int32||XmlEnum("""NREC""")|1|
||BLNK|Int32||XmlEnum("""BLNK""")|2|
||TWOY|Int32||XmlEnum("""TWOY""")|3|
||THRY|Int32||XmlEnum("""THRY""")|4|
||ONEY|Int32||XmlEnum("""ONEY""")|5|
||WTHH|Int32||XmlEnum("""WTHH""")|6|
||NOAC|Int32||XmlEnum("""NOAC""")|7|
||CFOR|Int32||XmlEnum("""CFOR""")|8|
||CHRM|Int32||XmlEnum("""CHRM""")|9|
||CAGS|Int32||XmlEnum("""CAGS""")|10|
||ABST|Int32||XmlEnum("""ABST""")|11|

---

## Enum ISO20022.Seev001001.VoteInstruction6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WMGT|Int32||XmlEnum("""WMGT""")|1|
||WTHH|Int32||XmlEnum("""WTHH""")|2|
||TWOY|Int32||XmlEnum("""TWOY""")|3|
||THRY|Int32||XmlEnum("""THRY""")|4|
||ONEY|Int32||XmlEnum("""ONEY""")|5|
||NOAC|Int32||XmlEnum("""NOAC""")|6|
||CFOR|Int32||XmlEnum("""CFOR""")|7|
||DISC|Int32||XmlEnum("""DISC""")|8|
||CHRM|Int32||XmlEnum("""CHRM""")|9|
||BLNK|Int32||XmlEnum("""BLNK""")|10|
||AMGT|Int32||XmlEnum("""AMGT""")|11|
||CAGS|Int32||XmlEnum("""CAGS""")|12|
||ABST|Int32||XmlEnum("""ABST""")|13|

---

## Value ISO20022.Seev001001.VoteInstructionType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|VoteInstrTpCd|ISO20022.Seev001001.VoteInstructionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VoteInstrTpCd))|

---

## Value ISO20022.Seev001001.VoteInstructionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev001001.GenericIdentification30||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Tp))|

---

## Value ISO20022.Seev001001.VoteMethods5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VoteByTel|global::System.Collections.Generic.List<String>||XmlElement()||
|+|ElctrncVote|global::System.Collections.Generic.List<ISO20022.Seev001001.CommunicationAddress12>||XmlElement()||
|+|VoteByMail|ISO20022.Seev001001.MailAddress1||XmlElement()||
|+|VoteThrghNtwk|ISO20022.Seev001001.VoteThroughNetwork1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""VoteByTel""",VoteByTel,5),validList("""ElctrncVote""",ElctrncVote),validListMax("""ElctrncVote""",ElctrncVote,5),validElement(ElctrncVote),validElement(VoteByMail),validElement(VoteThrghNtwk))|

---

## Value ISO20022.Seev001001.VoteParameters9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvsInstrInvldtyInd|String||XmlElement()||
|+|AddtlVtngRqrmnts|String||XmlElement()||
|+|VoteWthPrmMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|VoteWthPrmDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|EarlyVoteWthPrmDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|IncntivPrm|ISO20022.Seev001001.IncentivePremium6||XmlElement()||
|+|EarlyIncntivPrm|ISO20022.Seev001001.IncentivePremium6||XmlElement()||
|+|BnfclOwnrDsclsr|String||XmlElement()||
|+|RvcbltyMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|RvcbltyDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|VtngBlltReqAdr|ISO20022.Seev001001.PostalAddress1||XmlElement()||
|+|VtngBlltElctrncAdr|ISO20022.Seev001001.CommunicationAddress11||XmlElement()||
|+|VoteMthds|ISO20022.Seev001001.VoteMethods5||XmlElement()||
|+|VoteMktDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|VoteDdln|ISO20022.Seev001001.DateFormat58Choice||XmlElement()||
|+|SpltVoteAllwd|String||XmlElement()||
|+|PrtlVoteAllwd|String||XmlElement()||
|+|SctiesQtyReqrdToVote|ISO20022.Seev001001.FinancialInstrumentQuantity18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VoteWthPrmMktDdln),validElement(VoteWthPrmDdln),validElement(EarlyVoteWthPrmDdln),validElement(IncntivPrm),validElement(EarlyIncntivPrm),validElement(RvcbltyMktDdln),validElement(RvcbltyDdln),validElement(VtngBlltReqAdr),validElement(VtngBlltElctrncAdr),validElement(VoteMthds),validElement(VoteMktDdln),validElement(VoteDdln),validElement(SctiesQtyReqrdToVote))|

---

## Value ISO20022.Seev001001.VoteThroughNetwork1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VoteDrctlyToIssr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|VoteChanl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""VoteDrctlyToIssr""",VoteDrctlyToIssr),validPattern("""VoteDrctlyToIssr""",VoteDrctlyToIssr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validListMax("""VoteDrctlyToIssr""",VoteDrctlyToIssr,5),validChoice(VoteDrctlyToIssr,VoteChanl))|

---

## Enum ISO20022.Seev001001.VoteType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BNDG|Int32||XmlEnum("""BNDG""")|1|
||ADVI|Int32||XmlEnum("""ADVI""")|2|

---

## Value ISO20022.Seev001001.VoteTypeAndQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VoteQty|Decimal||XmlElement()||
|+|VoteInstrTp|ISO20022.Seev001001.VoteInstructionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VoteInstrTp))|

---

## Enum ISO20022.Seev001001.VotingParticipationMethod3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIRT|Int32||XmlEnum("""VIRT""")|1|
||PRXY|Int32||XmlEnum("""PRXY""")|2|
||PHNV|Int32||XmlEnum("""PHNV""")|3|
||PHYS|Int32||XmlEnum("""PHYS""")|4|
||EVOT|Int32||XmlEnum("""EVOT""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Seev001001.VotingRightsThreshold2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrshldBsis|ISO20022.Seev001001.ThresholdBasis1Choice||XmlElement()||
|+|Thrshld|ISO20022.Seev001001.NumberOrPercentage2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ThrshldBsis),validElement(Thrshld))|

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

