using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        string filename = "";

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자에게 열 파일 을 선택 하게 함
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();
            

            //1-1 선택한 파일명을 변수에 저장
            filename = openFileDialog1.FileName;

            //2. 파일의 내용을 읽는다.
            string Data = System.IO.File.ReadAllText(filename);

            //3. 화면에 표시 한다.
            tbContents.Text = Data;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //그렇지 않으면 다른이름으로 저장과 동일
            if( filename == "")
            {
                //1. 사용자 에게 저장할 파일을 선택 하게 함
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                

                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);

                //3. 파일명을 기억
                filename = saveFileDialog1.FileName;
            }
            else
            {
                //해당 파일명으로 현재 내용을 저장

                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(filename, tbContents.Text);
            }

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자 에게 저장할 파일을 선택 하게 함
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();
            
            //2. 파일을 저장 한다.            
            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            this.Close();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tbContents.WordWrap = !tbContents.WordWrap;
           
        } 

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;            
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }


        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = pd;
            printDialog1.ShowDialog();

        }

        private void tbContents_TextChanged(object sender, EventArgs e)
        {

            실행취소UToolStripMenuItem.Enabled = true;
            잘라내기TToolStripMenuItem.Enabled = true;
            복사CToolStripMenuItem.Enabled = true;
            삭제DToolStripMenuItem.Enabled = true;
            찾기FToolStripMenuItem.Enabled = true;
            다음찾기NToolStripMenuItem.Enabled = true;
            이동GToolStripMenuItem.Enabled = true;
        }

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tbContents.CanUndo)
            {
                this.tbContents.Undo();
            }
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbContents.SelectedText);
            tbContents.SelectedText = String.Empty;
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbContents.SelectedText);
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)){
                this.tbContents.SelectedText = Clipboard.GetDataObject().GetData(DataFormats.Text, true).ToString();
            }
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbContents.SelectedText = String.Empty;
        }
        
        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 find = new Form2();
            find.Show();
        }
        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            찾기FToolStripMenuItem_Click(null, null);
        }

        private void 이동GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 move = new Form3();
            move.Show();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbContents.SelectAll();
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbContents.SelectedText=String.Format("{0} {1}", DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
        }

        private void 배경색ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            tbContents.BackColor = colorDialog1.Color;
        }

        private void 글ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            tbContents.ForeColor = colorDialog2.Color;
        }
    }
}
