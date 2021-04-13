using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Label[] Labels { get; set; }
        public RichTextBox[] Boxes { get; set; }
        public Label[] FormLabels { get; set; }
        public RichTextBox[] FormBoxes { get; set; }
        public bool isYearValid { get; set; } = false;
        public bool isMonthValid { get; set; } = false;
        public int WeekEndDaysInMonth { get; set; }
        public int WorkingDaysInMonth { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Path { get; set; }


        public Form1()
        {
            InitializeComponent();

            richTextBox43.Text = DateTime.Now.Year.ToString();
            richTextBox44.Text = DateTime.Now.Month.ToString();

            label45.Text = String.Empty;
            label46.Text = String.Empty;
            label47.Text = String.Empty;
            label48.Text = String.Empty;

            Labels = new Label[] {
                 label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14,
                 label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26,
                 label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39,
                 label40, label41, label42};

            Boxes = new RichTextBox[] { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6,
                 richTextBox7, richTextBox8, richTextBox9, richTextBox10, richTextBox11, richTextBox12, richTextBox13, richTextBox14,
                 richTextBox15, richTextBox16, richTextBox17, richTextBox18, richTextBox19, richTextBox20, richTextBox21, richTextBox22,
                 richTextBox23, richTextBox24, richTextBox25, richTextBox26, richTextBox27, richTextBox28, richTextBox29, richTextBox30,
                 richTextBox31, richTextBox32, richTextBox33, richTextBox34, richTextBox35, richTextBox36, richTextBox37, richTextBox38,
                 richTextBox39, richTextBox40, richTextBox41, richTextBox42 };

            FormLabels = new Label[] { label50, label51, label52, label53, label54, label55 };

            FormBoxes = new RichTextBox[] { richTextBox48, richTextBox49, richTextBox50, richTextBox51, richTextBox52, richTextBox53 };

            Helpers.ShowHider(FormBoxes, false);
            Helpers.ShowHider(FormLabels, false);
            Helpers.ShowHider(label57, false);

            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;

            Path = $"{Application.StartupPath}{Month}_{Year}_Report.txt";

            GridHandler gd = new GridHandler(Labels, Boxes, Year, Month);
            gd.MonthSetter();

            Helpers.ShowHider(button4, false);
        }

        private void richTextBox43_TextChanged(object sender, EventArgs e)
        {
            FieldValidator fv = new FieldValidator(richTextBox43.Text, label45, button2);
            isYearValid = fv.ValidateYear();
            if (isYearValid)
            {
                label47.Text = String.Empty;
                button2.Enabled = true;
            }
        }

        private void richTextBox44_TextChanged(object sender, EventArgs e)
        {
            FieldValidator fv = new FieldValidator(richTextBox44.Text, label46, button2);
            isMonthValid = fv.ValidateMonth();
            if (isMonthValid)
            {
                label47.Text = String.Empty;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((label45.Text == "" && label46.Text == "") && (richTextBox43.Text != String.Empty && richTextBox44.Text != String.Empty))
            {
                Year = Convert.ToInt32(richTextBox43.Text);
                Month = Convert.ToInt32(richTextBox44.Text);

                Path = $"{Application.StartupPath}{Month}_{Year}_Report.txt";

                GridHandler gd = new GridHandler(Labels, Boxes, Year, Month);
                gd.MonthSetter();
                button2.Enabled = false;
                label48.Text = String.Empty;
                button4.Visible = false;
                button5.Enabled = true;
                button5.Text = "Load Report is available";

                Helpers.CellCleaner(Boxes);

                Helpers.ShowHider(FormBoxes, false);
                Helpers.ShowHider(FormLabels, false);
                Helpers.ShowHider(label57, false);
            }

            if (richTextBox43.Text == "" || richTextBox44.Text == "")
            {
                label47.Text = "Fill in the fields";
                button2.Enabled = false;
            }

            if (label45.Text != "" || label46.Text != "")
            {
                label47.Text = "Correct the errors";
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox43.Text = String.Empty;
            richTextBox44.Text = String.Empty;

            label45.Text = String.Empty;
            label46.Text = String.Empty;

            Helpers.CellCleaner(Boxes);
            Helpers.ShowHider(FormBoxes, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridHandler gh = new GridHandler(Labels, Boxes, Year, Month);
            gh.LabelsSetter();

            FieldValidator fv = new FieldValidator(Boxes, Labels, button1, label48);
            bool n = fv.ValidateAllCells();
            if (n)
            {
                LoadingCalculator lc = new LoadingCalculator(Boxes);
                lc.Calculate();

                WeekEndDaysInMonth = gh.WeekEnds;
                WorkingDaysInMonth = DateTime.DaysInMonth(Year, Month) - WeekEndDaysInMonth;
                lc.AverageLoad = lc.TotalLoad / lc.LoadedDays;

                FormBoxes[0].Text = DateTime.DaysInMonth(Year, Month).ToString();
                FormBoxes[1].Text = WorkingDaysInMonth.ToString();
                FormBoxes[2].Text = WeekEndDaysInMonth.ToString();
                FormBoxes[3].Text = lc.LoadedDays.ToString();
                FormBoxes[4].Text = lc.TotalLoad.ToString();
                FormBoxes[5].Text = Math.Round(lc.AverageLoad, 2).ToString();

                Helpers.ShowHider(FormBoxes, true);
                Helpers.ShowHider(FormLabels, true);

                label48.Visible = false;
                button4.Visible = true;
            }
            else
            {
                Helpers.ShowHider(FormBoxes, false);
                Helpers.ShowHider(FormLabels, false);
                label48.Visible = true;
                button4.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine(richTextBox43.Text);
                sw.WriteLine(richTextBox44.Text);

                for (int i = 0; i < 42; i++)
                {
                    if (Labels[i].Text != String.Empty)
                    {
                        sw.WriteLine($"{Labels[i].Text}\n{Boxes[i].Text}");
                    }
                }

                for (int j = 0; j < FormBoxes.Length; j++)
                {
                    sw.WriteLine($"{FormBoxes[j].Text}");
                }
            }
            button4.Text = $"Saved to {Month}_{Year}_Report.txt";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string[] fileLines = File.ReadAllLines(Path, Encoding.UTF8);

                Year = int.Parse(fileLines[0]);
                Month = int.Parse(fileLines[1]);
                Path = $"{Application.StartupPath}{Month}_{Year}_Report.txt";

                GridHandler gd = new GridHandler(Labels, Boxes, Year, Month);
                gd.MonthSetter();
                button2.Enabled = false;
                label48.Text = String.Empty;
                Helpers.ShowHider(button4, false);

                Helpers.CellCleaner(Boxes);

                for (int i = 0; i < fileLines.Length; i++)
                {
                    for (int j = 0; j < 42; j++)
                    {
                        if (fileLines[i] == Labels[j].Text)
                        {
                            Boxes[j].Text = fileLines[i+1];
                        }
                    }
                }

                int g = fileLines.Length - 1;

                for (int k = FormBoxes.Length - 1; k == 0 ; k--)
                {
                    FormBoxes[k].Text = fileLines[g];
                    g--;
                }

                Helpers.ShowHider(label57, true);

                label57.Text = "The Report is successfully loaded";
                label57.ForeColor = System.Drawing.Color.Green;
                button5.Text = "Report loaded";
                button5.Enabled = false;
                Helpers.ShowHider(FormBoxes, true);
                Helpers.ShowHider(FormLabels, true);
            }
            catch (FileNotFoundException ex)
            {
                button5.Text = "Report not found";
                Helpers.ShowHider(label57, true);
                label57.ForeColor = System.Drawing.Color.Red;
                label57.Text = "Cannot find Report for this Year/Month";
                button5.Enabled = false;
            }
        }


        class GridHandler
        {
            public Label[] Labels { get; set; }
            public RichTextBox[] Boxes { get; set; }
            public int Year { get; set; }
            public int Month { get; set; }
            public int WeekEnds { get; set; } = 0;

            public GridHandler(Label[] labels, RichTextBox[] boxes, int y, int m)
            {
                Labels = labels;
                Boxes = boxes;
                Year = y;
                Month = m;
            }

            public void MonthSetter()
            {
                int day = 1;

                var firstDay = new DateTime(Year, Month, 1);

                for (int h = 0; h < 42; h++)
                {
                    Labels[h].Text = String.Empty;
                    Labels[h].Visible = true;
                    Labels[h].ForeColor = System.Drawing.Color.Black;

                    Boxes[h].Visible = true;
                    Boxes[h].BackColor = System.Drawing.Color.White;
                    Boxes[h].Text = String.Empty;
                }

                for (int i = (int)firstDay.DayOfWeek - 1; i < DateTime.DaysInMonth(Year, Month) + (int)firstDay.DayOfWeek - 1; i++)
                {
                    Labels[i].Text = $"{day}.{Month}.{Year}";
                    DateTime dt = new DateTime(Year, Month, day);
                    

                    if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Labels[i].ForeColor = System.Drawing.Color.Red;
                        Boxes[i].BackColor = System.Drawing.Color.LightCoral;
                        WeekEnds++;
                    }
                    if (dt.Date < DateTime.Now.Date)
                    {
                        Boxes[i].BackColor = System.Drawing.Color.LightGray;
                    }
                    day++;
                }

                for (int j = 0; j < 42; j++)
                {
                    if (Labels[j].Text == String.Empty)
                    {
                        Labels[j].Visible = false;
                        Boxes[j].Visible = false;
                    }
                }
            }

            public void LabelsSetter()
            {
                int day = 1;

                var firstDay = new DateTime(Year, Month, 1);

                for (int h = 0; h < 42; h++)
                {
                    Labels[h].Text = String.Empty;
                    Labels[h].Visible = true;
                    Labels[h].ForeColor = System.Drawing.Color.Black;
                }

                for (int i = (int)firstDay.DayOfWeek - 1; i < DateTime.DaysInMonth(Year, Month) + (int)firstDay.DayOfWeek - 1; i++)
                {
                    Labels[i].Text = $"{day}.{Month}.{Year}";

                    DateTime dt = new DateTime(Year, Month, day);

                    if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Labels[i].ForeColor = System.Drawing.Color.Red;
                        WeekEnds++;
                    }
                    day++;
                }

                for (int j = 0; j < 42; j++)
                {
                    if (Labels[j].Text == String.Empty)
                    {
                        Labels[j].Visible = false;
                        Boxes[j].Visible = false;
                    }
                }
            }
        }

        class FieldValidator
        {
            public string TextValue { get; set; }
            public Label Label { get; set; }
            public Button Button { get; set; }
            public RichTextBox[] Boxes { get; set; }
            public Label[] Labels { get; set; }


            public FieldValidator(string textValue, Label label)
            {
                TextValue = textValue;
                Label = label;
            }

            public FieldValidator(string textValue, Label label, Button button) : this(textValue, label)
            {
                Button = button;
            }

            public FieldValidator(RichTextBox[] boxes, Label[] labels, Button button, Label label)
            {
                Boxes = boxes;
                Labels = labels;
                Button = button;
                Label = label;
            }

            public bool ValidateYear()
            {
                int c;

                if (TextValue == String.Empty)
                {
                    Label.Text = String.Empty;
                    return false;
                }

                try
                {
                    c = Convert.ToInt32(TextValue);
                    if (c < 2000 || c > 2050)
                    {
                        Button.Enabled = false;
                        Label.Text = "Out of range 2000-2050";
                        return false;
                    }
                    else
                    {
                        Label.Text = String.Empty;
                        Button.Enabled = true;
                        return true;
                    }
                }
                catch (FormatException ex)
                {
                    Button.Enabled = false;
                    Label.Text = "Invalid value";
                    return false;
                }
            }

            public bool ValidateMonth()
            {
                int c;

                if (TextValue == String.Empty)
                {
                    Label.Text = String.Empty;
                    return false;
                }

                try
                {
                    c = Convert.ToInt32(TextValue);

                    if (c < 1 || c > 12)
                    {
                        Button.Enabled = false;
                        Label.Text = "Out of range 1-12";
                        return false;
                    }
                    else
                    {
                        Label.Text = String.Empty;
                        Button.Enabled = true;
                        return true;
                    }
                }
                catch (FormatException ex)
                {
                    Button.Enabled = false;
                    Label.Text = "Invalid value";
                    return false;
                }
            }

            public bool ValidateCell()
            {
                int c;

                try
                {
                    if (TextValue != String.Empty)
                    {
                        c = Convert.ToInt32(TextValue);
                        if (c < 1 || c > 12)
                        {
                            Label.ForeColor = System.Drawing.Color.Red;
                            Label.Text = "Out of range 1-12";
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (FormatException ex)
                {
                    Label.ForeColor = System.Drawing.Color.Red;
                    Label.Text = "Invalid value";
                    return false;
                }
            }

            public bool ValidateAllCells()
            {
                bool cellsValidated = true;
                string a = String.Empty;
                int b = 0;

                for (int h = 0; h < 42; h++)
                {
                    FieldValidator fn = new FieldValidator(Boxes[h].Text, Labels[h]);
                    bool z = fn.ValidateCell();
                    if (!z)
                    {
                        cellsValidated = false;
                    }
                }

                for (int i = 0; i < 42; i++)
                {

                    if (!cellsValidated)
                    {
                        Label.Text = "Correct the errors";
                        cellsValidated = false;
                    }
                    if (Boxes[i].Text != String.Empty)
                    {
                        a += Boxes[i].Text;
                        b++;
                    }
                }

                if (a == String.Empty)
                {
                    Label.Text = "All cells empty";
                    cellsValidated = false;
                }

                if (cellsValidated)
                {
                    return true;
                }
                return false;
            }
        }

        class LoadingCalculator
        {
            public RichTextBox[] Boxes { get; set; }
            public RichTextBox[] FormBoxes { get; set; }
            public Label[] FormLabels { get; set; }
            public Label Label { get; set; }
            public double AverageLoad { get; set; }
            public double TotalLoad { get; set; }
            public int LoadedDays { get; set; }

            public LoadingCalculator(RichTextBox[] boxes)
            {
                Boxes = boxes;
            }

            public void Calculate()
            {
                int x = 0;

                for (int i = 0; i < 42; i++)
                {
                    if (Boxes[i].Text != String.Empty)
                    {
                        x++;
                    }
                }

                double[] loadedCells = new double[x];
                int y = 0;

                TotalLoad = 0;

                for (int j = 0; j < 42; j++)
                {
                    if (Boxes[j].Text != String.Empty)
                    {
                        loadedCells[y] = double.Parse(Boxes[j].Text);
                        TotalLoad += loadedCells[y];
                        y++;
                    }
                }

                AverageLoad = TotalLoad / loadedCells.Length;

                LoadedDays = loadedCells.Length;
            }
        }

        public static class Helpers
        {
            public static void ShowHider(Object[] objects, bool visible)
            {
                if (objects is Label[])
                {
                    for (int i = 0; i < objects.Length; i++)
                    {
                        ((Label)objects[i]).Visible = visible;
                    }
                }
                if (objects is RichTextBox[])
                {
                    for (int i = 0; i < objects.Length; i++)
                    {
                        ((RichTextBox)objects[i]).Visible = visible;
                    }
                }
            }

            public static void ShowHider(Object obj, bool visible)
            {
                if (obj is Label)
                {
                    ((Label)obj).Visible = visible;
                }
                if (obj is Button)
                {
                    ((Button)obj).Visible = visible;
                }
                if (obj is RichTextBox)
                {
                    ((RichTextBox)obj).Visible = visible;
                }
            }

            public static void CellCleaner(RichTextBox[] boxes)
            {
                foreach (RichTextBox b in boxes)
                {
                    b.Text = String.Empty;
                }
            }
        }
    }
}
