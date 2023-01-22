namespace Common.Attributes.Tests
{
    using System;
    using Xunit;
    using static System.Tuple;

    public class NotDefaultAttributeTests
    {
        public static TheoryData<Tuple<object, bool>> IsValidData => new ()
        {
            Create(default(object), true),
            Create(new object(), true),
            Create<object, bool>(default(DateTimeOffset), false),
            Create<object, bool>(default(Guid), false)
        };

        [Theory]
        [MemberData(nameof(IsValidData))]
        public void IsValid(Tuple<object, bool> data)
        {
            // Arrange
            var (value, isValid) = data;
            var attribute = new NotDefaultAttribute();

            // Act
            var result = attribute.IsValid(value);

            // Assert
            Assert.Equal(isValid, result);
        }
    }
}
