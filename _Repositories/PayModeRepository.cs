﻿using System.Data;
using Supermarket_mvp.Repositories;
using Supermarket_mvp.Models;
using System.Data.SqlClient;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {

        public PayModeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayModeModel> GetAll()
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }
            return payModeList;
        }

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;
            using (var connection =new SqlConnection(connectionString))
            using (var command = new SqlCommand()) 
            { 
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Pay Mode
                                        WHERE Pay_Mode_Id=@Id or Pay_Mode_Name Like @Name+ '%'
                                        ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeName;
                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    { 
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }

            }
            return payModeList;
        }
    }
}
