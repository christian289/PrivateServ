using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class HamsterYurlll : Member
    {
        public HamsterYurlll()
        {
            Name = "조유리";

            BirthDay = new DateTime(2001, 10, 22);

            BirthDayMessage = "율시";

            BirthDayImage = Image.FromFile(ImagePath.HamsterYurlllBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "조율",
                "조구리",
                "댕찌",
                "작댕",
                "햄찌장군",
                "햄찌율",
                "조감자",
                "3초갑",
                "부산상여자",
                "인소인간",
                "하랑",
                "조치타",
                "조댕찌",
                "조희지"
            };

            Hobby = new List<string>
            {
                "만화책 읽기",
                "공포영화 보기",
                "드럼 연주",
                "피아노 연주",
                "가창"
            };

            BloodType = "AB";

            Height_cm = 160;

            Weight_kg = 45;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구"
            };

            Company = "스톤뮤직엔터테인먼트";

            Position = new List<string>
            {
                "메인보컬"
            };

            Color = "율렌지, F3AA51";
        }
    }
}
