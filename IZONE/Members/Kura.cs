using System;
using System.Collections.Generic;
using System.Drawing;

namespace IZONE.Members
{
    public class Kura : Member
    {
        public Kura()
        {
            Name = "미야와키 사쿠라";

            BirthDay = new DateTime(1998, 3, 19);

            BirthDayMessage = "쿠라시";

            BirthDayImage = Image.FromFile(ImagePathObj.KuraBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "사쿠쨩",
                "사쿠라땅",
                "꾸라",
                "샄",
                "이쿠라",
                "걸꾸라시",
                "미야와키상",
                "민왁희",
                "하카타 깃털주먹",
                "둘째",
                "이치방언니",
                "야망있는찐따",
                "겜꾸라",
                "김꾸라"
            };

            Hobby = new List<string>
            {
                "게임",
                "재미있는 그림 그리기"
            };

            BloodType = "A";

            Height_cm = 163;

            Weight_kg = 46;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[Olive] 모두의 주방",
                "[니혼TV] 줄서는 법률 상담소"
            };

            Company = "AKS";

            Position = new List<string>
            {
                "서브보컬"
            };

            Color = "벚꽃핑크, F1D2E7";
        }
    }
}
