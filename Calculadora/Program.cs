using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp("01/10/2023");

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.somar(num1, num2)}");
