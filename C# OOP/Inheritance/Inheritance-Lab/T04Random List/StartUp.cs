﻿using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            RandomList randomList = new RandomList();
             randomList.Add("1");
             randomList.Add("2");
             randomList.Add("Pesho");
             randomList.Add("Gosho");
             randomList.Add("8");

             Console.WriteLine(randomList.RandomString());
             

        }
    }
}
