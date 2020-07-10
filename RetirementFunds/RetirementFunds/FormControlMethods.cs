using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RetirementFunds
{
    // This static class is a collection of of methods that are used for multiple form controls, especially textboxes.
    public static class FormControlMethods
    {
        // Method that makes sure a textbox only accepts numbers (with one decimal allowed).
        public static void GarbageNonText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Method that formats specific textboxes to the appropriate look. Dollar amounts, percentages, and whole numbers.
        public static void FormatTextBox(TextBox txt)
        {
            if (txt.Tag.Equals("dollar"))
            {
                if (txt.Text.Equals("$"))
                {
                    txt.Text = "$0.00";
                }
                else if (txt.TextLength > 0)
                {
                    decimal temp = decimal.Parse(txt.Text, NumberStyles.Currency);
                    txt.Text = temp.ToString("C2");
                }
                else
                {
                    txt.Text = "$0.00";
                }
            }
            else if (txt.Tag.ToString().Contains("rate"))
            {
                if (txt.TextLength > 0)
                {
                    float temp = float.Parse(txt.Text);
                    if (txt.Tag.ToString().Contains("fraction"))
                    {
                        txt.Text = temp.ToString("0.0");
                    }
                    else
                    {
                        txt.Text = temp.ToString("0.00");
                    }
                }
                else
                {
                    txt.Text = "1.00";
                }
            }
            else if (txt.Tag.Equals("period"))
            {
                if (txt.TextLength > 0)
                {
                    double temp = double.Parse(txt.Text);
                    temp = Math.Round(temp);
                    txt.Text = temp.ToString();
                }
                else
                {
                    txt.Text = "1";
                }
            }
        }

        // Method specific to textboxes that take dollar inputs. This makes sure that nothing gets inputed before the '$' sign.
        public static void FixTextBoxCursor(TextBox txt, PreviewKeyDownEventArgs e)
        {
            int i;
            if (!int.TryParse(e.KeyValue.ToString(), out i) || (txt.Text.Length - 1) <= txt.SelectionStart || txt.Text.Length == 0) return;

            char x = txt.Text[txt.SelectionStart];
            if (x.Equals('$') && txt.Text.Length > 1)
            {
                txt.SelectionStart++;
            }
        }
    }
}
