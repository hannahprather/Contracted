using System.Collections.Generic;
using Contracted.Models;
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

    internal List<Company> GetAll()
    {
      return _compRepo.GetAll();
    }

    internal Company GetById(int id)
    {
      return _compRepo.GetById(id);
    }

    internal string Delete(int id)
    {
      return _compRepo.Delete(id);
    }

    internal Company Create(Company companyData)
    {
      return _compRepo.Create(companyData);
    }
  }
}