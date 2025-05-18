using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SolarSystem.Globals;
using SolarSystem.Module.Astre;

namespace SolarSystem;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Planet p1;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = GParams.WINDOW_W;
        _graphics.PreferredBackBufferHeight = GParams.WINDOW_H;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        p1 = new Planet(Vector2.One*50 , new Vector2(20,50) ,100); 
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        GParams.spriteBatch = _spriteBatch;
        GParams.content = Content;
        base.Initialize();

    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        GParams.updateTime = gameTime;
        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        GParams.drawTime = gameTime;

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
