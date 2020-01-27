using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.br.com.GFT.Model
{
    class Malha : Tecido
    {
        public void vender()
        {
            Console.WriteLine("Vendeu Tecido de Malha");
        }
    }
}
