using Npgsql;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;

namespace no.teilin.turlogg.Repositories
{
  public class TestRepository
  {
    private IHostingEnvironment _env;
    private AppSettings _appSettings;

    public TestRepository(IHostingEnvironment env, IOptions<AppSettings> appSettings)
    {
      _env = env;
      _appSettings = appSettings.Value;
    }

    public void GetTests()
    {
      using(var connection = new NpgsqlConnection(_appSettings.ConnectionString))
      {
        var rs = connection.QueryAsync("");
      }
    }
  }
}
