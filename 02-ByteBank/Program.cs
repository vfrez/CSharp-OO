﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Pessoa Hue Hue";
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);

            conta.saldo = 250;
            Console.WriteLine(conta.saldo);

            Console.ReadLine();

        }
    }
}
