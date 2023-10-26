using Motocicleta.Services;

MotocicletaService service = new();


Console.WriteLine("Escolha uma opção:  " +
                    "\n\ta: acelerar  " +
                    "\n\tf: frear " +
                    "\n\ts: sair" +
                    "\n");

Motocicleta.Models.Motocicleta motocicleta = new();

Console.WriteLine("Motocicleta ligada.");
Console.WriteLine($"Velocidade:::: {motocicleta.Velocidade}");
Console.WriteLine($"Marcha:::::::: {motocicleta.Marcha}");


motocicleta.Marcha = service.AlterarMarcha(motocicleta);

bool continuar = true;
while (continuar)
{
    switch (Console.ReadLine()?.ToLower())
    {
        case "a":
            motocicleta = service.Acelerar(motocicleta);
            Console.WriteLine($"Velocidade:::: {motocicleta.Velocidade}");
            Console.WriteLine($"Marcha:::::::: {motocicleta.Marcha}");
            break;

        case "f":
            motocicleta = service.Frear(motocicleta);
            Console.WriteLine($"Velocidade:::: {motocicleta.Velocidade}");
            Console.WriteLine($"Marcha:::::::: {motocicleta.Marcha}");
            break;

        case "s":
            continuar = false;
            break;

        default: Console.WriteLine("Comando inválido.");
            break;
    }
}



