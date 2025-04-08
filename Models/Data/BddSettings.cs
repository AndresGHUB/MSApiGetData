using System.ComponentModel.DataAnnotations;

namespace MSApiGetData.Models.Data
{
    public class BddSettings
    {
        public string connectionString { get; set; } = string.Empty;

        public string queryByYear { get; set; } = string.Empty;

        public string queryByAvearge { get; set; } = string.Empty;
    }
}