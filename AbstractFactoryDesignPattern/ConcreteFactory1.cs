using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProdutoA CreateProdutoA()
        {
            return new ProdutoA1();
        }
        public override AbstractProdutoB CreateProdutoB()
        {
            return new ProdutoB1();
        }
    }
}
