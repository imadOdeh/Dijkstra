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
                // Node 0 Istanbul 
                new List<Dijkstra.Node> { new Dijkstra.Node("İzmit", 1, 200), new Dijkstra.Node("Tekirdağ", 2, 150) },
                // Node 1 İzmit
                new List<Dijkstra.Node> { new Dijkstra.Node("Sakarya", 3, 250), new Dijkstra.Node("Bursa", 4, 300) },
                // Node 2 Tekirdağ
                new List<Dijkstra.Node> { new Dijkstra.Node("Edirne", 5, 100) },
                // Node 3 Sakarya
                new List<Dijkstra.Node> { new Dijkstra.Node("Bolu", 6, 100), new Dijkstra.Node("Bilecek", 7, 300) },
                // Node 4 Bursa
                new List<Dijkstra.Node> { new Dijkstra.Node("Bilecek", 7, 100) },
                // Node 5 Edirne
                new List<Dijkstra.Node> { },
                // Node 6 Bolu
                new List<Dijkstra.Node> { new Dijkstra.Node("Ankara", 8, 100) },
                // Node 7 Bilecek
                new List<Dijkstra.Node> { new Dijkstra.Node("Ankara", 8, 100) },
                // Node 8 Ankara
                new List<Dijkstra.Node> { },
            };

            var dijkstra = new Dijkstra(9, new Dijkstra.Node("Istanbul", 0, 0), adj);
            var result = dijkstra.ExeucteAlgorithm();
            
            label2.Text = string.Join(',', result);
        }
    }
}