namespace Winform_4_homework3
{
    /// <summary>
    /// 接口
    /// </summary>
    public interface IRecord
    {
        string GetRecordInfo();

        decimal CalTotalAmount();
    }


    /// <summary>
    /// 实现接口的 收入记录类
    /// </summary>
    public class InterfaceIncomingRecord : IRecord
    {
        // 编号
        public int Id { get; set; }

        // 名目名称
        public string Name { get; set; }

        // 描述
        public string Description { get; set; }

        // 记账金额
        public decimal Amount { get; set; }

        public InterfaceIncomingRecord(string name, string description, decimal amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        /// <summary>
        /// 获取记录信息
        /// </summary>
        /// <returns></returns>
        public string GetRecordInfo()
        {
            return $"{Name}, {Amount}, {Description}\r\n";
        }

        /// <summary>
        /// 计算总收支
        /// </summary>
        /// <returns></returns>
        public decimal CalTotalAmount()
        {
            ComUtility.TotalAmount = ComUtility.TotalIncome - ComUtility.TotalExpense;
            return ComUtility.TotalAmount;
        }
    }

    /// <summary>
    /// 实现接口的 支出记录类
    /// </summary>
    public class InterfaceExpenseRecord : IRecord
    {
        // 编号
        public int Id { get; set; }

        // 名目名称
        public string Name { get; set; }

        // 描述
        public string Description { get; set; }

        // 记账金额
        public decimal Amount { get; set; }

        // 价格
        public decimal Price { get; set; }

        // 数量
        public int Num { get; set; }

        public InterfaceExpenseRecord(string name, string description, decimal amount, decimal price, int num)
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
        public string GetRecordInfo()
        {
            return $"{Name}, {Price}, {Num}, {Amount}, {Description}\r\n";
        }

        /// <summary>
        /// 计算总收支
        /// </summary>
        /// <returns></returns>
        public decimal CalTotalAmount()
        {
            ComUtility.TotalAmount = ComUtility.TotalIncome - ComUtility.TotalExpense;
            return ComUtility.TotalAmount;
        }
    }

}
