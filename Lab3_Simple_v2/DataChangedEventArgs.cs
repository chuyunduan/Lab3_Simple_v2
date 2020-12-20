using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.ComponentModel;

namespace Lab3_Simple_v2
{
    class DataChangedEventArgs
    {
        public ChangeInfo Function { get; set; }

        public double dou { get; set; }

        public DataChangedEventArgs(ChangeInfo change, double d)
        {
            Function = change;
            dou = d;
        }

        public override string ToString()
        {
            string function = "default";
            switch (Function)
            {
                case ChangeInfo.ItemChanged:
                    function = "ItemChanged";
                    break;
                case ChangeInfo.Add:
                    function = "Add";
                    break;
                case ChangeInfo.Remove:
                    function = "Remove";
                    break;
                case ChangeInfo.Replace:
                    function = "Replace";
                    break;
                default:
                    break;
            }
            return $"Function:{ function } Value: { dou.ToString() }\n";
        }

    }
}
