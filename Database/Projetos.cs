using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Database
{
    public class Projetos
    {
        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        public DataTable listaProjetos()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from projetos";
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

        public DataTable porClienteID(int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from projetos inner join clientes on projetos.clienteID = clientes.clienteID where projetos.clienteID LIKE '%" + clienteID + "%'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Salvar(int idProj, string nomeProj, string descricaoProj, decimal precoProj, int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into projetos (idProj,nomeProj,descricaoProj,precoProj,clienteID) values('" + idProj + "','" + nomeProj + "','" + descricaoProj + "','" + precoProj + "','" + clienteID + "')";
                if (idProj != 0)
                {
                    queryString = "update projetos set idProj='" + idProj + "',nomeProj='" + nomeProj + "',descricaoProj='" + descricaoProj + "',precoProj='" + precoProj + "' where idProj='" + idProj + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();

                Command.ExecuteNonQuery();
            }
        }

        public DataTable PorClienteID(int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "select * from projetos where clienteID='" + clienteID + "'";
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

        public DataTable porProjetoID(int idProj)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "select * from projetos where idProj='" + idProj + "'";
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

        public void Deletar(int idProj)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "DELETE FROM projetos WHERE idProj='" + idProj + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                //
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }
        
    }
}
