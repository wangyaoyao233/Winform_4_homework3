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
    public partial class FormItemInfo : Form
    {
        private bool canSubmit = false;
        public FormItemInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重置输入框
        /// </summary>
        private void resetValue()
        {
            textId.Text = "";
            textName.Text = "";
            canSubmit = false;
        }

        /// <summary>
        /// 检查Id
        /// </summary>
        private void checkId()
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                labelIdError.Text = Define.EMPTY;
                canSubmit = false;
            }
            else if (!int.TryParse(textId.Text.Trim(), out int result))
            {
                labelIdError.Text = Define.INTERROR;
                canSubmit = false;
            }
            else
            {
                // no error
                labelIdError.Text = "";
                canSubmit = true;
            }
        }

        /// <summary>
        /// 检查名字
        /// </summary>
        private void checkName()
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                labelNameError.Text = Define.EMPTY;
                canSubmit = false;
            }
            else
            {
                // no error
                labelNameError.Text = "";
                canSubmit = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!canSubmit) return;

            ItemInfo itemInfo = new ItemInfo();
            
            // 获取输入内容并填充itemInfo类
            foreach(RadioButton rb in this.panelItemType.Controls)
            {
                if (rb.Checked)
                {
                    itemInfo.Type = rb.Text;
                    break;
                }
            }
            if(this.textId.Text.Trim().ToInt() is int id)
            {
                itemInfo.Id = id;
            }
            itemInfo.Name = this.textName.Text.Trim();

            // 计算
            ComUtility.ItemNum++;

            // 输出显示内容
            this.labelNum.Text = ComUtility.ItemNum.ToString();
            this.labelDetail.Text += new ItemInfoDisplay().GetItemInfo(itemInfo);

            this.resetValue();
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            checkId();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            checkName();
        }
        private void textId_Enter(object sender, EventArgs e)
        {
            checkId();
        }

        private void textName_Enter(object sender, EventArgs e)
        {
            checkName();
        }
    }
}
