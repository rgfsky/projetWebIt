using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Book
    {

        public int Id { get; set; }
        public String Titre { get; set; }
        public virtual Auteur Auteur { get; set; }

        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateDeParution { get; set; }

        public int Prix { get; set; }
    }
}