using GM_Frota.interfaces;
using GM_Frota.utils;

namespace GM_Frota.entities
{
    internal class EntregadorMoto : FuncionarioTransporte, IEntregadorMoto
    {
        private string zonaEntrega = string.Empty;

        public EntregadorMoto(string nome, string registro, Moto moto, string zonaEntrega)
            : base(nome, registro, moto)
        {
            this.zonaEntrega = zonaEntrega;
        }

        public string ZonaEntrega
        {
            get { return zonaEntrega; }
            set { zonaEntrega = value; }
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            ConsoleWriter.WriteLine("Zona de Entrega", this.ZonaEntrega);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Placa da Moto", this.Veiculo.Placa);
            ConsoleWriter.WriteEmptyLine();

            if (this.Veiculo is IMoto moto)
            {
                ConsoleWriter.WriteLine("Tamanho do Guidao", moto.TamanhoGuidao);
                ConsoleWriter.WriteEmptyLine();
            }

            ConsoleWriter.WriteEnd();
        }
    }
}
