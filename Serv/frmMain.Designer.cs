namespace Serv
{
    partial class frmMain
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
            this.IZONEController = new IZONE.MasterCtl();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.TP_IZONE = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.TP_IZONE.SuspendLayout();
            this.SuspendLayout();
            // 
            // IZONEController
            // 
            this.IZONEController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IZONEController.Location = new System.Drawing.Point(3, 3);
            this.IZONEController.Name = "IZONEController";
            this.IZONEController.Size = new System.Drawing.Size(974, 506);
            this.IZONEController.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.TP_IZONE);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(988, 541);
            this.MainTab.TabIndex = 1;
            // 
            // TP_IZONE
            // 
            this.TP_IZONE.Location = new System.Drawing.Point(4, 25);
            this.TP_IZONE.Name = "TP_IZONE";
            this.TP_IZONE.Padding = new System.Windows.Forms.Padding(3);
            this.TP_IZONE.Size = new System.Drawing.Size(980, 512);
            this.TP_IZONE.TabIndex = 0;
            this.TP_IZONE.Text = "아이즈원 서비스";
            this.TP_IZONE.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 541);
            this.Controls.Add(this.MainTab);
            this.Name = "frmMain";
            this.MainTab.ResumeLayout(false);
            this.TP_IZONE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IZONE.MasterCtl IZONEController;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage TP_IZONE;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

