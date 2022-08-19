namespace Winform_4_homework3
{
    partial class FormIncoming
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelNameError = new System.Windows.Forms.Label();
            this.labelMoneyError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 11F);
            this.label3.Location = new System.Drawing.Point(61, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "记账金额:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 11F);
            this.label2.Location = new System.Drawing.Point(61, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "描述:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F);
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "收入名目:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(152, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(136, 21);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Enter += new System.EventHandler(this.textName_Enter);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(152, 208);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(136, 21);
            this.textDescription.TabIndex = 2;
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(152, 143);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(136, 21);
            this.textMoney.TabIndex = 1;
            this.textMoney.TextChanged += new System.EventHandler(this.textMoney_TextChanged);
            this.textMoney.Enter += new System.EventHandler(this.textMoney_Enter);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(126, 285);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(90, 37);
            this.buttonRecord.TabIndex = 3;
            this.buttonRecord.Text = "记录";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 11F);
            this.label4.Location = new System.Drawing.Point(426, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "总金额:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("SimSun", 11F);
            this.labelTotal.Location = new System.Drawing.Point(506, 44);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 15);
            this.labelTotal.TabIndex = 3;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("SimSun", 11F);
            this.labelDetail.Location = new System.Drawing.Point(426, 91);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(0, 15);
            this.labelDetail.TabIndex = 3;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelNameError.Location = new System.Drawing.Point(150, 115);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(0, 12);
            this.labelNameError.TabIndex = 7;
            // 
            // labelMoneyError
            // 
            this.labelMoneyError.AutoSize = true;
            this.labelMoneyError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMoneyError.Location = new System.Drawing.Point(150, 176);
            this.labelMoneyError.Name = "labelMoneyError";
            this.labelMoneyError.Size = new System.Drawing.Size(0, 12);
            this.labelMoneyError.TabIndex = 8;
            // 
            // FormIncoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMoneyError);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormIncoming";
            this.Text = "FormIncoming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.Label labelMoneyError;
    }
}