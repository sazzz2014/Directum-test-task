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
    /// Денежные активы.
    /// </summary>
    public class Money : Asset
    {
        public Money(TypeMoney typeMoney, int totalSum, string currency, string bankName = null, int accountNumber = 0)
            :base(currency)
        {
            this.typeMoney = typeMoney;
            BankName = bankName;
            TotalSum = totalSum;
            AccountNumber = accountNumber;
        }
       
        public Money(TypeMoney typeMoney, int totalSum, string currency, string typeTicket)
          : base(currency)
        {
            this.typeMoney = typeMoney;
            TotalSum = totalSum;
            TypeTicket = typeTicket;
        }
        /// <summary>
        /// Тип талона(напр: талон на бензин).
        /// </summary>
        public string TypeTicket { get; set; }
        /// <summary>
        /// Где хранится дененжный актив.
        /// </summary>
        public TypeMoney typeMoney { get; set; }
        /// <summary>
        /// Название банка.
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// Сумма.
        /// </summary>
        public int TotalSum { get; set; }
        /// <summary>
        /// Номер счета.
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Место хранения денежного актива.
        /// </summary>
        public enum TypeMoney
        {
            /// <summary>
            /// Банк.
            /// </summary>
            Bank,
            /// <summary>
            /// Касса.
            /// </summary>
            Kassa,
            /// <summary>
            /// Талон.
            /// </summary>
            Talon
        }
    }
}
