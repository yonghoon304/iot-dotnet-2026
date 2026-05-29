using System.Drawing;
using System.ComponentModel;
using System.Text;

namespace DotNet04ControlApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;    // OS에 설치된 폰트리스트
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }
            TxtResult.Text = "현재 글씨체,fonts";
            PrgStatus.Value = 0;

        }



        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }


        private void Chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }
        // 폰트 글자체,굵게,이탤릭 변경 메서드
        private void ChangeFontStyle()
        {
            if (CboFonts.SelectedIndex < 0)
            {
                return; // 아무것도 선택안됨
            }
            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked)
            {
                style = FontStyle.Bold;
            }
            if (Chkitalic.Checked)
            {
                style = FontStyle.Italic;   // 이탤릭체 변경
            }
            TxtResult.Font = new Font(CboFonts.SelectedItem as string, 10, style);
        }
        // 모달버튼 클릭이벤트핸들러
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Frmsub frmSub = new Frmsub();
            frmSub.Text = "모달창";
            frmSub.BackColor = Color.Orange;
            frmSub.ShowDialog();

        }
        // 모달리스버튼 클릭이벤트핸들러
        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Frmsub frmSub = new Frmsub();
            frmSub.BackColor = Color.Yellow;
            frmSub.Text = "모달리스창";
            frmSub.Location = new Point(this.Location.X + (this.Width - frmSub.Width) / 2,
                                        this.Location.Y + (this.Height - frmSub.Height) / 2);
            frmSub.Show(this);  // this -> FrmMain

        }

        private void BtnMsgbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtResult.Text, "메세지박스", MessageBoxButtons.OK);
        }

        private void BtnDialog_Click(object sender, EventArgs e)
        {
            // DlgOpenFile.ShowDialog(this); 일반오픈
            if (DlgOpenFile.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show($"선택한 파일은 {DlgOpenFile.FileName}입니다.");
            }
        }

        private void TrkStatus_Scroll(object sender, EventArgs e)
        {
            PrgStatus.Value = TrkStatus.Value;
        }

        private void TreeToList()
        {
            LvwDummy.Items.Clear();
            foreach (TreeNode node in TvwDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            LvwDummy.Items.Add(
                new ListViewItem(
                    new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);    // 재귀호출
            }
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            var random = new Random();
            TvwDummy.Nodes.Add(random.Next().ToString());
        }

        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            if (TvwDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 메서드 탈출
            }

            var random = new Random();
            TreeNode childNode = new TreeNode(random.Next().ToString());
            childNode.ImageIndex = 1;
            TvwDummy.SelectedNode.Nodes.Add(childNode);
            TvwDummy.ExpandAll(); // 하위노드 전부 확장
        }

        private void BtnLoadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "이미지 열기";
            dlg.Filter = "Image Files(*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(dlg.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PicImage_Click(object sender, EventArgs e)
        {
            if (PicImage.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            WrkProcess.CancelAsync();    // Async 비동기 처리
        }

        private void BtnNoThread_Click(object sender, EventArgs e)
        {
            var maximum = 100;
            var minimum = 0;
            var currValue = 0;
            TxtLog.Clear();
            PrgProcess.Minimum = minimum;
            PrgProcess.Maximum = maximum;
            PrgProcess.Value = 0;

            BtnThread.Enabled = false;
            BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            // 프로세스 진행 더미로 실행
            for (int i = 0; i < maximum; i++)
            {
                // 내부적으로 복잡하고 시간이 많이 소요되는 작업
                currValue = i;
                PrgProcess.Value = currValue;
                TxtLog.AppendText($"진행사항 : {currValue}\r\n");
                Thread.Sleep(100);  // 실제로는 업무 로직이 들어감

            }
            BtnNoThread.Enabled = BtnThread.Enabled = true;
            BtnStop.Enabled = false;

        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            var maximum = 100;
            var minimum = 0;
            var currValue = 0;
            TxtLog.Clear();
            PrgProcess.Minimum = minimum;
            PrgProcess.Maximum = maximum;
            PrgProcess.Value = 0;

            BtnThread.Enabled = false;
            BtnNoThread.Enabled = false;
            BtnStop.Enabled = true;

            WrkProcess.WorkerReportsProgress = true;
            WrkProcess.WorkerSupportsCancellation = true;
            WrkProcess.RunWorkerAsync(null);
        }

        #region '백그라운드워커 이벤트핸들러'
        // 1. 백그라운드워커 첫 시작점
        private void WrkProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            var maximum = 100;
            var currValue = 0.0;

            for (int i = 0; i < maximum; i++)
            {
                if (WrkProcess.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    currValue = i;
                    Thread.Sleep(100);
                    // 진행사항은 ProgressChanged 이벤트핸들러에 작성
                    WrkProcess.ReportProgress((int)((currValue / maximum) * 100));
                }
            }
        }
        // 2. 프로세스 변경사항 UI로 전달
        private void WrkProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // UI 스레드에 넘길값들만 실행!
            PrgProcess.Value = e.ProgressPercentage;
            TxtLog.AppendText($"진행률 : {PrgProcess.Value}\r\n");
        }
        // 3. 프로세스가 끝난 뒤 처리
        private void WrkProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                TxtLog.AppendText("작업 취소\n");
            }
            else
            {
                TxtLog.AppendText("작업 완료\n");
            }

            BtnNoThread.Enabled = BtnThread.Enabled = true;
            BtnStop.Enabled = false;


        }
        #endregion

        private void BtnFileLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "Text files(*.txt;*.cs;*.py;*.sql)|*.txt;*.cs;*.py;*.sql";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                RtbEditor.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);

                string fileContent = File.ReadAllText(dlg.FileName, Encoding.UTF8);
            }
        }

        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RichText file(*.rtf)|*.rtf";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                RtbEditor.SaveFile(dlg.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }
    }
}
