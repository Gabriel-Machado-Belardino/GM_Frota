using GM_Frota.interfaces;

namespace GM_Frota.entities
{
    internal class Moto : Veiculo, IMoto
    {
        private string tamanhoGuidao = String.Empty;

        public Moto(string nome, string cor, int ano, int rodas, float peso, string placa) : base(nome, cor, ano, rodas, peso, placa)
        {
        }

        public string TamanhoGuidao { get { return tamanhoGuidao; } set { tamanhoGuidao = value; } }
    }
}
