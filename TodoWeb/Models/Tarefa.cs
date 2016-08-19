using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWeb.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public string NomeTarefa { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
    }
}