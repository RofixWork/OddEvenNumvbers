int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

printNumbers(filterNumbers(numbers), "Even Numbers");
printNumbers(filterNumbers(numbers, type : "Odds"), "Odd Numbers");

static bool checkNumberType(int number)
{
    return int.IsEvenInteger(number);
}

static IEnumerable<int> filterNumbers(IEnumerable<int> numbers, string type = "Evens")
{
    switch (type.ToLower().Trim())
	{
		case "evens":
            return numbers.Where(number => checkNumberType(number));
        case "odds":
            return numbers.Where(number => !checkNumberType(number));
        default:
            return Enumerable.Empty<int>();
	}
}

static void printNumbers(IEnumerable<int> numbers, string title)
{
    Console.Write($"{title}: ");
    Console.Write($"[ {string.Join(" ", numbers)} ]\n");
}