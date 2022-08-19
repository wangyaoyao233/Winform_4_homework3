using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework3
{
    public class RecordBase
    {
        //定义一个RecordBase基类，包含编号、描述、名目类型、名目名称、记账金额属性，
        //定义一个虚方法：GetRecordInfo(),生成信息字符串，一个非虚方法：CalTotalAmount(),计算当前记账的总收支金额

        // 编号
        public int Id { get; set; }

        // 名目名称
        public string Name { get; set; }

        // 描述
        public string Description { get; set; }

        // 记账金额
        public decimal Amount { get; set; }

        public virtual string GetRecordInfo() 
        {
            return $"{Name}, {Amount}, {Description}\r\n";
        }

        public decimal CalTotalAmount()
        {
            ComUtility.TotalAmount = ComUtility.TotalIncome - ComUtility.TotalExpense;
            return ComUtility.TotalAmount;
        }
    }
}
