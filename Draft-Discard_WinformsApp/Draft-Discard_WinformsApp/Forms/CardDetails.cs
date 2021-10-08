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
            tbx_CardName.Text = card.CardName;
            tbx_Rarity.Text = card.CardRarity;
            tbx_ManaBase.Text = card.CardMana;
            string types = "";
            foreach(string type in card.CardTypes)
            {
                types += type + " ";
            }
            tbx_Types.Text = types;
            string tribes = "";
            foreach (string tribe in card.CardTribes)
            {
                tribes += tribe + " ";
            }
            tbx_Tribes.Text = tribes;
            rtb_Description.Text = card.CardDescription;
            tbx_Power.Text = Convert.ToString(card.CardPowDef[0]);
            tbx_Defence.Text = Convert.ToString(card.CardPowDef[1]);
            tbx_SetName.Text = card.CardSetID.SetName;
            tbx_SetRelease.Text = card.CardSetID.SetDate;
        }
    }
}
