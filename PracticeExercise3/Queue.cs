namespace PracticeExercise3;

public class Queue<T> : IQueue<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    public T First => throw new NotImplementedException();

    public T Last => throw new NotImplementedException();

    public int Length => throw new NotImplementedException();

    public bool IsEmpty => throw new NotImplementedException();

    public T Dequeue()
    {
        throw new NotImplementedException();
    }

    public void Enqueue(T item)
    {
        throw new NotImplementedException();
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