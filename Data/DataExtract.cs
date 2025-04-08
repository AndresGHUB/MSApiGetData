using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MSApiGetData.Models.Data;
using MSApiGetData.Models.Request;
using MSApiGetData.Models.Response;
using MSApiLoadCsvFiles.Utils;

namespace MSApiGetData.Services
{
    public class DataExtract(IOptions<BddSettings> bddSettings) : IDataExtract
    {
        private readonly BddSettings _bddSettings = bddSettings.Value;


        public async Task<ResHeaderByYear> GetDataDepartmentsByYear(RequestCount request)
        {
            string _connectionString =_bddSettings.connectionString;
            string _queryByYear = _bddSettings.queryByYear;
            string queryByAvearge = _bddSettings.queryByAvearge;

            ResHeaderByYear resHeaderByYear = new ResHeaderByYear()
            {
                Date = DateTime.Now,
                Status = false,
                Code = Constants.ERR_CODE,
                Message = Constants.ERR_MSG,
                ListResHiredByYear = new List<ResHiredByYear>()
            };

            var reponse = new List<ResHiredByYear>();

            string query = _queryByYear + " " + request.Year.ToString();

            try{

                using (var connection = new SqlConnection(_connectionString))
                {
                    // Abre la conexión
                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Ejecuta la consulta y obtiene los resultados
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                ResHiredByYear report = new ResHiredByYear{
                                    Department = reader.GetString(0),
                                    Job = reader.GetString(1),
                                    Quarter1 = reader.GetInt32(2),
                                    Quarter2 = reader.GetInt32(3),
                                    Quarter3 = reader.GetInt32(4),
                                    Quarter4 = reader.GetInt32(5)
                                };

                                reponse.Add(report);
                            }
                            resHeaderByYear.Code = Constants.OK_CODE;
                            resHeaderByYear.Message = Constants.OK_MSG;
                            resHeaderByYear.Status = true;
                            resHeaderByYear.ListResHiredByYear = reponse;
                        }

                    }
                }
            }catch(Exception ex){
                resHeaderByYear.Message = ex.Message;
            }
            return resHeaderByYear;
        }


        public async Task<ResHeaderCountAvgDepartment> GetDataCountAvgDepartments(RequestCount request)
        {
            string _connectionString =_bddSettings.connectionString;
            string queryByAvearge = _bddSettings.queryByAvearge;

            ResHeaderCountAvgDepartment countAvgDepartment = new ResHeaderCountAvgDepartment()
            {
                Date = DateTime.Now,
                Status = false,
                Code = Constants.ERR_CODE,
                Message = Constants.ERR_MSG,
                ListCountAvgDepartment = new List<ResCountAvgDepartment>()
            };

            var reponse = new List<ResCountAvgDepartment>();

            string query = queryByAvearge + " " + request.Year.ToString();

            try{

                using (var connection = new SqlConnection(_connectionString))
                {
                    // Abre la conexión
                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Ejecuta la consulta y obtiene los resultados
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                ResCountAvgDepartment report = new ResCountAvgDepartment{
                                    DepartmentID = reader.GetInt32(0),
                                    Department = reader.GetString(1),
                                    Hired = reader.GetInt32(2)
                                };

                                reponse.Add(report);
                            }
                            countAvgDepartment.Code = Constants.OK_CODE;
                            countAvgDepartment.Message = Constants.OK_MSG;
                            countAvgDepartment.Status = true;
                            countAvgDepartment.ListCountAvgDepartment = reponse;
                        }

                    }
                }
            }catch(Exception ex){
                countAvgDepartment.Message = ex.Message;
            }
            return countAvgDepartment;
        }

    }
}