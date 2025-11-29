# Blog 5 – VR 1st lab week

Authors: Julie, Maja, Simon, Rune

## HMD intro

The week before we started the HMD project and got the general concept written
down of which functions and aspects the program should have.

The concept of our HMD project was to create a game, with the overall theme of
it being a stealth puzzle game, where one was in a VR headset and other people
being on a separate big touch screen. Therefore, making the game a multiplayer
asynchronous VR game. By having this the main concept is therefore puzzle
communication, taking inspiration from the games ‘Operation Tango’ and the
series ‘We were here’. In our game we have the VR player moving around the
environment, looking for clues and solving puzzles while the players can see,
help and assist the player on the separate screen.

The game consists of three phases, where the first is the intro creating a feel
of the environment and theme. The second phase is the main part of the game. The
VR player is able to move around, hide from enemies and solve puzzles, while the
screen player helps and watches through cameras. The third and last phase is the
last puzzle taking what you’ve learned from the previous phase and applying
the players knowledge to solve the last puzzle.


## Starting VR development

Setting up a basic VR scene in Unity is very straightforward, since Unity has
ready-made templates, which set all the necessary packages. Additionally, it
also provides prefabs which already set up the whole XR rig, such that it can
simply be dragged into the hierarchy and be ready to interact with the other
unity subsystems, such as physics, rendering and UI.

The Unity XR stack consists of a large number of components, but at the top
level we interact with the XR hardware through the XR Interaction Toolkit. By
using this package, when can implement a VR application, without having to
interface with hardware-specific APIs. Of course, hardware-specific code and
drivers still have to be somewhere lower down the stack, but from our
applications viewpoint, we can run the same code on, for example Meta’s Quest
or HTC’s Vive headsets worrying about hardware-specific details.

We used the XR Interaction Toolkit and templates to quickly set up a simple VR
scene. We divided the game into smaller parts, which each person could work on
individually. Since we all based our parts on the same templates and prefabs
from XR Interaction Toolkit, it was not too difficult to combine our parts
later.

## Assets

We had decided that the environment would be an office building. To save time,
we started looking at Unity- and Blenders free assets stores and found a scene
on Blender's store, that worked with our concept. We also found some more office
supplies, to make the scene more “lived in”. One of the assets was sticky
notes, where we edited the texture in blender, to have a password written on it,
that could be used in the puzzle to get to the next room.

<img width="589" height="299" alt="image" src="https://github.com/user-attachments/assets/f65dcbab-2019-46ec-8b2b-672ca3924172" />

When pushing the assets to GitHub, our version control system, we were met with
a challenge. The asset for the office scene was too large for GitHub to handle.
To solve this, we used Git Large File Storage (Git LFS). Git LFS provides a
workaround for handling very large files inside a Git repository. Instead of
storing the full file directly in the repository, Git LFS replaces it with a
small pointer file. This pointer doesn’t contain the data itself but functions
as a reference to where the actual file is stored externally. GitHub manages
these pointer files alongside the rest of the project. In this way, the
repository remains lightweight, while still allowing large assets to be
included.
