// See https://aka.ms/new-console-template for more information

using APBS_lab01;

Console.WriteLine("Hello, World!");
Initial_project initialProject = new Initial_project(1, "GitHub");

static float avg(int [] arr)
{
    int sum = 0;
    for (int z = 0; z < arr.Length; z++)
    {
        sum += arr[z];
    }

    return (float)sum / arr.Length;
}
float average = avg(new int[]{1,2,3});
Console.WriteLine(average);

static int max(int[] arr)
{
    int max = arr[0];
    if (arr.Length > 1)
    {


        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
    }

    return max;
}