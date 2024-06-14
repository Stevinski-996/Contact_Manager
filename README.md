# Contact Manager

A simple C# console application for managing a list of contacts.

## Features

* **Add Contact:**  Add new contacts to your list.
* **Remove Contact:** Delete existing contacts.
* **View All Contacts:** See a list of all your contacts.

## Getting Started

1. **Prerequisites:**
   - .NET SDK installed on your system (https://dotnet.microsoft.com/download)

2. **Build and Run:**
   - Open a terminal and navigate to the project directory.
   - Run the following command to build and run the application:
     ```bash
     dotnet run
     ```

3. **Using the Application:**
   - Follow the on-screen menu to choose options:
     * **1:** View your contacts.
     * **2:** Add a new contact.
     * **3:** Remove a contact.
     * **4:** Exit the application.

## Code Overview

* `Program.cs`: Contains the main logic of the application, including:
    - `Main` method: Starts the program and handles user interaction.
    - `AddContact` method: Adds a new contact to the list, ensuring it's not empty or a duplicate.
    - `RemoveContact` method: Removes a contact from the list if it exists.
    - `ViewAllContacts` method: Prints all contacts in the list.

* **`contacts` list:** Stores the contact names.

## Error Handling

* The application provides error messages for invalid input (e.g., empty contact names) and attempts to remove non-existent contacts.
* **NOTE:** The error messages are displayed in red color in the console.

## Contributing

Feel free to contribute to this project by submitting issues or pull requests.

## License

This project is licensed under the MIT License...
