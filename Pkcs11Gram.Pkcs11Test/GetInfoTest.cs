using Net.Pkcs11Interop.HighLevelAPI;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pkcs11Gram.Pkcs11Test
{
    public class GetInfoTest : TestBase
    {
        [Fact]
        public void BasicGetInfoTest()
        {
            LibraryInfo libraryInfo = Pkcs11.GetInfo();

            libraryInfo.ShouldNotBeNull();
            libraryInfo.CryptokiVersion.ShouldBe("2.40");
            libraryInfo.ManufacturerId.ShouldNotBeNullOrEmpty();
        }
    }
}
