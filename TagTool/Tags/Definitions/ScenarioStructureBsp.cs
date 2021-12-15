using TagTool.Cache;
using TagTool.Common;
using TagTool.Geometry;
using TagTool.Havok;
using System;
using System.Collections.Generic;
using static TagTool.Tags.TagFieldFlags;
using TagTool.Tags.Resources;
using TagTool.Geometry.BspCollisionGeometry;
using TagTool.Pathfinding;

namespace TagTool.Tags.Definitions
{
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x3A0, MaxVersion = CacheVersion.Halo3Retail, Platform = CachePlatform.MCC)]
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x388, MaxVersion = CacheVersion.Halo3Retail)]
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x394, MaxVersion = CacheVersion.Halo3ODST)]
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x3AC, MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline106708)]
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x3B8, MinVersion = CacheVersion.HaloOnline700123, MaxVersion = CacheVersion.HaloOnline700123)]
    [TagStructure(Name = "scenario_structure_bsp", Tag = "sbsp", Size = 0x51C, MinVersion = CacheVersion.HaloReach, MaxVersion = CacheVersion.HaloReach)]
    public class ScenarioStructureBsp : TagStructure
    {
        [TagField(Flags = Padding, Length = 12, MaxVersion = CacheVersion.Halo2Vista)]
        public byte[] Unused1 = new byte[12];

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public StructureBuildIdentifier BuildIdentifier;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public StructureBuildIdentifier ParentBuildIdentifier;

        [TagField(MinVersion = CacheVersion.Halo3Beta)]
        public int ImportInfoChecksum;
        [TagField(MinVersion = CacheVersion.Halo3Beta)]
        public int ImportVersion;

        [TagField(Length = 2, Flags = Padding, MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline106708)]
        public byte[] Unused4;
        [TagField(MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline106708)]
        public StructureBspCompatibilityValue CompatibilityFlags; 

        [TagField(Length = 4, Flags = Padding, MinVersion = CacheVersion.Halo3ODST, MaxVersion = CacheVersion.Halo3ODST, Platform = CachePlatform.Original)]
        [TagField(Length = 4, Flags = Padding, MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.Halo3ODST, Platform = CachePlatform.MCC)]
        public byte[] Unused5;
        [TagField(Length = 4, Flags = Padding, MinVersion = CacheVersion.Halo3Beta, MaxVersion = CacheVersion.HaloOnline700123)]
        public byte[] Unused6;

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public FlagsValueReach FlagsReach;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public ContentPolicyFlagsValue ContentPolicyFlags;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public ContentPolicyFlagsValue FailedContentPolicyFlags;
        [TagField(Length = 2, Flags = Padding, MinVersion = CacheVersion.HaloReach)]
        public byte[] Padding1;

        [TagField(MinVersion = CacheVersion.Halo3Retail)]
        public List<SeamIdentifier> SeamIdentifiers;

        [TagField(MinVersion = CacheVersion.Halo3Retail)]
        public List<EdgeToSeamMapping> EdgeToSeams;

        public List<CollisionMaterial> CollisionMaterials;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public List<CollisionGeometry> CollisionBsp;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public float VehicleFloorWorldUnits;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public float VehicleCeilingWorldUnits;

        [TagField(Flags = Padding, Length = 8, MaxVersion = CacheVersion.Halo2Vista)]
        public byte[] Unused2 = new byte[8];

        public List<Leaf> Leaves; // UnknownRaw3rd

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<Gen4.ScenarioStructureBsp.StructureSuperNodeAabbsBlock> SuperAabbs;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<Gen4.ScenarioStructureBsp.SuperNodeMappingsBlock> SuperNodeParentMappings;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<Gen4.ScenarioStructureBsp.SuperNodeRecursableMasksBlock> SuperNodeRecursableMasks;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<Gen4.ScenarioStructureBsp.StructureSuperNodeTraversalGeometryBlock> SuperNodeTraversalGeometry;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public CollisionKdHierarchyStatic InstanceKdHierarchy;

        public Bounds<float> WorldBoundsX;
        public Bounds<float> WorldBoundsY;
        public Bounds<float> WorldBoundsZ;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public List<SurfaceReference> SurfaceReferences;

        [TagField(MinVersion = CacheVersion.Halo3Retail)]
        public List<SurfacesPlanes> SurfacePlanes;

        [TagField(MinVersion = CacheVersion.Halo3Retail)]
        public List<PlaneReference> Planes;

        [TagField(Flags = Padding, Length = 0xC, MinVersion = CacheVersion.Halo3Retail, Platform = CachePlatform.MCC)]
        [TagField(Flags = Padding, Length = 0xC, MinVersion = CacheVersion.HaloOnlineED, MaxVersion =  CacheVersion.HaloOnline700123, Platform = CachePlatform.Original)]
        public byte[] UnknownUnused1;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public byte[] ClusterData;

        public List<ClusterPortal> ClusterPortals;

        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        public List<UnknownBlock2> Unknown14;

        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public List<FogBlock> Fog;

        [TagField(Flags = Padding, Length = 24, MaxVersion = CacheVersion.Halo2Vista)]
        public byte[] Unused3 = new byte[24];

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public List<WeatherPaletteEntry> WeatherPalette;

        [TagField(MaxVersion = CacheVersion.Halo2Vista)]
        public List<WeatherPolyhedron> WeatherPolyhedra;

        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        public List<CameraEffect> CameraEffects;

        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown18;
        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown19;
        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown20;

        [TagField(Flags = Padding, Length = 0xC, MinVersion = CacheVersion.HaloOnline700123, MaxVersion = CacheVersion.HaloOnline700123)]
        public byte[] UnknownUnused2;

        public List<DetailObject> DetailObjects;
        public List<Cluster> Clusters;
        public List<RenderMaterial> Materials;
        public List<SkyOwnerClusterBlock> SkyOwnerCluster;
        public List<ConveyorSurface> ConveyorSurfaces;
        public List<BreakableSurfaceBits> BreakableSurfaces;
        public List<TagPathfinding> PathfindingData;
        public uint Unknown30; //  cookie cutters block?
        public uint Unknown31;
        public uint Unknown32;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown56; // emissive materials block?
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown57;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown58;
        public List<BackgroundSoundEnvironmentPaletteBlock> BackgroundSoundEnvironmentPalette;

        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown33;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown34;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown35;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown36;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown37;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown38;
        public uint Unknown39;
        public uint Unknown40;
        public uint Unknown41;
        public uint Unknown42;
        public uint Unknown43;
        public List<Marker> Markers;
        public List<TagReferenceBlock> Lights;
        public List<RuntimeLight> RuntimeLights;
        public List<RuntimeDecal> RuntimeDecals;
        public List<EnvironmentObjectPaletteBlock> EnvironmentObjectPalette;
        public List<EnvironmentObject> EnvironmentObjects;
        public uint Unknown45;

        public uint Unknown46;
        public uint Unknown47;
        public uint Unknown48;

        public uint Unknown49;
        public uint Unknown50;
        public uint Unknown51;

        public uint Unknown52;
        public uint Unknown53;
        public uint Unknown54;

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown91;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown92;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown93;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown94;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown95;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown96;

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<StructureInstanceClusterDefinition> ClusterToInstanceGroupSpheres;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<StructureInstanceGroupDefinition> InstanceGroupToInstanceSpheres;


        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown103;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown104;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown105;  
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public List<InstancedGeometryInstance> InstancedGeometryInstances;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<InstancedGeometryInstanceName> InstancedGeometryInstanceNames;
        [TagField(ValidTags = new[] { "iimz" }, MinVersion = CacheVersion.HaloReach)]
        public CachedTag InstanceImposters;
        public List<TagReferenceBlock> Decorators;
        public RenderGeometry DecoratorGeometry;

        [TagField( MinVersion = CacheVersion.HaloReach)]
        public List<BspPreplacedDecalSetReferenceBlock> PreplacedDecalSets;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public List<BspPreplacedDecalReferenceBlock> PreplacedDecals;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public RenderGeometry PreplacedDecalGeometry;

        public List<UnknownSoundClustersBlock> UnknownSoundClustersA;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public List<UnknownSoundClustersBlock> UnknownSoundClustersB;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public List<UnknownSoundClustersBlock> UnknownSoundClustersC;
        public List<TransparentPlane> TransparentPlanes;
        public uint Unknown64;
        public uint Unknown65;
        public uint Unknown66;
        public List<TagHkpMoppCode> CollisionMoppCodes;
        public uint Unknown67;
        public RealPoint3d CollisionWorldBoundsLower;
        public RealPoint3d CollisionWorldBoundsUpper;
        public List<TagHkpMoppCode> BreakableSurfaceMoppCodes;
        public List<BreakableSurfaceKeyTableBlock> BreakableSurfaceKeyTable;
        public uint Unknown68;
        public uint Unknown69;
        public uint Unknown70;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown71;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown72;
        [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown73;
        public RenderGeometry Geometry;

        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown75;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown76;
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public uint Unknown77;

        public List<LeafSystem> LeafSystems;
        public List<StructureBspTagResources> TagResources;

        public TagResourceReference CollisionBspResource;

        [TagField(MinVersion = CacheVersion.Halo3Retail, Platform = CachePlatform.MCC)]
        [TagField(MinVersion = CacheVersion.Halo3ODST, Platform = CachePlatform.Original)]
        public TagResourceReference PathfindingResource;

        [TagField(MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline106708)]
        [TagField(MinVersion = CacheVersion.HaloReach)]
        public int Unknown86;

        [TagField(MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown87;
        [TagField(MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown88;
        [TagField(MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown89;

        [TagField(MinVersion = CacheVersion.HaloOnline301003, MaxVersion = CacheVersion.HaloOnline700123)]
        public uint Unknown90;


        [TagStructure(Size = 0x18)]
        public class StructureBuildIdentifier : TagStructure
        {
            [TagField(Length = 4)]
            public int[] ManifestId = new int[4];
            public int BuildIndex;
            public int StructureImporterVersion;
        }

        [Flags]
        public enum FlagsValueReach : ushort
        {
            None = 0,
            HasInstanceGroups = 1 << 0,
            SurfaceToTriangleMappingRemapped = 1 << 1,
            ExternalReferencesConvertedToIo = 1 << 2,
            StructureMoppNeedsRebuilt = 1 << 3,
            StructurePrefabMaterialsNeedPostprocessing = 1 << 4,
            SerializedHavokDataConvertedToTargetPlatform = 1 << 5
        }

        [Flags]
        public enum ContentPolicyFlagsValue : ushort
        {
            None = 0,
            HasWorkingPathfinding = 1 << 0,
            ConvexDecompositionEnabled = 1 << 1
        }

        [Flags]
        public enum StructureBspCompatibilityValue : ushort
        {
            None = 0,
            UseMoppIndexPatch  = 1 << 0,
            Reach = 1 << 1
        }

        [TagStructure(Size = 0x28)]
        public class SeamIdentifier : TagStructure
        {
            [TagField(Length = 4)]
            public int[] SeamIDs;
            public List<Edge> EdgeMapping;
            public List<Cluster> ClusterMapping;

            [TagStructure(Size = 0x4)]
            public class Edge : TagStructure
            {
                public int StructureEdgeIndex;
            }

            [TagStructure(Size = 0x10)]
            public class Cluster : TagStructure
            {
                public int ClusterIndex;
                public RealPoint3d ClusterCenter;
            }
        }

        [TagStructure(Size = 0x14, MaxVersion = CacheVersion.Halo2Vista)]
        [TagStructure(Size = 0x18, MinVersion = CacheVersion.Halo3Retail)]
        public class CollisionMaterial : TagStructure
        {
            [TagField(Flags = Label, MaxVersion = CacheVersion.Halo2Vista)]
            public CachedTag OldShader;

            [TagField(Flags = Label, MinVersion = CacheVersion.Halo3Retail)]
            public CachedTag RenderMethod;

            public short RuntimeGlobalMaterialIndex;
            public short ConveyorSurfaceIndex;

            [TagField(MaxVersion = CacheVersion.Halo2Vista)]
            public CachedTag NewShader;

            [TagField(MinVersion = CacheVersion.Halo3Retail)]
            public short SeamMappingIndex;

            [TagField(MinVersion = CacheVersion.Halo3Retail)]
            public FlagsValue Flags;

            [Flags]
            public enum FlagsValue : ushort
            {
                None = 0,
                IsSeam = 1 << 0
            }
        }

        [TagStructure(Size = 0x8, MaxVersion = CacheVersion.Halo2Vista)]
        [TagStructure(Size = 0x1, MinVersion = CacheVersion.Halo3Retail)]
        public class Leaf : TagStructure
        {
            [TagField(MaxVersion = CacheVersion.Halo2Vista)]
            public short ClusterOld;
            [TagField(MinVersion = CacheVersion.Halo3Retail)]
            public byte ClusterNew;

            [TagField(MaxVersion = CacheVersion.Halo2Vista)]
            public short SurfaceReferenceCount;

            [TagField(MaxVersion = CacheVersion.Halo2Vista)]
            public int FirstSurfaceReferenceIndex;

            public override void PostConvert(CacheVersion from, CacheVersion to)
            {
                if (from <= CacheVersion.Halo2Vista && to >= CacheVersion.Halo3Retail)
                    ClusterNew = (byte)ClusterOld;
            }
        }

        [TagStructure(Size = 0x24, MaxVersion = CacheVersion.Halo2Vista)]
        [TagStructure(Size = 0x28, MinVersion = CacheVersion.Halo3Retail, MaxVersion = CacheVersion.HaloOnline700123)]
        [TagStructure(Size = 0x50, MinVersion = CacheVersion.HaloReach)]
        public class ClusterPortal : TagStructure
        {
            [TagField(MinVersion = CacheVersion.HaloReach)]
            public OrientedBoundsStruct OrientedBounds;
            public short BackCluster;
            public short FrontCluster;
            public int PlaneIndex;
            public RealPoint3d Centroid;
            public float BoundingRadius;
            public FlagsValue Flags;
            public List<Vertex> Vertices;

            public enum FlagsValue : int
            {
                None = 0,
                AiCantHearThroughThisShit = 1 << 0,
                OneWay = 1 << 1,
                Door = 1 << 2,
                NoWay = 1 << 3,
                OneWayReversed = 1 << 4,
                NoOneCanHearThroughThis = 1 << 5
            }

            [TagStructure(Size = 0xC)]
            public class Vertex : TagStructure
            {
                public RealPoint3d Position;
            }

            [TagStructure(Size = 0x28)]
            public class OrientedBoundsStruct : TagStructure
            {
                public RealPoint3d Center;
                public RealVector3d Extents;
                public RealQuaternion Orientation;
            }
        }

        [TagStructure(Size = 0x78)]
        public class UnknownBlock2 : TagStructure
        {
            [TagField(Length = 32)]
            public string Name;

            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;

            public uint Unknown5;

            public uint Unknown6;
            public uint Unknown7;
            public uint Unknown8;
            public uint Unknown9;
            public uint Unknown10;
            public uint Unknown11;
            public uint Unknown12;
            public uint Unknown13;

            public uint Unknown14;
            public uint Unknown15;
            public uint Unknown16;
            public uint Unknown17;

            public uint Unknown18;
            public uint Unknown19;
            public uint Unknown20;

            public uint Unknown21;

            public uint Unknown22;
        }

        [TagStructure(Size = 0x8)]
        public class FogBlock : TagStructure
        {
            public StringId Name;
            public short Unknown;
            public short Unknown2;
        }

        [TagStructure(Size = 0x78)]
        public class WeatherPaletteEntry : TagStructure
        {
            [TagField(Length = 32)]
            public string Name;

            [TagField(ValidTags = new[] { "weat" })]
            public CachedTag WeatherSystem;

            [TagField(Flags = Padding, Length = 2)]
            public byte[] Unused1 = new byte[2];

            [TagField(Flags = Padding, Length = 2)]
            public byte[] Unused2 = new byte[2];

            [TagField(Flags = Padding, Length = 32)]
            public byte[] Unused3 = new byte[32];

            [TagField(ValidTags = new[] { "wind" })]
            public CachedTag Wind;

            public RealVector3d WindDirection;
            public float WindMagnitude;
            public StringId WindScaleFunction;

            [TagField(Flags = Padding, Length = 16)]
            public byte[] Unused4 = new byte[16];
        }

        [TagStructure(Size = 0x18)]
        public class WeatherPolyhedron : TagStructure
        {
            public RealPoint3d BoundingSphereCenter;
            public float BoundingSphereRadius;
            public List<PlaneBlock> Planes;

            [TagStructure(Size = 0x10)]
            public class PlaneBlock : TagStructure
            {
                public RealPlane3d Plane;
            }
        }

        [TagStructure(Size = 0x30)]
        public class CameraEffect : TagStructure
        {
            [TagField(Flags = TagFieldFlags.Label)]
            public StringId Name;
            // if empty, uses default
            public CachedTag ClusterCameraFxTag;
            public CameraFxPaletteFlags Flags;
            [TagField(Length = 3, Flags = TagFieldFlags.Padding)]
            public byte[] Padding1;
            // the target exposure (ONLY USED WHEN FORCE EXPOSURE IS CHECKED)
            public float ForcedExposure; // stops
            // how bright you want the screen to be (ONLY USED WHEN FORCE AUTO EXPOSURE IS CHECKED)
            public float ForcedAutoexposureScreenBrightness; // [0.0001-1]
            public float ExposureMin; // stops
            public float ExposureMax; // stops
            public float InherentBloom;
            public float BloomIntensity;

            [Flags]
            public enum CameraFxPaletteFlags : byte
            {
                ForceExposure = 1 << 0,
                ForceAutoexposure = 1 << 1,
                OverrideExposureBounds = 1 << 2,
                OverrideInherentBloom = 1 << 3,
                OverrideBloomIntensity = 1 << 4
            }
        }

        [TagStructure(Size = 0x34)]
        public class DetailObject : TagStructure
        {
            public uint Unknown;
            public uint Unknown2;
            public uint Unknown3;
            public uint Unknown4;
            public uint Unknown5;
            public uint Unknown6;
            public uint Unknown7;
            public List<UnknownBlock> Unknown8;
            public uint Unknown9;
            public uint Unknown10;
            public uint Unknown11;

            [TagStructure(Size = 0x20)]
            public class UnknownBlock : TagStructure
            {
                public List<UnknownBlock2> Unknown;
                public byte[] Unknown2;

                [TagStructure(Size = 0x10)]
                public class UnknownBlock2 : TagStructure
                {
                    public uint Unknown;
                    public uint Unknown2;
                    public uint Unknown3;
                    public uint Unknown4;
                }
            }
        }

        [TagStructure(Size = 0x118, MinVersion = CacheVersion.Halo3Retail, Platform = CachePlatform.MCC)]
        [TagStructure(Size = 0xDC, MaxVersion = CacheVersion.HaloOnline106708, Platform = CachePlatform.Original)]
        [TagStructure(Size = 0xE0, MinVersion = CacheVersion.HaloOnline700123, MaxVersion = CacheVersion.HaloOnline700123, Platform = CachePlatform.Original)]
        [TagStructure(Size = 0x8C, MinVersion = CacheVersion.HaloReach, Platform = CachePlatform.Original)]
        public class Cluster : TagStructure
        {
            public Bounds<float> BoundsX;
            public Bounds<float> BoundsY;
            public Bounds<float> BoundsZ;
            public sbyte Unknown;
            public sbyte ScenarioSkyIndex;
            public sbyte CameraEffectIndex;
            public sbyte WeatherIndex;
            public short BackgroundSoundEnvironmentIndex; // acoustics index
            public short SoundClustersAIndex; // acoustics sound cluster index

            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public short Unknown3;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public short Unknown4;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public short Unknown5;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public short Unknown6;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public short Unknown7;

            [TagField(MinVersion = CacheVersion.HaloOnline700123, MaxVersion = CacheVersion.HaloOnline700123)]
            public short Ms30Unknown0;
            [TagField(MinVersion = CacheVersion.HaloOnline700123, MaxVersion = CacheVersion.HaloOnline700123)]
            public short Ms30Unknown1;

            public short RuntimeDecalStartIndex;
            public short RuntimeDecalEntryCount;
            public ClusterFlags Flags;
            
            [TagField(Length = 2, Flags = TagFieldFlags.Padding, MinVersion = CacheVersion.HaloReach)]
            public byte[] Padding1;

            [TagField(Length = 0xC, Flags = TagFieldFlags.Padding)]
            public byte[] PredictedResourcesPadding = new byte[0xC]; // predicted resources block
            public List<Portal> Portals;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public InstancedGeometryPhysicsData InstancedGeometryPhysics;
            public short MeshIndex;
            public short InstanceImposterClusterMoppIndex;
            public List<Seam> Seams;
            public List<DecoratorGrid> DecoratorGrids;
            public uint Unknown21; // cheap light marker refs block?
            public uint Unknown22;
            public uint Unknown23;
            public List<ObjectPlacement> ObjectPlacements;
            public List<UnknownBlock2> Unknown25;

            [TagStructure(Size = 0x2)]
            public class Portal : TagStructure
            {
                public short PortalIndex;
            }

            [Flags]
            public enum ClusterFlags : short
            {
                None = 0,
                OneWayPortal = 1 << 0,
                DoorPortal = 1 << 1,
                PostProcessedGeometry = 1 << 2,
                IsTheSky = 1 << 3,
                DecoratorsAreLit = 1 << 4
            }

            [TagStructure(Size = 0x60, Platform = CachePlatform.MCC)]
            [TagStructure(Size = 0x3C, Platform = CachePlatform.Original)]
            public class InstancedGeometryPhysicsData : HkpShapeCollection
            {
                public CachedTag StructureBsp;
                public int ClusterIndex;
                [TagField(Align = 4, Platform = CachePlatform.Original)]
                [TagField(Align = 8, Platform = CachePlatform.MCC)]
                public HkpMoppBvTreeShape Shape;
                public List<TagHkpMoppCode> MoppCodes;
            }

            [TagStructure(Size = 0x1)]
            public class Seam : TagStructure
            {
                public sbyte SeamIndex;
            }

            [TagStructure(Size = 0x3C, MinVersion = CacheVersion.Halo3Retail, Platform = CachePlatform.MCC)]
            [TagStructure(Size = 0x30, MaxVersion = CacheVersion.Halo3ODST, Platform = CachePlatform.Original)]
            [TagStructure(Size = 0x34, MinVersion = CacheVersion.HaloOnlineED, MaxVersion = CacheVersion.HaloOnline700123, Platform = CachePlatform.Original)]
            [TagStructure(Size = 0x30, MinVersion = CacheVersion.HaloReach, Platform = CachePlatform.Original)]
            public class DecoratorGrid : TagStructure
            {
                public short Amount;

                [TagField(Gen = CacheGeneration.Third)]
                public Gen3DecoratorInfo Gen3Info;

                [TagField(Gen = CacheGeneration.HaloOnline)]
                public HaloOnlineDecoratorInfo HaloOnlineInfo;

                public int VertexBufferOffset;
                public RealPoint3d Position;
                public float Radius;
                public RealPoint3d GridSize;
                public RealPoint3d BoundingSphereOffset;

                [TagField(Platform = CachePlatform.MCC)]
                public List<short> Unknown1;

                [TagField(Flags = Runtime)]
                public List<TinyPositionVertex> Vertices;

                [TagStructure(Size = 0x2)]
                public class Gen3DecoratorInfo : TagStructure
                {
                    public sbyte PaletteIndex;
                    public byte VertexBufferIndex;
                }

                [TagStructure(Size = 0x6)]
                public class HaloOnlineDecoratorInfo : TagStructure
                {
                    public short PaletteIndex;
                    public short Variant;
                    public short VertexBufferIndex;
                }
            }

            [TagStructure(Size = 0x4)]
            public class ObjectPlacement : TagStructure
            {
                public GameObjectType ObjectType;
                public short PlacementIndex;
            }

            [TagStructure(Size = 0x10)]
            public class UnknownBlock2 : TagStructure
            {
                public RealPoint3d ObjectLocation;
                public short PlacementIndex;
                public short ObjectType;
            }
        }

        [TagStructure(Size = 0x2)]
        public class SkyOwnerClusterBlock : TagStructure
        {
            public short Value;
        }

        [TagStructure(Size = 0x18)]
        public class ConveyorSurface : TagStructure
        {
            public RealVector3d U;
            public RealVector3d V;
        }

        

        [TagStructure(Size = 0x54, MaxVersion = CacheVersion.Halo3Retail)]
        [TagStructure(Size = 0x58, MinVersion = CacheVersion.Halo3ODST, MaxVersion = CacheVersion.HaloOnline700123)]
        [TagStructure(Size = 0x78, MinVersion = CacheVersion.HaloReach)]
        public class BackgroundSoundEnvironmentPaletteBlock : TagStructure
        {
            [TagField(Flags = Label)]
            public StringId Name;
            public CachedTag SoundEnvironment;
            [TagField(MinVersion = CacheVersion.Halo3ODST)]
            public SoundEnvironmentType Type;
            public float ReverbCutoffDistance;
            public float ReverbInterpolationSpeed;
            public CachedTag AmbienceBackgroundSound;
            public CachedTag AmbienceInsideClusterSound;
            [TagField(MinVersion = CacheVersion.HaloReach)]
            public CachedTag EntrySound;
            [TagField(MinVersion = CacheVersion.HaloReach)]
            public CachedTag ExitSound;
            public float AmbienceCutoffDistance;
            public BackgroundSoundScaleFlags AmbienceScaleFlags;
            public float AmbienceInteriorScale;
            public float AmbiencePortalScale;
            public float AmbienceExteriorScale;
            public float AmbienceInterpolationSpeed;
        }

        public enum SoundEnvironmentType : int
        {
            Default,
            InteriorNarrow,
            InteriorSmall,
            InteriorMedium,
            InteriorLarge,
            ExteriorSmall,
            ExteriorMedium,
            ExteriorLarge,
            ExteriorHalfOpen,
            ExteriorOpen
        }

        [Flags]
        public enum BackgroundSoundScaleFlags : int
        {
            None = 0,
            OverrideDefaultScale = 1 << 0,
            UseAdjacentClusterAsPortalScale = 1 << 1,
            UseAdjacentClusterAsExteriorScale = 1 << 2,
            ScaleWithWeatherIntensity = 1 << 3
        }

        [TagStructure(Size = 0x3C)]
        public class Marker : TagStructure
        {
            [TagField(Length = 32)]
            public string Name;
            public RealQuaternion Rotation;
            public RealPoint3d Position;
        }

        [TagStructure(Size = 0x2)]
        public class RuntimeLight : TagStructure
        {
            public short LightIndex;
        }

        [TagStructure(Size = 0x24, MaxVersion = CacheVersion.HaloOnline700123)]
        [TagStructure(Size = 0x28, MinVersion = CacheVersion.HaloReach)]
        public class RuntimeDecal : TagStructure
        {
            public short PaletteIndex;
            public sbyte Yaw;
            public sbyte Pitch;
            public RealQuaternion Rotation;
            public RealPoint3d Position;
            [TagField(MaxVersion = CacheVersion.HaloOnline700123)]
            public float Scale;
            [TagField(MinVersion = CacheVersion.HaloReach)]
            public RealVector2d ScaleReach; // x, y
        }

        [TagStructure(Size = 0x24)]
        public class EnvironmentObjectPaletteBlock : TagStructure
        {
            public CachedTag Definition;
            public CachedTag Model;
            public ObjectTypeValue ObjectType;

            [Flags]
            public enum ObjectTypeValue : int
            {
                None,
                Biped,
                Vehicle,
                Weapon = 4,
                Equipment = 8,
                ArgDevice = 16,
                Terminal = 32,
                Projectile = 64,
                Scenery = 128,
                Machine = 256,
                Control = 512,
                SoundScenery = 1024,
                Crate = 2048,
                Creature = 4096,
                Giant = 8192,
                EffectScenery = 16384
            }
        }

        [TagStructure(Size = 0x6C)]
        public class EnvironmentObject : TagStructure
        {
            [TagField(Length = 32)]
            public string Name;
            
            public RealQuaternion Rotation;
            public RealPoint3d Position;
            public float Scale;
            
            public short PaletteIndex;
            
            public FlagsValue Flags;
            
            [TagField(Flags = Padding, Length = 1)]
            public byte[] Unused = new byte[1];
            
            public int UniqueId;

            public Tag ExportedObjectType;

            [TagField(Length = 32)]
            public string ScenarioObjectName;

            [Flags]
            public enum FlagsValue : byte
            {
                None,
                ScriptsAlwaysRun = 1 << 0
            }
        }

        [TagStructure(Size = 0x4, MinVersion = CacheVersion.HaloReach)]
        public class InstancedGeometryInstanceName : TagStructure
        {
            [TagField(Flags = TagFieldFlags.Label)]
            public StringId Name;
        }

        [TagStructure(Size = 0x1C)]
        public class UnknownSoundClustersBlock : TagStructure
        {
            public short BackgroundSoundEnvironmentIndex;
            public short Unknown;
            public List<PortalDesignatorBlock> PortalDesignators;
            public List<InteriorClusterIndexBlock> InteriorClusterIndices;

            [TagStructure(Size = 0x2)]
            public class PortalDesignatorBlock : TagStructure
            {
                public short PortalDesignator;
            }

            [TagStructure(Size = 0x2)]
            public class InteriorClusterIndexBlock : TagStructure
            {
                public short InteriorClusterIndex;
            }
        }

        [TagStructure(Size = 0x14)]
        public class TransparentPlane : TagStructure
        {
            public short MeshIndex;
            public short PartIndex;
            public RealPlane3d Plane;
        }

        [TagStructure(Size = 0x20)]
        public class BreakableSurfaceKeyTableBlock : TagStructure
        {
            public short InstancedGeometryIndex;
            public sbyte BreakableSurfaceIndex;
            public byte BreakableSurfaceSubIndex;
            public int SeedSurfaceIndex;
            public Bounds<float> X;
            public Bounds<float> Y;
            public Bounds<float> Z;
        }

        [TagStructure(Size = 0x14)]
        public class LeafSystem : TagStructure
        {
            public short Unknown;
            public short Unknown2;
            public CachedTag LeafSystem2;
        }

        [TagStructure(Size = 0x1C)]
        public class BspPreplacedDecalSetReferenceBlock : TagStructure
        {
            [TagField(Flags = TagFieldFlags.Short)]
            public CachedTag DecalDefinitionIndex;
            public sbyte LocationBsp0;
            public byte LocationCluster0;
            public sbyte LocationBsp1;
            public byte LocationCluster1;
            public sbyte LocationBsp2;
            public byte LocationCluster2;
            public sbyte LocationBsp3;
            public byte LocationCluster3;
            public RealPoint3d Center;
            public short FirstDecalRefIndex;
            public short DecalRefCount;
        }

        [TagStructure(Size = 0x1C)]
        public class BspPreplacedDecalReferenceBlock : TagStructure
        {
            public short IndexStart;
            public short IndexCount;
            public short VertexStart;
            public short VertexCount;
            public short DefinitionBlockIndex;
            [TagField(Length = 0x2, Flags = TagFieldFlags.Padding)]
            public byte[] Padding;
            public RealPoint2d SpiritCorner;
            public RealVector2d SpiritSize;
        }

        [TagStructure(Size = 0x10)]
        public class StructureInstanceClusterDefinition : TagStructure
        {
            public StructureInstanceClusterFlags Flags;
            public List<IndexListBlock> InstanceGroupIndices;

            [Flags]
            public enum StructureInstanceClusterFlags : uint
            {
                OptimizedMopp = 1 << 0
            }

            [TagStructure(Size = 0x2)]
            public class IndexListBlock : TagStructure
            {
                public ushort Index;
            }
        }

        [TagStructure(Size = 0x28, MinVersion = CacheVersion.HaloReach, MaxVersion = CacheVersion.HaloReach)]
        [TagStructure(Size = 0x2C, MinVersion = CacheVersion.Halo4)]
        public class StructureInstanceGroupDefinition : TagStructure
        {
            public RealPoint3d Center;
            public float Radius;
            public short ClusterCount;
            public StructureInstanceGroupFlags Flags;
            public float MaximumImposterDistance;
            public float MinimumCentrifugalDistanceFromGroupCenter;
            [TagField(MinVersion = CacheVersion.Halo4)]
            public float MinimumImposterDistanceSquared;
            public List<IndexListBlock> InstanceIndices;

            [Flags]
            public enum StructureInstanceGroupFlags : ushort
            {
                ContainsCardImposters = 1 << 0,
                ContainsPolyImposters = 1 << 1,
                IsDecoratorType = 1 << 2,
                OptimizedMopp = 1 << 3
            }

            [TagStructure(Size = 0x2)]
            public class IndexListBlock : TagStructure
            {
                public ushort Index;
            }
        }
    }
}