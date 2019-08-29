using System;
using System.Collections.Generic;
using System.Drawing;

namespace IZONE.Members
{
    public class Member
    {
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
        /// 생일 시 이미지
        /// </summary>
        public Image BirthDayImage { get; set; }

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

        }

        public int CalculateAge(DateTime BirthDay)
        {
            int age = new int();

            DateTime Today = DateTime.Today;
            age = Today.Year - BirthDay.Year + 1;

            return age;
        }
    }
}
