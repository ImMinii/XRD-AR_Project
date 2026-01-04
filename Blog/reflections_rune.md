# Reflections – Rune

## AR Project

This was my first time working with Unity, as well as my first experience with
AR and VR. I therefore found the beginning of the AR project quite challenging,
since both Unity and AR were new to me. Luckily, I was fortunate to work with
three other group members who all had experience with Unity from the GMD course
and had also worked with XR in their bachelor projects. They were a great help
in getting started with Unity and XR.

At the start, I experimented with implementing terrain placement. The Unity AR
Foundation library already provided feature point tracking and surface
detection, so placing the module was simply a matter of performing a raycast hit
on an ARPlane and then using the ARPlane's normal vector to orient the model.

In the AR project, my main contribution was the animated, clickable markers on
the terrain. I created a very basic cone model for the markers in Blender and
wrote a script in Unity so they bobbed slowly up and down in a sine wave to
indicate that they were clickable. Together with Julie, we added click detection
to the markers using raycasts, which worked alongside the scaling, moving, and
rotation of the terrain. We also added a popup that would display informational
text. Since the markers were placed on the terrain, which was itself clickable,
any raycasts that hit the markers could also hit the terrain. We therefore had
to ensure that raycast hits on the markers were prioritized over raycast hits on
the terrain.

We did not have a clear plan for which features to include in the AR project
from the start, so not everything we implemented made it into the final
prototype. One example is the "storyboard" system. I implemented a way to set up
a predefined path in the Unity Editor that could be used to highlight different
parts of the terrain in an animation, with different text messages at each part.

<img width="336" height="211" alt="image" src="https://github.com/user-attachments/assets/36721d41-1cb8-4a86-a1e4-c6e68f17067e" />

The implementation used Unity Gizmos to draw spheres in the Unity Editor, making
the path clearer and easier to set up. The storyboard and path could be
configured entirely within the Unity Editor, so positioning the path was easier
than writing coordinates in code, and we did not have to wait for recompilation
when changing the storyboard.

## VR Project

When we started the VR project, I felt that I had a much better understanding of
how to work with XR in Unity and could therefore get started faster. My main
contributions were the user interfaces for both players, the maze symbol logic,
and merging all our individual parts.

I implemented the login keyboard, the maze symbols, and the emoji puzzle. I
tried to build as much as possible using prefabs so that it would be easier to
integrate with the rest of the project. Since this was mostly UI work, it did
not relate much to XR. However, I learned a lot by working on merging our
individual parts. In the VR project, we each worked on different features in
separate scenes to avoid source control conflicts. This meant that once all
features were ready, they had to be merged into a complete scene.

As in the AR project, much of the VR technology was already available in Unity,
so most of the work was integrating Unity's XR Toolkit with our own project,
rather than implementing input handling, tracking, and rendering from scratch.
Therefore most of what I learned was also about how to apply XR features of
Unity to build AR and VR experiences.
