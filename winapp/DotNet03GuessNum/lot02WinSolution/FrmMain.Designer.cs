namespace lot02WinSolution
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
            button1 = new Button();
            LblDisplay = new Label();
            button2 = new Button();
            TxtNum = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 427);
            button1.Name = "button1";
            button1.Size = new Size(800, 23);
            button1.TabIndex = 0;
            button1.Text = "게임시작";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = true;
            LblDisplay.Location = new Point(315, 48);
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(31, 15);
            LblDisplay.TabIndex = 1;
            LblDisplay.Text = "게임";
            // 
            // button2
            // 
            button2.Location = new Point(516, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "확인";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtNum
            // 
            TxtNum.Location = new Point(270, 128);
            TxtNum.Name = "TxtNum";
            TxtNum.Size = new Size(100, 23);
            TxtNum.TabIndex = 3;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNum);
            Controls.Add(button2);
            Controls.Add(LblDisplay);
            Controls.Add(button1);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LblDisplay;
        private Button button2;
        private TextBox TxtNum;
    }
}
