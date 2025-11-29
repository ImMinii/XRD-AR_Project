# Blog 3 – AR 2nd lab week

Authors: Julie, Maja, Simon, Rune

This week was focused on gathering our experiences from last week and turning
them into a coherent prototype. We started by looking at the customer’s
requirements, and determined which requirements could be implemented, without
having real assets or terrain data. We would try to make a flexible system,
where placeholder assets could be used during development, but could later be
swapped out for real assets.

## Interactive model

The first requirement we focused on was making an interactive model of the
terrain, which could teach the user about the effects of saltwater intrusion.
The user should be able to click on special points of interest on the virtual
model, and then read or listen to a description of the area.

<img width="456" height="257" alt="image" src="https://github.com/user-attachments/assets/a341b2d2-fa0d-46ec-8276-080541fb70b6" />


In Unity we designed the model as its own self-contained object. The coordinates
for the selectable points and the terrain are relative to a common parent
object, so the whole model can be scaled, rotated and moved together. This way
the model could be easily scaled when placing it in the XR coordinate space.

## Placing the model

We based our project on the AR sample project from the Unity XR Interaction
Toolkit. This sample already uses the components from the XR Interaction Toolkit
to implement feature point tracking. By moving the camera around and comparing
the parallax of tracked features points with previous frames, the distance to
the tracked feature points can be determined, and therefore flat planes can be
identified.

When the user clicks, we perform a raycast in AR Session Space from the Camera
Offset towards the looking direction. If the raycast hits one of the detected
planes, we use the hitpoint to place a scaled down instance of the model, and
use the plane’s normal vector to orient it.

## Selecting a marker

If the model is already placed, and the raycast hits one of the model’s points
of interest, then this hit takes priority over hitting the detected planes. A
text popup is shown with a description of the selected point.

A simple animation is applied to the selectable markers, to show that they are
interactable. The markers’ offset from their parent follow a sine wave, with a
configurable amplitude and frequency.

<img width="450" height="109" alt="image" src="https://github.com/user-attachments/assets/0342c9f8-a9c3-4c54-bae5-d8a1df6bf6a9" />


## Placeholder terrain

We made a placeholder terrain model using Blender. The placeholder terrain is
not based on a real location but attempts to illustrate the terrain features
which a relevant for saltwater intrusion, for example groundwater inundations.

We utilized the integration between Blender and Unity to make prototyping
faster. The Blender project file could be directly used in the Unity scene, so
making changes in Blender could quickly be tested in Unity.
