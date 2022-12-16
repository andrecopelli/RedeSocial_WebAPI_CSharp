using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace RedeSocial.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComentarioController
    {
        public List<Comentario> listaComentarios = new List<Comentario>()
        {
            new Comentario(1, "So colocar o z-index em 0.", DateTime.Now.AddDays(-364), "Ada Lovelace", 1),
            new Comentario(2, "Coloca width em 100vw e height em 100vh.", DateTime.Now.AddDays(-314), "Bill Gates", 1),
            new Comentario(3, "Reinicia.", DateTime.Now.AddDays(-260), "Kevin Mitnick", 2),
            new Comentario(4, "Reinicia apertando F10.", DateTime.Now.AddDays(-234), "Mark Zuckeberg", 2),
            new Comentario(5, "Instala o jdk de novo.", DateTime.Now.AddDays(-165), "Linus Torvalds", 3),
            new Comentario(6, "Versão errada amigo.", DateTime.Now.AddDays(-162), "Steve Wosniak", 3),
            new Comentario(7, "Estudando.", DateTime.Now.AddDays(-4), "Paul Allen", 4),
            new Comentario(8, "Tem um rapazinho indiando no youtube que é top.", DateTime.Now.AddDays(-1), "James Gosling", 4),
            new Comentario(9, "Na prática nenhuma.", DateTime.Now.AddDays(-1), "Grace Hopper", 5),
            new Comentario(10, "Da letra d pra frente muda tudo.", DateTime.Now.AddDays(-1), "Aaron Swartz", 5),
        };

        [HttpPost]
        public List<Comentario> Post([FromBody] Comentario comentario)
        {
            listaComentarios.Add(comentario);
            return listaComentarios;
        }

        [HttpGet]
        [Route("{id}")]
        public Comentario GetComentarioPorId(int id)
        {
            var comentario = listaComentarios.Find(c => c.Id == id);
            return comentario;
        }

        [HttpGet("porpublicacao/{idpublicacao}")]
        //[Route("{idpublicacao}")]
        public Comentario GetComentarioPorIdPublicacao(int idPublicacao)
        {
            var comentario = listaComentarios.Find(c => c.Publicacao.Id == idPublicacao);
            return comentario;
        }

        [HttpPatch]
        [Route("{id}")]
        public Comentario PatchCurtidaComentario(int id)
        {
            var comentarioBuscado = listaComentarios.Find(c => c.Id == id);
            comentarioBuscado.CurtirComentario();
            return comentarioBuscado;
        }

        [HttpDelete]
        [Route("{id}")]
        public List<Comentario> Delete(int id)
        {
            var comentarioBuscado = listaComentarios.Find(c => c.Id == id);
            listaComentarios.Remove(comentarioBuscado);
            return listaComentarios;
        }
    }
}
