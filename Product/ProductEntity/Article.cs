using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductEntity
{
    public class Article
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        public string ArticleName { get; set; }


        [ForeignKey("tblProduct")]
        public int ProductId { get; set; }//Foreign Key

        public Product tblProduct { get; set; }


        [ForeignKey("tblColor")]
        public int ColorId { get; set; }//Foreign Key

        public Color tblColor { get; set; }

        
    }
}
