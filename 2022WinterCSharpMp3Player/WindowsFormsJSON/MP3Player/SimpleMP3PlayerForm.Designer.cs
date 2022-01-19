namespace MP3Player
{
    partial class SimpleMP3PlayerForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.playerTrackBar = new System.Windows.Forms.TrackBar();
            this.lbMP3Timer = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mp3Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Font = new System.Drawing.Font("굴림", 14F);
            this.btnOpen.Location = new System.Drawing.Point(669, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(109, 42);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.playerTrackBar);
            this.panel2.Controls.Add(this.lbMP3Timer);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 380);
            this.panel2.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("굴림", 14F);
            this.btnStop.Location = new System.Drawing.Point(667, 187);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 50);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("굴림", 14F);
            this.btnPause.Location = new System.Drawing.Point(351, 187);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(111, 50);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // playerTrackBar
            // 
            this.playerTrackBar.Location = new System.Drawing.Point(29, 57);
            this.playerTrackBar.Name = "playerTrackBar";
            this.playerTrackBar.Size = new System.Drawing.Size(749, 45);
            this.playerTrackBar.TabIndex = 5;
            // 
            // lbMP3Timer
            // 
            this.lbMP3Timer.AutoSize = true;
            this.lbMP3Timer.Font = new System.Drawing.Font("굴림", 14F);
            this.lbMP3Timer.Location = new System.Drawing.Point(29, 117);
            this.lbMP3Timer.Name = "lbMP3Timer";
            this.lbMP3Timer.Size = new System.Drawing.Size(18, 19);
            this.lbMP3Timer.TabIndex = 4;
            this.lbMP3Timer.Text = "-";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("굴림", 14F);
            this.lbTitle.Location = new System.Drawing.Point(29, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(18, 19);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "-";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("굴림", 14F);
            this.btnPlay.Location = new System.Drawing.Point(33, 187);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(111, 50);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 350);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 100);
            this.pnlBottom.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // SimpleMP3PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SimpleMP3PlayerForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar playerTrackBar;
        private System.Windows.Forms.Label lbMP3Timer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer mp3Timer;
    }
}

