using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IZONE.Members
{
    public sealed class Frog : Member
    {
        public Frog()
        {
            Name = "김민주";

            BirthDay = new DateTime(2001, 2, 5);

            BirthDayMessage = "개굴시";

            BirthDayImage = Image.FromFile(Application.StartupPath + @"\BirthDayImage\민주.jpg");

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "밍구리",
                "퀸민주",
                "고독한 김민주",
                "애잔한 개구리",
                "개굴아씨",
                "김비율",
                "민주가또",
                "개굴갑",
                "과유연",
                "민주주의",
                "대천사",
                "당대표",
                "오버민주",
                "밍주",
                "청소좀 하지?"
            };

            Hobby = new List<string>
            {
                "영화 보기",
                "사진 찍기",
                "기타 연주"
            };

            BloodType = "AB";

            Height_cm = 166;

            Weight_kg = 45;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄 1",
                "[Mnet] 아이즈원 츄 2 비밀친구",
                "[플레이리스트] 에이틴2"
            };

            Company = "얼반웍스이엔티";

            Position = new List<string>
            {
                "서브보컬",
                "서브래퍼"
            };

            Color = "백설민주, FCFCFC";
        }
    }
}
