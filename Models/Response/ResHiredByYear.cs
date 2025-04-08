using System.ComponentModel.DataAnnotations;

namespace MSApiGetData.Models.Response
{
    public class ResHiredByYear
    {
        public string Department { get; set; } = string.Empty;

        public string Job {  get; set; } = string.Empty;

        public int Quarter1 {  get; set; }

        public int Quarter2 {  get; set; }

        public int Quarter3 {  get; set; }

        public int Quarter4 {  get; set; }
        
    }
}