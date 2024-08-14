class Program
{
    static void Main(string[] args)
    {
        exercicios exercicios = new exercicios();

        exercicios.BoasVindas();
        exercicios.NomeCompleto();
        exercicios.OperacoesMatematica();
        exercicios.QuantidadeCaracter();
        exercicios.PlacaCarro();
        exercicios.DataAtual();
    }
}

class exercicios
{

    public void BoasVindas()
    {
        Console.WriteLine("Olá, qual o seu nome?");
        var nome = "";
        nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo");
    }

    public void NomeCompleto()
    {
        Console.WriteLine("Qual o seu Nome?");
        var nome = Console.ReadLine();
        Console.WriteLine("Qual o seu Sobrenome? ");
        var sobrenome = Console.ReadLine();
        Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
    }

    public void OperacoesMatematica()
    {
        double numero01 = 50;
        double numero02 = 45;
        double divisao = 0;

        double soma = (numero01 + numero02);
        double mutiplicacao = (numero01 * numero02);
        double subtracao = (numero01 - numero02);
        if (numero01 != 0 && numero02 != 0)
        {
            divisao = (numero01 / numero02);
        }
        double media = (numero01 + numero02)/2;
        Console.WriteLine("A soma:" + soma + " mutiplicacao: " + mutiplicacao + " subtracao: " + subtracao + " divisao: " + divisao + " e do média dos valores é: " + media);
    }

    public void QuantidadeCaracter()
    {
        Console.WriteLine("Digite qualquer coisa: ");
        string texto = Console.ReadLine();

        var tamanho = texto.Replace(" ","").Length;
        Console.WriteLine("O tamanho da do texto é: " + tamanho);
    }
    
    public void PlacaCarro()
    {
        Console.WriteLine("Informe a placa do seu veículo.");
        var placa = Console.ReadLine();
        var tamanho = placa.Replace(" ", "").Length;

        if(tamanho == 7 &&
            placa.Length>=3 && Char.IsLetter(placa[0])&&
            placa.Length>=3 && Char.IsLetter(placa[1])&&
            placa.Length>=3 && Char.IsLetter(placa[2])&&
            placa.Length>=3 && Char.IsDigit(placa[3])&&
            placa.Length>=3 && Char.IsDigit(placa[4])&&
            placa.Length>=3 && Char.IsDigit(placa[5])&&
            placa.Length>=3 && Char.IsDigit(placa[6])
            
            ){
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

    public void DataAtual()
    {
        Console.WriteLine("Vou exibir a data atual em diferentes formatos:");
        DateTime dataAtual = DateTime.Now;

        string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
        Console.WriteLine("Formato Completo: " + formatoCompleto);

        string apenasData = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine("Apenas a data: " +apenasData);

        string apenasHora = dataAtual.ToString("HH:mm:ss");
        Console.WriteLine("Apenas a hora: " + apenasHora);

        string dataComMesPorExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine("Data com mês por extenso: " + dataComMesPorExtenso);
    }
}