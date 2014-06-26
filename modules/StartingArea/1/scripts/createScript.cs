function createSprite()
{
   %anim = "ToyAssets:TD_Wizard_WalkWest";
   %hero = new Sprite()
    {
        Animation = %anim;
         class = "createScript";
        position = "%CameraX %CameraY";
        size = getSpriteSize();
        SceneLayer = "15";
        SceneGroup = "15";
        CollisionCallback = true;
    };  
    return %hero;
}

function getSpriteSize()
{
	return "30 30";
}

function createScript::setXPos(%this)
{
  %hero.position = %this; 
}

function createScript::onCollision(%this, %object, %collisionDetails)
 {
    echo("it Worked");
 }