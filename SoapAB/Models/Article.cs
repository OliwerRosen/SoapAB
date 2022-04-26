
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoapAB.Models
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ArticleId { get; set; }
        public bool IsInStock { get; set; }
        [DataType(DataType.Date)]
        public string DateArrivedToStock { get; set; }
        [DataType(DataType.Date)]
        public string DateSentFromStock { get; set; }

        public string ArticleTypeId { get; set; }
        public ArticleType ArticleType { get; set; }
    }
}
