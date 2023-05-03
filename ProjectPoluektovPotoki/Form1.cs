using System.Windows.Forms;

namespace ProjectPoluektovPotoki
{
    public partial class Form1 : Form
    {
        List<string> allFoundFiles = new List<string>();    // имена файлов
        List<string> str = new List<string>();              // строки файла
        Mutex mutex1 = new Mutex();                         // Мьютекс для файлов со словами
      
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();

        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }

        public void OpenFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ShowFiles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (directory.Text == String.Empty)
            {
                MessageBox.Show("Чувак, выбери папку!");
            }
            else
            {
                Thread thread1 = new Thread(ShFales);
                thread1.Start();

                foreach (string file in allFoundFiles)
                {
                    listBox1.Items.Add(file);
                }

            }
        }

        public void ShFales()
        {
            allFoundFiles = Directory.GetFiles(directory.Text, "*.txt", SearchOption.AllDirectories).ToList();

        }

        private void LookFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            string nameFile = listBox1.SelectedItem.ToString();
                        
            Thread thread2 = new Thread(ReadFile);
            thread2.Start(nameFile);

            foreach (var s in str)
            {
                richTextBox1.Text += s + "\n";
            }

        }

        public void ReadFile(object? ob)
        {
            using (var sw = new StreamReader(ob as string))
            {
                string s = sw.ReadToEnd();
                str = s.Split('\n').Select(s => s != "" ? s : "0").ToList();
            }

        }

        private void ShowWithWords_Click(object sender, EventArgs e)
        {
            
            Mutex mutex1 = new Mutex();
            if (words.Text == String.Empty)
            {
                MessageBox.Show("Чувак, где слово?");
            }
            else
            {   
                listBox1.Items.Clear();
               
                Thread thread3 = new Thread(ShFalesMutix);
                thread3.Start(mutex1);

                Thread thread4 = new Thread(FalesWithWords);
                thread4.Start(mutex1);

                foreach (string file in allFoundFiles)
                {
                    listBox1.Items.Add(file);
                }
            }

        }
        public void ShFalesMutix(object? ob)
        {
            (ob as Mutex).WaitOne();
            allFoundFiles = Directory.GetFiles(directory.Text, "*.txt", SearchOption.AllDirectories).ToList();
            (ob as Mutex).ReleaseMutex();

        }

        public void FalesWithWords (object? ob)
        {
            (ob as Mutex).WaitOne();
            List <string> files = new List<string>();

            foreach (string file in allFoundFiles)
            {
                string[] lines = System.IO.File.ReadAllLines(file);
                int i = 0;
                string b = words.Text.ToLower(); //Искомое слово

                    foreach (string line in lines)
                    {
                        string[] var = lines[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                        i += 1;
                        foreach (string word in var)
                        {
                            if (word.ToLower().Contains(b))            
                            {
                            if (!files.Contains(file))
                            files.Add(file);
                           
                            }
                        }
                    }
            }
            allFoundFiles = files;
            (ob as Mutex).ReleaseMutex();
        }
    }
}