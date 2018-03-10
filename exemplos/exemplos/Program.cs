using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio
            Console.WriteLine("Meu aplicativo\n\n");
            var idade = 18;
            var nomePessoa = "João ";
            String sobrenome = "da Silva";

            String nomeMae;
            nomeMae = "Joana";
            int idadeMae = 54;


            String NomeCompleto(String primeiro, String segundo)
            {
                return primeiro + segundo;
            }

            void CalculoIdade(int idade1, int idade2)
            {
                int idadetotal = idade1 + idade2;
                Console.WriteLine("\n\nIdade Filho + idade da Mãe: " + idadetotal);

            }
            Console.WriteLine("Nome: " + nomePessoa + " " + sobrenome+"\n" + "Idade: " + idade);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Teste...\nIdade: " + idade.ToString());
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Nome da mãe: "+nomeMae);
            Console.WriteLine("\nIdade da mãe: " + idadeMae);
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Nome Completo: "+ NomeCompleto(nomePessoa, sobrenome));
            Console.WriteLine("\n\n\n");
            CalculoIdade(idade,idadeMae);

            Console.WriteLine("\n-----------------------------------------------------------");
            var pessoa = new Pessoa();
            pessoa.Nome = nomePessoa;
            pessoa.Sobrenome = sobrenome;
            pessoa.Cpf = "123456789-00";

            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.Cpf}");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Nome: {pessoa.Nome}",pessoa.NomeCompleto(pessoa.Nome,pessoa.Sobrenome));

            Console.ReadKey();
        }
    }
}
