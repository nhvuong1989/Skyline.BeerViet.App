using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.BeerViet.Jobs
{
    public class CheckInModel
    {
        public int Id { get; set; }
        public int TeamId { get; set; }

    }
    class Program
    {
        static string sqlConnection = @"Data Source=112.78.3.41\SQLEXPRESS;Initial Catalog=sky76641_MainStream;User ID=sa;Password=Skyline@123!;Connect Timeout=180;";
        static void Main(string[] args)
        {

            string sql = @"SELECT Id, TeamId
                            FROM CheckInHistory
                            WHERE CheckOutTime IS NULL
                                  AND CAST(CheckInTime AS DATE) = CAST(GETDATE() AS DATE)";

            using (var connection = new SqlConnection(sqlConnection))
            {
                List<CheckInModel> idArr = connection.Query<CheckInModel>(sql).ToList();
                foreach (var itmId in idArr)
                {
                    connection.ExecuteScalar("spUserCheckOut", new
                    {
                        itmId.Id,
                        itmId.TeamId,
                        UserName = "System",
                        Location = "System"
                    }, commandType: System.Data.CommandType.StoredProcedure);

                }
            }
        }
    }
}
