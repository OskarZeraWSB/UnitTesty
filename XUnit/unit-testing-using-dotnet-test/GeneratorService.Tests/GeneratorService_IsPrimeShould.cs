using Xunit;
using SimpleBank;

namespace Generate.UnitTests.Services
{
    public class GenerateService_IsGenerateShould
    {
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt4()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 1, 1, 1, 2, 6, 6, 1, 9, 0, 1, 7, 0, 5, 5, 3, 4 });
            Assert.Equal(7, result);
        }
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt6()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 6, 6, 9, 0, 3, 6, 7, 6, 9, 7, 3, 9, 7, 4, 5, 1 });
            Assert.Equal(8, result);
        }
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt10()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 8, 1, 9, 5, 7, 1, 3, 6, 7, 3, 1, 0, 0, 9, 4, 0 });
            Assert.Equal(8, result);
        }
    }
}