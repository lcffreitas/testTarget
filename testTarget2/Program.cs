int inputNumber = 4;

Dictionary<int,int> fibonacciMap = new Dictionary<int,int>();

int a = 0;
int b = 1;
int index = 0;

while (b <= inputNumber)
{
    int next = a + b;
    a = b;
    b = next;
    fibonacciMap.Add(index++, b);
}

if (fibonacciMap.ContainsValue(inputNumber))
{
    Console.WriteLine($"O número {inputNumber} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {inputNumber} não pertence à sequência de Fibonacci.");
}