using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace homeless_pets.Models
{
    public class Pet
    {
        [DataType(DataType.PhoneNumber)]
        [HiddenInput(DisplayValue = false)]
        public long PetID { get; set; }

        [Display(Name = "Телефон:")]
        public string tel { get; set; }

        [Display(Name = "Кастрирован/Стерилизована:")]
        public bool Сastrated { get; set; }

        [Display(Name = "Тип:")]
        public string Type { get; set; }

        [Display(Name = "Пол:")]
        public bool Gender { get; set; }

        [Display(Name = "Имя:")]
        public string Name { get; set; }

        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Условия приёма:")]
        public string ConditionsAccept { get; set; }

        [Display(Name = "Возраст")]
        public string Age { get; set; }

        [Display(Name = "Тип шерсти:")]
        public string Wool { get; set; }

        [Display(Name = "Преимущественный окрас:")]
        public string Colour { get; set; }

        [Display(Name = "Характер:")]
        public string Character { get; set; }

        [Display(Name = "Кормление:")]
        public string Food { get; set; }

        [Display(Name = "Приучен к лотку:")]
        public bool WC { get; set; }

        [Display(Name = "Обработка и уход:")]
        public string CheckedOut { get; set; }

        [Display(Name = "Адрес:")]
        public string Address { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Изображения")]
        public string Img { get; set; }
    }
}