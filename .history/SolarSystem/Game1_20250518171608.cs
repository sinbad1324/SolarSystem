using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SolarSystem.Globals;
using SolarSystem.Maths;
using SolarSystem.Module.Astre;

namespace SolarSystem;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Planet p1;
    private Planet p2;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = GParams.WINDOW_W;
        _graphics.PreferredBackBufferHeight = GParams.WINDOW_H;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        p1 = new Planet(Vector2.One * 50, new Vector2(20, 50), 100);
        p2 = new Planet(Vector2.One * 80, new Vector2(200, 300), 200);
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        GParams.content = Content;
        p1.Initialize();
        p2.Initialize();
        base.Initialize();

    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        GParams.spriteBatch = _spriteBatch;
        p1.LoadContent("earth");
        p2.LoadContent("jupiter");
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        GParams.updateTime = gameTime;
        // TODO: Add your update logic here
    
        System.Console.WriteLine(Formule.Gravity());

        p1.Update();
        p2.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        GParams.drawTime = gameTime;
        // TODO: Add your drawing code here
        p1.Draw();
        p2.Draw();
        base.Draw(gameTime);
    }
}
