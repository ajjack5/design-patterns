using DesignPatterns.Creational.Builder.CSharp.Examples.Normal;
using Xunit;

namespace DesignPatterns.UnitTests.Creational.BuilderUnitTests
{
    public class EmailOrchestratorUnitTests
    {
        [Fact]
        public void CreatePasswordResetEmail_BuildsCorrectObject_WhenInvoked()
        {
            // arrange
            var emailOrchestrator = new EmailOrchestrator();

            // act
            var result = emailOrchestrator.CreatePasswordResetEmail("email@email.email");

            // assert
            Assert.NotNull(result);

            // just asserting 1 thing here to prove the correct object has been created
            Assert.Contains("password reset link goes here", result.Body);
        }

        [Fact]
        public void CreateSuspiciousActivityEmail_BuildsCorrectObject_WhenInvoked()
        {
            // arrange
            var emailOrchestrator = new EmailOrchestrator();

            // act
            var result = emailOrchestrator.CreateSuspiciousActivityEmail("email@email.email");

            // assert
            Assert.NotNull(result);

            // just asserting 1 thing here to prove the correct object has been created
            Assert.Contains("<p>Email has been flagged for suspicion</p>", result.Body);
        }

        [Fact]
        public void CreateWeeklyNewsletterEmail_BuildsCorrectObject_WhenInvoked()
        {
            // arrange
            var emailOrchestrator = new EmailOrchestrator();

            // act
            var result = emailOrchestrator.CreateWeeklyNewsletterEmail("email@email.email");

            // assert
            Assert.NotNull(result);

            // just asserting 1 thing here to prove the correct object has been created
            Assert.DoesNotContain("<p>Email has been flagged for suspicion</p>", result.Body);
        }
    }
}
