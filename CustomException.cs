using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulador
{
    public class CustomException : Exception
    {
        public CustomException(string mensagem)
            : base(mensagem)
        {
            //Console.WriteLine(mensagem);
            //Console.WriteLine("here");
            //Form1.MessageBox.Show(error, message, MessageBoxButtons.OK);
        }
    }
}