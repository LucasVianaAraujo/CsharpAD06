namespace CsharpAD06;

class Program
{
    static void Main(string[] args)
    {
        ApresentarPrograma();

        LacoRepeticao();
    }

    public static void ApresentarPrograma()
    {
        Console.WriteLine("-- EXERCÍCIOS DE LAÇO DE REPETIÇÃO --");
    }

    public static void LacoRepeticao()
    {
        Console.WriteLine("Determine a altura do triângulo:");
        int AlturaTriangulo = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < AlturaTriangulo; i++)
        {
            for (int j = 0; j < AlturaTriangulo - (i + 1); j++)
            {
                Console.Write("  ");
            }

            for (int k = 0; k <= i; k++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }

    }
}