public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else if (!numbers.Contains(","))
        {
            return int.Parse(numbers);
        }
        else if (numbers.Contains(","))
        {
            int result = 0;
            var splitNumbers = numbers.Split(',');
            //return int.Parse(splitNumbers[0]) + int.Parse(splitNumbers[^1]);
            for (int i = 0; i < splitNumbers.Length; i++ )
            {
                result += int.Parse(splitNumbers[i]);
            }

            return result;
        }
        else
        {
            return -999;
        }
    }

}
