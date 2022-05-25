using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Animal
    {
        /// <summary>
        /// guarda o nome do animal de estimação
        /// </summary>
        string nome;

        /// <summary>
        /// guarda o tipo de animal animal que a pessoa tem,
        /// neste caso Cachorro, Gato ou Peixe
        /// </summary>
        string tipo;

        public Animal()
        {
        }


        /// <summary>
        /// metodo construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tipo"></param>
        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        /// <summary>
        /// verifica qual tipo de animal foi digitado pelo usuário e se está correto.
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool verificaTipo(string tipo)
        {
            if (tipo == "CACHORRO" || tipo == "GATO" || tipo == "PEIXE")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// verifica na lista de animais, as quantidades de cachorros, gatos e peixes
        /// </summary>
        /// <param name="lista"></param>
        public static void Quantidade(List<Animal> lista)
        {
            int quantidadeCachorro = 0;
            int quantidadeGato = 0;
            int quantidadePeixe = 0;

            foreach (Animal i in lista)
            {
                if (i.Tipo == "CACHORRO")
                {
                    quantidadeCachorro++;

                }
                else if (i.Tipo == "GATO")
                {
                    quantidadeGato++;
                }
                else
                {
                    quantidadePeixe++;
                }
            }
            Console.WriteLine("A lista de animais de estimação possui as seguintes quantidades: ");
            Console.WriteLine("Cachorro: " + quantidadeCachorro);
            Console.WriteLine("Gato: " + quantidadeGato);
            Console.WriteLine("Peixe: " + quantidadePeixe);
        }

        /// <summary>
        /// verifica na lista de animais, as quantidades de cachorros, gatos e peixes - com return
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string retornaQuantidade(List<Animal> lista)
        {
            int quantidadeCachorro = 0;
            int quantidadeGato = 0;
            int quantidadePeixe = 0;

            foreach (Animal i in lista)
            {
                if (i.Tipo == "CACHORRO")
                {
                    quantidadeCachorro++;

                }
                else if (i.Tipo == "GATO")
                {
                    quantidadeGato++;
                }
                else
                {
                    quantidadePeixe++;
                }
            }
            return " Cachorro: " + quantidadeCachorro +
                "\n Gato: " + quantidadeGato +
                "\n Peixe: " + quantidadePeixe;

        }
    }
}
