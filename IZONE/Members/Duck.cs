using System;
using System.Collections.Generic;
using System.Drawing;

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
                "오리쉑",
                "달콤언니",
                "최허세",
                "옌",
                "모태 끼쟁이",
                "콜라소녀",
                "하이예나",
                "예감독",
                "황토방 최사장님",
                "북경오리",
                "예나벨",
                "11번 친구",
                "막둥오리"
            };

            Hobby = new List<string>
            {
                "만화책 읽기",
                "영화 보기",
                "인형 뽑기",
                "게임"
            };

            BloodType = "A";

            Height_cm = 163;

            Weight_kg = 45;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[tvN] 호구들의 깜빵생활",
                "[SBS 파워 FM] 배성재의 TEN"
            };

            Company = "위에화엔터테인먼트";

            Position = new List<string>
            {
                "리드보컬, 리드댄서, 래퍼"
            };

            Color = "옌로우, FCF695";
        }
    }
}
