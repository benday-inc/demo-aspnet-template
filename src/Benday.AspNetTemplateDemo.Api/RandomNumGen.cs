using System.Security.Cryptography;

namespace Benday.AspNetTemplateDemo.Api;

public class RandomNumGen
{
    private RandomNumberGenerator _Random;
 
    /// <summary> 
    /// Constructor which creates the random number object 
    /// </summary> 
    public RandomNumGen()
    {
        // Create the random number generator. 
        _Random = RandomNumberGenerator.Create();
    }


    /// <summary> 
    /// This returns a random number of a particular size 
    /// </summary> 
    /// <param name="bits">Size of the random number in bits</param> 
    /// <returns>Random number</returns> 
    public ulong GetNumber(byte bits)
    {
        ulong randomNumber = 1;
        // Convert the number of bits to bytes. 
        byte numBytes = Convert.ToByte(bits / 8);

        byte[] ranbuff = new byte[numBytes];

        // This retrieves a random sequence of bytes. 
        _Random.GetBytes(ranbuff);

        uint randomByte;

        for (byte i = 0; i < numBytes; i++)
        {
            randomByte = ranbuff[i];
            randomNumber = randomNumber + randomByte *
                Convert.ToUInt64(Math.Pow(2, i * 8));
        }

        // Return the generated number. 
        return randomNumber;
    }

    /// <summary> 
    /// Returns a random number within a specific range min <= number 
    // < max. 
    /// </summary> 
    /// <param name="min">minimum number of the range</param> 
    /// <param name="max">maximum number of the range</param> 
    /// <returns>random number</returns> 
    public ulong GetNumberInRange(ulong min, ulong max)
    {
        byte bits = 32;


        ulong randomNumber = GetNumber(bits);
        ulong biggestNumber = Convert.ToUInt64(Math.Pow(2, bits));


        // Takes the generated number and puts it in the range 
        // that has been asked for. 
        ulong randomNumberInRange =
            Convert.ToUInt64(Math.Floor(Convert.ToDouble(randomNumber) /
              Convert.ToDouble(biggestNumber) * Convert.ToDouble(max - min) +
                                                                                                                                                     Convert.ToDouble(min)));


        return randomNumberInRange;
    }


    /// <summary> 
    /// Returns a random number within a specific range 
    /// min less than or equal to number less than max 
    /// </summary> 
    /// <param name="min">minimum number of the range</param> 
    /// <param name="max">maximum number of the range</param> 
    /// <returns>random number</returns> 
    public int GetNumberInRange(int min, int max)
    {
        return Convert.ToInt32(GetNumberInRange(Convert.ToUInt64(min),
                                                  Convert.ToUInt64(max)));
    }
    public int Next(int value1, int value2)
    {
        return GetNumberInRange(value1, value2);
    }
}