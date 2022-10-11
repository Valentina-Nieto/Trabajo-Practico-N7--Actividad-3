using System;

namespace actividad3TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación que solicite la temperatura diaria promedio para el lapso de una
            semana (7 días). Al finalizar se debe informar cual es la temperatura mínima registrada, cual la
            máxima y a que numero de día corresponde en cada caso.*/

            float tempDiaria = 0f, tempMin = 80f, tempMax = 0f;
            int diaMax = 0, diaMin = 0;

            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Ingrese temperatura, dia N° " + i);
                tempDiaria = Convert.ToInt32(Console.ReadLine());

                if (tempDiaria > tempMax)
                {
                    tempMax = tempDiaria;
                    diaMax = i;
                }

                if (tempDiaria < tempMin)
                {
                    tempMin = tempDiaria;
                    diaMin = i;
                }
            }

            Console.WriteLine("La temperatura MAXIMA es '{0}°', registrado el día '{1}'", tempMax, diaMax);
            Console.WriteLine("La temperatura MINIMA es '{0}°', registrado el día '{1}'", tempMin, diaMin);
        }
    }
}