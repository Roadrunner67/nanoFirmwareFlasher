using Xunit;

namespace nanoFirmwareFlasherTests
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var args = new string[] { "--stable", "--update", "--serialport", "COM4" };
            int result = await nanoFramework.Tools.FirmwareFlasher.Program.Main(args);
            Assert.Equal(0, result);
        }
    }
}
