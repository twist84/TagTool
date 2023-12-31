using TagTool.Cache;

namespace TagTool.Tags
{
    public class TagData
	{
        public CacheAddressType AddressType = CacheAddressType.Data;
        public byte[] Data;

        public int Size;
        public uint Address;
        public uint Gen1ExternalOffset;


        public TagData()
        {
        }

        public TagData(byte[] data)
        {
            Data = data;
            Size = data.Length;
        }
    }
}
