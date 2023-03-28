
using ExtensionMethods;
Console.WriteLine("Hello, World!");
int number = 25;

Console.WriteLine(number.GetSquare());

string sentence = "ali veliye meraba dedi";

Console.WriteLine(sentence.MergeWords());

object by = new ();

Console.WriteLine(by.Class());

Sombreros sombre = new() { Typee = "Fotr", Origin = "England", Description = "It is a type of hat with a hard inside and brim, created by an Englishman named Thomas William Coke in 1850,"
                                    +"whose main purpose is to protect from low tree branches while on a horse."};

sombre.PrintSombrerosProperties();