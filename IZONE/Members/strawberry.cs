using System;
using System.Collections.Generic;
using System.Drawing;

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
                "히이쨩",
                "월클토미",
                "홍다희",
                "히이노스케",
                "오이시",
                "빵토미",
                "꿈과 희망",
                "찹쌀떡",
                "토미",
                "히토끼",
                "히피치",
                "히도미",
                "딸기토미",
                "댄싱복숭아",
                "히토마",
                "히찬호",
                "히로콜리",
                "빡토미"
            };

            Hobby = new List<string>
            {
                "독서",
                "아크로바틱"
            };

            BloodType = "A";

            Height_cm = 158;

            Weight_kg = 44.4;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[RADIO BERRY] Honda Hitomi Heat Is On",
                "[RADIO BERRY] NEZAS presents IZ*ONE 本田仁美のWorld Get You"
            };

            Company = "AKS";

            Position = new List<string>
            {
                "서브보컬"
            };

            Color = "토미베이지, F1C3AA";
        }
    }
}
