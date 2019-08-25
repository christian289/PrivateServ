using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class CuteBling : Member
    {
        public CuteBling()
        {
            Name = "야부키 나코";

            BirthDay = new DateTime(2001, 6, 18);

            BirthDayMessage = "나코시";

            BirthDayImage = Image.FromFile(ImagePath.CuteBlingBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "귀염뽀짝",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "UnKnown";

            Height_cm = 149.9;

            Weight_kg = 40;

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
                ""
            };
        }
    }
}
