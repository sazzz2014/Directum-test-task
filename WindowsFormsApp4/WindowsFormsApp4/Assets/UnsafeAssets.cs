using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Assets
{
    /// <summary>
    /// Неденежные активы.
    /// </summary>
    public class UnsafeAssets : Asset
    {
        public UnsafeAssets(TypeUnsafe typeUnsafe, string name, string currency, int productionDate, int initialBalanceValue, 
            int remainsBalanceValue, int estimatedeValue, string address,  int inventoryNumber)
            : base(currency)
        {
            this.typeUnsafe = typeUnsafe;
            Name = name;
            Address = address;
            ProductionDate = productionDate;
            InitialBalanceValue = initialBalanceValue;
            RemainsBalanceValue = remainsBalanceValue;
            EstimatedeValue = estimatedeValue;
            InventoryNumber = inventoryNumber;
        }
        public UnsafeAssets(TypeUnsafe typeUnsafe, string name, int count, string unitMeasurement, string currency, int productionDate, int initialBalanceValue,
            int remainsBalanceValue, int marketValue)
            : base(currency)
        {
            this.typeUnsafe = typeUnsafe;
            Name = name;
            Count = count;
            UnitMeasurement = unitMeasurement;
            ProductionDate = productionDate;
            InitialBalanceValue = initialBalanceValue;
            RemainsBalanceValue = remainsBalanceValue;
            MarketValue = marketValue;
        }
        /// <summary>
        /// Навзание актива.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вид неденежного актива.
        /// </summary>
        public TypeUnsafe typeUnsafe { get; set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Размер актива.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Начальная стоимость.
        /// </summary>
        public int InitialBalanceValue { get; set; }
        /// <summary>
        /// Оценочная стоимость.
        /// </summary>
        public int RemainsBalanceValue { get; set; }
        /// <summary>
        /// Оценочная стоимость.
        /// </summary>        
        public int EstimatedeValue { get; set; }
        /// <summary>
        /// Рыночная стоимость.
        /// </summary>
        public int MarketValue { get; set; }
        /// <summary>
        /// Инвентарный номер.
        /// </summary>
        public int InventoryNumber { get; set; }
        /// <summary>
        /// Единицы измерения.
        /// </summary>
        public string UnitMeasurement { get; set; }
        /// <summary>
        /// Год производства.
        /// </summary>
        public int ProductionDate { get; set; }
        /// <summary>
        /// Вид неденежного актива.
        /// </summary>
        public enum TypeUnsafe
        {
            /// <summary>
            /// Основной фонд.
            /// </summary>
            Inventory,
            /// <summary>
            /// Материал.
            /// </summary>
            Nomenclator
        }

    }
}
