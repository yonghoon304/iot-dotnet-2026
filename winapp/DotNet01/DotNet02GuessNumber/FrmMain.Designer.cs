namespace DotNet02GuessNumber
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            LblDisplay = new Label();
            TxtGuess = new TextBox();
            button1 = new Button();
            BtnStart = new Button();
            SuspendLayout();
            // 
            // LblDisplay
            // 
            LblDisplay.Dock = DockStyle.Top;
            LblDisplay.Font = new Font("나눔고딕코딩", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDisplay.Location = new Point(0, 0);
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(449, 25);
            LblDisplay.TabIndex = 0;
            LblDisplay.Text = "게임을 시작합니다";
            LblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtGuess
            // 
            TxtGuess.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtGuess.Location = new Point(44, 81);
            TxtGuess.Name = "TxtGuess";
            TxtGuess.Size = new Size(213, 29);
            TxtGuess.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(304, 81);
            button1.Name = "button1";
            button1.Size = new Size(88, 29);
            button1.TabIndex = 2;
            button1.Text = "맞히기";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            BtnStart.Dock = DockStyle.Bottom;
            BtnStart.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnStart.Location = new Point(0, 156);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(449, 89);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "게임시작";
            BtnStart.UseVisualStyleBackColor = true;
         
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 245);
            Controls.Add(BtnStart);
            Controls.Add(button1);
            Controls.Add(TxtGuess);
            Controls.Add(LblDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "숫자맞히기";
            Load += this.FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDisplay;
        private TextBox TxtGuess;
        private Button button1;
        private Button BtnStart;
    }
}
