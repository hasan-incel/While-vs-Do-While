/*
Aşağıdaki örnek hem while hem do while ile yapılmıştır.While döngüsü, koşulu döngünün başında kontrol eder. 
Do-while döngüsü, koşulu döngünün sonunda kontrol eder. Bu nedenle, döngü en az bir kez çalışır, ardından koşul kontrol edilir. 
 */

Console.WriteLine("Lütfen input giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());
int sayac = 0;

Console.WriteLine();
Console.WriteLine("While");

while (sayac < limit) 
{
    Console.WriteLine("Ben bir Patika'lıyım -->" + sayac);
    sayac++;
}

Console.WriteLine();
Console.WriteLine("Do-While");

sayac = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım -->" + sayac);
    sayac++;
} while (sayac < limit);
