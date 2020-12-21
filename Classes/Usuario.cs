using System;

namespace Sistema_Produtos.Classes
{
    public class Usuario
    {

        public Usuario(){
            
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            
        }
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            
        }
        
        
    }
}