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
    public partial class OpenClose : Form
    {
        private static String content = "금일 3000원, 5000원\r\n계좌이체가 있는 경우 \r\nex)\r\n3000\r\n5000";
        private static String content1 = "금일 3000원, 5000원\r\n후불결제가 있는 경우 \r\nex)\r\n3000\r\n5000";
        public OpenClose()
        {
            InitializeComponent();
            String path = Environment.CurrentDirectory + "\\data\\정산.txt";
            String path1 = Environment.CurrentDirectory + "\\data\\후불.txt";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, content, Encoding.UTF8);
                StreamReader 정산text = new StreamReader(path , false);
                text.Text = 정산text.ReadToEnd();
                정산text.Close();
            }
            else
            {
                StreamReader 정산text = new StreamReader(path, false);
                text.Text = 정산text.ReadToEnd();
                정산text.Close();

                String[] line = text.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int breakPoint;
                Boolean check = true;
                for (int i = 0; i < line.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(line[i]))
                    {
                        continue;
                    }                    
                    if(!int.TryParse(line[i], out breakPoint))
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    stackCal(line, "계좌");
                }
            }

            if(!File.Exists(path1))
            {                
                File.AppendAllText(path1, content1, Encoding.UTF8);
                StreamReader 후불 = new StreamReader(path1, false);
                후불text.Text = 후불.ReadToEnd();
                후불.Close();
            }
            else
            {
                StreamReader 후불 = new StreamReader(path1, false);
                후불text.Text = 후불.ReadToEnd();
                후불.Close();

                String[] 후불line = 후불text.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int breakPoint1;
                Boolean check1 = true;
                for (int i = 0; i < 후불line.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(후불line[i]))
                    {
                        continue;
                    }
                    if (!int.TryParse(후불line[i], out breakPoint1))
                    {
                        check1 = false;
                    }
                }

                if (check1)
                {
                    stackCal(후불line, "후불");
                }
            }

            // 날짜 불러오기
            path = Environment.CurrentDirectory + "\\data\\정산날짜.txt";
            path1 = Environment.CurrentDirectory + "\\data\\후불날짜.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                StreamReader calDate = new StreamReader(path, false);
                date.Text = calDate.ReadToEnd();
                calDate.Close();
            }
            if(!File.Exists(path1))
            {
                File.Create(path1).Close();
            }
            else
            {
                StreamReader 후불날짜 = new StreamReader(path1, false);
                후불날짜text.Text = 후불날짜.ReadToEnd();
                후불날짜.Close();
            }
        }

        // 수정 및 확인
        private void toggle_Click(object sender, EventArgs e)
        {            
            if (text.Enabled)
            {
                정산toggle.Text = "계좌이체 수정";
                StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\data\\정산날짜.txt", false);
                String setTime = sr.ReadToEnd();
                String[] timeCount = setTime.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                StreamReader tmpSr = new StreamReader(Environment.CurrentDirectory + "\\data\\정산.txt", false);
                String exTmp = tmpSr.ReadToEnd();
                String[] count = exTmp.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                tmpSr.Close();
               
                String tmp = "";
                String setTimeTmp = "";
                
                // 숫자만 입력됬는지 확인
                String[] line = text.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int breakPoint;
                for (int i = 0; i < line.Length; i++)
                {
                    if(String.IsNullOrWhiteSpace(line[i]))
                    {
                        continue;
                    }
                    if (!int.TryParse(line[i], out breakPoint))
                    {
                        MessageBox.Show("계좌이체는 숫자 혹은 공백으로 입력해주세요.", "에러");
                        return;
                    }
                }
                
                int sum = 0;
                if(String.IsNullOrEmpty(setTime)) // 계좌이체를 처음 입력 받는 경우
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Contains(","))
                        {
                            line[i] = line[i].Replace(",", "");
                        }
                        if (!string.IsNullOrWhiteSpace(line[i]))
                        {
                            sum += Convert.ToInt32(line[i]);
                            if (tmp != "")
                            {
                                tmp = tmp + "\r\n" + line[i];
                                setTimeTmp = setTimeTmp + "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            }
                            else
                            {
                                tmp = line[i];
                                setTimeTmp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            }
                        }
                    }
                }
                else // 계좌이체 이력이 있었던 경우
                {
                    if(exTmp.Equals(text.Text))
                    {
                        text.Enabled = false;
                        return;
                    }
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Contains(","))
                        {
                            line[i] = line[i].Replace(",", "");
                        }
                        if (!string.IsNullOrWhiteSpace(line[i]))
                        {
                            sum += Convert.ToInt32(line[i]);
                            if(i < count.Length && count[i].Equals(line[i]))
                            {
                                if(tmp == "")
                                {
                                    tmp = line[i];
                                    setTimeTmp = timeCount[i];
                                }
                                else
                                {
                                    tmp = tmp + "\r\n" + line[i];
                                    setTimeTmp = setTimeTmp + "\r\n" + timeCount[i];
                                }
                            }
                            else
                            {
                                if (tmp == "")
                                {
                                    tmp = line[i];
                                    setTimeTmp = timeCount[i];
                                }
                                else
                                {
                                    tmp = tmp + "\r\n" + line[i];
                                    setTimeTmp = setTimeTmp + "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                                }
                            }
                        }
                    }
                }

                StreamWriter cal = new StreamWriter(Environment.CurrentDirectory + "\\data\\정산.txt", false);
                StreamWriter calDate = new StreamWriter(Environment.CurrentDirectory + "\\data\\정산날짜.txt", false);
                if (!string.IsNullOrWhiteSpace(tmp))
                {
                    cal.WriteLine(tmp);
                    calDate.WriteLine(setTimeTmp);
                }
                cal.Close();
                total.Text = String.Format("{0: #,##0}원", sum);
                text.Enabled = false;

                date.Text = setTimeTmp;
                calDate.Close();

            }
            else
            {
                StreamReader 정산text = new StreamReader(Environment.CurrentDirectory + "\\data\\정산.txt", false);
                text.Text = 정산text.ReadToEnd();
                정산text.Close();
                StreamReader 날짜text = new StreamReader(Environment.CurrentDirectory + "\\data\\정산날짜.txt", false);
                date.Text = 날짜text.ReadToEnd();
                날짜text.Close();
                정산toggle.Text = "계좌이체 저장";
                text.Enabled = true;
            }            
        }

        private void stackCal(String[] line, String name)
        {
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].Contains(","))
                {
                    line[i] = line[i].Replace(",", "");
                }
                if (!string.IsNullOrWhiteSpace(line[i]))
                {
                    sum += Convert.ToInt32(line[i]);
                }
            }

            if (name.Equals("후불"))
            {
                후불누적.Text = String.Format("{0: #,##0}원", sum);
                후불text.Enabled = false;
            }
            else
            {
                total.Text = String.Format("{0: #,##0}원", sum);
                text.Enabled = false;
            }
        }

        // 정산
        private void check_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(total.Text) && !string.IsNullOrWhiteSpace(t1.Text))
            {
                int 마감금액 = Convert.ToInt32(t1.Text);                
                int 잉여금액;
                int 후불결제 = 0;
                String 후불계산 = 후불누적.Text;
                if(후불누적.Text.Contains(","))
                {
                    후불계산 = 후불계산.Replace(",", "");
                }
                if(후불계산.Contains("원"))
                {
                    후불계산 = 후불계산.Substring(0, 후불계산.Length - 1);
                    후불결제 = Convert.ToInt32(후불계산);
                }                
                if(String.IsNullOrWhiteSpace(t2.Text))
                {
                    t2.Text = "0";
                }
                int.TryParse(t2.Text, out 잉여금액);
                if (마감금액 < 100_000)
                {
                    MessageBox.Show("마감금액은 10만원 이하가 될 수 없습니다.", "에러");
                    return;
                }

                String totalTmp = total.Text;
                if (!totalTmp.Equals("0"))
                {
                    totalTmp = totalTmp.Substring(0, totalTmp.Length - 1);
                }
                if(totalTmp.Contains(","))
                {
                    totalTmp = totalTmp.Replace(",", "");
                }
                int sum = 마감금액 + 후불결제 - Convert.ToInt32(totalTmp) - 100_000;
                if(!string.IsNullOrWhiteSpace(t2.Text))
                {
                    if(t2.Text.Contains("-"))
                    {
                        sum -= Math.Abs(잉여금액);
                    }
                    else
                    {
                        sum += 잉여금액;
                    }
                }
                t3.Text = String.Format("{0: #,##0}원", sum);
                if(sum < 0)
                {
                    MessageBox.Show("돈통 금액이 모자르니 사장님께 보고해주세요.", "보고 요망");
                }
            }
            else
            {
                MessageBox.Show("누적 계좌이체 금액과 마감 금액이 입력됬는지 확인해주세요.", "에러");
            }
        }

        // 초기화
        private void reset_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";

            total.Text = "0";
            후불누적.Text = "0";
            
            text.Text = content;
            date.Text = "";
            text.Enabled = false;
            정산toggle.Text = "계좌이체 수정";

            후불text.Text = content1;
            후불날짜text.Text = "";            
            후불text.Enabled = false;
            후불toggle.Text = "후불결제 수정";

            String path = Environment.CurrentDirectory + "\\data\\정산.txt";
            File.Delete(path);
            File.AppendAllText(path, content, Encoding.UTF8);
            path = Environment.CurrentDirectory + "\\data\\정산날짜.txt";
            File.Delete(path);
            File.Create(path).Close();

            String path1 = Environment.CurrentDirectory + "\\data\\후불.txt";
            File.Delete(path1);
            File.AppendAllText(path1, content1, Encoding.UTF8);
            path1 = Environment.CurrentDirectory + "\\data\\후불날짜.txt";
            File.Delete(path1);
            File.Create(path1).Close();
        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스만 입력
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
            }
        }

        private void OpenClose_Load(object sender, EventArgs e)
        {

        }

        // 후불 결제
        private void button1_Click(object sender, EventArgs e)
        {            
            if (후불text.Enabled)
            {
                후불toggle.Text = "후불결제 수정";
                StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\data\\후불날짜.txt", false);
                String setTime = sr.ReadToEnd();
                String[] timeCount = setTime.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                StreamReader tmpSr = new StreamReader(Environment.CurrentDirectory + "\\data\\후불.txt", false);
                String exTmp = tmpSr.ReadToEnd();
                String[] count = exTmp.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                tmpSr.Close();

                String tmp = "";
                String setTimeTmp = "";

                // 숫자만 입력됬는지 확인
                String[] line = 후불text.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int breakPoint;
                for (int i = 0; i < line.Length; i++)
                {
                    if (String.IsNullOrWhiteSpace(line[i]))
                    {
                        continue;
                    }
                    if (!int.TryParse(line[i], out breakPoint))
                    {
                        MessageBox.Show("후불결제는 숫자 혹은 공백으로 입력해주세요.", "에러");
                        return;
                    }
                }

                int sum = 0;
                if (String.IsNullOrEmpty(setTime)) // 후불결제를 처음 입력 받는 경우
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Contains(","))
                        {
                            line[i] = line[i].Replace(",", "");
                        }
                        if (!string.IsNullOrWhiteSpace(line[i]))
                        {
                            sum += Convert.ToInt32(line[i]);
                            if (tmp != "")
                            {
                                tmp = tmp + "\r\n" + line[i];
                                setTimeTmp = setTimeTmp + "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            }
                            else
                            {
                                tmp = line[i];
                                setTimeTmp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            }
                        }
                    }
                }
                else // 후불결제 이력이 있었던 경우
                {
                    if (exTmp.Equals(text.Text))
                    {
                        후불text.Enabled = false;
                        return;
                    }
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Contains(","))
                        {
                            line[i] = line[i].Replace(",", "");
                        }
                        if (!string.IsNullOrWhiteSpace(line[i]))
                        {
                            sum += Convert.ToInt32(line[i]);
                            if (i < count.Length && count[i].Equals(line[i]))
                            {
                                if (tmp == "")
                                {
                                    tmp = line[i];
                                    setTimeTmp = timeCount[i];
                                }
                                else
                                {
                                    tmp = tmp + "\r\n" + line[i];
                                    setTimeTmp = setTimeTmp + "\r\n" + timeCount[i];
                                }
                            }
                            else
                            {
                                if (tmp == "")
                                {
                                    tmp = line[i];
                                    setTimeTmp = timeCount[i];
                                }
                                else
                                {
                                    tmp = tmp + "\r\n" + line[i];
                                    setTimeTmp = setTimeTmp + "\r\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                                }
                            }
                        }
                    }
                }

                StreamWriter cal = new StreamWriter(Environment.CurrentDirectory + "\\data\\후불.txt", false);
                StreamWriter calDate = new StreamWriter(Environment.CurrentDirectory + "\\data\\후불날짜.txt", false);
                if (!string.IsNullOrWhiteSpace(tmp))
                {
                    cal.WriteLine(tmp);
                    calDate.WriteLine(setTimeTmp);
                }
                cal.Close();
                후불누적.Text = String.Format("{0: #,##0}원", sum);
                후불text.Enabled = false;

                후불날짜text.Text = setTimeTmp;
                calDate.Close();

            }
            else
            {
                StreamReader 후불 = new StreamReader(Environment.CurrentDirectory + "\\data\\후불.txt", false);
                후불text.Text = 후불.ReadToEnd();
                후불.Close();
                StreamReader 날짜text = new StreamReader(Environment.CurrentDirectory + "\\data\\후불날짜.txt", false);
                후불날짜text.Text = 날짜text.ReadToEnd();
                날짜text.Close();
                후불toggle.Text = "후불결제 저장";
                후불text.Enabled = true;
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
