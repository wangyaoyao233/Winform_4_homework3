using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework3
{
    public class ExpenseRecord: RecordBase
    {
        // 价格
        public decimal Price { get; set; }

        // 数量
        public int Num { get; set; }

        public ExpenseRecord(string name, string description, decimal amount, decimal price, int num)
        {
            Name = name;
            Description = description;
            Amount = amount;
            Price = price;
            Num = num;
        }

        /// <summary>
        /// 获取记录信息
        /// </summary>
        /// <returns></returns>
        public override string GetRecordInfo()
        {
            return $"{Name}, {Price}, {Num}, {Amount}, {Description}\r\n";
        }

        /// <summary>
        /// 隐藏
        /// </summary>
        /// <returns></returns>
        new public decimal CalTotalAmount()
        {
            return base.CalTotalAmount();
        }
    }
}
