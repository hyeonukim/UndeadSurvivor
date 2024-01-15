# UndeadSurvivor

 ## Table of Contents

- [AchieveManager](#achievemanager)
- [AudioManager](#audiomanager)
- [Bullet](#bullet)
- [Character](#character)
- [Enemy](#enemy)
- [Follow](#follow)
- [GameManager](#gamemanager)
- [Gear](#gear)
- [Hand](#hand)
- [HUD](#hud)
- [Item](#item)
- [ItemData](#itemdata)
- [LevelUp](#levelup)
- [Player](#player)
- [PoolManager](#poolmanager)
- [Reposition](#reposition)
- [Result](#result)
- [Scanner](#scanner)
- [Spawner](#spawner)
- [Weapon](#weapon)

---

## AchieveManager

### Description
The `AchieveManager` class handles achievements related to unlocking characters in the game. It manages character lock/unlock states, checks achievement conditions, and displays notices for achievements.

### Implementation

The Awake method initializes achievements and player data.
The Start method unlocks characters based on player progress.
The LateUpdate method checks achievements on each frame.
The CheckAchieve method checks specific achievements and displays notices.
The NoticeRoutine method handles the coroutine for displaying achievement notices.

## AudioManager

### Description

The AudioManager class is responsible for managing background music (BGM) and sound effects (SFX) in the game. It provides methods to play, stop, and control audio levels.

### Implementation

The Awake method initializes BGM and SFX players.
The Init method initializes audio sources for BGM and SFX.
The PlayBgm method controls background music playback.
The EffectBgm method enables/disables a high-pass filter effect on the BGM.
The PlaySfx method plays specified sound effects.

## Bullet

### Description

The Bullet class represents projectiles in the game, handling their initialization, movement, and interactions with enemies. Bullets deal damage and may have a limited lifespan.

###Implementation

The Awake method initializes the bullet's rigidbody.
The Init method sets the bullet's damage, lifespan (if applicable), and initial velocity.
The OnTriggerEnter2D method handles collisions with enemy objects and decrements the bullet's lifespan.

## Character

### Description
The `Character` class provides static properties for various attributes related to the player's character. It includes speed, weapon speed, weapon rate, damage, and count modifiers based on the player's ID.

## Enemy

### Description

The Enemy class represents enemy entities in the game. It handles movement, health, collisions with bullets, and provides functionality for initialization and knockback.

### Implementation

The Awake method initializes required components.
The FixedUpdate method handles enemy movement.
The OnEnable method initializes enemy state when enabled.
The Init method sets initial enemy parameters.
The OnTriggerEnter2D method handles collisions with bullets.
The KnockBack method applies a knockback force to the enemy.
The Dead method deactivates the enemy game object.

## Follow

### Description

The Follow class ensures that a UI element follows the player's position on the screen.

### Implementation

The Awake method initializes the RectTransform component.
The FixedUpdate method updates the UI element's position based on the player's world position.

## GameManager

### Description

The GameManager class controls the game state, player information, and game progression. It includes methods for starting, retrying, and ending the game, as well as managing player stats and achievements.

### Implementation

The Awake method initializes the GameManager instance.
The Update method updates the game time and checks for victory conditions.
The GameStart method initializes the game with a specific player ID.
The GameOver method initiates the game over sequence.
The GameVictory method initiates the victory sequence.
The GetExp method increments the player's experience points.
The Stop method pauses the game.
The Resume method resumes the game.

## Gear

### Description
The `Gear` class represents gear items that modify player attributes. It includes methods for initialization, level-up, and applying gear effects.

### Implementation

The Init method initializes the gear with specific data.
The LevelUp method increases the gear's rate and applies the corresponding effects.
The ApplyGear method applies specific gear effects based on the gear type.
The RateUp method modifies the rate for specific weapon types.
The SpeedUp method increases the player's speed.

## Hand 

### Description

The Hand class handles the positioning and rotation of the player's hands based on their orientation.

### Implementation

The Awake method initializes the player's sprite renderer.
The LateUpdate method adjusts the hand's position and rotation based on the player's orientation.

## HUD

### Description

The HUD class manages various in-game information displayed on the Heads-Up Display (HUD). It includes methods for updating text and sliders for experience, level, kills, time, and health.

### Implementation

The Awake method initializes the Text and Slider components.
The LateUpdate method updates the UI elements based on the specified information type.

## Item

### Description

The Item class represents in-game items that the player can interact with. It includes methods for initialization, handling clicks, and leveling up items.

###Implementation

The Awake method initializes UI elements.
The OnEnable method sets the item's text and description when enabled.
The OnClick method handles item clicks and levels up items.

## ItemData

### Description

The ItemData class is a ScriptableObject that holds data for different types of in-game items. It includes information such as item type, ID, name, description, icon, level data, and specific properties for weapons.

### Implementation

The scriptable object contains data for item types, IDs, names, descriptions, icons, base damage, base count, damages, counts, projectiles, and hand sprites.

## LevelUp

### Description
The LevelUp class manages the level-up screen, including item selection and presentation. It includes methods for showing, hiding, selecting items, and generating the next set of items.

### Implementation

The Awake method initializes UI elements and items.
The Show method displays the level-up screen.
The Hide method hides the level-up screen.
The Select method handles item selection.
The Next method generates the next set of items for selection.

## Player

### Description
The `Player` class represents the player character. It handles player movement, input, collisions, and interactions with various components.

### Implementation

The Awake method initializes player components such as Rigidbody2D, SpriteRenderer, Animator, Scanner, and Hands.
The OnEnable method sets the player's speed based on character attributes.
The Update method handles player input for movement.
The FixedUpdate method moves the player based on input and speed.
The LateUpdate method updates the player's animation and sprite flipping.
The OnCollisionStay2D method handles continuous collisions, decreasing player health over time.

## PoolManager

### Description
The PoolManager class manages object pooling for various prefabs in the game. It helps optimize instantiation and destruction of game objects.

### Implementation

The Awake method initializes object pools for different prefabs.

## Reposition

### Description

The Reposition class repositions game objects when they exit a trigger area, ensuring proper gameplay flow.
The Get method retrieves an inactive object from the pool or creates a new one if the pool is empty.

### Implementation

The Awake method initializes the Collider2D component.
The OnTriggerExit2D method repositions the game object based on its tag when it exits a trigger area.

## Result

### Description

The Result class handles displaying the game result titles based on win or loss conditions.

### Implementation

The Win and Lose methods activate the corresponding title game objects.

## Scanner

### Description

The Scanner class scans for nearby game objects within a specified range and provides information about the nearest target.

### Implementation

The FixedUpdate method scans for nearby targets using Physics2D.CircleCastAll.

## Spawner

### Description

The Spawner class spawns enemies based on a predefined schedule during the game.
The GetNearest method finds the nearest target among the scanned objects.

### Implementation

The Awake method initializes spawn points and calculates the level time.
The Update method triggers enemy spawns based on the current game time.

## SpawnData

### Description

The SpawnData class holds data for enemy spawning, including spawn time, sprite type, health, and speed.

### Implementation

The class includes fields for spawn time, sprite type, health, and speed.

## Weapon

### Description
The Weapon class represents player weapons. It handles rotation, firing, level-up, and initialization of weapon properties.

### Implementation

The Update method handles weapon behavior based on the weapon type.
The Batch method creates a batch of bullets for rotating weapons.
The Fire method fires projectiles towards the nearest target.
The Init method initializes the weapon with specific data.
The LevelUp method increases the weapon's damage
