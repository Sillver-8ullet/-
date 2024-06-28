// Core/Entity.cs
using System.Collections.Generic;

namespace A_Pleasant_Routine.Core
{
	public class Entity
	{
		public int Id { get; private set; }
		private List<Component> _components;

		public Entity(int id)
		{
			Id = id;
			_components = new List<Component>();
		}

		public void AddComponent(Component component)
		{
			_components.Add(component);
		}

		public T GetComponent<T>() where T : Component
		{
			return (T)_components.Find(c => c is T);
		}
	}
}
