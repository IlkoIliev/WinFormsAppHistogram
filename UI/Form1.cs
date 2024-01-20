using Business;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private Histogram histogram;
        private List<int> histogramList;
        public Form1()
        {
            InitializeComponent();
            histogram = new Histogram();
            histogramList = new List<int>();
        }

        private void buttonAddRows_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumberOfNumbers.Text, out int numberOfNumbers))
            {
                // Изчистване на текущите колони и редове
                dataGridViewNumbers.Columns.Clear();
                dataGridViewNumbers.Rows.Clear();

                // Добавяне на колона "Numbers"
                dataGridViewNumbers.Columns.Add("Numbers", "Numbers");

                // Добавяне на нужния брой редове
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    dataGridViewNumbers.Rows.Add();
                }
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBoxNumberOfNumbers.Text);

            foreach (DataGridViewRow row in dataGridViewNumbers.Rows)
            {
                // Проверка дали редът не е празен
                if (!row.IsNewRow)
                {
                    // Прочитане на стойността от колоната с име "Numbers"
                    if (row.Cells["Numbers"].Value != null && int.TryParse(row.Cells["Numbers"].Value.ToString(), out int num))
                    {
                        histogramList.Add(num);
                    }
                }
            }

            histogram = new Histogram(count, histogramList);
            string result = histogram.FindPercentages();

            textBoxResult.Text = result;
        }
    }
}