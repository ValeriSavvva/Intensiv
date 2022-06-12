using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Расширяемость
{
    public partial class Form1 : Form
    {
        [Serializable]
        public class ObjectFromDisk
        {
            public string Name { get; set; }
            public string RusName { get; set; }
            public string DescriptionObj { get; set; }
            public string DescriptionPlace { get; set; }
            public string BundleUrl { get; set; }
            public float Size { get; set; }
            public float Rotation { get; set; }
            public float x { get; set; }
            public float y { get; set; }
        }

        [Serializable]
        public class GameModels
        {
            public ObjectFromDisk[] models { get; set; }

            public GameModels()
            {
                models = new ObjectFromDisk[0];
            }

            public void Resize()
            {
                ObjectFromDisk[] md = new ObjectFromDisk[models.Length + 1];
                for (int i = 0; i < models.Length; i++)
                    md[i] = models[i];
                this.models = new ObjectFromDisk[md.Length];
                for (int i = 0; i < md.Length; i++)
                    models[i] = md[i];
            }

            public void deleteAt(int i)
            {
                List<ObjectFromDisk> md = new List<ObjectFromDisk>();

                for(int j = 0; j < models.Length; j++)
                {
                    if (j != i)
                        md.Add(models[j]);
                }

                this.models = new ObjectFromDisk[md.Count];

                for (int j = 0; j < md.Count; j++)
                    models[j] = md[j];
            }
        }

        GameModels gm;
        string jsonFile;
        string filePath;
        int selectIndex;
        bool showhide = false;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(298, 429);
            this.MaximumSize = new Size(298, 429);
            this.Size = new Size(298, 429);
            try
            {
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFile.FileName;
                    jsonFile = File.ReadAllText(filePath);
                    gm = JsonSerializer.Deserialize<GameModels>(jsonFile);
                    updateItemsList();
                }
                else
                {
                    gm = new GameModels();
                    openFile.FileName = null;
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить json файл");
                gm = new GameModels();
            }
        }

        private void updateItemsList()
        {
            itemsList.Items.Clear();
            for(int i = 0; i < gm.models.Length; i++)
            {
                itemsList.Items.Add(gm.models[i].Name);
            }
        }

        private int findIndex(string name)
        {
            for(int i = 0; i < gm.models.Length; i++)
            {
                if (gm.models[i].Name.Equals(name))
                    return i;
            }

            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectFromDisk a = new ObjectFromDisk();
                a.Name = this.NAME.Text;
                a.RusName = this.RUNAME.Text;
                a.DescriptionObj = this.DESCOBJ.Text;
                a.DescriptionPlace = this.DESCPLACE.Text;
                a.BundleUrl = this.LINK.Text;
                a.Size = float.Parse(this.SIZE.Text);
                a.Rotation = float.Parse(this.ROT.Text);
                a.x = float.Parse(this.X.Text);
                a.y = float.Parse(this.Y.Text);
                int index = findIndex(a.Name);
                if (index != -1)
                {
                    gm.models[index] = a;
                }
                else
                {
                    gm.Resize();
                    gm.models[gm.models.Length - 1] = a;
                    string serialized = JsonSerializer.Serialize(gm);
                    File.WriteAllText(filePath, serialized);
                }
                updateItemsList();
                changeText("", "", "", "", "", "", "", "", "");
                delete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно указаны данные!" + ex.Message);
            }
        }

        private void changeText(string name, string rusname, string desobj, string descplace,
            string url, string size, string rotation, string x, string y)
        {
            NAME.Text = name;
            RUNAME.Text = rusname;
            DESCOBJ.Text = desobj;
            DESCPLACE.Text = descplace;
            LINK.Text = url;
            SIZE.Text = size;
            ROT.Text = rotation;
            X.Text = x;
            Y.Text = y;
        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectIndex = itemsList.SelectedIndex;
            if (selectIndex != -1)
            {
                delete.Enabled = true;
                changeText(gm.models[selectIndex].Name, gm.models[selectIndex].RusName, gm.models[selectIndex].DescriptionObj,
                    gm.models[selectIndex].DescriptionPlace, gm.models[selectIndex].BundleUrl, gm.models[selectIndex].Size.ToString(),
                    gm.models[selectIndex].Rotation.ToString(), gm.models[selectIndex].x.ToString(), gm.models[selectIndex].y.ToString());
            }
            else
                delete.Enabled = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeText("", "", "", "", "", "", "", "", "");
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                jsonFile = File.ReadAllText(filePath);
                gm = JsonSerializer.Deserialize<GameModels>(jsonFile);
                updateItemsList();
            }
            else
            {
                gm = new GameModels();
                openFile.FileName = null;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            gm.deleteAt(selectIndex);
            itemsList.Items.RemoveAt(selectIndex);
            delete.Enabled = false;
            changeText("", "", "", "", "", "", "", "", "");
            string serialized = JsonSerializer.Serialize(gm);
            File.WriteAllText(filePath, serialized);
            updateItemsList();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Вы действительно хотите очистить файл?" +
                "\nИзменения нельзя будет обратить!", "Внимание!", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                gm = new GameModels();
                updateItemsList();
                changeText("", "", "", "", "", "", "", "", "");
                string serialized = JsonSerializer.Serialize(gm);
                File.WriteAllText(filePath, serialized);
            }
        }

        private void показатьскрытьЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showhide = !showhide;
            if (showhide)
            {
                показатьскрытьЗаписиToolStripMenuItem.Text = "Скрыть записи";
                this.MinimumSize = new Size(518, 429);
                this.MaximumSize = new Size(518, 429);
                this.Size = new Size(518, 429);
            }
            else
            {
                показатьскрытьЗаписиToolStripMenuItem.Text = "Показать записи";
                this.MinimumSize = new Size(298, 429);
                this.MaximumSize = new Size(298, 429);
                this.Size = new Size(298, 429);
            }
        }
    }
}
