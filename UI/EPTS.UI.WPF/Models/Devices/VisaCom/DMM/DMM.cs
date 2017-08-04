﻿using PropertyChanged;

namespace EPTS.UI.WPF.Models.Devices.VisaCom.DMM
{
    public class Dmm:Visa
    {
        [AlsoNotifyFor("Measure")]
        public string Measure { get; set; }

        [AlsoNotifyFor("MeasureType")]
        public string MeasureType { get; set; }
    }
}
