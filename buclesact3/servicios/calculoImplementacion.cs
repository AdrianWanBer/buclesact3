﻿namespace buclesact3.servicios
{
    internal class calculoImplementacion : calculoInterfaz
    {

        public void calcular(int num)
        {
            int i;
            int j;
            for (i = 0 ; i <= num; i++)
            {
                for (j = 1; j <= i; j++) {
                    Console.Write(j);
                    Console.Write(" | ");
                }             
                Console.WriteLine(" ");
            }   
        }
    }
}

