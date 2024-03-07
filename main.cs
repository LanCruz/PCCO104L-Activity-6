using System; 
class Program { 
    public static void Main(string[] args) { 
      
        while(true){
            Console.WriteLine("Select Activity from 1-5"); 
            string acts = Console.ReadLine(); 
            Console.WriteLine();

            switch (acts) 
                { 
                    case "1":
                        PHMoneyDenomination();
                    break;
                    case "2": 
                        NumberDivisibility();
                    break; 
                    case "3":
                        InputMessage();
                    break;
                    case "4":
                        BuildPyramid();
                    break;
                    case "5":
                        SumvsAppend();
                    break; 
                    case "exit":
                        Console.WriteLine("Closing program");
                    return;
                    default: Console.WriteLine("Invalid input. Please select from 1 to 5."); 
                    break;
                    } 
        }
    }
    static void PHMoneyDenomination()
        { Console.WriteLine("Activity 1 - PH Money Denomination"); 
            while (true) { 
                Console.WriteLine("Enter value: "); 
                string input = Console.ReadLine(); 
                decimal value; 
                if (input.ToLower() == "exit"){
                    Console.WriteLine("  ");
                    break; 
                } 
                if (decimal.TryParse(input, out value))
                { if (value == 0.01m || value == 0.05m || value == 0.25m){ 
                    Console.WriteLine($"No person is found in PHP. {value}"); 
                } 
                else if (value == 1){
                    Console.WriteLine($"Jose Rizal is found in Php. {value}");
                } else if (value == 5){ 
                    Console.WriteLine($"Emilio Aguinaldo is found in Php. {value}"); 
                } 
                else if (value == 10) { 
                    Console.WriteLine($"Andres Bonifacio & Apolinario Mabini is found in Php. {value}"); 
                } 
                else if (value == 20) { 
                    Console.WriteLine($"Manuel L. Quezon is found in Php. {value}"); 
                } 
                else if (value == 50) { Console.WriteLine($"Sergio Osmena is found in Php. {value}"); } 
                else if (value == 100) { Console.WriteLine($"Manuel Roxas is found in Php. {value}"); } 
                else if (value == 200) { Console.WriteLine($"Diosdado Macapagal is found in Php. {value}"); } 
                else if (value == 500) { Console.WriteLine($"Benigno Sr. & Corazon Aquino is found in Php. {value}"); } 
                else if (value == 1000) { Console.WriteLine($"Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda is found in Php. {value}"); } 
                else { 
                    Console.WriteLine("Invalid Denomination"); 

                } 

                } 

            } 

            } 
    static void NumberDivisibility() { 
        Console.WriteLine("Activity 2 - Number Divisibility by 3 and 5"); 
            while (true) 
            { 
                Console.WriteLine("Enter a value: "); 
                string input = Console.ReadLine(); 
                if (input.ToLower() == "exit") { 
                    break; 
                } 
                if (int.TryParse(input, out int numb)) {
                    for (int i = 1; i <= numb; i++) { if (i % 3 == 0 && i % 5 == 0) { 
                            Console.WriteLine($"{i} - FooBar"); 
                        } 
                    else if (i % 5 == 0) { 
                            Console.WriteLine($"{i} - Bar"); 
                        } 
                    else if (i % 3 == 0) { 
                            Console.WriteLine($"{i} - Foo"); 
                        } 
                    else { 
                            Console.WriteLine(i); 
                        } 

                        } 
                    } 
                } 
            } 
    static void InputMessage() {
        Console.WriteLine("Activity 3 - Input Message");
      var message = "";
        while (true) 
            { 
                Console.WriteLine("Enter Something: "); 
                var input = Console.ReadLine().Trim();
                if (input.ToLower() == "exit") { 
                    break; 
                    }
                else{
                  message += input + " ";
              }
              Console.WriteLine(message);

                } 
            } 
    static void BuildPyramid() { 
        Console.WriteLine("Activity 4 - Build Pyramid"); 
      while (true) {
      Console.Write("Enter a number: ");
      string input = Console.ReadLine();

      if (input == "0") {
          Console.WriteLine(" ");
          break;
      }

      if (int.TryParse(input, out int num) && num > 0) {
          for (int i = 1; i <= num; ++i) {
              for (int j = 1; j <= num - i; ++j) {
                  Console.Write(" ");
              }
              for (int k = 1; k <= 2 * i - 1; ++k) {
                  Console.Write("*");
              }
              Console.WriteLine();
          }
      }
      else {
          Console.WriteLine("Invalid value: ");
          }
      } 
            } 
    static void SumvsAppend() {
        Console.WriteLine("Activity 5 - Sum vs Append"); 
        var gogo = true; 
        string msg = ""; 
        int sum = 0; 
        while (gogo) 
        { 
            Console.Write("Enter something: "); 
            string input = Console.ReadLine().Trim(); 
            if (input.ToLower() == "exit") 
            { 
                Console.WriteLine(" "); 
                break; 
            } 
            if (int.TryParse(input, out int addnum)) 
            {
                sum += addnum; Console.WriteLine($"Adding {addnum} to {sum - addnum} = {sum}."); Console.WriteLine(); 
            } 
            else { 
                    msg += " " + input; Console.WriteLine($"Current Message is: {msg}"); Console.WriteLine(); 

                    } 
                }
                } 
}