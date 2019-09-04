using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE
{
    public interface IGetImage
    {
        /// <summary>
        /// 이미지 가져감 여부
        /// </summary>
        bool BirthDayImageReady { get; set; }

        void FlagInit();
    }
}
