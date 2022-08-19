namespace Winform_4_homework3
{
    public class WeekStatistics
    {
        /*
           1）定义一个周统计类：WeekStatistics,包含年份、周数、总收入、总支出、日收支列表（索引类）
           2）为日收支列表定义一个包含索引器的类，可按索引号、字符串索引访问列表中某天的收支金额。
           3）实例化一个周统计类的实例，初始化各属性值，可根据索引访问日收支列表中的金额。
         */
        public int Year { get; set; }
        public int Week { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public DailyReport DailyReport { get; set; }
    }

    public class DailyReport
    {
        const int DAYSOFYEAR = 365;
        // 日收支
        private decimal[] report = new decimal[DAYSOFYEAR];

        // 索引器
        public decimal this[int index]
        {
            get
            {
                decimal tmp;

                if (index >= 0 && index <= DAYSOFYEAR - 1)
                {
                    tmp = report[index];
                }
                else
                {
                    tmp = decimal.Zero;
                }

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= DAYSOFYEAR - 1)
                {
                    report[index] = value;
                }
            }
        }
    }
}
