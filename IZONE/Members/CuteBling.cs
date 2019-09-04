using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IZONE.Members
{
    public sealed class CuteBling : Member
    {
        public CuteBling()
        {
            Name = "야부키 나코";

            BirthDay = new DateTime(2001, 6, 18);

            BirthDayMessage = "나코시";

            BirthDayImage = Image.FromFile(Application.StartupPath + @"\BirthDayImage\나코.jpg");

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "귀염뽀짝요정",
                "나북희",
                "나코나코땅땅",
                "김나코",
                "나코나코니",
                "낰",
                "하카타 꿀주먹",
                "야부 키나코",
                "야부키 잔디",
                "담담이"
            };

            Hobby = new List<string>
            {
                "영화 보기",
                "무쌍커풀 만들기",
                "고속 머리땋기"
            };

            BloodType = "UnKnown";

            Height_cm = 149.9;

            Weight_kg = 40;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구"
            };

            Company = "AKS";

            Position = new List<string>
            {
                "서브보컬"
            };

            Color = "나부키 하늘, B7D3E9";
        }
    }
}
