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
    public partial class Form3 : Form
    {
        private int line;
        private int current;

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(int lineLength, int currentLine)
        {
            this.line = lineLength;
            this.current = currentLine;
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int maxLine = Convert.ToInt32(this.lineNum.Text);

            if (maxLine > this.line)
            {
                MessageBox.Show("줄 번호가 범위를 초과 하였습니다.", "메모장"
                        , MessageBoxButtons.OK);
                return;
            }
            else if (maxLine < 1)
            {
                MessageBox.Show("줄 번호가 범위를 벗어났습니다.\n 다시 입력해주세요", "메모장"
                        , MessageBoxButtons.OK);
                return;
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lineNum.Text = this.current.ToString();
        }
    }
}
