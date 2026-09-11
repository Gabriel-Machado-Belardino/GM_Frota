using GM_Frota.entities;

Carreta carreta = new Carreta("Scania R450", "Vermelha", 2022, 6, 9500f, "CRT-1A23");
carreta.PesoSuportado = 25000f;

Moto moto = new Moto("Honda CG 160", "Preta", 2023, 2, 150f, "MTO-9B87");
moto.TamanhoGuidao = "Medio";

FuncionarioTransporte motorista = new MotoristaCarreta("Carlos Eduardo Silva", "MC-001", carreta, "E");
FuncionarioTransporte entregador = new EntregadorMoto("Juliana Alves Souza", "EM-001", moto, "Zona Sul");

List<FuncionarioTransporte> colaboradores = new List<FuncionarioTransporte>
{
    motorista,
    entregador
};

Console.WriteLine("SISTEMA DE LOGISTICA - TRANSPORTADORA");
Console.WriteLine();

foreach (FuncionarioTransporte colaborador in colaboradores)
{
    colaborador.MostrarDetalhes();
    Console.WriteLine();
}
