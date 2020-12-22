using System;
using System.Collections.Generic;

namespace Sistema_Produtos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor { get; set; }
        
        
        public List<Produto> ListaDeProdutos = new List<Produto>();
        public List<Marca> Marcas = new List<Marca>();        
        
        public void Cadastrar(){

            Produto novoPoduto = new Produto();

            Console.WriteLine("Digite o Codigo do produto :");
            novoPoduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto :");
            novoPoduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto :");
            novoPoduto.Preco = float.Parse(Console.ReadLine());

            novoPoduto.DataCadastro = DateTime.UtcNow;

            novoPoduto.Marca = Marca.CadastrarMarca();

            novoPoduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoPoduto);
            
        }
        public void Listar(){

           Console.ForegroundColor = ConsoleColor.Green;
           foreach (var item in ListaDeProdutos)
           {
               Console.WriteLine($" Codigo: {item.Codigo}");
               Console.WriteLine($" Nome: {item.NomeProduto}");
               Console.WriteLine($" Preço: R$ {item.Preco}");
               Console.WriteLine($" Data de cadastro: {item.DataCadastro}");
               Console.WriteLine($" Marca: {item.Marca.NomeMarca}");
               Console.WriteLine($" Cadastrado por: {item.CadastradoPor.Nome}");
           }
           Console.ResetColor();

        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }
        
    }
}