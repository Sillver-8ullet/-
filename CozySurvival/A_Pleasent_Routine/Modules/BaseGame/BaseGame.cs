// Modules/BaseGame/BaseGame.cs
using System.Collections.Generic;
using System.Reflection;
using A_Pleasant_Routine.Core;
using A_Pleasant_Routine.Core.Components;
using A_Pleasant_Routine.Core.Systems;
using Microsoft.Xna.Framework;

namespace A_Pleasant_Routine.Modules.BaseGame
{
	public class BaseGame : Core.Module
	{
		private List<Core.System> _systems;
		private Entity _playerEntity;

		public BaseGame()
		{
			_systems = new List<Core.System>();
			_playerEntity = new Entity(1);
		}

		public override void Load()
		{
			// Initialize base game systems and entities
			var playerSystem = new PlayerSystem();
			_playerEntity.AddComponent(new PlayerComponent(100f));
			_playerEntity.AddComponent(new PositionComponent(new Microsoft.Xna.Framework.Vector2(0, 0)));
			playerSystem.AddEntity(_playerEntity);
			_systems.Add(playerSystem);
		}

		public override void Unload()
		{
			// Cleanup base game resources
			_systems.Clear();
		}

		public void Update(GameTime gameTime)
		{
			foreach (var system in _systems)
			{
				system.Update(gameTime);
			}
		}
	}
}
