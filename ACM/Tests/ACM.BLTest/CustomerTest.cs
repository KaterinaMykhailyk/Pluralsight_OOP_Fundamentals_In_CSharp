using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Katya",
                LastName = "Mykhailyk"
            };
            string expected = "Mykhailyk, Katya";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Mykhailyk"
            };
            string expected = "Mykhailyk";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Katya"
            };
            string expected = "Katya";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // -- Act
            
            // -- Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = true;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
