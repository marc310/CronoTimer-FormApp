using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Database;


namespace CodeX
{
    public class Clientes
    {
        public static readonly object cboClienteP;

        public int clienteID { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public decimal precoHora { get; set; }
        public int moeda { get; set; }
        public bool ativo { get; set; }
        public DateTime dataCadastro {get;set;}

        private Moedas tipo;

        public Moedas Moeda
        {
            get
            {
                //var idCli = Convert.ToInt32(this.clienteID);
                if (tipo != null) return tipo;
                tipo = Moedas.porMoedaID(this.moeda);
                return tipo;
            }
        }

        /// <summary>
        /// Retona Lista de Clientes
        /// </summary>
        /// <returns>select all</returns>
        public static List<Clientes> listaClientes()
        {
            var lista = new List<Clientes>();
            var cliDB = new Database.Clientes();
            foreach (DataRow row in cliDB.listaClientes().Rows)
            {
                var c = new Clientes();
                c.clienteID = Convert.ToInt32(row["clienteID"]);
                c.nome = Convert.ToString(row["nome"]);
                c.telefone = Convert.ToString(row["telefone"]);
                c.celular = Convert.ToString(row["celular"]);
                c.email = Convert.ToString(row["email"]);
                c.moeda = Convert.ToInt32(row["moeda"]);
                c.precoHora = Convert.ToDecimal(row["precoHora"]);
                //c.ativo=Convert.ToBoolean(row.Cells["ativo"]).forma
                lista.Add(c);
            }
            return lista;
        }

        /// <summary>
        /// busca clientes pelo nome do cliente (usado pra busca por texto)
        /// </summary>
        /// <param name="nomeCliente"></param>
        /// <returns>select col nome</returns>
        public static List<Clientes> buscaNomeCli(string nomeCliente)
        {
            List<Clientes> li = new List<Clientes>();
            var db = new Database.Clientes().buscaCliente(nomeCliente);
            if (db.Rows.Count > 0)
            {
                foreach (DataRow row in db.Rows)
                {
                    li.Add(new Clientes()
                    {
                        clienteID = Convert.ToInt32(row["clienteID"]),
                        nome = row["nome"].ToString(),
                        telefone = row["telefone"].ToString(),
                        celular = Convert.ToString(row["celular"]),
                        email = Convert.ToString(row["email"]),
                        precoHora = Convert.ToDecimal(row["precoHora"]),
                });
                }
            }
            return li;
        }

        public static List<Clientes> carregaClientes()
        {
            var lista = new List<Clientes>();
            var dbCli = new Database.Clientes().listaClientes();
            if (dbCli.Rows.Count > 0)
            {
                foreach (DataRow row in dbCli.Rows)
                {
                    lista.Add(new Clientes()
                    {
                        clienteID = Convert.ToInt32(row["clienteID"]),
                        nome = row["nome"].ToString(),
                        telefone = row["telefone"].ToString(),
                        celular = row["celular"].ToString(),
                        email = row["email"].ToString(),
                        precoHora = Convert.ToDecimal(row["precoHora"])
                    });
                }
            }
            return lista;
        }
        //
        /// <summary>
        /// Busca Informações pelo ID
        /// </summary>
        /// <param name="idC"></param>
        /// <returns>Retorna uma lista</returns>
        public static List<Clientes> porClienteID(int idC)
        {
            var lista = new List<Clientes>();
            var tab = new Database.Clientes().porClienteID(idC);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Clientes()
                    {
                        clienteID = Convert.ToInt32(row["clienteID"]),
                        nome = Convert.ToString(row["nome"]),
                        telefone = Convert.ToString(row["telefone"]),
                        celular = Convert.ToString(row["celular"]),
                        email = Convert.ToString(row["email"]),
                        moeda = Convert.ToInt32(row["moeda"]),
                        precoHora=Convert.ToDecimal(row["precoHora"])
                    });
                }
            }
            return lista;
        }

        /// <summary>
        /// Busca informações do cliente pelo id referente
        /// </summary>
        /// <param name="clienteID"></param>
        /// <returns>Retorna um DataRow</returns>
        public static Clientes ClientePID(int clienteID)
        {
            var tabela = new Database.Clientes().PorID(clienteID);
            var c = new Clientes();
                foreach (DataRow row in tabela.Rows)
                {
                c.clienteID = Convert.ToInt32(row["clienteID"]);
                c.nome = row["nome"].ToString();
                c.telefone = row["telefone"].ToString();
                c.celular = row["celular"].ToString();
                c.email = row["email"].ToString();
                c.precoHora = Convert.ToDecimal(row["precoHora"]);
                }
            return c;
        }

        /// <summary>
        /// Salvar Cliente
        /// </summary>
        public void Salvar()
        {
            new Database.Clientes().Salvar(this.clienteID, this.nome, this.telefone, this.celular, this.email, this.moeda, this.precoHora);
        }

        /// <summary>
        /// Deletar cliente pelo ID
        /// </summary>
        /// <param name="clienteID">parametro obrigatorio</param>
        public void Deleta(int clienteID)
        {
           new Database.Clientes().Deleta(clienteID);
        }
    }
}