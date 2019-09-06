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

            Time = new DateTime(2019, 4, 1);

            AnniversaryImage_AM = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Violeta_오전.jpg");

            AnniversaryImage_PM = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Violeta_오후.jpg");

            Announcement = "비올시";
        }
    }
}
