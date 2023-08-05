using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BS_Calculadora
{
    public partial class Calculadora : Form
    {
        int i = 0;
        string op = "";
        string[] calculoLabel = new string[0];
        bool operationClicked = false, equalsClicked, equalsClicked2 = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void numberInserting(string numIn)
        {
            if (txt_Resultado.TextLength <= 30)
            {

                if (equalsClicked)
                {
                    btn_Clean.PerformClick();
                    equalsClicked = false;
                }
                if (txt_Resultado.Text == "0")
                {
                    txt_Resultado.Text = txt_Resultado.Text.Substring(1);
                }

                if (operationClicked)
                {
                    txt_Resultado.Text = numIn;
                }
                else
                {
                    txt_Resultado.Text += numIn;
                }
                operationClicked = false;
            }
        }

        private void operationInserting(string opIn)
        {
            string opText, aux;
            opText = " " + opIn + " ";
            if (equalsClicked)
            {
                aux = txt_Resultado.Text;
                btn_Clean.PerformClick();
                equalsClicked = false;
                txt_Resultado.Text = aux;
            }
            if (!operationClicked)
            {
                op += opIn;
                if (txt_Resultado.Text.Contains("."))
                {
                    txt_Resultado.Text = Convert.ToDecimal(txt_Resultado.Text).ToString();
                }
                else
                {
                    txt_Resultado.Text = Convert.ToDouble(txt_Resultado.Text).ToString();
                }
                Array.Resize(ref calculoLabel, calculoLabel.Length + 1);
                calculoLabel[calculoLabel.Length - 1] = txt_Resultado.Text;
                txt_Calculo.Text += txt_Resultado.Text + opText;
            }
            else
            {
                op = opIn;
                txt_Calculo.Text = txt_Calculo.Text.Substring(0, txt_Calculo.TextLength - 3) + opText;
            }
            operationClicked = true;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.TabStop = false;
            numberInserting(clickedButton.Text);
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            operationInserting(clickedButton.Text);
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            double resultado, calcNum;
            string calcAux;
            if (!equalsClicked)
            {
                equalsClicked = true;
                if (!equalsClicked2)
                {
                    Array.Resize(ref calculoLabel, calculoLabel.Length + 1);
                    calculoLabel[calculoLabel.Length - 1] = txt_Resultado.Text;
                }
                txt_Calculo.Text += calculoLabel[calculoLabel.Length - 1] + " = ";
                resultado = double.Parse(calculoLabel[0]);
                foreach (char opValue in op)
                {
                    calcNum = double.Parse(calculoLabel[i + 1]);
                    switch (opValue)
                    {
                        case '+':
                            resultado += calcNum;
                            break;
                        case '-':
                            resultado -= calcNum;
                            break;
                        case 'x':
                            resultado *= calcNum;
                            break;
                        case '÷':
                            resultado /= calcNum;
                            break;
                    }
                    i++;
                }
                txt_Resultado.Text = resultado.ToString();
            }
            else if (op.Length > 0)
            {
                equalsClicked2 = true;
                op = op.Substring(op.Length - 1);
                i = 0;
                txt_Calculo.Text = txt_Resultado.Text + " " + op + " ";
                operationClicked = false;
                calcAux = calculoLabel[calculoLabel.Length - 1];
                Array.Resize(ref calculoLabel, 2);
                calculoLabel[0] = txt_Resultado.Text;
                calculoLabel[1] = calcAux;
                equalsClicked = false;
                btn_Igual.PerformClick();
            }

        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (!operationClicked)
            {
                if (txt_Resultado.Text.Length > 1 && (txt_Resultado.Text.Length != 2 || !txt_Resultado.Text.Contains("-")))
                {
                    txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.Text.Length - 1);
                }
                else
                {
                    txt_Resultado.Text = "0";
                }
            }

        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            string keyP;
            keyP = Convert.ToString(e.KeyCode);
            if (keyP == "Back")
            {
                btn_Backspace.PerformClick();
            }
            keyP = keyP.Replace("NumPad", "");
            keyP = keyP.Replace("Add", "+");
            keyP = keyP.Replace("Subtract", "-");
            keyP = keyP.Replace("Multiply", "x");
            keyP = keyP.Replace("Divide", "÷");
            keyP = keyP.Replace("D", "");
            Match matchOp = Regex.Match(keyP, @"[-+x÷]");
            Match matchNum = Regex.Match(keyP, "[0-9]");
            if (matchNum.Success && !keyP.Contains("Oem"))
            {
                numberInserting(keyP);
            }
            if (matchOp.Success && !keyP.Contains("Oem"))
            {
                operationInserting(keyP);
            }
        }

        private void txt_Resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            string resultValue = txt_Resultado.Text;
            operationClicked = false;
            txt_Resultado.Text = (decimal.Parse(txt_Resultado.Text) * (-1)).ToString();
            if (resultValue.Substring(resultValue.Length - 1) == ".")
            {
                txt_Resultado.Text += ".";
            }
            if (resultValue.Substring(0, 1) == "0" && txt_Resultado.Text.Contains(".") && !txt_Resultado.Text.Contains("-"))
            {
                txt_Resultado.Text = "-" + txt_Resultado.Text;
            }

        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            if (operationClicked)
            {
                txt_Resultado.Text = "0.";
            }
            else if (!txt_Resultado.Text.Contains("."))
            {
                txt_Resultado.Text = txt_Resultado.Text.Substring(0, txt_Resultado.Text.Length) + ".";
            }
            operationClicked = false;
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = Math.Pow(double.Parse(txt_Resultado.Text), 2).ToString();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            i = 0;
            txt_Resultado.Font = new Font("Segoe UI", 32, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            op = "";
            txt_Resultado.Text = "0";
            txt_Calculo.Text = "";
            operationClicked = false;
            equalsClicked2 = false;
            Array.Resize(ref calculoLabel, 0);
        }

        private void btn_CleanE_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = "0";
        }

        private void txt_Resultado_TextChanged(object sender, EventArgs e)
        {
            if (TextRenderer.MeasureText(txt_Resultado.Text, txt_Resultado.Font).Width >= 300)
            {
                txt_Resultado.Font = new Font("Segoe UI", txt_Resultado.Font.Size - 4, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.ActiveControl is Button)
            {
                this.btn_Igual.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}




























































































