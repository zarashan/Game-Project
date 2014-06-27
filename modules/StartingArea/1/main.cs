
function StartingArea::create( %this )
{
	//run script
   exec("./scripts/crashedShip.cs");
   exec("./scripts/createScript.cs");
   exec("./scripts/Scene.cs");
   exec("./scripts/SceneWindow.cs");
	//exec("./scripts/PlatformerCameraBehavior.cs");
	exec("./scripts/shooterControls.cs");
	createSceneWindow();
	createScene();
	
	mySceneWindow.setScene(myScene);
	%hero = %this.spawnPlayer();
		
	
   mySceneWindow.mount(%hero, "0 15", %force, true);
	

    // Set the gravity.
    myScene.setGravity(0, 9.8);
	
    /*StartingArea.topLeft = 35;
    StartingArea.topRight = -110;
    StartingArea.bottomLeft = -50;
    StartingArea.bottomRight = 140;*/
    // Limit the camera to the four sections of the desert
  // mySceneWindow.setViewLimitOn( StartingArea.topLeft, StartingArea.topRight, StartingArea.bottomLeft, StartingArea.bottomRight );
    
   
    // Add backgrounds
    //StartingArea.createBackground();
	
    buildArea(myScene);
    buildground(myScene);
	
	
}

//-----------------------------------------------------------------------------

function StartingArea::destroy( %this )
{

}

//-----------------------------------------------------------------------------

function StartingArea::reset(%this)
{
	
}

function StartingArea::spawnPlayer(%this)
{
    
	
	%CameraX = 10;
	%CameraY = 10;
    %hero = createSprite();
    %size = getSpriteSize();
	
	//mainWindow.CameraPosition(CameraX CameraY);
	
	%controls = ShooterControlsBehavior.createInstance();
	%hero.addBehavior(%controls);
	
   %hero.setBodyType("dynamic");  
    %hero.createPolygonBoxCollisionShape(%size);
    %hero.setCollisionGroups( "15" );

    myScene.add( %hero ); 
    return %hero;
}




