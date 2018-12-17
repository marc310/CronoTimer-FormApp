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
    public class Faturas
    {
        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        /// <summary>
        /// Lista Faturas
        /// </summary>
        /// <returns>select all</returns>
        public DataTable listaFaturas()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from fatura";
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

        /// <summary>
        /// select MAX
        /// </summary>
        /// <returns>Ultimo ID Salvo</returns>
        public DataTable retornaID()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "SELECT MAX(IDFat) as IDFat FROM fatura";
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

        /// <summary>
        /// Salvar Fatura
        /// </summary>
        /// <param name="IDFat"></param>
        /// <param name="clienteFatura"></param>
        /// <param name="dataEmissao"></param>
        /// <param name="dataVencimento"></param>
        /// <param name="totalFatura"></param>
        /// <param name="pago"></param>
        public void Salvar(int IDFat, int clienteFatura, DateTime dataEmissao, DateTime dataVencimento, string moeda, string valorHora, string totalFatura, bool pago)
        {
            dataEmissao.ToShortDateString();
            var dataE = dataEmissao.ToString("yyyy/MM/dd");
            //
            dataVencimento.ToShortDateString();
            var dataV = dataVencimento.ToString("yyyy/MM/dd");
            //
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into fatura (IDFat,clienteFatura,dataEmissao,dataVencimento,moeda,valorHora,totalFatura,pago) values('" + IDFat + "','" + clienteFatura + "','" + dataE + "','" + dataV + "','" + moeda + "','" + valorHora + "','" + totalFatura + "','" + pago + "')";
                if (IDFat != 0)
                {
                    queryString = "update fatura set IDFat='" + IDFat + "',clienteFatura='" + clienteFatura + "',dataEmissao='" + dataE + "',dataVencimento='" + dataV + "',moeda='" + moeda + "',valorHora='" + valorHora + "',totalFatura='" + totalFatura + "',pago='" + pago + "' where IDFat='" + IDFat + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();

                Command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Lista Faturas por ID
        /// </summary>
        /// <param name="IDFat"></param>
        /// <returns></returns>
        public DataTable porFaturaID(int IDFat)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from fatura where IDFat='" + IDFat + "'";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        /// <summary>
        /// Deletar Fatura pelo ID
        /// </summary>
        /// <param name="IDFat"></param>
        public void Deletar(int IDFat)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "DELETE FROM fatura WHERE IDFat='" + IDFat + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                //
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Seta valor de status pelo ID da Fatura (1 pra verdadeiro e 0 para falso)
        /// </summary>
        /// <param name="iDFat">passagem de ID da Fatura Obrigatória</param>
        public void Quita(int iDFat, int pago)
        {
            //TODO
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "UPDATE fatura SET pago='" + pago + "' where IDFat='" + iDFat + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                //
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }
    }
}

