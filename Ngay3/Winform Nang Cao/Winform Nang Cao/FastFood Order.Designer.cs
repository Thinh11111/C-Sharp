namespace Winform_Nang_Cao
{
    partial class FastFood_Order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnComGaTender = new System.Windows.Forms.Button();
            this.btnGaRanPhan = new System.Windows.Forms.Button();
            this.btnGaVienCola = new System.Windows.Forms.Button();
            this.btnTomVienCola = new System.Windows.Forms.Button();
            this.btnPhoMaiCa = new System.Windows.Forms.Button();
            this.btnPhoMaiTom = new System.Windows.Forms.Button();
            this.btnPhoMaiGa = new System.Windows.Forms.Button();
            this.btnPhoMaiBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbChonBan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FastFood Order";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btn7Up);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnKhoaiTayChien);
            this.groupBox1.Controls.Add(this.btnComGaTender);
            this.groupBox1.Controls.Add(this.btnGaRanPhan);
            this.groupBox1.Controls.Add(this.btnGaVienCola);
            this.groupBox1.Controls.Add(this.btnTomVienCola);
            this.groupBox1.Controls.Add(this.btnPhoMaiCa);
            this.groupBox1.Controls.Add(this.btnPhoMaiTom);
            this.groupBox1.Controls.Add(this.btnPhoMaiGa);
            this.groupBox1.Controls.Add(this.btnPhoMaiBo);
            this.groupBox1.Location = new System.Drawing.Point(25, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnCam
            // 
            this.btnCam.Location = new System.Drawing.Point(315, 87);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(52, 23);
            this.btnCam.TabIndex = 2;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.Location = new System.Drawing.Point(315, 58);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(52, 23);
            this.btnLipton.TabIndex = 2;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.btnLipton_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Location = new System.Drawing.Point(262, 87);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(47, 23);
            this.btnCafe.TabIndex = 2;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.Location = new System.Drawing.Point(315, 29);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(52, 23);
            this.btnCoca.TabIndex = 2;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btnCoca_Click);
            // 
            // btn7Up
            // 
            this.btn7Up.Location = new System.Drawing.Point(262, 58);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(47, 23);
            this.btn7Up.TabIndex = 2;
            this.btn7Up.Text = "7 up";
            this.btn7Up.UseVisualStyleBackColor = true;
            this.btn7Up.Click += new System.EventHandler(this.btn7Up_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Location = new System.Drawing.Point(262, 29);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(47, 23);
            this.btnPepsi.TabIndex = 2;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPepsi_Click);
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(262, 116);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(105, 23);
            this.btnKhoaiTayChien.TabIndex = 1;
            this.btnKhoaiTayChien.Text = "Khoai Tây Chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            this.btnKhoaiTayChien.Click += new System.EventHandler(this.btnKhoaiTayChien_Click);
            // 
            // btnComGaTender
            // 
            this.btnComGaTender.Location = new System.Drawing.Point(151, 116);
            this.btnComGaTender.Name = "btnComGaTender";
            this.btnComGaTender.Size = new System.Drawing.Size(93, 23);
            this.btnComGaTender.TabIndex = 1;
            this.btnComGaTender.Text = "Cơm Gà Tender";
            this.btnComGaTender.UseVisualStyleBackColor = true;
            this.btnComGaTender.Click += new System.EventHandler(this.btnComGaTender_Click);
            // 
            // btnGaRanPhan
            // 
            this.btnGaRanPhan.Location = new System.Drawing.Point(151, 87);
            this.btnGaRanPhan.Name = "btnGaRanPhan";
            this.btnGaRanPhan.Size = new System.Drawing.Size(93, 23);
            this.btnGaRanPhan.TabIndex = 1;
            this.btnGaRanPhan.Text = "Gà rán phần";
            this.btnGaRanPhan.UseVisualStyleBackColor = true;
            this.btnGaRanPhan.Click += new System.EventHandler(this.btnGaRanPhan_Click);
            // 
            // btnGaVienCola
            // 
            this.btnGaVienCola.Location = new System.Drawing.Point(151, 58);
            this.btnGaVienCola.Name = "btnGaVienCola";
            this.btnGaVienCola.Size = new System.Drawing.Size(93, 23);
            this.btnGaVienCola.TabIndex = 1;
            this.btnGaVienCola.Text = "Gà viên Cola";
            this.btnGaVienCola.UseVisualStyleBackColor = true;
            this.btnGaVienCola.Click += new System.EventHandler(this.btnGaVienCola_Click);
            // 
            // btnTomVienCola
            // 
            this.btnTomVienCola.Location = new System.Drawing.Point(151, 29);
            this.btnTomVienCola.Name = "btnTomVienCola";
            this.btnTomVienCola.Size = new System.Drawing.Size(93, 23);
            this.btnTomVienCola.TabIndex = 1;
            this.btnTomVienCola.Text = "Tôm viên Cola";
            this.btnTomVienCola.UseVisualStyleBackColor = true;
            this.btnTomVienCola.Click += new System.EventHandler(this.btnTomVienCola_Click);
            // 
            // btnPhoMaiCa
            // 
            this.btnPhoMaiCa.Location = new System.Drawing.Point(13, 116);
            this.btnPhoMaiCa.Name = "btnPhoMaiCa";
            this.btnPhoMaiCa.Size = new System.Drawing.Size(119, 23);
            this.btnPhoMaiCa.TabIndex = 0;
            this.btnPhoMaiCa.Text = "Burger Phô mai Cá";
            this.btnPhoMaiCa.UseVisualStyleBackColor = true;
            this.btnPhoMaiCa.Click += new System.EventHandler(this.btnPhoMaiCa_Click);
            // 
            // btnPhoMaiTom
            // 
            this.btnPhoMaiTom.Location = new System.Drawing.Point(13, 87);
            this.btnPhoMaiTom.Name = "btnPhoMaiTom";
            this.btnPhoMaiTom.Size = new System.Drawing.Size(119, 23);
            this.btnPhoMaiTom.TabIndex = 0;
            this.btnPhoMaiTom.Text = "Burger Phô mai Tôm";
            this.btnPhoMaiTom.UseVisualStyleBackColor = true;
            this.btnPhoMaiTom.Click += new System.EventHandler(this.btnPhoMaiTom_Click);
            // 
            // btnPhoMaiGa
            // 
            this.btnPhoMaiGa.Location = new System.Drawing.Point(13, 58);
            this.btnPhoMaiGa.Name = "btnPhoMaiGa";
            this.btnPhoMaiGa.Size = new System.Drawing.Size(119, 23);
            this.btnPhoMaiGa.TabIndex = 0;
            this.btnPhoMaiGa.Text = "Burger Phô mai Gà";
            this.btnPhoMaiGa.UseVisualStyleBackColor = true;
            this.btnPhoMaiGa.Click += new System.EventHandler(this.btnPhoMaiGa_Click);
            // 
            // btnPhoMaiBo
            // 
            this.btnPhoMaiBo.Location = new System.Drawing.Point(13, 29);
            this.btnPhoMaiBo.Name = "btnPhoMaiBo";
            this.btnPhoMaiBo.Size = new System.Drawing.Size(119, 23);
            this.btnPhoMaiBo.TabIndex = 0;
            this.btnPhoMaiBo.Text = "Burger Phô mai Bò";
            this.btnPhoMaiBo.UseVisualStyleBackColor = true;
            this.btnPhoMaiBo.Click += new System.EventHandler(this.BtnPhoMaiBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(25, 242);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 27);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(319, 242);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(62, 27);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bàn:";
            // 
            // cbbChonBan
            // 
            this.cbbChonBan.FormattingEnabled = true;
            this.cbbChonBan.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3"});
            this.cbbChonBan.Location = new System.Drawing.Point(163, 246);
            this.cbbChonBan.Name = "cbbChonBan";
            this.cbbChonBan.Size = new System.Drawing.Size(121, 21);
            this.cbbChonBan.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 154);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winform_Nang_Cao.Properties.Resources._7e0c47559e;
            this.pictureBox1.Location = new System.Drawing.Point(58, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FastFood_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbChonBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FastFood_Order";
            this.Text = "FastFood Order";
            this.Load += new System.EventHandler(this.FastFood_Order_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComGaTender;
        private System.Windows.Forms.Button btnGaRanPhan;
        private System.Windows.Forms.Button btnGaVienCola;
        private System.Windows.Forms.Button btnTomVienCola;
        private System.Windows.Forms.Button btnPhoMaiCa;
        private System.Windows.Forms.Button btnPhoMaiTom;
        private System.Windows.Forms.Button btnPhoMaiGa;
        private System.Windows.Forms.Button btnPhoMaiBo;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbChonBan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}