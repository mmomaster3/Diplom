using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homeless_pets.Models
{
    public class New
    {
        [HiddenInput(DisplayValue = false)]
        public long NewID { get; set; }

        [Display(Name = "Заголовок:")]
        public string Header { get; set; }

        [Display(Name = "Тело:")]
        public string Body { get; set; }

        [Display(Name = "Дата:")]
        public DateTime Date { get; set; }

        [Display(Name = "Краткая информация:")]
        public string Short { get; set; }
    }
}