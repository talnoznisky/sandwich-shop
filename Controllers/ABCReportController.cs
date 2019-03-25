using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Data.SqlClient;
using SandwichShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace SandwichShop.Controllers
{
    public class ABCReportController : Controller
    {
        private SqlConnection _connection;
        public ABCReportController(System.Data.SqlClient.SqlConnection connection)
        {
            this._connection = connection;
        }

        public IActionResult Index(SqlViewModel model)
        {
                _connection.Open();
                System.Data.SqlClient.SqlCommand command = _connection.CreateCommand();
                command.CommandText = "EXEC OrderProcedure 1";

                System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                System.Data.DataSet dataSet = new System.Data.DataSet();
                adapter.Fill(dataSet);
                _connection.Close();

                model.FirstName  = (string)dataSet.Tables[0].Rows[0][1];
                model.LastName = (string)dataSet.Tables[0].Rows[0][2];
                model.BillingAddress = (string)dataSet.Tables[0].Rows[0][3];
                model.City = (string)dataSet.Tables[0].Rows[0][4];
                model.ZipCode = (string)dataSet.Tables[0].Rows[0][5];
                model.State= (string)dataSet.Tables[0].Rows[0][6];

            return View(model);
        }
    }
}
