using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 漏电检测系统
{
    public class _NotifyMessageEventArgs: EventArgs
    {
        public SIM300Param SIM300Param { get; set; }

        public _NotifyMessageEventArgs(SIM300Param data)
        {
            SIM300Param = data;
        }
    }
}
