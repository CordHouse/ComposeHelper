
namespace compose
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.근무자box = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.형태 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.출근기록 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.출근시간 = new System.Windows.Forms.ComboBox();
            this.출근분 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.퇴근분 = new System.Windows.Forms.ComboBox();
            this.퇴근시간 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.누락기록 = new System.Windows.Forms.TextBox();
            this.누락등록 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.근무자등록 = new System.Windows.Forms.Button();
            this.근무타임 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.이름 = new System.Windows.Forms.TextBox();
            this.삭제 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.수정기록 = new System.Windows.Forms.TextBox();
            this.수정등록 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 근무자box
            // 
            this.근무자box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.근무자box.FormattingEnabled = true;
            this.근무자box.Location = new System.Drawing.Point(4, 15);
            this.근무자box.Name = "근무자box";
            this.근무자box.Size = new System.Drawing.Size(150, 20);
            this.근무자box.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 12);
            this.label.TabIndex = 4;
            this.label.Text = "출근시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "퇴근시간";
            // 
            // 형태
            // 
            this.형태.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.형태.FormattingEnabled = true;
            this.형태.Items.AddRange(new object[] {
            "기존",
            "대타"});
            this.형태.Location = new System.Drawing.Point(7, 15);
            this.형태.Name = "형태";
            this.형태.Size = new System.Drawing.Size(70, 20);
            this.형태.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "근무 형태";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "근무자";
            // 
            // 출근기록
            // 
            this.출근기록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.출근기록.ForeColor = System.Drawing.SystemColors.ControlText;
            this.출근기록.Location = new System.Drawing.Point(14, 161);
            this.출근기록.Name = "출근기록";
            this.출근기록.Size = new System.Drawing.Size(241, 41);
            this.출근기록.TabIndex = 13;
            this.출근기록.Text = "출근 기록하기";
            this.출근기록.UseVisualStyleBackColor = true;
            this.출근기록.Click += new System.EventHandler(this.출근기록_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "근무 변경 사유";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 14;
            // 
            // 출근시간
            // 
            this.출근시간.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.출근시간.FormattingEnabled = true;
            this.출근시간.Items.AddRange(new object[] {
            "07시",
            "08시",
            "09시",
            "10시",
            "11시",
            "12시",
            "13시",
            "14시",
            "15시",
            "16시",
            "17시",
            "18시",
            "19시",
            "20시",
            "21시",
            "22시",
            "23시"});
            this.출근시간.Location = new System.Drawing.Point(3, 15);
            this.출근시간.Name = "출근시간";
            this.출근시간.Size = new System.Drawing.Size(53, 20);
            this.출근시간.TabIndex = 19;
            this.출근시간.SelectedIndexChanged += new System.EventHandler(this.출근시간_SelectedIndexChanged);
            // 
            // 출근분
            // 
            this.출근분.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.출근분.FormattingEnabled = true;
            this.출근분.Items.AddRange(new object[] {
            "00분",
            "05분",
            "10분",
            "15분",
            "20분",
            "25분",
            "30분",
            "35분",
            "40분",
            "45분",
            "50분",
            "55분"});
            this.출근분.Location = new System.Drawing.Point(63, 15);
            this.출근분.Name = "출근분";
            this.출근분.Size = new System.Drawing.Size(53, 20);
            this.출근분.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64789F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.31034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.68966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 103);
            this.tableLayoutPanel1.TabIndex = 23;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.근무자box);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.형태);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Size = new System.Drawing.Size(246, 45);
            this.splitContainer3.SplitterDistance = 157;
            this.splitContainer3.TabIndex = 11;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Location = new System.Drawing.Point(3, 58);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.출근분);
            this.splitContainer5.Panel1.Controls.Add(this.출근시간);
            this.splitContainer5.Panel1.Controls.Add(this.label);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.퇴근분);
            this.splitContainer5.Panel2.Controls.Add(this.label1);
            this.splitContainer5.Panel2.Controls.Add(this.퇴근시간);
            this.splitContainer5.Size = new System.Drawing.Size(246, 41);
            this.splitContainer5.SplitterDistance = 120;
            this.splitContainer5.TabIndex = 13;
            // 
            // 퇴근분
            // 
            this.퇴근분.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.퇴근분.FormattingEnabled = true;
            this.퇴근분.Items.AddRange(new object[] {
            "00분",
            "05분",
            "10분",
            "15분",
            "20분",
            "25분",
            "30분",
            "35분",
            "40분",
            "45분",
            "50분",
            "55분"});
            this.퇴근분.Location = new System.Drawing.Point(64, 15);
            this.퇴근분.Name = "퇴근분";
            this.퇴근분.Size = new System.Drawing.Size(53, 20);
            this.퇴근분.TabIndex = 22;
            // 
            // 퇴근시간
            // 
            this.퇴근시간.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.퇴근시간.FormattingEnabled = true;
            this.퇴근시간.Items.AddRange(new object[] {
            "07시",
            "08시",
            "09시",
            "10시",
            "11시",
            "12시",
            "13시",
            "14시",
            "15시",
            "16시",
            "17시",
            "18시",
            "19시",
            "20시",
            "21시",
            "22시",
            "23시"});
            this.퇴근시간.Location = new System.Drawing.Point(5, 15);
            this.퇴근시간.Name = "퇴근시간";
            this.퇴근시간.Size = new System.Drawing.Size(53, 20);
            this.퇴근시간.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 234);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.출근기록);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "근무 기록";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.수정기록);
            this.tabPage2.Controls.Add(this.수정등록);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.누락기록);
            this.tabPage2.Controls.Add(this.누락등록);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(264, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "기록 누락";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "누락 일";
            // 
            // 누락기록
            // 
            this.누락기록.Location = new System.Drawing.Point(47, 27);
            this.누락기록.Multiline = true;
            this.누락기록.Name = "누락기록";
            this.누락기록.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.누락기록.Size = new System.Drawing.Size(67, 112);
            this.누락기록.TabIndex = 26;
            // 
            // 누락등록
            // 
            this.누락등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.누락등록.ForeColor = System.Drawing.SystemColors.ControlText;
            this.누락등록.Location = new System.Drawing.Point(47, 145);
            this.누락등록.Name = "누락등록";
            this.누락등록.Size = new System.Drawing.Size(67, 57);
            this.누락등록.TabIndex = 25;
            this.누락등록.Text = "근무 누락 기록";
            this.누락등록.UseVisualStyleBackColor = true;
            this.누락등록.Click += new System.EventHandler(this.누락등록_Click);
            this.누락등록.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage3.Controls.Add(this.근무자등록);
            this.tabPage3.Controls.Add(this.근무타임);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.이름);
            this.tabPage3.Controls.Add(this.삭제);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(264, 208);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "근무자 등록";
            // 
            // 근무자등록
            // 
            this.근무자등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.근무자등록.ForeColor = System.Drawing.SystemColors.ControlText;
            this.근무자등록.Location = new System.Drawing.Point(55, 120);
            this.근무자등록.Name = "근무자등록";
            this.근무자등록.Size = new System.Drawing.Size(156, 31);
            this.근무자등록.TabIndex = 24;
            this.근무자등록.Text = "근무자 등록";
            this.근무자등록.UseVisualStyleBackColor = true;
            this.근무자등록.Click += new System.EventHandler(this.근무자등록_Click_1);
            // 
            // 근무타임
            // 
            this.근무타임.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.근무타임.FormattingEnabled = true;
            this.근무타임.Items.AddRange(new object[] {
            "평일 오픈",
            "평일 미들",
            "평일 마감",
            "주말 오픈",
            "주말 미들",
            "주말 마감",
            "오픈",
            "미들",
            "마감"});
            this.근무타임.Location = new System.Drawing.Point(121, 80);
            this.근무타임.Name = "근무타임";
            this.근무타임.Size = new System.Drawing.Size(90, 20);
            this.근무타임.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F);
            this.label9.Location = new System.Drawing.Point(52, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "근무타임";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10F);
            this.label10.Location = new System.Drawing.Point(52, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "이름";
            // 
            // 이름
            // 
            this.이름.Location = new System.Drawing.Point(87, 37);
            this.이름.Name = "이름";
            this.이름.Size = new System.Drawing.Size(124, 21);
            this.이름.TabIndex = 20;
            this.이름.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 삭제
            // 
            this.삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.삭제.ForeColor = System.Drawing.SystemColors.ControlText;
            this.삭제.Location = new System.Drawing.Point(55, 157);
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(156, 31);
            this.삭제.TabIndex = 19;
            this.삭제.Text = "근무자 삭제";
            this.삭제.UseVisualStyleBackColor = true;
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "수정 일";
            // 
            // 수정기록
            // 
            this.수정기록.Location = new System.Drawing.Point(148, 27);
            this.수정기록.Multiline = true;
            this.수정기록.Name = "수정기록";
            this.수정기록.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.수정기록.Size = new System.Drawing.Size(67, 112);
            this.수정기록.TabIndex = 29;
            // 
            // 수정등록
            // 
            this.수정등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.수정등록.ForeColor = System.Drawing.SystemColors.ControlText;
            this.수정등록.Location = new System.Drawing.Point(148, 145);
            this.수정등록.Name = "수정등록";
            this.수정등록.Size = new System.Drawing.Size(67, 57);
            this.수정등록.TabIndex = 28;
            this.수정등록.Text = "근무 기록 수정";
            this.수정등록.UseVisualStyleBackColor = true;
            this.수정등록.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(295, 254);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check";
            this.Text = "출근관리";
            this.Load += new System.EventHandler(this.Check_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox 근무자box;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 형태;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 출근기록;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox 출근시간;
        private System.Windows.Forms.ComboBox 출근분;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox 퇴근분;
        private System.Windows.Forms.ComboBox 퇴근시간;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button 삭제;
        private System.Windows.Forms.Button 근무자등록;
        private System.Windows.Forms.ComboBox 근무타임;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 이름;
        private System.Windows.Forms.Button 누락등록;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 누락기록;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 수정기록;
        private System.Windows.Forms.Button 수정등록;
    }
}