namespace Text_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            richTextBox1.Text = "";
            lblword.Text = "word_count:";
            lblcharcount.Text = "charcter_count:";
            lblfrequent.Text = "frequent_word_count:";
        }

        private void btnanalye_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            if (string.IsNullOrWhiteSpace(str))
            {
                MessageBox.Show("please enter text");
                return;
            }
            string[] words = str.Split(
                new char[] { ' ', '\t', '\n', '\r', '.', '?', ','},
                StringSplitOptions.RemoveEmptyEntries);

            lblcharcount.Text = "charcter count" + str.Length;
            lblword.Text = "word count" + words.Length;
            List<string> uniquewords = new List<string>();
            List<int> wordcount = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentword = words[i].ToLower();
                bool found = false;
                for (int j = 0; j < uniquewords.Count; j++)
                {
                    if (uniquewords[j] == currentword)
                    {
                        wordcount[j]++;
                        found = true;
                        break;
                    }
                }
                if (!found) { 
                  uniquewords.Add(currentword);
                    wordcount.Add(1);
                }
            }
            listBox1.Items.Clear();
            for (int i = 0; i < uniquewords.Count; i++)
            {
                listBox1.Items.Add(uniquewords[i] + ":" + wordcount[i]);

            }
            int maxcount = wordcount[0];
            string mostfrequent=uniquewords[0];
            for (int i = 0; i < wordcount.Count; i++)
            {
                if (wordcount[i] > maxcount)
                {
                    maxcount = wordcount[i];
                    mostfrequent = uniquewords[i];

                }
            }
            lblfrequent.Text = "Most Frequent word:"+mostfrequent+maxcount;
        }
    }
}
