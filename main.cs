using System;

class Program
{
    static void Main()
    {
      int baseFanPower = 10;
      int fanSpeed = 0;
      while (fanSpeed < 1 || fanSpeed > 3)

      {
          Console.Write("Favorite number sa electric fan: ");
          fanSpeed = Convert.ToInt32(Console.ReadLine());
      }

      char oscillateOption = ' ';
      while (oscillateOption != 'Y' && oscillateOption != 'N')
      while (true)
        {
            Console.Write("Umiikot? (Y/N): ");
            string input = Console.ReadLine()?.ToUpper();
            if (!string.IsNullOrEmpty(input) && (input == "Y" || input == "N"))
            {
                oscillateOption = input[0];
                break;
            }
            else
            {
                Console.WriteLine("Invalid!.");
            }
        }

        int fanPowerOutput = sum(baseFanPower, fanSpeed);

        if (oscillateOption == 'Y')
        {
            OscillateFan(fanSpeed, fanPowerOutput);
        }
        else
        {
            StaticFan(fanSpeed);
        }

        Console.ReadLine();
    }

    private static void StaticFan(int fanSpeed)
    {
        throw new NotImplementedException();
    }

    static int sum(int baseFanPower, int fanSpeed)
    {
        return baseFanPower * fanSpeed;
    }

    static void OscillateFan(int fanSpeed, int fanPowerOutput)
    {
        for (int i = fanSpeed; i <= Math.Min(fanPowerOutput, fanSpeed * 10); i += fanSpeed)
        {
            Console.WriteLine($"{new string('~', i)}");
        }

        for (int i = Math.Min(fanPowerOutput, fanSpeed * 10) - fanSpeed; i >= fanSpeed; i -= fanSpeed)
        {
            Console.WriteLine($"{new string('~', i)}");
        }
    }
}