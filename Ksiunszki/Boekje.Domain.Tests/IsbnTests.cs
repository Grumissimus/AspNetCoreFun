using Boekje.Core.Domain.Exceptions;
using Boekje.Core.Domain.Models;
using Boekje.Core.Domain.Mappers;
using NUnit.Framework;
using System;
using Boekje.Core.Domain.Factories;

namespace Boekje.Core.Domain.Tests
{
    public class ISBNTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("0-306-40615-2")]
        [TestCase("2-1234-5680-2")]
        [TestCase("83-87347-42-6")]
        public void ISBN10_CreatesIsbnWithoutErrors(string isbn)
        {
            Assert.DoesNotThrow(() => new ISBN10(isbn));
        }

        [Test]
        public void ISBN10_ThrowsFormatExceptionOnNull()
        {
            Assert.Throws<ArgumentException>(() => new ISBN10(null));
        }

        [Test]
        public void ISBN13_ThrowsFormatExceptionOnNull()
        {
            Assert.Throws<ArgumentException>(() => new ISBN13(null));
        }

        [TestCase("0-306-40615-1")]
        [TestCase("2-1234-5680-1")]
        [TestCase("83-87347-42-0")]
        public void ISBN10_ThrowsIsbnFailedChecksumExceptionOnChecksumFailure(string isbn)
        {
            Assert.Throws<ISBNFailedChecksumException>(() => new ISBN10(isbn));
        }

        [TestCase("978-3-16-148410-0")]
        [TestCase("978-83-7181-510-2")]
        [TestCase("978-83-89405-00-5")]
        [TestCase("978-3-540-21219-5")]
        [TestCase("978-0-070-26205-8")]
        [TestCase("978-1-7281-0889-6")]
        [TestCase("979-10-95558-04-0")]
        public void ISBN13_CreatesIsbnWithoutErrors(string isbn)
        {
            Assert.DoesNotThrow(() => new ISBN13(isbn));
        }

        [TestCase("0-306-40615-2", "978-0-306-40615-7")]
        [TestCase("83-87347-42-6", "978-83-87347-42-0")]
        public void ISBNMapper_ConvertsISBN10ToISBN13Correctly(string isbn, string expectedResult)
        {
            ISBN13 newIsbn = null;
            Assert.DoesNotThrow(() => newIsbn = ISBNMapper.From(new ISBN10(isbn)));
            Assert.AreEqual(newIsbn.Value, expectedResult);
        }

        [TestCase("978-3-16-148410-0", "3-16-148410-X")]
        public void ISBNMapper_ConvertsISBN13ToISBN10Correctly(string isbn, string expectedResult)
        {
            ISBN10 newIsbn = null;
            Assert.DoesNotThrow(() => newIsbn = ISBNMapper.From(new ISBN13(isbn)));
            Assert.AreEqual(newIsbn.Value, expectedResult);
        }


        [TestCase("979-10-95558-04-0")]
        public void ISBNMapper_ThrowsFormatExceptionIfISBN13StartsWith979(string isbn)
        {
            ISBN13 newIsbn = new ISBN13(isbn);
            Assert.Throws<FormatException>(() => ISBNMapper.From(newIsbn));
        }

        [TestCase("979-10-95558-04-0")]
        [TestCase("978-3-16-148410-0")]
        [TestCase("978-83-7181-510-2")]
        [TestCase("0-306-40615-2")]
        [TestCase("83-87347-42-6")]
        public void ISBNFactory_CreatesWithoutError(string isbn)
        {
            ISBN newIsbn = ISBNFactory.Create(isbn);
            Assert.IsInstanceOf<ISBN13>(newIsbn);
        }

        [TestCase("979-1065465165321-95558")]
        [TestCase("978-310-0")]
        [TestCase("")]
        [TestCase("0000000")]
        [TestCase(null)]
        public void ISBNFactory_ThrowsFormatExceptionIfISBNHasIncorrectNumberOfDigits(string isbn)
        {
            Assert.Throws<FormatException>(() => ISBNFactory.Create(isbn));
        }
    }
}