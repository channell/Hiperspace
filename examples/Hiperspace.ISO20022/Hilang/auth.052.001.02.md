# auth.052.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth052001.ActiveOrHistoricCurrencyAnd20DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth052001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityDairy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityForestry1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityGrain2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityLiveStock1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityOilSeed1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityOliveOil2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommodityPotato1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommoditySeafood1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AgriculturalCommoditySoft1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AmountAndDirection107 {
        + Sgn  : String
        + Amt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    }
    ISO20022.Auth052001.AmountAndDirection107 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAnd20DecimalAmount
    class ISO20022.Auth052001.AmountAndDirection53 {
        + Sgn  : String
        + Amt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth052001.AmountAndDirection53 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth052001.AmountHaircutMargin1 {
        + HrcutOrMrgn  : Decimal
        + Amt  : ISO20022.Auth052001.AmountAndDirection53
    }
    ISO20022.Auth052001.AmountHaircutMargin1 *-- ISO20022.Auth052001.AmountAndDirection53
    class ISO20022.Auth052001.AssetClassCommodity5Choice {
        + Othr  : ISO20022.Auth052001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth052001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth052001.AssetClassCommodityMultiCommodityExotic1
        + Infltn  : ISO20022.Auth052001.AssetClassCommodityInflation1
        + Plprpln  : ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice
        + Ppr  : ISO20022.Auth052001.AssetClassCommodityPaper3Choice
        + OthrC10  : ISO20022.Auth052001.AssetClassCommodityOtherC102Choice
        + Metl  : ISO20022.Auth052001.AssetClassCommodityMetal1Choice
        + IndstrlPdct  : ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice
        + Frght  : ISO20022.Auth052001.AssetClassCommodityFreight3Choice
        + Frtlzr  : ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice
        + Envttl  : ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice
        + Nrgy  : ISO20022.Auth052001.AssetClassCommodityEnergy2Choice
        + Agrcltrl  : ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice
    }
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityOther1
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityInflation1
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityPaper3Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityOtherC102Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityMetal1Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityFreight3Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityEnergy2Choice
    ISO20022.Auth052001.AssetClassCommodity5Choice *-- ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice
    class ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice {
        + Othr  : ISO20022.Auth052001.AgriculturalCommodityOther1
        + Grn  : ISO20022.Auth052001.AgriculturalCommodityGrain2
        + LiveStock  : ISO20022.Auth052001.AgriculturalCommodityLiveStock1
        + Sfd  : ISO20022.Auth052001.AgriculturalCommoditySeafood1
        + Frstry  : ISO20022.Auth052001.AgriculturalCommodityForestry1
        + Dairy  : ISO20022.Auth052001.AgriculturalCommodityDairy1
        + OlvOil  : ISO20022.Auth052001.AgriculturalCommodityOliveOil2
        + Ptt  : ISO20022.Auth052001.AgriculturalCommodityPotato1
        + Soft  : ISO20022.Auth052001.AgriculturalCommoditySoft1
        + GrnOilSeed  : ISO20022.Auth052001.AgriculturalCommodityOilSeed1
    }
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityGrain2
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityLiveStock1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommoditySeafood1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityForestry1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityDairy1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityOliveOil2
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityPotato1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommoditySoft1
    ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice *-- ISO20022.Auth052001.AgriculturalCommodityOilSeed1
    class ISO20022.Auth052001.AssetClassCommodityEnergy2Choice {
        + Othr  : ISO20022.Auth052001.EnergyCommodityOther1
        + Dstllts  : ISO20022.Auth052001.EnergyCommodityDistillates1
        + LghtEnd  : ISO20022.Auth052001.EnergyCommodityLightEnd1
        + RnwblNrgy  : ISO20022.Auth052001.EnergyCommodityRenewableEnergy1
        + IntrNrgy  : ISO20022.Auth052001.EnergyCommodityInterEnergy1
        + Coal  : ISO20022.Auth052001.EnergyCommodityCoal1
        + Oil  : ISO20022.Auth052001.EnergyCommodityOil2
        + NtrlGas  : ISO20022.Auth052001.EnergyCommodityNaturalGas2
        + Elctrcty  : ISO20022.Auth052001.EnergyCommodityElectricity1
    }
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityDistillates1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityLightEnd1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityRenewableEnergy1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityInterEnergy1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityCoal1
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityOil2
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityNaturalGas2
    ISO20022.Auth052001.AssetClassCommodityEnergy2Choice *-- ISO20022.Auth052001.EnergyCommodityElectricity1
    class ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice {
        + Othr  : ISO20022.Auth052001.EnvironmentCommodityOther1
        + CrbnRltd  : ISO20022.Auth052001.EnvironmentalCommodityCarbonRelated1
        + Wthr  : ISO20022.Auth052001.EnvironmentalCommodityWeather1
        + Emssns  : ISO20022.Auth052001.EnvironmentalCommodityEmission2
    }
    ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth052001.EnvironmentCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth052001.EnvironmentalCommodityCarbonRelated1
    ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth052001.EnvironmentalCommodityWeather1
    ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice *-- ISO20022.Auth052001.EnvironmentalCommodityEmission2
    class ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice {
        + Othr  : ISO20022.Auth052001.FertilizerCommodityOther1
        + UreaAndAmmnmNtrt  : ISO20022.Auth052001.FertilizerCommodityUreaAndAmmoniumNitrate1
        + Urea  : ISO20022.Auth052001.FertilizerCommodityUrea1
        + Slphr  : ISO20022.Auth052001.FertilizerCommoditySulphur1
        + Ptsh  : ISO20022.Auth052001.FertilizerCommodityPotash1
        + DmmnmPhspht  : ISO20022.Auth052001.FertilizerCommodityDiammoniumPhosphate1
        + Ammn  : ISO20022.Auth052001.FertilizerCommodityAmmonia1
    }
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityUreaAndAmmoniumNitrate1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityUrea1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommoditySulphur1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityPotash1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityDiammoniumPhosphate1
    ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice *-- ISO20022.Auth052001.FertilizerCommodityAmmonia1
    class ISO20022.Auth052001.AssetClassCommodityFreight3Choice {
        + Othr  : ISO20022.Auth052001.FreightCommodityOther1
        + CntnrShip  : ISO20022.Auth052001.FreightCommodityContainerShip1
        + Wet  : ISO20022.Auth052001.FreightCommodityWet2
        + Dry  : ISO20022.Auth052001.FreightCommodityDry2
    }
    ISO20022.Auth052001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth052001.FreightCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth052001.FreightCommodityContainerShip1
    ISO20022.Auth052001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth052001.FreightCommodityWet2
    ISO20022.Auth052001.AssetClassCommodityFreight3Choice *-- ISO20022.Auth052001.FreightCommodityDry2
    class ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice {
        + Manfctg  : ISO20022.Auth052001.IndustrialProductCommodityManufacturing1
        + Cnstrctn  : ISO20022.Auth052001.IndustrialProductCommodityConstruction1
    }
    ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth052001.IndustrialProductCommodityManufacturing1
    ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice *-- ISO20022.Auth052001.IndustrialProductCommodityConstruction1
    class ISO20022.Auth052001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AssetClassCommodityMetal1Choice {
        + Prcs  : ISO20022.Auth052001.MetalCommodityPrecious1
        + NonPrcs  : ISO20022.Auth052001.MetalCommodityNonPrecious1
    }
    ISO20022.Auth052001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth052001.MetalCommodityPrecious1
    ISO20022.Auth052001.AssetClassCommodityMetal1Choice *-- ISO20022.Auth052001.MetalCommodityNonPrecious1
    class ISO20022.Auth052001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth052001.AssetClassCommodityOtherC102Choice {
        + NonDlvrbl  : ISO20022.Auth052001.OtherC10CommodityNonDeliverable2
        + Dlvrbl  : ISO20022.Auth052001.OtherC10CommodityDeliverable2
    }
    ISO20022.Auth052001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth052001.OtherC10CommodityNonDeliverable2
    ISO20022.Auth052001.AssetClassCommodityOtherC102Choice *-- ISO20022.Auth052001.OtherC10CommodityDeliverable2
    class ISO20022.Auth052001.AssetClassCommodityPaper3Choice {
        + Othr  : ISO20022.Auth052001.PaperCommodityRecoveredPaper2
        + RcvrdPpr  : ISO20022.Auth052001.PaperCommodityRecoveredPaper1
        + Pulp  : ISO20022.Auth052001.PaperCommodityPulp1
        + Nwsprnt  : ISO20022.Auth052001.PaperCommodityNewsprint1
        + CntnrBrd  : ISO20022.Auth052001.PaperCommodityContainerBoard1
    }
    ISO20022.Auth052001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth052001.PaperCommodityRecoveredPaper2
    ISO20022.Auth052001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth052001.PaperCommodityRecoveredPaper1
    ISO20022.Auth052001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth052001.PaperCommodityPulp1
    ISO20022.Auth052001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth052001.PaperCommodityNewsprint1
    ISO20022.Auth052001.AssetClassCommodityPaper3Choice *-- ISO20022.Auth052001.PaperCommodityContainerBoard1
    class ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice {
        + Othr  : ISO20022.Auth052001.PolypropyleneCommodityOther1
        + Plstc  : ISO20022.Auth052001.PolypropyleneCommodityPlastic1
    }
    ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice *-- ISO20022.Auth052001.PolypropyleneCommodityOther1
    ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice *-- ISO20022.Auth052001.PolypropyleneCommodityPlastic1
    class ISO20022.Auth052001.AssetClassDetailedSubProductType10Code {
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
    class ISO20022.Auth052001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType29Code {
        OTHR = 1
        LAMP = 2
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType30Code {
        OTHR = 1
        MWHT = 2
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType31Code {
        OTHR = 1
        NBPG = 2
        TTFG = 3
        NCGG = 4
        LNGG = 5
        GASP = 6
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType32Code {
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
    class ISO20022.Auth052001.AssetClassDetailedSubProductType33Code {
        OTHR = 1
        DBCR = 2
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType34Code {
        OTHR = 1
        TNKR = 2
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth052001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth052001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth052001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth052001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth052001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth052001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth052001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth052001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth052001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth052001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth052001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth052001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth052001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth052001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth052001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType38Code {
        RCVP = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType47Code {
        DLVR = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType48Code {
        NDLV = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType49Code {
        OTHR = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth052001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth052001.BenchmarkCurveName10Choice {
        + Nm  : String
        + Indx  : String
    }
    class ISO20022.Auth052001.BenchmarkCurveName3Code {
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
    class ISO20022.Auth052001.Branch5Choice {
        + Ctry  : String
        + Id  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.Branch5Choice *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.Branch6Choice {
        + Ctry  : String
        + Id  : ISO20022.Auth052001.PartyIdentification236Choice
    }
    ISO20022.Auth052001.Branch6Choice *-- ISO20022.Auth052001.PartyIdentification236Choice
    class ISO20022.Auth052001.Cleared16Choice {
        + NonClrd  : String
        + Clrd  : ISO20022.Auth052001.ClearingPartyAndTime14
    }
    ISO20022.Auth052001.Cleared16Choice *-- ISO20022.Auth052001.ClearingPartyAndTime14
    class ISO20022.Auth052001.ClearingPartyAndTime14 {
        + PrtflCd  : String
        + RptTrckgNb  : String
        + ClrDtTm  : DateTime
        + CCP  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.ClearingPartyAndTime14 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.Collateral52 {
        + BsktIdr  : ISO20022.Auth052001.SecurityIdentification26Choice
        + NetXpsrCollstnInd  : String
        + AsstTp  : ISO20022.Auth052001.CollateralType21
        + CollValDt  : DateTime
    }
    ISO20022.Auth052001.Collateral52 *-- ISO20022.Auth052001.SecurityIdentification26Choice
    ISO20022.Auth052001.Collateral52 *-- ISO20022.Auth052001.CollateralType21
    class ISO20022.Auth052001.CollateralData35 {
        + BsktIdr  : ISO20022.Auth052001.SecurityIdentification26Choice
        + NetXpsrCollstnInd  : String
        + AsstTp  : ISO20022.Auth052001.CollateralType21
    }
    ISO20022.Auth052001.CollateralData35 *-- ISO20022.Auth052001.SecurityIdentification26Choice
    ISO20022.Auth052001.CollateralData35 *-- ISO20022.Auth052001.CollateralType21
    class ISO20022.Auth052001.CollateralDeliveryMethod1Code {
        TTCA = 1
        SIUR = 2
        SICA = 3
    }
    class ISO20022.Auth052001.CollateralFlag13Choice {
        + Uncollsd  : String
        + Collsd  : ISO20022.Auth052001.CollaterisedData12
    }
    ISO20022.Auth052001.CollateralFlag13Choice *-- ISO20022.Auth052001.CollaterisedData12
    class ISO20022.Auth052001.CollateralQualityType1Code {
        NOAP = 1
        NOTR = 2
        NIVG = 3
        INVG = 4
    }
    class ISO20022.Auth052001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Auth052001.CollateralType21 {
        + Cmmdty  : global::System.Collections.Generic.List~ISO20022.Auth052001.Commodity43~
        + Csh  : global::System.Collections.Generic.List~ISO20022.Auth052001.AmountHaircutMargin1~
        + Scty  : global::System.Collections.Generic.List~ISO20022.Auth052001.Security52~
    }
    ISO20022.Auth052001.CollateralType21 *-- ISO20022.Auth052001.Commodity43
    ISO20022.Auth052001.CollateralType21 *-- ISO20022.Auth052001.AmountHaircutMargin1
    ISO20022.Auth052001.CollateralType21 *-- ISO20022.Auth052001.Security52
    class ISO20022.Auth052001.CollaterisedData12 {
        + BsktIdr  : ISO20022.Auth052001.SecurityIdentification26Choice
        + NetXpsrCollstnInd  : String
        + AsstTp  : ISO20022.Auth052001.CollateralType21
        + CollValDt  : DateTime
    }
    ISO20022.Auth052001.CollaterisedData12 *-- ISO20022.Auth052001.SecurityIdentification26Choice
    ISO20022.Auth052001.CollaterisedData12 *-- ISO20022.Auth052001.CollateralType21
    class ISO20022.Auth052001.Commodity43 {
        + MktVal  : ISO20022.Auth052001.AmountAndDirection53
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + Qty  : ISO20022.Auth052001.Quantity17
        + Clssfctn  : ISO20022.Auth052001.AssetClassCommodity5Choice
    }
    ISO20022.Auth052001.Commodity43 *-- ISO20022.Auth052001.AmountAndDirection53
    ISO20022.Auth052001.Commodity43 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.Commodity43 *-- ISO20022.Auth052001.Quantity17
    ISO20022.Auth052001.Commodity43 *-- ISO20022.Auth052001.AssetClassCommodity5Choice
    class ISO20022.Auth052001.ContractTerm7Choice {
        + Fxd  : ISO20022.Auth052001.FixedOpenTermContract2
        + Opn  : ISO20022.Auth052001.FixedOpenTermContract2
    }
    ISO20022.Auth052001.ContractTerm7Choice *-- ISO20022.Auth052001.FixedOpenTermContract2
    ISO20022.Auth052001.ContractTerm7Choice *-- ISO20022.Auth052001.FixedOpenTermContract2
    class ISO20022.Auth052001.CounterpartyData88 {
        + CtrPty  : global::System.Collections.Generic.List~ISO20022.Auth052001.CounterpartyData89~
        + RptSubmitgNtty  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + RptgDtTm  : DateTime
    }
    ISO20022.Auth052001.CounterpartyData88 *-- ISO20022.Auth052001.CounterpartyData89
    ISO20022.Auth052001.CounterpartyData88 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.CounterpartyData89 {
        + OthrPtyData  : ISO20022.Auth052001.TransactionCounterpartyData11
        + NttyRspnsblForRpt  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth052001.CounterpartyIdentification12
        + RptgCtrPty  : ISO20022.Auth052001.CounterpartyIdentification11
    }
    ISO20022.Auth052001.CounterpartyData89 *-- ISO20022.Auth052001.TransactionCounterpartyData11
    ISO20022.Auth052001.CounterpartyData89 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.CounterpartyData89 *-- ISO20022.Auth052001.CounterpartyIdentification12
    ISO20022.Auth052001.CounterpartyData89 *-- ISO20022.Auth052001.CounterpartyIdentification11
    class ISO20022.Auth052001.CounterpartyIdentification11 {
        + Sd  : String
        + Brnch  : ISO20022.Auth052001.Branch5Choice
        + Ntr  : ISO20022.Auth052001.CounterpartyTradeNature7Choice
        + Id  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.CounterpartyIdentification11 *-- ISO20022.Auth052001.Branch5Choice
    ISO20022.Auth052001.CounterpartyIdentification11 *-- ISO20022.Auth052001.CounterpartyTradeNature7Choice
    ISO20022.Auth052001.CounterpartyIdentification11 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.CounterpartyIdentification12 {
        + CtryCd  : String
        + Brnch  : ISO20022.Auth052001.Branch6Choice
        + Id  : ISO20022.Auth052001.PartyIdentification236Choice
    }
    ISO20022.Auth052001.CounterpartyIdentification12 *-- ISO20022.Auth052001.Branch6Choice
    ISO20022.Auth052001.CounterpartyIdentification12 *-- ISO20022.Auth052001.PartyIdentification236Choice
    class ISO20022.Auth052001.CounterpartyTradeNature7Choice {
        + NFI  : global::System.Collections.Generic.List~ISO20022.Auth052001.FinancialPartyClassification2~
        + FI  : ISO20022.Auth052001.FinancialPartyClassification1
    }
    ISO20022.Auth052001.CounterpartyTradeNature7Choice *-- ISO20022.Auth052001.FinancialPartyClassification2
    ISO20022.Auth052001.CounterpartyTradeNature7Choice *-- ISO20022.Auth052001.FinancialPartyClassification1
    class ISO20022.Auth052001.EnergyCommodityCoal1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityDistillates1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityElectricity1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityInterEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityLightEnd1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityNaturalGas2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityOil2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnergyCommodityRenewableEnergy1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnvironmentCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnvironmentalCommodityCarbonRelated1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnvironmentalCommodityEmission2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.EnvironmentalCommodityWeather1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityAmmonia1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityDiammoniumPhosphate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityPotash1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommoditySulphur1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityUrea1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FertilizerCommodityUreaAndAmmoniumNitrate1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FinancialPartyClassification1 {
        + InvstmtFndClssfctn  : String
        + Clssfctn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth052001.FinancialPartyClassification2 {
        + InvstmtFndClssfctn  : String
        + Clssfctn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth052001.FinancialPartySectorType2Code {
        UCIT = 1
        REIN = 2
        INVF = 3
        ORPI = 4
        INUN = 5
        CDTI = 6
        CCPS = 7
        CSDS = 8
        AIFD = 9
    }
    class ISO20022.Auth052001.FixedOpenTermContract2 {
        + TermntnOptn  : String
        + MtrtyDt  : DateTime
    }
    class ISO20022.Auth052001.FixedRate11 {
        + DayCntBsis  : ISO20022.Auth052001.InterestComputationMethodFormat6Choice
        + Rate  : Decimal
    }
    ISO20022.Auth052001.FixedRate11 *-- ISO20022.Auth052001.InterestComputationMethodFormat6Choice
    class ISO20022.Auth052001.FloatingInterestRate22 {
        + DayCntBsis  : ISO20022.Auth052001.InterestComputationMethodFormat6Choice
        + RateAdjstmnt  : global::System.Collections.Generic.List~ISO20022.Auth052001.RateAdjustment1~
        + Sprd  : ISO20022.Auth052001.SecuritiesTransactionPrice18Choice
        + RstFrqcy  : ISO20022.Auth052001.InterestRateContractTerm2
        + PmtFrqcy  : ISO20022.Auth052001.InterestRateContractTerm2
        + Term  : ISO20022.Auth052001.InterestRateContractTerm2
        + RefRate  : ISO20022.Auth052001.BenchmarkCurveName10Choice
    }
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.InterestComputationMethodFormat6Choice
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.RateAdjustment1
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.SecuritiesTransactionPrice18Choice
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.InterestRateContractTerm2
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.InterestRateContractTerm2
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.InterestRateContractTerm2
    ISO20022.Auth052001.FloatingInterestRate22 *-- ISO20022.Auth052001.BenchmarkCurveName10Choice
    class ISO20022.Auth052001.FreightCommodityContainerShip1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FreightCommodityDry2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FreightCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FreightCommodityWet2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.FundType2Code {
        REIT = 1
        OTHR = 2
        MMFT = 3
        ETFT = 4
    }
    class ISO20022.Auth052001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth052001.IndustrialProductCommodityConstruction1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.IndustrialProductCommodityManufacturing1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.InterestComputationMethod1Code {
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
    class ISO20022.Auth052001.InterestComputationMethodFormat6Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth052001.InterestRate27Choice {
        + Fltg  : ISO20022.Auth052001.FloatingInterestRate22
        + Fxd  : ISO20022.Auth052001.FixedRate11
    }
    ISO20022.Auth052001.InterestRate27Choice *-- ISO20022.Auth052001.FloatingInterestRate22
    ISO20022.Auth052001.InterestRate27Choice *-- ISO20022.Auth052001.FixedRate11
    class ISO20022.Auth052001.InterestRate6 {
        + IntrstRate  : ISO20022.Auth052001.InterestRate27Choice
        + Amt  : ISO20022.Auth052001.AmountAndDirection53
    }
    ISO20022.Auth052001.InterestRate6 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.InterestRate6 *-- ISO20022.Auth052001.AmountAndDirection53
    class ISO20022.Auth052001.InterestRateContractTerm2 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth052001.LoanData113 {
        + MktVal  : ISO20022.Auth052001.AmountAndDirection53
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData113 *-- ISO20022.Auth052001.AmountAndDirection53
    class ISO20022.Auth052001.LoanData120 {
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + UnqTradIdr  : String
        + EvtDt  : DateTime
    }
    ISO20022.Auth052001.LoanData120 *-- ISO20022.Auth052001.MasterAgreement7
    class ISO20022.Auth052001.LoanData135 {
        + TermntnDt  : DateTime
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
        + IntrstRate  : ISO20022.Auth052001.InterestRate27Choice
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
        + GnlColl  : String
        + EarlstCallBckDt  : DateTime
        + MinNtcePrd  : Decimal
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData135 *-- ISO20022.Auth052001.PrincipalAmount3
    ISO20022.Auth052001.LoanData135 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData135 *-- ISO20022.Auth052001.ContractTerm7Choice
    ISO20022.Auth052001.LoanData135 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData135 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData136 {
        + TermntnDt  : DateTime
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
        + GnlColl  : String
        + MtrtyDt  : DateTime
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData136 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.LoanData136 *-- ISO20022.Auth052001.PrincipalAmount3
    ISO20022.Auth052001.LoanData136 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData136 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData137 {
        + TermntnDt  : DateTime
        + LndgFee  : Decimal
        + RbtRate  : ISO20022.Auth052001.InterestRate27Choice
        + LnVal  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + AsstTp  : ISO20022.Auth052001.SecurityCommodity9
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
        + GnlColl  : String
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.SecurityCommodity9
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.ContractTerm7Choice
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData137 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData138 {
        + TermntnDt  : DateTime
        + MrgnLnAttr  : global::System.Collections.Generic.List~ISO20022.Auth052001.InterestRate6~
        + ShrtMktValAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + OutsdngMrgnLnAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + CollDlvryMtd  : String
        + TradgVn  : String
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData138 *-- ISO20022.Auth052001.InterestRate6
    ISO20022.Auth052001.LoanData138 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.LoanData138 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth052001.LoanData139 {
        + TermntnDt  : DateTime
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
        + IntrstRate  : ISO20022.Auth052001.InterestRate27Choice
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
        + GnlColl  : String
        + EarlstCallBckDt  : DateTime
        + MinNtcePrd  : Decimal
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData139 *-- ISO20022.Auth052001.PrincipalAmount3
    ISO20022.Auth052001.LoanData139 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData139 *-- ISO20022.Auth052001.ContractTerm7Choice
    ISO20022.Auth052001.LoanData139 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData139 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData140 {
        + TermntnDt  : DateTime
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
        + GnlColl  : String
        + MtrtyDt  : DateTime
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData140 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.LoanData140 *-- ISO20022.Auth052001.PrincipalAmount3
    ISO20022.Auth052001.LoanData140 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData140 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData141 {
        + TermntnDt  : DateTime
        + LndgFee  : Decimal
        + RbtRate  : ISO20022.Auth052001.InterestRate27Choice
        + LnVal  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + AsstTp  : ISO20022.Auth052001.SecurityCommodity9
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
        + GnlColl  : String
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.SecurityCommodity9
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.ContractTerm7Choice
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData141 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData142 {
        + TermntnDt  : DateTime
        + MrgnLnAttr  : global::System.Collections.Generic.List~ISO20022.Auth052001.InterestRate6~
        + ShrtMktValAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + OutsdngMrgnLnAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + CollDlvryMtd  : String
        + TradgVn  : String
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData142 *-- ISO20022.Auth052001.InterestRate6
    ISO20022.Auth052001.LoanData142 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.LoanData142 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth052001.LoanData143 {
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + TermntnDt  : DateTime
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
        + IntrstRate  : ISO20022.Auth052001.InterestRate27Choice
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
        + GnlColl  : String
        + ValDt  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + ExctnDtTm  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.PrincipalAmount3
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.ContractTerm7Choice
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData143 *-- ISO20022.Auth052001.Cleared16Choice
    class ISO20022.Auth052001.LoanData144 {
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + GnlColl  : String
        + TermntnDt  : DateTime
        + ValDt  : DateTime
        + ExctnDtTm  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + EvtDt  : DateTime
        + UnqTradIdr  : String
        + MtrtyDt  : DateTime
        + PrncplAmt  : ISO20022.Auth052001.PrincipalAmount3
    }
    ISO20022.Auth052001.LoanData144 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.LoanData144 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData144 *-- ISO20022.Auth052001.Cleared16Choice
    ISO20022.Auth052001.LoanData144 *-- ISO20022.Auth052001.PrincipalAmount3
    class ISO20022.Auth052001.LoanData145 {
        + GnlColl  : String
        + TermntnDt  : DateTime
        + ValDt  : DateTime
        + ExctnDtTm  : DateTime
        + MstrAgrmt  : ISO20022.Auth052001.MasterAgreement7
        + TradgVn  : String
        + ClrSts  : ISO20022.Auth052001.Cleared16Choice
        + EvtDt  : DateTime
        + UnqTradIdr  : String
        + LndgFee  : Decimal
        + LnVal  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + RbtRate  : ISO20022.Auth052001.InterestRate27Choice
        + AsstTp  : ISO20022.Auth052001.SecurityCommodity9
        + Term  : global::System.Collections.Generic.List~ISO20022.Auth052001.ContractTerm7Choice~
        + CollDlvryMtd  : String
        + DlvryByVal  : String
    }
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.MasterAgreement7
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.Cleared16Choice
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.InterestRate27Choice
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.SecurityCommodity9
    ISO20022.Auth052001.LoanData145 *-- ISO20022.Auth052001.ContractTerm7Choice
    class ISO20022.Auth052001.LoanData86 {
        + TermntnDt  : DateTime
        + EvtDt  : DateTime
        + UnqTradIdr  : String
    }
    class ISO20022.Auth052001.MasterAgreement7 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth052001.AgreementType2Choice
    }
    ISO20022.Auth052001.MasterAgreement7 *-- ISO20022.Auth052001.AgreementType2Choice
    class ISO20022.Auth052001.MetalCommodityNonPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.MetalCommodityPrecious1 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth052001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth052001.GenericIdentification175
    }
    ISO20022.Auth052001.NaturalPersonIdentification2 *-- ISO20022.Auth052001.GenericIdentification175
    class ISO20022.Auth052001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth052001.NotAvailable1Code {
        NTAV = 1
    }
    class ISO20022.Auth052001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth052001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth052001.OrganisationIdentification15Choice *-- ISO20022.Auth052001.OrganisationIdentification38
    class ISO20022.Auth052001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth052001.GenericIdentification175
    }
    ISO20022.Auth052001.OrganisationIdentification38 *-- ISO20022.Auth052001.GenericIdentification175
    class ISO20022.Auth052001.OtherC10CommodityDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.OtherC10CommodityNonDeliverable2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PaperCommodityContainerBoard1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PaperCommodityNewsprint1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PaperCommodityPulp1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PaperCommodityRecoveredPaper1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PaperCommodityRecoveredPaper2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth052001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.PartyIdentification236Choice *-- ISO20022.Auth052001.NaturalPersonIdentification2
    ISO20022.Auth052001.PartyIdentification236Choice *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.PolypropyleneCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PolypropyleneCommodityPlastic1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth052001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth052001.PrincipalAmount3 {
        + MtrtyDtAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
        + ValDtAmt  : ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Auth052001.PrincipalAmount3 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Auth052001.PrincipalAmount3 *-- ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Auth052001.Quantity17 {
        + UnitOfMeasr  : String
        + Val  : Decimal
    }
    class ISO20022.Auth052001.QuantityNominalValue2Choice {
        + NmnlVal  : ISO20022.Auth052001.AmountAndDirection53
        + Qty  : Decimal
    }
    ISO20022.Auth052001.QuantityNominalValue2Choice *-- ISO20022.Auth052001.AmountAndDirection53
    class ISO20022.Auth052001.RateAdjustment1 {
        + AdjstmntDt  : DateTime
        + Rate  : Decimal
    }
    class ISO20022.Auth052001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth052001.RepoTerminationOption2Code {
        NOAP = 1
        ETSB = 2
        EGAE = 3
        EGRN = 4
    }
    class ISO20022.Auth052001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth052001.SecuritiesFinancingReportingTransactionReportV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + TradData  : ISO20022.Auth052001.TradeData40Choice
    }
    ISO20022.Auth052001.SecuritiesFinancingReportingTransactionReportV02 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.SecuritiesFinancingReportingTransactionReportV02 *-- ISO20022.Auth052001.TradeData40Choice
    class ISO20022.Auth052001.SecuritiesLendingType3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth052001.SecuritiesTransactionPrice18Choice {
        + BsisPts  : Decimal
        + Dcml  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth052001.AmountAndDirection107
    }
    ISO20022.Auth052001.SecuritiesTransactionPrice18Choice *-- ISO20022.Auth052001.AmountAndDirection107
    class ISO20022.Auth052001.SecuritiesTransactionPrice19Choice {
        + Othr  : ISO20022.Auth052001.SecuritiesTransactionPrice5
        + PdgPric  : String
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth052001.AmountAndDirection107
    }
    ISO20022.Auth052001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth052001.SecuritiesTransactionPrice5
    ISO20022.Auth052001.SecuritiesTransactionPrice19Choice *-- ISO20022.Auth052001.AmountAndDirection107
    class ISO20022.Auth052001.SecuritiesTransactionPrice5 {
        + Tp  : String
        + Val  : Decimal
    }
    class ISO20022.Auth052001.Security51 {
        + AvlblForCollReuse  : String
        + ExclsvArrgmnt  : String
        + Tp  : global::System.Collections.Generic.List~ISO20022.Auth052001.SecuritiesLendingType3Choice~
        + Issr  : ISO20022.Auth052001.SecurityIssuer4
        + Mtrty  : DateTime
        + Qlty  : String
        + MktVal  : ISO20022.Auth052001.AmountAndDirection53
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + QtyOrNmnlVal  : ISO20022.Auth052001.QuantityNominalValue2Choice
        + ClssfctnTp  : String
        + Id  : String
    }
    ISO20022.Auth052001.Security51 *-- ISO20022.Auth052001.SecuritiesLendingType3Choice
    ISO20022.Auth052001.Security51 *-- ISO20022.Auth052001.SecurityIssuer4
    ISO20022.Auth052001.Security51 *-- ISO20022.Auth052001.AmountAndDirection53
    ISO20022.Auth052001.Security51 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.Security51 *-- ISO20022.Auth052001.QuantityNominalValue2Choice
    class ISO20022.Auth052001.Security52 {
        + AvlblForCollReuse  : String
        + HrcutOrMrgn  : Decimal
        + ExclsvArrgmnt  : String
        + Tp  : global::System.Collections.Generic.List~ISO20022.Auth052001.SecuritiesLendingType3Choice~
        + Issr  : ISO20022.Auth052001.SecurityIssuer4
        + Mtrty  : DateTime
        + Qlty  : String
        + MktVal  : ISO20022.Auth052001.AmountAndDirection53
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + QtyOrNmnlVal  : ISO20022.Auth052001.QuantityNominalValue2Choice
        + ClssfctnTp  : String
        + Id  : String
    }
    ISO20022.Auth052001.Security52 *-- ISO20022.Auth052001.SecuritiesLendingType3Choice
    ISO20022.Auth052001.Security52 *-- ISO20022.Auth052001.SecurityIssuer4
    ISO20022.Auth052001.Security52 *-- ISO20022.Auth052001.AmountAndDirection53
    ISO20022.Auth052001.Security52 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.Security52 *-- ISO20022.Auth052001.QuantityNominalValue2Choice
    class ISO20022.Auth052001.Security55 {
        + HrcutOrMrgn  : Decimal
        + AvlblForCollReuse  : String
        + ExclsvArrgmnt  : String
        + Tp  : global::System.Collections.Generic.List~ISO20022.Auth052001.SecuritiesLendingType3Choice~
        + Issr  : ISO20022.Auth052001.SecurityIssuer4
        + Mtrty  : DateTime
        + Qlty  : String
        + MktVal  : ISO20022.Auth052001.AmountAndDirection53
        + UnitPric  : ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
        + QtyOrNmnlVal  : ISO20022.Auth052001.QuantityNominalValue2Choice
        + ClssfctnTp  : String
        + Id  : String
    }
    ISO20022.Auth052001.Security55 *-- ISO20022.Auth052001.SecuritiesLendingType3Choice
    ISO20022.Auth052001.Security55 *-- ISO20022.Auth052001.SecurityIssuer4
    ISO20022.Auth052001.Security55 *-- ISO20022.Auth052001.AmountAndDirection53
    ISO20022.Auth052001.Security55 *-- ISO20022.Auth052001.SecuritiesTransactionPrice19Choice
    ISO20022.Auth052001.Security55 *-- ISO20022.Auth052001.QuantityNominalValue2Choice
    class ISO20022.Auth052001.SecurityCommodity9 {
        + Cmmdty  : global::System.Collections.Generic.List~ISO20022.Auth052001.Commodity43~
        + Scty  : global::System.Collections.Generic.List~ISO20022.Auth052001.Security51~
    }
    ISO20022.Auth052001.SecurityCommodity9 *-- ISO20022.Auth052001.Commodity43
    ISO20022.Auth052001.SecurityCommodity9 *-- ISO20022.Auth052001.Security51
    class ISO20022.Auth052001.SecurityIdentification26Choice {
        + NotAvlbl  : String
        + Id  : String
    }
    class ISO20022.Auth052001.SecurityIssuer4 {
        + JursdctnCtry  : String
        + Id  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.SecurityIssuer4 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.SettlementParties34Choice {
        + IndrctPtcpt  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + CntrlSctiesDpstryPtcpt  : ISO20022.Auth052001.OrganisationIdentification15Choice
    }
    ISO20022.Auth052001.SettlementParties34Choice *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.SettlementParties34Choice *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    class ISO20022.Auth052001.SpecialCollateral1Code {
        SPEC = 1
        GENE = 2
    }
    class ISO20022.Auth052001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth052001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth052001.SupplementaryData1 *-- ISO20022.Auth052001.SupplementaryDataEnvelope1
    class ISO20022.Auth052001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth052001.TradeData40Choice {
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Auth052001.TradeReport22Choice~
        + DataSetActn  : String
    }
    ISO20022.Auth052001.TradeData40Choice *-- ISO20022.Auth052001.TradeReport22Choice
    class ISO20022.Auth052001.TradeError9 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + LnData  : ISO20022.Auth052001.LoanData86
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeError9 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeError9 *-- ISO20022.Auth052001.LoanData86
    ISO20022.Auth052001.TradeError9 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TradeNewTransaction13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + LvlTp  : String
        + CollData  : ISO20022.Auth052001.TransactionCollateralData18Choice
        + LnData  : ISO20022.Auth052001.TransactionLoanData30Choice
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeNewTransaction13 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeNewTransaction13 *-- ISO20022.Auth052001.TransactionCollateralData18Choice
    ISO20022.Auth052001.TradeNewTransaction13 *-- ISO20022.Auth052001.TransactionLoanData30Choice
    ISO20022.Auth052001.TradeNewTransaction13 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TradeReport22Choice {
        + ValtnUpd  : ISO20022.Auth052001.TradeValuationUpdate9
        + Crrctn  : ISO20022.Auth052001.TradeTransactionCorrection13
        + CollUpd  : ISO20022.Auth052001.TradeTransactionCollateralUpdate8
        + PosCmpnt  : ISO20022.Auth052001.TradeTransactionPositionComponent8
        + EarlyTermntn  : ISO20022.Auth052001.TradeError9
        + Err  : ISO20022.Auth052001.TradeError9
        + Mod  : ISO20022.Auth052001.TradeTransactionCorrection13
        + New  : ISO20022.Auth052001.TradeNewTransaction13
    }
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeValuationUpdate9
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeTransactionCorrection13
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeTransactionCollateralUpdate8
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeTransactionPositionComponent8
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeError9
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeError9
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeTransactionCorrection13
    ISO20022.Auth052001.TradeReport22Choice *-- ISO20022.Auth052001.TradeNewTransaction13
    class ISO20022.Auth052001.TradeTransactionCollateralUpdate8 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + CollData  : ISO20022.Auth052001.TransactionCollateralData18Choice
        + LnData  : ISO20022.Auth052001.TransactionLoanData26Choice
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeTransactionCollateralUpdate8 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeTransactionCollateralUpdate8 *-- ISO20022.Auth052001.TransactionCollateralData18Choice
    ISO20022.Auth052001.TradeTransactionCollateralUpdate8 *-- ISO20022.Auth052001.TransactionLoanData26Choice
    ISO20022.Auth052001.TradeTransactionCollateralUpdate8 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TradeTransactionCorrection13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + LvlTp  : String
        + CollData  : ISO20022.Auth052001.TransactionCollateralData18Choice
        + LnData  : ISO20022.Auth052001.TransactionLoanData31Choice
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeTransactionCorrection13 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeTransactionCorrection13 *-- ISO20022.Auth052001.TransactionCollateralData18Choice
    ISO20022.Auth052001.TradeTransactionCorrection13 *-- ISO20022.Auth052001.TransactionLoanData31Choice
    ISO20022.Auth052001.TradeTransactionCorrection13 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TradeTransactionPositionComponent8 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + LvlTp  : String
        + CollData  : ISO20022.Auth052001.CollateralData35
        + LnData  : ISO20022.Auth052001.TransactionLoanData32Choice
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeTransactionPositionComponent8 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeTransactionPositionComponent8 *-- ISO20022.Auth052001.CollateralData35
    ISO20022.Auth052001.TradeTransactionPositionComponent8 *-- ISO20022.Auth052001.TransactionLoanData32Choice
    ISO20022.Auth052001.TradeTransactionPositionComponent8 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TradeValuationUpdate9 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth052001.SupplementaryData1~
        + LnData  : ISO20022.Auth052001.LoanData113
        + CtrPtySpcfcData  : ISO20022.Auth052001.CounterpartyData88
        + TechRcrdId  : String
    }
    ISO20022.Auth052001.TradeValuationUpdate9 *-- ISO20022.Auth052001.SupplementaryData1
    ISO20022.Auth052001.TradeValuationUpdate9 *-- ISO20022.Auth052001.LoanData113
    ISO20022.Auth052001.TradeValuationUpdate9 *-- ISO20022.Auth052001.CounterpartyData88
    class ISO20022.Auth052001.TransactionCollateralData18Choice {
        + MrgnLndg  : global::System.Collections.Generic.List~ISO20022.Auth052001.Security55~
        + SctiesLndg  : ISO20022.Auth052001.CollateralFlag13Choice
        + BuySellBck  : ISO20022.Auth052001.Collateral52
        + RpTrad  : ISO20022.Auth052001.Collateral52
    }
    ISO20022.Auth052001.TransactionCollateralData18Choice *-- ISO20022.Auth052001.Security55
    ISO20022.Auth052001.TransactionCollateralData18Choice *-- ISO20022.Auth052001.CollateralFlag13Choice
    ISO20022.Auth052001.TransactionCollateralData18Choice *-- ISO20022.Auth052001.Collateral52
    ISO20022.Auth052001.TransactionCollateralData18Choice *-- ISO20022.Auth052001.Collateral52
    class ISO20022.Auth052001.TransactionCounterpartyData11 {
        + AgtLndr  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + SttlmPties  : ISO20022.Auth052001.SettlementParties34Choice
        + ClrMmb  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + Brkr  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + TrptyAgt  : ISO20022.Auth052001.OrganisationIdentification15Choice
        + Bnfcry  : ISO20022.Auth052001.PartyIdentification236Choice
    }
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.SettlementParties34Choice
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.OrganisationIdentification15Choice
    ISO20022.Auth052001.TransactionCounterpartyData11 *-- ISO20022.Auth052001.PartyIdentification236Choice
    class ISO20022.Auth052001.TransactionLoanData26Choice {
        + MrgnLndg  : ISO20022.Auth052001.LoanData120
        + SctiesLndg  : ISO20022.Auth052001.LoanData120
        + BuySellBck  : ISO20022.Auth052001.LoanData120
        + RpTrad  : ISO20022.Auth052001.LoanData120
    }
    ISO20022.Auth052001.TransactionLoanData26Choice *-- ISO20022.Auth052001.LoanData120
    ISO20022.Auth052001.TransactionLoanData26Choice *-- ISO20022.Auth052001.LoanData120
    ISO20022.Auth052001.TransactionLoanData26Choice *-- ISO20022.Auth052001.LoanData120
    ISO20022.Auth052001.TransactionLoanData26Choice *-- ISO20022.Auth052001.LoanData120
    class ISO20022.Auth052001.TransactionLoanData30Choice {
        + MrgnLndg  : ISO20022.Auth052001.LoanData138
        + SctiesLndg  : ISO20022.Auth052001.LoanData137
        + BuySellBck  : ISO20022.Auth052001.LoanData136
        + RpTrad  : ISO20022.Auth052001.LoanData135
    }
    ISO20022.Auth052001.TransactionLoanData30Choice *-- ISO20022.Auth052001.LoanData138
    ISO20022.Auth052001.TransactionLoanData30Choice *-- ISO20022.Auth052001.LoanData137
    ISO20022.Auth052001.TransactionLoanData30Choice *-- ISO20022.Auth052001.LoanData136
    ISO20022.Auth052001.TransactionLoanData30Choice *-- ISO20022.Auth052001.LoanData135
    class ISO20022.Auth052001.TransactionLoanData31Choice {
        + MrgnLndg  : ISO20022.Auth052001.LoanData142
        + SctiesLndg  : ISO20022.Auth052001.LoanData141
        + BuySellBck  : ISO20022.Auth052001.LoanData140
        + RpTrad  : ISO20022.Auth052001.LoanData139
    }
    ISO20022.Auth052001.TransactionLoanData31Choice *-- ISO20022.Auth052001.LoanData142
    ISO20022.Auth052001.TransactionLoanData31Choice *-- ISO20022.Auth052001.LoanData141
    ISO20022.Auth052001.TransactionLoanData31Choice *-- ISO20022.Auth052001.LoanData140
    ISO20022.Auth052001.TransactionLoanData31Choice *-- ISO20022.Auth052001.LoanData139
    class ISO20022.Auth052001.TransactionLoanData32Choice {
        + SctiesLndg  : ISO20022.Auth052001.LoanData145
        + BuySellBck  : ISO20022.Auth052001.LoanData144
        + RpTrad  : ISO20022.Auth052001.LoanData143
    }
    ISO20022.Auth052001.TransactionLoanData32Choice *-- ISO20022.Auth052001.LoanData145
    ISO20022.Auth052001.TransactionLoanData32Choice *-- ISO20022.Auth052001.LoanData144
    ISO20022.Auth052001.TransactionLoanData32Choice *-- ISO20022.Auth052001.LoanData143
    class ISO20022.Auth052001.UnitOfMeasure11Code {
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

## Value ISO20022.Auth052001.ActiveOrHistoricCurrencyAnd20DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth052001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth052001.AgriculturalCommodityDairy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityForestry1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityGrain2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityLiveStock1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityOilSeed1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityOliveOil2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommodityPotato1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommoditySeafood1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AgriculturalCommoditySoft1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AmountAndDirection107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAnd20DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth052001.AmountAndDirection53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth052001.AmountHaircutMargin1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutOrMrgn|Decimal||XmlElement()||
|+|Amt|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth052001.AssetClassCommodity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth052001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth052001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Infltn|ISO20022.Auth052001.AssetClassCommodityInflation1||XmlElement()||
|+|Plprpln|ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice||XmlElement()||
|+|Ppr|ISO20022.Auth052001.AssetClassCommodityPaper3Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth052001.AssetClassCommodityOtherC102Choice||XmlElement()||
|+|Metl|ISO20022.Auth052001.AssetClassCommodityMetal1Choice||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice||XmlElement()||
|+|Frght|ISO20022.Auth052001.AssetClassCommodityFreight3Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice||XmlElement()||
|+|Envttl|ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth052001.AssetClassCommodityEnergy2Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Infltn),validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Metl),validElement(IndstrlPdct),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Infltn,Plprpln,Ppr,OthrC10,Metl,IndstrlPdct,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth052001.AssetClassCommodityAgricultural5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.AgriculturalCommodityOther1||XmlElement()||
|+|Grn|ISO20022.Auth052001.AgriculturalCommodityGrain2||XmlElement()||
|+|LiveStock|ISO20022.Auth052001.AgriculturalCommodityLiveStock1||XmlElement()||
|+|Sfd|ISO20022.Auth052001.AgriculturalCommoditySeafood1||XmlElement()||
|+|Frstry|ISO20022.Auth052001.AgriculturalCommodityForestry1||XmlElement()||
|+|Dairy|ISO20022.Auth052001.AgriculturalCommodityDairy1||XmlElement()||
|+|OlvOil|ISO20022.Auth052001.AgriculturalCommodityOliveOil2||XmlElement()||
|+|Ptt|ISO20022.Auth052001.AgriculturalCommodityPotato1||XmlElement()||
|+|Soft|ISO20022.Auth052001.AgriculturalCommoditySoft1||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth052001.AgriculturalCommodityOilSeed1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Othr,Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth052001.AssetClassCommodityEnergy2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.EnergyCommodityOther1||XmlElement()||
|+|Dstllts|ISO20022.Auth052001.EnergyCommodityDistillates1||XmlElement()||
|+|LghtEnd|ISO20022.Auth052001.EnergyCommodityLightEnd1||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth052001.EnergyCommodityRenewableEnergy1||XmlElement()||
|+|IntrNrgy|ISO20022.Auth052001.EnergyCommodityInterEnergy1||XmlElement()||
|+|Coal|ISO20022.Auth052001.EnergyCommodityCoal1||XmlElement()||
|+|Oil|ISO20022.Auth052001.EnergyCommodityOil2||XmlElement()||
|+|NtrlGas|ISO20022.Auth052001.EnergyCommodityNaturalGas2||XmlElement()||
|+|Elctrcty|ISO20022.Auth052001.EnergyCommodityElectricity1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Othr,Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth052001.AssetClassCommodityEnvironmental2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.EnvironmentCommodityOther1||XmlElement()||
|+|CrbnRltd|ISO20022.Auth052001.EnvironmentalCommodityCarbonRelated1||XmlElement()||
|+|Wthr|ISO20022.Auth052001.EnvironmentalCommodityWeather1||XmlElement()||
|+|Emssns|ISO20022.Auth052001.EnvironmentalCommodityEmission2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(Othr,CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth052001.AssetClassCommodityFertilizer3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.FertilizerCommodityOther1||XmlElement()||
|+|UreaAndAmmnmNtrt|ISO20022.Auth052001.FertilizerCommodityUreaAndAmmoniumNitrate1||XmlElement()||
|+|Urea|ISO20022.Auth052001.FertilizerCommodityUrea1||XmlElement()||
|+|Slphr|ISO20022.Auth052001.FertilizerCommoditySulphur1||XmlElement()||
|+|Ptsh|ISO20022.Auth052001.FertilizerCommodityPotash1||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth052001.FertilizerCommodityDiammoniumPhosphate1||XmlElement()||
|+|Ammn|ISO20022.Auth052001.FertilizerCommodityAmmonia1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(Othr,UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth052001.AssetClassCommodityFreight3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.FreightCommodityOther1||XmlElement()||
|+|CntnrShip|ISO20022.Auth052001.FreightCommodityContainerShip1||XmlElement()||
|+|Wet|ISO20022.Auth052001.FreightCommodityWet2||XmlElement()||
|+|Dry|ISO20022.Auth052001.FreightCommodityDry2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(Othr,CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth052001.AssetClassCommodityIndustrialProduct1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth052001.IndustrialProductCommodityManufacturing1||XmlElement()||
|+|Cnstrctn|ISO20022.Auth052001.IndustrialProductCommodityConstruction1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth052001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AssetClassCommodityMetal1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth052001.MetalCommodityPrecious1||XmlElement()||
|+|NonPrcs|ISO20022.Auth052001.MetalCommodityNonPrecious1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth052001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.AssetClassCommodityOtherC102Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonDlvrbl|ISO20022.Auth052001.OtherC10CommodityNonDeliverable2||XmlElement()||
|+|Dlvrbl|ISO20022.Auth052001.OtherC10CommodityDeliverable2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonDlvrbl),validElement(Dlvrbl),validChoice(NonDlvrbl,Dlvrbl))|

---

## Value ISO20022.Auth052001.AssetClassCommodityPaper3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.PaperCommodityRecoveredPaper2||XmlElement()||
|+|RcvrdPpr|ISO20022.Auth052001.PaperCommodityRecoveredPaper1||XmlElement()||
|+|Pulp|ISO20022.Auth052001.PaperCommodityPulp1||XmlElement()||
|+|Nwsprnt|ISO20022.Auth052001.PaperCommodityNewsprint1||XmlElement()||
|+|CntnrBrd|ISO20022.Auth052001.PaperCommodityContainerBoard1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(Othr,RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth052001.AssetClassCommodityPolypropylene3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.PolypropyleneCommodityOther1||XmlElement()||
|+|Plstc|ISO20022.Auth052001.PolypropyleneCommodityPlastic1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Plstc),validChoice(Othr,Plstc))|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType10Code


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

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LAMP|Int32||XmlEnum("""LAMP""")|2|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MWHT|Int32||XmlEnum("""MWHT""")|2|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NBPG|Int32||XmlEnum("""NBPG""")|2|
||TTFG|Int32||XmlEnum("""TTFG""")|3|
||NCGG|Int32||XmlEnum("""NCGG""")|4|
||LNGG|Int32||XmlEnum("""LNGG""")|5|
||GASP|Int32||XmlEnum("""GASP""")|6|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType32Code


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

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DBCR|Int32||XmlEnum("""DBCR""")|2|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TNKR|Int32||XmlEnum("""TNKR""")|2|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth052001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth052001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType38Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCVP|Int32||XmlEnum("""RCVP""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType47Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVR|Int32||XmlEnum("""DLVR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType48Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NDLV|Int32||XmlEnum("""NDLV""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType49Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth052001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Value ISO20022.Auth052001.BenchmarkCurveName10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Nm,Indx))|

---

## Enum ISO20022.Auth052001.BenchmarkCurveName3Code


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

## Value ISO20022.Auth052001.Branch5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Ctry,Id))|

---

## Value ISO20022.Auth052001.Branch6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth052001.PartyIdentification236Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Ctry,Id))|

---

## Value ISO20022.Auth052001.Cleared16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrd|String||XmlElement()||
|+|Clrd|ISO20022.Auth052001.ClearingPartyAndTime14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clrd),validChoice(NonClrd,Clrd))|

---

## Value ISO20022.Auth052001.ClearingPartyAndTime14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflCd|String||XmlElement()||
|+|RptTrckgNb|String||XmlElement()||
|+|ClrDtTm|DateTime||XmlElement()||
|+|CCP|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCP))|

---

## Value ISO20022.Auth052001.Collateral52


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsktIdr|ISO20022.Auth052001.SecurityIdentification26Choice||XmlElement()||
|+|NetXpsrCollstnInd|String||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.CollateralType21||XmlElement()||
|+|CollValDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BsktIdr),validElement(AsstTp))|

---

## Value ISO20022.Auth052001.CollateralData35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsktIdr|ISO20022.Auth052001.SecurityIdentification26Choice||XmlElement()||
|+|NetXpsrCollstnInd|String||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.CollateralType21||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BsktIdr),validElement(AsstTp))|

---

## Enum ISO20022.Auth052001.CollateralDeliveryMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TTCA|Int32||XmlEnum("""TTCA""")|1|
||SIUR|Int32||XmlEnum("""SIUR""")|2|
||SICA|Int32||XmlEnum("""SICA""")|3|

---

## Value ISO20022.Auth052001.CollateralFlag13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Uncollsd|String||XmlElement()||
|+|Collsd|ISO20022.Auth052001.CollaterisedData12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Collsd),validChoice(Uncollsd,Collsd))|

---

## Enum ISO20022.Auth052001.CollateralQualityType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||NOTR|Int32||XmlEnum("""NOTR""")|2|
||NIVG|Int32||XmlEnum("""NIVG""")|3|
||INVG|Int32||XmlEnum("""INVG""")|4|

---

## Enum ISO20022.Auth052001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Value ISO20022.Auth052001.CollateralType21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmmdty|global::System.Collections.Generic.List<ISO20022.Auth052001.Commodity43>||XmlElement()||
|+|Csh|global::System.Collections.Generic.List<ISO20022.Auth052001.AmountHaircutMargin1>||XmlElement()||
|+|Scty|global::System.Collections.Generic.List<ISO20022.Auth052001.Security52>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmmdty""",Cmmdty),validElement(Cmmdty),validList("""Csh""",Csh),validElement(Csh),validList("""Scty""",Scty),validElement(Scty))|

---

## Value ISO20022.Auth052001.CollaterisedData12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsktIdr|ISO20022.Auth052001.SecurityIdentification26Choice||XmlElement()||
|+|NetXpsrCollstnInd|String||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.CollateralType21||XmlElement()||
|+|CollValDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BsktIdr),validElement(AsstTp))|

---

## Value ISO20022.Auth052001.Commodity43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|Qty|ISO20022.Auth052001.Quantity17||XmlElement()||
|+|Clssfctn|ISO20022.Auth052001.AssetClassCommodity5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktVal),validElement(UnitPric),validElement(Qty),validElement(Clssfctn))|

---

## Value ISO20022.Auth052001.ContractTerm7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fxd|ISO20022.Auth052001.FixedOpenTermContract2||XmlElement()||
|+|Opn|ISO20022.Auth052001.FixedOpenTermContract2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fxd),validElement(Opn),validChoice(Fxd,Opn))|

---

## Value ISO20022.Auth052001.CounterpartyData88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPty|global::System.Collections.Generic.List<ISO20022.Auth052001.CounterpartyData89>||XmlElement()||
|+|RptSubmitgNtty|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|RptgDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""CtrPty""",CtrPty),validList("""CtrPty""",CtrPty),validListMax("""CtrPty""",CtrPty,2),validElement(CtrPty),validElement(RptSubmitgNtty))|

---

## Value ISO20022.Auth052001.CounterpartyData89


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPtyData|ISO20022.Auth052001.TransactionCounterpartyData11||XmlElement()||
|+|NttyRspnsblForRpt|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth052001.CounterpartyIdentification12||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth052001.CounterpartyIdentification11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPtyData),validElement(NttyRspnsblForRpt),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth052001.CounterpartyIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sd|String||XmlElement()||
|+|Brnch|ISO20022.Auth052001.Branch5Choice||XmlElement()||
|+|Ntr|ISO20022.Auth052001.CounterpartyTradeNature7Choice||XmlElement()||
|+|Id|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brnch),validElement(Ntr),validElement(Id))|

---

## Value ISO20022.Auth052001.CounterpartyIdentification12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryCd|String||XmlElement()||
|+|Brnch|ISO20022.Auth052001.Branch6Choice||XmlElement()||
|+|Id|ISO20022.Auth052001.PartyIdentification236Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryCd""",CtryCd,"""[A-Z]{2,2}"""),validElement(Brnch),validElement(Id))|

---

## Value ISO20022.Auth052001.CounterpartyTradeNature7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NFI|global::System.Collections.Generic.List<ISO20022.Auth052001.FinancialPartyClassification2>||XmlElement()||
|+|FI|ISO20022.Auth052001.FinancialPartyClassification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NFI""",NFI),validList("""NFI""",NFI),validElement(NFI),validElement(FI),validChoice(NFI,FI))|

---

## Type ISO20022.Auth052001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgRptgTxRpt|ISO20022.Auth052001.SecuritiesFinancingReportingTransactionReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgRptgTxRpt))|

---

## Value ISO20022.Auth052001.EnergyCommodityCoal1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityDistillates1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityElectricity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityInterEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityLightEnd1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityNaturalGas2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityOil2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnergyCommodityRenewableEnergy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnvironmentCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnvironmentalCommodityCarbonRelated1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnvironmentalCommodityEmission2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.EnvironmentalCommodityWeather1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityAmmonia1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityDiammoniumPhosphate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityPotash1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommoditySulphur1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityUrea1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FertilizerCommodityUreaAndAmmoniumNitrate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FinancialPartyClassification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstmtFndClssfctn|String||XmlElement()||
|+|Clssfctn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Clssfctn""",Clssfctn))|

---

## Value ISO20022.Auth052001.FinancialPartyClassification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstmtFndClssfctn|String||XmlElement()||
|+|Clssfctn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Clssfctn""",Clssfctn),validPattern("""Clssfctn""",Clssfctn,"""[A-U]{1,1}"""))|

---

## Enum ISO20022.Auth052001.FinancialPartySectorType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCIT|Int32||XmlEnum("""UCIT""")|1|
||REIN|Int32||XmlEnum("""REIN""")|2|
||INVF|Int32||XmlEnum("""INVF""")|3|
||ORPI|Int32||XmlEnum("""ORPI""")|4|
||INUN|Int32||XmlEnum("""INUN""")|5|
||CDTI|Int32||XmlEnum("""CDTI""")|6|
||CCPS|Int32||XmlEnum("""CCPS""")|7|
||CSDS|Int32||XmlEnum("""CSDS""")|8|
||AIFD|Int32||XmlEnum("""AIFD""")|9|

---

## Value ISO20022.Auth052001.FixedOpenTermContract2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnOptn|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FixedRate11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DayCntBsis|ISO20022.Auth052001.InterestComputationMethodFormat6Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DayCntBsis))|

---

## Value ISO20022.Auth052001.FloatingInterestRate22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DayCntBsis|ISO20022.Auth052001.InterestComputationMethodFormat6Choice||XmlElement()||
|+|RateAdjstmnt|global::System.Collections.Generic.List<ISO20022.Auth052001.RateAdjustment1>||XmlElement()||
|+|Sprd|ISO20022.Auth052001.SecuritiesTransactionPrice18Choice||XmlElement()||
|+|RstFrqcy|ISO20022.Auth052001.InterestRateContractTerm2||XmlElement()||
|+|PmtFrqcy|ISO20022.Auth052001.InterestRateContractTerm2||XmlElement()||
|+|Term|ISO20022.Auth052001.InterestRateContractTerm2||XmlElement()||
|+|RefRate|ISO20022.Auth052001.BenchmarkCurveName10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DayCntBsis),validList("""RateAdjstmnt""",RateAdjstmnt),validElement(RateAdjstmnt),validElement(Sprd),validElement(RstFrqcy),validElement(PmtFrqcy),validElement(Term),validElement(RefRate))|

---

## Value ISO20022.Auth052001.FreightCommodityContainerShip1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FreightCommodityDry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FreightCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.FreightCommodityWet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth052001.FundType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REIT|Int32||XmlEnum("""REIT""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||MMFT|Int32||XmlEnum("""MMFT""")|3|
||ETFT|Int32||XmlEnum("""ETFT""")|4|

---

## Value ISO20022.Auth052001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.IndustrialProductCommodityConstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.IndustrialProductCommodityManufacturing1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth052001.InterestComputationMethod1Code


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

## Value ISO20022.Auth052001.InterestComputationMethodFormat6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth052001.InterestRate27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|ISO20022.Auth052001.FloatingInterestRate22||XmlElement()||
|+|Fxd|ISO20022.Auth052001.FixedRate11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fltg),validElement(Fxd),validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth052001.InterestRate6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrstRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|Amt|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstRate),validElement(Amt))|

---

## Value ISO20022.Auth052001.InterestRateContractTerm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.LoanData113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktVal))|

---

## Value ISO20022.Auth052001.LoanData120


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MstrAgrmt))|

---

## Value ISO20022.Auth052001.LoanData135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
|+|IntrstRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|EarlstCallBckDt|DateTime||XmlElement()||
|+|MinNtcePrd|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrncplAmt),validElement(IntrstRate),validList("""Term""",Term),validElement(Term),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitPric),validElement(PrncplAmt),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData137


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|LndgFee|Decimal||XmlElement()||
|+|RbtRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|LnVal|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.SecurityCommodity9||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RbtRate),validElement(LnVal),validElement(AsstTp),validList("""Term""",Term),validElement(Term),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData138


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|MrgnLnAttr|global::System.Collections.Generic.List<ISO20022.Auth052001.InterestRate6>||XmlElement()||
|+|ShrtMktValAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OutsdngMrgnLnAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MrgnLnAttr""",MrgnLnAttr),validElement(MrgnLnAttr),validElement(ShrtMktValAmt),validElement(OutsdngMrgnLnAmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Auth052001.LoanData139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
|+|IntrstRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|EarlstCallBckDt|DateTime||XmlElement()||
|+|MinNtcePrd|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrncplAmt),validElement(IntrstRate),validList("""Term""",Term),validElement(Term),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData140


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitPric),validElement(PrncplAmt),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData141


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|LndgFee|Decimal||XmlElement()||
|+|RbtRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|LnVal|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.SecurityCommodity9||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RbtRate),validElement(LnVal),validElement(AsstTp),validList("""Term""",Term),validElement(Term),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData142


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|MrgnLnAttr|global::System.Collections.Generic.List<ISO20022.Auth052001.InterestRate6>||XmlElement()||
|+|ShrtMktValAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OutsdngMrgnLnAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""MrgnLnAttr""",MrgnLnAttr),validElement(MrgnLnAttr),validElement(ShrtMktValAmt),validElement(OutsdngMrgnLnAmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Auth052001.LoanData143


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|TermntnDt|DateTime||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
|+|IntrstRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitPric),validElement(PrncplAmt),validElement(IntrstRate),validList("""Term""",Term),validElement(Term),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts))|

---

## Value ISO20022.Auth052001.LoanData144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|GnlColl|String||XmlElement()||
|+|TermntnDt|DateTime||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|PrncplAmt|ISO20022.Auth052001.PrincipalAmount3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitPric),validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts),validElement(PrncplAmt))|

---

## Value ISO20022.Auth052001.LoanData145


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GnlColl|String||XmlElement()||
|+|TermntnDt|DateTime||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|ExctnDtTm|DateTime||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth052001.MasterAgreement7||XmlElement()||
|+|TradgVn|String||XmlElement()||
|+|ClrSts|ISO20022.Auth052001.Cleared16Choice||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
|+|LndgFee|Decimal||XmlElement()||
|+|LnVal|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|RbtRate|ISO20022.Auth052001.InterestRate27Choice||XmlElement()||
|+|AsstTp|ISO20022.Auth052001.SecurityCommodity9||XmlElement()||
|+|Term|global::System.Collections.Generic.List<ISO20022.Auth052001.ContractTerm7Choice>||XmlElement()||
|+|CollDlvryMtd|String||XmlElement()||
|+|DlvryByVal|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MstrAgrmt),validPattern("""TradgVn""",TradgVn,"""[A-Z0-9]{4,4}"""),validElement(ClrSts),validElement(LnVal),validElement(RbtRate),validElement(AsstTp),validList("""Term""",Term),validElement(Term))|

---

## Value ISO20022.Auth052001.LoanData86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnDt|DateTime||XmlElement()||
|+|EvtDt|DateTime||XmlElement()||
|+|UnqTradIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.MasterAgreement7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth052001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth052001.MetalCommodityNonPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.MetalCommodityPrecious1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth052001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth052001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth052001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Enum ISO20022.Auth052001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Enum ISO20022.Auth052001.NotAvailable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NTAV|Int32||XmlEnum("""NTAV""")|1|

---

## Value ISO20022.Auth052001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth052001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth052001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth052001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth052001.OtherC10CommodityDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.OtherC10CommodityNonDeliverable2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PaperCommodityContainerBoard1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PaperCommodityNewsprint1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PaperCommodityPulp1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PaperCommodityRecoveredPaper1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PaperCommodityRecoveredPaper2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth052001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth052001.PolypropyleneCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.PolypropyleneCommodityPlastic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth052001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Value ISO20022.Auth052001.PrincipalAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtrtyDtAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValDtAmt|ISO20022.Auth052001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtrtyDtAmt),validElement(ValDtAmt))|

---

## Value ISO20022.Auth052001.Quantity17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.QuantityNominalValue2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmnlVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmnlVal),validChoice(NmnlVal,Qty))|

---

## Value ISO20022.Auth052001.RateAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdjstmntDt|DateTime||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth052001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Enum ISO20022.Auth052001.RepoTerminationOption2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||ETSB|Int32||XmlEnum("""ETSB""")|2|
||EGAE|Int32||XmlEnum("""EGAE""")|3|
||EGRN|Int32||XmlEnum("""EGRN""")|4|

---

## Enum ISO20022.Auth052001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Aspect ISO20022.Auth052001.SecuritiesFinancingReportingTransactionReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth052001.TradeData40Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData))|

---

## Value ISO20022.Auth052001.SecuritiesLendingType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth052001.SecuritiesTransactionPrice18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPts|Decimal||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth052001.AmountAndDirection107||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPts,Dcml,Pctg,MntryVal))|

---

## Value ISO20022.Auth052001.SecuritiesTransactionPrice19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth052001.SecuritiesTransactionPrice5||XmlElement()||
|+|PdgPric|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth052001.AmountAndDirection107||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,PdgPric,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth052001.SecuritiesTransactionPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.Security51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblForCollReuse|String||XmlElement()||
|+|ExclsvArrgmnt|String||XmlElement()||
|+|Tp|global::System.Collections.Generic.List<ISO20022.Auth052001.SecuritiesLendingType3Choice>||XmlElement()||
|+|Issr|ISO20022.Auth052001.SecurityIssuer4||XmlElement()||
|+|Mtrty|DateTime||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|MktVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|QtyOrNmnlVal|ISO20022.Auth052001.QuantityNominalValue2Choice||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tp""",Tp),validElement(Tp),validElement(Issr),validElement(MktVal),validElement(UnitPric),validElement(QtyOrNmnlVal),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth052001.Security52


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlblForCollReuse|String||XmlElement()||
|+|HrcutOrMrgn|Decimal||XmlElement()||
|+|ExclsvArrgmnt|String||XmlElement()||
|+|Tp|global::System.Collections.Generic.List<ISO20022.Auth052001.SecuritiesLendingType3Choice>||XmlElement()||
|+|Issr|ISO20022.Auth052001.SecurityIssuer4||XmlElement()||
|+|Mtrty|DateTime||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|MktVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|QtyOrNmnlVal|ISO20022.Auth052001.QuantityNominalValue2Choice||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tp""",Tp),validElement(Tp),validElement(Issr),validElement(MktVal),validElement(UnitPric),validElement(QtyOrNmnlVal),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth052001.Security55


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutOrMrgn|Decimal||XmlElement()||
|+|AvlblForCollReuse|String||XmlElement()||
|+|ExclsvArrgmnt|String||XmlElement()||
|+|Tp|global::System.Collections.Generic.List<ISO20022.Auth052001.SecuritiesLendingType3Choice>||XmlElement()||
|+|Issr|ISO20022.Auth052001.SecurityIssuer4||XmlElement()||
|+|Mtrty|DateTime||XmlElement()||
|+|Qlty|String||XmlElement()||
|+|MktVal|ISO20022.Auth052001.AmountAndDirection53||XmlElement()||
|+|UnitPric|ISO20022.Auth052001.SecuritiesTransactionPrice19Choice||XmlElement()||
|+|QtyOrNmnlVal|ISO20022.Auth052001.QuantityNominalValue2Choice||XmlElement()||
|+|ClssfctnTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tp""",Tp),validElement(Tp),validElement(Issr),validElement(MktVal),validElement(UnitPric),validElement(QtyOrNmnlVal),validPattern("""ClssfctnTp""",ClssfctnTp,"""[A-Z]{6,6}"""),validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth052001.SecurityCommodity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmmdty|global::System.Collections.Generic.List<ISO20022.Auth052001.Commodity43>||XmlElement()||
|+|Scty|global::System.Collections.Generic.List<ISO20022.Auth052001.Security51>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmmdty""",Cmmdty),validElement(Cmmdty),validList("""Scty""",Scty),validElement(Scty))|

---

## Value ISO20022.Auth052001.SecurityIdentification26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotAvlbl|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(NotAvlbl,Id))|

---

## Value ISO20022.Auth052001.SecurityIssuer4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|JursdctnCtry|String||XmlElement()||
|+|Id|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""JursdctnCtry""",JursdctnCtry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth052001.SettlementParties34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndrctPtcpt|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|CntrlSctiesDpstryPtcpt|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndrctPtcpt),validElement(CntrlSctiesDpstryPtcpt),validChoice(IndrctPtcpt,CntrlSctiesDpstryPtcpt))|

---

## Enum ISO20022.Auth052001.SpecialCollateral1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPEC|Int32||XmlEnum("""SPEC""")|1|
||GENE|Int32||XmlEnum("""GENE""")|2|

---

## Value ISO20022.Auth052001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth052001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth052001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth052001.TradeData40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Auth052001.TradeReport22Choice>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth052001.TradeError9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|LnData|ISO20022.Auth052001.LoanData86||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TradeNewTransaction13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|LvlTp|String||XmlElement()||
|+|CollData|ISO20022.Auth052001.TransactionCollateralData18Choice||XmlElement()||
|+|LnData|ISO20022.Auth052001.TransactionLoanData30Choice||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TradeReport22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValtnUpd|ISO20022.Auth052001.TradeValuationUpdate9||XmlElement()||
|+|Crrctn|ISO20022.Auth052001.TradeTransactionCorrection13||XmlElement()||
|+|CollUpd|ISO20022.Auth052001.TradeTransactionCollateralUpdate8||XmlElement()||
|+|PosCmpnt|ISO20022.Auth052001.TradeTransactionPositionComponent8||XmlElement()||
|+|EarlyTermntn|ISO20022.Auth052001.TradeError9||XmlElement()||
|+|Err|ISO20022.Auth052001.TradeError9||XmlElement()||
|+|Mod|ISO20022.Auth052001.TradeTransactionCorrection13||XmlElement()||
|+|New|ISO20022.Auth052001.TradeNewTransaction13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnUpd),validElement(Crrctn),validElement(CollUpd),validElement(PosCmpnt),validElement(EarlyTermntn),validElement(Err),validElement(Mod),validElement(New),validChoice(ValtnUpd,Crrctn,CollUpd,PosCmpnt,EarlyTermntn,Err,Mod,New))|

---

## Value ISO20022.Auth052001.TradeTransactionCollateralUpdate8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|CollData|ISO20022.Auth052001.TransactionCollateralData18Choice||XmlElement()||
|+|LnData|ISO20022.Auth052001.TransactionLoanData26Choice||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TradeTransactionCorrection13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|LvlTp|String||XmlElement()||
|+|CollData|ISO20022.Auth052001.TransactionCollateralData18Choice||XmlElement()||
|+|LnData|ISO20022.Auth052001.TransactionLoanData31Choice||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TradeTransactionPositionComponent8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|LvlTp|String||XmlElement()||
|+|CollData|ISO20022.Auth052001.CollateralData35||XmlElement()||
|+|LnData|ISO20022.Auth052001.TransactionLoanData32Choice||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TradeValuationUpdate9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth052001.SupplementaryData1>||XmlElement()||
|+|LnData|ISO20022.Auth052001.LoanData113||XmlElement()||
|+|CtrPtySpcfcData|ISO20022.Auth052001.CounterpartyData88||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LnData),validElement(CtrPtySpcfcData))|

---

## Value ISO20022.Auth052001.TransactionCollateralData18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnLndg|global::System.Collections.Generic.List<ISO20022.Auth052001.Security55>||XmlElement()||
|+|SctiesLndg|ISO20022.Auth052001.CollateralFlag13Choice||XmlElement()||
|+|BuySellBck|ISO20022.Auth052001.Collateral52||XmlElement()||
|+|RpTrad|ISO20022.Auth052001.Collateral52||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""MrgnLndg""",MrgnLndg),validList("""MrgnLndg""",MrgnLndg),validElement(MrgnLndg),validElement(SctiesLndg),validElement(BuySellBck),validElement(RpTrad),validChoice(MrgnLndg,SctiesLndg,BuySellBck,RpTrad))|

---

## Value ISO20022.Auth052001.TransactionCounterpartyData11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtLndr|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|SttlmPties|ISO20022.Auth052001.SettlementParties34Choice||XmlElement()||
|+|ClrMmb|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|Brkr|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|TrptyAgt|ISO20022.Auth052001.OrganisationIdentification15Choice||XmlElement()||
|+|Bnfcry|ISO20022.Auth052001.PartyIdentification236Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtLndr),validElement(SttlmPties),validElement(ClrMmb),validElement(Brkr),validElement(TrptyAgt),validElement(Bnfcry))|

---

## Value ISO20022.Auth052001.TransactionLoanData26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnLndg|ISO20022.Auth052001.LoanData120||XmlElement()||
|+|SctiesLndg|ISO20022.Auth052001.LoanData120||XmlElement()||
|+|BuySellBck|ISO20022.Auth052001.LoanData120||XmlElement()||
|+|RpTrad|ISO20022.Auth052001.LoanData120||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnLndg),validElement(SctiesLndg),validElement(BuySellBck),validElement(RpTrad),validChoice(MrgnLndg,SctiesLndg,BuySellBck,RpTrad))|

---

## Value ISO20022.Auth052001.TransactionLoanData30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnLndg|ISO20022.Auth052001.LoanData138||XmlElement()||
|+|SctiesLndg|ISO20022.Auth052001.LoanData137||XmlElement()||
|+|BuySellBck|ISO20022.Auth052001.LoanData136||XmlElement()||
|+|RpTrad|ISO20022.Auth052001.LoanData135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnLndg),validElement(SctiesLndg),validElement(BuySellBck),validElement(RpTrad),validChoice(MrgnLndg,SctiesLndg,BuySellBck,RpTrad))|

---

## Value ISO20022.Auth052001.TransactionLoanData31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnLndg|ISO20022.Auth052001.LoanData142||XmlElement()||
|+|SctiesLndg|ISO20022.Auth052001.LoanData141||XmlElement()||
|+|BuySellBck|ISO20022.Auth052001.LoanData140||XmlElement()||
|+|RpTrad|ISO20022.Auth052001.LoanData139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnLndg),validElement(SctiesLndg),validElement(BuySellBck),validElement(RpTrad),validChoice(MrgnLndg,SctiesLndg,BuySellBck,RpTrad))|

---

## Value ISO20022.Auth052001.TransactionLoanData32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesLndg|ISO20022.Auth052001.LoanData145||XmlElement()||
|+|BuySellBck|ISO20022.Auth052001.LoanData144||XmlElement()||
|+|RpTrad|ISO20022.Auth052001.LoanData143||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesLndg),validElement(BuySellBck),validElement(RpTrad),validChoice(SctiesLndg,BuySellBck,RpTrad))|

---

## Enum ISO20022.Auth052001.UnitOfMeasure11Code


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

