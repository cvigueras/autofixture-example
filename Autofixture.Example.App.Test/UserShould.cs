using AutoFixture;

namespace Autofixture.Example.App.Test
{
    public class UserShould
    {
        private Home home;
        private Fixture fixture;

        [SetUp]
        public void Setup()
        {
            home = new Home();
            fixture = new Fixture();
        }

        [Test]
        public void get_message_under_eighteen_years()
        {
            //Given
            var givenUserUnderEighteen = fixture.Build<User>()
                                                .With(u => u.Age, 16)
                                                .Create();

            //When
            var message = home.Access(givenUserUnderEighteen);

            //Then
            Assert.IsTrue(string.Equals(message, "Aplicación web solo para personas mayores de edad",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_eighteen_under_thirty_years()
        {
            //Given
            var givenUserOverEighteenUnderThirty = fixture.Build<User>()
                                                .With(u => u.Age, 29)
                                                .Create();

            //When
            var message = home.Access(givenUserOverEighteenUnderThirty);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 20€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }


        [Test]
        public void get_message_over_thirty_under_sixty_five_years()
        {
            //Given
            var givenUserOverThirtyUnderSixtyFive = fixture.Build<User>()
                                                .With(u => u.Age, 46)
                                                .Create();

            //When
            var message = home.Access(givenUserOverThirtyUnderSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 25€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_sixty_five_years()
        {
            //Given
            var givenUserOverSixtyFive = fixture.Build<User>()
                                                .With(u => u.Age, 67)
                                                .Create();

            //When
            var message = home.Access(givenUserOverSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 30€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}