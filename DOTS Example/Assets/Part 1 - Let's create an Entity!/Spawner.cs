using UnityEngine;
using Unity.Entities; // For ECS
using Unity.Mathematics; // For math in ECS
using Unity.Transforms; // For the equivalent of Transform in ECS

namespace Part1
{
	public class Spawner : MonoBehaviour
	{
		private quaternion q;
		// Start is called before the first frame update
		void Start()
		{
			SpawnEntity();
		}

		private void SpawnEntity()
		{
			EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

			EntityArchetype archetype = entityManager.CreateArchetype(
				typeof(Translation),
				typeof(Rotation)
			);


			Entity myEntity = entityManager.CreateEntity(archetype);

			entityManager.AddComponentData(myEntity, new Translation
			{
				Value = new float3(2f, 0f, 4f)
			});
		}
	}
}