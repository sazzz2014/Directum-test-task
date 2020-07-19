using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Assets
{
    /// <summary>
    /// Активы.
    /// </summary>
    public class Asset
    {
        public Asset(string currency)
        {
            Currency = currency;
        }
        /// <summary>
        /// В какой валюте измеряется.
        /// </summary>
        public string Currency { get; set; }

    }
}
