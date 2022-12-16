using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RedeSocial.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PublicacaoController
    {
        public static List<Publicacao> listaPublicacoes = new List<Publicacao>()
        {
            new Publicacao(1, DateTime.Now.AddDays(-365), "Como centraliza uma Div?", "André Copelli"),
            new Publicacao(2, DateTime.Now.AddDays(-265), "O erro não tem nada haver com a atualização, o que faço agora?", "Uncle Bob"),
            new Publicacao(3, DateTime.Now.AddDays(-165), "No meu computador funciona, e agora?", "Frederick P. Brooks Jr."),
            new Publicacao(4, DateTime.Now.AddDays(-5), "Qual o modo fácil de aprender Java?", "Martin Fowler"),
            new Publicacao(5, DateTime.Now.AddDays(-1), "Qual a diferença de um decimal para um double?", "Eric Evans"),
        };

        [HttpPost]
        public List<Publicacao> Post([FromBody] Publicacao publicacao)
        {
            listaPublicacoes.Add(publicacao);
            return listaPublicacoes;
        }

        [HttpGet]
        [Route("{id}")]
        public Publicacao GetPublicacaoPorId(int id)
        {
            var publicacao = listaPublicacoes.Find(p => p.Id == id);
            return publicacao;
        }

        [HttpPatch]
        public List<Publicacao> PatchDataPublicacao([FromBody] Publicacao publicacaoEditada)
        {
            var publicacaoBuscada = listaPublicacoes.Find(f => f.Id == publicacaoEditada.Id);
            publicacaoBuscada.DataPublicacao = publicacaoEditada.DataPublicacao;
            return listaPublicacoes;
        }

        [HttpPatch]
        [Route("{id}")]
        public Publicacao PatchCurtidaPublicacao(int id)
        {
            var publicacaoBuscada = listaPublicacoes.Find(f => f.Id == id);
            publicacaoBuscada.CurtirPublicacao();
            return publicacaoBuscada;
        }

        [HttpDelete]
        [Route("{id}")]
        public List<Publicacao> Delete(int id)
        {
            var publicacaoBuscada = listaPublicacoes.Find(f => f.Id == id);
            listaPublicacoes.Remove(publicacaoBuscada);
            return listaPublicacoes;
        }

    }
}
