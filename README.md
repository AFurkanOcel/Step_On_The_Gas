<h1 align="center">🚗 Step On The Gas</h1>

<p align="center">
3D endless driving game built with Unity and C#, featuring dynamic road gameplay, obstacle avoidance, collectible systems, and configurable day/night environments.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022.3%20LTS-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Game%20Type-Endless%20Driving-orange"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

# Overview

**Step On The Gas** is a PC-based arcade driving game where the player controls a vehicle on an endless road while avoiding traffic and obstacles, collecting coins, and maximizing score.

The project focuses on real-time gameplay mechanics, modular game systems, and interactive player controls within a responsive 3D environment.

---

# Project Structure

```text
Step_On_The_Gas/
├── Assets/
│   ├── Scripts/
│   ├── Scenes/
│   ├── Prefabs/
│   ├── Materials/
│   ├── Audio/
│   └── UI/
├── Packages/
├── ProjectSettings/
└── README.md
```

---

# Features

- Endless driving gameplay loop
- Dynamic road environment
- Coin collection & score tracking
- Traffic and obstacle avoidance
- Multiple camera modes (first-person / third-person)
- Vehicle horn and light controls
- Day / Night environment settings
- Pause and restart system
- Main menu & settings UI

---

# Technical Stack

| Component | Technology |
|-----------|------------|
| Engine | Unity 2022.3 LTS |
| Language | C# |
| UI | TextMeshPro + Unity UI |
| Physics | Unity Physics |
| Audio | Unity Audio System |
| Rendering | Built-in Render Pipeline |

---

# Architecture

The project follows a modular Unity scene architecture with separate systems for gameplay, environment management, user interface, and player interaction.

Core systems include:

- Player Vehicle Controller
- Camera Controller
- Coin & Score Manager
- Obstacle Spawner
- UI Manager
- Environment Manager

---

# Controls

| Key | Action |
|-----|--------|
| A / ← | Move Left |
| D / → | Move Right |
| Space | Switch Camera |
| Enter | Horn |
| L | Toggle Lights |
| P | Pause |
| R | Restart |
| Esc | Return to Menu |

---

# Screenshots

## Day Mode
<img width="1920" height="1080" alt="morning" src="https://github.com/user-attachments/assets/709c5697-0652-495e-af24-2f90807a9de3" />

## Night Mode
<img width="1920" height="1080" alt="night" src="https://github.com/user-attachments/assets/7ffe1404-6792-401f-bd00-7087e6cbdd6b" />

---

# Assets & Credits

External assets used from:

- https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085
- https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014
- https://assetstore.unity.com/packages/audio/sound-fx/score-and-time-59255
- https://assetstore.unity.com/packages/audio/music/fantasy-tavern-music-free-pack-118847

---

# Run Locally

```bash
git clone https://github.com/AFurkanOcel/Step_On_The_Gas
```

Open the project using **Unity Hub (Unity 2022.3.4f1)** and press **Play** inside the Unity Editor.

---

# Developer

**A. Furkan ÖCEL**
