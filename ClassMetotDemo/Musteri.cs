using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }

        public Musteri(int id, string ad, string soyad, string email) 
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Email = email;
        }
    }

}
