using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compose
{
    public partial class Memo : Form
    {
        String nullMemo = "메모가 존재하지 않습니다.";
        private Boolean keyTpye = false;
        private String[] path = {
            Environment.CurrentDirectory + "\\data\\사장님.txt",
            Environment.CurrentDirectory + "\\data\\오픈.txt",
            Environment.CurrentDirectory + "\\data\\미들.txt",
            Environment.CurrentDirectory + "\\data\\마감.txt"
        };
        public Memo()
        {
            InitializeComponent();            

            for(int i = 0; i < path.Length; i++)
            {
                if(!File.Exists(path[i]))
                {
                    File.Create(path[i]).Close();
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyTpye = false;
            if(put.Text == "취   소")
            {
                put.Text = "수   정";
            }
            if (comboBox1.SelectedItem.ToString() == "전체")
            {
                button2.Enabled = false;
                StreamReader boss = new StreamReader(path[0], false);
                StreamReader open = new StreamReader(path[1], false);
                StreamReader midle = new StreamReader(path[2], false);
                StreamReader close = new StreamReader(path[3], false);
                String b = boss.ReadToEnd();
                String o = open.ReadToEnd();
                String m = midle.ReadToEnd();
                String c = close.ReadToEnd();

                if (b.Length == 0 && o.Length == 0 && m.Length == 0 && c.Length == 0)
                {
                    text.Text = nullMemo;
                }
                else
                {
                    String t = "----------------사장님 공지-------------------\r\n" + b + "\r\n\r\n" +
                        "------------오픈 -> 모두 전달사항-------------\r\n" + o + "\r\n\r\n" +
                        "------------미들 -> 모두 전달사항-------------\r\n" + m + "\r\n\r\n" +
                        "------------마감 -> 모두 전달사항-------------\r\n" + c;

                    text.Text = t;
                }
                boss.Close();
                open.Close();
                midle.Close();
                close.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "사장님 공지")
            {
                button2.Enabled = false;
                StreamReader boss = new StreamReader(path[0], false);
                String t = boss.ReadToEnd();
                if(t.Length != 0)
                {
                    text.Text = t;
                }
                else
                {
                    text.Text = nullMemo;
                }
                boss.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "오픈 -> 모두 전달사항")
            {
                button2.Enabled = false;
                StreamReader open = new StreamReader(path[1], false);
                String t = open.ReadToEnd();
                if (t.Length != 0)
                {
                    text.Text = t;
                }
                else
                {
                    text.Text = nullMemo;
                }
                open.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "미들 -> 모두 전달사항")
            {
                button2.Enabled = false;
                StreamReader midle = new StreamReader(path[2], false);
                String t = midle.ReadToEnd();
                if (t.Length != 0)
                {
                    text.Text = t;
                }
                else
                {
                    text.Text = nullMemo;
                }
                midle.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "마감 -> 모두 전달사항")
            {                
                button2.Enabled = false;
                StreamReader close = new StreamReader(path[3], false);
                String t = close.ReadToEnd();
                if (t.Length != 0)
                {
                    text.Text = t;
                }
                else
                {
                    text.Text = nullMemo;
                }
                close.Close();
            }
        }

        // 메모 수정
        private void put_Click(object sender, EventArgs e)
        {            
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("항목을 선택해주세요.", "에러");
            }
            else if (comboBox1.SelectedItem.ToString() == "전체")
            {
                MessageBox.Show("전체 메뉴는 수정이 불가능합니다.", "에러");
            }
            else
            {                
                button2.Enabled = true;
                if (put.Text == "취   소")
                {
                    DialogResult dr = MessageBox.Show("메모를 취소하시겠습니까?", "메모 취소", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        put.Text = "수   정";
                        button2.Enabled = false;
                        keyTpye = false;
                        if (comboBox1.SelectedItem.ToString() == "사장님 공지")
                        {
                            StreamReader boss = new StreamReader(path[0], false);
                            text.Text = boss.ReadToEnd().TrimEnd();
                            boss.Close();
                        }
                        else if (comboBox1.SelectedItem.ToString() == "오픈 -> 모두 전달사항")
                        {
                            StreamReader open = new StreamReader(path[1], false);
                            text.Text = open.ReadToEnd().TrimEnd();
                            open.Close();
                        }
                        else if (comboBox1.SelectedItem.ToString() == "미들 -> 모두 전달사항")
                        {
                            StreamReader midle = new StreamReader(path[2], false);
                            text.Text = midle.ReadToEnd().TrimEnd();
                            midle.Close();
                        }
                        else if (comboBox1.SelectedItem.ToString() == "마감 -> 모두 전달사항")
                        {
                            StreamReader close = new StreamReader(path[3], false);
                            text.Text = close.ReadToEnd().TrimEnd();
                            close.Close();
                        }
                    }
                }
                else
                {
                    put.Text = "취   소";
                    keyTpye = true;
                }
            }
        }

        // 메모 저장
        private void button2_Click(object sender, EventArgs e)
        {                      
            if (comboBox1.SelectedItem.ToString() == "사장님 공지")
            {
                memoSave(new StreamWriter(path[0], false));
            }
            else if (comboBox1.SelectedItem.ToString() == "오픈 -> 모두 전달사항")
            {
                memoSave(new StreamWriter(path[1], false));
            }
            else if (comboBox1.SelectedItem.ToString() == "미들 -> 모두 전달사항")
            {
                memoSave(new StreamWriter(path[2], false));
            }
            else if (comboBox1.SelectedItem.ToString() == "마감 -> 모두 전달사항")
            {
                memoSave(new StreamWriter(path[3], false));
            }           
            
        }

        private void memoSave(StreamWriter cmd)
        {
            if (!string.IsNullOrWhiteSpace(text.Text))
            {
                String 시간 = "              작성 날짜 < " + DateTime.Now.ToString("yyyy-MM-dd hh:mm") + " >\r\n";
                String t = "";
                String[] te = text.Text.Split('\n');
                if (te[0].Contains("              작성 날짜 < "))
                {
                    t = 시간;
                    for (int i = 1; i < te.Length; i++)
                    {
                        t += te[i] + "\r\n";
                    }
                }
                else
                {
                    t = 시간 + text.Text;
                }
                DialogResult dr = MessageBox.Show("메모를 저장하시겠습니까?", "메모 저장", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    text.Text = t;
                    cmd.WriteLine(t);
                    cmd.Close();
                    keyTpye = false;
                    if (put.Text == "취   소")
                    {
                        put.Text = "수   정";
                    }
                    button2.Enabled = false;
                }
                else
                {
                    cmd.Close();
                }
            }
            else
            {
                cmd.Close();                
                text.Text = "메모가 존재하지 않습니다.";
            }
        }

        // 초기화
        private void reset_Click(object sender, EventArgs e)
        {
            resetAllMemo();
        }

        private void resetAllMemo()
        {
            DialogResult dr = MessageBox.Show("모든 메모를 초기화 하시겠습니까?", "메모 초기화", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    if (File.Exists(path[i]))
                    {
                        File.Delete(path[i]);
                    }
                    if (!File.Exists(path[i]))
                    {
                        File.Create(path[i]).Close();
                    }
                }
                comboBox1_SelectedIndexChanged("전체", EventArgs.Empty);
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memo_Load(object sender, EventArgs e)
        {

        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!keyTpye)
            {
                // 모든 입력차단            
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
