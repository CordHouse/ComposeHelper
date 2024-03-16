
namespace compose
{
    partial class OpenClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenClose));
            this.t1 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.정산toggle = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.후불text = new System.Windows.Forms.TextBox();
            this.후불날짜text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.후불누적 = new System.Windows.Forms.TextBox();
            this.후불toggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t1.Location = new System.Drawing.Point(366, 43);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(97, 25);
            this.t1.TabIndex = 2;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // t3
            // 
            this.t3.Enabled = false;
            this.t3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t3.Location = new System.Drawing.Point(366, 141);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(97, 25);
            this.t3.TabIndex = 4;
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "마감 금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "제외 금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "잉여 잔액";
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t2.Location = new System.Drawing.Point(366, 92);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(97, 25);
            this.t2.TabIndex = 3;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(368, 261);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(98, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "초기화";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // 정산toggle
            // 
            this.정산toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.정산toggle.Location = new System.Drawing.Point(283, 26);
            this.정산toggle.Name = "정산toggle";
            this.정산toggle.Size = new System.Drawing.Size(66, 109);
            this.정산toggle.TabIndex = 12;
            this.정산toggle.Text = "계좌이체 수정";
            this.정산toggle.UseVisualStyleBackColor = true;
            this.정산toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // check
            // 
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(366, 174);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(97, 77);
            this.check.TabIndex = 13;
            this.check.Text = "정산";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // text
            // 
            this.text.Enabled = false;
            this.text.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text.Location = new System.Drawing.Point(12, 22);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(139, 113);
            this.text.TabIndex = 1;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            this.text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "계좌이체 내역";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.total.Location = new System.Drawing.Point(157, 226);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(120, 25);
            this.total.TabIndex = 16;
            this.total.Text = "0";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(9, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "금일 누적 계좌이체";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.Location = new System.Drawing.Point(157, 22);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(120, 113);
            this.date.TabIndex = 18;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "날짜";
            // 
            // 후불text
            // 
            this.후불text.Enabled = false;
            this.후불text.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.후불text.Location = new System.Drawing.Point(12, 156);
            this.후불text.Multiline = true;
            this.후불text.Name = "후불text";
            this.후불text.Size = new System.Drawing.Size(139, 64);
            this.후불text.TabIndex = 20;
            // 
            // 후불날짜text
            // 
            this.후불날짜text.Enabled = false;
            this.후불날짜text.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.후불날짜text.Location = new System.Drawing.Point(157, 156);
            this.후불날짜text.Multiline = true;
            this.후불날짜text.Name = "후불날짜text";
            this.후불날짜text.Size = new System.Drawing.Size(120, 64);
            this.후불날짜text.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "후불정산 내역";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "날짜";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(9, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "금일 누적 후불결제";
            // 
            // 후불누적
            // 
            this.후불누적.Enabled = false;
            this.후불누적.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.후불누적.Location = new System.Drawing.Point(157, 257);
            this.후불누적.Multiline = true;
            this.후불누적.Name = "후불누적";
            this.후불누적.Size = new System.Drawing.Size(120, 25);
            this.후불누적.TabIndex = 24;
            this.후불누적.Text = "0";
            this.후불누적.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // 후불toggle
            // 
            this.후불toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.후불toggle.Location = new System.Drawing.Point(283, 156);
            this.후불toggle.Name = "후불toggle";
            this.후불toggle.Size = new System.Drawing.Size(66, 64);
            this.후불toggle.TabIndex = 26;
            this.후불toggle.Text = "후불결제 수정";
            this.후불toggle.UseVisualStyleBackColor = true;
            this.후불toggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(475, 292);
            this.Controls.Add(this.후불toggle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.후불누적);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.후불날짜text);
            this.Controls.Add(this.후불text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.check);
            this.Controls.Add(this.정산toggle);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenClose";
            this.Text = "정산";
            this.Load += new System.EventHandler(this.OpenClose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button 정산toggle;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 후불text;
        private System.Windows.Forms.TextBox 후불날짜text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 후불누적;
        private System.Windows.Forms.Button 후불toggle;
    }
}