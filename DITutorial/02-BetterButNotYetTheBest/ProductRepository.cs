﻿using System;

namespace DITutorial.BetterButNotYetTheBest
{
    public interface IProductRepository
    {
        void Save();
    }

    public class ProductRepository : IProductRepository
    {
        public void Save()
        {
            Console.WriteLine("ProductRepository - Save called");
        }
    }
}