using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour
{
	// �_�C�A���O��Panel���A�^�b�`
	public GameObject confirmDialog;

	// �Q�[���I���̃��N�G�X�g
	public void RequestQuit()
	{
		// �m�F�_�C�A���O��\��
		confirmDialog.SetActive(true);
	}

	// �Q�[�����I�����鏈��
	public void QuitGame()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
	}

	// �L�����Z������
	public void CancelQuit()
	{
		// �m�F�_�C�A���O���\��
		confirmDialog.SetActive(false);
	}
}
