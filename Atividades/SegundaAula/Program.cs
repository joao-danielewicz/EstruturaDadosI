using System.Globalization;
string[] meses = new string[12];

for(int mes=1; mes <=12; mes++){
    DateTime diaPrimeiro = new DateTime(DateTime.Now.Year, mes,1);
    string nome = diaPrimeiro.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt")) ;
    meses[mes-1] = nome;
}

foreach(string mes in meses)
    Console.WriteLine($"-> {mes}");