using ClsAppEntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace ClsAppEntityFrameworkCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (Context ctx = new Context())
            {
                
                //Client c = new Client();
                //c.Active = true;
                //c.Created = DateTime.Now.AddDays(-1);
                //c.Name = "Hugo L.";

                //ctx.Add(c);

                //ctx.SaveChanges();


                //long cId = 3;
                //Phone p = new Phone();
                //p.Active = true;
                //p.Client = ctx.Client.Find(cId);
                //p.Ddd = "018";
                //p.Number = "32695189";


                //ctx.Phone.Add(p);
                //ctx.SaveChanges();

                long cId = 2;

                //ctx.Client
                //    .Include(a => a.Phones)
                //    .ToList();


                //var cl02 = ctx
                //    .Client
                //    .Where(x => x.Id == cId)                    
                //    .FirstOrDefault();

                //ctx.Entry(cl02)
                //    .Collection(a => a.Phones)
                //    .Query()
                //    .Where(w => w.Active == true)
                //    .Load();                  

            }
        }
    }
}
