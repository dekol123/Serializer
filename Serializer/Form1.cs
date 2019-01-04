using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializer
{
    public partial class Form1 : Form
    {
        List<string> labels = new List<string>();
        ChartValues<double> values = new ChartValues<double>();
        IEnumerable<Rootobject> mas;
        List<Rootobject> jsonResult;
        public Form1()
        {
            InitializeComponent();
            homeUserStatistic.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = labels,
                Unit = 1
            });
            //y axis label - this creates the y axis labels. 
            homeUserStatistic.AxisY.Add(new Axis
            {
                Title = "Amount",
                LabelFormatter = value => value.ToString()
            });
            homePanel.Visible = true;
            userPanel.Visible = false;
            bankPanel.Visible = false;
            /// Home panel diagrams
            dataAnalyze.Series = new SeriesCollection
        {           
        new LineSeries
        {
         Values = new ChartValues<double> { 3, 5, 7, 4 },
         

        }
        };
            dataAnalyze.Series.Add(new ColumnSeries
            {
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(4),
                    new ObservableValue(2),
                    new ObservableValue(8),
                    new ObservableValue(2),
                    new ObservableValue(3),
                    new ObservableValue(0),
                    new ObservableValue(1),
                },
                DataLabels = true,
                LabelPoint = point => point.Y + "K"
            });
            dataAnalyze.AxisX.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            dataAnalyze.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            userStatistic.Series.Add(new ColumnSeries
            {
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(4),
                    new ObservableValue(2),
                    new ObservableValue(8),
                    new ObservableValue(2),
                    new ObservableValue(3),
                    new ObservableValue(0),
                    new ObservableValue(1),
                },
                DataLabels = true,
                LabelPoint = point => point.Y + "K"
            });
            userStatistic.AxisX.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            userStatistic.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            buyersPrediction.Visible = false;
            dataAnalyze.Visible = true;
            userStatistic.Visible = false;
            categories.Visible = false;
            pieChart1.Visible = true;
            homeUserStatistic.Visible = false;

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("PingFin.json"))
            {
                string json = reader.ReadToEnd();
                jsonResult = JsonConvert.DeserializeObject<List<Rootobject>>(json);
            }
       }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            userPanel.Visible = false;
            bankPanel.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userPanel.Visible = true;
            homePanel.Visible = false;
            bankPanel.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            homePanel.Visible = false;
            userPanel.Visible = false;
            bankPanel.Visible = true;
            dataAnalyze.Visible = true;

        }

        private void bankPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randomColor = new Random();
            textColor.ForeColor = Color.FromArgb(randomColor.Next(255), randomColor.Next(255), randomColor.Next(255));
            textColor.BackColor = Color.FromArgb(randomColor.Next(70), randomColor.Next(70), randomColor.Next(70));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuThinButton23.IdleCornerRadius = 10;
            bunifuThinButton23.IdleForecolor = Color.White;
            bunifuThinButton23.IdleFillColor = Color.Tomato;
            bunifuThinButton23.IdleLineColor = Color.Transparent;

            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton22.IdleFillColor = Color.Transparent;
            bunifuThinButton22.IdleLineColor = Color.FromArgb(45, 58, 167);
            ///
            bunifuThinButton24.IdleCornerRadius = 20;
            bunifuThinButton24.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton24.IdleFillColor = Color.Transparent;
            bunifuThinButton24.IdleLineColor = Color.FromArgb(45, 58, 167);
            userStatistic.Visible = true;
            dataAnalyze.Visible = false;
            buyersPrediction.Visible = false;
            categories.Visible = false;

        }
        public IEnumerable<Rootobject> getAllInfo()
        {
            IEnumerable<Rootobject>  mas1 = jsonResult;
            foreach (var m in mas1)
            {
                if (m.ExtraInfo.CategoryValues == null || m.ExtraInfo.CategoryValues.Count() == 0)
                    continue;
                if (string.IsNullOrEmpty(m.Description))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "noname";
                }
                else if (m.Description.ToLower().Contains("shop") || m.Description.ToLower().Contains("market"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Food";
                }
                else if (m.Description.ToLower().Contains("uber") || m.Description.ToLower().Contains("taxi"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Taxi";
                }
                else if (m.Description.ToLower().Contains("apteca"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Health";
                }
                else if (m.Description.ToLower().Contains("bank") || m.Description.ToLower().Contains("mtb") || m.Description.ToLower().Contains("m6739113") || m.Description.ToLower().Contains("karta") || m.Description.ToLower().Contains("vklad") || m.Description.ToLower().Contains("perevod") || m.Description.ToLower().Contains("с вашего вклада") || m.Description.ToLower().Contains("sms opoveshenie") || m.Description.Contains("erip"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Bank";
                }
            }
            return mas1;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuThinButton22.IdleCornerRadius = 10;
            bunifuThinButton22.IdleForecolor = Color.White;
            bunifuThinButton22.IdleFillColor = Color.Tomato;
            bunifuThinButton22.IdleLineColor = Color.Transparent;
            ///
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton23.IdleFillColor = Color.Transparent;
            bunifuThinButton23.IdleLineColor = Color.FromArgb(45, 58, 167);
            ///
            bunifuThinButton24.IdleCornerRadius = 20;
            bunifuThinButton24.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton24.IdleFillColor = Color.Transparent;
            bunifuThinButton24.IdleLineColor = Color.FromArgb(45, 58, 167);
            ///
            buyersPrediction.Visible = true;
            userStatistic.Visible = false;
            dataAnalyze.Visible = false;
            categories.Visible = false;
            IEnumerable<Rootobject> mas1 = getAllInfo();

            /////
            buyersPrediction.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4,10,20,3,1,0},
                }
            };
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataAnalyze.Visible = true;
            userStatistic.Visible = false;
            buyersPrediction.Visible = false;
            categories.Visible = false;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuThinButton24.IdleCornerRadius = 10;
            bunifuThinButton24.IdleForecolor = Color.White;
            bunifuThinButton24.IdleFillColor = Color.Tomato;
            bunifuThinButton24.IdleLineColor = Color.Transparent;

            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton23.IdleFillColor = Color.Transparent;
            bunifuThinButton23.IdleLineColor = Color.FromArgb(45, 58, 167);
            ///
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleForecolor = Color.FromArgb(45, 58, 167);
            bunifuThinButton22.IdleFillColor = Color.Transparent;
            bunifuThinButton22.IdleLineColor = Color.FromArgb(45, 58, 167);

            categories.Series.Clear();
            categories.Visible = true;
            dataAnalyze.Visible = false;
            userStatistic.Visible = false;
            buyersPrediction.Visible = false;
            IEnumerable<Rootobject> mas1  = getAllInfo();
            jsonResult.RemoveAll(x => x.ExtraInfo.CategoryValues?.FirstOrDefault()?.Type == "noname");
            HashSet<string> typesHashSet = new HashSet<string>(); // HashSet - контейнер, принемающий только разные значения (повторы отбрасывает)
            foreach (var m in mas1)
            {

                typesHashSet.Add(m.ExtraInfo.CategoryValues?.FirstOrDefault()?.Type);
            }
            typesHashSet.Remove(null); // Удаление пустых значений (обычно это первый элемент)
            List<string> typesList = new List<string>(typesHashSet);
            List<double> Top = new List<double>();
            double sum = 0;
            for (int n = 0; n < typesList.Count; n++)
            {
                sum = 0;
                mas1 = mas1.Where(m => m.ExtraInfo.CategoryValues?.FirstOrDefault()?.Type == typesList[n]);
                foreach (var m in mas1)
                {
                    sum += m.Amount;
                }
                Top.Add(sum);
            }
            string specifier = "F";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            string result;
            double buff;
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            string name_buff;
            for (int i = 0; i < Top.Count; i++)
            {
                for (int j = 0; j < Top.Count-1; j++)
                {
                    if (Top[j] < Top[j + 1])
                    {
                        //  Сортировка сумм по категориям
                        buff = Top[j];
                        Top[j] = Top[j + 1];
                        Top[j + 1] = buff;
                        //  Сортировка категорий
                        name_buff = typesList[j];
                        typesList[j] = typesList[j + 1];
                        typesList[j + 1] = name_buff;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                result = Top[i].ToString(specifier, culture);
                categories.Series.Add(new PieSeries
                {
                    Title = typesList[i],
                    Values = new ChartValues<double> { double.Parse(result) },
                    PushOut = 15,
                    LabelPoint = labelPoint
                });
            }
            categories.LegendLocation = LegendLocation.Bottom;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = true;
            homeUserStatistic.Visible = false;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            homeUserStatistic.Visible = true;
            pieChart1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            homeUserStatistic.Series.Clear();
            pieChart1.Series.Clear();
            string hashUserId = textBox1.Text;
            mas = jsonResult.Where(r => r.UserId == hashUserId);
            foreach (var m in mas)
            {
                if (m.ExtraInfo.CategoryValues == null)
                    continue;
                if (string.IsNullOrEmpty(m.Description))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "noname";
                }
                else if (m.Description.ToLower().Contains("shop") || m.Description.ToLower().Contains("market"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Food";
                }
                else if (m.Description.ToLower().Contains("uber") || m.Description.ToLower().Contains("taxi"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Taxi";
                }
                else if (m.Description.ToLower().Contains("apteca"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Health";
                }
                else if (m.Description.ToLower().Contains("bank") || m.Description.ToLower().Contains("mtb") || m.Description.ToLower().Contains("m6739113") || m.Description.ToLower().Contains("karta") || m.Description.ToLower().Contains("vklad") || m.Description.ToLower().Contains("perevod") || m.Description.ToLower().Contains("с вашего вклада") || m.Description.ToLower().Contains("sms opoveshenie") || m.Description.Contains("erip"))
                {
                    m.ExtraInfo.CategoryValues.FirstOrDefault().Type = "Bank";
                }
                values.Add(m.Amount);
                labels.Add(Convert.ToString(m.Date));
                homeUserStatistic.Series.Add(new ColumnSeries
                {
                    Title = Convert.ToString(m.ExtraInfo.CategoryValues?.FirstOrDefault().Type) + "\t" + m.Date,
                    Values = new ChartValues<double> { m.Amount }
                });
            }
            HashSet<string> typesHashSet = new HashSet<string>(); // HashSet - контейнер, принемающий только разные значения (повторы отбрасывает)
            foreach (var m in mas)
            {
                typesHashSet.Add(m.ExtraInfo.CategoryValues?.FirstOrDefault().Type);
            }
            typesHashSet.Remove(null); // Удаление пустых значений (обычно это первый элемент)
            List<string> typesList = new List<string>(typesHashSet); // Запись HashSet в List чтобы пользоваться индексацией (HashSet нет индексации)
            double sum;
            string specifier = "F";
            string result;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            for (int n = 0;n< typesList.Count; n++)
            {
                sum = 0;
                mas = mas.Where(m => m.ExtraInfo.CategoryValues?.FirstOrDefault().Type == typesList[n]);
                foreach (var m in mas)
                {
                    sum += m.Amount;  
                }
                result = sum.ToString(specifier, culture);
                pieChart1.Series.Add(new PieSeries
                {
                    Title = typesList[n],
                    Values = new ChartValues<double> { double.Parse(result) },
                    PushOut = 15,
                    LabelPoint = labelPoint
                });
                pieChart1.LegendLocation = LegendLocation.Bottom;
            }

        }
    }
    public class Rootobject
    {
        public string CardId { get; set; }
        public string Id { get; set; }
        public float Amount { get; set; }
        public string BankId { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Extrainfo ExtraInfo { get; set; }
        public string UserId { get; set; }
    }

    public class Extrainfo
    {
        public Categoryvalue[] CategoryValues { get; set; }
    }

    public class Categoryvalue
    {
        public float Percentage { get; set; }
        public string Type { get; set; }
    }
}
