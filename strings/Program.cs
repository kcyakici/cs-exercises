// using length method for the string and printing a formatted string
string firstFriend = "Maria";
string secondFriend = "Sage";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} characters\nThe name {secondFriend} has {secondFriend.Length} characters");


// trimming right and left side of the string
string greeting = "        Hello World!          ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// replace a word with another word in the string
string sayHello = "Hello World!";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// make string all lower case or all upper case
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// searching strings

string songLyrics = "You say goodbye, and I say hello";

// .Contains() method returns a boolean expression 
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// assigning the boolean expression to a variable
var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);

// check whether a string ends or starts with a certain string
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("say"));
