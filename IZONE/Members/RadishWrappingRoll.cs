using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class RadishWrappingRoll : Member
    {
        public RadishWrappingRoll()
        {
            Name = "김채원";

            BirthDay = new DateTime(2000, 8, 1);

            BirthDayMessage = "쌈무시";

            BirthDayImage = Image.FromFile(ImagePath.RadishWrappingRollBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "쌈무",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "B";

            Height_cm = 163;

            Weight_kg = 42;

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
                "1집 : 리드 보컬"
            };
        }
    }
}
