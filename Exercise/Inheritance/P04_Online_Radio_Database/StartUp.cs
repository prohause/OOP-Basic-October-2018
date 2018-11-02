using P04_Online_Radio_Database.Models;
using System;

namespace P04_Online_Radio_Database
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            try
            {
                throw new InvalidSongException();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}