using Unity.Entities;
using Unity.Mathematics;

namespace Part3
{
	[GenerateAuthoringComponent]
	public struct MoveData : IComponentData
	{
		public float3 direction;
		public float speed;
	}
}