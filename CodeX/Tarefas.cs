using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeX
{
    public class Tarefas
    {
        public int idTar { get; set; }
        public string nomeTar { get; set; }
        public string descricaoTar {get;set;}

        public static object carregaTarefas()
        {
            var lista = new List<Tarefas>();
            var tarDB = new Database.Tarefas().listaTarefas();
            if (tarDB.Rows.Count > 0)
            {
                foreach (DataRow row in tarDB.Rows)
                {
                    lista.Add(new Tarefas()
                    {
                        idTar = Convert.ToInt32(row["idTar"]),
                        nomeTar = row["nomeTar"].ToString()
                    });
                }
            }
            return lista;
        }

        public static List<Tarefas> porID(int tarefas)
        {
            var lista = new List<Tarefas>();
            var tab = new Database.Tarefas().porID(tarefas);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new Tarefas()
                    {
                        idTar=Convert.ToInt32(row["idTar"]),
                        nomeTar=Convert.ToString(row["nomeTar"]),
                        descricaoTar=Convert.ToString(row["descricaoTar"])
                    });
                }
            }
            return lista;
        }

        public static Tarefas porTarefaID(int tarefas)
        {
            var tab = new Database.Tarefas().porID(tarefas);
            var t = new Tarefas();
            foreach(DataRow row in tab.Rows)
            {
                t.idTar = Convert.ToInt32(row["idTar"]);
                t.nomeTar = Convert.ToString(row["nomeTar"]);
                t.descricaoTar = Convert.ToString(row["descricaoTar"]);
            }
            return t;
            //
            //public static Projetos porProjetoID(int idProj)
            //{
            //    var tab = new Database.Projetos().porProjetoID(idProj);
            //    var projeto = new Projetos();
            //    foreach (DataRow row in tab.Rows)
            //    {
            //        projeto.idProj = Convert.ToInt32(row["idProj"]);
            //        projeto.nomeProj = Convert.ToString(row["nomeProj"]);
            //        projeto.descricaoProj = Convert.ToString(row["descricaoProj"]);
            //        projeto.precoProj = Convert.ToDecimal(row["precoProj"]);
            //        projeto.clienteID = Convert.ToInt32(row["clienteID"]);
            //    }
            //    //
            //    return projeto;
            //}
        }

        public static List<Tarefas> listaTarefas()
        {
            var lista = new List<Tarefas>();
            var tarDB = new Database.Tarefas();
            foreach (DataRow row in tarDB.listaTarefas().Rows)
            {
                var t = new Tarefas();
                t.idTar = Convert.ToInt32(row["idTar"]);
                t.nomeTar = Convert.ToString(row["nomeTar"]);
                t.descricaoTar = Convert.ToString(row["descricaoTar"]);

                lista.Add(t);
            }
            return lista;
        }

        public void Salvar()
        {
            new Database.Tarefas().Salvar(this.idTar,this.nomeTar,this.descricaoTar);
        }
    }
}
