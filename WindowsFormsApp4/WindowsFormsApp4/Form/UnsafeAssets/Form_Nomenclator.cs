using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Assets;

namespace WindowsFormsApp4
{
    public partial class Form_Small : Form
    {
        public Form_Small()
        {
            InitializeComponent();
        }
        public void Output(List<Asset> assets)
        {
            foreach (var item in assets)
            {
                if (item is UnsafeAssets)
                {
                    var transformedItem = item as UnsafeAssets;
                    if (transformedItem.typeUnsafe == UnsafeAssets.TypeUnsafe.Nomenclator)
                        dataGridView1.Rows.Add("Материал", transformedItem.Count,
                            transformedItem.UnitMeasurement, transformedItem.ProductionDate, transformedItem.InitialBalanceValue,
                            transformedItem.RemainsBalanceValue, transformedItem.MarketValue);
                }
            }
        }
    }
}
