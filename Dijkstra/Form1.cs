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
            var adj = new List<List<Dijkstra.Node>>()
            {
                new List<Dijkstra.Node> { new Dijkstra.Node("İzmit", 1, 200), new Dijkstra.Node("Tekirdağ", 2, 150) },
                new List<Dijkstra.Node> { new Dijkstra.Node("Sakarya", 3, 250), new Dijkstra.Node("Bursa", 4, 300) },
                new List<Dijkstra.Node> { new Dijkstra.Node("Edirne", 5, 100) },
                new List<Dijkstra.Node> { new Dijkstra.Node("Bolu", 6, 100), new Dijkstra.Node("Bilecek", 7, 300) },
                new List<Dijkstra.Node> { new Dijkstra.Node("Bilecek", 7, 100) },
                new List<Dijkstra.Node> { },
                new List<Dijkstra.Node> { new Dijkstra.Node("Ankara", 8, 100) },
                new List<Dijkstra.Node> { new Dijkstra.Node("Ankara", 8, 100) },
                new List<Dijkstra.Node> { },
            };

            var dijkstra = new Dijkstra(9, new Dijkstra.Node("Istanbul", 0, 0), adj);
            var result = dijkstra.ExeucteAlgorithm();
            
            // output
            label2.Text = string.Join(',', result);
        }
    }
}