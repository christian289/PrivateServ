using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Puppy : Member
    {
        public Puppy()
        {
            Name = "안유진";

            BirthDay = new DateTime(2003, 9, 1);

            BirthDayMessage = "율시";

            BirthDayImage = Image.FromFile(ImagePath.PuppyBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "댕댕이",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "A";

            Height_cm = 168;

            Weight_kg = 48;

            BroadCastList = new List<string>
            {
                "Mnet 프로듀스 48",
                "Mnet 아이즈원 츄 1",
                "Mnet 아이즈원 츄 2 비밀친구",
                "MBC 복면가왕 - 고드름"
            };

            Words = new List<string>
            {
                "",
                ""
            };

            Position = new List<string>
            {
                "한국 1집 라비앙로즈 : ",
                "한국 2집 비올레타 : "
            };
        }
    }
}
