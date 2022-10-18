using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEditorLib
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SimpleEditor frmEditor = new SimpleEditor();
            frmEditor.Text = "Document Content";
            frmEditor.RtfFile = @"D:\projects\GRSimpleEditor\Gangs 101- Understanding the Culture of Youth Violence.rtf";
            frmEditor.ReadOnly = true;
            frmEditor.AddHighlight(100, 12);
            Application.Run(frmEditor);
        }
    }
}
