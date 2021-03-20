using System;
using Xunit;
using Application.Products;
using Moq;
using Persistence;
using Domain;
using System.Collections.Generic;
namespace UnitTests
{
    public class ListTest
    {
        private readonly List _list;
        private readonly Mock<DataContext> _context;

        public ListTest()
        {
            _context = new Mock<DataContext>();
            _list = new List(_context.Object);
        }

        [Fact]
        public void GetList_GivenTypeIsListProduct()
        {
            var result = _list.GetList();
            Assert.IsType<List<Product>>(result);
        }
    }
}