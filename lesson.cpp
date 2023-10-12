#include <iostream>

void fill_array(int *array, int N, int m, int k)
{
    int counter = 0;
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < k; ++j)
        {
            array[i * m + j] = N + counter;
            counter++;
        }
    }
}

void print_array(int *array, int m, int k)
{
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < k; ++j)
        {
            std::cout << array[i * m + j] << " ";
        }
        std::cout << std::endl;
    }
}

int main(const int argc, const char *argv[])
{
    int N = 0;
    int m = 0;
    int k = 0;
    std::cin >> N >> m >> k;

    int *array = (int *)calloc(sizeof(int), m * k);
    fill_array(array, N, m, k);
    print_array(array, m, k);

    free(array);
    return 0;
}