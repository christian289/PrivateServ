using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonServices.Earthquake.Entity.Request
{
    /// <summary>
    /// 지진해일통보문 목록조회 요청 Entity
    /// </summary>
    public class TsunamiReportList
    {
        /// <summary>
        /// 발표시각(From)
        /// 항목크기 : 8
        /// 샘플데이터 : 20171101
        /// </summary>
        public string fromTmFc { get; set; }

        /// <summary>
        /// 발표시각(To)
        /// 항목크기 : 8
        /// 샘플데이터 : 20171129
        /// </summary>
        public string toTmFc { get; set; }

        /// <summary>
        /// 서비스 키
        /// 항목크기 : 255
        /// 샘플데이터 : 사이트 관리 페이지에서 발급
        /// </summary>
        public string ServiceKey { get; set; }

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
    }
}
