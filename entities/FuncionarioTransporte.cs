using GM_Frota.interfaces;
using GM_Frota.utils;

namespace GM_Frota.entities
{
    public abstract class FuncionarioTransporte : IFuncionarioTransporte
    {
        private string nome = string.Empty;
        private string registro = string.Empty;
        private IVeiculo veiculo;

        protected FuncionarioTransporte(string nome, string registro, IVeiculo veiculo)
        {
            this.nome = nome;
            this.registro = registro;
            this.veiculo = veiculo;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        public IVeiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public virtual void MostrarDetalhes()
        {
            ConsoleWriter.WriteStart();
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Nome", this.Nome);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Registro", this.Registro);
            ConsoleWriter.WriteEmptyLine();
        }
    }
}
