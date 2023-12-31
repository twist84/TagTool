using TagTool.Common;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "shader_black", Tag = "rmbk", Size = 0x4)]
    public class ShaderBlack : RenderMethod
    {
        [TagField(Flags = TagFieldFlags.GlobalMaterial)]
        public StringId Material;
    }
}