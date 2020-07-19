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
    public partial class Form_Big : Form
    {
        public Form_Big()
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
                    if (transformedItem.typeUnsafe == UnsafeAssets.TypeUnsafe.Inventory)
                        dataGridView1.Rows.Add("Основной фонд", transformedItem.Currency, transformedItem.ProductionDate,
                            transformedItem.InitialBalanceValue, transformedItem.RemainsBalanceValue,
                            transformedItem.RemainsBalanceValue, transformedItem.InventoryNumber);
                }                   
            }
        }
    }
}
