namespace N9;

class Program
{
    static void Main(string[] args)
    {
        //dados e parametros opcionais
        double? x = null;
        // ? opcional(nullable)

        //.getValueOrDefault();

        //Default double é 0
        double x = 0;
        x.getValueOrDefault();
        //Pega o valor do X ou valor Padrao dele

        x.HasValue();
        //Ira dizer se tem ou nao um valor(True / False)

        x.Value();
        //Pega o valor direto

        //Operacao de Coalescência

        double? x = null;
        double y = x ?? 0.0;

        double? x = null;
        double? y = 38;

        double a = x ?? 7.42;
        double b = y ?? 1.1;

    }
}
