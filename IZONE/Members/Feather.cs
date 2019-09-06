using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IZONE.Members
{
    public sealed class Feather : Member
    {
        public Feather()
        {
            Name = "이채연";

            BirthDay = new DateTime(2000, 1, 11);

            BirthDayMessage = "깃털시";

            BirthDayImage_AM = Image.FromFile(Application.StartupPath + @"\BirthDayImage\채연_오전.jpg");

            BirthDayImage_PM = Image.FromFile(Application.StartupPath + @"\BirthDayImage\채연_오후.jpg");

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "깃털채연",
                "째욘",
                "미야와키 채연",
                "깃깅이",
                "어미새",
                "엄마",
                "다섯째",
                "완두콩",
                "두콩이",
                "갓깅이",
                "꾸깃",
                "웅이"
            };

            Hobby = new List<string>
            {
                "요리",
                "안무 창작"
            };

            BloodType = "A";

            Height_cm = 164;

            Weight_kg = 47;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[MBC] 마이 리틀 텔레비전 V2",
                "[Mnet] 니가 알던 내가 아냐 V2",
                "[JTBC] 취향존중 리얼라이프-취존생활"
            };

            Company = "WM엔터테인먼트";

            Position = new List<string>
            {
                "리드보컬",
                "메인댄서"
            };

            Color = "챈메랄드, A7E0E1";
        }
    }
}
