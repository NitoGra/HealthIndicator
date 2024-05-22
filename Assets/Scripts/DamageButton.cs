using UnityEngine;

public class DamageButton : BaseButton
{
	[SerializeField] private Health _health;
	[SerializeField] private int _damage;

	protected override void OnClick()
	{
		_health.TakeDamage(_damage);
	}
}