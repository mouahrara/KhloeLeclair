using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Leclair.Stardew.CloudySkies.Models;


public enum LayerDrawType {
	Normal,
	Lighting
}


public interface IWeatherLayer {

	ulong Id { get; }

	LayerDrawType DrawType { get; }

	void ReloadAssets();

	void Resize(Point newSize, Point oldSize);

	void MoveWithViewport(int offsetX, int offsetY);

	void Update(GameTime time);

	void Draw(SpriteBatch batch, GameTime time, RenderTarget2D targetScreen);

}