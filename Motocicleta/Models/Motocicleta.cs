using Motocicleta.Interfaces;

namespace Motocicleta.Models;

public class Motoclicleta: IMotocicleta
{
	public int Marcha { get; set; }
	public int Velocidade { get; set; }

	public Motoclicleta()
	{
		Marcha = (int)Enumerators.Marcha.NEUTRO;
        Velocidade = 0;
	}

	public int Acelerar(Motoclicleta veiculo)
	{
        /*
         Alterar para receber o objeto motocicleta ao invés das propriedades - msm coisa pro frear e alteração de marcha
         */
        if (veiculo.Velocidade == 0)
		{
			if (veiculo.Marcha == (int)Enumerators.Marcha.PRIMEIRA)
				veiculo.Velocidade += 5;
			else
                //não vai aumentar pq 
				return velocidade ;
		} 

		switch (marchaAtual)
		{
            //1a — 00 até 20 km/h
            case (int)Enumerators.Marcha.PRIMEIRA:
				
				if (velocidade >= 21)
				{
                    AlterarMarcha(velocidade);
                     velocidade += 5;
                }
				break;

            // 2a — 21 até 40 km/h
            case (int)Enumerators.Marcha.SEGUNDA:

                if (velocidade >= 40)
                {
                    AlterarMarcha(velocidade);
                     velocidade += 5;
                }
                break;

             // 3a — 41 até 60 km/h
            case (int)Enumerators.Marcha.TERCEIRA:

                if (velocidade >= 60)
                {
                    AlterarMarcha(velocidade);
                     velocidade += 5;
                }
                break;
        }

        return velocidade;
	}

	public int Frear(int velocidade, int marchaAtual) {
        /*(frear)ela deverá ser decrementada(8 em 8)*/

        /*
         ● Redução de marcha:
        o É possível trocar apenas uma marcha, caso a velocidade seja superior ao
        intervalo da marcha anterior.

        o Caso a velocidade seja interior ao intervalo da marcha, será possível trocar
        normalmente.
         */

        if (velocidade <= 8)
        {
            return 0;
        }

        switch (marchaAtual)
        {
            // 2a — 21 até 40 km/h
            case (int)Enumerators.Marcha.SEGUNDA:

                if (velocidade >= 20)
                    AlterarMarcha(velocidade);

                 velocidade -= 8;
                break;

            // 3a — 41 até 60 km/h
            case (int)Enumerators.Marcha.TERCEIRA:
                if (velocidade >= 40)
                    AlterarMarcha(velocidade);

                velocidade -= 8;
                break;
        }

        return velocidade;
	}

	public int AlterarMarcha(int velocidade)
    {
        int marcha = (int) Enumerators.Marcha.NEUTRO;
        switch (velocidade)
        {
            case >= 0 and <= 20:
                marcha = (int)Enumerators.Marcha.PRIMEIRA;
            break;

            case >= 21 and <= 40:
                marcha = (int)Enumerators.Marcha.SEGUNDA;
                break;

            case >= 41 and <= 60:
                marcha = (int)Enumerators.Marcha.TERCEIRA;
                break;
        }

        return marcha;
    }


}