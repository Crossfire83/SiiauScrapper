namespace SIIAUScrapper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FormTab = new System.Windows.Forms.TabPage();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowRegistersCb = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.orderTypeCb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AulaTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EdificioTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SabadoChB = new System.Windows.Forms.CheckBox();
            this.ViernesChB = new System.Windows.Forms.CheckBox();
            this.JuevesChB = new System.Windows.Forms.CheckBox();
            this.MiercolesChB = new System.Windows.Forms.CheckBox();
            this.MartesChB = new System.Windows.Forms.CheckBox();
            this.LunesChB = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HoraFinTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HoraInicioTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MateriaTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClaveTb = new System.Windows.Forms.TextBox();
            this.CarreraCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CentroCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CicloTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowserTab = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.FormTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BrowserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FormTab);
            this.tabControl1.Controls.Add(this.BrowserTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 456);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // FormTab
            // 
            this.FormTab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormTab.Controls.Add(this.SearchButton);
            this.FormTab.Controls.Add(this.ShowRegistersCb);
            this.FormTab.Controls.Add(this.label17);
            this.FormTab.Controls.Add(this.orderTypeCb);
            this.FormTab.Controls.Add(this.label16);
            this.FormTab.Controls.Add(this.groupBox2);
            this.FormTab.Controls.Add(this.groupBox1);
            this.FormTab.Controls.Add(this.CarreraCb);
            this.FormTab.Controls.Add(this.label3);
            this.FormTab.Controls.Add(this.CentroCb);
            this.FormTab.Controls.Add(this.label2);
            this.FormTab.Controls.Add(this.CicloTb);
            this.FormTab.Controls.Add(this.label1);
            this.FormTab.Location = new System.Drawing.Point(4, 22);
            this.FormTab.Name = "FormTab";
            this.FormTab.Padding = new System.Windows.Forms.Padding(3);
            this.FormTab.Size = new System.Drawing.Size(569, 430);
            this.FormTab.TabIndex = 0;
            this.FormTab.Text = "Formulario";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(23, 371);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(521, 36);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Buscar Disponibles";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowRegistersCb
            // 
            this.ShowRegistersCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRegistersCb.FormattingEnabled = true;
            this.ShowRegistersCb.Items.AddRange(new object[] {
            "100 en 100",
            "200 en 200",
            "500 en 500"});
            this.ShowRegistersCb.Location = new System.Drawing.Point(120, 322);
            this.ShowRegistersCb.Name = "ShowRegistersCb";
            this.ShowRegistersCb.Size = new System.Drawing.Size(135, 21);
            this.ShowRegistersCb.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 323);
            this.label17.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "Mostrar de:";
            // 
            // orderTypeCb
            // 
            this.orderTypeCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTypeCb.FormattingEnabled = true;
            this.orderTypeCb.Items.AddRange(new object[] {
            "MATERIA",
            "CLAVE DEL CURSO",
            "NRC"});
            this.orderTypeCb.Location = new System.Drawing.Point(120, 288);
            this.orderTypeCb.Name = "orderTypeCb";
            this.orderTypeCb.Size = new System.Drawing.Size(135, 21);
            this.orderTypeCb.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 289);
            this.label16.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ordenar por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horario";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AulaTb);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.EdificioTb);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(383, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 69);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lugar";
            // 
            // AulaTb
            // 
            this.AulaTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AulaTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AulaTb.Location = new System.Drawing.Point(79, 39);
            this.AulaTb.Name = "AulaTb";
            this.AulaTb.Size = new System.Drawing.Size(59, 21);
            this.AulaTb.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Aula";
            // 
            // EdificioTb
            // 
            this.EdificioTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EdificioTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdificioTb.Location = new System.Drawing.Point(14, 39);
            this.EdificioTb.Name = "EdificioTb";
            this.EdificioTb.Size = new System.Drawing.Size(59, 21);
            this.EdificioTb.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Edificio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SabadoChB);
            this.groupBox4.Controls.Add(this.ViernesChB);
            this.groupBox4.Controls.Add(this.JuevesChB);
            this.groupBox4.Controls.Add(this.MiercolesChB);
            this.groupBox4.Controls.Add(this.MartesChB);
            this.groupBox4.Controls.Add(this.LunesChB);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(183, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 69);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dias";
            // 
            // SabadoChB
            // 
            this.SabadoChB.AutoSize = true;
            this.SabadoChB.Location = new System.Drawing.Point(160, 43);
            this.SabadoChB.Name = "SabadoChB";
            this.SabadoChB.Size = new System.Drawing.Size(15, 14);
            this.SabadoChB.TabIndex = 11;
            this.SabadoChB.UseVisualStyleBackColor = true;
            // 
            // ViernesChB
            // 
            this.ViernesChB.AutoSize = true;
            this.ViernesChB.Location = new System.Drawing.Point(132, 43);
            this.ViernesChB.Name = "ViernesChB";
            this.ViernesChB.Size = new System.Drawing.Size(15, 14);
            this.ViernesChB.TabIndex = 10;
            this.ViernesChB.UseVisualStyleBackColor = true;
            // 
            // JuevesChB
            // 
            this.JuevesChB.AutoSize = true;
            this.JuevesChB.Location = new System.Drawing.Point(105, 43);
            this.JuevesChB.Name = "JuevesChB";
            this.JuevesChB.Size = new System.Drawing.Size(15, 14);
            this.JuevesChB.TabIndex = 9;
            this.JuevesChB.UseVisualStyleBackColor = true;
            // 
            // MiercolesChB
            // 
            this.MiercolesChB.AutoSize = true;
            this.MiercolesChB.Location = new System.Drawing.Point(75, 43);
            this.MiercolesChB.Name = "MiercolesChB";
            this.MiercolesChB.Size = new System.Drawing.Size(15, 14);
            this.MiercolesChB.TabIndex = 8;
            this.MiercolesChB.UseVisualStyleBackColor = true;
            // 
            // MartesChB
            // 
            this.MartesChB.AutoSize = true;
            this.MartesChB.Location = new System.Drawing.Point(45, 43);
            this.MartesChB.Name = "MartesChB";
            this.MartesChB.Size = new System.Drawing.Size(15, 14);
            this.MartesChB.TabIndex = 7;
            this.MartesChB.UseVisualStyleBackColor = true;
            // 
            // LunesChB
            // 
            this.LunesChB.AutoSize = true;
            this.LunesChB.Location = new System.Drawing.Point(12, 43);
            this.LunesChB.Name = "LunesChB";
            this.LunesChB.Size = new System.Drawing.Size(15, 14);
            this.LunesChB.TabIndex = 6;
            this.LunesChB.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "SA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "VI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "JU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "MI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "MA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "LU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HoraFinTb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.HoraInicioTb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 69);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hora";
            // 
            // HoraFinTb
            // 
            this.HoraFinTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraFinTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoraFinTb.Location = new System.Drawing.Point(79, 39);
            this.HoraFinTb.Name = "HoraFinTb";
            this.HoraFinTb.Size = new System.Drawing.Size(59, 21);
            this.HoraFinTb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fin";
            // 
            // HoraInicioTb
            // 
            this.HoraInicioTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraInicioTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoraInicioTb.Location = new System.Drawing.Point(14, 39);
            this.HoraInicioTb.Name = "HoraInicioTb";
            this.HoraInicioTb.Size = new System.Drawing.Size(59, 21);
            this.HoraInicioTb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Inicio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MateriaTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ClaveTb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materia";
            // 
            // MateriaTb
            // 
            this.MateriaTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MateriaTb.Location = new System.Drawing.Point(95, 44);
            this.MateriaTb.Name = "MateriaTb";
            this.MateriaTb.Size = new System.Drawing.Size(441, 21);
            this.MateriaTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave";
            // 
            // ClaveTb
            // 
            this.ClaveTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClaveTb.Location = new System.Drawing.Point(15, 44);
            this.ClaveTb.Name = "ClaveTb";
            this.ClaveTb.Size = new System.Drawing.Size(51, 21);
            this.ClaveTb.TabIndex = 7;
            // 
            // CarreraCb
            // 
            this.CarreraCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarreraCb.FormattingEnabled = true;
            this.CarreraCb.Items.AddRange(new object[] {
            "BIM - LIC EN ING. BIOMEDICA",
            "CEL - LIC EN ING. EN COM.Y ELEC.",
            "CIV - LIC EN ING. CIVIL",
            "COM - LIC EN ING. EN COMPUTACION",
            "DCEC - DOC. EN CIEN. DE LA ELEC. Y LA",
            "DCFI - DOC EN CIENCIAS EN FISIC",
            "DCM - DOC EN CIENCIA DE MATERI",
            "DCPB - DOC EN CS EN PROCESOS BIOTEC",
            "DDCM - DOC DIRECTO EN CIENCIA E",
            "DOCQ - DOC EN CIENCIAS EN QUIMICA",
            "DOEC - DOCT.EN CS.DE LA ELECT.Y COMP.",
            "DUBI - DOCTORADO EN CIENCIAS EN PROCE",
            "DUCE - DOCTORADO EN CIENCIAS EN INGEN",
            "DUCF - DOCTORADO EN CIENCIAS EN FISIC",
            "DUCI - DOCTORADO EN CIENCIAS EN FISIC",
            "DUCQ - DOCTORADO EN CIENCIAS EN INGEN",
            "DUFS - DOCTORADO EN CIENCIAS EN FISIC",
            "DUHD - DOC EN CS EN HIDROMETEOROLOGIA",
            "DUIQ - DOCTORADO EN CIENCIAS EN INGEN",
            "DUPB - DOCTORADO EN CIENCIAS EN PROCE",
            "DUPR - DOC EN CIENCIAS EN PROCE",
            "DUPT - DOCTORADO EN CIENCIAS EN PROCE",
            "DVIT - DOCTORADO EN INGENIERIA Y TECN",
            "FIS - LIC EN FISICA",
            "ICI - MAE EN CS EN INGENIER",
            "ICIV - INGENIERIA CIVIL",
            "ICT - MAE EN CS DE LA TIERRA",
            "IGFO - INGENIERIA FOTONICA",
            "IIE - MAE EN INGENIERIA ELECTRICA",
            "IIP - MAE EN ING. DE PROYECTOS",
            "INAB - LIC EN ING. EN ALIMENTOS Y BI",
            "INBI - ING BIOMEDICA",
            "INCE - ING EN COMUNICACIONES Y ELECTR",
            "INCO - ING EN COMPUTACION",
            "IND - LIC ING. INDUSTRIAL",
            "INDU - ING INDUSTRIAL",
            "INF - LIC EN INFORMATICA",
            "INFC - LIC EN INFORMATICA SIST COMPU",
            "INFI - LIC EN INFORMATICA SIST INFOR",
            "INME - ING MECANICA ELECTRICA",
            "INNI - ING INFORMATICA",
            "INQU - ING QUIMICA",
            "INRO - INGENIERIA ROBOTICA",
            "IPF - MAE EN CS PRODUCTOS FORESTA",
            "IQU - LIC EN ING. QUIMICA",
            "ITOG - ING. EN TOPOGRAFIA GEOMATICA",
            "LCMA - LIC. EN CIENCIA DE MATERIALES",
            "LIFI - LIC EN FISICA",
            "LIMA - LIC EN MATEMATICAS",
            "LINA - LIC EN ING EN ALIMENTOS Y BIOT",
            "LQFB - LIC EN QUIMICO FARMACE BIOLOGO",
            "LQUI - LIC EN QUIMICA",
            "MAAF - MAE.EN.CS.EN ING.ELECTRO ORIEN",
            "MAIE - MAE.CS.EN ING.ELECTRICA",
            "MAII - MAE.EN CIENCIAS EN ING.ELECT.O",
            "MAPB - MAE. EN CIEN. EN PROC. BIOTECN",
            "MAT - LIC EN MATEMATICAS",
            "MCAL - MAE EN CS DE LOS ALIMENTOS",
            "MCCA - MAE EN CONTROL DE LA CONT",
            "MCFI - MAE EN CS EN FISICA",
            "MCM - MAE EN CIENCIA DE MATERIALES",
            "MEL - LIC EN ING. MECANICA ELECTRICA",
            "MEMA - MAE.EN ENSE~ANZA D MATE",
            "MIAL - MAE EN CS DE LOS ALIMENTOS",
            "MIAP - MAE EN TECNOLOGIA PARA EL",
            "MIBI - MAE EN CS EN PROCVE",
            "MICN - MAE EN CS EN INGENI",
            "MICQ - MAE EN CS EN QUIMICA",
            "MICR - MAE EN CS EN MICRO E IO",
            "MIEC - MAE EN CS EN ING. ELECTRONICA",
            "MIEM - MAE EN CS EN LA ENS",
            "MIET - MAE EN CS EN INGENI",
            "MIFA - MAE EN FARMACIA",
            "MIFI - MAE EN CS EN FISICA",
            "MIFM - MAE EN CS EN FARMAC",
            "MIFR - MAE EN FARMACIA",
            "MIFS - MAE EN CS EN FISICA",
            "MIHD - MAE EN CS EN HIDROM",
            "MIHI - MAE EN CS EN HIDROM",
            "MIIE - MAE EN CS EN INGENI",
            "MIIG - MAE EN CS EN INGENI",
            "MIIM - POSGRADO EN INGENIERIA MECANIC",
            "MIIN - MAE EN INGENIERIA ELECTRI",
            "MIIQ - MAE EN CS EN INGENI",
            "MILI - MAE EN CS DE LOS ALIMENTOS",
            "MIMC - MAE EN INGENIERIA MECANIC",
            "MIMT - MAE EN ENSE~ANZA DE LAS M",
            "MIPA - MAE EN PROTECCION AMBIENT",
            "MIPB - MAE EN CS EN PROCES",
            "MIPF - MAE EN CIENCIA DE PRODUC FORES",
            "MIPR - MAE EN CS EN PROCES",
            "MIPT - MAE EN CS EN PROCESOS BIOTEC.",
            "MIQA - MAE EN CS EN QUIMICA",
            "MIQC - MAE EN QUIMICA CLINICA",
            "MIQI - MAE EN QUIMICA CLINICA",
            "MIQM - MAE EN CS EN INGENI",
            "MIQU - MAE EN CS EN QUIMICA",
            "MISC - MAE EN SISTEMAS DE CALIDA",
            "MISE - MAE EN CS EN INGENI",
            "MISI - MAE EN SISTEMAS DE INFORM",
            "MITA - MAE EN TECNOLOGIA PARA EL",
            "MITE - MAE EN CS EN MATEMA",
            "MITL - MAE EN TECNOLOGIAS PARA E",
            "MIVA - MAE EN VALUACION",
            "MMHA - MAE EN MICROBIOLOGIA E HI",
            "MPFO - MAE EN CS DE PRODUC",
            "MPTE - MAESTRIA EN PROYECTOS TECNOLOG",
            "PEC - TEC SUP UNIVERSITARIO ELECTRO",
            "PEL - TEC. SUP. UNI. EN ELECTRONICA",
            "PHE - TEC. SUP. UNI. EN HERRAMENTALE",
            "PIN - TEC. SUP. UNI. EN INFORMATICA",
            "PIP - TEC. SUP. UNI. EN INY. DE PLAS",
            "PME - TEC. SUP. UNI. EN METEOROLOGIA",
            "PRC - TEC. SUP. UNI. EN REDES DE COM",
            "PSS - TEC. SUP. UNI. EN SISTEMAS DEC",
            "QFB - LIC EN QUIM.FARMACOBIOLOGO",
            "QUI - LIC EN QUIMICA",
            "RDCI - DOCTORADO EN CIENCIAS EN INGEN",
            "RDIQ - DOCTORADO EN CIENCIAS EN INGEN",
            "RMAN - MAE EN ANALISIS DE SIST IND",
            "RMCI - MAE EN CS EN INGENI",
            "RMEM - MAE EN CS ENSE~ANZA D LAS MAT",
            "RMIC - MAE EN CS DE LA ING",
            "RMIQ - MAE EN CS EN INGENI",
            "RMMA - MAE EN CS EN LA ENS",
            "RMPF - MAE EN CS DE PRODUC",
            "RMQC - MAE EN QUIMICA CLINICA",
            "RMSI - MAE EN SISTEMAS DE INFORM",
            "TOP - LIC ING. TOPOGRAFICA",
            "UCT - DOC EN CS DE LA TIERRA",
            "XEF - ESP EN FARMACIA",
            "XVA - ESP EN VALUACION",
            "XVAL - ESP EN VALUACION"});
            this.CarreraCb.Location = new System.Drawing.Point(83, 63);
            this.CarreraCb.Name = "CarreraCb";
            this.CarreraCb.Size = new System.Drawing.Size(255, 21);
            this.CarreraCb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carrera:";
            // 
            // CentroCb
            // 
            this.CentroCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CentroCb.FormattingEnabled = true;
            this.CentroCb.Items.AddRange(new object[] {
            "A - CUAAD",
            "B - CUCBA",
            "C - CUCEA",
            "D - CUCEI",
            "E - CUCS",
            "F - CUCSH",
            "G - CUALTOS",
            "H - CUCIENEGA",
            "I - CUCOSTA",
            "J - CUCSUR",
            "K - CUSUR",
            "M - CUVALLES",
            "N - CUNORTE",
            "O - CUCEI SEDE VALLES",
            "P - CUCSUR SEDE VALLES",
            "Q - CUCEI SEDE NORTE",
            "R - CUALTOS SEDE NORTE",
            "S - CUCOSTA SEDE NORTE",
            "T - CUSUR SEDE NORTE",
            "U - CULAGOS"});
            this.CentroCb.Location = new System.Drawing.Point(83, 40);
            this.CentroCb.Name = "CentroCb";
            this.CentroCb.Size = new System.Drawing.Size(255, 21);
            this.CentroCb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Centro:";
            // 
            // CicloTb
            // 
            this.CicloTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CicloTb.Enabled = false;
            this.CicloTb.Location = new System.Drawing.Point(82, 17);
            this.CicloTb.Name = "CicloTb";
            this.CicloTb.Size = new System.Drawing.Size(100, 20);
            this.CicloTb.TabIndex = 1;
            this.CicloTb.Text = "201710";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclo:";
            // 
            // BrowserTab
            // 
            this.BrowserTab.Controls.Add(this.webBrowser1);
            this.BrowserTab.Location = new System.Drawing.Point(4, 22);
            this.BrowserTab.Name = "BrowserTab";
            this.BrowserTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserTab.Size = new System.Drawing.Size(569, 430);
            this.BrowserTab.TabIndex = 1;
            this.BrowserTab.Text = "Navegador";
            this.BrowserTab.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(563, 424);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(577, 456);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SIIAU Scrapper";
            this.tabControl1.ResumeLayout(false);
            this.FormTab.ResumeLayout(false);
            this.FormTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BrowserTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FormTab;
        private System.Windows.Forms.TextBox ClaveTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarreraCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CentroCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CicloTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage BrowserTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HoraFinTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HoraInicioTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MateriaTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox ShowRegistersCb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox orderTypeCb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox AulaTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EdificioTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox SabadoChB;
        private System.Windows.Forms.CheckBox ViernesChB;
        private System.Windows.Forms.CheckBox JuevesChB;
        private System.Windows.Forms.CheckBox MiercolesChB;
        private System.Windows.Forms.CheckBox MartesChB;
        private System.Windows.Forms.CheckBox LunesChB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

