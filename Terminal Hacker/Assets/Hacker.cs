using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    //game state
    int level;

    enum Screen { MainMenu, Password, Win};
    string password;
    string[] level1Passwords = {"fitness", "swimming", "slide", "books", "library"};
    string[] level2Passwords = {"finance", "monetary", "mortgage", "teller", "money"};
    string[] level3Passwords = {"security", "fraud", "intelligence", "espionage", "shadows"};

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
        } else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");

        if (isValidLevelNumber)
        {
            level = int.Parse(input);
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

        //if (input == "1")
        //{
        //    password = "fitness";
        //    StartGame();
        //}
        //else if (input == "2")
        //{
        //    password = "financial";
        //    StartGame();
        //}
        //else if (input == "3")
        //{
        //    password = "security";
        //    StartGame();
        //}
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            currentScreen = Screen.Win;
            ShowWinScreen();
        }
        else
        {
            Terminal.WriteLine("Please Try Again");
        }
    }
    
    void ShowWinScreen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Password Accepted");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Congraulations. you've completed level " + level + ". Type menu to go back to main menu");
    }
}
