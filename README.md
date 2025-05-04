# DiaryApp: A Journal and Note-Taking Application
___

## 📘 Project description and features
___
- DiaryApp is a journal and notes management application for writing down and managing your individual notes for the day. The project features file handling, alongside input validation or error handling, to ensure file consistency.

## 🧱 How OOP principles are used
___

### 🔒 Encapsulation

Encapsulation is enforced within the Diary class by making internal methods and properties private. For example, the ``filepath` attribute and `GetAllEntries()` method are private, ensuring they are not accessible outside the class. Only the public methods necessary for external interaction—such as viewing entries and performing other user-facing actions—are exposed. This design protects the internal state and logic of the Diary class, reducing the risk of unintended interference or unintended misuse of methods. Furthermore, this encapsulation further reinforces what the class's responsibility is: it only performs the read and write operations on the diary, and nothing else.

### 💭 Abstraction

The project uses an IDiary interface to define the essential diary operations: reading, writing, and searching entries by date. The Diary class implements this interface, allowing the core menu logic to remain abstracted from the specific implementation details of the diary.

By implementing the IDiary interface, the Diary class is effectively decoupled from the Menu classes. The Menu doesn't have to concern itself with how Diaries work, all it has to know is that it can read, write, and filter by date. By doing so, it allows for a modular design: one could easily switch diary types without having to alter code in the main menu. Furthermore, this also allows the implementation of new complex Diary types so long as they implement the IDiary interface.

## Instructions on running the app
___

1. Clone the repository
2. Compile the program using `dotnet build` in the terminal
3. Run the project by using `dotnet run --project DiaryApp`

## 📁 File structure
___

CS222Team9Lab3/
├── DiaryApp/
├── .gitignore
├── DiaryProgram.sln
└── README.md


## 📷 Sample output
___

## 👨‍💻 Team members
___

## 🙏 Acknowledgement
___
