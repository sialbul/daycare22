using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace daycare22.Models
{
    public class Fee
    {
        public decimal DailyFeeOneChild { get;}

        public decimal WeeklyFeeOneChild { get; }

        public decimal DailyFeeTwoKids { get; }
        public decimal WeeklyFeeTwoKids { get; }

        public decimal PartTimeFee { get; }

        public decimal Part12HalfAWeek { get; }

        public decimal RegistrationFee { get; }

        public decimal LatePickUpFee { get; }

        public decimal Daily2AndHalfHour { get; }

    }
}
