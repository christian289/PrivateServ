using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Kura : Member
    {
        public Kura()
        {
            Name = "미야와키 사쿠라";

            BirthDay = new DateTime(1998, 3, 19);

            BirthDayMessage = "쿠라시";

            BirthDayImage = Image.FromFile(ImagePath.KuraBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "꾸라",
                ""
            };

            Hobby = new List<string>
            {
                "게임",
                ""
            };

            BloodType = "A";

            Height_cm = 163;

            Weight_kg = 46;

            BroadCastList = new List<string>
            {
                "모두의 주방",
                ""
            };

            Words = new List<string>
            {
                "",
                ""
            };

            Position = new List<string>
            {

            };
        }
    }
}
