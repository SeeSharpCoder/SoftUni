﻿using System;

namespace _01.Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount( );

            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}