//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Limnor Studio.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefaultNamespace
{
    using System;
    using System.Xml;
    using System.Text;
    using System.Collections.Generic;
    using Limnor.Drawing2D;
    using System.Windows.Forms;
    using System.IO;
    using System.Drawing;
    using System.Windows.Forms.Design;
    using System.ComponentModel;
    using Limnor.InputDevice;
    using Limnor.Application;
    using System.CodeDom;
    using Limnor.Windows;
    
    public class Form1 : Limnor.Drawing2D.DrawingPage
    {
        protected internal System.Windows.Forms.Button ButtonInsert;
        protected internal System.Windows.Forms.Button ButtonName;
        protected internal System.Windows.Forms.Label Label10;
        protected internal System.Windows.Forms.Label Label9;
        protected internal System.Windows.Forms.GroupBox GroupBox1;
        protected internal System.Windows.Forms.Label Label8;
        protected internal System.Windows.Forms.Label Label7;
        protected internal System.Windows.Forms.Label Label6;
        protected internal System.Windows.Forms.Label Label4;
        protected internal System.Windows.Forms.Label Label5;
        protected internal System.Windows.Forms.Button btInsert;
        protected internal System.Windows.Forms.TextBox txtName;
        protected internal System.Windows.Forms.Label Label3;
        protected internal System.Windows.Forms.TextBox txtIndex;
        protected internal System.Windows.Forms.Label Label2;
        protected internal System.Windows.Forms.Button btFolder;
        protected internal System.Windows.Forms.Label Label1;
        protected internal System.Windows.Forms.TextBox txtFolder;
        protected internal Limnor.InputDevice.Keyboard Keyboard1;
        protected internal Limnor.Application.ApplicationConfiguration ApplicationConfiguration1;
        protected internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.ComponentModel.IContainer components;
        protected internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        protected internal System.Windows.Forms.ToolStripMenuItem ShowSettingsMenuItem;
        protected internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2147483646;
        protected internal System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        protected internal System.Windows.Forms.ToolStripMenuItem mi1e23a49e;
        protected internal Limnor.Windows.WindowsManager WindowsManager1;
        private static Form1 _DefaultForm;
        private bool valueOfAddingSlide;
        /// <summary>
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }
        public static Form1 DefaultForm
        {
            get
            {
                if (((_DefaultForm == null) 
                            || (_DefaultForm.IsDisposed || _DefaultForm.Disposing)))
                {
                    _DefaultForm = new Form1();
                }
                return _DefaultForm;
            }
        }
        public virtual string ImageFilename
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[] {
                            this.txtName.Text,
                            "_",
                            this.txtIndex.Text,
                            ".jpg"});
            }
        }
        public virtual string SlideImageFullPath
        {
            get
            {
                return System.IO.Path.Combine(this.txtFolder.Text, this.ImageFilename);
            }
        }
        public virtual string SlideFilename
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[] {
                            this.txtName.Text,
                            "_",
                            this.txtIndex.Text,
                            ".xml"});
            }
        }
        public virtual string SlideFullPath
        {
            get
            {
                return System.IO.Path.Combine(this.txtFolder.Text, this.SlideFilename);
            }
        }
        /// <summary>
        /// When hot keys are pressed, set this property to true to disable the handling of hot keys before current hot key is handled
        /// </summary>
        public virtual bool AddingSlide
        {
            get
            {
                return this.valueOfAddingSlide;
            }
            set
            {
                this.valueOfAddingSlide = value;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.ButtonName = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btFolder = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.Keyboard1 = new Limnor.InputDevice.Keyboard();
            this.ApplicationConfiguration1 = new Limnor.Application.ApplicationConfiguration();
            this.components = new System.ComponentModel.Container();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mi1e23a49e = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WindowsManager1 = new Limnor.Windows.WindowsManager(this.components);
            this.ToolStripMenuItem2147483646 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(256, 62);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(75, 23);
            this.ButtonInsert.TabIndex = 34;
            this.ButtonInsert.Text = "Insert Slide";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.Click_ad2f4fda);
            // 
            // ButtonName
            // 
            this.ButtonName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonName.Location = new System.Drawing.Point(341, 36);
            this.ButtonName.Name = "ButtonName";
            this.ButtonName.Size = new System.Drawing.Size(29, 23);
            this.ButtonName.TabIndex = 31;
            this.ButtonName.Text = "...";
            this.ButtonName.UseVisualStyleBackColor = true;
            this.ButtonName.Click += new System.EventHandler(this.Click_a5d061c7);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(12, 128);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(215, 13);
            this.Label10.TabIndex = 30;
            this.Label10.Text = "Slide # starts from 1 and sequentially go up..";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(12, 104);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(267, 13);
            this.Label9.TabIndex = 29;
            this.Label9.Text = "In one slide-show, all slides have the same Slide Name.";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Location = new System.Drawing.Point(15, 150);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(348, 126);
            this.GroupBox1.TabIndex = 26;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "How to create slides";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 100);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(313, 13);
            this.Label8.TabIndex = 26;
            this.Label8.Text = "3. Add texts, lines, arrows, etc., to the captured image as needed";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(16, 83);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(292, 13);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "You may cancel the clipping and redo the clipping if needed.";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(6, 66);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(278, 13);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "2. Use the mouse to clip the captured image, if you want. ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(298, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "1. Keep the mouse over the window to be captured, press F3.";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(202, 13);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Or, press F4 to capture the whole screen.";
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(175, 62);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 17;
            this.btInsert.Text = "Edit Slide";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.Click_9a8faed9);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(100, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 12;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 45);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Slide Name:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(100, 64);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(69, 20);
            this.txtIndex.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Next Slide #:";
            // 
            // btFolder
            // 
            this.btFolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btFolder.Location = new System.Drawing.Point(341, 11);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(29, 23);
            this.btFolder.TabIndex = 4;
            this.btFolder.Text = "...";
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.Click_d2e530ca);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Save to Folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(100, 14);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(235, 20);
            this.txtFolder.TabIndex = 2;
            // 
            // Keyboard1
            // 
            this.Keyboard1.HotKeys = ((Limnor.InputDevice.HotKeyList)(resources.GetObject("Keyboard1.HotKeys")));
            this.Keyboard1.Location = new System.Drawing.Point(249, 128);
            this.Keyboard1.Name = "Keyboard1";
            this.Keyboard1.GetEventHolder("KeyPress_F4").Event += new System.EventHandler(this.KeyPress_F4_8b2ce384);
            this.Keyboard1.GetEventHolder("KeyPress_F3").Event += new System.EventHandler(this.KeyPress_F3_3b54cbf2);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.BalloonTipText = "Catch screenshot";
            this.NotifyIcon1.BalloonTipTitle = "Catch screenshot";
            this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "ScreenShot";
            this.NotifyIcon1.Visible = true;
            // 
            // mi1e23a49e
            // 
            this.mi1e23a49e.BackColor = System.Drawing.SystemColors.Window;
            this.mi1e23a49e.Name = "mi1e23a49e";
            this.mi1e23a49e.Size = new System.Drawing.Size(106, 20);
            this.mi1e23a49e.Text = "ContextMenuStrip";
            // 
            // ShowSettingsMenuItem
            // 
            this.ShowSettingsMenuItem.Name = "ShowSettingsMenuItem";
            this.ShowSettingsMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ShowSettingsMenuItem.Text = "Show Settings";
            this.ShowSettingsMenuItem.Click += new System.EventHandler(this.Click_8f7ed9a5);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                        this.ShowSettingsMenuItem,
                        this.ToolStripMenuItem2147483646,
                        this.ExitMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(149, 54);
            // 
            // WindowsManager1
            // 
            this.WindowsManager1.FoundWindow = System.IntPtr.Zero;
            this.WindowsManager1.WindowBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.WindowsManager1.WindowLocation = new System.Drawing.Point(0, 0);
            this.WindowsManager1.WindowSize = new System.Drawing.Size(0, 0);
            // 
            // ToolStripMenuItem2147483646
            // 
            this.ToolStripMenuItem2147483646.Name = "ToolStripMenuItem2147483646";
            this.ToolStripMenuItem2147483646.Size = new System.Drawing.Size(145, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ExitMenuItem.Text = "E&xit";
            this.ExitMenuItem.Click += new System.EventHandler(this.Click_a3e4ba47);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(375, 288);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.ButtonName);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.Keyboard1);
            this.DrawingLayerList = ((Limnor.Drawing2D.DrawingLayerHeaderList)(resources.GetObject("$this.DrawingLayerList")));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Slides Maker";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SizeChanged += new System.EventHandler(this.SizeChanged_53e488c2);
            Limnor.Application.ApplicationConfiguration.LoadingConfigurations += new System.EventHandler(this.LoadingConfigurations_3165520d);
            this.Load += new System.EventHandler(this.Load_e3a67207);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_5a01dd65);
            Limnor.Application.ApplicationConfiguration.SavingConfigurations += new System.EventHandler(this.SavingConfigurations_7e20ca90);
        }
        /// <summary>
        /// </summary>
        /// <param name="wholeScreen"></param>
        public virtual void CreateSlide(bool wholeScreen)
        {
            Form2 Form2177d30346 = null;
            System.Drawing.Bitmap Bitmap1ffe4e41c = null;
            bool Boolean1b42c38f3 = false;
            System.Drawing.Image Image1cb55d16 = null;
            this.AddingSlide = true;
            if (wholeScreen)
            {
                Boolean1b42c38f3 = this.WindowsManager1.SaveScreenImageToFile(this.SlideImageFullPath, VPL.EnumImageFormat.Jpeg, true);
                goto l_8c6636f5;
            }
            else
            {
                Boolean1b42c38f3 = this.WindowsManager1.SaveWindowUnderMouseImageToFile(this.SlideImageFullPath, VPL.EnumImageFormat.Jpeg, true);
                goto l_8c6636f5;
            }
        l_8c6636f5:
            if ((Boolean1b42c38f3 == true))
            {
                Form2177d30346 = new Form2();
                Bitmap1ffe4e41c = new System.Drawing.Bitmap(this.SlideImageFullPath);
                Form2177d30346.BackgroundImage = Bitmap1ffe4e41c;
                if (System.IO.File.Exists(this.SlideFullPath))
                {
                    Form2177d30346.LoadDrawingsFromFile(this.SlideFullPath);
                }
                Form2177d30346.Show();
                Form2177d30346.ClientSize = Bitmap1ffe4e41c.Size;
                Form2177d30346.BringToFront();
                bool ret7f893709 = Form2177d30346.EditDrawings();
                if ((ret7f893709 == true))
                {
                    Form2177d30346.SaveDrawingsToFile(this.SlideFullPath);
                    Image1cb55d16 = System.Drawing.Image.FromFile(this.SlideImageFullPath);
                    System.Windows.Forms.Clipboard.SetImage(Image1cb55d16);
                    this.txtIndex.Text = ((int.Parse(this.txtIndex.Text) + 1)).ToString();
                    goto l_50fddd6d;
                }
                else
                {
                    goto l_50fddd6d;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}", new object[] {
                                "Window [",
                                this.btInsert.Text,
                                "] not created"}), "Capture Windows Image", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                goto l_92304d7c;
            }
        l_50fddd6d:
            Form2177d30346.Close();
            Bitmap1ffe4e41c.Dispose();
            goto l_92304d7c;
        l_92304d7c:
            this.AddingSlide = false;
            return;
        }
        /// <summary>
        /// </summary>
        public virtual void AddSlide()
        {
            Form2 Form21982e646f = null;
            Form21982e646f = new Form2();
            Form21982e646f.Show();
            Form21982e646f.LoadSlide(this.txtFolder.Text, System.Convert.ToInt16(this.txtIndex.Text), this.txtName.Text);
            bool retdbabeade = Form21982e646f.EditDrawings();
            if ((retdbabeade == true))
            {
                Form21982e646f.SaveDrawingsToFile(this.SlideFullPath);
                this.txtIndex.Text = ((System.Convert.ToInt32(this.txtIndex.Text) + 1)).ToString();
                goto l_ee52ee69;
            }
            else
            {
                goto l_ee52ee69;
            }
        l_ee52ee69:
            Form21982e646f.Close();
            if ((Form21982e646f.BackgroundImage != null))
            {
                Form21982e646f.BackgroundImage.Dispose();
            }
            // unlock picture file 
            Form21982e646f.BackgroundImage = null;
            return;
        }
        /// <summary>
        /// </summary>
        public virtual void SelectSlideName()
        {
            DialogSlideName DialogSlideName11709842b = null;
            if (System.IO.Directory.Exists(this.txtFolder.Text))
            {
                DialogSlideName11709842b = new DialogSlideName();
                DialogSlideName11709842b.LoadSlideNames(this.txtFolder.Text);
                System.Windows.Forms.DialogResult ret2201b95d = DialogSlideName11709842b.ShowDialog(this);
                if ((ret2201b95d == System.Windows.Forms.DialogResult.OK))
                {
                    this.txtName.Text = DialogSlideName11709842b.SelectedName;
                }
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="SlideNumber"></param>
        public virtual void InsertSlide(int SlideNumber)
        {
            this.InsertFile(SlideNumber, ".jpg");
            this.InsertFile(SlideNumber, ".xml");
        }
        /// <summary>
        /// </summary>
        /// <param name="SlideNumber"></param>
        /// <param name="fileType"></param>
        public virtual void InsertFile(int SlideNumber, string fileType)
        {
            string currentFilenamecb1ff5c7 = null;
            string nextFilename45e043b1 = null;
            nextFilename45e043b1 = System.IO.Path.Combine(this.txtFolder.Text, string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[] {
                            this.txtName.Text,
                            "_",
                            (SlideNumber + ((double)(1D))),
                            fileType}));
            currentFilenamecb1ff5c7 = System.IO.Path.Combine(this.txtFolder.Text, string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}{2}{3}", new object[] {
                            this.txtName.Text,
                            "_",
                            SlideNumber,
                            fileType}));
            if (System.IO.File.Exists(currentFilenamecb1ff5c7))
            {
                if (System.IO.File.Exists(nextFilename45e043b1))
                {
                    this.InsertSlide(System.Convert.ToInt32((SlideNumber + ((double)(1D)))));
                    goto l_91f3c536;
                }
                else
                {
                    goto l_91f3c536;
                }
            }
            return;
        l_91f3c536:
            System.IO.File.Move(currentFilenamecb1ff5c7, nextFilename45e043b1);
            return;
        }
        private void Click_8f7ed9a5(object sender, System.EventArgs e)
        {
            this.Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.BringToFront();
        }
        private void SizeChanged_53e488c2(object sender0, System.EventArgs e)
        {
            Limnor.Drawing2D.DrawingPage sender = ((Limnor.Drawing2D.DrawingPage)(sender0));
            if ((this.WindowState == System.Windows.Forms.FormWindowState.Minimized))
            {
                this.Hide();
            }
        }
        private void Click_d2e530ca(object sender0, System.EventArgs e)
        {
            System.Windows.Forms.Button sender = ((System.Windows.Forms.Button)(sender0));
            System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog129df3c47 = null;
            FolderBrowserDialog129df3c47 = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult retacafc7ee = FolderBrowserDialog129df3c47.ShowDialog(this);
            if ((retacafc7ee == System.Windows.Forms.DialogResult.OK))
            {
                this.txtFolder.Text = FolderBrowserDialog129df3c47.SelectedPath;
                this.txtIndex.Text = "1";
            }
        }
        private void KeyPress_F3_3b54cbf2(object sender, System.EventArgs e)
        {
            if ((this.AddingSlide == false))
            {
                this.CreateSlide(false);
            }
        }
        private void Click_9a8faed9(object sender, System.EventArgs e)
        {
            this.AddSlide();
        }
        private void KeyPress_F4_8b2ce384(object sender, System.EventArgs e)
        {
            if ((this.AddingSlide == false))
            {
                this.CreateSlide(true);
            }
        }
        private void Click_a5d061c7(object sender, System.EventArgs e)
        {
            this.SelectSlideName();
        }
        private void Click_ad2f4fda(object sender, System.EventArgs e)
        {
            this.InsertSlide(System.Convert.ToInt32(this.txtIndex.Text));
        }
        private void LoadingConfigurations_3165520d(object sender, System.EventArgs e)
        {
            this.txtFolder.Text = ((string)(this.ApplicationConfiguration1["Category1"]["Slide Folder"]));
            this.txtIndex.Text = ((int)(this.ApplicationConfiguration1["Category1"]["Slide Index"])).ToString();
            this.txtName.Text = ((string)(this.ApplicationConfiguration1["Category1"]["Slide Name"]));
        }
        private void Load_e3a67207(object sender, System.EventArgs e)
        {
            this.ApplicationConfiguration1.ExecuteLoadingConfigurations();
        }
        private void FormClosing_5a01dd65(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.ApplicationConfiguration1.ExecuteSavingConfigurations();
        }
        private void SavingConfigurations_7e20ca90(object sender, System.EventArgs e)
        {
            this.ApplicationConfiguration1["Category1"]["Slide Folder"] = this.txtFolder.Text;
            this.ApplicationConfiguration1["Category1"]["Slide Index"] = System.Convert.ToInt32(this.txtIndex.Text);
            this.ApplicationConfiguration1["Category1"]["Slide Name"] = this.txtName.Text;
        }
        private void Click_a3e4ba47(object sender, System.EventArgs e)
        {
            this.Close();
        }
        protected override void Dispose(bool disposing)
        {
            if ((disposing 
                        && (components != null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
