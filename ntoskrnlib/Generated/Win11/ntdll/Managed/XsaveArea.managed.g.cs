using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_XSAVE_AREA")]
    public sealed class XsaveArea : DynamicStructure
    {
        [Offset(0UL)]
        public XsaveFormat LegacyState { get => ReadStructure<XsaveFormat>(nameof(LegacyState)); set => WriteStructure(nameof(LegacyState), value); }

        [Offset(512UL)]
        public XsaveAreaHeader Header { get => ReadStructure<XsaveAreaHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        public XsaveArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XsaveArea>();
        }
    }
}