using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Printing;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;

namespace SimpleEditorLib
{
    public partial class SimpleEditor : Form
    {
        public SimpleEditor()
        {
            InitializeComponent();

            _highlights = new List<HighlightPosition>();
            _annotations = new List<Annotation>();
            LoadFonts();
        }

        private void LoadFonts()
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    string fname = fa.Name;
                    cmbFont.Items.Add(fname);
                    if (fa.Name == "Arial")
                        cmbFont.SelectedItem = fname;
                }
            }

            for (int i = 6; i < 24; i++)
            {
                cmbFontSize.Items.Add(i);
            }
            cmbFontSize.SelectedItem = 12;
        }

        private string _rtf_file;
        public string RtfFile
        {
            get
            {
                return _rtf_file;
            }
            set
            {
                try
                {
                    _rtf_file = value;
                    rbMain.Text = "";
                    rbMain.LoadFile(value);
                    _highlights.Clear();
                    _annotations.Clear();
                }
                catch (Exception)
                {
                }
            }
        }

        private string _pdf_file;
        public string PdfFile
        {
            get
            {
                return _pdf_file;
            }
            set
            {
                try
                {
                    _pdf_file = value;
                    rbMain.Text = "";
                    rbAnnotation.Text = "";
                    _highlights.Clear();
                    _annotations.Clear();

                    using (PdfReader reader = new PdfReader(_pdf_file))
                    {
                        StringBuilder text = new StringBuilder();
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }
                        rbMain.Text = text.ToString();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private bool _readonly;
        public bool ReadOnly
        {
            get
            {
                return _readonly;
            }
            set
            {
                _readonly = value;
                rbMain.ReadOnly = _readonly;
            }
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            rbMain.Undo();
        }

        private void tsbRedo_Click(object sender, EventArgs e)
        {
            rbMain.Redo();
        }

        private void ApplyFontStyle()
        {
            FontStyle fs = FontStyle.Regular;
            if (tsbBold.Checked)
                fs |= FontStyle.Bold;
            if (tsbItalic.Checked)
                fs |= FontStyle.Italic;
            if (tsbUnderline.Checked)
                fs |= FontStyle.Underline;

            rbMain.SelectionFont = new Font(rbMain.SelectionFont, fs);
        }

        private void tsbBold_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFontStyle();
        }

        private void tsbItalic_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFontStyle();
        }

        private void tsbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFontStyle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rbMain.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rbMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rbMain.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ApplyFont()
        {
            try
            {
                FontStyle fs = FontStyle.Regular;
                if (tsbBold.Checked)
                    fs |= FontStyle.Bold;
                if (tsbItalic.Checked)
                    fs |= FontStyle.Italic;
                if (tsbUnderline.Checked)
                    fs |= FontStyle.Underline;

                string fontName = cmbFont.Text;
                float fontSize = (float)Convert.ToDouble(cmbFontSize.Text);
                rbMain.SelectionFont = new Font(fontName, fontSize, fs);
            }
            catch (Exception)
            {
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFontSize_TextChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 100, 100);
            printDocument1.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            DialogResult result = printPreviewDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Color backcolor = rbMain.BackColor;
            Color theColor = rbMain.ForeColor;
            Font theFont = rbMain.SelectionFont;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            RectangleF rect = new RectangleF(x, y, rbMain.Width, rbMain.Height);
            e.Graphics.FillRectangle(new SolidBrush(backcolor), rect);
            e.Graphics.DrawString(rbMain.Text, theFont, new SolidBrush(theColor), x, y);
        }

        public string GetContent()
        {
            return rbMain.Text;
        }

        #region Highlight

        public void AddHighlight(int startIdx, int len)
        {
            rbMain.SelectionStart = startIdx;
            rbMain.SelectionLength = len;
            rbMain.SelectionBackColor = Color.Yellow;
            bool b = true;
            foreach (HighlightPosition hlp in _highlights)
            {
                if (hlp.StartIdx == rbMain.SelectionStart &&
                    hlp.Length == rbMain.SelectionLength)
                {
                    b = false;
                    break;
                }
            }
            if (b)
            {
                HighlightPosition hlp = new HighlightPosition();
                hlp.StartIdx = startIdx;
                hlp.Length = len;
                _highlights.Add(hlp);
            }
        }

        private List<HighlightPosition> _highlights;
        public List<HighlightPosition> GetHighlights()
        {
            return _highlights;
        }

        private void tsbHighlight_Click(object sender, EventArgs e)
        {
            int startIdx = rbMain.SelectionStart;
            int length = rbMain.SelectionLength;
            if (rbMain.SelectionLength == 0)
                return;
            bool b = true;
            foreach (HighlightPosition hlp in _highlights)
            {
                if (hlp.StartIdx == startIdx && hlp.Length == length)
                {
                    b = false;
                    _highlights.Remove(hlp);
                    break;
                }
            }
            if (b)
            {
                rbMain.SelectionBackColor = Color.Yellow;
                HighlightPosition hlp = new HighlightPosition();
                hlp.StartIdx = startIdx;
                hlp.Length = length;
                _highlights.Add(hlp);
            }
            else
            {
                rbMain.SelectionBackColor = Color.White;
            }
        }
        #endregion

        #region Annotation

        private List<Annotation> _annotations = null;
        public List<Annotation> GetAnnotaions()
        {
            return _annotations;
        }

        public void AddAnnotation(int startIdx, int len, string content)
        {
            rbMain.SelectionStart = startIdx;
            rbMain.SelectionLength = len;
            rbMain.SelectionBackColor = Color.Pink;
            Annotation anno = new Annotation();
            anno.StartIdx = startIdx;
            anno.Length = len;
            anno.Annot = content;
            _annotations.Add(anno);
        }

        private Annotation FindAnnotation(int idx)
        {
            Annotation annotation = null;
            foreach (Annotation annot in _annotations)
            {
                if (idx >= annot.StartIdx && idx < annot.StartIdx + annot.Length)
                {
                    rbAnnotation.Text = annot.Annot;
                    annotation = annot;
                    break;
                }
            }
            return annotation;
        }

        private void UpdateAnnotation(int startIdx, int len, string content)
        {
            foreach (Annotation annot in _annotations)
            {
                if (startIdx >= annot.StartIdx && startIdx < annot.StartIdx + annot.Length)
                {
                    annot.Annot = rbAnnotation.Text;
                    break;
                }
            }
        }

        private void tsbAnnotation_Click(object sender, EventArgs e)
        {
            pnAnnotation.Visible = true;
            int startIdx = rbMain.SelectionStart;
            int len = rbMain.SelectionLength;
            if (len == 0)
                len = 1;

            Annotation annotation = FindAnnotation(startIdx);
            if (annotation == null)
            {
                AddAnnotation(startIdx, len, "");
            }
            rbAnnotation.Focus();
        }
        #endregion

        #region Save
        public event EventHandler<EventArgs> ToSaveDoc;
        protected void OnToSaveDoc(EventArgs e)
        {
            if (ToSaveDoc != null)
            {
                ToSaveDoc(this, e);
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.OnToSaveDoc(new EventArgs());
        }
        #endregion

        private void rbMain_SelectionChanged(object sender, EventArgs e)
        {
            int startIdx = rbMain.SelectionStart;
            Annotation annotation = FindAnnotation(startIdx);
            if (annotation == null)
            {
                rbAnnotation.Clear();
            }
            else
            {
                rbAnnotation.Text = annotation.Annot;
            }
        }

        private void tsbSaveAnno_Click(object sender, EventArgs e)
        {
            int startIdx = rbMain.SelectionStart;
            int length = rbMain.SelectionLength;
            length = length == 0 ? 1 : length;
            UpdateAnnotation(startIdx, length, rbAnnotation.Text);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this annotation?", "Confirm", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes)
                return;

            int startIdx = rbMain.SelectionStart;
            int length = rbMain.SelectionLength;
            length = length == 0 ? 1 : length;
            foreach (Annotation annot in _annotations)
            {
                if (startIdx >= annot.StartIdx && startIdx < annot.StartIdx + annot.Length)
                {
                    _annotations.Remove(annot);
                    rbMain.SelectionBackColor = Color.White;
                    break;
                }
            }
            rbAnnotation.Text = "";
        }
    }

    public class HighlightPosition
    {
        public int StartIdx { get; set; }
        public int Length { get; set; }
    }

    public class Annotation
    {
        public int StartIdx { get; set; }
        public int Length { get; set; }
        public string Annot { get; set; }
    }

}
