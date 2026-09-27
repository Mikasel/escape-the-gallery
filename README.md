# 💎 Escape The Gallery

A 3D stealth game developed using Unity and C# as my first game development project.

The player infiltrates a gallery, steals a valuable gem, and must escape through the exit without being caught by the security guards.

## 🎮 Gameplay

The game consists of a single gallery level.

<img width="816" height="1038" alt="gameplay" src="https://github.com/user-attachments/assets/14370bca-a3b7-4351-becc-bb8f939d92c6" />

At the beginning of the game, security guards do not actively chase the player. The player must navigate through the gallery and steal the valuable gem.

Once the gem is collected, the security guards start chasing the player using Unity's NavMesh system.

The player must reach the exit before being caught.

## 📸 Screenshots

<img width="1763" height="1038" alt="Screenshot 2026-09-27 at 17 46 37" src="https://github.com/user-attachments/assets/ec139437-046d-4d12-92ed-60593cf538ef" />

## 🕹️ Controls

•⁠  ⁠⁠ W ⁠ ⁠ A ⁠ ⁠ S ⁠ ⁠ D ⁠ - Move
•⁠  ⁠⁠ Shift ⁠ - Increase movement speed
•⁠  ⁠⁠ R ⁠ - Restart the level

## ✨ Features

•⁠  ⁠3D stealth gameplay
•⁠  ⁠Single-level gallery environment
•⁠  ⁠Valuable gem objective
•⁠  ⁠Security guard AI
•⁠  ⁠NavMesh-based enemy pathfinding
•⁠  ⁠Dynamic enemy chase system
•⁠  ⁠Randomised enemy count.
•⁠  ⁠Sprint mechanic
•⁠  ⁠Win and lose conditions
•⁠  ⁠Level restart functionality

## 🤖 Enemy AI

The security guards use Unity's NavMesh system to navigate through the gallery and chase the player.

At the beginning of the level, the guards remain passive and do not follow the player.

When the player collects the gem, the enemy behavior changes and the guards begin pursuing the player.

If a guard catches the player, the game is lost.

## ⚙️ Technical Implementation

### Player Movement

The player can move using the WASD keys. Holding ⁠ Shift ⁠ increases the character's movement speed, allowing the player to escape from pursuing guards more quickly.

### Gem & Enemy Trigger

The gem acts as the main gameplay trigger.

Before the gem is collected, the security guards remain passive. Once the player obtains the gem, the guards are activated and begin chasing the player.

```text
Explore Gallery
       ↓
   Steal Gem
       ↓
Guards Start Chasing
       ↓
  Reach Exit
   ↙️       ↘️
 Win       Lose
            ↓
       Guard Catches
