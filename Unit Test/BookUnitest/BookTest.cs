using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test;



//namespace Unit_Test
//{
//    [TestClass]
//    public class BookTest
//    {
//        private Book _book;

//        [TestInitialize]
//        public void BeforeTest()//ose Setup()
//        {
//            _book = new Book("Du", 2015);
//        }

//        [TestMethod]
//        public void TestTitle()
//        {
//            // Kontrollo vlerën fillestare
//            Assert.AreEqual("Du", _book.Title);

//            // Vendos një titull të ri
//            string expected = "Titanic";
//            _book.Title = expected;
//            string actual = _book.Title;
//            Assert.AreEqual(expected, actual);

//            // Testo që jep exception kur vendos null
//            try
//            {
//                _book.Title = null;
//                Assert.Fail("Expected exception was not thrown");
//            }
//            catch (ArgumentException e)
//            {
//                Assert.AreEqual("Title is null or empty", e.Message);
//            }
//        }

//        [TestMethod]
//        public void TestYear()
//        {
//            Assert.AreEqual(2015, _book.Year);

//            _book.Year = 2030;
//            Assert.AreEqual(2030, _book.Year);

//            // Testo që jep exception për vit negativ
//            try
//            {
//                _book.Year = -10;
//                Assert.Fail("Expected exception not thrown");
//            }
//            catch (ArgumentOutOfRangeException)
//            {
//                // OK
//            }
//        }

//        [TestMethod]
//        public void TestToString()
//        {
//            Assert.AreEqual("Book(Du,2015)", _book.ToString());
//        }
//    }
//}


namespace Unit_Test
{
    [TestClass]
    public sealed class BookTest
    {
        [TestMethod]
        public void TestTitle()
        {
            Book book = new Book("C# er fantastisk", 2015);

            Assert.AreEqual("C# er fantastisk", book.Title);

            string expected = "C# er sjovt";
            book.Title = expected;
            string actual = book.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleArgumentException()
        {
            Book book = new Book("C# er fantastisk", 2015);
            book.Title = null;     // duhet të hedhë ArgumentException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleArgumentException2()
        {
            Book book = new Book("C# er fantastisk", 2015);
            book.Title = "";       // duhet të hedhë ArgumentException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTitleArgumentOutOfRangeException()
        {
            Book book = new Book("C# er fantastisk", 2015);
            book.Title = "C";      // shumë e shkurtër → duhet të hedhë ArgumentOutOfRangeException
        }

        [TestMethod]
        public void TestYear()
        {
            Book book = new Book("C# er fantastisk", 2015);
            Assert.AreEqual(2015, book.Year);

            book.Year = 2010;
            Assert.AreEqual(2010, book.Year);//  if (value < 1100 || value > 2015) throw ArgumentOutOfRangeException

            // PROVO NJE GABIM.= që jep exception për vit negativ
            try
            {   
                book.Year = -10;
                Assert.Fail("Expected exception not thrown");
            }
            catch (ArgumentOutOfRangeException)//bravo — exception doli, testi kaloi
            {
                


            }
        }

        
    }
}