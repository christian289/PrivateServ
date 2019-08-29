using System;
using System.Collections.Generic;
using System.Drawing;

namespace IZONE.Members
{
    public class Puppy : Member
    {
        public Puppy()
        {
            Name = "안유진";

            BirthDay = new DateTime(2003, 9, 1);

            BirthDayMessage = "윶시";

            BirthDayImage = Image.FromFile(ImagePath.PuppyBirthDayImg);

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "안유딩",
                "안댕댕",
                "윶깅이",
                "뉴깅이",
                "렌즈소녀",
                "광고여신",
                "MC유진",
                "장꾸댕댕이",
                "큰 댕댕이",
                "안콩알",
                "콩주님",
                "스타쉽의 공주님",
                "안유능",
                "비글유진",
                "제거유진",
                "안유델",
                "얼짱유진",
                "미스 마리댕"
            };

            Hobby = new List<string>
            {
                "줄넘기",
                "달리기"
            };

            BloodType = "A";

            Height_cm = 168;

            Weight_kg = 48;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[MBC] 미스터리 음악쇼 복면가왕 - 고드름",
                "[JTBC] 아이돌룸",
                "[tvN] 호구들의 감빵생활",
                "[MBC] 마이 리틀 텔레비전 V2"
            };

            Company = "스타쉽엔터테인먼트";

            Position = new List<string>
            {
                "리드보컬",
                "리드댄서"
            };

            Color = "블루지니, 567ACE";
        }
    }
}
