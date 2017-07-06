using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace homeless_pets.Models
{
    public class BDactions
    {
        PetsContext context;

        public BDactions()
        {
            context = new PetsContext();
        }
        //сохраниение животных
        public void SavePet(Pet pet, HttpPostedFileBase[] images)
        {
            string pathsToImgs = "";
            if (images != null && images.All(el => el != null))
            {
                foreach (var img in images)
                {
                    string pathToImg = @"Images/" + RandomString(10) + img.FileName;
                    img.SaveAs(Path.Combine(HttpContext.Current.Server.MapPath("~"), pathToImg));
                    pathsToImgs += "/" + pathToImg + ';';
                }
            }



            if (pet.PetID == 0)
            {

                if (images != null && images.All(el => el != null))
                {
                    pet.Img = pathsToImgs;
                }

                context.Pets.Add(pet);
            }
            else
            {



                Pet petInBD = context.Pets.Find(pet.PetID);
                if (petInBD != null)
                {
                    pathsToImgs += pet.Img;
                    pathsToImgs = pathsToImgs.Replace(";;", ";");

                    petInBD.Name = pet.Name;
                    petInBD.Address = pet.Address;
                    petInBD.Age = pet.Age;
                    petInBD.Character = pet.Character;
                    petInBD.CheckedOut = pet.CheckedOut;
                    petInBD.Colour = pet.Colour;
                    petInBD.ConditionsAccept = pet.ConditionsAccept;
                    petInBD.Food = pet.Food;
                    petInBD.Gender = pet.Gender;
                    petInBD.Img = pathsToImgs;
                    petInBD.tel = pet.tel;
                    petInBD.Type = pet.Type;
                    petInBD.WC = pet.WC;
                    petInBD.Wool = pet.Wool;
                    petInBD.Сastrated = pet.Сastrated;
                }
            }
            context.SaveChanges();
        }

        //удаление животных
        public Pet DeletePet(int id)
        {
            Pet dbEntry = context.Pets.Find(id);
            if (dbEntry != null)
            {
                context.Pets.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}