using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace dictionaryappa
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
  
   {
        {"Tufaax", "Apple"},
{"Moos", "Banana"},
{"Karoot", "Carrot"},
{"Timir", "Date"},
{"Beer", "Eggplant"},
{"Feeg", "Fig"},
{"Canab", "Grape"},
{"Malab", "Honey"},
{"Jalaato", "Ice Cream"},
{"Jamu", "Jam"},
{"Isbinaash", "Kale"},
{"Liin", "Lemon"},
{"Mango", "Mango"},
{"Iniij", "Nuts"},
{"Liin dhanaan", "Orange"},
{"Tufaax dhanaan", "Pineapple"},
{"Quinoa (Qudaar)", "Quinoa"},
{"Bariis", "Rice"},
{"Canab casaanka", "Strawberry"},
{"Yaanyo", "Tomato"},
{"Udon", "Udon (nooc ka mid ah baasto)"},
{"Khudaar", "Vegetables"},
{"Qaraha", "Watermelon"},
{"Xacuti (cunto Hindi ah)", "Xacuti"},
{"Caano gareysnaan", "Yogurt"},
{"Zucchini (nooc ka mid ah qajaar)", "Zucchini"},
{"Bisha", "Ant"},
{"Midho", "Bear"},
{"Bisad", "Cat"},
{"Eey", "Dog"},
{"Maroodi", "Elephant"},
{"Yaxaask", "Fox"},
{"Jiraf", "Giraffe"},
{"Fardaha", "Horse"},
{"Iguana", "Iguana"},
{"Jagar", "Jaguar"},
{"Kangaruu", "Kangaroo"},
{"Libaax", "Lion"},
{"Maymuna", "Monkey"},
{"Narwhal (nooc kalluun)", "Narwhal"},
{"Kalluunka octopus", "Octopus"},
{"Penguini", "Penguin"},
{"Qoyaale", "Quail"},
{"Hurdid", "Rabbit"},
{"Kalluunka shark", "Shark"},
{"Shabeel", "Tiger"},
{"Uakari (nooc ah simitar)", "Uakari"},
{"Urbaan", "Vulture"},
{"Waraabe", "Wolf"},
{"Xerus (nooc jiir)", "Xerus"},
{"Yakh", "Yak"},
{"Zebra", "Zebra"}
    };

SpeechSynthesizer Synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words = {
    "Tufaax", "Moos", "Karoot", "Timir", "Beer", "Feeg", "Canab", "Malab", "Jalaato", "Jamu",
    "Isbinaash", "Liin", "Mango", "Iniij", "Liin dhanaan", "Tufaax dhanaan", "Quinoa (Qudaar)", "Bariis", "Canab casaanka", "Yaanyo",
    "Udon (nooc ka mid ah baasto)", "Khudaar", "Qaraha", "Xacuti (cunto Hindi ah)", "Caano gareysnaan", "Zucchini (nooc ka mid ah qajaar)",
    "Bisha", "Midho", "Bisad", "Eey", "Maroodi", "Yaxaask", "Jiraf", "Fardaha", "Iguana", "Jagar",
    "Kangaruu", "Libaax", "Maymuna", "Narwhal (nooc kalluun)", "Kalluunka octopus", "Penguini", "Qoyaale", "Hurdid", "Kalluunka shark", "Shabeel",
    "Uakari (nooc ah simitar)", "Urbaan", "Waraabe", "Xerus (nooc jiir)", "Yakh", "Zebra"
};

            string[] definitions = {
    "Apple", "Banana", "Carrot", "Date", "Eggplant", "Fig", "Grape", "Honey", "Ice Cream", "Jam",
    "Kale", "Lemon", "Mango", "Nuts", "Orange", "Pineapple", "Quinoa", "Rice", "Strawberry", "Tomato",
    "Udon", "Vegetables", "Watermelon", "Xacuti", "Yogurt", "Zucchini",
    "Ant", "Bear", "Cat", "Dog", "Elephant", "Fox", "Giraffe", "Horse", "Iguana", "Jaguar",
    "Kangaroo", "Lion", "Monkey", "Narwhal", "Octopus", "Penguin", "Quail", "Rabbit", "Shark", "Tiger",
    "Uakari", "Vulture", "Wolf", "Xerus", "Yak", "Zebra"
};

            for (int i = 0; i < words.Length; i++)
            {
                lstWords.Items.Add(words[i]);
            }

            // Marka item la doorto, macnaha muujiso
            lstWords.SelectedIndexChanged += (s, args) =>
            {
                if (lstWords.SelectedIndex >= 0)
                {
                    // Muujin macnaha erayga la doortay
                    lblMeaning.Text = definitions[lstWords.SelectedIndex];
                }
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            bool found = false;
            foreach (var item in dictionary)
            {
                if (item.Key.ToLower().Equals(searchText))
                {
                    lblMeaning.Text = item.Value;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("waxad gelisay lama helin!", "digniin", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        } 
           

        private void btnspeak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMeaning.Text))

            {  SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(lblMeaning.Text);
                }
            else
            {
                MessageBox.Show("waxaad akhriso mahayo ");
            }
        }
    }
}
