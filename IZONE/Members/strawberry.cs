using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Strawberry : Member
    {
        public Strawberry()
        {
            Name = "혼다 히토미";

            BirthDay = new DateTime(2001, 10, 6);

            BirthDayMessage = "힡시";

            BirthDayImage = Image.FromFile(ImagePath.StrawberryBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "월클",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "A";

            Height_cm = 158;

            Weight_kg = 44.4;

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
