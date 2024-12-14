namespace FileHelper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<string> pdfFilesList = new List<string>();
            List<string> xmlFilesList = new List<string>();
            List<string> missingFiles = new List<string>();

            string folderPath = tbFolderPath.Text;

            if (Directory.Exists(folderPath))
            {
                string[] fileEntries = Directory.GetFiles(folderPath);
                foreach (string fileName in fileEntries)
                {
                    if (fileName.Contains(".pdf"))
                    {
                        string fileNameTrim = fileName.Replace(folderPath + "\\", "");
                        string[] fileNameParts = fileNameTrim.Split(".");
                        pdfFilesList.Add(fileNameParts[0]);
                    }
                    else if (fileName.Contains(".xml"))
                    {
                        string fileNameTrim = fileName.Replace(folderPath + "\\", "");
                        string[] fileNameParts = fileNameTrim.Split(".");
                        xmlFilesList.Add(fileNameParts[0]);
                    }
                }

                foreach (string pdfFile in pdfFilesList)
                {
                    bool isContains = FileCheck(pdfFile, xmlFilesList);

                    if (isContains)
                    {
                        continue;
                    }
                    else
                    {
                        missingFiles.Add(pdfFile + ".xml");
                    }
                }

                foreach (string xmlFile in xmlFilesList)
                {
                    bool isContains = FileCheck(xmlFile, pdfFilesList);

                    if (isContains)
                    {
                        continue;
                    }
                    else
                    {
                        missingFiles.Add(xmlFile + ".pdf");
                    }
                }

                FrmOutput frm = new FrmOutput(missingFiles);
                frm.ShowDialog();
            }
            else
            {
                FrmOutput frm = new FrmOutput();
                frm.ShowDialog();
            }
        }

        public bool FileCheck(string fileName, List<string> filesList) 
        {
            foreach(string file in filesList)
            {
                if (file == fileName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
