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

namespace Draft_Discard_WinformsApp.Forms
{
    public partial class CardDetails : Form
    {
        Cards card = new Cards();
        public CardDetails(Cards card)
        {
            InitializeComponent();
            this.card = card;
            SetValues(this.card);
        }
        void SetValues(Cards card)
        {
            tbx_CardName.Text = card.getCardName();
            tbx_Rarity.Text = card.getCardRarity();
            tbx_ManaBase.Text = card.getCardManabase();
            string types = "";
            foreach(string type in card.getCardTypes())
            {
                types += type + " ";
            }
            tbx_Types.Text = types;
            string tribes = "";
            foreach (string tribe in card.getCardTribes())
            {
                tribes += tribe + " ";
            }
            tbx_Tribes.Text = tribes;
            rtb_Description.Text = card.getCardDescription();
            tbx_Power.Text = Convert.ToString(card.getCardAD()[0]);
            tbx_Defence.Text = Convert.ToString(card.getCardAD()[1]);
            tbx_SetName.Text = card.getCardSet().getSetName();
            tbx_SetRelease.Text = card.getCardSet().getSetDate();
        }
    }
}
