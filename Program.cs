using System;

namespace Ex_passagem_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis 
            string[] nomes = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string [5];
                        
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---Sistema de passagens aéreas---");
            Console.WriteLine("---------------------------------");

            bool senhaValida;
            do
            {

                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);

            }while (!senhaValida);
            //Criar o menu
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        //Cadastrar a passagem
                        
                        for (var i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Digite o nome do {i+1}"º Passageiros);
                            nomes [i] = Console.ReadLine();
                            Console.WriteLine($"Digite a origem do {i+1}"º Passageiros);
                            origem [i] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino do {i+1}"º Passageiros);
                            destino [i] = Console.ReadLine();
                            Console.WriteLine($"Digite a data do vôo do {i+1}"º Passageiros);
                            data [i] = Console.ReadLine();
                        }

                        break;
                    case 2:
                        //Listar as passagens
                                for (var i = 0; i < 5; i++)
                                {
                                    Console.WriteLine($"Passageiro {nomes[i]}");
                                }
                        break;
                    case 3:
                        //Sair
                        break;

                    default:
                        break;
                }
                


            }while (true;)










            //Funções
            bool EfetuarLogin(string senha){

                if(senha == "123456"){
                    Console.WriteLine("Achei");
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }//fim efetuar login 

                void CadastrarPassageiros()
                {

                }
        }
    }
}
