using System;

namespace Target_Test_prj
{
    class Program
    {

        static int fibo(int num, int lim)
        {
            int aux = 0;
            int fi = 0;
            int aux2 = 1;
            int aux3 = 0; 

            do
            {
                aux = fi;
                fi = aux2;
                aux2 = aux + fi;
                if (aux2 == num)
                {
                    aux3 = num;
                    aux2 = lim + 10;
                    return aux3;
                }
                else
                {
                    aux3 = -20;
                    return aux3;
                }


            } while (aux2 <= lim);


        }

        static string fatu(ref string[] dia,ref double[] vlr)
        {
            string x1 = "";
            string x2 = "";
            string texto = "";
            int i = 0;
            int super = 0;
            double aux = 0;
            double aux2 = 0;
            double med = 0;
            double med2;
            double maior = 0;
            double menor = 0;

            do
            {

                med = med + vlr[i];

            } while (i < 30);

            med2 = med / 21;

            i = 0;

            do
            {
                if (vlr[i] > aux)
                {
                    aux = vlr[i];
                    maior = aux;
                    x1 = dia[i];
                }
                else
                {
                    if (vlr[i] < aux)
                    {
                        aux2 = vlr[i];
                        menor = aux2;
                        x2 = dia[i];
                    }
                }

                if (vlr[i] > med2)
                {
                    super = super + 1;
                }

            } while (i < 30);

            texto = "Dia " + x1 + " teve o maior faturamento com o valor de " + maior + "; Dia " + x2 + " teve o menor faturamento com o valor de " + menor + "; Média de faturamento de " + med2 + " com " + super +" dias de faturamento acima da média.";

            return texto;


        }

        static string fatu2(double est, double est2, double est3, double est4, double est5)
        {
            double soma = 0;
            double estado1 = 0;
            double estado2 = 0;
            double estado3 = 0;
            double estado4 = 0;
            double estado5 = 0;
            string texto = "";

            soma = est + est2 + est3 + est4 + est5;

            estado1 = est / soma;
            estado2 = est2 / soma;
            estado3 = est3 / soma;
            estado4 = est4 / soma;
            estado5 = est5 / soma;

            texto = "Estado de SP: " + estado1 * 100 + "% ; Estado do RJ: " + estado2 * 100 + "% ; Estado de MG: " + estado3 * 100 + "% ; Estado de ES: " + estado4 * 100 + "% ; Outros: " + estado5 * 100 + "% ";

            return texto;
        }

        static string Inverte(string palavra)
        {
            int count = palavra.Length;
            string aux = "";
            string aux2 = "";
            int soman = 0;

            soman = (count - count) - count;

            aux = palavra.Substring(0, count);

            aux = palavra.Substring(count, soman);
            //for (int i = 0; i < length; i++)
            //{

            //}



            return aux2;
        }

        static void Main(string[] args)
        {
            //ex 2

            int x, x2;
            Console.WriteLine("Digite o valor para verificar na sequencia Fibonacci");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o limite da sequencia Fibonacci");
            x2 = int.Parse(Console.ReadLine());

            if (fibo(x, x2) == x)
            {
                Console.WriteLine("Pertençe sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine("Não pertençe sequencia Fibonacci");
            }

            //ex 3

            string[] dia = new string[30];
            double[] vlr = new double[30];
            int count = 0;

            for (int i = 0; i < 30; i++)
            {
                count = i + 1;
                dia[i] = count.ToString();
            }

            vlr[0] = 22174.1664;
            vlr[1] = 24537.6698;
            vlr[2] = 26139.6134;
            vlr[3] = 0;
            vlr[4] = 0;
            vlr[5] = 26742.6612;
            vlr[6] = 0;
            vlr[7] = 42889.2258;
            vlr[8] = 46251.174;
            vlr[9] = 11191.4722;
            vlr[10] = 0;
            vlr[11] = 0;
            vlr[12] = 3847.4823;
            vlr[13] = 373.7838;
            vlr[14] = 2659.7563;
            vlr[15] = 48924.2448;
            vlr[16] = 18419.2614;
            vlr[17] = 0;
            vlr[18] = 0;
            vlr[19] = 35240.1826;
            vlr[20] = 43829.1667;
            vlr[21] = 18235.6852;
            vlr[22] = 4355.0662;
            vlr[23] = 13327.1025;
            vlr[24] = 0;
            vlr[25] = 0;
            vlr[26] = 25681.8318;
            vlr[27] = 1718.1221;
            vlr[28] = 13220.495;
            vlr[29] = 8414.61;

            Console.WriteLine(fatu(ref dia, ref vlr));



            //ex 4

            Console.WriteLine(fatu2(67836.43, 36678.66, 29229.88, 27165.48, 19849.53));

            //ex 5

            string a;

            Console.WriteLine("Digite uma palavra");
            a = Console.ReadLine();

            Console.WriteLine(Inverte(a));
            
            // fim
            Console.ReadKey();
        }
    }
}
