namespace GM_Frota.interfaces
{
    public interface IVeiculo
    {
        string Nome { get; set; }
        string Cor { get; set; }
        float Peso { get; set; }
        string Placa { get; set; }
        int Ano { get; set; }
        int Rodas { get; set; }

        void MostrarDetalhes();
    }
}
