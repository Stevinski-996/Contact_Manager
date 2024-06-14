using System;

namespace Contacts_Manager 
{
    public class Program
    {
        static List<string> contacts = new List<string>() ;
        static void Main(string[] args)
        {
        ContactsManager() ;
        }
        public static void ContactsManager() 
            {
            AddContact("Fadi");
            AddContact("Fadi");
            AddContact("");
            AddContact("Yazan");
            AddContact("Huda");
            RemoveContact("Fadi");
            RemoveContact("");
            RemoveContact("Salam");
            ViewAllContacts();}
        public static void AddContact(string contact) {
       if (string.IsNullOrEmpty(contact)) { 
            Console.WriteLine("\u001b[31mCannot add empty contact\u001b[0m");
            } else {
                if (contacts.Contains(contact)) {
                        Console.WriteLine("\u001b[31mYou already have this contact\u001b[0m") ;
                } else {
                    contacts.Add(contact);
                    Console.WriteLine("\u001b[32mContact added\u001b[0m");
                }    }
        ViewAllContacts() ;
                }
        public static void RemoveContact(string contact) {
            if (string.IsNullOrEmpty(contact)) {
                Console.WriteLine("\u001b[31mCannot remove empty contact\u001b[0m");
            } else {
                if (contacts.Contains(contact)) {
                    contacts.Remove(contact);
                    Console.WriteLine("\u001b[32mContact removed\u001b[0m");
                } else {
                    Console.WriteLine("\u001b[31mYou don't have this contact\u001b[0m");
                }  }
        ViewAllContacts() ;
                }
        public static void ViewAllContacts() {
            foreach (string contact in contacts) {
                Console.WriteLine(contact);
            }  } } }