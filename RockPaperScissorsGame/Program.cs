using LibraryForGame;
 Console.WriteLine("Привет! Ты хочешь поиграть в камень ножницы бумага?"); // вынес за while, чтобы не повторялось
    while (true){

    Console.WriteLine("Выбери свой предмет. r - камень, p - бумага,s - ножницы. ");
    var userinput = Console.ReadLine();
    var userchoise = options.nothing; 
    Random rnd = new Random();
    int randforcompchoise = rnd.Next(1, 4); //Решил сделать свой рандом с помощью switch, потому что предыдущий не мог быть условием в if
    var computerchoise = options.nothing;
    switch (userinput)
    {
        case "r":
            {
                userchoise = options.rock;
                break;

            }
        case "p":
            {
                userchoise = options.paper;
                break;
            }
        case "s":
            {
                userchoise= options.scissors;
                break;
            }
            default:
            {
                Console.WriteLine("Выбери букву из перечисленных");
                
                break;
            }

    }
    switch (randforcompchoise)
    {
        case 1:
            {
                computerchoise = options.rock;
                break;
            }
        case 2:
            {
                computerchoise = options.paper;
                break;
            }

        case 3:
            {
                computerchoise = options.scissors;
                break;
            }
    }

    
    if (computerchoise == userchoise) { Console.WriteLine("Ничья"); } // оптимизация
    if (userchoise == options.rock && computerchoise == options.paper ) { Console.WriteLine("Ты выбрал камень, а компьютер бумагу. Компьютер выйграл!"); }
    if (userchoise == options.rock && computerchoise == options.scissors) { Console.WriteLine("Ты выбрал камень, а компьютер ножницы. Ты выйграл!"); }
    if (userchoise == options.paper && computerchoise == options.rock) { Console.WriteLine("Ты выбрал бумагу, а компьютер камень. Ты выйграл!"); }
    if (userchoise == options.paper && computerchoise == options.scissors) { Console.WriteLine("Ты выбрал бумагу, а компьютер ножницы. Компьютер выйграл!"); }
    if (userchoise == options.scissors && computerchoise == options.rock) { Console.WriteLine("Ты выбрал ножницы, а компьютер камень. Компьютер выйграл!"); }
    if (userchoise == options.scissors && computerchoise == options.paper) { Console.WriteLine("Ты выбрал ножницы, а компьютер бумагу. Ты выйграл!"); }
}

