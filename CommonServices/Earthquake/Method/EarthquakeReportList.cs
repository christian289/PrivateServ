﻿using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using CommonServices.HttpComm;

namespace CommonServices.Earthquake.Method
{
    public class EarthquakeReportList : EarthquakeBase
    {
        Entity.Response.EarthquakeReportList _EarthquakeReportListRes;

        public Entity.Response.EarthquakeReportList EarthquakeReportListRes
        {
            get
            {
                return _EarthquakeReportListRes;
            }
            private set
            {
                if (ReferenceEquals(_EarthquakeReportListRes, null) || !_EarthquakeReportListRes.code.Equals(value.code))
                {
                    _EarthquakeReportListRes = value;

                    if (!string.IsNullOrEmpty(_EarthquakeReportListRes.code)) // Exception으로 인해 기본 생성자가 할당되었을 경우 Callback Pass
                    {
                        InComming();
                    }
                }
            }
        }

        public EarthquakeReportList()
        {
        }

        public override async void Service()
        {
            int iCount = 1000; // Open API 사이트에서 제한한 횟수

            Entity.Request.EarthquakeReportList Entity = new Earthquake.Entity.Request.EarthquakeReportList();
            Entity.fromTmFc = (TodayDT.AddDays(-2)).ToString("yyyyMMdd"); // API가 3일 간 발생했던 것만 조회가능
            Entity.toTmFc = TodayDT.ToString("yyyyMMdd");
            Entity.ServiceKey = EarthquakeKey.Key;
            Entity.numOfRows = "10";
            Entity.pageNo = "1";

            while (iCount > 0)
            {
                if (bServiceControl)
                {
                    bServiceControl = false;
                    break;
                }

                // 하루 API 호출 횟수가 1000번이 최대치인데, 하루가 끝나기 전에 1000번을 모두 호출 했을 경우, 다음날까지 대기
                while (iCount.Equals(0))
                {
                    TodayDT = DateTime.Today;

                    if (bDateTimeChanged) // 날짜가 변경되었을 때
                    {
                        bDateTimeChanged = false;
                        iCount = 1000; // 날짜가 변경되었으니 다시 1000회로 초기화.
                        break;
                    }

                    await Task.Delay(100); // 계속 돌면 좀 거시기하니까 0.1초마다 도는 것으로.
                }

                try
                {
                    // 추후 Android Socket을 사용하게 되면 Socket으로 전송.
                    // 지금은 PC 카카오톡으로 전송
                    EarthquakeReportListRes = SelectiveParse(await Comm.Instance.request(
                             url: SiteURI.EarthquakeReportList,
                             method: Comm.METHOD_GET,
                             postOrParamsData: JObject.FromObject(Entity).ToString()
                             ), typeof(Entity.Response.EarthquakeReportList)
                         );
                }
                catch
                {
                    if (ReferenceEquals(EarthquakeReportListRes, null))
                    {
                        EarthquakeReportListRes = new Entity.Response.EarthquakeReportList();
                    }
                }

                iCount--;

                if (bDateTimeChanged)
                {
                    bDateTimeChanged = false;
                    iCount = 1000; // 날짜가 변경되었으니 다시 1000회로 초기화.
                }

                // 하루 86400초를 최대 호출 횟수인 1000으로 나누면 86.4초당 1회 호출해야 하루동안 알맞게 호출할 수 있음.
                // 따라서 86.4의 반올림인 90초마다 반복실행. 
                await Task.Delay(90000);
            }

            // 메서드가 끝나버렸을 경우 로그남겨야 함.
        }
    }
}
