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
    public class Tarefas
    {
        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        public DataTable listaTarefas()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from tarefas";
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

        public DataTable porID(int tarefas)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "select * from tarefas where idTar='" + tarefas + "'";
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

        public void Salvar(int idTar, string nomeTar, string descricaoTar)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into tarefas (idTar,nomeTar,descricaoTar) values('" + idTar + "','" + nomeTar + "','" + descricaoTar + "')";
                if (idTar != 0)
                {
                    queryString = "update tarefas set idTar='" + idTar + "',nomeTar='" + nomeTar + "',descricaoTar='" + descricaoTar + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();
                Command.ExecuteNonQuery();


            }
        }
    }
}
