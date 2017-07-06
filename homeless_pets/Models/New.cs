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

        [Required(ErrorMessage = "Пожалуйста, введите заголовок для новости")]
        [Display(Name = "Заголовок:")]
        public string Header { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите содержание для новости")]
        [Display(Name = "Содержание:")]
        public string Body { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Пожалуйста, введите дату ")]
        [Display(Name = "Дата:")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Пожалуйста, напишите краткую информацию для новости")]
        [Display(Name = "Краткая информация:")]
        public string Short { get; set; }
    }
}