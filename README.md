
---
# Generic Sorting Program

This program demonstrates sorting arrays of different types (integers, strings, and custom objects) using a generic sorting algorithm.

## Overview

The program utilizes a generic sorting algorithm to sort arrays of various types. It includes implementations for sorting integer arrays, string arrays, and arrays of custom objects (Employee objects).

## Usage

1. **Instantiate Sortable Objects**: Create instances of `IntArrayFactory`, `StringArrayFactory`, and `EmployeeArrayFactory` to generate arrays of integers, strings, and employees respectively.
2. **Sorting**: Utilize the `ArraySorter<T>` class to sort the generated arrays.
3. **Display**: Use the `DisplayArray<T>` method to display the sorted arrays.

## Components

### `Program` Class

- Contains the `Main` method where the program execution begins.
- Instantiates sortable objects for different types of arrays.
- Sorts and displays arrays of integers, strings, and employees.

### `IArrayFactory<T>` Interface

- Declares a method `Create()` to create arrays of type `T`.

### `IntArrayFactory`, `StringArrayFactory`, `EmployeeArrayFactory` Classes

- Implement `IArrayFactory<T>` to create arrays of integers, strings, and employees respectively.

### `Employee` Class

- Represents an Employee with properties `Id` and `Name`.
- Implements `IComparable<Employee>` to enable comparison based on the employee ID.

### `ArraySorter<T>` Class

- Implements a generic sorting algorithm to sort arrays of type `T`.
- Utilizes `IComparable<T>` for comparison between elements.

### `DisplayArray<T>` Method

- A helper method to display sorted arrays of type `T`.

