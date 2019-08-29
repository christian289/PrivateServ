namespace CommonServices.Earthquake.Entity.Response
{
    /// <summary>
    /// 지진해일통보문조회 응답 Entity
    /// </summary>
    public class TsunamiReport
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
        /// 발표관서
        /// 항목크기 : 3
        /// 샘플데이터 108
        /// </summary>
        public string stnId { get; set; }

        /// <summary>
        /// 발표종류
        /// 항목크기 : 1
        /// 샘플데이터 : 2
        /// 1: 지진해일 주의보
        /// 2: 지진해일 경보
        /// 3: 지진해일 해제
        /// </summary>
        public string fcTp { get; set; }

        /// <summary>
        /// 발표시각 (년월일시분)
        /// 항목크기 : 14
        /// 샘플데이터 : 200811251313
        /// </summary>
        public string tmFc { get; set; }

        /// <summary>
        /// 참조번호
        /// 항목크기 : 3
        /// 샘플데이터 : 0
        /// </summary>
        public string cnt { get; set; }

        /// <summary>
        /// 발효시각 (년월일시분)
        /// 항목크기 : 14
        /// 샘플데이터 : 200811251313
        /// </summary>
        public string tmEf { get; set; }

        /// <summary>
        /// 해당지역
        /// 항목크기 : 2000
        /// 샘플데이터 : 예제 참조
        /// </summary>
        public string reg { get; set; }

        /// <summary>
        /// 내용
        /// 항목크기 : 2000
        /// 샘플데이터 : 예제 참조
        /// </summary>
        public string ann { get; set; }

        /// <summary>
        /// 진앙시 (년월일시분)
        /// 항목크기 : 14
        /// 샘플데이터 : 200810311347
        /// </summary>
        public string tmEqk { get; set; }

        /// <summary>
        /// 진앙 위도(deg)
        /// 항목크기 : 8
        /// 샘플데이터 : 35.1
        /// </summary>
        public string lat { get; set; }

        /// <summary>
        /// 진앙 경도(deg)
        /// 항목크기 : 8
        /// 샘플데이터 : 130.4
        /// </summary>
        public string lon { get; set; }

        /// <summary>
        /// 진앙 위치
        /// 항목크기 : 200
        /// 샘플데이터 : 예제 참조
        /// </summary>
        public string loc { get; set; }

        /// <summary>
        /// 규모
        /// 항목크기 : 3
        /// 샘플데이터 : 2.1
        /// </summary>
        public string mt { get; set; }

        /// <summary>
        /// 당부사항
        /// 항목크기 : 2000
        /// 샘플데이터 : 예제 참조
        /// </summary>
        public string rem { get; set; }
    }
}
