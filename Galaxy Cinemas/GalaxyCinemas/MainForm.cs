using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Common;

namespace GalaxyCinemas
{
    public partial class MainForm : Form
    {
        private List<ISpecialPlugin> specialPlugins = new List<ISpecialPlugin>();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                foreach (FileInfo file in dir.GetFiles("Plugin*.dll"))
                {
                    string name = Path.GetFileNameWithoutExtension(file.Name);

                    Assembly pluginAssembly = Assembly.Load("name");
                    var plugins = from type in pluginAssembly.GetTypes()
                                  where typeof(ISpecialPlugin).IsAssignableFrom(type) && !type.IsInterface
                                  select type;
                    foreach(Type pluginType in plugins)
                    {
                        ISpecialPlugin plugin = Activator.CreateInstance(pluginType) as ISpecialPlugin;
                        specialPlugins.Add(plugin);
                    }







                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading special pricing plugins.");
            }
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // To ensure the main form has focus after a child form is closed.
            this.Focus();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportDataForm idf = new ImportDataForm();
            idf.FormClosed += ChildFormClosed;
            idf.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingForm bf = new BookingForm(specialPlugins);
            bf.FormClosed += ChildFormClosed;
            bf.Show();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            ExportDataForm xdf = new ExportDataForm();
            xdf.FormClosed += ChildFormClosed;
            xdf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
