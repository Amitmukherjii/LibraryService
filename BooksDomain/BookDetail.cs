using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksDomain
{
    public partial class BookDetail
    {
        [Column("Book_ID")]
        public int BookID { get; set; }
        [Required]
        [Column("Book_Name")]
        [StringLength(100)]
        public string BookName { get; set; }
        [Column("Book_Price")]
        public int BookPrice { get; set; }
        [Required]
        [Column("Image_Name")]
        [StringLength(100)]
        public string ImageName { get; set; }
        [Required]
        [Column("Book_Description")]
        [StringLength(100)]
        public string BookDescription { get; set; }
        [Required]
        [StringLength(100)]
        public string AddedBy { get; set; }
    }
}