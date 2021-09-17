
namespace Draft_Discard_WinformsApp
{
    partial class nud_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nud_));
            this.lsb_SetNames = new System.Windows.Forms.ListBox();
            this.gpb_Sets = new System.Windows.Forms.GroupBox();
            this.lbl_ReleaseDates = new System.Windows.Forms.Label();
            this.lsb_SetReleaeDates = new System.Windows.Forms.ListBox();
            this.btn_RemoveSet = new System.Windows.Forms.Button();
            this.lbl_Sets = new System.Windows.Forms.Label();
            this.lbl_ReleaseDatum = new System.Windows.Forms.Label();
            this.dtp_SetReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_SetName = new System.Windows.Forms.TextBox();
            this.lbl_SetName = new System.Windows.Forms.Label();
            this.btn_AddSet = new System.Windows.Forms.Button();
            this.Img_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.gpb_Cards = new System.Windows.Forms.GroupBox();
            this.tbx_Rarity = new System.Windows.Forms.TextBox();
            this.lbl_Rarity = new System.Windows.Forms.Label();
            this.lbl_Defence = new System.Windows.Forms.Label();
            this.lbl_SeperatorSign = new System.Windows.Forms.Label();
            this.nud_CardDefence = new System.Windows.Forms.NumericUpDown();
            this.nud_CardPower = new System.Windows.Forms.NumericUpDown();
            this.btn_RemoveCard = new System.Windows.Forms.Button();
            this.btn_AddCard = new System.Windows.Forms.Button();
            this.lbl_Power = new System.Windows.Forms.Label();
            this.lbl_CardList = new System.Windows.Forms.Label();
            this.lsb_Cards = new System.Windows.Forms.ListBox();
            this.tbx_CardTribe = new System.Windows.Forms.TextBox();
            this.lbl_CardTribe = new System.Windows.Forms.Label();
            this.tbx_CardType = new System.Windows.Forms.TextBox();
            this.lbl_CardType = new System.Windows.Forms.Label();
            this.lbl_CardDescription = new System.Windows.Forms.Label();
            this.rtb_CardDescription = new System.Windows.Forms.RichTextBox();
            this.llb_Help = new System.Windows.Forms.LinkLabel();
            this.tbx_ManaBase = new System.Windows.Forms.TextBox();
            this.lbl_ManaBase = new System.Windows.Forms.Label();
            this.tbx_CardName = new System.Windows.Forms.TextBox();
            this.lbl_CardName = new System.Windows.Forms.Label();
            this.gpb_Sets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).BeginInit();
            this.gpb_Cards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardDefence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardPower)).BeginInit();
            this.SuspendLayout();
            // 
            // lsb_SetNames
            // 
            this.lsb_SetNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_SetNames.FormattingEnabled = true;
            this.lsb_SetNames.ItemHeight = 16;
            this.lsb_SetNames.Location = new System.Drawing.Point(274, 42);
            this.lsb_SetNames.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_SetNames.Name = "lsb_SetNames";
            this.lsb_SetNames.Size = new System.Drawing.Size(200, 196);
            this.lsb_SetNames.TabIndex = 0;
            this.lsb_SetNames.SelectedIndexChanged += new System.EventHandler(this.lsb_SetNames_SelectedIndexChanged);
            // 
            // gpb_Sets
            // 
            this.gpb_Sets.Controls.Add(this.lbl_ReleaseDates);
            this.gpb_Sets.Controls.Add(this.lsb_SetReleaeDates);
            this.gpb_Sets.Controls.Add(this.btn_RemoveSet);
            this.gpb_Sets.Controls.Add(this.lbl_Sets);
            this.gpb_Sets.Controls.Add(this.lbl_ReleaseDatum);
            this.gpb_Sets.Controls.Add(this.dtp_SetReleaseDate);
            this.gpb_Sets.Controls.Add(this.tbx_SetName);
            this.gpb_Sets.Controls.Add(this.lbl_SetName);
            this.gpb_Sets.Controls.Add(this.btn_AddSet);
            this.gpb_Sets.Controls.Add(this.lsb_SetNames);
            this.gpb_Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Sets.Location = new System.Drawing.Point(291, 15);
            this.gpb_Sets.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_Sets.Name = "gpb_Sets";
            this.gpb_Sets.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_Sets.Size = new System.Drawing.Size(698, 246);
            this.gpb_Sets.TabIndex = 1;
            this.gpb_Sets.TabStop = false;
            this.gpb_Sets.Text = "Card Sets";
            // 
            // lbl_ReleaseDates
            // 
            this.lbl_ReleaseDates.AutoSize = true;
            this.lbl_ReleaseDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReleaseDates.Location = new System.Drawing.Point(478, 23);
            this.lbl_ReleaseDates.Name = "lbl_ReleaseDates";
            this.lbl_ReleaseDates.Size = new System.Drawing.Size(116, 16);
            this.lbl_ReleaseDates.TabIndex = 10;
            this.lbl_ReleaseDates.Text = "Release Dates:";
            // 
            // lsb_SetReleaeDates
            // 
            this.lsb_SetReleaeDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lsb_SetReleaeDates.FormattingEnabled = true;
            this.lsb_SetReleaeDates.ItemHeight = 16;
            this.lsb_SetReleaeDates.Location = new System.Drawing.Point(481, 42);
            this.lsb_SetReleaeDates.Name = "lsb_SetReleaeDates";
            this.lsb_SetReleaeDates.Size = new System.Drawing.Size(210, 196);
            this.lsb_SetReleaeDates.TabIndex = 9;
            this.lsb_SetReleaeDates.SelectedIndexChanged += new System.EventHandler(this.lsb_SetReleaeDates_SelectedIndexChanged);
            // 
            // btn_RemoveSet
            // 
            this.btn_RemoveSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveSet.Location = new System.Drawing.Point(173, 201);
            this.btn_RemoveSet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoveSet.Name = "btn_RemoveSet";
            this.btn_RemoveSet.Size = new System.Drawing.Size(93, 37);
            this.btn_RemoveSet.TabIndex = 8;
            this.btn_RemoveSet.Text = "Remove";
            this.btn_RemoveSet.UseVisualStyleBackColor = true;
            this.btn_RemoveSet.Click += new System.EventHandler(this.btn_RemoveSet_Click);
            // 
            // lbl_Sets
            // 
            this.lbl_Sets.AutoSize = true;
            this.lbl_Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sets.Location = new System.Drawing.Point(271, 23);
            this.lbl_Sets.Name = "lbl_Sets";
            this.lbl_Sets.Size = new System.Drawing.Size(80, 16);
            this.lbl_Sets.TabIndex = 7;
            this.lbl_Sets.Text = "Set Name:";
            // 
            // lbl_ReleaseDatum
            // 
            this.lbl_ReleaseDatum.AutoSize = true;
            this.lbl_ReleaseDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReleaseDatum.Location = new System.Drawing.Point(7, 84);
            this.lbl_ReleaseDatum.Name = "lbl_ReleaseDatum";
            this.lbl_ReleaseDatum.Size = new System.Drawing.Size(106, 16);
            this.lbl_ReleaseDatum.TabIndex = 6;
            this.lbl_ReleaseDatum.Text = "Release date:";
            // 
            // dtp_SetReleaseDate
            // 
            this.dtp_SetReleaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_SetReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_SetReleaseDate.Location = new System.Drawing.Point(12, 103);
            this.dtp_SetReleaseDate.Name = "dtp_SetReleaseDate";
            this.dtp_SetReleaseDate.Size = new System.Drawing.Size(255, 22);
            this.dtp_SetReleaseDate.TabIndex = 5;
            // 
            // tbx_SetName
            // 
            this.tbx_SetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_SetName.Location = new System.Drawing.Point(11, 42);
            this.tbx_SetName.Name = "tbx_SetName";
            this.tbx_SetName.Size = new System.Drawing.Size(255, 22);
            this.tbx_SetName.TabIndex = 4;
            // 
            // lbl_SetName
            // 
            this.lbl_SetName.AutoSize = true;
            this.lbl_SetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SetName.Location = new System.Drawing.Point(8, 23);
            this.lbl_SetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SetName.Name = "lbl_SetName";
            this.lbl_SetName.Size = new System.Drawing.Size(80, 16);
            this.lbl_SetName.TabIndex = 3;
            this.lbl_SetName.Text = "Set Name:";
            // 
            // btn_AddSet
            // 
            this.btn_AddSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSet.Location = new System.Drawing.Point(11, 201);
            this.btn_AddSet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddSet.Name = "btn_AddSet";
            this.btn_AddSet.Size = new System.Drawing.Size(93, 37);
            this.btn_AddSet.TabIndex = 1;
            this.btn_AddSet.Text = "Add Set";
            this.btn_AddSet.UseVisualStyleBackColor = true;
            this.btn_AddSet.Click += new System.EventHandler(this.btn_AddSet_Click);
            // 
            // Img_Logo
            // 
            this.Img_Logo.Enabled = false;
            this.Img_Logo.ImageLocation = "D:\\WinForms\\Draft-Discard_WinformsApp\\Draft-Discard_WinformsApp\\Assets\\DraftDisca" +
    "rd_Logo.bmp";
            this.Img_Logo.InitialImage = null;
            this.Img_Logo.Location = new System.Drawing.Point(16, 15);
            this.Img_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Img_Logo.Name = "Img_Logo";
            this.Img_Logo.Size = new System.Drawing.Size(267, 246);
            this.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Logo.TabIndex = 2;
            this.Img_Logo.TabStop = false;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Location = new System.Drawing.Point(0, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(100, 23);
            this.lbl_Amount.TabIndex = 0;
            // 
            // gpb_Cards
            // 
            this.gpb_Cards.Controls.Add(this.tbx_Rarity);
            this.gpb_Cards.Controls.Add(this.lbl_Rarity);
            this.gpb_Cards.Controls.Add(this.lbl_Defence);
            this.gpb_Cards.Controls.Add(this.lbl_SeperatorSign);
            this.gpb_Cards.Controls.Add(this.nud_CardDefence);
            this.gpb_Cards.Controls.Add(this.nud_CardPower);
            this.gpb_Cards.Controls.Add(this.btn_RemoveCard);
            this.gpb_Cards.Controls.Add(this.btn_AddCard);
            this.gpb_Cards.Controls.Add(this.lbl_Power);
            this.gpb_Cards.Controls.Add(this.lbl_CardList);
            this.gpb_Cards.Controls.Add(this.lsb_Cards);
            this.gpb_Cards.Controls.Add(this.tbx_CardTribe);
            this.gpb_Cards.Controls.Add(this.lbl_CardTribe);
            this.gpb_Cards.Controls.Add(this.tbx_CardType);
            this.gpb_Cards.Controls.Add(this.lbl_CardType);
            this.gpb_Cards.Controls.Add(this.lbl_CardDescription);
            this.gpb_Cards.Controls.Add(this.rtb_CardDescription);
            this.gpb_Cards.Controls.Add(this.llb_Help);
            this.gpb_Cards.Controls.Add(this.tbx_ManaBase);
            this.gpb_Cards.Controls.Add(this.lbl_ManaBase);
            this.gpb_Cards.Controls.Add(this.tbx_CardName);
            this.gpb_Cards.Controls.Add(this.lbl_CardName);
            this.gpb_Cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.gpb_Cards.Location = new System.Drawing.Point(16, 277);
            this.gpb_Cards.Name = "gpb_Cards";
            this.gpb_Cards.Size = new System.Drawing.Size(757, 306);
            this.gpb_Cards.TabIndex = 3;
            this.gpb_Cards.TabStop = false;
            this.gpb_Cards.Text = "Cards";
            // 
            // tbx_Rarity
            // 
            this.tbx_Rarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Rarity.Location = new System.Drawing.Point(297, 168);
            this.tbx_Rarity.Name = "tbx_Rarity";
            this.tbx_Rarity.Size = new System.Drawing.Size(243, 22);
            this.tbx_Rarity.TabIndex = 30;
            // 
            // lbl_Rarity
            // 
            this.lbl_Rarity.AutoSize = true;
            this.lbl_Rarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Rarity.Location = new System.Drawing.Point(300, 149);
            this.lbl_Rarity.Name = "lbl_Rarity";
            this.lbl_Rarity.Size = new System.Drawing.Size(53, 16);
            this.lbl_Rarity.TabIndex = 29;
            this.lbl_Rarity.Text = "Rarity:";
            // 
            // lbl_Defence
            // 
            this.lbl_Defence.AutoSize = true;
            this.lbl_Defence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Defence.Location = new System.Drawing.Point(444, 204);
            this.lbl_Defence.Name = "lbl_Defence";
            this.lbl_Defence.Size = new System.Drawing.Size(70, 16);
            this.lbl_Defence.TabIndex = 28;
            this.lbl_Defence.Text = "Defence:";
            // 
            // lbl_SeperatorSign
            // 
            this.lbl_SeperatorSign.AutoSize = true;
            this.lbl_SeperatorSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_SeperatorSign.Location = new System.Drawing.Point(406, 225);
            this.lbl_SeperatorSign.Name = "lbl_SeperatorSign";
            this.lbl_SeperatorSign.Size = new System.Drawing.Size(12, 16);
            this.lbl_SeperatorSign.TabIndex = 27;
            this.lbl_SeperatorSign.Text = "/";
            // 
            // nud_CardDefence
            // 
            this.nud_CardDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nud_CardDefence.Location = new System.Drawing.Point(434, 223);
            this.nud_CardDefence.Name = "nud_CardDefence";
            this.nud_CardDefence.Size = new System.Drawing.Size(93, 22);
            this.nud_CardDefence.TabIndex = 26;
            // 
            // nud_CardPower
            // 
            this.nud_CardPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nud_CardPower.Location = new System.Drawing.Point(297, 223);
            this.nud_CardPower.Name = "nud_CardPower";
            this.nud_CardPower.Size = new System.Drawing.Size(93, 22);
            this.nud_CardPower.TabIndex = 24;
            // 
            // btn_RemoveCard
            // 
            this.btn_RemoveCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveCard.Location = new System.Drawing.Point(448, 251);
            this.btn_RemoveCard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoveCard.Name = "btn_RemoveCard";
            this.btn_RemoveCard.Size = new System.Drawing.Size(93, 37);
            this.btn_RemoveCard.TabIndex = 11;
            this.btn_RemoveCard.Text = "Remove";
            this.btn_RemoveCard.UseVisualStyleBackColor = true;
            this.btn_RemoveCard.Click += new System.EventHandler(this.btn_RemoveCard_Click);
            // 
            // btn_AddCard
            // 
            this.btn_AddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCard.Location = new System.Drawing.Point(298, 252);
            this.btn_AddCard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCard.Name = "btn_AddCard";
            this.btn_AddCard.Size = new System.Drawing.Size(93, 37);
            this.btn_AddCard.TabIndex = 11;
            this.btn_AddCard.Text = "Add Card";
            this.btn_AddCard.UseVisualStyleBackColor = true;
            this.btn_AddCard.Click += new System.EventHandler(this.btn_AddCard_Click);
            // 
            // lbl_Power
            // 
            this.lbl_Power.AutoSize = true;
            this.lbl_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Power.Location = new System.Drawing.Point(308, 204);
            this.lbl_Power.Name = "lbl_Power";
            this.lbl_Power.Size = new System.Drawing.Size(54, 16);
            this.lbl_Power.TabIndex = 23;
            this.lbl_Power.Text = "power:";
            // 
            // lbl_CardList
            // 
            this.lbl_CardList.AutoSize = true;
            this.lbl_CardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardList.Location = new System.Drawing.Point(546, 22);
            this.lbl_CardList.Name = "lbl_CardList";
            this.lbl_CardList.Size = new System.Drawing.Size(45, 16);
            this.lbl_CardList.TabIndex = 11;
            this.lbl_CardList.Text = "Card:";
            // 
            // lsb_Cards
            // 
            this.lsb_Cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lsb_Cards.FormattingEnabled = true;
            this.lsb_Cards.ItemHeight = 16;
            this.lsb_Cards.Location = new System.Drawing.Point(549, 41);
            this.lsb_Cards.Name = "lsb_Cards";
            this.lsb_Cards.Size = new System.Drawing.Size(200, 244);
            this.lsb_Cards.TabIndex = 21;
            this.lsb_Cards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsb_Cards_MouseDoubleClick);
            // 
            // tbx_CardTribe
            // 
            this.tbx_CardTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CardTribe.Location = new System.Drawing.Point(298, 107);
            this.tbx_CardTribe.Name = "tbx_CardTribe";
            this.tbx_CardTribe.Size = new System.Drawing.Size(243, 22);
            this.tbx_CardTribe.TabIndex = 20;
            // 
            // lbl_CardTribe
            // 
            this.lbl_CardTribe.AutoSize = true;
            this.lbl_CardTribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CardTribe.Location = new System.Drawing.Point(301, 88);
            this.lbl_CardTribe.Name = "lbl_CardTribe";
            this.lbl_CardTribe.Size = new System.Drawing.Size(49, 16);
            this.lbl_CardTribe.TabIndex = 19;
            this.lbl_CardTribe.Text = "Tribe:";
            // 
            // tbx_CardType
            // 
            this.tbx_CardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CardType.Location = new System.Drawing.Point(298, 41);
            this.tbx_CardType.Name = "tbx_CardType";
            this.tbx_CardType.Size = new System.Drawing.Size(243, 22);
            this.tbx_CardType.TabIndex = 18;
            // 
            // lbl_CardType
            // 
            this.lbl_CardType.AutoSize = true;
            this.lbl_CardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CardType.Location = new System.Drawing.Point(301, 22);
            this.lbl_CardType.Name = "lbl_CardType";
            this.lbl_CardType.Size = new System.Drawing.Size(48, 16);
            this.lbl_CardType.TabIndex = 17;
            this.lbl_CardType.Text = "Type:";
            // 
            // lbl_CardDescription
            // 
            this.lbl_CardDescription.AutoSize = true;
            this.lbl_CardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CardDescription.Location = new System.Drawing.Point(6, 143);
            this.lbl_CardDescription.Name = "lbl_CardDescription";
            this.lbl_CardDescription.Size = new System.Drawing.Size(79, 16);
            this.lbl_CardDescription.TabIndex = 16;
            this.lbl_CardDescription.Text = "Card Text:";
            // 
            // rtb_CardDescription
            // 
            this.rtb_CardDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtb_CardDescription.Location = new System.Drawing.Point(6, 162);
            this.rtb_CardDescription.Name = "rtb_CardDescription";
            this.rtb_CardDescription.Size = new System.Drawing.Size(255, 127);
            this.rtb_CardDescription.TabIndex = 15;
            this.rtb_CardDescription.Text = "";
            // 
            // llb_Help
            // 
            this.llb_Help.AutoSize = true;
            this.llb_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Help.Location = new System.Drawing.Point(226, 132);
            this.llb_Help.Name = "llb_Help";
            this.llb_Help.Size = new System.Drawing.Size(35, 13);
            this.llb_Help.TabIndex = 14;
            this.llb_Help.TabStop = true;
            this.llb_Help.Text = "Help?";
            this.llb_Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Help_LinkClicked);
            // 
            // tbx_ManaBase
            // 
            this.tbx_ManaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ManaBase.Location = new System.Drawing.Point(6, 107);
            this.tbx_ManaBase.Name = "tbx_ManaBase";
            this.tbx_ManaBase.Size = new System.Drawing.Size(255, 22);
            this.tbx_ManaBase.TabIndex = 13;
            // 
            // lbl_ManaBase
            // 
            this.lbl_ManaBase.AutoSize = true;
            this.lbl_ManaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ManaBase.Location = new System.Drawing.Point(6, 88);
            this.lbl_ManaBase.Name = "lbl_ManaBase";
            this.lbl_ManaBase.Size = new System.Drawing.Size(90, 16);
            this.lbl_ManaBase.TabIndex = 12;
            this.lbl_ManaBase.Text = "Mana Base:";
            // 
            // tbx_CardName
            // 
            this.tbx_CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CardName.Location = new System.Drawing.Point(9, 41);
            this.tbx_CardName.Name = "tbx_CardName";
            this.tbx_CardName.Size = new System.Drawing.Size(255, 22);
            this.tbx_CardName.TabIndex = 11;
            // 
            // lbl_CardName
            // 
            this.lbl_CardName.AutoSize = true;
            this.lbl_CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CardName.Location = new System.Drawing.Point(6, 22);
            this.lbl_CardName.Name = "lbl_CardName";
            this.lbl_CardName.Size = new System.Drawing.Size(90, 16);
            this.lbl_CardName.TabIndex = 0;
            this.lbl_CardName.Text = "Card Name:";
            // 
            // nud_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 593);
            this.Controls.Add(this.gpb_Cards);
            this.Controls.Add(this.Img_Logo);
            this.Controls.Add(this.gpb_Sets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nud_";
            this.Text = "Draft-Discard";
            this.gpb_Sets.ResumeLayout(false);
            this.gpb_Sets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).EndInit();
            this.gpb_Cards.ResumeLayout(false);
            this.gpb_Cards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardDefence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CardPower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_SetNames;
        private System.Windows.Forms.GroupBox gpb_Sets;
        private System.Windows.Forms.PictureBox Img_Logo;
        private System.Windows.Forms.Label lbl_ReleaseDatum;
        private System.Windows.Forms.DateTimePicker dtp_SetReleaseDate;
        private System.Windows.Forms.TextBox tbx_SetName;
        private System.Windows.Forms.Label lbl_SetName;
        private System.Windows.Forms.Button btn_AddSet;
        private System.Windows.Forms.Label lbl_Sets;
        private System.Windows.Forms.Button btn_RemoveSet;
        private System.Windows.Forms.Label lbl_ReleaseDates;
        private System.Windows.Forms.ListBox lsb_SetReleaeDates;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.GroupBox gpb_Cards;
        private System.Windows.Forms.Label lbl_CardName;
        private System.Windows.Forms.TextBox tbx_ManaBase;
        private System.Windows.Forms.Label lbl_ManaBase;
        private System.Windows.Forms.TextBox tbx_CardName;
        private System.Windows.Forms.LinkLabel llb_Help;
        private System.Windows.Forms.Label lbl_Power;
        private System.Windows.Forms.Label lbl_CardList;
        private System.Windows.Forms.ListBox lsb_Cards;
        private System.Windows.Forms.TextBox tbx_CardTribe;
        private System.Windows.Forms.Label lbl_CardTribe;
        private System.Windows.Forms.TextBox tbx_CardType;
        private System.Windows.Forms.Label lbl_CardType;
        private System.Windows.Forms.Label lbl_CardDescription;
        private System.Windows.Forms.RichTextBox rtb_CardDescription;
        private System.Windows.Forms.Button btn_RemoveCard;
        private System.Windows.Forms.Button btn_AddCard;
        private System.Windows.Forms.Label lbl_SeperatorSign;
        private System.Windows.Forms.NumericUpDown nud_CardDefence;
        private System.Windows.Forms.NumericUpDown nud_CardPower;
        private System.Windows.Forms.Label lbl_Defence;
        private System.Windows.Forms.TextBox tbx_Rarity;
        private System.Windows.Forms.Label lbl_Rarity;
    }
}

