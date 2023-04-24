using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers;

[ApiController]
// url/worker/getworker
[Route("[controller]")]
public class WorkerController : ControllerBase
{


    //  R   U     D     C
    // get put delete post
    [HttpGet]
    [Route("getworker")]
    public Worker[] Get() => Repository.Read();


    [HttpGet]
    [Route("getworker/{id}")]
    public Worker Get(int id) => Repository.Read(id);
}
