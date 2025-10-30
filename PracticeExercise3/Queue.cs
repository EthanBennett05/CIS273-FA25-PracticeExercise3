using System.Runtime.CompilerServices;

namespace PracticeExercise3;

public class Queue<T> : IQueue<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    public T First => linkedList.First();

    public T Last => linkedList.Last();

    public int Length => linkedList.Count;

    public bool IsEmpty => Length == 0;

    public T Dequeue()
    {
        var item = linkedList.First();
        linkedList.RemoveFirst();
        return item;
    }

    public void Enqueue(T item)
    {
        linkedList.AddLast(item);
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