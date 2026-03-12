using UnityEngine;

public class agentmodel : MonoBehaviour
{

    [SerializeField] private AgentController _Controlls;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;

  public void Movimiento() {

        _rb.linearVelocity = new Vector3(_Controlls.movevalue.y, _rb.linearVelocity.y, _Controlls.movevalue.x);
    
    
    }
    private void Update()
    {
        Movimiento();
    }

}
