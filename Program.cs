
string continuar ="s";


while (continuar == "s"){

Console.Write("Tamanho do Largura:");
int  largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Tamanho da Altura:");
int  altura = Convert.ToInt32(Console.ReadLine());
;

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