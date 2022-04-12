using System;
using System.Collections.Generic;
using Contracted.Models;
using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class CompaniesController : ControllerBase
  {
    private readonly CompaniesService _compS;
    public CompaniesController(CompaniesService compS)
    {
      _compS = compS;
    }

    [HttpGet]
    public ActionResult<List<Company>> GetAll()
    {
      try
      {
        return Ok(_compS.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Company> GetById(int id)
    {
      try
      {
        Company company = _compS.GetById(id);
        return Ok(company);
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
        _compS.Delete(id);
        return Ok("delorted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Company> Create([FromBody] Company companyData)
    {
      try
      {
        Company company = _compS.Create(companyData);
        return Ok(companyData);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
