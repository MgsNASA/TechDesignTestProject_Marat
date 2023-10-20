using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Animator animator;


    private void Start( )
    {
        animator = GetComponent<Animator> ();

    }

    private void Update( )
    {
        // ��������� ���� ����� (��� ������������� �� ��������� �����������)
        if ( Input.GetMouseButtonDown ( 0 ) )
        {
            // ������� ��� (ray) �� ����� �����
            Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );
            RaycastHit2D hit = Physics2D.GetRayIntersection ( ray );

            // ���������, ������ �� �� �� ������� � �����������
            if ( hit.collider != null && hit.collider.gameObject == gameObject )
            {
             
                    animator.SetTrigger ( "PlayAnimation" ); // "PlayAnimation" - ��� �������� �������� 
                
            }
        }
    }
}
