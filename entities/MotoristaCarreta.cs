using GM_Frota.interfaces;

namespace GM_Frota.entities
{
    internal class MotoristaCarreta : FuncionarioTransporte, IMotoristaCarreta
    {
        public MotoristaCarreta(string Nome, string Registro) : base(Nome, Registro)
        {
        }
    }
}
