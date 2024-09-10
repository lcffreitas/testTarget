double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double faturamentoTotal = sp + rj + mg + es + outros;

double percentualSP = (sp / faturamentoTotal) * 100;
double percentualRJ = (rj / faturamentoTotal) * 100;
double percentualMG = (mg / faturamentoTotal) * 100;
double percentualES = (es / faturamentoTotal) * 100;
double percentualOutros = (outros / faturamentoTotal) * 100;

Console.WriteLine($"Percentual de representação por estado:");
Console.WriteLine($"SP: {percentualSP:0.00}%");
Console.WriteLine($"RJ: {percentualRJ:0.00}%");
Console.WriteLine($"MG: {percentualMG:0.00}%");
Console.WriteLine($"ES: {percentualES:0.00}%");
Console.WriteLine($"Outros: {percentualOutros:0.00}%");