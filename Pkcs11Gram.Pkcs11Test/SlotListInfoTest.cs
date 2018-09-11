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
    public class SlotListInfoTest : TestBase
    {
        [Fact]
        public void SlotListTest()
        {
            List<Slot> slots = Pkcs11.GetSlotList(SlotsType.WithOrWithoutTokenPresent);

            slots.ShouldNotBeNull();
            slots.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public void SlotInfoTest()
        {
            List<Slot> slots = Pkcs11.GetSlotList(SlotsType.WithOrWithoutTokenPresent);

            slots.ShouldNotBeNull();
            slots.Count.ShouldBeGreaterThan(0);

            SlotInfo slotInfo = slots.First().GetSlotInfo();

            slotInfo.ShouldNotBeNull();
            slotInfo.ManufacturerId.ShouldNotBeNullOrEmpty();
        }
    }
}
