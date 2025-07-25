﻿namespace ToDoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}

public class TodoItemCreateDto
{
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}
