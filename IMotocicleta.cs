namespace Motocicleta.Interfaces;
public interface IMotocicleta 
{
	/*
	 Criar um algoritmo que simule uma motocicleta, onde seja possível acelerar, frear e realizar
a troca de marchas (0 - neutro, 1 – primeira, 2 – segunda, etc).
	 */

	public int Acelerar(int velocidade);

	public int Frear(int velocidade);

	public void AlterarMarcha(int marcha);
}