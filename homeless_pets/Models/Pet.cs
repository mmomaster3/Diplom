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


        //[Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение для цены")]
        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        [Display(Name = "Телефон:")]
        public string tel { get; set; }

        [Required(ErrorMessage = "Пожалуйста, отметьте состояние репродуктивных органов животного")]
        [Display(Name = "Кастрирован/Стерилизована:")]
        public bool Сastrated { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите тип животного")]
        [Display(Name = "Тип:")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Пожалуйста, отметьте пол животного")]
        [Display(Name = "Пол:")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Пожалуйста, придумайте кличку для животного")]
        [Display(Name = "Кличка:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите условия приёма питомца")]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Условия приёма:")]
        public string ConditionsAccept { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите примерный возраст животного. Например \"около года\"")]
        [Display(Name = "Возраст")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Пожалуйста, напишите тип шерсти животного")]
        [Display(Name = "Тип шерсти:")]
        public string Wool { get; set; }

        [Required(ErrorMessage = "Пожалуйста, напишите окрас шерсти или цвет кожи животного")]
        [Display(Name = "Преимущественный окрас:")]
        public string Colour { get; set; }

        [Required(ErrorMessage = "Пожалуйста, опишите характер животного")]
        [Display(Name = "Характер:")]
        public string Character { get; set; }

        [Required(ErrorMessage = "Пожалуйста, напишите чем кормить животное")]
        [Display(Name = "Кормление:")]
        public string Food { get; set; }

        [Required(ErrorMessage = "Пожалуйста, отметьте приручено ли животное к лотку")]
        [Display(Name = "Приучен к лотку:")]
        public bool WC { get; set; }

        [Required(ErrorMessage = "Пожалуйста, отметьте проделанные тесты для проверки здоровья животного, рекомендуется в формате" + @"<ul><li>тест</li></ul>")]
        [Display(Name = "Обработка и уход:")]
        public string CheckedOut { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите адрес передерживания животного")]
        [Display(Name = "Адрес:")]
        public string Address { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Изображения")]
        public string Img { get; set; }
    }
}