using System.Diagnostics;

namespace Snake.Src
{
    /// <summary>
    /// Not stolen from: https://www.reddit.com/r/csharp/comments/ypojtb/how_to_make_an_update_loop_in_a_game/
    /// </summary>
    public class GameLoop
    {
        #region Ctor & fields

        private const int TargetUpdateRate = 60;
        private const int TargetRenderRate = 144;
        private const double UpdateInterval = 1000.0 / TargetUpdateRate;
        private const double RenderInterval = 1000.0 / TargetRenderRate;

        private Stopwatch stopwatch;
        private double accumulatedTime;
        private double accumulatedRenderTime;
        public bool Running { get; set; }

        // Counters for update and render calls
        private int updateCount;
        private int renderCount;
        private double secondCounter;

        public GameLoop()
        {

        }

        #endregion

        public void Start()
        {
            stopwatch = new Stopwatch();
            accumulatedTime = 0.0;
            Running = true;

            // Start the game loop in a separate thread
            Thread gameThread = new Thread(Loop);
            gameThread.IsBackground = true;
            gameThread.Start();
        }

        private void Loop()
        {
            stopwatch.Start();

            double lastFrameTime = stopwatch.Elapsed.TotalMilliseconds;

            while (Running)
            {
                // Calculate elapsed time
                double currentFrameTime = stopwatch.Elapsed.TotalMilliseconds;
                double elapsedTime = currentFrameTime - lastFrameTime;
                lastFrameTime = currentFrameTime;

                // Accumulate elapsed time
                accumulatedTime += elapsedTime;
                accumulatedRenderTime += elapsedTime;
                secondCounter += elapsedTime;

                // Update game logic if enough time has passed
                while (accumulatedTime >= UpdateInterval)
                {
                    float deltaTime = (float)UpdateInterval / 1000.0f; // Convert to seconds
                    Update(deltaTime);
                    accumulatedTime -= UpdateInterval;
                    updateCount++;
                }

                // Render the game if enough time has passed
                if (accumulatedRenderTime >= RenderInterval)
                {
                    Render();
                    renderCount++;
                    accumulatedRenderTime -= RenderInterval;
                }

                // Sleep if necessary to maintain target update and render rates
                if (accumulatedRenderTime < RenderInterval && accumulatedTime < UpdateInterval)
                {
                    int sleepTime = (int)Math.Min(UpdateInterval - accumulatedTime, RenderInterval - accumulatedRenderTime);
                    if (sleepTime > 0)
                    {
                        Thread.Sleep(sleepTime);
                    }
                }

                // Log and reset counters every second
                if (secondCounter >= 1000.0)
                {
                    Debug.WriteLine($"Updates per second: {updateCount}, Renders per second: {renderCount}");
                    updateCount = 0;
                    renderCount = 0;
                    secondCounter = 0.0;
                }
            }

            stopwatch.Stop();
        }

        private void Update(float deltaTime)
        {
            // Push update to updator so it can do something with it.
            Game.Updater.Update(deltaTime);
            //Debug.WriteLine("Delta = " + deltaTime);
        }

        private void Render()
        {
            if (Game.InnerFrame.InvokeRequired)
            {
                Game.InnerFrame.Invoke(new MethodInvoker(Game.InnerFrame.Refresh));
            }
        }
    }
}