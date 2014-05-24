using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tracker.Models
{
    public class WeightTracker
    {
        public WeightTracker()
        {
            var WeighIns = new Dictionary<WeighIn, DateTime>();
        }

        public Dictionary<WeighIn, DateTime> WeighIns { get; set; }
    }
}