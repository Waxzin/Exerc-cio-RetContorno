
string continuar ="s";


while (continuar == "s"){

Console.Write("Tamanho do Largura (max 10 digitos):");
int  largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Tamanho da Altura (max 10 digitos:");
int  altura = Convert.ToInt32(Console.ReadLine());

if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
    {
        Console.WriteLine("Deve estar entre 1 a 10");
    }
    else
    {
     int contadorLinha = 0;
while (contadorLinha < altura) 
{
int contadorcoluna = 0;
    while (contadorcoluna < largura)
    {
        if (contadorLinha == 0 || contadorLinha == altura - 1 || contadorcoluna == 0 || contadorcoluna == largura - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" "); 
        }
        
        contadorcoluna = contadorcoluna + 1;
    }
    Console.WriteLine();
    contadorLinha = contadorLinha + 1;
}

Console.Write("Deseja executar novamente? (S/N)?");
continuar = Console.ReadLine()!.ToLower();
}
Console.WriteLine("muito obrigado por usar o programa!");   
    }