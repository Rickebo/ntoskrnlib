using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_CPTABLEINFO")]
    public sealed class _CPTABLEINFO : DynamicStructure
    {
        public ushort CodePage { get; }
        public ushort MaximumCharacterSize { get; }
        public ushort DefaultChar { get; }
        public ushort UniDefaultChar { get; }
        public ushort TransDefaultChar { get; }
        public ushort TransUniDefaultChar { get; }
        public ushort DBCSCodePage { get; }
        public byte[] LeadByte { get; }
        public IntPtr MultiByteTable { get; }
        public IntPtr WideCharTable { get; }
        public IntPtr DBCSRanges { get; }
        public IntPtr DBCSOffsets { get; }

        public _CPTABLEINFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CPTABLEINFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CPTABLEINFO.CodePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.MaximumCharacterSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.DefaultChar),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.UniDefaultChar),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.TransDefaultChar),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.TransUniDefaultChar),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.DBCSCodePage),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.LeadByte),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.MultiByteTable),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.WideCharTable),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.DBCSRanges),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CPTABLEINFO.DBCSOffsets),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_CPTABLEINFO>((mem, ptr) => new _CPTABLEINFO(mem, ptr), offsets);
        }
    }
}