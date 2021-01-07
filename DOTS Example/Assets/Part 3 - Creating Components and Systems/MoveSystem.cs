using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Part3
{
	public class MoveSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			var deltaTime = Time.DeltaTime;
			Entities.ForEach((ref Translation translation, in MoveData moveData) =>
			{
				float3 normalizedDirection = math.normalize(moveData.direction);
				translation.Value += normalizedDirection * moveData.speed * deltaTime;
			}).Run();
		}
	}
}