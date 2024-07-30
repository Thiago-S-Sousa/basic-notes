//STRUCTS

    /*
        DEFINIÇÕES

        TIPOS DE DADO ESTRUTURADO
        APENAS A ESTRUTURA, O ESQUELETO
        VALUE TYPE
        ARMAZENAM APENAS OUTROS TIPOS DE DADOS
        DEFINIDO PELA PALAVRA STRUCT
        COMPOSTO DE PROPRIEDADES E MÉTODOS
        NOME SEMPRE COM MAIÚSCULO
            - O MESMO PARA PROPRIEDADES E MÉTODOS
        CRIADO A PARTIR DA PALAVRA NEW
            - NESTE MOMENTO SIM TEMOS OS VALORES
    */
    
namespace Teste
{
    public class Struct
    {
        
    }

    public struct Products{
        public string Title;
        public double Price;
        public string Description;

        public double PriceInDolar(double dolar){
            return Price * dolar;
        }
    }


    public struct Users{
        public Users(string name, byte age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality;

        }
        public string Name;
        public byte Age;
        public string Nationality;
    }
}