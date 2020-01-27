using PatternFactory.br.com.GFT.Model;
using System;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tecido EscolherTecido;
            FactoryTecido FabricaTecido = new FactoryTecido();

            EscolherTecido = FabricaTecido.GetTecido("algodao");
            EscolherTecido.vender();

            EscolherTecido = FabricaTecido.GetTecido("jeans");
            EscolherTecido.vender();

            EscolherTecido = FabricaTecido.GetTecido("malha");
            EscolherTecido.vender();

        }
    }
}
