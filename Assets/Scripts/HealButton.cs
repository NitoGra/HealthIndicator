using UnityEngine;

public class HealButton : BaseButton
{
	[SerializeField] private Health _health;
	[SerializeField] private int _heal;

	protected override void OnClick()
	{
		_health.Healing(_heal);
	}
}
