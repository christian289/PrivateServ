using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IZONE.Members
{
    public sealed class KwangBae : Member
    {
        public KwangBae()
        {
            Name = "강혜원";

            BirthDay = new DateTime(1999, 7, 5);

            BirthDayMessage = "광배시";

            BirthDayImage_AM = Image.FromFile(Application.StartupPath + @"\BirthDayImage\혜원_오전.jpg");

            BirthDayImage_PM = Image.FromFile(Application.StartupPath + @"\BirthDayImage\혜원_오후.jpg");

            Age = CalculateAge(BirthDay);

            Alias = new List<string>
            {
                "광배",
                "광순이",
                "강짱",
                "세정맛 소혜",
                "지옥에서 온 청순 래퍼",
                "기어갑",
                "미나미맘",
                "강햄찌",
                "야먹",
                "팡IdH",
                "종료요정",
                "강코랄",
                "공항여포",
                "셋째",
                "형",
                "강씨",
                "광토그래퍼",
                "얼음공주",
                "스킨십 빌런",
                "光北"
            };

            Hobby = new List<string>
            {
                "애니 감상",
                "드라마 감상",
                "피아노 연주"
            };

            BloodType = "B";

            Height_cm = 163;

            Weight_kg = 43;

            BroadCastList = new List<string>
            {
                "[Mnet] 프로듀스 48",
                "[Mnet] 아이즈원 츄",
                "[Mnet] 아이즈원 츄 비밀친구",
                "[MBC] 마이 리틀 텔레비전 V2"
            };

            Company = "에잇디 크리에이티브";

            Position = new List<string>
            {
                "리드래퍼",
                "서브보컬"
            };

            Color = "강코랄, DB706C";
        }
    }
}
