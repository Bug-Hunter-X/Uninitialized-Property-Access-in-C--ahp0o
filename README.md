# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's been initialized.  This can lead to a `NullReferenceException` if the property is a reference type or unexpected behavior if it's a value type that hasn't been explicitly assigned a default value.

The `bug.cs` file contains the problematic code.  The `bugSolution.cs` file shows how to fix the issue.

## Problem
The `MyProperty` in `ExampleClass` is not initialized before it's used in `MyMethod`.  If `MyProperty` is not assigned a value before `MyMethod` is called, accessing `MyProperty` in `MyMethod` will result in a `NullReferenceException` if `MyProperty` is a reference type or undefined behavior if it is a value type.