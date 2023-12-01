using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastros.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
        }
        public string Nome { get; set; }
        public List<string> Livros = new List<string>();
        private int Codigo { get; }
        
        public string AdicionarLivro()
        {
            Console.WriteLine($"Digite o código para {Nome}:");
            int codigoFornecido = Convert.ToInt32(Console.ReadLine());

            if(codigoFornecido != Codigo)
            {
                return "Acesso negado.";
            }

            Console.WriteLine("Digite o nome do livro para adiciona-lo: ");
            string livro = Console.ReadLine();
            Livros.Add(livro);

            return $"Livro {livro} adicionado com sucesso!";
        }

        public string RemoverLivro()
        {
            Console.WriteLine($"Digite o código para {Nome}:");
            int codigoFornecido = Convert.ToInt32(Console.ReadLine());

            if(codigoFornecido != Codigo)
            {
                return "Acesso negado.";
            }

            foreach (string livroCadastrado in Livros)
                {
                    Console.WriteLine(livroCadastrado);
                }

            Console.WriteLine("Digite o nome do livro que deseja remover: ");
            string livro = Console.ReadLine();
            if (Livros.Contains(livro))
            {
                Livros.Remove(livro);
                return $"O livro {livro} foi removido da sua lista.";
            }
            else
            {
                return $"Livro {livro} não encontrado.";
            }
        }

        public void ListarLivros()
        {
            Console.WriteLine($"Digite o código para {Nome}:");
            int codigoFornecido = Convert.ToInt32(Console.ReadLine());

            if(codigoFornecido != Codigo)
            {
                Console.WriteLine("Acesso negado.");
                return;
            }

            if(Livros.Any())
            {
                Console.WriteLine($"Os livros de {Nome} são: ");
                foreach (string livro in Livros)
                {
                    Console.WriteLine(livro);
                }
            }
            else
            {
                Console.WriteLine($"Não há livros na lista de {Nome}.");
            }

            return;
        }
    }
}