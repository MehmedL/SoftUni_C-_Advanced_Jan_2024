string input = Console.ReadLine();

HashSet<string> output = new HashSet<string>();
while (input.ToLower() != "end")
{
    string[] line = input.Split(", ").ToArray();
    string comand = line[0];
    string carNumber = line[1];

    if (comand.ToLower() == "in")
    {
        output.Add(carNumber);
    }
    else if (comand.ToLower() == "out")
    {
        output.Remove(carNumber);
    }
    input = Console.ReadLine();
}
if (output.Count > 0)
{
    foreach (string regNum in output)
    {
        Console.WriteLine(regNum);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
