namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        List<Profile> allProfiles = new List<Profile>();
        Profile lisa = new Profile("Lisa", Gender.Female, Gender.Male);
        Profile collin = new Profile("Collin", Gender.Male, Gender.Female);
        Profile youssef = new Profile("Youssef", Gender.Male, Gender.Female);
        Profile lee = new Profile("Lee", Gender.Male, Gender.Female);
        Profile ana = new Profile("Ana", Gender.Female, Gender.Male);
        Profile jasper = new Profile("Jasper", Gender.Male, Gender.Male);
        Profile john = new Profile("John", Gender.Male, Gender.Male);

        allProfiles.Add(lisa);
        allProfiles.Add(collin);
        allProfiles.Add(youssef);
        allProfiles.Add(lee);
        allProfiles.Add(ana);
        allProfiles.Add(jasper);
        allProfiles.Add(john);

        lisa.Like(collin, true);
        collin.Like(lisa, true);

        collin.ShowMatched();
        youssef.ShowMatched();

        jasper.ShowPotentialList(allProfiles);


    }
}
