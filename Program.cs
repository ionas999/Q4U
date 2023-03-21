using System.Transactions;
/*
Level 1
while (true)
{
    Console.WriteLine("Enter: ");
    string[] input = Console.ReadLine().Split(' ');
    int amoutOfPeople = int.Parse(input[0]);
    int firstKapitalist = int.Parse(input[1]) + 2;
    int lastKapitalist = int.Parse(input[2]) + 2;

    int sum = 0;

    for (int i = firstKapitalist; i <= lastKapitalist; i++)
    {
        sum += int.Parse(input[i]);
    }

    Console.WriteLine(sum); 
}


*/
/*
 Level 2
while (true)
{
    Console.WriteLine("Enter: ");
    string[] input = Console.ReadLine().Split(' ');
    int[] money = new int[input.Length - 1];
    int amoutOfPeople = int.Parse(input[0]);
    int sum = 0;
    int lastHighestSum = 0;
    int highestMoneyIndex;
    int highestMoney = -500;

    for (int i = 1; i < input.Length; i++)
    {
        money[i - 1] += int.Parse(input[i]);
        if (money[i - 1] > highestMoney)
        {
            highestMoney = money[i - 1];
        }
    }
    
    

    for (int i = 0; i < money.Length; i++)
    {
        for (int j = i; j < money.Length; j++)
        {
            sum += money[j];
            if (sum > lastHighestSum)
            {
                lastHighestSum = sum;
            }
                
        }

        sum = 0;
    }



    Console.WriteLine(lastHighestSum); 
}

*/
/*
 Level 3
while (true)
{
    Console.WriteLine("Enter: ");
    string[] input = Console.ReadLine().Split(' ');
    int[] money = new int[input.Length - 1];
    int amoutOfPeople = int.Parse(input[0]);
    int sum = 0;
    int lastHighestSum = 0;
    int highestMoneyIndex;
    int highestMoney = -500;
    List < int[] > possiblitiys = new List<int[]>();

    for (int i = 1; i < input.Length; i++)
    {
        money[i - 1] += int.Parse(input[i]);
        if (money[i - 1] > highestMoney)
        {
            highestMoney = money[i - 1];
        }
    }
    
    
    for (int i = 0; i < money.Length; i++)
    {
        for (int j = i; j < money.Length; j++)
        {
            sum += money[j];
            if (sum > lastHighestSum)
            {
                lastHighestSum = sum;
                possiblitiys = new List<int[]>();
                possiblitiys.Add(new int[]{i,j});
            }
            else if(sum == lastHighestSum)
            {
                possiblitiys.Add(new int[]{i,j}); 
            }
                
        }

        sum = 0;
    }

    string output = lastHighestSum.ToString();
    output += $" {possiblitiys.Count}";

    foreach (var position in possiblitiys)
    {
        output += $" {position[0] + 1} {position[1] + 1}";
    }
    Console.WriteLine(output);
}
*/

// Level 4+5
{
    Console.WriteLine("Test 1");

    StreamReader streamReader = new StreamReader(@"input.2");
    string[] input = streamReader.ReadLine().Split(' ');
    Console.WriteLine("TEst 2");
    int[] money = new int[input.Length - 1];
    int sum = 0;
    int lastHighestSum = 0;
    int highestMoney = -500;

    for (int i = 1; i < input.Length; i++)
    {
        money[i - 1] += int.Parse(input[i]);
        if (money[i - 1] > highestMoney)
        {
            highestMoney = money[i - 1];
        }
    }
    
    Console.WriteLine("Test 3");

    for (int i = 0; i < money.Length; i++)
    {
        for (int j = i; j < money.Length; j++)
        {
            sum += money[j];
            if (sum > lastHighestSum)
            {
                lastHighestSum = sum;
            }
                
        }
        Console.WriteLine(lastHighestSum + " " + i);
        sum = 0;
    }



    Console.WriteLine(lastHighestSum); 
}