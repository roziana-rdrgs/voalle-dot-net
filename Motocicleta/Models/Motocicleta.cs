namespace Motocicleta.Models;

public class Motocicleta
{
	public int Marcha { get; set; }
	public int Velocidade { get; set; }

	public Motocicleta()
	{
		Marcha = (int)Enumerators.Marcha.NEUTRO;
        Velocidade = 0;
	}
}