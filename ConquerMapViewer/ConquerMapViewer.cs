using ReaLTaiizor.Forms;

namespace ConquerMapViewer
{
    public partial class ConquerMapViewer : MetroForm
    {
        public ConquerMapViewer()
        {
            InitializeComponent();
        }

        private void MapViewer_Load(object sender, EventArgs e)
        {
            tbxClientPath.Text = Properties.Settings.Default.ClientPath;
        }

        private void BtnChooseClient_Click(object sender, EventArgs e)
        {
            if (clientPathSelector.ShowDialog() == DialogResult.OK)
            {
                tbxClientPath.Text = clientPathSelector.SelectedPath;
                Properties.Settings.Default.ClientPath = clientPathSelector.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnLoadClient_Click(object sender, EventArgs e)
        {
            lstMaps.Clear();
            foreach (string file in Directory.GetFiles(Path.Combine(tbxClientPath.Text, "map", "map"), "*.DMap"))
            {
                lstMaps.Items.Add(file);
            }
        }

        private void LstMaps_SelectedIndexChanged(object sender)
        {
            string mapPath = string.Join('-', lstMaps.SelectedItem.ToString()).Split('-').Last().Trim();
            string mapFilename = Path.GetFileName(mapPath) + ".png";
            DmapHelper.Result result = DmapHelper.RunStitchDmap(Properties.Settings.Default.Tiled2DmapPath, mapFilename, tbxClientPath.Text, mapPath);
            //MessageBox.Show(result.StdOut + " ERR: " + result.StdErr);
            pbxMap.Image = System.Drawing.Image.FromFile(mapFilename);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
