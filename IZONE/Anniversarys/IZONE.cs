using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZONE.Anniversarys
{
    public class IZONE : Anniversary
    {
        public IZONE()
        {
            Name = "아이즈원";

            Time = new DateTime(2018, 12, 1);

            AnniversaryImage_AM = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Debut_오전.jpg");

            AnniversaryImage_PM = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Debut_오후.jpg");

            Announcement = "앚즈시";
        }
    }
}
