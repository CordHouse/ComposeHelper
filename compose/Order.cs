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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();

            if (!File.Exists(Environment.CurrentDirectory + "\\data\\근무자목록.txt"))
            {
                File.Create(Environment.CurrentDirectory + "\\data\\근무자목록.txt").Close();
            }
            근무자설정();

            getExcelData();
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
                    작성자.Items.Add(근무자[i]);
                }
                작성자.Sorted = true;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void 구매요청_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(품명.Text))
            {
                MessageBox.Show("품명을 작성해주세요.", "에러");
                return;
            }
            else if(String.IsNullOrWhiteSpace(작성자.Text))
            {
                MessageBox.Show("작성자를 선택해주세요.", "에러");
                return;
            }
            CustomSheet customSheet = new CustomSheet();
            String title = "발주관리";
            List<object> oblist;
            // 배당된 근무지가 없다면 생성
            if (customSheet.getSheetId(title) == -1)
            {
                MessageBox.Show("발주표를 생성 중입니다.\r\n발주표가 할당되면 기록을 시작할 수 있습니다.", "성공");
                customSheet.createSheet(title); // 시트 생성    
                customSheet.sheetWidth(title);
                customSheet.UpdateCellsAndStyle(title);
                oblist = new List<object>() {
                    "날짜", "발주 품목", "작성자", "비고", "주문여부"                        
                    };
                customSheet.insertRowsData(title + "!A1", ref oblist);
                MessageBox.Show("발주표가 생성되었습니다.", "성공");
            }
            
            IList<IList<object>> getData = customSheet.GetColumnValues(title + "!B2:B");
            foreach (var row in getData)
            {
                if (row.Contains(품명.Text))
                {
                    MessageBox.Show("이미 발주처리가 되어있습니다.", "에러");
                    return;
                }
            }
            oblist = new List<object>()
            {
                DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                품명.Text,
                작성자.Text,
                비고.Text
            };
            customSheet.insertRowsData(title + "!A2", ref oblist);
            MessageBox.Show("발주가 정상처리 되었습니다.", "성공");
            getExcelData();
        }

        private void getExcelData()
        {
            조회.Text = "";
            조회.Font = new Font(FontFamily.GenericMonospace, 조회.Font.Size);
            CustomSheet customSheet = new CustomSheet();
            IList<IList<object>> getData = customSheet.GetColumnValues("발주관리!A3:E");
            foreach (var row in getData)
            {
                String sum = "";
                foreach (var sell in row)
                {
                    sum += Convert.ToString(sell) + " ";
                }
                조회.AppendText(sum + "\r\n\r\n");
            }
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 모든 입력차단           
            e.Handled = true;
        }
    }    
}
