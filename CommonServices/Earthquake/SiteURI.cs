namespace CommonServices.Earthquake
{
    /// <summary>
    /// 서비스 API Endpoint URI 주소
    /// </summary>
    internal static class SiteURI
    {
        internal static string EarthquakeServiceDefaultPath = "http://newsky2.kma.go.kr/service/ErthqkInfoService";

        /// <summary>
        /// 지진통보문조회 URI
        /// </summary>
        internal static string EarthquakeReport = EarthquakeServiceDefaultPath + "/EarthquakeReport";

        /// <summary>
        /// 지진정보문목록조회 URI
        /// </summary>
        internal static string EarthquakeReportList = EarthquakeServiceDefaultPath + "/EarthquakeReportList";

        /// <summary>
        /// 지진해일통보문조회 URI
        /// </summary>
        internal static string TsunamiReport = EarthquakeServiceDefaultPath + "/TsunamiReport";

        /// <summary>
        /// 지진해일통보문목록조회 URI
        /// </summary>
        internal static string TsunamiReportList = EarthquakeServiceDefaultPath + "/TsunamiReportList";
    }
}
