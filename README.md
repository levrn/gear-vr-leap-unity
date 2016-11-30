# gear-vr-leap
Workaround in Unity to use Leap Motion Controller with Gear VR (or any other headset that doesn't support it)


## Motivation

It is currently "impossible" to use Leap Motion with the Gear VR (in Unity 3D). You can't plug in the Leap to the phone or the Gear and access it's data from there. Furthermore, Leap Motion's Android SDK is (as of this writing) in alpha (invite only, with invites closed).

## How it works

The repository is a Unity package that leverages `Unity Networking` over a local wifi connection between the Android device and a PC. 

The Android device/application acts as the server and while the PC Application acts as the client. Both devices need to be on the same local network.

The client player consists of two custom knobby hand prefabs (created following this [tutorial](https://developer.leapmotion.com/documentation/unity/unity/Unity_MakeDiscreteHand.html)) and the camera object. The client player's hands is being controlled by the Leap Motion using the official Leap core assets and SDK. 

The client player will be spawned on the server with it's `Transform` being sent over the local network to the server using Unity's `NetworkTransform` and `NetworkTransformChild`. 

Conceptually, this is a simple multiplayer game where the movement of one player gets streamed for the other player to view. 

### High level schematic

![high level schematic](http://res.cloudinary.com/duswj2lve/raw/upload/v1479252306/Levrn_-_4_kstjln.jpg)

## Example(s)
You can download the example APK and EXE [here]()
All you need to do is run the app(s) and follow the steps in "How to use it", starting from step 9.

## Prequisites

It is important to already have Leap Motion working in your Unity Project.
-  Make sure you have the Leap SDK Installed. Get it [here](https://developer.leapmotion.com/v2)
- Also, if you're using the free version of unity, make sure you've done [this](https://developer.leapmotion.com/getting-started/unity/free)

## How to use it

1. Fork/clone this repository. (Apologies. This might take a while; large files)
2. Connect your android device and smart phone to the same local network.
3. In the `gear-vr-leap packages` folder, there are two packages. One for the mobile app and one for the PC app. They're essentially the same. Only difference is that one (mobile) of them starts in VR mode. Import the appropriate package into your unity project.
4. If you already have Google VR and Leap Motion packages in your project, do not forget to deselect them during importation.
5. Make sure to add the scenes in the package to your build.
7. Build the appropriate project for android and have it run on your smartphone.
8. Run the appropriate project on your computer too. (Make sure you have the Leap Motion device connected)
9. On the android smartphone, click "Server". The IP address of the device will be displayed.
10. On the PC, click "Client". Then enter the IP address of the server, 
11. On the android smartphone, click "Create Room" (to begin the online session).
12. On the PC, click "Join Room" (to join this session).
13. Now you may move your hands over the leap motion and watch your actions be mirrored on the smartphone.

With this as a base, you can proceed to build your Leap controlled Gear VR game. The only drawback is that your leap has to be tethered to the PC via USB. 

## Building your own application
Once the connection has been made and the session is joined, the game will be moved to the Online Scene. This is where all the additions you need to make to your game/experience should be. 

Furthermore, you only need to work on the Online Scene within your Android Unity Project, you don't need to keep making changes to the Unity Project that builds for PC.

However, you need to note that the **exact same character prefab** (the hands) need to be present in the PC/Desktop Unity Project, including the meta files. It is this prefab that you'll have to work on if you want to modify/change how hands are displayed in your game.

## Screenshots

![screenshots](http://res.cloudinary.com/duswj2lve/image/upload/v1480498557/compiled_ia2vop.jpg)


## Contributing

Please help make this better by making pull requests and posting issues. There are probably a lot of bugs and things that can be made better because we're relatively inexperienced with Unity. All contribution is welcome.

Contribution commits should be made in the `gear-vr-leap-mobile` and `gear-vr-leap-pc` folders. Those are the Unity Projects from which the packages are created.
