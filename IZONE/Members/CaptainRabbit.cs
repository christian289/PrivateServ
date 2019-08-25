using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    /// <summary>
    /// 대장 토끼
    /// </summary>
    public class CaptainRabbit : Member
    {
        public CaptainRabbit()
        {
            Name = "권은비";

            BirthDay = new DateTime(1995, 9, 27);

            BirthDayMessage = "은비시";

            BirthDayImage = Image.FromFile(ImagePath.CaptainRabbitBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "대장토끼",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "A";

            Height_cm = 160.0;

            Weight_kg = 46.0;

            BroadCastList = new List<string>
            {
                "취존생활",
                ""
            };

            Words = new List<string>
            {
                "땡모땡모",
                ""
            };

            Position = new List<string>
            {
                "리더"
            };
        }
    }
}
