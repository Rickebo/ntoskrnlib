using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT")]
    public sealed class _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT : DynamicStructure
    {
        public uint Level { get; }
        public uint Slot { get; }

        public _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT.Slot),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT>((mem, ptr) => new _PSP_SYSCALL_PROVIDER_DISPATCH_CONTEXT(mem, ptr), offsets);
        }
    }
}