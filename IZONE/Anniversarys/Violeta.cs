using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZONE.Anniversarys
{
    public class Violeta : Anniversary
    {
        public Violeta()
        {
            Name = "대한민국 2집 비올레타 발매 기념";
            Time = new DateTime(2019, 4, 21);
            BirthDayImageReady = true;
            //AnniversaryImage = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Violeta.jpg");
            AnniversaryImage = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Debut.jpg");
            Announcement = "비올시";
        }
    }
}
