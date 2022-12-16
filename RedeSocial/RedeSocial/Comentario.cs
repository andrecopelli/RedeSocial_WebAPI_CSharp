using RedeSocial.Controllers;
using System;
using System.Collections.Generic;

namespace RedeSocial
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataComentario { get; set; }
        public string Usuario { get; set; }
        public int CurtidasComentario { get; set; }
        public Publicacao Publicacao { get; set; }

        public Comentario(int id, string descricao, DateTime dataComentario, string usuario , int publicacaoId)
        {
            Id = id;
            Descricao = descricao;
            DataComentario = dataComentario;
            Usuario = usuario;
            var publicacao = PublicacaoController.listaPublicacoes.Find(p => p.Id == publicacaoId);
            Publicacao = publicacao;
        }

        public Comentario()
        {
                
        }

        public int CurtirComentario()
        {
            CurtidasComentario = CurtidasComentario + 1;
            return CurtidasComentario;
        }
    }
}
