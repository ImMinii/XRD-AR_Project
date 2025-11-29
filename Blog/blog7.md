# Blog 7 – VR 3rd lab week

Authors: Julie, Maja, Simon, Rune

## Camera Movement and different renders & testing asynchronous screen

The cameras have 2 movement features. One is an automatic rotation and the other
controls the camera. The automatic rotation is always on except when the player
chooses to control a specific camera. It’s run by the script
“SecurityCameraAnimation”. The way that the automatic rotation works is that
the cameras have a list of rotation angles. The script rotates between the
specific angles in a loop. You are able to change the rotation speed and wait
time in the editor, so you have full control of the animation of the rotations.
The script that controls the cameras is under the “SecuritySystemHandler”.
This script is called “SecurityCameraControl” and works together with
“SecurityCameraSwitcher”. When the player chooses a camera in the UI, it
keeps track of an integer as mentioned in blogpost 6. This script sets an
integer for the “SecurityCameraControl” script. When clicking the button
that controls the chosen camera, it runs a method that disables
“SecurityCameraAnimation” and activates the arrow buttons, which make it
possible to control the camera. When switching to another camera the control
script automatically re-activates the animation script, continuing the animation
of the camera.

The game was an asynchronous game, having one in the VR headset and the other on
a touchscreen. This was fairly easy since coincidentally we did it correctly on
our first lab day. The VR camera was set to display 1 and all the UI things were
set to display 2. The game runs locally on one PC, and currently setting the
target displays to 1 and 2 in the editor isn’t enough. Instead, the gameobject
“MonitorHandler” has a “MonitorDisplay” script. This script just opens
another display when starting the game. So when the game is built and started,
it opens the VR view on one screen and UI view on the second screen.

## Fade to black on respawn

One of the challenges with VR is preventing nauseousness. If the VR headset
displays some kind of motion that the user does not feel themselves, the
discrepancy between what the player sees and fells can cause motion sickness.
Generally, in our game, the motion in the virtual world is initiated by the
player moving around in the real world, and the virtual world follows
accordingly. As long as there is minimal latency, the player will therefore both
see and feel the same motion.

However, a discrepancy occurs when the player respawns after being caught by an
enemy. The player’s position in the virtual world changes, but their position
in the real world stays the same. To make the sudden motion less noticeable, we
introduced a fade out to black animation, so the player does not see the
instantaneous teleport back to the respawn point. Once the teleport is done, the
animation fades in to the game again.
