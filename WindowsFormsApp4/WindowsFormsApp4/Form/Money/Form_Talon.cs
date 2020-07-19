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
    public partial class Form_Talon : Form
    {
        public Form_Talon()
        {
            InitializeComponent();
        }
        public void Output(List<Asset> assets)
        {
            foreach (var item in assets)
            {
                if (item is Money)
                {
                    var transformedItem = item as Money;
                    if (transformedItem.typeMoney == Money.TypeMoney.Talon)
                        dataGridView1.Rows.Add("Талон", transformedItem.TotalSum, 
                            transformedItem.Currency, transformedItem.TypeTicket);
                }
                
            }
        }
    }
}
