using Kse.Algorithms.Samples;

var generator = new MapGenerator(new MapGeneratorOptions()
{
    Height = 35,
    Width = 90,
});

string[,] map = generator.Generate();
new MapPrinter().Print(map);
List<Point> GetShortestPath(string[,] map, Point start, Point goal)
{
   
}