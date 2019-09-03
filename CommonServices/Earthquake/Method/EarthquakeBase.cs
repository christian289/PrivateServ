using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.Earthquake.Method
{
    public class EarthquakeBase
    {
        public delegate void ResponseFired();
        public ResponseFired InComming;

        public bool bServiceControl;
        protected bool bDateTimeChanged;
        private DateTime _TodayDT; // Property를 { get; set; } 형식으로 쓰지 않고 아래처럼 get과 set의 동작을 명시할 경우, private 변수를 따로 지정하지 않았을 때 재귀호출이 생겨서 StackOverFlowException이 발생한다.

        protected DateTime TodayDT
        {
            get
            {
                return _TodayDT;
            }
            set
            {
                if (_TodayDT != value) // 현재 날짜와 입력되는 날짜가 다를 경우.
                {
                    bDateTimeChanged = true; // 날짜가 변경될 경우 변경되었다는 표시.
                }

                _TodayDT = value;
            }
        }

        public string Level(string num)
        {
            switch(num)
            {
                case "2":
                    return "국외 지진정보";
                case "3":
                    return "국내 지진정보";
                case "5":
                    return "국내 지진정보(재통보)";
                case "11":
                    return "국내 지진조기경보";
                case "12":
                    return "국외 지진조기경보";
                case "13":
                    return "조기경보 정밀분석";
                case "14":
                    return "지진속보(조기분석)";
                default:
                    return "";
            }
        }

        public dynamic SelectiveParse(string RestfulValue, Type type)
        {
            JObject obj = JObject.Parse(RestfulValue);

            if (type.Equals(typeof(Entity.Response.EarthquakeReport)))
            {
                Entity.Response.EarthquakeReport rtnValue = new Entity.Response.EarthquakeReport();

                rtnValue.img = obj.Root["response"].Last.First["items"]["item"]["img"].ToString(); // 지진 이미지
                rtnValue.tmFc = obj.Root["response"].Last.First["items"]["item"]["tmFc"].ToString(); // 지진 발령
                rtnValue.tmSeq = obj.Root["response"].Last.First["items"]["item"]["tmSeq"].ToString(); // 지진 번호
                rtnValue.tmEqk = obj.Root["response"].Last.First["items"]["item"]["tmEqk"].ToString(); // 지진 발령 상세
                rtnValue.lat = obj.Root["response"].Last.First["items"]["item"]["lat"].ToString(); // 위도
                rtnValue.lon = obj.Root["response"].Last.First["items"]["item"]["lon"].ToString(); // 경도
                rtnValue.loc = obj.Root["response"].Last.First["items"]["item"]["loc"].ToString(); // 발생 위치
                rtnValue.mt = obj.Root["response"].Last.First["items"]["item"]["mt"].ToString(); // 규모
                rtnValue.dep = obj.Root["response"].Last.First["items"]["item"]["dep"].ToString(); // 깊이
                rtnValue.rem = obj.Root["response"].Last.First["items"]["item"]["rem"].ToString(); // 설명
                rtnValue.fcTp = obj.Root["response"].Last.First["items"]["item"]["fcTp"].ToString(); // 분류

                return rtnValue;
            }
            else if (type.Equals(typeof(Entity.Response.EarthquakeReportList)))
            {
                Entity.Response.EarthquakeReportList rtnValue = new Entity.Response.EarthquakeReportList();

                return rtnValue;
            }
            else if (type.Equals(typeof(Entity.Response.TsunamiReport)))
            {
                Entity.Response.TsunamiReport rtnValue = new Entity.Response.TsunamiReport();

                return rtnValue;
            }
            else //if (type.Equals(typeof(Entity.Response.TsunamiReportList)))
            {
                Entity.Response.TsunamiReportList rtnValue = new Entity.Response.TsunamiReportList();

                return rtnValue;
            }
        }

        protected EarthquakeBase()
        {
            bServiceControl = false;
            bDateTimeChanged = false; // 최초 실행 때 오늘 날짜가 입력 되었을 때는 변경표시를 하지 않음.
            TodayDT = DateTime.Today;
        }

        public virtual void Service()
        {

        }
    }
}
