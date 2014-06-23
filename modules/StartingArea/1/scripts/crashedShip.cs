
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
   
    %composite_Ground = new CompositeSprite();
      $groundSize = "100 1";
    %composite_Ground.setSceneLayer(15);
    %composite_Ground.setSceneGroup(14);
   %composite_Ground.addSprite();
    %composite_Ground.setSpriteLocalPosition(0, -130);
    %composite_Ground.setSpriteSize(100, 10);
    %composite_Ground.setSpriteImage( "StartingArea:wall");
    
    %composite_Ground.createPolygonBoxCollisionShape($groundSize);
    %composite_Ground.setCollisionShapeIsSensor(0, true);
    %composite_Ground.setCollisionGroups( "15" );
    
    %myScene.add (%composite_Ground);
}