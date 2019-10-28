using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Edsac
{
    public partial class MainForm : Form
    {
        private Cpu edsac;
        private Boolean running;
        private uint[] longTank;
        private int lastDisassem;
        private int lastDump;
        private long[] displayLines;
        private uint lastScr;
        private uint lastOrder;
        private uint[] lastAccumulator;
        private uint[] lastMultiplier;
        private uint[] lastMultiplicand;
        
        public MainForm()
        {
            int i;
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            InitializeComponent();
            edsac = new Cpu();
            longTankTube.Image = new Bitmap(longTankTube.Width, longTankTube.Height);
            displayLines = new long[16];
            lastAccumulator = new uint[4];
            lastMultiplier = new uint[2];
            lastMultiplicand = new uint[2];
            scrTube.Image = new Bitmap(scrTube.Width, scrTube.Height);
            orderTube.Image = new Bitmap(orderTube.Width, orderTube.Height);
            accumulatorTube.Image = new Bitmap(accumulatorTube.Width, accumulatorTube.Height);
            multiplyTube.Image = new Bitmap(multiplyTube.Width, multiplyTube.Height);
            for (i = 0; i < 16; i++)
            {
                displayLines[i] = 0;
                displayLine(i);
            }
            ordersSelect.SelectedIndex = 0;
            tankSelector.SelectedIndex = 0;
            longTank = new uint[32];
            lastDisassem = 0;
            lastDump = 0;
            lastOrder = 0;
            lastScr = 0;
            for (i = 0; i < 4; i++) lastAccumulator[i] = 0;
            for (i = 0; i < 2; i++) lastMultiplier[i] = 0;
            for (i = 0; i < 2; i++) lastMultiplicand[i] = 0;
            displayAccumulator();
            displayScr();
            displayOrder();
            displayMultiply();
        }

        private void displayScr()
        {
            Graphics gc;
            Pen pen;
            int x, y;
            uint v;
            int o;
            if (showScr.Checked == false) return;
            gc = Graphics.FromImage(scrTube.Image);
            pen = new Pen(Color.Lime);
            v = lastScr;
            y = 7 * 12 + 5;
            o = 80;
            for (x = 10; x >= 0; x--)
            {
                pen.Width = 5;
                pen.Color = Color.Black;
                gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                if ((v & 1) == 1)
                {
                    pen.Width = 5;
                    pen.Color = Color.Lime;
                    gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                }
                else
                {
                    pen.Width = 1;
                    pen.Color = Color.Green;
                    gc.DrawLine(pen, o + x * 6 + 3, y + 3, o + x * 6 + 4, y + 3);
                }
                v >>= 1;
            }
            pen.Dispose();
            gc.Dispose();
            scrTube.Invalidate();
        }

        private void displayOrder()
        {
            Graphics gc;
            Pen pen;
            int x, y;
            uint v;
            int o;
            if (showOrder.Checked == false) return;
            gc = Graphics.FromImage(orderTube.Image);
            pen = new Pen(Color.Lime);
            v = lastOrder;
            y = 7 * 12 + 5;
            o = 60;
            for (x = 17; x >= 0; x--)
            {
                pen.Width = 5;
                pen.Color = Color.Black;
                gc.DrawLine(pen, o +x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                if ((v & 1) == 1)
                {
                    pen.Width = 5;
                    pen.Color = Color.Lime;
                    gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                }
                else
                {
                    pen.Width = 1;
                    pen.Color = Color.Green;
                    gc.DrawLine(pen, o + x * 6 + 3, y + 3, o + x * 6 + 4, y + 3);
                }
                v >>= 1;
            }
            pen.Dispose();
            gc.Dispose();
            orderTube.Invalidate();
        }

        private void displayAccumulator()
        {
            Graphics gc;
            Pen pen;
            int x, y;
            long v;
            int o;
            int i;
            if (showAccumulator.Checked == false) return;
            gc = Graphics.FromImage(accumulatorTube.Image);
            pen = new Pen(Color.Lime);
            o = 6;
            for (i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    v = lastAccumulator[0];
                    v <<= 18;
                    v += lastAccumulator[1];
                    y = 7 * 12 + 5;
                }
                else
                {
                    v = lastAccumulator[2];
                    v <<= 18;
                    v += lastAccumulator[3];
                    y = 9 * 12 + 5;
                }
                for (x = 34 + i; x >= 0; x--)
                {
                    pen.Width = 5;
                    pen.Color = Color.Black;
                    gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                    if ((v & 1) == 1)
                    {
                        pen.Width = 5;
                        pen.Color = Color.Lime;
                        gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                    }
                    else
                    {
                        pen.Width = 1;
                        pen.Color = Color.Green;
                        gc.DrawLine(pen, o + x * 6 + 3, y + 3, o + x * 6 + 4, y + 3);
                    }
                    v >>= 1;
                }
            }
            pen.Dispose();
            gc.Dispose();
            accumulatorTube.Invalidate();
        }

        private void displayMultiply()
        {
            Graphics gc;
            Pen pen;
            int x, y;
            long v;
            int o;
            int i;
            if (showMultiply.Checked == false) return;
            gc = Graphics.FromImage(multiplyTube.Image);
            pen = new Pen(Color.Lime);
            o = 0;
            for (i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    v = lastMultiplier[0];
                    v <<= 18;
                    v += lastMultiplier[1];
                    y = 7 * 12 + 5;
                }
                else
                {
                    v = lastMultiplicand[0];
                    v <<= 18;
                    v += lastMultiplicand[1];
                    y = 9 * 12 + 5;
                }
                for (x = 35; x >= 0; x--)
                {
                    pen.Width = 5;
                    pen.Color = Color.Black;
                    gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                    if ((v & 1) == 1)
                    {
                        pen.Width = 5;
                        pen.Color = Color.Lime;
                        gc.DrawLine(pen, o + x * 6 + 1, y + 3, o + x * 6 + 5, y + 3);
                    }
                    else
                    {
                        pen.Width = 1;
                        pen.Color = Color.Green;
                        gc.DrawLine(pen, o + x * 6 + 3, y + 3, o + x * 6 + 4, y + 3);
                    }
                    v >>= 1;
                }
            }
            pen.Dispose();
            gc.Dispose();
            multiplyTube.Invalidate();
        }

        private void displayLine(int line)
        {
            Graphics gc;
            Pen pen;
            int x, y;
            long v;
            int ox, oy;
            gc = Graphics.FromImage(longTankTube.Image);
            pen = new Pen(Color.Lime);
            v = displayLines[line];
            y = (15 - line) * 12 + 5;
            ox = 10; oy = 7;
            for (x = 34; x >= 0; x--)
            {
                pen.Width = 5;
                pen.Color = Color.Black;
                gc.DrawLine(pen, ox + x * 6 + 1, oy + y + 3, ox + x * 6 + 5, oy + y + 3);
                if ((v & 1) == 1)
                {
                    pen.Width = 5;
                    pen.Color = Color.Lime;
                    gc.DrawLine(pen, ox + x * 6 + 1, oy + y + 3, ox + x * 6 + 5, oy + y + 3);
                }
                else
                {
                    pen.Width = 1;
                    pen.Color = Color.Green;
                    gc.DrawLine(pen, ox + x * 6 + 3, oy + y + 3, ox + x * 6 + 4, oy + y + 3);
                }
                v >>= 1;
            }
            pen.Dispose();
            gc.Dispose();
            longTankTube.Invalidate();
        }

        private void print(byte b)
        {
            if (b == 255) return;
            if (b == 10) printerOutput.AppendText("\r\n");
            else printerOutput.AppendText(((char)b).ToString());
            printerOutput.SelectionStart = printerOutput.Text.Length;
            printerOutput.ScrollToCaret();
        }

        private void runProgram()
        {
            int i;
            byte b;
            long count;
            running = true;
            count = 0;
            edsac.clearStopped();
            stoppedLabel.Hide();
            runningLabel.Show();
            while (running)
            {
                b = edsac.step();
                if (traceEnabled.Checked) if (edsac.getDebug().Length > 0) trace.Text += edsac.getDebug();
                count++;
                print(b);
                if (edsac.getStopped()) running = false;
                updateDisplays();
                for (i = 0; i < breakpoints.Items.Count; i++)
                    if (edsac.getScr() == Convert.ToInt32(breakpoints.Items[i])) running = false;
                Application.DoEvents();
            }
            runningLabel.Hide();
            stoppedLabel.Show();
            countBox.Text = count.ToString();
            nextInstruction.Text = edsac.disassem(edsac.getScr(), edsac.getCurrentInst());
            scrOut.Text = edsac.getScr().ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (running) return;
            runProgram();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            running = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (running) return;
            running = false;
            edsac.reset();
            if (ordersSelect.SelectedIndex == 0) edsac.initialOrders1();
            else edsac.initialOrders2();
            edsac.setTape(tapeInput.Text);
            runProgram();
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            byte b;
            b = edsac.step();
            print(b);
            if (edsac.getDebug().Length > 0) trace.Text += edsac.getDebug();
            nextInstruction.Text = edsac.disassem(edsac.getScr(), edsac.getCurrentInst());
            updateDisplays();
            scrOut.Text = edsac.getScr().ToString();
        }

        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            printerOutput.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (running) return;
            edsac.reset();
            if (ordersSelect.SelectedIndex == 0) edsac.initialOrders1();
            else edsac.initialOrders2();
            edsac.setTape(tapeInput.Text);
            nextInstruction.Text = edsac.disassem(edsac.getScr(), edsac.getCurrentInst());
            updateDisplays();
        }

        private void clearTraceButton_Click(object sender, EventArgs e)
        {
            trace.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            StreamReader inFile;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inFile = new StreamReader(openFileDialog.FileName);
                tapeInput.Text = inFile.ReadToEnd();
                inFile.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outFile = new StreamWriter(saveFileDialog.FileName);
                outFile.Write(tapeInput.Text);
                outFile.Close();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            tapeInput.Text = "";
        }

        private void dial(uint n)
        {
            if (running) return;
            edsac.dial(n);
            runProgram();
        }

        private void dial0_Click(object sender, EventArgs e)
        {
            dial(10);
        }

        private void dial1_Click(object sender, EventArgs e)
        {
            dial(1);
        }

        private void dial2_Click(object sender, EventArgs e)
        {
            dial(2);
        }

        private void dial3_Click(object sender, EventArgs e)
        {
            dial(3);
        }

        private void dial4_Click(object sender, EventArgs e)
        {
            dial(4);
        }

        private void dial5_Click(object sender, EventArgs e)
        {
            dial(5);
        }

        private void dial6_Click(object sender, EventArgs e)
        {
            dial(6);
        }

        private void dial7_Click(object sender, EventArgs e)
        {
            dial(7);
        }

        private void dial8_Click(object sender, EventArgs e)
        {
            dial(8);
        }

        private void dial9_Click(object sender, EventArgs e)
        {
            dial(9);
        }

        private String convertToBinary(uint n)
        {
            String ret;
            int i;
            ret = "";
            for (i = 0; i < 18; i++)
            {
                if ((n & 1) == 1) ret = "*" + ret; else ret = "." + ret;
                n >>= 1;
            }
            return ret;
        }

        private void refreshTank()
        {
            int i;
            uint[] mem;
            int tank = tankSelector.SelectedIndex;
            long tmp;
            mem = edsac.getMemory();
            for (i = 15; i >=0; i--)
            {
                tmp = mem[i * 2 + 1 + tank * 32];
                tmp <<= 18;
                tmp += (long)mem[i * 2 + tank * 32];
                if (tmp != displayLines[i])
                {
                    displayLines[i] = mem[i * 2 + 1 + tank * 32];
                    displayLines[i] <<= 18;
                    displayLines[i] += (long)mem[i * 2 + tank * 32];
                    displayLine(i);
                }
//                tankDisplay.Text += convertToBinary(mem[i*2  + 1 + tank * 32]);
//                tankDisplay.Text += convertToBinary(mem[i * 2 + tank * 32]);
//                if (i != 0) tankDisplay.Text += "\r\n";
            }
        }

        private void tankRefreshButton_Click(object sender, EventArgs e)
        {
            refreshTank();
        }

        private void tankSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTank();
        }

        private void updateDisplays()
        {
            Boolean flag;
            int start;
            int i;
            uint[] mem;
            mem = edsac.getMemory();
            start = tankSelector.SelectedIndex * 32;
            flag = false;
            for (i = 0; i < 32; i++)
            {
                if (mem[start + i] != longTank[i]) flag = true;
                longTank[i] = mem[start + i];
            }
            if (flag) {
                refreshTank();
            }
            if (edsac.getScr() != lastScr)
            {
                lastScr = edsac.getScr();
                displayScr();
            }
            if (edsac.getOrder() != lastOrder)
            {
                lastOrder = edsac.getOrder();
                displayOrder();
            }
            if (edsac.getAccumulator(0) != lastAccumulator[0] ||
                edsac.getAccumulator(1) != lastAccumulator[1] ||
                edsac.getAccumulator(2) != lastAccumulator[2] ||
                edsac.getAccumulator(3) != lastAccumulator[3])
            {
                for (i = 0; i < 4; i++) lastAccumulator[i] = edsac.getAccumulator(i);
                displayAccumulator();
            }
            if (edsac.getMultiplier(0) != lastMultiplier[0] ||
                edsac.getMultiplier(1) != lastMultiplier[1] ||
                edsac.getMultiplicand(0) != lastMultiplicand[0] ||
                edsac.getMultiplicand(1) != lastMultiplicand[1])
            {
                for (i = 0; i < 2; i++) lastMultiplier[i] = edsac.getMultiplier(i);
                for (i = 0; i < 2; i++) lastMultiplicand[i] = edsac.getMultiplicand(i);
                displayMultiply();
            }
        }

        private void newBreakpointButton_Click(object sender, EventArgs e)
        {
            int i;
            int bp;
            Boolean flag;
            flag = true;
            bp = Convert.ToInt16(newBreakpoint.Text);
            for (i = 0; i < breakpoints.Items.Count; i++)
            {
                if (bp == Convert.ToInt16(breakpoints.Items[i])) flag = false;
            }
            if (flag)
            {
                breakpoints.Items.Add(newBreakpoint.Text);
            }
        }

        private void deleteBreakpointButton_Click(object sender, EventArgs e)
        {
            int i;
            i = breakpoints.SelectedIndex;
            if (i >= 0) breakpoints.Items.RemoveAt(i);
        }

        private void disassem(int st,int en) {
            uint[] mem;
            int i;
            String cmd;
            mem = edsac.getMemory();
            disassembly.Text = "";
            if (en > 1023)
            {
                en = 1023;
                st = en - 30;
            }
            for (i = st; i < en; i++)
            {
                cmd = edsac.disassem((uint)i, mem[i]);
                disassembly.Text += cmd + "\r\n";
            }
            lastDisassem = st;
        }

        private void disCsrButton_Click(object sender, EventArgs e)
        {
            uint scr;
            int st, en;
            scr = edsac.getScr();
            st = (int)scr;
            en = st + 30;
            disassem(st, en);
        }

        private void disAddressButton_Click(object sender, EventArgs e)
        {
            uint scr;
            int st, en;
            scr = (uint)Convert.ToInt32(disFrom.Text);
            st = (int)scr;
            en = st + 30;
            disassem(st, en);
        }

        private void disNextButton_Click(object sender, EventArgs e)
        {
            int st, en;
            st = lastDisassem + 30;
            en = st + 30;
            disassem(st, en);
        }

        private void disPrevButton_Click(object sender, EventArgs e)
        {
            int st, en;
            st = lastDisassem - 30;
            if (st < 0) st = 0;
            en = st + 30;
            disassem(st, en);
        }

        private void disRefreshButton_Click(object sender, EventArgs e)
        {
            int st, en;
            st = lastDisassem;
            en = st + 30;
            disassem(st, en);
        }

        private String inBinary(uint n)
        {
            int i;
            String ret = "";
            for (i = 0; i < 18; i++)
            {
                ret = (((n & 1) == 1) ? "1" : "0" ) + ret;
                n >>= 1;
                if (i == 0 || i == 10 || i == 11 || i == 16) ret = " " + ret;
            }
            return ret;
        }

        private void dumpMemory(uint st)
        {
            uint en;
            String cmd;
            int i;
            uint[] mem;
            mem = edsac.getMemory();
            en = st + 30;
            if (en > 1023)
            {
                en = 1024;
                st = en - 30;
            }
            memoryDump.Text = "";
            for (i = (int)st; i < en; i++)
            {
                cmd = edsac.disassem((uint)i, mem[i]);
                memoryDump.Text += cmd + " ";
                memoryDump.Text += String.Format("{0:X5}     ", mem[i]);
                memoryDump.Text += inBinary(mem[i]);
                memoryDump.Text += "\r\n";
            }
            lastDump = (int)st;
        }

        private void memScrButton_Click(object sender, EventArgs e)
        {
            dumpMemory(edsac.getScr());
        }

        private void memNextButton_Click(object sender, EventArgs e)
        {
            dumpMemory((uint)(lastDump + 30));
        }

        private void memPrevButton_Click(object sender, EventArgs e)
        {
            lastDump = (lastDump >= 30) ? lastDump - 30 : 0;
            dumpMemory((uint)lastDump);
        }

        private void memRefreshButton_Click(object sender, EventArgs e)
        {
            dumpMemory((uint)lastDump);
        }

        private void memAddressButton_Click(object sender, EventArgs e)
        {
            dumpMemory((uint)Convert.ToInt16(memAddress.Text));
        }

    }
}
