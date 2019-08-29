using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IZONE.Members;
using Newtonsoft.Json.Linq;

namespace IZONE
{
    public partial class MasterCtl : UserControl
    {
        private const string RoomName = "이상준";

        IntPtr TgtHnd;
        DateTime CurTime;

        HtmlDocument _HtmlDocument;
        HtmlElement _HtmlElement;
        HtmlElementCollection _HtmlElementCollection;

        List<Member> IZONE;

        CommonServices.Earthquake.Method.EarthquakeReport _EarthquakeReport;
        CommonServices.Earthquake.Method.EarthquakeReportList _EarthquakeReportList;
        CommonServices.Earthquake.Method.TsunamiReport _TsunamiReport;
        CommonServices.Earthquake.Method.TsunamiReportList _TsunamiReportList;

        CommonServices.Earthquake.Entity.Response.EarthquakeReport _EarthquakeReportRes;
        CommonServices.Earthquake.Entity.Response.EarthquakeReportList _EarthquakeReportListRes;
        CommonServices.Earthquake.Entity.Response.TsunamiReport _TsunamiReportRes;
        CommonServices.Earthquake.Entity.Response.TsunamiReportList _TsunamiReportListRes;

        public MasterCtl()
        {
            InitializeComponent();

            tmr_BirthDayChecker.Tick += delegate (object sender, EventArgs e)
            {
                tmr_BirthDayChecker.Enabled = false;

                BirthDayChecker();

                tmr_BirthDayChecker.Enabled = true;
            };
            tmr_NaverScraping.Tick += delegate (object sender, EventArgs e)
            {
                tmr_NaverScraping.Enabled = false;

                Scrapping();

                tmr_NaverScraping.Enabled = true;
            };
            btnBirthDayCheckStart.Click += delegate (object sender, EventArgs e)
            {
                tmr_BirthDayChecker.Enabled = true;
                btnBirthDayCheckStart.Enabled = false;
                btnBirthDayCheckStop.Enabled = true;
            };
            btnBirthDayCheckStop.Click += delegate (object sender, EventArgs e)
            {
                tmr_BirthDayChecker.Enabled = false;
                btnBirthDayCheckStart.Enabled = true;
                btnBirthDayCheckStop.Enabled = false;
            };
            btnEarthquakeCheckStart.Click += delegate (object sender, EventArgs e)
            {
                _EarthquakeReport.Service();
                _EarthquakeReportList.Service();
                _TsunamiReport.Service();
                _TsunamiReportList.Service();
            };
            btnEarthquakeCheckStop.Click += delegate (object sender, EventArgs e)
            {
                _EarthquakeReport.bServiceControl = true;
                _EarthquakeReportList.bServiceControl = true;
                _TsunamiReport.bServiceControl = true;
                _TsunamiReportList.bServiceControl = true;
            };
            lvBirthDayImages.ItemDrag += LvBirthDayImages_ItemDrag;

            IZONE = new List<Member>();
            IZONE.Add(new CaptainRabbit());
            IZONE.Add(new Kura());
            IZONE.Add(new KwangBae());
            IZONE.Add(new Duck());
            IZONE.Add(new Feather());
            IZONE.Add(new RadishWrappingRoll());
            IZONE.Add(new Frog());
            IZONE.Add(new CuteBling());
            IZONE.Add(new Strawberry());
            IZONE.Add(new HamsterYurlll());
            IZONE.Add(new Puppy());
            IZONE.Add(new GiantBaby());

            _EarthquakeReport = new CommonServices.Earthquake.Method.EarthquakeReport();
            _EarthquakeReportList = new CommonServices.Earthquake.Method.EarthquakeReportList();
            _TsunamiReport = new CommonServices.Earthquake.Method.TsunamiReport();
            _TsunamiReportList = new CommonServices.Earthquake.Method.TsunamiReportList();
            _EarthquakeReport.InComming += EarthquakeReportCallback;
            _EarthquakeReportList.InComming += EarthquakeReportListCallback;
            _TsunamiReport.InComming += TsunamiReportCallback;
            _TsunamiReportList.InComming += TsunamiReportListCallBack;

            //tmr_NaverScraping.Enabled = true;

            ImgLst_BirthDay.ImageSize = new Size(32, 32);
            lvBirthDayImages.LargeImageList = ImgLst_BirthDay; // LargeImageList를 사용하기 위해선 ListView.View 속성이 LargeIcon or Tile 이어야 한다.
            lvBirthDayImages.SmallImageList = ImgLst_BirthDay; // SmallImageList를 사용하기 위해선 ListView.View 속성이 Details or SmallIcon or List 여야 한다.
            lvBirthDayImages.View = View.LargeIcon;
            AddImages();
        }

        private void AddImages()
        {
            int iKey = 0;

            foreach (Member member in IZONE)
            {
                ImgLst_BirthDay.Images.Add(member.BirthDayImage);
                lvBirthDayImages.Items.Add(member.Name, iKey++);
            }
        }

        private void LvBirthDayImages_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void Scrapping()
        {

        }

        private void BirthDayChecker()
        {
            // 나중에 패턴 사용해서 if 문 삭제
            if (IsKaKaoTalkOpen(RoomName, out TgtHnd))
            // if (IsKaKaoTalkOpen("안고독한 아이즈원(IZ*ONE)", out ThtHnd))
            {
                CurTime = DateTime.Now;

                foreach (Member member in IZONE)
                {
                    if (CurTime.ToString("hh").Equals(member.BirthDay.ToString("MM")) &&
                        CurTime.ToString("mm").Equals(member.BirthDay.ToString("dd")))
                    {
                        SendText(TgtHnd, member.BirthDayMessage);
                    }
                }
            }
        }

        private bool IsKaKaoTalkOpen(string RoomName, out IntPtr TgtHnd)
        {
            IntPtr TargetWindowNameHnd = Utils.FindWindow(null, RoomName);

            if (TargetWindowNameHnd.Equals(IntPtr.Zero))
            {
                TgtHnd = IntPtr.Zero;
                return false;
            }

            if (!Utils.IsWindow(TargetWindowNameHnd)) // 창 핸들인지 확인한다.
            {
                TgtHnd = IntPtr.Zero;
                return false;
            }

            // 총 2개의 하위 다이얼로그가 있으므로 핸들을 각각 가져온다.
            IntPtr kakaoTextboxHandle = Utils.FindWindowEx(TargetWindowNameHnd, IntPtr.Zero, "RichEdit20W", null);

            // 두 개의 다이얼로그 중 하나의 값이라도 받아오지 못한 경우 정상적인 카카오톡 창이 아니다.
            if (kakaoTextboxHandle == IntPtr.Zero)
            {
                TgtHnd = IntPtr.Zero;
                return false;
            }

            TgtHnd = kakaoTextboxHandle;

            return true;
        }

        public void SendText(IntPtr hEdit, string SendText)
        {
            Utils.SendMessage(hEdit, Utils.WM_SETTEXT, IntPtr.Zero, SendText);
            Utils.PostMessage(hEdit, Utils.WM_KEYDOWN, Utils.VK_ENTER, IntPtr.Zero);
            Utils.PostMessage(hEdit, Utils.WM_KEYUP, Utils.VK_ENTER, IntPtr.Zero);
        }

        #region Callbacks

        private void EarthquakeReportCallback()
        {
            if (IsKaKaoTalkOpen(RoomName, out TgtHnd))
            {
                SendText(TgtHnd, MakeEarthquakeString(JObject.FromObject(_EarthquakeReport.EarthquakeReportRes)));
            }
        }

        private void EarthquakeReportListCallback()
        {
            if (IsKaKaoTalkOpen(RoomName, out TgtHnd))
            {
                SendText(TgtHnd, MakeEarthquakeString(JObject.FromObject(_EarthquakeReportList.EarthquakeReportListRes)));
            }
        }

        private void TsunamiReportCallback()
        {
            if (IsKaKaoTalkOpen(RoomName, out TgtHnd))
            {
                SendText(TgtHnd, MakeEarthquakeString(JObject.FromObject(_TsunamiReport.TsunamiReportRes)));
            }
        }

        private void TsunamiReportListCallBack()
        {
            if (IsKaKaoTalkOpen(RoomName, out TgtHnd))
            {
                SendText(TgtHnd, MakeEarthquakeString(JObject.FromObject(_TsunamiReportList.TsunamiReportListRes)));
            }
        }

        #endregion

        private string MakeEarthquakeString(JObject obj)
        {
            string returnString = string.Empty;

            return returnString;
        }
    }
}
