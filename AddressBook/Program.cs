﻿using System;

namespace AddressBook
{
    public class Contact
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
            Console.WriteLine("contact details" + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip +"\n" + contact.PhoneNumber  +"\n" + contact.Email );
        }
    }
}
