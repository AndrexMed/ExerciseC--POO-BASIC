using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.model
{
    public class Cliente
    {
        //Atributos + get & set
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Constructor
        public Cliente(long id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }


    }
}
