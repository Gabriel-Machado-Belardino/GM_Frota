using GM_Frota.interfaces;
using GM_Frota.utils;

namespace GM_Frota.entities
{
    internal class Veiculo : IVeiculo
    {
        private string nome = String.Empty;
        private string cor = String.Empty;
        private int ano = 0;
        private int rodas = 0;
        private float peso = 0;
        private string placa = String.Empty;

        public Veiculo(string nome, string cor, int ano, int rodas, float peso, string placa)
        {
            this.nome = nome;
            this.cor = cor;
            this.ano = ano;
            this.rodas = rodas;
            this.peso = peso;
            this.placa = placa;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cor { get { return cor; } set { cor = value; } }
        public int Ano { get { return ano; } set { ano = value; } }
        public int Rodas { get { return rodas; } set { rodas = value; } }
        public float Peso { get { return peso; } set { peso = value; } }
        public string Placa { get { return placa; } set { placa = value; } } 

        public void MostrarDetalhes()
        {
            ConsoleWriter.WriteStart();
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Nome", this.Nome);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Cor", this.Cor);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Ano", this.Ano.ToString());
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Rodas", this.Rodas.ToString());
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Peso", this.Peso.ToString());
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteLine("Placa", this.Placa);
            ConsoleWriter.WriteEmptyLine();
            ConsoleWriter.WriteEnd();
        }
    }
}
