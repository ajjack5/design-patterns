using DesignPatterns.Creational.Builder.CSharp.Examples.Static;
using System;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.BuilderUnitTests
{
    public class StaticEmailBuilderUnitTests
    {
        [Fact]
        public void To_AppendsEmailRecipient_InitialisingTheRecipientListIfNotInitialised()
        {
            // arrange
            var email = new StandardEmail();
            var recipientEmail = "newEmail@newEmail";

            // act
            email.AppendToRecipient(recipientEmail);

            // assert
            Assert.NotNull(email.To);
            Assert.Equal(1, email.To.Count);
            Assert.Equal(email.To[0], recipientEmail);
        }

        [Fact]
        public void To_ThrowsException_WhenRecipientIsNull()
        {
            // arrange
            var email = new StandardEmail();
            string recipientEmail = null;

            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => email.AppendToRecipient(recipientEmail));
        }

        [Fact]
        public void AddFrom_AppendsSenderEmail_WhenInvoked()
        {
            // arrange
            var email = new StandardEmail();

            // act
            email.AddFrom();

            // assert
            Assert.Equal("email@email.email", email.From);
        }

        [Fact]
        public void AddBody_AppendsBody_WhenInvoked()
        {
            // arrange
            var email = new StandardEmail();
            var body = "email body goes here";

            // act
            email.AddBody(body);

            // assert
            Assert.Equal(body, email.Body);
        }

        [Fact]
        public void AddTitle_AppendsTitle_WhenTitleGreaterThan5Letters()
        {
            // arrange
            var email = new StandardEmail();
            var title = "1234565";

            // act
            email.AddTitle(title);

            // assert
            Assert.Equal(title, email.Title);
        }

        [Fact]
        public void AddTitle_ThrowsException_WhenTitleLessThan5Letters()
        {
            // arrange
            var email = new StandardEmail();
            var title = "1234";

            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => email.AddTitle(title));
        }
    }
}
