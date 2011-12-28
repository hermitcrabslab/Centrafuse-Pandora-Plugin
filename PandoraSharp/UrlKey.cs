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
	        0xCB42446B, 0x84C9ADD7, 0x58BB40B6, 0x67309C28,
	        0x847AE93F, 0x634B08FA, 0x7B41B0E7, 0x6CA77EA8,
	        0x680A3F07, 0x32C26224, 0x15F68F8F, 0x84983ECE,
	        0xE88938C0, 0xFB2F1633, 0x172C14BD, 0xEDD40F8C,
	        0xFF10C4FB, 0x22B7AB11
        };

        public static readonly UInt32[,] S = new UInt32[4,256]
        {
            {
		        0x44B440E2, 0xE99DBE06, 0xB9F1A081, 0x0933FCA1,
		        0x6B412E99, 0xB30F4B41, 0xE32063E6, 0xF9C0101E,
		        0x5265F727, 0x678F8106, 0xACF39C5C, 0x28F2868F,
		        0x5475BE2F, 0x404DE0BC, 0x23468728, 0x184A1488,
		        0xEA971385, 0x2F886887, 0x5E95611C, 0x239508CC,
		        0x88355159, 0x5E7E789F, 0x9A805DAF, 0xEC5AB7E0,
		        0x4A3E4C9F, 0xA2BE130C, 0xEE7E0076, 0x05B9A2F8,
		        0x6D7AD1C3, 0x3CAA426E, 0x2879FC42, 0x29BB3A22,
		        0x62AE8B5D, 0xC561999B, 0x98D278B1, 0x0373DDA7,
		        0x3CED65D5, 0x4540C197, 0x8AE57D79, 0x24F37705,
		        0x54E2BF0C, 0xCAF2D2C8, 0xAB85D018, 0xBBD96449,
		        0xB36A13B9, 0x3C44EB0A, 0xD820C26B, 0xF90B784D,
		        0xAB672603, 0xD532CF15, 0x7FFB6686, 0x7BE27118,
		        0x793DDA02, 0xE73107DD, 0x2632F764, 0x6FBE7A13,
		        0x65982C19, 0xAFF729A3, 0x69B5BBF7, 0x2864B0FA,
		        0x8AED80D3, 0x0AEB3597, 0x13689958, 0x80B40D77,
		        0x3D9641A8, 0xF24E7E40, 0xB9E7A890, 0xDC02983D,
		        0xD9050DA9, 0xFB874500, 0xB2C64291, 0xDC12F8F5,
		        0x128A5CD2, 0x527F82D3, 0xCD7C1081, 0xC5EBDB5F,
		        0xF968BDD0, 0xF3E427A3, 0xBCF76022, 0xA94CA0BB,
		        0x28884495, 0x8214C39C, 0x6851B166, 0xEBA17650,
		        0x95729279, 0xCE1666C5, 0x6A57605D, 0x1BD16C4B,
		        0x59EF9ECC, 0xE7C09A6A, 0x24673702, 0x0E7CE01E,
		        0x3636E13A, 0x40F429BA, 0x9FBA277E, 0x9AE49DD0,
		        0x300E6BAB, 0x201ADB58, 0xC029E2D9, 0xE5C74ED7,
		        0x5C143553, 0x8E747F2C, 0x159043C5, 0x379614D4,
		        0x9075D06F, 0x585C1BC2, 0xE9D22CC1, 0x0914AEC0,
		        0xB3B46C73, 0xC96D2F00, 0xB14BB0D9, 0x46A5C5B6,
		        0x0E3516F4, 0xEB9AB01E, 0x5C04E434, 0x284AAFB4,
		        0x1BCAF462, 0xF1A5542A, 0xBBD03E4A, 0x4BDC3DA7,
		        0x6BD0FCC9, 0x40D21E00, 0x32E2AEF1, 0xEF62B668,
		        0x344EA1BA, 0x46B1BD02, 0xCAFE4DC6, 0x15BE27F0,
		        0xBFF5A998, 0x3B0D9B30, 0x27CA9A40, 0x84C597FF,
		        0xD6859FE3, 0x5D045192, 0x2A002659, 0xCC8B3052,
		        0xFAEFE7C2, 0xEB9F883E, 0x69772177, 0x5FA05797,
		        0x69DF2134, 0xDACC373B, 0x3C035B9E, 0x977A58DC,
		        0x84D49E26, 0x912CFF20, 0xDFA2D5A6, 0x0CA8AA62,
		        0x53CC93D9, 0x3DD8536A, 0xF40CF797, 0xC6EF5FA5,
		        0xDDBF6EA2, 0xFF79AD8B, 0x9CC8F9B6, 0x9070482E,
		        0xB6779612, 0x0A7C86DF, 0x968E17A3, 0x28CA9EF1,
		        0x86DB025B, 0xF2A80541, 0x2631C384, 0x5750F7E3,
		        0x78191CBF, 0x4025BF50, 0x1E032A2B, 0xC3B4DE8D,
		        0xAC98A492, 0xCD90D98F, 0x92B02F24, 0xFC462ECF,
		        0x435695A9, 0xEDECDDA4, 0x297B6304, 0xD973A25A,
		        0x65A7991D, 0x8B727303, 0xC8F89BD7, 0xCF18B1D7,
		        0x60A234FF, 0x13E68F78, 0xF919D31A, 0x5249D0A5,
		        0x117B11AA, 0xEF6D0783, 0x2128D583, 0xA7A24FEA,
		        0xD9C379EC, 0x86A4C5AD, 0xF3CDAA1C, 0x04A8A51F,
		        0xE19C74E7, 0x578622A0, 0xFD70277D, 0xEDD3226A,
		        0x503434D8, 0x31A8EBB5, 0x9122632E, 0x7EF237DA,
		        0xA59DEF47, 0xDD87BA93, 0x7965AB65, 0x26790F7C,
		        0xDFDF407B, 0xAF80CDF0, 0xA9E55C4F, 0x54B77138,
		        0x39B26324, 0xBE3FD4CD, 0xDEB06C51, 0xEEB11B71,
		        0x90B974D4, 0xE125702E, 0x9F6E26EA, 0x6E4574E1,
		        0x0ABC33CA, 0x3F51A4B0, 0x225E548A, 0x7D275103,
		        0x3849134B, 0xE32DC3B0, 0x08297936, 0x788C457B,
		        0x17F9219E, 0xE7E6FE7D, 0xD79DB0B0, 0xD3F8FEF0,
		        0x8B0D4DBF, 0x210883B0, 0xEACAC580, 0xAEC1E03E,
		        0xF2A7678A, 0x76457B5B, 0xB518F841, 0x31E3B067,
		        0x4E972C3B, 0x19E5A9BC, 0xB7438C21, 0x4C5B5F28,
		        0xFBB2E5BD, 0x7734BB35, 0x705A9013, 0xD132FAC5,
		        0x99F8BC98, 0x8E6B0A9D, 0xB287744F, 0x4CBC0613,
		        0xF094CEB8, 0xF93137B0, 0x9242EE26, 0xC25D9AEB,
		        0xD517C2F2, 0xEC2F7F38, 0xE18380AF, 0x22C2678A,
		    }, 
            {
		        0xDE0A562A, 0x596C7989, 0x2E99CBDE, 0x5CC946AF,
		        0x2DA232BF, 0x64145592, 0x7885E518, 0x85B53628,
		        0xFB83003E, 0x5F643977, 0x193D31BF, 0x0FDB8849,
		        0x2BA77CF5, 0x86D0A1A5, 0x48803977, 0xB670B7DD,
		        0x2924E754, 0x333CAA9F, 0x994FF797, 0x9858B8BE,
		        0x22BFD9AD, 0x1A51D7DC, 0x372CD282, 0xB38A5CA4,
		        0xB0B6858D, 0x4F5CAD72, 0x3C0DC2D6, 0xEB090786,
		        0xC45E17FC, 0xF0C37D9C, 0x8315CA42, 0x336E14D8,
		        0xE4DA980C, 0x14EEBD73, 0xA82E556C, 0x4ABA084A,
		        0x9EEC5155, 0x0CA47152, 0x03BE2A25, 0x874F8618,
		        0xC3C31219, 0x8554B382, 0x26FFF693, 0xD9FE05D6,
		        0xC69BB513, 0xC547ED34, 0x44F66E01, 0x58B32FD0,
		        0xF9F7FA8A, 0xFEF4A493, 0x2999E20B, 0x6D23743F,
		        0x97E2A9DC, 0x1916908A, 0x905CBF0D, 0xE0290BDB,
		        0xC06B65EF, 0xE5A45154, 0x45ABB6EC, 0xDD329C85,
		        0xEDF93835, 0xE5D485D5, 0x248B2CD5, 0x60CC627B,
		        0x2B3224F1, 0xD7DFA43D, 0xD5D6DA9A, 0x7A3F9A29,
		        0x26605F98, 0x435FB927, 0xED9A7CD7, 0x6020C2EF,
		        0x43AC15D0, 0x05FE8353, 0x74AF1FB8, 0xADFDC949,
		        0x3BA09A14, 0x2BC91C0D, 0x7D681AD5, 0xA08CA21C,
		        0x208C85AD, 0x0F3DE514, 0xB4C87BE1, 0x455233DC,
		        0xFF35FDF1, 0xCE93E7E9, 0x409BA175, 0x817C4198,
		        0x749B8E5A, 0xBA599286, 0x44E40068, 0x7FA013C6,
		        0x9D62E731, 0x453F48E4, 0x375CADBE, 0xC3D661D5,
		        0xA96A5BF9, 0x9D2B321A, 0x0A144AFB, 0x01590B67,
		        0x9887312F, 0x7592FB46, 0x99AC6DD8, 0xAA347510,
		        0x0F3DC8A9, 0x9BE58B17, 0x49C674FC, 0x3D1F5303,
		        0x138E2052, 0x1B7CA3EB, 0xB3C8BE68, 0xB5C6CB1D,
		        0xBA62EA1C, 0x269241DB, 0xA0EE1AB3, 0x8EB3E79C,
		        0x94EA0E9F, 0xB86FFB54, 0x56DCBF7F, 0x3404FD03,
		        0x8076B757, 0xB05A9529, 0x8CC7B224, 0x4F29804C,
		        0x6CD2C621, 0x99424188, 0xF89E7F5D, 0xFDF62C52,
		        0x94D264B1, 0x9AE26508, 0xE7C1DF25, 0xFCE03375,
		        0x4111F745, 0x46978B8A, 0x6D3DEBE0, 0xA8C9A4A1,
		        0xBF9ADEE2, 0x651A9A66, 0x37EBEFED, 0x6BAC6274,
		        0xED007BFA, 0x8B00DB5D, 0x8EB88E4F, 0x7247626B,
		        0xC70E0D71, 0xB06D9EC3, 0x777CBB67, 0x9812CC56,
		        0x12ACE7D0, 0xEE395981, 0xFE39A6EF, 0xC1F592CD,
		        0xB8C0866D, 0xC0D8526E, 0xC6AA7A35, 0x91113015,
		        0x36CC0A0D, 0xD1E8DBA0, 0x074756C8, 0xFC272600,
		        0x6C33093E, 0x44D5C245, 0xCA27B4C7, 0x5A794CFA,
		        0x459D3DD0, 0x0F7D4917, 0x139A3245, 0x9B2E5E3C,
		        0x31018582, 0x759B9D72, 0x8BDD1D9B, 0xA16CB7FC,
		        0x3BBE42B1, 0x87E40683, 0x9BE04779, 0xE9DDE72B,
		        0x0BE9A89A, 0x1CB85941, 0x96134FD9, 0xFB347B02,
		        0xD908504A, 0x71F33096, 0x705269F0, 0x3EF468FD,
		        0xC97983DA, 0x71277190, 0x8C2B030F, 0x8CAE4554,
		        0x2E643F45, 0xE16A9CE9, 0x2C06928E, 0xC7E0F46A,
		        0xBDDCEB74, 0x74985EDB, 0xBC223E1D, 0x7F8F5B2A,
		        0x1EBFAFBC, 0x3B60AE99, 0x63083D95, 0x2905083C,
		        0xF926F42E, 0xD5389D31, 0x6CA90A33, 0xE1158CAA,
		        0x352434A4, 0xB45FD6B1, 0x17389418, 0x70D400F6,
		        0x9127D3E0, 0xA8EB8D18, 0x39020FBE, 0x417AB2E5,
		        0xA5E92B88, 0x5F36AEFC, 0x4057731C, 0xD1E966F7,
		        0x0DA44875, 0x3BE7D0DB, 0x1C7850CD, 0xE3B1462E,
		        0xF9AFEFF6, 0x210E1CCE, 0x36FBB8AE, 0x8584030D,
		        0x2DD9731A, 0x9554A44B, 0x2C6F8100, 0x983A1BE5,
		        0x25FAF22D, 0x338316A7, 0x0E5A690D, 0xE702EBEB,
		        0x52AC420E, 0xEAC503EF, 0xD2FE1B98, 0xE1D55B98,
		        0xD7DD5C6E, 0xE756FFF0, 0xD3FD66EB, 0x1FD30A11,
		        0x03E18282, 0x856F2216, 0x6917F24C, 0x12975941,
		        0xD98387CA, 0x2B9E153F, 0xFD7005E0, 0x05A501F2,
		        0xA731DB07, 0xBF268F18, 0x47E9E9C2, 0x442148F8,
		        0x1CCF6FAC, 0x239820BE, 0x56C0EC64, 0xC6C59DF1,
		    },
            {
		        0x1D985BEE, 0x336930D2, 0xCA40E672, 0x7036E21C,
		        0x7B43BD3C, 0xA02DBD7D, 0x7DFA1A92, 0xB13508C5,
		        0x01633D3C, 0x6CBD1AA5, 0xCDC61031, 0x15993E15,
		        0x669E1B6F, 0x78B79587, 0x61D58836, 0x888D5578,
		        0x8B99F671, 0x346906B6, 0x5EA37C50, 0xC32C7220,
		        0xAA6101DE, 0xAF0CD647, 0x9840E7DF, 0xBC4EB801,
		        0x071126BA, 0xCD6D71A4, 0x0CDA5F16, 0x7838C18C,
		        0x8F1641CB, 0x7DF307E3, 0xB83E78D1, 0x24E91D07,
		        0x0F5BB3BC, 0x172BDFFB, 0xD24AA952, 0x41CF15C3,
		        0x78A696A5, 0x15CD0C0A, 0xD24D916D, 0xA2CF942C,
		        0xA1EC1AAA, 0x0B48FCE0, 0xE1779859, 0x99F8806A,
		        0x34333D69, 0xABBA62D0, 0xF6E91D76, 0x0B0D5FDA,
		        0x5A467847, 0x74DA0A4D, 0x0335F980, 0xE7C55B44,
		        0x6DD5E917, 0xC7305285, 0xCF1D07C6, 0x8D017ECB,
		        0xE10A16C1, 0x0DB9438C, 0x2FA12B58, 0x332FA54D,
		        0x02BD7743, 0x4B544614, 0x7907B6AE, 0x75401EBA,
		        0xF7382064, 0xF1325592, 0x06FB5C05, 0x9F5FEF1F,
		        0x3A641771, 0x807BF700, 0xC63EDF23, 0x9FFD35E9,
		        0x437A410E, 0x225D18FB, 0xAD901352, 0x9D2F8585,
		        0xEA317135, 0xCB724C48, 0xCA568A14, 0xB153340A,
		        0x88794F5F, 0x0C208094, 0x85BE94E6, 0x86C5F48A,
		        0xFC4AC759, 0xFCCEA783, 0x491AF14B, 0x23C9622C,
		        0x85660BAF, 0x110300CB, 0xDE2D8E21, 0xBAD7D22B,
		        0x3649D2A8, 0x64439BF3, 0xFDD7F2AD, 0x68129C07,
		        0x3D03801D, 0xE2D3B28C, 0xA94193D2, 0xEE2C34F0,
		        0x457DCDF1, 0x4E21BC94, 0x8F557C82, 0x13EE8AB5,
		        0x0B2A8EC9, 0x7796592B, 0x5D9E3346, 0x3621C85F,
		        0x1EB7FF52, 0xCCDF71D8, 0x538DD6AE, 0x748274A9,
		        0x6552081C, 0xFA61EE48, 0xFB2A7098, 0xA02BA33F,
		        0xB145EA01, 0xE4C5DEC9, 0x9E2BF9B1, 0x6413006D,
		        0x8F7C7501, 0x9B51E842, 0x5ADD5755, 0x06CAF452,
		        0x80050406, 0xCB961521, 0xEFC54E27, 0x420EE737,
		        0xADB18EAE, 0xF8B0B2FB, 0xC8CDC88F, 0x3A026D91,
		        0x5F99BB22, 0x391C12F8, 0xBDF1CEE6, 0xFEBE0726,
		        0x6CC79280, 0x3F7AC7F2, 0x3B92345C, 0x5C7BB986,
		        0xC60C12D7, 0x4F29C1FA, 0x04276434, 0xC1272CD2,
		        0x5E64BC58, 0xD473D8F8, 0x38E9D502, 0x5C00EE4E,
		        0x80A1A552, 0xD49CD6D2, 0xEA96CBE7, 0x029E2A86,
		        0x0D04BA72, 0xE9B0389D, 0x4AC913EB, 0x85927E61,
		        0x134A0D51, 0xE63AFF82, 0x5D7C3FEE, 0x9373DA83,
		        0x361324B4, 0x18569865, 0x7EAC6BD8, 0x945CA42C,
		        0x6A1FD8B8, 0x6C9D06F7, 0x01D4072F, 0xAED3BEA5,
		        0x9C7BADA7, 0x740C8802, 0xAD1D6843, 0xB84145EB,
		        0x2804CAEB, 0x31EB19FB, 0x402E5195, 0x05451516,
		        0xF9770FC4, 0x547FA291, 0xF9B980EA, 0xD6DC914D,
		        0x8A009CDF, 0xFDFEDDAD, 0xEBAC5EF5, 0x575B2AD2,
		        0x67A8655F, 0x54590146, 0x21FA9A1F, 0xB8CD9B23,
		        0x1D313DFF, 0xC5D15FFF, 0xB6734243, 0xD1B44EFF,
		        0xEE6DFF7E, 0x0A6DB2BC, 0x2A2AE34E, 0x596782E6,
		        0x1DF3E26B, 0xCE3EA01A, 0x3CCBBEEF, 0xD4B8AF1F,
		        0x555D5325, 0x78F81205, 0x528EFD8C, 0x01F3D29F,
		        0xAD12326C, 0x816D4F2E, 0x6DD2FFE9, 0x03C4EE90,
		        0xE9E561B6, 0x28237064, 0x82143F5F, 0xEED4AA29,
		        0x9E63A1C6, 0xB25E2AEA, 0x516B9A8A, 0xB52B4B71,
		        0xDDEF7CFF, 0x6A8FFBDD, 0x877EC0E5, 0x72AF36D8,
		        0xF9EC2EC3, 0xBD89E9AF, 0x0A2FC438, 0xD0E8BEE7,
		        0xD8979CF1, 0x0AF071BE, 0x0BC600C9, 0x7E1F6318,
		        0xBFF4BF36, 0x01DF67EE, 0x6B35580B, 0x2A3487AB,
		        0x1694328E, 0x68358F88, 0x23C60980, 0xBE312A5B,
		        0x444E80C9, 0x7ECE3A97, 0xC3CE446C, 0x5269084C,
		        0xC611CCE5, 0xA156FBAD, 0xA2331EC8, 0x1065EA4B,
		        0xA59F0F71, 0xE46F2C17, 0x2E2247DC, 0xB5EBAA6F,
		        0xD8DE0349, 0x0EA6F1B3, 0x465FB0A0, 0x0CE5A14C,
		        0x6A10A909, 0xBCB590D3, 0x8FA66C30, 0xD1FCB44D,
		    },
            {
		        0x475CA7E8, 0x4C51BBC1, 0xA90763E1, 0x7BDF2294,
		        0x04D96F34, 0x11318CB9, 0x54A65710, 0x041597BE,
		        0xC49B15C2, 0x09B9521A, 0x5589972B, 0x10167358,
		        0xA3927ED5, 0x405F7752, 0x2CBCB573, 0x37106B2E,
		        0x4CF216A4, 0x5AB1D0F2, 0x3ED8CA8E, 0xA612D957,
		        0xADC5D570, 0xD45C1E98, 0x53C28628, 0xBCF19A34,
		        0x6CA25F5C, 0x5C5E4FA2, 0x7C155954, 0xE99CE5F9,
		        0xD9A180F9, 0x4F3CF09B, 0x9DDF75A6, 0x6D240EE0,
		        0x67973B52, 0xE13895B4, 0x36ADE486, 0x22EC32D2,
		        0x075D6EAE, 0x29C31053, 0xAC06EE74, 0x1A9D3316,
		        0x8A2D0CC3, 0x57DC77D3, 0x40B2D07F, 0xDFA2051A,
		        0xFDC90DFC, 0x342E9AC5, 0xB04EB091, 0x9E1C2D1F,
		        0x075A20A3, 0xE45FA195, 0x3F958FE3, 0x18C98F15,
		        0xC70AE917, 0x78040F9B, 0xE4322DEB, 0x0903841F,
		        0xAE71257E, 0xA82C7909, 0xA398504B, 0x56A9A694,
		        0x7DA7F73B, 0x12942475, 0xAAC0C982, 0xDFD0E53E,
		        0x27CE728B, 0xE94327CB, 0xF2EBA423, 0x72B1476E,
		        0x317756F6, 0x056654E3, 0x074C0192, 0x11B6FF21,
		        0x939FD4C5, 0xE6E45B55, 0x66211539, 0x753C6C46,
		        0x536DB219, 0x939C3AF0, 0x9783EE73, 0xC8978DE8,
		        0xBA0329F6, 0x3B892181, 0x4CDA3336, 0xFD15F1EF,
		        0xAE2B2E61, 0x2637C83B, 0x9D9930BF, 0x72ADFC41,
		        0x48DBFFFF, 0x448E80F4, 0xBA1CC3E1, 0x61CCB37D,
		        0xD3CFEC32, 0x0E6804A9, 0x1ECE11A1, 0x15809783,
		        0x9F7FD813, 0x64A39648, 0x9E67CA64, 0x19B3E4B8,
		        0x8740466A, 0xEBB79667, 0x1CE86B36, 0xC7BCE505,
		        0x2445215D, 0x54ADCC77, 0xAB187AC2, 0x97B82A38,
		        0xA66B2D42, 0xA3D07412, 0x4A9CB0F4, 0x2C51F98C,
		        0xCA7FC25B, 0x73AEB532, 0xF45769BB, 0x8068AEF4,
		        0x48A14C08, 0x011E7A0B, 0xD4FEF360, 0xB572B6EC,
		        0x947692FF, 0x8EB6BE12, 0xDEB04AF3, 0xA9CD494E,
		        0x7C522A9D, 0x4CC24357, 0x616E3132, 0x68073F0D,
		        0x20F7237A, 0x7EA98584, 0x3B6BF43C, 0x29F11571,
		        0x759B5F60, 0x7D5BCACC, 0x8C86BC43, 0xB378EF1B,
		        0xD00EAF88, 0xBD85FE1A, 0xB4A42C5D, 0x2075442D,
		        0x184038CC, 0xC3D9F6F8, 0x1D72BAC3, 0xDD8C41C0,
		        0xD85F7634, 0xB48A6902, 0x8BB3F160, 0x178CCA70,
		        0x4EE8D16E, 0x5121D6FD, 0xF2F09DA9, 0x84B55B38,
		        0x8D081959, 0x13F21DAD, 0x19BCDA5C, 0x909A9FDF,
		        0x11AD6731, 0x2CE9D09F, 0xAA8E9543, 0x9F8D5555,
		        0x679FE7C1, 0x251591CB, 0xC4187630, 0x57324F07,
		        0xB2C35182, 0xBD16E4F0, 0xC3B3DE3F, 0xEA6CBA23,
		        0x00C810DB, 0xBB040931, 0xE0BA08A6, 0xDC4AC24B,
		        0xEE1428BB, 0x964A6F9F, 0x2096F5DC, 0x2170A50C,
		        0x3FBCA4BD, 0x7C321FAA, 0x88679D5D, 0x0F5FFFDC,
		        0x88AA1865, 0xFD51E01A, 0xA35EF105, 0x8B99A039,
		        0xD5C22176, 0xB1A73D55, 0xA0080F3D, 0xDBC61A70,
		        0x3FB106E3, 0xBAEA8E73, 0x7E34C1B3, 0x40F3DC19,
		        0xFD9AEEE4, 0xA3E6A013, 0xEECF6A5E, 0xA83012D4,
		        0xDEDF0B25, 0x7CB1D8C2, 0x02C4180C, 0xE38905D8,
		        0x2D631C38, 0x36612C66, 0x9845588C, 0x9510F7FD,
		        0xBCD5C8B1, 0x55D50272, 0x9B35118E, 0xFB7C4E3F,
		        0x2E3BD98F, 0x56DD4BD7, 0x4C3B6F27, 0x0264DDB7,
		        0xBD4A811C, 0x2A9A4F84, 0x2292258A, 0xE7799B02,
		        0xF5B529B2, 0x894B5D58, 0xD3392CAA, 0x515CCAC1,
		        0xB6857B04, 0xB2CBE5DF, 0x28B230C2, 0xE3CE03F5,
		        0x0581D4DF, 0x3CC0D279, 0xD0C1EDEC, 0x160B926F,
		        0x32F58056, 0x9D574911, 0xED9FB621, 0xA2D920F7,
		        0xB4BE7EAC, 0x6947D33F, 0xBB438F92, 0xDD11B405,
		        0xDEFF0F70, 0x03B3E6A8, 0x4BD0A277, 0xE28FA297,
		        0x7098CAF4, 0xB74B88E5, 0xC3330744, 0x77E7975A,
		        0xB35AC1B1, 0x3BFEA68C, 0x84BF6163, 0x101D5CC0,
		        0xF4558349, 0x0CF6A28B, 0xD76AF6B8, 0xD6A3140D,
		        0x3F37D065, 0x0E55EA90, 0xC1A759D1, 0x70265EAB,
            }
        };
    }
}