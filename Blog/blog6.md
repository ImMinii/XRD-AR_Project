# Blog 6 – VR 2nd lab week

Authors: Julie, Maja, Simon, Rune

## Camera with UI

One of the things the screen players are able to do, is to watch through
“Security” cameras and switch between the different cameras in the world.
For the player there is a “SecuritySystemHandler” with different scripts.
The script “SecurityCameraSwitcher” is the one handling the cameras. It
keeps track of 2 lists and an integer. One list is for the cameras and the other
is for the corresponding UI buttons. By clicking one of these buttons, the
script knows the camera’s integer index, and switches to the right camera. It
then shows the camera feed on a screen which is an image inside of Unity. Each
camera has its own render texture that is used for giving the image a live feed
of the cameras. Additionally, the image has its own shader, which makes the
camera feel more like a classic security camera. The image has a grayscale
shader, so the image only shows black and white.


## World space and camera space UI

For rendering UI in unity, there are two overall options: World space and screen
space. When UI is rendered in World space, it is transformed/projected in the
same way as other objects in the scene. This means that the UI is subject to
perspective like a normal object. The UI looks larger when the player is closer,
and smaller when the player is further away. It can also be occluded either
partially or completely by other objects in the scene. This, in addition to the
perspective, makes the UI look like it is a physical object in the scene.

When UI is rendered in Screen space, it is mapped directly to the 2D dimensions
of the display. This means that the UI is not subject to perspective but instead
remains flat and fixed relative to the screen frame. The UI keeps a constant
size and rotation regardless of the player’s position or rotation. It is drawn
on top of everything else, ensuring it cannot be occluded by objects in the
scene. This makes the UI appear as a digital overlay that exists separately from
the game world.

Our project uses both screen and world space UI. Screen space UI is used on the
table touch screen player’s display. This makes the UI appear flat on the
surface of the table. For UI which the VR player interacts with, it is rendered
in world space. This is because the VR player interacts with the UI using their
handheld controllers, which they also perceive as physical objects in the scene.
If we had used screen space, the UI would appear as a heads-up display, which
would be unintuitive to interact with using the handheld controllers.

## NPCs

There are NPCs that patrol the map in predetermine routes. The NPC has a
cone-shaped field of view that if the player enters, the NPC will go from patrol
to chase mode. In chase mode, the NPC can follow you through doors. For the
pathfinding and making the NPC be able to go through doors, the door was moved
onto its own layer. This way the pathfinding could be baked without doors layer
interfering. If the player gets caught, the NPC will return to its own patrol
route and only after returning will the NPC be able to enter chase mode again.
Furthermore, if a door gets closed and the NPC loses sight, it will stop the
chase and go back to patrol mode. For the player to be detected by the NPC, it
uses the VR headsets position to figure out if it entered the field of view.
