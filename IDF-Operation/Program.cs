﻿using IdfOperation.Models;

namespace IdfOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hamas hamas = new Hamas("1972", "Muchamad");
            List<Terrorist> t1 = hamas.CreateTerroristList(10);
        }
    }
}