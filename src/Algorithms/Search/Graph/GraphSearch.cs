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
}