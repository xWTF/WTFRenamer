﻿namespace WTFRenamer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ext = new System.Windows.Forms.CheckBox();
            this.checkBox_autosort = new System.Windows.Forms.CheckBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_bottom = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_top = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.replace_with = new System.Windows.Forms.ComboBox();
            this.match_regex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_start = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_incr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_length = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_list = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button_menu_unregister = new System.Windows.Forms.Button();
            this.button_menu_register = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_undo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_incr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_ext);
            this.groupBox1.Controls.Add(this.checkBox_autosort);
            this.groupBox1.Controls.Add(this.button_sort);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button_remove);
            this.groupBox1.Controls.Add(this.button_bottom);
            this.groupBox1.Controls.Add(this.button_down);
            this.groupBox1.Controls.Add(this.button_top);
            this.groupBox1.Controls.Add(this.button_up);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(359, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File List";
            // 
            // checkBox_ext
            // 
            this.checkBox_ext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_ext.AutoSize = true;
            this.checkBox_ext.Location = new System.Drawing.Point(377, 397);
            this.checkBox_ext.Name = "checkBox_ext";
            this.checkBox_ext.Size = new System.Drawing.Size(82, 21);
            this.checkBox_ext.TabIndex = 7;
            this.checkBox_ext.Text = "Extension";
            this.checkBox_ext.UseVisualStyleBackColor = true;
            this.checkBox_ext.CheckedChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // checkBox_autosort
            // 
            this.checkBox_autosort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_autosort.AutoSize = true;
            this.checkBox_autosort.Location = new System.Drawing.Point(253, 397);
            this.checkBox_autosort.Name = "checkBox_autosort";
            this.checkBox_autosort.Size = new System.Drawing.Size(118, 21);
            this.checkBox_autosort.TabIndex = 5;
            this.checkBox_autosort.Text = "Sort on new file";
            this.checkBox_autosort.UseVisualStyleBackColor = true;
            // 
            // button_sort
            // 
            this.button_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sort.Location = new System.Drawing.Point(10, 395);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 23);
            this.button_sort.TabIndex = 2;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear.Location = new System.Drawing.Point(172, 395);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_remove.Location = new System.Drawing.Point(91, 395);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_bottom
            // 
            this.button_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bottom.Location = new System.Drawing.Point(474, 226);
            this.button_bottom.Name = "button_bottom";
            this.button_bottom.Size = new System.Drawing.Size(26, 38);
            this.button_bottom.TabIndex = 0;
            this.button_bottom.TabStop = false;
            this.button_bottom.Text = "▼\r\n▼";
            this.button_bottom.UseCompatibleTextRendering = true;
            this.button_bottom.UseVisualStyleBackColor = true;
            this.button_bottom.Click += new System.EventHandler(this.button_bottom_Click);
            // 
            // button_down
            // 
            this.button_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_down.Location = new System.Drawing.Point(474, 197);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(26, 23);
            this.button_down.TabIndex = 0;
            this.button_down.TabStop = false;
            this.button_down.Text = "▼";
            this.button_down.UseCompatibleTextRendering = true;
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_top
            // 
            this.button_top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_top.Location = new System.Drawing.Point(474, 124);
            this.button_top.Name = "button_top";
            this.button_top.Size = new System.Drawing.Size(26, 38);
            this.button_top.TabIndex = 0;
            this.button_top.TabStop = false;
            this.button_top.Text = "▲\r\n▲";
            this.button_top.UseCompatibleTextRendering = true;
            this.button_top.UseVisualStyleBackColor = true;
            this.button_top.Click += new System.EventHandler(this.button_top_Click);
            // 
            // button_up
            // 
            this.button_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_up.Location = new System.Drawing.Point(474, 168);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(26, 23);
            this.button_up.TabIndex = 0;
            this.button_up.TabStop = false;
            this.button_up.Text = "▲";
            this.button_up.UseCompatibleTextRendering = true;
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 367);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView1_ColumnWidthChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preview";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Result";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 426);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.replace_with);
            this.tabPage1.Controls.Add(this.match_regex);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(333, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pattern";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // replace_with
            // 
            this.replace_with.FormattingEnabled = true;
            this.replace_with.Items.AddRange(new object[] {
            "$0",
            "[#]",
            "$1",
            "$1_$2",
            "[$1]$2"});
            this.replace_with.Location = new System.Drawing.Point(6, 71);
            this.replace_with.Name = "replace_with";
            this.replace_with.Size = new System.Drawing.Size(321, 25);
            this.replace_with.TabIndex = 2;
            this.replace_with.TextChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // match_regex
            // 
            this.match_regex.FormattingEnabled = true;
            this.match_regex.Items.AddRange(new object[] {
            ".+ \\[(.+?)\\].*",
            ".+ \\[(.+?)\\]\\[(.+?)\\].*",
            "第(\\d+?)話 (.*)"});
            this.match_regex.Location = new System.Drawing.Point(6, 23);
            this.match_regex.Name = "match_regex";
            this.match_regex.Size = new System.Drawing.Size(321, 25);
            this.match_regex.TabIndex = 1;
            this.match_regex.TextChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Replace With:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No Transform",
            "To Uppercase",
            "To Lowercase",
            "Reverse case"});
            this.comboBox1.Location = new System.Drawing.Point(90, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 25);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Letter Case:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown_start);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_incr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown_length);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numbering";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 5;
            // 
            // numericUpDown_start
            // 
            this.numericUpDown_start.Location = new System.Drawing.Point(84, 22);
            this.numericUpDown_start.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_start.Name = "numericUpDown_start";
            this.numericUpDown_start.Size = new System.Drawing.Size(98, 23);
            this.numericUpDown_start.TabIndex = 3;
            this.numericUpDown_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_start.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "# -> Numeric ID\r\n\\# -> #";
            // 
            // numericUpDown_incr
            // 
            this.numericUpDown_incr.Location = new System.Drawing.Point(84, 51);
            this.numericUpDown_incr.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown_incr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_incr.Name = "numericUpDown_incr";
            this.numericUpDown_incr.Size = new System.Drawing.Size(98, 23);
            this.numericUpDown_incr.TabIndex = 4;
            this.numericUpDown_incr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_incr.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Increment:";
            // 
            // numericUpDown_length
            // 
            this.numericUpDown_length.Location = new System.Drawing.Point(84, 80);
            this.numericUpDown_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_length.Name = "numericUpDown_length";
            this.numericUpDown_length.Size = new System.Drawing.Size(98, 23);
            this.numericUpDown_length.TabIndex = 5;
            this.numericUpDown_length.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_length.ValueChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filename Regex:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_list);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(333, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Text";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_list
            // 
            this.textBox_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_list.Location = new System.Drawing.Point(6, 6);
            this.textBox_list.Multiline = true;
            this.textBox_list.Name = "textBox_list";
            this.textBox_list.Size = new System.Drawing.Size(321, 384);
            this.textBox_list.TabIndex = 0;
            this.textBox_list.TextChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button_menu_unregister);
            this.tabPage2.Controls.Add(this.button_menu_register);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(333, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Copyright 2022 xWTF";
            // 
            // button_menu_unregister
            // 
            this.button_menu_unregister.Location = new System.Drawing.Point(6, 35);
            this.button_menu_unregister.Name = "button_menu_unregister";
            this.button_menu_unregister.Size = new System.Drawing.Size(180, 23);
            this.button_menu_unregister.TabIndex = 5;
            this.button_menu_unregister.Text = "Unregister Context Menu";
            this.button_menu_unregister.UseVisualStyleBackColor = true;
            this.button_menu_unregister.Click += new System.EventHandler(this.button_menu_unregister_Click);
            // 
            // button_menu_register
            // 
            this.button_menu_register.Location = new System.Drawing.Point(6, 6);
            this.button_menu_register.Name = "button_menu_register";
            this.button_menu_register.Size = new System.Drawing.Size(180, 23);
            this.button_menu_register.TabIndex = 5;
            this.button_menu_register.Text = "Register Context Menu";
            this.button_menu_register.UseVisualStyleBackColor = true;
            this.button_menu_register.Click += new System.EventHandler(this.button_menu_register_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(69, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(258, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Source code (AGPLv3) available on GitHub!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(726, 444);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(140, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_undo
            // 
            this.button_undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_undo.Enabled = false;
            this.button_undo.Location = new System.Drawing.Point(580, 444);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(140, 23);
            this.button_undo.TabIndex = 4;
            this.button_undo.Text = "Undo";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 478);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(894, 517);
            this.Name = "FormMain";
            this.Text = "WTF Renamer";
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_incr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button_down;
        private Button button_up;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button_clear;
        private Button button_remove;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown_start;
        private Label label5;
        private NumericUpDown numericUpDown_incr;
        private Label label4;
        private NumericUpDown numericUpDown_length;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private Button button_start;
        private CheckBox checkBox_ext;
        private Button button_bottom;
        private Button button_top;
        private Button button_undo;
        private LinkLabel linkLabel1;
        private TabPage tabPage2;
        private Button button_menu_register;
        private Label label9;
        private Button button_menu_unregister;
        private Button button_sort;
        private CheckBox checkBox_autosort;
        private TabPage tabPage3;
        private TextBox textBox_list;
        private ComboBox match_regex;
        private ComboBox replace_with;
    }
}