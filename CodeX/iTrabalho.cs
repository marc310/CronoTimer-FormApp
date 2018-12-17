using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CodeX
{
    public class iTrabalho
    {
        public int idTrabalho { get; set; }
        public string nota { get; set; }
        //public string Data { get; set; }
        public DateTime data { get; set; }
        public DateTime dataF { get; set; }
        public string inicio { get; set; }
        public string final { get; set; }
        public int projetoID { get; set; }
        public int tarefas { get; set; }
        public string horas { get; set; }
        public string horaInt { get; set; }
        public bool livre { get; set; }
        public string moeda { get; set; }
        public string rendimento { get; set; }
        public bool faturado { get; set; }
        public int idFaturaItem { get; set; }
        private Projetos projetos;
        private Tarefas tarefa;

        public Tarefas Tarefas
        {
            get
            {
                if (tarefa != null) return tarefa;
                tarefa = Tarefas.porTarefaID(this.tarefas);
                return tarefa;
            }
        }

        public Projetos Projetos
        {
            get
            {
                if (projetos != null) return projetos;
                projetos = Projetos.porProjetoID(this.projetoID);
                return projetos;
            }
        }
        //
        //*****************************************************//
        // LISTA TRABALHOS
        /// <summary>
        /// Select All na Lista de Entradas de Trabalho do timer
        /// </summary>
        /// <returns>Lista de Entradas</returns>
        public static List<iTrabalho> listaTrabalhos()
        {
            var lista = new List<iTrabalho>();
            var TrabDB = new Database.iTrabalhos();
            foreach (DataRow row in TrabDB.listaTrabalhos().Rows)
            {
                var trampo = new iTrabalho();
                trampo.idTrabalho = Convert.ToInt32(row["idTrabalho"]);
                trampo.projetoID = Convert.ToInt32(row["projetoID"]);
                trampo.tarefas = Convert.ToInt32(row["tarefas"]);
                trampo.nota = Convert.ToString(row["nota"]);
                trampo.data = Convert.ToDateTime(row["data"]);
                trampo.dataF = Convert.ToDateTime(row["dataF"]);
                trampo.inicio = Convert.ToString(row["inicio"]);
                trampo.final = Convert.ToString(row["final"]);
                trampo.horas = Convert.ToString(row["horas"]);
                trampo.horaInt = Convert.ToString(row["horaInt"]);
                trampo.moeda = Convert.ToString(row["moeda"]);
                trampo.rendimento = Convert.ToString(row["rendimento"]);
                trampo.faturado = Convert.ToBoolean(row["faturado"]);
                trampo.idFaturaItem = Convert.ToInt16(row["idFaturaItem"]);
                //
                lista.Add(trampo);
            }
            return lista;
        }
        //
        //
        public static List<iTrabalho> listaItensFatura()
        {
            var lista = new List<iTrabalho>();
            var TrabDB = new Database.iTrabalhos();
            foreach (DataRow row in TrabDB.listaTrabalhos().Rows)
            {
                var trampo = new iTrabalho();
                trampo.idTrabalho = Convert.ToInt32(row["idTrabalho"]);
                trampo.projetoID = Convert.ToInt32(row["projetoID"]);
                trampo.tarefas = Convert.ToInt32(row["tarefas"]);
                trampo.nota = Convert.ToString(row["nota"]);
                trampo.data = Convert.ToDateTime(row["data"]);
                trampo.dataF = Convert.ToDateTime(row["dataF"]);
                trampo.inicio = Convert.ToString(row["inicio"]);
                trampo.final = Convert.ToString(row["final"]);
                trampo.horas = Convert.ToString(row["horas"]);
                trampo.horaInt = Convert.ToString(row["horaInt"]);
                trampo.moeda = Convert.ToString(row["moeda"]);
                trampo.rendimento = Convert.ToString(row["rendimento"]);
                trampo.faturado = Convert.ToBoolean(row["faturado"]);
                trampo.idFaturaItem = Convert.ToInt16(row["idFaturaItem"]);
                //
                lista.Add(trampo);
            }
            return lista;
        }
        //
        //*****************************************************//
        // RETORNA ID TRABALHOS
        /// <summary>
        /// Retornar o Último ID da Lista de Trabalhos Salvos
        /// </summary>
        /// <returns>Retornar ID</returns>
        public static List<iTrabalho> retornaID()
        {
            var lista = new List<iTrabalho>();
            var tab = new Database.iTrabalhos().retornaID();
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new iTrabalho()
                    {
                        idTrabalho = Convert.ToInt32(row["idTrabalho"])
                    });
                }
            }
            return lista;
        }
        //
        //
        //*****************************************************//
        //*****************************************************//
        //            LISTA TRABALHOS ENTRE DATAS              //
        //*****************************************************//
        //*****************************************************//
        /// <summary>
        /// Consulta Lista de Entradas de Trabalho entre Datas
        /// </summary>
        /// <param name="DataInicial"></param>
        /// <param name="DataFinal"></param>
        /// <returns>lista todos por data</returns>
        public static List<iTrabalho> consTrabalhosEntreDatas(DateTime DataInicial, DateTime DataFinal)
        {
            var lista = new List<iTrabalho>();
            var tab = new Database.iTrabalhos().EntreDatas(DataInicial, DataFinal);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new iTrabalho()
                    {
                        //idProj = Convert.ToInt32(row["idProj"]),
                        idTrabalho = Convert.ToInt32(row["idTrabalho"]),
                        projetoID = Convert.ToInt32(row["projetoID"]),
                        tarefas = Convert.ToInt32(row["tarefas"]),
                        nota = Convert.ToString(row["nota"]),
                        data = Convert.ToDateTime(row["data"]),
                        dataF = Convert.ToDateTime(row["dataF"]),
                        inicio = Convert.ToString(row["inicio"]),
                        final = Convert.ToString(row["final"]),
                        horas = Convert.ToString(row["horas"]),
                        horaInt = Convert.ToString(row["horaInt"]),
                        moeda = Convert.ToString(row["moeda"]),
                        rendimento = Convert.ToString(row["rendimento"]),
                        faturado = Convert.ToBoolean(row["faturado"]),
                        idFaturaItem = Convert.ToInt32(row["idFaturaItem"]),
                    });
                }
            }
            return lista;
        }
        //
        //******************************************************//
        // LISTA PROJETOS PELO IDPROJETO NA TABELA TRABALHOS
        /// <summary>
        /// Consulta Lista de Entradas de trabalho pelo id de Trabalho
        /// </summary>
        /// <param name="idTrabalho"></param>
        /// <returns>entrada pelo id</returns>
        public static List<iTrabalho> porTrabalhoID(int idTrabalho)
        {
            var lista = new List<iTrabalho>();
            var tab = new Database.iTrabalhos().porTrabalhoID(idTrabalho);
            if (tab.Rows.Count > 0)
            {
                foreach (DataRow row in tab.Rows)
                {
                    lista.Add(new iTrabalho()
                    {
                        //idProj = Convert.ToInt32(row["idProj"]),
                        idTrabalho = Convert.ToInt32(row["idTrabalho"]),
                        projetoID = Convert.ToInt32(row["projetoID"]),
                        tarefas = Convert.ToInt32(row["tarefas"]),
                        nota = Convert.ToString(row["nota"]),
                        data = Convert.ToDateTime(row["data"]),
                        dataF = Convert.ToDateTime(row["dataF"]),
                        inicio = Convert.ToString(row["inicio"]),
                        final = Convert.ToString(row["final"]),
                        horas = Convert.ToString(row["horas"]),
                        horaInt = Convert.ToString(row["horaInt"]),
                        moeda = Convert.ToString(row["moeda"]),
                        rendimento = Convert.ToString(row["rendimento"]),
                        faturado = Convert.ToBoolean(row["faturado"]),
                        idFaturaItem = Convert.ToInt32(row["idFaturaItem"]),
                    });
                }
            }
            return lista;
        }

        /// <summary>
        /// Função Salvar
        /// </summary>
        public void Salvar()
        {
            new Database.iTrabalhos().Salvar(this.idTrabalho,this.projetoID,this.tarefas,this.idFaturaItem,this.nota,this.data,this.dataF,this.inicio,this.final,this.horas,this.horaInt,this.moeda, this.rendimento,this.faturado);
        }

        /// <summary>
        /// Deletar item pelo ID de trabalho
        /// </summary>
        /// <param name="idTrabalho">Deletar</param>
        public void Deleta(int idTrabalho)
        {
            new Database.iTrabalhos().Deletar(idTrabalho);
        }
        
        /// <summary>
        /// Função Faturamento, altera o status da fatura do item e (IMPLEMENTAR: salvar o id do item retornado)
        /// </summary>
        /// <param name="idTrabalho">ID do Trabalho (referencia)</param>
        /// <param name="statusFat">Status da Fatura</param>
        public void Fatura(int idTrabalho, int statusFat, int idRetornado)
        {
            new Database.iTrabalhos().Faturar(idTrabalho,statusFat,idRetornado);
        }
    }
}
