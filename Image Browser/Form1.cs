using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace Image_Browser
{
    public partial class Form1 : Form
    {
        List<string> filesInLocation = new List<string>();
        //string path = "E:\\Folder1\\Folder11";
        string path = "C:\\BIOS";
        int index = 0;
        string parentFolder = "";
        public Form1()
        {
            InitializeComponent();

            filesInLocation = Directory.GetFiles(path).ToList();
            PBCurrent.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                PBCurrent.Image = Image.FromFile(filesInLocation[index]);
            }
            catch { };

            TVFrom.Nodes.Clear();
            TVFrom.NodeMouseDoubleClick += TVFrom_OnNodeDoubleClick;
            TVFrom.NodeMouseHover += TV_OnMouseHover;
            TVFrom.NodeMouseClick += TV_OnNodeRightClick;

            TVTo.Nodes.Clear();
            TVTo.NodeMouseHover += TV_OnMouseHover;
        }

        private void TV_OnNodeRightClick(Object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                string path = parentFolder.Substring(0, parentFolder.LastIndexOf('\\')) + "\\" + e.Node.FullPath.ToString();
                MessageBox.Show(path);
            }
        }
        private void UpdateMainImage(string p)
        {
            LabelFileName.Text = "";
            try
            {
                PBCurrent.Image = Image.FromFile(p);
                LabelFileName.Text = p.Substring(p.LastIndexOf("\\") + 1);
            }
            catch (NotSupportedException ex)
            {
                try
                {
                    PBCurrent.Load(p);
                    LabelFileName.Text = p;
                }
                catch { };
            }
            catch { };
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (filesInLocation.Count > 1)
            {
                index = index == filesInLocation.Count - 1 ? 0 : index + 1;
            }
            UpdateMainImage(filesInLocation[index]);
        }
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (filesInLocation.Count > 1)
            {
                index = index == 0 ? filesInLocation.Count - 1 : index - 1;
            }
            UpdateMainImage(filesInLocation[index]);
        }
        private void ButtonGo_Click(object sender, EventArgs e)
        {
            try
            {
                string uri = TBWebsite.Text;
                WebRequest request = WebRequest.Create(uri);
                request.Timeout = 10000;
                WebResponse response = request.GetResponse();
                Regex regex = new Regex("http((.)\\S+?)((\\.jpg)|(\\.gif)|(\\.jpeg)|(\\.png))+?"); 
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();

                    MatchCollection matches = regex.Matches(result);
                    if (matches.Count == 0)
                    {
                        MessageBox.Show("Parse failed.");
                        return;
                    }

                    foreach (Match match in matches)
                    {
                        if (!match.Success)
                        {
                            continue;
                        }
                    }
                    filesInLocation.Clear();
                    using (System.IO.StreamWriter file = new StreamWriter(@"C:/BIOS/linki.txt"))
                    {
                        foreach (Match match in matches)
                        {
                            if (!match.ToString().Contains(@"\"))
                            {
                                filesInLocation.Add(match.ToString());
                                //filesInLocation.Add(match.ToString().Replace(@"\", ""));
                                file.WriteLine(match.ToString());
                            }
                        }
                    }
                    request.Abort();
                    response.Dispose();
                    UpdateMainImage(filesInLocation[index]);
                }
            }
            catch { };
        }
        private void ButtonSetNewPath_Click(object sender, EventArgs e)
        {
            if (FBDNewTreePath.ShowDialog() == DialogResult.OK)
            {
                TVFrom.Nodes.Clear();
                parentFolder = FBDNewTreePath.SelectedPath.ToString();
                var rootDirectoryInfo = new DirectoryInfo(parentFolder);
                TVFrom.Nodes.Add(fillTree(rootDirectoryInfo));
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string filePath = "E:\\" + filesInLocation[index].Substring(filesInLocation[index].LastIndexOf("/") + 1);
            MessageBox.Show(filePath);
            webClient.DownloadFile(filesInLocation[index], filePath);
        }
        private void ButtonTo_Click(object sender, EventArgs e)
        {
            if (FBDNewTreePathTo.ShowDialog() == DialogResult.OK)
            {
                TVTo.Nodes.Clear();
                parentFolder = FBDNewTreePathTo.SelectedPath.ToString();
                var rootDirectoryInfo = new DirectoryInfo(parentFolder);
                TVTo.Nodes.Add(fillTree(rootDirectoryInfo));
            }
        }

        private TreeNode fillTree(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(fillTree(directory));
            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    if(file.Name.EndsWith(".jpg") || file.Name.EndsWith(".jpeg") || file.Name.EndsWith(".gif") || file.Name.EndsWith(".png"))
            //        directoryNode.Nodes.Add(new TreeNode(file.Name));
            //}
            return directoryNode;
        }
        private void TVFrom_OnNodeDoubleClick(Object sender, TreeNodeMouseClickEventArgs e)
        {
            path = parentFolder.Substring(0, parentFolder.LastIndexOf('\\')) + "\\" + e.Node.FullPath.ToString();
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
            {
                var a = Directory.GetFiles(path).ToList();
                filesInLocation.Clear();
                foreach (var f in a)
                {
                    if (f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".gif") || f.EndsWith(".png"))
                    {
                        filesInLocation.Add(f);
                    }
                }
                index = 0;
                if (filesInLocation.Count != 0)
                {
                    UpdateMainImage(filesInLocation[0]);
                }
                papapanel.Controls.Clear();
                PictureBox[] PB = new PictureBox[filesInLocation.Count];
                for(int i = 0; i < PB.Length; i++)
                {
                    PB[i] = new PictureBox();
                    PB[i].SizeMode = PictureBoxSizeMode.Zoom;
                    int y = 10;
                    int x = 10;
                    y = 15 + 130 * (i / 3);
                    x = 10 + 130 * (i % 3);
                    PB[i].Location = new Point(x, y);
                    PB[i].Size = new Size(125, 125);
                    PB[i].ImageLocation = filesInLocation[i];
                    PB[i].DoubleClick += miniature_DoubleClick;
                    papapanel.Controls.Add(PB[i]);
                }
            }
            else
            {
                try
                {
                    UpdateMainImage(path);
                    index = e.Node.Parent.Nodes.IndexOf(e.Node);
                    filesInLocation = Directory.GetFiles(path).ToList();
                }
                catch
                { }
            }
            ClearNode(e.Node.TreeView.Nodes[0]);
        }

        private void miniature_DoubleClick(Object sender, EventArgs e)
        {
            UpdateMainImage((sender as PictureBox).ImageLocation);
            index = filesInLocation.IndexOf((sender as PictureBox).ImageLocation.ToString());
        }

        private void ClearNode(TreeNode tn)
        {
            tn.BackColor = SystemColors.Window;
            tn.ForeColor = SystemColors.WindowText;
            foreach (TreeNode t in tn.Nodes)
                ClearNode(t);
        }
        private void TV_OnMouseHover(Object sender, TreeNodeMouseHoverEventArgs e)
        {
            try
            {
                foreach (Control c in e.Node.TreeView.Parent.Controls)
                {
                    if(c.GetType().Equals(typeof(PictureBox)))
                        (c as PictureBox).Image = Image.FromFile("C:\\" + e.Node.FullPath);
                }
            }
            catch { }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            for (int i = Int32.Parse(DUDLower.Text); i <= Int32.Parse(DUDUpper.Text); i++)
            {
                string filePath = "E:\\IBProba";
                MessageBox.Show(filePath + "  " + i);
                string adress = TBAdress1.Text + i + TBAdress2.Text;
                webClient.DownloadFile(adress, filePath);
            }
        }
    }
}

