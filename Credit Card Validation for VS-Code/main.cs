using System;

class Program {
  public static void Main (string[] args) {
    long num = 4060320351340691L;
    Console.Write(num + " is " +
                  (isValid(num) ?
                  "Valid" : "Invalid"));
  }

  public static bool isValid(long num)
  {
    return (getSize(num) >= 13 &&
            getSize(num) <= 16) &&
            (prefixMatched(num, 4) ||
            prefixMatched(num, 5) ||
            prefixMatched(num, 37) ||
            prefixMatched(num, 6)) &&
            ((sumEvenPlace(num) +
            sumOddPlace(num)) % 10 == 0);
  }

  public static int sumEvenPlace(long num)
  {
    int sum = 0;
    String no = num + "";
    for (int i = getSize(num) - 2; i >= 0; i -= 2)
      sum += getDigit(int.Parse(no[i] + "") * 2);

    return sum;
  }

  public static int getDigit(int num)
  {
    if (num < 9)
      return num;
    return num / 10 + num % 10;
  }

  public static int sumOddPlace(long num)
  {
    int sum = 0;
    String no = num + "";
    for (int i = getSize(num) - 1; i >= 0; i -= 2)
      sum += int.Parse(no[i] + "");
    return sum;
  }

  public static bool prefixMatched(long num, int d)
  {
    return getPrefix(num, getSize(d)) == d;
  }

  public static int getSize(long d)
  {
    String no = d + "";
    return no.Length;
  }

  public static long getPrefix(long num, int k)
  {
    if (getSize(num) > k)
    {
      String no = num + "";
      return long.Parse(no.Substring(0, k));
    }
    return num;
  }
}
