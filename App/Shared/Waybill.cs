﻿using System;

namespace Tellurian.Trains.Planning.App.Shared
{
    public class Waybill
    {
        public CargoCustomer? Origin { get; set; }
        public CargoCustomer? Destination { get; set; }
        public string Cargo { get; set; } = "TOM";
        public string OperatorName { get; set; } = string.Empty;
        public string Epoch { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        [Obsolete("Use " + nameof(OperationDays))]
        public string Days { get; set; } = string.Empty;
        public OperationDays OperationDays { get; set; } = new OperationDays();
    }
}
