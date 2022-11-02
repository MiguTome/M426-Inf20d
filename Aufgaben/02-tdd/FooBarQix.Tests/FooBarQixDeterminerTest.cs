using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_WhenNumber_ShouldReturnNumberAsString() {
            int number = 1;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("1", result);
        }
        [Fact]
        public void Determine_WhenThree_ShouldReturnFoo() {
            int number = 3;
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("Foo", result);

        }
        [Fact]
        public void Determine_WhenFive_ShouldReturnBar() {
            int number = 5; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("Bar", result);

        }

        [Fact]
        public void Determine_WhenSeven_ShouldReturnQix() {
            int number = 7; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("Qix", result);
            
        }

        [Fact]
        public void Determine_ShouldReturnFooBar() {
            int number = 15; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("FooBar", result);
            
        }
        [Fact]
        public void Determine_ShouldReturnFooQix() {
            int number = 21; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("FooQix", result);

        }
        [Fact]
        public void Determine_ShouldReturnBarQix() {
            int number = 35; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("BarQix", result);

        }
        [Fact]
        public void Determine_ShouldReturnFooBarQix() {
            int number = 105; 
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            var result = determiner.Determine(number);

            Assert.Equal("FooBarQix", result);

        }

    }
}