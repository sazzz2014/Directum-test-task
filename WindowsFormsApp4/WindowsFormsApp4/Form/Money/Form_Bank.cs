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
    public partial class Form_Bank : Form
    {
        public Form_Bank()
        {
            InitializeComponent();
        }
        int id = 1;

        public void Output(List<Asset> assets)
        {
            foreach (var item in assets)
            {
                if (item is Money)
                {
                    var transformedItem = item as Money;
                    if (transformedItem.typeMoney == Money.TypeMoney.Bank)
                        dataGridView1.Rows.Add(id++, "Банк", transformedItem.TotalSum, item.Currency, 
                            transformedItem.BankName, transformedItem.AccountNumber);
                }
            }
        }
    }
}
