using Blazor.Extensions.Canvas.Canvas2D;
using Simple.Core._2D;

namespace Pong.Shared
{
    public class BlazorGameContext : IGameContext
    {
        private readonly Canvas2DContext _context;

        public BlazorGameContext(Canvas2DContext context)
        {
            _context = context;
        }
        public void Draw()
        {
        }

        public void Initialize()
        {
        }

        public void LoadContent()
        {
        }

        public void Update()
        {
        }
    }
}
