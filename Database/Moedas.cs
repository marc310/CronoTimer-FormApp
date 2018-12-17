using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Database
{
    public class Moedas
    {
        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        public DataTable listaMoedas()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from moedas";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

                //..

            }
        }

        public DataTable porID(int moeda)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "select * from moedas where idMoeda='" + moeda + "'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();
                //
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                //
                DataTable table = new DataTable();
                adapter.Fill(table);
                //
                return table;
            }
        }

        public void Salvar(int idMoeda, string codigo, string simbolo, string descricao)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into moedas (idMoeda,codigo,simbolo,descricao) values('" + idMoeda + "','" + codigo + "','" + simbolo + "','" + descricao + "')";
                if (idMoeda != 0)
                {
                    queryString = "update moedas set idMoeda='" + idMoeda + "',codigo='" + codigo + "',simbolo='" + simbolo + "',descricao='" + descricao + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();
                Command.ExecuteNonQuery();


            }
        }
    }
}
