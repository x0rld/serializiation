﻿using System;
using System.Text.Json;

namespace serialize;

internal class Program
{
    private static void Main(string[] args)
    {
        string username;
        string password;
        Quiz myQuiz = new Quiz("user","pass");
        try
        {
            Console.WriteLine("se connecter :");
            username = Console.ReadLine();
            Console.WriteLine("mot de passe :");
            password = Console.ReadLine();
            bool isconnected = myQuiz.VerifUser(username, password);
            //Si l'utilisateur est connecté, on vérifie maintenant s'il s'agit de l'admin ou d'un user.
            if (isconnected)
            {
                if (username != "Admin") // User car != admin
                    myQuiz.DisplayQuiz();
                else // Admin
                {
                    myQuiz.DisplayAdminMenu();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Erreur");
        }
        


        /*
         * File.ReadAllLines("data.json");
         * serializeJSon
         */
        /*
         * Menu/mdp 
         */
        /*
        Console.WriteLine("SERIALIZATION");
        */


    }

    //Affichage du menu




}






