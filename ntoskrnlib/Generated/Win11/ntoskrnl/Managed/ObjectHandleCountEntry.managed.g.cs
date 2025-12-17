using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_COUNT_ENTRY")]
    public sealed class ObjectHandleCountEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(8UL)]
        public uint HandleCount { get => ReadHere<uint>(nameof(HandleCount)); set => WriteHere(nameof(HandleCount), value); }

        [Offset(8UL)]
        public uint LockCount { get => ReadHere<uint>(nameof(LockCount)); set => WriteHere(nameof(LockCount), value); }

        public ObjectHandleCountEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHandleCountEntry>();
        }
    }
}