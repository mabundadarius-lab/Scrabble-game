# LDIL Scramble Game 🎮

A console-based word guessing game built with **C#** and **.NET**. Players must guess hidden words based on a series of hints to progress through 15 increasingly difficult levels.

## 🚀 Features

* **Secure Access:** Password-protected entry (Password: `LDIL`).
* **Progressive Difficulty:** 15 unique levels with custom hints ranging from animals to local culture.
* **Hint System:** Each word comes with 3 distinct clues. If you fail a guess, the next hint is revealed to assist you.
* **Dynamic Visuals:** Uses console colors (Green for success, Red for failure) to provide instant feedback.
* **Object-Oriented Design:** Uses a dedicated `Scrabblegame` class to manage level data and state.

## 🛠️ Requirements

* [.NET SDK](https://dotnet.microsoft.com/download)
* A C# IDE (Visual Studio, VS Code, or JetBrains Rider)

## 🕹️ How to Play

1.  **Launch the App:** Run the program.
2.  **Login:** Enter the secret password `LDIL`.
3.  **Identify:** Enter your player name.
4.  **Guess the Word:**
    * Read **Hint 1**.
    * Type your guess and press `Enter`.
    * If incorrect, **Hint 2** and **Hint 3** will follow.
    * If all hints are exhausted, the word is revealed and the game continues.
5.  **Finish:** Complete all 15 levels to see the Game Over screen.

## 📂 Code Logic

The game operates on a nested loop structure:
1.  **Outer Loop:** Iterates through the `List<Scrabblegame>` levels.
2.  **Inner Loop:** Manages the three-hint attempt system per level.



## 📝 Level Preview

| Level | Word | Hint 1 | Hint 2 | Hint 3 |
| :--- | :--- | :--- | :--- | :--- |
| 1 | CAT | Small pet | Meows | Likes milk |
| 4 | LDIL | Has white tables | Has expensive screens | 15 girls and 10 boys |
| 15 | GIRAFFE | Tallest animal | Long neck | Spots |

## 🏗️ Future Roadmap

* [ ] **Scoring:** Implement a points system based on how many hints are used.
* [ ] **Shuffling:** Add an actual "Scramble" mechanic to display shuffled letters.
* [ ] **Persistence:** Save high scores to a `.txt` or `.json` file.

---
*Developed as a C# learning project.*
