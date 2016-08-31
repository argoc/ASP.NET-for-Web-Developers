using System;

/// <summary>
/// PhoneBookEntry matches a row in the PhoneBookDB
/// </summary>
public class PhoneBookEntry
{
    public PhoneBookEntry(dynamic row)
    {
        Id = row.Id;
        Name = row.Name;
        PhoneNumber = row.PhoneNumber;
        Email = row.Email;
        TwitterHandle = row.TwitterHandle;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public string TwitterHandle { get; set; }
}