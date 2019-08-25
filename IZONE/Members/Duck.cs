using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Duck : Member
    {
        public Duck()
        {
            Name = "최예나";

            BirthDay = new DateTime(1999, 9, 29);

            BirthDayMessage = "옌시";

            BirthDayImage = Image.FromFile(ImagePath.DuckBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "오리",
                ""
            };

            Hobby = new List<string>
            {
                "",
                ""
            };

            BloodType = "A";

            Height_cm = 163;

            Weight_kg = 45;

            BroadCastList = new List<string>
            {
                "프로듀스 48",
                "아이즈원 츄",
                "아이즈원 츄2 비밀친구",
                "호구들의 깜빵생활"
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
