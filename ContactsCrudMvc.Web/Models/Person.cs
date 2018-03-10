using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ContactsCrudMvc.Web.Models
{
    public class Person
    {
        public int Id { get; set; }

        // [Display(Name ="Quem?")]
        public String Nome { get; set; }
        
        [Display(Name = "Telefone")]
        public String Fone { get; set; }
        [Display(Name = "Endereço de E-Mail")]
        public String Email { get; set; }
        

    }
}