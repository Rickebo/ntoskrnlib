using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_MAP")]
    public sealed class WnfScopeMap : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public IntPtr SystemScopeInstance { get => ReadHere<IntPtr>(nameof(SystemScopeInstance)); set => WriteHere(nameof(SystemScopeInstance), value); }

        [Offset(16UL)]
        public IntPtr MachineScopeInstance { get => ReadHere<IntPtr>(nameof(MachineScopeInstance)); set => WriteHere(nameof(MachineScopeInstance), value); }

        [Offset(24UL)]
        public IntPtr PhysicalMachineScopeInstance { get => ReadHere<IntPtr>(nameof(PhysicalMachineScopeInstance)); set => WriteHere(nameof(PhysicalMachineScopeInstance), value); }

        [Offset(32UL)]
        [Length(6)]
        public DynamicArray ByDataScope { get => ReadStructure<DynamicArray>(nameof(ByDataScope)); set => WriteStructure(nameof(ByDataScope), value); }

        public WnfScopeMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfScopeMap>();
        }
    }
}