﻿// Use Parameters In Methods

/*   CountTo(5);

void CountTo(int max)
{
    for(int i = 0; i<max; i++)
    {
        Console.Write($"${i}, ");
    }
} */


//Create A Method With Parameters

/* int[] schedule = { 800, 1200, 1600, 2000 };
DisplayAdjustedTimes(schedule, 6, -6);
void DisplayAdjustedTimes(int[]times,int currentGMT,int newGMT)
{
    int diff = 0;
    if(Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <=0 && currentGMT <= 0 || newGMT >=0 && currentGMT >= 0)
    {
        diff = 100*(Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for(int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]}-> {newTime}");
    }
} */


//Method Scope

/*string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };
DisplayStudents(students);
inspekta tahidi machachari shirandula kaarada naswa motheril 
junior auntieboss 
DisplayStudents(new string[] { "Robert", "Vanya" });
void DisplayStudents(string[] students)
{
    foreach(string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
} */

/*double pi = 3.14159;
void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
void PrintCircleArea(int radius)
{
    
    double area = pi* (radius * radius);
    Console.WriteLine($"Area = {area}");
} 

 pi = 3.14159;
 PrintCircleInfo(12);
    PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
} */

//Value And Reference Type Parameters

using System.Data;
using System.Runtime.CompilerServices;

/*int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"Inside Multiply Method: {a} x {b} = {c}");
} */

/* int[] array = { 1, 2, 3, 4, 5 };
PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
}
void Clear(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
} */

/*string status = "Healthy";
Console.WriteLine($"Start: {status}");
SetHealth( false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
} */


//Methods With Optional Parameters

/* string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count =  0;

RSVP("Rebecca"/*, 1, "none", true);
RSVP("Nadia", 2, "Nuts"/*, true);
RSVP(name: "Linh", partySize: 2, /*allergies: "none", inviteOnly: false);      //the parameters have been assigned the values but this will not affect the output     
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit"/*, partySize: 1);    
RSVP("Noor", 4,/* "none", inviteOnly : false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1,string allergies = "none",bool inviteOnly = true)
{
    if (inviteOnly)        //You check to see if the given name is equal to any of the names on the guest list.
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if(guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;  
        }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i< count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
} */


//Challenge to Display email Adresses

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
} 