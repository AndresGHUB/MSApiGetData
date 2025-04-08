using MSApiGetData.Models.Request;
using MSApiGetData.Models.Response;

namespace MSApiGetData.Services
{
    public interface IDataExtract
    {
        /// <summary>
        /// Extract from data base list of hired by Department and Job
        /// </summary>
        /// <param name="request">Input parameters, contains the year of processing</param>
        /// <returns></returns>
        public Task<ResHeaderByYear> GetDataDepartmentsByYear(RequestCount request);

        /// <summary>
        /// Extract from data base list of hired more tha average
        /// </summary>
        /// <param name="request">Input parameters, contains the year of processing</param>
        /// <returns></returns>
        public Task<ResHeaderCountAvgDepartment> GetDataCountAvgDepartments(RequestCount request);
    }
}