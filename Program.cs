Console.Clear();

double nota1, nota2, nota3, nota4, media;

Console.Write("Digite a 1º nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a 2º nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a 3º nota: ");
nota3 = double.Parse(Console.ReadLine());

Console.Write("Digite a 4º nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (nota1 > 10 || nota1 < 0 || nota2 > 10 || nota2 < 0 || nota3 > 10 || nota3 < 0 || nota4 > 10 || nota4 < 0){

    Console.WriteLine("Digite somente notas entre 0 e 10.");

}

else if (media < 5.0){

    Console.WriteLine("Você ficou com média {0:f1}. Resultado: Reprovado", media);

}

else if (media > 5.0 && media < 6.0){

    Console.WriteLine("Você ficou com média {0:f1}. Resultado: Em recuperação", media);
    
}

else if (media > 6.0){

    Console.WriteLine("Você ficou com média {0:f1}. Resultado: Aprovado", media);
    
}