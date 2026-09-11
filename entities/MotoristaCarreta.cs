using GM_Frota.interfaces;
using GM_Frota.utils;

namespace GM_Frota.entities
{
    internal class MotoristaCarreta : FuncionarioTransporte, IMotoristaCarreta
    {
        private string categoriaCnh = string.Empty;

        public MotoristaCarreta(string nome, string registro, Carreta carreta, string categoriaCnh)
            : base(nome, registro, carreta)
        {
            this.categoriaCnh = categoriaCnh;
        }

        public string CategoriaCnh
        {
            get { return categoriaCnh; }
            set { categoriaCnh = value; }
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            ConsoleWriter.WriteLine("Categoria CNH", this.CategoriaCnh);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Placa da Carreta", this.Veiculo.Placa);
            ConsoleWriter.WriteEmptyLine();

            if (this.Veiculo is ICarreta carreta)
            {
                ConsoleWriter.WriteLine("Peso Suportado (kg)", carreta.PesoSuportado.ToString());
                ConsoleWriter.WriteEmptyLine();
            }

            ConsoleWriter.WriteEnd();
        }
    }
}
