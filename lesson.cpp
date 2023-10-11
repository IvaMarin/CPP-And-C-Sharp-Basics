#include <iostream>

int main(const int argc, const char *argv[])
{
    int N = 0;
    int m = 0;
    int k = 0;
    std::cin >> N >> m >> k;

    int **array = (int **)calloc(sizeof(int *), k);
    for (int i = 0; i < k; i++)
    {
        array[i] = (int *)calloc(sizeof(int), m);
    }
    
    int counter = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i][j] = N + counter;
            counter++;
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            std::cout << array[i][j] << " ";
        }
        std::cout << std::endl;
    }

    return 0;
}