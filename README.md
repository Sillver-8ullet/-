# -
快い日常[こころよい にちじょう(Kokoroyoi Nichijou)] A Pleasent Routine, a cozy survival game.

### Plan

1. **Core Engine Setup**: Set up the basic structure of your game engine.
2. **Basic Game Loop**: Implement a simple game loop to handle updates and rendering.
3. **Entity-Component System (ECS)**: Create a flexible system to manage game entities and their behaviors.
4. **Modular System Support**: Design the engine to support modular systems/DLCs.
5. **Cozy Survival Core Mechanics**: Implement the basic mechanics of the cozy survival game.
6. **DLC Integration**: Show how to add modular systems like zombie apocalypse and post-apocalypse story.

### Pseudocode

1. **Core Engine Setup**:
    - Create a basic project structure.
    - Set up a game window.
    - Initialize necessary libraries (graphics, input, etc.).

2. **Basic Game Loop**:
    - Initialize game resources.
    - Enter the game loop (handle input, update game state, render).

3. **Entity-Component System (ECS)**:
    - Define entities and components.
    - Create a system to manage and update entities.

4. **Modular System Support**:
    - Design a plugin architecture to load additional modules/DLCs.
    - Implement a basic plugin system.

5. **Cozy Survival Core Mechanics**:
    - Implement player controls and basic interactions.
    - Add simple resource gathering and crafting.

6. **DLC Integration**:
    - Create example DLCs (zombie apocalypse, post-apocalypse story).
    - Show how to load and integrate these DLCs into the game.

### Implementation

**Project Structure:**
```
MyGameEngine/
|-- MyGameEngine.csproj
|-- Program.cs
|-- Game1.cs
|-- Core/
|   |-- Entity.cs
|   |-- Component.cs
|   |-- System.cs
|   |-- Module.cs
|-- Modules/
|   |-- BaseGame/
|   |   |-- BaseGame.cs
|   |-- AddOnName/
|   |   |-- AddOnName.cs
```
