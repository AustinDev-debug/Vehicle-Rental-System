# Vehicle Rental System

A console-based vehicle rental system built in C#. This application allows users to manage a fleet of cars and trucks by adding vehicles, searching for them, renting them out, returning them, and viewing all available vehicles.

This project was created to strengthen object-oriented programming skills while learning inheritance, constructors, and C# properties.

## Features

* Add cars to the rental fleet
* Add trucks to the rental fleet
* List all vehicles
* Search for a vehicle by model
* Rent available vehicles
* Return rented vehicles
* Input validation for text and numeric values

## Concepts Used

* C#
* Object-Oriented Programming (OOP)
* Classes and Objects
* Inheritance
* Constructors
* Properties (`get` / `set`)
* Lists (`List<T>`)
* Methods
* Switch Statements
* Loops (`for` and `foreach`)
* Input Validation

## Project Structure

* **Vehicle** – Base class containing shared vehicle information.
* **Car** – Inherits from `Vehicle` and stores the number of doors.
* **Truck** – Inherits from `Vehicle` and stores towing capacity.
* **Program** – Handles the menu system and user interaction.

## What I Learned

While building this project, I learned how inheritance allows multiple classes to share common functionality through a base class. I also learned how constructors work with inherited classes using `base()`, and how C# properties provide a cleaner way to store and access object data compared to public fields.

## Future Improvements

* Save vehicles to a file or database
* Load saved vehicles when the application starts
* Allow vehicles to be removed or edited
* Search by make, year, or multiple criteria
* Display additional information when listing vehicles
* Track customer information for rentals
* Calculate rental costs based on the number of days rented

## How to Run

1. Open the solution in Visual Studio.
2. Build the project.
3. Press **F5** or click **Start**.
4. Use the menu to add, search, rent, and return vehicles.

## Author

Created by Austin (AustinDev-Debug) as part of a series of C# projects focused on learning object-oriented programming and software development.
