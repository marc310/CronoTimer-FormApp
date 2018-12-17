using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeX
{
    public class Faturas
    {
        public int IDFat { get; set; }
        public int clienteFatura { get; set; }
        public DateTime dataEmissao { get; set; }
        public DateTime dataVencimento { get; set; }
        public string moeda { get; set; }
        public string valorHora { get; set; }
        public string totalFatura { get; set; }
        public bool pago { get; set; }
        private Clientes cliente;

        public Clientes Cliente
        {
            get
            {
                if (cliente != null) return cliente;
                cliente = Clientes.ClientePID(this.clienteFatura);
                return cliente;
            }
        }

        //public static List<Faturas> carregaFaturas()
        //{
        //    var lista = new List<Faturas>();
        //    var fatDB = new Database.Faturas().listaFaturas();
        //    if (fatDB.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in fatDB.Rows)
        //        {
        //            lista.Add(new Faturas()
        //            {
        //                IDFat = Convert.ToInt32(row["IDFat"]),
        //                clienteFatura = Convert.ToInt32(row["clienteFatura"]),
        //                dataEmissao =Convert.ToDateTime(row["dataEmissao"]),
        //                dataVencimento =Convert.ToDateTime(row["dataVencimento"]),
        //                totalFatura =Convert.ToString(row["totalFatura"]),
        //                pago =Convert.ToBoolean(row["pago"])
        //            });
        //        }
        //    }
        //    return lista;
        //}

        /// <summary>
        /// Lista todas as Faturas
        /// </summary>
        /// <returns>lista de faturas</returns>
        public static List<Faturas> listaFaturas()
        {
            var lista = new List<Faturas>();
            var fatDB = new Database.Faturas();
            foreach(DataRow row in fatDB.listaFaturas().Rows)
            {
                var f = new Faturas();
                f.IDFat = Convert.ToInt32(row["idFat"]);
                f.clienteFatura = Convert.ToInt32(row["clienteFatura"]);
                f.dataEmissao = Convert.ToDateTime(row["dataEmissao"]);
                f.dataVencimento = Convert.ToDateTime(row["dataVencimento"]);
                f.moeda = Convert.ToString(row["moeda"]);
                f.valorHora = Convert.ToString(row["valorHora"]);
                f.totalFatura = Convert.ToString(row["totalFatura"]);
                f.pago = Convert.ToBoolean(row["pago"]);

                lista.Add(f);
            }
            return lista;
        }


        /// <summary>
        /// Busca Fatura pelo ID
        /// </summary>
        /// <param name="IDFat"></param>
        /// <returns>Dados da fatura</returns>
        public static List<Faturas> porFaturaID(int IDFat)
        {
            var lista = new List<Faturas>();
            var tab = new Database.Faturas().porFaturaID(IDFat);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Faturas()
                    {
                        IDFat = Convert.ToInt32(row["IDFat"]),
                        clienteFatura = Convert.ToInt32(row["clienteFatura"]),
                        dataEmissao = Convert.ToDateTime(row["dataEmissao"]),
                        dataVencimento = Convert.ToDateTime(row["dataVencimento"]),
                        moeda = Convert.ToString(row["moeda"]),
                        valorHora = Convert.ToString(row["valorHora"]),
                        totalFatura = Convert.ToString(row["totalFatura"]),
                        pago = Convert.ToBoolean(row["pago"])
                    });
                }
            }
            return lista;
        }

        //public static List<Projetos> porClienteID(int clienteID)
        //{
        //    var lista = new List<Projetos>();
        //    var tab = new Database.Projetos().porClienteID(clienteID);
        //    if (tab.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in tab.Rows)
        //        {
        //            lista.Add(new Projetos()
        //            {
        //                idProj = Convert.ToInt32(row["idProj"]),
        //                nomeProj = row["nomeProj"].ToString(),
        //                descricaoProj = row["descricaoProj"].ToString(),
        //                precoProj = Convert.ToDecimal(row["precoProj"]),
        //                clienteID = Convert.ToInt32(row["clienteID"])
        //            });
        //        }
        //    }
        //    return lista;
        //}

        //
        //*****************************************************//
        /// <summary>
        /// Retornar ID da Ultima Fatura Salva
        /// </summary>
        /// <returns>Retornar ID</returns>
        public static List<Faturas> retornaID()
        {
            var lista = new List<Faturas>();
            var tab = new Database.Faturas().retornaID();
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Faturas()
                    {
                        IDFat = Convert.ToInt32(row["IDFat"])
                    });
                }
            }
            return lista;
        }

        public void Salvar()
        {
            new Database.Faturas().Salvar(this.IDFat,this.clienteFatura,this.dataEmissao,this.dataVencimento,this.moeda, this.valorHora, this.totalFatura,this.pago);
        }

        public void Deleta(int IDFat)
        {
            new Database.Faturas().Deletar(IDFat);
        }

        public void Quitar(int fatura, int status)
        {
            new Database.Faturas().Quita(fatura, status);
        }
    }
}
