using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpExAPI.Data;
using OpExAPI.DTOs.Parts;
using OpExAPI.Models;
using OpExAPI.Utils;

namespace OpExAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreroomController : ControllerBase
    {
        private Singleton Data = Singleton.Instance();

        [Authorize]
        [HttpGet("all")]
        public ActionResult<CustomResponse<object>> GetAllStorerooms()
        {
            List<Part> parts = new List<Part>();
            this.Data.storerooms.ForEach((storeroom) => parts.AddRange(storeroom.parts));

            if (parts != null)
            {
                var mappedParts = Mapper.Map<List<Part>, List<PartDTO>>(parts);
                return Ok(new CustomResponse<List<PartDTO>>
                {
                    Message = Global.ResponseMessages.Success,
                    StatusCode = StatusCodes.Status200OK,
                    Result = mappedParts,
                });
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
    }
}
