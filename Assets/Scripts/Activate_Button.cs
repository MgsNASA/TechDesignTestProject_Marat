using UnityEngine;
using UnityEngine.UI;

public class Activate_Button : MonoBehaviour
{
    public Button buttonToActivate; // ”кажите кнопку, которую вы хотите активировать

    private void OnMouseDown( )
    {
        // јктивируйте кнопку
        buttonToActivate.gameObject.SetActive ( true );
    }
}
