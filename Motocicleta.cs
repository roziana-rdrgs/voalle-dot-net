namespace Motocicleta.Models;
using Motoclicleta.Interfaces;

public class Motoclicleta: IMotocicleta
{
	public int Marcha { get; set; }
	public int Velocidade { get; set; }

	public Motoclicleta()
	{
		Marcha = Enumerators
	}

	public int Acelerar(int velocidade, int marchaAtual)
	{
		/*
		  O sistema deverá incrementar (5 em 5) a velocidade sempre que a moto for acelerada.

		Caso a velocidade seja 0, só será possível acelerar se a moto estiver na marcha 1.

		Caso a velocidade extrapole o valor máximo da marcha, ela não poderá ser
aumentada até que seja incrementada a marcha, possibilitando assim o aumento
da velocidade.
		 */
		if (velocidade == 0 && marchaAtual ==)
		{

		}
		return velocidade += 5;
	}

	public int Frear(int velocidade) {
		/*(frear)ela deverá ser decrementada(8 em 8)*/
		return velocidade -= 8;
	}

	public void AlterarMarcha(int marcha);
}