using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Panier
    {

        public int Id { get; set; }
       public List<Article> Articles { get; set; }
    }
}