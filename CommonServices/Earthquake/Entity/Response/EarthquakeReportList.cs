using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.Earthquake.Entity.Response
{
    /// <summary>
    /// 지진통보문 목록조회 응답 Entity
    /// </summary>
    public class EarthquakeReportList
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
        /// 샘플데이터 : 3
        /// </summary>
        public string totalCount { get; set; }

        /// <summary>
        /// 발표
        /// 항목크기 : 31
        /// 샘플데이터 : 
        /// 2: 국외 지진정보
        /// 3: 국내 지진정보
        /// 5: 국내 지진정보(수정)
        /// 11: 국내 지진조기경보
        /// 12: 국외 지진조기경보
        /// 13: 조기경보 정밀분석
        /// 14: 지진속보(조기분석)
        /// 항목구성(발표종류명 + 발표시간 + '발표')
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 발표종류코드
        /// 항목크기 : 15
        /// 샘플데이터 : 3:201510110059 [발표코드 + 발표시간(년월일시분)]
        /// </summary>
        public string code { get; set; }
    }
}
