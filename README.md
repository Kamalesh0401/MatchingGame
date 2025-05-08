# 🧠 Matching Game - Windows Forms Application

A classic **Matching Game** (Memory Game) developed using **C#** and **Windows Forms**. This game challenges users to match pairs of hidden tiles based on memory. It features multiple difficulty levels, a scoring system based on time taken, and an interactive user interface.

---

## 🚀 Features

- 🧩 Dynamic grid layout based on difficulty (Easy, Medium, Hard)
- ⏱ Timer to track how long the user takes to complete the game
- 🧠 Randomized card positions on every new game
- 🔢 Score calculation based on level and time taken
- 🎨 Interactive and responsive tile click behavior
- 🏁 Leaderboard / high score tracking system
- 💾 Progress and statistics saved using SQLite
- 🏆 Final score display after game completion


## 🛠 Technologies Used

- **C#**
- **.NET Framework (Windows Forms)**
- **Visual Studio**


## 🎮 Game Levels

| Level   | Grid Size | Suggested Time to Beat |
|---------|-----------|------------------------|
| Easy    | 4 x 4     | ~10 seconds            |
| Medium  | 6 x 6     | ~20 seconds           |
| Hard    | 8 x 8     | ~30 seconds           |

> ⏱ These times are suggested goals. Players who complete levels faster than the benchmark are considered high performers.


## 📊 Score Calculation Logic

- The score is calculated based on the **time taken** to complete the game.
- There is **no fixed maximum score**—a **lower time equals a better score**.
- Timer starts as soon as the game board is generated.
- Your final score is displayed once all pairs are matched.

**Example:**

If a user completes the Medium level in `75 seconds`, the score recorded is simply `75`.

This approach encourages players to **improve speed and memory** with each level.


## 🧩 How to Play

  - Enter Name and select a level from the menu (Easy, Medium, Hard).
  
  - Select theme which interfare you like(Classic, Animals, Fruits, Numbers, Letters).

  - The game board will generate a grid of hidden tiles.

  - Click on two tiles to flip them.

  - If they match, they remain visible.

  - If they don't match, they flip back.

  - The game ends when all pairs are matched.

  - Your time and score will be displayed.


## 🖼 Screenshot
![image](https://github.com/user-attachments/assets/0cf73a7e-69d6-44b0-b9d7-bfe6558737f0)


## 🏗 Project Structure

/MatchingGame
├── MatchingGame.cs    # Main game logic and UI
├── SQLite.cs          # Logic for score, user to store in SQLite File
├── Program.cs         # Entry point
├── README.md          # Project documentation
└── Resources/         # Optional images/icons for cards


## 📦 Setup Instructions
  - Clone the repository or download the ZIP.

  - Open the .sln file using Visual Studio.

  - Build the solution.

  - Run the application (F5 or Ctrl+F5).

    
## ✅ To Do / Future Enhancements

  - 🔊 Add sound effects

  - 🌟 Add animations for tile flip

  - ⭐ Implement a star rating system based on time and accuracy

  - ☁️ Sync user progress to cloud or allow multi-device login


## 🙋‍♂️ Author

**Kamalesh** | [Portfolio](https://kamaleshdev.netlify.app) | [LinkedIn](https://www.linkedin.com/in/kamalesh-s-aa5031248/) | [GitHub](https://github.com/Kamalesh0401)


## 📄 License

- This project is open-source and available for educational and personal use.
