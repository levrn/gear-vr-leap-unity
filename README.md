# gear-vr-leap
Workaround in Unity to use Leap Motion Controller with Gear VR (or any other headset that doesn't support it)


## Motivation

It is currently "impossible" to use Leap Motion with the Gear VR (in Unity 3D). You can't plug in the Leap to the phone or the Gear and access it's data from there. Furthermore, Leap Motion's Android SDK is (as of this writing) in alpha (invite only, with invites closed).

## How it works

The repository is a base/example Unity project that leverages `Unity Networking` over a local wifi connection between the Android device and a PC. 

The Android device/application acts as the server and while the PC Application acts as the client. Both devices need to be on the same local network.

The client player consists of two custom knobby hand prefabs (created following this [tutorial](https://developer.leapmotion.com/documentation/unity/unity/Unity_MakeDiscreteHand.html)) and the camera object. The client player's hands is being controlled by the Leap Motion using the official Leap core assets and SDK. 

The client player will be spawned on the server with it's `Transform` being sent over the local network to the server using Unity's `NetworkTransform` and `NetworkTransformChild`. 

Conceptually, this is a simple multiplayer game where the movement of one player gets streamed for the other player to view. 

### High level schematic

![high level schematic](http://res.cloudinary.com/duswj2lve/raw/upload/v1479252306/Levrn_-_4_kstjln.jpg)


## How to use it

1. Fork this repository and clone it.
2. Connect your android device and smart phone to the same local network.
3. Open the application in Unity 3D.
4. Connect the Leap Motion Controller to the PC.
5. Build the project for android and have it run on your smartphone.
6. Run the project on your computer too.
7. On the android smartphone, click "Server". The IP address of the device will be displayed.
8. On the PC, click "Client". Then enter the IP address of the server, 
9. On the android smartphone, click "Start Server" (to begin the online session).
10. On the PC, click "Join Game" (to join this session).
11. Now you may move your hands over the leap motion and watch your actions be mirrored on the smartphone.

With this as a base/starter project, you can proceed to build your Leap controlled Gear VR game. The only drawback is that your leap has to be tethered to the PC via USB. 

## Screenshots

![screenshots](http://res.cloudinary.com/duswj2lve/raw/upload/v1479255981/gearleap-shots_equvx3.jpg)


## Contributing

Please help make this better by making pull requests and posting issues. There are probably a lot of bugs and things that can be made better because we're relatively inexperienced with Unity. All contribution is welcome.
