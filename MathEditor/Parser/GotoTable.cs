
using System.Collections.Generic;
using System.Text;
using NTList = System.Collections.Generic.SortedList<Parser.NonTerminalTypes, int>;

namespace Parser
{
    class GotoTable
    {
        public GotoTable()
        {
            NTList state;

						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,3);
						state.Add(NonTerminalTypes.N_Equations,2);
						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,4);
						state.Add(NonTerminalTypes.N_Goal,1);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[0] = state;
						state = new NTList();

						gotoTable[1] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,15);
						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,4);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[2] = state;
						state = new NTList();

						gotoTable[3] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[4] = state;
						state = new NTList();

						gotoTable[5] = state;
						state = new NTList();

						gotoTable[6] = state;
						state = new NTList();

						gotoTable[7] = state;
						state = new NTList();

						gotoTable[8] = state;
						state = new NTList();

						gotoTable[9] = state;
						state = new NTList();

						gotoTable[10] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,40);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[11] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,50);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[12] = state;
						state = new NTList();

						gotoTable[13] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,60);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[14] = state;
						state = new NTList();

						gotoTable[15] = state;
						state = new NTList();

						gotoTable[16] = state;
						state = new NTList();

						gotoTable[17] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,61);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[18] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,62);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[19] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,63);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[20] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,5);
						state.Add(NonTerminalTypes.N_Expressions,64);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[21] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,65);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[22] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,66);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[23] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,67);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[24] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,68);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[25] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,69);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[26] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,70);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[27] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,71);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[28] = state;
						state = new NTList();

						gotoTable[29] = state;
						state = new NTList();

						gotoTable[30] = state;
						state = new NTList();

						gotoTable[31] = state;
						state = new NTList();

						gotoTable[32] = state;
						state = new NTList();

						gotoTable[33] = state;
						state = new NTList();

						gotoTable[34] = state;
						state = new NTList();

						gotoTable[35] = state;
						state = new NTList();

						gotoTable[36] = state;
						state = new NTList();

						gotoTable[37] = state;
						state = new NTList();

						gotoTable[38] = state;
						state = new NTList();

						gotoTable[39] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[40] = state;
						state = new NTList();

						gotoTable[41] = state;
						state = new NTList();

						gotoTable[42] = state;
						state = new NTList();

						gotoTable[43] = state;
						state = new NTList();

						gotoTable[44] = state;
						state = new NTList();

						gotoTable[45] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,101);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[46] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,102);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[47] = state;
						state = new NTList();

						gotoTable[48] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,103);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[49] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[50] = state;
						state = new NTList();

						gotoTable[51] = state;
						state = new NTList();

						gotoTable[52] = state;
						state = new NTList();

						gotoTable[53] = state;
						state = new NTList();

						gotoTable[54] = state;
						state = new NTList();

						gotoTable[55] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,128);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[56] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,129);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[57] = state;
						state = new NTList();

						gotoTable[58] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,130);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[59] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[60] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[61] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[62] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[63] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,16);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[64] = state;
						state = new NTList();

						gotoTable[65] = state;
						state = new NTList();

						gotoTable[66] = state;
						state = new NTList();

						gotoTable[67] = state;
						state = new NTList();

						gotoTable[68] = state;
						state = new NTList();

						gotoTable[69] = state;
						state = new NTList();

						gotoTable[70] = state;
						state = new NTList();

						gotoTable[71] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,134);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[72] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,136);
						state.Add(NonTerminalTypes.N_Equations,135);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[73] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_MathTextContent,147);
						gotoTable[74] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,151);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[75] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,152);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[76] = state;
						state = new NTList();

						gotoTable[77] = state;
						state = new NTList();

						gotoTable[78] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,153);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[79] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,154);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[80] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,155);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[81] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,156);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[82] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,157);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[83] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,158);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[84] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,159);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[85] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,160);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[86] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,161);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[87] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,162);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[88] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,163);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[89] = state;
						state = new NTList();

						gotoTable[90] = state;
						state = new NTList();

						gotoTable[91] = state;
						state = new NTList();

						gotoTable[92] = state;
						state = new NTList();

						gotoTable[93] = state;
						state = new NTList();

						gotoTable[94] = state;
						state = new NTList();

						gotoTable[95] = state;
						state = new NTList();

						gotoTable[96] = state;
						state = new NTList();

						gotoTable[97] = state;
						state = new NTList();

						gotoTable[98] = state;
						state = new NTList();

						gotoTable[99] = state;
						state = new NTList();

						gotoTable[100] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[101] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[102] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[103] = state;
						state = new NTList();

						gotoTable[104] = state;
						state = new NTList();

						gotoTable[105] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,171);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[106] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,172);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[107] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,173);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[108] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,174);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[109] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,175);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[110] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,176);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[111] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,177);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[112] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,178);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[113] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,179);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[114] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,180);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[115] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,181);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[116] = state;
						state = new NTList();

						gotoTable[117] = state;
						state = new NTList();

						gotoTable[118] = state;
						state = new NTList();

						gotoTable[119] = state;
						state = new NTList();

						gotoTable[120] = state;
						state = new NTList();

						gotoTable[121] = state;
						state = new NTList();

						gotoTable[122] = state;
						state = new NTList();

						gotoTable[123] = state;
						state = new NTList();

						gotoTable[124] = state;
						state = new NTList();

						gotoTable[125] = state;
						state = new NTList();

						gotoTable[126] = state;
						state = new NTList();

						gotoTable[127] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[128] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[129] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[130] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,189);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[131] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,190);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[132] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,191);
						state.Add(NonTerminalTypes.N_MathTextContent,6);
						gotoTable[133] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[134] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,193);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[135] = state;
						state = new NTList();

						gotoTable[136] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[137] = state;
						state = new NTList();

						gotoTable[138] = state;
						state = new NTList();

						gotoTable[139] = state;
						state = new NTList();

						gotoTable[140] = state;
						state = new NTList();

						gotoTable[141] = state;
						state = new NTList();

						gotoTable[142] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,219);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[143] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,51);
						state.Add(NonTerminalTypes.N_Expressions,220);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[144] = state;
						state = new NTList();

						gotoTable[145] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,221);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[146] = state;
						state = new NTList();

						gotoTable[147] = state;
						state = new NTList();

						gotoTable[148] = state;
						state = new NTList();

						gotoTable[149] = state;
						state = new NTList();

						gotoTable[150] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[151] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[152] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[153] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[154] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[155] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[156] = state;
						state = new NTList();

						gotoTable[157] = state;
						state = new NTList();

						gotoTable[158] = state;
						state = new NTList();

						gotoTable[159] = state;
						state = new NTList();

						gotoTable[160] = state;
						state = new NTList();

						gotoTable[161] = state;
						state = new NTList();

						gotoTable[162] = state;
						state = new NTList();

						gotoTable[163] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,229);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[164] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,136);
						state.Add(NonTerminalTypes.N_Equations,230);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[165] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_MathTextContent,231);
						gotoTable[166] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,232);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[167] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,233);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[168] = state;
						state = new NTList();

						gotoTable[169] = state;
						state = new NTList();

						gotoTable[170] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[171] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[172] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[173] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[174] = state;
						state = new NTList();

						gotoTable[175] = state;
						state = new NTList();

						gotoTable[176] = state;
						state = new NTList();

						gotoTable[177] = state;
						state = new NTList();

						gotoTable[178] = state;
						state = new NTList();

						gotoTable[179] = state;
						state = new NTList();

						gotoTable[180] = state;
						state = new NTList();

						gotoTable[181] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,237);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[182] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,136);
						state.Add(NonTerminalTypes.N_Equations,238);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[183] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_MathTextContent,239);
						gotoTable[184] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,240);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[185] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,241);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[186] = state;
						state = new NTList();

						gotoTable[187] = state;
						state = new NTList();

						gotoTable[188] = state;
						state = new NTList();

						gotoTable[189] = state;
						state = new NTList();

						gotoTable[190] = state;
						state = new NTList();

						gotoTable[191] = state;
						state = new NTList();

						gotoTable[192] = state;
						state = new NTList();

						gotoTable[193] = state;
						state = new NTList();

						gotoTable[194] = state;
						state = new NTList();

						gotoTable[195] = state;
						state = new NTList();

						gotoTable[196] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,242);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[197] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,243);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[198] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,244);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[199] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,245);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[200] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,246);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[201] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,247);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[202] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,248);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[203] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,249);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[204] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,250);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[205] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,251);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[206] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,252);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[207] = state;
						state = new NTList();

						gotoTable[208] = state;
						state = new NTList();

						gotoTable[209] = state;
						state = new NTList();

						gotoTable[210] = state;
						state = new NTList();

						gotoTable[211] = state;
						state = new NTList();

						gotoTable[212] = state;
						state = new NTList();

						gotoTable[213] = state;
						state = new NTList();

						gotoTable[214] = state;
						state = new NTList();

						gotoTable[215] = state;
						state = new NTList();

						gotoTable[216] = state;
						state = new NTList();

						gotoTable[217] = state;
						state = new NTList();

						gotoTable[218] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[219] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,104);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[220] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[221] = state;
						state = new NTList();

						gotoTable[222] = state;
						state = new NTList();

						gotoTable[223] = state;
						state = new NTList();

						gotoTable[224] = state;
						state = new NTList();

						gotoTable[225] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,261);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[226] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,262);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[227] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,263);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[228] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[229] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,193);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[230] = state;
						state = new NTList();

						gotoTable[231] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[232] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[233] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,269);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[234] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,270);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[235] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,271);
						state.Add(NonTerminalTypes.N_MathTextContent,52);
						gotoTable[236] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[237] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,193);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[238] = state;
						state = new NTList();

						gotoTable[239] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[240] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[241] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[242] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[243] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[244] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,195);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[245] = state;
						state = new NTList();

						gotoTable[246] = state;
						state = new NTList();

						gotoTable[247] = state;
						state = new NTList();

						gotoTable[248] = state;
						state = new NTList();

						gotoTable[249] = state;
						state = new NTList();

						gotoTable[250] = state;
						state = new NTList();

						gotoTable[251] = state;
						state = new NTList();

						gotoTable[252] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,280);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[253] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,136);
						state.Add(NonTerminalTypes.N_Equations,281);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[254] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_MathTextContent,282);
						gotoTable[255] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,283);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[256] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,284);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[257] = state;
						state = new NTList();

						gotoTable[258] = state;
						state = new NTList();

						gotoTable[259] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,285);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[260] = state;
						state = new NTList();

						gotoTable[261] = state;
						state = new NTList();

						gotoTable[262] = state;
						state = new NTList();

						gotoTable[263] = state;
						state = new NTList();

						gotoTable[264] = state;
						state = new NTList();

						gotoTable[265] = state;
						state = new NTList();

						gotoTable[266] = state;
						state = new NTList();

						gotoTable[267] = state;
						state = new NTList();

						gotoTable[268] = state;
						state = new NTList();

						gotoTable[269] = state;
						state = new NTList();

						gotoTable[270] = state;
						state = new NTList();

						gotoTable[271] = state;
						state = new NTList();

						gotoTable[272] = state;
						state = new NTList();

						gotoTable[273] = state;
						state = new NTList();

						gotoTable[274] = state;
						state = new NTList();

						gotoTable[275] = state;
						state = new NTList();

						gotoTable[276] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,288);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[277] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,289);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[278] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,290);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[279] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[280] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Equation,193);
						state.Add(NonTerminalTypes.N_Expression,138);
						state.Add(NonTerminalTypes.N_Expressions,137);
						state.Add(NonTerminalTypes.N_MathTextContent,139);
						gotoTable[281] = state;
						state = new NTList();

						gotoTable[282] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[283] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[284] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[285] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,297);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[286] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,298);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[287] = state;
						state = new NTList();

						gotoTable[288] = state;
						state = new NTList();

						gotoTable[289] = state;
						state = new NTList();

						gotoTable[290] = state;
						state = new NTList();

						gotoTable[291] = state;
						state = new NTList();

						gotoTable[292] = state;
						state = new NTList();

						gotoTable[293] = state;
						state = new NTList();

						gotoTable[294] = state;
						state = new NTList();

						gotoTable[295] = state;
						state = new NTList();

						gotoTable[296] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[297] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[298] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,41);
						state.Add(NonTerminalTypes.N_Expressions,302);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[299] = state;
						state = new NTList();

						gotoTable[300] = state;
						state = new NTList();

						gotoTable[301] = state;
						state = new NTList();

						state.Add(NonTerminalTypes.N_Expression,77);
						state.Add(NonTerminalTypes.N_MathTextContent,42);
						gotoTable[302] = state;
						state = new NTList();

						gotoTable[303] = state;
			
		}
        public int Goto(int state, NonTerminalTypes ntType)
        {
            NTList st = gotoTable[state];
            return st[ntType];
        }
        //used as double index [state][nonterminal index]

		private NTList[] gotoTable = new NTList[304];

	}
}