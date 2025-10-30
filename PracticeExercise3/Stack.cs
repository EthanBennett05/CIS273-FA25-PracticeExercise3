namespace PracticeExercise3;

public class Stack<T> : IStack<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    public bool IsEmpty => Length == 0;

    public int Length => linkedList.Count;

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new EmptyStackException();
        }

        T topOfStack = linkedList.First.Value;

        return topOfStack;
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new EmptyStackException();
        }

        T topOfStack = linkedList.First.Value;
        // remove the front of the linked list
        linkedList.RemoveFirst();
        return topOfStack;
    }

    public void Push(T item)
    {
        linkedList.AddFirst(item);
    }

    public override string ToString()
    {
        string result = "";

        var currentNode = linkedList.First;

        while (currentNode != null)
        {
            result += currentNode.Value + "\n";
            currentNode = currentNode.Next;
        }

        return result;
    }
}