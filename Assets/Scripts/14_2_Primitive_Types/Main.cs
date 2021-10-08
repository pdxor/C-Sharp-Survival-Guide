using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DictionaryPrimitiveTypesSpace
{
    public class Main : MonoBehaviour
    {
        public Dictionary<string, int> people = new Dictionary<string, int>();
        public Dictionary<int, string> books = new Dictionary<int, string>();

        void Start()
        {
            // people
            people.Add("Jon", 26);
            people.Add("Rachel", 31);
            people.Add("Yin", 42);
            people.Add("James", 55);

            // access people
            int rachelsAge = people["Rachel"];
            Debug.Log("Rachel's Age: " + rachelsAge);

            // books
            books.Add(0, "The Ultimate Guide to Game Development with Unity");
            books.Add(1, "The Unity C# Survival Guide");
            books.Add(2, "Beautiful Games with Unity");

            // access books
            Debug.Log("Book ID 1: " + books[1]);

            // print all books
            foreach (KeyValuePair<int, string> book in books)
            {
                Debug.Log("Book " + book.Key + " Title: " + book.Value);
            }

            foreach (string book in books.Values)
            {
                Debug.Log("Title: " + book);
            }

            foreach (int bookid in books.Keys)
            {
                Debug.Log("Book ID: " + bookid);
            }

        }
    }
}
