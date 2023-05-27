#include <iostream>
using namespace std;

class node
{
    public:
	int data;
    node* next;
};

class stack
{
    public:
   stack()
    {
        top = NULL;
    }
    void display();
    void push(int value);
    int pop();
    int peek();
    double search(double value);
    public:

    node* top;

};
void stack::push(int value)
{
    node* new_node = new node;
    new_node->data = value;
    new_node->next = top;
    top = new_node;
}

int stack::pop()
{
    int value;
    if (top == NULL)
    {
        cout << "stack is empty or ender flow.\n";
        return -1;
    }
    else
    {
        node* first_node = top;
        top = first_node->next;
        value = first_node->data
;
        return value;
    }
}
int stack ::peek()
{
    if (top == NULL)
    {
        cout << "stack is empty or ender flow.\n";
        return -1;
    }
    else
    {
        return top->data;
    }
}
void stack:: display()
{
    node* current_node;
    if (top == NULL)
    {
        x
    }
    else
    {
        current_node = top;
        while (current_node != NULL)
        {
            cout << current_node->data << "\t";
            current_node = current_node->next;
        }
    }
}
double stack::search(double value)
{
    double last;
    node* current, *previous;
    int counter = 1;
    current = top;
    previous = top;

    while (current->data != value)
    {
        previous = current;
        current = current->next;
        counter++;
    }
    last = current->data;
    previous->next = current->next;
    free(current);
    cout << last << " was found and deleted from index : " << counter << endl;

}



int main()
{
    stack stack;
    stack.push(90);
    stack.push(60);
    stack.push(30);
    stack.push(10);
    stack.search(60);
    stack.display();
    cout << endl;
    stack.pop();
    stack.display();
    cout << endl;

}
