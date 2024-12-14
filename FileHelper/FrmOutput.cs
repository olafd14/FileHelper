using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHelper
{
    public partial class FrmOutput : Form
    {
        public FrmOutput(List<string> missingFiles)
        {
            InitializeComponent();
            SetOutputLabel(missingFiles);
        }
        public FrmOutput()
        {
            InitializeComponent();
            SetInstructionLabel();
        }

        private void SetInstructionLabel()
        {
            lblOutput.Text = "Podany folder nie istnieje, prawdopodobnie ścieżka została źle skopiowana.\n\n" +
                "Poradnik dla seniora jak powinno się przekopiować ścieżkę:\n" +
                "1. Otworzyć Eksplorator plików na komputerze.\n" +
                "2. Odszukać i otworzyć folder który chcemy przeszukać.\n" +
                "3. Kliknąć raz w ścieżkę w górnym polu do wyszukiwania.\n" +
                "4. Przekopiować całą ścieżkę i wkleić w aplikacji w odpowiednim polu (jedynym dostępnym).\n\n" +
                "W razie innych problemów z PWS (Programem Wsparcia Seniora), proszę kontaktować się z obsługą techniczna dostępną od poniedziałku do wtorku w godzinach 10:00-10:07.\n";
        }

        public void SetOutputLabel(List<string> missingFiles)
        {
            if (missingFiles.Any())
            {
                string missingFilesText = "";
                foreach (string missingFile in missingFiles)
                {
                    missingFilesText += missingFile + "\n";
                }

                lblOutput.Text = "Brakujące pliki:\n" + missingFilesText;
            }
            else
            {
                lblOutput.Text = "Wszystkie wymagane pliki zostały zapisane.";
            }
        }
    }
}
