using System;

namespace P04_Online_Radio_Database.Models
{
    internal class InvalidSongException : ArgumentException
    {
        public InvalidSongException() : base("Invalid song.")
        {
        }
    }
}