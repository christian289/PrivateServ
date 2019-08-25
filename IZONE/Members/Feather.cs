using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class Feather : Member
    {
        public Feather()
        {
            Name = "이채연";

            BirthDay = new DateTime(2000, 1, 11);

            BirthDayMessage = "깃털시";

            BirthDayImage = Image.FromFile(ImagePath.FeatherBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "깃털",
                ""
            };

            Hobby = new List<string>
            {
                "댄스",
                ""
            };

            BloodType = "A";

            Height_cm = 164;

            Weight_kg = 47;

            BroadCastList = new List<string>
            {
                "프로듀스 48",
                "아이즈원 츄",
                "아이즈원 츄2 비밀친구"
            };

            Words = new List<string>
            {
                "",
                ""
            };

            Position = new List<string>
            {
                "1집 : 메인 댄서"
            };
        }
    }
}
