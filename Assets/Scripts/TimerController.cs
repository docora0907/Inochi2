using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //public float speed = 5f; // �v���C���[�̈ړ����x
    private float currentTime = 0f; // ���݂̃^�C��
    private bool isTiming = true; // �^�C�}�[�̃I��/�I�t
    public TextMeshProUGUI currentTimeText; // ���݂̃^�C���\���pUI
    public TextMeshProUGUI bestTimeText; // �x�X�g�^�C���\���pUI

    void Start()
    {
        DisplayBestTime(); // �x�X�g�^�C������ʂɕ\��
    }

    void Update()
    {
        // �^�C�}�[�̍X�V
        if (isTiming)
        {
            currentTime += Time.deltaTime;
            currentTimeText.text = "Time: " + currentTime.ToString("F2") + "s";
        }

        // �v���C���[�̈ړ�
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isTiming = false;
            SaveBestTime(); // �x�X�g�^�C����ۑ�
        }
    }

    // �x�X�g�^�C����\��
    private void DisplayBestTime()
    {
        if (PlayerPrefs.HasKey("BestTime"))
        {
            float bestTime = PlayerPrefs.GetFloat("BestTime");
            bestTimeText.text = "Best Time: " + bestTime.ToString("F2") + "s";
        }
        else
        {
            bestTimeText.text = "Best Time: --";
        }
    }

    // �x�X�g�^�C����ۑ�
    private void SaveBestTime()
    {
        if (!PlayerPrefs.HasKey("BestTime") || currentTime < PlayerPrefs.GetFloat("BestTime"))
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
            PlayerPrefs.Save();
            DisplayBestTime();
        }
    }

    // �x�X�g�^�C�������Z�b�g
    public void ResetBestTime()
    {
        PlayerPrefs.DeleteKey("BestTime");
        PlayerPrefs.Save();
        DisplayBestTime();
    }
}