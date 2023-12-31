﻿using System;

namespace LocadoraWebApi.Entidades
{
    public class Filme
    {
        #region Atributes

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public bool Disponivel { get; set; }
        public bool Ativo { get; set; }

        #endregion
        public Filme() { }
        public Filme(string nome, string genero, bool ativo)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Genero = genero;
            this.Ativo = ativo;
            this.Disponivel = true;
        }
        
        
    }
}
