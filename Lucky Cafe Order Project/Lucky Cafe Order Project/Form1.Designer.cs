namespace Lucky_Cafe_Order_Project
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.radioTea = new System.Windows.Forms.RadioButton();
            this.radioCoffee = new System.Windows.Forms.RadioButton();
            this.radioJuice = new System.Windows.Forms.RadioButton();
            this.checkStudent = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLuckyMessage = new System.Windows.Forms.Label();
            this.lstOrderlist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucky Cafe Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drink Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // txtCustomName
            // 
            this.txtCustomName.Location = new System.Drawing.Point(185, 70);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(134, 20);
            this.txtCustomName.TabIndex = 4;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(165, 155);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(134, 20);
            this.textQuantity.TabIndex = 5;
            // 
            // radioTea
            // 
            this.radioTea.AutoSize = true;
            this.radioTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTea.Location = new System.Drawing.Point(136, 110);
            this.radioTea.Name = "radioTea";
            this.radioTea.Size = new System.Drawing.Size(79, 20);
            this.radioTea.TabIndex = 6;
            this.radioTea.TabStop = true;
            this.radioTea.Text = "Tea($1)";
            this.radioTea.UseVisualStyleBackColor = true;
            // 
            // radioCoffee
            // 
            this.radioCoffee.AutoSize = true;
            this.radioCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCoffee.Location = new System.Drawing.Point(223, 112);
            this.radioCoffee.Name = "radioCoffee";
            this.radioCoffee.Size = new System.Drawing.Size(96, 20);
            this.radioCoffee.TabIndex = 7;
            this.radioCoffee.TabStop = true;
            this.radioCoffee.Text = "Coffee($2)";
            this.radioCoffee.UseVisualStyleBackColor = true;
            // 
            // radioJuice
            // 
            this.radioJuice.AutoSize = true;
            this.radioJuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJuice.Location = new System.Drawing.Point(337, 112);
            this.radioJuice.Name = "radioJuice";
            this.radioJuice.Size = new System.Drawing.Size(88, 20);
            this.radioJuice.TabIndex = 8;
            this.radioJuice.TabStop = true;
            this.radioJuice.Text = "Juice($3)";
            this.radioJuice.UseVisualStyleBackColor = true;
            // 
            // checkStudent
            // 
            this.checkStudent.AutoSize = true;
            this.checkStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStudent.Location = new System.Drawing.Point(64, 203);
            this.checkStudent.Name = "checkStudent";
            this.checkStudent.Size = new System.Drawing.Size(217, 22);
            this.checkStudent.TabIndex = 9;
            this.checkStudent.Text = "Student Member(10%Off)";
            this.checkStudent.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 267);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 35);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Order";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(12, 331);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(136, 29);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load From File";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(200, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(134, 381);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(165, 23);
            this.lblTotalPrice.TabIndex = 15;
            // 
            // lblLuckyMessage
            // 
            this.lblLuckyMessage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLuckyMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuckyMessage.ForeColor = System.Drawing.Color.Black;
            this.lblLuckyMessage.Location = new System.Drawing.Point(132, 416);
            this.lblLuckyMessage.Name = "lblLuckyMessage";
            this.lblLuckyMessage.Size = new System.Drawing.Size(165, 23);
            this.lblLuckyMessage.TabIndex = 16;
            // 
            // lstOrderlist
            // 
            this.lstOrderlist.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderlist.FormattingEnabled = true;
            this.lstOrderlist.ItemHeight = 17;
            this.lstOrderlist.Location = new System.Drawing.Point(461, 12);
            this.lstOrderlist.Name = "lstOrderlist";
            this.lstOrderlist.Size = new System.Drawing.Size(361, 463);
            this.lstOrderlist.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lucky Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstOrderlist);
            this.Controls.Add(this.lblLuckyMessage);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.checkStudent);
            this.Controls.Add(this.radioJuice);
            this.Controls.Add(this.radioCoffee);
            this.Controls.Add(this.radioTea);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.txtCustomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.RadioButton radioTea;
        private System.Windows.Forms.RadioButton radioCoffee;
        private System.Windows.Forms.RadioButton radioJuice;
        private System.Windows.Forms.CheckBox checkStudent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLuckyMessage;
        private System.Windows.Forms.ListBox lstOrderlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

