namespace DotNet04ControlApp
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
            groupBox1 = new GroupBox();
            BtnDialog = new Button();
            BtnMsgbox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            TxtResult = new TextBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            Chkitalic = new CheckBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PrgStatus = new ProgressBar();
            TrkStatus = new TrackBar();
            groupBox3 = new GroupBox();
            BtnAddRoot = new Button();
            BtnAddNode = new Button();
            LvwDummy = new ListView();
            TvwDummy = new TreeView();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            BtnLoadimg = new Button();
            PicImage = new PictureBox();
            groupBox6 = new GroupBox();
            DlgOpenFile = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnDialog);
            groupBox1.Controls.Add(BtnMsgbox);
            groupBox1.Controls.Add(BtnModaless);
            groupBox1.Controls.Add(BtnModal);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(Chkitalic);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "기본 컨트롤";
            // 
            // BtnDialog
            // 
            BtnDialog.Location = new Point(182, 103);
            BtnDialog.Name = "BtnDialog";
            BtnDialog.Size = new Size(141, 23);
            BtnDialog.TabIndex = 8;
            BtnDialog.Text = "...";
            BtnDialog.UseVisualStyleBackColor = true;
            BtnDialog.Click += BtnDialog_Click;
            // 
            // BtnMsgbox
            // 
            BtnMsgbox.Location = new Point(15, 103);
            BtnMsgbox.Name = "BtnMsgbox";
            BtnMsgbox.Size = new Size(146, 23);
            BtnMsgbox.TabIndex = 7;
            BtnMsgbox.Text = "메세지창";
            BtnMsgbox.UseVisualStyleBackColor = true;
            BtnMsgbox.Click += BtnMsgbox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(182, 78);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(141, 23);
            BtnModaless.TabIndex = 6;
            BtnModaless.Text = "모달리스";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(15, 78);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(146, 23);
            BtnModal.TabIndex = 5;
            BtnModal.Text = "모달";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(15, 51);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(309, 23);
            TxtResult.TabIndex = 4;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Location = new Point(207, 26);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굴게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(52, 24);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(147, 23);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // Chkitalic
            // 
            Chkitalic.AutoSize = true;
            Chkitalic.Location = new Point(261, 26);
            Chkitalic.Name = "Chkitalic";
            Chkitalic.Size = new Size(62, 19);
            Chkitalic.TabIndex = 3;
            Chkitalic.Text = "이텔릭";
            Chkitalic.UseVisualStyleBackColor = true;
            Chkitalic.CheckedChanged += Chkitalic_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left;
            groupBox2.Controls.Add(PrgStatus);
            groupBox2.Controls.Add(TrkStatus);
            groupBox2.Location = new Point(21, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바,진행바";
            // 
            // PrgStatus
            // 
            PrgStatus.Location = new Point(15, 82);
            PrgStatus.Name = "PrgStatus";
            PrgStatus.Size = new Size(308, 23);
            PrgStatus.TabIndex = 1;
            // 
            // TrkStatus
            // 
            TrkStatus.Location = new Point(15, 31);
            TrkStatus.Maximum = 100;
            TrkStatus.Name = "TrkStatus";
            TrkStatus.Size = new Size(308, 45);
            TrkStatus.TabIndex = 0;
            TrkStatus.TickFrequency = 5;
            TrkStatus.Value = 10;
            TrkStatus.Scroll += TrkStatus_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(BtnAddRoot);
            groupBox3.Controls.Add(BtnAddNode);
            groupBox3.Controls.Add(LvwDummy);
            groupBox3.Controls.Add(TvwDummy);
            groupBox3.Location = new Point(21, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 254);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "트리,리스트뷰";
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(198, 220);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(64, 23);
            BtnAddRoot.TabIndex = 3;
            BtnAddRoot.Text = "루트추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // BtnAddNode
            // 
            BtnAddNode.Location = new Point(268, 220);
            BtnAddNode.Name = "BtnAddNode";
            BtnAddNode.Size = new Size(67, 23);
            BtnAddNode.TabIndex = 2;
            BtnAddNode.Text = "노드추가";
            BtnAddNode.UseVisualStyleBackColor = true;
            BtnAddNode.Click += BtnAddNode_Click;
            // 
            // LvwDummy
            // 
            LvwDummy.Location = new Point(167, 27);
            LvwDummy.Name = "LvwDummy";
            LvwDummy.Size = new Size(168, 187);
            LvwDummy.TabIndex = 1;
            LvwDummy.UseCompatibleStateImageBehavior = false;
            // 
            // TvwDummy
            // 
            TvwDummy.Location = new Point(15, 27);
            TvwDummy.Name = "TvwDummy";
            TvwDummy.Size = new Size(146, 187);
            TvwDummy.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom;
            groupBox4.Location = new Point(368, 322);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(462, 227);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "스레드";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top;
            groupBox5.Controls.Add(BtnLoadimg);
            groupBox5.Controls.Add(PicImage);
            groupBox5.Location = new Point(368, 21);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(462, 295);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽쳐박스";
            // 
            // BtnLoadimg
            // 
            BtnLoadimg.Location = new Point(381, 259);
            BtnLoadimg.Name = "BtnLoadimg";
            BtnLoadimg.Size = new Size(75, 23);
            BtnLoadimg.TabIndex = 1;
            BtnLoadimg.Text = "이미지";
            BtnLoadimg.UseVisualStyleBackColor = true;
            BtnLoadimg.Click += BtnLoadimg_Click;
            // 
            // PicImage
            // 
            PicImage.Location = new Point(6, 15);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(450, 238);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            PicImage.Click += PicImage_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Location = new Point(836, 21);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(336, 528);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "텍스트에디터";
            // 
            // DlgOpenFile
            // 
            DlgOpenFile.FileName = "텍스트 파일을 입력하시오";
            DlgOpenFile.Filter = "Text files (*.txt)|*.txt|All files(*.*(|*.*";
            DlgOpenFile.Title = "텍스트 파일 열기";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "컨트롤 예제";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrkStatus).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private ComboBox CboFonts;
        private CheckBox Chkitalic;
        private Label label1;
        private CheckBox ChkBold;
        private TextBox TxtResult;
        private Button BtnDialog;
        private Button BtnMsgbox;
        private Button BtnModaless;
        private Button BtnModal;
        private OpenFileDialog DlgOpenFile;
        private ProgressBar PrgStatus;
        private TrackBar TrkStatus;
        private ListView LvwDummy;
        private TreeView TvwDummy;
        private Button BtnAddRoot;
        private Button BtnAddNode;
        private Button BtnLoadimg;
        private PictureBox PicImage;
    }
}
