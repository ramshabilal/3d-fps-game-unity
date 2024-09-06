# 3D First Person Shooter Game

This project is an exciting 3D First Person Shooter Game developed in Unity where a player can navigate a rugged area and fight enemy drones. 

## **Video of gameplay:** https://drive.google.com/file/d/1dMSY0m-_qy45jA6A7LfXvRgTqsgkyX_P/view?usp=sharing

## Features Implemented
#### First Person Character and Weapon
- The main player sees their weapon on the screen as they navigate through the scene.
- Player can walk or run around, jump, and shoot.
- The player can shoot. If they shoot enemies, the enemies die and disappear.

#### Enemy drones, states, and AI waypoints
- Enemy drones attack players
- Patrol state: Enemies are in Patrol state initially and they follow a bunch of waypoints around them. In this state they search the area around them for player. If found, they go into follow state.
- Follow state: when in follow state, they follow the player and when close enough (within shooting distance) they go into attack state.
- Attack State: In this state, enemy drones attack the player by shooting bullets at them. Some enemies have fire sound while others have bullet shell sounds.
- Spotlight colors: Different drones have different sizes and spotlight colors. Also, the spotlight color becomes red when enemy attacks so player knows they are udner attack. Shooting sound also plays when they attack.

#### Player Health
- Player has 200 health at the beginning of game. When enemy drones attack, the player loses health due to damage. The damage inflicted depends on the drone - some bigger drones cause 20 damage, while smaller ones cause 10 damage.

#### HUD - Display Player Health
- A Display allows user to see the player health so they know when they lose health due to enemy attack.

#### Automatic Doors
- To add interactivity, automatic doors are added to the scene that open when player is nearby and close again when the player is far.

#### Design elements
- To add life to the scene, trees, crates, barrels, and boxes are added to the scene to enhance design and realism. Also, corridoors and automatic doors are added.
- The terrain has a rugged look to it to increase thrill.

#### Sound or FX
- Sound effects such as shooting, running, jumping, etc sounds are added to enhance the gaming experience.

#### Assets and Elements
- Various assets such as weapons, sci-fi lite, and crates-barrels etc are used.
- Elements include the use of Scripts, Nav Mesh, colliders, rigid body, and similar elements to enable various features.

## Video Demo

**Updated demos:**

**Video of gameplay:** 
https://drive.google.com/file/d/1dMSY0m-_qy45jA6A7LfXvRgTqsgkyX_P/view?usp=sharing 

**Initial demo:**
https://drive.google.com/file/d/1_7Dk16SLnBf1XjoXsJRL2hiqjKPJdQSM/view?usp=sharing

### All requirements of the assignment are met.

## Main Scene
[fps_scene.unity file contains the main scene](Assets/fps_scene.unity)
