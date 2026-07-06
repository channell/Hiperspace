# auth.091.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth091001.AgreementType2Choice {
        + Prtry  : String
        + Tp  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityDairy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityForestry2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityGrain3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityLiveStock2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityOilSeed2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityOliveOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommodityPotato2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommoditySeafood2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AgriculturalCommoditySoft2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AmountAndDirection106 {
        + Sgn  : String
        + Amt  : ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth091001.AmountAndDirection106 *-- ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth091001.AssetClassCommodity6Choice {
        + Plprpln  : ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice
        + Ppr  : ISO20022.Auth091001.AssetClassCommodityPaper4Choice
        + OthrC10  : ISO20022.Auth091001.AssetClassCommodityC10Other1
        + Othr  : ISO20022.Auth091001.AssetClassCommodityOther1
        + OffclEcnmcSttstcs  : ISO20022.Auth091001.AssetClassCommodityOfficialEconomicStatistics1
        + MultiCmmdtyExtc  : ISO20022.Auth091001.AssetClassCommodityMultiCommodityExotic1
        + Metl  : ISO20022.Auth091001.AssetClassCommodityMetal2Choice
        + Infltn  : ISO20022.Auth091001.AssetClassCommodityInflation1
        + IndstrlPdct  : ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice
        + Indx  : ISO20022.Auth091001.AssetClassCommodityIndex1
        + Frght  : ISO20022.Auth091001.AssetClassCommodityFreight4Choice
        + Frtlzr  : ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice
        + Envttl  : ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice
        + Nrgy  : ISO20022.Auth091001.AssetClassCommodityEnergy3Choice
        + Agrcltrl  : ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice
    }
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityPaper4Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityC10Other1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityOther1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityOfficialEconomicStatistics1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityMultiCommodityExotic1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityMetal2Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityInflation1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityIndex1
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityFreight4Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityEnergy3Choice
    ISO20022.Auth091001.AssetClassCommodity6Choice *-- ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice
    class ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice {
        + Othr  : ISO20022.Auth091001.AgriculturalCommodityOther2
        + Grn  : ISO20022.Auth091001.AgriculturalCommodityGrain3
        + LiveStock  : ISO20022.Auth091001.AgriculturalCommodityLiveStock2
        + Sfd  : ISO20022.Auth091001.AgriculturalCommoditySeafood2
        + Frstry  : ISO20022.Auth091001.AgriculturalCommodityForestry2
        + Dairy  : ISO20022.Auth091001.AgriculturalCommodityDairy2
        + OlvOil  : ISO20022.Auth091001.AgriculturalCommodityOliveOil3
        + Ptt  : ISO20022.Auth091001.AgriculturalCommodityPotato2
        + Soft  : ISO20022.Auth091001.AgriculturalCommoditySoft2
        + GrnOilSeed  : ISO20022.Auth091001.AgriculturalCommodityOilSeed2
    }
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityGrain3
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityLiveStock2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommoditySeafood2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityForestry2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityDairy2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityOliveOil3
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityPotato2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommoditySoft2
    ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice *-- ISO20022.Auth091001.AgriculturalCommodityOilSeed2
    class ISO20022.Auth091001.AssetClassCommodityC10Other1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityEnergy3Choice {
        + Othr  : ISO20022.Auth091001.EnergyCommodityOther2
        + Dstllts  : ISO20022.Auth091001.EnergyCommodityDistillates2
        + LghtEnd  : ISO20022.Auth091001.EnergyCommodityLightEnd2
        + RnwblNrgy  : ISO20022.Auth091001.EnergyCommodityRenewableEnergy2
        + IntrNrgy  : ISO20022.Auth091001.EnergyCommodityInterEnergy2
        + Coal  : ISO20022.Auth091001.EnergyCommodityCoal2
        + Oil  : ISO20022.Auth091001.EnergyCommodityOil3
        + NtrlGas  : ISO20022.Auth091001.EnergyCommodityNaturalGas3
        + Elctrcty  : ISO20022.Auth091001.EnergyCommodityElectricity2
    }
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityDistillates2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityLightEnd2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityRenewableEnergy2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityInterEnergy2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityCoal2
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityOil3
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityNaturalGas3
    ISO20022.Auth091001.AssetClassCommodityEnergy3Choice *-- ISO20022.Auth091001.EnergyCommodityElectricity2
    class ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice {
        + Othr  : ISO20022.Auth091001.EnvironmentCommodityOther2
        + CrbnRltd  : ISO20022.Auth091001.EnvironmentalCommodityCarbonRelated2
        + Wthr  : ISO20022.Auth091001.EnvironmentalCommodityWeather2
        + Emssns  : ISO20022.Auth091001.EnvironmentalCommodityEmission3
    }
    ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth091001.EnvironmentCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth091001.EnvironmentalCommodityCarbonRelated2
    ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth091001.EnvironmentalCommodityWeather2
    ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice *-- ISO20022.Auth091001.EnvironmentalCommodityEmission3
    class ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice {
        + Othr  : ISO20022.Auth091001.FertilizerCommodityOther2
        + UreaAndAmmnmNtrt  : ISO20022.Auth091001.FertilizerCommodityUreaAndAmmoniumNitrate2
        + Urea  : ISO20022.Auth091001.FertilizerCommodityUrea2
        + Slphr  : ISO20022.Auth091001.FertilizerCommoditySulphur2
        + Ptsh  : ISO20022.Auth091001.FertilizerCommodityPotash2
        + DmmnmPhspht  : ISO20022.Auth091001.FertilizerCommodityDiammoniumPhosphate2
        + Ammn  : ISO20022.Auth091001.FertilizerCommodityAmmonia2
    }
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityUreaAndAmmoniumNitrate2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityUrea2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommoditySulphur2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityPotash2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityDiammoniumPhosphate2
    ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice *-- ISO20022.Auth091001.FertilizerCommodityAmmonia2
    class ISO20022.Auth091001.AssetClassCommodityFreight4Choice {
        + Othr  : ISO20022.Auth091001.FreightCommodityOther2
        + CntnrShip  : ISO20022.Auth091001.FreightCommodityContainerShip2
        + Wet  : ISO20022.Auth091001.FreightCommodityWet3
        + Dry  : ISO20022.Auth091001.FreightCommodityDry3
    }
    ISO20022.Auth091001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth091001.FreightCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth091001.FreightCommodityContainerShip2
    ISO20022.Auth091001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth091001.FreightCommodityWet3
    ISO20022.Auth091001.AssetClassCommodityFreight4Choice *-- ISO20022.Auth091001.FreightCommodityDry3
    class ISO20022.Auth091001.AssetClassCommodityIndex1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice {
        + Manfctg  : ISO20022.Auth091001.IndustrialProductCommodityManufacturing2
        + Cnstrctn  : ISO20022.Auth091001.IndustrialProductCommodityConstruction2
    }
    ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth091001.IndustrialProductCommodityManufacturing2
    ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice *-- ISO20022.Auth091001.IndustrialProductCommodityConstruction2
    class ISO20022.Auth091001.AssetClassCommodityInflation1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityMetal2Choice {
        + Prcs  : ISO20022.Auth091001.MetalCommodityPrecious2
        + NonPrcs  : ISO20022.Auth091001.MetalCommodityNonPrecious2
    }
    ISO20022.Auth091001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth091001.MetalCommodityPrecious2
    ISO20022.Auth091001.AssetClassCommodityMetal2Choice *-- ISO20022.Auth091001.MetalCommodityNonPrecious2
    class ISO20022.Auth091001.AssetClassCommodityMultiCommodityExotic1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityOfficialEconomicStatistics1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityOther1 {
        + BasePdct  : String
    }
    class ISO20022.Auth091001.AssetClassCommodityPaper4Choice {
        + Othr  : ISO20022.Auth091001.PaperCommodityOther1
        + RcvrdPpr  : ISO20022.Auth091001.PaperCommodityOther1
        + Pulp  : ISO20022.Auth091001.PaperCommodityPulp2
        + Nwsprnt  : ISO20022.Auth091001.PaperCommodityNewsprint2
        + CntnrBrd  : ISO20022.Auth091001.PaperCommodityContainerBoard2
    }
    ISO20022.Auth091001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth091001.PaperCommodityOther1
    ISO20022.Auth091001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth091001.PaperCommodityOther1
    ISO20022.Auth091001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth091001.PaperCommodityPulp2
    ISO20022.Auth091001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth091001.PaperCommodityNewsprint2
    ISO20022.Auth091001.AssetClassCommodityPaper4Choice *-- ISO20022.Auth091001.PaperCommodityContainerBoard2
    class ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice {
        + Othr  : ISO20022.Auth091001.PolypropyleneCommodityOther2
        + Plstc  : ISO20022.Auth091001.PolypropyleneCommodityPlastic2
    }
    ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth091001.PolypropyleneCommodityOther2
    ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice *-- ISO20022.Auth091001.PolypropyleneCommodityPlastic2
    class ISO20022.Auth091001.AssetClassDetailedSubProductType10Code {
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
    class ISO20022.Auth091001.AssetClassDetailedSubProductType11Code {
        SLVR = 1
        PTNM = 2
        PLDM = 3
        OTHR = 4
        GOLD = 5
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType1Code {
        RICE = 1
        CORN = 2
        OTHR = 3
        RPSD = 4
        SOYB = 5
        FWHT = 6
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType29Code {
        OTHR = 1
        LAMP = 2
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType2Code {
        OTHR = 1
        WHSG = 2
        BRWN = 3
        CCOA = 4
        ROBU = 5
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType30Code {
        OTHR = 1
        MWHT = 2
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType31Code {
        OTHR = 1
        NBPG = 2
        TTFG = 3
        NCGG = 4
        LNGG = 5
        GASP = 6
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType32Code {
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
    class ISO20022.Auth091001.AssetClassDetailedSubProductType33Code {
        OTHR = 1
        DBCR = 2
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType34Code {
        OTHR = 1
        TNKR = 2
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType5Code {
        OTHR = 1
        OFFP = 2
        PKLD = 3
        FITR = 4
        BSLD = 5
    }
    class ISO20022.Auth091001.AssetClassDetailedSubProductType8Code {
        OTHR = 1
        EUAA = 2
        EUAE = 3
        ERUE = 4
        CERE = 5
    }
    class ISO20022.Auth091001.AssetClassProductType11Code {
        OTHC = 1
    }
    class ISO20022.Auth091001.AssetClassProductType12Code {
        INFL = 1
    }
    class ISO20022.Auth091001.AssetClassProductType13Code {
        MCEX = 1
    }
    class ISO20022.Auth091001.AssetClassProductType14Code {
        OEST = 1
    }
    class ISO20022.Auth091001.AssetClassProductType15Code {
        OTHR = 1
    }
    class ISO20022.Auth091001.AssetClassProductType16Code {
        INDX = 1
    }
    class ISO20022.Auth091001.AssetClassProductType1Code {
        AGRI = 1
    }
    class ISO20022.Auth091001.AssetClassProductType2Code {
        NRGY = 1
    }
    class ISO20022.Auth091001.AssetClassProductType3Code {
        ENVR = 1
    }
    class ISO20022.Auth091001.AssetClassProductType4Code {
        FRGT = 1
    }
    class ISO20022.Auth091001.AssetClassProductType5Code {
        FRTL = 1
    }
    class ISO20022.Auth091001.AssetClassProductType6Code {
        INDP = 1
    }
    class ISO20022.Auth091001.AssetClassProductType7Code {
        METL = 1
    }
    class ISO20022.Auth091001.AssetClassProductType8Code {
        PAPR = 1
    }
    class ISO20022.Auth091001.AssetClassProductType9Code {
        POLY = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType10Code {
        EMIS = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType15Code {
        NPRM = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType16Code {
        PRME = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType18Code {
        PLST = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType1Code {
        GROS = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType20Code {
        DIRY = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType21Code {
        FRST = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType22Code {
        LSTK = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType23Code {
        SEAF = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType24Code {
        COAL = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType25Code {
        DIST = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType26Code {
        INRG = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType27Code {
        LGHT = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType28Code {
        RNNG = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType29Code {
        CRBR = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType2Code {
        SOFT = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType30Code {
        WTHR = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType31Code {
        DRYF = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType32Code {
        WETF = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType33Code {
        CSTR = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType34Code {
        MFTG = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType35Code {
        CBRD = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType36Code {
        NSPT = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType37Code {
        PULP = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType39Code {
        AMMO = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType3Code {
        OOLI = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType40Code {
        DAPH = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType41Code {
        PTSH = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType42Code {
        SLPH = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType43Code {
        UREA = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType44Code {
        UAAN = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType45Code {
        POTA = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType46Code {
        CSHP = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType49Code {
        OTHR = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType5Code {
        GRIN = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType6Code {
        ELEC = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType7Code {
        NGAS = 1
    }
    class ISO20022.Auth091001.AssetClassSubProductType8Code {
        OILP = 1
    }
    class ISO20022.Auth091001.BasketConstituents3 {
        + UnitOfMeasr  : ISO20022.Auth091001.UnitOfMeasure8Choice
        + Qty  : Decimal
        + InstrmId  : ISO20022.Auth091001.InstrumentIdentification6Choice
    }
    ISO20022.Auth091001.BasketConstituents3 *-- ISO20022.Auth091001.UnitOfMeasure8Choice
    ISO20022.Auth091001.BasketConstituents3 *-- ISO20022.Auth091001.InstrumentIdentification6Choice
    class ISO20022.Auth091001.Cleared23Choice {
        + NonClrd  : ISO20022.Auth091001.ClearingExceptionOrExemption3Choice
        + IntndToClear  : ISO20022.Auth091001.ClearingPartyAndTime22Choice
        + Clrd  : ISO20022.Auth091001.ClearingPartyAndTime21Choice
    }
    ISO20022.Auth091001.Cleared23Choice *-- ISO20022.Auth091001.ClearingExceptionOrExemption3Choice
    ISO20022.Auth091001.Cleared23Choice *-- ISO20022.Auth091001.ClearingPartyAndTime22Choice
    ISO20022.Auth091001.Cleared23Choice *-- ISO20022.Auth091001.ClearingPartyAndTime21Choice
    class ISO20022.Auth091001.ClearingAccountType4Code {
        HOUS = 1
        CLIE = 2
    }
    class ISO20022.Auth091001.ClearingExceptionOrExemption2 {
        + OthrCtrPty  : ISO20022.Auth091001.NonClearingReason2
        + RptgCtrPty  : ISO20022.Auth091001.NonClearingReason2
    }
    ISO20022.Auth091001.ClearingExceptionOrExemption2 *-- ISO20022.Auth091001.NonClearingReason2
    ISO20022.Auth091001.ClearingExceptionOrExemption2 *-- ISO20022.Auth091001.NonClearingReason2
    class ISO20022.Auth091001.ClearingExceptionOrExemption3Choice {
        + CtrPties  : ISO20022.Auth091001.ClearingExceptionOrExemption2
        + Rsn  : String
    }
    ISO20022.Auth091001.ClearingExceptionOrExemption3Choice *-- ISO20022.Auth091001.ClearingExceptionOrExemption2
    class ISO20022.Auth091001.ClearingExemptionException1Code {
        SMBK = 1
        OTHR = 2
        NORE = 3
        NOAL = 4
        AFFL = 5
        ENDU = 6
        COOP = 7
    }
    class ISO20022.Auth091001.ClearingObligationType1Code {
        TRUE = 1
        UKWN = 2
        FLSE = 3
    }
    class ISO20022.Auth091001.ClearingPartyAndTime21Choice {
        + Dtls  : ISO20022.Auth091001.ClearingPartyAndTime22
        + Rsn  : String
    }
    ISO20022.Auth091001.ClearingPartyAndTime21Choice *-- ISO20022.Auth091001.ClearingPartyAndTime22
    class ISO20022.Auth091001.ClearingPartyAndTime22 {
        + ClrAcctOrgn  : String
        + OrgnlTradRpstryIdr  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + OrgnlIdr  : ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
        + ClrIdr  : ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
        + ClrDtTm  : DateTime
        + ClrRctDtTm  : DateTime
        + CCP  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.ClearingPartyAndTime22 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    ISO20022.Auth091001.ClearingPartyAndTime22 *-- ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth091001.ClearingPartyAndTime22 *-- ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth091001.ClearingPartyAndTime22 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.ClearingPartyAndTime22Choice {
        + Dtls  : ISO20022.Auth091001.ClearingPartyAndTime23
        + Rsn  : String
    }
    ISO20022.Auth091001.ClearingPartyAndTime22Choice *-- ISO20022.Auth091001.ClearingPartyAndTime23
    class ISO20022.Auth091001.ClearingPartyAndTime23 {
        + OrgnlTradRpstryIdr  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + OrgnlIdr  : ISO20022.Auth091001.UniqueTransactionIdentifier1Choice
        + ClrIdr  : ISO20022.Auth091001.UniqueTransactionIdentifier1Choice
        + ClrDtTm  : DateTime
        + ClrRctDtTm  : DateTime
        + CCP  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.ClearingPartyAndTime23 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    ISO20022.Auth091001.ClearingPartyAndTime23 *-- ISO20022.Auth091001.UniqueTransactionIdentifier1Choice
    ISO20022.Auth091001.ClearingPartyAndTime23 *-- ISO20022.Auth091001.UniqueTransactionIdentifier1Choice
    ISO20022.Auth091001.ClearingPartyAndTime23 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.CollateralPortfolioCode5Choice {
        + MrgnPrtflCd  : ISO20022.Auth091001.MarginPortfolio3
        + Prtfl  : ISO20022.Auth091001.PortfolioCode3Choice
    }
    ISO20022.Auth091001.CollateralPortfolioCode5Choice *-- ISO20022.Auth091001.MarginPortfolio3
    ISO20022.Auth091001.CollateralPortfolioCode5Choice *-- ISO20022.Auth091001.PortfolioCode3Choice
    class ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4 {
        + Val2  : ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
        + Val1  : ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    }
    ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4 *-- ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4 *-- ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount
    class ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareAmountAndDirection3 {
        + Val2  : ISO20022.Auth091001.AmountAndDirection106
        + Val1  : ISO20022.Auth091001.AmountAndDirection106
    }
    ISO20022.Auth091001.CompareAmountAndDirection3 *-- ISO20022.Auth091001.AmountAndDirection106
    ISO20022.Auth091001.CompareAmountAndDirection3 *-- ISO20022.Auth091001.AmountAndDirection106
    class ISO20022.Auth091001.CompareAssetClass1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareBenchmarkCode1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareCFIIdentifier3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareCommodityAssetClass4 {
        + Val2  : ISO20022.Auth091001.AssetClassCommodity6Choice
        + Val1  : ISO20022.Auth091001.AssetClassCommodity6Choice
    }
    ISO20022.Auth091001.CompareCommodityAssetClass4 *-- ISO20022.Auth091001.AssetClassCommodity6Choice
    ISO20022.Auth091001.CompareCommodityAssetClass4 *-- ISO20022.Auth091001.AssetClassCommodity6Choice
    class ISO20022.Auth091001.CompareDate3 {
        + Val2  : DateTime
        + Val1  : DateTime
    }
    class ISO20022.Auth091001.CompareDatePeriod2 {
        + Val2  : ISO20022.Auth091001.DatePeriod4
        + Val1  : ISO20022.Auth091001.DatePeriod4
    }
    ISO20022.Auth091001.CompareDatePeriod2 *-- ISO20022.Auth091001.DatePeriod4
    ISO20022.Auth091001.CompareDatePeriod2 *-- ISO20022.Auth091001.DatePeriod4
    class ISO20022.Auth091001.CompareDateTime3 {
        + Val2  : DateTime
        + Val1  : DateTime
    }
    class ISO20022.Auth091001.CompareDayCount1 {
        + Val2  : ISO20022.Auth091001.InterestComputationMethodFormat7
        + Val1  : ISO20022.Auth091001.InterestComputationMethodFormat7
    }
    ISO20022.Auth091001.CompareDayCount1 *-- ISO20022.Auth091001.InterestComputationMethodFormat7
    ISO20022.Auth091001.CompareDayCount1 *-- ISO20022.Auth091001.InterestComputationMethodFormat7
    class ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1 {
        + Val2  : ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice
        + Val1  : ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice
    }
    ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1 *-- ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice
    ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1 *-- ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice
    class ISO20022.Auth091001.CompareDeliveryType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareDerivativeEvent1 {
        + Val2  : ISO20022.Auth091001.DerivativeEvent6
        + Val1  : ISO20022.Auth091001.DerivativeEvent6
    }
    ISO20022.Auth091001.CompareDerivativeEvent1 *-- ISO20022.Auth091001.DerivativeEvent6
    ISO20022.Auth091001.CompareDerivativeEvent1 *-- ISO20022.Auth091001.DerivativeEvent6
    class ISO20022.Auth091001.CompareDurationType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 {
        + NrgyPricTmIntrvlQty  : ISO20022.Auth091001.CompareAmountAndDirection3
        + NrgyQtyUnit  : ISO20022.Auth091001.CompareEnergyQuantityUnit1
        + NrgyDlvryCpcty  : ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
        + NrgyWkDay  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareWeekDay1~
        + NrgyDrtn  : ISO20022.Auth091001.CompareDurationType1
        + NrgyDt  : ISO20022.Auth091001.CompareDatePeriod2
        + NrgyDlvryIntrvl  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareTimePeriod2~
    }
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareEnergyQuantityUnit1
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareWeekDay1
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareDurationType1
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareDatePeriod2
    ISO20022.Auth091001.CompareEnergyDeliveryAttribute1 *-- ISO20022.Auth091001.CompareTimePeriod2
    class ISO20022.Auth091001.CompareEnergyLoadType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareEnergyQuantityUnit1 {
        + Val2  : ISO20022.Auth091001.EnergyQuantityUnit2Choice
        + Val1  : ISO20022.Auth091001.EnergyQuantityUnit2Choice
    }
    ISO20022.Auth091001.CompareEnergyQuantityUnit1 *-- ISO20022.Auth091001.EnergyQuantityUnit2Choice
    ISO20022.Auth091001.CompareEnergyQuantityUnit1 *-- ISO20022.Auth091001.EnergyQuantityUnit2Choice
    class ISO20022.Auth091001.CompareExchangeRate1 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth091001.CompareExchangeRateBasis1 {
        + Val2  : ISO20022.Auth091001.ExchangeRateBasis1Choice
        + Val1  : ISO20022.Auth091001.ExchangeRateBasis1Choice
    }
    ISO20022.Auth091001.CompareExchangeRateBasis1 *-- ISO20022.Auth091001.ExchangeRateBasis1Choice
    ISO20022.Auth091001.CompareExchangeRateBasis1 *-- ISO20022.Auth091001.ExchangeRateBasis1Choice
    class ISO20022.Auth091001.CompareFinancialInstrumentContractType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareFrequencyUnit1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareISINIdentifier2 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareISINIdentifier4 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareLegDirection2 {
        + Val2  : ISO20022.Auth091001.Direction4Choice
        + Val1  : ISO20022.Auth091001.Direction4Choice
    }
    ISO20022.Auth091001.CompareLegDirection2 *-- ISO20022.Auth091001.Direction4Choice
    ISO20022.Auth091001.CompareLegDirection2 *-- ISO20022.Auth091001.Direction4Choice
    class ISO20022.Auth091001.CompareLongFraction19DecimalNumber1 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth091001.CompareMICIdentifier3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareMasterAgreementType1 {
        + Val2  : ISO20022.Auth091001.AgreementType2Choice
        + Val1  : ISO20022.Auth091001.AgreementType2Choice
    }
    ISO20022.Auth091001.CompareMasterAgreementType1 *-- ISO20022.Auth091001.AgreementType2Choice
    ISO20022.Auth091001.CompareMasterAgreementType1 *-- ISO20022.Auth091001.AgreementType2Choice
    class ISO20022.Auth091001.CompareMax350Text1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareMax50Text1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareNumber5 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth091001.CompareNumber7 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth091001.CompareOptionStyle1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareOptionType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareOrganisationIdentification6 {
        + Val2  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + Val1  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.CompareOrganisationIdentification6 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    ISO20022.Auth091001.CompareOrganisationIdentification6 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.CompareOrganisationIdentification7 {
        + Val2  : ISO20022.Auth091001.PartyIdentification236Choice
        + Val1  : ISO20022.Auth091001.PartyIdentification236Choice
    }
    ISO20022.Auth091001.CompareOrganisationIdentification7 *-- ISO20022.Auth091001.PartyIdentification236Choice
    ISO20022.Auth091001.CompareOrganisationIdentification7 *-- ISO20022.Auth091001.PartyIdentification236Choice
    class ISO20022.Auth091001.CompareOtherPayment1 {
        + OthrPmtRcvr  : ISO20022.Auth091001.CompareOrganisationIdentification7
        + OthrPmtPyer  : ISO20022.Auth091001.CompareOrganisationIdentification7
        + OthrPmtDt  : ISO20022.Auth091001.CompareDate3
        + OthrPmtAmt  : ISO20022.Auth091001.CompareAmountAndDirection3
        + OthrPmtTp  : ISO20022.Auth091001.CompareOtherPaymentType1
    }
    ISO20022.Auth091001.CompareOtherPayment1 *-- ISO20022.Auth091001.CompareOrganisationIdentification7
    ISO20022.Auth091001.CompareOtherPayment1 *-- ISO20022.Auth091001.CompareOrganisationIdentification7
    ISO20022.Auth091001.CompareOtherPayment1 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.CompareOtherPayment1 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.CompareOtherPayment1 *-- ISO20022.Auth091001.CompareOtherPaymentType1
    class ISO20022.Auth091001.CompareOtherPaymentType1 {
        + Val2  : ISO20022.Auth091001.PaymentType5Choice
        + Val1  : ISO20022.Auth091001.PaymentType5Choice
    }
    ISO20022.Auth091001.CompareOtherPaymentType1 *-- ISO20022.Auth091001.PaymentType5Choice
    ISO20022.Auth091001.CompareOtherPaymentType1 *-- ISO20022.Auth091001.PaymentType5Choice
    class ISO20022.Auth091001.ComparePercentageRate3 {
        + Val2  : Decimal
        + Val1  : Decimal
    }
    class ISO20022.Auth091001.ComparePostTradeRiskReduction2 {
        + Val2  : ISO20022.Auth091001.PTRREvent3
        + Val1  : ISO20022.Auth091001.PTRREvent3
    }
    ISO20022.Auth091001.ComparePostTradeRiskReduction2 *-- ISO20022.Auth091001.PTRREvent3
    ISO20022.Auth091001.ComparePostTradeRiskReduction2 *-- ISO20022.Auth091001.PTRREvent3
    class ISO20022.Auth091001.CompareReferenceParty1 {
        + Val2  : ISO20022.Auth091001.DerivativePartyIdentification1Choice
        + Val1  : ISO20022.Auth091001.DerivativePartyIdentification1Choice
    }
    ISO20022.Auth091001.CompareReferenceParty1 *-- ISO20022.Auth091001.DerivativePartyIdentification1Choice
    ISO20022.Auth091001.CompareReferenceParty1 *-- ISO20022.Auth091001.DerivativePartyIdentification1Choice
    class ISO20022.Auth091001.CompareReportingLevelType2 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareSeniorityType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareText1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareText2 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareTimePeriod2 {
        + Val2  : ISO20022.Auth091001.TimePeriod3
        + Val1  : ISO20022.Auth091001.TimePeriod3
    }
    ISO20022.Auth091001.CompareTimePeriod2 *-- ISO20022.Auth091001.TimePeriod3
    ISO20022.Auth091001.CompareTimePeriod2 *-- ISO20022.Auth091001.TimePeriod3
    class ISO20022.Auth091001.CompareTradeClearingObligation1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareTradeClearingStatus3 {
        + Val2  : ISO20022.Auth091001.Cleared23Choice
        + Val1  : ISO20022.Auth091001.Cleared23Choice
    }
    ISO20022.Auth091001.CompareTradeClearingStatus3 *-- ISO20022.Auth091001.Cleared23Choice
    ISO20022.Auth091001.CompareTradeClearingStatus3 *-- ISO20022.Auth091001.Cleared23Choice
    class ISO20022.Auth091001.CompareTradeConfirmation2 {
        + Val2  : ISO20022.Auth091001.TradeConfirmation3Choice
        + Val1  : ISO20022.Auth091001.TradeConfirmation3Choice
    }
    ISO20022.Auth091001.CompareTradeConfirmation2 *-- ISO20022.Auth091001.TradeConfirmation3Choice
    ISO20022.Auth091001.CompareTradeConfirmation2 *-- ISO20022.Auth091001.TradeConfirmation3Choice
    class ISO20022.Auth091001.CompareTrancheIndicator1 {
        + Val2  : ISO20022.Auth091001.TrancheIndicator3Choice
        + Val1  : ISO20022.Auth091001.TrancheIndicator3Choice
    }
    ISO20022.Auth091001.CompareTrancheIndicator1 *-- ISO20022.Auth091001.TrancheIndicator3Choice
    ISO20022.Auth091001.CompareTrancheIndicator1 *-- ISO20022.Auth091001.TrancheIndicator3Choice
    class ISO20022.Auth091001.CompareTrueFalseIndicator3 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareUnderlyingInstrument3 {
        + Val2  : ISO20022.Auth091001.SecurityIdentification41Choice
        + Val1  : ISO20022.Auth091001.SecurityIdentification41Choice
    }
    ISO20022.Auth091001.CompareUnderlyingInstrument3 *-- ISO20022.Auth091001.SecurityIdentification41Choice
    ISO20022.Auth091001.CompareUnderlyingInstrument3 *-- ISO20022.Auth091001.SecurityIdentification41Choice
    class ISO20022.Auth091001.CompareUniqueProductIdentifier2 {
        + Val2  : ISO20022.Auth091001.UniqueProductIdentifier2Choice
        + Val1  : ISO20022.Auth091001.UniqueProductIdentifier2Choice
    }
    ISO20022.Auth091001.CompareUniqueProductIdentifier2 *-- ISO20022.Auth091001.UniqueProductIdentifier2Choice
    ISO20022.Auth091001.CompareUniqueProductIdentifier2 *-- ISO20022.Auth091001.UniqueProductIdentifier2Choice
    class ISO20022.Auth091001.CompareUniqueTransactionIdentifier2 {
        + Val2  : ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
        + Val1  : ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    }
    ISO20022.Auth091001.CompareUniqueTransactionIdentifier2 *-- ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth091001.CompareUniqueTransactionIdentifier2 *-- ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    class ISO20022.Auth091001.CompareUnitPrice4 {
        + Val2  : ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
        + Val1  : ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    }
    ISO20022.Auth091001.CompareUnitPrice4 *-- ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    ISO20022.Auth091001.CompareUnitPrice4 *-- ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth091001.CompareUnitPrice5 {
        + Val2  : ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
        + Val1  : ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    }
    ISO20022.Auth091001.CompareUnitPrice5 *-- ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    ISO20022.Auth091001.CompareUnitPrice5 *-- ISO20022.Auth091001.SecuritiesTransactionPrice17Choice
    class ISO20022.Auth091001.CompareUnitPrice7 {
        + Val2  : ISO20022.Auth091001.SecuritiesTransactionPrice14Choice
        + Val1  : ISO20022.Auth091001.SecuritiesTransactionPrice14Choice
    }
    ISO20022.Auth091001.CompareUnitPrice7 *-- ISO20022.Auth091001.SecuritiesTransactionPrice14Choice
    ISO20022.Auth091001.CompareUnitPrice7 *-- ISO20022.Auth091001.SecuritiesTransactionPrice14Choice
    class ISO20022.Auth091001.CompareUnitPrice8 {
        + Val2  : ISO20022.Auth091001.SecuritiesTransactionPrice13Choice
        + Val1  : ISO20022.Auth091001.SecuritiesTransactionPrice13Choice
    }
    ISO20022.Auth091001.CompareUnitPrice8 *-- ISO20022.Auth091001.SecuritiesTransactionPrice13Choice
    ISO20022.Auth091001.CompareUnitPrice8 *-- ISO20022.Auth091001.SecuritiesTransactionPrice13Choice
    class ISO20022.Auth091001.CompareValuationType1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.CompareWeekDay1 {
        + Val2  : String
        + Val1  : String
    }
    class ISO20022.Auth091001.ContractMatchingCriteria3 {
        + SttlmCcyScndLeg  : ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1
        + SttlmCcy  : ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1
        + UndrlygInstrm  : ISO20022.Auth091001.CompareUnderlyingInstrument3
        + DerivBasedOnCrptAsst  : ISO20022.Auth091001.CompareTrueFalseIndicator3
        + AsstClss  : ISO20022.Auth091001.CompareAssetClass1
        + CtrctTp  : ISO20022.Auth091001.CompareFinancialInstrumentContractType1
        + PdctClssfctn  : ISO20022.Auth091001.CompareCFIIdentifier3
        + AltrntvInstrmId  : ISO20022.Auth091001.CompareText1
        + UnqPdctIdr  : ISO20022.Auth091001.CompareUniqueProductIdentifier2
        + ISIN  : ISO20022.Auth091001.CompareISINIdentifier2
    }
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareUnderlyingInstrument3
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareTrueFalseIndicator3
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareAssetClass1
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareFinancialInstrumentContractType1
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareCFIIdentifier3
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareText1
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareUniqueProductIdentifier2
    ISO20022.Auth091001.ContractMatchingCriteria3 *-- ISO20022.Auth091001.CompareISINIdentifier2
    class ISO20022.Auth091001.CounterpartyData91 {
        + NttyRspnsblForRpt  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + RptSubmitgNtty  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + OthrCtrPty  : ISO20022.Auth091001.PartyIdentification236Choice
        + RptgCtrPty  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.CounterpartyData91 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    ISO20022.Auth091001.CounterpartyData91 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    ISO20022.Auth091001.CounterpartyData91 *-- ISO20022.Auth091001.PartyIdentification236Choice
    ISO20022.Auth091001.CounterpartyData91 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.CounterpartyMatchingCriteria6 {
        + DrctnOrSd  : ISO20022.Auth091001.CompareLegDirection2
        + OthrCtrPty  : ISO20022.Auth091001.CompareOrganisationIdentification7
        + RptgCtrPty  : ISO20022.Auth091001.CompareOrganisationIdentification6
    }
    ISO20022.Auth091001.CounterpartyMatchingCriteria6 *-- ISO20022.Auth091001.CompareLegDirection2
    ISO20022.Auth091001.CounterpartyMatchingCriteria6 *-- ISO20022.Auth091001.CompareOrganisationIdentification7
    ISO20022.Auth091001.CounterpartyMatchingCriteria6 *-- ISO20022.Auth091001.CompareOrganisationIdentification6
    class ISO20022.Auth091001.CustomBasket4 {
        + Cnsttnts  : global::System.Collections.Generic.List~ISO20022.Auth091001.BasketConstituents3~
        + Id  : String
        + Strr  : String
    }
    ISO20022.Auth091001.CustomBasket4 *-- ISO20022.Auth091001.BasketConstituents3
    class ISO20022.Auth091001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Auth091001.DatePeriod4 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Auth091001.DebtInstrumentSeniorityType2Code {
        OTHR = 1
        SNDB = 2
        SBOD = 3
    }
    class ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth091001.DerivativeEvent6 {
        + AmdmntInd  : String
        + TmStmp  : ISO20022.Auth091001.DateAndDateTime2Choice
        + Id  : ISO20022.Auth091001.EventIdentifier1Choice
        + Tp  : String
    }
    ISO20022.Auth091001.DerivativeEvent6 *-- ISO20022.Auth091001.DateAndDateTime2Choice
    ISO20022.Auth091001.DerivativeEvent6 *-- ISO20022.Auth091001.EventIdentifier1Choice
    class ISO20022.Auth091001.DerivativeEventType3Code {
        UPDT = 1
        TRAD = 2
        PTNG = 3
        NOVA = 4
        INCP = 5
        EXER = 6
        ETRM = 7
        CREV = 8
        CORP = 9
        COMP = 10
        CLAL = 11
        CLRG = 12
        ALOC = 13
    }
    class ISO20022.Auth091001.DerivativePartyIdentification1Choice {
        + LEI  : String
        + CtrySubDvsn  : String
        + Ctry  : String
    }
    class ISO20022.Auth091001.DerivativesTradeReconciliationStatisticalReportV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth091001.SupplementaryData1~
        + RcncltnSttstcs  : ISO20022.Auth091001.StatisticsPerCounterparty19Choice
    }
    ISO20022.Auth091001.DerivativesTradeReconciliationStatisticalReportV03 *-- ISO20022.Auth091001.SupplementaryData1
    ISO20022.Auth091001.DerivativesTradeReconciliationStatisticalReportV03 *-- ISO20022.Auth091001.StatisticsPerCounterparty19Choice
    class ISO20022.Auth091001.Direction2 {
        + DrctnOfTheScndLeg  : String
        + DrctnOfTheFrstLeg  : String
    }
    class ISO20022.Auth091001.Direction4Choice {
        + CtrPtySd  : String
        + Drctn  : ISO20022.Auth091001.Direction2
    }
    ISO20022.Auth091001.Direction4Choice *-- ISO20022.Auth091001.Direction2
    class ISO20022.Auth091001.DurationType1Code {
        OTHR = 1
        DASD = 2
        HOUR = 3
        MNUT = 4
        MNTH = 5
        QURT = 6
        SEAS = 7
        WEEK = 8
        YEAR = 9
    }
    class ISO20022.Auth091001.EnergyCommodityCoal2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityDistillates2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityElectricity2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityInterEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityLightEnd2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityNaturalGas3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityOil3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyCommodityRenewableEnergy2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnergyLoadType1Code {
        SHPD = 1
        PKLD = 2
        OTHR = 3
        OFFP = 4
        HABH = 5
        GASD = 6
        BSLD = 7
    }
    class ISO20022.Auth091001.EnergyQuantityUnit2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth091001.EnergyQuantityUnit2Code {
        THMD = 1
        MWHH = 2
        MWHD = 3
        MWAT = 4
        MTMD = 5
        MMJD = 6
        MBTD = 7
        MJDD = 8
        MCMD = 9
        KWHH = 10
        KWHD = 11
        KWAT = 12
        KTMD = 13
        HMJD = 14
        GWHH = 15
        GWHD = 16
        GWAT = 17
        GJDD = 18
        CMPD = 19
        BTUD = 20
    }
    class ISO20022.Auth091001.EnvironmentCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnvironmentalCommodityCarbonRelated2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnvironmentalCommodityEmission3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EnvironmentalCommodityWeather2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.EventIdentifier1Choice {
        + PstTradRskRdctnIdr  : ISO20022.Auth091001.PostTradeRiskReductionIdentifier1
        + EvtIdr  : String
    }
    ISO20022.Auth091001.EventIdentifier1Choice *-- ISO20022.Auth091001.PostTradeRiskReductionIdentifier1
    class ISO20022.Auth091001.ExchangeRateBasis1 {
        + QtdCcy  : String
        + BaseCcy  : String
    }
    class ISO20022.Auth091001.ExchangeRateBasis1Choice {
        + Prtry  : String
        + CcyPair  : ISO20022.Auth091001.ExchangeRateBasis1
    }
    ISO20022.Auth091001.ExchangeRateBasis1Choice *-- ISO20022.Auth091001.ExchangeRateBasis1
    class ISO20022.Auth091001.FertilizerCommodityAmmonia2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommodityDiammoniumPhosphate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommodityPotash2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommoditySulphur2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommodityUrea2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FertilizerCommodityUreaAndAmmoniumNitrate2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FinancialInstrumentContractType2Code {
        OTHR = 1
        SWPT = 2
        SWAP = 3
        SPDB = 4
        OPTN = 5
        FORW = 6
        FUTR = 7
        FRAS = 8
        CFDS = 9
    }
    class ISO20022.Auth091001.FreightCommodityContainerShip2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FreightCommodityDry3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FreightCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.FreightCommodityWet3 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.Frequency13Code {
        QURT = 1
        MIAN = 2
        EXPI = 3
        ADHO = 4
        YEAR = 5
        MNTH = 6
        WEEK = 7
        DAIL = 8
    }
    class ISO20022.Auth091001.GenericIdentification175 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth091001.GenericIdentification179 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Auth091001.GenericIdentification184 {
        + Src  : String
        + Id  : String
    }
    class ISO20022.Auth091001.GenericIdentification185 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Auth091001.IndexIdentification1 {
        + Indx  : String
        + Nm  : String
        + ISIN  : String
    }
    class ISO20022.Auth091001.IndustrialProductCommodityConstruction2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.IndustrialProductCommodityManufacturing2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.InstrumentIdentification6Choice {
        + OthrId  : ISO20022.Auth091001.GenericIdentification184
        + UnqPdctIdr  : ISO20022.Auth091001.UniqueProductIdentifier1Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth091001.InstrumentIdentification6Choice *-- ISO20022.Auth091001.GenericIdentification184
    ISO20022.Auth091001.InstrumentIdentification6Choice *-- ISO20022.Auth091001.UniqueProductIdentifier1Choice
    class ISO20022.Auth091001.InterestComputationMethod4Code {
        A020 = 1
        NARR = 2
        A016 = 3
        A007 = 4
        A013 = 5
        A012 = 6
        A003 = 7
        A002 = 8
        A001 = 9
        A011 = 10
        A018 = 11
        A015 = 12
        A008 = 13
        A006 = 14
        A010 = 15
        A014 = 16
        A009 = 17
        A005 = 18
        A017 = 19
        A019 = 20
        A004 = 21
    }
    class ISO20022.Auth091001.InterestComputationMethodFormat7 {
        + Nrrtv  : String
        + Cd  : String
    }
    class ISO20022.Auth091001.LegalPersonIdentification1 {
        + Ctry  : String
        + Id  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.LegalPersonIdentification1 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.MarginPortfolio3 {
        + VartnMrgnPrtflCd  : ISO20022.Auth091001.PortfolioCode5Choice
        + InitlMrgnPrtflCd  : ISO20022.Auth091001.PortfolioCode5Choice
    }
    ISO20022.Auth091001.MarginPortfolio3 *-- ISO20022.Auth091001.PortfolioCode5Choice
    ISO20022.Auth091001.MarginPortfolio3 *-- ISO20022.Auth091001.PortfolioCode5Choice
    class ISO20022.Auth091001.MasterAgreement8 {
        + OthrMstrAgrmtDtls  : String
        + Vrsn  : String
        + Tp  : ISO20022.Auth091001.AgreementType2Choice
    }
    ISO20022.Auth091001.MasterAgreement8 *-- ISO20022.Auth091001.AgreementType2Choice
    class ISO20022.Auth091001.MatchingCriteria17 {
        + TxMtchgCrit  : ISO20022.Auth091001.TransactionMatchingCriteria7
        + CtrctMtchgCrit  : ISO20022.Auth091001.ContractMatchingCriteria3
        + ValtnMtchgCrit  : ISO20022.Auth091001.ValuationMatchingCriteria1
        + CtrPtyMtchgCrit  : ISO20022.Auth091001.CounterpartyMatchingCriteria6
    }
    ISO20022.Auth091001.MatchingCriteria17 *-- ISO20022.Auth091001.TransactionMatchingCriteria7
    ISO20022.Auth091001.MatchingCriteria17 *-- ISO20022.Auth091001.ContractMatchingCriteria3
    ISO20022.Auth091001.MatchingCriteria17 *-- ISO20022.Auth091001.ValuationMatchingCriteria1
    ISO20022.Auth091001.MatchingCriteria17 *-- ISO20022.Auth091001.CounterpartyMatchingCriteria6
    class ISO20022.Auth091001.MetalCommodityNonPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.MetalCommodityPrecious2 {
        + AddtlSubPdct  : String
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.ModificationLevel1Code {
        TCTN = 1
        PSTN = 2
    }
    class ISO20022.Auth091001.NaturalPersonIdentification2 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth091001.GenericIdentification175
    }
    ISO20022.Auth091001.NaturalPersonIdentification2 *-- ISO20022.Auth091001.GenericIdentification175
    class ISO20022.Auth091001.NaturalPersonIdentification3 {
        + Ctry  : String
        + Id  : ISO20022.Auth091001.NaturalPersonIdentification2
    }
    ISO20022.Auth091001.NaturalPersonIdentification3 *-- ISO20022.Auth091001.NaturalPersonIdentification2
    class ISO20022.Auth091001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Auth091001.NonClearingReason2 {
        + NonClrRsnInf  : String
        + ClrXmptnXcptn  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Auth091001.NotApplicable1Code {
        NOAP = 1
    }
    class ISO20022.Auth091001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Auth091001.OptionParty3Code {
        TAKE = 1
        MAKE = 2
    }
    class ISO20022.Auth091001.OptionStyle6Code {
        AMER = 1
        ASIA = 2
        BERM = 3
        EURO = 4
    }
    class ISO20022.Auth091001.OptionType2Code {
        OTHR = 1
        PUTO = 2
        CALL = 3
    }
    class ISO20022.Auth091001.OrganisationIdentification15Choice {
        + AnyBIC  : String
        + Othr  : ISO20022.Auth091001.OrganisationIdentification38
        + LEI  : String
    }
    ISO20022.Auth091001.OrganisationIdentification15Choice *-- ISO20022.Auth091001.OrganisationIdentification38
    class ISO20022.Auth091001.OrganisationIdentification38 {
        + Dmcl  : String
        + Nm  : String
        + Id  : ISO20022.Auth091001.GenericIdentification175
    }
    ISO20022.Auth091001.OrganisationIdentification38 *-- ISO20022.Auth091001.GenericIdentification175
    class ISO20022.Auth091001.PTRREvent3 {
        + SvcPrvdr  : ISO20022.Auth091001.OrganisationIdentification15Choice
        + Tchnq  : String
    }
    ISO20022.Auth091001.PTRREvent3 *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.PairingStatus1Code {
        UNPR = 1
        PARD = 2
    }
    class ISO20022.Auth091001.PaperCommodityContainerBoard2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PaperCommodityNewsprint2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PaperCommodityOther1 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PaperCommodityPulp2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PartyIdentification236Choice {
        + Ntrl  : ISO20022.Auth091001.NaturalPersonIdentification2
        + Lgl  : ISO20022.Auth091001.OrganisationIdentification15Choice
    }
    ISO20022.Auth091001.PartyIdentification236Choice *-- ISO20022.Auth091001.NaturalPersonIdentification2
    ISO20022.Auth091001.PartyIdentification236Choice *-- ISO20022.Auth091001.OrganisationIdentification15Choice
    class ISO20022.Auth091001.PartyIdentification248Choice {
        + Ntrl  : ISO20022.Auth091001.NaturalPersonIdentification3
        + Lgl  : ISO20022.Auth091001.LegalPersonIdentification1
    }
    ISO20022.Auth091001.PartyIdentification248Choice *-- ISO20022.Auth091001.NaturalPersonIdentification3
    ISO20022.Auth091001.PartyIdentification248Choice *-- ISO20022.Auth091001.LegalPersonIdentification1
    class ISO20022.Auth091001.PaymentType4Code {
        PEXH = 1
        UWIN = 2
        UFRO = 3
    }
    class ISO20022.Auth091001.PaymentType5Choice {
        + PrtryTp  : String
        + Tp  : String
    }
    class ISO20022.Auth091001.PhysicalTransferType4Code {
        CASH = 1
        OPTL = 2
        PHYS = 3
    }
    class ISO20022.Auth091001.PolypropyleneCommodityOther2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PolypropyleneCommodityPlastic2 {
        + SubPdct  : String
        + BasePdct  : String
    }
    class ISO20022.Auth091001.PortfolioCode3Choice {
        + NoPrtfl  : String
        + Cd  : String
    }
    class ISO20022.Auth091001.PortfolioCode5Choice {
        + NoPrtfl  : String
        + Prtfl  : ISO20022.Auth091001.PortfolioIdentification3
    }
    ISO20022.Auth091001.PortfolioCode5Choice *-- ISO20022.Auth091001.PortfolioIdentification3
    class ISO20022.Auth091001.PortfolioIdentification3 {
        + PrtflTxXmptn  : String
        + Cd  : String
    }
    class ISO20022.Auth091001.PostTradeRiskReductionIdentifier1 {
        + Id  : String
        + Strr  : String
    }
    class ISO20022.Auth091001.PriceStatus1Code {
        NOAP = 1
        PNDG = 2
    }
    class ISO20022.Auth091001.ProductType4Code {
        OTHR = 1
        COMM = 2
        INTR = 3
        EQUI = 4
        CURR = 5
        CRDT = 6
    }
    class ISO20022.Auth091001.ReconciliationCategory4 {
        + FrthrMod  : String
        + Rvvd  : String
    }
    class ISO20022.Auth091001.ReconciliationCategory5 {
        + FrthrMod  : String
        + Rvvd  : String
        + ValtnRcncltn  : String
        + Rcncltn  : String
        + Pairg  : String
        + RptgTp  : String
    }
    class ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7 {
        + RcncltnRpt  : global::System.Collections.Generic.List~ISO20022.Auth091001.ReconciliationReport15~
        + TtlNbOfTxs  : Decimal
        + CtrPtyId  : ISO20022.Auth091001.CounterpartyData91
    }
    ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7 *-- ISO20022.Auth091001.ReconciliationReport15
    ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7 *-- ISO20022.Auth091001.CounterpartyData91
    class ISO20022.Auth091001.ReconciliationReport15 {
        + MtchgCrit  : ISO20022.Auth091001.MatchingCriteria17
        + TxId  : ISO20022.Auth091001.TradeTransactionIdentification24
    }
    ISO20022.Auth091001.ReconciliationReport15 *-- ISO20022.Auth091001.MatchingCriteria17
    ISO20022.Auth091001.ReconciliationReport15 *-- ISO20022.Auth091001.TradeTransactionIdentification24
    class ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4 {
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7~
        + TtlNbOfTxs  : Decimal
        + RcncltnCtgrs  : ISO20022.Auth091001.ReportingRequirement3Choice
        + RefDt  : DateTime
    }
    ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4 *-- ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7
    ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4 *-- ISO20022.Auth091001.ReportingRequirement3Choice
    class ISO20022.Auth091001.ReconciliationStatus1Code {
        RECO = 1
        NREC = 2
    }
    class ISO20022.Auth091001.ReconciliationStatus2Code {
        NOAP = 1
        RECO = 2
        NREC = 3
    }
    class ISO20022.Auth091001.ReportPeriodActivity1Code {
        NOTX = 1
    }
    class ISO20022.Auth091001.ReportingRequirement3Choice {
        + NoRptgRqrmnt  : ISO20022.Auth091001.ReconciliationCategory4
        + RptgRqrmnt  : ISO20022.Auth091001.ReconciliationCategory5
    }
    ISO20022.Auth091001.ReportingRequirement3Choice *-- ISO20022.Auth091001.ReconciliationCategory4
    ISO20022.Auth091001.ReportingRequirement3Choice *-- ISO20022.Auth091001.ReconciliationCategory5
    class ISO20022.Auth091001.RiskReductionService1Code {
        PWAS = 1
        PRBM = 2
        OTHR = 3
        PWOS = 4
        NORR = 5
    }
    class ISO20022.Auth091001.SecuritiesTransactionPrice13Choice {
        + BsisPtSprd  : Decimal
        + Dcml  : Decimal
        + Pctg  : Decimal
        + MntryVal  : ISO20022.Auth091001.AmountAndDirection106
    }
    ISO20022.Auth091001.SecuritiesTransactionPrice13Choice *-- ISO20022.Auth091001.AmountAndDirection106
    class ISO20022.Auth091001.SecuritiesTransactionPrice14Choice {
        + Dcml  : Decimal
        + Rate  : Decimal
    }
    class ISO20022.Auth091001.SecuritiesTransactionPrice17Choice {
        + Othr  : ISO20022.Auth091001.SecuritiesTransactionPrice5
        + PdgPric  : String
        + Dcml  : Decimal
        + Yld  : Decimal
        + Pctg  : Decimal
        + Unit  : Decimal
        + MntryVal  : ISO20022.Auth091001.AmountAndDirection106
    }
    ISO20022.Auth091001.SecuritiesTransactionPrice17Choice *-- ISO20022.Auth091001.SecuritiesTransactionPrice5
    ISO20022.Auth091001.SecuritiesTransactionPrice17Choice *-- ISO20022.Auth091001.AmountAndDirection106
    class ISO20022.Auth091001.SecuritiesTransactionPrice5 {
        + Tp  : String
        + Val  : Decimal
    }
    class ISO20022.Auth091001.SecurityIdentification41Choice {
        + IdNotAvlbl  : String
        + Othr  : ISO20022.Auth091001.GenericIdentification184
        + Indx  : ISO20022.Auth091001.IndexIdentification1
        + Bskt  : ISO20022.Auth091001.CustomBasket4
        + UnqPdctIdr  : ISO20022.Auth091001.UniqueProductIdentifier2Choice
        + AltrntvInstrmId  : String
        + ISIN  : String
    }
    ISO20022.Auth091001.SecurityIdentification41Choice *-- ISO20022.Auth091001.GenericIdentification184
    ISO20022.Auth091001.SecurityIdentification41Choice *-- ISO20022.Auth091001.IndexIdentification1
    ISO20022.Auth091001.SecurityIdentification41Choice *-- ISO20022.Auth091001.CustomBasket4
    ISO20022.Auth091001.SecurityIdentification41Choice *-- ISO20022.Auth091001.UniqueProductIdentifier2Choice
    class ISO20022.Auth091001.StatisticsPerCounterparty19Choice {
        + Rpt  : global::System.Collections.Generic.List~ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4~
        + DataSetActn  : String
    }
    ISO20022.Auth091001.StatisticsPerCounterparty19Choice *-- ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4
    class ISO20022.Auth091001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth091001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth091001.SupplementaryData1 *-- ISO20022.Auth091001.SupplementaryDataEnvelope1
    class ISO20022.Auth091001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth091001.TimePeriod3 {
        + ToTm  : DateTime
        + FrTm  : DateTime
    }
    class ISO20022.Auth091001.TradeConfirmation3Choice {
        + NonConfd  : ISO20022.Auth091001.TradeNonConfirmation1
        + Confd  : ISO20022.Auth091001.TradeConfirmation4
    }
    ISO20022.Auth091001.TradeConfirmation3Choice *-- ISO20022.Auth091001.TradeNonConfirmation1
    ISO20022.Auth091001.TradeConfirmation3Choice *-- ISO20022.Auth091001.TradeConfirmation4
    class ISO20022.Auth091001.TradeConfirmation4 {
        + TmStmp  : DateTime
        + Tp  : String
    }
    class ISO20022.Auth091001.TradeConfirmationType1Code {
        YCNF = 1
        ECNF = 2
    }
    class ISO20022.Auth091001.TradeConfirmationType2Code {
        NCNF = 1
    }
    class ISO20022.Auth091001.TradeNonConfirmation1 {
        + Tp  : String
    }
    class ISO20022.Auth091001.TradeRepositoryReportingType1Code {
        TWOS = 1
        SWOS = 2
    }
    class ISO20022.Auth091001.TradeTransactionIdentification24 {
        + CollPrtflCd  : ISO20022.Auth091001.CollateralPortfolioCode5Choice
        + MstrAgrmt  : ISO20022.Auth091001.MasterAgreement8
        + UnqIdr  : ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
        + OthrCtrPty  : ISO20022.Auth091001.PartyIdentification248Choice
        + DerivEvtTmStmp  : ISO20022.Auth091001.DateAndDateTime2Choice
        + DerivEvtTp  : String
        + RptgTmStmp  : DateTime
        + ActnTp  : String
        + TechRcrdId  : String
    }
    ISO20022.Auth091001.TradeTransactionIdentification24 *-- ISO20022.Auth091001.CollateralPortfolioCode5Choice
    ISO20022.Auth091001.TradeTransactionIdentification24 *-- ISO20022.Auth091001.MasterAgreement8
    ISO20022.Auth091001.TradeTransactionIdentification24 *-- ISO20022.Auth091001.UniqueTransactionIdentifier2Choice
    ISO20022.Auth091001.TradeTransactionIdentification24 *-- ISO20022.Auth091001.PartyIdentification248Choice
    ISO20022.Auth091001.TradeTransactionIdentification24 *-- ISO20022.Auth091001.DateAndDateTime2Choice
    class ISO20022.Auth091001.Tranche3 {
        + DtchmntPt  : Decimal
        + AttchmntPt  : Decimal
    }
    class ISO20022.Auth091001.TrancheIndicator3Choice {
        + Utrnchd  : String
        + Trnchd  : ISO20022.Auth091001.Tranche3
    }
    ISO20022.Auth091001.TrancheIndicator3Choice *-- ISO20022.Auth091001.Tranche3
    class ISO20022.Auth091001.TransactionMatchingCriteria7 {
        + Lvl  : ISO20022.Auth091001.CompareReportingLevelType2
        + CdtTrch  : ISO20022.Auth091001.CompareTrancheIndicator1
        + CdtIndxFctr  : ISO20022.Auth091001.ComparePercentageRate3
        + CdtVrsn  : ISO20022.Auth091001.CompareNumber7
        + CdtSrs  : ISO20022.Auth091001.CompareNumber7
        + CdtRefPty  : ISO20022.Auth091001.CompareReferenceParty1
        + CdtSnrty  : ISO20022.Auth091001.CompareSeniorityType1
        + OptnMtrtyDtOfUndrlyg  : ISO20022.Auth091001.CompareDate3
        + OptnPrmPmtDt  : ISO20022.Auth091001.CompareDate3
        + OptnPrmAmt  : ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4
        + OptnStrkPricSchdlAmt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareUnitPrice4~
        + OptnStrkPricSchdlUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + OptnStrkPricSchdlUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + OptnStrkPric  : ISO20022.Auth091001.CompareUnitPrice4
        + OptnExrcStyle  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareOptionStyle1~
        + OptnTp  : ISO20022.Auth091001.CompareOptionType1
        + DlvryAttr  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareEnergyDeliveryAttribute1~
        + NrgyLdTp  : ISO20022.Auth091001.CompareEnergyLoadType1
        + NrgyIntrCnnctnPt  : ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1
        + NrgyDlvryPtOrZone  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1~
        + Cmmdty  : ISO20022.Auth091001.CompareCommodityAssetClass4
        + CcyXchgRateBsis  : ISO20022.Auth091001.CompareExchangeRateBasis1
        + CcyFwdXchgRate  : ISO20022.Auth091001.CompareExchangeRate1
        + CcyXchgRate  : ISO20022.Auth091001.CompareExchangeRate1
        + PackgSprd  : ISO20022.Auth091001.CompareUnitPrice8
        + IntrstFltgRateScndLegSprd  : ISO20022.Auth091001.CompareUnitPrice8
        + IntrstFltgRateScndLegRstFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateScndLegRstFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateScndLegRefPrdVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateScndLegRefPrdUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateScndLegPmtFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateScndLegPmtFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateScndLegDayCnt  : ISO20022.Auth091001.CompareDayCount1
        + IntrstFltgRateScndLegNm  : ISO20022.Auth091001.CompareMax350Text1
        + IntrstFltgRateScndLegCd  : ISO20022.Auth091001.CompareBenchmarkCode1
        + IntrstFltgRateScndLegId  : ISO20022.Auth091001.CompareISINIdentifier4
        + IntrstFxdRateScndLegPmtFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFxdRateScndLegPmtFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFxdRateScndLegDayCnt  : ISO20022.Auth091001.CompareDayCount1
        + IntrstRateFxdScndLeg  : ISO20022.Auth091001.CompareUnitPrice7
        + IntrstFltgRateFrstLegSprd  : ISO20022.Auth091001.CompareUnitPrice8
        + IntrstFltgRateFrstLegRstFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateFrstLegRstFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateFrstLegRefPrdVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateFrstLegRefPrdUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateFrstLegPmtFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFltgRateFrstLegPmtFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFltgRateFrstLegDayCnt  : ISO20022.Auth091001.CompareDayCount1
        + IntrstFltgRateFrstLegNm  : ISO20022.Auth091001.CompareMax350Text1
        + IntrstFltgRateFrstLegCd  : ISO20022.Auth091001.CompareBenchmarkCode1
        + IntrstFltgRateFrstLegId  : ISO20022.Auth091001.CompareISINIdentifier4
        + IntrstFxdRateFrstLegPmtFrqcyVal  : ISO20022.Auth091001.CompareNumber5
        + IntrstFxdRateFrstLegPmtFrqcyUnit  : ISO20022.Auth091001.CompareFrequencyUnit1
        + IntrstFxdRateFrstLegDayCnt  : ISO20022.Auth091001.CompareDayCount1
        + IntrstFxdRateFrstLeg  : ISO20022.Auth091001.CompareUnitPrice7
        + OthrPmt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareOtherPayment1~
        + NtnlQtyScndLegSchdlQty  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareLongFraction19DecimalNumber1~
        + NtnlQtyScndLegUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlQtyScndLegUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlQtyScndLeg  : ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
        + NtnlAmtScndLegSchdlAmt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareAmountAndDirection3~
        + NtnlAmtScndLegUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlAmtScndLegUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlAmtScndLeg  : ISO20022.Auth091001.CompareAmountAndDirection3
        + NtnlQtyFrstLegSchdlQty  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareLongFraction19DecimalNumber1~
        + NtnlQtyFrstLegUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlQtyFrstLegUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlQtyFrstLeg  : ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
        + NtnlAmtFrstLegSchdlAmt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareAmountAndDirection3~
        + NtnlAmtFrstLegUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlAmtFrstLegUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + NtnlAmtFrstLeg  : ISO20022.Auth091001.CompareAmountAndDirection3
        + PackgPric  : ISO20022.Auth091001.CompareUnitPrice5
        + TxSchdlPric  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareUnitPrice5~
        + PricSchdlUadjstdEndDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + PricSchdlUadjstdFctvDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + TxPric  : ISO20022.Auth091001.CompareUnitPrice5
        + DlvryTp  : ISO20022.Auth091001.CompareDeliveryType1
        + SttlmDt  : global::System.Collections.Generic.List~ISO20022.Auth091001.CompareDate3~
        + EarlyTermntnDt  : ISO20022.Auth091001.CompareDate3
        + XprtnDt  : ISO20022.Auth091001.CompareDate3
        + FctvDt  : ISO20022.Auth091001.CompareDate3
        + ExctnTmStmp  : ISO20022.Auth091001.CompareDateTime3
        + PltfmIdr  : ISO20022.Auth091001.CompareMICIdentifier3
        + DerivEvt  : ISO20022.Auth091001.CompareDerivativeEvent1
        + PstTradRskRdctn  : ISO20022.Auth091001.ComparePostTradeRiskReduction2
        + IntraGrp  : ISO20022.Auth091001.CompareTrueFalseIndicator3
        + MstrAgrmtVrsn  : ISO20022.Auth091001.CompareMax50Text1
        + MstrAgrmtTp  : ISO20022.Auth091001.CompareMasterAgreementType1
        + TradClrSts  : ISO20022.Auth091001.CompareTradeClearingStatus3
        + TradClrOblgtn  : ISO20022.Auth091001.CompareTradeClearingObligation1
        + TradConf  : ISO20022.Auth091001.CompareTradeConfirmation2
        + Dlta  : ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
        + SbsqntPosUnqTxIdr  : ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
        + PrrUnqTxIdr  : ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
        + UnqTxIdr  : ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
        + RptTrckgNb  : ISO20022.Auth091001.CompareText2
    }
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareReportingLevelType2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareTrancheIndicator1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.ComparePercentageRate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber7
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber7
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareReferenceParty1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareSeniorityType1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareOptionStyle1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareOptionType1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareEnergyDeliveryAttribute1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareEnergyLoadType1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareCommodityAssetClass4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareExchangeRateBasis1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareExchangeRate1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareExchangeRate1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice8
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice8
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDayCount1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareMax350Text1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareBenchmarkCode1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareISINIdentifier4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDayCount1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice7
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice8
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDayCount1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareMax350Text1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareBenchmarkCode1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareISINIdentifier4
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareNumber5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareFrequencyUnit1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDayCount1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice7
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareOtherPayment1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUnitPrice5
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDeliveryType1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDate3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDateTime3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareMICIdentifier3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareDerivativeEvent1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.ComparePostTradeRiskReduction2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareTrueFalseIndicator3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareMax50Text1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareMasterAgreementType1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareTradeClearingStatus3
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareTradeClearingObligation1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareTradeConfirmation2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareLongFraction19DecimalNumber1
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareUniqueTransactionIdentifier2
    ISO20022.Auth091001.TransactionMatchingCriteria7 *-- ISO20022.Auth091001.CompareText2
    class ISO20022.Auth091001.TransactionOperationType10Code {
        PRTO = 1
        MARU = 2
        VALU = 3
        TERM = 4
        REVI = 5
        POSC = 6
        OTHR = 7
        NEWT = 8
        MODI = 9
        EROR = 10
        CORR = 11
        COMP = 12
    }
    class ISO20022.Auth091001.UnderlyingIdentification1Code {
        INDX = 1
        BSKT = 2
        UKWN = 3
    }
    class ISO20022.Auth091001.UniqueProductIdentifier1Choice {
        + Prtry  : ISO20022.Auth091001.GenericIdentification175
        + Id  : String
    }
    ISO20022.Auth091001.UniqueProductIdentifier1Choice *-- ISO20022.Auth091001.GenericIdentification175
    class ISO20022.Auth091001.UniqueProductIdentifier2Choice {
        + Prtry  : ISO20022.Auth091001.GenericIdentification185
        + Id  : String
    }
    ISO20022.Auth091001.UniqueProductIdentifier2Choice *-- ISO20022.Auth091001.GenericIdentification185
    class ISO20022.Auth091001.UniqueTransactionIdentifier1Choice {
        + Prtry  : ISO20022.Auth091001.GenericIdentification179
        + UnqTxIdr  : String
    }
    ISO20022.Auth091001.UniqueTransactionIdentifier1Choice *-- ISO20022.Auth091001.GenericIdentification179
    class ISO20022.Auth091001.UniqueTransactionIdentifier2Choice {
        + Prtry  : ISO20022.Auth091001.GenericIdentification175
        + UnqTxIdr  : String
    }
    ISO20022.Auth091001.UniqueTransactionIdentifier2Choice *-- ISO20022.Auth091001.GenericIdentification175
    class ISO20022.Auth091001.UnitOfMeasure8Choice {
        + Prtry  : ISO20022.Auth091001.GenericIdentification175
        + Cd  : String
    }
    ISO20022.Auth091001.UnitOfMeasure8Choice *-- ISO20022.Auth091001.GenericIdentification175
    class ISO20022.Auth091001.ValuationMatchingCriteria1 {
        + Tp  : ISO20022.Auth091001.CompareValuationType1
        + CtrctVal  : ISO20022.Auth091001.CompareAmountAndDirection3
    }
    ISO20022.Auth091001.ValuationMatchingCriteria1 *-- ISO20022.Auth091001.CompareValuationType1
    ISO20022.Auth091001.ValuationMatchingCriteria1 *-- ISO20022.Auth091001.CompareAmountAndDirection3
    class ISO20022.Auth091001.ValuationType1Code {
        MTMO = 1
        MTMA = 2
        CCPV = 3
    }
    class ISO20022.Auth091001.WeekDay3Code {
        WEND = 1
        WDAY = 2
        WEDD = 3
        TUED = 4
        THUD = 5
        SUND = 6
        SATD = 7
        MOND = 8
        FRID = 9
        IBHL = 10
        XBHL = 11
        ALLD = 12
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

## Value ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth091001.AgreementType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Tp))|

---

## Value ISO20022.Auth091001.AgriculturalCommodityDairy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityForestry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityGrain3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityLiveStock2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityOilSeed2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityOliveOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommodityPotato2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommoditySeafood2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AgriculturalCommoditySoft2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AmountAndDirection106


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth091001.AssetClassCommodity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Plprpln|ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice||XmlElement()||
|+|Ppr|ISO20022.Auth091001.AssetClassCommodityPaper4Choice||XmlElement()||
|+|OthrC10|ISO20022.Auth091001.AssetClassCommodityC10Other1||XmlElement()||
|+|Othr|ISO20022.Auth091001.AssetClassCommodityOther1||XmlElement()||
|+|OffclEcnmcSttstcs|ISO20022.Auth091001.AssetClassCommodityOfficialEconomicStatistics1||XmlElement()||
|+|MultiCmmdtyExtc|ISO20022.Auth091001.AssetClassCommodityMultiCommodityExotic1||XmlElement()||
|+|Metl|ISO20022.Auth091001.AssetClassCommodityMetal2Choice||XmlElement()||
|+|Infltn|ISO20022.Auth091001.AssetClassCommodityInflation1||XmlElement()||
|+|IndstrlPdct|ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice||XmlElement()||
|+|Indx|ISO20022.Auth091001.AssetClassCommodityIndex1||XmlElement()||
|+|Frght|ISO20022.Auth091001.AssetClassCommodityFreight4Choice||XmlElement()||
|+|Frtlzr|ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice||XmlElement()||
|+|Envttl|ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice||XmlElement()||
|+|Nrgy|ISO20022.Auth091001.AssetClassCommodityEnergy3Choice||XmlElement()||
|+|Agrcltrl|ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Plprpln),validElement(Ppr),validElement(OthrC10),validElement(Othr),validElement(OffclEcnmcSttstcs),validElement(MultiCmmdtyExtc),validElement(Metl),validElement(Infltn),validElement(IndstrlPdct),validElement(Indx),validElement(Frght),validElement(Frtlzr),validElement(Envttl),validElement(Nrgy),validElement(Agrcltrl),validChoice(Plprpln,Ppr,OthrC10,Othr,OffclEcnmcSttstcs,MultiCmmdtyExtc,Metl,Infltn,IndstrlPdct,Indx,Frght,Frtlzr,Envttl,Nrgy,Agrcltrl))|

---

## Value ISO20022.Auth091001.AssetClassCommodityAgricultural6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.AgriculturalCommodityOther2||XmlElement()||
|+|Grn|ISO20022.Auth091001.AgriculturalCommodityGrain3||XmlElement()||
|+|LiveStock|ISO20022.Auth091001.AgriculturalCommodityLiveStock2||XmlElement()||
|+|Sfd|ISO20022.Auth091001.AgriculturalCommoditySeafood2||XmlElement()||
|+|Frstry|ISO20022.Auth091001.AgriculturalCommodityForestry2||XmlElement()||
|+|Dairy|ISO20022.Auth091001.AgriculturalCommodityDairy2||XmlElement()||
|+|OlvOil|ISO20022.Auth091001.AgriculturalCommodityOliveOil3||XmlElement()||
|+|Ptt|ISO20022.Auth091001.AgriculturalCommodityPotato2||XmlElement()||
|+|Soft|ISO20022.Auth091001.AgriculturalCommoditySoft2||XmlElement()||
|+|GrnOilSeed|ISO20022.Auth091001.AgriculturalCommodityOilSeed2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Grn),validElement(LiveStock),validElement(Sfd),validElement(Frstry),validElement(Dairy),validElement(OlvOil),validElement(Ptt),validElement(Soft),validElement(GrnOilSeed),validChoice(Othr,Grn,LiveStock,Sfd,Frstry,Dairy,OlvOil,Ptt,Soft,GrnOilSeed))|

---

## Value ISO20022.Auth091001.AssetClassCommodityC10Other1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityEnergy3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.EnergyCommodityOther2||XmlElement()||
|+|Dstllts|ISO20022.Auth091001.EnergyCommodityDistillates2||XmlElement()||
|+|LghtEnd|ISO20022.Auth091001.EnergyCommodityLightEnd2||XmlElement()||
|+|RnwblNrgy|ISO20022.Auth091001.EnergyCommodityRenewableEnergy2||XmlElement()||
|+|IntrNrgy|ISO20022.Auth091001.EnergyCommodityInterEnergy2||XmlElement()||
|+|Coal|ISO20022.Auth091001.EnergyCommodityCoal2||XmlElement()||
|+|Oil|ISO20022.Auth091001.EnergyCommodityOil3||XmlElement()||
|+|NtrlGas|ISO20022.Auth091001.EnergyCommodityNaturalGas3||XmlElement()||
|+|Elctrcty|ISO20022.Auth091001.EnergyCommodityElectricity2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Dstllts),validElement(LghtEnd),validElement(RnwblNrgy),validElement(IntrNrgy),validElement(Coal),validElement(Oil),validElement(NtrlGas),validElement(Elctrcty),validChoice(Othr,Dstllts,LghtEnd,RnwblNrgy,IntrNrgy,Coal,Oil,NtrlGas,Elctrcty))|

---

## Value ISO20022.Auth091001.AssetClassCommodityEnvironmental3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.EnvironmentCommodityOther2||XmlElement()||
|+|CrbnRltd|ISO20022.Auth091001.EnvironmentalCommodityCarbonRelated2||XmlElement()||
|+|Wthr|ISO20022.Auth091001.EnvironmentalCommodityWeather2||XmlElement()||
|+|Emssns|ISO20022.Auth091001.EnvironmentalCommodityEmission3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CrbnRltd),validElement(Wthr),validElement(Emssns),validChoice(Othr,CrbnRltd,Wthr,Emssns))|

---

## Value ISO20022.Auth091001.AssetClassCommodityFertilizer4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.FertilizerCommodityOther2||XmlElement()||
|+|UreaAndAmmnmNtrt|ISO20022.Auth091001.FertilizerCommodityUreaAndAmmoniumNitrate2||XmlElement()||
|+|Urea|ISO20022.Auth091001.FertilizerCommodityUrea2||XmlElement()||
|+|Slphr|ISO20022.Auth091001.FertilizerCommoditySulphur2||XmlElement()||
|+|Ptsh|ISO20022.Auth091001.FertilizerCommodityPotash2||XmlElement()||
|+|DmmnmPhspht|ISO20022.Auth091001.FertilizerCommodityDiammoniumPhosphate2||XmlElement()||
|+|Ammn|ISO20022.Auth091001.FertilizerCommodityAmmonia2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(UreaAndAmmnmNtrt),validElement(Urea),validElement(Slphr),validElement(Ptsh),validElement(DmmnmPhspht),validElement(Ammn),validChoice(Othr,UreaAndAmmnmNtrt,Urea,Slphr,Ptsh,DmmnmPhspht,Ammn))|

---

## Value ISO20022.Auth091001.AssetClassCommodityFreight4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.FreightCommodityOther2||XmlElement()||
|+|CntnrShip|ISO20022.Auth091001.FreightCommodityContainerShip2||XmlElement()||
|+|Wet|ISO20022.Auth091001.FreightCommodityWet3||XmlElement()||
|+|Dry|ISO20022.Auth091001.FreightCommodityDry3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(CntnrShip),validElement(Wet),validElement(Dry),validChoice(Othr,CntnrShip,Wet,Dry))|

---

## Value ISO20022.Auth091001.AssetClassCommodityIndex1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityIndustrialProduct2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Manfctg|ISO20022.Auth091001.IndustrialProductCommodityManufacturing2||XmlElement()||
|+|Cnstrctn|ISO20022.Auth091001.IndustrialProductCommodityConstruction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Manfctg),validElement(Cnstrctn),validChoice(Manfctg,Cnstrctn))|

---

## Value ISO20022.Auth091001.AssetClassCommodityInflation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityMetal2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prcs|ISO20022.Auth091001.MetalCommodityPrecious2||XmlElement()||
|+|NonPrcs|ISO20022.Auth091001.MetalCommodityNonPrecious2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prcs),validElement(NonPrcs),validChoice(Prcs,NonPrcs))|

---

## Value ISO20022.Auth091001.AssetClassCommodityMultiCommodityExotic1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityOfficialEconomicStatistics1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.AssetClassCommodityPaper4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.PaperCommodityOther1||XmlElement()||
|+|RcvrdPpr|ISO20022.Auth091001.PaperCommodityOther1||XmlElement()||
|+|Pulp|ISO20022.Auth091001.PaperCommodityPulp2||XmlElement()||
|+|Nwsprnt|ISO20022.Auth091001.PaperCommodityNewsprint2||XmlElement()||
|+|CntnrBrd|ISO20022.Auth091001.PaperCommodityContainerBoard2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(RcvrdPpr),validElement(Pulp),validElement(Nwsprnt),validElement(CntnrBrd),validChoice(Othr,RcvrdPpr,Pulp,Nwsprnt,CntnrBrd))|

---

## Value ISO20022.Auth091001.AssetClassCommodityPolypropylene4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.PolypropyleneCommodityOther2||XmlElement()||
|+|Plstc|ISO20022.Auth091001.PolypropyleneCommodityPlastic2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Plstc),validChoice(Othr,Plstc))|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType10Code


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

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLVR|Int32||XmlEnum("""SLVR""")|1|
||PTNM|Int32||XmlEnum("""PTNM""")|2|
||PLDM|Int32||XmlEnum("""PLDM""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||GOLD|Int32||XmlEnum("""GOLD""")|5|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RICE|Int32||XmlEnum("""RICE""")|1|
||CORN|Int32||XmlEnum("""CORN""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||RPSD|Int32||XmlEnum("""RPSD""")|4|
||SOYB|Int32||XmlEnum("""SOYB""")|5|
||FWHT|Int32||XmlEnum("""FWHT""")|6|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LAMP|Int32||XmlEnum("""LAMP""")|2|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WHSG|Int32||XmlEnum("""WHSG""")|2|
||BRWN|Int32||XmlEnum("""BRWN""")|3|
||CCOA|Int32||XmlEnum("""CCOA""")|4|
||ROBU|Int32||XmlEnum("""ROBU""")|5|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MWHT|Int32||XmlEnum("""MWHT""")|2|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NBPG|Int32||XmlEnum("""NBPG""")|2|
||TTFG|Int32||XmlEnum("""TTFG""")|3|
||NCGG|Int32||XmlEnum("""NCGG""")|4|
||LNGG|Int32||XmlEnum("""LNGG""")|5|
||GASP|Int32||XmlEnum("""GASP""")|6|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType32Code


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

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DBCR|Int32||XmlEnum("""DBCR""")|2|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||TNKR|Int32||XmlEnum("""TNKR""")|2|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||OFFP|Int32||XmlEnum("""OFFP""")|2|
||PKLD|Int32||XmlEnum("""PKLD""")|3|
||FITR|Int32||XmlEnum("""FITR""")|4|
||BSLD|Int32||XmlEnum("""BSLD""")|5|

---

## Enum ISO20022.Auth091001.AssetClassDetailedSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||EUAA|Int32||XmlEnum("""EUAA""")|2|
||EUAE|Int32||XmlEnum("""EUAE""")|3|
||ERUE|Int32||XmlEnum("""ERUE""")|4|
||CERE|Int32||XmlEnum("""CERE""")|5|

---

## Enum ISO20022.Auth091001.AssetClassProductType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHC|Int32||XmlEnum("""OTHC""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFL|Int32||XmlEnum("""INFL""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MCEX|Int32||XmlEnum("""MCEX""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OEST|Int32||XmlEnum("""OEST""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRI|Int32||XmlEnum("""AGRI""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRGY|Int32||XmlEnum("""NRGY""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ENVR|Int32||XmlEnum("""ENVR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRGT|Int32||XmlEnum("""FRGT""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTL|Int32||XmlEnum("""FRTL""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDP|Int32||XmlEnum("""INDP""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||METL|Int32||XmlEnum("""METL""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassProductType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POLY|Int32||XmlEnum("""POLY""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EMIS|Int32||XmlEnum("""EMIS""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NPRM|Int32||XmlEnum("""NPRM""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRME|Int32||XmlEnum("""PRME""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLST|Int32||XmlEnum("""PLST""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GROS|Int32||XmlEnum("""GROS""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIRY|Int32||XmlEnum("""DIRY""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType21Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRST|Int32||XmlEnum("""FRST""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType22Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LSTK|Int32||XmlEnum("""LSTK""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType23Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEAF|Int32||XmlEnum("""SEAF""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COAL|Int32||XmlEnum("""COAL""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INRG|Int32||XmlEnum("""INRG""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LGHT|Int32||XmlEnum("""LGHT""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RNNG|Int32||XmlEnum("""RNNG""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType29Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CRBR|Int32||XmlEnum("""CRBR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType30Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHR|Int32||XmlEnum("""WTHR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType31Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRYF|Int32||XmlEnum("""DRYF""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType32Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WETF|Int32||XmlEnum("""WETF""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSTR|Int32||XmlEnum("""CSTR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MFTG|Int32||XmlEnum("""MFTG""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBRD|Int32||XmlEnum("""CBRD""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType36Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NSPT|Int32||XmlEnum("""NSPT""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PULP|Int32||XmlEnum("""PULP""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType39Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMMO|Int32||XmlEnum("""AMMO""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OOLI|Int32||XmlEnum("""OOLI""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DAPH|Int32||XmlEnum("""DAPH""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType41Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PTSH|Int32||XmlEnum("""PTSH""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType42Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLPH|Int32||XmlEnum("""SLPH""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType43Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UREA|Int32||XmlEnum("""UREA""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType44Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UAAN|Int32||XmlEnum("""UAAN""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType45Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POTA|Int32||XmlEnum("""POTA""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType46Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSHP|Int32||XmlEnum("""CSHP""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType49Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRIN|Int32||XmlEnum("""GRIN""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELEC|Int32||XmlEnum("""ELEC""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NGAS|Int32||XmlEnum("""NGAS""")|1|

---

## Enum ISO20022.Auth091001.AssetClassSubProductType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OILP|Int32||XmlEnum("""OILP""")|1|

---

## Value ISO20022.Auth091001.BasketConstituents3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitOfMeasr|ISO20022.Auth091001.UnitOfMeasure8Choice||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|InstrmId|ISO20022.Auth091001.InstrumentIdentification6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UnitOfMeasr),validElement(InstrmId))|

---

## Value ISO20022.Auth091001.Cleared23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrd|ISO20022.Auth091001.ClearingExceptionOrExemption3Choice||XmlElement()||
|+|IntndToClear|ISO20022.Auth091001.ClearingPartyAndTime22Choice||XmlElement()||
|+|Clrd|ISO20022.Auth091001.ClearingPartyAndTime21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonClrd),validElement(IntndToClear),validElement(Clrd),validChoice(NonClrd,IntndToClear,Clrd))|

---

## Enum ISO20022.Auth091001.ClearingAccountType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HOUS|Int32||XmlEnum("""HOUS""")|1|
||CLIE|Int32||XmlEnum("""CLIE""")|2|

---

## Value ISO20022.Auth091001.ClearingExceptionOrExemption2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCtrPty|ISO20022.Auth091001.NonClearingReason2||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth091001.NonClearingReason2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth091001.ClearingExceptionOrExemption3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPties|ISO20022.Auth091001.ClearingExceptionOrExemption2||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrPties),validChoice(CtrPties,Rsn))|

---

## Enum ISO20022.Auth091001.ClearingExemptionException1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMBK|Int32||XmlEnum("""SMBK""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NORE|Int32||XmlEnum("""NORE""")|3|
||NOAL|Int32||XmlEnum("""NOAL""")|4|
||AFFL|Int32||XmlEnum("""AFFL""")|5|
||ENDU|Int32||XmlEnum("""ENDU""")|6|
||COOP|Int32||XmlEnum("""COOP""")|7|

---

## Enum ISO20022.Auth091001.ClearingObligationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRUE|Int32||XmlEnum("""TRUE""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||FLSE|Int32||XmlEnum("""FLSE""")|3|

---

## Value ISO20022.Auth091001.ClearingPartyAndTime21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth091001.ClearingPartyAndTime22||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validChoice(Dtls,Rsn))|

---

## Value ISO20022.Auth091001.ClearingPartyAndTime22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrAcctOrgn|String||XmlElement()||
|+|OrgnlTradRpstryIdr|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|OrgnlIdr|ISO20022.Auth091001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|ClrIdr|ISO20022.Auth091001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|ClrDtTm|DateTime||XmlElement()||
|+|ClrRctDtTm|DateTime||XmlElement()||
|+|CCP|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlTradRpstryIdr),validElement(OrgnlIdr),validElement(ClrIdr),validElement(CCP))|

---

## Value ISO20022.Auth091001.ClearingPartyAndTime22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|ISO20022.Auth091001.ClearingPartyAndTime23||XmlElement()||
|+|Rsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dtls),validChoice(Dtls,Rsn))|

---

## Value ISO20022.Auth091001.ClearingPartyAndTime23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlTradRpstryIdr|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|OrgnlIdr|ISO20022.Auth091001.UniqueTransactionIdentifier1Choice||XmlElement()||
|+|ClrIdr|ISO20022.Auth091001.UniqueTransactionIdentifier1Choice||XmlElement()||
|+|ClrDtTm|DateTime||XmlElement()||
|+|ClrRctDtTm|DateTime||XmlElement()||
|+|CCP|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlTradRpstryIdr),validElement(OrgnlIdr),validElement(ClrIdr),validElement(CCP))|

---

## Value ISO20022.Auth091001.CollateralPortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgnPrtflCd|ISO20022.Auth091001.MarginPortfolio3||XmlElement()||
|+|Prtfl|ISO20022.Auth091001.PortfolioCode3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnPrtflCd),validElement(Prtfl),validChoice(MrgnPrtflCd,Prtfl))|

---

## Value ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
|+|Val1|ISO20022.Auth091001.ActiveOrHistoricCurrencyAnd19DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{3,3}"""),validPattern("""Val1""",Val1,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth091001.CompareAmountAndDirection3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.AmountAndDirection106||XmlElement()||
|+|Val1|ISO20022.Auth091001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareAssetClass1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareBenchmarkCode1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareCFIIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{6,6}"""),validPattern("""Val1""",Val1,"""[A-Z]{6,6}"""))|

---

## Value ISO20022.Auth091001.CompareCommodityAssetClass4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.AssetClassCommodity6Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.AssetClassCommodity6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareDate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|DateTime||XmlElement()||
|+|Val1|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareDatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.DatePeriod4||XmlElement()||
|+|Val1|ISO20022.Auth091001.DatePeriod4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareDateTime3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|DateTime||XmlElement()||
|+|Val1|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareDayCount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.InterestComputationMethodFormat7||XmlElement()||
|+|Val1|ISO20022.Auth091001.InterestComputationMethodFormat7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareDeliveryType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareDerivativeEvent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.DerivativeEvent6||XmlElement()||
|+|Val1|ISO20022.Auth091001.DerivativeEvent6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareDurationType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareEnergyDeliveryAttribute1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NrgyPricTmIntrvlQty|ISO20022.Auth091001.CompareAmountAndDirection3||XmlElement()||
|+|NrgyQtyUnit|ISO20022.Auth091001.CompareEnergyQuantityUnit1||XmlElement()||
|+|NrgyDlvryCpcty|ISO20022.Auth091001.CompareLongFraction19DecimalNumber1||XmlElement()||
|+|NrgyWkDay|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareWeekDay1>||XmlElement()||
|+|NrgyDrtn|ISO20022.Auth091001.CompareDurationType1||XmlElement()||
|+|NrgyDt|ISO20022.Auth091001.CompareDatePeriod2||XmlElement()||
|+|NrgyDlvryIntrvl|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareTimePeriod2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NrgyPricTmIntrvlQty),validElement(NrgyQtyUnit),validElement(NrgyDlvryCpcty),validList("""NrgyWkDay""",NrgyWkDay),validElement(NrgyWkDay),validElement(NrgyDrtn),validElement(NrgyDt),validList("""NrgyDlvryIntrvl""",NrgyDlvryIntrvl),validElement(NrgyDlvryIntrvl))|

---

## Value ISO20022.Auth091001.CompareEnergyLoadType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareEnergyQuantityUnit1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.EnergyQuantityUnit2Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.EnergyQuantityUnit2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareExchangeRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareExchangeRateBasis1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.ExchangeRateBasis1Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.ExchangeRateBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareFinancialInstrumentContractType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareFrequencyUnit1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareISINIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validPattern("""Val1""",Val1,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth091001.CompareISINIdentifier4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validPattern("""Val1""",Val1,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth091001.CompareLegDirection2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.Direction4Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.Direction4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareLongFraction19DecimalNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareMICIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Val2""",Val2,"""[A-Z0-9]{4,4}"""),validPattern("""Val1""",Val1,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Auth091001.CompareMasterAgreementType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.AgreementType2Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareMax350Text1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareMax50Text1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareNumber5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareNumber7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareOptionStyle1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareOptionType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareOrganisationIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareOrganisationIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.PartyIdentification236Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.PartyIdentification236Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareOtherPayment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPmtRcvr|ISO20022.Auth091001.CompareOrganisationIdentification7||XmlElement()||
|+|OthrPmtPyer|ISO20022.Auth091001.CompareOrganisationIdentification7||XmlElement()||
|+|OthrPmtDt|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|OthrPmtAmt|ISO20022.Auth091001.CompareAmountAndDirection3||XmlElement()||
|+|OthrPmtTp|ISO20022.Auth091001.CompareOtherPaymentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPmtRcvr),validElement(OthrPmtPyer),validElement(OthrPmtDt),validElement(OthrPmtAmt),validElement(OthrPmtTp))|

---

## Value ISO20022.Auth091001.CompareOtherPaymentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.PaymentType5Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.PaymentType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.ComparePercentageRate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|Decimal||XmlElement()||
|+|Val1|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.ComparePostTradeRiskReduction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.PTRREvent3||XmlElement()||
|+|Val1|ISO20022.Auth091001.PTRREvent3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareReferenceParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.DerivativePartyIdentification1Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.DerivativePartyIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareReportingLevelType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareSeniorityType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareText1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareText2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareTimePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.TimePeriod3||XmlElement()||
|+|Val1|ISO20022.Auth091001.TimePeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareTradeClearingObligation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareTradeClearingStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.Cleared23Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.Cleared23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareTradeConfirmation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.TradeConfirmation3Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.TradeConfirmation3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareTrancheIndicator1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.TrancheIndicator3Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.TrancheIndicator3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareTrueFalseIndicator3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareUnderlyingInstrument3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.SecurityIdentification41Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.SecurityIdentification41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUniqueProductIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.UniqueProductIdentifier2Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.UniqueProductIdentifier2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUniqueTransactionIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.UniqueTransactionIdentifier2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUnitPrice4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.SecuritiesTransactionPrice17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUnitPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.SecuritiesTransactionPrice17Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.SecuritiesTransactionPrice17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUnitPrice7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.SecuritiesTransactionPrice14Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.SecuritiesTransactionPrice14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareUnitPrice8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|ISO20022.Auth091001.SecuritiesTransactionPrice13Choice||XmlElement()||
|+|Val1|ISO20022.Auth091001.SecuritiesTransactionPrice13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val2),validElement(Val1))|

---

## Value ISO20022.Auth091001.CompareValuationType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.CompareWeekDay1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val2|String||XmlElement()||
|+|Val1|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.ContractMatchingCriteria3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmCcyScndLeg|ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1||XmlElement()||
|+|SttlmCcy|ISO20022.Auth091001.CompareActiveOrHistoricCurrencyCode1||XmlElement()||
|+|UndrlygInstrm|ISO20022.Auth091001.CompareUnderlyingInstrument3||XmlElement()||
|+|DerivBasedOnCrptAsst|ISO20022.Auth091001.CompareTrueFalseIndicator3||XmlElement()||
|+|AsstClss|ISO20022.Auth091001.CompareAssetClass1||XmlElement()||
|+|CtrctTp|ISO20022.Auth091001.CompareFinancialInstrumentContractType1||XmlElement()||
|+|PdctClssfctn|ISO20022.Auth091001.CompareCFIIdentifier3||XmlElement()||
|+|AltrntvInstrmId|ISO20022.Auth091001.CompareText1||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth091001.CompareUniqueProductIdentifier2||XmlElement()||
|+|ISIN|ISO20022.Auth091001.CompareISINIdentifier2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmCcyScndLeg),validElement(SttlmCcy),validElement(UndrlygInstrm),validElement(DerivBasedOnCrptAsst),validElement(AsstClss),validElement(CtrctTp),validElement(PdctClssfctn),validElement(AltrntvInstrmId),validElement(UnqPdctIdr),validElement(ISIN))|

---

## Value ISO20022.Auth091001.CounterpartyData91


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NttyRspnsblForRpt|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|RptSubmitgNtty|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth091001.PartyIdentification236Choice||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NttyRspnsblForRpt),validElement(RptSubmitgNtty),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth091001.CounterpartyMatchingCriteria6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctnOrSd|ISO20022.Auth091001.CompareLegDirection2||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth091001.CompareOrganisationIdentification7||XmlElement()||
|+|RptgCtrPty|ISO20022.Auth091001.CompareOrganisationIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrctnOrSd),validElement(OthrCtrPty),validElement(RptgCtrPty))|

---

## Value ISO20022.Auth091001.CustomBasket4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cnsttnts|global::System.Collections.Generic.List<ISO20022.Auth091001.BasketConstituents3>||XmlElement()||
|+|Id|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cnsttnts""",Cnsttnts),validElement(Cnsttnts),validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth091001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Auth091001.DatePeriod4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.DebtInstrumentSeniorityType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SNDB|Int32||XmlEnum("""SNDB""")|2|
||SBOD|Int32||XmlEnum("""SBOD""")|3|

---

## Value ISO20022.Auth091001.DeliveryInterconnectionPoint1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Cd""",Cd,"""[A-Z0-9\-]{16}"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth091001.DerivativeEvent6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmdmntInd|String||XmlElement()||
|+|TmStmp|ISO20022.Auth091001.DateAndDateTime2Choice||XmlElement()||
|+|Id|ISO20022.Auth091001.EventIdentifier1Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TmStmp),validElement(Id))|

---

## Enum ISO20022.Auth091001.DerivativeEventType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UPDT|Int32||XmlEnum("""UPDT""")|1|
||TRAD|Int32||XmlEnum("""TRAD""")|2|
||PTNG|Int32||XmlEnum("""PTNG""")|3|
||NOVA|Int32||XmlEnum("""NOVA""")|4|
||INCP|Int32||XmlEnum("""INCP""")|5|
||EXER|Int32||XmlEnum("""EXER""")|6|
||ETRM|Int32||XmlEnum("""ETRM""")|7|
||CREV|Int32||XmlEnum("""CREV""")|8|
||CORP|Int32||XmlEnum("""CORP""")|9|
||COMP|Int32||XmlEnum("""COMP""")|10|
||CLAL|Int32||XmlEnum("""CLAL""")|11|
||CLRG|Int32||XmlEnum("""CLRG""")|12|
||ALOC|Int32||XmlEnum("""ALOC""")|13|

---

## Value ISO20022.Auth091001.DerivativePartyIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""CtrySubDvsn""",CtrySubDvsn,"""[A-Z]{2,2}\-[0-9A-Z]{1,3}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(LEI,CtrySubDvsn,Ctry))|

---

## Aspect ISO20022.Auth091001.DerivativesTradeReconciliationStatisticalReportV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth091001.SupplementaryData1>||XmlElement()||
|+|RcncltnSttstcs|ISO20022.Auth091001.StatisticsPerCounterparty19Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RcncltnSttstcs))|

---

## Value ISO20022.Auth091001.Direction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrctnOfTheScndLeg|String||XmlElement()||
|+|DrctnOfTheFrstLeg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.Direction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrPtySd|String||XmlElement()||
|+|Drctn|ISO20022.Auth091001.Direction2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Drctn),validChoice(CtrPtySd,Drctn))|

---

## Type ISO20022.Auth091001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DerivsTradRcncltnSttstclRpt|ISO20022.Auth091001.DerivativesTradeReconciliationStatisticalReportV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradRcncltnSttstclRpt))|

---

## Enum ISO20022.Auth091001.DurationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||DASD|Int32||XmlEnum("""DASD""")|2|
||HOUR|Int32||XmlEnum("""HOUR""")|3|
||MNUT|Int32||XmlEnum("""MNUT""")|4|
||MNTH|Int32||XmlEnum("""MNTH""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||SEAS|Int32||XmlEnum("""SEAS""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Auth091001.EnergyCommodityCoal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityDistillates2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityElectricity2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityInterEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityLightEnd2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityNaturalGas3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityOil3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnergyCommodityRenewableEnergy2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.EnergyLoadType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHPD|Int32||XmlEnum("""SHPD""")|1|
||PKLD|Int32||XmlEnum("""PKLD""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||OFFP|Int32||XmlEnum("""OFFP""")|4|
||HABH|Int32||XmlEnum("""HABH""")|5|
||GASD|Int32||XmlEnum("""GASD""")|6|
||BSLD|Int32||XmlEnum("""BSLD""")|7|

---

## Value ISO20022.Auth091001.EnergyQuantityUnit2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth091001.EnergyQuantityUnit2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||THMD|Int32||XmlEnum("""THMD""")|1|
||MWHH|Int32||XmlEnum("""MWHH""")|2|
||MWHD|Int32||XmlEnum("""MWHD""")|3|
||MWAT|Int32||XmlEnum("""MWAT""")|4|
||MTMD|Int32||XmlEnum("""MTMD""")|5|
||MMJD|Int32||XmlEnum("""MMJD""")|6|
||MBTD|Int32||XmlEnum("""MBTD""")|7|
||MJDD|Int32||XmlEnum("""MJDD""")|8|
||MCMD|Int32||XmlEnum("""MCMD""")|9|
||KWHH|Int32||XmlEnum("""KWHH""")|10|
||KWHD|Int32||XmlEnum("""KWHD""")|11|
||KWAT|Int32||XmlEnum("""KWAT""")|12|
||KTMD|Int32||XmlEnum("""KTMD""")|13|
||HMJD|Int32||XmlEnum("""HMJD""")|14|
||GWHH|Int32||XmlEnum("""GWHH""")|15|
||GWHD|Int32||XmlEnum("""GWHD""")|16|
||GWAT|Int32||XmlEnum("""GWAT""")|17|
||GJDD|Int32||XmlEnum("""GJDD""")|18|
||CMPD|Int32||XmlEnum("""CMPD""")|19|
||BTUD|Int32||XmlEnum("""BTUD""")|20|

---

## Value ISO20022.Auth091001.EnvironmentCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnvironmentalCommodityCarbonRelated2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnvironmentalCommodityEmission3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EnvironmentalCommodityWeather2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.EventIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstTradRskRdctnIdr|ISO20022.Auth091001.PostTradeRiskReductionIdentifier1||XmlElement()||
|+|EvtIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstTradRskRdctnIdr),validPattern("""EvtIdr""",EvtIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(PstTradRskRdctnIdr,EvtIdr))|

---

## Value ISO20022.Auth091001.ExchangeRateBasis1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtdCcy|String||XmlElement()||
|+|BaseCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Auth091001.ExchangeRateBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|CcyPair|ISO20022.Auth091001.ExchangeRateBasis1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyPair),validChoice(Prtry,CcyPair))|

---

## Value ISO20022.Auth091001.FertilizerCommodityAmmonia2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommodityDiammoniumPhosphate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommodityPotash2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommoditySulphur2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommodityUrea2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FertilizerCommodityUreaAndAmmoniumNitrate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.FinancialInstrumentContractType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SWPT|Int32||XmlEnum("""SWPT""")|2|
||SWAP|Int32||XmlEnum("""SWAP""")|3|
||SPDB|Int32||XmlEnum("""SPDB""")|4|
||OPTN|Int32||XmlEnum("""OPTN""")|5|
||FORW|Int32||XmlEnum("""FORW""")|6|
||FUTR|Int32||XmlEnum("""FUTR""")|7|
||FRAS|Int32||XmlEnum("""FRAS""")|8|
||CFDS|Int32||XmlEnum("""CFDS""")|9|

---

## Value ISO20022.Auth091001.FreightCommodityContainerShip2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FreightCommodityDry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FreightCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.FreightCommodityWet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.Frequency13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QURT|Int32||XmlEnum("""QURT""")|1|
||MIAN|Int32||XmlEnum("""MIAN""")|2|
||EXPI|Int32||XmlEnum("""EXPI""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|
||MNTH|Int32||XmlEnum("""MNTH""")|6|
||WEEK|Int32||XmlEnum("""WEEK""")|7|
||DAIL|Int32||XmlEnum("""DAIL""")|8|

---

## Value ISO20022.Auth091001.GenericIdentification175


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.GenericIdentification179


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.GenericIdentification184


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Src|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.GenericIdentification185


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.IndexIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indx|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Auth091001.IndustrialProductCommodityConstruction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.IndustrialProductCommodityManufacturing2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.InstrumentIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|ISO20022.Auth091001.GenericIdentification184||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth091001.UniqueProductIdentifier1Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrId,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Enum ISO20022.Auth091001.InterestComputationMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||A020|Int32||XmlEnum("""A020""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|
||A016|Int32||XmlEnum("""A016""")|3|
||A007|Int32||XmlEnum("""A007""")|4|
||A013|Int32||XmlEnum("""A013""")|5|
||A012|Int32||XmlEnum("""A012""")|6|
||A003|Int32||XmlEnum("""A003""")|7|
||A002|Int32||XmlEnum("""A002""")|8|
||A001|Int32||XmlEnum("""A001""")|9|
||A011|Int32||XmlEnum("""A011""")|10|
||A018|Int32||XmlEnum("""A018""")|11|
||A015|Int32||XmlEnum("""A015""")|12|
||A008|Int32||XmlEnum("""A008""")|13|
||A006|Int32||XmlEnum("""A006""")|14|
||A010|Int32||XmlEnum("""A010""")|15|
||A014|Int32||XmlEnum("""A014""")|16|
||A009|Int32||XmlEnum("""A009""")|17|
||A005|Int32||XmlEnum("""A005""")|18|
||A017|Int32||XmlEnum("""A017""")|19|
||A019|Int32||XmlEnum("""A019""")|20|
||A004|Int32||XmlEnum("""A004""")|21|

---

## Value ISO20022.Auth091001.InterestComputationMethodFormat7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.LegalPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Auth091001.MarginPortfolio3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VartnMrgnPrtflCd|ISO20022.Auth091001.PortfolioCode5Choice||XmlElement()||
|+|InitlMrgnPrtflCd|ISO20022.Auth091001.PortfolioCode5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VartnMrgnPrtflCd),validElement(InitlMrgnPrtflCd))|

---

## Value ISO20022.Auth091001.MasterAgreement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrMstrAgrmtDtls|String||XmlElement()||
|+|Vrsn|String||XmlElement()||
|+|Tp|ISO20022.Auth091001.AgreementType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Auth091001.MatchingCriteria17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxMtchgCrit|ISO20022.Auth091001.TransactionMatchingCriteria7||XmlElement()||
|+|CtrctMtchgCrit|ISO20022.Auth091001.ContractMatchingCriteria3||XmlElement()||
|+|ValtnMtchgCrit|ISO20022.Auth091001.ValuationMatchingCriteria1||XmlElement()||
|+|CtrPtyMtchgCrit|ISO20022.Auth091001.CounterpartyMatchingCriteria6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxMtchgCrit),validElement(CtrctMtchgCrit),validElement(ValtnMtchgCrit),validElement(CtrPtyMtchgCrit))|

---

## Value ISO20022.Auth091001.MetalCommodityNonPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.MetalCommodityPrecious2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlSubPdct|String||XmlElement()||
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.ModificationLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TCTN|Int32||XmlEnum("""TCTN""")|1|
||PSTN|Int32||XmlEnum("""PSTN""")|2|

---

## Value ISO20022.Auth091001.NaturalPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth091001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth091001.NaturalPersonIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Auth091001.NaturalPersonIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Auth091001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Auth091001.NonClearingReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonClrRsnInf|String||XmlElement()||
|+|ClrXmptnXcptn|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ClrXmptnXcptn""",ClrXmptnXcptn))|

---

## Enum ISO20022.Auth091001.NotApplicable1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|

---

## Enum ISO20022.Auth091001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Enum ISO20022.Auth091001.OptionParty3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|

---

## Enum ISO20022.Auth091001.OptionStyle6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AMER|Int32||XmlEnum("""AMER""")|1|
||ASIA|Int32||XmlEnum("""ASIA""")|2|
||BERM|Int32||XmlEnum("""BERM""")|3|
||EURO|Int32||XmlEnum("""EURO""")|4|

---

## Enum ISO20022.Auth091001.OptionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||PUTO|Int32||XmlEnum("""PUTO""")|2|
||CALL|Int32||XmlEnum("""CALL""")|3|

---

## Value ISO20022.Auth091001.OrganisationIdentification15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AnyBIC|String||XmlElement()||
|+|Othr|ISO20022.Auth091001.OrganisationIdentification38||XmlElement()||
|+|LEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validChoice(AnyBIC,Othr,LEI))|

---

## Value ISO20022.Auth091001.OrganisationIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dmcl|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Auth091001.GenericIdentification175||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Auth091001.PTRREvent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcPrvdr|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
|+|Tchnq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SvcPrvdr))|

---

## Enum ISO20022.Auth091001.PairingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNPR|Int32||XmlEnum("""UNPR""")|1|
||PARD|Int32||XmlEnum("""PARD""")|2|

---

## Value ISO20022.Auth091001.PaperCommodityContainerBoard2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PaperCommodityNewsprint2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PaperCommodityOther1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PaperCommodityPulp2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PartyIdentification236Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth091001.NaturalPersonIdentification2||XmlElement()||
|+|Lgl|ISO20022.Auth091001.OrganisationIdentification15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Value ISO20022.Auth091001.PartyIdentification248Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntrl|ISO20022.Auth091001.NaturalPersonIdentification3||XmlElement()||
|+|Lgl|ISO20022.Auth091001.LegalPersonIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntrl),validElement(Lgl),validChoice(Ntrl,Lgl))|

---

## Enum ISO20022.Auth091001.PaymentType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEXH|Int32||XmlEnum("""PEXH""")|1|
||UWIN|Int32||XmlEnum("""UWIN""")|2|
||UFRO|Int32||XmlEnum("""UFRO""")|3|

---

## Value ISO20022.Auth091001.PaymentType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryTp|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtryTp""",PrtryTp,"""[a-zA-Z0-9]{1,4}"""),validChoice(PrtryTp,Tp))|

---

## Enum ISO20022.Auth091001.PhysicalTransferType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CASH|Int32||XmlEnum("""CASH""")|1|
||OPTL|Int32||XmlEnum("""OPTL""")|2|
||PHYS|Int32||XmlEnum("""PHYS""")|3|

---

## Value ISO20022.Auth091001.PolypropyleneCommodityOther2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PolypropyleneCommodityPlastic2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubPdct|String||XmlElement()||
|+|BasePdct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PortfolioCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(NoPrtfl,Cd))|

---

## Value ISO20022.Auth091001.PortfolioCode5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoPrtfl|String||XmlElement()||
|+|Prtfl|ISO20022.Auth091001.PortfolioIdentification3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtfl),validChoice(NoPrtfl,Prtfl))|

---

## Value ISO20022.Auth091001.PortfolioIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTxXmptn|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.PostTradeRiskReductionIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Strr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Strr""",Strr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Auth091001.PriceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||PNDG|Int32||XmlEnum("""PNDG""")|2|

---

## Enum ISO20022.Auth091001.ProductType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||COMM|Int32||XmlEnum("""COMM""")|2|
||INTR|Int32||XmlEnum("""INTR""")|3|
||EQUI|Int32||XmlEnum("""EQUI""")|4|
||CURR|Int32||XmlEnum("""CURR""")|5|
||CRDT|Int32||XmlEnum("""CRDT""")|6|

---

## Value ISO20022.Auth091001.ReconciliationCategory4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrthrMod|String||XmlElement()||
|+|Rvvd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.ReconciliationCategory5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrthrMod|String||XmlElement()||
|+|Rvvd|String||XmlElement()||
|+|ValtnRcncltn|String||XmlElement()||
|+|Rcncltn|String||XmlElement()||
|+|Pairg|String||XmlElement()||
|+|RptgTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcncltnRpt|global::System.Collections.Generic.List<ISO20022.Auth091001.ReconciliationReport15>||XmlElement()||
|+|TtlNbOfTxs|Decimal||XmlElement()||
|+|CtrPtyId|ISO20022.Auth091001.CounterpartyData91||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""RcncltnRpt""",RcncltnRpt),validList("""RcncltnRpt""",RcncltnRpt),validElement(RcncltnRpt),validElement(CtrPtyId))|

---

## Value ISO20022.Auth091001.ReconciliationReport15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtchgCrit|ISO20022.Auth091001.MatchingCriteria17||XmlElement()||
|+|TxId|ISO20022.Auth091001.TradeTransactionIdentification24||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtchgCrit),validElement(TxId))|

---

## Value ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Auth091001.ReconciliationCounterpartyPairStatistics7>||XmlElement()||
|+|TtlNbOfTxs|Decimal||XmlElement()||
|+|RcncltnCtgrs|ISO20022.Auth091001.ReportingRequirement3Choice||XmlElement()||
|+|RefDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(RcncltnCtgrs))|

---

## Enum ISO20022.Auth091001.ReconciliationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECO|Int32||XmlEnum("""RECO""")|1|
||NREC|Int32||XmlEnum("""NREC""")|2|

---

## Enum ISO20022.Auth091001.ReconciliationStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOAP|Int32||XmlEnum("""NOAP""")|1|
||RECO|Int32||XmlEnum("""RECO""")|2|
||NREC|Int32||XmlEnum("""NREC""")|3|

---

## Enum ISO20022.Auth091001.ReportPeriodActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOTX|Int32||XmlEnum("""NOTX""")|1|

---

## Value ISO20022.Auth091001.ReportingRequirement3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoRptgRqrmnt|ISO20022.Auth091001.ReconciliationCategory4||XmlElement()||
|+|RptgRqrmnt|ISO20022.Auth091001.ReconciliationCategory5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NoRptgRqrmnt),validElement(RptgRqrmnt),validChoice(NoRptgRqrmnt,RptgRqrmnt))|

---

## Enum ISO20022.Auth091001.RiskReductionService1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PWAS|Int32||XmlEnum("""PWAS""")|1|
||PRBM|Int32||XmlEnum("""PRBM""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||PWOS|Int32||XmlEnum("""PWOS""")|4|
||NORR|Int32||XmlEnum("""NORR""")|5|

---

## Value ISO20022.Auth091001.SecuritiesTransactionPrice13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth091001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MntryVal),validChoice(BsisPtSprd,Dcml,Pctg,MntryVal))|

---

## Value ISO20022.Auth091001.SecuritiesTransactionPrice14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dcml|Decimal||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Dcml,Rate))|

---

## Value ISO20022.Auth091001.SecuritiesTransactionPrice17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth091001.SecuritiesTransactionPrice5||XmlElement()||
|+|PdgPric|String||XmlElement()||
|+|Dcml|Decimal||XmlElement()||
|+|Yld|Decimal||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|MntryVal|ISO20022.Auth091001.AmountAndDirection106||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(MntryVal),validChoice(Othr,PdgPric,Dcml,Yld,Pctg,Unit,MntryVal))|

---

## Value ISO20022.Auth091001.SecuritiesTransactionPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.SecurityIdentification41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdNotAvlbl|String||XmlElement()||
|+|Othr|ISO20022.Auth091001.GenericIdentification184||XmlElement()||
|+|Indx|ISO20022.Auth091001.IndexIdentification1||XmlElement()||
|+|Bskt|ISO20022.Auth091001.CustomBasket4||XmlElement()||
|+|UnqPdctIdr|ISO20022.Auth091001.UniqueProductIdentifier2Choice||XmlElement()||
|+|AltrntvInstrmId|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Indx),validElement(Bskt),validElement(UnqPdctIdr),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(IdNotAvlbl,Othr,Indx,Bskt,UnqPdctIdr,AltrntvInstrmId,ISIN))|

---

## Value ISO20022.Auth091001.StatisticsPerCounterparty19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rpt|global::System.Collections.Generic.List<ISO20022.Auth091001.ReconciliationStatisticsPerCounterparty4>||XmlElement()||
|+|DataSetActn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validChoice(Rpt,DataSetActn))|

---

## Value ISO20022.Auth091001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth091001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth091001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.TimePeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToTm|DateTime||XmlElement()||
|+|FrTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.TradeConfirmation3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonConfd|ISO20022.Auth091001.TradeNonConfirmation1||XmlElement()||
|+|Confd|ISO20022.Auth091001.TradeConfirmation4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NonConfd),validElement(Confd),validChoice(NonConfd,Confd))|

---

## Value ISO20022.Auth091001.TradeConfirmation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TmStmp|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.TradeConfirmationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YCNF|Int32||XmlEnum("""YCNF""")|1|
||ECNF|Int32||XmlEnum("""ECNF""")|2|

---

## Enum ISO20022.Auth091001.TradeConfirmationType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCNF|Int32||XmlEnum("""NCNF""")|1|

---

## Value ISO20022.Auth091001.TradeNonConfirmation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Auth091001.TradeRepositoryReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TWOS|Int32||XmlEnum("""TWOS""")|1|
||SWOS|Int32||XmlEnum("""SWOS""")|2|

---

## Value ISO20022.Auth091001.TradeTransactionIdentification24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollPrtflCd|ISO20022.Auth091001.CollateralPortfolioCode5Choice||XmlElement()||
|+|MstrAgrmt|ISO20022.Auth091001.MasterAgreement8||XmlElement()||
|+|UnqIdr|ISO20022.Auth091001.UniqueTransactionIdentifier2Choice||XmlElement()||
|+|OthrCtrPty|ISO20022.Auth091001.PartyIdentification248Choice||XmlElement()||
|+|DerivEvtTmStmp|ISO20022.Auth091001.DateAndDateTime2Choice||XmlElement()||
|+|DerivEvtTp|String||XmlElement()||
|+|RptgTmStmp|DateTime||XmlElement()||
|+|ActnTp|String||XmlElement()||
|+|TechRcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollPrtflCd),validElement(MstrAgrmt),validElement(UnqIdr),validElement(OthrCtrPty),validElement(DerivEvtTmStmp))|

---

## Value ISO20022.Auth091001.Tranche3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtchmntPt|Decimal||XmlElement()||
|+|AttchmntPt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth091001.TrancheIndicator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Utrnchd|String||XmlElement()||
|+|Trnchd|ISO20022.Auth091001.Tranche3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Trnchd),validChoice(Utrnchd,Trnchd))|

---

## Value ISO20022.Auth091001.TransactionMatchingCriteria7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lvl|ISO20022.Auth091001.CompareReportingLevelType2||XmlElement()||
|+|CdtTrch|ISO20022.Auth091001.CompareTrancheIndicator1||XmlElement()||
|+|CdtIndxFctr|ISO20022.Auth091001.ComparePercentageRate3||XmlElement()||
|+|CdtVrsn|ISO20022.Auth091001.CompareNumber7||XmlElement()||
|+|CdtSrs|ISO20022.Auth091001.CompareNumber7||XmlElement()||
|+|CdtRefPty|ISO20022.Auth091001.CompareReferenceParty1||XmlElement()||
|+|CdtSnrty|ISO20022.Auth091001.CompareSeniorityType1||XmlElement()||
|+|OptnMtrtyDtOfUndrlyg|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|OptnPrmPmtDt|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|OptnPrmAmt|ISO20022.Auth091001.CompareActiveOrHistoricCurrencyAndAmount4||XmlElement()||
|+|OptnStrkPricSchdlAmt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareUnitPrice4>||XmlElement()||
|+|OptnStrkPricSchdlUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|OptnStrkPricSchdlUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|OptnStrkPric|ISO20022.Auth091001.CompareUnitPrice4||XmlElement()||
|+|OptnExrcStyle|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareOptionStyle1>||XmlElement()||
|+|OptnTp|ISO20022.Auth091001.CompareOptionType1||XmlElement()||
|+|DlvryAttr|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareEnergyDeliveryAttribute1>||XmlElement()||
|+|NrgyLdTp|ISO20022.Auth091001.CompareEnergyLoadType1||XmlElement()||
|+|NrgyIntrCnnctnPt|ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1||XmlElement()||
|+|NrgyDlvryPtOrZone|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDeliveryInterconnectionPoint1>||XmlElement()||
|+|Cmmdty|ISO20022.Auth091001.CompareCommodityAssetClass4||XmlElement()||
|+|CcyXchgRateBsis|ISO20022.Auth091001.CompareExchangeRateBasis1||XmlElement()||
|+|CcyFwdXchgRate|ISO20022.Auth091001.CompareExchangeRate1||XmlElement()||
|+|CcyXchgRate|ISO20022.Auth091001.CompareExchangeRate1||XmlElement()||
|+|PackgSprd|ISO20022.Auth091001.CompareUnitPrice8||XmlElement()||
|+|IntrstFltgRateScndLegSprd|ISO20022.Auth091001.CompareUnitPrice8||XmlElement()||
|+|IntrstFltgRateScndLegRstFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateScndLegRstFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateScndLegRefPrdVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateScndLegRefPrdUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateScndLegPmtFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateScndLegPmtFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateScndLegDayCnt|ISO20022.Auth091001.CompareDayCount1||XmlElement()||
|+|IntrstFltgRateScndLegNm|ISO20022.Auth091001.CompareMax350Text1||XmlElement()||
|+|IntrstFltgRateScndLegCd|ISO20022.Auth091001.CompareBenchmarkCode1||XmlElement()||
|+|IntrstFltgRateScndLegId|ISO20022.Auth091001.CompareISINIdentifier4||XmlElement()||
|+|IntrstFxdRateScndLegPmtFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFxdRateScndLegPmtFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFxdRateScndLegDayCnt|ISO20022.Auth091001.CompareDayCount1||XmlElement()||
|+|IntrstRateFxdScndLeg|ISO20022.Auth091001.CompareUnitPrice7||XmlElement()||
|+|IntrstFltgRateFrstLegSprd|ISO20022.Auth091001.CompareUnitPrice8||XmlElement()||
|+|IntrstFltgRateFrstLegRstFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateFrstLegRstFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateFrstLegRefPrdVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateFrstLegRefPrdUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateFrstLegPmtFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFltgRateFrstLegPmtFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFltgRateFrstLegDayCnt|ISO20022.Auth091001.CompareDayCount1||XmlElement()||
|+|IntrstFltgRateFrstLegNm|ISO20022.Auth091001.CompareMax350Text1||XmlElement()||
|+|IntrstFltgRateFrstLegCd|ISO20022.Auth091001.CompareBenchmarkCode1||XmlElement()||
|+|IntrstFltgRateFrstLegId|ISO20022.Auth091001.CompareISINIdentifier4||XmlElement()||
|+|IntrstFxdRateFrstLegPmtFrqcyVal|ISO20022.Auth091001.CompareNumber5||XmlElement()||
|+|IntrstFxdRateFrstLegPmtFrqcyUnit|ISO20022.Auth091001.CompareFrequencyUnit1||XmlElement()||
|+|IntrstFxdRateFrstLegDayCnt|ISO20022.Auth091001.CompareDayCount1||XmlElement()||
|+|IntrstFxdRateFrstLeg|ISO20022.Auth091001.CompareUnitPrice7||XmlElement()||
|+|OthrPmt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareOtherPayment1>||XmlElement()||
|+|NtnlQtyScndLegSchdlQty|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareLongFraction19DecimalNumber1>||XmlElement()||
|+|NtnlQtyScndLegUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlQtyScndLegUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlQtyScndLeg|ISO20022.Auth091001.CompareLongFraction19DecimalNumber1||XmlElement()||
|+|NtnlAmtScndLegSchdlAmt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareAmountAndDirection3>||XmlElement()||
|+|NtnlAmtScndLegUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlAmtScndLegUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlAmtScndLeg|ISO20022.Auth091001.CompareAmountAndDirection3||XmlElement()||
|+|NtnlQtyFrstLegSchdlQty|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareLongFraction19DecimalNumber1>||XmlElement()||
|+|NtnlQtyFrstLegUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlQtyFrstLegUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlQtyFrstLeg|ISO20022.Auth091001.CompareLongFraction19DecimalNumber1||XmlElement()||
|+|NtnlAmtFrstLegSchdlAmt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareAmountAndDirection3>||XmlElement()||
|+|NtnlAmtFrstLegUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlAmtFrstLegUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|NtnlAmtFrstLeg|ISO20022.Auth091001.CompareAmountAndDirection3||XmlElement()||
|+|PackgPric|ISO20022.Auth091001.CompareUnitPrice5||XmlElement()||
|+|TxSchdlPric|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareUnitPrice5>||XmlElement()||
|+|PricSchdlUadjstdEndDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|PricSchdlUadjstdFctvDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|TxPric|ISO20022.Auth091001.CompareUnitPrice5||XmlElement()||
|+|DlvryTp|ISO20022.Auth091001.CompareDeliveryType1||XmlElement()||
|+|SttlmDt|global::System.Collections.Generic.List<ISO20022.Auth091001.CompareDate3>||XmlElement()||
|+|EarlyTermntnDt|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|XprtnDt|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|FctvDt|ISO20022.Auth091001.CompareDate3||XmlElement()||
|+|ExctnTmStmp|ISO20022.Auth091001.CompareDateTime3||XmlElement()||
|+|PltfmIdr|ISO20022.Auth091001.CompareMICIdentifier3||XmlElement()||
|+|DerivEvt|ISO20022.Auth091001.CompareDerivativeEvent1||XmlElement()||
|+|PstTradRskRdctn|ISO20022.Auth091001.ComparePostTradeRiskReduction2||XmlElement()||
|+|IntraGrp|ISO20022.Auth091001.CompareTrueFalseIndicator3||XmlElement()||
|+|MstrAgrmtVrsn|ISO20022.Auth091001.CompareMax50Text1||XmlElement()||
|+|MstrAgrmtTp|ISO20022.Auth091001.CompareMasterAgreementType1||XmlElement()||
|+|TradClrSts|ISO20022.Auth091001.CompareTradeClearingStatus3||XmlElement()||
|+|TradClrOblgtn|ISO20022.Auth091001.CompareTradeClearingObligation1||XmlElement()||
|+|TradConf|ISO20022.Auth091001.CompareTradeConfirmation2||XmlElement()||
|+|Dlta|ISO20022.Auth091001.CompareLongFraction19DecimalNumber1||XmlElement()||
|+|SbsqntPosUnqTxIdr|ISO20022.Auth091001.CompareUniqueTransactionIdentifier2||XmlElement()||
|+|PrrUnqTxIdr|ISO20022.Auth091001.CompareUniqueTransactionIdentifier2||XmlElement()||
|+|UnqTxIdr|ISO20022.Auth091001.CompareUniqueTransactionIdentifier2||XmlElement()||
|+|RptTrckgNb|ISO20022.Auth091001.CompareText2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lvl),validElement(CdtTrch),validElement(CdtIndxFctr),validElement(CdtVrsn),validElement(CdtSrs),validElement(CdtRefPty),validElement(CdtSnrty),validElement(OptnMtrtyDtOfUndrlyg),validElement(OptnPrmPmtDt),validElement(OptnPrmAmt),validList("""OptnStrkPricSchdlAmt""",OptnStrkPricSchdlAmt),validElement(OptnStrkPricSchdlAmt),validList("""OptnStrkPricSchdlUadjstdEndDt""",OptnStrkPricSchdlUadjstdEndDt),validElement(OptnStrkPricSchdlUadjstdEndDt),validList("""OptnStrkPricSchdlUadjstdFctvDt""",OptnStrkPricSchdlUadjstdFctvDt),validElement(OptnStrkPricSchdlUadjstdFctvDt),validElement(OptnStrkPric),validList("""OptnExrcStyle""",OptnExrcStyle),validElement(OptnExrcStyle),validElement(OptnTp),validList("""DlvryAttr""",DlvryAttr),validElement(DlvryAttr),validElement(NrgyLdTp),validElement(NrgyIntrCnnctnPt),validList("""NrgyDlvryPtOrZone""",NrgyDlvryPtOrZone),validElement(NrgyDlvryPtOrZone),validElement(Cmmdty),validElement(CcyXchgRateBsis),validElement(CcyFwdXchgRate),validElement(CcyXchgRate),validElement(PackgSprd),validElement(IntrstFltgRateScndLegSprd),validElement(IntrstFltgRateScndLegRstFrqcyVal),validElement(IntrstFltgRateScndLegRstFrqcyUnit),validElement(IntrstFltgRateScndLegRefPrdVal),validElement(IntrstFltgRateScndLegRefPrdUnit),validElement(IntrstFltgRateScndLegPmtFrqcyVal),validElement(IntrstFltgRateScndLegPmtFrqcyUnit),validElement(IntrstFltgRateScndLegDayCnt),validElement(IntrstFltgRateScndLegNm),validElement(IntrstFltgRateScndLegCd),validElement(IntrstFltgRateScndLegId),validElement(IntrstFxdRateScndLegPmtFrqcyVal),validElement(IntrstFxdRateScndLegPmtFrqcyUnit),validElement(IntrstFxdRateScndLegDayCnt),validElement(IntrstRateFxdScndLeg),validElement(IntrstFltgRateFrstLegSprd),validElement(IntrstFltgRateFrstLegRstFrqcyVal),validElement(IntrstFltgRateFrstLegRstFrqcyUnit),validElement(IntrstFltgRateFrstLegRefPrdVal),validElement(IntrstFltgRateFrstLegRefPrdUnit),validElement(IntrstFltgRateFrstLegPmtFrqcyVal),validElement(IntrstFltgRateFrstLegPmtFrqcyUnit),validElement(IntrstFltgRateFrstLegDayCnt),validElement(IntrstFltgRateFrstLegNm),validElement(IntrstFltgRateFrstLegCd),validElement(IntrstFltgRateFrstLegId),validElement(IntrstFxdRateFrstLegPmtFrqcyVal),validElement(IntrstFxdRateFrstLegPmtFrqcyUnit),validElement(IntrstFxdRateFrstLegDayCnt),validElement(IntrstFxdRateFrstLeg),validList("""OthrPmt""",OthrPmt),validElement(OthrPmt),validList("""NtnlQtyScndLegSchdlQty""",NtnlQtyScndLegSchdlQty),validElement(NtnlQtyScndLegSchdlQty),validList("""NtnlQtyScndLegUadjstdEndDt""",NtnlQtyScndLegUadjstdEndDt),validElement(NtnlQtyScndLegUadjstdEndDt),validList("""NtnlQtyScndLegUadjstdFctvDt""",NtnlQtyScndLegUadjstdFctvDt),validElement(NtnlQtyScndLegUadjstdFctvDt),validElement(NtnlQtyScndLeg),validList("""NtnlAmtScndLegSchdlAmt""",NtnlAmtScndLegSchdlAmt),validElement(NtnlAmtScndLegSchdlAmt),validList("""NtnlAmtScndLegUadjstdEndDt""",NtnlAmtScndLegUadjstdEndDt),validElement(NtnlAmtScndLegUadjstdEndDt),validList("""NtnlAmtScndLegUadjstdFctvDt""",NtnlAmtScndLegUadjstdFctvDt),validElement(NtnlAmtScndLegUadjstdFctvDt),validElement(NtnlAmtScndLeg),validList("""NtnlQtyFrstLegSchdlQty""",NtnlQtyFrstLegSchdlQty),validElement(NtnlQtyFrstLegSchdlQty),validList("""NtnlQtyFrstLegUadjstdEndDt""",NtnlQtyFrstLegUadjstdEndDt),validElement(NtnlQtyFrstLegUadjstdEndDt),validList("""NtnlQtyFrstLegUadjstdFctvDt""",NtnlQtyFrstLegUadjstdFctvDt),validElement(NtnlQtyFrstLegUadjstdFctvDt),validElement(NtnlQtyFrstLeg),validList("""NtnlAmtFrstLegSchdlAmt""",NtnlAmtFrstLegSchdlAmt),validElement(NtnlAmtFrstLegSchdlAmt),validList("""NtnlAmtFrstLegUadjstdEndDt""",NtnlAmtFrstLegUadjstdEndDt),validElement(NtnlAmtFrstLegUadjstdEndDt),validList("""NtnlAmtFrstLegUadjstdFctvDt""",NtnlAmtFrstLegUadjstdFctvDt),validElement(NtnlAmtFrstLegUadjstdFctvDt),validElement(NtnlAmtFrstLeg),validElement(PackgPric),validList("""TxSchdlPric""",TxSchdlPric),validElement(TxSchdlPric),validList("""PricSchdlUadjstdEndDt""",PricSchdlUadjstdEndDt),validElement(PricSchdlUadjstdEndDt),validList("""PricSchdlUadjstdFctvDt""",PricSchdlUadjstdFctvDt),validElement(PricSchdlUadjstdFctvDt),validElement(TxPric),validElement(DlvryTp),validList("""SttlmDt""",SttlmDt),validElement(SttlmDt),validElement(EarlyTermntnDt),validElement(XprtnDt),validElement(FctvDt),validElement(ExctnTmStmp),validElement(PltfmIdr),validElement(DerivEvt),validElement(PstTradRskRdctn),validElement(IntraGrp),validElement(MstrAgrmtVrsn),validElement(MstrAgrmtTp),validElement(TradClrSts),validElement(TradClrOblgtn),validElement(TradConf),validElement(Dlta),validElement(SbsqntPosUnqTxIdr),validElement(PrrUnqTxIdr),validElement(UnqTxIdr),validElement(RptTrckgNb))|

---

## Enum ISO20022.Auth091001.TransactionOperationType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRTO|Int32||XmlEnum("""PRTO""")|1|
||MARU|Int32||XmlEnum("""MARU""")|2|
||VALU|Int32||XmlEnum("""VALU""")|3|
||TERM|Int32||XmlEnum("""TERM""")|4|
||REVI|Int32||XmlEnum("""REVI""")|5|
||POSC|Int32||XmlEnum("""POSC""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||NEWT|Int32||XmlEnum("""NEWT""")|8|
||MODI|Int32||XmlEnum("""MODI""")|9|
||EROR|Int32||XmlEnum("""EROR""")|10|
||CORR|Int32||XmlEnum("""CORR""")|11|
||COMP|Int32||XmlEnum("""COMP""")|12|

---

## Enum ISO20022.Auth091001.UnderlyingIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDX|Int32||XmlEnum("""INDX""")|1|
||BSKT|Int32||XmlEnum("""BSKT""")|2|
||UKWN|Int32||XmlEnum("""UKWN""")|3|

---

## Value ISO20022.Auth091001.UniqueProductIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth091001.GenericIdentification175||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth091001.UniqueProductIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth091001.GenericIdentification185||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Id))|

---

## Value ISO20022.Auth091001.UniqueTransactionIdentifier1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth091001.GenericIdentification179||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth091001.UniqueTransactionIdentifier2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth091001.GenericIdentification175||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""),validChoice(Prtry,UnqTxIdr))|

---

## Value ISO20022.Auth091001.UnitOfMeasure8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth091001.GenericIdentification175||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth091001.ValuationMatchingCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Auth091001.CompareValuationType1||XmlElement()||
|+|CtrctVal|ISO20022.Auth091001.CompareAmountAndDirection3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(CtrctVal))|

---

## Enum ISO20022.Auth091001.ValuationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MTMO|Int32||XmlEnum("""MTMO""")|1|
||MTMA|Int32||XmlEnum("""MTMA""")|2|
||CCPV|Int32||XmlEnum("""CCPV""")|3|

---

## Enum ISO20022.Auth091001.WeekDay3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEND|Int32||XmlEnum("""WEND""")|1|
||WDAY|Int32||XmlEnum("""WDAY""")|2|
||WEDD|Int32||XmlEnum("""WEDD""")|3|
||TUED|Int32||XmlEnum("""TUED""")|4|
||THUD|Int32||XmlEnum("""THUD""")|5|
||SUND|Int32||XmlEnum("""SUND""")|6|
||SATD|Int32||XmlEnum("""SATD""")|7|
||MOND|Int32||XmlEnum("""MOND""")|8|
||FRID|Int32||XmlEnum("""FRID""")|9|
||IBHL|Int32||XmlEnum("""IBHL""")|10|
||XBHL|Int32||XmlEnum("""XBHL""")|11|
||ALLD|Int32||XmlEnum("""ALLD""")|12|

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

