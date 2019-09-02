using System.Windows.Forms;

namespace IZONE
{
    public class ImagePath
    {
        public string DefaultPath;
        public string CaptainRabbitBirthDayImg;
        public string KuraBirthDayImg;
        public string KwangBaeBirthDayImg;
        public string DuckBirthDayImg;
        public string FeatherBirthDayImg;
        public string RadishWrappingRollBirthDayImg;
        public string FrogBirthDayImg;
        public string CuteBlingBirthDayImg;
        public string StrawberryBirthDayImg;
        public string HamsterYurlllBirthDayImg;
        public string PuppyBirthDayImg;
        public string GiantBabyBirthDayImg;

        public ImagePath()
        {            
        }

        public void Init()
        {
            DefaultPath = Application.StartupPath + @"\BirthDay";
            CaptainRabbitBirthDayImg = DefaultPath + @"\은비.jpg";
            KuraBirthDayImg = DefaultPath + @"\사쿠라.jpg";
            KwangBaeBirthDayImg = DefaultPath + @"\혜원.jpg";
            DuckBirthDayImg = DefaultPath + @"\예나.jpg";
            FeatherBirthDayImg = DefaultPath + @"\채연.jpg";
            RadishWrappingRollBirthDayImg = DefaultPath + @"\채원.jpg";
            FrogBirthDayImg = DefaultPath + @"\민주.jpg";
            CuteBlingBirthDayImg = DefaultPath + @"\나코.jpg";
            StrawberryBirthDayImg = DefaultPath + @"\히토미.jpg";
            HamsterYurlllBirthDayImg = DefaultPath + @"\유리.jpg";
            PuppyBirthDayImg = DefaultPath + @"\유진.jpg";
            GiantBabyBirthDayImg = DefaultPath + @"\원영.jpg";
        }
    }
}
