using projetobanco;


internal class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.Nome = "Banco do Brasil";
        meuBanco.CodigoBACEN = "001";

        ContaBancaria origem = new ContaBancaria();
        origem.Agencia = "0001";
        origem.NumeroConta = "12345-6";

        ContaBancaria destino = new ContaBancaria();
        destino.Agencia = "0001";
        destino.NumeroConta = "98765-4";

        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 1500;
        meuPix.ChavePix = "conta@gmail.com";
        meuPix.ContaOrigem = origem;
        meuPix.ContaDestino = destino;


        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;
        meuTed.Finalidade = "Pagamento fornecedor";
        meuTed.ContaOrigem = origem;
        meuTed.ContaDestino = destino;

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("----------------------");

        Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");
    }

    public static void ExibirRelatorio(decimal valorBruto, IConversorGrandeza conversor)
    {
        decimal valorConvertido = conversor.Converter(valorBruto);
        Console.WriteLine($"Valor convertido: {valorConvertido:N2} {conversor.ObterSimbolo()}");
    }
}
}