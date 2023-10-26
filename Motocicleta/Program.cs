
Motocicleta.Models.Motoclicleta motocicleta = new Motocicleta.Models.Motoclicleta();

Console.WriteLine("Motocicleta - escolha uma opção:  a-acelerar  f-frear s-sair");

bool continuar = true;
while (continuar)
{
    switch (Console.ReadLine())
    {
        case "a":
            motocicleta.Velocidade = motocicleta.Acelerar(motocicleta.Velocidade, motocicleta.Marcha);
            Console.WriteLine($"Velocidade aumentada para {motocicleta.Velocidade}");
            Console.WriteLine($"Marcha atual {motocicleta.Marcha}");
            break;

        case "f":
            motocicleta.Velocidade =  motocicleta.Frear(motocicleta.Velocidade, motocicleta.Marcha);
            Console.WriteLine($"Velocidade reduzida para {motocicleta.Velocidade}");
            Console.WriteLine($"Marcha atual {motocicleta.Marcha}");
            break;

        case "s":
            continuar = false;
            break;

        default: Console.WriteLine("Opção inválida");
            break;
    }
}



