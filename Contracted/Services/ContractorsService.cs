using System.Collections.Generic;
using Contracted.Models;
using Contracted.Repositories;

namespace Contracted.Services
{

  public class ContractorsService
  {
    private readonly ContractorsRepository _conRepo;
    public ContractorsService(ContractorsRepository conRepo)
    {
      _conRepo = conRepo;
    }

    internal List<Contractor> GetAll()
    {
      return _conRepo.GetAll();
    }

    internal Contractor GetById(int id)
    {
      return _conRepo.GetById(id);
    }

    internal Contractor Create(Contractor contractorData)
    {
      return _conRepo.Create(contractorData);
    }

    internal string Delete(int id)
    {
      return _conRepo.Delete(id);
    }
  }
}