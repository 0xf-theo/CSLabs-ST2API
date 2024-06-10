using static System.Net.Mime.MediaTypeNames;

namespace Lab2_Ex2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // applique et active les styles visuels de Windows aux contr�les. Ce n'est pas n�cessaire mais si on fait un design ce serait int�ressant de pas l'oublier
            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false); // signifie utiliser GDI+ pour le rendu du texte.
            Application.Run(new Form1());  // Lance l'application en ouvrant la fen�tre principale Form1.

        }
    }
}