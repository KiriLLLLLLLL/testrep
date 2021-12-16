double[][] vertices =
{
    new double[] {0,0},
    new double[] {2,0},
    new double[] {2,2},
    new double[] {0,2}
};

double[] ratio = new double[] {2, 4, 0.5};

for(int j = 0; j < ratio.Length; j++)
{
    for(int i = 0; i < vertices.Length; i++)
    {
        for(int k = 0; k < vertices[i].Length; k++)
        {
            Console.Write($"{vertices[i][k] * ratio[j]}  ");

        }

    }
Console.WriteLine();
}