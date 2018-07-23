using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    //game state
    int level;

    enum Screen { MainMenu, Password, Win};

    Screen currentScreen;

	// Use this for initialization
	void Start() {
        ShowMainMenu("Welcome Khalid");       
	}

    void ShowMainMenu(string greeting) {
        currentScreen = Screen.MainMenu;
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
        } else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "42")
        {
            Terminal.WriteLine("Ah you wise wizard,\nyou know the meaning of life,\nbut unfourtanently it is not a valid\nlevel.");
        }
        else if (input == "007")
        {
            Terminal.WriteLine("We've been expecting you, Mr.Bond.\nPlease head to any level to begin your mission");
        }
        else if (input == "69")
        {
            Terminal.WriteLine("Title of your sex tape!;p\nPlease select a valid level");
        }
        else if (input == "99")
        {
            Terminal.WriteLine("NINE NINE!, noice, smort.\nCatch the Pontiact Bandit\nin one of the levels!");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level!\nThe fate of the world is at stake!");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected level " + level);
        Terminal.WriteLine("Enter your password");
    }
}
