using System;
using System.Collections.Generic;

namespace Sistema_Produtos.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        
        
        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> Marcas{ get; set; }

        public void CadastrarMarca(){

            Marca novaMarca = new Marca();
            Console.WriteLine("Digite o código da marca :");
            novaMarca.Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome da marca :");
            novaMarca.NomeMarca  = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);
        
        }

        public void Listar(){

            Console.WriteLine("Marcas Cadastradas :");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Codigo : {item.Codigo}");
                Console.WriteLine($" Nome : {item.NomeMarca}");
                Console.WriteLine($" Data de cadastro : {item.DataCadastro}");
            }
        }

        public void Deletar(int cod){
             Marca marcaDelete = Marcas.Find(z => z.Codigo == cod);
             Marcas.Remove(marcaDelete);
        }
        
        
        
        
        

        
        
        
    }
}