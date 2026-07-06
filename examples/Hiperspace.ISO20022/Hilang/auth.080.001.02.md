# auth.080.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth080001.ActiveOrHistoricCurrencyAnd20DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth080001.AgreementType1Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth080001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityDairy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityForestry1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityGrain2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityLiveStock1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityOilSeed1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityOliveOil2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommodityPotato1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommoditySeafood1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AgriculturalCommoditySoft1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AmountAndDirection107 {
        + Sgn  : String
        + Amt  : ISO20022.Auth080001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth080001.AmountAndDirection107 *-- ISO20022.Auth080001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth080001.AmountAndDirection53 {
        + Sgn  : String
        + Amt  : ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth080001.AmountAndDirection53 *-- ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth080001.AssetClassCommodity5Choice {
        + Othr  : ISO20022.Auth080001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth080001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth080001.AssetClassCommodityMultiCommodityExotic1
        + Infltn  : ISO20022.Auth080001.AssetClassCommodityInflation1
        + Plprpln  : ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice
        + Ppr  : ISO20022.Auth080001.AssetClassCommodityPaper3Choice
        + OthrC10  : ISO20022.Auth080001.AssetClassCommodityOtherC102Choice
        + Metl  : ISO20022.Auth080001.AssetClassCommodityMetal1Choice
        + IndstrlPdct  : ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice
        + Frght  : ISO20022.Auth080001.AssetClassCommodityFreight3Choice
        + Frtlzr  : ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice
        + Envttl  : ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice
        + Nrgy  : ISO20022.Auth080001.AssetClassCommodityEnergy2Choice
        + Agrcltrl  : ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice
    }
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityOther1
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityInflation1
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityPaper3Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityOtherC102Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityMetal1Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityFreight3Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityEnergy2Choice
    ISO20022.Auth080001.AssetClassCommodity5Choice *-- ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice
    class ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice {
        + Othr  : ISO20022.Auth080001.AgriculturalCommodityOther1
        + Grn  : ISO20022.Auth080001.AgriculturalCommodityGrain2
        + LiveStock  : ISO20022.Auth080001.AgriculturalCommodityLiveStock1
        + Sfd  : ISO20022.Auth080001.AgriculturalCommoditySeafood1
        + Frstry  : ISO20022.Auth080001.AgriculturalCommodityForestry1
        + Dairy  : ISO20022.Auth080001.AgriculturalCommodityDairy1
        + OlvOil  : ISO20022.Auth080001.AgriculturalCommodityOliveOil2
        + Ptt  : ISO20022.Auth080001.AgriculturalCommodityPotato1
        + Soft  : ISO20022.Auth080001.AgriculturalCommoditySoft1
        + GrnOilSeed  : ISO20022.Auth080001.AgriculturalCommodityOilSeed1
    }
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityGrain2
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityLiveStock1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommoditySeafood1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityForestry1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityDairy1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityOliveOil2
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityPotato1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommoditySoft1
    ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth080001.AgriculturalCommodityOilSeed1
    class ISO20022.Auth080001.AssetClassCommodityEnergy2Choice {
        + Othr  : ISO20022.Auth080001.EnergyCommodityOther1
        + Dstllts  : ISO20022.Auth080001.EnergyCommodityDistillates1
        + LghtEnd  : ISO20022.Auth080001.EnergyCommodityLightEnd1
        + RnwblNrgy  : ISO20022.Auth080001.EnergyCommodityRenewableEnergy1
        + IntrNrgy  : ISO20022.Auth080001.EnergyCommodityInterEnergy1
        + Coal  : ISO20022.Auth080001.EnergyCommodityCoal1
        + Oil  : ISO20022.Auth080001.EnergyCommodityOil2
        + NtrlGas  : ISO20022.Auth080001.EnergyCommodityNaturalGas2
        + Elctrcty  : ISO20022.Auth080001.EnergyCommodityElectricity1
    }
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityDistillates1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityLightEnd1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityRenewableEnergy1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityInterEnergy1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityCoal1
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityOil2
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityNaturalGas2
    ISO20022.Auth080001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth080001.EnergyCommodityElectricity1
    class ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice {
        + Othr  : ISO20022.Auth080001.EnvironmentCommodityOther1
        + CrbnRltd  : ISO20022.Auth080001.EnvironmentalCommodityCarbonRelated1
        + Wthr  : ISO20022.Auth080001.EnvironmentalCommodityWeather1
        + Emssns  : ISO20022.Auth080001.EnvironmentalCommodityEmission2
    }
    ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth080001.EnvironmentCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth080001.EnvironmentalCommodityCarbonRelated1
    ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth080001.EnvironmentalCommodityWeather1
    ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth080001.EnvironmentalCommodityEmission2
    class ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice {
        + Othr  : ISO20022.Auth080001.FertilizerCommodityOther1
        + UreaAndAmmnmNtrt  : ISO20022.Auth080001.FertilizerCommodityUreaAndAmmoniumNitrate1
        + Urea  : ISO20022.Auth080001.FertilizerCommodityUrea1
        + Slphr  : ISO20022.Auth080001.FertilizerCommoditySulphur1
        + Ptsh  : ISO20022.Auth080001.FertilizerCommodityPotash1
        + DmmnmPhspht  : ISO20022.Auth080001.FertilizerCommodityDiammoniumPhosphate1
        + Ammn  : ISO20022.Auth080001.FertilizerCommodityAmmonia1
    }
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityUreaAndAmmoniumNitrate1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityUrea1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommoditySulphur1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityPotash1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityDiammoniumPhosphate1
    ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth080001.FertilizerCommodityAmmonia1
    class ISO20022.Auth080001.AssetClassCommodityFreight3Choice {
        + Othr  : ISO20022.Auth080001.FreightCommodityOther1
        + CntnrShip  : ISO20022.Auth080001.FreightCommodityContainerShip1
        + Wet  : ISO20022.Auth080001.FreightCommodityWet2
        + Dry  : ISO20022.Auth080001.FreightCommodityDry2
    }
    ISO20022.Auth080001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth080001.FreightCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth080001.FreightCommodityContainerShip1
    ISO20022.Auth080001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth080001.FreightCommodityWet2
    ISO20022.Auth080001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth080001.FreightCommodityDry2
    class ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice {
        + Manfctg  : ISO20022.Auth080001.IndustrialProductCommodityManufacturing1
        + Cnstrctn  : ISO20022.Auth080001.IndustrialProductCommodityConstruction1
    }
    ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth080001.IndustrialProductCommodityManufacturing1
    ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth080001.IndustrialProductCommodityConstruction1
    class ISO20022.Auth080001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AssetClassCommodityMetal1Choice {
        + Prcs  : ISO20022.Auth080001.MetalCommodityPrecious1
        + NonPrcs  : ISO20022.Auth080001.MetalCommodityNonPrecious1
    }
    ISO20022.Auth080001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth080001.MetalCommodityPrecious1
    ISO20022.Auth080001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth080001.MetalCommodityNonPrecious1
    class ISO20022.Auth080001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth080001.AssetClassCommodityOtherC102Choice {
        + NonDlvrbl  : ISO20022.Auth080001.OtherC10CommodityNonDeliverable2
        + Dlvrbl  : ISO20022.Auth080001.OtherC10CommodityDeliverable2
    }
    ISO20022.Auth080001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth080001.OtherC10CommodityNonDeliverable2
    ISO20022.Auth080001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth080001.OtherC10CommodityDeliverable2
    class ISO20022.Auth080001.AssetClassCommodityPaper3Choice {
        + Othr  : ISO20022.Auth080001.PaperCommodityRecoveredPaper2
        + RcvrdPpr  : ISO20022.Auth080001.PaperCommodityRecoveredPaper1
        + Pulp  : ISO20022.Auth080001.PaperCommodityPulp1
        + Nwsprnt  : ISO20022.Auth080001.PaperCommodityNewsprint1
        + CntnrBrd  : ISO20022.Auth080001.PaperCommodityContainerBoard1
    }
    ISO20022.Auth080001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth080001.PaperCommodityRecoveredPaper2
    ISO20022.Auth080001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth080001.PaperCommodityRecoveredPaper1
    ISO20022.Auth080001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth080001.PaperCommodityPulp1
    ISO20022.Auth080001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth080001.PaperCommodityNewsprint1
    ISO20022.Auth080001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth080001.PaperCommodityContainerBoard1
    class ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice {
        + Othr  : ISO20022.Auth080001.PolypropyleneCommodityOther1
        + Plstc  : ISO20022.Auth080001.PolypropyleneCommodityPlastic1
    }
    ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice *-- ISO20022.Auth080001.PolypropyleneCommodityOther1
    ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice *-- ISO20022.Auth080001.PolypropyleneCommodityPlastic1
    class ISO20022.Auth080001.AssetClassDetailedSubProductType10Code {
        LEAD = 1
        OTHR = 2
        ZINC = 3
        TINN = 4
        STEL = 5
        NICK = 6
        NASC = 7
        MOLY = 8
        IRON = 9
        COPR = 10
        CBLT = 11
        ALUA = 12
        ALUM = 13
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType29Code {
        OTHR = 1
        LAMP = 2
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType30Code {
        OTHR = 1
        MWHT = 2
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType31Code {
        OTHR = 1
        NBPG = 2
        TTFG = 3
        NCGG = 4
        LNGG = 5
        GASP = 6
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType32Code {
        OTHR = 1
        URAL = 2
        WTIO = 3
        TAPI = 4
        NGLO = 5
        NAPH = 6
        MARS = 7
        LLSO = 8
        KERO = 9
        JTFL = 10
        HEAT = 11
        GSLN = 12
        GOIL = 13
        FOIL = 14
        FUEL = 15
        ETHA = 16
        ESPO = 17
        DUBA = 18
        DSEL = 19
        COND = 20
        CNDA = 21
        BRNX = 22
        BRNT = 23
        BDSL = 24
        BAKK = 25
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType33Code {
        OTHR = 1
        DBCR = 2
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType34Code {
        OTHR = 1
        TNKR = 2
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth080001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth080001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth080001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth080001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth080001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth080001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth080001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth080001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth080001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth080001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth080001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth080001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth080001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth080001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth080001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType38Code {
        RCVP = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType47Code {
        DLVR = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType48Code {
        NDLV = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType49Code {
        OTHR = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth080001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth080001.BenchmarkCurveName10Choice {
        + Nm  : String
        + Indx  : String
    }
    class ISO20022.Auth080001.BenchmarkCurveName3Code {
        SONA = 1
        SOFR = 2
        WIBO = 3
        TREA = 4
        TIBO = 5
        TLBO = 6
        SWAP = 7
        STBO = 8
        PRBO = 9
        PFAN = 10
        NIBO = 11
        MAAA = 12
        MOSP = 13
        LIBO = 14
        LIBI = 15
        JIBA = 16
        ISDA = 17
        GCFR = 18
        FUSW = 19
        EUCH = 20
        EUUS = 21
        EURI = 22
        EONS = 23
        EONA = 24
        CIBO = 25
        CDOR = 26
        BUBO = 27
        BBSW = 28
        ESTR = 29
    }
    class ISO20022.Auth080001.CashCompare3 {
        + HrcutOrMrgn  : ISO20022.Auth080001.ComparePercentageRate3
        + Val  : ISO20022.Auth080001.CompareAmountAndDirection2
    }
    ISO20022.Auth080001.CashCompare3 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.CashCompare3 *-- ISO20022.Auth080001.CompareAmountAndDirection2
    class ISO20022.Auth080001.Cleared4Choice {
        + NonClrd  : String
        + Clrd  : String
    }
    class ISO20022.Auth080001.CollateralDeliveryMethod1Code {
        TTCA = 1
        SIUR = 2
        SICA = 3
    }
    class ISO20022.Auth080001.CollateralMatchingCriteria6 {
        + BsktIdr  : ISO20022.Auth080001.CompareSecurityIdentification4
        + AsstTp  : ISO20022.Auth080001.SecurityCommodityCash4
        + CollValDt  : ISO20022.Auth080001.CompareDate3
        + NetXpsrCollstnInd  : ISO20022.Auth080001.CompareTrueFalseIndicator3
        + UncollsdFlg  : ISO20022.Auth080001.CompareTrueFalseIndicator3
    }
    ISO20022.Auth080001.CollateralMatchingCriteria6 *-- ISO20022.Auth080001.CompareSecurityIdentification4
    ISO20022.Auth080001.CollateralMatchingCriteria6 *-- ISO20022.Auth080001.SecurityCommodityCash4
    ISO20022.Auth080001.CollateralMatchingCriteria6 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.CollateralMatchingCriteria6 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    ISO20022.Auth080001.CollateralMatchingCriteria6 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    class ISO20022.Auth080001.CollateralQualityType1Code {
        NOAP = 1
        NOTR = 2
        NIVG = 3
        INVG = 4
    }
    class ISO20022.Auth080001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Auth080001.Commodity42 {
        + UnitOfMeasr  : ISO20022.Auth080001.CompareUnitOfMeasure3
        + MktVal  : ISO20022.Auth080001.CompareAmountAndDirection2
        + UnitPric  : ISO20022.Auth080001.CompareUnitPrice6
        + Qty  : ISO20022.Auth080001.CompareDecimalNumber3
        + Clssfctn  : ISO20022.Auth080001.CompareCommodityAssetClass3
    }
    ISO20022.Auth080001.Commodity42 *-- ISO20022.Auth080001.CompareUnitOfMeasure3
    ISO20022.Auth080001.Commodity42 *-- ISO20022.Auth080001.CompareAmountAndDirection2
    ISO20022.Auth080001.Commodity42 *-- ISO20022.Auth080001.CompareUnitPrice6
    ISO20022.Auth080001.Commodity42 *-- ISO20022.Auth080001.CompareDecimalNumber3
    ISO20022.Auth080001.Commodity42 *-- ISO20022.Auth080001.CompareCommodityAssetClass3
    class ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3 {
        + Val2  : ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
        + Val1  : ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3 *-- ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3 *-- ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth080001.CompareAgreementType2 {
        + Val2  : ISO20022.Auth080001.AgreementType1Choice
        + Val1  : ISO20022.Auth080001.AgreementType1Choice
    }
    ISO20022.Auth080001.CompareAgreementType2 *-- ISO20022.Auth080001.AgreementType1Choice
    ISO20022.Auth080001.CompareAgreementType2 *-- ISO20022.Auth080001.AgreementType1Choice
    class ISO20022.Auth080001.CompareAmountAndDirection1 {
        + Val2  : ISO20022.Auth080001.AmountAndDirection53
        + Val1  : ISO20022.Auth080001.AmountAndDirection53
    }
    ISO20022.Auth080001.CompareAmountAndDirection1 *-- ISO20022.Auth080001.AmountAndDirection53
    ISO20022.Auth080001.CompareAmountAndDirection1 *-- ISO20022.Auth080001.AmountAndDirection53
    class ISO20022.Auth080001.CompareAmountAndDirection2 {
        + Val2  : ISO20022.Auth080001.AmountAndDirection53
        + Val1  : ISO20022.Auth080001.AmountAndDirection53
    }
    ISO20022.Auth080001.CompareAmountAndDirection2 *-- ISO20022.Auth080001.AmountAndDirection53
    ISO20022.Auth080001.CompareAmountAndDirection2 *-- ISO20022.Auth080001.AmountAndDirection53
    class ISO20022.Auth080001.CompareBenchmarkCurveName3 {
        + Val2  : ISO20022.Auth080001.BenchmarkCurveName10Choice
        + Val1  : ISO20022.Auth080001.BenchmarkCurveName10Choice
    }
    ISO20022.Auth080001.CompareBenchmarkCurveName3 *-- ISO20022.Auth080001.BenchmarkCurveName10Choice
    ISO20022.Auth080001.CompareBenchmarkCurveName3 *-- ISO20022.Auth080001.BenchmarkCurveName10Choice
    class ISO20022.Auth080001.CompareCFIIdentifier3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareClearingStatus3 {
        + Val2  : ISO20022.Auth080001.Cleared4Choice
        + Val1  : ISO20022.Auth080001.Cleared4Choice
    }
    ISO20022.Auth080001.CompareClearingStatus3 *-- ISO20022.Auth080001.Cleared4Choice
    ISO20022.Auth080001.CompareClearingStatus3 *-- ISO20022.Auth080001.Cleared4Choice
    class ISO20022.Auth080001.CompareCollateralQualityType3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareCommodityAssetClass3 {
        + Val2  : ISO20022.Auth080001.AssetClassCommodity5Choice
        + Val1  : ISO20022.Auth080001.AssetClassCommodity5Choice
    }
    ISO20022.Auth080001.CompareCommodityAssetClass3 *-- ISO20022.Auth080001.AssetClassCommodity5Choice
    ISO20022.Auth080001.CompareCommodityAssetClass3 *-- ISO20022.Auth080001.AssetClassCommodity5Choice
    class ISO20022.Auth080001.CompareCounterpartySide2 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareCountryCode3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareDate3 {
        + Val2  : DateTime
        + Val1  : DateTime
    }
    class ISO20022.Auth080001.CompareDateTime3 {
        + Val2  : DateTime
        + Val1  : DateTime
    }
    class ISO20022.Auth080001.CompareDecimalNumber3 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth080001.CompareDeliveryMethod3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareExposureType3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareISINIdentifier4 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareInterestComputationMethod3 {
        + Val2  : ISO20022.Auth080001.InterestComputationMethodFormat6Choice
        + Val1  : ISO20022.Auth080001.InterestComputationMethodFormat6Choice
    }
    ISO20022.Auth080001.CompareInterestComputationMethod3 *-- ISO20022.Auth080001.InterestComputationMethodFormat6Choice
    ISO20022.Auth080001.CompareInterestComputationMethod3 *-- ISO20022.Auth080001.InterestComputationMethodFormat6Choice
    class ISO20022.Auth080001.CompareInterestRate1 {
        + BsisPtSprd  : ISO20022.Auth080001.CompareDecimalNumber3
        + FltgIntrstRateRstFrqcyVal  : ISO20022.Auth080001.CompareNumber6
        + FltgIntrstRateRstFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRatePmtFrqcyVal  : ISO20022.Auth080001.CompareNumber5
        + FltgIntrstRatePmtFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRateTermVal  : ISO20022.Auth080001.CompareNumber5
        + FltgIntrstRateTermUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRefRate  : ISO20022.Auth080001.CompareBenchmarkCurveName3
        + DayCntBsis  : ISO20022.Auth080001.CompareInterestComputationMethod3
        + FxdIntrstRate  : ISO20022.Auth080001.ComparePercentageRate3
        + MrgnLnAmt  : ISO20022.Auth080001.CompareAmountAndDirection1
    }
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareDecimalNumber3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareNumber6
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareNumber5
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareNumber5
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareBenchmarkCurveName3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareInterestComputationMethod3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.CompareInterestRate1 *-- ISO20022.Auth080001.CompareAmountAndDirection1
    class ISO20022.Auth080001.CompareMICIdentifier3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareNumber5 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth080001.CompareNumber6 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth080001.CompareOrganisationIdentification6 {
        + Val2  : ISO20022.Auth080001.OrganisationIdentification15Choice
        + Val1  : ISO20022.Auth080001.OrganisationIdentification15Choice
    }
    ISO20022.Auth080001.CompareOrganisationIdentification6 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    ISO20022.Auth080001.CompareOrganisationIdentification6 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    class ISO20022.Auth080001.CompareOrganisationIdentification7 {
        + Val2  : ISO20022.Auth080001.PartyIdentification236Choice
        + Val1  : ISO20022.Auth080001.PartyIdentification236Choice
    }
    ISO20022.Auth080001.CompareOrganisationIdentification7 *-- ISO20022.Auth080001.PartyIdentification236Choice
    ISO20022.Auth080001.CompareOrganisationIdentification7 *-- ISO20022.Auth080001.PartyIdentification236Choice
    class ISO20022.Auth080001.ComparePercentageRate3 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth080001.CompareRateBasis3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareReportingLevelType3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareSecuritiesLendingType3 {
        + Val2  : ISO20022.Auth080001.SecuritiesLendingType3Choice
        + Val1  : ISO20022.Auth080001.SecuritiesLendingType3Choice
    }
    ISO20022.Auth080001.CompareSecuritiesLendingType3 *-- ISO20022.Auth080001.SecuritiesLendingType3Choice
    ISO20022.Auth080001.CompareSecuritiesLendingType3 *-- ISO20022.Auth080001.SecuritiesLendingType3Choice
    class ISO20022.Auth080001.CompareSecurityIdentification4 {
        + Val2  : ISO20022.Auth080001.SecurityIdentification26Choice
        + Val1  : ISO20022.Auth080001.SecurityIdentification26Choice
    }
    ISO20022.Auth080001.CompareSecurityIdentification4 *-- ISO20022.Auth080001.SecurityIdentification26Choice
    ISO20022.Auth080001.CompareSecurityIdentification4 *-- ISO20022.Auth080001.SecurityIdentification26Choice
    class ISO20022.Auth080001.CompareSpecialCollateral3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareTerminationOption3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareText2 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareTrueFalseIndicator3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareUnitOfMeasure3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth080001.CompareUnitPrice6 {
        + Val2  : ISO20022.Auth080001.SecuritiesTransactionPrice19Choice
        + Val1  : ISO20022.Auth080001.SecuritiesTransactionPrice19Choice
    }
    ISO20022.Auth080001.CompareUnitPrice6 *-- ISO20022.Auth080001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth080001.CompareUnitPrice6 *-- ISO20022.Auth080001.SecuritiesTransactionPrice19Choice
    class ISO20022.Auth080001.CounterpartyMatchingCriteria4 {
        + CtrPtySd  : ISO20022.Auth080001.CompareCounterpartySide2
        + OthrCtrPty  : ISO20022.Auth080001.CompareOrganisationIdentification7
        + RptgCtrPty  : ISO20022.Auth080001.CompareOrganisationIdentification6
    }
    ISO20022.Auth080001.CounterpartyMatchingCriteria4 *-- ISO20022.Auth080001.CompareCounterpartySide2
    ISO20022.Auth080001.CounterpartyMatchingCriteria4 *-- ISO20022.Auth080001.CompareOrganisationIdentification7
    ISO20022.Auth080001.CounterpartyMatchingCriteria4 *-- ISO20022.Auth080001.CompareOrganisationIdentification6
    class ISO20022.Auth080001.EnergyCommodityCoal1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityDistillates1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityElectricity1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityInterEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityLightEnd1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityNaturalGas2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityOil2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnergyCommodityRenewableEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnvironmentCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnvironmentalCommodityCarbonRelated1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnvironmentalCommodityEmission2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.EnvironmentalCommodityWeather1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.ExposureType10Code {
        REPO = 1
        SLEB = 2
        MGLD = 3
        SBSC = 4
    }
    class ISO20022.Auth080001.FertilizerCommodityAmmonia1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommodityDiammoniumPhosphate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommodityPotash1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommoditySulphur1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommodityUrea1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FertilizerCommodityUreaAndAmmoniumNitrate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FreightCommodityContainerShip1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FreightCommodityDry2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FreightCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.FreightCommodityWet2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth080001.IndustrialProductCommodityConstruction1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.IndustrialProductCommodityManufacturing1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.InterestComputationMethod1Code {
        A014 = 1
        A013 = 2
        A012 = 3
        A011 = 4
        A010 = 5
        A009 = 6
        A008 = 7
        A007 = 8
        A006 = 9
        A005 = 10
        A004 = 11
        A003 = 12
        A002 = 13
        A001 = 14
    }
    class ISO20022.Auth080001.InterestComputationMethodFormat6Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth080001.LoanMatchingCriteria9 {
        + UnitOfMeasr  : ISO20022.Auth080001.CompareUnitOfMeasure3
        + LvlTp  : ISO20022.Auth080001.CompareReportingLevelType3
        + ShrtMktValAmt  : ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
        + OutsdngMrgnLnAmt  : ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
        + LndgFee  : ISO20022.Auth080001.ComparePercentageRate3
        + FltgRateAdjstmntDt  : global::System.Collections.Generic.List~ISO20022.Auth080001.CompareDate3~
        + FltgRateAdjstmnt  : global::System.Collections.Generic.List~ISO20022.Auth080001.ComparePercentageRate3~
        + RbtRateBsisPtSprd  : ISO20022.Auth080001.CompareDecimalNumber3
        + FltgRbtRateRstFrqcyVal  : ISO20022.Auth080001.CompareNumber6
        + FltgRbtRateRstFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgRbtRatePmtFrqcyVal  : ISO20022.Auth080001.CompareNumber6
        + FltgRbtRatePmtFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgRbtRateTermVal  : ISO20022.Auth080001.CompareNumber6
        + FltgRbtRateTermUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgRbtRefRate  : ISO20022.Auth080001.CompareBenchmarkCurveName3
        + FxdRbtRefRate  : ISO20022.Auth080001.ComparePercentageRate3
        + LnVal  : ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
        + AsstTp  : ISO20022.Auth080001.SecurityCommodity7Choice
        + PrncplAmtMtrtyDtAmt  : ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
        + PrncplAmtValDtAmt  : ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
        + MrgnLnAttr  : global::System.Collections.Generic.List~ISO20022.Auth080001.CompareInterestRate1~
        + BsisPtSprd  : ISO20022.Auth080001.CompareDecimalNumber3
        + FltgIntrstRateRstFrqcyVal  : ISO20022.Auth080001.CompareNumber6
        + FltgIntrstRateRstFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRatePmtFrqcyVal  : ISO20022.Auth080001.CompareNumber5
        + FltgIntrstRatePmtFrqcyUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRateTermVal  : ISO20022.Auth080001.CompareNumber5
        + FltgIntrstRateTermUnit  : ISO20022.Auth080001.CompareRateBasis3
        + FltgIntrstRefRate  : ISO20022.Auth080001.CompareBenchmarkCurveName3
        + DayCntBsis  : ISO20022.Auth080001.CompareInterestComputationMethod3
        + FxdIntrstRate  : ISO20022.Auth080001.ComparePercentageRate3
        + TermntnOptn  : ISO20022.Auth080001.CompareTerminationOption3
        + OpnTerm  : ISO20022.Auth080001.CompareTrueFalseIndicator3
        + CollDlvryMtd  : ISO20022.Auth080001.CompareDeliveryMethod3
        + DlvryByVal  : ISO20022.Auth080001.CompareTrueFalseIndicator3
        + GnlColl  : ISO20022.Auth080001.CompareSpecialCollateral3
        + EarlstCallBckDt  : ISO20022.Auth080001.CompareDate3
        + MinNtcePrd  : ISO20022.Auth080001.CompareNumber5
        + MtrtyDt  : ISO20022.Auth080001.CompareDate3
        + ValDt  : ISO20022.Auth080001.CompareDate3
        + ExctnDtTm  : ISO20022.Auth080001.CompareDateTime3
        + MstrAgrmtTp  : ISO20022.Auth080001.CompareAgreementType2
        + TradgVn  : ISO20022.Auth080001.CompareMICIdentifier3
        + CCP  : ISO20022.Auth080001.CompareOrganisationIdentification6
        + ClrDtTm  : ISO20022.Auth080001.CompareDateTime3
        + ClrSts  : ISO20022.Auth080001.CompareClearingStatus3
        + CtrctTp  : ISO20022.Auth080001.CompareExposureType3
        + TermntnDt  : ISO20022.Auth080001.CompareDate3
        + UnqTradIdr  : ISO20022.Auth080001.CompareText2
    }
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareUnitOfMeasure3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareReportingLevelType3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDecimalNumber3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber6
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber6
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber6
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareBenchmarkCurveName3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.SecurityCommodity7Choice
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareInterestRate1
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDecimalNumber3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber6
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber5
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber5
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareRateBasis3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareBenchmarkCurveName3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareInterestComputationMethod3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareTerminationOption3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDeliveryMethod3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareSpecialCollateral3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareNumber5
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDateTime3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareAgreementType2
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareMICIdentifier3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareOrganisationIdentification6
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDateTime3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareClearingStatus3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareExposureType3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.LoanMatchingCriteria9 *-- ISO20022.Auth080001.CompareText2
    class ISO20022.Auth080001.MasterAgreement7 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth080001.AgreementType2Choice
    }
    ISO20022.Auth080001.MasterAgreement7 *-- ISO20022.Auth080001.AgreementType2Choice
    class ISO20022.Auth080001.MatchingCriteria10 {
        + CollMtchgCrit  : ISO20022.Auth080001.CollateralMatchingCriteria6
        + LnMtchgCrit  : ISO20022.Auth080001.LoanMatchingCriteria9
        + CtrPtyMtchgCrit  : ISO20022.Auth080001.CounterpartyMatchingCriteria4
    }
    ISO20022.Auth080001.MatchingCriteria10 *-- ISO20022.Auth080001.CollateralMatchingCriteria6
    ISO20022.Auth080001.MatchingCriteria10 *-- ISO20022.Auth080001.LoanMatchingCriteria9
    ISO20022.Auth080001.MatchingCriteria10 *-- ISO20022.Auth080001.CounterpartyMatchingCriteria4
    class ISO20022.Auth080001.MetalCommodityNonPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.MetalCommodityPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth080001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth080001.GenericIdentification175
    }
    ISO20022.Auth080001.NaturalPersonIdentification2 *-- ISO20022.Auth080001.GenericIdentification175
    class ISO20022.Auth080001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth080001.NotAvailable1Code {
        NTAV = 1
    }
    class ISO20022.Auth080001.NumberOfReportsPerStatus4 {
        + DtldSts  : String
        + DtldNbOfRpts  : String
    }
    class ISO20022.Auth080001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth080001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth080001.OrganisationIdentification15Choice *-- ISO20022.Auth080001.OrganisationIdentification38
    class ISO20022.Auth080001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth080001.GenericIdentification175
    }
    ISO20022.Auth080001.OrganisationIdentification38 *-- ISO20022.Auth080001.GenericIdentification175
    class ISO20022.Auth080001.OtherC10CommodityDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.OtherC10CommodityNonDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PairedReconciled3Code {
        UNPR = 1
        RECO = 2
        PARD = 3
        LNRC = 4
        CLRC = 5
    }
    class ISO20022.Auth080001.PaperCommodityContainerBoard1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PaperCommodityNewsprint1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PaperCommodityPulp1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PaperCommodityRecoveredPaper1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PaperCommodityRecoveredPaper2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth080001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth080001.OrganisationIdentification15Choice
    }
    ISO20022.Auth080001.PartyIdentification236Choice *-- ISO20022.Auth080001.NaturalPersonIdentification2
    ISO20022.Auth080001.PartyIdentification236Choice *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    class ISO20022.Auth080001.PolypropyleneCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PolypropyleneCommodityPlastic1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth080001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth080001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth080001.ReconciliationMatchedStatus9Choice {
        + NotMtchd  : ISO20022.Auth080001.ReconciliationResult10
        + Mtchd  : String
    }
    ISO20022.Auth080001.ReconciliationMatchedStatus9Choice *-- ISO20022.Auth080001.ReconciliationResult10
    class ISO20022.Auth080001.ReconciliationReport8 {
        + RcncltnSts  : ISO20022.Auth080001.ReconciliationStatus8Choice
        + Modfd  : String
        + TxId  : ISO20022.Auth080001.TradeTransactionIdentification19
        + TechRcrdId  : String
    }
    ISO20022.Auth080001.ReconciliationReport8 *-- ISO20022.Auth080001.ReconciliationStatus8Choice
    ISO20022.Auth080001.ReconciliationReport8 *-- ISO20022.Auth080001.TradeTransactionIdentification19
    class ISO20022.Auth080001.ReconciliationResult10 {
        + MtchgCrit  : ISO20022.Auth080001.MatchingCriteria10
        + CtrPty2  : ISO20022.Auth080001.OrganisationIdentification15Choice
        + CtrPty1  : ISO20022.Auth080001.OrganisationIdentification15Choice
    }
    ISO20022.Auth080001.ReconciliationResult10 *-- ISO20022.Auth080001.MatchingCriteria10
    ISO20022.Auth080001.ReconciliationResult10 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    ISO20022.Auth080001.ReconciliationResult10 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    class ISO20022.Auth080001.ReconciliationStatus8Choice {
        + RptgData  : ISO20022.Auth080001.ReconciliationMatchedStatus9Choice
        + NoRcncltnReqrd  : String
    }
    ISO20022.Auth080001.ReconciliationStatus8Choice *-- ISO20022.Auth080001.ReconciliationMatchedStatus9Choice
    class ISO20022.Auth080001.RepoTerminationOption2Code {
        NOAP = 1
        ETSB = 2
        EGAE = 3
        EGRN = 4
    }
    class ISO20022.Auth080001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth080001.SecuritiesFinancingReportingReconciliationStatusAdviceV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth080001.SupplementaryData1~
        + RcncltnData  : ISO20022.Auth080001.TradeData34Choice
    }
    ISO20022.Auth080001.SecuritiesFinancingReportingReconciliationStatusAdviceV02 *-- ISO20022.Auth080001.SupplementaryData1
    ISO20022.Auth080001.SecuritiesFinancingReportingReconciliationStatusAdviceV02 *-- ISO20022.Auth080001.TradeData34Choice
    class ISO20022.Auth080001.SecuritiesLendingType3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth080001.SecuritiesTransactionPrice19Choice {
        + Othr  : ISO20022.Auth080001.SecuritiesTransactionPrice5
        + PdgPric  : String
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth080001.AmountAndDirection107
    }
    ISO20022.Auth080001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth080001.SecuritiesTransactionPrice5
    ISO20022.Auth080001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth080001.AmountAndDirection107
    class ISO20022.Auth080001.SecuritiesTransactionPrice5 {
        + Tp  : String
        + Val  : Decimal
    }
    class ISO20022.Auth080001.Security48 {
        + HrcutOrMrgn  : ISO20022.Auth080001.ComparePercentageRate3
        + AvlblForCollReuse  : ISO20022.Auth080001.CompareTrueFalseIndicator3
        + MktVal  : ISO20022.Auth080001.CompareAmountAndDirection2
        + ExclsvArrgmnt  : ISO20022.Auth080001.CompareTrueFalseIndicator3
        + UnitPric  : ISO20022.Auth080001.CompareUnitPrice6
        + Tp  : global::System.Collections.Generic.List~ISO20022.Auth080001.CompareSecuritiesLendingType3~
        + IssrCtry  : ISO20022.Auth080001.CompareCountryCode3
        + IssrId  : ISO20022.Auth080001.CompareOrganisationIdentification6
        + Mtrty  : ISO20022.Auth080001.CompareDate3
        + Qlty  : ISO20022.Auth080001.CompareCollateralQualityType3
        + NmnlVal  : ISO20022.Auth080001.CompareAmountAndDirection2
        + Qty  : ISO20022.Auth080001.CompareDecimalNumber3
        + ClssfctnTp  : ISO20022.Auth080001.CompareCFIIdentifier3
        + Id  : ISO20022.Auth080001.CompareISINIdentifier4
    }
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.ComparePercentageRate3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareAmountAndDirection2
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareTrueFalseIndicator3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareUnitPrice6
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareSecuritiesLendingType3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareCountryCode3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareOrganisationIdentification6
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareDate3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareCollateralQualityType3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareAmountAndDirection2
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareDecimalNumber3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareCFIIdentifier3
    ISO20022.Auth080001.Security48 *-- ISO20022.Auth080001.CompareISINIdentifier4
    class ISO20022.Auth080001.SecurityCommodity7Choice {
        + Cmmdty  : global::System.Collections.Generic.List~ISO20022.Auth080001.Commodity42~
        + Scty  : global::System.Collections.Generic.List~ISO20022.Auth080001.Security48~
    }
    ISO20022.Auth080001.SecurityCommodity7Choice *-- ISO20022.Auth080001.Commodity42
    ISO20022.Auth080001.SecurityCommodity7Choice *-- ISO20022.Auth080001.Security48
    class ISO20022.Auth080001.SecurityCommodityCash4 {
        + Csh  : global::System.Collections.Generic.List~ISO20022.Auth080001.CashCompare3~
        + Cmmdty  : global::System.Collections.Generic.List~ISO20022.Auth080001.Commodity42~
        + Scty  : global::System.Collections.Generic.List~ISO20022.Auth080001.Security48~
    }
    ISO20022.Auth080001.SecurityCommodityCash4 *-- ISO20022.Auth080001.CashCompare3
    ISO20022.Auth080001.SecurityCommodityCash4 *-- ISO20022.Auth080001.Commodity42
    ISO20022.Auth080001.SecurityCommodityCash4 *-- ISO20022.Auth080001.Security48
    class ISO20022.Auth080001.SecurityIdentification26Choice {
        + NotAvlbl  : String
        + Id  : String
    }
    class ISO20022.Auth080001.SpecialCollateral1Code {
        SPEC = 1
        GENE = 2
    }
    class ISO20022.Auth080001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth080001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth080001.SupplementaryData1 *-- ISO20022.Auth080001.SupplementaryDataEnvelope1
    class ISO20022.Auth080001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth080001.TradeData28 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth080001.SupplementaryData1~
        + RcncltnRpt  : global::System.Collections.Generic.List~ISO20022.Auth080001.ReconciliationReport8~
        + PairgRcncltnSts  : global::System.Collections.Generic.List~ISO20022.Auth080001.NumberOfReportsPerStatus4~
    }
    ISO20022.Auth080001.TradeData28 *-- ISO20022.Auth080001.SupplementaryData1
    ISO20022.Auth080001.TradeData28 *-- ISO20022.Auth080001.ReconciliationReport8
    ISO20022.Auth080001.TradeData28 *-- ISO20022.Auth080001.NumberOfReportsPerStatus4
    class ISO20022.Auth080001.TradeData34Choice {
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Auth080001.TradeData28~
        + DataSetActn  : String
    }
    ISO20022.Auth080001.TradeData34Choice *-- ISO20022.Auth080001.TradeData28
    class ISO20022.Auth080001.TradeTransactionIdentification19 {
        + TrptyAgt  : ISO20022.Auth080001.OrganisationIdentification15Choice
        + AgtLndr  : ISO20022.Auth080001.OrganisationIdentification15Choice
        + MstrAgrmt  : ISO20022.Auth080001.MasterAgreement7
        + UnqTradIdr  : String
        + NttyRspnsblForRpt  : ISO20022.Auth080001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth080001.PartyIdentification236Choice
        + RptgCtrPty  : ISO20022.Auth080001.OrganisationIdentification15Choice
    }
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.MasterAgreement7
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.PartyIdentification236Choice
    ISO20022.Auth080001.TradeTransactionIdentification19 *-- ISO20022.Auth080001.OrganisationIdentification15Choice
    class ISO20022.Auth080001.UnitOfMeasure11Code {
        USQA = 1
        GGEU = 2
        TOCD = 3
        DGEU = 4
        PWRD = 5
        IPNT = 6
        UCWT = 7
        OZTR = 8
        MBTU = 9
        MIBA = 10
        TONE = 11
        MWYC = 12
        MMOC = 13
        MWMC = 14
        MWHC = 15
        MWHO = 16
        MWDC = 17
        KWYC = 18
        KWMC = 19
        KMOC = 20
        KWHC = 21
        KWHO = 22
        KWDC = 23
        HUWG = 24
        ENVO = 25
        ENVC = 26
        DMET = 27
        DAYS = 28
        CBME = 29
        PUND = 30
        LITR = 31
        CELI = 32
        MILI = 33
        SQKI = 34
        HECT = 35
        SCMT = 36
        SMIL = 37
        ARES = 38
        ACRE = 39
        SQYA = 40
        KMET = 41
        MMET = 42
        USGA = 43
        GBQA = 44
        USPI = 45
        GBPI = 46
        USOU = 47
        GBOU = 48
        SQMI = 49
        SQFO = 50
        SQIN = 51
        MILE = 52
        FOOT = 53
        SMET = 54
        CMET = 55
        GRAM = 56
        GBGA = 57
        YARD = 58
        INCH = 59
        METR = 60
        TONS = 61
        PIEC = 62
        KILO = 63
        CLRT = 64
        CEER = 65
        BUSL = 66
        BDFT = 67
        BCUF = 68
        BARL = 69
        ACCY = 70
        ALOW = 71
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

## Value ISO20022.Auth080001.ActiveOrHistoricCurrencyAnd20DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth080001.AgreementType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth080001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth080001.AgriculturalCommodityDairy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityForestry1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityGrain2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityLiveStock1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityOilSeed1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityOliveOil2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommodityPotato1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommoditySeafood1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AgriculturalCommoditySoft1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AmountAndDirection107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth080001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth080001.AmountAndDirection53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth080001.AssetClassCommodity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth080001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth080001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Infltn|ISO20022.Auth080001.AssetClassCommodityInflation1||XmlElement()||
|+|Plprpln|ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice||XmlElement()||
|+|Ppr|ISO20022.Auth080001.AssetClassCommodityPaper3Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth080001.AssetClassCommodityOtherC102Choice||XmlElement()||
|+|Metl|ISO20022.Auth080001.AssetClassCommodityMetal1Choice||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice||XmlElement()||
|+|Frght|ISO20022.Auth080001.AssetClassCommodityFreight3Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice||XmlElement()||
|+|Envttl|ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth080001.AssetClassCommodityEnergy2Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Infltn),validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Metl),validElement(IndstrlPdct),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Infltn,Plprpln,Ppr,OthrC10,Metl,IndstrlPdct,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth080001.AssetClassCommodityAgricultural5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.AgriculturalCommodityOther1||XmlElement()||
|+|Grn|ISO20022.Auth080001.AgriculturalCommodityGrain2||XmlElement()||
|+|LiveStock|ISO20022.Auth080001.AgriculturalCommodityLiveStock1||XmlElement()||
|+|Sfd|ISO20022.Auth080001.AgriculturalCommoditySeafood1||XmlElement()||
|+|Frstry|ISO20022.Auth080001.AgriculturalCommodityForestry1||XmlElement()||
|+|Dairy|ISO20022.Auth080001.AgriculturalCommodityDairy1||XmlElement()||
|+|OlvOil|ISO20022.Auth080001.AgriculturalCommodityOliveOil2||XmlElement()||
|+|Ptt|ISO20022.Auth080001.AgriculturalCommodityPotato1||XmlElement()||
|+|Soft|ISO20022.Auth080001.AgriculturalCommoditySoft1||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth080001.AgriculturalCommodityOilSeed1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Othr,Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth080001.AssetClassCommodityEnergy2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.EnergyCommodityOther1||XmlElement()||
|+|Dstllts|ISO20022.Auth080001.EnergyCommodityDistillates1||XmlElement()||
|+|LghtEnd|ISO20022.Auth080001.EnergyCommodityLightEnd1||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth080001.EnergyCommodityRenewableEnergy1||XmlElement()||
|+|IntrNrgy|ISO20022.Auth080001.EnergyCommodityInterEnergy1||XmlElement()||
|+|Coal|ISO20022.Auth080001.EnergyCommodityCoal1||XmlElement()||
|+|Oil|ISO20022.Auth080001.EnergyCommodityOil2||XmlElement()||
|+|NtrlGas|ISO20022.Auth080001.EnergyCommodityNaturalGas2||XmlElement()||
|+|Elctrcty|ISO20022.Auth080001.EnergyCommodityElectricity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Othr,Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth080001.AssetClassCommodityEnvironmental2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.EnvironmentCommodityOther1||XmlElement()||
|+|CrbnRltd|ISO20022.Auth080001.EnvironmentalCommodityCarbonRelated1||XmlElement()||
|+|Wthr|ISO20022.Auth080001.EnvironmentalCommodityWeather1||XmlElement()||
|+|Emssns|ISO20022.Auth080001.EnvironmentalCommodityEmission2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(Othr,CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth080001.AssetClassCommodityFertilizer3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.FertilizerCommodityOther1||XmlElement()||
|+|UreaAndAmmnmNtrt|ISO20022.Auth080001.FertilizerCommodityUreaAndAmmoniumNitrate1||XmlElement()||
|+|Urea|ISO20022.Auth080001.FertilizerCommodityUrea1||XmlElement()||
|+|Slphr|ISO20022.Auth080001.FertilizerCommoditySulphur1||XmlElement()||
|+|Ptsh|ISO20022.Auth080001.FertilizerCommodityPotash1||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth080001.FertilizerCommodityDiammoniumPhosphate1||XmlElement()||
|+|Ammn|ISO20022.Auth080001.FertilizerCommodityAmmonia1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(Othr,UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth080001.AssetClassCommodityFreight3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.FreightCommodityOther1||XmlElement()||
|+|CntnrShip|ISO20022.Auth080001.FreightCommodityContainerShip1||XmlElement()||
|+|Wet|ISO20022.Auth080001.FreightCommodityWet2||XmlElement()||
|+|Dry|ISO20022.Auth080001.FreightCommodityDry2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(Othr,CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth080001.AssetClassCommodityIndustrialProduct1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth080001.IndustrialProductCommodityManufacturing1||XmlElement()||
|+|Cnstrctn|ISO20022.Auth080001.IndustrialProductCommodityConstruction1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth080001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AssetClassCommodityMetal1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth080001.MetalCommodityPrecious1||XmlElement()||
|+|NonPrcs|ISO20022.Auth080001.MetalCommodityNonPrecious1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth080001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.AssetClassCommodityOtherC102Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonDlvrbl|ISO20022.Auth080001.OtherC10CommodityNonDeliverable2||XmlElement()||
|+|Dlvrbl|ISO20022.Auth080001.OtherC10CommodityDeliverable2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonDlvrbl),validElement(Dlvrbl),validChoice(NonDlvrbl,Dlvrbl))|

---

## Value ISO20022.Auth080001.AssetClassCommodityPaper3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.PaperCommodityRecoveredPaper2||XmlElement()||
|+|RcvrdPpr|ISO20022.Auth080001.PaperCommodityRecoveredPaper1||XmlElement()||
|+|Pulp|ISO20022.Auth080001.PaperCommodityPulp1||XmlElement()||
|+|Nwsprnt|ISO20022.Auth080001.PaperCommodityNewsprint1||XmlElement()||
|+|CntnrBrd|ISO20022.Auth080001.PaperCommodityContainerBoard1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(Othr,RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth080001.AssetClassCommodityPolypropylene3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.PolypropyleneCommodityOther1||XmlElement()||
|+|Plstc|ISO20022.Auth080001.PolypropyleneCommodityPlastic1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Plstc),validChoice(Othr,Plstc))|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LEAD|Int32||XmlEnum("""LEAD""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||ZINC|Int32||XmlEnum("""ZINC""")|3|
||TINN|Int32||XmlEnum("""TINN""")|4|
||STEL|Int32||XmlEnum("""STEL""")|5|
||NICK|Int32||XmlEnum("""NICK""")|6|
||NASC|Int32||XmlEnum("""NASC""")|7|
||MOLY|Int32||XmlEnum("""MOLY""")|8|
||IRON|Int32||XmlEnum("""IRON""")|9|
||COPR|Int32||XmlEnum("""COPR""")|10|
||CBLT|Int32||XmlEnum("""CBLT""")|11|
||ALUA|Int32||XmlEnum("""ALUA""")|12|
||ALUM|Int32||XmlEnum("""ALUM""")|13|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LAMP|Int32||XmlEnum("""LAMP""")|2|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MWHT|Int32||XmlEnum("""MWHT""")|2|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NBPG|Int32||XmlEnum("""NBPG""")|2|
||TTFG|Int32||XmlEnum("""TTFG""")|3|
||NCGG|Int32||XmlEnum("""NCGG""")|4|
||LNGG|Int32||XmlEnum("""LNGG""")|5|
||GASP|Int32||XmlEnum("""GASP""")|6|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||URAL|Int32||XmlEnum("""URAL""")|2|
||WTIO|Int32||XmlEnum("""WTIO""")|3|
||TAPI|Int32||XmlEnum("""TAPI""")|4|
||NGLO|Int32||XmlEnum("""NGLO""")|5|
||NAPH|Int32||XmlEnum("""NAPH""")|6|
||MARS|Int32||XmlEnum("""MARS""")|7|
||LLSO|Int32||XmlEnum("""LLSO""")|8|
||KERO|Int32||XmlEnum("""KERO""")|9|
||JTFL|Int32||XmlEnum("""JTFL""")|10|
||HEAT|Int32||XmlEnum("""HEAT""")|11|
||GSLN|Int32||XmlEnum("""GSLN""")|12|
||GOIL|Int32||XmlEnum("""GOIL""")|13|
||FOIL|Int32||XmlEnum("""FOIL""")|14|
||FUEL|Int32||XmlEnum("""FUEL""")|15|
||ETHA|Int32||XmlEnum("""ETHA""")|16|
||ESPO|Int32||XmlEnum("""ESPO""")|17|
||DUBA|Int32||XmlEnum("""DUBA""")|18|
||DSEL|Int32||XmlEnum("""DSEL""")|19|
||COND|Int32||XmlEnum("""COND""")|20|
||CNDA|Int32||XmlEnum("""CNDA""")|21|
||BRNX|Int32||XmlEnum("""BRNX""")|22|
||BRNT|Int32||XmlEnum("""BRNT""")|23|
||BDSL|Int32||XmlEnum("""BDSL""")|24|
||BAKK|Int32||XmlEnum("""BAKK""")|25|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DBCR|Int32||XmlEnum("""DBCR""")|2|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TNKR|Int32||XmlEnum("""TNKR""")|2|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth080001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth080001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType38Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCVP|Int32||XmlEnum("""RCVP""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType47Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVR|Int32||XmlEnum("""DLVR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType48Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NDLV|Int32||XmlEnum("""NDLV""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType49Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth080001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Value ISO20022.Auth080001.BenchmarkCurveName10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Nm,Indx))|

---

## Enum ISO20022.Auth080001.BenchmarkCurveName3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SONA|Int32||XmlEnum("""SONA""")|1|
||SOFR|Int32||XmlEnum("""SOFR""")|2|
||WIBO|Int32||XmlEnum("""WIBO""")|3|
||TREA|Int32||XmlEnum("""TREA""")|4|
||TIBO|Int32||XmlEnum("""TIBO""")|5|
||TLBO|Int32||XmlEnum("""TLBO""")|6|
||SWAP|Int32||XmlEnum("""SWAP""")|7|
||STBO|Int32||XmlEnum("""STBO""")|8|
||PRBO|Int32||XmlEnum("""PRBO""")|9|
||PFAN|Int32||XmlEnum("""PFAN""")|10|
||NIBO|Int32||XmlEnum("""NIBO""")|11|
||MAAA|Int32||XmlEnum("""MAAA""")|12|
||MOSP|Int32||XmlEnum("""MOSP""")|13|
||LIBO|Int32||XmlEnum("""LIBO""")|14|
||LIBI|Int32||XmlEnum("""LIBI""")|15|
||JIBA|Int32||XmlEnum("""JIBA""")|16|
||ISDA|Int32||XmlEnum("""ISDA""")|17|
||GCFR|Int32||XmlEnum("""GCFR""")|18|
||FUSW|Int32||XmlEnum("""FUSW""")|19|
||EUCH|Int32||XmlEnum("""EUCH""")|20|
||EUUS|Int32||XmlEnum("""EUUS""")|21|
||EURI|Int32||XmlEnum("""EURI""")|22|
||EONS|Int32||XmlEnum("""EONS""")|23|
||EONA|Int32||XmlEnum("""EONA""")|24|
||CIBO|Int32||XmlEnum("""CIBO""")|25|
||CDOR|Int32||XmlEnum("""CDOR""")|26|
||BUBO|Int32||XmlEnum("""BUBO""")|27|
||BBSW|Int32||XmlEnum("""BBSW""")|28|
||ESTR|Int32||XmlEnum("""ESTR""")|29|

---

## Value ISO20022.Auth080001.CashCompare3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutOrMrgn|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|Val|ISO20022.Auth080001.CompareAmountAndDirection2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrcutOrMrgn),validElement(Val))|

---

## Value ISO20022.Auth080001.Cleared4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrd|String||XmlElement()||
|+|Clrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NonClrd,Clrd))|

---

## Enum ISO20022.Auth080001.CollateralDeliveryMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TTCA|Int32||XmlEnum("""TTCA""")|1|
||SIUR|Int32||XmlEnum("""SIUR""")|2|
||SICA|Int32||XmlEnum("""SICA""")|3|

---

## Value ISO20022.Auth080001.CollateralMatchingCriteria6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsktIdr|ISO20022.Auth080001.CompareSecurityIdentification4||XmlElement()||
|+|AsstTp|ISO20022.Auth080001.SecurityCommodityCash4||XmlElement()||
|+|CollValDt|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|NetXpsrCollstnInd|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
|+|UncollsdFlg|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BsktIdr),validElement(AsstTp),validElement(CollValDt),validElement(NetXpsrCollstnInd),validElement(UncollsdFlg))|

---

## Enum ISO20022.Auth080001.CollateralQualityType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||NOTR|Int32||XmlEnum("""NOTR""")|2|
||NIVG|Int32||XmlEnum("""NIVG""")|3|
||INVG|Int32||XmlEnum("""INVG""")|4|

---

## Enum ISO20022.Auth080001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Value ISO20022.Auth080001.Commodity42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|ISO20022.Auth080001.CompareUnitOfMeasure3||XmlElement()||
|+|MktVal|ISO20022.Auth080001.CompareAmountAndDirection2||XmlElement()||
|+|UnitPric|ISO20022.Auth080001.CompareUnitPrice6||XmlElement()||
|+|Qty|ISO20022.Auth080001.CompareDecimalNumber3||XmlElement()||
|+|Clssfctn|ISO20022.Auth080001.CompareCommodityAssetClass3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validElement(MktVal),validElement(UnitPric),validElement(Qty),validElement(Clssfctn))|

---

## Value ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Val1|ISO20022.Auth080001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareAgreementType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.AgreementType1Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.AgreementType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareAmountAndDirection1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.AmountAndDirection53||XmlElement()||
|+|Val1|ISO20022.Auth080001.AmountAndDirection53||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareAmountAndDirection2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.AmountAndDirection53||XmlElement()||
|+|Val1|ISO20022.Auth080001.AmountAndDirection53||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareBenchmarkCurveName3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.BenchmarkCurveName10Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.BenchmarkCurveName10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareCFIIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{6,6}"""),validPattern("""Val1""",Val1,"""[A-Z]{6,6}"""))|

---

## Value ISO20022.Auth080001.CompareClearingStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.Cleared4Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.Cleared4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareCollateralQualityType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareCommodityAssetClass3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.AssetClassCommodity5Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.AssetClassCommodity5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareCounterpartySide2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareCountryCode3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{2,2}"""),validPattern("""Val1""",Val1,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Auth080001.CompareDate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|DateTime||XmlElement()||
|+|Val1|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareDateTime3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|DateTime||XmlElement()||
|+|Val1|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareDecimalNumber3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareDeliveryMethod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareExposureType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareISINIdentifier4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validPattern("""Val1""",Val1,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth080001.CompareInterestComputationMethod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.InterestComputationMethodFormat6Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.InterestComputationMethodFormat6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareInterestRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|ISO20022.Auth080001.CompareDecimalNumber3||XmlElement()||
|+|FltgIntrstRateRstFrqcyVal|ISO20022.Auth080001.CompareNumber6||XmlElement()||
|+|FltgIntrstRateRstFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRatePmtFrqcyVal|ISO20022.Auth080001.CompareNumber5||XmlElement()||
|+|FltgIntrstRatePmtFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRateTermVal|ISO20022.Auth080001.CompareNumber5||XmlElement()||
|+|FltgIntrstRateTermUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRefRate|ISO20022.Auth080001.CompareBenchmarkCurveName3||XmlElement()||
|+|DayCntBsis|ISO20022.Auth080001.CompareInterestComputationMethod3||XmlElement()||
|+|FxdIntrstRate|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|MrgnLnAmt|ISO20022.Auth080001.CompareAmountAndDirection1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BsisPtSprd),validElement(FltgIntrstRateRstFrqcyVal),validElement(FltgIntrstRateRstFrqcyUnit),validElement(FltgIntrstRatePmtFrqcyVal),validElement(FltgIntrstRatePmtFrqcyUnit),validElement(FltgIntrstRateTermVal),validElement(FltgIntrstRateTermUnit),validElement(FltgIntrstRefRate),validElement(DayCntBsis),validElement(FxdIntrstRate),validElement(MrgnLnAmt))|

---

## Value ISO20022.Auth080001.CompareMICIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z0-9]{4,4}"""),validPattern("""Val1""",Val1,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Auth080001.CompareNumber5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareNumber6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareOrganisationIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareOrganisationIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.PartyIdentification236Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.PartyIdentification236Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.ComparePercentageRate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareRateBasis3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareReportingLevelType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareSecuritiesLendingType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.SecuritiesLendingType3Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.SecuritiesLendingType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareSecurityIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.SecurityIdentification26Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.SecurityIdentification26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CompareSpecialCollateral3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareTerminationOption3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareText2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareTrueFalseIndicator3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareUnitOfMeasure3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.CompareUnitPrice6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth080001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|Val1|ISO20022.Auth080001.SecuritiesTransactionPrice19Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth080001.CounterpartyMatchingCriteria4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySd|ISO20022.Auth080001.CompareCounterpartySide2||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth080001.CompareOrganisationIdentification7||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth080001.CompareOrganisationIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrPtySd),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Type ISO20022.Auth080001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgRptgRcncltnStsAdvc|ISO20022.Auth080001.SecuritiesFinancingReportingReconciliationStatusAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgRptgRcncltnStsAdvc))|

---

## Value ISO20022.Auth080001.EnergyCommodityCoal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityDistillates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityElectricity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityInterEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityLightEnd1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityNaturalGas2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityOil2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnergyCommodityRenewableEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnvironmentCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnvironmentalCommodityCarbonRelated1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnvironmentalCommodityEmission2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.EnvironmentalCommodityWeather1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth080001.ExposureType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPO|Int32||XmlEnum("""REPO""")|1|
||SLEB|Int32||XmlEnum("""SLEB""")|2|
||MGLD|Int32||XmlEnum("""MGLD""")|3|
||SBSC|Int32||XmlEnum("""SBSC""")|4|

---

## Value ISO20022.Auth080001.FertilizerCommodityAmmonia1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommodityDiammoniumPhosphate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommodityPotash1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommoditySulphur1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommodityUrea1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FertilizerCommodityUreaAndAmmoniumNitrate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FreightCommodityContainerShip1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FreightCommodityDry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FreightCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.FreightCommodityWet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.IndustrialProductCommodityConstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.IndustrialProductCommodityManufacturing1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth080001.InterestComputationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||A014|Int32||XmlEnum("""A014""")|1|
||A013|Int32||XmlEnum("""A013""")|2|
||A012|Int32||XmlEnum("""A012""")|3|
||A011|Int32||XmlEnum("""A011""")|4|
||A010|Int32||XmlEnum("""A010""")|5|
||A009|Int32||XmlEnum("""A009""")|6|
||A008|Int32||XmlEnum("""A008""")|7|
||A007|Int32||XmlEnum("""A007""")|8|
||A006|Int32||XmlEnum("""A006""")|9|
||A005|Int32||XmlEnum("""A005""")|10|
||A004|Int32||XmlEnum("""A004""")|11|
||A003|Int32||XmlEnum("""A003""")|12|
||A002|Int32||XmlEnum("""A002""")|13|
||A001|Int32||XmlEnum("""A001""")|14|

---

## Value ISO20022.Auth080001.InterestComputationMethodFormat6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth080001.LoanMatchingCriteria9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|ISO20022.Auth080001.CompareUnitOfMeasure3||XmlElement()||
|+|LvlTp|ISO20022.Auth080001.CompareReportingLevelType3||XmlElement()||
|+|ShrtMktValAmt|ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3||XmlElement()||
|+|OutsdngMrgnLnAmt|ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3||XmlElement()||
|+|LndgFee|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|FltgRateAdjstmntDt|global::System.Collections.Generic.List<ISO20022.Auth080001.CompareDate3>||XmlElement()||
|+|FltgRateAdjstmnt|global::System.Collections.Generic.List<ISO20022.Auth080001.ComparePercentageRate3>||XmlElement()||
|+|RbtRateBsisPtSprd|ISO20022.Auth080001.CompareDecimalNumber3||XmlElement()||
|+|FltgRbtRateRstFrqcyVal|ISO20022.Auth080001.CompareNumber6||XmlElement()||
|+|FltgRbtRateRstFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgRbtRatePmtFrqcyVal|ISO20022.Auth080001.CompareNumber6||XmlElement()||
|+|FltgRbtRatePmtFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgRbtRateTermVal|ISO20022.Auth080001.CompareNumber6||XmlElement()||
|+|FltgRbtRateTermUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgRbtRefRate|ISO20022.Auth080001.CompareBenchmarkCurveName3||XmlElement()||
|+|FxdRbtRefRate|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|LnVal|ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3||XmlElement()||
|+|AsstTp|ISO20022.Auth080001.SecurityCommodity7Choice||XmlElement()||
|+|PrncplAmtMtrtyDtAmt|ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3||XmlElement()||
|+|PrncplAmtValDtAmt|ISO20022.Auth080001.CompareActiveOrHistoricCurrencyAndAmount3||XmlElement()||
|+|MrgnLnAttr|global::System.Collections.Generic.List<ISO20022.Auth080001.CompareInterestRate1>||XmlElement()||
|+|BsisPtSprd|ISO20022.Auth080001.CompareDecimalNumber3||XmlElement()||
|+|FltgIntrstRateRstFrqcyVal|ISO20022.Auth080001.CompareNumber6||XmlElement()||
|+|FltgIntrstRateRstFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRatePmtFrqcyVal|ISO20022.Auth080001.CompareNumber5||XmlElement()||
|+|FltgIntrstRatePmtFrqcyUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRateTermVal|ISO20022.Auth080001.CompareNumber5||XmlElement()||
|+|FltgIntrstRateTermUnit|ISO20022.Auth080001.CompareRateBasis3||XmlElement()||
|+|FltgIntrstRefRate|ISO20022.Auth080001.CompareBenchmarkCurveName3||XmlElement()||
|+|DayCntBsis|ISO20022.Auth080001.CompareInterestComputationMethod3||XmlElement()||
|+|FxdIntrstRate|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|TermntnOptn|ISO20022.Auth080001.CompareTerminationOption3||XmlElement()||
|+|OpnTerm|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
|+|CollDlvryMtd|ISO20022.Auth080001.CompareDeliveryMethod3||XmlElement()||
|+|DlvryByVal|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
|+|GnlColl|ISO20022.Auth080001.CompareSpecialCollateral3||XmlElement()||
|+|EarlstCallBckDt|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|MinNtcePrd|ISO20022.Auth080001.CompareNumber5||XmlElement()||
|+|MtrtyDt|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|ValDt|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|ExctnDtTm|ISO20022.Auth080001.CompareDateTime3||XmlElement()||
|+|MstrAgrmtTp|ISO20022.Auth080001.CompareAgreementType2||XmlElement()||
|+|TradgVn|ISO20022.Auth080001.CompareMICIdentifier3||XmlElement()||
|+|CCP|ISO20022.Auth080001.CompareOrganisationIdentification6||XmlElement()||
|+|ClrDtTm|ISO20022.Auth080001.CompareDateTime3||XmlElement()||
|+|ClrSts|ISO20022.Auth080001.CompareClearingStatus3||XmlElement()||
|+|CtrctTp|ISO20022.Auth080001.CompareExposureType3||XmlElement()||
|+|TermntnDt|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|UnqTradIdr|ISO20022.Auth080001.CompareText2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validElement(LvlTp),validElement(ShrtMktValAmt),validElement(OutsdngMrgnLnAmt),validElement(LndgFee),validList("""FltgRateAdjstmntDt""",FltgRateAdjstmntDt),validElement(FltgRateAdjstmntDt),validList("""FltgRateAdjstmnt""",FltgRateAdjstmnt),validElement(FltgRateAdjstmnt),validElement(RbtRateBsisPtSprd),validElement(FltgRbtRateRstFrqcyVal),validElement(FltgRbtRateRstFrqcyUnit),validElement(FltgRbtRatePmtFrqcyVal),validElement(FltgRbtRatePmtFrqcyUnit),validElement(FltgRbtRateTermVal),validElement(FltgRbtRateTermUnit),validElement(FltgRbtRefRate),validElement(FxdRbtRefRate),validElement(LnVal),validElement(AsstTp),validElement(PrncplAmtMtrtyDtAmt),validElement(PrncplAmtValDtAmt),validList("""MrgnLnAttr""",MrgnLnAttr),validElement(MrgnLnAttr),validElement(BsisPtSprd),validElement(FltgIntrstRateRstFrqcyVal),validElement(FltgIntrstRateRstFrqcyUnit),validElement(FltgIntrstRatePmtFrqcyVal),validElement(FltgIntrstRatePmtFrqcyUnit),validElement(FltgIntrstRateTermVal),validElement(FltgIntrstRateTermUnit),validElement(FltgIntrstRefRate),validElement(DayCntBsis),validElement(FxdIntrstRate),validElement(TermntnOptn),validElement(OpnTerm),validElement(CollDlvryMtd),validElement(DlvryByVal),validElement(GnlColl),validElement(EarlstCallBckDt),validElement(MinNtcePrd),validElement(MtrtyDt),validElement(ValDt),validElement(ExctnDtTm),validElement(MstrAgrmtTp),validElement(TradgVn),validElement(CCP),validElement(ClrDtTm),validElement(ClrSts),validElement(CtrctTp),validElement(TermntnDt),validElement(UnqTradIdr))|

---

## Value ISO20022.Auth080001.MasterAgreement7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth080001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth080001.MatchingCriteria10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollMtchgCrit|ISO20022.Auth080001.CollateralMatchingCriteria6||XmlElement()||
|+|LnMtchgCrit|ISO20022.Auth080001.LoanMatchingCriteria9||XmlElement()||
|+|CtrPtyMtchgCrit|ISO20022.Auth080001.CounterpartyMatchingCriteria4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollMtchgCrit),validElement(LnMtchgCrit),validElement(CtrPtyMtchgCrit))|

---

## Value ISO20022.Auth080001.MetalCommodityNonPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.MetalCommodityPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth080001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth080001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth080001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Enum ISO20022.Auth080001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Enum ISO20022.Auth080001.NotAvailable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTAV|Int32||XmlEnum("""NTAV""")|1|

---

## Value ISO20022.Auth080001.NumberOfReportsPerStatus4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtldSts|String||XmlElement()||
|+|DtldNbOfRpts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DtldNbOfRpts""",DtldNbOfRpts,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Auth080001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth080001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth080001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth080001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth080001.OtherC10CommodityDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.OtherC10CommodityNonDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth080001.PairedReconciled3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNPR|Int32||XmlEnum("""UNPR""")|1|
||RECO|Int32||XmlEnum("""RECO""")|2|
||PARD|Int32||XmlEnum("""PARD""")|3|
||LNRC|Int32||XmlEnum("""LNRC""")|4|
||CLRC|Int32||XmlEnum("""CLRC""")|5|

---

## Value ISO20022.Auth080001.PaperCommodityContainerBoard1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PaperCommodityNewsprint1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PaperCommodityPulp1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PaperCommodityRecoveredPaper1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PaperCommodityRecoveredPaper2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth080001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth080001.PolypropyleneCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.PolypropyleneCommodityPlastic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth080001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Enum ISO20022.Auth080001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth080001.ReconciliationMatchedStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotMtchd|ISO20022.Auth080001.ReconciliationResult10||XmlElement()||
|+|Mtchd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotMtchd),validChoice(NotMtchd,Mtchd))|

---

## Value ISO20022.Auth080001.ReconciliationReport8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcncltnSts|ISO20022.Auth080001.ReconciliationStatus8Choice||XmlElement()||
|+|Modfd|String||XmlElement()||
|+|TxId|ISO20022.Auth080001.TradeTransactionIdentification19||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcncltnSts),validElement(TxId))|

---

## Value ISO20022.Auth080001.ReconciliationResult10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtchgCrit|ISO20022.Auth080001.MatchingCriteria10||XmlElement()||
|+|CtrPty2|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
|+|CtrPty1|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchgCrit),validElement(CtrPty2),validElement(CtrPty1))|

---

## Value ISO20022.Auth080001.ReconciliationStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RptgData|ISO20022.Auth080001.ReconciliationMatchedStatus9Choice||XmlElement()||
|+|NoRcncltnReqrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptgData),validChoice(RptgData,NoRcncltnReqrd))|

---

## Enum ISO20022.Auth080001.RepoTerminationOption2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||ETSB|Int32||XmlEnum("""ETSB""")|2|
||EGAE|Int32||XmlEnum("""EGAE""")|3|
||EGRN|Int32||XmlEnum("""EGRN""")|4|

---

## Enum ISO20022.Auth080001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Aspect ISO20022.Auth080001.SecuritiesFinancingReportingReconciliationStatusAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth080001.SupplementaryData1>||XmlElement()||
|+|RcncltnData|ISO20022.Auth080001.TradeData34Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RcncltnData))|

---

## Value ISO20022.Auth080001.SecuritiesLendingType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth080001.SecuritiesTransactionPrice19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth080001.SecuritiesTransactionPrice5||XmlElement()||
|+|PdgPric|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth080001.AmountAndDirection107||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,PdgPric,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth080001.SecuritiesTransactionPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.Security48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutOrMrgn|ISO20022.Auth080001.ComparePercentageRate3||XmlElement()||
|+|AvlblForCollReuse|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
|+|MktVal|ISO20022.Auth080001.CompareAmountAndDirection2||XmlElement()||
|+|ExclsvArrgmnt|ISO20022.Auth080001.CompareTrueFalseIndicator3||XmlElement()||
|+|UnitPric|ISO20022.Auth080001.CompareUnitPrice6||XmlElement()||
|+|Tp|global::System.Collections.Generic.List<ISO20022.Auth080001.CompareSecuritiesLendingType3>||XmlElement()||
|+|IssrCtry|ISO20022.Auth080001.CompareCountryCode3||XmlElement()||
|+|IssrId|ISO20022.Auth080001.CompareOrganisationIdentification6||XmlElement()||
|+|Mtrty|ISO20022.Auth080001.CompareDate3||XmlElement()||
|+|Qlty|ISO20022.Auth080001.CompareCollateralQualityType3||XmlElement()||
|+|NmnlVal|ISO20022.Auth080001.CompareAmountAndDirection2||XmlElement()||
|+|Qty|ISO20022.Auth080001.CompareDecimalNumber3||XmlElement()||
|+|ClssfctnTp|ISO20022.Auth080001.CompareCFIIdentifier3||XmlElement()||
|+|Id|ISO20022.Auth080001.CompareISINIdentifier4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrcutOrMrgn),validElement(AvlblForCollReuse),validElement(MktVal),validElement(ExclsvArrgmnt),validElement(UnitPric),validList("""Tp""",Tp),validElement(Tp),validElement(IssrCtry),validElement(IssrId),validElement(Mtrty),validElement(Qlty),validElement(NmnlVal),validElement(Qty),validElement(ClssfctnTp),validElement(Id))|

---

## Value ISO20022.Auth080001.SecurityCommodity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmmdty|global::System.Collections.Generic.List<ISO20022.Auth080001.Commodity42>||XmlElement()||
|+|Scty|global::System.Collections.Generic.List<ISO20022.Auth080001.Security48>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmmdty""",Cmmdty),validElement(Cmmdty),validList("""Scty""",Scty),validElement(Scty),validChoice(Cmmdty,Scty))|

---

## Value ISO20022.Auth080001.SecurityCommodityCash4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Csh|global::System.Collections.Generic.List<ISO20022.Auth080001.CashCompare3>||XmlElement()||
|+|Cmmdty|global::System.Collections.Generic.List<ISO20022.Auth080001.Commodity42>||XmlElement()||
|+|Scty|global::System.Collections.Generic.List<ISO20022.Auth080001.Security48>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Csh""",Csh),validElement(Csh),validList("""Cmmdty""",Cmmdty),validElement(Cmmdty),validList("""Scty""",Scty),validElement(Scty))|

---

## Value ISO20022.Auth080001.SecurityIdentification26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotAvlbl|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(NotAvlbl,Id))|

---

## Enum ISO20022.Auth080001.SpecialCollateral1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPEC|Int32||XmlEnum("""SPEC""")|1|
||GENE|Int32||XmlEnum("""GENE""")|2|

---

## Value ISO20022.Auth080001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth080001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth080001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth080001.TradeData28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth080001.SupplementaryData1>||XmlElement()||
|+|RcncltnRpt|global::System.Collections.Generic.List<ISO20022.Auth080001.ReconciliationReport8>||XmlElement()||
|+|PairgRcncltnSts|global::System.Collections.Generic.List<ISO20022.Auth080001.NumberOfReportsPerStatus4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RcncltnRpt""",RcncltnRpt),validList("""RcncltnRpt""",RcncltnRpt),validElement(RcncltnRpt),validList("""PairgRcncltnSts""",PairgRcncltnSts),validElement(PairgRcncltnSts))|

---

## Value ISO20022.Auth080001.TradeData34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Auth080001.TradeData28>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth080001.TradeTransactionIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgt|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
|+|AgtLndr|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth080001.MasterAgreement7||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth080001.PartyIdentification236Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth080001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyAgt),validElement(AgtLndr),validElement(MstrAgrmt),validElement(NttyRspnsblForRpt),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Enum ISO20022.Auth080001.UnitOfMeasure11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USQA|Int32||XmlEnum("""USQA""")|1|
||GGEU|Int32||XmlEnum("""GGEU""")|2|
||TOCD|Int32||XmlEnum("""TOCD""")|3|
||DGEU|Int32||XmlEnum("""DGEU""")|4|
||PWRD|Int32||XmlEnum("""PWRD""")|5|
||IPNT|Int32||XmlEnum("""IPNT""")|6|
||UCWT|Int32||XmlEnum("""UCWT""")|7|
||OZTR|Int32||XmlEnum("""OZTR""")|8|
||MBTU|Int32||XmlEnum("""MBTU""")|9|
||MIBA|Int32||XmlEnum("""MIBA""")|10|
||TONE|Int32||XmlEnum("""TONE""")|11|
||MWYC|Int32||XmlEnum("""MWYC""")|12|
||MMOC|Int32||XmlEnum("""MMOC""")|13|
||MWMC|Int32||XmlEnum("""MWMC""")|14|
||MWHC|Int32||XmlEnum("""MWHC""")|15|
||MWHO|Int32||XmlEnum("""MWHO""")|16|
||MWDC|Int32||XmlEnum("""MWDC""")|17|
||KWYC|Int32||XmlEnum("""KWYC""")|18|
||KWMC|Int32||XmlEnum("""KWMC""")|19|
||KMOC|Int32||XmlEnum("""KMOC""")|20|
||KWHC|Int32||XmlEnum("""KWHC""")|21|
||KWHO|Int32||XmlEnum("""KWHO""")|22|
||KWDC|Int32||XmlEnum("""KWDC""")|23|
||HUWG|Int32||XmlEnum("""HUWG""")|24|
||ENVO|Int32||XmlEnum("""ENVO""")|25|
||ENVC|Int32||XmlEnum("""ENVC""")|26|
||DMET|Int32||XmlEnum("""DMET""")|27|
||DAYS|Int32||XmlEnum("""DAYS""")|28|
||CBME|Int32||XmlEnum("""CBME""")|29|
||PUND|Int32||XmlEnum("""PUND""")|30|
||LITR|Int32||XmlEnum("""LITR""")|31|
||CELI|Int32||XmlEnum("""CELI""")|32|
||MILI|Int32||XmlEnum("""MILI""")|33|
||SQKI|Int32||XmlEnum("""SQKI""")|34|
||HECT|Int32||XmlEnum("""HECT""")|35|
||SCMT|Int32||XmlEnum("""SCMT""")|36|
||SMIL|Int32||XmlEnum("""SMIL""")|37|
||ARES|Int32||XmlEnum("""ARES""")|38|
||ACRE|Int32||XmlEnum("""ACRE""")|39|
||SQYA|Int32||XmlEnum("""SQYA""")|40|
||KMET|Int32||XmlEnum("""KMET""")|41|
||MMET|Int32||XmlEnum("""MMET""")|42|
||USGA|Int32||XmlEnum("""USGA""")|43|
||GBQA|Int32||XmlEnum("""GBQA""")|44|
||USPI|Int32||XmlEnum("""USPI""")|45|
||GBPI|Int32||XmlEnum("""GBPI""")|46|
||USOU|Int32||XmlEnum("""USOU""")|47|
||GBOU|Int32||XmlEnum("""GBOU""")|48|
||SQMI|Int32||XmlEnum("""SQMI""")|49|
||SQFO|Int32||XmlEnum("""SQFO""")|50|
||SQIN|Int32||XmlEnum("""SQIN""")|51|
||MILE|Int32||XmlEnum("""MILE""")|52|
||FOOT|Int32||XmlEnum("""FOOT""")|53|
||SMET|Int32||XmlEnum("""SMET""")|54|
||CMET|Int32||XmlEnum("""CMET""")|55|
||GRAM|Int32||XmlEnum("""GRAM""")|56|
||GBGA|Int32||XmlEnum("""GBGA""")|57|
||YARD|Int32||XmlEnum("""YARD""")|58|
||INCH|Int32||XmlEnum("""INCH""")|59|
||METR|Int32||XmlEnum("""METR""")|60|
||TONS|Int32||XmlEnum("""TONS""")|61|
||PIEC|Int32||XmlEnum("""PIEC""")|62|
||KILO|Int32||XmlEnum("""KILO""")|63|
||CLRT|Int32||XmlEnum("""CLRT""")|64|
||CEER|Int32||XmlEnum("""CEER""")|65|
||BUSL|Int32||XmlEnum("""BUSL""")|66|
||BDFT|Int32||XmlEnum("""BDFT""")|67|
||BCUF|Int32||XmlEnum("""BCUF""")|68|
||BARL|Int32||XmlEnum("""BARL""")|69|
||ACCY|Int32||XmlEnum("""ACCY""")|70|
||ALOW|Int32||XmlEnum("""ALOW""")|71|

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

