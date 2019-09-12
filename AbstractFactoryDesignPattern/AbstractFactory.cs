using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    abstract class AbstractFactory
    {
        public abstract AbstractProdutoA CreateProdutoA();
        public abstract AbstractProdutoB CreateProdutoB();

    }
}
