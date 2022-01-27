// using length method for the string and printing a formatted string
string firstFriend = "Maria";
string secondFriend = "Sage";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} characters\nThe name {secondFriend} has {secondFriend.Length} characters");


string greeting = "        Hello World!          ";
Console.WriteLine($"[{greeting}]");

// trimming left side of the string
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// trimming right side of the string
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// trimming both sides of the string
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
Console.WriteLine("");


// replace a word with another word in the string
string sayHello = "Hello World!";
Console.WriteLine($"The string before changing a word: {sayHello}");

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine($"The new lyrics after changing the word: {sayHello}");

// make string all lower case or all upper case
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

Console.WriteLine("");

// searching strings

string songLyrics = "You say goodbye, and I say hello";

// .Contains() method returns a boolean expression 
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

Console.WriteLine("");

// assigning the boolean expression to a variable
var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);

Console.WriteLine("");

// check whether a string ends or starts with a certain string
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("say"));
