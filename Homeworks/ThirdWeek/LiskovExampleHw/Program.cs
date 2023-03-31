using LiskovExampleHw;
// See https://aka.ms/new-console-template for more information

var typeForSuit = ValidationLibrary.ValidationFactory(4);
Console.WriteLine(typeForSuit.GetType().Name);
Console.WriteLine(typeForSuit.IsDayValid(DateTime.Now.AddHours(2), DateTime.Now.AddDays(5)));
var typeForMeeting = ValidationLibrary.ValidationFactory(130);
Console.WriteLine(typeForMeeting.GetType().Name);
Console.WriteLine(typeForMeeting.IsAvailableValid());
var typeForConference = ValidationLibrary.ValidationFactory(500);
Console.WriteLine(typeForConference.GetType().Name);
Console.WriteLine(typeForConference.IsCapacityValid());