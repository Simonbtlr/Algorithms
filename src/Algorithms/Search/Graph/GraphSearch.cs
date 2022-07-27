namespace Algorithms.Search.Graph;

public static class GraphSearch
{
    public static Person? Search(Person startPerson)
    {
        var searchQueue = new Queue<Person>();
        var searched = new List<Person>();

        if (startPerson.Friends is null)
            return null;

        foreach (var friend in startPerson.Friends)
            searchQueue.Enqueue(friend);

        while (searchQueue.Count > 0)
        {
            var person = searchQueue.Dequeue();

            if (searched.Any(x => x.Equals(person)))
                continue;

            if (person.IsSeller)
                return person;

            searched.Add(person);

            if (person.Friends is null)
                continue;

            foreach (var friend in person.Friends)
                searchQueue.Enqueue(friend);
        }

        return null;
    }

    public static IEnumerable<string> DijkstrasAlgorithm(
        Dictionary<string, Dictionary<string, float>> graph,
        Dictionary<string, float> costs,
        Dictionary<string, string> parents)
    {
        var processed = new Dictionary<string, float>();

        var node = FindLowestCostNode(costs, processed);

        while (node != string.Empty)
        {
            var cost = costs[node];
            var neighbors = graph[node];

            foreach (var neighbor in neighbors.Keys)
            {
                var newCost = cost + neighbors[neighbor];

                if (costs[neighbor] < newCost)
                    continue;

                costs[neighbor] = newCost;
                parents[neighbor] = node;
            }

            processed.Add(node, costs[node]);
            node = FindLowestCostNode(costs, processed);
        }

        var pointName = "fin";
        var path = new Queue<string>();
        path.Enqueue(pointName);

        while (pointName != "start" && !path.Contains(string.Empty))
        {
            pointName = parents[pointName];
            path.Enqueue(pointName);
        }

        path = new Queue<string>(path.Reverse());

        return path;
    }

    private static string FindLowestCostNode(
        Dictionary<string, float> costs,
        IReadOnlyDictionary<string, float> processed)
    {
        var lowestCost = float.PositiveInfinity;
        var lowestCostNode = string.Empty;

        foreach (var node in costs.Keys)
        {
            var cost = costs[node];

            if (cost > lowestCost || processed.ContainsKey(node))
                continue;

            lowestCost = cost;
            lowestCostNode = node;
        }

        return lowestCostNode;
    }
}