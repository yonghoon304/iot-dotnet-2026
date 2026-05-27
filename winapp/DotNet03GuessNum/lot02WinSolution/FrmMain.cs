namespace lot02WinSolution
{
    public partial class FrmMain : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 30 + 1);
            chance = 10;
            LblDisplay.Text = "맞힐 숫자를 입력하세요";
            MessageBox.Show("게임을 시작하지", "게임시작", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inputNum = int Parse(TxtNum.Text);
            if (inputNum == findNumber)
            {
                LblDisplay.Text = "맞히셨습니다.";
                MessageBox.Show("축하드립니다", "게임종료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                chance--;

                string strVal;
                if (inputNum > findNumber)
                {
                    strVal = "큼";
                }
                else
                {
                    strVal = "작음";
                }
                LblDisplay.Text = $"기회가 {chance}번, 찾는 수보다 {strVal}";
            }
            if (chance <= 0)
            {
                LblDisplay.Text = "실패했습니다.";
                MessageBox.Show("실패했습니다", "게임종료", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
