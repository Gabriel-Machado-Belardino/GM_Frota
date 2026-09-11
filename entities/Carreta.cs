using GM_Frota.interfaces;

namespace GM_Frota.entities
{
    internal class Carreta : Veiculo, ICarreta
    {
        private float pesoSuportado = 0;

        public Carreta(string nome, string cor, int ano, int rodas, float peso, string placa) : base(nome, cor, ano, rodas, peso, placa)
        {
        }

        public float PesoSuportado { get  { return pesoSuportado; } set { pesoSuportado = value; } }
    }
}
