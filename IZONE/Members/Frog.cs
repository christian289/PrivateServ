using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Frog : Member
    {
        public Frog()
        {
            Name = "김민주";

            BirthDay = new DateTime(2001, 2, 5);

            BirthDayMessage = "민주시";

            BirthDayImage = Image.FromFile(ImagePath.FrogBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "개굴",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "AB";

            Height_cm = 165;

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
                ""
            };
        }
    }
}
