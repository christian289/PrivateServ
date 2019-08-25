using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class HamsterYurlll : Member
    {
        public HamsterYurlll()
        {
            Name = "조유리";

            BirthDay = new DateTime(2001, 10, 22);

            BirthDayMessage = "율시";

            BirthDayImage = Image.FromFile(ImagePath.HamsterYurlllBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "햄찌율",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "AB";

            Height_cm = 160;

            Weight_kg = 45;

            BroadCastList = new List<string>
            {
                "Mnet 프로듀스 48",
                "Mnet 아이즈원 츄 1",
                "Mnet 아이즈원 츄 2 비밀친구"
            };

            Words = new List<string>
            {
                "",
                ""
            };

            Position = new List<string>
            {
                "한국 1집 라비앙로즈 : 메인 보컬",
                "한국 2집 비올레타 : 메인 보컬"
            };
        }
    }
}
