Console.WriteLine("Calculadora de Salário com Horas Extras");

Console.Write("Digite o salário por hora: R$ ");
if (!decimal.TryParse(Console.ReadLine(), out decimal salarioHoraBase))
{
    Console.WriteLine("Entrada inválida para o salário por hora.");
    return;
}

Console.Write("Digite o total de horas trabalhadas: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal totalHoras))
{
    Console.WriteLine("Entrada inválida para o total de horas trabalhadas.");
    return;
}

Console.Write("Digite o número de horas extras trabalhadas: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal numHorasExtras))
{
    Console.WriteLine("Entrada inválida para o número de horas extras.");
    return;
}

decimal salarioBase = salarioHoraBase * totalHoras;
decimal valorHoraExtra = salarioHoraBase * 1.40m; // Acréscimo de 40%
decimal salarioTotal = salarioBase + (valorHoraExtra * numHorasExtras);

Console.WriteLine($"\nSalário Total: R$ {salarioTotal:N2}");