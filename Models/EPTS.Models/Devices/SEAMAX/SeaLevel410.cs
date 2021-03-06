using System.Collections.Generic;
using DigitalOutput = EPTS.Models.Devices.SEAMAX.Core.DigitalOutput;

namespace EPTS.Models.Devices.SEAMAX
{
    public class SeaLevel410:SeaMax
    {

        public delegate void SeaLevelDigitalOutputHandler(object sender, DigitalOutput digitalOutput);
        public event SeaLevelDigitalOutputHandler SeaLevelDigitalOutput;

        public List<DigitalOutput> DigitalOutput { get; set; }


        public virtual void OnSeaLevelDigitalOutput(DigitalOutput digitaloutput)
        {
            SeaLevelDigitalOutput?.Invoke(this, digitaloutput);
        }
    }
}