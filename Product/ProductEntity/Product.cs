using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductEntity
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductYear { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ProductCode { get; set; }

        public int ChannelId { get; set; }


        [ForeignKey("SizeScale")]
        public int SizeId { get; set; }//Foreign Key

        public SizeScale tblSize { get; set; }


    }
}
