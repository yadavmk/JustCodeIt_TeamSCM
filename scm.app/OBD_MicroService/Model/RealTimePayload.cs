﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCM.Model
{
    public class RealTimePayload
    {
        [Key]
        public int RealTimePayLoadId { get; set; }
        public string CarId { get; set; }
        public float Speed { get; set; }
        public float Rpm { get; set; }
        public float FuelLevel { get; set; }
        public float EngineOilTemperature { get; set; }
        public float CoolantTemperature { get; set; }
        public long PayloadTimestamp { get; set; }
    }
}
