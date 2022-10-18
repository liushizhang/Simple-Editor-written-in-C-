namespace SimpleEditorLib
{
    partial class SimpleEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleEditor));
            this.rbMain = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHighlight = new System.Windows.Forms.ToolStripButton();
            this.tsbAnnotation = new System.Windows.Forms.ToolStripButton();
            this.pnAnnotation = new System.Windows.Forms.Panel();
            this.rbAnnotation = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSaveAnno = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.pnAnnotation.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMain
            // 
            this.rbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMain.HideSelection = false;
            this.rbMain.Location = new System.Drawing.Point(0, 32);
            this.rbMain.Name = "rbMain";
            this.rbMain.Size = new System.Drawing.Size(702, 762);
            this.rbMain.TabIndex = 0;
            this.rbMain.Text = "";
            this.rbMain.SelectionChanged += new System.EventHandler(this.rbMain_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(6);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbUndo,
            this.tsbRedo,
            this.toolStripSeparator2,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline,
            this.toolStripSeparator3,
            this.cmbFont,
            this.cmbFontSize,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.tsbHighlight,
            this.tsbAnnotation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1005, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 29);
            this.tsbSave.Text = "save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbUndo
            // 
            this.tsbUndo.AutoSize = false;
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(32, 32);
            this.tsbUndo.Text = "toolStripButton1";
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.AutoSize = false;
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedo.Image")));
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(32, 32);
            this.tsbRedo.Text = "toolStripButton2";
            this.tsbRedo.Click += new System.EventHandler(this.tsbRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbBold
            // 
            this.tsbBold.AutoSize = false;
            this.tsbBold.CheckOnClick = true;
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbBold.Image")));
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(32, 32);
            this.tsbBold.Text = "bold";
            this.tsbBold.CheckedChanged += new System.EventHandler(this.tsbBold_CheckedChanged);
            // 
            // tsbItalic
            // 
            this.tsbItalic.AutoSize = false;
            this.tsbItalic.CheckOnClick = true;
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(32, 32);
            this.tsbItalic.Text = "italic";
            this.tsbItalic.CheckedChanged += new System.EventHandler(this.tsbItalic_CheckedChanged);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.AutoSize = false;
            this.tsbUnderline.CheckOnClick = true;
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(32, 32);
            this.tsbUnderline.Text = "under line";
            this.tsbUnderline.CheckedChanged += new System.EventHandler(this.tsbUnderline_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // cmbFont
            // 
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 32);
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 32);
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            this.cmbFontSize.TextChanged += new System.EventHandler(this.cmbFontSize_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton1.Text = "align left";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton2.Text = "align center";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton3.Text = "align right";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbHighlight
            // 
            this.tsbHighlight.AutoSize = false;
            this.tsbHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHighlight.Image = ((System.Drawing.Image)(resources.GetObject("tsbHighlight.Image")));
            this.tsbHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHighlight.Name = "tsbHighlight";
            this.tsbHighlight.Size = new System.Drawing.Size(32, 32);
            this.tsbHighlight.Text = "highlight";
            this.tsbHighlight.Click += new System.EventHandler(this.tsbHighlight_Click);
            // 
            // tsbAnnotation
            // 
            this.tsbAnnotation.AutoSize = false;
            this.tsbAnnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnnotation.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnnotation.Image")));
            this.tsbAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnnotation.Name = "tsbAnnotation";
            this.tsbAnnotation.Size = new System.Drawing.Size(32, 32);
            this.tsbAnnotation.Text = "annotation";
            this.tsbAnnotation.Click += new System.EventHandler(this.tsbAnnotation_Click);
            // 
            // pnAnnotation
            // 
            this.pnAnnotation.Controls.Add(this.rbAnnotation);
            this.pnAnnotation.Controls.Add(this.toolStrip2);
            this.pnAnnotation.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAnnotation.Location = new System.Drawing.Point(702, 32);
            this.pnAnnotation.Name = "pnAnnotation";
            this.pnAnnotation.Size = new System.Drawing.Size(303, 762);
            this.pnAnnotation.TabIndex = 4;
            this.pnAnnotation.Visible = false;
            // 
            // rbAnnotation
            // 
            this.rbAnnotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbAnnotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnnotation.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnnotation.Location = new System.Drawing.Point(0, 0);
            this.rbAnnotation.Name = "rbAnnotation";
            this.rbAnnotation.Size = new System.Drawing.Size(270, 762);
            this.rbAnnotation.TabIndex = 2;
            this.rbAnnotation.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveAnno,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(270, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(33, 762);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbSaveAnno
            // 
            this.tsbSaveAnno.AutoSize = false;
            this.tsbSaveAnno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAnno.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAnno.Image")));
            this.tsbSaveAnno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAnno.Name = "tsbSaveAnno";
            this.tsbSaveAnno.Size = new System.Drawing.Size(32, 32);
            this.tsbSaveAnno.Text = "toolStripButton2";
            this.tsbSaveAnno.Click += new System.EventHandler(this.tsbSaveAnno_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton4.Text = "toolStripButton3";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // SimpleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 794);
            this.Controls.Add(this.rbMain);
            this.Controls.Add(this.pnAnnotation);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleEditor";
            this.Text = "SimpleEditor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnAnnotation.ResumeLayout(false);
            this.pnAnnotation.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbItalic;
        private System.Windows.Forms.ToolStripButton tsbUnderline;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cmbFont;
        private System.Windows.Forms.ToolStripComboBox cmbFontSize;
        private System.Windows.Forms.ToolStripButton tsbAnnotation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbHighlight;
        private System.Windows.Forms.Panel pnAnnotation;
        private System.Windows.Forms.RichTextBox rbAnnotation;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSaveAnno;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}