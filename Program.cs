// start main
int userChoice = GetUserChoice(); 
while(userChoice!=3) 
{ 
    RouteEm(userChoice);
    userChoice = GetUserChoice(); 
}


static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

// end main

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice=="1" || userChoice=="2" || userChoice=="3"){
        return true;
    }
    return false; 
}

static void GetFullTriangle() {
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 1; i <= number; i++) {
        for(int j = 1; j <= i; j++) {
            System.Console.Write("0");
        }
        System.Console.WriteLine("");
    }
    PauseAction();
}

static void GetPartialTriangle() {
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 1; i <= number; i++) {
        for(int j = 1; j <= i; j++) {
            int decomp = rnd.Next(4);
            if(decomp != 1){
                System.Console.Write("0");
            }
        } 
        System.Console.WriteLine("");
    }
    PauseAction();

}
static void SayInvalidChoice() {
    System.Console.WriteLine("Invalid Choice");
    
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFullTriangle();
    }
    else if(menuChoice==2) {
        GetPartialTriangle();
    }else if(menuChoice!=3) {
        SayInvalidChoice();
        PauseAction();
    }
    
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

