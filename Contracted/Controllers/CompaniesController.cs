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


  }
}
