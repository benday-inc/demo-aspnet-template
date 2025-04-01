namespace Benday.AspNetTemplateDemo.Api;

public static class ExtensionMethods
{
    public static string GetRandom(this List<string> list)
    {
        var rnd = new Random();
        var index = rnd.Next(0, list.Count);
        return list[index];
    }

    public static string GetRandomPossiblyTwoWords(this List<string> list)
    {
        var rnd = new Random();
        var isTwoWords = rnd.Next(0, 2) == 1;
        var index1 = rnd.Next(0, list.Count);
        if (isTwoWords == false)
        {
            return list[index1];
        }
        else
        {
            var index2 = rnd.Next(0, list.Count);
            var value1 = list[index1];
            var value2 = list[index2];
            var returnValue = $"{value1} {value2}";
            return returnValue;
        }
    }

    public static string GetRandomPossiblyHyphenated(this List<string> list)
    {
        var rnd = new Random();

        var isHyphenated = rnd.Next(0, 2) == 1;

        var index1 = rnd.Next(0, list.Count);

        if (isHyphenated == false)
        {
            return list[index1];
        }
        else
        {
            var index2 = rnd.Next(0, list.Count);

            var value1 = list[index1];
            var value2 = list[index2];

            var returnValue = $"{value1}-{value2}";

            return returnValue;
        }
    }


}