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
    public class Clientes
    {
        //string connectionString = @"server=localhost;user id=root;database=dbcodex";

        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        public DataTable listaClientes()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from clientes";
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

        public void Salvar(int clienteID, string nome, string telefone, string celular, string email, int moeda, decimal precoHora)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into clientes(clienteID,nome,telefone,celular,email,moeda,precoHora) values('" + clienteID + "','" + nome + "','" + telefone + "','" + celular + "','" + email + "','" + moeda + "','" + precoHora + "')";
                if (clienteID != 0)
                {
                    queryString = "update clientes set nome='" + nome + "',telefone='" + telefone + "',celular='" + celular + "',email='" + email + "',moeda='" + moeda + "',precoHora='" + precoHora + "' where clienteID='" + clienteID + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();
                Command.ExecuteNonQuery();


            }
        }

        public DataTable buscaCliente(string nomeCliente)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "select * from clientes where nome LIKE '%" + nomeCliente + "%'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable PorID(int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                //string queryString = "select * from clientes where id='" + clienteID + "'";
                string queryString = "SELECT * from clientes inner join projetos on clientes.clienteID=projetos.clienteID where clientes.clienteID LIKE '%" + clienteID + "%'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        //
        public DataTable porClienteID(int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from clientes where clienteID='" + clienteID + "'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Deleta(int clienteID)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "DELETE FROM clientes WHERE clienteID='" + clienteID + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }
    }
}
//
//public DataTable PorCPF(string cpf)
//{
//    using (SqlConnection connection = new SqlConnection(
//       connectionString))
//    {
//        string queryString = "select * from enderecos where cpf='" + cpf + "'";
//        SqlCommand command = new SqlCommand(queryString, connection);
//        command.Connection.Open();

//        SqlDataAdapter adapter = new SqlDataAdapter();
//        adapter.SelectCommand = command;

//        DataTable table = new DataTable();
//        adapter.Fill(table);

//        return table;
//    }
//}