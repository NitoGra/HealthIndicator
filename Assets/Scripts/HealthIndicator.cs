using UnityEngine;

public class HealthIndicator : MonoBehaviour
{
	[SerializeField] protected Health Health;

	private void OnEnable()
	{
		Health.TakeHealing += ChangeBar;
		Health.Damaging += ChangeBar;
	}

	private void OnDisable()
	{
		Health.TakeHealing -= ChangeBar;
		Health.Damaging -= ChangeBar;
	}

	protected virtual void ChangeBar(){}
}