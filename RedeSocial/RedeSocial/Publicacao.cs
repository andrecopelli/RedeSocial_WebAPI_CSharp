using System;
using System.Collections.Generic;

namespace RedeSocial
{
    public class Publicacao
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Titulo { get; set; }
        public string Usuario { get; set; }
        public int CurtidasPublicacao { get; set; }

        public Publicacao(int id, DateTime dataPublicacao, string titulo, string usuario)
        {
            Id = id;
            DataPublicacao = dataPublicacao;
            Titulo = titulo;
            Usuario = usuario;
        }

        public Publicacao(int id)
        {
            Id = id;
        }

        public Publicacao()
        {

        }

        public int CurtirPublicacao()
        {
            CurtidasPublicacao = CurtidasPublicacao + 1;
            return CurtidasPublicacao;
        }
    }
}
