﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Review
    {
        string Comment { get; set; }


        Klant Klant { get; set; }
        Artikel Artikel { get; set; }
    }
}