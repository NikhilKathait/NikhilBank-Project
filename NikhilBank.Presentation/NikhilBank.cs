class Bank
{   // Basic bank program without linking to SQL database
    // Applicatin execution starts
    static void Main()
    {
        // Display Title
        System.Console.WriteLine("************NikhilBank************");
        System.Console.WriteLine("::Login Page::");

        // Declare variables to store username and password
        string username = null, password = null;

        // Read username from keyboard
        System.Console.Write("Username: ");
        username = System.Console.ReadLine();

        if(username != "")
        {
            // Read password from keyboard
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        // Check username and password
        if(username == "system" && password == "admin")
        {
            // Declare a variable to store main menu choice
            int MainMenuChoice = -1;

            do
            {

                // Show main menu
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer statement");
                System.Console.WriteLine("5. Account statement");
                System.Console.WriteLine("0. Exit");

                // Accept main menu choice from keyboard
                System.Console.Write("Enter choice: ");
                MainMenuChoice = int.Parse(System.Console.ReadLine());

                // Switch-case to check main menu choice
                switch (MainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3: // TO DO: Display Funds Transfer menu
                        break;
                    case 4: // TO DO: Display Funds Transfer statement menu
                        break;
                    case 5: // TO DO: Display Account statement menu
                        break;
                }
            } while (MainMenuChoice != 0);
            } 
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }
        // About to exit
        System.Console.WriteLine("Thank You! Visit Again.");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        // Declare a variable to store CustomersMenu choice
        int customerMenuChoice = -1;

        // do-while loop starts
        do
        {
            // Print CustomersMenu
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add customer");
            System.Console.WriteLine("2. Delete customer");
            System.Console.WriteLine("3. Update customer");
            System.Console.WriteLine("4. View customer");
            System.Console.WriteLine("0. Back to Main Menu");

            // Accept customers menu choice
            System.Console.Write("Enter choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            // Switch-case to check main menu choice
            switch (customerMenuChoice)
            {
                case 1: // TO DO:
                    break;
                case 2: // TO DO: Display Accounts menu
                    break;
                case 3: // TO DO: Display Funds Transfer menu
                    break;
                case 4: // TO DO: Display Funds Transfer statement menu
                    break;
            }
        }while(customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        // Declare a variable to store AccountsMenu choice
        int AccountsMenuChoice = -1;

        // do-while loop starts
        do
        {
            // Print AccountsMenu
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            // Accept customers menu choice
            System.Console.Write("Enter choice: ");
            AccountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            // Switch-case to check main menu choice
            switch (AccountsMenuChoice)
            {
                case 1: // TO DO:
                    break;
                case 2: // TO DO: Display Accounts menu
                    break;
                case 3: // TO DO: Display Funds Transfer menu
                    break;
                case 4: // TO DO: Display Funds Transfer statement menu
                    break;
            }
        } while (AccountsMenuChoice != 0);
    }
}
