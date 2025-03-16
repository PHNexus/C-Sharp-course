// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.Win32;

namespace ConsoleApp  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        // Declarar Variavel, Sem Declarar o Tipo
            var texto = ("Hello,World");  
            Console.WriteLine(texto);     

            // cor var, e uma maneira mais preguisosa de se Declarar 

            // Declaracao de variavel Com Tipo
            int numero1 = 1;         // Numero Inteiro
            float numero2 = 15.6F;   // Numero Real
            double numero3 = 125.61; //Numero Real
            bool numero4 = true;     // ou falso
            string texto2 = "texto"; // tipo texto entre aspas duplas

            // soma com Numero Inteiro
            int somas = 12;
            int soma = 12 + somas;
            Console.WriteLine(soma);

            // soma com Numero Real
            double somas1 = 24;
            double soma1 = 24 + somas1;
            Console.WriteLine(soma1);

            // Outras Formas De Declarar Variaveis

            // maneira mais avancada, Tipagem Dinamica

            dynamic cor_favorita = "Vermelho";
            Console.WriteLine(cor_favorita);

            // com variavel dinamica posso alterar o tipo dela
            cor_favorita = 212121;
            Console.WriteLine(cor_favorita);


                    // comentario com multiplas linhas /* */

            /*
             Int    || 156 como 32334 Numero Inteiro
             Float  || 15.6 como 234.123 Numero Real, Com Virgula ===> Double/ decimal
             Bool   || Boleano || so pode ter 2 valores verdadeiro ou falso
             String || tipo de dado 'Texto'
             Char   || '' aspas Simples 1 unico caracter
            */


            
            Console.Write("teste01");         // ira retornar teste 01
            Console.ReadLine();               // ira detectar oque o usuario,escreveu // ira esperar uma acao do usuario
            Console.Write("Hello World\n!"); // ira retornar Hello,World
            Console.Write("");

            // /n ira quebrar a linha agora
            // WriteLine ira escrever o comando na tela e quebrar a linha
        }
    }
}