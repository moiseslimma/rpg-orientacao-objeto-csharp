// See https://aka.ms/new-console-template for more information

using rpg.src.Entities;
using static System.Console;

Knight arus = new("Arus", 10, "Knight");
Wizard wizard = new("Jennica", 23, "Wizard");
Ninja ninja = new("Wedge", 16, "Ninja");
BlackWizard blackWizard = new("Topapa", 5, "Black Wizard");

WriteLine(wizard.ToString());
WriteLine(wizard.Attack(10));
WriteLine(ninja.ToString());
WriteLine(arus.ToString());
WriteLine(blackWizard.ToString());
WriteLine(ninja.Attack());
WriteLine(arus.Attack());

