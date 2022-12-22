
var x = 23424;
var y = 46463;
var z = 46463;

try
{
    var result = x * x / (y - z);
    Console.WriteLine(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}