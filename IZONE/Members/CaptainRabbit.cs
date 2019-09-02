using System;
using System.Collections.Generic;
using System.Drawing;

namespace IZONE.Members
{
    /// <summary>
    /// 대장 토끼
    /// </summary>
    public class CaptainRabbit : Member
    {
        public CaptainRabbit()
        {
            Name = "권은비";

            BirthDay = new DateTime(1995, 9, 27);

            BirthDayMessage = "은비시";

            BirthDayImage = Image.FromFile(ImagePathObj.CaptainRabbitBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "대장토끼",
                "관장님",
                "깝은비",
                "권셀럽",
                "성산동 피주먹",
                "권팀장",
                "권선배",
                "작소토",
                "권또청",
                "권또쳌",
                "권또레",
                "권판넬",
                "거능비",
                "궈능비",
                "맏내",
                "첫째",
                "권버벅",
                "금비",
                "비비",
                "녹비",
                "은발장",
                "핑크돼지",
                "땡모"
            };

            Hobby = new List<string>
            {
                "영화 보기",
                "글씨 쓰기",
                "쇼핑",
                "독서",
                "악기 연주"
            };

            BloodType = "A";

            Height_cm = 160.0;

            Weight_kg = 46.0;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 - 비밀친구",
                "[JTBC] 취향존중 리얼라이프-취존생활"
            };

            Company = "울림엔터테인먼트";

            Position = new List<string>
            {
                "리더, 리드보컬, 메인댄서"
            };

            Color = "수놓은 별빛, BBB0DC";
        }
    }
}
