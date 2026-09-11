using GM_Frota.entities;

namespace GM_Frota.interfaces
{
    public interface IFuncionarioTransporte
    {
        string Nome { get; set; }
        string Registro { get; set; }

        IVeiculo Veiculo { get; set; } 

        void MostrarDetalhes();
    }
}
