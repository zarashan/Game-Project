function StartingArea::create( %this )
{

    // We need a main "Scene" we can use as our game world.  The place where sceneObjects play.
    
// Give it a global name "mainScene" since we may want to access it directly in our scripts.
   
 new Scene(mainScene);

   
 // Without a system window or "Canvas", we can't see or interact with our scene.
    
// AppCore initialized the Canvas already

    
// Now that we have a Canvas, we need a viewport into the scene.
    
// Give it a global name "mainWindow" since we may want to access it directly in our scripts.
    
new SceneWindow(mainWindow);
    
mainWindow.profile = new GuiControlProfile();
    
Canvas.setContent(mainWindow);

    
// Finally, connect our scene into the viewport (or sceneWindow).
    
// Note that a viewport comes with a camera built-in.
 mainWindow.setScene(mainScene);
    mainWindow.setCameraPosition( %posX, %posY );
    mainWindow.setCameraSize( 100, 75 );

    // load some scripts and variables
    // exec("./scripts/someScript.cs");

    buildArea(mainScene);
    //createAquariumEffects(mainScene);

   StartingArea.spawnPlayer();
}

//-----------------------------------------------------------------------------

function StartingArea::destroy( %this )
{
}

//-----------------------------------------------------------------------------

function StartingArea::spawnPlayer(%this)
{
    %anim = "ToyAssets:TD_Wizard_WalkWest";    
    %size = getSpriteSize(%anim);
	
	%CameraX = 10;
	%CameraY = 10;
    %hero = new Sprite()
    {
        Animation = %anim;
        // class = "FishClass";
        position = "%CameraX %CameraY";
        size = %size;
        SceneLayer = "15";
        SceneGroup = "14";
        minSpeed = "5";
        maxSpeed = "15";
        CollisionCallback = false;
    };
	
	//mainWindow.CameraPosition(CameraX CameraY);
	
	%controls = ShooterControlsBehavior.createInstance();
	%hero.addBehavior(%controls);

    %hero.createPolygonBoxCollisionShape(%size);
    %hero.setCollisionShapeIsSensor(0, false);
    %hero.setCollisionGroups( "15" );

    mainScene.add( %hero ); 
}
