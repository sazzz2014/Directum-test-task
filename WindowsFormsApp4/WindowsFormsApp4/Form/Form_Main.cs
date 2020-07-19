using Microsoft.SqlServer.Server;
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
    public partial class Form_Main : Form
    {
        public List<Asset> assets = new List<Asset>()
        {
            new Money(Money.TypeMoney.Bank, 1000, "Рубль","ЕвроВорБанк", 5),
            new Money(Money.TypeMoney.Bank, 5, "Доллар", "ЕвроВорБанк",3),
            new Money(Money.TypeMoney.Kassa, 100,  "Рубль"),
            new Money(Money.TypeMoney.Kassa, 10120, "Доллар"),
            new Money(Money.TypeMoney.Talon, 300, "Рубль", "Бензин"),
            new Money(Money.TypeMoney.Talon, 50, "Рубль", "Сахар"),
            new UnsafeAssets(UnsafeAssets.TypeUnsafe.Inventory, "Дом","Рубль", 1970, 30000, 5000, 1000000, "Бассейная 6",  7),
            new UnsafeAssets(UnsafeAssets.TypeUnsafe.Nomenclator, "Гвозди", 100, "КГ", "Рубль",  2000, 1000, 100, 2000),
            new UnsafeAssets(UnsafeAssets.TypeUnsafe.Inventory, "Торговый центр","Доллар", 2016, 300000, 50000, 10000000, "Удмуртская 161",  3),
            new UnsafeAssets(UnsafeAssets.TypeUnsafe.Nomenclator, "Капюшон", 3, "Шт", "Рубль",  2020, 500, 100, 1300),
        };       
        int lastSelectRow;

        public Form_Main()
        {
            InitializeComponent();
            UpdateSetAssets();
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];         
        }

        public void UpdateSetAssets()
        {
            int id = 1;
            string str = "";
            dataGridView1.Rows.Clear();
            foreach (var item in assets)
            {
                if (item is Money)
                {
                    var transItem = item as Money;
                    switch (transItem.typeMoney)
                    {
                        case Money.TypeMoney.Bank:
                            str = $"На счёте №{transItem.AccountNumber} в {transItem.BankName}е лежит {transItem.TotalSum } денежных единиц ({transItem.Currency})";
                            break;
                        case Money.TypeMoney.Kassa:
                            str = $"В кассе лежит {transItem.TotalSum } денежных единиц ({item.Currency})";
                            break;
                        case Money.TypeMoney.Talon:
                            str = $"В кассе лежит талон на {transItem.TypeTicket} на {transItem.TotalSum } денежных единиц ({transItem.Currency})";
                            break;
                        default:
                            str = "";
                            break;
                    }
                }
                if (item is UnsafeAssets)
                {
                    var transItem = item as UnsafeAssets;
                    switch (transItem.typeUnsafe)
                    {
                        case UnsafeAssets.TypeUnsafe.Inventory:
                            str = $"{transItem.Name} по адресу {transItem.Address}, год производства {transItem.ProductionDate}. Начальная стоимость(" +
                                $"{transItem.Currency}) {transItem.InitialBalanceValue}, остаточная стоимость {transItem.RemainsBalanceValue}, оценочная стоимость" +
                                $" {transItem.EstimatedeValue}. Инвентарный номер {transItem.InventoryNumber}";
                            break;
                        case UnsafeAssets.TypeUnsafe.Nomenclator:
                            str = $"{transItem.Name} ({transItem.Count} {transItem.UnitMeasurement}), год производства {transItem.ProductionDate}. " +
                                $"Начальная стоимость({transItem.Currency}) {transItem.InitialBalanceValue}, " +
                                $"остаточная стоимость {transItem.RemainsBalanceValue}, рыночная стоимость {transItem.MarketValue}.";
                            break;
                        default:
                            str = "";
                            break;
                    }
                }
                dataGridView1.Rows.Add(id++, str);
            }
        }

        private void вБанкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bank form = new Form_Bank();
            form.Output(assets);
            form.Show();
        }

        private void вКассеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Kassa form = new Form_Kassa();
            form.Output(assets);
            form.Show();
        }

        private void вТалонахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Talon form = new Form_Talon();
            form.Output(assets);
            form.Show();
        }
        private void большиеАктивыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Big form = new Form_Big();
            form.Output(assets);
            form.Show();
        }

        private void небольшиеАктивыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Small form = new Form_Small();
            form.Output(assets);
            form.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            if (formAdd.assets != null)
                assets.Add(formAdd.assets);
            UpdateSetAssets();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectRow < assets.Count)
            {
                FormEdit formEdit;
                formEdit = new FormEdit(lastSelectRow, assets[lastSelectRow]);
                formEdit.ShowDialog();

                if (formEdit.money != null)
                    assets[lastSelectRow] = formEdit.money;
                if (formEdit.unsafeAsset != null)
                    assets[lastSelectRow] = formEdit.unsafeAsset;
                UpdateSetAssets();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (lastSelectRow < assets.Count)
                assets.RemoveAt(lastSelectRow);
            UpdateSetAssets();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            lastSelectRow = dataGridView1.CurrentRow.Index;
        }        
    }
}
