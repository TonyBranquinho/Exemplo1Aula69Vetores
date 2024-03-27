using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Digite quantas pessoas serao registradas");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura das pessoas");

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(),CI);
            }

            double soma = 0.0;
            for (int i = 0;i < n; i++) {
                soma = soma + vect[i];
            }

            double media = soma / n;
            Console.WriteLine("A media das alturas é de " + media.ToString("F2",CI));

        }
    }
}
