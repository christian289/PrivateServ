namespace CommonServices.Earthquake.Entity.Response
{
    /// <summary>
    /// 지진통보문조회 응답 Entity
    /// </summary>
    public class EarthquakeReport
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
        /// 지점코드
        /// 항목크기 : 3
        /// 샘플데이터 : 108
        /// 지점코드 108(전국)으로 고정
        /// </summary>
        public string stnId { get; set; }

        /// <summary>
        /// 통보종류
        /// 항목크기 : 1
        /// 샘플데이터 : 3
        /// 2: 국외 지진정보
        /// 3: 국내 지진정보
        /// 5: 국내 지진정보(재통보)
        /// 11: 국내 지진조기경보
        /// 12: 국외 지진조기경보
        /// 13: 조기경보 정밀분석
        /// 14: 지진속보(조기분석)
        /// </summary>
        public string fcTp { get; set; }

        /// <summary>
        /// 지도 이미지
        /// 항목크기 : 400
        /// 샘플데이터 : URL으로 제공(fcTp가 2번 또는 3번일 경우만 제공)
        /// </summary>
        public string img { get; set; }

        /// <summary>
        /// 발표시각(년월일시분)
        /// 항목크기 : 14
        /// 샘플데이터 : 201711260317
        /// </summary>
        public string tmFc { get; set; }

        /// <summary>
        /// 발표 일련번호 (월별)
        /// 항목크기 : 4
        /// 샘플데이터 : 109
        /// </summary>
        public string tmSeq { get; set; }
        
        /// <summary>
        /// 참조번호
        /// 항목크기 : 3
        /// 샘플데이터 : 1
        /// </summary>
        public string cnt { get; set; }

        /// <summary>
        /// 진앙시(년월일시분초)
        /// 항목크기 : 14
        /// 샘플데이터 : 20171126031345
        /// </summary>
        public string tmEqk { get; set; }

        /// <summary>
        /// 진앙시(초 미만)
        /// 항목크기 : 3
        /// 샘플데이터 : 
        /// </summary>
        public string tmMsc { get; set; }

        /// <summary>
        /// 위도(deg.)
        /// 항목크기 : 8
        /// 샘플데이터 : 36.47
        /// </summary>
        public string lat { get; set; }

        /// <summary>
        /// 경도(deg.)
        /// 항목크기 : 8
        /// 샘플데이터 : 124.83
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
        /// 샘플데이터 : 2.9
        /// </summary>
        public string mt { get; set; }

        /// <summary>
        /// 진도
        /// 항목크기 : 1000
        /// 샘플데이터 : 최대진도 I
        /// </summary>
        public string inT { get; set; }

        /// <summary>
        /// 깊이
        /// 항목크기 : 10
        /// 샘플데이터 : 
        /// </summary>
        public string dep { get; set; }

        /// <summary>
        /// 참고사항
        /// 항목크기 : 2000
        /// 샘플데이터 : 예제 참조
        /// </summary>
        public string rem { get; set; }

        /// <summary>
        /// 수정사항
        /// 항목크기 : 1000
        /// 샘플데이터 : 없음
        /// </summary>
        public string cor { get; set; }
    }
}
