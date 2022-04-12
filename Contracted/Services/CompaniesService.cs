using Contracted.Repositories;

namespace Contracted.Services
{

  public class CompaniesService
  {
    private readonly CompaniesRepository _compRepo;
    public CompaniesService(CompaniesRepository compRepo)
    {
      _compRepo = compRepo;
    }


  }
}