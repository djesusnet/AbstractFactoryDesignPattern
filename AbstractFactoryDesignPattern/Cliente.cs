using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class Cliente
    {
        private AbstractProdutoA _abstractProdutoA;
        private AbstractProdutoB _abstractProdutoB;

        public Cliente(AbstractFactory factory)
        {
            _abstractProdutoA = factory.CreateProdutoA();
            _abstractProdutoB = factory.CreateProdutoB();
        }

        public void Run()
        {
            _abstractProdutoB.Interact(_abstractProdutoA);
        }
    }
}
