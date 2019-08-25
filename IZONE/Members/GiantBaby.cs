using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class GiantBaby : Member
    {
        public GiantBaby()
        {
            Name = "장원영";

            BirthDay = new DateTime(2004, 8, 31);

            BirthDayMessage = "원영시";

            BirthDayImage = Image.FromFile(ImagePath.GiantBabyBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "자이언트 베이비",
                "102"
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "O";

            Height_cm = 169.2;

            Weight_kg = 47;

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
                "한국 1집 라비앙로즈 : 센터",
                "한국 2집 비올레타 : 센터"
            };
        }
    }
}
