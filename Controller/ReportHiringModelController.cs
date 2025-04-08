using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSApiGetData.Models.Request;
using MSApiGetData.Models.Response;
using MSApiGetData.Services;

namespace MSApiGetData.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportHiringModelController : ControllerBase
    {

        private readonly IServReportHiring _servReportHiring;

        public ReportHiringModelController(IServReportHiring servReportHiring)
        {
            _servReportHiring = servReportHiring;
        }



        /// <summary>
        /// GetHiredByDepartments: Metod to get data from requierement 1: list of hired employee by Department and Job
        /// </summary>
        /// <param name="request">Object contains detail of request</param>
        /// <returns>List</returns>
        [HttpGet(Name = "GetHiredByDepartments"), AllowAnonymous]
        public async Task<ActionResult> GetHiredByDepartments(RequestCount request)
        {
            var response = await _servReportHiring.GetHiringDepartmentsByYear(request);
            return Ok(response);
        }


        /// <summary>
        /// GetHiredByDepartments: Metod to get data from requierement 2: list of hired employees more tha average
        /// </summary>
        /// <param name="request">Object contains detail of request</param>
        /// <returns>List</returns>
        [HttpGet(Name = "GetCountAvegareDepartments"), AllowAnonymous]
        public async Task<ActionResult> GetCountAvegareDepartments(RequestCount request)
        {
            var response = await _servReportHiring.GetCountAverageDepartments(request);
            return Ok(response);
        }
    }
}
