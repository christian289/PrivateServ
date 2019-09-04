﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZONE.Anniversarys
{
    public class Debut : Anniversary
    {
        public Debut()
        {
            Name = "데뷔";
            Time = new DateTime(2018, 10, 29);
            BirthDayImageReady = true;
            AnniversaryImage = Image.FromFile(Application.StartupPath + @"\AnniversarysImage\Debut.jpg");
            Announcement = "데뷔시";
        }
    }
}