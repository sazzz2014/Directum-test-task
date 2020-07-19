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
    public partial class FormEdit : Form
    {
        public FormEdit(int lastSelectRow, Asset assets)
        {
            InitializeComponent();
            if (assets is Money)
            {
                money = assets as Money;
                dataGridView1.Columns.Add("1", "Кол-во денег");
                dataGridView1.Columns.Add("2", "Единица измерения");
                dataGridView1[0, 0].Value = money.TotalSum;
                dataGridView1[1, 0].Value = money.Currency;

                if (money.typeMoney == Money.TypeMoney.Bank)
                {
                    dataGridView1.Columns.Add("3", "Банк");
                    dataGridView1.Columns.Add("4", "Номер счета");
                    dataGridView1[2, 0].Value = money.BankName;
                    dataGridView1[3, 0].Value = money.AccountNumber;
                }
                if (money.typeMoney == Money.TypeMoney.Talon)
                {
                    dataGridView1.Columns.Add("3", "Тип талона");
                    dataGridView1[2, 0].Value = money.TypeTicket;
                }
            }
            if (assets is UnsafeAssets)
            {
                unsafeAsset = assets as UnsafeAssets;
                if (unsafeAsset.typeUnsafe == UnsafeAssets.TypeUnsafe.Inventory)
                {
                    dataGridView1.Columns.Add("1", "Название актива");
                    dataGridView1.Columns.Add("2", "Валюта");
                    dataGridView1.Columns.Add("3", "Год производства");
                    dataGridView1.Columns.Add("4", "Начальная стоимость");
                    dataGridView1.Columns.Add("5", "Остаточная стоимость");
                    dataGridView1.Columns.Add("6", "Оценочная стоимость");
                    dataGridView1.Columns.Add("7", "Адрес");
                    dataGridView1.Columns.Add("8", "Инвентарный номер");
                    dataGridView1[0, 0].Value = unsafeAsset.Name;
                    dataGridView1[1, 0].Value = unsafeAsset.Currency;
                    dataGridView1[2, 0].Value = unsafeAsset.ProductionDate;
                    dataGridView1[3, 0].Value = unsafeAsset.InitialBalanceValue;
                    dataGridView1[4, 0].Value = unsafeAsset.RemainsBalanceValue;
                    dataGridView1[5, 0].Value = unsafeAsset.EstimatedeValue;
                    dataGridView1[6, 0].Value = unsafeAsset.Address;
                    dataGridView1[7, 0].Value = unsafeAsset.InventoryNumber;
                }

                if (unsafeAsset.typeUnsafe == UnsafeAssets.TypeUnsafe.Nomenclator)
                {
                    dataGridView1.Columns.Add("1", "Название актива");
                    dataGridView1.Columns.Add("2", "Кол-во");
                    dataGridView1.Columns.Add("3", "Единица измерения");
                    dataGridView1.Columns.Add("4", "Валюта");
                    dataGridView1.Columns.Add("5", "Год производства");
                    dataGridView1.Columns.Add("6", "Начальная стоимость");
                    dataGridView1.Columns.Add("7", "Остаточная стоимость");
                    dataGridView1.Columns.Add("8", "Рыночная стоимость");
                    dataGridView1[0, 0].Value = unsafeAsset.Name;
                    dataGridView1[1, 0].Value = unsafeAsset.Count;
                    dataGridView1[2, 0].Value = unsafeAsset.UnitMeasurement;
                    dataGridView1[3, 0].Value = unsafeAsset.Currency;
                    dataGridView1[4, 0].Value = unsafeAsset.ProductionDate;
                    dataGridView1[5, 0].Value = unsafeAsset.InitialBalanceValue;
                    dataGridView1[6, 0].Value = unsafeAsset.RemainsBalanceValue;
                    dataGridView1[7, 0].Value = unsafeAsset.MarketValue;
                }
            }
        }
       
        public Money money { get; set; }
        public UnsafeAssets unsafeAsset { get; set; }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var tableRow = dataGridView1.Rows[0].Cells;
            List<string> row = new List<string>();
            bool elementCorrect = true;

            for (int i = 0; i < tableRow.Count; i++)
            {
                if (tableRow[i].Value != null)
                    row.Add(tableRow[i].Value.ToString());
                else
                    elementCorrect = false;
            }

            if (elementCorrect)
            {
                if(money != null)
                {
                    if (money.typeMoney == Money.TypeMoney.Bank)
                        money = new Money(Money.TypeMoney.Bank, Convert.ToInt32(row[0]), row[1], row[2], Convert.ToInt32(row[3]));
                    if (money.typeMoney == Money.TypeMoney.Kassa)
                        money = new Money(Money.TypeMoney.Kassa, Convert.ToInt32(row[0]), row[1]);
                    if (money.typeMoney == Money.TypeMoney.Talon)
                        money = new Money(Money.TypeMoney.Talon, Convert.ToInt32(row[0]), row[1], row[2]);
                }
                if (unsafeAsset != null)
                {
                    if (unsafeAsset.typeUnsafe == UnsafeAssets.TypeUnsafe.Inventory)
                        unsafeAsset = new UnsafeAssets(UnsafeAssets.TypeUnsafe.Inventory, row[0], row[1], Convert.ToInt32(row[2]),
                            Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), row[6], Convert.ToInt32(row[7]));
                    if (unsafeAsset.typeUnsafe == UnsafeAssets.TypeUnsafe.Nomenclator)
                        unsafeAsset = new UnsafeAssets(UnsafeAssets.TypeUnsafe.Nomenclator, row[0], Convert.ToInt32(row[1]), row[2],
                            row[3], Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]), Convert.ToInt32(row[7]));
                }
            }
            else
                MessageBox.Show("Элемент не сохранен. Не все поля заполнены.");
            Close();
        }
    }
}
