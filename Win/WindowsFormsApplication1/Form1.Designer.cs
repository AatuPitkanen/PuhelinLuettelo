using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void BuildDataGrid()
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.henkilötToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asunnotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.henkiloID = new System.Windows.Forms.TextBox();
            this.henkiloEtunimi = new System.Windows.Forms.TextBox();
            this.henkiloSukunimi = new System.Windows.Forms.TextBox();
            this.henkiloSukupuoli = new System.Windows.Forms.ComboBox();
            this.henkiloAsunto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.asuntoOsoite = new System.Windows.Forms.TextBox();
            this.asuntoAla = new System.Windows.Forms.TextBox();
            this.asuntoHuoneet = new System.Windows.Forms.TextBox();
            this.asuntoTyyppi = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.asuntoOmistus = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.henkiloSyntyma = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.asuntoId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.henkiloID_poista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.asuntoID_poista = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.henkiloMId = new System.Windows.Forms.TextBox();
            this.asuntoMenu = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 344);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.newTabToolStripMenuItem,
            this.ShowToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.tiedostoToolStripMenuItem.Text = "FIle";
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.lopetaToolStripMenuItem.Text = "Exit";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combinationToolStripMenuItem});
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.newTabToolStripMenuItem.Text = "Testi";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // combinationToolStripMenuItem
            // 
            this.combinationToolStripMenuItem.Name = "combinationToolStripMenuItem";
            this.combinationToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.combinationToolStripMenuItem.Text = "Combination";
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.henkilötToolStripMenuItem,
            this.asunnotToolStripMenuItem});
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ShowToolStripMenuItem.Text = "Show";
            // 
            // henkilötToolStripMenuItem
            // 
            this.henkilötToolStripMenuItem.Name = "henkilötToolStripMenuItem";
            this.henkilötToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.henkilötToolStripMenuItem.Text = "Henkilöt";
            this.henkilötToolStripMenuItem.Click += new System.EventHandler(this.henkilötToolStripMenuItem_Click);
            // 
            // asunnotToolStripMenuItem
            // 
            this.asunnotToolStripMenuItem.Name = "asunnotToolStripMenuItem";
            this.asunnotToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.asunnotToolStripMenuItem.Text = "Asunnot";
            this.asunnotToolStripMenuItem.Click += new System.EventHandler(this.asunnotToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.HelpToolStripMenuItem.Text = "Credits";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AatuToolStripMenuItem});
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // AatuToolStripMenuItem
            // 
            this.AatuToolStripMenuItem.Name = "AatuToolStripMenuItem";
            this.AatuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.AatuToolStripMenuItem.Text = "Aatu Pitkänen G3315";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sukupuoli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asunto";
            // 
            // henkiloID
            // 
            this.henkiloID.Location = new System.Drawing.Point(8, 29);
            this.henkiloID.Name = "henkiloID";
            this.henkiloID.Size = new System.Drawing.Size(23, 20);
            this.henkiloID.TabIndex = 5;
            this.henkiloID.TextChanged += new System.EventHandler(this.henkiloID_TextChanged);
            // 
            // henkiloEtunimi
            // 
            this.henkiloEtunimi.Location = new System.Drawing.Point(37, 29);
            this.henkiloEtunimi.Name = "henkiloEtunimi";
            this.henkiloEtunimi.Size = new System.Drawing.Size(77, 20);
            this.henkiloEtunimi.TabIndex = 5;
            // 
            // henkiloSukunimi
            // 
            this.henkiloSukunimi.Location = new System.Drawing.Point(120, 29);
            this.henkiloSukunimi.Name = "henkiloSukunimi";
            this.henkiloSukunimi.Size = new System.Drawing.Size(152, 20);
            this.henkiloSukunimi.TabIndex = 5;
            // 
            // henkiloSukupuoli
            // 
            this.henkiloSukupuoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.henkiloSukupuoli.FormattingEnabled = true;
            this.henkiloSukupuoli.Location = new System.Drawing.Point(390, 28);
            this.henkiloSukupuoli.Name = "henkiloSukupuoli";
            this.henkiloSukupuoli.Size = new System.Drawing.Size(68, 21);
            this.henkiloSukupuoli.TabIndex = 6;
            // 
            // henkiloAsunto
            // 
            this.henkiloAsunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.henkiloAsunto.FormattingEnabled = true;
            this.henkiloAsunto.Location = new System.Drawing.Point(479, 28);
            this.henkiloAsunto.Name = "henkiloAsunto";
            this.henkiloAsunto.Size = new System.Drawing.Size(194, 21);
            this.henkiloAsunto.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lisää Henkilö";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Osoite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tyyppi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pinta-ala";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Huonelkm";
            // 
            // asuntoOsoite
            // 
            this.asuntoOsoite.Location = new System.Drawing.Point(59, 29);
            this.asuntoOsoite.Name = "asuntoOsoite";
            this.asuntoOsoite.Size = new System.Drawing.Size(210, 20);
            this.asuntoOsoite.TabIndex = 5;
            // 
            // asuntoAla
            // 
            this.asuntoAla.Location = new System.Drawing.Point(332, 29);
            this.asuntoAla.Name = "asuntoAla";
            this.asuntoAla.Size = new System.Drawing.Size(50, 20);
            this.asuntoAla.TabIndex = 5;
            // 
            // asuntoHuoneet
            // 
            this.asuntoHuoneet.Location = new System.Drawing.Point(275, 30);
            this.asuntoHuoneet.Name = "asuntoHuoneet";
            this.asuntoHuoneet.Size = new System.Drawing.Size(51, 20);
            this.asuntoHuoneet.TabIndex = 5;
            // 
            // asuntoTyyppi
            // 
            this.asuntoTyyppi.Cursor = System.Windows.Forms.Cursors.Default;
            this.asuntoTyyppi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asuntoTyyppi.FormattingEnabled = true;
            this.asuntoTyyppi.Location = new System.Drawing.Point(511, 29);
            this.asuntoTyyppi.Name = "asuntoTyyppi";
            this.asuntoTyyppi.Size = new System.Drawing.Size(157, 21);
            this.asuntoTyyppi.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lisää Asunto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // asuntoOmistus
            // 
            this.asuntoOmistus.AutoSize = true;
            this.asuntoOmistus.Location = new System.Drawing.Point(388, 29);
            this.asuntoOmistus.Name = "asuntoOmistus";
            this.asuntoOmistus.Size = new System.Drawing.Size(95, 17);
            this.asuntoOmistus.TabIndex = 8;
            this.asuntoOmistus.Text = "Omistusasunto";
            this.asuntoOmistus.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 377);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 95);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.henkiloSyntyma);
            this.tabPage1.Controls.Add(this.henkiloID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.henkiloAsunto);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.henkiloSukupuoli);
            this.tabPage1.Controls.Add(this.henkiloEtunimi);
            this.tabPage1.Controls.Add(this.henkiloSukunimi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 69);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uusi henkilö";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // henkiloSyntyma
            // 
            this.henkiloSyntyma.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.henkiloSyntyma.Location = new System.Drawing.Point(278, 26);
            this.henkiloSyntyma.MaxDate = new System.DateTime(2014, 12, 18, 0, 0, 0, 0);
            this.henkiloSyntyma.MinDate = new System.DateTime(1920, 12, 14, 0, 0, 0, 0);
            this.henkiloSyntyma.Name = "henkiloSyntyma";
            this.henkiloSyntyma.Size = new System.Drawing.Size(106, 20);
            this.henkiloSyntyma.TabIndex = 8;
            this.henkiloSyntyma.Value = new System.DateTime(2014, 12, 18, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Syntymäaika";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.asuntoId);
            this.tabPage2.Controls.Add(this.asuntoOsoite);
            this.tabPage2.Controls.Add(this.asuntoOmistus);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.asuntoTyyppi);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.asuntoHuoneet);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.asuntoAla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 69);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uusi asunto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // asuntoId
            // 
            this.asuntoId.Location = new System.Drawing.Point(11, 29);
            this.asuntoId.Name = "asuntoId";
            this.asuntoId.Size = new System.Drawing.Size(42, 20);
            this.asuntoId.TabIndex = 5;
            this.asuntoId.TextChanged += new System.EventHandler(this.asuntoId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.henkiloID_poista);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 69);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Poista henkilö";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // henkiloID_poista
            // 
            this.henkiloID_poista.Location = new System.Drawing.Point(12, 26);
            this.henkiloID_poista.Name = "henkiloID_poista";
            this.henkiloID_poista.Size = new System.Drawing.Size(58, 20);
            this.henkiloID_poista.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Henkilön Id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Poista henkilö";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.asuntoID_poista);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(676, 69);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Poista asunto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // asuntoID_poista
            // 
            this.asuntoID_poista.Location = new System.Drawing.Point(21, 30);
            this.asuntoID_poista.Name = "asuntoID_poista";
            this.asuntoID_poista.Size = new System.Drawing.Size(56, 20);
            this.asuntoID_poista.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 39);
            this.button4.TabIndex = 1;
            this.button4.Text = "Poista asunto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "AsuntoId";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.henkiloMId);
            this.tabPage5.Controls.Add(this.asuntoMenu);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(676, 69);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Muokkaa..";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Asunto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "HenkilöID";
            // 
            // henkiloMId
            // 
            this.henkiloMId.Location = new System.Drawing.Point(9, 28);
            this.henkiloMId.Name = "henkiloMId";
            this.henkiloMId.Size = new System.Drawing.Size(51, 20);
            this.henkiloMId.TabIndex = 2;
            // 
            // asuntoMenu
            // 
            this.asuntoMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asuntoMenu.FormattingEnabled = true;
            this.asuntoMenu.Location = new System.Drawing.Point(66, 26);
            this.asuntoMenu.Name = "asuntoMenu";
            this.asuntoMenu.Size = new System.Drawing.Size(149, 21);
            this.asuntoMenu.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(221, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Valmis";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(676, 69);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem ShowToolStripMenuItem;
        private ToolStripMenuItem henkilötToolStripMenuItem;
        private ToolStripMenuItem asunnotToolStripMenuItem;
        private ToolStripMenuItem lopetaToolStripMenuItem;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox henkiloID;
        private TextBox henkiloEtunimi;
        private TextBox henkiloSukunimi;
        private ComboBox henkiloSukupuoli;
        private ComboBox henkiloAsunto;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox asuntoOsoite;
        private TextBox asuntoAla;
        private TextBox asuntoHuoneet;
        private ComboBox asuntoTyyppi;
        private Button button2;
        private CheckBox asuntoOmistus;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox asuntoId;
        private Label label9;
        private DateTimePicker henkiloSyntyma;
        private Label label11;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label12;
        private Button button3;
        private TextBox henkiloID_poista;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem AatuToolStripMenuItem;
        private Label label13;
        private TextBox asuntoID_poista;
        private Button button4;
        private TabPage tabPage5;
        private Label label15;
        private Label label14;
        private TextBox henkiloMId;
        private ComboBox asuntoMenu;
        private Button button5;
        private TabPage tabPage6;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolStripMenuItem combinationToolStripMenuItem;
    }
}

