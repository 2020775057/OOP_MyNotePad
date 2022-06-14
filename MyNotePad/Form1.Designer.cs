namespace MyNotePad
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.찾기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.글자색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.인쇄ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.저장ToolStripMenuItem.Text = "저장(&S)";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.인쇄ToolStripMenuItem.Text = "인쇄(P)";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.끝내기ToolStripMenuItem.Text = "끝내기(X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator1,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭제DToolStripMenuItem,
            this.toolStripSeparator2,
            this.찾기FToolStripMenuItem,
            this.다음찾기NToolStripMenuItem,
            this.이동GToolStripMenuItem,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.편집ToolStripMenuItem.Text = "편집";
            this.편집ToolStripMenuItem.Click += new System.EventHandler(this.편집ToolStripMenuItem_Click);
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.실행취소UToolStripMenuItem.Text = "실행취소(&U)";
            this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.실행취소UToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)";
            this.잘라내기TToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TToolStripMenuItem_Click);
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.복사CToolStripMenuItem.Text = "복사(&C)";
            this.복사CToolStripMenuItem.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기(&P)";
            this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기ToolStripMenuItem_Click);
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.삭제DToolStripMenuItem.Text = "삭제(&L)";
            this.삭제DToolStripMenuItem.Click += new System.EventHandler(this.삭제DToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // 찾기FToolStripMenuItem
            // 
            this.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
            this.찾기FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.찾기FToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.찾기FToolStripMenuItem.Text = "찾기(F)";
            this.찾기FToolStripMenuItem.Click += new System.EventHandler(this.찾기FToolStripMenuItem_Click);
            // 
            // 다음찾기NToolStripMenuItem
            // 
            this.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
            this.다음찾기NToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.다음찾기NToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.다음찾기NToolStripMenuItem.Text = "다음찾기(&N)";
            this.다음찾기NToolStripMenuItem.Click += new System.EventHandler(this.다음찾기NToolStripMenuItem_Click);
            // 
            // 이동GToolStripMenuItem
            // 
            this.이동GToolStripMenuItem.Name = "이동GToolStripMenuItem";
            this.이동GToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.이동GToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.이동GToolStripMenuItem.Text = "이동(&G)";
            this.이동GToolStripMenuItem.Click += new System.EventHandler(this.이동GToolStripMenuItem_Click);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.모두선택AToolStripMenuItem.Text = "모두선택(&A)";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(&D)";
            this.시간날짜DToolStripMenuItem.Click += new System.EventHandler(this.시간날짜DToolStripMenuItem_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼴ToolStripMenuItem,
            this.색ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄바꿈";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.글꼴ToolStripMenuItem.Text = "글꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상태표시줄ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Checked = true;
            this.상태표시줄ToolStripMenuItem.CheckOnClick = true;
            this.상태표시줄ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            this.상태표시줄ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.상태표시줄ToolStripMenuItem.Text = "상태 표시줄";
            this.상태표시줄ToolStripMenuItem.Click += new System.EventHandler(this.상태표시줄ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메모장정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 메모장정보ToolStripMenuItem
            // 
            this.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            this.메모장정보ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.메모장정보ToolStripMenuItem.Text = "메모장 정보";
            this.메모장정보ToolStripMenuItem.Click += new System.EventHandler(this.메모장정보ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tbContents
            // 
            this.tbContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContents.Location = new System.Drawing.Point(0, 27);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContents.Size = new System.Drawing.Size(466, 391);
            this.tbContents.TabIndex = 2;
            this.tbContents.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // 색ToolStripMenuItem
            // 
            this.색ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배경색ToolStripMenuItem1,
            this.글자색ToolStripMenuItem});
            this.색ToolStripMenuItem.Name = "색ToolStripMenuItem";
            this.색ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.색ToolStripMenuItem.Text = "색";
            // 
            // 배경색ToolStripMenuItem1
            // 
            this.배경색ToolStripMenuItem1.Name = "배경색ToolStripMenuItem1";
            this.배경색ToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.배경색ToolStripMenuItem1.Text = "배경색";
            this.배경색ToolStripMenuItem1.Click += new System.EventHandler(this.배경색ToolStripMenuItem1_Click);
            // 
            // 글자색ToolStripMenuItem
            // 
            this.글자색ToolStripMenuItem.Name = "글자색ToolStripMenuItem";
            this.글자색ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.글자색ToolStripMenuItem.Text = "글자 색";
            this.글자색ToolStripMenuItem.Click += new System.EventHandler(this.글ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 440);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "간단한 메모장";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기FToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동GToolStripMenuItem;
        public System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 글자색ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

