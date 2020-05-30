using System.ComponentModel.DataAnnotations;

namespace Server.DTOs
{
    public class ResultDto
    {
        [Required]
        [StringLength(10)]
        public string title { get; set; } = "title";
        public string url { get; set; } = "some data..";
    }
}
