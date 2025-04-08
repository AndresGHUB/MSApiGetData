using System.ComponentModel.DataAnnotations;

namespace MSApiGetData.Models.Response
{
    public class ResHeaderCountAvgDepartment
    {
        public DateTime Date  { get; set; }

        public bool Status {  get; set; }

        public string Code {  get; set; } = string.Empty;

        public string Message {  get; set; } = string.Empty;

        public List<ResCountAvgDepartment>? ListCountAvgDepartment {  get; set; }
        
    }
}