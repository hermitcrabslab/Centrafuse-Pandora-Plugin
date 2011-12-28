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
		    0xD8A1A847, 0xBCDA04F4, 0x54684D7B, 0xCDFD2D53, 0xADAD96BA, 0x83F7C7D2,
		    0x97A48912, 0xA9D594AD, 0x6B4F3733, 0x0657C13E, 0xFCAE0687, 0x700858E4,
		    0x34601911, 0x2A9DC589, 0xE3D08D11, 0x29B2D6AB, 0xC9657084, 0xFB5B9AF0
        };

        public static readonly UInt32[,] S = new UInt32[4, 256]
        {
            {
		        0x4EE44D9D, 0xCCEEAB0F, 0xD86488F6, 0x25FDD9B7, 0xB0DE3A97, 0x66EADF2F,
		        0xC0D3DCA4, 0xEE72A5FA, 0x54074DEC, 0xCBAD83AD, 0x4B1771A3, 0xD92AE545,
		        0xB5FCE937, 0x26AD96D9, 0x5D615D68, 0xF2994B82, 0xE668D342, 0x61051D4C,
		        0xCFB29CA4, 0x8B421D38, 0xDA3B4EB9, 0xD92D6A55, 0xF7D940C7, 0x99C4BC83,
		        0xAB896E79, 0x77C7039B, 0x1215B24A, 0x0C0EBC0D, 0xE9F082B2, 0x6B7DFE9C,
		        0x4A714E76, 0x91280D88, 0xA422A361, 0x3E674D4A, 0x6EBC2D42, 0x6838580B,
		        0xBAE461AB, 0xE8FEDD17, 0xEFD6E5E0, 0x690D3E93, 0x32FADEB0, 0x1B99EE04,
		        0xBE9FA7D9, 0x7997DFC6, 0xFD1B8025, 0x667B35D8, 0x2D909996, 0xFE487FF0,
		        0x628BCFE1, 0xA534C620, 0x6644DEFE, 0x8BF9236D, 0xE943DD51, 0xF4615657,
		        0x605D4F80, 0x2E02FC45, 0xD924D2D0, 0xFD4AB9E3, 0x5AEB18F0, 0x7A8D7C92,
		        0x6CA40CA6, 0xD8AD4139, 0xCA5E7EC2, 0x69BE3C59, 0x554A4DD6, 0xBA474DD1,
		        0xE113576B, 0xCB89A6BD, 0xF366EC0C, 0x876661AB, 0xD85E5381, 0x79A93327,
		        0x5A4E5D92, 0xE3301F23, 0xF211DD61, 0x6F0140D0, 0xDBA134BF, 0x3C623008,
		        0xD5FCE976, 0x6EDE648E, 0x814CF920, 0xB38878E1, 0x6232D49C, 0x2310373B,
		        0xA8C6EBFC, 0xCD506842, 0x62BEF441, 0x1324C803, 0x69D1F137, 0x3907EE67,
		        0x47967932, 0xC3C3F280, 0xC4B036B9, 0x5EC264B4, 0x9484AA3C, 0x5FEF9C53,
		        0xC1B9030F, 0xE86C6BBA, 0x3AE49DAE, 0xBBAC421C, 0x54D06D99, 0xBA13A2B2,
		        0x3132FA87, 0x2FDDB5E2, 0x4B751219, 0x5B59778F, 0xEFFA2E62, 0x3BD56164,
		        0xE7EDFC1D, 0xCF4D5FDB, 0xC6310BDA, 0x0CAE8B8F, 0x53196C2F, 0xAC951D1F,
		        0x32FD1D71, 0x7D9D5956, 0x2EA62C92, 0x9FA4A4C8, 0xE491DC41, 0x7E5F2507,
		        0x4568300F, 0xF210AAA8, 0xB6980949, 0x017405E7, 0x5EBF3350, 0x44B863F6,
		        0xDF96854A, 0xFA8A8390, 0x342BDFFA, 0x93096350, 0xCD0F0083, 0xBE295FDD,
		        0x549AA9C9, 0x8554D31B, 0x2F2FE138, 0x30E8C78D, 0xED603733, 0x4B47F4C2,
		        0x03D481DC, 0x8BE4479C, 0x9A307E98, 0x73CFC5DC, 0x71DE3DFB, 0x55DA2605,
		        0x2CC97898, 0x13F0CC6F, 0x5F30FEE1, 0xF65D36D0, 0x99D05438, 0xB6A1DF23,
		        0x2EA6EF9B, 0x12D3A110, 0xF1C89B1A, 0x522BAA1F, 0xE39AC7B3, 0xAFC153D1,
		        0x2A565274, 0x51530B46, 0x1291387D, 0x15BC2B63, 0xA73AD01F, 0x13EBC4A7,
		        0x849583D7, 0x4A9E1AE6, 0x430C9A05, 0xEB2A78FB, 0xFA3A817D, 0x6D1D7AE5,
		        0xB99588F5, 0x6D2C571B, 0xF975441C, 0x1348927D, 0xB069BDE2, 0x0771A398,
		        0x4B93EDCC, 0x3C167223, 0xC3BBCFDF, 0x40C406DA, 0x81C867B1, 0xEB20C3D2,
		        0x2476ED54, 0xB581F042, 0x1160A8B8, 0xBCA1AD0F, 0xD8F18C9F, 0x708BC7C6,
		        0x0579D83C, 0x29BAA2B8, 0x45B845EE, 0xA57F5579, 0xE52E4A8A, 0x48365478,
		        0xC6CCBFB4, 0x2F53D280, 0x8E1FF972, 0xF4E02067, 0x3F878869, 0x5879FF3C,
		        0x1EDFAB0F, 0xD4FE52E3, 0x630AC960, 0xABD69092, 0xFAA3BF43, 0xF1CA3317,
		        0x9CFF48D2, 0x8FE33F83, 0x260C1DE3, 0x89DB0B0B, 0xF127E1E3, 0x7DA503FF,
		        0x01C9A821, 0x30573A67, 0x8A567A2E, 0xE47B86CF, 0xB8709ADE, 0xB19ADD3A,
		        0x46A37074, 0x134CE184, 0x1F73191B, 0xE22B39F6, 0xE9D35D3D, 0x996390AF,
		        0xADBBCCDB, 0xC9312071, 0xD442107D, 0x0B50C70A, 0xB9B6CC8C, 0x60A51E0E,
		        0xA1076443, 0x215F1292, 0x5A53C644, 0xEA96EA2E, 0xE9F3B4BC, 0xBA5F45D2,
		        0x454B65D6, 0x2CF04D9C, 0x05EF1D0F, 0xCD1ABBEE, 0xE86697B0, 0xFB92F164,
		        0xEBEDADBF, 0x69282B8D, 0x65C91F0D, 0x6215AB51, 0x87E7BDF6, 0xC663D502,
		        0x6EF4864E, 0xDC3BDCC9, 0x97184DBB, 0xCD315EED, 0x64001E09, 0x6F7DE8CE,
		        0x38435D03, 0x840B5C82, 0x23CDBC8A, 0x7FA0D4FB
		        }, {
		        0xEBCBE20D, 0x09FADAEC, 0x98FF9F63, 0x16D0DFE1, 0x54B65FA8, 0x8C58D07C,
		        0xEAACBEA0, 0xEA8BC5B7, 0xD343B8ED, 0x46D416FC, 0x0247DCBB, 0x527CA3F5,
		        0x22DAF183, 0x6684CF7F, 0xA2D5D9F6, 0xC507E43B, 0x7B368AE6, 0xFC8179EC,
		        0x47E959C4, 0xDADF15F2, 0x92E48145, 0xD9CFA8B3, 0x94F209E8, 0x10F93D6D,
		        0x3BAAF7B5, 0x9E5009B4, 0xE7E66FD8, 0x10F6D58F, 0x1EAFFF4D, 0x0423FCE5,
		        0xE860C60A, 0x7713B2B4, 0x7C5EEF7E, 0x430801CF, 0x46613A77, 0xFADEC916,
		        0x58AB09B3, 0xEE05C51F, 0xD4C6331F, 0x9BCA1941, 0x15BF041F, 0xC3B04E8D,
		        0x6CD037AF, 0x11C81E53, 0xB38393DF, 0xB1D07B52, 0x067D02F7, 0xA9E5798B,
		        0x4E5C10A6, 0x790DD862, 0xDEA21AD1, 0x3C0C90BF, 0xB05D8240, 0xFEA81F59,
		        0x832F19FF, 0x17190D1C, 0x03E07FDC, 0x43A6AEAC, 0xFE0C8A2E, 0x216813A6,
		        0xF0428728, 0xC1D21DCF, 0x54109ACB, 0x68FB51BB, 0x3F5AEE69, 0x557FEA14,
		        0x07965E16, 0x58E2A204, 0x6E765B0C, 0x3B8D920F, 0xDD712180, 0xDD0F67CA,
		        0x37F9D475, 0x91815CCF, 0xC31A34BB, 0x8F710EF2, 0xF2DA2F82, 0x2A24931B,
		        0x41CFF29F, 0x16C9BECF, 0x1AEB93FB, 0x090DF533, 0xC10D27B6, 0xF7EE2303,
		        0xF82A0ED0, 0x57031132, 0x88AFF451, 0x574A8BFF, 0xF1ACA4F0, 0xDD556F49,
		        0x90D7CF52, 0x4BCA4AA3, 0xC917557C, 0x4BB6B151, 0x52CD8251, 0x7C7ED836,
		        0x3488ED59, 0xC50C6A0B, 0x675413ED, 0x6368583D, 0x98B61BAE, 0x1AF59261,
		        0x46590022, 0xA4C70187, 0x4658F3EB, 0x80A61049, 0x8F120E7A, 0xBEAC09D8,
		        0x195ACD49, 0x6BE1DE45, 0x6EF1E32D, 0xB8A4B816, 0xC18758B8, 0xCA7AD046,
		        0xD475BFE1, 0xCC3AB8AF, 0x45AB9AD7, 0xC37C62AC, 0x9AAD7E2E, 0xB9D87862,
		        0x28F3CD26, 0xA0577A0E, 0x75859ECE, 0x4A6E5B86, 0xE61E36B3, 0xA00E0CA4,
		        0x3E2CC99C, 0x581DF442, 0xCE40B79B, 0x17BAB635, 0x73F1C282, 0x7C009CE0,
		        0x1A8BBC5A, 0xBBB87ECD, 0x162ED0AC, 0x8DB76F5A, 0xD5AD1234, 0xD0D7A773,
		        0x41CBDEFB, 0x7197AFF4, 0x5C60E777, 0x5D9141D4, 0xF43D5211, 0xA4F064D9,
		        0x40C13CB3, 0xE9DE900D, 0xBF733203, 0xC00F2E89, 0x095D476F, 0x277A825D,
		        0x4B6A61D3, 0xFF857740, 0xE34705C0, 0x65F8372C, 0x497AC161, 0x1231CA4A,
		        0xFB385036, 0x24B36150, 0x6CB9FA2D, 0xCBAB3399, 0x3832629E, 0x1BB815EE,
		        0x6AAA74C7, 0x8FFA22B8, 0x64093F28, 0x973BBA95, 0x831A8195, 0x48B2923D,
		        0x9680C36E, 0x16BA5344, 0x1F190542, 0xBCB0DFCC, 0xCCC24623, 0xFA503EAD,
		        0x7189956C, 0x80B3C715, 0xFA9F4685, 0x36CF833E, 0x19A53ADF, 0xA5A4BD79,
		        0x187ADC8D, 0x8AEFA6B6, 0xF64FF62A, 0x88A590BA, 0xE30C75BE, 0xA3BFBCC7,
		        0xAC669722, 0xC4AEAFF2, 0x822DC5FA, 0xAA73C1D5, 0x422EFD93, 0x946FE915,
		        0xEF623E46, 0x24395A31, 0xF28FF488, 0xB4D7CA7E, 0x27703504, 0x9F390B73,
		        0xA6999558, 0x8AE04A20, 0xDD6FE7DB, 0x55963137, 0xCFEF70BB, 0x708CA677,
		        0x804CF78B, 0xD5AC1CA2, 0x88D7CCFC, 0x5FE056DF, 0x25B390EA, 0x11550845,
		        0x15A58C0B, 0x7C3530A3, 0x24550544, 0xD395EDD0, 0xEB046782, 0x7E3CCE71,
		        0x25A8640C, 0x96A955DE, 0x4BF7614E, 0x3014FD08, 0xE2AC1E2E, 0x7D3AB3C3,
		        0xB63CB59C, 0x9E92D401, 0x859B2C44, 0x1F893940, 0xEE81B9BB, 0x7F430589,
		        0xAF2CC2EC, 0x0FA273E2, 0x3E5C6FAA, 0xE580E6A9, 0x64D73FE6, 0xE7C5A28A,
		        0x99B760BC, 0xC0FCBA71, 0xDB521C76, 0xDBC7C1F8, 0x4968CF63, 0xD4928D17,
		        0x6DBBCC5F, 0x681EB668, 0xC326CEB9, 0x7C6B0EBB, 0xF071C193, 0x5CC6A08C,
		        0xFA4B95EB, 0x0BED345D, 0x16854F61, 0x22ECDDA9, 0x77335F2D, 0xCC016EE5,
		        0x4CE1D7F6, 0x32B1409B, 0x2197B046, 0x73CD94F3
		        }, {
		        0x56D997EE, 0x92FA3097, 0xA1AF0D9D, 0x11FCBB9C, 0xA2673993, 0x3860F1CE,
		        0xB2B70A39, 0x5BC90183, 0xBFA62ADC, 0x58E257F2, 0xD221A704, 0x0A876CE4,
		        0xD7B0FCA9, 0x80D3D874, 0x696A6CFD, 0xB989EFF1, 0xEAA5F132, 0xA29ECB5D,
		        0x674B7380, 0x0BAD725F, 0x59D55508, 0x8DB40E2A, 0x003EBD12, 0x871AD00E,
		        0x7ACE20A9, 0xE670BA85, 0x43D53997, 0x79461049, 0x806C102B, 0xB21337BD,
		        0x791483E8, 0x6ECA44EA, 0x959CF50D, 0x8D87166D, 0xFA939DF8, 0xB0E519DE,
		        0x8C069B44, 0x0A47F71A, 0x8D7AD1CA, 0x24E6FEDD, 0xCEF2173E, 0xB46A57F1,
		        0x9DD9C775, 0x549B2E5D, 0x67A37485, 0x38F7FC18, 0xA269F5A1, 0x1B04F14E,
		        0x4550E006, 0x8F5E0E14, 0x5EB9992C, 0x88D780A5, 0x334FFA1E, 0x473A75C1,
		        0x9D96E913, 0x7DB16188, 0xE699B708, 0x88D087FA, 0x06E44D4E, 0xCB29E519,
		        0x68529AB8, 0xBC74B1FD, 0xDA074140, 0x557B9936, 0x80BB557E, 0x42522D24,
		        0x909E967F, 0x7D578A28, 0x7F78EBD7, 0xB793DC4B, 0x08498F07, 0x8A77FC08,
		        0xFFFDA0C1, 0x2ECA4123, 0xB63861DC, 0xD909606E, 0x29A545E4, 0xB37539D6,
		        0x292FAC93, 0xBDC6C4F3, 0xDAC7CE05, 0x68201C9D, 0xE08DC67A, 0xE0FB0327,
		        0x17554D62, 0x636D9040, 0x0612D29F, 0xAF250475, 0xB8961740, 0xBE3E4408,
		        0x3AF166E6, 0x3B16CC87, 0x2DC77141, 0x3C874024, 0x0E409623, 0xC7576B7A,
		        0x35CAF7DA, 0x0AA9AED6, 0x6C5F2CC0, 0x23AAB90F, 0x74A41C51, 0xDAA1B557,
		        0x412EC422, 0xD9E55CF0, 0x7F6A804E, 0x9256A133, 0xF3FD2639, 0x42C9A68A,
		        0xB20588E4, 0x33339C04, 0xCB9B9300, 0xCCA198E9, 0x849A2FFF, 0xF2B71118,
		        0xD27C41DF, 0xF1453CD9, 0xEB94D640, 0x9CE6A69E, 0x1561C1BD, 0x8A8F7E07,
		        0x1FA3989C, 0x601C3440, 0x95DE5ED8, 0xB2F2AE94, 0x831BA7C3, 0x6831E3ED,
		        0x5C5C0BD8, 0x628A0E89, 0x2726D7A3, 0x82B6E434, 0xB729A5C7, 0x5AB563C2,
		        0xA4119CE6, 0x4459E404, 0x0B3E858A, 0x080C2DF9, 0x6EBE3FFB, 0xC1D64BCE,
		        0xB2C90336, 0x998AE507, 0xC152879A, 0x31B99F23, 0x37769978, 0xF5C78668,
		        0x2B954114, 0x54169F1A, 0xBF9E6E7D, 0x41BEBC39, 0x35BC63BD, 0x77E91F12,
		        0x89909690, 0xCB17B79D, 0xCCBF4A25, 0x3E5E653E, 0x3B4531F1, 0x31AF6109,
		        0x027DC03F, 0x334AE2A7, 0x8A685A70, 0xD82C335D, 0x7D73C193, 0xF0311C79,
		        0xE8091EAF, 0x64B12983, 0x85CEB9A6, 0x402AB7C9, 0xA95E4546, 0x85CE4FD7,
		        0x21968004, 0x0846E117, 0xD290B888, 0xCE2888FC, 0xE2F318F1, 0x89B189DD,
		        0x7A2D73BA, 0xE28937E5, 0x6D857435, 0x8A2F05FA, 0xA19B966F, 0x37EF297F,
		        0xC50696F5, 0xA7C3DE1A, 0x988D3850, 0x24007793, 0xB94C792C, 0x4DA98736,
		        0xA04EB570, 0x4AA44F84, 0x7124E7C6, 0x13B9026E, 0x27AC2D15, 0xFBB9AD93,
		        0x2F94AA1C, 0x98587A3D, 0x9C9DB996, 0x7E3487D5, 0xA819272C, 0x32AA5E43,
		        0xE0DB72F5, 0x4DB4853C, 0x7350C7EC, 0xB1626C73, 0x07130A5F, 0xC3DAA529,
		        0xD6422735, 0x8559200D, 0x1046E85C, 0x326CFB54, 0xAD42DB6A, 0xAE4CC364,
		        0xA49F5718, 0xF472F8A0, 0x3C002484, 0x013067BE, 0xC88A1317, 0x4C3C209B,
		        0x7CBB8BB3, 0x41FB8DAF, 0x236591B3, 0xDC974A45, 0x8639E738, 0x97C38B19,
		        0xD7FF5725, 0xE7094458, 0xF28B223F, 0xF73C878B, 0x7F7502D9, 0x52F7FD09,
		        0x4A661B36, 0x62814D8E, 0xBBDD1D16, 0x002598D9, 0x56B17A84, 0x87A331B7,
		        0x6C2898C2, 0xAFCBA795, 0x4EFEE9AE, 0xEAE3A4F1, 0xC3D4D9CD, 0x5EFD7C32,
		        0xB1B31E64, 0x95245686, 0x21A7DA12, 0x7155E041, 0x7362B475, 0x36486BD5,
		        0xA97E5D7C, 0x8871303B, 0x93199D52, 0x246F919E, 0x5A581359, 0x6AE746DD,
		        0x3CA9098C, 0x56DA5714, 0xAA0B674A, 0x08C89A5D
		        }, {
		        0x7DD47329, 0xF270A704, 0x71BF31DA, 0x3B57772E, 0xFBE90F4B, 0x87FC23F6,
		        0xCF413D71, 0x4FFEA8EC, 0xEFBA20C2, 0xEB53E0C1, 0xFFE7633E, 0x854E28E8,
		        0xFBFFE904, 0x8A7841BE, 0x94E99960, 0xA3E69064, 0x365C57AB, 0xBEE976CC,
		        0x596B94C2, 0x8C5E90E2, 0x074B3C54, 0x89B5E926, 0xDF192C71, 0xAF631D85,
		        0x67A8EDEC, 0x24BE4919, 0x81EB9C8A, 0xFDB13471, 0xEE61A4A1, 0x1EE368DE,
		        0x8C55C255, 0xD273A000, 0x12A24DCD, 0x22A6708E, 0x6BB4C19A, 0xF2599FDE,
		        0xE84B8A95, 0xDD578159, 0x1F666F1E, 0x483BBCE2, 0x46E340BA, 0x8B7D6490,
		        0xE65BD77D, 0xA50F2282, 0x4B455D23, 0x9B5D486B, 0x95CEA1A3, 0x4B7A484A,
		        0x2E16BE82, 0x096A8E05, 0x5494AF5E, 0x1EBA1525, 0x84FDB773, 0xD47CE143,
		        0xC1254007, 0x1CE4CBBE, 0x8049402D, 0x114D7B59, 0x64D760AD, 0x6AEECE49,
		        0x83DC9867, 0x36FF9C28, 0x6FFB709D, 0xB22F7301, 0x6E6CAD92, 0x0001F394,
		        0xB560CDE7, 0xEA02FDDA, 0x40609266, 0x7F599B81, 0x1B8FD59A, 0xA562FF5C,
		        0xA01750C6, 0x78A35114, 0x789F8094, 0xF46594B8, 0xFF3A12BE, 0x29DDEB50,
		        0xE3CF5A2C, 0x8E440B20, 0xBFBF3DD8, 0x649DB58A, 0xC48A8A51, 0x97F139C3,
		        0x0BB07943, 0x548C90BD, 0x8153FCF1, 0x13098DEF, 0x812EA492, 0xFC0AC487,
		        0xC5EAE50A, 0x7A02481B, 0xC75279D7, 0x59CBC149, 0x6AB39416, 0x39331E1A,
		        0x233BE50B, 0x7F09C1BD, 0xECC11E6E, 0xA6647D03, 0x06BD33AD, 0xD717C795,
		        0xE07E2D67, 0x2688D40B, 0xE23E349F, 0x8C7F559E, 0x3BA698C2, 0xEB5FCD3C,
		        0xE94E2DE5, 0x3C0FE4DF, 0x55454456, 0x12731019, 0x21AF58D7, 0x2555CE03,
		        0x17BBC647, 0xF0C66012, 0xE02D87F8, 0x340DB0CE, 0x72A3766F, 0xE2724C51,
		        0x3636A5FD, 0xC226C419, 0x1A5F0464, 0xA543817B, 0x0B850A8D, 0xD5A6F88B,
		        0xCE3715B8, 0xB73918A2, 0x6AC92E61, 0x0FCD43EA, 0xF559EEDE, 0x3482C340,
		        0x447D9924, 0xF95D6EB2, 0xB22E6C6F, 0x935740D2, 0x7C04B228, 0xB90ABD1A,
		        0x8D9D01C9, 0x43B63B2D, 0xE0EBEDAC, 0x7C219604, 0x8479756F, 0xB67355FE,
		        0xA056539B, 0xAF1D5A02, 0x6660BB07, 0xD1A0593C, 0x5AABEF47, 0x73802FC5,
		        0xAADB5251, 0x92556CFF, 0x5BF44BDC, 0x4DC171CF, 0x1EE4E879, 0x516BC896,
		        0xCDBB21EA, 0xF513BD04, 0x94267720, 0x6B29DAC1, 0x1D778D67, 0x9625EA42,
		        0x23946BBC, 0xF23D2E0A, 0x001C2CFB, 0xEF121203, 0x963A0C2B, 0x1AAE960B,
		        0x13F2D588, 0xAE6BFEAE, 0x77424AC8, 0x1E0B2A9F, 0x9074C626, 0x9BCDE764,
		        0xF8539561, 0xC14A5B05, 0xD88D9FAE, 0x2C5C4C67, 0x2C63BAE5, 0x99CCF4CB,
		        0x3563CA53, 0x0CE7A114, 0xCB8938D3, 0x7C61537F, 0xE717A35E, 0xB69D3832,
		        0xE47931C3, 0xD5C9D409, 0x355E0B97, 0xC60EB27E, 0xB17978F6, 0x77CCBCEA,
		        0x85AEFA12, 0x59DFA376, 0x36DB61D2, 0x96832915, 0xCC4411F3, 0xB81F1EF9,
		        0x2C54E5E1, 0xDD3CE944, 0x02D92E29, 0x1D4795B1, 0x27F900B0, 0x97A516CC,
		        0xA2DB2CC8, 0x3125B863, 0xBF44DC77, 0x211A0226, 0x3A98AB5F, 0x2612396E,
		        0xA1BEF080, 0x708B7433, 0x5D457230, 0xED03C4EB, 0xA84D73AE, 0x89D5582D,
		        0x95F0C7FA, 0xEF51B8C9, 0xF9DCA97D, 0xCB2E49FD, 0xC12B4ADD, 0x611C9AD5,
		        0x35D1D7CE, 0xA77E13BE, 0x207C1B88, 0x0AC289D4, 0x4B553B81, 0x4940991A,
		        0x23D9F9D5, 0xDFD93925, 0xB924E9D2, 0xBFA61D10, 0x861FDF0F, 0xBBD30811,
		        0x953CE5DA, 0x92B48334, 0x5E5B44FC, 0x5B949533, 0x31A5D165, 0x99339641,
		        0x2737671F, 0x512EB25C, 0x54408346, 0xA090A7FE, 0x1D9CA5F9, 0x470C19E4,
		        0x720F936E, 0xA8628453, 0x364D29CC, 0x42E472DF, 0x54949196, 0x6C7C46EA,
		        0x12797418, 0x7D775295, 0xC46A7C32, 0x69CE8560
		    }
        };
    }
}
