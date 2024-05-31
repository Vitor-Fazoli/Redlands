using Microsoft.Extensions.Configuration;

using Redlands.Application.Windows;
using Redlands.Infrastructure;
using Terminal.Gui;

internal class Program
{
    public static Supabase.Client? supabase;
    public static Supabase.Gotrue.Session? session;

    private static async Task Main()
    {
        Console.Title = "Redlands";

        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        supabase = await SupabaseConnection.Init(config) ?? throw new Exception("Supabase connection failed");

        Application.Run<LoginWindow>();

        Application.Shutdown();
    }
}


//* menu
// Console.Clear();
// Console.OutputEncoding = Encoding.UTF8;
// Console.CursorVisible = false;
// Console.WriteLine("\nUse as setas para navegar e pressione ENTER para selecionar:");
// (int left, int top) = Console.GetCursorPosition();
// var option = 1;
// var decorator = "-> ";
// ConsoleKeyInfo key;
// bool isSelected = false;

// while (!isSelected)
// {
//     Console.SetCursorPosition(left, top);

//     Console.WriteLine($"{(option == 1 ? decorator : "   ")}Iniciar");
//     Console.WriteLine($"{(option == 2 ? decorator : "   ")}Continue");
//     Console.WriteLine($"{(option == 3 ? decorator : "   ")}Exit");

//     key = Console.ReadKey(false);

//     switch (key.Key)
//     {
//         case ConsoleKey.UpArrow:
//             option = option == 1 ? 3 : option - 1;
//             break;

//         case ConsoleKey.DownArrow:
//             option = option == 3 ? 1 : option + 1;
//             break;

//         case ConsoleKey.Enter:
//             isSelected = true;
//             break;
//     }
// }

// 

// Console.WriteLine("Bem vindo ao Redlands, um jogo de aventura e sobrevivência em um mundo pós-apocalíptico.");
// bool isValid = false;
// string? loginInput;

// do
// {
//     Console.WriteLine("\nDigite 'L' para login ou 'C' para criar conta:");
//     loginInput = Console.ReadLine() ?? string.Empty;

//     if (loginInput.Equals("L", StringComparison.CurrentCultureIgnoreCase) || loginInput.Equals("C", StringComparison.CurrentCultureIgnoreCase))
//     {
//         isValid = true;
//     }
//     else
//     {
//         Console.WriteLine("Resposta inválida. Por favor, digite 'L' ou 'C'.");
//     }
// } while (!isValid);

// switch (loginInput)
// {
//     case "L":
//         break;
//     case "C":
//         Console.WriteLine("Digite o email no qual deseja realizar o cadastro: ");
//         string? email = Console.ReadLine() ?? string.Empty;

//         while (!email.Contains('@') || email == string.Empty)
//         {
//             Console.WriteLine("Email invalido, ou nulo");
//             Console.WriteLine("Digite o email no qual deseja realizar o cadastro: ");
//             Console.ReadLine();
//         }

//         Console.WriteLine("Digite sua senha (minimo 9 caracteres): ");
//         string? password = Auth.ReadPassword() ?? string.Empty;

//         while (password.Length < 9 || password == string.Empty)
//         {
//             Console.WriteLine("Senha muito curta, ou nulo");
//             Console.WriteLine("Digite sua senha (minimo 9 caracteres): ");
//             Auth.ReadPassword();
//         }

//         var session = await supabase.Auth.SignUp(email, password);

//         if (session != null)
//         {
//             Console.WriteLine("Usuário criado com sucesso");
//             Console.WriteLine("Antes de prosseguir ative sua conta, acessando seu email e clicando em confirmar");
//         }

//         break;
// }

// StringBuilder sb = new();

// sb.AppendLine("Em um mundo assolado por um fungo insidioso, que não apenas corrompe a carne, mas também semeia a agressividade desenfreada,");
// sb.AppendLine("os sobreviventes se agruparam em cidades fortificadas e grupos de resistência, lutando para manter um último bastião de humanidade.");
// sb.AppendLine("O fungo, uma praga biológica desencadeada por eventos desconhecidos, transformou criaturas antes familiares em abominações ágeis e mortais. ");
// sb.AppendLine("É nesse cenário apocalíptico que você, um destemido habitante desse mundo pós-colapso, seu conhecimento especializado, habilidades de rastreamento e destreza em combate são a última linha de defesa contra a extinção.");
// sb.AppendLine("Embarque nesta jornada, onde cada decisão pode ser a diferença entre a sobrevivência e a decadência. Enfrente criaturas mutantes, explore cidades em ruínas e descubra segredos enterrados sob as cinzas do antigo mundo.");
// sb.AppendLine("Em Redlands, a linha entre a ciência e o pesadelo desfocou, e agora, sua história está prestes a se desenrolar em meio ao caos fungoso que envolve o planeta.");
// sb.AppendLine("Prepare-se para a batalha, pois a luta pela sobrevivência está apenas começando.");

// Helper.WriteSleepyText(sb.ToString());

// while(true){
//     Combat.OnCombatProgress();
// }


// Console.WriteLine("Escolha o nome do seu personagem:");
// string? name = Console.ReadLine();

/*
    Aqui irei descrever o prologo, onde tudo vai se encaminhar para a história (Londrina, Brasil)

    Depois das noticias, o mundo ficou abalado, todos começaram a correr em direção aos mercados, 
    drogarias, postos de gasolina, virou um panico geral... 

    Com o medo de que este fungo se espalhasse para humanos, havia muitas pessoas que não saiam de casa,
    mas quando ele chegou, não havia mais tempo se esconder atrás de muros

    As criaturas que vivem no brasil agora eram capazes de acabar com muros de casas, carros, dependendo até
    mesmo prédios, mais de 60% da população no Brasil morreu, muitos pelos ataques, outros pela escassez de comidam
    até mesmo conflitos entre pessoas por comida.

    Você começa aí, muito caos nas ruas, milhares de mortos diariamente e muito ódio entre os sobreviventes

    você está em um escritório fazendo uma entrevista de emprego...

    Helena: Oi, tudo bem ? estamos muito interessados no seu perfil, depois de você ter feito a prova
    ficamos bem confiantes de que nosso caminhos estão alinhados!


    Agora, preciso fazer uma bateria de perguntas que talvez sejá um pouco desconfortavel


    Resposta: Vai em frente | Ok | Não tem outro teste não!

    Infelizmente, você precisa passar por esse processo, vou iniciar as perguntas beleza!

    Você se chama [ nome aleatorio ], certo ?

    Resposta: | Não | Sim |

    Não: digite seu nome ?

    Não: Nossa me desculpa, são muitos candidatos acabei me perdendo

    Sim: Perfeito [ nome aleatorio ], minha memoria ainda está boa

    Vamos lá, segunda pergunta: 

    Em uma possível guerra, qual cargo você teria ?

    Resposta: | Soldado | Médico | Engenheiro | Cientista |

    Soldado: Entendi, você é uma pessoa que gosta de resolver as coisas na base da força

    Médico: Entendi, você é uma pessoa que gosta de ajudar as pessoas

    Engenheiro: Entendi, você é uma pessoa que gosta de resolver problemas

    Cientista: Entendi, você é uma pessoa que gosta de descobrir coisas novas

    Ok, vamos lá para uma ultima pergunta [ nome ], //TODO: pensar em uma pergunta

    .//TODO: Finalizar o primeiro dialogo do jogo
*/



// if (name is null)
// {
//     Console.WriteLine("O Nome não pode estar em branco, Escolha o nome do seu personagem:");
//     name = Console.ReadLine();
// }

//          +----------------------------------------------------------------------+
//          | {entity.Name}              | Londrina  |                  EXPlorar   |
//          +----------------------------------------------------------------------+
//          |   INVentário  |                                                      |
//          +---------------+                                                      |
//          | p | p | p | p |                                                      |
//          +---------------+                                                      |
//          | p | p | p | p |                                                      |
//          +---------------+                                                      |
//          | p | p | p | p |                                                      |
//          +---------------+                                                      |
//          | p | p | p | p |                                                      |
//          +----------------------------------------------------------------------+

// Console.Clear();

// Console.WriteLine($"Por favor {name}, Selecione sua classe:");
// Console.WriteLine("1 - Encouraçado");
// Console.WriteLine("2 - Fungomante");
// string? profissão = Console.ReadLine();

// Entity accioli = new("Accioli", 0, 0, 6);
// accioli.SetDefault();

// // Entity inimigo = new("Inimigo do Accioli", 2, 2, 2);
// // inimigo.SetDefault();

// // Combat.OnCombatInit(accioli, inimigo);


// Save.FindOrCreateBaseDirectory();
// Save.SaveEntity(accioli);

// Console.WriteLine(Save.LoadEntity(accioli).ToString());

