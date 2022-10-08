using System;

namespace Game // RPG no estilo antigo :)
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1- Seja bem Vindo");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Selecione o número:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: ola(); break;
                default: Menu(); break;
            }

        }
        static void ola()
        {
            Console.Clear();

            Console.WriteLine("1- abrir a porta");
            Console.WriteLine("2- seguir em frente");

            Console.WriteLine("Escolha um número:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Abriu(); break;
                case 2: Seguiu(); break;
                default: ola(); break;
            }
        }
        static void Abriu()
        {
            Console.Clear();

            Console.WriteLine("Você abriu a porta e viu uma mulher");
            Console.WriteLine("");
            Console.WriteLine("1- Falar com ela");
            Console.WriteLine("2- Ignorar ela");

            Console.WriteLine("Selecione o número:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Falou(); break;
                case 2: Ignorou(); break;
                default: Abriu(); break;
            }
        }
        static void Seguiu()
        {
            Console.Clear();

            Console.WriteLine("Você seguiu e viu um campo grande, Começou a chover muito");
            Console.WriteLine("");
            Console.WriteLine("1- Correr no meio do campo");
            Console.WriteLine("2- Se abrigar no celeiro próximo");

            Console.WriteLine("Escolha um número");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Correu(); break;
                case 2: Abrigou(); break;
                default: Seguiu(); break;
            }
        }
        static void Falou()
        {
            Console.Clear();

            Console.WriteLine("Você falou com ela e ganhou um mapa para o seu destino");
            Console.WriteLine("");
            Console.WriteLine("1- Seguir viagem");

            Console.WriteLine("Selecione o número:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Seguirviagem(); break;
                default: Falou(); break;
            }
        }
        static void Ignorou()
        {
            Console.Clear();

            Console.WriteLine("Você a ignorou e foi expulso da casa, ");
            Console.WriteLine("");
            Console.WriteLine("1- Seguir para o campo aberto");
            Console.WriteLine("2- Seguir para a cabana");

            Console.WriteLine("Escolha um número");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Seguiu(); break;
                case 2: Abrigou(); break;
                default: Ignorou(); break;
            }
        }
        static void Correu()
        {
            Console.Clear();

            Console.WriteLine("Você correu no meio da chuva e foi antigido por um raio");
            Console.WriteLine("Você morreu");

            Console.ReadKey();
            Menu();
        }
        static void Abrigou()
        {
            Console.Clear();

            Console.WriteLine("Você entrou numa cabana próxima. Um homem se aproxima");
            Console.WriteLine("");
            Console.WriteLine("1- Expulsa-lo");
            Console.WriteLine("2- Dar espaço para ele");

            Console.WriteLine("Escolha um número");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Expulsou(); break;
                case 2: Deuespaco(); break;
                default: Abrigou(); break;
            }
        }
        static void Seguirviagem()
        {
            Console.WriteLine("Você chegou no seu destino e agora pode descansar em paz");
            Console.WriteLine("Fim do jogo");

            Console.ReadKey();

        }
        static void Expulsou()
        {
            Console.Clear();

            Console.WriteLine("Você expulsou o homem e ele te esfaqueou de raiva");
            Console.WriteLine("");
            Console.WriteLine("Você morreu");

            Console.ReadKey();
            Menu();
        }
        static void Deuespaco()
        
        {
            Console.Clear();

            Console.WriteLine("Você deu espaço para o homem e ficou sem o seu.");
            Console.WriteLine("Você volta para o campo aberto.");
            Console.WriteLine("");
            Console.WriteLine("1- Correr no meio do campo");

            Console.WriteLine("Escolha um número");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Correu(); break;
                default: Deuespaco(); break;
            }
        }
    }
}