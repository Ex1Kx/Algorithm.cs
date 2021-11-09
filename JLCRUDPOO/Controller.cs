using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLCRUDPOO
{
    class Controller : Conexion
    {
        public List<Object> query(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if(date == null)
            {
                sql = "SELECT id, prnames FROM persons ORDER BY prnames ASC";
            }else
            {
                sql = "SELECT id, prnames FROM persons WHERE prnames LIKE '%"+date+"%' ORDER BY prnames ASC";
            }
            try
            {
                MySqlConnection conexionDB = base.conexion();
                conexionDB.Open();
                MySqlCommand command = new MySqlCommand(sql, conexionDB);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Persons _persons = new Persons();
                    _persons.Id = int.Parse(reader.GetString(0));
                    _persons.Prnames = reader[1].ToString();
                    list.Add(_persons);
                }
            } catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return list;
        }
    }
}
