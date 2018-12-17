using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeX
{
    public class Moedas
    {
        public int idMoeda { get; set; }
        public string codigo { get; set; }
        public string simbolo {get;set;}
        public string descricao {get;set; }

        public static object carregaMoedas()
        {
            var lista = new List<Moedas>();
            var tarDB = new Database.Moedas().listaMoedas();
            if (tarDB.Rows.Count > 0)
            {
                foreach (DataRow row in tarDB.Rows)
                {
                    lista.Add(new Moedas()
                    {
                        idMoeda = Convert.ToInt32(row["idMoeda"]),
                        codigo = row["codigo"].ToString()
                    });
                }
            }
            return lista;
        }

        /// <summary>
        /// Busca e cria Lista da Moeda por ID
        /// </summary>
        /// <param name="moeda"></param>
        /// <returns>Retorna todos os dados</returns>
        public static List<Moedas> porID(int moeda)
        {
            var lista = new List<Moedas>();
            var tab = new Database.Moedas().porID(moeda);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Moedas()
                    {
                        idMoeda = Convert.ToInt32(row["idMoeda"]),
                        codigo = Convert.ToString(row["codigo"]),
                        simbolo = Convert.ToString(row["simbolo"]),
                        descricao = Convert.ToString(row["descricao"])
                    });
                }
            }
            return lista;
    }

        /// <summary>
        /// Busca um DataRow da Moeda por ID
        /// </summary>
        /// <param name="moeda"></param>
        /// <returns>Retorna apenas o Símbolo da Moeda</returns>
        public static Moedas porMoedaID(int moeda)
        {
            var tab = new Database.Moedas().porID(moeda);
            var t = new Moedas();
            foreach(DataRow row in tab.Rows)
            {
                t.idMoeda = Convert.ToInt32(row["idMoeda"]);
                t.simbolo = Convert.ToString(row["simbolo"]);
            }
            return t;
        }

        public static List<Moedas> listarMoedas()
        {
            var lista = new List<Moedas>();
            var tarDB = new Database.Moedas();
            foreach (DataRow row in tarDB.listaMoedas().Rows)
            {
                var t = new Moedas();
                t.idMoeda = Convert.ToInt32(row["idMoeda"]);
                t.codigo = Convert.ToString(row["codigo"]);
                t.simbolo = Convert.ToString(row["simbolo"]);
                t.descricao = Convert.ToString(row["descricao"]);

                lista.Add(t);
            }
            return lista;
        }

        public void Salvar()
        {
            new Database.Moedas().Salvar(this.idMoeda, this.codigo, this.simbolo, this.descricao);
        }
    }
}
