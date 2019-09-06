using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Anniversarys
{
    public class Anniversary
    {
        private Image _AnniversaryImage_AM;
        private Image _AnniversaryImage_PM;

        public bool AnniversaryImageReady_AM { get; set; }

        public bool AnniversaryImageReady_PM { get; set; }

        /// <summary>
        /// 기념일 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 기념일 시
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 오전 기념일 이미지
        /// </summary>
        public Image AnniversaryImage_AM
        {
            get
            {
                AnniversaryImageReady_AM = false;
                FlagInit(true);
                return _AnniversaryImage_AM;
            }
            protected set
            {
                _AnniversaryImage_AM = value;
            }
        }

        /// <summary>
        /// 오후 기념일 이미지
        /// </summary>
        public Image AnniversaryImage_PM
        {
            get
            {
                AnniversaryImageReady_PM = false;
                FlagInit(false);
                return _AnniversaryImage_PM;
            }
            protected set
            {
                _AnniversaryImage_PM = value;
            }
        }

        public string Announcement { get; set; }

        public Anniversary()
        {
            AnniversaryImageReady_AM = true;
            AnniversaryImageReady_PM = true;
        }

        /// <summary>
        /// 이미지 가져감 플래그 초기화
        /// </summary>
        /// <param name="AMPM">true: 오전, false: 오후</param>
        public async void FlagInit(bool AMPM)
        {
            await Task.Delay(60000);

            if (AMPM)
            {
                AnniversaryImageReady_AM = true;
            }
            else
            {
                AnniversaryImageReady_PM = true;
            }
        }
    }
}
