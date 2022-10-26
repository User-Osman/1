/// <summary>
/// Ввод-вывод с консоли квадратной матрицы
/// </summary>
public void InOutMatrix();
{
    int n;
    Console.WriteLine("Ввод квадратной матрицы A размерности n");
    Console.WriteLine("Введите целое - n");
    n = Convert.ToInt32(Console.ReadLine());
    double[,] A = new double[n,n]; 
    for(int i = 0; i<n; i++)
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Введите A[{0}],[{1}]", i, j);
            A[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    Console.WriteLine("Вывод матрицы A");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)                
            Console.Write("A[{0}],[{1}] = {2}  ", i, j, A[i, j]);
        Console.WriteLine();
    }
}