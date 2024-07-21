using System;

namespace Teste;
class Program
{   
    static void Main(string[] args)
    {
        var texto = "testando";
        Console.WriteLine(texto);

        // DEFINIÇÂO DE VARIÀVEIS

        /*  
            TIPO NOME = VALOR

            int idade; Correto
            int idade = 25; Correto
            var idade = 25; Correto
            var idade; Incorreto
        */

        //--- TIPOS PRIMITIVOS ---

        // NÙMEROS INTEIROS
        // BYTE e SBYTE

        /*
            DEFINIÇÔES

            BYTE (8 bit) - do número 0 até 255 positivo
            SBYTE (8 bit) - do número -128 negativo até 127 positivo
        */

        byte meuByte = 127;
        sbyte meuSByte = -88;

        // SHORT e USHORT

        /*
            DEFINIÇÔES

            SHORT (16 bit) - do número -32,768 negativo até 32,767 positivo
            USHORT (16 bit) - do número 0 até 65,535 positivo
        */

        short pagamentoMensal = -27789;
        ushort lucroMensal = 62000;

        // INT e UINT

        /*
            DEFINIÇÔES

            INT (32 bit) - do número -2,147,483,648 negativo até 2,147,483,647 positivo
            UINT (32 bit) - do número 0 até 4,294,967,295 positivo
        */

        int defitMetaAnual = -1987500231;
        uint lucroAnualEstimado = 500000000;

        // LONG e ULONG

        /*
            DEFINIÇÔES

            LONG (64 bit) - do número -9,223,372,036,854,775,808 negativo até 9,223,372,036,854,775,807 positivo
            ULONG (64 bit) - do número 0 até 18,446,744,073,709,551,615 positivo
        */

        long dividaAtivaTotal = -8000000000000000000;
        ulong SaldoDisponível = 14900543271000000012;

        // NÙMEROS REAIS
        // FLOAT, DOUBLE e DECIMAL

        /*
            DEFINIÇÔES

            FLOAT (32 bit) - do número -3.402823e38 até 3.402823e38
            DOUBLE (64 bit) - do número -1.79769313486232e308 até 1.79769313486232e308
            DECIMAL (128 bit) - (+ ou -) 1.0 * 10e-28 até 7.9 * 10e28
        */

        float salario = 2.500f; // NOTAÇÂO - (f)
        double pagamentoTotal = 25.000;
        decimal meuDecimal = 250.000m; // NOTAÇÂO - (m)

        //BOOLEAN
        // BOOL

        /*
            DEFINIÇÔES

            BOOL (8 bit) - true ou false
        */

        bool usuarioJaCadastrado = true;
        bool pagamentoEfetuado = false;

        //CARACTERE ÚNICO
        //CHAR

        /*
            DEFINIÇÔES

            CHAR (16 bit) - Qualquer caractere (formato Unicode / aspas simples - '')
        */

        char primeiraLetra = 'T';

        //LISTA DE CARACTERES
        //STRING

        /*
            DEFINIÇÔES

            STRING (depende do tamanho da string) - Uma cadeia de caracteres (aspas duplas - "")
        */

        string nomeCompleto = "José Bezerra Valencar";

        //OBJECT

        /*
            DEFINIÇÔES

            TIPO DESCONHECIDO - ACEITA QUALQUER VALOR E SUA MUDANÇA POSTERIORMENTE
            USO NÃO ACONSELHADO
        */

        //TIPOS NULOS
        //NULL

        /*
            DEFINIÇÔES

            TIPO VAZIO (NADA) - DIFERENTE DE 0 OU UMA STRING VAZIA
            PARA ATRIBUIR NULL A UM OBJETO, É NECESSÁRIO QUE ESTE SEJA MARCADO COMO NULLABLE (?)
        */

        int? idade = null;
        Console.WriteLine(idade);

        //CONVERSÕES
        //PARSE

        /*
            DEFINIÇÕES

            MÉTODO PRESENTE EM TODOS OS TIPOS PRIMITIVOS
            SEMPRE ESPERA UMA STRING OU CARACTERE
            CASO HAJA ALGUMA INCOMPATIBILIDADE, GERA UM ERRO
        */

        string cpf = "12345678910";
        ulong inteiro = ulong.Parse(cpf);

        Console.WriteLine(inteiro);

        //CONVERT

        /*
            DEFINIÇÕES

            MÉTODO PRESENTE EM TODOS OS TIPOS PRIMITIVOS
            É POSSÍVEL CONVERTER VÁRIOS TIPOS DE VALOR (NÃO APENAS CARACTERES COMO NO PARSE)
            DEVEMOS INFORMAR O TIPO NA CHAMADA DA CONVERSÃO
            CASO HAJA ALGUMA INCOMPATIBILIDADE, GERA UM ERRO
        */

        bool maiorDeIdade = true;
        byte idadeBoll = Convert.ToByte(maiorDeIdade);

        Console.WriteLine(idadeBoll);

        //CONVERSÃO IMPLÍCITA - SEM A NECESSIDADE DE EXPLICITAR O TIPO

        int quantidadeSemanal = 7;
        float notaRedacao = 5.1f;

        /*
            quantidadeSemanal = notaRedacao; 
            ERRADO - INCOMPATIBILIDADE DE TIPOS DE DADOS 
        */

        notaRedacao = quantidadeSemanal;

        //CONVERSÃO EXPLÍCITA - É NECESSÁRIO EXPLICITAR O TIPO

        quantidadeSemanal = (int)notaRedacao;
        Console.WriteLine(quantidadeSemanal);

        //MÉTODO TOSTRING PARA CONVERSÃO COM PARSE

        double populacaoLocal = 17.89672223;

        /*
            string pop = populacaoLocal.ToString(); - CONVERTENDO PARA STRING
            int populacao = int.Parse(pop); - CONVERTENDO PARA INTEIRO ATRAVÉS DO PARSE
    
            ERRADO - INCOMPATIBILIDADE DE TIPOS DE DADOS
        */

        int populacao = Convert.ToInt32(populacaoLocal);

        Console.WriteLine(populacao);

    }
}