function createSceneWindow()
{
    // Sanity!
    if ( !isObject(mySceneWindow) )
    {
        // Create the scene window.
        new SceneWindow(mySceneWindow);

       // Set Gui profile. If you omit the following line, the program will still run as it uses                
       // GuiDefaultProfile by default

        mySceneWindow.Profile = GuiDefaultProfile;

        // Place the sceneWindow on the Canvas
        Canvas.setContent( mySceneWindow );                     
    }
    mySceneWindow.setCameraSize( 200, 150 );
   
}

function destroySceneWindow()
{
    // Finish if no window available.
    if ( !isObject(mySceneWindow) )
        return;

    // Delete the window.
    mySceneWindow.delete();
}