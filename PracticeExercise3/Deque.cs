using System.Runtime.CompilerServices;

namespace PracticeExercise3;

public class Deque<T> : IDeque<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    public bool IsEmpty => Length == 0;

    public int Length => linkedList.Count;

    public T Front => linkedList.First();

    public T Back => linkedList.Last();

    public void AddBack(T item)
    {
        linkedList.AddLast(item);
    }

    public void AddFront(T item)
    {
        linkedList.AddFirst(item);

    }

    public T RemoveBack()
    {
        var item = linkedList.Last();
        linkedList.RemoveLast();
        return item;
    }

    public T RemoveFront()
    {
        var item = linkedList.First();
        linkedList.RemoveFirst();
        return item;
    }

    public override string ToString()
    {
        string result = "<Back> ";

        var currentNode = linkedList.Last;
        while (currentNode != null)
        {
            result += currentNode.Value;
            if (currentNode.Previous != null)
            {
                result += " → ";
            }
            currentNode = currentNode.Previous;
        }

        result += " <Front>";

        return result;
    }
}