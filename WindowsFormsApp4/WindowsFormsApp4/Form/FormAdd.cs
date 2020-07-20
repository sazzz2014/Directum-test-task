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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                dataGridView1.Columns.Add("1", "Кол-во денег");
                dataGridView1.Columns.Add("2", "Валюта");
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.Columns.Add("3", "Банк");
                    dataGridView1.Columns.Add("4", "Номер счета");
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    dataGridView1.Columns.Add("3", "Тип талона");
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.Columns.Add("1", "Название актива");
                dataGridView1.Columns.Add("2", "Валюта");
                dataGridView1.Columns.Add("3", "Год производства");
                dataGridView1.Columns.Add("4", "Начальная стоимость");
                dataGridView1.Columns.Add("5", "Остаточная стоимость");
                dataGridView1.Columns.Add("6", "Оценочная стоимость");
                dataGridView1.Columns.Add("7", "Адрес");
                dataGridView1.Columns.Add("8", "Инвентарный номер");
            }
        
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.Columns.Add("1", "Название актива");
                dataGridView1.Columns.Add("2", "Кол-во");
                dataGridView1.Columns.Add("3", "Единица измерения");
                dataGridView1.Columns.Add("4", "Валюта");
                dataGridView1.Columns.Add("5", "Год производства");
                dataGridView1.Columns.Add("6", "Начальная стоимость");
                dataGridView1.Columns.Add("7", "Остаточная стоимость");
                dataGridView1.Columns.Add("8", "Рыночная стоимость");
            }
            dataGridView1.Visible = true;
            label2.Visible = true;
            buttonSave.Visible = true;
        }

        public Asset assets{ get; set; }
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
                if (comboBox1.SelectedIndex == 0)
                    assets = new Money(Money.TypeMoney.Bank, Convert.ToInt32(row[0]), row[1],  row[2], Convert.ToInt32(row[3]));
                if (comboBox1.SelectedIndex == 1)
                    assets = new Money(Money.TypeMoney.Kassa, Convert.ToInt32(row[0]), row[1]);
                if (comboBox1.SelectedIndex == 2)
                    assets = new Money(Money.TypeMoney.Talon, Convert.ToInt32(row[0]), row[1],  row[2]);               
                if (comboBox1.SelectedIndex == 3)
                    assets = new UnsafeAssets(UnsafeAssets.TypeUnsafe.Inventory, row[0], row[1], Convert.ToInt32(row[2]),
                        Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), row[6], Convert.ToInt32(row[7]));
                if (comboBox1.SelectedIndex == 4)
                    assets = new UnsafeAssets(UnsafeAssets.TypeUnsafe.Nomenclator, row[0], Convert.ToInt32(row[1]), row[2],
                        row[3], Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]), Convert.ToInt32(row[7]));
            }
            else
                MessageBox.Show("Элемент не сохранен. Не все поля заполнены.");
            Close();
        }
    }
}
