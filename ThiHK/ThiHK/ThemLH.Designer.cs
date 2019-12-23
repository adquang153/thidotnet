namespace ThiHK
{
    partial class ThemLH
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.cb_khoihoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphonghoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(238, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học:";
            // 
            // txttenlop
            // 
            this.txttenlop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenlop.Location = new System.Drawing.Point(125, 178);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(195, 29);
            this.txttenlop.TabIndex = 3;
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Items.AddRange(new object[] {
            "2019-2020",
            "2018-2019",
            "2017-2018"});
            this.cb_namhoc.Location = new System.Drawing.Point(125, 26);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(195, 29);
            this.cb_namhoc.TabIndex = 4;
            // 
            // cb_khoihoc
            // 
            this.cb_khoihoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khoihoc.FormattingEnabled = true;
            this.cb_khoihoc.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cb_khoihoc.Location = new System.Drawing.Point(125, 72);
            this.cb_khoihoc.Name = "cb_khoihoc";
            this.cb_khoihoc.Size = new System.Drawing.Size(195, 29);
            this.cb_khoihoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên lớp";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phòng học";
            // 
            // txtphonghoc
            // 
            this.txtphonghoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonghoc.Location = new System.Drawing.Point(125, 232);
            this.txtphonghoc.Name = "txtphonghoc";
            this.txtphonghoc.Size = new System.Drawing.Size(195, 29);
            this.txtphonghoc.TabIndex = 8;
            this.txtphonghoc.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã lớp:";
            // 
            // txtmalop
            // 
            this.txtmalop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop.Location = new System.Drawing.Point(125, 126);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(195, 29);
            this.txtmalop.TabIndex = 10;
            // 
            // ThemLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 344);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphonghoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_khoihoc);
            this.Controls.Add(this.cb_namhoc);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ThemLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemLH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private System.Windows.Forms.ComboBox cb_khoihoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphonghoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmalop;
    }
}