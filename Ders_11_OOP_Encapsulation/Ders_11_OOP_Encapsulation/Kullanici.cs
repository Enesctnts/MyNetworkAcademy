﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_OOP_Encapsulation
{
    class Kullanici
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }

        public Kuafor kuafor;

        public Kullanici()
        {
            kuafor = new Kuafor();
        }
       
    }
}
