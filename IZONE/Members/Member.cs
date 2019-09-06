using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Member
    {
        private Image _BirthDayImage_AM;
        private Image _BirthDayImage_PM;

        /// <summary>
        /// 성명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 생년월일
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// 생일 시 메세지
        /// </summary>
        public string BirthDayMessage { get; set; }

        /// <summary>
        /// 생일 시 이미지(오전)
        /// </summary>
        public Image BirthDayImage_AM
        {
            get
            {
                BirthDayImageReady_AM = false;
                FlagInit(true);
                return _BirthDayImage_AM;
            }
            protected set
            {
                _BirthDayImage_AM = value;
            }
        }

        /// <summary>
        /// 생일 시 이미지(오후)
        /// </summary>
        public Image BirthDayImage_PM
        {
            get
            {
                BirthDayImageReady_PM = false;
                FlagInit(false);
                return _BirthDayImage_PM;
            }
            protected set
            {
                _BirthDayImage_PM = value;
            }
        }

        /// <summary>
        /// 오전 이미지 가져감 여부
        /// </summary>
        public bool BirthDayImageReady_AM { get; set; }

        /// <summary>
        /// 오후 이미지 가져감 여부
        /// </summary>
        public bool BirthDayImageReady_PM { get; set; }

        /// <summary>
        /// 한국 기준 나이
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 별명
        /// </summary>
        public List<string> Alias { get; set; }

        /// <summary>
        /// 취미
        /// </summary>
        public List<string> Hobby { get; set; }

        /// <summary>
        /// 혈액형
        /// </summary>
        public string BloodType { get; set; }

        /// <summary>
        /// 키(단위 : 센티미터)
        /// </summary>
        public double Height_cm { get; set; }

        /// <summary>
        /// 몸무게(단위 : 킬로그램)
        /// </summary>
        public double Weight_kg { get; set; }

        /// <summary>
        /// 방송 참여 목록
        /// </summary>
        public List<string> BroadCastList { get; set; }

        /// <summary>
        /// 소속사
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 포지션
        /// </summary>
        public List<string> Position { get; set; }

        /// <summary>
        /// 상징색
        /// </summary>
        public string Color { get; set; }

        public Member()
        {
            BirthDayImageReady_AM = true;
            BirthDayImageReady_PM = true;
        }

        public int CalculateAge(DateTime BirthDay)
        {
            DateTime Today = DateTime.Today;
            int age = Today.Year - BirthDay.Year + 1;

            return age;
        }

        /// <summary>
        /// 이미지 가져감 플래그
        /// </summary>
        /// <param name="AMPM">true: 오전, false: 오후</param>
        public async void FlagInit(bool AMPM)
        {
            await Task.Delay(60000);

            if (AMPM)
            {
                BirthDayImageReady_AM = true;
            }
            else
            {
                BirthDayImageReady_AM = true;
            }
        }
    }
}
