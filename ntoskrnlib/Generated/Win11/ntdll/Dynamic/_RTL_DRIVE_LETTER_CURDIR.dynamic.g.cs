using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_DRIVE_LETTER_CURDIR")]
    public sealed class _RTL_DRIVE_LETTER_CURDIR : DynamicStructure
    {
        public ushort Flags { get; }
        public ushort Length { get; }
        public uint TimeStamp { get; }
        public _STRING DosPath { get; }

        public _RTL_DRIVE_LETTER_CURDIR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DRIVE_LETTER_CURDIR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DRIVE_LETTER_CURDIR.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DRIVE_LETTER_CURDIR.Length),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_RTL_DRIVE_LETTER_CURDIR.TimeStamp),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_DRIVE_LETTER_CURDIR.DosPath),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_DRIVE_LETTER_CURDIR>((mem, ptr) => new _RTL_DRIVE_LETTER_CURDIR(mem, ptr), offsets);
        }
    }
}