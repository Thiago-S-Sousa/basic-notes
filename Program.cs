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

        //OPERADOR CONDICIONAL IF

        int anoAtual = 2024;
        int anoNascimento = 1957;

        int idadeAtual = anoAtual - anoNascimento;

        Console.WriteLine(idadeAtual);

        byte idadeMinima = 16;
        byte maiorIdade = 18;
        byte idadeMaxima = 65;

        if(idadeAtual >= maiorIdade && idadeAtual < idadeMaxima)
        {
            Console.WriteLine("Maior de idade! Voto obrigatório!");
        } else if(idadeAtual >= idadeMinima && idadeAtual < maiorIdade)
        {
            Console.WriteLine("Menor de idade, voto opcional.");
        }else
        {
            Console.WriteLine("Idade incompatível! Você não pode votar.");
        }

        // ESTRUTURA CONDICIONAL SWITCH

        /*
            DEFINIÇÕES

            UTILIZADO QUANDO SE TEM MUITAS DECISÕES
            EXECUÇÃO EM CASCATA
            DEVEMOS PARAR MANUALMENTE A EXECUÇÃO ATRAVÉS DO COMANDO BREAK
            CASO NENHUMA DAS CONDIÇÕES FOREM ATENDIDAS CAI NA EXECUÇÃO PADRÃO - DEFAULT
        */

        string nacionalidade = "ARG";

        switch(nacionalidade){
            case "BR" : Console.WriteLine("você é brasileiro.");
                break;
            case "CA" : Console.WriteLine("You are canadian.");
                break;
            case "EUA" : Console.WriteLine("Are you a U.S. citizen.");
                break;
            case "PAR" : Console.WriteLine("Eres de Paraguay.");
                break;
            default : Console.WriteLine("Nationality not identified, contact our operators.");
                break;
        }

        bool? valorBool = null;

        switch(valorBool){
            case true : Console.WriteLine("Valor verdadeiro."); break;
            case false : Console.WriteLine("Valor falso."); break;
            default: Console.WriteLine("Valor nullo."); break;
        }

        //LAÇOS DE REPETIÇÃO
        //FOR

        /*
            DEFINIÇÕES

            TRADUÇÃO "PARA", OU SEJA, PARA CADA ITEM EM UM VALOR
            EXECUTA UMA DETERMINADA AÇÃO VÁRIAS VEZES
            EXIGE 3 PARÂMETROS - CONTADOR, CONDIÇÃO E INCREMENTO/DECREMENTO
        */

        //CONTA DE 0 A 5
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        } ;

        //CONTA DE 0 A 4
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        } ;

        //CONTA DE 5 A 0
        for (var i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);
        };

        //CONTA DO 1 A 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        } ;

        //WHILE

        /*
            DEFINIÇÕES

            TRADUÇÃO "ENQUANTO", OU SEJA, ENQUANTO UMA CONDIÇÃO FOR VERDADEIRA/ATENDIDA
            EXIGE APENAS UMA CONDIÇÃO
            CHECA A CONDIÇÃO ANTES DE EXECUTAR
        */

        int condicao = 0;

        //CONTA DE 0 A 5
        //EXIBE DE 0 A 5 NA TELA
        //DESSA FORMA A INCREMENTAÇÃO ACONTECE DEPOIS DA EXIBIÇÃO
        while(condicao <= 5)
        {
            Console.WriteLine(condicao);
            condicao++;
        }

        int mesmaCondicao = 0;

        //CONTA DE 0 A 5
        //EXIBE DE 1 A 6 NA TELA
        //DESSA FORMA A INCREMENTAÇÃO ACONTECE ANTES DA EXIBIÇÃO
        while(mesmaCondicao <= 5)
        {
            mesmaCondicao++;
            Console.WriteLine(mesmaCondicao);
        }

        //DO

        /*
            DEFINIÇÕES
            
            TRADUÇÃO "FAÇA", OU SEJA, REALIZE UMA AÇÃO ENQUANTO
            DEFINIDO PELA PALAVRA DO/WHILE
            CHECA A CONDIÇÃO DEPOIS DE EXECUTAR
        */

        int chequeDepois = 0;

        do
        {
            Console.WriteLine(chequeDepois);
            chequeDepois++;
        } while (chequeDepois <= 5);
    }
}