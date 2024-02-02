using System.Text;
using Redlands;
using Redlands.Entities;

Helper.InitialConfiguration();

StringBuilder sb = new();

sb.AppendLine("Em um mundo assolado por um fungo insidioso, que não apenas corrompe a carne, mas também semeia a agressividade desenfreada,");
sb.AppendLine("os sobreviventes se agruparam em cidades fortificadas e grupos de resistência, lutando para manter um último bastião de humanidade.");
sb.AppendLine("O fungo, uma praga biológica desencadeada por eventos desconhecidos, transformou criaturas antes familiares em abominações ágeis e mortais. ");
sb.AppendLine("É nesse cenário apocalíptico que você, um destemido habitante desse mundo pós-colapso, seu conhecimento especializado, habilidades de rastreamento e destreza em combate são a última linha de defesa contra a extinção.");
sb.AppendLine("Embarque nesta jornada, onde cada decisão pode ser a diferença entre a sobrevivência e a decadência. Enfrente criaturas mutantes, explore cidades em ruínas e descubra segredos enterrados sob as cinzas do antigo mundo.");
sb.AppendLine("Em Redlands, a linha entre a ciência e o pesadelo desfocou, e agora, sua história está prestes a se desenrolar em meio ao caos fungoso que envolve o planeta.");
sb.AppendLine("Prepare-se para a batalha, pois a luta pela sobrevivência está apenas começando.");

Helper.WriteText(sb.ToString());


Console.WriteLine("Escolha o nome do seu personagem:");
string? name = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Seja Bem vindo {name}");
Console.WriteLine("Selecione sua classe:");


Console.ReadLine();

