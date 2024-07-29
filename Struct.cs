using System;

namespace Teste
{
    public class Struct
    {
        //ISTÂNCIANDO
        static void PriceProduct(){
            var Product = new Product();

            Product.Id = 1;
            Product.Title = "Teclado PRO.";
            Product.Price = 130.99f;

            Console.WriteLine(Product.Id);
            Console.WriteLine(Product.Title);
            Console.WriteLine(Product.Price);
        }

        //ISTÂNCIANDO
        static void CarIten(){
            var Car = new Car("Ford",2015, true);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

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
        
        //A ANATOMIA DE UMA STRUCT NORMAMAENTE É:
        struct Product
        {
            // Propriedades
            public int Id;
            public float Price;
            public string Title;

            // Métodos
            public float PriceInDolar(float dolar){
                return Price * dolar;
            }

        };

        //APLICANDO MÉTODO CONSTRUTOR

        struct Car
        {
            public Car(string mark, int model, bool combustion)
            {
                var Mark = mark;
                var Model = model;
                var Combustion = combustion;
            }
        }
}