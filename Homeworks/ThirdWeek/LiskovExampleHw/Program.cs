using LiskovExampleHw;
// See https://aka.ms/new-console-template for more information

var typeForSuit = ValidationLibrary.ValidationFactory(4).GetType().Name;
Console.WriteLine(typeForSuit);
var typeForMeeting = ValidationLibrary.ValidationFactory(130).GetType().Name;
Console.WriteLine(typeForMeeting);
var typeForConference = ValidationLibrary.ValidationFactory(500).GetType().Name;
Console.WriteLine(typeForConference);