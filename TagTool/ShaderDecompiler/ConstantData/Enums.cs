﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.ShaderDecompiler.ConstantData
{
	// Semantic byte values
	public enum Semantic
	{
		POSITION0 = 0x00,
		POSITION1 = 0x01,
		POSITION2 = 0x02,
		POSITION3 = 0x03,
		POSITION4 = 0x04,
		POSITION5 = 0x05,
		POSITION6 = 0x06,
		POSITION7 = 0x07,
		POSITION8 = 0x08,
		POSITION9 = 0x09,
		POSITION10 = 0x0A,
		POSITION11 = 0x0B,
		POSITION12 = 0x0C,
		POSITION13 = 0x0D,
		POSITION14 = 0x0E,
		POSITION15 = 0x0F,

		BLENDWEIGHT0 = 0x10,
		BLENDWEIGHT1 = 0x11,
		BLENDWEIGHT2 = 0x12,
		BLENDWEIGHT3 = 0x13,
		BLENDWEIGHT4 = 0x14,
		BLENDWEIGHT5 = 0x15,
		BLENDWEIGHT6 = 0x16,
		BLENDWEIGHT7 = 0x17,
		BLENDWEIGHT8 = 0x18,
		BLENDWEIGHT9 = 0x19,
		BLENDWEIGHT10 = 0x1A,
		BLENDWEIGHT11 = 0x1B,
		BLENDWEIGHT12 = 0x1C,
		BLENDWEIGHT13 = 0x1D,
		BLENDWEIGHT14 = 0x1E,
		BLENDWEIGHT15 = 0x1F,

		BLENDINDICES0 = 0x20,
		BLENDINDICES1 = 0x21,
		BLENDINDICES2 = 0x22,
		BLENDINDICES3 = 0x23,
		BLENDINDICES4 = 0x24,
		BLENDINDICES5 = 0x25,
		BLENDINDICES6 = 0x26,
		BLENDINDICES7 = 0x27,
		BLENDINDICES8 = 0x28,
		BLENDINDICES9 = 0x29,
		BLENDINDICES10 = 0x2A,
		BLENDINDICES11 = 0x2B,
		BLENDINDICES12 = 0x2C,
		BLENDINDICES13 = 0x2D,
		BLENDINDICES14 = 0x2E,
		BLENDINDICES15 = 0x2F,

		NORMAL0 = 0x30,
		NORMAL1 = 0x31,
		NORMAL2 = 0x32,
		NORMAL3 = 0x33,
		NORMAL4 = 0x34,
		NORMAL5 = 0x35,
		NORMAL6 = 0x36,
		NORMAL7 = 0x37,
		NORMAL8 = 0x38,
		NORMAL9 = 0x39,
		NORMAL10 = 0x3A,
		NORMAL11 = 0x3B,
		NORMAL12 = 0x3C,
		NORMAL13 = 0x3D,
		NORMAL14 = 0x3E,
		NORMAL15 = 0x3F,

		PSIZE0 = 0x40,
		PSIZE1 = 0x41,
		PSIZE2 = 0x42,
		PSIZE3 = 0x43,
		PSIZE4 = 0x44,
		PSIZE5 = 0x45,
		PSIZE6 = 0x46,
		PSIZE7 = 0x47,
		PSIZE8 = 0x48,
		PSIZE9 = 0x49,
		PSIZE10 = 0x4A,
		PSIZE11 = 0x4B,
		PSIZE12 = 0x4C,
		PSIZE13 = 0x4D,
		PSIZE14 = 0x4E,
		PSIZE15 = 0x4F,

		TEXCOORD0 = 0x50,
		TEXCOORD1 = 0x51,
		TEXCOORD2 = 0x52,
		TEXCOORD3 = 0x53,
		TEXCOORD4 = 0x54,
		TEXCOORD5 = 0x55,
		TEXCOORD6 = 0x56,
		TEXCOORD7 = 0x57,
		TEXCOORD8 = 0x58,
		TEXCOORD9 = 0x59,
		TEXCOORD10 = 0x5A,
		TEXCOORD11 = 0x5B,
		TEXCOORD12 = 0x5C,
		TEXCOORD13 = 0x5D,
		TEXCOORD14 = 0x5E,
		TEXCOORD15 = 0x5F,

		TANGENT0 = 0x60,
		TANGENT1 = 0x61,
		TANGENT2 = 0x62,
		TANGENT3 = 0x63,
		TANGENT4 = 0x64,
		TANGENT5 = 0x65,
		TANGENT6 = 0x66,
		TANGENT7 = 0x67,
		TANGENT8 = 0x68,
		TANGENT9 = 0x69,
		TANGENT10 = 0x6A,
		TANGENT11 = 0x6B,
		TANGENT12 = 0x6C,
		TANGENT13 = 0x6D,
		TANGENT14 = 0x6E,
		TANGENT15 = 0x6F,

		BINORMAL0 = 0x70,
		BINORMAL1 = 0x71,
		BINORMAL2 = 0x72,
		BINORMAL3 = 0x73,
		BINORMAL4 = 0x74,
		BINORMAL5 = 0x75,
		BINORMAL6 = 0x76,
		BINORMAL7 = 0x77,
		BINORMAL8 = 0x78,
		BINORMAL9 = 0x79,
		BINORMAL10 = 0x7A,
		BINORMAL11 = 0x7B,
		BINORMAL12 = 0x7C,
		BINORMAL13 = 0x7D,
		BINORMAL14 = 0x7E,
		BINORMAL15 = 0x7F,

		TESSFACTOR0 = 0x80,
		TESSFACTOR1 = 0x81,
		TESSFACTOR2 = 0x82,
		TESSFACTOR3 = 0x83,
		TESSFACTOR4 = 0x84,
		TESSFACTOR5 = 0x85,
		TESSFACTOR6 = 0x86,
		TESSFACTOR7 = 0x87,
		TESSFACTOR8 = 0x88,
		TESSFACTOR9 = 0x89,
		TESSFACTOR10 = 0x8A,
		TESSFACTOR11 = 0x8B,
		TESSFACTOR12 = 0x8C,
		TESSFACTOR13 = 0x8D,
		TESSFACTOR14 = 0x8E,
		TESSFACTOR15 = 0x8F,

		COLOR0 = 0xA0,
		COLOR1 = 0xA1,
		COLOR2 = 0xA2,
		COLOR3 = 0xA3,
		COLOR4 = 0xA4,
		COLOR5 = 0xA5,
		COLOR6 = 0xA6,
		COLOR7 = 0xA7,
		COLOR8 = 0xA8,
		COLOR9 = 0xA9,
		COLOR10 = 0xAA,
		COLOR11 = 0xAB,
		COLOR12 = 0xAC,
		COLOR13 = 0xAD,
		COLOR14 = 0xAE,
		COLOR15 = 0xAF,

		FOG0 = 0xB0,
		FOG1 = 0xB1,
		FOG2 = 0xB2,
		FOG3 = 0xB3,
		FOG4 = 0xB4,
		FOG5 = 0xB5,
		FOG6 = 0xB6,
		FOG7 = 0xB7,
		FOG8 = 0xB8,
		FOG9 = 0xB9,
		FOG10 = 0xBA,
		FOG11 = 0xBB,
		FOG12 = 0xBC,
		FOG13 = 0xBD,
		FOG14 = 0xBE,
		FOG15 = 0xBF,

		DEPTH0 = 0xC0,
		DEPTH1 = 0xC1,
		DEPTH2 = 0xC2,
		DEPTH3 = 0xC3,
		DEPTH4 = 0xC4,
		DEPTH5 = 0xC5,
		DEPTH6 = 0xC6,
		DEPTH7 = 0xC7,
		DEPTH8 = 0xC8,
		DEPTH9 = 0xC9,
		DEPTH10 = 0xCA,
		DEPTH11 = 0xCB,
		DEPTH12 = 0xCC,
		DEPTH13 = 0xCD,
		DEPTH14 = 0xCE,
		DEPTH15 = 0xCF,

		SAMPLE0 = 0xD0,
		SAMPLE1 = 0xD1,
		SAMPLE2 = 0xD2,
		SAMPLE3 = 0xD3,
		SAMPLE4 = 0xD4,
		SAMPLE5 = 0xD5,
		SAMPLE6 = 0xD6,
		SAMPLE7 = 0xD7,
		SAMPLE8 = 0xD8,
		SAMPLE9 = 0xD9,
		SAMPLE10 = 0xDA,
		SAMPLE11 = 0xDB,
		SAMPLE12 = 0xDC,
		SAMPLE13 = 0xDD,
		SAMPLE14 = 0xDE,
		SAMPLE15 = 0xDF,
	}
}
