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

namespace IZONE
{
    public partial class MasterCtl : UserControl
    {
        IntPtr TgtHnd;
        DateTime CurTime;

        HtmlDocument _HtmlDocument;
        HtmlElement _HtmlElement;
        HtmlElementCollection _HtmlElementCollection;

        CaptainRabbit _CaptainRabbit;
        Kura _Kura;
        KwangBae _KwangBae;
        Duck _Duck;
        Feather _Feather;
        RadishWrappingRoll _RadishWrappingRoll;
        Frog _Frog;
        CuteBling _CuteBling;
        Strawberry _Strawberry;
        HamsterYurlll _HamsterYurlll;
        Puppy _Puppy;
        GiantBaby _GiantBaby;

        public MasterCtl()
        {
            InitializeComponent();
            tmr_BirthDayChecker.Tick += Tmr_BirthDayChecker_Tick;
            tmr_NaverScraping.Tick += Tmr_NaverScraping_Tick;
            btnBirthDayCheckerStart.Click += ((sender, e) => tmr_BirthDayChecker.Enabled = true );
            btnBirthDayCheckerStop.Click += ((sender, e) => tmr_BirthDayChecker.Enabled = false );

            _CaptainRabbit = new CaptainRabbit();
            _Kura = new Kura();
            _KwangBae = new KwangBae();
            _Duck = new Duck();
            _Feather = new Feather();
            _RadishWrappingRoll = new RadishWrappingRoll();
            _Frog = new Frog();
            _CuteBling = new CuteBling();
            _Strawberry = new Strawberry();
            _HamsterYurlll = new HamsterYurlll();
            _Puppy = new Puppy();
            _GiantBaby = new GiantBaby();

            tmr_NaverScraping.Enabled = true;
        }

        private void Tmr_NaverScraping_Tick(object sender, EventArgs e)
        {
            // 5초마다 발생하는 타이머라 과부하가 적어서 재부팅할 필요가 없다.
            Scrapping();
        }

        private void Scrapping()
        {

        }

        private void Tmr_BirthDayChecker_Tick(object sender, EventArgs e)
        {
            tmr_BirthDayChecker.Enabled = false;

            // 나중에 패턴 사용해서 if 문 삭제
            if (IsKaKaoTalkOpen(out TgtHnd))
            {
                CurTime = DateTime.Now;

                if (CurTime.ToString("hh").Equals(_CaptainRabbit.BirthDay.Month.ToString().PadLeft(2, '0').ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_CaptainRabbit.BirthDay.Day))
                {
                    SendText(TgtHnd, _CaptainRabbit.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Kura.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Kura.BirthDay.Day))
                {
                    SendText(TgtHnd, _Kura.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_KwangBae.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_KwangBae.BirthDay.Day))
                {
                    SendText(TgtHnd, _KwangBae.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Duck.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Duck.BirthDay.Day))
                {
                    SendText(TgtHnd, _Duck.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Feather.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Feather.BirthDay.Day))
                {
                    SendText(TgtHnd, _Feather.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_RadishWrappingRoll.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_RadishWrappingRoll.BirthDay.Day))
                {
                    SendText(TgtHnd, _RadishWrappingRoll.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Frog.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Frog.BirthDay.Day))
                {
                    SendText(TgtHnd, _Frog.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_CuteBling.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_CuteBling.BirthDay.Day))
                {
                    SendText(TgtHnd, _CuteBling.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Strawberry.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Strawberry.BirthDay.Day))
                {
                    SendText(TgtHnd, _Strawberry.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_HamsterYurlll.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_HamsterYurlll.BirthDay.Day))
                {
                    SendText(TgtHnd, _HamsterYurlll.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_Puppy.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_Puppy.BirthDay.Day))
                {
                    SendText(TgtHnd, _Puppy.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(_GiantBaby.BirthDay.Month.ToString().PadLeft(2, '0')) && CurTime.Minute.Equals(_GiantBaby.BirthDay.Day))
                {
                    SendText(TgtHnd, _GiantBaby.BirthDayMessage);
                }
                else if (CurTime.ToString("hh").Equals(10) && CurTime.Minute.Equals(29))
                {
                    SendText(TgtHnd, Msg.TimeOfDebut);
                }
            }

            tmr_BirthDayChecker.Enabled = true;
        }

        private bool IsKaKaoTalkOpen(out IntPtr TgtHnd)
        {
            //IntPtr TargetWindowNameHnd = Utils.FindWindow(null, "안고독한 아이즈원(IZ*ONE)");
            IntPtr TargetWindowNameHnd = Utils.FindWindow(null, "이상준");

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
            IntPtr hChildDialog1 = Utils.FindWindowEx(TargetWindowNameHnd, IntPtr.Zero, "RichEdit20W", null);

            // 두 개의 다이얼로그 중 하나의 값이라도 받아오지 못한 경우 정상적인 카카오톡 창이 아니다.
            if (hChildDialog1 == IntPtr.Zero)
            {
                TgtHnd = IntPtr.Zero;
                return false;
            }

            TgtHnd = TargetWindowNameHnd;

            return true;
        }

        public void SendText(IntPtr hEdit, string SendText)
        {
            Utils.SendMessage(hEdit, Utils.WM_SETTEXT, IntPtr.Zero, SendText);
            Utils.PostMessage(hEdit, Utils.WM_KEYDOWN, Utils.VK_ENTER, IntPtr.Zero);
            Utils.PostMessage(hEdit, Utils.WM_KEYUP, Utils.VK_ENTER, IntPtr.Zero);
        }
    }
}
