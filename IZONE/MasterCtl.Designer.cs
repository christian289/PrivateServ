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
            this.lstBx_WhoIsCall = new System.Windows.Forms.ListBox();
            this.tmr_BirthDayChecker = new System.Windows.Forms.Timer(this.components);
            this.tmr_NaverScraping = new System.Windows.Forms.Timer(this.components);
            this.lvBirthDayBitMap = new System.Windows.Forms.ListView();
            this.ImgLst_BirthDay = new System.Windows.Forms.ImageList(this.components);
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
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(807, 407);
            this.pnlMain.TabIndex = 0;
            // 
            // grpFunctionList
            // 
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckerStop);
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckerStart);
            this.grpFunctionList.Location = new System.Drawing.Point(17, 309);
            this.grpFunctionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunctionList.Name = "grpFunctionList";
            this.grpFunctionList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunctionList.Size = new System.Drawing.Size(771, 80);
            this.grpFunctionList.TabIndex = 2;
            this.grpFunctionList.TabStop = false;
            this.grpFunctionList.Text = "기능";
            // 
            // btnBirthDayCheckerStop
            // 
            this.btnBirthDayCheckerStop.Location = new System.Drawing.Point(166, 19);
            this.btnBirthDayCheckerStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBirthDayCheckerStop.Name = "btnBirthDayCheckerStop";
            this.btnBirthDayCheckerStop.Size = new System.Drawing.Size(145, 52);
            this.btnBirthDayCheckerStop.TabIndex = 2;
            this.btnBirthDayCheckerStop.Text = "멤버 시 체크 안 함";
            this.btnBirthDayCheckerStop.UseVisualStyleBackColor = true;
            // 
            // btnBirthDayCheckerStart
            // 
            this.btnBirthDayCheckerStart.Location = new System.Drawing.Point(16, 19);
            this.btnBirthDayCheckerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBirthDayCheckerStart.Name = "btnBirthDayCheckerStart";
            this.btnBirthDayCheckerStart.Size = new System.Drawing.Size(145, 52);
            this.btnBirthDayCheckerStart.TabIndex = 2;
            this.btnBirthDayCheckerStart.Text = "멤버 시 체크 시작";
            this.btnBirthDayCheckerStart.UseVisualStyleBackColor = true;
            // 
            // grpCheckLog
            // 
            this.grpCheckLog.Controls.Add(this.lvBirthDayBitMap);
            this.grpCheckLog.Controls.Add(this.lstBx_WhoIsCall);
            this.grpCheckLog.Location = new System.Drawing.Point(17, 18);
            this.grpCheckLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheckLog.Name = "grpCheckLog";
            this.grpCheckLog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheckLog.Size = new System.Drawing.Size(771, 286);
            this.grpCheckLog.TabIndex = 1;
            this.grpCheckLog.TabStop = false;
            this.grpCheckLog.Text = "모니터링";
            // 
            // lstBx_WhoIsCall
            // 
            this.lstBx_WhoIsCall.FormattingEnabled = true;
            this.lstBx_WhoIsCall.ItemHeight = 12;
            this.lstBx_WhoIsCall.Location = new System.Drawing.Point(16, 18);
            this.lstBx_WhoIsCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBx_WhoIsCall.Name = "lstBx_WhoIsCall";
            this.lstBx_WhoIsCall.Size = new System.Drawing.Size(295, 256);
            this.lstBx_WhoIsCall.TabIndex = 0;
            // 
            // tmr_NaverScraping
            // 
            this.tmr_NaverScraping.Interval = 10000;
            // 
            // lvBirthDayBitMap
            // 
            this.lvBirthDayBitMap.Location = new System.Drawing.Point(317, 18);
            this.lvBirthDayBitMap.Name = "lvBirthDayBitMap";
            this.lvBirthDayBitMap.Size = new System.Drawing.Size(448, 256);
            this.lvBirthDayBitMap.SmallImageList = this.ImgLst_BirthDay;
            this.lvBirthDayBitMap.TabIndex = 3;
            this.lvBirthDayBitMap.UseCompatibleStateImageBehavior = false;
            // 
            // ImgLst_BirthDay
            // 
            this.ImgLst_BirthDay.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgLst_BirthDay.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgLst_BirthDay.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MasterCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterCtl";
            this.Size = new System.Drawing.Size(807, 407);
            this.pnlMain.ResumeLayout(false);
            this.grpFunctionList.ResumeLayout(false);
            this.grpCheckLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFunctionList;
        private System.Windows.Forms.GroupBox grpCheckLog;
        private System.Windows.Forms.ListBox lstBx_WhoIsCall;
        private System.Windows.Forms.Timer tmr_BirthDayChecker;
        private System.Windows.Forms.Button btnBirthDayCheckerStop;
        private System.Windows.Forms.Button btnBirthDayCheckerStart;
        private System.Windows.Forms.Timer tmr_NaverScraping;
        private System.Windows.Forms.ListView lvBirthDayBitMap;
        private System.Windows.Forms.ImageList ImgLst_BirthDay;
    }
}
