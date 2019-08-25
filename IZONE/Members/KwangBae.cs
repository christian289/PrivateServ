using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class KwangBae : Member
    {
        public KwangBae()
        {
            Name = "강혜원";

            BirthDay = new DateTime(1999, 7, 5);

            BirthDayMessage = "광배시";

            BirthDayImage = Image.FromFile(ImagePath.KwangBaeBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "광배",
                ""
            };

            Hobby = new List<string>
            {
                "먹방",
                ""
            };

            BloodType = "B";

            Height_cm = 163;

            Weight_kg = 43;

            BroadCastList = new List<string>
            {
                "프로듀스 48",
                "아이즈원 츄",
                "아이즈원 츄2 비밀친구"
            };

            Words = new List<string>
            {
                "너 내 동료가 되어라.",
                ""
            };

            Position = new List<string>
            {
                "래퍼"
            };
        }
    }
}
