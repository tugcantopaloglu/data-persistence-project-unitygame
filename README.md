# Data Persistence Project - Unity Game

This Unity project demonstrates the concept of data persistence in a game environment. It allows saving and loading player data, such as high scores and player names, across game sessions using local storage (JSON-based or PlayerPrefs-based).

## Features

- **Data Saving/Loading**: Stores player data (e.g., name and high score) across sessions.
- **Scene Transition Persistence**: Maintains data consistency across different scenes.
- **JSON Serialization**: Data is serialized and written to local files.
- **Modular Architecture**: Easy to adapt and integrate into other Unity projects.

## Technologies Used

- Unity Engine (2021.3 LTS or newer recommended)
- C# (MonoBehaviour scripts)
- JSON serialization
- Unity UI System

## Getting Started

### Prerequisites

- Unity Editor 2021.3 LTS or later
- .NET SDK compatible with Unity version

### Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/tugcantopaloglu/data-persistence-project-unitygame.git
   ```

2. Open the project with Unity Editor.

3. Load the initial scene from the `Scenes/` folder.

4. Press Play and test saving/loading functionality.

## Folder Structure

- `Assets/Scripts/`: Contains C# scripts managing data handling, UI, and core logic.
- `Scenes/`: Game scenes with UI and logic integration.
- `StreamingAssets/`: Location for persistent data files (if used).
- `Prefabs/`: UI components and reusable GameObjects.

## Usage

- Input a player name, play the game, and observe score tracking.
- Press Save to store your high score.
- Close and reopen the game to see persistence in action.
