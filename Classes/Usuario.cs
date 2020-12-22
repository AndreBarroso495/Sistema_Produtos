using System;

namespace Sistema_Produtos.Classes
{
    public class Usuario
    {

        public Usuario(){
            
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome   = _nome;
            Email  = _email;
            Senha  = _senha;
            DataCadastro = DateTime.UtcNow;
        }
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            Nome = "Andre";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(){
            Nome  = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }
        
        
        
        
    }
}