using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.Earthquake.Method
{
    public class EarthquakeBase
    {
        public bool bServiceControl;

        protected bool bDateTimeChanged;

        protected DateTime TodayDT
        {
            get
            {
                return TodayDT;
            }
            set
            {
                if (TodayDT != value) // 현재 날짜와 입력되는 날짜가 다를 경우.
                {
                    bDateTimeChanged = true; // 날짜가 변경될 경우 변경되었다는 표시.
                }

                TodayDT = value;
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
