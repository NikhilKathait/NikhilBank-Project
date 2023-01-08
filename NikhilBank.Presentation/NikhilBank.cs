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
            System.Console.WriteLine("TO DO: Main menu here");

        }
        // About to exit
        System.Console.WriteLine("Thank You! Visit Again.");
        System.Console.ReadKey();
    }
}
