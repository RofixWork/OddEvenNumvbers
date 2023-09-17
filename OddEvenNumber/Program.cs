int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

printNumbers(filterNumbers(numbers), "Even Numbers");
printNumbers(filterNumbers(numbers, type : "Odds"), "Odd Numbers");

//check number type (even | odd)
static bool checkNumberType(int number) => int.IsEvenInteger(number);

//filter numbers
static IEnumerable<int> filterNumbers(IEnumerable<int> numbers, string type = "Evens")
{
    return type.ToLower().Trim() switch
    {
        "evens" => numbers.Where(number => checkNumberType(number)),
        "odds" => numbers.Where(number => !checkNumberType(number)),
        _ => Enumerable.Empty<int>(),
    };
}
//print numbers
static void printNumbers(IEnumerable<int> numbers, string title)
{
    Console.Write($"{title}:\t ");
    Console.Write("[ {0} ]\n", string.Join(", ", numbers));
}