using System;
using System.Collections.Generic;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialData = new List<int> { };
            using (LargeDataCollection collection = new LargeDataCollection(initialData))
            {
                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Add an element");
                    Console.WriteLine("2. Remove an element");
                    Console.WriteLine("3. Access an element");
                    Console.WriteLine("4. Display all elements");
                    Console.WriteLine("5. Exit");
                    Console.Write("Your choice: ");
                    string choiceStr = Console.ReadLine();
                    if (!int.TryParse(choiceStr, out int choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the element to add: ");
                            if (int.TryParse(Console.ReadLine(), out int elementToAdd))
                                collection.Add(elementToAdd);
                            else
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            break;
                        case 2:
                            Console.Write("Enter the element to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int elementToRemove))
                            {
                                if (collection.Remove(elementToRemove))
                                    Console.WriteLine("Element removed successfully.");
                                else
                                    Console.WriteLine("Element not found in the collection.");
                            }
                            else
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            break;
                        case 3:
                            Console.Write("Enter the index of the element to access: ");
                            if (int.TryParse(Console.ReadLine(), out int index))
                            {
                                if (index >= 0 && index < collection.Count)
                                    Console.WriteLine($"Element at index {index}: {collection[index]}");
                                else
                                    Console.WriteLine("Invalid index. Please enter a valid index within the collection range.");
                            }
                            else
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            break;
                        case 4:
                            collection.DisplayAllElements();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
            }
        }
    }
}