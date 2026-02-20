using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
////unitest=TestBook na ndihmon të gjejmë gabimet
// Dhe bën që programi “Book” të funksionojë si duhet
// Pa unit test → gabimet do t’i kuptonim shumë më vonë
// Me unit test → i shohim menjëherë
//metodat punojnë siç duhet
//gjejë gabimet në kod automatikisht

public class Book
{
    private string _title;
    private int _year;

    public string Title
    {
        get { return _title; }
        set
        {
            if (value == null)
                throw new ArgumentException("Title cannot be null.");

            if (value.Length == 0)
                throw new ArgumentException("Title cannot be empty.");

            if (value.Length < 2)
                throw new ArgumentOutOfRangeException("Title must be at least 2 characters long.");

            _title = value;
        }
    }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 1100 || value > 2015)
                throw new ArgumentOutOfRangeException("year", value, "Year must be between 1100 and 2015.");

            _year = value;
        }
    }

    public Book(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public override string ToString()
    {
        return $"Book({Title}, {Year})";
    }
}

