using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Node
{
    public object data;
    public Node next;
}
class MyStack
{
    Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object newdata)
    {
        Node newnode = new Node();
        newnode.data = newdata;
        newnode.next = top;
        top = newnode;
    }
    public object Pop()
    {
        if (IsEmpty()) return null;
        Node d = top;
        top = top.next;
        return d.data;
    }
    public object Peek()
    {
        return top.data;
    }
    public void Clear()
    {
        while (top != null)
            Pop();
    }
    public bool Contains(object x)
    {
        MyStack s = new MyStack();
        while (this.top != null)
        {
            object temp = this.Pop();
            s.Push(temp);
            if (temp.Equals(x))
            {
                while (s.top != null)
                    this.Push(s.Pop());
                return true;
            }
        }
        while (s.top != null)
            this.Push(s.Pop());
        return false;
    }
    public int Count()
    {
        MyStack st = new MyStack();
        int count = 0;
        while (this.top != null)
        {
            object t = this.Pop();
            st.Push(t);
            count++;
        }
        while (st.top != null)
        {
            this.Push(st.Pop());
        }
        return count;
    }
    public object Sum()
    {
        MyStack st = new MyStack();
        int sum = 0;
        while (this.top != null)
        {
            object t = this.Pop();
            sum += (int)t;
            st.Push(t);
        }
        while (st.top != null)
        {
            this.Push(st.Pop());
        }
        return sum;
    }
    public int CountOdd()
    {
        MyStack st = new MyStack();
        int count = 0;
        while (this.top != null)
        {
            object t = this.Pop();
            st.Push(t);
            if ((int)t % 2 == 0)
            {
                count++;
            }
        }
        while (st.top != null)
        {
            this.Push(st.Pop());
        }
        return count;
    }
    public void Reverse()
    {
        List<object> list = new List<object>();
        while(this.top!=null)
            list.Add(this.Pop());
        foreach(object v in list)
            this.Push(v);
    }
    public void Sort()
    {
        List<object> list = new List<object>();
        while(this.top!=null)
            list.Add(this.Pop());
        for(int i=0; i<list.Count-1; i++)
            for(int j=i+1; j<list.Count; j++)
                if ((int)list[i] > (int)list[j])
                {
                    object temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
        foreach(object v in list)
            this.Push(v);
    }
    public void Print()
    {
        Console.WriteLine("-> Stack elements:");
        MyStack temp = new MyStack();
        while (this.top != null)
        {
            object t = this.Pop();
            temp.Push(t);
            Console.Write(t + "  ");
        }
        while(temp.top!=null)
            this.Push(temp.Pop());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        MyStack st = new MyStack();
        st.Push(1);
        st.Push(5);
        st.Push(2);
        st.Push(4);
        
        st.Print();
        Console.WriteLine("\nCount: "+st.Count());
        Console.WriteLine("Count Odd: " + st.CountOdd());
        Console.WriteLine("Sum: " + st.Sum());

        Console.WriteLine("=> Reverse: ");
        st.Reverse();
        st.Print();

        Console.WriteLine("\n=> Sort: ");
        st.Sort();
        st.Print();

    }
}