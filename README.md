# AR-Series
Setup of basic AR scenes using Unity AR foundation



About the AR Template
The AR Project Template configures project settings for Unity applications that wish to use Augmented Reality.

This Template uses the following Unity features:

### AR Foundation: 
a tool that allows you to work with augmented reality platforms in a multi-platform way within Unity. This package presents an interface for Unity developers to use. For more information see the AR Foundation docs.
Interfaces for the following platforms: **ARCore, ARKit, Hololens, and Magic Leap.**

### XR Management: 
a tool to help streamline XR plug-in lifecycle management and potentially provide users with build time UI through the Unity Unified Settings system. For more information see the XR Management docs.

The template contains the following:

- A sample scene that is already configured for Augmented Reality, including an `AR Session` and `AR Session Origin`.
- Example Assets for an AR Scene all in a single folder that can be easily removed.


Using the AR Project Template
Using the sample Scene
The template contains a Scene named SampleScene. This scene contains sample materials and models. It additionally contains all the tutorials, and a script that allows you to spawn anchors through input.

You can use this Scene as a reference, or you can remove the example Assets from it and use it as a starting point for your own Project.

Removing the example Assets from the Scene
If you want to completely remove the example Assets from your Project, it is easy to do so.

In the Project window, open the Assets folder
Right click the ExampleAssets folder
Click Delete
In the pop-up that appears, click Delete
Be sure to remove the disconnected script from the ARSessionOrigin object. XR Management Menu
How to build to a specific platform
In order to make sure your application seemlessly builds to your desired platform you must do that following.

Open Edit > ProjectSettings
Open the XR Plug-in Manager Menu XR Management Menu
Select your desired platform and select at least one provider from the list for that platform. Providers for PC, Mac & Standalone
Build.
