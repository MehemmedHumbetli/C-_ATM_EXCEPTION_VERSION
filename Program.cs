using System;

class Program
{
    static void Main(string[] args)
    {
        int pin = 1234;
        int balans = 500;

        while (true)
        {
            Console.WriteLine("Enter your Pin: ");
            int password = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (password <= 9999)
                {
                    try
                    {
                        if (password == pin)
                        {
                            while (true)
                            {
                                Console.WriteLine("1.Check balance" +
                                                  "\n2.Withdraw money from balance" +
                                                  "\n3.Add money to balance" +
                                                  "\n4.Change PIN" +
                                                  "\n5.Home");
                                Console.WriteLine("Choose the option: ");
                                string choice = Console.ReadLine();
                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("Balance: " + balans);
                                        break;
                                    case "2":
                                        Console.WriteLine("How much money would you like to withdraw? ");
                                        int withdrawn_money = Convert.ToInt32(Console.ReadLine());
                                        try
                                        {
                                            if (withdrawn_money <= balans)
                                            {
                                                balans = balans - withdrawn_money;
                                                Console.WriteLine("Withdrawn money: " + withdrawn_money);
                                            }
                                            else
                                            {
                                                throw new IncorrectAmountException("There is no money in the balance!!");
                                            }
                                        }
                                        catch (IncorrectAmountException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("Enter money: ");
                                        int add_balans = Convert.ToInt32(Console.ReadLine());
                                        balans = balans + add_balans;
                                        Console.WriteLine("New Balance: " + balans);
                                        break;
                                    case "4":
                                        Console.WriteLine("Enter new PIN: ");
                                        int new_pin = Convert.ToInt32(Console.ReadLine());
                                        if (new_pin <= 9999)
                                        {
                                            pin = new_pin;
                                            Console.WriteLine("PIN successfully changed.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("INFO: Please enter a maximum of 4 digits for the PIN.");
                                        }
                                        break;
                                    case "5":
                                        Console.WriteLine("Returning to main menu...");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid option. Please choose again.");
                                        continue;
                                }
                                break;
                            }
                        }
                        else
                        {
                            throw new IncorrectPinException("INFO: Incorrect PIN");
                        }
                    }
                    catch (IncorrectPinException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new InccorectPinLenException("INFO: Please enter a maximum of 4 digits");
                }
            }
            catch (InccorectPinLenException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
