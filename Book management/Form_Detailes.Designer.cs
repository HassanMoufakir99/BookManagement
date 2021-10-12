namespace Book_management
{
    partial class Form_Detailes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Detailes));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rating1 = new Bunifu.Framework.UI.BunifuRating();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_auther = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_books = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-1, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_auther);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_books);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Rating1);
            this.groupBox1.Controls.Add(this.Datepicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(739, 403);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الكتاب";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Rating1
            // 
            this.Rating1.BackColor = System.Drawing.Color.Transparent;
            this.Rating1.Font = new System.Drawing.Font("Arabic Typesetting", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.Rating1.Location = new System.Drawing.Point(27, 148);
            this.Rating1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Rating1.Name = "Rating1";
            this.Rating1.Size = new System.Drawing.Size(255, 46);
            this.Rating1.TabIndex = 12;
            this.Rating1.Value = 0;
            // 
            // Datepicker1
            // 
            this.Datepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(0, 65);
            this.Datepicker1.Margin = new System.Windows.Forms.Padding(6);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(282, 36);
            this.Datepicker1.TabIndex = 11;
            this.Datepicker1.Value = new System.DateTime(2020, 3, 17, 14, 8, 18, 576);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(161, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "غلاف الكتاب:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(212, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "التقييم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(212, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "التاريخ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(590, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "التصنيف:";
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price.HintText = "";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_price.LineThickness = 4;
            this.txt_price.Location = new System.Drawing.Point(400, 238);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(281, 33);
            this.txt_price.TabIndex = 20;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(611, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "السعر:";
            // 
            // txt_auther
            // 
            this.txt_auther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_auther.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_auther.HintForeColor = System.Drawing.Color.Empty;
            this.txt_auther.HintText = "";
            this.txt_auther.isPassword = false;
            this.txt_auther.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_auther.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_auther.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_auther.LineThickness = 4;
            this.txt_auther.Location = new System.Drawing.Point(400, 148);
            this.txt_auther.Margin = new System.Windows.Forms.Padding(4);
            this.txt_auther.Name = "txt_auther";
            this.txt_auther.Size = new System.Drawing.Size(281, 33);
            this.txt_auther.TabIndex = 18;
            this.txt_auther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(597, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "المؤلف:";
            // 
            // txt_books
            // 
            this.txt_books.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_books.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_books.HintForeColor = System.Drawing.Color.Empty;
            this.txt_books.HintText = "";
            this.txt_books.isPassword = false;
            this.txt_books.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_books.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_books.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_books.LineThickness = 4;
            this.txt_books.Location = new System.Drawing.Point(400, 63);
            this.txt_books.Margin = new System.Windows.Forms.Padding(4);
            this.txt_books.Name = "txt_books";
            this.txt_books.Size = new System.Drawing.Size(281, 33);
            this.txt_books.TabIndex = 16;
            this.txt_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(567, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "اسم الكتاب:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(400, 328);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(281, 33);
            this.bunifuMaterialTextbox1.TabIndex = 22;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Detailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Detailes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuRating Rating1;
        public Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        private System.Windows.Forms.Label label8;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_auther;
        private System.Windows.Forms.Label label9;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_books;
        private System.Windows.Forms.Label label10;
    }
}