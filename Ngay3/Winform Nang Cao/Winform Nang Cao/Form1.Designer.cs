namespace Winform_Nang_Cao
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
            this.nudChose = new System.Windows.Forms.NumericUpDown();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClickme = new System.Windows.Forms.Button();
            this.ltbThu = new System.Windows.Forms.ListBox();
            this.btnClickme2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudChose
            // 
            this.nudChose.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudChose.Location = new System.Drawing.Point(22, 33);
            this.nudChose.Name = "nudChose";
            this.nudChose.Size = new System.Drawing.Size(120, 20);
            this.nudChose.TabIndex = 0;
            this.nudChose.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(22, 79);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(100, 20);
            this.txtShow.TabIndex = 1;
            this.txtShow.TextChanged += new System.EventHandler(this.TxtShow_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thu 2",
            "Thu 3",
            "Thu 4",
            "Thu 5",
            "Thu 6",
            "Thu 7",
            "Chu Nhat"});
            this.comboBox1.Location = new System.Drawing.Point(291, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnClickme
            // 
            this.btnClickme.Location = new System.Drawing.Point(315, 77);
            this.btnClickme.Name = "btnClickme";
            this.btnClickme.Size = new System.Drawing.Size(75, 23);
            this.btnClickme.TabIndex = 3;
            this.btnClickme.Text = "Click Me";
            this.btnClickme.UseVisualStyleBackColor = true;
            this.btnClickme.Click += new System.EventHandler(this.BtnClickme_Click);
            // 
            // ltbThu
            // 
            this.ltbThu.FormattingEnabled = true;
            this.ltbThu.Items.AddRange(new object[] {
            "Thu Hai",
            "Thu Ba",
            "Thu Tu ",
            "Thu Nam",
            "Thu Sau",
            "Thu Bay",
            "Chu Nhat"});
            this.ltbThu.Location = new System.Drawing.Point(22, 122);
            this.ltbThu.Name = "ltbThu";
            this.ltbThu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ltbThu.Size = new System.Drawing.Size(120, 95);
            this.ltbThu.TabIndex = 4;
            this.ltbThu.SelectedIndexChanged += new System.EventHandler(this.LtbThu_SelectedIndexChanged);
            // 
            // btnClickme2
            // 
            this.btnClickme2.Location = new System.Drawing.Point(37, 236);
            this.btnClickme2.Name = "btnClickme2";
            this.btnClickme2.Size = new System.Drawing.Size(75, 23);
            this.btnClickme2.TabIndex = 5;
            this.btnClickme2.Text = "Click Me";
            this.btnClickme2.UseVisualStyleBackColor = true;
            this.btnClickme2.Click += new System.EventHandler(this.BtnClickme2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winform_Nang_Cao.Properties.Resources.thumb_1920_826217;
            this.pictureBox1.Location = new System.Drawing.Point(200, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 365);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClickme2);
            this.Controls.Add(this.ltbThu);
            this.Controls.Add(this.btnClickme);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.nudChose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudChose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudChose;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClickme;
        private System.Windows.Forms.ListBox ltbThu;
        private System.Windows.Forms.Button btnClickme2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

