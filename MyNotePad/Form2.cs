using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 memo = null;

        public Form2(Form1 objForm1)
        {
            memo = objForm1;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            this.btnFind.Enabled = true;
        }

        private void bfind_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(this.TextFind.Text + "을(를) 찾을 수 없습니다",
                    "메모장",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool FindText()
        {
            int nFind, len;
            string strText, strFind;

            if (uplow.Checked)
            {
                strText = memo.tbContents.Text; //찾을 대상
                strFind = TextFind.Text; //찾을 단어
            }
            else
            {
                strText = memo.tbContents.Text.ToLower();
                strFind = TextFind.Text.ToLower();
            }

            len = TextFind.Text.Length; //텍스트 길이

            //검색
            if (rup.Checked) //위로
            {
                if ((memo.tbContents.SelectionStart - memo.tbContents.SelectionLength) < 0)
                    nFind = -1;
                else
                    nFind = strText.LastIndexOf(strFind, memo.tbContents.SelectionStart - memo.tbContents.SelectionLength);
            }
            else // 아래로
            {
                nFind = strText.IndexOf(strFind, memo.tbContents.SelectionStart + memo.tbContents.SelectionLength);

            }

            if (nFind == -1)
                return false;
            else
            {
                memo.tbContents.SelectionStart = nFind;
                memo.tbContents.SelectionLength = len;
                memo.tbContents.Focus();
                return true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
