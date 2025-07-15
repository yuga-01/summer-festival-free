using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
	[SerializeField] private GameObject _loadingUI;
	[SerializeField] private Slider _slider;
	[SerializeField] private AudioSource _audioSource; // 効果音を鳴らすためのAudioSource
	[SerializeField] private AudioClip _buttonClickSound; // 効果音のAudioClip

	public void LoadNextScene()
	{
		// 効果音を鳴らす
		_audioSource.PlayOneShot(_buttonClickSound);

		// ローディングUIを表示
		_loadingUI.SetActive(true);

		// シーンを非同期で読み込む
		StartCoroutine(LoadScene());
	}
	IEnumerator LoadScene()
	{
		// シーンの非同期ロードを開始
		AsyncOperation async = SceneManager.LoadSceneAsync("GameScene");

		// ロード進行状況に応じてスライダーの値を更新
		while (!async.isDone)
		{
			_slider.value = async.progress;
			yield return null;
		}
	}
}
