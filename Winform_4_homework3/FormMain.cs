using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_4_homework3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonItemInfo_Click(object sender, EventArgs e)
        {
            FormItemInfo formItemInfo = new FormItemInfo();
            formItemInfo.Show();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            FormIncoming formIncoming = new FormIncoming();
            formIncoming.Show();
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            FormExpense formExpense = new FormExpense();
            formExpense.Show();
        }

        private void buttonWeekStatistics_Click(object sender, EventArgs e)
        {
            WeekStatistics weekStatistics = new WeekStatistics();
            weekStatistics.DailyReport = new DailyReport();
            
            // 为数组赋值
            for(int i = 0; i < 365; i++)
            {
                weekStatistics.DailyReport[i] = i;
            }

            // 随机访问测试
            MessageBox.Show(weekStatistics.DailyReport[new Random().Next(0,365)].ToString());
        }
    }
}
