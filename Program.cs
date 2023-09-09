using System;

class Program {
  public static void Main (string[] args) 
  
  {

    //This program demonstrates the purpose of a DO...WHILE loop
    string enteredUsername, enteredPassword;
    string storedUsername = "user";
    string storedPassword = "password";

    //DO WHILE is a condition-based loop that is exit-controlled
    //To exit the loop you will need to change the value of the boolean from TRUE to FALSE
    //The key difference between a WHILE() and a DO...WHILE() is that a DO WHILE will be executed at least once before being executed again. A WHILE loop may never be executed
    
    bool incorrectDetails = true;//Depending on whether this is true or false will determine whether or not the loop repeats
    int counter =0;//This variable will record the number of times the loop as ran
    
    do
    {
      if(counter==0)//This will run the first time into the loop
      {
        Console.WriteLine("Please enter your username");
        enteredUsername= Console.ReadLine();
        Console.WriteLine("Please enter your username");
        enteredPassword= Console.ReadLine();
      }
      else//This will only run if the user has entered the correct details on at least one occasion
      {
        Console.WriteLine("Incorrect details entered.\nPlease enter your username");
        enteredUsername= Console.ReadLine();
        Console.WriteLine("Please enter your username");
        enteredPassword= Console.ReadLine();
      }

      //A NESTED if can be use to verify both the username and password are correct
      if(enteredUsername ==storedUsername)
        if(enteredPassword == storedPassword)
        {
          incorrectDetails = false;
        }
      counter++;//This is the same as saying counter=counter+1. This should only add one after the body of the loop has been processed
    }
    while(incorrectDetails);
    Console.WriteLine("You have entered the correct username and password.");
  }
}
