using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.br.com.GFT.Model
{
    class Jeans : Tecido
    {
        public void vender()
        {
            Console.WriteLine("Vendeu Tecido Jeans");
        }
    }
}
