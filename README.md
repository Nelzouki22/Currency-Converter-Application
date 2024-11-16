Currency Converter Application 🌍💱


Description
A simple and efficient C# program for converting currencies using fixed exchange rates. This project is beginner-friendly and demonstrates basic programming concepts like conditionals, loops, and user input handling.

Features
Convert between different currencies:
Dollar to Euro
Euro to Dollar
Dollar to Libyan Dinar
Simple text-based user interface.
Predefined exchange rates for fast calculations.

Technologies Used
Language: C#
IDE: Visual Studio (or any C# compiler).

How to Run
Clone this repository:
bash
git clone https://github.com/yourusername/currency-converter.git


Open the project in your preferred IDE (e.g., Visual Studio).
Build and run the project.
Follow the on-screen instructions to select a conversion type and enter the amount.


Code Example
csharp
Copy code
switch (choice)
{
    case 1:
        convertedAmount = amount * 0.85; // Dollar to Euro
        break;
    case 2:
        convertedAmount = amount * 1.18; // Euro to Dollar
        break;
    case 3:
        convertedAmount = amount * 4.8; // Dollar to Libyan Dinar
        break;
    default:
        Console.WriteLine("Invalid option.");
        return;
}


Future Improvements
Add more currency conversion options.
Fetch live exchange rates using an API.
Build a graphical user interface (GUI) for better user experience.


Contact
If you have any questions or suggestions, feel free to reach out:

Email: elzoukigroup2018@gmail.com
GitHub: Nelzouki22
LinkedIn: Nadir Elzouki
YouTube: Nadir Elzouki


License
This project is licensed under the MIT License.

