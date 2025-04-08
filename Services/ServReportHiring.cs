using MSApiGetData.Models.Request;
using MSApiGetData.Models.Response;

namespace MSApiGetData.Services
{
    public class ServReportHiring: IServReportHiring
    {
        private readonly IDataExtract _dataExtract;

        public ServReportHiring(IDataExtract dataExtract)
        {
            _dataExtract = dataExtract;
        }

        public async Task<ResHeaderByYear> GetHiringDepartmentsByYear(RequestCount request)
        {

            ResHeaderByYear response = await _dataExtract.GetDataDepartmentsByYear(request);

            return response;
        }

        public async Task<ResHeaderCountAvgDepartment> GetCountAverageDepartments(RequestCount request)
        {

            ResHeaderCountAvgDepartment response = await _dataExtract.GetDataCountAvgDepartments(request);

            return response;
        }


    }
}