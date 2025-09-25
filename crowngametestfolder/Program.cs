using System.Collections;
bool gameloop = true;
while (gameloop == true)
{
  //intro  
  Console.Write("there are three doors ahead of you, one has the king that you are looking for and one has a grumpy dragon in it. which door do you pick");
    string doorchoice = Console.ReadLine() + "";
  //assignes the options random numbers  
  Random drandom = new Random();
    int dragondoor = drandom.Next(1, 4);
    Random krandom = new Random();
    int golddoor = krandom.Next(1, 4);
    Random nrandom = new Random();
    int kingdoor = nrandom.Next(1, 4);
    while (dragondoor == golddoor)
    {
        golddoor = krandom.Next(1, 4);
    }
    while (kingdoor == golddoor || kingdoor == dragondoor)
    {
        kingdoor = krandom.Next(1, 4);
    }
    switch (doorchoice)
    {
      //options if 1 is selected  
      case "1":
            switch (dragondoor)
            {
                case 1:
                    Console.WriteLine("Congragulations, you found the dragon and died");
                    gameloop = false;
                    break;
            }
            switch (kingdoor)
            {
                case 1:
                    Console.WriteLine("you found the king, victorie");
                    gameloop = false;
                    break;
            }
            switch (golddoor)
            {
                case 1:
                    Console.WriteLine("you found some gold, please continue");
                    break;
            }
            break;
        //options if 2 is selected
        case "2":
            switch (dragondoor)
            {
                case 2:
                    Console.WriteLine("Congragulations, you found the dragon and died");
                    gameloop = false;
                    break;
            }
            switch (kingdoor)
            {
                case 2:
                    Console.WriteLine("you found the king, victorie");
                    gameloop = false;
                    break;
            }
            switch (golddoor)
            {
                case 2:
                    Console.WriteLine("you found some gold, please continue");
                    break;
            }
            break;
        //options if 3 is selected
        case "3":
            switch (dragondoor)
            {
                case 3:
                    Console.WriteLine("Congragulations, you found the dragon and died");
                    gameloop = false;
                    break;
            }
            switch (kingdoor)
            {
                case 3:
                    Console.WriteLine("you found the king, victorie");
                    gameloop = false;
                    break;
            }
            switch (golddoor)
            {
                case 3:
                    Console.WriteLine("you found some gold, please continue");
                    break;
            }
            break;
    }
}





