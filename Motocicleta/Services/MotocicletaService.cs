using Motocicleta.Interfaces.IService;
using static Motocicleta.Models.Enumerators;

namespace Motocicleta.Services;

public class MotocicletaService : IMotocicletaService
{
    public Models.Motocicleta Acelerar(Models.Motocicleta motocicleta)
    {
        if (motocicleta.Velocidade == 0)
        {
            if (motocicleta.Marcha == (int)Marcha.PRIMEIRA)
            {
                motocicleta.Velocidade += 5;
                return motocicleta;
            }
            else
                return motocicleta;
        }

        switch (motocicleta.Marcha)
        {
            case (int)Marcha.PRIMEIRA:
                if (motocicleta.Velocidade >= 0 && motocicleta.Velocidade <= 20)                
                    motocicleta.Velocidade += 5;
                
                if (motocicleta.Velocidade >= 21)                
                    motocicleta.Marcha = AlterarMarcha(motocicleta);
                
                break;

            case (int)Marcha.SEGUNDA:
                if (motocicleta.Velocidade < 21)
                    motocicleta.Velocidade -= 2;

                if (motocicleta.Velocidade >= 21 && motocicleta.Velocidade <= 40)    
                    motocicleta.Velocidade += 5;
                
                if (motocicleta.Velocidade >= 41)                
                    motocicleta.Marcha = AlterarMarcha(motocicleta);
                
                break;

            case (int)Marcha.TERCEIRA:
                if (motocicleta.Velocidade < 41)
                    motocicleta.Velocidade -= 2;

                if (motocicleta.Velocidade >= 41 && motocicleta.Velocidade <= 60)
                    motocicleta.Velocidade += 5;
                
                if (motocicleta.Velocidade >= 61)
                    motocicleta.Marcha = AlterarMarcha(motocicleta);
                
                break;

            case (int)Marcha.QUARTA:
                if (motocicleta.Velocidade < 61)
                    motocicleta.Velocidade -= 2;

                if (motocicleta.Velocidade >= 61 && motocicleta.Velocidade <= 80)
                    motocicleta.Velocidade += 5;

                if (motocicleta.Velocidade >= 81)
                    motocicleta.Marcha = AlterarMarcha(motocicleta);

                break;

            case (int)Marcha.QUINTA:
                if (motocicleta.Velocidade <  81)
                    motocicleta.Velocidade -= 2;

                if (motocicleta.Velocidade >= 81 && motocicleta.Velocidade <= 100)
                    motocicleta.Velocidade += 5;
                break;
        }

        return motocicleta;
    }

    public int AlterarMarcha(Models.Motocicleta motoclicleta)
    {
        int marcha = (int)Marcha.NEUTRO;

        Console.WriteLine(":::::Realizando troca de marcha:::::");
        Console.Beep();
        switch (motoclicleta.Velocidade)
        {
            case >= 0 and <= 20:
                marcha = (int)Marcha.PRIMEIRA;
                break;

            case >= 21 and <= 40:
                marcha = (int)Marcha.SEGUNDA;
                break;

            case >= 41 and <= 60:
                marcha = (int)Marcha.TERCEIRA;
                break;
            case >= 61 and <= 80:
                marcha = (int)Marcha.QUARTA;
                break;
            case >= 81 and <= 100:
                marcha = (int)Marcha.QUINTA;
                break;
        }
        return marcha;
    }

    public Models.Motocicleta Frear(Models.Motocicleta motocicleta)
    {
        if (motocicleta.Velocidade <= 8)
            motocicleta.Velocidade = 0;
        else
            motocicleta.Velocidade -= 8;

        motocicleta.Marcha = AlterarMarcha(motocicleta);
 

        return motocicleta;
    }
}
