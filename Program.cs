using ByteBank.ADM.Funcionarios;
using ByteBank.ADM.Parceria;
using ByteBank.ADM.SistemaInterno;
using ByteBank.ADM.Utilitario;


#region

//Funcionario vinicius = new Funcionario("123456789-X",2000);

//vinicius.Nome    = "Vinicius Benicio";


//Console.WriteLine("Nome: "      +    vinicius.Nome);
//Console.WriteLine("CPF: "       +    vinicius.CPF);
//Console.WriteLine("Salario: "   +    vinicius.Salario);
//Console.WriteLine("Bonificação: " + vinicius.GetBonificacao());

//Console.WriteLine();
//Console.WriteLine("__________________");
//Console.WriteLine();

//Diretor roberta = new Diretor("112233446-X");
//roberta.Nome = "Roberta Benicio";

//Console.WriteLine("Nome: " + roberta.Nome);
//Console.WriteLine("CPF: " + roberta.CPF);
//Console.WriteLine("Salario: " + roberta.Salario);
//Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//gerenciador.Registrar(vinicius);
//gerenciador.Registrar(roberta);

//Console.WriteLine();
//Console.WriteLine("__________________");
//Console.WriteLine();

//Console.WriteLine("Total de Bonificações: " + gerenciador.TotalBonificacao);
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

//vinicius.AumentarSalario();
//roberta.AumentarSalario();


//Console.WriteLine();
//Console.WriteLine("__________________");
//Console.WriteLine();

//Console.WriteLine("Novo salário do Vinicius: " + vinicius.Salario);
//Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer bianca = new Designer("123456");
    bianca.Nome = "Bianca Oba";

    Diretor vinicius = new Diretor("089787");
    vinicius.Nome = "Vinicius Benicio";

    Auxiliar igor = new Auxiliar("12901892");
    igor.Nome = "Igor Xpto";

    GerenteDeContas paula = new GerenteDeContas("12121243");
    paula.Nome = "Paula Xtpa";

    gerenciador.Registrar(bianca);
    gerenciador.Registrar(vinicius);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);


    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalBonificacao);


    
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("12124121");
    ingrid.Nome = "Ingrid Santana";
    ingrid.Senha = "123";

    GerenteDeContas tevez = new GerenteDeContas("2121212");
    tevez.Nome = "Tevez Cabrito";
    tevez.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "123";



    sistema.Logar(ingrid, "123");
    sistema.Logar(tevez, "xa12123");
    sistema.Logar(caio, "123");

}