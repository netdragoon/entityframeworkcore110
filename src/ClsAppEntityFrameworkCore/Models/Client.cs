using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//https://github.com/aspnet/EntityFramework/wiki/Roadmap
//https://expressprofiler.codeplex.com/downloads/get/849229
//https://github.com/aspnet/EntityFramework/wiki/Design-Documents
namespace ClsAppEntityFrameworkCore.Models
{
    public class Client
    {
        public Client()
        {
            Phones = new HashSet<Phone>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }  
        public virtual ICollection<Phone> Phones { get; set; }
    }

          
    public class Phone
    {
        public long Id { get; set; }          
        public long ClientId { get; set; }
        public virtual Client Client { get; set; }   
        public string Ddd { get; set; }
        public string Number { get; set; }
        public bool Active { get; set; }

    }  
}
