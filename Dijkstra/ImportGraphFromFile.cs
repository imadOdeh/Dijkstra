using ClosedXML.Excel;

namespace Dijkstra
{
    public class ImportGraphFromFile
    {
        public static List<List<Dijkstra.Node>> ImportExcel(string filePath, out List<string> vertexes)
        {
            using var workbook = new XLWorkbook(filePath);
            // get the first worksheet in the workbook
            var worksheet = workbook.Worksheets.FirstOrDefault();
            if (worksheet == null)
                throw new Exception("No worksheet found");

            int col = 1;
            vertexes = new List<string>();
            for (int i = 1; ; i++)
            {
                var cellValue = worksheet.Cell(i, col).Value.ToString();
                if (string.IsNullOrEmpty(cellValue))
                    break;

                vertexes.Add(cellValue);
            }

            var graph = new List<List<Dijkstra.Node>>();
            for (int i = 1; i <= vertexes.Count; i++)
            {
                var list = new List<Dijkstra.Node>();
                for (int j = 2; ;j++)
                {
                    var cellValue = worksheet.Cell(i, j).Value.ToString();
                    if (string.IsNullOrEmpty(cellValue))
                        break;

                    var index_weight = cellValue.Split('/');
                    list.Add(new Dijkstra.Node(vertexes[i-1], int.Parse(index_weight[0]), double.Parse(index_weight[1])));
                }
                
                graph.Add(list);
            }

            return graph;
        }
    }
}
