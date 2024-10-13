using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static byte a;
        public static byte b;
        public const int sizeOfChar = 16;
        public static bool ov;
        public static bool c;

        static int[] bitMasA = new int[16];
        static int[] bitMasB = new int[16];

        static string strBinA = "";
        static string strBinB = "";

        //static int MultyplyByShiftnSum(int a, int b)
        //{
        //    int result = 0;
        //    while (b != 0)
        //    {
        //        if ((b & 0x1) == 0x1)
        //            result += a;

        //        b >>= 1;
        //        a <<= 1;
        //    }
        //    return result;
        //}
#region one
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void firstInput_TextChanged(object sender, EventArgs e)
        {
            if (firstInput.Text != "")
            {
                foreach (int i in bitMasA)
                    bitMasA[i] = 0;

                int num = Convert.ToInt32(firstInput.Text);
                string str1 = Convert.ToString(num, 2);
                int numbin = Convert.ToInt32(str1);

                int j = 15;
                while (numbin > 0)
                {
                    bitMasA[j] = numbin % 10;
                    numbin /= 10;
                    j--;
                }

                strBinA = "";
                for (int k = 0; k < 16; k++)
                {
                    strBinA += bitMasA[k];
                }

                firstOutput.Text = strBinA;
            }
            else
            {
                firstOutput.Text = " ";
            }
        }

        private void secondInput_TextChanged(object sender, EventArgs e)
        {
            if (secondInput.Text != "")
            {
                foreach (int i in bitMasB)
                    bitMasB[i] = 0;

                int num = Convert.ToInt32(secondInput.Text);
                string str1 = Convert.ToString(num, 2);
                int numbin = Convert.ToInt32(str1);

                int j = 15;
                while (numbin > 0)
                {
                    bitMasB[j] = numbin % 10;
                    numbin /= 10;
                    j--;
                }

                strBinB = "";
                for (int k = 0; k < 16; k++)
                {
                    strBinB += bitMasB[k];
                }

                secondOutput.Text = strBinB;
            }
            else
            {
                secondOutput.Text = " ";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firstInput.Text = "";
            firstOutput.Text = "";
            secondInput.Text = "";
            secondOutput.Text = "";
            resultOutput.Text = "";
            flagsOutput.Text = "";
            foreach (int j in bitMasA)
                bitMasA[j] = 0;
            foreach (int j in bitMasB)
                bitMasB[j] = 0;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите закрыть окно?", "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            this.Close();
        }
        
        private void Equivalence_Click(object sender, EventArgs e)
        {
            string result = "";

            for (int i = 0; i < strBinA.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(strBinA[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(strBinB[i].ToString()));

                if (a ^ b)
                    result += "0";
                else
                    result += "1";
            }
            resultOutput.Text = result;
            flagsOutput.Text = "OV = False   C = False";

        }

        public static int[] AddMas(int[] mas1, int[] mas2)
        {
            int[] sum = new int[16];

            for (int i = 15; i > 0; i--)
            {
                if ((mas1[i] + mas2[i]) <= 1)
                {
                    sum[i] = (mas1[i] + mas2[i]);
                }
                if ((mas1[i] + mas2[i]) > 1)
                {
                    if (i > 1)
                    {
                        sum[i] = 1;
                        sum[i - 1] += 1;
                    }
                    if (i == 0)
                    {
                        sum[i] = (mas1[i] + mas2[i]) % 2;
                        ov = true;
                    }
                }
            }

            return sum;
        }

        //public static BitArray AddMas(int[] mas1, int[] mas2)
        //{
        //    int[] sum = new int[16];
        //    var A = new BitArray(16);
        //    var B = new BitArray(16);
        //    for (int i = 0; i < A.Length; ++i)
        //    {
        //        A[i] = mas1[i] == 1;
        //    }
        //    for (int i = 0; i < A.Length; ++i)
        //    {
        //        B[i] = mas2[i] == 1;
        //    }

        //    bool overflow = false;
        //    for (int i = A.Length - 1; i >= 0; --i)
        //    {
        //        if (overflow)
        //        {
        //            overflow = B[i] || A[i];
        //            A[i] = B[i] == A[i];
        //        }
        //        else
        //        {
        //            overflow = B[i] && A[i];
        //            A[i] = !overflow && (B[i] || A[i]);
        //        }
        //    }
        //    return A;
        //}

        static void LeftShift(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; ++i)
            {
                mas[i] = mas[i + 1];
            }
            mas[mas.Length - 1] = 0;
        }

        public static void BitToInt(BitArray bitSmt, int[] intSmt)
        {
            for (int r = 0; r < 16; r++)
            {
                if (bitSmt[r] == false)
                {
                    intSmt[r] = 0;
                }
                if (bitSmt[r] == true)
                {
                    intSmt[r] = 1;
                }
            }
        }

        public static void IntToBit(BitArray bitSmt, int[] intSmt)
        {
            for (int b = 0; b < bitSmt.Length; b++)
            {
                if (intSmt[b] == 0)
                {
                    bitSmt[b] = false;
                }
                if (intSmt[b] == 1)
                {
                    bitSmt[b] = true;
                }
            }
        }


        static string AddBinaryStrings(string str1, string str2)
        {
            int maxL = Math.Max(str1.Length, str2.Length);
            if(maxL > 15)
            {
                maxL = 15;
            }
            char[] res = new char[maxL + 1];
            for (int i = 0; i < maxL +1; i++)
            {
                res[i] = ' ';
            }
            int car = 0;
            for(int i = 0; i < maxL; i++)
            {
                int b1 = (i < str1.Length) ? str1[str1.Length - 1 - i] - '0' : 0;
                int b2 = (i < str2.Length) ? str2[str2.Length - 1 - i] - '0' : 0;

                int sum = b1 + b2 + car;
                res[maxL - 1] = (sum % 2).ToString()[0];

            }

            if (car > 0)
                res[0] = '1';
            return new string(res);
        }

        private void AccMultiply_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] masA = new int[16];
            int[] masB = new int[16];

            masA = strBinA.ToCharArray().Select(r => int.Parse(r.ToString())).ToArray();
            masB = strBinB.ToCharArray().Select(r => int.Parse(r.ToString())).ToArray();

            string firstA = strBinA.Substring(0, 1);
            string firstB = strBinB.Substring(0, 1);

            char[] charA = strBinA.ToCharArray();
            charA[0] = '0';
            strBinA = new string(charA);

            char[] charB = strBinB.ToCharArray();
            charB[0] = '0';
            strBinB = new string(charB);
            string twoReg = AddBinaryStrings(strBinA, strBinA);
            string threeReg = AddBinaryStrings(twoReg, strBinA);

            string S = "";
            S += twoReg;

            for (int i = 0; i < masB.Length; i += 2)
            {
                if (masB[i] == '0' && masB[i + 1] == '0')
                {
                    if (((masB.Length - i) != 2) && (i != 0))
                    {
                        S = S + "00";
                    }
                }
                else if (masB[i] == '0' && masB[i + 1] == '1')
                {
                    S = AddBinaryStrings(S, strBinA);
                    if ((masB.Length - i) != 2)
                    {
                        S = S + "00";
                    }
                }
                else if (masB[i] == '1' && masB[i + 1] == '0')
                {
                    S = AddBinaryStrings(S, twoReg);
                    if ((masB.Length - i) != 2)
                    {
                        S = S + "00";
                    }
                }
                else if (masB[i] == '1' && masB[i + 1] == '1')
                {
                    S = AddBinaryStrings(S, threeReg);
                    if ((masB.Length - i) != 2)
                    {
                        S = S + "00";
                    }
                }
            }

            
            resultOutput.Text = S;
        }
    }
}


//#region two
//string result = "";
//int a = Convert.ToInt32(strBinA);
//int b = Convert.ToInt32(strBinB);
//int bReverse;

//string s = b.ToString();
//char[] ar = s.ToCharArray();
//Array.Reverse(ar);
//s = new String(ar);
//bReverse = Convert.ToInt32(s);

//string strA = strBinA;
//string strB = strBinB;

//int reg = a;
////shift
//reg *= 10;
//int sum = 0;

//for (int i = 0; i < 8; i++)
//{
//    int pair = bReverse % 100;
//    if (pair == 1)
//    {
//        sum += a;
//    }
//    if (pair == 10)
//    {
//        sum += reg;
//    }
//    if (pair == 11)
//    {
//        sum += a;
//        sum += reg;
//    }
//    //shift sum left 2
//    LeftShift();
//    sum *= 100;

//    bReverse /= 100;
//}

//resultOutput.Text = a.ToString();
//#endregion