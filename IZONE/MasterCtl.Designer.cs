namespace IZONE
{
    partial class MasterCtl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpFunctionList = new System.Windows.Forms.GroupBox();
            this.btnBirthDayCheckerStop = new System.Windows.Forms.Button();
            this.btnBirthDayCheckerStart = new System.Windows.Forms.Button();
            this.grpCheckLog = new System.Windows.Forms.GroupBox();
            this.lstBx_Monitoring = new System.Windows.Forms.ListBox();
            this.lstBx_WhoIsCall = new System.Windows.Forms.ListBox();
            this.tmr_BirthDayChecker = new System.Windows.Forms.Timer(this.components);
            this.tmr_NaverScraping = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.grpFunctionList.SuspendLayout();
            this.grpCheckLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpFunctionList);
            this.pnlMain.Controls.Add(this.grpCheckLog);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(922, 509);
            this.pnlMain.TabIndex = 0;
            // 
            // grpFunctionList
            // 
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckerStop);
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckerStart);
            this.grpFunctionList.Location = new System.Drawing.Point(19, 386);
            this.grpFunctionList.Name = "grpFunctionList";
            this.grpFunctionList.Size = new System.Drawing.Size(881, 100);
            this.grpFunctionList.TabIndex = 2;
            this.grpFunctionList.TabStop = false;
            this.grpFunctionList.Text = "기능";
            // 
            // btnBirthDayCheckerStop
            // 
            this.btnBirthDayCheckerStop.Location = new System.Drawing.Point(190, 24);
            this.btnBirthDayCheckerStop.Name = "btnBirthDayCheckerStop";
            this.btnBirthDayCheckerStop.Size = new System.Drawing.Size(166, 65);
            this.btnBirthDayCheckerStop.TabIndex = 2;
            this.btnBirthDayCheckerStop.Text = "멤버 시 체크 안 함";
            this.btnBirthDayCheckerStop.UseVisualStyleBackColor = true;
            // 
            // btnBirthDayCheckerStart
            // 
            this.btnBirthDayCheckerStart.Location = new System.Drawing.Point(18, 24);
            this.btnBirthDayCheckerStart.Name = "btnBirthDayCheckerStart";
            this.btnBirthDayCheckerStart.Size = new System.Drawing.Size(166, 65);
            this.btnBirthDayCheckerStart.TabIndex = 2;
            this.btnBirthDayCheckerStart.Text = "멤버 시 체크 시작";
            this.btnBirthDayCheckerStart.UseVisualStyleBackColor = true;
            // 
            // grpCheckLog
            // 
            this.grpCheckLog.Controls.Add(this.lstBx_Monitoring);
            this.grpCheckLog.Controls.Add(this.lstBx_WhoIsCall);
            this.grpCheckLog.Location = new System.Drawing.Point(19, 23);
            this.grpCheckLog.Name = "grpCheckLog";
            this.grpCheckLog.Size = new System.Drawing.Size(881, 357);
            this.grpCheckLog.TabIndex = 1;
            this.grpCheckLog.TabStop = false;
            this.grpCheckLog.Text = "모니터링";
            // 
            // lstBx_Monitoring
            // 
            this.lstBx_Monitoring.FormattingEnabled = true;
            this.lstBx_Monitoring.ItemHeight = 15;
            this.lstBx_Monitoring.Location = new System.Drawing.Point(18, 24);
            this.lstBx_Monitoring.Name = "lstBx_Monitoring";
            this.lstBx_Monitoring.Size = new System.Drawing.Size(641, 319);
            this.lstBx_Monitoring.TabIndex = 1;
            // 
            // lstBx_WhoIsCall
            // 
            this.lstBx_WhoIsCall.FormattingEnabled = true;
            this.lstBx_WhoIsCall.ItemHeight = 15;
            this.lstBx_WhoIsCall.Location = new System.Drawing.Point(683, 24);
            this.lstBx_WhoIsCall.Name = "lstBx_WhoIsCall";
            this.lstBx_WhoIsCall.Size = new System.Drawing.Size(181, 319);
            this.lstBx_WhoIsCall.TabIndex = 0;
            // 
            // tmr_NaverScraping
            // 
            this.tmr_NaverScraping.Interval = 10000;
            // 
            // MasterCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "MasterCtl";
            this.Size = new System.Drawing.Size(922, 509);
            this.pnlMain.ResumeLayout(false);
            this.grpFunctionList.ResumeLayout(false);
            this.grpCheckLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFunctionList;
        private System.Windows.Forms.GroupBox grpCheckLog;
        private System.Windows.Forms.ListBox lstBx_Monitoring;
        private System.Windows.Forms.ListBox lstBx_WhoIsCall;
        private System.Windows.Forms.Timer tmr_BirthDayChecker;
        private System.Windows.Forms.Button btnBirthDayCheckerStop;
        private System.Windows.Forms.Button btnBirthDayCheckerStart;
        private System.Windows.Forms.Timer tmr_NaverScraping;
    }
}
