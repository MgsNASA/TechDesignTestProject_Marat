using UnityEngine;
using UnityEngine.UI;

public class Activate_Button : MonoBehaviour
{
    public Button buttonToActivate; // ������� ������, ������� �� ������ ������������

    private void OnMouseDown( )
    {
        // ����������� ������
        buttonToActivate.gameObject.SetActive ( true );
    }
}
