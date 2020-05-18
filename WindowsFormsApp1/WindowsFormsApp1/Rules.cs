﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace MediaBazar
{
    class Rules
    {
        public int id { get; }
        private int createdById;
        public string description;



        public Rules(string description, int createdById)
        {
            this.description = description;
            this.createdById = createdById;
            AddRule();
        }
        public Rules(int id, string description, int createdById)
        {
            this.description = description;
            this.createdById = createdById;
            this.id = id;
        }

        private void AddRule()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO rules (created_by, description) VALUES (@Created_By, @Description);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Created_By", createdById);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string epra = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void RemoveRule(int id)
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "DELETE FROM rules WHERE id = @ruleId;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ruleId", id);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string epra = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Rules> GetAllRules()
        {
            MySqlConnection conn = Utils.GetConnection();
            List<Rules> ruleList = new List<Rules>();

            try
            {

                string GetList = "SELECT id, created_by, description FROM rules";
                MySqlCommand cmd = new MySqlCommand(GetList, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    int ID = Convert.ToInt32(row[0]);
                    int CreatedById = Convert.ToInt32(row[1]);
                    string ruleDesc = row[2].ToString();

                    Rules rule = new Rules(ID, ruleDesc, CreatedById);

                    ruleList.Add(rule);

                }
            }
            catch (Exception ex)
            {
                String e = ex.Message;
            }
            finally { conn.Close(); }

            return ruleList;
        }

    }
}
