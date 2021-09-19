namespace BasicControl
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
            this.btnCong_click = new System.Windows.Forms.Button();
            this.btnTru_CLick = new System.Windows.Forms.Button();
            this.btnNhan_Click = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnChia_Click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình nhập cơ bản ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ hai:";
            // 
            // btnCong_click
            // 
            this.btnCong_click.Location = new System.Drawing.Point(239, 192);
            this.btnCong_click.Name = "btnCong_click";
            this.btnCong_click.Size = new System.Drawing.Size(46, 26);
            this.btnCong_click.TabIndex = 2;
            this.btnCong_click.Text = "+";
            this.btnCong_click.UseVisualStyleBackColor = true;
            this.btnCong_click.Click += new System.EventHandler(this.btnCong_click_Click);
            // 
            // btnTru_CLick
            // 
            this.btnTru_CLick.Location = new System.Drawing.Point(302, 192);
            this.btnTru_CLick.Name = "btnTru_CLick";
            this.btnTru_CLick.Size = new System.Drawing.Size(46, 26);
            this.btnTru_CLick.TabIndex = 2;
            this.btnTru_CLick.Text = "-";
            this.btnTru_CLick.UseVisualStyleBackColor = true;
            this.btnTru_CLick.Click += new System.EventHandler(this.btnTru_CLick_Click);
            // 
            // btnNhan_Click
            // 
            this.btnNhan_Click.Location = new System.Drawing.Point(373, 192);
            this.btnNhan_Click.Name = "btnNhan_Click";
            this.btnNhan_Click.Size = new System.Drawing.Size(46, 26);
            this.btnNhan_Click.TabIndex = 2;
            this.btnNhan_Click.Text = "*";
            this.btnNhan_Click.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(459, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 26);
            this.button4.TabIndex = 2;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnChia_Click
            // 
            this.btnChia_Click.Location = new System.Drawing.Point(459, 192);
            this.btnChia_Click.Name = "btnChia_Click";
            this.btnChia_Click.Size = new System.Drawing.Size(46, 26);
            this.btnChia_Click.TabIndex = 2;
            this.btnChia_Click.Text = "/";
            this.btnChia_Click.UseVisualStyleBackColor = true;
            this.btnChia_Click.Click += new System.EventHandler(this.btnChia_Click_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(236, 241);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 13);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "0";
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(242, 103);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(367, 20);
            this.txtsothunhat.TabIndex = 3;
            this.txtsothunhat.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(242, 155);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(367, 20);
            this.txtsothuhai.TabIndex = 3;
            this.txtsothuhai.TextChanged += new System.EventHandler(this.sothuhai_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 345);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.btnChia_Click);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnNhan_Click);
            this.Controls.Add(this.btnTru_CLick);
            this.Controls.Add(this.btnCong_click);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCong_click;
        private System.Windows.Forms.Button btnTru_CLick;
        private System.Windows.Forms.Button btnNhan_Click;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnChia_Click;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.TextBox txtsothuhai;
    }
}

