﻿using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ErrorsController(DataContext context) : BaseApiController
{
    [Authorize]
    [HttpGet("auth")]
    public ActionResult<string> GetAuth()
    {
        return "You are not authorized";
    }
    
    [HttpGet("not-found")]
    public ActionResult<AppUser> GetNotFound()
    {
        var thing = context.Users.Find(-1);
        if (thing == null) return NotFound();
        
        return thing;
    }
    
    [HttpGet("server-error")]
    public ActionResult<AppUser> GetServerError()
    {
        var thing = context.Users.Find(-1) ?? throw new Exception("Test server-error");
        return thing;
    }
    
    [HttpGet("bad-request")]
    public ActionResult<string> GetBadRequest()
    {
        return BadRequest("This was bad request");
    }
}