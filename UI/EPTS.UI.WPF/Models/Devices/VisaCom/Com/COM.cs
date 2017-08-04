﻿using PropertyChanged;

namespace EPTS.UI.WPF.Models.Devices.VisaCom.Com
{
    public abstract class Com:Visa
    {
        [AlsoNotifyFor("BaudRate")]
        public string BaudRate { get; set; }

        [AlsoNotifyFor("TimeOut")]
        public string TimeOut { get; set; }
    }
}
