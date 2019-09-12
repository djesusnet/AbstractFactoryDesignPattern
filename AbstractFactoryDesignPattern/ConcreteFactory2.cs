using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ConcreteFactory2 : AbstractFactory
    {
       public override AbstractProdutoA CreateProdutoA()
        {
            return new ProdutoA2();
        }
        public override AbstractProdutoB CreateProdutoB()
        {
            return new ProdutoB2();
        }
    }
}
