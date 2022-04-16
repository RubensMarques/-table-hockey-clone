Made by:
Ibrahim Aladross
Version 1.0 - March 8, 2021

Version 1.1 - Updated March 13, 2021
    *Support for PS4 controllers added
    *Code rewritten to be cleaner and easier to read
    *ControllerButton class written to make it easier to check button states
    *ControllerDetector class added to check when controllers connect and disconnect

-This tool was designed to make it easy for you to get inputs from Xbox controllers and PS4 controllers.
-It supports up to 8 controllers by default.
-Examples for how to use this kit can be found in explanations below.
-You can use preprocessing directives to enable/disable XBOX or PS4 on the InputManager class


InputAxisGenerator
  -Prior to using the InputManager, you must generate Input Axes. The InputAxisGenerator component 
   can be used in the editor to generate all recommended XBOX axes and PS4 axes. 
      1. Attach the component to an empty game object.
      2. Click "Generate Recommended XBOX Axes" only once. Click "Generate Recommended PS4 Axes" only once.
      3. Either close your unity editor and reopen, or patiently wait for unity to update the input manager 
         axis list. This may take 1-2 minutes.
  -Once you have generated all the recommended axes, it is advised to delete this component from your game. 
   It is only needed to set up the input manager for you. If your input manager list doesn't update, you can
   force it to update by closing and reopening the unity editor.


InputManager 
  -The InputManager class is in charge of taking all inputs from the controllers and updating static
   variables accordingly. You can access these variables from any other script by referring to InputManager.
   There is no need to use the Unity Input class when you have the InputManagerSingleton active.

  -An InputManager singleton must be active in the scene for the InputManager class to update.

  -All XBOX inputs are stored in an XboxController array variable called xboxControllers.
  -All PS4 inputs are stored in an PS4Controller array variable called ps4Controllers.

  -To access axis input values on a specific controller, see the examples below:
     
     //The controller index ranges from 0-7 inclusive for XBOX, or 0-3 for PS4.
     float axisValue = InputManager.xboxControllers[1].LeftStickX; 

     //The controller index is one less than player number. 
     //0 indicates the first controller connected.
     //1 indicates the second controller connected.
     //2 indicates the third controller connected.
     float axisValue = InputManager.controllers[0].RightTrigger;

     //These values can be used in the same way as Unity's Input.GetAxis();
     //Values returned are in the range from 0-1 inclusive inclusive.
     //The dual trigger axis has values -1 to 1 and responds to both triggers



  -ButtonState: 
     "isPressed" is active for only one frame similar to Unity's GetKeyDown
     "isHolding" is active while the button is held down similar to Unity's GetKey
     "isReleased" is active for only one frame similar to Unity's GetKeyUp
     "isReady" is active while the button is not down, opposite of "isHolding"


  -To access button states on a specific controller, see the examples below:
     
     //This will call the function only one time when Player 1 presses "A"
     if (InputManager.controllers[0].A.IsPressed)
         CallFunctionHere();

     //This will call the function up to once per frame when Player 2 holds down "A"
     if (InputManager.controllers[1].A.IsHolding)
         CallFunctionHere();

     //This will call the function only one time when Player 1 lets go of "A"
     if (InputManager.controllers[0].A.IsReleased)
         CallFunctionHere();

     //This will call the function up to once per frame when Player 5 is not holding "A"
     if (InputManager.controllers[4].A.IsReady)
         CallFunctionHere();
   


