
namespace compose
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.title = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.takingOver = new System.Windows.Forms.Button();
            this.calculator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Info;
            this.title.Font = new System.Drawing.Font("굴림", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.title.Location = new System.Drawing.Point(59, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(169, 19);
            this.title.TabIndex = 0;
            this.title.Text = "COMPOSE 도우미";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.LemonChiffon;
            this.check.Cursor = System.Windows.Forms.Cursors.Default;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Location = new System.Drawing.Point(84, 78);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(111, 43);
            this.check.TabIndex = 1;
            this.check.Text = "출근관리";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.LemonChiffon;
            this.order.Cursor = System.Windows.Forms.Cursors.Default;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Location = new System.Drawing.Point(84, 153);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(111, 43);
            this.order.TabIndex = 2;
            this.order.Text = "물품구비";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // takingOver
            // 
            this.takingOver.BackColor = System.Drawing.Color.LemonChiffon;
            this.takingOver.Cursor = System.Windows.Forms.Cursors.Default;
            this.takingOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takingOver.Location = new System.Drawing.Point(84, 231);
            this.takingOver.Name = "takingOver";
            this.takingOver.Size = new System.Drawing.Size(111, 43);
            this.takingOver.TabIndex = 3;
            this.takingOver.Text = "인수인계";
            this.takingOver.UseVisualStyleBackColor = false;
            this.takingOver.Click += new System.EventHandler(this.takingOver_Click);
            // 
            // calculator
            // 
            this.calculator.BackColor = System.Drawing.Color.LemonChiffon;
            this.calculator.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculator.Location = new System.Drawing.Point(84, 307);
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(111, 43);
            this.calculator.TabIndex = 4;
            this.calculator.Text = "정산";
            this.calculator.UseVisualStyleBackColor = false;
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 1.0.1 / 문의 : 지우";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(280, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculator);
            this.Controls.Add(this.takingOver);
            this.Controls.Add(this.order);
            this.Controls.Add(this.check);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "COMPOSE 정산프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button takingOver;
        private System.Windows.Forms.Button calculator;
        private System.Windows.Forms.Label label1;
    }
}

