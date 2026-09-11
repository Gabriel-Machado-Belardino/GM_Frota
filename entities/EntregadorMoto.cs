using GM_Frota.interfaces;

namespace GM_Frota.entities
{
    internal class EntregadorMoto : FuncionarioTransporte, IEntregadorMoto
    {
        public EntregadorMoto(string Nome, string Registro) : base(Nome, Registro)
        {
        }
    }
}
