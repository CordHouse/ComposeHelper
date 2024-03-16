using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace compose
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
            형태.SelectedIndex = 0;
            출근시간.SelectedIndex = 0;
            출근분.SelectedIndex = 0;
            퇴근시간.SelectedIndex = 0;
            퇴근분.SelectedIndex = 0;
            if (!File.Exists(Environment.CurrentDirectory + "\\data\\근무자목록.txt"))
            {
                File.Create(Environment.CurrentDirectory + "\\data\\근무자목록.txt").Close();
            }
            근무자설정();
        }

        private void 근무자설정()
        {
            StreamReader 근무자목록 = new StreamReader(Environment.CurrentDirectory + "\\data\\근무자목록.txt", false);
            String s = 근무자목록.ReadToEnd();
            근무자목록.Close();
            if (!String.IsNullOrEmpty(s))
            {
                String[] 근무자 = s.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < 근무자.Length; i++)
                {
                    근무자box.Items.Add(근무자[i]);
                }
                근무자box.Sorted = true;
            }
        }

        private void Check_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void 출근시간_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 출근기록_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(근무자box.Text))
            {
                CustomSheet customSheet = new CustomSheet();
                String title = DateTime.Now.ToString("MMMM") + 근무자box.Text;
                List<object> oblist;        
                // 배당된 근무지가 없다면 생성
                if (customSheet.getSheetId(title) == -1)
                {
                    MessageBox.Show("근무지를 생성 중입니다.\r\n근무지가 할당되면 기록을 시작할 수 있습니다.", "성공");
                    customSheet.createSheet(title); // 시트 생성    
                    customSheet.UpdateCellsAndStyle(title);
                    oblist = new List<object>() { 
                        DateTime.Now.ToString("yyyy") + "년" + DateTime.Now.ToString("MM") + "월 근무지" 
                    };
                    customSheet.insertRowsData(title + "!A1", ref oblist);
                    oblist = new List<object>() { "근무자 : " + title };
                    customSheet.insertRowsData(title + "!A2", ref oblist);
                    customSheet.MergeCells(title, 0, 1, 0, 5); // 셀 범위 병합
                    customSheet.MergeCells(title, 1, 2, 0, 5); // 셀 범위 병함                    
                    oblist = new List<object>() { "날짜", "요일", "근무시간", "누적시간", "비고" };
                    customSheet.insertRowsData(title + "!A3", ref oblist);
                    MessageBox.Show("근무지가 할당되었습니다.", "성공");
                }

                // 하루 한 번 만 출근처리 가능
                IList<IList<object>> getData = customSheet.GetColumnValues(title + "!A3:A");
                foreach (var row in getData)
                {
                    if (row.Contains(DateTime.Now.ToString("yyyy-MM-dd")))
                    {
                        MessageBox.Show("이미 출근처리가 되었습니다.", "에러");
                        return;
                    }
                }

                // 기록 작성
                근무기록(customSheet, title, "!A3");
                customSheet.sortSheet(title, getData[0].Count);
                MessageBox.Show("근무가 정상적으로 기록되었습니다.", "성공");
            }
            else
            {
                MessageBox.Show("근무자를 선택해주세요.", "에러");
            }
        }

        private void 근무기록(CustomSheet customSheet, string title, string range)
        {
            string 출근sub = 출근시간.Text.Substring(0, 2);
            string 출근분sub = 출근분.Text.Substring(0, 2);
            string 퇴근sub = 퇴근시간.Text.Substring(0, 2);
            string 퇴근분sub = 퇴근분.Text.Substring(0, 2);
            int start = Convert.ToInt32(출근sub + 출근분sub);
            int end = Convert.ToInt32(퇴근sub + 퇴근분sub);
            double 시간차 = Convert.ToDouble(퇴근sub) - Convert.ToDouble(출근sub);
            double 분차 = Math.Round((Convert.ToDouble(퇴근분sub) - Convert.ToDouble(출근분sub)) / 60, 1);
            String 요일 = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(DateTime.Now.DayOfWeek);

            if (근무자box.Text.Contains("주말 ") && "월화수목금".Contains(요일) && 형태.Text.Equals("기존"))
            {
                MessageBox.Show("주말 근무자는 대타가 아니면 평일 근무를 기록할 수 없습니다.", "에러");
                return;
            }
            else if (근무자box.Text.Contains("평일 ") && "토일".Contains(요일) && 형태.Text.Equals("기존"))
            {
                MessageBox.Show("평일 근무자는 대타가 아니면 주말 근무를 기록할 수 없습니다.", "에러");
                return;
            }
            if (end - start > 0)
            {
                DialogResult dr = MessageBox.Show("근무시간을 기록하시겠습니까?", "근무시간 기록", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    List<object>  oblist = new List<object>() {
                            DateTime.Now.ToString("yyyy-MM-dd"),
                            DateTime.Now.ToString("ddd"),
                            출근sub + " : " + 출근분sub +
                            " ~ " +
                            퇴근sub + " : " + 퇴근분sub,
                            Convert.ToString(시간차 + 분차),
                            textBox1.Text
                        };
                    customSheet.insertRowsData(title + range, ref oblist);
                }
            }
            else
            {
                MessageBox.Show("출근시간은 퇴근시간보다 작아야합니다.", "에러");
            }
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(이름.Text) && !String.IsNullOrWhiteSpace(근무타임.Text))
            {;
                if (근무자box.Items.Contains(근무타임.Text + " - " + 이름.Text))
                {
                    DialogResult dr = MessageBox.Show("근무자를 삭제하시겠습니까?", "근무자 삭제", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        StreamReader 근무자목록 = new StreamReader(Environment.CurrentDirectory + "\\data\\근무자목록.txt", false);
                        String[] s = 근무자목록.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        근무자목록.Close();
                        String sum = "";
                        for(int i = 0; i < s.Length; i++)
                        {
                            if(s[i].Equals(근무타임.Text + " - " + 이름.Text))
                            {
                                continue;
                            }
                            sum += s[i] + "\r\n";
                        }
                        
                        근무자box.Items.Remove(근무타임.Text + " - " + 이름.Text);
                        StreamWriter 근무자입력 = new StreamWriter(Environment.CurrentDirectory + "\\data\\근무자목록.txt", false);
                        근무자입력.WriteLine(sum.Trim());
                        근무자입력.Close();
                        근무자box.Sorted = true;
                    }
                }
                else
                {
                    MessageBox.Show("존재하지 않는 근무자입니다.", "에러");
                }
            }
            else
            {
                MessageBox.Show("이름 혹은 근무타임이 누락되어 삭제할 수 없습니다.", "에러");
            }
        }

        private void 근무자등록_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(이름.Text) && !String.IsNullOrWhiteSpace(근무타임.Text))
            {
                if (!근무자box.Items.Contains(근무타임.Text + " - " + 이름.Text))
                {
                    DialogResult dr = MessageBox.Show("근무자를 등록하시겠습니까?", "근무자 등록", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        근무자box.Items.Add(근무타임.Text + " - " + 이름.Text);
                        근무자box.Sorted = true;
                        StreamWriter 근무자입력 = new StreamWriter(Environment.CurrentDirectory + "\\data\\근무자목록.txt", true);
                        근무자입력.WriteLine(근무타임.Text + " - " + 이름.Text);
                        근무자입력.Close();
                    }
                }
                else
                {
                    MessageBox.Show("이미 등록된 근무자입니다.", "에러");
                }
            }
            else
            {
                MessageBox.Show("이름 혹은 근무타임이 누락되어 등록할 수 없습니다.", "에러");
            }
        }

        private void 누락등록_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(근무자box.Text))
            {
                CustomSheet customSheet = new CustomSheet();
                String title = DateTime.Now.ToString("MMMM") + 근무자box.Text;
                List<object> oblist;
                // 배당된 근무지가 없다면 생성
                if (customSheet.getSheetId(title) == -1)
                {
                    MessageBox.Show("근무지를 생성 중입니다.\r\n근무지가 할당되면 기록을 시작할 수 있습니다.", "성공");
                    customSheet.createSheet(title); // 시트 생성    
                    customSheet.UpdateCellsAndStyle(title);
                    oblist = new List<object>() {
                        DateTime.Now.ToString("yyyy") + "년" + DateTime.Now.ToString("MM") + "월 근무지"
                    };
                    customSheet.insertRowsData(title + "!A1", ref oblist);
                    oblist = new List<object>() { "근무자 : " + title };
                    customSheet.insertRowsData(title + "!A2", ref oblist);
                    customSheet.MergeCells(title, 0, 1, 0, 5); // 셀 범위 병합
                    customSheet.MergeCells(title, 1, 2, 0, 5); // 셀 범위 병함                    
                    oblist = new List<object>() { "날짜", "요일", "근무시간", "누적시간", "비고" };
                    customSheet.insertRowsData(title + "!A3", ref oblist);
                    MessageBox.Show("근무지가 할당되었습니다.", "성공");
                }

                String year = DateTime.Now.ToString("yyyy");
                String month = DateTime.Now.ToString("MM");
                String[] 일 = 누락기록.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Distinct().ToArray();
                String 요일;

                // 데이터를 담을 List 초기화
                List<IList<object>> dataList = new List<IList<object>>();

                // 하루 한 번 만 출근처리 가능
                IList<IList<object>> getData = customSheet.GetColumnValues(title + "!A3:A");
                string day;
                foreach (var date in 일)
                {
                    if(String.IsNullOrWhiteSpace(date))
                    {
                        continue;
                    }
                    if (Convert.ToInt32(date) <= 0 || Convert.ToInt32(date) > 31)
                    {
                        MessageBox.Show("입력 날짜가 올바르지 않습니다.\r\n" + date, "에러");
                        continue;
                    }
                    if (date.Length == 1)
                    {
                        day = "0" + date;                        
                    }
                    else
                    {
                        day = date;
                    }
                    String 기록일 = year + "-" + month + "-" + day;
                    요일 = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(
                        new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)).DayOfWeek
                        );
                    Boolean 같은날짜확인 = false;
                    if(근무자box.Text.Contains("주말 ") && "월화수목금".Contains(요일) && 형태.Text.Equals("기존"))
                    {
                        MessageBox.Show("주말 근무자는 대타가 아니면 평일 근무를 기록할 수 없습니다.\r\n" + 기록일 + " " + 요일, "에러");
                        continue;
                    }
                    else if (근무자box.Text.Contains("평일 ") && "토일".Contains(요일) && 형태.Text.Equals("기존"))
                    {
                        MessageBox.Show("평일 근무자는 대타가 아니면 주말 근무를 기록할 수 없습니다.\r\n" + 기록일 + " " + 요일, "에러");
                        continue;
                    }
                    foreach (var row in getData)
                    {
                        // 같은 기록이 있거나, 현재 날짜보다 많은 경우 기록 제외
                        if (row.Contains(기록일) || Convert.ToInt32(day) > Convert.ToInt32(DateTime.Now.ToString("dd")))
                        {
                            같은날짜확인 = true;
                            break;
                        }                        
                    }
                    if (!같은날짜확인)
                    {
                        string 출근sub = 출근시간.Text.Substring(0, 2);
                        string 출근분sub = 출근분.Text.Substring(0, 2);
                        string 퇴근sub = 퇴근시간.Text.Substring(0, 2);
                        string 퇴근분sub = 퇴근분.Text.Substring(0, 2);
                        int start = Convert.ToInt32(출근sub + 출근분sub);
                        int end = Convert.ToInt32(퇴근sub + 퇴근분sub);
                        double 시간차 = Convert.ToDouble(퇴근sub) - Convert.ToDouble(출근sub);
                        double 분차 = Math.Round((Convert.ToDouble(퇴근분sub) - Convert.ToDouble(출근분sub)) / 60, 1);

                        String 근무시간 = 출근sub + " : " + 출근분sub +
                            " ~ " + 퇴근sub + " : " + 퇴근분sub;
                        String 누적시간 = Convert.ToString(시간차 + 분차);                        
                        String 비고 = textBox1.Text;
                        if((근무자box.Text.Contains("주말 ") && "월화수목금".Contains(요일) && 형태.Text.Equals("대타"))
                            || (근무자box.Text.Contains("평일 ") && "토일".Contains(요일) && 형태.Text.Equals("대타"))
                            && String.IsNullOrWhiteSpace(비고))
                        {
                            비고 = 형태.Text;
                        }
                        if (end - start > 0)
                        {
                            dataList.Add(new List<object>() { 기록일, 요일, 근무시간, 누적시간, 비고 });
                        }
                        else
                        {
                            MessageBox.Show("해당 날짜는 근무시간이 올바르지 않습니다.\r\n" + 기록일, "에러");
                        }
                    }
                }
                if (dataList.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("근무시간을 기록하시겠습니까?", "근무시간 기록", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        // 기록 작성
                        customSheet.insertRowsData(title + "!A3", ref dataList);
                        customSheet.sortSheet(title, getData[0].Count);
                        MessageBox.Show("근무누락 기록완료", "완료");
                    }
                }
                else
                {
                    MessageBox.Show("아래내용을 확인해주세요.\r\n\r\n" +
                        "1. 누락 일 입력이 없습니다.\r\n" +
                        "2. 모두 기록 되어있는 날짜입니다.\r\n" +
                        "3. 미래의 날짜는 출근처리할 수 없습니다.", "확인요망");
                }
            }
            else
            {
                MessageBox.Show("근무자를 선택해주세요.", "에러");
            }
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스만 입력
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Enter)))
            {
                e.Handled = true;
            }
        }

        // 수정
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(근무자box.Text))
            {                
                CustomSheet customSheet = new CustomSheet();
                String title = DateTime.Now.ToString("MMMM") + 근무자box.Text;
                // 배당된 근무지가 없다면 실패
                if (customSheet.getSheetId(title) == -1)
                {                    
                    MessageBox.Show("근무지가 존재하지 않아 수정할 수 없습니다.", "에러");
                    return;
                }

                String year = DateTime.Now.ToString("yyyy");
                String month = DateTime.Now.ToString("MM");
                String[] 일 = 수정기록.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Distinct().ToArray();
                String 요일;

                // 데이터를 담을 List 초기화
                List<IList<object>> dataList = new List<IList<object>>();

                // 하루 한 번 만 출근처리 가능
                IList<IList<object>> getData = customSheet.GetColumnValues(title + "!A3:A");
                string day;
                foreach (var date in 일)
                {
                    if (String.IsNullOrWhiteSpace(date))
                    {
                        continue;
                    }
                    if (Convert.ToInt32(date) <= 0 || Convert.ToInt32(date) > 31)
                    {
                        MessageBox.Show("입력 날짜가 올바르지 않습니다.\r\n" + date, "에러");
                        continue;
                    }
                    if (date.Length == 1)
                    {
                        day = "0" + date;
                    }
                    else
                    {
                        day = date;
                    }
                    String 기록일 = year + "-" + month + "-" + day;
                    요일 = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(
                        new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)).DayOfWeek
                        );
                    
                    for (int i = 1; i < getData.Count; i++)
                    {                            
                        if (getData[i][0].Equals(기록일))
                        {
                            DialogResult dr = MessageBox.Show(기록일 + "\r\n근무시간을 수정하시겠습니까?", "근무시간 수정", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {          
                                string 출근sub = 출근시간.Text.Substring(0, 2);
                                string 출근분sub = 출근분.Text.Substring(0, 2);
                                string 퇴근sub = 퇴근시간.Text.Substring(0, 2);
                                string 퇴근분sub = 퇴근분.Text.Substring(0, 2);
                                int start = Convert.ToInt32(출근sub + 출근분sub);
                                int end = Convert.ToInt32(퇴근sub + 퇴근분sub);
                                double 시간차 = Convert.ToDouble(퇴근sub) - Convert.ToDouble(출근sub);
                                double 분차 = Math.Round((Convert.ToDouble(퇴근분sub) - Convert.ToDouble(출근분sub)) / 60, 1);

                                String 근무시간 = 출근sub + " : " + 출근분sub +
                                    " ~ " + 퇴근sub + " : " + 퇴근분sub;
                                String 누적시간 = Convert.ToString(시간차 + 분차);
                                String 비고 = textBox1.Text;
                                if ((근무자box.Text.Contains("주말 ") && "월화수목금".Contains(요일) && 형태.Text.Equals("대타"))
                                    || (근무자box.Text.Contains("평일 ") && "토일".Contains(요일) && 형태.Text.Equals("대타"))
                                    && String.IsNullOrWhiteSpace(비고))
                                {
                                    비고 = 형태.Text;
                                }
                                if (end - start > 0)
                                {
                                    // 수정여부 확인
                                    customSheet.deleteRow(title, i + 2);
                                    dataList.Add(new List<object>() { 기록일, 요일, 근무시간, 누적시간, 비고 });
                                }
                                else
                                {
                                    MessageBox.Show("해당 날짜는 근무시간이 올바르지 않습니다.\r\n" + 기록일, "에러");
                                }
                            }
                            break;
                        }
                    }                        
                }
                
                if (dataList.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("근무시간을 수정하시겠습니까?", "근무시간 수정", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        // 기록 작성
                        customSheet.insertRowsData(title + "!A3", ref dataList);
                        customSheet.sortSheet(title, getData[0].Count);
                        MessageBox.Show("근무기록 수정완료", "완료");
                    }
                }
                else if(string.IsNullOrWhiteSpace(수정기록.Text))
                {
                    MessageBox.Show("아래내용을 확인해주세요.\r\n\r\n" +
                        "1. 수정 일 입력이 없습니다.\r\n", "확인요망");
                }
            }
            else
            {
                MessageBox.Show("근무자를 선택해주세요.", "에러");
            }
        }
    }
}
