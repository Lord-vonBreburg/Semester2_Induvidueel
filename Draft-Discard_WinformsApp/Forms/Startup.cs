using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft_Discard_WinformsApp.Classes;


namespace Draft_Discard_WinformsApp
{
    public partial class nud_ : Form
    {
        List<Sets> sets = new List<Sets>();
        List<Cards> cards = new List<Cards>();

        public nud_()
        {
            InitializeComponent();
            PictureBox picture = new PictureBox
            {
                Name = "img_Logo",
                Size = new Size(220, 220),
                Location = new Point(16, 15),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Img_Logo.Controls.Add(picture);
            picture.ImageLocation = @"..\Image\Logo.bmp";
        }

        private void btn_AddSet_Click(object sender, EventArgs e)
        {
            if (tbx_SetName.Text != "")
            {
                sets.Add(new Sets(Convert.ToInt32(sets.Count()), Convert.ToString(tbx_SetName.Text), dtp_SetReleaseDate.Value.ToString("dd MMM yyyy")));
                UpdateSets(sets);
                tbx_SetName.Text = "";
            }
            else
            {
                MessageBox.Show("Set Name Missing!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSets(List<Sets> sets)
        {
            lsb_SetNames.Items.Clear();
            lsb_SetReleaeDates.Items.Clear();
            foreach (Sets item in sets)
            {
                lsb_SetNames.Items.Add(item.getSetName());
                lsb_SetReleaeDates.Items.Add(item.getSetDate());
            }
        }
        private void UpdateCards(List<Cards> cards)
        {
            lsb_Cards.Items.Clear();
            foreach (Cards item in cards)
            {
                lsb_Cards.Items.Add(item.getCardID().ToString()+": "+item.getCardName());
            }
        }

        private void btn_RemoveSet_Click(object sender, EventArgs e)
        {
            if (lsb_SetNames.SelectedIndex != -1)
            {
                List<Sets> Buffer = new List<Sets>();
                sets.RemoveAt(lsb_SetNames.SelectedIndex);
                foreach (Sets item in sets)
                {
                    Buffer.Add(new Sets(Buffer.Count, item.getSetName(), item.getSetDate()));
                }
                sets = Buffer;
                UpdateSets(sets);
            }
            else
            {
                MessageBox.Show("None Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RemoveCard_Click(object sender, EventArgs e)
        {
            if (lsb_Cards.SelectedIndex != -1)
            {
                List<Cards> Buffer = new List<Cards>();
                cards.RemoveAt(lsb_Cards.SelectedIndex);
                foreach (Cards item in cards)
                {
                    Buffer.Add(new Cards(
                        Buffer.Count,
                        item.getCardName(),
                        item.getCardTypes(),
                        item.getCardTribes(),
                        item.getCardRarity(),
                        item.getCardSet(),
                        item.getCardManabase(),
                        item.getCardAD().ToArray()[0],
                        item.getCardAD().ToArray()[1],
                        item.getCardDescription()));
                }
                cards = Buffer;
                UpdateCards(cards);
            }
            else
            {
                MessageBox.Show("None Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsb_SetNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsb_SetReleaeDates.SelectedIndex = lsb_SetNames.SelectedIndex;
        }

        private void lsb_SetReleaeDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsb_SetNames.SelectedIndex = lsb_SetReleaeDates.SelectedIndex;
        }

        private void llb_Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "To add mana to a card the following fotmat must be used. {N}" +
                "\nN is the shortname of the mana\n" +
                "\n{W} --> White" +
                "\n{U} --> Blue" +
                "\n{B} --> Black" +
                "\n{R} --> Red" +
                "\n{G} --> Green" +
                "\n{X} --> Generic (X can also be a number)"
                , "Mana Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_AddCard_Click(object sender, EventArgs e)
        {
            if (tbx_CardName.Text == "")
            {
                MessageBox.Show("Card Name Missing!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbx_CardType.Text == "")
            {
                MessageBox.Show("Card Type/Types Missing!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbx_CardTribe.Text == "")
            {
                MessageBox.Show("Card Tribe/Tribes Missing!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lsb_SetNames.SelectedIndex == -1)
            {
                MessageBox.Show("No Set Selecte\nSelect Set Above!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cards.Add(new Cards(
                    cards.Count,
                    tbx_CardName.Text,
                    tbx_CardType.Text.Split(' ').ToList<string>(),
                    tbx_CardTribe.Text.Split(' ').ToList<string>(),
                    tbx_Rarity.Text,
                    sets[lsb_SetNames.SelectedIndex],
                    tbx_ManaBase.Text,
                    Convert.ToInt32(nud_CardPower.Value),
                    Convert.ToInt32(nud_CardDefence.Value),
                    rtb_CardDescription.Text
                    ));
                cbx
                UpdateCards(cards);
            }
        }

        private void lsb_Cards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(cards.Count != 0)
            {
                Form CardDetailForm = new Forms.CardDetails(cards[lsb_Cards.SelectedIndex]);
                CardDetailForm.Show();
            }
            else
            {
                MessageBox.Show("No Cards Present","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
