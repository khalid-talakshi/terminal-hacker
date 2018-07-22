using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start() {
        ShowMainMenu("Welcome Khalid");       
	}

    void ShowMainMenu(string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Initializing Hacker.exe");
        Terminal.WriteLine("Loading Script...");
        Terminal.WriteLine("Script Loaded Successfully");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Please Select Destination");
        Terminal.WriteLine("1. Rec Center");
        Terminal.WriteLine("2. TD Bank");
        Terminal.WriteLine("3. Canadian Security Agency");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your Selection: ");
    }

    void OnUserInput(string input)
    {
        Terminal.ClearScreen();
        if (input == "menu")
        {
            ShowMainMenu("Welcome Back Khalid");
        } else if (input == "1")
        {
            Terminal.WriteLine("Rec Center Selected");
        } else if (input == "2")
        {
            Terminal.WriteLine("TD Bank Selected");
        } else if (input == "3")
        {
            Terminal.WriteLine("Canadian Security Agency Selected");
        } else if (input == "42")
        {
            Terminal.WriteLine("Ah you wise wizard,\nyou know the meaning of life,\nbut unfourtanently it is not a valid\nlevel.");
        } else if(input == "007")
        {
            Terminal.WriteLine("We've been expecting you, Mr.Bond.\nPlease head to any level to begin your mission");
        } else if (input == "69")
        {
            Terminal.WriteLine("Title of your sex tape!;p\nPlease select a valid level");
        } else if (input == "99")
        {
            Terminal.WriteLine("NINE NINE!, noice, smort.\nCatch the Pontiact Bandit\nin one of the levels!");
        } else
        {
            Terminal.WriteLine("Please select a valid level!\nThe fate of the world is at stake!");
        }
    }
}
