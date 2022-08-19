using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework3
{
    public class IncomingRecord: RecordBase
    {
        public IncomingRecord(string name, string description, decimal amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        /// <summary>
        /// 获取记录信息
        /// </summary>
        /// <returns></returns>
        public override string GetRecordInfo()
        {
            return $"{Name}, {Amount}, {Description}\r\n";
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
