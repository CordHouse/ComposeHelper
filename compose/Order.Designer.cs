
namespace compose
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.구매요청 = new System.Windows.Forms.Button();
            this.작성자 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.품명 = new System.Windows.Forms.TextBox();
            this.비고 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.조회 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 구매요청
            // 
            this.구매요청.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.구매요청.ForeColor = System.Drawing.SystemColors.ControlText;
            this.구매요청.Location = new System.Drawing.Point(465, 253);
            this.구매요청.Name = "구매요청";
            this.구매요청.Size = new System.Drawing.Size(220, 41);
            this.구매요청.TabIndex = 19;
            this.구매요청.Text = "구 매 요 청";
            this.구매요청.UseVisualStyleBackColor = true;
            this.구매요청.Click += new System.EventHandler(this.구매요청_Click);
            // 
            // 작성자
            // 
            this.작성자.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.작성자.FormattingEnabled = true;
            this.작성자.Location = new System.Drawing.Point(531, 177);
            this.작성자.Name = "작성자";
            this.작성자.Size = new System.Drawing.Size(154, 20);
            this.작성자.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F);
            this.label6.Location = new System.Drawing.Point(462, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "작 성 자";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("굴림", 10F);
            this.label.Location = new System.Drawing.Point(462, 139);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 14);
            this.label.TabIndex = 16;
            this.label.Text = "품     명";
            // 
            // 품명
            // 
            this.품명.Location = new System.Drawing.Point(531, 132);
            this.품명.Name = "품명";
            this.품명.Size = new System.Drawing.Size(154, 21);
            this.품명.TabIndex = 15;
            this.품명.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 비고
            // 
            this.비고.Location = new System.Drawing.Point(531, 212);
            this.비고.Multiline = true;
            this.비고.Name = "비고";
            this.비고.Size = new System.Drawing.Size(154, 23);
            this.비고.TabIndex = 20;
            this.비고.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(462, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "비     고";
            // 
            // 조회
            // 
            this.조회.Location = new System.Drawing.Point(12, 33);
            this.조회.Multiline = true;
            this.조회.Name = "조회";
            this.조회.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.조회.Size = new System.Drawing.Size(430, 390);
            this.조회.TabIndex = 22;
            this.조회.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "발 주 현 황";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.조회);
            this.Controls.Add(this.비고);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.구매요청);
            this.Controls.Add(this.작성자);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.품명);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "물품구비";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 구매요청;
        private System.Windows.Forms.ComboBox 작성자;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox 품명;
        private System.Windows.Forms.TextBox 비고;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 조회;
        private System.Windows.Forms.Label label1;
    }
}