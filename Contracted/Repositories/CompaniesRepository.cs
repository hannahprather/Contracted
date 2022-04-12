using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Contracted.Models;
using Dapper;

namespace Contracted.Repositories
{
  public class CompaniesRepository
  {
    private readonly IDbConnection _db;
    public CompaniesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Company> GetAll()
    {
      string sql = @"
      SELECT * FROM companies;";
      return _db.Query<Company>(sql).ToList();
    }

    internal Company GetById(int id)
    {
      string sql = @"
      SELECT * FROM companies
      WHERE id = @id;";
      return _db.Query<Company>(sql, new { id }).FirstOrDefault();
    }

    internal string Delete(int id)
    {
      string sql = @"
      DELETE FROM companies
      WHERE id = @id;
      ";
      int rowsAffected = _db.Execute(sql, new { id });
      if (rowsAffected > 0)
      {
        return "deleted";
      }
      throw new Exception("couldn't delete");
    }

    internal Company Create(Company companyData)
    {
      string sql = @"
      INSERT INTO companies
      (name)
      VALUES 
      (@Name);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, companyData);
      companyData.Id = id;
      return companyData;
    }

  }
}