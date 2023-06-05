using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Atividadescom_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Conrado";
            string nome2 = "Pedrita";
             int idade1 = 15;
            int idade2 = 19;
            bool cliente1= true;
            bool cliente2 = false;
            int qnt_cafe = 187;
            int qnt_cafe2 = 5;
            int qnt_cafe_total = qnt_cafe + qnt_cafe2;
            int qnt_cafe_restaurante = 200 - qnt_cafe;
            int qnt_cafe_restaurante2 = 200 - qnt_cafe2;




            
            
            Console.WriteLine("Aula 03 -Atividades com variáveis \n");

            Console.WriteLine("Olá!");
            Console.WriteLine("Bem-vindo ao sistema  de ususário do conradito");
            Console.WriteLine("Abaixo estão as informações dos usuários cadastrados no nosso sistema: \n \n");

            Console.WriteLine("----- Lista de usuários:");
            Console.WriteLine($"1- Nome: {nome1}, idade: {idade1}. É cliente: {cliente1}");
            Console.WriteLine($"2- Nome: {nome2}, idade: {idade2}. É cliente: {cliente2} \n");

            Console.WriteLine("----- Quantidade de cafés");
            Console.WriteLine($"O cliente {nome1} já tomou {qnt_cafe} cafés");
            Console.WriteLine($"O cliente {nome2} já tomou {qnt_cafe2} cafés \n");

            Console.WriteLine("----- Soma de cafés tomados");
            Console.WriteLine($" Junto, os clientes { nome1} e { nome2} tomaram { qnt_cafe_total} \n");
           

            Console.WriteLine("----- Quantos cafés faltam para chegar em 200?");
            Console.WriteLine($" Faltam {qnt_cafe_restaurante} para {nome1}");
            Console.WriteLine($" Faltam {qnt_cafe_restaurante2} para {nome2} \n");
            Console.WriteLine("----- Fim do sistema de consultas");
            Console.WriteLine("- Obrigado e volta sempre!");






            Console.ReadKey();
        }
    }
}
