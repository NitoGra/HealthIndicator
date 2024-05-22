using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthIndicator
{
	[SerializeField] private Slider _healthBar;

	private void Start() => Invoke(nameof(ChangeBar), 0.1f);

	protected override void ChangeBar()
	{
		float health = Health.GetHealth;
		float maxHealth = Health.GetMaxHealth;
		_healthBar.value = (health / maxHealth);
	}
}