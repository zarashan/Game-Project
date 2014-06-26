
function buildArea(%myScene)
{
    // Create the composite sprite.
    %composite = new CompositeSprite();

    %composite.setSceneLayer(29);

    // Set the batch layout mode.  We must do this before we add any sprites.
    %composite.SetBatchLayout( "off" );

    // Add upper left desert
    %composite.addSprite();
    %composite.setSpriteLocalPosition(0, 0);
    %composite.setSpriteSize(100, 75);
    %composite.setSpriteImage( "StartingArea:topLeft");

    // Add upper right desert
    %composite.addSprite();
    %composite.setSpriteLocalPosition(100, 0);
    %composite.setSpriteSize(100, 75);
    %composite.setSpriteImage( "StartingArea:topRight");

    // Add lower left desert
    %composite.addSprite();
    %composite.setSpriteLocalPosition(0, -75);
    %composite.setSpriteSize(100, 75);
    %composite.setSpriteImage( "StartingArea:bottomLeft");

    // Add lower right desert
    %composite.addSprite();
    %composite.setSpriteLocalPosition(100, -75);
    %composite.setSpriteSize(100, 75);
    %composite.setSpriteImage( "StartingArea:bottomRight");

    // Add to the scene.
    %myScene.add( %composite );
}


function buildground(%myScene)
{
   
      $groundSize = "150 10";
    %Ground = new Sprite()    
      {
        image = "StartingArea:wall";
        position = 0 -150;
        size = $groundSize;
        SceneLayer = "15";
        SceneGroup = "15";
    };      
   %Ground.setBodyType( static );
    
    %Ground.createPolygonBoxCollisionShape($groundSize);
    %Ground.setCollisionGroups( "15" );
    
    %myScene.add (%Ground);
}