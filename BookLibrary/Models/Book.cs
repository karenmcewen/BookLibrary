using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        //can change the format that is displayed by putting a [] above the definition
        [DisplayFormat(DataFormatString ="{0:yyyy}")]
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

      [ForeignKey("Author")]
      public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

    }
}