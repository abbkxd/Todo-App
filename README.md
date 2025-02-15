# ToDo App

This ToDo App project has user control enabled features and follows the MVVM (Model-View-ViewModel) pattern. It includes functionalities for adding, updating, deleting, filtering, and sorting tasks. The project uses WPF for the user interface, with `TaskListView` and `TaskListUpdate` user controls to display and update tasks, respectively. The `MainWindowViewModel` manages the application's data and commands, ensuring a clear separation of concerns between the UI and business logic.

## Features

- **Add Task**: Add new tasks to the list.
- **Update Task**: Update details of existing tasks.
- **Delete Task**: Remove tasks from the list.
- **Filter Tasks**: Filter tasks based on their status (e.g., All, Completed, Pending).
- **Sort Tasks**: Sort tasks based on different criteria (e.g., Date, Name, Status).

## User Controls

- **TaskListView**: Displays the list of tasks.
- **TaskListUpdate**: Provides UI for updating the selected task.

## ViewModel

- **MainWindowViewModel**: Manages the application's data and commands, ensuring a clear separation of concerns between the UI and business logic.

## Issues

- **Sorting Functionality**: The sorting functionality is currently not working as expected.
