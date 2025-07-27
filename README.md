# Return Keyword Demo in C\#

## Overview

This is a simple C# console application demonstrating the use of the `return` keyword in methods. It allows the user to input two numeric values, multiplies them using a method, and displays the result.

## Features

* Demonstrates how to use the `return` keyword to pass values back from a method
* Includes basic error handling using `try-catch-finally`
* Converts user input from the console to `double` data type
* Multiplies two user-provided values and prints the result

## How It Works

1. The program prompts the user to input two numeric values (`ValueX` and `ValueY`).
2. These values are passed to the `Multiply` method.
3. The `Multiply` method returns the product of the two numbers.
4. The result is displayed in the console.

## Code Structure

### Main Method

* Reads input from the user.
* Calls the `Multiply` method.
* Displays the result.
* Handles exceptions and displays appropriate error messages.

### Multiply Method

* Accepts two `double` parameters.
* Multiplies the values and returns the result.
* Handles internal exceptions and returns `0` in case of an error.

## Sample Output

```
Enter Value X: 5
Enter Value Y: 4
5 * 4 = 20
Press any key to exit...
```

## Requirements

* .NET Framework or .NET Core SDK
* C# compatible IDE or text editor (e.g., Visual Studio, Visual Studio Code)

## How to Run

1. Clone this repository:

   ```
   git clone https://github.com/Naoyuki-Christopher-H/return-keyword-demo-cs.git
   ```
2. Open the solution in Visual Studio or another C# IDE.
3. Build and run the project.

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---
