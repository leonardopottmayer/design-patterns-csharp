﻿namespace DesignPatternsCSharp.Creational.AbstractFactory
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
