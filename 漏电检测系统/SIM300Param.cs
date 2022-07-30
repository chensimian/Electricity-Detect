using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 漏电检测系统
{
    public class SIM300Param
    {
        public string Datetime { get; set; }
        public int Index { get; set; }

        public string Imea { get; set; }
        public string Line { get; set; }
        public string Dangwei { get; set; }
        public double Adc { get; set; }

        public SIM300Param()
        {
            Adc = 0;
            Imea = "";
            Datetime = "";
            Line = "0";
            Dangwei = "0";
            Index = 0;
        }
    }
}
