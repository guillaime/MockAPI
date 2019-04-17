using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpExAPI.Data;
using OpExAPI.Models;
using OpExAPI.Models.WorkOrders;
using OpExAPI.Utils;

namespace OpExAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceTask : ControllerBase
    {
        private Singleton Data = Singleton.Instance();

        [Authorize]
        [HttpPost("add")]
        public ActionResult<CustomResponse<object>> NewRequestedMaintenanceTask(NewRequestedMaintenanceTaskObject receiveObject)
        {
            if(Enum.IsDefined(typeof(Priority), receiveObject.Priority))
            {
                User reporter = this.Data.users.Find(x => x.username.Equals(receiveObject.Username));
                Models.Object node = this.Data.objects.Find(x => x.id.Equals(receiveObject.ObjectId));
                string description = receiveObject.Description;

                if (reporter != null || node != null)
                {
                    this.Data.
                }
                else
                {
                    return NotFound(new CustomResponse<Error>
                    {
                        Message = Global.ResponseMessages.NotFound,
                        StatusCode = StatusCodes.Status404NotFound,
                        Result = new Error { ErrorMessage = Global.ResponseMessages.NotFound }
                    });
                }
            } 
            else
            {
                return BadRequest(new CustomResponse<Error>
                {
                    Message = Global.ResponseMessages.BadRequest,
                    StatusCode = StatusCodes.Status400BadRequest,
                    Result = new Error { ErrorMessage = Global.ResponseMessages.BadRequest }
                });
            }
        }
    }
}
