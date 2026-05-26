namespace WinSolution
{
    // partial 
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 실행할 코드
        }

        private void BtnPress_Click(object sender, EventArgs e)
        {
            LblResult.Text = "결과 : 컴퓨터 터짐!";
            MessageBox.Show("버튼 클릭","테스트",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }
}
