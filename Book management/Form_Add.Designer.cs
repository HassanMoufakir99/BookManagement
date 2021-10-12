namespace Book_management
{
    partial class Form_Add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_auther = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_books = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rating1 = new Bunifu.Framework.UI.BunifuRating();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 43);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 460);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_auther);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_books);
            this.groupBox2.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(326, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(293, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات اساسية";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.bunifuTransition1.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(192, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "التصنيف:";
            // 
            // txt_price
            // 
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_price, BunifuAnimatorNS.DecorationType.None);
            this.txt_price.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_price.HintText = "";
            this.txt_price.isPassword = false;
            this.txt_price.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_price.LineThickness = 4;
            this.txt_price.Location = new System.Drawing.Point(5, 236);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(281, 33);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_price.OnValueChanged += new System.EventHandler(this.txt_price_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(213, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "السعر:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_auther
            // 
            this.txt_auther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_auther, BunifuAnimatorNS.DecorationType.None);
            this.txt_auther.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_auther.HintForeColor = System.Drawing.Color.Empty;
            this.txt_auther.HintText = "";
            this.txt_auther.isPassword = false;
            this.txt_auther.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_auther.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_auther.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_auther.LineThickness = 4;
            this.txt_auther.Location = new System.Drawing.Point(6, 159);
            this.txt_auther.Margin = new System.Windows.Forms.Padding(4);
            this.txt_auther.Name = "txt_auther";
            this.txt_auther.Size = new System.Drawing.Size(281, 33);
            this.txt_auther.TabIndex = 3;
            this.txt_auther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_auther.OnValueChanged += new System.EventHandler(this.txt_auther_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(199, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "المؤلف:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_books
            // 
            this.txt_books.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_books, BunifuAnimatorNS.DecorationType.None);
            this.txt_books.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_books.HintForeColor = System.Drawing.Color.Empty;
            this.txt_books.HintText = "";
            this.txt_books.isPassword = false;
            this.txt_books.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_books.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_books.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_books.LineThickness = 4;
            this.txt_books.Location = new System.Drawing.Point(5, 77);
            this.txt_books.Margin = new System.Windows.Forms.Padding(4);
            this.txt_books.Name = "txt_books";
            this.txt_books.Size = new System.Drawing.Size(281, 33);
            this.txt_books.TabIndex = 1;
            this.txt_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_books.OnValueChanged += new System.EventHandler(this.txt_books_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(169, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الكتاب:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Rating1);
            this.groupBox1.Controls.Add(this.Datepicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(286, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات ثانوية";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Location = new System.Drawing.Point(65, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحميل صورة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Rating1
            // 
            this.Rating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Rating1, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.Datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(0, 77);
            this.Datepicker1.Margin = new System.Windows.Forms.Padding(6);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(282, 36);
            this.Datepicker1.TabIndex = 11;
            this.Datepicker1.Value = new System.DateTime(2020, 3, 17, 14, 8, 18, 576);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(161, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "غلاف الكتاب:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(203, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "التقييم:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(212, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "التاريخ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 57);
            this.panel3.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "اضافة ";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_add, BunifuAnimatorNS.DecorationType.None);
            this.btn_add.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(196, -1);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(239, 58);
            this.btn_add.TabIndex = 1;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 4;
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_price;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_auther;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_books;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuRating Rating1;
        public Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}