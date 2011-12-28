using System;
using System.Collections.Generic;
using System.Text;

namespace PandoraSharp
{
    internal static class UrlKey
    {
        public static readonly uint N = 16;

        public static readonly UInt32[] P = new UInt32[18]
        {
		    0x71207091, 0x64EC5FDF, 0xA519DC17, 0x19146AB7, 0x18DF87E7, 0x98377B97,
		    0x032887B7, 0xC7A310D5, 0xA506E589, 0xE97346B9, 0xE3AA5B39, 0x0261BB1D,
		    0x466DDC6D, 0xDEF661FF, 0xCD257710, 0xE50A5901, 0x191CFE2E, 0x16AF68DD
        };

        public static readonly UInt32[,] S = new UInt32[4,256]
        {
            {
		        0x53B04195, 0x34D8664F, 0x564FA6F9, 0x943A4261, 0x43EE3112, 0x2FBC9B61,
		        0x31C92B2F, 0x5F23E485, 0x1D51F5AE, 0x45589853, 0xEC79BEF5, 0x64E56904,
		        0xD2B94FB8, 0x12ECF786, 0x39FBB15C, 0xADC822DF, 0xF63EB8D0, 0x707E6E03,
		        0xC9EE963B, 0xAF4C533B, 0xB6CA295D, 0x669EC8F6, 0x5B2128DA, 0xCDCC7042,
		        0xECE8EA68, 0xB6564227, 0x042D1DE9, 0xA7BB4D38, 0x702AF25D, 0x04218195,
		        0xDA5DBB60, 0x05776188, 0xE6FB54D4, 0xD0D273F3, 0xF498395C, 0xD2FFAA63,
		        0x2ECC5F00, 0x9B785AAB, 0xE88DF10E, 0x46A5C5A7, 0xCB05BAF6, 0x93D07466,
		        0xFD82EB2F, 0x29C7525C, 0x88151216, 0x7FEA6803, 0x79AF1507, 0xABEEF999,
		        0x2C338D91, 0x8BDC112D, 0xAE639DF1, 0x3395771D, 0xE5D05978, 0x985DFBCE,
		        0x7A33712C, 0x77EE0800, 0x6A3235A7, 0xAD25178A, 0x5DEAB99C, 0xA518351E,
		        0xE191C29C, 0x8F58F7B5, 0x8F59301A, 0x230D7717, 0x36480929, 0xE7389FA5,
		        0x75101209, 0xCC80D6EA, 0x20A77201, 0xDF34CC7F, 0xDD0D15EC, 0xAAD39BD7,
		        0xE148C1C8, 0x60053D1E, 0xA765BBAA, 0x055A807E, 0x243EF591, 0x3BC6A318,
		        0x86B4E2A8, 0x36068D06, 0x8E38E7ED, 0xF6EF1C43, 0x4BC12D1C, 0xEE5CD4DE,
		        0xA5635E1F, 0x4EA7103F, 0xE37CC2D5, 0xAA24D152, 0xC10D25A1, 0xB5A4B1DD,
		        0x38A0E8AF, 0xC2E96D92, 0xC537DB8C, 0xFB00FD39, 0x96D3E31F, 0x1587D1D5,
		        0x3D3C6162, 0x116E9A21, 0x5E73A15A, 0xFB1207F6, 0x205C8CE6, 0xCD2EB8F4,
		        0xBF2D8E53, 0xC00799B6, 0x05AB657A, 0x5A337660, 0x13F66753, 0x769969FF,
		        0x112E9892, 0xE900968F, 0xC09E5462, 0xF83D1DCD, 0xCE8730EE, 0xB8A9F537,
		        0x7D4A07F9, 0xE885BB2A, 0x6CAE2932, 0x959FF20B, 0x266FF5A7, 0xD2465D75,
		        0x20BA50CD, 0x3DADB44A, 0xE72D39EE, 0x1B3D759E, 0x4F537258, 0x0F403950,
		        0xE7F64B2C, 0xE033D524, 0x07FF6009, 0x2C8270B2, 0x6AA43085, 0x56659DE5,
		        0x2082EA85, 0x3D347FAB, 0x2C903DF5, 0xE7B54B39, 0xAAD7B6F3, 0x10BDF5DF,
		        0x9F8405F8, 0x74635701, 0xBBC945A3, 0xEF0F67C2, 0x8ECFE353, 0xC47947D4,
		        0xCB638932, 0xE0DFD27D, 0x390ECFF3, 0x329941FF, 0xB7B8B2E1, 0x96129843,
		        0x6D487C00, 0xF7A31803, 0xEFD5F48D, 0x144881D4, 0x82C99F97, 0x3CA6233C,
		        0x5D81D880, 0x5452C86E, 0x92F7424B, 0x1ABF8230, 0x2B9D844E, 0x53151082,
		        0xFFDB3720, 0x5398D8CE, 0xD2B1DB66, 0x637FEEDF, 0x0C281873, 0x0D5B080F,
		        0x1CC84819, 0xA9C6416E, 0x0CBD6FA2, 0x5D311F65, 0x1B10E4AA, 0x862EFCE7,
		        0xB82B8EA1, 0x2C6FCB4D, 0x48197672, 0x4DE9F5A1, 0x189A1587, 0x11B82778,
		        0xDF0620A2, 0x8F9EB547, 0x0C42BC08, 0xEF386B9B, 0x2882BA91, 0x5CB16824,
		        0x95B04228, 0x0A84C744, 0x4A4F12F1, 0x3328121D, 0x099D0C58, 0x9FFE4330,
		        0x53676878, 0x0F4BFE6D, 0xF7F6757A, 0x849E6A1F, 0xE7F305AF, 0xABE5CF0A,
		        0xD4C73D1F, 0xEC1BA28A, 0xDF481C60, 0x3A0169E9, 0x644F5F06, 0x74A03899,
		        0x2E1CC42A, 0xBF181E7A, 0xBFD031DF, 0xA8F9BFAD, 0xB08FF9BC, 0x07F040A6,
		        0x9AA8240D, 0x936730A6, 0x4B659CAE, 0x70792DFF, 0x50738D93, 0x2E02F9DF,
		        0x01F6AA81, 0xAA5557E6, 0xF5DF588E, 0x70D3217B, 0xBFD2CF2C, 0x6193A8BC,
		        0x4C1D0DAD, 0x8E626F01, 0x878B8F70, 0x422B5FEC, 0x77A5D368, 0x9C5A4A84,
		        0x31260B03, 0xA00A2738, 0xFE1A531C, 0x8D268013, 0x926D9087, 0x66CCC472,
		        0xA0E6BC5D, 0x72B4806C, 0xD75EC86E, 0xE2AA9D6C, 0x5F8DD394, 0x70C92981,
		        0x32578C75, 0x2E110E4F, 0x20F0883F, 0x505740F5, 0xD52B76F7, 0x4C087E4F,
		        0x6D6455EE, 0x2E9E895F, 0xD826A8C3, 0x032152E6, 0xE3BCD79D, 0xBA6796AA,
		        0xE1F2CC8D, 0x61A70735, 0x581A8A85, 0xFF4A937F
		        }, {
		        0xCBD350B6, 0x04217557, 0x0B48BEDE, 0x87D87806, 0xE78282F6, 0x1518E761,
		        0xD0242D75, 0xFEE8A656, 0xE1EF119C, 0x465D0A5F, 0x8627A798, 0xB2589459,
		        0x6A8BF4D2, 0xAEF2E605, 0x22354462, 0xA3B5DE00, 0xC40086BE, 0xAB4FA4FA,
		        0xD7C782A4, 0x095003F7, 0x76550A91, 0x51D742A6, 0xE6B1868C, 0x7A2E891B,
		        0x32C24C32, 0xB71EB54E, 0x58F1F230, 0x2C73427B, 0x6CAF2DB1, 0x6E65848B,
		        0x202FCC18, 0x782E5C7A, 0xCC37A03B, 0xE1D9FD4D, 0xBA8CEBE8, 0xBA5D7E12,
		        0xE37E60F3, 0x99CA41AE, 0xB70F141A, 0x3399E5E6, 0x6F168416, 0xD9FCCDFD,
		        0xE0149EF0, 0x6632458E, 0x192C72C2, 0xBB37A8D4, 0x4DEB6CFA, 0x1D65E9BE,
		        0x9F47349D, 0xB44857CC, 0xEE4EBB41, 0x5571F80A, 0x7060121A, 0x1863AAE5,
		        0x89E44DA0, 0xA8AB709B, 0xC8B0D49E, 0x7A0A4DAD, 0x53BF4EBD, 0xF52C4C3C,
		        0x13E00197, 0xF5C748EA, 0x01993E7A, 0xCBEDF34F, 0xC5A6B7BC, 0xCEF7AFD4,
		        0xFF554458, 0xB381FB5F, 0x13B4B32C, 0x4E7E2A88, 0x5015434F, 0x977B5E72,
		        0x595037D5, 0xAA9914EE, 0xE48ECD4A, 0xB5933128, 0x819BC797, 0x1FDA1451,
		        0x7E246FD0, 0x70AE3F82, 0x3ABEBFE4, 0xE89BA94A, 0x0F8BA57F, 0xAD2EDFD1,
		        0x71C248D1, 0xDE31588B, 0x9058ACB8, 0x1D811B61, 0x6A459746, 0x75698B77,
		        0x06C5291A, 0xC4FDC707, 0x3412F7A2, 0xA11D2CB7, 0x771C35D9, 0xFB5252B9,
		        0x8ADCC6BB, 0xACFDB11F, 0xA53D102E, 0x3BDD6B7A, 0x7242DFBC, 0x600EAF36,
		        0x55399BD7, 0x5C52D902, 0xE6D5A548, 0xE3599A58, 0xE98182B0, 0x748C0C18,
		        0x4B2BEE05, 0xCC531DD8, 0xA3231F8C, 0x8FD29390, 0xFD8C43FB, 0x7E221049,
		        0xCD489DEF, 0x2312C991, 0x55633208, 0x3514163F, 0xAB3BEE59, 0x77FFAA7B,
		        0x90915A4C, 0x213FF94A, 0x3CCD3F06, 0x574DF4E9, 0x256EE273, 0xB9FEE691,
		        0x979A0F80, 0xFBA4876D, 0xCA3448B8, 0x9A05788E, 0x01817985, 0xFDC95285,
		        0x64FDABDD, 0x7E8EFF2E, 0xC9F8DFB0, 0x3585290F, 0xA359E9CD, 0xE7361ACE,
		        0x0F05DE97, 0xA84A949F, 0x816F79D1, 0x80053F79, 0xF3ED1531, 0x0077675E,
		        0xAA407D1C, 0xA905EC4E, 0xB5031A49, 0xF7840308, 0x1749068C, 0xE7B994B4,
		        0x7963F746, 0xF8D6832E, 0xF2C43B73, 0x0C858859, 0x8ACA9FDF, 0xA980B080,
		        0x2DA83BA8, 0x88A9E6FE, 0xA1D65DCA, 0xB7466978, 0x1C7579D5, 0xA3E829E7,
		        0xA038A762, 0x2E6CFC22, 0x80A3C2DD, 0x6FB505A2, 0x40A809C9, 0x45A1345A,
		        0xCA1FED04, 0x623F44F9, 0xBCECFD8C, 0xBC1EA3D8, 0x3CFA9C4E, 0xC3F84B71,
		        0x245EADC3, 0x0635934D, 0xFD115EF2, 0xE6A29E9D, 0x3B135A32, 0x54316287,
		        0x6427B2DD, 0x9A58AD8A, 0x18C4F685, 0x0BCF5559, 0x1F937C1C, 0xF7EBADE2,
		        0xBB6D1EFC, 0x5EC3076E, 0xB330C228, 0xFB630B27, 0xBA582D2D, 0x6810A8D0,
		        0x93426874, 0x2CF4EB4D, 0xBC650CDD, 0x6DE2A493, 0x7FE6B0FB, 0xF251E5DB,
		        0x6F12D6BE, 0xC6BA7485, 0x5F419C45, 0x22B0F07C, 0x92EDDB3C, 0xF169D257,
		        0x32663AE2, 0x04B74EA2, 0xC8A37378, 0x0652BC72, 0xB402FDC7, 0xDF7F8268,
		        0x44030F03, 0xAF3FD392, 0x5491C194, 0xB85DB9CE, 0xD651CA8F, 0x1255050C,
		        0xC29846CA, 0x4C839D32, 0x3F5B7E14, 0x2A877586, 0xF98A241E, 0x9E293240,
		        0xA1FDEAAF, 0x20A30A8C, 0x1CBD8053, 0x34F51B81, 0x2385CD90, 0x96AA3920,
		        0xF5E2BE30, 0x49336625, 0x8D8C7CAC, 0xE218E266, 0x140AFB4B, 0xE3716DCE,
		        0xC78D4357, 0xC7A08538, 0x012D82CC, 0xAE079F67, 0x1FC97F4D, 0x13B82CF6,
		        0xA450A8F9, 0x3EF2B891, 0x37016870, 0x85837D47, 0x9E0554B9, 0x5E250425,
		        0x924D3CF5, 0x1AA84C00, 0x27B42F8C, 0x49023610, 0xA7B73B7B, 0x62C8BCFD,
		        0x3631472D, 0x0E33D2D6, 0x0A0B4B0A, 0x6A2556C3
		        }, {
		        0xD13723BF, 0x9414C5A7, 0x67FFF98A, 0x01945128, 0xD037928C, 0xDEC7C303,
		        0x5EBD36AC, 0x5C905BCB, 0x020B6426, 0xB7C9C54D, 0x8613F926, 0x1FEC9118,
		        0x51A1AA61, 0x16BA1018, 0x68338FC2, 0x5542A1ED, 0x8063E942, 0x8BAE40A2,
		        0x1C5D6954, 0xA463AC5D, 0x3C301ED8, 0x4F4B860A, 0x6EE45E7C, 0xD462EE68,
		        0xDFA82F0E, 0x763EB7CF, 0x78335FBC, 0x95EED064, 0xFB2F79D6, 0xECAA236A,
		        0x59459EAE, 0x233D236A, 0x4DB2900A, 0x8B9D5EB4, 0x0F21ABB6, 0xFA27F2B1,
		        0xA4A6FA51, 0x4653FD21, 0x93E9C526, 0xCCCB341B, 0x1F66711A, 0x68E054BE,
		        0x7204FD43, 0x689E8AC0, 0x12302D1B, 0x96D11239, 0xB3DA833A, 0xCA15D14E,
		        0x80D4798B, 0xB6465C4D, 0xDAAD50A1, 0x9FD6B95E, 0x1B4EFECB, 0xEA61AA1C,
		        0x18AD77FA, 0x5A736118, 0x511A3385, 0xD5D92A85, 0xB957043E, 0xAA3554A6,
		        0xFB571DF0, 0x305A86FE, 0x240E4572, 0x80DEFE96, 0x2888F5CC, 0x5272DAE5,
		        0x1A283749, 0x0DF5E014, 0x1F6F2F7D, 0x292C1DC7, 0xC72ED514, 0x59E99AE5,
		        0x0C4FDE67, 0xE30B2643, 0x24C12F6A, 0x4C9B0BFC, 0xA78F1A03, 0x0036C1DF,
		        0x913B7309, 0x7FDE5A89, 0xFFC9D504, 0x9F7C42DB, 0x8BE84B2A, 0x588BBCFA,
		        0x872C26E7, 0xA3BC8F41, 0x5B1160B4, 0x239B30E4, 0xB2DD5494, 0xE337530F,
		        0xF113CD33, 0xEADC8DDF, 0xFF339D9F, 0x71F15A7D, 0x5973E16B, 0x5A4D3F0A,
		        0x28656238, 0x0EB676E9, 0x5533A9A2, 0x07EAF535, 0x5C271A91, 0xDAFA35CF,
		        0x8C0C4E34, 0xB2D15020, 0xA9CEAF93, 0x271157B4, 0x41B88963, 0x88EA0624,
		        0x94400C7C, 0x650DCD70, 0xBAF8C4DF, 0x13DC1789, 0x0040522B, 0x13E1D0C1,
		        0x80C2C55C, 0x4C22B92B, 0xC9BDFD2C, 0xAB74AB27, 0xAEAF6AD8, 0xA2A5E893,
		        0x10A9000D, 0xDFE44794, 0xF94F9FA0, 0xFC7316A5, 0x7B967375, 0x0114700D,
		        0xABFC7363, 0x09CB8915, 0xB96C9B3A, 0xE95142BD, 0x1B632A21, 0x57A66288,
		        0x80B22AAD, 0xC276DBCC, 0x8C38D035, 0xB5AEC8CE, 0x4150EB32, 0xE8FE1512,
		        0x184FE503, 0xC66A57A9, 0x25992BF4, 0x746F8100, 0xC7790E91, 0xE8988227,
		        0x626C1812, 0xAA60037C, 0x43997BEA, 0x9508A877, 0x5AE80E46, 0xDE2758FF,
		        0xF7E89EEE, 0x0EE387D6, 0xD763F872, 0x97D7F238, 0x910882D5, 0x6754994B,
		        0x436C7433, 0x93210B5A, 0xCC33EBF7, 0xC530B930, 0x5DA8B772, 0x325DEC23,
		        0x4599CC7B, 0x458591CC, 0x5A49130A, 0xB87F80DC, 0x708208CE, 0xE4B6033F,
		        0xAFE91366, 0xCBAB3EF2, 0x718B84B8, 0x60859C5E, 0x50701AEC, 0x05E2CA48,
		        0xB2BFCDB8, 0xFD47C881, 0xB18ECC02, 0xF8AABC72, 0x0ABD654B, 0x1A6602C0,
		        0xFFFBCED7, 0xDA627448, 0x67E0590A, 0x3B1952D9, 0x4C0A32FB, 0xE9F0507C,
		        0x830699D6, 0xCF481E29, 0x3FEC6807, 0x18CB4E71, 0x6CAC5839, 0x592E5FD5,
		        0x1A2B1DA2, 0xA104840F, 0xE2B4A352, 0xAA202DF2, 0xC1E3D837, 0x4DA02F3A,
		        0xB8AE3EE2, 0xBAF2AD8F, 0x60A0A49C, 0x03A08BA2, 0x3C7613FC, 0xC42B5AA7,
		        0xFB799A04, 0x3FC12E4F, 0xE2F8881A, 0x854B6F93, 0x732EB662, 0xF04CB10D,
		        0x3BBDFD40, 0x9B1F08BD, 0x679E054C, 0x5A5C81B9, 0x42EEF45A, 0xE1CAC282,
		        0x8E057351, 0x618F3140, 0x2B4EB7BE, 0x7C0B4416, 0xD67CF521, 0x61B12968,
		        0x12454732, 0x09E117B5, 0x427F05E2, 0x151256A0, 0xD4DE1087, 0x610F2E55,
		        0x0703EDE6, 0xD984D328, 0x3F349754, 0x76E7FB05, 0x8C339292, 0x1C7B2C00,
		        0xEAD34339, 0xEED62B3B, 0x8AD430DE, 0x56977BEE, 0xC73DB96B, 0x74ECF426,
		        0xEC27F20A, 0xD250B1B3, 0xD1DB7436, 0xBADF98FB, 0xB5DBF4B7, 0xC87589C2,
		        0xD634D942, 0xB5A2FEF4, 0x7FD6F13B, 0xB89DA34D, 0x9FC14AFC, 0x733563D4,
		        0xCEE0EE6A, 0x5699CCBE, 0xD684349C, 0xFD2CCCEC
		        }, {
		        0x9CE989E5, 0x27A0CB56, 0x02E00928, 0xABBA6B68, 0xD721FCCF, 0xA696A7B7,
		        0x36CE1D63, 0x9B4287D7, 0x390743D1, 0x69F6BB36, 0x93D521C5, 0x44D162AD,
		        0xE0070AA9, 0x5FB59DC6, 0x19542E39, 0x26F788BE, 0x75FE89D6, 0x0C80CFCB,
		        0x0540DC8C, 0xFA54F755, 0xF773FC82, 0xA35D570A, 0xC5723322, 0x25EF7BDE,
		        0x87F8E80A, 0x946960D7, 0x1ADBD76B, 0x750C1AF9, 0x0360C46B, 0x8446D2A9,
		        0xC9202B06, 0x278C843A, 0x5DA07CCF, 0x2245D4AA, 0x93DFF522, 0x192AAAEF,
		        0x9CDE5DD9, 0x3D9794C2, 0xF3E16F90, 0x36CCC653, 0xF16949C0, 0xD8554E88,
		        0x5824EC8E, 0xE311AAE5, 0xFDBC7A0D, 0x10F4AD37, 0xF468F494, 0x4E4F819D,
		        0x3F9E57EA, 0xE43EC4AD, 0x871F2076, 0x4ADDB4F1, 0xE8E299B3, 0x7C0A1836,
		        0x941F36A1, 0x35457B0F, 0x39470AEC, 0x9A5B504B, 0x4BB2F6F8, 0xF6DE598B,
		        0x8CFEC07F, 0x4548D4BF, 0xD41E0229, 0x3F2A12F7, 0x1AF19BD5, 0x644175B5,
		        0xA4CA85FC, 0x49276FD6, 0xF62A4D52, 0x210A6846, 0xBB56CCC3, 0x031158B2,
		        0x4DC62335, 0x10FFA10E, 0xF055BCEF, 0xC5AA7928, 0x1434F73C, 0x2A43ECA8,
		        0x842132AC, 0xD562AD21, 0xD5CEC47C, 0x1B691AB0, 0x42767035, 0x13BA59C9,
		        0x29AF3D75, 0xB39E2850, 0x31D492A5, 0x7D9E2352, 0x6AF923E1, 0x3BE1D419,
		        0x16158A7E, 0x44EF7376, 0x2EE3C6C1, 0x8D352616, 0x9CB629BA, 0x6208B9AD,
		        0x0B631F69, 0x8F571F32, 0xB0D68B0C, 0xCDFAD3A0, 0xC80875FE, 0x59E9602F,
		        0x51F6B69A, 0x1D409455, 0x61FDB55C, 0xCE3720E3, 0x137DE790, 0x8B04FC1B,
		        0xC19CE38A, 0xB29D90F9, 0xD3593524, 0x1627951C, 0x5C11A5DE, 0xAF94409B,
		        0xC832B671, 0x32B72AE3, 0xBA6BB680, 0xA12ACF8A, 0xE4A9D43F, 0x107B81B9,
		        0x53B1B9D5, 0x8DA00BB9, 0x2C148921, 0x151EC1A6, 0xD768ECCD, 0x436855B7,
		        0x8E33A334, 0xEBB502A1, 0x2ECCD157, 0x39F958F6, 0x9A325E5B, 0xDAEE53FE,
		        0x0278EC16, 0xADDE5BFB, 0x9248885D, 0x413218E1, 0x1C63F37E, 0x4D0C747C,
		        0x9135BAF4, 0xD86EEEED, 0x73D431C5, 0x28328C16, 0x6BCF2229, 0x46DCDB0D,
		        0xDF1A50DC, 0x9860C3AC, 0x708CD67D, 0xF6872403, 0x522D6E98, 0xE6CEA50F,
		        0xAAC9DC07, 0xD5605E8D, 0xE56E2CA7, 0x47FD227D, 0xF8210DDD, 0x0F3F974C,
		        0x062E6E11, 0x4EFF4F43, 0xA61945E3, 0xED59FF50, 0x6094DBED, 0x70383AE0,
		        0xE2B55F47, 0x81212B70, 0xD47B4D3D, 0x727BFD92, 0x607A07EC, 0xEE4AA97B,
		        0xFE9FCC26, 0xBB2FEEA4, 0x31C4E4CC, 0xA06ACF19, 0xD7A8A983, 0xC7A038EA,
		        0xBC89CB3C, 0x58C63BF6, 0xC60A7E0D, 0x1DC2A9DF, 0x5F7C8278, 0x616B32FA,
		        0x3475A5E2, 0x608A8F4C, 0x7EC19DD7, 0x0CD2C716, 0xAE46828E, 0xE53B17FA,
		        0xF5A4AD4D, 0x0B1290AE, 0x5C6E74D3, 0x866D7316, 0x39054DF1, 0xA2A818BB,
		        0x42D6C33A, 0xB6FEC0F2, 0xA1D3B572, 0x6F48AD3E, 0x6144A64A, 0x7BF86B73,
		        0x0E444BC4, 0x9AD01D4A, 0x43C3C4EB, 0x9D518FCD, 0x1CE1B720, 0xAD579F70,
		        0xB2EECB4F, 0x9502AFC7, 0xEBC647A0, 0xB7FA1B5C, 0x3ACC4F6E, 0x047E7148,
		        0x496E7AC9, 0x7F136464, 0x41C36E76, 0xCC38CB5E, 0xB24F9444, 0x2E95E3B1,
		        0xDE7DE530, 0xCDCA74C3, 0x044AA504, 0xFA4B351F, 0xFBC33DA2, 0x14FB5DAC,
		        0x179B39C8, 0xBD4A85E1, 0x3EFAAD11, 0x2C2C6F71, 0xE92A32C4, 0x76B6C150,
		        0xE1FE212C, 0xF38FD4CF, 0x268C35D9, 0xEDB03308, 0x7B8E2CB5, 0xB3706839,
		        0x8144E420, 0xF6CECF27, 0x0DE5225D, 0x5D40CD54, 0x8B42965C, 0x7295E976,
		        0x844D6827, 0x881E23DF, 0x964A45F1, 0x528E84E8, 0x57DA399F, 0xD7903C7A,
		        0x78B0FEE1, 0xB8D3A5D7, 0x2C9A9DE1, 0x4D73B1FD, 0xE3558381, 0x8B0434E1,
		        0xBF918EBC, 0x7248BC30, 0xA19E9B98, 0x128E7B36
		    }
        };
    }
}
