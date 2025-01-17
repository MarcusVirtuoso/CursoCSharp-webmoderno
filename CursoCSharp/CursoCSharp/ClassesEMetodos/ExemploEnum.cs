﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int idAnimacao = (int)Genero.Animacao;
            Console.WriteLine(idAnimacao);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Up Altas Aventuras";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
