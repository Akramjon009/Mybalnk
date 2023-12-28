int day;
int oy;
int yil;
try
{
    Console.WriteLine("kun");
    day = int.Parse(Console.ReadLine());
    Console.WriteLine("oy");
    oy = int.Parse(Console.ReadLine());
    Console.WriteLine("yil");
    yil = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
var dateTime = new DateTime(year: yil, month: oy, day: day);
var now = DateTime.Now;
TimeSpan days = now - dateTime;
Console.WriteLine(days.Days);