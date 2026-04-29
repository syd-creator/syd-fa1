using System;

public class CitizenProfile
{
    public string FullName { get; set; }
    public string IDNumber { get; set; }
    public int Age { get; set; }
    public string CitizenshipStatus { get; set; }

    public CitizenProfile(string name, string id, string citizenship)
    {
        FullName = name;
        IDNumber = id;
        CitizenshipStatus = citizenship;

        Age = CalculateAge(id);
    }

    private int CalculateAge(string id)
    {
        string dob = id.Substring(0, 6);

        int year = int.Parse(dob.Substring(0, 2));
        int month = int.Parse(dob.Substring(2, 2));
        int day = int.Parse(dob.Substring(4, 2));

        int fullYear;

        if (year <= DateTime.Now.Year % 100)
            fullYear = 2000 + year;
        else
            fullYear = 1900 + year;

        DateTime birthDate = new DateTime(fullYear, month, day);

        int age = DateTime.Now.Year - birthDate.Year;

        if (DateTime.Now < birthDate.AddYears(age))
            age--;

        return age;
    }

    public string ValidateID()
    {
        if (IDNumber.Length != 13)
            return "Invalid ID: Must be 13 digits";

        if (!long.TryParse(IDNumber, out _))
            return "Invalid ID: Must be numeric";

        return "ID Validated Successfully";
    }
}