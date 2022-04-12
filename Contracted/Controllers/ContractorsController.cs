using System;
using System.Collections.Generic;
using Contracted.Models;
using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _conS;
    public ContractorsController(ContractorsService conS)
    {
      _conS = conS;
    }


    [HttpGet]
    public ActionResult<List<Contractor>> GetAll()
    {
      try
      {
        return Ok(_conS.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }



    [HttpGet("{id}")]
    public ActionResult<Contractor> GetById(int id)
    {
      try
      {
        Contractor contractor = _conS.GetById(id);
        return Ok(contractor);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }

    }


    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor contractorData)
    {
      try
      {
        Contractor contractor = _conS.Create(contractorData);
        return Ok(contractorData);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        _conS.Delete(id);
        return Ok("delorted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}