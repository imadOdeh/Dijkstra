namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pqType = PQType.FibonacciHeapQueue;
            var checkedRadioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            switch (checkedRadioButton?.Name)
            {
                case "FibonacciHeapQueue":
                    pqType = PQType.FibonacciHeapQueue;
                    break;
                case "MinHeapQueue":
                    pqType = PQType.MinHeapQueue;
                    break;
                case "UnorderedLinkedList":
                    pqType = PQType.UnorderedLinkedList;
                    break;
            }

            var adj = ImportGraphFromFile.ImportExcel(filePathTextBox.Text, out var vertexes);

            var dijkstra = new Dijkstra(vertexes.Count, new Dijkstra.Node(vertexes[0], 0, 0), adj, pqType);

            var now = DateTime.Now;
            var result = dijkstra.ExeucteAlgorithm();
            var duration = (DateTime.Now - now).TotalMilliseconds;

            // output
            var output = "";
            for (int i = 1; i < result.Length; i++)
            {
                output += $"From {vertexes[0]} to {vertexes[i]}: {result[i]}\n";
            }

            File.WriteAllText("output.txt", output);

            resultLabel.Text = "The result is saved in 'output.txt' \nin same folder that contains .exe file";
            durationLabel.Text = $"Duration: {Math.Round(duration, 4)} ms / {Math.Round(duration / 1000, 4)} s";
        }

        private void importExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Excel Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "Excel Files|*.xlsx;",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog1.FileName;
            }
        }
    }
}