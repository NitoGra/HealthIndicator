using TMPro;
using UnityEngine;

public class TextHealthBar : BaseHealth
{
	[SerializeField] private TextMeshProUGUI _healthBar;

	private void Start() => _healthBar.text = $"{Health.GetHealth}/{Health.GetMaxHealth}";

	protected override void ChangeBar() => _healthBar.text = $"{Health.GetHealth}/{Health.GetMaxHealth}";
}