using FluentAssertions;
using Hiperspace.Heap;
using Hiperspace.Rocks;

namespace CodePath.Test
{
    public class TestSequence
    {
        [Fact]
        public async Task TestGetSequence()
        {
            using (var driver = new HeapSpace())
            {
                using (var code = new CodePathSpace(driver))
                {
                    var key = new Class();
                    var seq = await code.Classs.GetSequenceAsync(key);
                    seq.Should().Be(1);
                }
            }
        }
        [Fact]
        public async Task TestUseSequence()
        {
            using (var driver = new HeapSpace())
            {
                using (var code = new CodePathSpace(driver))
                {
                    var key = new Class();
                    var seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(1);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(2);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(3);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(4);
                }
            }
        }
        [Fact]
        public async Task TestUseRocksSequence()
        {
            if (Directory.Exists("./rockstest")) Directory.Delete("./rockstest", true);
            using (var driver = new RockSpace("./rockstest"))

            {
                using (var code = new CodePathSpace(driver))
                {
                    var key = new Class();
                    var seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(1);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(2);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(3);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(4);
                    key = new Class { Id = 1 };
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(1);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(2);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(3);
                    seq = await code.Classs.UseSequenceAsync(key);
                    seq.Should().Be(4);

                }
            }
        }
    }
}
