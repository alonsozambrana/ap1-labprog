
Console.WriteLine("Ap1");

bool continuação = true;

do
{
    // recebendo o nome, idade, altura e peso da pessoa
    Console.WriteLine("Digite seu nome: ");
    string? nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
  
    Console.WriteLine("Digite sua altura em metros separado por vírgula: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite seu peso em kg separado por vírgula: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    // armazenando calculo do imc na variavel
    double imc = (float)peso / (altura * altura);

    // separando os tipos de imc
    string tipoIMC;
    if (imc < 18.5f)
        tipoIMC = "Abaixo do peso";
    else if (imc >= 18.5f && imc <= 24.9f)
        tipoIMC = "Normal";
    else if (imc >= 25 && imc <= 29.9f)
        tipoIMC = "Sobrepeso";
    else
        tipoIMC = "Obeso";

    // separando as faixas etarias
    string faixaEtaria;
    if (idade < 10)
        faixaEtaria = "Criança";
    else if (idade >= 10 && idade < 20)
        faixaEtaria = "Adolescente";
    else if (idade >= 20 && idade < 60)
        faixaEtaria = "Adulto";
    else
        faixaEtaria = "Idoso";

    // printando o resultado final
    Console.WriteLine($"Olá {nome} de {idade} anos. De acordo com as informações recebidas você é {faixaEtaria} e sua categoria é {tipoIMC}");

    // opção para sair ou voltar do programa
    Console.Write("\nDigite 's' se deseja fazer uma nova consulta ou 'n' para encerrar o programa:");
    continuação = Console.ReadLine() == "s";

} while (continuação);
