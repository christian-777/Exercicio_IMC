internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio imc e risco

        double alt, peso, imc;
        char sexo;

        Console.WriteLine("Digite a altura: ");
        alt = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso: ");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo: ");
        sexo = char.Parse(Console.ReadLine());

        imc = peso / (Math.Pow(alt, 2.0));

        if (sexo == 'm')
        {
            if (imc < 20.7)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (imc < 26.5)
            {
                Console.WriteLine("peso ideal");
            }
            else if (imc < 27.9)
            {
                Console.WriteLine("pouco acima do peso");
            }
            else if (imc < 31.2)
            {
                Console.WriteLine("acima do peso");
            }
            else
            {
                Console.WriteLine("obesidade");
            }
        }

        if (sexo == 'f')
        {
            if (imc < 19.1)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (imc < 25.9)
            {
                Console.WriteLine("peso ideal");
            }
            else if (imc < 27.4)
            {
                Console.WriteLine("pouco acima do peso");
            }
            else if (imc < 32.4)
            {
                Console.WriteLine("acima do peso");
            }
            else
            {
                Console.WriteLine("obesidade");
            }
        }

    }
}