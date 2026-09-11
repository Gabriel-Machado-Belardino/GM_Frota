using GM_Frota.interfaces;
using GM_Frota.utils;

namespace GM_Frota.entities
{
    class FuncionarioTransporte : IFuncionarioTransporte
    {
        private string nome = string.Empty;
        private string registro = string.Empty;

        public FuncionarioTransporte(string nome, string registro)
        {
            this.nome = nome;
            this.registro = registro;
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



        public void MostrarDetalhes()
        {
            ConsoleWriter.WriteStart();
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Nome", this.Nome);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Registro", this.Registro);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteEnd();
        }
    }
}
