// initialize variables - graded assignments 
int currentAssignments = 5;

int sinvaldo1 = 93;
int sinvaldo2 = 87;
int sinvaldo3 = 98;
int sinvaldo4 = 95;
int sinvaldo5 = 100;

int mirela1 = 80;
int mirela2 = 83;
int mirela3 = 82;
int mirela4 = 88;
int mirela5 = 85;

int gilvan1 = 84;
int gilvan2 = 96;
int gilvan3 = 73;
int gilvan4 = 85;
int gilvan5 = 79;

int andrezza1 = 90;
int andrezza2 = 92;
int andrezza3 = 98;
int andrezza4 = 100;
int andrezza5 = 97;

int sinvaldoSum = sinvaldo1 + sinvaldo2 + sinvaldo3 + sinvaldo4 + sinvaldo5;
int mirelaSum = mirela1 + mirela2 + mirela3 + mirela4 + mirela5;
int gilvanSum = gilvan1 + gilvan2 + gilvan3 + gilvan4 + gilvan5;
int andrezzaSum = andrezza1 + andrezza2 + andrezza3 + andrezza4 + andrezza5;

Console.WriteLine($"A soma da nota do Sinvaldo é: {sinvaldoSum}");
Console.WriteLine($"A soma da nota da Mirela é: {mirelaSum}");
Console.WriteLine($"A soma da nota do Gilvan é: {gilvanSum}");
Console.WriteLine($"A soma da nota da Andrezza é: {andrezzaSum}");

decimal sinvaldoMedia = (decimal) sinvaldoSum / currentAssignments;
decimal mirelaMedia = (decimal) mirelaSum / currentAssignments;
decimal gilvanMedia = (decimal) gilvanSum / currentAssignments;
decimal andrezzaMedia = (decimal) andrezzaSum / currentAssignments;

Console.WriteLine($"A média do Sinvaldo é: {sinvaldoMedia} " + "A");
Console.WriteLine($"A média do Mirela é: {mirelaMedia} " + "B");
Console.WriteLine($"A média do Gilvan é: {gilvanMedia} " + "B");
Console.WriteLine($"A média do Andrezza é: {andrezzaMedia} " + "A");