using System;
using System.Threading;
using System.Windows.Forms;
// Gère la disposition et l'initialisation des modules sur le formulaire.
namespace Lab2_Ex2
{
        class LetterClass
        {
            private char _val;
            private TextBox _textBox;

            public LetterClass(char val, TextBox textBox)
            {
                this._val = val;
                this._textBox = textBox;
            }

            public void letterDisplay()
            {
                while (true)
                {
                    // Ensure thread-safe access to the TextBox
                    if (_textBox.InvokeRequired)
                    {
                        _textBox.Invoke(new Action(() => _textBox.AppendText(_val.ToString())));
                    }
                    else
                    {
                        _textBox.AppendText(_val.ToString());
                    }
                    Thread.Sleep(100);
                }
            }
        }
}

