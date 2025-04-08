using MSApiGetData.Models.Request;
using MSApiGetData.Models.Response;

namespace MSApiGetData.Services
{
    public interface IServReportHiring
    {
        /// <summary>
        /// Business Interface to get list of hired by Department and Job
        /// </summary>
        /// <param name="request">Input parameters, contains the year of processing</param>
        /// <returns></returns>
        public Task<ResHeaderByYear> GetHiringDepartmentsByYear(RequestCount request);

        /// <summary>
        /// Business Interface to get list of hired more tha average
        /// </summary>
        /// <param name="request">Input parameters, contains the year of processing</param>
        /// <returns></returns>
        public Task<ResHeaderCountAvgDepartment> GetCountAverageDepartments(RequestCount request);
    }
}