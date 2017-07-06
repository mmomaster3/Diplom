using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homeless_pets.Models
{
    public class DBforNewsRedactor
    {
        NewsContext context;

        public DBforNewsRedactor()
        {
            context = new NewsContext();
        }
        //сохранение новостей
        public void SaveNew(New newVariable)
        {

            if (newVariable.NewID == 0)
            {
                context.News.Add(newVariable);
            }
            else
            {
                New newVariableInBD = context.News.Find(newVariable.NewID);
                if (newVariableInBD != null)
                {
                    newVariableInBD.Body = newVariable.Body;
                    newVariableInBD.Date = newVariable.Date;
                    newVariableInBD.Header = newVariable.Header;
                    newVariableInBD.Short = newVariable.Short;
                }
            }
            context.SaveChanges();
        }

        //удаление новостей
        public New DeleteNew(int id)
        {
            New dbEntry = context.News.Find(id);
            if (dbEntry != null)
            {
                context.News.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}