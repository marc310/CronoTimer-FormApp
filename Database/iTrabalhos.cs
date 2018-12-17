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
    public class iTrabalhos
    {
        private string conexao()
        {
            return ConfigurationManager.AppSettings["conexao"];

        }

        /// <summary>
        /// Preenche lista de trabalhos, Select All
        /// </summary>
        /// <returns>Lista de Trabalhos</returns>
        public DataTable listaTrabalhos()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from itenstrabalho";
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
        /// Retorna ID do a Lista de Trabalho Salva
        /// </summary>
        /// <returns>Retornar Último ID</returns>
        public DataTable retornaID()
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "SELECT MAX(idTrabalho) as idTrabalho FROM itenstrabalho";
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
        /// Deletar Trabalho da Lista pelo ID
        /// </summary>
        /// <param name="idTrabalho">Deletar</param>
        public void Deletar(int idTrabalho)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "DELETE FROM itenstrabalho WHERE idTrabalho='" + idTrabalho + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                //
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Salva Trabalho na lista de Entradas
        /// </summary>
        /// <param name="idTrabalho"></param>
        /// <param name="projetoID"></param>
        /// <param name="tarefas"></param>
        /// <param name="idFaturaItem"></param>
        /// <param name="nota"></param>
        /// <param name="dataI"></param>
        /// <param name="dataF"></param>
        /// <param name="inicio"></param>
        /// <param name="final"></param>
        /// <param name="horas"></param>
        /// <param name="horaInt"></param>
        /// <param name="rendimento"></param>
        /// <param name="faturado"></param>
        public void Salvar(int idTrabalho, int projetoID, int tarefas, int idFaturaItem, string nota, DateTime data, DateTime dataF, string inicio, string final, string horas, string horaInt, string moeda, string rendimento, bool faturado)
        {
            var dataInicial = data.ToString("yyyy/MM/dd HH:mm:ss");
            var dataFinal = dataF.ToString("yyyy/MM/dd HH:mm:ss");
            //
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "insert into itenstrabalho (idTrabalho,projetoID,tarefas,idFaturaItem,nota,data,dataF,inicio,final,horas,horaInt,moeda,rendimento,faturado) values('" + idTrabalho + "','" + projetoID + "','" + tarefas + "','" + idFaturaItem + "','" + nota + "','" + dataInicial + "','" + dataFinal + "','" + inicio + "','" + final + "','" + horas + "','" + horaInt + "','" + moeda + "','" + rendimento + "','" + faturado + "')";
                if (idTrabalho != 0)
                {
                    queryString = "update itenstrabalho set idTrabalho='" + idTrabalho + "',projetoID='" + projetoID + "',tarefas='" + tarefas + "',idFaturaItem='" + idFaturaItem + "',nota='" + nota + "',data='" + dataInicial + "',dataF='" + dataFinal + "',inicio='" + inicio + "',final='" + final + "',horas='" + horas + "',horaInt='" + horaInt + "',moeda='" + moeda + "',rendimento='" + rendimento + "',faturado='" + faturado + "' where idTrabalho='" + idTrabalho + "'";
                }
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                Command.Connection.Open();

                Command.ExecuteNonQuery();
            }
        }

        public DataTable porTrabalhoID(int idTrabalho)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from itenstrabalho where idTrabalho='" + idTrabalho + "'";
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
        /// Lista todos os registros entre Datas
        /// </summary>
        /// <param name="DataInicial"></param>
        /// <param name="DataFinal"></param>
        /// <returns>select all between</returns>
        public DataTable EntreDatas(DateTime DataInicial, DateTime DataFinal)
        {
            var dataIn = DataInicial.ToString("yyyy/MM/dd HH:mm:ss");
            var dataFin = DataFinal.ToString("yyyy/MM/dd 23:59:59");
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {

                string queryString = "select * from itenstrabalho where data between '" + dataIn + "' and '" + dataFin + "' order by data";
                MySqlCommand command = new MySqlCommand(queryString, Connection);
                command.Connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public void Faturar(int idTrabalho, int statusFat, int idRetornado)
        {
            using (MySqlConnection Connection = new MySqlConnection(conexao()))
            {
                string queryString = "update itenstrabalho set faturado='" + statusFat + "',idFaturaItem='" + idRetornado + "' where idTrabalho='" + idTrabalho + "'";
                MySqlCommand Command = new MySqlCommand(queryString, Connection);
                //
                Command.Connection.Open();
                Command.ExecuteNonQuery();
            }
        }
    }
}
