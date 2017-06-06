using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homeless_pets.Models
{
    public class Pet
    {
        public long PetID { get; set; }
        public string tel { get; set; }
        public bool Сastrated { get; set; }
        public string Type { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
        public string ConditionsAccept { get; set; }
        public string Age { get; set; }
        public string Wool { get; set; }
        public string Colour { get; set; }
        public string Character { get; set; }
        public string Food { get; set; }
        public bool WC { get; set; }
        public string CheckedOut { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }
    }
}