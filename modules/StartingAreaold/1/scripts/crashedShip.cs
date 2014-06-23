
function buildArea(%scene)
{
    // Background
    %background = new Sprite();
    %background.setBodyType( "static" );
    %background.setImage( "StartingArea:bottomLeft" );
    %background.setSize( 100, 75 );
    %background.setCollisionSuppress();
    %background.setAwake( false );
    %background.setActive( false );
    %background.setSceneLayer(30);
    %scene.add( %background );
}

function getSpriteSize(%anim)
{
	return "10 10";
}