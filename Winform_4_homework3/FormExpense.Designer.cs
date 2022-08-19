namespace Winform_4_homework3
{
    partial class FormExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRecord = new System.Windows.Forms.Button();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(138, 356);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(90, 37);
            this.buttonRecord.TabIndex = 5;
            this.buttonRecord.Text = "记录";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // textMoney
            // 
            this.textMoney.Enabled = false;
            this.textMoney.Location = new System.Drawing.Point(164, 274);
            this.textMoney.Name = "textMoney";
            this.textMoney.ReadOnly = true;
            this.textMoney.Size = new System.Drawing.Size(136, 21);
            this.textMoney.TabIndex = 4;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(164, 223);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(136, 21);
            this.textDescription.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(164, 79);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(136, 21);
            this.textName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 11F);
            this.label3.Location = new System.Drawing.Point(73, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "记账金额:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 11F);
            this.label2.Location = new System.Drawing.Point(73, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "描述:";
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.AutoSize = true;
            this.labelTotalMoney.Font = new System.Drawing.Font("SimSun", 9F);
            this.labelTotalMoney.Location = new System.Drawing.Point(518, 41);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(0, 12);
            this.labelTotalMoney.TabIndex = 8;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("SimSun", 9F);
            this.labelDetail.Location = new System.Drawing.Point(438, 114);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(0, 12);
            this.labelDetail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F);
            this.label4.Location = new System.Drawing.Point(438, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "总金额:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F);
            this.label1.Location = new System.Drawing.Point(73, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "支出名目:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 11F);
            this.label5.Location = new System.Drawing.Point(73, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "单价:";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(164, 123);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(136, 21);
            this.textPrice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 11F);
            this.label6.Location = new System.Drawing.Point(73, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "数量:";
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(164, 170);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(136, 21);
            this.textNum.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F);
            this.label7.Location = new System.Drawing.Point(438, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "总数量:";
            // 
            // labelTotalNum
            // 
            this.labelTotalNum.AutoSize = true;
            this.labelTotalNum.Font = new System.Drawing.Font("SimSun", 9F);
            this.labelTotalNum.Location = new System.Drawing.Point(518, 65);
            this.labelTotalNum.Name = "labelTotalNum";
            this.labelTotalNum.Size = new System.Drawing.Size(0, 12);
            this.labelTotalNum.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9F);
            this.label9.Location = new System.Drawing.Point(438, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "平均金额:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("SimSun", 9F);
            this.labelAverage.Location = new System.Drawing.Point(518, 88);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 12);
            this.labelAverage.TabIndex = 8;
            // 
            // FormExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelTotalNum);
            this.Controls.Add(this.labelTotalMoney);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormExpense";
            this.Text = "FormExpense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAverage;
    }
}