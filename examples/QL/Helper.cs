using Microsoft.CodeAnalysis.CSharp.Syntax;
using QLNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL
{
    public static class Helper
    {
        public static O make<O, E>(O o, E e) 
            where O : QLNet.Instrument
            where E : QLNet.IPricingEngine         
        {
            o.setPricingEngine(e);
            return o;
        }
        public static QLNet.Calendar Calendar(string? name)
        {
            return name switch
            {
                "UnitedKingdom" => new QLNet.UnitedKingdom(),
                _ => new QLNet.TARGET()
            };
        }

        public static QLNet.BusinessDayConvention BusinessDayConvention(string? name)
        {
            return name switch
            {
                "Nearest" => QLNet.BusinessDayConvention.Nearest,
                "Following" => QLNet.BusinessDayConvention.Following,
                "Unadjusted" => QLNet.BusinessDayConvention.Unadjusted,
                "ModifiedFollowing" => QLNet.BusinessDayConvention.ModifiedFollowing,
                _ => QLNet.BusinessDayConvention.Unadjusted,
            };
        }
        public static QLNet.Handle<QLNet.YieldTermStructure> FlatForward (DateTime? date, double? quote, QLNet.DayCounter? counter)
        {
            if (date == null) throw new ArgumentException(nameof(date));
            if (quote == null) throw new ArgumentException(nameof(quote));

            return new QLNet.Handle<QLNet.YieldTermStructure> ( new QLNet.FlatForward(date.Value, quote.Value, counter));
        }
        public static QLNet.Period Period(string? name)
        {
            return new QLNet.Period(name);
        }

        public static QLNet.DateGeneration.Rule DateRule(string? name)
        {
            return name switch
            {
                "Forward" => QLNet.DateGeneration.Rule.Forward,
                "Backward" => QLNet.DateGeneration.Rule.Backward,
                _ => QLNet.DateGeneration.Rule.Zero,
            };
        }

        public static QLNet.Schedule Schedule
            (DateTime? effectiveDate, 
             DateTime? terminationDate,  
             QLNet.Period? period,
             QLNet.Calendar? calendar,
             QLNet.BusinessDayConvention? convention, 
             QLNet.DateGeneration.Rule? rule)
        {
            if (effectiveDate == null) throw new ArgumentNullException(nameof(effectiveDate));
            if (terminationDate == null) throw new ArgumentNullException(nameof(terminationDate));
            if (period == null) throw new ArgumentNullException(nameof(period));
            if (calendar == null) throw new ArgumentNullException(nameof(calendar));
            if (convention == null) throw new ArgumentNullException(nameof(convention));
            if (rule == null) throw new ArgumentNullException(nameof(rule));

            return new QLNet.Schedule (effectiveDate.Value, terminationDate.Value, period, calendar, convention.Value, convention.Value, rule.Value, false);
        }

        public static QLNet.IPricingEngine? Engine(string? name, QLNet.Handle<QLNet.YieldTermStructure>? curve)
        {
            return name switch
            {
                "DiscountingBondEngine" => new QLNet.DiscountingBondEngine(curve),
                _ => null
            };
        }

        public static QLNet.DayCounter DayCounter (string? name)
        {
            return name switch
            {
                "Thirty360" => new Thirty360(Thirty360.Thirty360Convention.ISDA),
                "ActualActual" => new ActualActual(),
                _ => throw new ArgumentException()
            };
        }

        public static QLNet.FixedRateBond FixedRateBond
            (int? settlementDays, 
             double? faceAmount, 
             QLNet.Schedule? schedule, 
             List<double>? coupons, 
             QLNet.DayCounter? accrualDayCounter) 
        {
            if (settlementDays == null ) throw new ArgumentNullException(nameof(settlementDays));
            if (faceAmount == null) throw new ArgumentNullException(nameof(faceAmount));

            return new QLNet.FixedRateBond(settlementDays.Value, faceAmount.Value, schedule, coupons, accrualDayCounter);
        }

        public static double? NPV(QLNet.Instrument? instrument)
        {
            return instrument?.NPV();
        }
        public static double? CASH(QLNet.Instrument? instrument)
        {
            return instrument?.CASH();
        }
    }
}
