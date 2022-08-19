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
    public partial class FormExpense : Form
    {
        private int totalNum = 0;
        public FormExpense()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            this.textName.Text = "";
            this.textDescription.Text = "";
            this.textPrice.Text = "";
            this.textNum.Text = "";
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string name = this.textName.Text;
            string description = this.textDescription.Text;
            int num = int.Parse(this.textNum.Text);
            decimal price = decimal.Parse(this.textPrice.Text);
            decimal amount = num * price;

            ExpenseRecord expenseRecord = new ExpenseRecord(
                name,
                description,
                amount,
                price,
                num);

            // 记录总支出
            ComUtility.TotalExpense += decimal.Parse(this.textPrice.Text) * int.Parse(this.textNum.Text);
            // 记录总数量
            totalNum += num;
            // 计算均价
            decimal averagePrice = ComUtility.TotalExpense / totalNum;

            // show info
            this.textMoney.Text = amount.ToString("0.00");
            // 显示总收支(TotalAmount = Income - Expense)
            this.labelTotalMoney.Text = expenseRecord.CalTotalAmount().ToString("0.00");
            this.labelTotalNum.Text = totalNum.ToString();
            this.labelAverage.Text = averagePrice.ToString("0.00");

            this.labelDetail.Text += expenseRecord.GetRecordInfo();

            this.resetValue();
        }
    }
}
