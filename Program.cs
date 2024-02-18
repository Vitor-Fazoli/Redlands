using System.Text;
using Redlands.Common;
using Redlands;
using Redlands.Entities;
using Redlands.Abstract;
using Redlands.Common.System;

Helper.InitialConfiguration();


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

Console.WriteLine("Bem vindo ao Redlands, um jogo de aventura e sobrevivência em um mundo pós-apocalíptico.");

Console.ReadLine();

StringBuilder sb = new();

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

Entity accioli = new("Accioli", 0, 0, 6);
accioli.SetDefault();

// Entity inimigo = new("Inimigo do Accioli", 2, 2, 2);
// inimigo.SetDefault();

// Combat.OnCombatInit(accioli, inimigo);


Save.FindOrCreateBaseDirectory();
Save.SaveEntity(accioli);

Console.WriteLine(Save.LoadEntity(accioli).ToString());

