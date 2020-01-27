using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.br.com.GFT.Model
{
    class FactoryTecido
    {
        public Tecido GetTecido(String nomeTecido)
        {
            switch (nomeTecido)
            {
                case "algodao":
                    return new Algodao();

                case "jeans":
                    return new Jeans();

                case "malha":
                    return new Malha();

                default:
                    return null;
            }
        }
    }
}
