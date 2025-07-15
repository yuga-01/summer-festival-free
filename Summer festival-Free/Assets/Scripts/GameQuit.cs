using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour
{
	// ダイアログのPanelをアタッチ
	public GameObject confirmDialog;

	// ゲーム終了のリクエスト
	public void RequestQuit()
	{
		// 確認ダイアログを表示
		confirmDialog.SetActive(true);
	}

	// ゲームを終了する処理
	public void QuitGame()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
	}

	// キャンセル処理
	public void CancelQuit()
	{
		// 確認ダイアログを非表示
		confirmDialog.SetActive(false);
	}
}
