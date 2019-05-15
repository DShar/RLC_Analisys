using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop.Word;
using System.Windows.Xps.Packaging;

namespace RLC_Analysis.Windows
{
    /// <summary>
    /// Interaction logic for UserGuide.xaml
    /// </summary>
    public partial class UserGuide : System.Windows.Window
    {
        public UserGuide()
        {
            InitializeComponent();
            string newXPSDocumentName = @"C:\Users\User\source\repos\RLC_Analysis\RLC_Analysis\Files\UserGuide.xps";
            XpsDocument xpsDoc = new XpsDocument(newXPSDocumentName, System.IO.FileAccess.Read);

            documentViewer1.Document = xpsDoc.GetFixedDocumentSequence();
        }

    }
}
