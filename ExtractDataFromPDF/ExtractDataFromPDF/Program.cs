using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ExtractDataFromPDF
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private static string STR_OUTPUT_FILE_NAME = "ExtractTextToPDFOutput.txt";

        static void Main(String[] args)
        {
            IntPtr objWindowHandler;
            string strPDFFile = string.Empty;
            string strParameter = string.Empty;

            try
            {
                objWindowHandler = Process.GetCurrentProcess().MainWindowHandle;

                ShowWindow(objWindowHandler, 0);

                if (File.Exists(@Directory.GetCurrentDirectory() + "\\" + STR_OUTPUT_FILE_NAME))
                    File.Delete(@Directory.GetCurrentDirectory() + "\\" + STR_OUTPUT_FILE_NAME);

                if (args == null)
                    throw new Exception("Nenhum argumento informado!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                if (args.Length < 2)
                    throw new Exception("Número de arqumentos inválido!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                else if (string.IsNullOrEmpty(args[0]))
                    throw new Exception("Informe o Caminho do Arquivo PDF!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                else if (!File.Exists(args[0]))
                    throw new Exception("Arquivo PDF Informado não Existe!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                else if (string.IsNullOrEmpty(args[1]))
                    throw new Exception("Informe o Parâmetro de Existência de Imagem no Arquivo PDF!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                else if (args[1] != "-i" && args[1] != "-n")
                    throw new Exception("Parâmetro de Existência de Imagem Incorreto!\nARG1: Nome Arquivo | ARG2: -i (com imagem) -n (sem imagem)");
                else
                {
                    strPDFFile = args[0].Trim();
                    strParameter = args[1].Trim();

                    WriteOutput(new PDFHandler(@strPDFFile, strParameter == "-i" ? true : false).ProcessPDFFile());
                }

                //ShowWindow(objWindowHandler, 5);
                //Console.ReadKey();
            }
            catch (Exception objException)
            {
                WriteOutput(objException.Message);
            }
        }     

        private static void WriteOutput(string strText) 
        {
            TextWriter txWriter = null;

            txWriter = new StreamWriter(@Directory.GetCurrentDirectory() + "\\" + STR_OUTPUT_FILE_NAME, true);

            txWriter.Write(strText);
            txWriter.Close();
            txWriter.Dispose();
            txWriter = null;
        }
    }
}
