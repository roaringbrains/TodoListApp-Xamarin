﻿using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TodoListApp
{
    public class TodoListViewModel
    {

        public ObservableCollection<TodoItem> TodoItems { get; set; }


        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("todo 1", false));
            TodoItems.Add(new TodoItem("todo 2", false));
            TodoItems.Add(new TodoItem("todo 3", false));

        }


        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoListInputValue { get; set; }
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoListInputValue, false));
        }


        //Remove 
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            if (todoItemBeingRemoved != null)
                TodoItems.Remove(todoItemBeingRemoved);

        }





    }
}
