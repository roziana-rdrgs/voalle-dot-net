namespace Motocicleta.Interfaces.IService;
public interface IMotocicletaService
{
    public Models.Motocicleta Acelerar(Models.Motocicleta motoclicleta);
    public Models.Motocicleta Frear(Models.Motocicleta motoclicleta);
    public int AlterarMarcha(Models.Motocicleta motoclicleta);
}