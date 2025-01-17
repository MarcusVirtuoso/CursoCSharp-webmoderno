﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // propriedades autoimplementadas
        public double Preco { get; set; }

        // somente leitura
        public double PrecoComDesconto
        {
            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
            get => Preco - (desconto * Preco); // Lambda
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            // Não é possível atribuir valor a propriedade abaixo, pois esta é "somente leitura"
            //op1.PrecoComDesconto = 3000;

            CarroOpcional op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);

        }
    }
}
