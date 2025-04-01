using System.Text;

namespace Benday.AspNetTemplateDemo.Api;

public class TestDataFactory
{
    public TestDataFactory()
    {
        CreateFakePostalCodes(200);
    }

    private List<Person>? _TestData;
    public List<Person> TestData
    {
        get
        {
            if (_TestData == null)
            {
                _TestData = GetPersonList(25);

                _TestData = _TestData.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            }

            return _TestData;
        }
    }


    public Person GetPerson()
    {
        var person = new Person();
        person.FirstName = FirstNames.GetRandom();
        person.LastName = LastNames.GetRandomPossiblyHyphenated();
        person.Addresses.Add(GetAddress("Home"));
        person.Addresses.Add(GetAddress("Office"));
        person.Addresses.Add(GetAddress("Other"));
        return person;
    }
    private Address GetAddress(string addressType)
    {
        var address = new Address();

        address.Type = addressType;

        var rnd = new Random();

        var numberOfWordsInStreet = rnd.Next(1, 3);

       var streetName = StreetNames.GetRandomPossiblyTwoWords();

        address.Line1 = $"{rnd.Next(1000, 9999)} {streetName} {StreetTypes.GetRandom()}";

        var createSecondLine = rnd.Next(0, 2) == 1;

        if (createSecondLine == true)
        {
            address.Line2 = $"Apt {rnd.Next(100, 999)}";
        }

        address.City = Cities.GetRandomPossiblyTwoWords();

        address.State = States.GetRandom();

        address.PostalCode = PostalCodes.GetRandom();

        return address;
    }

    public List<string> FirstNames { get; set; } = new()
    {
        "John",
        "Jane",
        "Bob",
        "Sue",
        "Muffin",
        "Fluffy",
        "Bingo",
        "Thor",
        "Crumpet",
        "Pumpernickel",
        "Flimsy"
    };

    public List<string> LastNames { get; private set; } = new()
    {
        "Smith",
        "Johnson",
        "Williams",
        "Jones",
        "Brown",
        "Davis",
        "Miller",
        "Wilson",
        "Moore",
        "Taylor",
        "Anderson",
        "Bumpkin",
        "Gahdonk",
        "Flibber",
        "McGee",
        "McGunky",
        "McBingbong",
        "McFlippy",
        "Chandra",
        "Gupta",
        "Patel",
        "Muffin",
        "Hamster",
        "Yoink",
        "Topp"
    };

    public List<string> Cities { get; private set; } = new()
    {
        "Basket",
        "Disappointment",
        "Amused",
        "Confusion",
        "Funtown",
        "Boring",
        "Chicken Nugget",
        "West Chicken Nugget",
        "Corncob",
        "Conjunction",
        "Adequate",
        "Bingo",
        "Pancake"
    };

    public List<string> States { get; private set; } = new()
    {
        "Rhode Island",
        "Massachusetts",
        "Connecticut",
        "New Hampshire",
        "Maine",
        "Vermont",
        "New Mexico", 
        "Wisconsin",
        "Wyoming",
        "North Dakota"
    };

    public List<string> StreetNames { get; private set; } = new()
    {
        "Donkey",
        "Sandwich",
        "Meh",
        "North",
        "South",
        "East",
        "West",
        "Flippy",
        "Floppy",
        "Marginal",
        "Average",
        "Bingo",
        "Clapping",
        "Fumble",
        "Gahdonk",
        "Doink",
        "Flimsy",
        "Main",
        "Secondary",
        "Tertiary",
        "Quaternary",
        "Nope",
        "Ambivalent",
        "Boredom",
        "Ennui",
        "Standard"
    };

    public List<string> StreetTypes { get; private set; } = new()
    {
        "St",
        "Ave",
        "Rd",
        "Cir",
        "Blvd",
        "Ln",
        "Ct",
        "Dr",
        "Pkwy",
        "Pl",
        "Way"
    };

    public List<string> PostalCodes { get; private set; } = new();
    private void CreateFakePostalCodes(int numberToCreate)
    {
        var rnd = new Random();

        for (int i = 0; i < numberToCreate; i++)
        {
            var builder = new StringBuilder();

            for (int j = 0; j < 5; j++)
            {
                builder.Append(j);
            }

            var temp = builder.ToString();

            if (PostalCodes.Contains(temp) == false)
            {
                PostalCodes.Add(temp);
            }
        }
    }

    public List<Person> GetPersonList(int count)
    {
        var list = new List<Person>();

        for (int i = 0; i < count; i++)
        {
            list.Add(GetPerson());
        }

        return list;
    }
}
