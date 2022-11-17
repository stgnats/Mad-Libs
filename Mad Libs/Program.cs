using System;
// 4 different commentary excperts, answers, and titles:
string commATitle = " THROUGH GOES HAMILTON!";
string commBTitle = "CHAMPION OF THE WORLD!";
string commCTitle = "BUT HERE COMES SEBASTIAN VETTEL!";
string commDTitle = "HE WINS IN SPA, HE WINS IN MONZA!";
string commA = "Mercedes through everything at him today; Charles Leclerc has _____ brilliantly. He won in spa – __ ____ __ _____! Charles Leclerc is the winner of the 2019 Italian grand prix.";
string commB = "Mercedes not happy, Redbull will be _________. They have shared a brilliant ____________ battle, but the championship can only be one by one and its going _____ __ ____. Max Verstappen, for the first time ever, is champion of the world!";
string commC = "Up to the top of Radillion _________ has made up places at the start, ___ ____ _____ _________ ______! He’s neck and neck with _____ ________ - Vettel is alongside and ahead, ____ is also ahead, they’re 4 abreast going into ___ ______.";
string commD = "_____ is catching _______ _______, he takes him towards the ______ - _____ on the inside - _______ _______ gives him just enough _____. Can _____ squeeze past? They're going _____ __ _____ towards ____ now - who's gonna be last on the ______? _______ has that inside line, _____ goes off the track, cuts the chicane, ___ ____ _______ - _______ ____ ________! Unbelievable stuff coming out of the final ______. _____ and ______ going for it, ________ says thank you very much, another thing _____ up for him.";
string commDAns = "Perez is catching Charles Leclerc, he takes him towards the inside - Perez on the inside - Charles Leclerc gives him just enough space. Can Perez squeeze past? They're going wheel to wheel towards vale now - who's gonna be last on the brakes? Leclerc has that inside line, Perez goes off the track, cuts the chicane, off goes Leclerc - THROUGH GOES HAMILTON! Unbelievable stuff coming out of the final corner. Perez and Leclerc going for it, Hamilton says thank you very much, another thing opens up for him.";
string commCAns = "Up to the top of Radillion Magnussen has made up places at the start, BUT HERE COMES SEBASTIAN VETTEL! He’s neck and neck with Lewis Hamilton - Vettel is alongside and ahead, Ocon is also ahead, they’re 4 abreast going into les combes.";
string commBAns = "Mercedes not happy, Redbull will be delighted. They have shared a brilliant championship battle, but the championship can only be one by one and its going Dutch in 2021. Max Verstappen, for the first time ever, is champion of the world!";
string commAAns = "Mercedes through everything at him today; Charles Leclerc has coped brilliantly. He won in spa – HE WINS IN MONZA! Charles Leclerc is the winner of the 2019 Italian grand prix.";

// Main Menu Code:
//if (commDAns == )
Console.WriteLine("Welcome to Commentary Madlibs! - Press any enter to continue...");
Console.ReadLine();
Console.WriteLine("Please Choose your commentary exerpt:");
Console.WriteLine($"{commATitle}: VERY HARD \n {commBTitle}: Hard \n {commCTitle}: Medium \n {commDTitle}: Easy"); //$ sign allows the variables to be put into the string easily
string choice = Console.ReadLine();

// Main Game Code:

if (choice.ToLower() == "a") 
{
    // displays the text with blanks in
    Console.WriteLine("You have selected A, write your answers below in order and press enter to move to next blank - good luck! \n" + commA);
    Console.Write("1. ");
    string choice1 = Console.ReadLine();
    Console.Write("2. ");
    string choice2 = Console.ReadLine();
    Console.Write("3. ");
    string choice3 = Console.ReadLine();
    Console.Write("4. ");
    string choice4 = Console.ReadLine();
    Console.Write("5. ");
    string choice5 = Console.ReadLine();
    // shows what the user has put and what the correct answer was and tells the user if they are correct
    string userAns = $"Mercedes through everything at him today; Charles Leclerc has {choice1} brilliantly. He won in spa – {choice2} {choice3} {choice4} {choice5}! Charles Leclerc is the winner of the 2019 Italian grand prix.";
    Console.WriteLine($"Your answer is:  \n{userAns} \nThe correct answer is: \n{commAAns}");
    if (userAns.ToLower() == commAAns.ToLower())
    {
        Console.WriteLine("You are correct!");
    }
    else
    {
        Console.WriteLine("Your answer was not correct!");
    }
}
else if (choice.ToLower() == "b")
{
    Console.WriteLine("You have selected B, write your answers below in order and press enter to move to next blank - good luck! \n" + commB);
    Console.Write("1. ");
    string choice1 = Console.ReadLine();
    Console.Write("2. ");
    string choice2 = Console.ReadLine();
    Console.Write("3. ");
    string choice3 = Console.ReadLine();
    Console.Write("4. ");
    string choice4 = Console.ReadLine();
    Console.Write("5. ");
    string choice5 = Console.ReadLine();
    string userAns = $"Mercedes not happy, Redbull will be {choice1}. They have shared a brilliant {choice2} battle, but the championship can only be one by one and its going {choice3} {choice4} {choice5}. Max Verstappen, for the first time ever, is champion of the world!";
    Console.WriteLine($"Your answer is:  \n{userAns} \nThe correct answer is: \n{commBAns}");
    if (userAns.ToLower() == commBAns.ToLower())
    {
        Console.WriteLine("You are correct!");
    }
    else
    {
        Console.WriteLine("Your answer was not correct!");
    }
}
else if (choice.ToLower() == "c")
{
    Console.WriteLine("You have selected C, write your answers below in order and press enter to move to next blank - good luck! \n" + commC);
    string choice1 = Console.ReadLine();
    Console.Write("2. ");
    string choice2 = Console.ReadLine();
    Console.Write("3. ");
    string choice3 = Console.ReadLine();
    Console.Write("4. ");
    string choice4 = Console.ReadLine();
    Console.Write("5. ");
    string choice5 = Console.ReadLine();
    Console.Write("6. ");
    string choice6 = Console.ReadLine();
    Console.Write("7. ");
    string choice7 = Console.ReadLine();
    Console.Write("8. ");
    string choice8 = Console.ReadLine();
    Console.Write("9. ");
    string choice9 = Console.ReadLine();
    Console.Write("10. ");
    string choice10 = Console.ReadLine();
    Console.Write("11. ");
    string choice11 = Console.ReadLine();
    string userAns = $"Up to the top of Radillion {choice1} has made up places at the start, {choice2} {choice3} {choice4} {choice5} {choice6}! He’s neck and neck with {choice7} {choice8} - Vettel is alongside and ahead, {choice9} is also ahead, they’re 4 abreast going into {choice10} {choice11}";
    Console.WriteLine($"Your answer is:  \n{userAns} \nThe correct answer is: \n{commCAns}");
    if (userAns.ToLower() == commCAns.ToLower())
    {
        Console.WriteLine("You are correct!");
    }
    else
    {
        Console.WriteLine("Your answer was not correct!");
    }
}
else if (choice.ToLower() == "d")
{
    //probably much better way so come back and sort it
    Console.WriteLine("You have selected D, write your answers below in order and press enter to move to next blank - good luck! \n" + commD);
    Console.Write("1. ");
    string choice1 = Console.ReadLine();
    Console.Write("2. ");
    string choice2 = Console.ReadLine();
    Console.Write("3. ");
    string choice3 = Console.ReadLine();
    Console.Write("4. ");
    string choice4 = Console.ReadLine();
    Console.Write("5. ");
    string choice5 = Console.ReadLine();
    Console.Write("6. ");
    string choice6 = Console.ReadLine();
    Console.Write("7. ");
    string choice7 = Console.ReadLine();
    Console.Write("8. ");
    string choice8 = Console.ReadLine();
    Console.Write("9. ");
    string choice9 = Console.ReadLine();
    Console.Write("10. ");
    string choice10 = Console.ReadLine();
    Console.Write("11. ");
    string choice11 = Console.ReadLine();
    Console.Write("12. ");
    string choice12 = Console.ReadLine();
    Console.Write("13. ");
    string choice13 = Console.ReadLine();
    Console.Write("14. ");
    string choice14 = Console.ReadLine();
    Console.Write("15. ");
    string choice15 = Console.ReadLine();
    Console.Write("16. ");
    string choice16 = Console.ReadLine();
    Console.Write("17. ");
    string choice17 = Console.ReadLine();
    Console.Write("18. ");
    string choice18 = Console.ReadLine();
    Console.Write("19. ");
    string choice19 = Console.ReadLine();
    Console.Write("20. ");
    string choice20 = Console.ReadLine();
    Console.Write("21. ");
    string choice21 = Console.ReadLine();
    Console.Write("22. ");
    string choice22 = Console.ReadLine();
    Console.Write("23. ");
    string choice23 = Console.ReadLine();
    Console.Write("24. ");
    string choice24 = Console.ReadLine();
    Console.Write("25. ");
    string choice25 = Console.ReadLine();
    Console.Write("26. ");
    string choice26 = Console.ReadLine();
    Console.Write("27. ");
    string choice27 = Console.ReadLine();
    string userAns = $"{choice1} is catching {choice2} {choice3}, he takes him towards the {choice4} - {choice5} on the inside - {choice6} {choice7} gives him just enough {choice8}. Can {choice9} squeeze past? They're going {choice10} {choice11} {choice12} towards {choice13} now - who's gonna be last on the {choice14}? {choice15} has that inside line, {choice16} goes off the track, cuts the chicane, {choice17} {choice18} {choice19} - {choice20} {choice21} {choice22}! Unbelievable stuff coming out of the final {choice23}. {choice24} and {choice25} going for it, {choice26} says thank you very much, another thing {choice27} up for him.";
    Console.WriteLine($"Your answer is:  \n{userAns} \nThe correct answer is: \n{commDAns}");
    if (userAns.ToLower() == commDAns.ToLower())
    {
        Console.WriteLine("You are correct!");
    }
    else
    {
        Console.WriteLine("Your answer was not correct!");
    }
}