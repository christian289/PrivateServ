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
            this.grpRoomSet = new System.Windows.Forms.GroupBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.grpFunctionList = new System.Windows.Forms.GroupBox();
            this.btnEarthquakeCheckStop = new System.Windows.Forms.Button();
            this.btnBirthDayCheckStop = new System.Windows.Forms.Button();
            this.btnEarthquakeCheckStart = new System.Windows.Forms.Button();
            this.btnBirthDayCheckStart = new System.Windows.Forms.Button();
            this.grpCheckLog = new System.Windows.Forms.GroupBox();
            this.lvBirthDayImages = new System.Windows.Forms.ListView();
            this.ImgLst_BirthDay = new System.Windows.Forms.ImageList(this.components);
            this.lstBx_WhoIsCall = new System.Windows.Forms.ListBox();
            this.tmr_BirthDayChecker = new System.Windows.Forms.Timer(this.components);
            this.tmr_NaverScraping = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.grpRoomSet.SuspendLayout();
            this.grpFunctionList.SuspendLayout();
            this.grpCheckLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpRoomSet);
            this.pnlMain.Controls.Add(this.grpFunctionList);
            this.pnlMain.Controls.Add(this.grpCheckLog);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(890, 453);
            this.pnlMain.TabIndex = 0;
            // 
            // grpRoomSet
            // 
            this.grpRoomSet.Controls.Add(this.lblRoomName);
            this.grpRoomSet.Controls.Add(this.txtRoomName);
            this.grpRoomSet.Location = new System.Drawing.Point(547, 361);
            this.grpRoomSet.Name = "grpRoomSet";
            this.grpRoomSet.Size = new System.Drawing.Size(327, 79);
            this.grpRoomSet.TabIndex = 3;
            this.grpRoomSet.TabStop = false;
            this.grpRoomSet.Text = "목표 채팅방";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Location = new System.Drawing.Point(6, 17);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(52, 23);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "방 이름:";
            this.lblRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(64, 19);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(257, 21);
            this.txtRoomName.TabIndex = 0;
            // 
            // grpFunctionList
            // 
            this.grpFunctionList.Controls.Add(this.btnEarthquakeCheckStop);
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckStop);
            this.grpFunctionList.Controls.Add(this.btnEarthquakeCheckStart);
            this.grpFunctionList.Controls.Add(this.btnBirthDayCheckStart);
            this.grpFunctionList.Location = new System.Drawing.Point(17, 360);
            this.grpFunctionList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunctionList.Name = "grpFunctionList";
            this.grpFunctionList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFunctionList.Size = new System.Drawing.Size(524, 80);
            this.grpFunctionList.TabIndex = 2;
            this.grpFunctionList.TabStop = false;
            this.grpFunctionList.Text = "기능";
            // 
            // btnEarthquakeCheckStop
            // 
            this.btnEarthquakeCheckStop.Location = new System.Drawing.Point(394, 19);
            this.btnEarthquakeCheckStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEarthquakeCheckStop.Name = "btnEarthquakeCheckStop";
            this.btnEarthquakeCheckStop.Size = new System.Drawing.Size(120, 25);
            this.btnEarthquakeCheckStop.TabIndex = 2;
            this.btnEarthquakeCheckStop.Text = "지진 체크 안 함";
            this.btnEarthquakeCheckStop.UseVisualStyleBackColor = true;
            // 
            // btnBirthDayCheckStop
            // 
            this.btnBirthDayCheckStop.Location = new System.Drawing.Point(142, 19);
            this.btnBirthDayCheckStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBirthDayCheckStop.Name = "btnBirthDayCheckStop";
            this.btnBirthDayCheckStop.Size = new System.Drawing.Size(120, 25);
            this.btnBirthDayCheckStop.TabIndex = 2;
            this.btnBirthDayCheckStop.Text = "멤버 시 체크 안 함";
            this.btnBirthDayCheckStop.UseVisualStyleBackColor = true;
            // 
            // btnEarthquakeCheckStart
            // 
            this.btnEarthquakeCheckStart.Location = new System.Drawing.Point(268, 19);
            this.btnEarthquakeCheckStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEarthquakeCheckStart.Name = "btnEarthquakeCheckStart";
            this.btnEarthquakeCheckStart.Size = new System.Drawing.Size(120, 25);
            this.btnEarthquakeCheckStart.TabIndex = 2;
            this.btnEarthquakeCheckStart.Text = "지진 체크 시작";
            this.btnEarthquakeCheckStart.UseVisualStyleBackColor = true;
            // 
            // btnBirthDayCheckStart
            // 
            this.btnBirthDayCheckStart.Location = new System.Drawing.Point(16, 19);
            this.btnBirthDayCheckStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBirthDayCheckStart.Name = "btnBirthDayCheckStart";
            this.btnBirthDayCheckStart.Size = new System.Drawing.Size(120, 25);
            this.btnBirthDayCheckStart.TabIndex = 2;
            this.btnBirthDayCheckStart.Text = "멤버 시 체크 시작";
            this.btnBirthDayCheckStart.UseVisualStyleBackColor = true;
            // 
            // grpCheckLog
            // 
            this.grpCheckLog.Controls.Add(this.lvBirthDayImages);
            this.grpCheckLog.Controls.Add(this.lstBx_WhoIsCall);
            this.grpCheckLog.Location = new System.Drawing.Point(17, 18);
            this.grpCheckLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheckLog.Name = "grpCheckLog";
            this.grpCheckLog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCheckLog.Size = new System.Drawing.Size(857, 338);
            this.grpCheckLog.TabIndex = 1;
            this.grpCheckLog.TabStop = false;
            this.grpCheckLog.Text = "모니터링";
            // 
            // lvBirthDayImages
            // 
            this.lvBirthDayImages.HideSelection = false;
            this.lvBirthDayImages.LargeImageList = this.ImgLst_BirthDay;
            this.lvBirthDayImages.Location = new System.Drawing.Point(248, 18);
            this.lvBirthDayImages.Name = "lvBirthDayImages";
            this.lvBirthDayImages.Size = new System.Drawing.Size(603, 315);
            this.lvBirthDayImages.SmallImageList = this.ImgLst_BirthDay;
            this.lvBirthDayImages.TabIndex = 3;
            this.lvBirthDayImages.UseCompatibleStateImageBehavior = false;
            this.lvBirthDayImages.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ImgLst_BirthDay
            // 
            this.ImgLst_BirthDay.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgLst_BirthDay.ImageSize = new System.Drawing.Size(90, 90);
            this.ImgLst_BirthDay.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstBx_WhoIsCall
            // 
            this.lstBx_WhoIsCall.FormattingEnabled = true;
            this.lstBx_WhoIsCall.ItemHeight = 12;
            this.lstBx_WhoIsCall.Location = new System.Drawing.Point(16, 18);
            this.lstBx_WhoIsCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBx_WhoIsCall.Name = "lstBx_WhoIsCall";
            this.lstBx_WhoIsCall.Size = new System.Drawing.Size(226, 316);
            this.lstBx_WhoIsCall.TabIndex = 0;
            // 
            // tmr_NaverScraping
            // 
            this.tmr_NaverScraping.Interval = 10000;
            // 
            // MasterCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MasterCtl";
            this.Size = new System.Drawing.Size(890, 453);
            this.pnlMain.ResumeLayout(false);
            this.grpRoomSet.ResumeLayout(false);
            this.grpRoomSet.PerformLayout();
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
        private System.Windows.Forms.Button btnBirthDayCheckStop;
        private System.Windows.Forms.Button btnBirthDayCheckStart;
        private System.Windows.Forms.Timer tmr_NaverScraping;
        private System.Windows.Forms.ImageList ImgLst_BirthDay;
        private System.Windows.Forms.Button btnEarthquakeCheckStop;
        private System.Windows.Forms.Button btnEarthquakeCheckStart;
        private System.Windows.Forms.ListView lvBirthDayImages;
        private System.Windows.Forms.GroupBox grpRoomSet;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtRoomName;
    }
}
