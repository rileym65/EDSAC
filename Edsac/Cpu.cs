using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edsac
{
    class Cpu
    {
        private uint[] acc;
        private uint[] multiplier;
        private uint[] multiplicand;
        private uint[] mem;
        private uint order;
        private uint scr;
        private Boolean stopCommand;
        private uint lastOutput;
        private String tape;
        private int tapePos;
        private Boolean tapeRemark;
        private byte output;
        private byte shiftMode;
        private String debug;
        private int initialOrders;


        public Cpu()
        {
            acc = new uint[4];
            multiplier = new uint[2];
            multiplicand = new uint[2];
            mem = new uint[1024];
            reset();
            initialOrders = 0;
        }

        public uint getScr()
        {
            return scr;
        }

        public uint getOrder()
        {
            return order;
        }

        public uint getAccumulator(int n)
        {
            return acc[n];
        }

        public uint getMultiplier(int n)
        {
            return multiplier[n];
        }

        public uint getMultiplicand(int n)
        {
            return multiplicand[n];
        }

        public uint getCurrentInst()
        {
            return mem[scr];
        }

        public void reset()
        {
            int i;
            for (i = 0; i < 1024; i++) mem[i] = 0;
            for (i = 0; i < 4; i++) acc[i] = 0;
            scr = 0;
            shiftMode = 0;
            stopCommand = false;
            debug = "";
        }

        public uint[] getMemory()
        {
            return mem;
        }

        public void dial(uint n)
        {
            acc[0] = n << 1;
            acc[1] = 0;
            acc[2] = 0;
            acc[3] = 0;
        }

        public void clearStopped()
        {
            stopCommand = false;
        }

        public Boolean getStopped()
        {
            return stopCommand;
        }

        public String getDebug()
        {
            return debug;
        }

        public void initialOrders1()
        {
            mem[00] = 0x05000;       /* [00] 00101 0 0000000000 0  T    S */
            mem[01] = 0x15004;       /* [01] 10101 0 0000000010 0  H  2 S */
            mem[02] = 0x05000;       /* [02] 00101 0 0000000000 0  T    S */
            mem[03] = 0x0300c;       /* [03] 00011 0 0000000110 0  E  6 S */
            mem[04] = 0x00002;       /* [04] 00000 0 0000000001 0  P  1 S */
            mem[05] = 0x0000a;       /* [05] 00000 0 0000000101 0  P  5 S */
            mem[06] = 0x05000;       /* [06] 00101 0 0000000000 0  T    S */
            mem[07] = 0x08000;       /* [07] 01000 0 0000000000 0  I    S */
            mem[08] = 0x1c000;       /* [08] 11100 0 0000000000 0  A    S */
            mem[09] = 0x04020;       /* [09] 00100 0 0000010000 0  R 16 S */
            mem[10] = 0x05001;       /* [10] 00101 0 0000000000 1  T    L */
            mem[11] = 0x08004;       /* [11] 01000 0 0000000010 0  I  2 S */
            mem[12] = 0x1c004;       /* [12] 11100 0 0000000010 0  A  2 S */
            mem[13] = 0x0c00a;       /* [13] 01100 0 0000000101 0  S  5 S */
            mem[14] = 0x0302a;       /* [14] 00011 0 0000010101 0  E 21 S */
            mem[15] = 0x05006;       /* [15] 00101 0 0000000011 0  T  3 S */
            mem[16] = 0x1f002;       /* [16] 11111 0 0000000001 0  V  1 S */
            mem[17] = 0x19010;       /* [17] 11001 0 0000001000 0  L  8 S */
            mem[18] = 0x1c004;       /* [18] 11100 0 0000000010 0  A  2 S */
            mem[19] = 0x05002;       /* [19] 00101 0 0000000001 0  T  1 S */
            mem[20] = 0x03016;       /* [20] 00011 0 0000001011 0  E 11 S */
            mem[21] = 0x04008;       /* [21] 00100 0 0000000100 0  R  4 S */
            mem[22] = 0x1c002;       /* [22] 11100 0 0000000001 0  A  1 S */
            mem[23] = 0x19001;       /* [23] 11001 0 0000000000 1  L    L */
            mem[24] = 0x1c000;       /* [24] 11100 0 0000000000 0  A    S */
            mem[25] = 0x0503e;       /* [25] 00101 0 0000011111 0  T 31 S */
            mem[26] = 0x1c032;       /* [26] 11100 0 0000011001 0  A 25 S */
            mem[27] = 0x1c008;       /* [27] 11100 0 0000000100 0  A  4 S */
            mem[28] = 0x07032;       /* [28] 00111 0 0000011001 0  U 25 S */
            mem[29] = 0x0c03e;       /* [29] 01100 0 0000011111 0  S 31 S */
            mem[30] = 0x1b00c;       /* [30] 11011 0 0000000110 0  G  6 S */
            initialOrders = 1;
        }

        public void initialOrders2()
        {
            mem[00] = 0x05000;     /* 00101 0 0000000000 0  [ 0]   T    F */
            mem[01] = 0x03028;     /* 00011 0 0000010100 0  [ 1]   E 20 F */
            mem[02] = 0x00002;     /* 00000 0 0000000001 0  [ 2]   P  1 F */
            mem[03] = 0x07004;     /* 00111 0 0000000010 0  [ 3]   U  2 F */
            mem[04] = 0x1c04e;     /* 11100 0 0000100111 0  [ 4]   A 39 F */
            mem[05] = 0x04008;     /* 00100 0 0000000100 0  [ 5]   R  4 F */
            mem[06] = 0x1f000;     /* 11111 0 0000000000 0  [ 6]   V    F */
            mem[07] = 0x19010;     /* 11001 0 0000001000 0  [ 7]   L  8 F */
            mem[08] = 0x05000;     /* 00101 0 0000000000 0  [ 8]   T    F */
            mem[09] = 0x08002;     /* 01000 0 0000000001 0  [ 9]   I  1 F */
            mem[10] = 0x1c002;     /* 11100 0 0000000001 0  [10]   A  1 F */
            mem[11] = 0x0c04e;     /* 01100 0 0000100111 0  [11]   S 39 F */
            mem[12] = 0x1b008;     /* 11011 0 0000000100 0  [12]   G  4 F */
            mem[13] = 0x19001;     /* 11001 0 0000000000 1  [13]   L    D */
            mem[14] = 0x0c04e;     /* 01100 0 0000100111 0  [14]   S 39 F */
            mem[15] = 0x03022;     /* 00011 0 0000010001 0  [15]   E 17 F */
            mem[16] = 0x0c00e;     /* 01100 0 0000000111 0  [16]   S  7 F */
            mem[17] = 0x1c046;     /* 11100 0 0000100011 0  [17]   A 35 F */
            mem[18] = 0x05028;     /* 00101 0 0000010100 0  [18]   T 20 F */
            mem[19] = 0x1c000;     /* 11100 0 0000000000 0  [19]   A    F */
            mem[20] = 0x15010;     /* 10101 0 0000001000 0  [20]   H  8 F */
            mem[21] = 0x1c050;     /* 11100 0 0000101000 0  [21]   A 40 F */
            mem[22] = 0x05056;     /* 00101 0 0000101011 0  [22]   T 43 F */
            mem[23] = 0x1c02c;     /* 11100 0 0000010110 0  [23]   A 22 F */
            mem[24] = 0x1c004;     /* 11100 0 0000000010 0  [24]   A  2 F */
            mem[25] = 0x0502c;     /* 00101 0 0000010110 0  [25]   T 22 F */
            mem[26] = 0x03044;     /* 00011 0 0000100010 0  [26]   E 34 F */
            mem[27] = 0x1c056;     /* 11100 0 0000101011 0  [27]   A 43 F */
            mem[28] = 0x03010;     /* 00011 0 0000001000 0  [28]   E  8 F */
            mem[29] = 0x1c054;     /* 11100 0 0000101010 0  [29]   A 42 F */
            mem[30] = 0x1c050;     /* 11100 0 0000101000 0  [30]   A 40 F */
            mem[31] = 0x03032;     /* 00011 0 0000011001 0  [31]   E 25 F */
            mem[32] = 0x1c02c;     /* 11100 0 0000010110 0  [32]   A 22 F */
            mem[33] = 0x05054;     /* 00101 0 0000101010 0  [33]   T 42 F */
            mem[34] = 0x08051;     /* 01000 0 0000101000 1  [34]   I 40 D */
            mem[35] = 0x1c051;     /* 11100 0 0000101000 1  [35]   A 40 D */
            mem[36] = 0x04020;     /* 00100 0 0000010000 0  [36]   R 16 F */
            mem[37] = 0x05051;     /* 00101 0 0000101000 1  [37]   T 40 D */
            mem[38] = 0x03010;     /* 00011 0 0000001000 0  [38]   E  8 F */
            mem[39] = 0x0000b;     /* 00000 0 0000000101 1  [39]   P  5 D */
            mem[40] = 0x00001;     /* 00000 0 0000000000 1  [40]   P    D */
            initialOrders = 2;
        }

        public String disassem(uint scr, uint order)
        {
            String ret = "";
            ret += String.Format("[{0:D3}] ", scr);
            switch ((order >> 12) & 0x1ff)
            {
                case 0: ret += "P"; break;
                case 1: ret += "Q"; break;
                case 2: ret += "W"; break;
                case 3: ret += "E"; break;
                case 4: ret += "R"; break;
                case 5: ret += "T"; break;
                case 6: ret += "Y"; break;
                case 7: ret += "U"; break;
                case 8: ret += "I"; break;
                case 9: ret += "O"; break;
                case 10: ret += "J"; break;
                case 11: ret += "#"; break;
                case 12: ret += "S"; break;
                case 13: ret += "Z"; break;
                case 14: ret += "K"; break;
                case 15: ret += "*"; break;
                case 16: ret += "."; break;
                case 17: ret += "F"; break;
                case 18: ret += "@"; break;
                case 19: ret += "D"; break;
                case 20: ret += "!"; break;
                case 21: ret += "H"; break;
                case 22: ret += "N"; break;
                case 23: ret += "M"; break;
                case 24: ret += "&"; break;
                case 25: ret += "L"; break;
                case 26: ret += "X"; break;
                case 27: ret += "G"; break;
                case 28: ret += "A"; break;
                case 29: ret += "B"; break;
                case 30: ret += "C"; break;
                case 31: ret += "V"; break;
                default: ret += "-"; break;
            }
            ret += " ";
            if (((order >> 1) & 0x7ff) > 0) ret += String.Format("{0:D5}", (order >> 1) & 0x7ff);
            else ret += "     ";
            if (initialOrders == 1) { if ((order & 1) == 1) ret += " L"; else ret += " S"; }
            if (initialOrders == 2) { if ((order & 1) == 1) ret += " D"; else ret += " F"; }
            ret += "     ";
            return ret;
        }


        uint getShiftCount(uint a)
        {
            uint r;
            r = 1;
            while (r < 17 && ((a & 1) != 1)) {
                r++;
                a >>= 1;
            }
            return r;
        }

        void twosComp(uint[] number, int num)
        {
            int i;
            for (i = 0; i < num; i++) number[i] = ((~number[i]) & 0x3ffff);
            number[num - 1]++;
            for (i = num - 2; i >= 0; i--)
            {
                if ((number[i + 1] & 0x40000) == 0x40000)
                {
                    number[i]++;
                    number[i + 1] &= 0x3ffff;
                }
            }
            number[0] &= 0x1ffff;
        }

        void lShift(uint[] number, int num)
        {
            uint c;
            int i;
            c = 0;
            for (i = num - 1; i >= 0; i--)
            {
                number[i] = (number[i] << 1) + c;
                c = (uint)(((number[i] & 0x40000) == 0x40000) ? 1 : 0);
                number[i] &= 0x3ffff;
            }
            number[0] &= 0x1ffff;
        }

        void rShift(uint[] number, int num)
        {
            uint c;
            uint tc;
            int i;
            c = 0;
            if ((number[0] & 0x10000) == 0x10000) number[0] |= 0x20000;
            for (i = 0; i < num; i++)
            {
                tc = (uint)(((number[i] & 1) == 1) ? 0x20000 : 0);
                number[i] = (number[i] >> 1) + c;
                c = tc;
                number[i] &= 0x3ffff;
            }
            number[0] &= 0x1ffff;
        }

        void mbAdd(uint[] value, int words)
        {
            uint c;
            int i;
            c = 0;
            for (i = words - 1; i >= 0; i--)
            {
                acc[i] += (value[i] + c);
                c = (uint)(((acc[i] & 0x40000) == 0x40000) ? 1 : 0);
                acc[i] &= 0x3ffff;
            }
            acc[0] &= 0x1ffff;
        }

        void mbSub(uint[] value, int words)
        {
            uint[] tmp = new uint[8];
            int i;
            for (i = 0; i < words; i++) tmp[i] = value[i];
            twosComp(tmp, words);
            mbAdd(tmp, words);
        }

        byte prepForMul(uint[] number)
        {
            if ((number[2] & 0x10000) == 0x10000)
            {
                number[0] = 0xffffffff;
                number[1] = 0xffffffff;
                number[2] |= 0xffff0000;
                twosComp(number, 4);
                return 1;
            }
            return 0;
        }

        void doMul(char mode)
        {
            byte sign;
            uint[] tmp = new uint[4];
            uint[] a = new uint[4];
            a[3] = multiplicand[1];
            a[2] = multiplicand[0];
            a[1] = 0;
            a[0] = 0;
            tmp[3] = multiplier[1];
            tmp[2] = multiplier[0];
            tmp[1] = 0;
            tmp[0] = 0;
            sign = 0;
            sign ^= prepForMul(tmp);
            sign ^= prepForMul(a);
            lShift(tmp, 4);
            lShift(tmp, 4);
            if (sign == 1) mode = (mode == 'A') ? 'S' : 'A';
            while ((a[0] | a[1] | a[2] | a[3]) != 0)
            {
                if ((a[3] & 1) == 1)
                {
                    if (mode == 'A') mbAdd(tmp, 4); else mbSub(tmp, 4);
                }
                lShift(tmp, 4);
                rShift(a, 4);
            }
        }

        void sMul(uint a, char mode)
        {
            multiplicand[0] = a;
            multiplicand[1] = 0;
            doMul(mode);
        }

        void lMul(UInt32 address, char mode)
        {
            multiplicand[1] = mem[address];
            multiplicand[0] = mem[address + 1];
            doMul(mode);
        }

        void and()
        {
            uint[] tmp = new uint[2];
            tmp[0] = multiplier[0] & multiplicand[0];
            tmp[1] = multiplier[1] & multiplicand[1];
            mbAdd(tmp, 2);
        }

        void roundAcc()
        {
            uint[] tmp = new uint[4];
            tmp[0] = 0;
            tmp[1] = 0;
            tmp[2] = 0x20000;
            tmp[3] = 0;
            mbAdd(tmp, 4);
        }

        public byte step()
        {
            int i;
            uint b;
            Boolean longInst;
            uint address;
            uint[] tmp = new uint[2];
            debug = "";
            order = mem[scr];
            debug += disassem(scr, order);
            scr++;
            address = (order >> 1) & 0x3ff;
            longInst = ((order & 1) == 1) ? true : false;
            output = 255;
            switch (order >> 12)
            {
                case 28: if (longInst)                     /* A - Add */
                    {
                        address &= 0x1fffe;
                        debug += String.Format("{0:X5} {1:X5} + {2:X5} {3:X5}", acc[0], acc[1], mem[address+1], mem[address]);
                        tmp[0] = mem[address + 1];
                        tmp[1] = mem[address];
                        mbAdd(tmp, 2);
                        debug += String.Format(" = {0:X5} {1:X5}", acc[0], acc[1]);
                    }
                    else
                    {
                        debug += String.Format("{0:X5} + {1:X5}", acc[0], mem[address]);
                        tmp[0] = mem[address];
                        mbAdd(tmp, 1);
                        debug += String.Format(" = {0:X5}", acc[0]);
                    }
                    break;
                case 12: if (longInst)                     /* S - Subtract */
                    {
                        address &= 0x1fffe;
                        debug += String.Format("{0:X5} {1:X5} - {2:X5} {3:X5}", acc[0], acc[1], mem[address + 1], mem[address]);
                        tmp[0] = mem[address + 1];
                        tmp[1] = mem[address];
                        mbSub(tmp, 2);
                        debug += String.Format(" = {0:X5} {1:X5}", acc[0], acc[1]);
                    }
                    else
                    {
                        debug += String.Format("{0:X5} - {1:X5}", acc[0], mem[address]);
                        tmp[0] = mem[address];
                        mbSub(tmp, 1);
                        debug += String.Format(" = {0:X5}", acc[0]);
                    }
                    break;
                case 21: if (longInst)                     /* H - Load Multiplier */
                    {
                        address &= 0x1fffe;
                        multiplier[0] = mem[address + 1];
                        multiplier[1] = mem[address];
                        debug += String.Format("R = {0:X5} {1:X5}", multiplier[0], multiplier[1]);
                    }
                    else
                    {
                        multiplier[0] = mem[address];
                        multiplier[1] = 0;
                        debug += String.Format("R = {0:X5} {1:X5}", multiplier[0], multiplier[1]);
                    }
                    break;
                case 31: if (longInst)                     /* V - Multiply */
                    {
                        address &= 0x1fffe;
                        debug += String.Format("{0:X5} {1:X5} * {2:X5} {3:X5}", multiplier[0], multiplier[1], mem[address + 1], mem[address]);
                        lMul(address, 'A');
                        debug += String.Format(" = {0:X5} {1:X5} {2:X5} {3:X5}", acc[0], acc[1], acc[2], acc[3]);
                    }
                    else
                    {
                        debug += String.Format("{0:X5} * {1:X5}", multiplier[0], mem[address]);
                        sMul(mem[address], 'A');
                        debug += String.Format(" = {0:X5} {1:X5}", acc[0], acc[1]);
                    }
                    break;
                case 22: if (longInst)                     /* N - Multiply */
                    {
                        address &= 0x1fffe;
                        debug += String.Format("{0:X5} {1:X5} * {2:X5} {3:X5}", multiplier[0], multiplier[1], mem[address + 1], mem[address]);
                        lMul(address, 'S');
                        debug += String.Format(" = {0:X5} {1:X5} {2:X5} {3:X5}", acc[0], acc[1], acc[2], acc[3]);
                    }
                    else
                    {
                        debug += String.Format("{0:X5} * {1:X5}", multiplier[0], mem[address]);
                        sMul(mem[address], 'S');
                        debug += String.Format(" = {0:X5} {1:X5}", acc[0], acc[1]);
                    }
                    break;
                case 5: if (longInst)                      /* T - Transfer/Clear */
                    {
                        address &= 0x1fffe;
                        mem[address] = acc[1];
                        mem[address + 1] = acc[0];
                        debug += String.Format("[{0:D}]={1:X} [{2:D}]={3:X}",address+1,acc[0],address,acc[1]);
                    }
                    else
                    {
                        mem[address] = acc[0];
                        debug += String.Format("[{0:D}]={1:X}",address, acc[0]);
                    }
                    for (i = 0; i < 4; i++) acc[i] = 0;
                    break;
                case 7: if (longInst)                      /* U - Transfer */
                    {
                        address &= 0x1fffe;
                        mem[address] = acc[1];
                        mem[address + 1] = acc[0];
                        debug += String.Format("[{0:D}]={1:X} [{2:D}]={3:X}", address + 1, acc[0], address, acc[1]);
                    }
                    else
                    {
                        mem[address] = acc[0];
                        debug += String.Format("[{0:D}]={1:X}", address, acc[0]);
                    }
                    break;
                case 30: if (longInst)                     /* C - Collate */
                    {
                        address &= 0x1fffe;
                        multiplicand[0] = mem[address + 1];
                        multiplicand[1] = mem[address];
                        and();
                    }
                    else
                    {
                        multiplicand[0] = mem[address];
                        multiplicand[1] = 0;
                        and();
                    }
                    break;
                case 4: b = getShiftCount(order);          /* R - Shift Right */
                    debug += String.Format("{0:X5} {1:X5} {2:X5} {3:X5} >> {4:D} = ", acc[0], acc[1], acc[2], acc[3], b);
                    for (i = 0; i < b; i++)
                        rShift(acc, 4);
                    debug += String.Format("{0:X5} {1:X5} {2:X5} {3:X5}", acc[0], acc[1], acc[2], acc[3]);
                    break;
                case 25: b = getShiftCount(order);         /* L - Shift Left */
                    debug += String.Format("{0:X5} {1:X5} {2:X5} {3:X5} << {4:D} = ", acc[0], acc[1], acc[2], acc[3], b);
                    for (i = 0; i < b; i++)
                        lShift(acc, 4);
                    debug += String.Format("{0:X5} {1:X5} {2:X5} {3:X5}", acc[0], acc[1], acc[2], acc[3]);
                    break;
                case 3: if ((acc[0] & 0x10000) == 0)       /* E - Branch Positive */
                    {
                        scr = address;
                        debug += String.Format("Positive, Jumping --> {0:D}", address);
                    }
                    else debug += String.Format("Negative, No jump");
                    break;
                case 27: if ((acc[0] & 0x10000) != 0)      /* G - Branch Negative */
                    {
                        scr = address;
                        debug += String.Format("Negative, Jumping --> {0:D}", address);
                    }
                    else debug += String.Format("Positive, No jump");
                    break;
                case 8: b = readTape();                    /* I - Input */
                    if (b != 255)
                    {
                        if ((order & 1) == 1) address &= 0x1fffe;
                        mem[address + (order & 1)] = (uint)b;
                        if ((order & 1) == 1) mem[address] = 0;
                        debug += String.Format("[{0:D}]={1:X}", address + (order & 1), b);
                    }
                    break;
                case 9: b = (mem[address] >> 12) & 0x1ff;  /* O - Output */
                    print(b);
                    lastOutput = b;
                    break;
                case 17:                                   /* F - Verify */
                    mem[address] = lastOutput << 12;
                    break;
                case 26:                                   /* X - Nop */
                    break;
                case 6: roundAcc();                        /* Y - Extend ABC */
                    break;
                case 13: stopCommand = true;               /* Z - Stop */
                    break;
                default: stopCommand = true;
                    break;


            }
            debug += "\r\n";
            return output;
        }

        /* ********************************************************* */
        /* ***** Next section implements the paper tape reader ***** */
        /* ********************************************************* */
        private byte translateInput(byte i)
        {
            if (i >= 'a' && i <= 'z') i -= 32;
            switch ((char)i)
            {
                case 'P': return 0;
                case 'Q': return 1;
                case 'W': return 2;
                case 'E': return 3;
                case 'R': return 4;
                case 'T': return 5;
                case 'Y': return 6;
                case 'U': return 7;
                case 'I': return 8;
                case 'O': return 9;
                case 'J': return 10;
                case '#': return 11;
                case 'S': return 12;
                case 'Z': return 13;
                case 'K': return 14;
                case '*': return 15;
                case '.': return 16;
                case 'F': return 17;
                case '@': return 18;
                case 'D': return 19;
                case '!': return 20;
                case 'H': return 21;
                case 'N': return 22;
                case 'M': return 23;
                case '&': return 24;
                case 'L': return 25;
                case 'X': return 26;
                case 'G': return 27;
                case 'A': return 28;
                case 'B': return 29;
                case 'C': return 30;
                case 'V': return 31;
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
            }
            return 255;
        }

        byte readNext()
        {
            byte r;
            if (tapePos == tape.Length) return 255;
            r = (byte)tape[tapePos];
            tapePos++;
            return r;
        }

        byte readTape()
        {
            byte i;
            Boolean flag;
            flag = false;
            i = 255;
            while (flag == false)
            {
                i = readNext();
                if (i == 255) return 255;
                if (i == '[') tapeRemark = true;
                else if (i == ']') tapeRemark = false;
                else if (tapeRemark == false)
                {
                    i = translateInput(i);
                    if (i != 255) flag = true;
                }

            }
            if (flag) return i;
            return 255;
        }

        public void setTape(String t) {
            tape = t;
            tapePos = 0;
            tapeRemark = false;
        }

        /* ******************************************************* */
        /* ***** Next section of code implements the printer ***** */
        /* ******************************************************* */

        char translateOutput(byte i)
        {
            if (shiftMode == 0)
            {
                switch (i)
                {
                    case 0: return 'P';
                    case 1: return 'Q';
                    case 2: return 'W';
                    case 3: return 'E';
                    case 4: return 'R';
                    case 5: return 'T';
                    case 6: return 'Y';
                    case 7: return 'U';
                    case 8: return 'I';
                    case 9: return 'O';
                    case 10: return 'J';
                    case 11: return (char)201;
                    case 12: return 'S';
                    case 13: return 'Z';
                    case 14: return 'K';
                    case 15: return (char)200;
                    case 16: return ' ';
                    case 17: return 'F';
                    case 18: return (char)13;
                    case 19: return 'D';
                    case 20: return ' ';
                    case 21: return 'H';
                    case 22: return 'N';
                    case 23: return 'M';
                    case 24: return (char)10;
                    case 25: return 'L';
                    case 26: return 'X';
                    case 27: return 'G';
                    case 28: return 'A';
                    case 29: return 'B';
                    case 30: return 'C';
                    case 31: return 'V';
                }
                return ' ';
            }
            switch (i)
            {
                case 0: return '0';
                case 1: return '1';
                case 2: return '2';
                case 3: return '3';
                case 4: return '4';
                case 5: return '5';
                case 6: return '6';
                case 7: return '7';
                case 8: return '8';
                case 9: return '9';
                case 10: return ' ';
                case 11: return (char)201;
                case 12: return '"';
                case 13: return '+';
                case 14: return '(';
                case 15: return (char)200;
                case 16: return ' ';
                case 17: return '$';
                case 18: return (char)13;
                case 19: return ';';
                case 20: return ' ';
                case 21: return 'l';
                case 22: return ',';
                case 23: return '.';
                case 24: return (char)10;
                case 25: return ')';
                case 26: return '/';
                case 27: return '#';
                case 28: return '-';
                case 29: return '?';
                case 30: return ':';
                case 31: return '=';
            }
            return ' ';
        }


        void print(uint uo)
        {
            byte o;
            o = (byte)uo;
            o = (byte)translateOutput(o);
            if (o == 200) shiftMode = 0;
            else if (o == 201) shiftMode = 1;
            else output = o;
        }

    
    
    }
}
