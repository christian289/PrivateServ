using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class RadishWrappingRoll : Member
    {
        public RadishWrappingRoll()
        {
            Name = "김채원";

            BirthDay = new DateTime(2000, 8, 1);

            BirthDayMessage = "쌈무시";

            BirthDayImage = Image.FromFile(ImagePath.RadishWrappingRollBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "쌈무요정",
                "쌈무",
                "째오니",
                "로봇채원",
                "천사소녀",
                "짬무",
                "대천사",
                "채원",
                "쌈아치",
                "코알라",
                "빛나는 쌈무",
                "광군",
                "자몽요정",
                "김자몽"
            };

            Hobby = new List<string>
            {
                "영화 보기",
                "안무 영상 보기",
                "매운 음식 먹기"
            };

            BloodType = "B";

            Height_cm = 164;

            Weight_kg = 42;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[MBC every1] SHOW CHAMPION"
            };

            Company = "울림엔터테인먼트";

            Position = new List<string>
            {
                "리드보컬"
            };

            Color = "챔무, CEE5D5";
        }
    }
}
