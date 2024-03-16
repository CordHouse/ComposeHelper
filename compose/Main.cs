using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace compose
{
    public partial class Main : Form
    {        
        public Main()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // 품절 관리
        private void check_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if(openForm.Name == "Check")
                {
                    if(openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }
            Check check = new Check();
            check.StartPosition = FormStartPosition.Manual;
            check.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            check.Show();
        }

        // 재고 관리
        private void order_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "Order")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }
            Order order = new Order();
            order.StartPosition = FormStartPosition.Manual;
            order.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            order.Show();
        }
        
        // 인수인계 및 메모
        private void takingOver_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "Memo")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }
            Memo memo = new Memo();
            memo.StartPosition = FormStartPosition.Manual;
            memo.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            memo.Show();
        }

        // 정산 및 오픈 및 마감
        private void calculator_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "OpenClose")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }
            OpenClose openClose = new OpenClose();
            openClose.StartPosition = FormStartPosition.Manual;
            openClose.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            openClose.Show();
        }
    }
}
