using UnityEngine;

public class BaseButton : MonoBehaviour
{
	[SerializeField] private UnityEngine.UI.Button _button;

	private void OnEnable()
	{
		_button.onClick.AddListener(OnClick);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(OnClick);
	}

	protected virtual void OnClick(){ }
}