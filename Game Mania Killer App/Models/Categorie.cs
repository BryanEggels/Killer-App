﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_Mania_Killer_App.Models
{
    public class Categorie
    {
        int ID { get; set; }
        string Naam { get; set; }
        int ParentID { get; set; }

        List<Artikel> Artikelen { get; set; }
    }
}