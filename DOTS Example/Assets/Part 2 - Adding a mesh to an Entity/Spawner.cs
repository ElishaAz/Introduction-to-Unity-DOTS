﻿using Part3;
using UnityEngine;
using Unity.Entities; // For ECS
using Unity.Mathematics; // For math in ECS
using Unity.Transforms; // For the equivalent of Transform in ECS
using Unity.Rendering; // For rendering in ECS

namespace Part2
{
	public class Spawner : MonoBehaviour
	{
		public Material mat;
		public Mesh mesh;

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
				typeof(Rotation),
				typeof(RenderMesh),
				typeof(RenderBounds),
				typeof(LocalToWorld)
			);


			Entity myEntity = entityManager.CreateEntity(archetype);

			var translation = new Translation();
			translation.Value = new float3(2f, 0f, 4f);

			entityManager.AddComponentData(myEntity, translation);

			var renderMesh = new RenderMesh();
			renderMesh.mesh = mesh;
			renderMesh.material = mat;

			entityManager.AddSharedComponentData(myEntity, renderMesh);
		}
	}
}