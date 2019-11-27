namespace WinForm
{
    partial class Demo_Bai_Tap_8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtLBGT = new System.Windows.Forms.RadioButton();
            this.cbxC = new System.Windows.Forms.CheckBox();
            this.cbxJava = new System.Windows.Forms.CheckBox();
            this.cbxPython = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Detail";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(120, 86);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(185, 23);
            this.tbxAddress.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(120, 52);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(185, 23);
            this.tbxName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(50, 86);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            this.lblAddress.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(426, 27);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 1;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            this.rbtMale.CheckedChanged += new System.EventHandler(this.RbtMale_CheckedChanged);
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(426, 70);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 1;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtLBGT
            // 
            this.rbtLBGT.AutoSize = true;
            this.rbtLBGT.Location = new System.Drawing.Point(426, 111);
            this.rbtLBGT.Name = "rbtLBGT";
            this.rbtLBGT.Size = new System.Drawing.Size(53, 17);
            this.rbtLBGT.TabIndex = 1;
            this.rbtLBGT.TabStop = true;
            this.rbtLBGT.Text = "LBGT";
            this.rbtLBGT.UseVisualStyleBackColor = true;
            // 
            // cbxC
            // 
            this.cbxC.AutoSize = true;
            this.cbxC.Location = new System.Drawing.Point(426, 166);
            this.cbxC.Name = "cbxC";
            this.cbxC.Size = new System.Drawing.Size(40, 17);
            this.cbxC.TabIndex = 2;
            this.cbxC.Text = "C#";
            this.cbxC.UseVisualStyleBackColor = true;
            this.cbxC.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // cbxJava
            // 
            this.cbxJava.AutoSize = true;
            this.cbxJava.Location = new System.Drawing.Point(426, 207);
            this.cbxJava.Name = "cbxJava";
            this.cbxJava.Size = new System.Drawing.Size(49, 17);
            this.cbxJava.TabIndex = 3;
            this.cbxJava.Text = "Java";
            this.cbxJava.UseVisualStyleBackColor = true;
            // 
            // cbxPython
            // 
            this.cbxPython.AutoSize = true;
            this.cbxPython.Location = new System.Drawing.Point(426, 250);
            this.cbxPython.Name = "cbxPython";
            this.cbxPython.Size = new System.Drawing.Size(59, 17);
            this.cbxPython.TabIndex = 4;
            this.cbxPython.Text = "Python";
            this.cbxPython.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(426, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh",
            "Bình Dương",
            "Cần Thơ",
            "Long An"});
            this.lstCity.Location = new System.Drawing.Point(12, 161);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(382, 173);
            this.lstCity.TabIndex = 6;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.LbxInfo_SelectedIndexChanged);
            // 
            // Demo_Bai_Tap_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxPython);
            this.Controls.Add(this.cbxJava);
            this.Controls.Add(this.cbxC);
            this.Controls.Add(this.rbtLBGT);
            this.Controls.Add(this.rbtFemale);
            this.Controls.Add(this.rbtMale);
            this.Controls.Add(this.groupBox1);
            this.Name = "Demo_Bai_Tap_8";
            this.Text = "Demo_Bai_Tap_8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtLBGT;
        private System.Windows.Forms.CheckBox cbxC;
        private System.Windows.Forms.CheckBox cbxJava;
        private System.Windows.Forms.CheckBox cbxPython;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstCity;
    }
}