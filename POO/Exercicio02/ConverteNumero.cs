using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class ConverteNumero
    {

        string num_convertido;
        public ConverteNumero()
        {
        }

        public string Num_convertido { get => num_convertido; set => num_convertido = value; }

        public string Converter(int numero)
        {
            
            switch (numero)
            {
                case 0:
                    Num_convertido = " Primeiro";
                    break;
                case 1:
                    Num_convertido = " Segundo";
                    break;
                case 2:
                    Num_convertido = " Terceiro";
                    break;
                case 3:
                    Num_convertido = " Quarto";
                    break;
                case 4:
                    Num_convertido = " Quinto";
                    break;
                default:
                    break;
            }//switch
            return Num_convertido;
        } //metodo
    } //class
} //namespace
