using System;
using System.Collections.Generic;
using System.Drawing;

namespace IZONE.Members
{
    public class GiantBaby : Member
    {
        public GiantBaby()
        {
            Name = "장원영";

            BirthDay = new DateTime(2004, 8, 31);

            BirthDayMessage = "원영시";

            BirthDayImage = Image.FromFile(ImagePath.GiantBabyBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "워뇨",
                "워녕이",
                "녕깅이",
                "102",
                "원콩이",
                "아기토끼",
                "녕토끼",
                "녕데렐라",
                "이촌동 꿀주먹",
                "자이언트 베이비",
                "모태 센터",
                "노벨 아이돌상",
                "장바페",
                "장센",
                "만년돌",
                "장비키",
                "망나뇽",
                "밥파고",
                "장원일",
                "워뇨봇",
                "사랑둥이"
            };

            Hobby = new List<string>
            {
                "언니들하고 놀기",
                "외국어"
            };

            BloodType = "O";

            Height_cm = 169.2;

            Weight_kg = 47;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[JTBC] 한끼줍쇼"
            };

            Company = "스타쉽엔터테인먼트";

            Position = new List<string>
            {
                "센터",
                "서브보컬"
            };

            Color = "캔디핑크10, D9598C";
        }
    }
}
