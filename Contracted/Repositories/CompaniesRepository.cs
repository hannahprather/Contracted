using System.Data;

namespace Contracted.Repositories
{
  public class CompaniesRepository
  {
    private readonly IDbConnection _db;
    public CompaniesRepository(IDbConnection db)
    {
      _db = db;
    }

  }
}