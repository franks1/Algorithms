namespace AlgoList;

public static class Algorithms
{
    //pascal

    public static void PascalTriangle(int series)
    {
        int[,] pascal = new int[series, series];

        for (int i = 0; i < series; i++)
        {
            for (int k = series; k > i; k += -1)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                if (j == 0 || i == j)
                {
                    pascal[i, j] = 1;
                }
                else
                {
                    pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
                }
                Console.Write(pascal[i, j]+" ");
            }
            Console.WriteLine();
        }
    }

    public static void FibonucciSeries(int series)
    {
        List<int> _list = new();

        if (series <= 1)
        {
            _list.Add(0);
            return;
        }
        
        _list.Add(0);
        _list.Add(1);
        int a = 0, b = 1, c = 0;
        for (int i = 2; i < series; i++)
        {
            c = a + b;
            _list.Add(c);
            a = b;
            b = c;
        }

        foreach(var item in _list)
        {
            Console.Write(item+",");
        }
    }

    public static string RomanNumerals(int numerals)
    {
        string output = string.Empty;
        Dictionary < string, int > romanNumbersDictionary = new() {
            {
                "I",
                1
            }, {
                "IV",
                4
            }, {
                "V",
                5
            }, {
                "IX",
                9
            }, {
                "X",
                10
            }, {
                "XL",
                40
            }, {
                "L",
                50
            }, {
                "XC",
                90
            }, {
                "C",
                100
            }, {
                "CD",
                400
            }, {
                "D",
                500
            }, {
                "CM",
                900
            }, {
                "M",
                1000
            }
        };

        foreach (var item in romanNumbersDictionary.Reverse())
        {
            if (numerals <= 0) break;
            while (numerals >= item.Value)
            {
                output += item.Key;
                numerals -= item.Value;
            }
        }
        return output;
    }
    
}