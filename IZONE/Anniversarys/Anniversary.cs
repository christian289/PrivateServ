using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Anniversarys
{
    public class Anniversary : IGetImage
    {
        private Image _AnniversaryImage;

        public bool BirthDayImageReady { get; set; }

        /// <summary>
        /// 기념일 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 기념일 시
        /// </summary>
        public DateTime Time { get; set; }        

        public Image AnniversaryImage
        {
            get
            {
                BirthDayImageReady = false;
                FlagInit();
                return _AnniversaryImage;
            }
            protected set
            {
                _AnniversaryImage = value;
            }
        }

        public string Announcement { get; set; }

        public Anniversary()
        {
            BirthDayImageReady = true;
        }

        public async void FlagInit()
        {
            await Task.Delay(60000);
            BirthDayImageReady = true;
        }
    }
}
