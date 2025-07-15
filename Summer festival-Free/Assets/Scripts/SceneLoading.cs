using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
	[SerializeField] private GameObject _loadingUI;
	[SerializeField] private Slider _slider;
	[SerializeField] private AudioSource _audioSource; // ���ʉ���炷���߂�AudioSource
	[SerializeField] private AudioClip _buttonClickSound; // ���ʉ���AudioClip

	public void LoadNextScene()
	{
		// ���ʉ���炷
		_audioSource.PlayOneShot(_buttonClickSound);

		// ���[�f�B���OUI��\��
		_loadingUI.SetActive(true);

		// �V�[����񓯊��œǂݍ���
		StartCoroutine(LoadScene());
	}
	IEnumerator LoadScene()
	{
		// �V�[���̔񓯊����[�h���J�n
		AsyncOperation async = SceneManager.LoadSceneAsync("GameScene");

		// ���[�h�i�s�󋵂ɉ����ăX���C�_�[�̒l���X�V
		while (!async.isDone)
		{
			_slider.value = async.progress;
			yield return null;
		}
	}
}
