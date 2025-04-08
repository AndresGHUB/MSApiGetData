using System.ComponentModel.DataAnnotations;

namespace MSApiGetData.Models.Request
{
    public class RequestCount
    {
        [Required]
        public DateTime Date { get; set; } 

        [Required]
        public string User {  get; set; } = string.Empty;

        [Required]
        public int Year {  get; set; }
    }
}