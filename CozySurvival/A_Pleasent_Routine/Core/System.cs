// Core/System.cs
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace A_Pleasant_Routine.Core
{
	public abstract class System
	{
		protected List<Entity> Entities;

		public System()
		{
			Entities = new List<Entity>();
		}

		public void AddEntity(Entity entity)
		{
			Entities.Add(entity);
		}

		public abstract void Update(GameTime gameTime);
	}
}
