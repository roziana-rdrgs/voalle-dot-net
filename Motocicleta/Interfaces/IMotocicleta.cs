namespace Motocicleta.Interfaces;
public interface IMotocicleta 
{
	/*
	 Criar um algoritmo que simule uma motocicleta, onde seja possível acelerar, frear e realizar
a troca de marchas (0 - neutro, 1 – primeira, 2 – segunda, etc).
	 */

	public int Acelerar(int velocidade, int marchaAtual);

	public int Frear(int velocidade, int marchaAtual);

	public int AlterarMarcha(int velocidade);
}