namespace ATV3_CJ3022528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota");
            double nota =
                Convert.ToDouble(Console.ReadLine());

            //1//

            if (nota > +6)
            {
                Console.WriteLine("O aluno passou");
            }
            else
            {
                Console.WriteLine("O aluno reprovou");

                


                Console.WriteLine("Digite qualquer  numero");

                //2//
                Console.WriteLine("Por favor, insira um número:");
                int numero = Convert.ToInt32(Console.ReadLine());

                
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} é ímpar.");
                }

            }
        }
    }
}

            
        
   
