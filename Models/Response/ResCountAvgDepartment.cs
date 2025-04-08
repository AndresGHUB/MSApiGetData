using System.ComponentModel.DataAnnotations;

namespace MSApiGetData.Models.Response
{
    public class ResCountAvgDepartment
    {
        public int DepartmentID { get; set; }

        public string Department { get; set; } = string.Empty;

        public int Hired {  get; set; }
        
    }
}