namespace Winform_4_homework3
{
    partial class FormItemInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panelItemType = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIdError = new System.Windows.Forms.Label();
            this.labelNameError = new System.Windows.Forms.Label();
            this.panelItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名目类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "名目编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(59, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "名目名称:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(140, 145);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(144, 21);
            this.textId.TabIndex = 1;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            this.textId.Enter += new System.EventHandler(this.textId_Enter);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 206);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(144, 21);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Enter += new System.EventHandler(this.textName_Enter);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(121, 286);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(96, 41);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // panelItemType
            // 
            this.panelItemType.Controls.Add(this.radioButton2);
            this.panelItemType.Controls.Add(this.radioButton1);
            this.panelItemType.Location = new System.Drawing.Point(141, 82);
            this.panelItemType.Name = "panelItemType";
            this.panelItemType.Size = new System.Drawing.Size(143, 38);
            this.panelItemType.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "支出";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "收入";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("SimSun", 10F);
            this.labelNum.Location = new System.Drawing.Point(527, 82);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(0, 14);
            this.labelNum.TabIndex = 4;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(414, 129);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(0, 12);
            this.labelDetail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10F);
            this.label4.Location = new System.Drawing.Point(444, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "名目数量: ";
            // 
            // labelIdError
            // 
            this.labelIdError.AutoSize = true;
            this.labelIdError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIdError.Location = new System.Drawing.Point(139, 178);
            this.labelIdError.Name = "labelIdError";
            this.labelIdError.Size = new System.Drawing.Size(0, 12);
            this.labelIdError.TabIndex = 6;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelNameError.Location = new System.Drawing.Point(139, 239);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(0, 12);
            this.labelNameError.TabIndex = 7;
            // 
            // FormItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.labelIdError);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.panelItemType);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormItemInfo";
            this.Text = "FormItemInfo";
            this.panelItemType.ResumeLayout(false);
            this.panelItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Panel panelItemType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIdError;
        private System.Windows.Forms.Label labelNameError;
    }
}