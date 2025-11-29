# Blog 4 – AR 3rd lab week

Authors: Julie, Maja, Simon, Rune

## Occlusion

In a basic AR application, the virtually rendered models are simply overlay onto
the camera feed. This means that if any real objects passes between the
phone’s camera, and the point on which the virtual model is placed, then the
virtual model will still be shown on top, even though it should be behind the
object.

One solution to this problem is creating a predefined 3D model of the real
environment. This model will not be visible on the final rendered image but will
be used for occluding the virtual objects. However this approach is not feasible
for our use case, since the user is able to place the virtual model anywhere
they like, so a predefined 3D model of the environment is not possible.

Another solution is to calculate occlusion in real-time. This would require
newer technology, which is not fully reliable yet, and is also not widely
available. For this project we decided that implementing occlusion detection was
not necessary. Typically, no objects will be between the user and the tabletop
model. This means that the hardware requirements for the application are
lighter, and therefore users with older phones would still be able to use the
application.

## Marker-less vs. marker-based

As described in the blog post 2, the application uses point clouds to find flat
planes to place to model on. Another solution could be to use marker-based
tracking. In marker-based tracking, a well-recognizable marker, such as a QR
code, is placed in the real world. This marker is then used to “calibrate”
to an initial known location. Afterwards the phone’s onboard odometry sensors
are used to detect changes in position and are able to transform the model using
homography. However, this requires extra preparation from the user, since they
would need to first print out a marker. With the marker-less approach, no
preparation is necessary, except for installing the application. However, the
tradeoff is that some inconsistencies may be visible. Since the requirements
specify a table-top experience, we determined that the marker-less approach
would give the best user experience of our prototype.

## Final application

Our final application is a proof-of-concept for an interactive model that
presents the geological effects of rising levels. The application demonstrates
how the user might interact with the model using placeholder terrain and
clickable points of interest. It does not make use of any real terrain data, or
real geological effects, but the model is self-containing and independent of the
rest of the application, so it could be swapped out for real terrain in the
future.

<img width="352" height="327" alt="image" src="https://github.com/user-attachments/assets/6c0c590a-e761-40f3-8480-c4c2b427d2f3" />

