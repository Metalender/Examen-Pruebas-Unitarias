using Xunit;

namespace Metaverso
{

    public class SistemaTest

    {

        [Theory]
        [InlineData(3,"Meta ")]
        [InlineData(5,"Verso ")]
        [InlineData(15,"Metaverso ")]
        [InlineData(1, "1 ")]
        public void MetaTest(int num, string esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.Meta(num);
            // Then
            Assert.Equal(result, esperado);
        }
      /*  [Theory]
        [InlineData(3, "Meta 77 ")]
        [InlineData(5, "Verso Meta")]
        [InlineData(15,"Metaverso Metaverso Verso")]
        [InlineData(1,3,4,5, "1 3 4 Verso")]
        public void MetaTestArray(int[] num, string esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.Meta(num);
            // Then
            Assert.Equal(result, esperado);
        }
        */
    }
}