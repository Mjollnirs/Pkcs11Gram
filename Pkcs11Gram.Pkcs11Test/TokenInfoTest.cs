using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Pkcs11Gram.Pkcs11Test
{
    public class TokenInfoTest : TestBase
    {
        [Fact]
        public void BasicTokenInfoTest()
        {
            Slot slot = Pkcs11.GetSlotList(SlotsType.WithTokenPresent).First();

            slot.ShouldNotBeNull();

            TokenInfo tokenInfo = slot.GetTokenInfo();
            tokenInfo.ShouldNotBeNull();
            tokenInfo.ManufacturerId.ShouldNotBeNullOrEmpty();
        }
    }
}
