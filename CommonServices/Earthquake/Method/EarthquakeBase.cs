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
