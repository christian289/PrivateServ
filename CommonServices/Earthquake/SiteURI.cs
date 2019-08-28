using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.Earthquake
{
    /// <summary>
    /// 서비스 API Endpoint URI 주소
    /// </summary>
    internal static class SiteURI
    {
        /// <summary>
        /// 지진통보문조회 URI
        /// </summary>
        internal static string EarthquakeReport = "http://newsky2.kma.go.kr/service/ErthqkInfoService/EarthquakeReport";

        /// <summary>
        /// 지진정보문목록조회 URI
        /// </summary>
        internal static string EarthquakeReportList = "http://newsky2.kma.go.kr/service/ErthqkInfoService/EarthquakeReportList";

        /// <summary>
        /// 지진해일통보문조회 URI
        /// </summary>
        internal static string TsunamiReport = "http://newsky2.kma.go.kr/service/ErthqkInfoService/TsunamiReport";

        /// <summary>
        /// 지진해일통보문목록조회 URI
        /// </summary>
        internal static string TsunamiReportList = "http://newsky2.kma.go.kr/service/ErthqkInfoService/TsunamiReportList";
    }
}
