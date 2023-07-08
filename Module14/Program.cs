

using System.Runtime.InteropServices;

namespace Module14
{
    class Program
    {
        public static void Main()
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 7999945005 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            while (true)
            {
                var keyChar = Console.ReadKey().KeyChar;
                Console.Clear();

                if (!Char.IsDigit(keyChar))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                else
                {
                    IEnumerable<Contact> page = null;

                    switch (keyChar)
                    {
                        case ('1'):
                            page = contacts.Take(2);
                            break;
                        case ('2'):
                            page = contacts.Skip(2).Take(2);
                            break;
                        case ('3'):
                            page = contacts.Skip(4).Take(2);
                            break;

                            if (page == null)
                            {
                                Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                                continue;
                            }

                            
                            foreach (var contact in page)
                                Console.WriteLine(contact.Name + " " + contact.Phone);
                    }
                }
            }
        }
    }
}