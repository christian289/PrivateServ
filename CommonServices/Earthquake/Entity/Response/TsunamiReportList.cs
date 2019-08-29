namespace CommonServices.Earthquake.Entity.Response
{
    /// <summary>
    /// 지진해일통보문 목록조회 응답 Entity
    /// </summary>
    public class TsunamiReportList
    {
        /// <summary>
        /// 결과코드
        /// 항목크기 : 4
        /// 샘플데이터 : 0000
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 결과메시지
        /// 항목크기 : 50
        /// 샘플데이터 : OK
        /// </summary>
        public string resultMsg { get; set; }

        /// <summary>
        /// 한 페이지 결과 수
        /// 항목크기 : 2
        /// 샘플데이터 : 10
        /// </summary>
        public string numOfRows { get; set; }

        /// <summary>
        /// 페이지 번호
        /// 항목크기 : 5
        /// 샘플데이터 : 1
        /// </summary>
        public string pageNo { get; set; }

        /// <summary>
        /// 전체 결과 수
        /// 항목크기 : 7
        /// 샘플데이터 : 1
        /// </summary>
        public string totalCount { get; set; }

        /// <summary>
        /// 발표
        /// 항목크기 : 31
        /// 샘플데이터 :
        /// 1: [지진해일 주의]
        /// 2: [지진해일 경보]
        /// 3: [지진해일 해제]
        /// (발표종류명 + 발표시간 + '발표')
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 발표종류코드
        /// 항목크기 : 15
        /// 샘플데이터 : 2:200811251313 (발표코드 + 발표시간)
        /// </summary>
        public string code { get; set; }
    }
}
