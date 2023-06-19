using System.Xml;

string sizeShirt, response;
int AllquantityShirt = 0, quantityPeople, pp = 0, p = 0, m = 0, g = 0, gg = 0;

Console.WriteLine("Quantas Pessoas vão fazer a camiseta: ");
quantityPeople = Convert.ToInt32(Console.ReadLine());

for (int cont = quantityPeople; cont > 0; cont--)
{
    Console.WriteLine($"Qual tamanho da Camiseta da {quantityPeople - cont +1}° pessoa?:\nPP\nP\nM\nG\nGG\n");
    sizeShirt = Console.ReadLine().ToUpper();
    CountShirtSize(sizeShirt, ref pp, ref p, ref m, ref g, ref gg);
    AllquantityShirt++;

    Console.WriteLine("A pessoa deseja ter uma camiseta extra?\nS para sim\nQualquer outra Tecla para não: ");
    response = Console.ReadLine().ToUpper();

    switch (response)
    {
        case "S":
            AllquantityShirt++;
            Console.WriteLine($"Qual tamanho da Camiseta extra dessa pessoa:\nPP\nP\nM\nG\nGG");
            sizeShirt = Console.ReadLine();
            CountShirtSize(sizeShirt, ref pp, ref p, ref m, ref g, ref gg);
            break;
        default: 
            break;
    }

}

Console.WriteLine($"Total de Camisetas: {AllquantityShirt}\nQuantidades de Camiseta:\nPP:{pp}\nP;{p}\nM:{m}\nG:{g}\nGG:{gg}");
static void CountShirtSize(string sizeShirt, ref int pp, ref int p, ref int m, ref int g, ref int gg)
{
    switch (sizeShirt)
    {
        case "PP":
            pp++;
            break;
        case "P":
            p++;
            break;
        case "M":
            m++;
            break;
        case "G":
            g++;
            break;
        case "GG":
            gg++;
            break;
        default:
            break;

    }
}