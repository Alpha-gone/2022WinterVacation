namespace MyWcfWindowsForms
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputNum = new System.Windows.Forms.TextBox();
            this.btnMaxNum = new System.Windows.Forms.Button();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvgNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInputNum
            // 
            this.txtInputNum.Location = new System.Drawing.Point(56, 75);
            this.txtInputNum.Name = "txtInputNum";
            this.txtInputNum.Size = new System.Drawing.Size(264, 21);
            this.txtInputNum.TabIndex = 0;
            // 
            // btnMaxNum
            // 
            this.btnMaxNum.Location = new System.Drawing.Point(353, 56);
            this.btnMaxNum.Name = "btnMaxNum";
            this.btnMaxNum.Size = new System.Drawing.Size(128, 56);
            this.btnMaxNum.TabIndex = 1;
            this.btnMaxNum.Text = "값 구하기";
            this.btnMaxNum.UseVisualStyleBackColor = true;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(107, 126);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(213, 21);
            this.txtMaxNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "최대값:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "합계:";
            // 
            // txtSumNum
            // 
            this.txtSumNum.Location = new System.Drawing.Point(107, 180);
            this.txtSumNum.Name = "txtSumNum";
            this.txtSumNum.Size = new System.Drawing.Size(213, 21);
            this.txtSumNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "평균값:";
            // 
            // txtAvgNum
            // 
            this.txtAvgNum.Location = new System.Drawing.Point(107, 216);
            this.txtAvgNum.Name = "txtAvgNum";
            this.txtAvgNum.Size = new System.Drawing.Size(213, 21);
            this.txtAvgNum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "최소값:";
            // 
            // txtMinNum
            // 
            this.txtMinNum.Location = new System.Drawing.Point(107, 153);
            this.txtMinNum.Name = "txtMinNum";
            this.txtMinNum.Size = new System.Drawing.Size(213, 21);
            this.txtMinNum.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAvgNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxNum);
            this.Controls.Add(this.btnMaxNum);
            this.Controls.Add(this.txtInputNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNum;
        private System.Windows.Forms.Button btnMaxNum;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvgNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinNum;
    }
}

