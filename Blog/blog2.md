# Blog 2 – AR 1st lab week

Authors: Julie, Maja, Simon, Rune

This week was focused on two areas: Getting an overview of the client’s
requirements and exploring the AR Sample project.

## Use case

The client would like an application that will help users understand how clime
change will affect the geology of coastal areas in Flanders, Belgium. AR will be
used to make complex scientific geological concepts more tangible to the users,
by showing the changing geology in an interactable model of the terrain.

The project will be a tabletop application, which means that the user will
select a flat plane in the real world, where the virtual model will be placed.
When the application starts, the phone will start scanning the camera feed for
feature points, which will be used to construct a point cloud. Afterwards the
user selects a place in the point cloud to place the model. Using the point
cloud, the phone’s position and rotation can be determined.

## AR sample project

We started by each getting a copy of the AR sample project and then
experimenting with adding different features to it. Most ended up being
prototypes that were scrapped later, but it still helped us gain experience in
working with AR in Unity.

We implemented a basic form of showing water level changes, where the user
controls the water level with a slider, and sees it applied to the AR model.

We also implemented a basic storyboard system, where different parts of the
terrain can be highlighted along with a textual description. Marker objects
could be placed on the terrain and then given a text string and a time duration.
An animation manager would then iterate through the markers and animate a cursor
between them.

<img width="336" height="211" alt="image" src="https://github.com/user-attachments/assets/36721d41-1cb8-4a86-a1e4-c6e68f17067e" />

