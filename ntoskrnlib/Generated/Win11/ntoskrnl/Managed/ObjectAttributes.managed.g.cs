using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_ATTRIBUTES")]
    public sealed class ObjectAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public IntPtr RootDirectory { get => ReadHere<IntPtr>(nameof(RootDirectory)); set => WriteHere(nameof(RootDirectory), value); }

        [Offset(16UL)]
        public IntPtr ObjectName { get => ReadHere<IntPtr>(nameof(ObjectName)); set => WriteHere(nameof(ObjectName), value); }

        [Offset(24UL)]
        public uint Attributes { get => ReadHere<uint>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(32UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(40UL)]
        public IntPtr SecurityQualityOfService { get => ReadHere<IntPtr>(nameof(SecurityQualityOfService)); set => WriteHere(nameof(SecurityQualityOfService), value); }

        public ObjectAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectAttributes>();
        }
    }
}