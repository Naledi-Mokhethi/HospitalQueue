using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
namespace HospitalQueue.DAL
{
    public class PatientsDAL
    {
        private readonly string _connectionString;

        public PatientsDAL(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void InsertData(List<object> dataList)
        {
            string insertQuery = "INSERT INTO ERPatientData ([Full Names],[Last Name], ID, [Phone Number],DateTime,Priority,Description) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    Value1 = (string)dataList[0],
                    Value2 = (string)dataList[1],
                    Value3 = (string)dataList[2],
                    Value4 = (string)dataList[3],
                    Value5 = (DateTime)dataList[4],
                    Value6 = (int)dataList[5],
                    Value7 = (string)dataList[6]

                };

                connection.Execute(insertQuery, parameters);
            }
        }
    }
}

