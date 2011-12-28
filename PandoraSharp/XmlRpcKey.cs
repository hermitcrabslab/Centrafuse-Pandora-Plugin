using System;
using System.Collections.Generic;
using System.Text;

namespace PandoraSharp
{
    internal static class XmlRpcKey
    {
        public static readonly uint N = 16;

        public static readonly UInt32[] P = new UInt32[18]
        {
		    0x77B1CD94, 0xDCB48217, 0x69404CDC, 0x2C02F724,
		    0x22961551, 0xB497993B, 0x5B5EEE8C, 0xA209AE23,
		    0xE26B1B43, 0x90F1CE4C, 0xB86F975A, 0xF3CB8371,
		    0xDED8E87C, 0xB2882D4F, 0x74984776, 0x361650B2,
		    0x666FB475, 0x85A10677,
        };

        public static readonly UInt32[,] S = new UInt32[4, 256]
        {
            {
		        0xBA448614, 0xC35FBBD7, 0x31B6EC14, 0xA85F989B,
		        0x89A83B0E, 0xAB11C2E7, 0xFC376FBB, 0x55B2E7B6,
		        0xA330F22E, 0xA8229AE0, 0x9D025EF0, 0x5E917398,
		        0x3BE382F9, 0x8F103C90, 0x463C36A2, 0xD223C350,
		        0x29DDD3F8, 0x35075D14, 0x0F963F64, 0x74D02046,
		        0x28DCFBF1, 0xEE12889E, 0x46C74707, 0xA1C5A67F,
		        0x8FFE2E9D, 0xACE75324, 0x49DA447C, 0x3061FBB3,
		        0x14579E12, 0xF1E8ED6E, 0x76A679C1, 0xD8EF0FEF,
		        0xA5EA7835, 0xD63EDB8D, 0x484F139D, 0x3D3AD62A,
		        0x8A6331F1, 0xEF43FE4E, 0x3745B29F, 0xEAF8A9AD,
		        0xF9FFF4AE, 0x1E5BB3C5, 0xFF988E0A, 0x8C9E1147,
		        0x3EC6CED1, 0x4CE0F56D, 0x206E4341, 0x79C0520F,
		        0x4FA3C2FD, 0x1A8189E5, 0xFA0BC58E, 0xA0F29358,
		        0x42B379BB, 0xEC55CB3D, 0xBD7F1551, 0x31E17BEA,
		        0xACC91098, 0x7C36A984, 0x8611A88B, 0x255CE7CF,
		        0xC80DB988, 0x743CEEBC, 0x7AA258B6, 0xE82424C9,
		        0xD1EAC3DB, 0x2D562386, 0x5250E40B, 0x9B5285F5,
		        0x895D0124, 0xAB8037D6, 0xFD67BA8F, 0x351B05D7,
		        0x0B124E65, 0x20CF592B, 0x91BE281F, 0x879AD90A,
		        0x6609FEB6, 0xD8A2305F, 0x861194A2, 0xD51DB0E3,
		        0xF735D810, 0xAEFA5174, 0x56A9577F, 0x24F3408B,
		        0x10627B95, 0xBEE74251, 0x7ECD2211, 0x95A8B55E,
		        0xBDE1028E, 0xDEF339E2, 0xD0768D34, 0x6BD5A569,
		        0xC2240D0F, 0xE171393D, 0x14A24028, 0x96760DFA,
		        0x4C78040F, 0xBD6F76D0, 0x5EE4BA83, 0xB20C926F,
		        0xC0F0DCD8, 0xEF5D4105, 0x383D3B65, 0x51E42A4A,
		        0x1505EECE, 0x86B2BFFD, 0x56EE7DFC, 0x8734574B,
		        0xCAA9E52D, 0xE0F66450, 0x76B7037B, 0x84AE5148,
		        0xFB7EC4EB, 0x6A3DEB3D, 0x06C7EA69, 0x165F2DFF,
		        0x7B9DB92A, 0xB9B24C67, 0x43AB448A, 0xA64F30D7,
		        0x998BE34D, 0x628E747A, 0x294162B9, 0xAB8014C7,
		        0x22E1516F, 0x74C3E589, 0x003D14D0, 0x8D724CE1,
		        0x2053C615, 0x9AD67B30, 0x29C3D0E8, 0xBC3269B5,
		        0x7CD7D118, 0x892FD6BE, 0x30170170, 0xF582162A,
		        0x35C8F272, 0x19844866, 0x85259078, 0x7C744927,
		        0x1DA54115, 0x5505DEC7, 0x7A84A6D8, 0xC7D8C609,
		        0x2E198969, 0xF6020F4B, 0x837DCD75, 0x2DF45B36,
		        0x83C0DA9F, 0x4DE5E15C, 0x8F70E4A4, 0x364CF096,
		        0xECBDAE6F, 0x548DC21B, 0xAFD70D50, 0x60378522,
		        0x7A405AB5, 0x60A18616, 0xFA0905BC, 0x953A1CCB,
		        0xBE5141D0, 0xA9403F7B, 0x5D1E37B6, 0x500DA5D5,
		        0xBCDB815C, 0xE78B89E3, 0x63A3546F, 0x5AAD9FD4,
		        0x5C6E8B71, 0xD7971A6F, 0x40856F48, 0x91F6CA81,
		        0x956C447A, 0xF966868F, 0xF191BB51, 0x7C015EAF,
		        0x58A8785B, 0x43710423, 0x2C246B80, 0x0072DCD6,
		        0x40569C99, 0xCB544BB9, 0x2CC2B579, 0xA3AF010D,
		        0x5638B6A5, 0x8918B2D4, 0x18928D95, 0x557BAE61,
		        0xA0D578F2, 0x3CF4B1F1, 0x1D592634, 0xED9B40B5,
		        0x0BE033EB, 0xDD437BAE, 0x6188202D, 0x9F0A444D,
		        0x4DCD2CC0, 0xC28D6DC5, 0x9ABDD269, 0xB0843012,
		        0x00951EE5, 0x4715466D, 0x3CC39115, 0xB270DD7B,
		        0x6510D189, 0x2BBC6F8F, 0x331B8E06, 0x54F13F9E,
		        0xA8223944, 0xC7B1B375, 0xFD79FA77, 0xB7930324,
		        0x6197A094, 0x46CB50D9, 0xC49A908F, 0xAC297BAF,
		        0x84D14B51, 0x0A50682A, 0x8AFB5E73, 0x1C1172C6,
		        0x358A5364, 0x88415003, 0x4D5666F8, 0xA287110C,
		        0xD61B0A4A, 0x3CC0961B, 0x44BF5FC3, 0xD69E0492,
		        0xCFD94EE6, 0x019813D5, 0xB7D38A5F, 0x69C15DC1,
		        0x0D896A60, 0x7ACB18CE, 0x5CE6D6E7, 0x743A4295,
		        0xD7E5A8B7, 0x457E7DD5, 0x4A07442B, 0x2ADA51DE,
		        0xF3202F3B, 0xD4574157, 0x81A94A0A, 0xF26BDDFD,
		        0x775935B3, 0xB9BC3B76, 0x3FD81E05, 0xB95EE989,
		        0x9A0F555D, 0xFD7E49C8, 0x3A1D12C5, 0x7955E2EF,
		        0x7F4A75A1, 0x16DD1739, 0x3B3EF7E0, 0x8795C597,
		    },
            {
		        0x0640766D, 0xCD661DAF, 0x2BDECFBD, 0xDAA77B87,
		        0x5A7E41B5, 0x9A3CD4EA, 0xC6CA8D2F, 0x65F989EB,
		        0x736C3573, 0xFA69679C, 0xB317B71B, 0x41A7E6FE,
		        0x72D83E2A, 0xE22CAB56, 0x08920117, 0x7030D96E,
		        0x35CDE674, 0x7405A058, 0x97D69990, 0xE95C5EF3,
		        0xDC992FB4, 0xD33C9F8B, 0xDAF1AD7A, 0x03503095,
		        0x00967754, 0x8CF12CD7, 0x950FD719, 0x1ADB3F8C,
		        0xDB4F120A, 0x712C33D5, 0x8626D609, 0x1F2CA165,
		        0x3B8FB27F, 0xBBA56B76, 0xD0D7517C, 0xE1B34706,
		        0x2D89956E, 0xFFDFF151, 0xD992E142, 0x9C662E5A,
		        0xD3D210A4, 0xD914DD04, 0x712980F3, 0xF5AE77E4,
		        0x1E186A6D, 0xC3CED643, 0x5A8841B0, 0xD113DB05,
		        0x1C93C9FD, 0xB0B64822, 0xDCDA2B02, 0x09F3B19A,
		        0xF59692CE, 0x01117325, 0xCA61CC6B, 0xF3E6788A,
		        0xAE70FCF0, 0x2BA3BDD7, 0x359B04A2, 0xB422ECFF,
		        0x4CF00372, 0x6374AD34, 0xEB0C631B, 0x56587BA8,
		        0xC32CD2DE, 0x5294BDC9, 0x65B79362, 0x5E38BFAD,
		        0x2A8FBE8C, 0x8E738683, 0xC673FFD0, 0x4B04FB4D,
		        0xCC76EE0F, 0xF45FD305, 0xB77848D3, 0x0D3CB64E,
		        0x48772949, 0xB5E5B2EE, 0x354BFBEA, 0x22BDE81F,
		        0x2181F5BE, 0x40F5F099, 0x99C49F11, 0xEF46CF3B,
		        0x4F9B3DD0, 0x2E34B17E, 0xF35F478E, 0xB0ADC5E2,
		        0x06A4CE4E, 0xF0395C8A, 0x3F344031, 0x0B4A502C,
		        0x85DD868C, 0x0E52D760, 0x84124817, 0x08197C7A,
		        0x5520AD9A, 0xEA8268FC, 0xA11B655B, 0xE3204A0E,
		        0x9183F85F, 0x9A294A29, 0xE6350EC4, 0x09202931,
		        0x28BA52EF, 0x21B2DB1C, 0xA20FF528, 0x42918DAE,
		        0xB8E49971, 0x9E203A81, 0x2A07F36C, 0xA2F84D75,
		        0x824D4513, 0x1D8AC558, 0x7E65E471, 0x06002169,
		        0xBEBC8C82, 0x9B7B8B6B, 0x3FF164C2, 0x5672E9C3,
		        0xBFC72AA3, 0xD3C9D9E3, 0xCB64E2DD, 0xE196A84D,
		        0xCF336932, 0xA5F3CA20, 0xA8D3D903, 0x81CB0B86,
		        0xFB4BF27D, 0xFCA4C125, 0x21F1D5B6, 0xCF6BA988,
		        0x1D408BB7, 0x629F088F, 0xF4746130, 0x1B5C2212,
		        0x47AD1F87, 0x1E1E9B5C, 0xCD01B844, 0x5D3307E1,
		        0xA68FE8F7, 0x3B13346B, 0x602308E7, 0x751416AB,
		        0x38030F2B, 0x1ABC8EF6, 0x8929E128, 0x97040FCA,
		        0x13E59C8D, 0xA121B4D9, 0xDB599765, 0x95EDA62D,
		        0xDAEA1CC5, 0x2CAF5AC9, 0x5490F679, 0xFB410588,
		        0x023C15F3, 0x5FCD4247, 0x99455DD9, 0x82CFC454,
		        0x2EBECB55, 0xE6ED032F, 0x876F578D, 0xA4BF3657,
		        0x8DAD590E, 0xF6ECC607, 0xF8B5CD9C, 0xEC124316,
		        0x4159E6DA, 0xD7EFA744, 0x2A20A160, 0x982F527F,
		        0x60C84A77, 0xFF60A850, 0xFD5C6EAF, 0xFD2D5797,
		        0x954F58C6, 0xA48A9852, 0x55B5A9D2, 0xF3F29933,
		        0xB3580EC7, 0xF7021CB8, 0x25238BDB, 0x7FE667E2,
		        0x47353A71, 0xD9F9D37D, 0x79374988, 0x939566EF,
		        0xC1279574, 0x835BD0DC, 0xCB52DE4F, 0x028364BD,
		        0xBE33E780, 0xB09647D8, 0x73FA4EAB, 0x859922EA,
		        0xC7520CCA, 0x72A331D2, 0x3F5CFE19, 0x008F9772,
		        0x5CBFD2B8, 0xF1937A57, 0xACC6DBA9, 0xEFF7AB89,
		        0x72A55667, 0x628DE4B7, 0xA0CE9591, 0x3BFD1D5F,
		        0xCA8D7811, 0x55BE1BD2, 0x8B4E3C73, 0xE0ADA4A4,
		        0xB0A9AB99, 0xFE319FE4, 0x1C2BE3A3, 0x037B2517,
		        0xC084B5D6, 0x2BE02274, 0xFF05F558, 0x8482CABD,
		        0x8B3D719A, 0x1CB98561, 0x80DA6AEE, 0x443B8093,
		        0x01D8FAA4, 0xD7B783D6, 0x33F0B71E, 0x73CA82D8,
		        0x4D9DFDA4, 0xA91F57FE, 0x17AB093C, 0x689F8D37,
		        0x40EE7199, 0xFA702024, 0xD1DD8C1F, 0x5F9BD69B,
		        0x64D28176, 0xF9DAA31B, 0xBB186496, 0x078787B1,
		        0x3783C428, 0xBDA68050, 0x7E709830, 0x1BBDB10E,
		        0x6349027F, 0xF8306215, 0xD8855420, 0x0BE3D1A8,
		        0xD3D9C187, 0x5329049F, 0xE3395F69, 0x65AC7995,
		        0x664848D1, 0x68C64650, 0x0F9C1F75, 0xA4808E20,
		    },
            {
		        0x5CFD009F, 0x4C09F290, 0xA786F99C, 0x76A5A243,
		        0x2DC97400, 0x424D9AAE, 0x6644DE0C, 0x30DAFAE5,
		        0x5ED77CC3, 0xD1003D99, 0xCD3C1222, 0x1CA766C1,
		        0x5B976615, 0x014E4796, 0x0A715936, 0x405D0D57,
		        0x0AB115F1, 0x8A963877, 0xBE96D670, 0xE2310AAC,
		        0x148D00F2, 0x9787F4BF, 0xE5F62A68, 0xFD025DA4,
		        0x194B6DF7, 0x960D3E7B, 0xB330C5C1, 0x2932C25B,
		        0x13738072, 0x9D62ABA1, 0x0ECD92CA, 0xF75ACC9B,
		        0x229E433A, 0xD0A247BF, 0xE4B0D9BA, 0xFA69F70E,
		        0x9B7D254F, 0xD2849281, 0x4132F364, 0xF2E4B87F,
		        0x4189B43C, 0x7E807CBC, 0x10498724, 0xF48C5F29,
		        0x03312ACE, 0x239307BD, 0x3541CEBC, 0x1B1AE36D,
		        0xF993F1B1, 0x3B6BE060, 0x9782191A, 0xACC1CC1B,
		        0xA8B4798E, 0x486399CD, 0x59A7ECB9, 0x46490B98,
		        0xB80EA77E, 0x1071EE10, 0x8FE10517, 0xE29D8F08,
		        0x9BDA44C2, 0x629C5056, 0xE40E10E3, 0x0048CBB1,
		        0xF8E698E7, 0x09369CB7, 0x898942DC, 0x0F49BFE0,
		        0x3600B868, 0x44EE4C88, 0x6625BBFB, 0x7C956C83,
		        0x5C42B182, 0x080AF33B, 0x1503CC24, 0xAE64DA10,
		        0x9F3537D3, 0x99618740, 0xE7D50FFD, 0x6CBB4AFF,
		        0x56062EE1, 0x70C1AD52, 0xAC54BF35, 0x5A7D4D07,
		        0x65DC58DE, 0x7B362255, 0x6133AFC8, 0x4C2ACE68,
		        0x858FA998, 0x5C336C93, 0x78193EA7, 0x5613E9BD,
		        0x8B1F58AC, 0x563D5D47, 0x6163AF27, 0x71183690,
		        0x5944DDC3, 0x817D18BE, 0x41260F8B, 0x259ED297,
		        0xA3CCEE2E, 0xDBB13DDD, 0x1009CD47, 0xD12B82C3,
		        0x9A6FF89D, 0x4248C9D4, 0x31484739, 0x7C3DEEC3,
		        0x2E2CBAC1, 0x9597DDA3, 0xF64414B0, 0x066FC96F,
		        0x31F4AAA0, 0xB2DBBCFF, 0x50B991AD, 0x95AC5272,
		        0x0CAA50C4, 0x0864DE61, 0xF38A70D4, 0x08CE8D6C,
		        0x53941C89, 0xC54DBEBE, 0xE4DBC2B0, 0x2B3E9E66,
		        0x6F3E0BA4, 0x164DC014, 0xCC6CEC5F, 0x08238664,
		        0x30988E18, 0xFDE4501A, 0x030B3099, 0xE6F49802,
		        0x94A08714, 0xC3A784E5, 0xECDA930D, 0x0B40E2F9,
		        0x0EE564F8, 0xF5993B88, 0x5B8DB5DB, 0xF77CCA85,
		        0x9C4FCDA9, 0x2114F372, 0x2AA12CCE, 0x2B07C3F1,
		        0xD660E47A, 0xD0B26A65, 0x56F8945C, 0x4C07FCA5,
		        0x5EF2197F, 0x073CBFFC, 0xF83E8935, 0x04DB4798,
		        0x79DE4FB4, 0x207E0BB1, 0xD0D47C14, 0x9DADB205,
		        0x5EBD3EA0, 0xCA83B290, 0xC8BF53A1, 0x4DCBF491,
		        0xB590CD79, 0x9C98C12E, 0x8C877D6E, 0xD0F17FD2,
		        0xB3FFF22F, 0xE8D38B07, 0x15641B63, 0x6FE5D245,
		        0x04045C48, 0xEF16069B, 0xB58781CE, 0x7D07653D,
		        0xCFB9BD0C, 0x21CA5DE7, 0xB35606D9, 0xA7854DE0,
		        0xC134207C, 0xFE978430, 0x0C830455, 0xCB784991,
		        0xC95A3072, 0xC0AC5E17, 0x7B999149, 0xA289D877,
		        0xB4E3254E, 0x743F72B1, 0x98CF8054, 0x7E4E1C3F,
		        0x0A64C32C, 0xF04CEB0F, 0x0488ABF6, 0x004554B3,
		        0x359E3441, 0x192ABA6F, 0x28DC322E, 0xDDE52491,
		        0xF1D8C2A7, 0xEAE3E74A, 0xA10B3376, 0x7A879F55,
		        0xB5F13C45, 0x5194862C, 0x6F65DC08, 0x753F6AFE,
		        0xF08EA616, 0x26D382C3, 0x3315E1E5, 0x538106B9,
		        0xEC0B9F78, 0xF298C82D, 0x0125FD86, 0x07465A0D,
		        0x23953151, 0x70569F93, 0x75D261A5, 0xC5AD33E5,
		        0x49464CDF, 0xB4E0D04D, 0xA0866011, 0x383CC817,
		        0x545FBC56, 0xA49BED33, 0x4E4B516A, 0x38CBF5D4,
		        0x6DBA987C, 0x1DFE208F, 0x65466F04, 0x6D3DCD1D,
		        0xEB4D60C6, 0xE3FB6AEC, 0xFA16DBDB, 0xCD1CDF2B,
		        0xF07F845D, 0x4DA0ECD1, 0x0EEB40B0, 0x1CB7A2F0,
		        0xCD8E54F3, 0x37376D53, 0xF7AAC8D3, 0x8BA724AA,
		        0xEF5C922D, 0x6F1BE181, 0xD1808DF8, 0x44764B58,
		        0x0CD247C4, 0x0C137F60, 0xB77F6981, 0x4AC13745,
		        0xBA311B48, 0x42A5DE75, 0x4522E7E0, 0x84E90F54,
		        0xCC0AD21C, 0x00F8D9A7, 0x9CA2CED9, 0x4F8E0583,
		    },
            {
		        0x6AFF5CA7, 0x0D8AB1F0, 0x75E3AD44, 0x6B5A1A52,
		        0xE9658216, 0x71B42FBB, 0xF57D3F6C, 0x0A79678E,
		        0x534F306F, 0xB9C725AB, 0x7157BF11, 0x2A52F490,
		        0x4D01079C, 0x6D18FC2B, 0x94EC0BDB, 0xA736324E,
		        0x7540D554, 0x6B9DFB4D, 0xFA158CA1, 0xECE8E1AB,
		        0xAFAF64B2, 0x61450E7B, 0x4CEBA4FA, 0xB2AFAAA2,
		        0xFE669447, 0x4E63D10B, 0xFBD8AEC8, 0x5F6B6B1A,
		        0x70A8F15B, 0xA91D68B6, 0x59034211, 0x98273D40,
		        0xB9A9C9AD, 0xCE4DDCD7, 0xC3159554, 0xFD5D1C2D,
		        0x9ABF93B5, 0x70A8C01F, 0xA70FCF1A, 0x641301DD,
		        0x4EDB9E0B, 0xC548E7B1, 0x4884B172, 0x714610B7,
		        0x4086DCCF, 0xC8D88CC6, 0x77594608, 0xBCABFDE1,
		        0x77962F00, 0x56F6372C, 0xB9507A98, 0x0EF9473E,
		        0xDBA8C6E2, 0x5BE1AA28, 0xCEA5C805, 0x750F1D15,
		        0x1F986C17, 0x3693A790, 0x71B0C4CC, 0xC0776116,
		        0xD660B7BC, 0x8D0ABAB1, 0x7F1FDFB7, 0x4900FDE1,
		        0x2208372B, 0xB8263157, 0xB53378F5, 0x10DF5849,
		        0xC3C8CD69, 0x5E842514, 0x8085986A, 0xC305CE78,
		        0x6C5D3C16, 0xC11A49B6, 0x391DBE69, 0x3BACD18D,
		        0x87253FDE, 0x56D409DE, 0x68629118, 0x1C1E9C6F,
		        0x7F737B29, 0x96838CC1, 0xC300D7B2, 0x2A23D185,
		        0x52271100, 0xCB4B3F01, 0xB78A9B86, 0xB9BEDEF5,
		        0x5D8075FF, 0x5C325E39, 0x48A76A2B, 0x96A61231,
		        0x933ADA05, 0xF9971C9C, 0xFF2C75FC, 0x27FA5DAA,
		        0xAEF8AD6E, 0xF2DEA20B, 0x11F247FB, 0xC383DA2A,
		        0xF85A5ED1, 0xC35FBC79, 0xBDCEF0AD, 0xEEBBCFB3,
		        0xCA711BF4, 0xB7DABFB3, 0xE03177D0, 0xBB727F1F,
		        0x142CC33D, 0xDB6C384E, 0xAC6D38B4, 0xF55B4325,
		        0xF020F44F, 0x5630D9C1, 0xED39B172, 0xACB5AFF7,
		        0x8D98DC58, 0xB6DF90A1, 0xEC98CD13, 0xE0C6A237,
		        0xAC64BDF0, 0x3560D439, 0x7B0DDB44, 0x1D3682C3,
		        0x664EBF1A, 0xD41A4A0C, 0x0D5DFE5B, 0x4E133D8C,
		        0xB129ECD6, 0xD9DA3194, 0xE45DADBA, 0x6B27E47F,
		        0xBA9600DD, 0x8E1936D2, 0x1F8B1E51, 0x3860AE03,
		        0xEE540893, 0x5F31C76B, 0xE9302FA1, 0x452CB6B9,
		        0x5D9CA533, 0xA19F4B2F, 0x6C0046A4, 0x657713DD,
		        0x1B5D5A04, 0xC3D594E6, 0xBB80FA30, 0x9BF9E647,
		        0x716F2F97, 0xF2B8ADA6, 0x7F242755, 0x40FB6614,
		        0x4F85BCF9, 0x18799EB2, 0x76B4124A, 0xFCAEC005,
		        0x38231D8A, 0xD449CE69, 0xC6877AD2, 0x16B37A06,
		        0x7DAF096B, 0xCE11C2B4, 0x750754B5, 0xCAC33C86,
		        0x10E20D73, 0xE4997D0F, 0x6B06DE8D, 0x1D70D15F,
		        0xBF060E4F, 0x18BC4C59, 0xD1C8585E, 0x1AEC12B4,
		        0x9AB3F241, 0x46CFC4CD, 0xCF16D587, 0xF1722424,
		        0x0ECA4D9C, 0xCC6131F3, 0x0E990CC3, 0x9771D4BF,
		        0x4C624E9F, 0x5CA79CBC, 0x02368C90, 0x25826D54,
		        0x32D1B4C9, 0xDA9A049B, 0x616CC784, 0x47B562F3,
		        0xB5553B6E, 0xF205F397, 0x6FA01B63, 0xC857201F,
		        0xC5C7C8A1, 0xA27C47E2, 0xDB185877, 0x67236F63,
		        0xBF369D88, 0x4E7054BD, 0xD6544BEA, 0x36EF3BC3,
		        0x60F4B74D, 0x430EA61E, 0xC3E9C76D, 0x499A0517,
		        0x91D45BCD, 0xDCAEADFA, 0x355FBC9D, 0x8CA1770E,
		        0x820BE4F9, 0x00AE9FD2, 0x9E63CE49, 0x46FE33E8,
		        0xA07048A3, 0x225FBD27, 0xAF0FD02C, 0x8F9D7C95,
		        0xD4F0E647, 0x6DFB3949, 0xE289B0B0, 0xF9CC7F56,
		        0x7F168AD2, 0xED8433E0, 0xEBB189B5, 0x765AD69C,
		        0x7730DCF0, 0xD54C3A0D, 0xACF6BD6B, 0x1E19DF12,
		        0xBD984D49, 0xC4FC38B8, 0x0D36C9FF, 0xCC3AD912,
		        0x0A6E4ED6, 0x27B27847, 0x604F6917, 0xD4C1ADAD,
		        0xCB19F4BE, 0x5127D2FD, 0x38FFA03A, 0xB983BC5F,
		        0x5CAF3A6E, 0x84E94F45, 0xFC3FA473, 0xC9299B07,
		        0x322F38AF, 0x2A228E93, 0x76D63922, 0x1326A518,
		        0xFEC3F151, 0xB821D755, 0x8D1C67AC, 0x5DA96628,
		        0x04F7335F, 0xC6F5CD2E, 0x7D211328, 0xE19180D3,
		    }
        };
    }
}