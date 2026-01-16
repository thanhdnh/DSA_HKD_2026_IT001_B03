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
    public void Push(object newdata){
        Node newnode = new Node();
        newnode.data = newdata;
        newnode.next = top;
        top = newnode;
    }
    public object Pop(){
        if(IsEmpty()) return null;
        Node d = top;
        top = top.next;
        return d.data;
    }
}

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();

    MyStack st = new MyStack();
    st.Push(1); 
    st.Push(2); 
    st.Push(3);
    ;
    st.Pop(); 
    st.Pop(); 
    st.Pop();
  }
}