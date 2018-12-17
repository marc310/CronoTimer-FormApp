using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeX
{
    public class Projetos
    {
        public int idProj { get; set; }
        public string nomeProj { get; set; }
        public string descricaoProj { get; set; }
        public decimal precoProj { get; set; }
        public int clienteID { get; set; }
        //public string nomeCliente { get; set; }
        private Clientes cliente;

        public Clientes Cliente
        {
            get
            {
                //var idCli = Convert.ToInt32(this.clienteID);
                if (cliente != null) return cliente;
                cliente = Clientes.ClientePID(this.clienteID);
                return cliente;
            }
        }

        public static List<Projetos> carregaProjetos()
        {
            var lista = new List<Projetos>();
            var projDB = new Database.Projetos().listaProjetos();
            if (projDB.Rows.Count > 0)
            {
                foreach (DataRow row in projDB.Rows)
                {
                    lista.Add(new Projetos()
                    {
                        idProj = Convert.ToInt32(row["idProj"]),
                        nomeProj = row["nomeProj"].ToString(),
                        clienteID=Convert.ToInt32(row["clienteID"])
                    });
                }
            }
            return lista;
        }

        public static List<Projetos> porID(int idProj)
        {
            var lista = new List<Projetos>();
            var tab = new Database.Projetos().porProjetoID(idProj);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Projetos()
                    {
                        idProj = Convert.ToInt32(row["idProj"]),
                        nomeProj = row["nomeProj"].ToString(),
                        descricaoProj = row["descricaoProj"].ToString(),
                        precoProj = Convert.ToDecimal(row["precoProj"]),
                        clienteID = Convert.ToInt32(row["clienteID"])
                    });
                }
            }
            return lista;
        }

        public static List<Projetos> listaProjetos()
        {
            var lista = new List<Projetos>();
            var projDB = new Database.Projetos();
            foreach(DataRow row in projDB.listaProjetos().Rows)
            {
                var proj = new Projetos();
                proj.idProj = Convert.ToInt32(row["idProj"]);
                proj.nomeProj = Convert.ToString(row["nomeProj"]);
                proj.descricaoProj = Convert.ToString(row["descricaoProj"]);
                proj.precoProj = Convert.ToDecimal(row["precoProj"]);
                proj.clienteID = Convert.ToInt32(row["clienteID"]);

                lista.Add(proj);
            }
            return lista;
        }

        //public static List<Clientes> dadosCliente(int clienteID)
        //{
        //    var list = new List<Clientes>();
        //    var tabela = new Database.Clientes().PorID(clienteID);
        //    if (tabela.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in tabela.Rows)
        //        {
        //            list.Add(new Clientes()
        //            {
        //                clienteID = Convert.ToInt32(row["clienteID"]),
        //                nome = row["nome"].ToString(),
        //                telefone = row["telefone"].ToString(),
        //                celular = row["celular"].ToString(),
        //                email = row["email"].ToString(),
        //                precoHora = Convert.ToDecimal(row["precoHora"])
        //            });
        //        }
        //    }
        //    return list;
        //}

        public static List<Projetos> porClienteID(int clienteID)
        {
            var lista = new List<Projetos>();
            var tab = new Database.Projetos().porClienteID(clienteID);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Projetos()
                    {
                        idProj = Convert.ToInt32(row["idProj"]),
                        nomeProj = row["nomeProj"].ToString(),
                        descricaoProj = row["descricaoProj"].ToString(),
                        precoProj = Convert.ToDecimal(row["precoProj"]),
                        clienteID = Convert.ToInt32(row["clienteID"])
                    });
                }
            }
            return lista;
        }
        public static Projetos porProjetoID(int idProj)
        {
            var tab = new Database.Projetos().porProjetoID(idProj);
            var projeto = new Projetos();
                foreach (DataRow row in tab.Rows)
                {
                projeto.idProj = Convert.ToInt32(row["idProj"]);
                projeto.nomeProj = Convert.ToString(row["nomeProj"]);
                projeto.descricaoProj = Convert.ToString(row["descricaoProj"]);
                projeto.precoProj = Convert.ToDecimal(row["precoProj"]);
                projeto.clienteID = Convert.ToInt32(row["clienteID"]);
                }
            //
            return projeto;
        }

        public void Salvar()
        {
            new Database.Projetos().Salvar(this.idProj,this.nomeProj,this.descricaoProj,this.precoProj,this.clienteID);
        }

        public void Deleta(int idProj)
        {
            new Database.Projetos().Deletar(idProj);
        }
    }
}
