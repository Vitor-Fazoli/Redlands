using System.Text;
using Redlands.Common;
using Redlands;

// Helper.InitialConfiguration();

// StringBuilder sb = new();

// sb.AppendLine("Em um mundo assolado por um fungo insidioso, que não apenas corrompe a carne, mas também semeia a agressividade desenfreada,");
// sb.AppendLine("os sobreviventes se agruparam em cidades fortificadas e grupos de resistência, lutando para manter um último bastião de humanidade.");
// sb.AppendLine("O fungo, uma praga biológica desencadeada por eventos desconhecidos, transformou criaturas antes familiares em abominações ágeis e mortais. ");
// sb.AppendLine("É nesse cenário apocalíptico que você, um destemido habitante desse mundo pós-colapso, seu conhecimento especializado, habilidades de rastreamento e destreza em combate são a última linha de defesa contra a extinção.");
// sb.AppendLine("Embarque nesta jornada, onde cada decisão pode ser a diferença entre a sobrevivência e a decadência. Enfrente criaturas mutantes, explore cidades em ruínas e descubra segredos enterrados sob as cinzas do antigo mundo.");
// sb.AppendLine("Em Redlands, a linha entre a ciência e o pesadelo desfocou, e agora, sua história está prestes a se desenrolar em meio ao caos fungoso que envolve o planeta.");
// sb.AppendLine("Prepare-se para a batalha, pois a luta pela sobrevivência está apenas começando.");

// Helper.WriteText(sb.ToString());


// Console.WriteLine("Escolha o nome do seu personagem:");
// string? name = Console.ReadLine();

// if (name is null)
// {
//     Console.WriteLine("O Nome não pode estar em branco, Escolha o nome do seu personagem:");
//     name = Console.ReadLine();
// }

// Console.Clear();

// Console.WriteLine($"Por favor {name}, Selecione sua classe:");
// Console.WriteLine("1 - Encouraçado");
// Console.WriteLine("2 - Fungomante");
// string? profissão = Console.ReadLine();



            List<Option>  options =
            [
                new("Thing", () => Environment.Exit(0)),
                new("Another Thing", () =>  Environment.Exit(0)),
                new("Yet Another Thing", () =>  Environment.Exit(0)),
                new("Exit", () => Environment.Exit(0)),
            ];

            // Set the default index of the selected item to be the first
            int index = 0;

            // Write the menu out
            Helper.WriteMenu("Escolha sua classe",options, options[index]);

            // Store key info in here
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        Helper.WriteMenu("Escolha sua classe",options, options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        Helper.WriteMenu("Escolha sua classe",options, options[index]);
                    }
                }
                // Handle different action for the option
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();


