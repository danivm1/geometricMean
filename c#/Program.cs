while (true)
{
    List<int> nList = new();

    while (true)
    {
        Console.WriteLine("Insira um dos números do conjunto (ou uma letra para calcular)");
        string txt = Console.ReadLine() ?? "";

        if (int.TryParse(txt, out int n))
            nList.Add(n);
        else
            break;
    }

    if (nList.Count > 0)
    {
        int prod = 1;
        foreach (int n in nList)
        {
            prod *= n > 0 ? n : -n;
        }


        double root = 1.0 / nList.Count;
        double geometricMean = Math.Pow(prod, root);

        Console.WriteLine($"Media Geométrica: {geometricMean}");
        Console.WriteLine("Digite 'fim' para finalizar ou qualquer coisa para fazer outra operação:");
        string t = Console.ReadLine() ?? "";

        if (t == "fim") break;
    }
    else
    {
        Console.WriteLine("Nenhum número inserido.");
        break;
    }
}
