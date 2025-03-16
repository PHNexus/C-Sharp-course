// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.Win32;

namespace ConsoleApp  
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var texto = ("Hello,World"); // variavel

            Console.WriteLine(texto);
            Console.WriteLine(texto*5);



            // /n ira quebrar a linha agora || WriteLine ira escrever o comando na tela e quebrar a linha
            // Console.Write("teste01");|| // ira retornar teste 01
            // Console.ReadLine();      || // ira detectar oque o usuario,escreveu // ira esperar uma acao do usuario
            //Console.Write("Hello World\n!"); // ira retornar Hello,World
           //   Console.Write(""); 
        }
    }
}